using IntegralCalculation.Interfaces;
using IntegralCalculation.Classes;

namespace IntegralCalculationTests
{
    /// <summary>
    /// Тесты методов расчета интеграла в случае,
    /// если не пердана функция для расчета.
    /// </summary>
    public class NullFunctionTests
    {
        /// <summary>
        /// Тестирование функции расчета интеграла по формуле Симпсона.
        /// Тест на значение при исключении.
        /// </summary>
        [Fact]
        public void SimpsonCalculationTestOnNullFunction()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new SimpsonCalculation(messageThrowable);

            double testResult = 0;
            double factResult = Math.Round(calculator.Calculation(null, 0, 1, 1000), 3);
            Assert.Equal(testResult, factResult);
        }

        /// <summary>
        /// Тестирование функции расчета интеграла методом трапеций.
        /// Тест на значение при исключении.
        /// </summary>
        [Fact]
        public void TrapezoidCalculationTestOnNullFunction()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new TrapezoidCalculation(messageThrowable);

            double testResult = 0;
            double factResult = Math.Round(calculator.Calculation(null, 0, 1, 1000), 3);
            Assert.Equal(testResult, factResult);
        }

        /// <summary>
        /// Тестирование функции расчета интеграла методом трапеций.
        /// Тест на значение при исключении.
        /// </summary>
        [Fact]
        public void RectangleCalculationTestOnNullFunction()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new RectangleCalculation(messageThrowable);

            double testResult = 0;
            double factResult = Math.Round(calculator.Calculation(null, 0, 1, 1000), 3);
            Assert.Equal(testResult, factResult);
        }
    }
}
