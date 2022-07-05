#define SEG7_H

#include "stm32f1xx_hal.h"

#define SEG_A(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_0, x)
#define SEG_B(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_1, x)
#define SEG_C(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_2, x)
#define SEG_D(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_3, x)
#define SEG_E(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_4, x)
#define SEG_F(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_5, x)
#define SEG_G(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_6, x)
#define SEG_DP(x) HAL_GPIO_WritePin(GPIOA, GPIO_PIN_7, x)

#define COL_1(x) HAL_GPIO_WritePin(GPIOB, GPIO_PIN_0, x);

void SEG7_out(unsigned char dem);
void SEG7_Send(unsigned char data);