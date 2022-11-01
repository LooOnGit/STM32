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
ADC_HandleTypeDef hadc1;

UART_HandleTypeDef huart1;

/* USER CODE BEGIN PV */
uint8_t i;
uint8_t step1  = 0, 
step2 = 0, 
step3 = 0, 
step4 = 0,
step5 = 0,
step6 = 0,
step7 = 0,
step8 = 0,
step9 = 0,
step10 = 0;
uint8_t data_receive[1];
uint8_t flag = 0;
uint32_t adc_value;
float v;
/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_ADC1_Init(void);
static void MX_USART1_UART_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
void write_to_lcd_8bit(uint8_t rs, uint8_t data)
{
	 HAL_GPIO_WritePin(RS_GPIO_Port,RS_Pin,rs);
	 HAL_GPIO_WritePin(RW_GPIO_Port,RW_Pin,0);
	 HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,1);
	 
	 HAL_GPIO_WritePin(D7_GPIO_Port,D7_Pin,  ((data>>7)&0x01));
	 HAL_GPIO_WritePin(D6_GPIO_Port,D6_Pin,  ((data>>6)&0x01));
	 HAL_GPIO_WritePin(D5_GPIO_Port,D5_Pin,  ((data>>5)&0x01));
	 HAL_GPIO_WritePin(D4_GPIO_Port,D4_Pin,  ((data>>4)&0x01));
	 HAL_GPIO_WritePin(D3_GPIO_Port,D3_Pin,  ((data>>3)&0x01));
	 HAL_GPIO_WritePin(D2_GPIO_Port,D2_Pin,  ((data>>2)&0x01));
	 HAL_GPIO_WritePin(D1_GPIO_Port,D1_Pin,  ((data>>1)&0x01));
	 HAL_GPIO_WritePin(D0_GPIO_Port,D0_Pin,  ((data>>0)&0x01));
	 for(i=0;i<48;i++)
	 {
			__asm("NOP");
	 }
	 HAL_GPIO_WritePin(EN_GPIO_Port,EN_Pin,0);
	 HAL_Delay(1);
}

void lcd_send_command(uint8_t data)
{
	  write_to_lcd_8bit(0, (data>>0));
	  HAL_Delay(2);
}

void lcd_send_data(uint8_t data)
{
	  write_to_lcd_8bit(1, (data>>0));
	  HAL_Delay(2);
}

void lcd_init(void)
{
	  HAL_Delay(20);
	  write_to_lcd_8bit(0,0x30);
	  HAL_Delay(5);

	  lcd_send_command(0x38);
	  lcd_send_command(0x0C);
	  lcd_send_command(0x01);
	  lcd_send_command(0x06);
}

void display_text(char *data)
{
	  uint8_t j;
	  for (j=0;j<strlen(data);j++)
	  	lcd_send_data(data[j]);
}

void set_cursor( uint8_t row,uint8_t col)
{
	  uint8_t temp;
	  switch(row)
	  {
			case 0: temp=col |0x80;
	  	break;
	  	case 1: temp=col |0xC0;
	  	break;
	  	default : temp=col |0x80;
	  }
	  lcd_send_command(temp);
}

void lcd_Reset()
{
	HAL_Delay(100);
	set_cursor(0,0);
	display_text("Status_1");
	HAL_UART_Transmit(&huart1,"Start", 5, 10);
}

void lcd_A()
{
	HAL_Delay(100);
	set_cursor(0,0);
	display_text("Status_2");
	HAL_UART_Transmit(&huart1,"02", 2, 10);
}

void lcd_ADC2()
{
	HAL_Delay(100);
	set_cursor(0,0);
	display_text("Status_3");
	HAL_UART_Transmit(&huart1,"03", 2, 10);
}

void lcd_B()
{
	HAL_Delay(100);
	set_cursor(0,0);
	display_text("Status_4");
	HAL_UART_Transmit(&huart1,"04", 2, 10);
}

