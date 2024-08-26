

using IntegralCalculation.Interfaces;

namespace IntegralCalculationTests.Interfaces
{
    /// <summary>
    /// Интерфейс для тестирования методов.
    /// </summary>
    public interface ITestable
    {
        /// <summary>
        /// Сообщения при исключениях.
        /// </summary>
        IMessageThrowable MessageThrowable { get; }

        /// <summary>
        /// IIntegralCalculator.
        /// </summary>
        IIntegralCalculator Calculator { get; }

        /// <summary>
        /// Проверка объекта IMessageThrowable на null.
        /// </summary>
        [Fact]
        void MessageServiceExist();

        /// <summary>
        /// Проверка объекта IIntegralCalculator на null.
        /// </summary>
        [Fact]
        void CalculatorExist();

        /// <summary>
        /// Тест по умолчанию. Обычный расчет.
        /// </summary>
        [Fact]
        void StandardTest();

        /// <summary>
        /// Тест при отсутствии переданной функции.
        /// </summary>
        [Fact]
        void NullFunctionTest();

        /// <summary>
        /// Тест ошибки диапазона интегрирования.
        /// </summary>
        [Fact]
        void LimitErrorTest();

        /// <summary>
        /// Тест ошибки шага интегрирования.
        /// </summary>
        [Fact]
        void StepErrorTest();

        /// <summary>
        /// Проверка сообщения из исключения при отсутствии функции.
        /// </summary>
        [Fact]
        void NullFunctionExceptionTest();

        /// <summary>
        /// Проверка сообщения из исключения при отсутствии передаче неправильного диапазона.
        /// </summary>
        [Fact]
        void LimitErrorExceptionTest();

        /// <summary>
        /// Проверка сообщения из исключения при отсутствии передаче неправильного шага интегрирования.
        /// </summary>
        [Fact]
        void StepErrorExceptionTest();
    }
}
