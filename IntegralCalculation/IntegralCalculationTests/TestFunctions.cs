

namespace IntegralCalculationTests
{
    /// <summary>
    /// Функции для тестирования.
    /// </summary>
    public class TestFunctions
    {
        /// <summary>
        /// Функция для тестирования интегралов.
        /// </summary>
        /// <param name="x">Значение точке X.</param>
        /// <returns>Значение функции в точке X.</returns>
        public static double TestFunction(double x)
        {
            return 1 / (1 + Math.Pow(x, 2));
        }
    }
}
