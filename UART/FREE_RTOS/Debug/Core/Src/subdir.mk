################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Core/Src/freertos.c \
../Core/Src/main.c \
../Core/Src/stm32f1xx_hal_msp.c \
../Core/Src/stm32f1xx_it.c \
../Core/Src/syscalls.c \
../Core/Src/system_stm32f1xx.c 

OBJS += \
./Core/Src/freertos.o \
./Core/Src/main.o \
./Core/Src/stm32f1xx_hal_msp.o \
./Core/Src/stm32f1xx_it.o \
./Core/Src/syscalls.o \
./Core/Src/system_stm32f1xx.o 

C_DEPS += \
./Core/Src/freertos.d \
./Core/Src/main.d \
./Core/Src/stm32f1xx_hal_msp.d \
./Core/Src/stm32f1xx_it.d \
./Core/Src/syscalls.d \
./Core/Src/system_stm32f1xx.d 


# Each subdirectory must supply rules for building sources it contributes
Core/Src/%.o: ../Core/Src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m3 -mthumb -mfloat-abi=soft -DUSE_HAL_DRIVER -DSTM32F103xE -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Core/Inc" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/STM32F1xx_HAL_Driver/Inc/Legacy" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/STM32F1xx_HAL_Driver/Inc" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/include" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/portable/GCC/ARM_CM3" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/CMSIS/Device/ST/STM32F1xx/Include" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


