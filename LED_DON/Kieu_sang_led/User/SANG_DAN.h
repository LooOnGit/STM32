#define SANG_DAN_H
#include "stm32f1xx_hal.h"

#define LED_0(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_0, x)
#define LED_1(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_1, x)
#define LED_2(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2, x)
#define LED_3(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, x)
#define LED_4(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_4, x)\

void Led(unsigned char name, unsigned char x);
void Led_tat(void);
void Led_bat(void);
void Sang_Dan(void);
void Sang_Duoi(void);
void Sang_Don(void);