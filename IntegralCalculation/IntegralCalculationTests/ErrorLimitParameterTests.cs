using IntegralCalculation.Classes;
using IntegralCalculation.Interfaces;

namespace IntegralCalculationTests
{
    /// <summary>
    /// Тесты методов расчета интеграла в случае,
    /// если переданы ошибочные параметры начала и окончания интегрирования.
    /// </summary>
    public class ErrorLimitParameterTests
    {
        /// <summary>
        /// Тестирование функции расчета интеграла по формуле Симпсона.
        /// Ошибка в диапазоне интегрирования.
        /// </summary>
        [Fact]
        public void TestSimpsonCalculationLimitError()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new SimpsonCalculation(messageThrowable);

            double testResult = 0;
            double factResult = calculator.Calculation(TestFunctions.MyFunction, 1, -1, 1000);
            Assert.Equal(testResult, factResult);
        }

        /// <summary>
        /// Тестирование функции расчета интеграла по формуле Симпсона.
        /// Ошибка в шаге интегрирования.
        /// </summary>
        [Fact]
        public void TestSimpsonCalculationStepError()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new SimpsonCalculation(messageThrowable);

            double testResult = 0;
            double factResult = calculator.Calculation(TestFunctions.MyFunction, 0, 1, 0);
            Assert.Equal(testResult, factResult);
        }

        /// <summary>
        /// Тестирование функции расчета интеграла методом трапеций.
        /// Ошибка в диапазоне интегрирования.
        /// </summary>
        [Fact]
        public void TestTrapezoidCalculationLimitError()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new TrapezoidCalculation(messageThrowable);

            double testResult = 0;
            double factResult = calculator.Calculation(TestFunctions.MyFunction, 1, 0, 100);
            Assert.Equal(testResult, factResult);
        }
        /// <summary>
        /// Тестирование функции расчета интеграла методом трапеций.
        /// Ошибка в шаге интегрирования.
        /// </summary>
        [Fact]
        public void TestTrapezoidCalculationStepError()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new TrapezoidCalculation(messageThrowable);

            double testResult = 0;
            double factResult = calculator.Calculation(TestFunctions.MyFunction, 0, 1, 0);
            Assert.Equal(testResult, factResult);
        }

        /// <summary>
        /// Тестирование функции расчета интеграла методом трапеций.
        /// Ошибка в диапазоне интегрирования.
        /// </summary>
        [Fact]
        public void TestRectangleCalculationLimitError()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new RectangleCalculation(messageThrowable);

            double testResult = 0;
            double factResult = calculator.Calculation(TestFunctions.MyFunction, 1, 0, 100);
            Assert.Equal(testResult, factResult);
        }
        /// <summary>
        /// Тестирование функции расчета интеграла методом трапеций.
        /// Ошибка в шаге интегрирования.
        /// </summary>
        [Fact]
        public void TestRectangleCalculationStepError()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new RectangleCalculation(messageThrowable);

            double testResult = 0;
            double factResult = calculator.Calculation(TestFunctions.MyFunction, 0, 1, 0);
            Assert.Equal(testResult, factResult);
        }
    }
}
