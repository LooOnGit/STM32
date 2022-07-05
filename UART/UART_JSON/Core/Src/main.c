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
#include "stdio.h"
#include <stdint.h>
#include <stdbool.h>
#include <string.h>
#include <stdlib.h>
#include "cJSON.h"
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
void SendData(unsigned int ND, unsigned int DA, unsigned int trangthaiden, unsigned int trangthaiquat, unsigned int C1, unsigned int C2);
void ChuongtrinhCB();
void Received(void);
void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart);
void clearBuffer(void);
void XuLyJSON(char *DataJSON);
void Button(void);
int i = 0;
unsigned int ND = 0;
unsigned int DA = 0;
unsigned int trangthaiden = 0;
unsigned int trangthaiquat = 0;
unsigned int C1 = 0;
unsigned int C2 = 0;

char Str_ND[100];
char Str_DA[100];
char Str_TB1[100];
char Str_TB2[100];
char Str_C1[100];
char Str_C2[100];
char JSON[100];
char rx_buffer[200];

uint8_t rx_data;
unsigned int Index = 0;
long last;

cJSON *str_json, *str_TB1, *str_TB2, *str_C1, *str_C2, *str_Mode;
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
	HAL_UART_Receive_IT(&huart1,&rx_data,1);
	last = HAL_GetTick();
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
		
		//SendData(ND, DA, trangthaiden,  trangthaiquat, C1, C2);
		//HAL_Delay(1000);
		Button();
		if(HAL_GetTick()-last>=1000)
		{
			ChuongtrinhCB();
			SendData(ND,DA,trangthaiden,trangthaiquat,C1,C2);
			last = HAL_GetTick();
		}
  }
  /* USER CODE END 3 */
}

void Button(void)
{
	if(HAL_GPIO_ReadPin(GPIOA,GPIO_PIN_4) == 0)
	{
		HAL_Delay(200);
		last = HAL_GetTick();
		if(HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_4) == 1)
		{
			if(trangthaiden == 0)
			{
				HAL_GPIO_WritePin(GPIOC, GPIO_PIN_13, GPIO_PIN_RESET);
				trangthaiden = 1;
			}
			else if( trangthaiden == 1)
			{
				HAL_GPIO_WritePin(GPIOC, GPIO_PIN_13,GPIO_PIN_SET);
				trangthaiden = 0;
			}
			HAL_Delay(200);
			last = HAL_GetTick();
		}
	}
	if(HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_5) == 0)
	{
		HAL_Delay(200);
		last = HAL_GetTick();
		if(HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_5) == 1)
		{
			if(trangthaiquat == 0)
			{
				HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_SET);
				trangthaiquat = 1;
			}
			else if(trangthaiquat == 1)
			{
				HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_RESET);
				trangthaiquat = 0;
			}
			HAL_Delay(200);
			last = HAL_GetTick();
		}
	}
}

void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart)
{
	if(huart->Instance == huart1.Instance)
	{
		//chuong trinh doc du lieu => mang data
		last = HAL_GetTick();
		Received();
		HAL_UART_Receive_IT(&huart1,&rx_data,1);
	}
	
}

void Received(void)
{
	//rx_buffer
	if(rx_data != '\n')
	{
		rx_buffer[Index++] = rx_data;
	}
	else
	{
		//xu ly hien cai gi day

		strcat(rx_buffer,"\n");
		int i =0;
		while(rx_buffer[i] != 0)
		{
			unsigned char Send=rx_buffer[i];
			HAL_UART_Transmit(&huart1,&Send, 1, 1);
			i++;
		}
		
		XuLyJSON(rx_buffer);
		clearBuffer();
	}
}

