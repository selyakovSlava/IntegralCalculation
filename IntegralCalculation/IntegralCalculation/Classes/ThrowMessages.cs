using IntegralCalculation.Interfaces;

namespace IntegralCalculation.Classes
{
    public class ThrowMessages : IMessageThrowable
    {

        public void ExceptionMessage(Exception exception)
        {
            Console.WriteLine($"Исключение: {exception.Message}");
            Console.WriteLine($"Метод: {exception.TargetSite}");
            Console.WriteLine($"Трассировка стека: {exception.StackTrace}");
        }

        public void ExceptionMessageColor(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Исключение: {exception.Message}");
            Console.WriteLine($"Метод: {exception.TargetSite}");
            Console.WriteLine($"Трассировка стека: {exception.StackTrace}");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
