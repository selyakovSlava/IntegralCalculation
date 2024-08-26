
namespace IntegralCalculation.Interfaces
{
    /// <summary>
    /// Интерфейс для сообщений в исключениях.
    /// </summary>
    public interface IMessageThrowable
    {
        /// <summary>
        /// Вывести тест исключения в стандартном виде.
        /// </summary>
        /// <param name="exception">Исключение.</param>
        void ExceptionMessage(Exception exception);

        /// <summary>
        /// Вывести тест исключения с цветом.
        /// </summary>
        /// <param name="exception">Исключение.</param>
        void ExceptionMessageColor(Exception exception);
    }
}
