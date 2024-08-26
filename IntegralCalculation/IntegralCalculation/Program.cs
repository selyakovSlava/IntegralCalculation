using IntegralCalculation.Classes;
using IntegralCalculation.Interfaces;
using Microsoft.Extensions.DependencyInjection;


var services = new ServiceCollection()
    .AddTransient<IMessageThrowable, ThrowMessages>()
    .AddTransient<SimpsonCalculation>()
    .AddTransient<TrapezoidCalculation>();

var serviceProvider = services.BuildServiceProvider();



Console.WriteLine("Тест расчетов интеграла численными методами\n");

/// Функция для интегрирования.
static double myFunction(double x)
{
    return 1 / (1 + Math.Pow(x, 2));
}


// Формула Симпсона.
IIntegralCalculator? calculator = serviceProvider.GetService<SimpsonCalculation>();
Console.WriteLine($"Расчет по формуле Симпсона: {await calculator?.CalculationAsync(null, 0, 1, 1000)}\n");

// Метод трапеций.
calculator = serviceProvider.GetService<TrapezoidCalculation>();
Console.WriteLine($"Расчет методом трапеций: {calculator?.Calculation(myFunction, 0, 1, 1000)}\n");


Console.WriteLine("Программа завершена");
Console.ReadLine();