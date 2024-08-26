﻿using IntegralCalculation.Interfaces;

namespace IntegralCalculation.Classes
{
    public class TrapezoidCalculation : IIntegralCalculator
    {
        public IMessageThrowable ThrowMessages { get; }

        public TrapezoidCalculation(IMessageThrowable throwMessages)
        {
            ThrowMessages = throwMessages;
        }
        
        public double Calculation(Func<double, double> function, double start, double end, int steps)
        {
            double result = 0;
            double stepSize = (end - start) / steps; // Величина шага.

            try
            {
                if (function == null)
                {
                    throw new Exception("Функция интегрирования не определена!");
                }
                else if (start >= end)
                {
                    throw new Exception("Заданы неправильные параметры начала и конца отрезка интегрирования!");
                }
                else if (steps <= 0)
                {
                    throw new Exception("Заданы неправильное количество интервалов разбиения!");
                }
                else
                {
                    for (int i = 1; i < steps + 1; i++)
                    {
                        result += stepSize * (function.Invoke(start + (i - 1) * stepSize) + function.Invoke(start + i * stepSize)) / 2;
                    }
                }
            }
            catch (Exception ex)
            {
                ThrowMessages.ExceptionMessageColor(ex);
            }

            return result;
        }

        public async Task<double> CalculationAsync(Func<double, double> function, double start, double end, int steps)
        {
            double result = 0;
            double stepSize = (end - start) / steps; // Величина шага.

            await Task.Run(() =>
            {
                try
                {
                    if (function == null)
                    {
                        throw new Exception("Функция интегрирования не определена!");
                    }
                    else if (start >= end)
                    {
                        throw new Exception("Заданы неправильные параметры начала и конца отрезка интегрирования!");
                    }
                    else if (steps <= 0)
                    {
                        throw new Exception("Заданы неправильное количество интервалов разбиения!");
                    }
                    else
                    {
                        for (int i = 1; i < steps + 1; i++)
                        {
                            result += stepSize * (function.Invoke(start + (i - 1) * stepSize) + function.Invoke(start + i * stepSize)) / 2;
                        }
                    }
                }
                catch (Exception ex)
                {
                    ThrowMessages.ExceptionMessageColor(ex);
                }
            });

            return result;
        }
    }
}
