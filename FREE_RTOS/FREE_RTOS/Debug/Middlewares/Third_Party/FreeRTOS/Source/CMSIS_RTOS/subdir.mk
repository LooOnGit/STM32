################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS/cmsis_os.c 

OBJS += \
./Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS/cmsis_os.o 

C_DEPS += \
./Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS/cmsis_os.d 


# Each subdirectory must supply rules for building sources it contributes
Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS/%.o: ../Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m3 -mthumb -mfloat-abi=soft -DUSE_HAL_DRIVER -DSTM32F103xE -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Core/Inc" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/STM32F1xx_HAL_Driver/Inc/Legacy" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/STM32F1xx_HAL_Driver/Inc" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/include" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/portable/GCC/ARM_CM3" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/CMSIS/Device/ST/STM32F1xx/Include" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