void lcd_ADC1()
{
	HAL_Delay(100);
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
  MX_ADC1_Init();
  MX_USART1_UART_Init();
  /* USER CODE BEGIN 2 */
	lcd_init();
	HAL_UART_Receive_IT(&huart1,&data_receive[0],1);
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
		//step1
		if(step1 == 0)
		{
			lcd_Reset();
			step1 = 1;
		}
		//step2
		if((step1 == 1) && (step2 == 0))
		{
			if((data_receive[0] == 'A') && (flag == 1))
			{
				step2 = 1;
				flag = 0;
			}
		}
		if((step2 == 1) && (step3 == 0))
		{
			lcd_A();
			step3 = 1;
			step2 = 0;
		}
		//step3
		if((step3 == 1) && (step4 == 0)) 
		{
			HAL_ADC_Start(&hadc1);
			HAL_ADC_PollForConversion(&hadc1, 10);
			adc_value = HAL_ADC_GetValue(&hadc1);
			v = adc_value*3.3/4095;
			if(v >= 2)
			{
				step4 = 1;
			}
		}
		if((step4 == 1) && (step5 == 0))
		{
			lcd_ADC2();
			step5 = 1;
			step4 = 0;
		}
		//step4
		if((step5==1) && (step6 == 0))
		{
			if((data_receive[0] == 'B') && (flag == 1))
			{
				step6 = 1;
				flag = 0;
			}
			if((data_receive[0] == 'D') && (flag == 1))
			{
				step8 = 1;
				flag = 0;
			}
		}
		if((step6 == 1)&&(step7 == 0))
		{
			lcd_B();
			step7 = 1;
		}
		
		//step5
		if((step7==1) && (step8 == 0))
		{
			HAL_ADC_Start(&hadc1);
			HAL_ADC_PollForConversion(&hadc1, 10);
			adc_value = HAL_ADC_GetValue(&hadc1);
			v = adc_value*3.3/4095;
			if(v > 1)
			{
				step8 = 1;
			}
		}
		if((step8 == 1) && (step9 == 0))
		{
			lcd_ADC1();
			step8 = 0;
			step9 = 1;
		}
		//step6
		if((step9 == 1)&&(step10 == 0))
		{
			HAL_ADC_Start(&hadc1);
			HAL_ADC_PollForConversion(&hadc1, 10);
			adc_value = HAL_ADC_GetValue(&hadc1);
			v = adc_value*3.3/4095;
			if(v < 1)
			{
				step1 = 0, step2 = 0, step3 = 0, step4 = 0,
				step5 = 0, step6 = 0, step7 = 0, step8 = 0,
				step9 = 0;
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
  RCC_PeriphCLKInitTypeDef PeriphClkInit = {0};

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
  PeriphClkInit.PeriphClockSelection = RCC_PERIPHCLK_ADC;
  PeriphClkInit.AdcClockSelection = RCC_ADCPCLK2_DIV6;
  if (HAL_RCCEx_PeriphCLKConfig(&PeriphClkInit) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief ADC1 Initialization Function
  * @param None
  * @retval None
  */
static void MX_ADC1_Init(void)
{

  /* USER CODE BEGIN ADC1_Init 0 */

  /* USER CODE END ADC1_Init 0 */

  ADC_ChannelConfTypeDef sConfig = {0};

  /* USER CODE BEGIN ADC1_Init 1 */

  /* USER CODE END ADC1_Init 1 */

  /** Common config
  */
  hadc1.Instance = ADC1;
  hadc1.Init.ScanConvMode = ADC_SCAN_DISABLE;
  hadc1.Init.ContinuousConvMode = DISABLE;
  hadc1.Init.DiscontinuousConvMode = DISABLE;
  hadc1.Init.ExternalTrigConv = ADC_SOFTWARE_START;
  hadc1.Init.DataAlign = ADC_DATAALIGN_RIGHT;
  hadc1.Init.NbrOfConversion = 1;
  if (HAL_ADC_Init(&hadc1) != HAL_OK)
  {
    Error_Handler();
  }

  /** Configure Regular Channel
  */
  sConfig.Channel = ADC_CHANNEL_0;
  sConfig.Rank = ADC_REGULAR_RANK_1;
  sConfig.SamplingTime = ADC_SAMPLETIME_239CYCLES_5;
  if (HAL_ADC_ConfigChannel(&hadc1, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN ADC1_Init 2 */

  /* USER CODE END ADC1_Init 2 */

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
  huart1.Init.BaudRate = 115200;
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
  HAL_GPIO_WritePin(GPIOA, D7_Pin|D6_Pin|D5_Pin|D3_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOB, D4_Pin|EN_Pin|RS_Pin|RW_Pin
                          |D0_Pin|D1_Pin|D2_Pin, GPIO_PIN_RESET);

  /*Configure GPIO pins : D7_Pin D6_Pin D5_Pin D3_Pin */
  GPIO_InitStruct.Pin = D7_Pin|D6_Pin|D5_Pin|D3_Pin;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : D4_Pin EN_Pin RS_Pin RW_Pin
                           D0_Pin D1_Pin D2_Pin */
  GPIO_InitStruct.Pin = D4_Pin|EN_Pin|RS_Pin|RW_Pin
                          |D0_Pin|D1_Pin|D2_Pin;
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
