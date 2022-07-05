#include "Seg7.h"

void SEG7_Send(unsigned char data)
{
	unsigned char check, soBitDich = 0;
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_A(check);
	
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_B(check);
	
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_C(check);
	
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_D(check);
	
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_E(check);
	
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_F(check);
	
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_G(check);
	
	check = data & (0x01<<soBitDich++);
	check = check!=0?1:0;
	SEG_DP(check);
}

void SEG7_out(unsigned char dem)
{
	unsigned char Seg7[] = {0xC0, 0xF9, 0xA4, 0xB0, 0x99, 0x92, 0x82, 0xF8, 0x80, 0x90, 0xFF};
	unsigned char so_dem = Seg7[dem];
	
	SEG7_Send(so_dem);
	//COL_1(0);//xuat kieu muc thap
}