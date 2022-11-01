/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2022 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "string.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
UART_HandleTypeDef huart1;

/* USER CODE BEGIN PV */
uint8_t OK[2] = {"OK"};
uint8_t Er0[8] = {"ERROR 41"};
uint8_t Er1[8] = {"ERROR 42"};
uint8_t Er2[8] = {"ERROR 43"};
uint8_t Er3[8] = {"ERROR 44"};
uint8_t Er4[8] = {"ERROR 45"};
uint8_t Er5[8] = {"ERROR 46"};
uint8_t ptu = 0;
uint8_t data_receive[1];
uint8_t data_copy[16];
uint8_t flag = 0;
uint8_t check_xor;
void lcd_busy(void);
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_USART1_UART_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
void write_to_lcd_4bits(uint8_t rs, uint8_t data)
{
	HAL_GPIO_WritePin(RS_GPIO_Port, RS_Pin, rs);
	HAL_GPIO_WritePin(RW_GPIO_Port, RW_Pin, 0);
	HAL_GPIO_WritePin(EN_GPIO_Port, EN_Pin, 1);
	
	HAL_GPIO_WritePin(D7_GPIO_Port, D7_Pin, ((data>>3)&0x01));
	HAL_GPIO_WritePin(D6_GPIO_Port, D6_Pin, ((data>>2)&0x01));
	HAL_GPIO_WritePin(D5_GPIO_Port, D5_Pin, ((data>>1)&0x01));
	HAL_GPIO_WritePin(D4_GPIO_Port, D4_Pin, ((data>>0)&0x01));
	
	for(int i = 0; i < 72; i++)
	{
		__asm("NOP");
	}
	
	HAL_GPIO_WritePin(EN_GPIO_Port, EN_Pin, 0);
	lcd_busy();
}

void send_command(uint8_t data)
{
	write_to_lcd_4bits(0, (data>>4)&0x0f);
	write_to_lcd_4bits (0, (data>>0)&0x0f);
}

void display_lcd(uint8_t data)
{
	write_to_lcd_4bits(1, (data>>4)&0x0f);
	write_to_lcd_4bits (1, (data>>0)&0x0f);
}

void display_text(char *data)
{
	uint8_t j;
	for(j=0; j<strlen(data); j++)
	{
		display_lcd(data[j]);
	}
}

void  lcd_clear()
{
	send_command(0x01);
	lcd_busy();
}

void set_cursor(uint8_t row, uint8_t col)
{
	uint8_t temp;
	switch(row)
	{
		case 0:
			temp = col|0x80;
		  break;
		case 1:
			temp = col|0xC0;
		  break;
		default:
			temp = col|0x80;
	}
	send_command(temp);
}

void lcd_config()
{
	send_command(0x28); //LCD 4bit, 2-line, 5x8 hieu 2
	lcd_busy();
	send_command(0x28); //LCD 4bit, 2-line, 5x8 hieu 8
	lcd_busy();
	send_command(0x0f);
	lcd_busy();
	send_command(0x06);
	lcd_busy();
	send_command(0x01);
	lcd_busy();
}

void lcd_busy(void)
{
	uint8_t busy_flag_copy;
	GPIO_InitTypeDef GPIO_InitStruct = {0};
	GPIO_InitStruct.Pin = GPIO_PIN_5;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
	
	HAL_GPIO_WritePin(RS_GPIO_Port, RS_Pin, 0);
	HAL_GPIO_WritePin(RW_GPIO_Port, RW_Pin, 1);
	do{
		busy_flag_copy = 0;
		HAL_GPIO_WritePin(EN_GPIO_Port, EN_Pin, 1);
		for(int i = 0; i < 72; i++);
		
		busy_flag_copy = HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_5);
		
		HAL_GPIO_WritePin(EN_GPIO_Port, EN_Pin, 0);
		for(int i = 0; i < 72; i++);
		
		HAL_GPIO_WritePin(EN_GPIO_Port, EN_Pin, 1);
		for(int i = 0; i < 72; i++);
		
		HAL_GPIO_WritePin(EN_GPIO_Port, EN_Pin, 0);
		for(int i = 0; i < 72; i++);
	}while(busy_flag_copy);
	HAL_GPIO_WritePin(RW_GPIO_Port, RW_Pin, 0);
	GPIO_InitStruct.Pin = GPIO_PIN_5;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);
}

void lcd_Reset()
{
	set_cursor(0,0);
	display_text("Status_1");
	HAL_UART_Transmit(&huart1,"Start", 5, 10);
}

void lcd_A()
{
	set_cursor(0,0);
	display_text("Status_2");
	HAL_UART_Transmit(&huart1,"02", 2, 10);
	flag = 0;
}

void lcd_ADC2()
{
	set_cursor(0,0);
	display_text("Status_3");
	HAL_UART_Transmit(&huart1,"03", 2, 10);
}

void lcd_B()
{
	set_cursor(0,0);
	display_text("Status_4");
	HAL_UART_Transmit(&huart1,"04", 2, 10);
	flag = 0;
}

void lcd_ADC1()
{
	set_cursor(0,0);
	display_text("Status_5");
	HAL_UART_Transmit(&huart1,"05", 2, 10);
}
/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */
	
  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_USART1_UART_Init();
  /* USER CODE BEGIN 2 */
	HAL_UART_Receive_IT(&huart1, &data_receive[0], 1);
	lcd_config();
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
		if(flag == 1)
		{
			if(data_copy[0] == 'A')
			{
				lcd_A();
				while(1)
				{
					HAL_ADC_Start(&hadc1);
					HAL_ADC_PollForConversion(&hadc1, 10);
					adc_value = HAL_ADC_GetValue(&hadc1);
					v = adc_value*3.3/4096;
					if(v >= 2)
					{
						lcd_ADC2();
					}
				}
			}
		}
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.HSEPredivValue = RCC_HSE_PREDIV_DIV1;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL9;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }

  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief USART1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_USART1_UART_Init(void)
{

  /* USER CODE BEGIN USART1_Init 0 */

  /* USER CODE END USART1_Init 0 */

  /* USER CODE BEGIN USART1_Init 1 */

  /* USER CODE END USART1_Init 1 */
  huart1.Instance = USART1;
  huart1.Init.BaudRate = 57600;
  huart1.Init.WordLength = UART_WORDLENGTH_8B;
  huart1.Init.StopBits = UART_STOPBITS_1;
  huart1.Init.Parity = UART_PARITY_NONE;
  huart1.Init.Mode = UART_MODE_TX_RX;
  huart1.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart1.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart1) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN USART1_Init 2 */

  /* USER CODE END USART1_Init 2 */

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{
  GPIO_InitTypeDef GPIO_InitStruct = {0};

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOB_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, D7_Pin|D6_Pin|D5_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, D4_Pin|EN_Pin|RS_Pin|RW_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pins : D7_Pin D6_Pin D5_Pin */
  GPIO_InitStruct.Pin = D7_Pin|D6_Pin|D5_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : D4_Pin EN_Pin RS_Pin RW_Pin */
  GPIO_InitStruct.Pin = D4_Pin|EN_Pin|RS_Pin|RW_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOB, &GPIO_InitStruct);

}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */
