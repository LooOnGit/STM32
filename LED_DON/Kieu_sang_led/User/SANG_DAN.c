#include "SANG_DAN.h"

void Led(unsigned char name, unsigned char x){
	switch(name){
		case 0:
		{
			LED_0(x);
		  break;
		}
		case 1:
		{
			LED_1(x);
		  break;
		}
		case 2:
		{
			LED_2(x);
		  break;
	  }
		case 3:
		{
			LED_3(x);
		  break;
		}
		case 4:
		{
			LED_4(x);
		  break;
		}
	}
}

void Led_tat(void){
	unsigned char i;
	
	for(i = 0; i<5; i++){
		Led(i,0);
	}
}

void Sang_Dan(void){
	unsigned char i;
	Led_tat();
  for(i = 0; i < 5; i++){
	 Led(i,1);
	 HAL_Delay(500);
 }
}

void Sang_Duoi(void){
	unsigned char i, j;
	for(i = 0; i < 5; i++){
		Led(i,1);
	  HAL_Delay(500);
		Led_tat();
	}
}

void Sang_Don(void){
	unsigned char i, j, k;
	Led_tat();
	for(j = 4; j > 0; j--){
		for(i = 0; i < (5 - i); i++){
			Led(i,1);
			HAL_Delay(500);
			Led_tat();
			}
		switch(4-j){
			case 0:
				Led(4,1);
			  break;
			case 1:
				Led(4,1);
			  Led(3,1);
			  break;
			case 2:
				Led(4,1);
			  Led(3,1);
			  Led(2,1);
			  break; 
			case 3:
				Led(4,1);
			  Led(3,1);
			  Led(2,1);
			  Led(1,1);
			  break;
			case 4:
				Led(4,1);
			  Led(3,1);
			  Led(2,1);
			  Led(1,1);
			  Led(0,1);
			  break; 
		}
	}
}