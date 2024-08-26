
namespace IntegralCalculationTests
{
    /// <summary>
    /// Класс с функциями для тестирования.
    /// </summary>
    public class TestFunctions
    {
        /// <summary>
        /// Функция для интегрирования.
        /// </summary>
        /// <param name="x">Значение точки X.</param>
        /// <returns>Значение функции в точке X.</returns>
        public static double MyFunction(double x)
        {
            return 1 / (1 + Math.Pow(x, 2));
        }
    }
}