void XuLyJSON(char *DataJSON)
{
	str_json = cJSON_Parse(DataJSON);
	if(!str_json)
	{
		char *error = "JSON ERROR!\r\n";
		HAL_UART_Transmit(&huart1,(uint8_t *)error, strlen(error),1);
		return;
	}
	else
	{
		char *OK = "JSON OK!\r\n";
		HAL_UART_Transmit(&huart1,(uint8_t *)OK, strlen(OK),1);
		//("TB1":"1-0")
		if(cJSON_GetObjectItem(str_json, "TB1"))
		{
			if(strstr(cJSON_GetObjectItem(str_json, "TB1")->valuestring,"0") != NULL)
			{
				char *TT1 = "OFF LED 1\r\n";
		    HAL_UART_Transmit(&huart1,(uint8_t *)TT1, strlen(TT1),1);
				HAL_GPIO_WritePin(GPIOC, GPIO_PIN_13, GPIO_PIN_SET);
				trangthaiden = 0;
			}
			else if(strstr(cJSON_GetObjectItem(str_json,"TB1")->valuestring,"1")!=NULL)
			{
				char *TT1 = "ON LED 1\r\n";
		    HAL_UART_Transmit(&huart1,(uint8_t *)TT1, strlen(TT1),1);
				HAL_GPIO_WritePin(GPIOC, GPIO_PIN_13, GPIO_PIN_RESET);
				trangthaiden = 1;
			}
		}
		if(cJSON_GetObjectItem(str_json, "TB2"))
		{
			if(strstr(cJSON_GetObjectItem(str_json, "TB2")->valuestring,"0") != NULL)
			{
				char *TT2 = "OFF LED 2\r\n";
		    HAL_UART_Transmit(&huart1,(uint8_t *)TT2, strlen(TT2),1);
				HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_RESET);
				trangthaiquat = 0;
			}
			else if(strstr(cJSON_GetObjectItem(str_json,"TB2")->valuestring,"1")!=NULL)
			{
				char *TT2 = "ON LED 2\r\n";
		    HAL_UART_Transmit(&huart1,(uint8_t *)TT2, strlen(TT2),1);
				HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_SET);
				trangthaiquat = 1;
			}
		}
		if(cJSON_GetObjectItem(str_json, "C1"))
		{
			char *TD1 = cJSON_GetObjectItem(str_json,"C1")->valuestring;
			C1 = atoi(TD1);//atoi chuyen ve so nguyen
			strcat(TD1,"\n");
		  HAL_UART_Transmit(&huart1,(uint8_t *)TD1, strlen(TD1),1);
		}
		if(cJSON_GetObjectItem(str_json, "C2"))
		{
			char *TD2 = cJSON_GetObjectItem(str_json,"C2")->valuestring;
			C2 = atoi(TD2);
			strcat(TD2,"\n");
			HAL_UART_Transmit(&huart1,(uint8_t *)TD2, strlen(TD2),1);
		}
		cJSON_Delete(str_json);
	}
}

void clearBuffer(void)
{
	Index = 0;
	for(int i = 0; i < 200; i++)
	{
		rx_buffer[i] = 0;
	}
	last = HAL_GetTick();
}
void SendData(unsigned int ND, unsigned int DA, unsigned int trangthaiden, unsigned int trangthaiquat, unsigned int C1, unsigned int C2)
{
	
	//xoa mang du lieu
	for(int i = 0; i < 100; i++)
	{
		JSON[i] = 0;
		Str_ND[i] = 0;
		Str_DA[i] = 0;
		Str_C1[i] = 0;
		Str_C2[i] = 0;
		Str_TB1[i] = 0;
		Str_TB2[i] = 0;
	}
	//Truyen du lieu vao ve char
	sprintf(Str_ND, "%d", ND);
	sprintf(Str_DA, "%d", DA);
	sprintf(Str_TB1, "%d", trangthaiden);
	sprintf(Str_TB2, "%d", trangthaiquat);
	sprintf(Str_C1, "%d", C1);
	sprintf(Str_C2, "%d", C2);
	
	//{"ND":"123","DA":"456"}
	strcat(JSON,"{\"ND\":\"");
	strcat(JSON,Str_ND);
	strcat(JSON,"\",");
	
	strcat(JSON,"\"DA\":\"");
	strcat(JSON,Str_DA);
	strcat(JSON,"\",");
	
	strcat(JSON,"\"TB1\":\"");
	strcat(JSON,Str_TB1);
	strcat(JSON,"\",");
	
	strcat(JSON,"\"TB2\":\"");
	strcat(JSON,Str_TB2);
	strcat(JSON,"\",");
	
	strcat(JSON,"\"C1\":\"");
	strcat(JSON,Str_C1);
	strcat(JSON,"\",");
	
	strcat(JSON,"\"C2\":\"");
	strcat(JSON,Str_C2);
	
	strcat(JSON,"\"}");
	strcat(JSON,"\n");
	int i=0;
	
	while(JSON[i]!=0)
	{
		unsigned char Send=JSON[i];
		HAL_UART_Transmit(&huart1, &Send, 1, 1);
		i++;
	}
}

void ChuongtrinhCB(void)
{
	ND++;
	DA = DA + 2;
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
  sConfig.Channel = ADC_CHANNEL_1;
  sConfig.Rank = ADC_REGULAR_RANK_1;
  sConfig.SamplingTime = ADC_SAMPLETIME_1CYCLE_5;
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
  __HAL_RCC_GPIOC_CLK_ENABLE();
  __HAL_RCC_GPIOD_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOC, GPIO_PIN_13, GPIO_PIN_SET);

  /*Configure GPIO pin Output Level */
  HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, GPIO_PIN_RESET);

  /*Configure GPIO pin : PC13 */
  GPIO_InitStruct.Pin = GPIO_PIN_13;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOC, &GPIO_InitStruct);

  /*Configure GPIO pin : PA3 */
  GPIO_InitStruct.Pin = GPIO_PIN_3;
  GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
  GPIO_InitStruct.Pull = GPIO_NOPULL;
  GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_LOW;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

  /*Configure GPIO pins : PA4 PA5 */
  GPIO_InitStruct.Pin = GPIO_PIN_4|GPIO_PIN_5;
  GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
  GPIO_InitStruct.Pull = GPIO_PULLUP;
  HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

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
