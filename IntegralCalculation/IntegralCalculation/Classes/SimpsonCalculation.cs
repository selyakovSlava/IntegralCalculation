using IntegralCalculation.Interfaces;


namespace IntegralCalculation.Classes
{
    /// <summary>
    /// Рассчет интеграла по формуле Симпсона (метод парабол).
    /// </summary>
    public class SimpsonCalculation : IIntegralCalculator
    {
        public IMessageThrowable ThrowMessages { get; }

        public SimpsonCalculation(IMessageThrowable throwMessages)
        {
            ThrowMessages = throwMessages;
        }

        public double Calculation(Func<double, double> function, double start, double end, int steps)
        {
            double result = 0;
            double stepSize = (end - start) / steps; // Величина шага.
            double sumEven = 0; // Сумма значений функции на четных шагах.
            double sumOdd = 0; // Сумма значений функции на нечетных шагах.
            double sumStart = 0; // Значение функции в начале отрезка.
            double sumEnd = 0; // Значение функции в конце отрезка.
            double currentValue = start;

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
                    sumStart = function.Invoke(start);
                    sumEnd = function.Invoke(end);

                    for (int i = 1; i < steps; i++)
                    {
                        currentValue += stepSize;

                        if (i % 2 == 0)
                        {
                            sumEven += function.Invoke(currentValue);
                        }
                        else
                        {
                            sumOdd += function.Invoke(currentValue);
                        }
                    }

                    result = (stepSize / 3) * (sumStart + (2 * sumOdd) + (4 * sumEven) + sumEnd);
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
            double sumEven = 0; // Сумма значений функции на четных шагах.
            double sumOdd = 0; // Сумма значений функции на нечетных шагах.
            double sumStart = 0; // Значение функции в начале отрезка.
            double sumEnd = 0; // Значение функции в конце отрезка.
            double currentValue = start;

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
                        sumStart = function.Invoke(start);
                        sumEnd = function.Invoke(end);

                        for (int i = 1; i < steps; i++)
                        {
                            currentValue += stepSize;

                            if (i % 2 == 0)
                            {
                                sumEven += function.Invoke(currentValue);
                            }
                            else
                            {
                                sumOdd += function.Invoke(currentValue);
                            }
                        }

                        result = (stepSize / 3) * (sumStart + (2 * sumOdd) + (4 * sumEven) + sumEnd);
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
