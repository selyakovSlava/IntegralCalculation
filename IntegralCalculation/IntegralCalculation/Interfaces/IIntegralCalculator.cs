

namespace IntegralCalculation.Interfaces
{
    /// <summary>
    /// Интерфейс для численного расчета интегралов.
    /// </summary>
    public interface IIntegralCalculator
    {
        /// <summary>
        /// Сервис сообщений.
        /// </summary>
        IMessageThrowable ThrowMessages { get; }

        /// <summary>
        /// Функция расчета интеграла (синхронно).
        /// </summary>
        /// <param name="function">Делегат функции для рассчета.</param>
        /// <param name="start">Начало отрезка.</param>
        /// <param name="end">Конец отрезка.</param>
        /// <param name="steps">Кол-во шагов (число интервалов разбиения).</param>
        /// <returns>Значение переданного интеграла.</returns>
        double Calculation(Func<double, double> function, double start, double end, int steps);

        /// <summary>
        /// Функция расчета интеграла (асинхронно).
        /// </summary>
        /// <param name="function">Делегат функции для рассчета.</param>
        /// <param name="start">Начало отрезка.</param>
        /// <param name="end">Конец отрезка.</param>
        /// <param name="steps">Кол-во шагов (число интервалов разбиения).</param>
        /// <returns>Значение переданного интеграла.</returns>
        Task<double> CalculationAsync(Func<double, double> function, double start, double end, int steps);
    }
}
