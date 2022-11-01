################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Middlewares/Third_Party/FreeRTOS/Source/croutine.c \
../Middlewares/Third_Party/FreeRTOS/Source/event_groups.c \
../Middlewares/Third_Party/FreeRTOS/Source/list.c \
../Middlewares/Third_Party/FreeRTOS/Source/queue.c \
../Middlewares/Third_Party/FreeRTOS/Source/stream_buffer.c \
../Middlewares/Third_Party/FreeRTOS/Source/tasks.c \
../Middlewares/Third_Party/FreeRTOS/Source/timers.c 

OBJS += \
./Middlewares/Third_Party/FreeRTOS/Source/croutine.o \
./Middlewares/Third_Party/FreeRTOS/Source/event_groups.o \
./Middlewares/Third_Party/FreeRTOS/Source/list.o \
./Middlewares/Third_Party/FreeRTOS/Source/queue.o \
./Middlewares/Third_Party/FreeRTOS/Source/stream_buffer.o \
./Middlewares/Third_Party/FreeRTOS/Source/tasks.o \
./Middlewares/Third_Party/FreeRTOS/Source/timers.o 

C_DEPS += \
./Middlewares/Third_Party/FreeRTOS/Source/croutine.d \
./Middlewares/Third_Party/FreeRTOS/Source/event_groups.d \
./Middlewares/Third_Party/FreeRTOS/Source/list.d \
./Middlewares/Third_Party/FreeRTOS/Source/queue.d \
./Middlewares/Third_Party/FreeRTOS/Source/stream_buffer.d \
./Middlewares/Third_Party/FreeRTOS/Source/tasks.d \
./Middlewares/Third_Party/FreeRTOS/Source/timers.d 


# Each subdirectory must supply rules for building sources it contributes
Middlewares/Third_Party/FreeRTOS/Source/%.o: ../Middlewares/Third_Party/FreeRTOS/Source/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: MCU GCC Compiler'
	@echo $(PWD)
	arm-none-eabi-gcc -mcpu=cortex-m3 -mthumb -mfloat-abi=soft -DUSE_HAL_DRIVER -DSTM32F103xE -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Core/Inc" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/STM32F1xx_HAL_Driver/Inc/Legacy" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/STM32F1xx_HAL_Driver/Inc" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/include" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/CMSIS_RTOS" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Middlewares/Third_Party/FreeRTOS/Source/portable/GCC/ARM_CM3" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/CMSIS/Device/ST/STM32F1xx/Include" -I"D:/3.Nam_ba_2022-2023/1.Hoc_ky_1/Vi_dieu_khien/Bai_tap/Buoi_thu_10/FREE_RTOS/Drivers/CMSIS/Include"  -Og -g3 -Wall -fmessage-length=0 -ffunction-sections -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


