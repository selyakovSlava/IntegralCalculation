using IntegralCalculation.Classes;
using IntegralCalculation.Interfaces;
using IntegralCalculationTests.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralCalculationTests.Tests
{
    public class TrapezoidCalculationTests : ITestable
    {
        /// <summary>
        /// Точность округления.
        /// </summary>
        private readonly int _roundingAccuracy = 3;

        public IMessageThrowable MessageThrowable { get; }

        public IIntegralCalculator Calculator { get; }

        public TrapezoidCalculationTests()
        {
            MessageThrowable = new ThrowMessages();
            Calculator = new TrapezoidCalculation(MessageThrowable);
        }

        [Fact]
        public void MessageServiceExist()
        {
            Assert.NotNull(MessageThrowable);
        }

        [Fact]
        public void CalculatorExist()
        {
            Assert.NotNull(Calculator);
        }


        [Fact]
        public void StandardTest()
        {
            double testResult = Math.Round(0.7853981217307819, _roundingAccuracy);
            double factResult = Math.Round(Calculator.Calculation(TestFunctions.TestFunction, 0, 1, 1000), _roundingAccuracy);
            Assert.Equal(testResult, factResult);
        }

        [Fact]
        public void NullFunctionTest()
        {
            double testResult = 0;
            double factResult = Calculator.Calculation(null, 0, 1, 1000);
            Assert.Equal(testResult, factResult);
        }

        [Fact]
        public void LimitErrorTest()
        {
            double testResult = 0;
            double factResult = Calculator.Calculation(TestFunctions.TestFunction, 1, -1, 1000);
            Assert.Equal(testResult, factResult);
        }

        [Fact]
        public void StepErrorTest()
        {
            double testResult = 0;
            double factResult = Calculator.Calculation(TestFunctions.TestFunction, 0, 1, 0);
            Assert.Equal(testResult, factResult);
        }

        [Fact]
        public void NullFunctionExceptionTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            Calculator.Calculation(null, 0, 1, 1000);

            Assert.Contains("Функция интегрирования не определена!", output.ToString());
        }

        [Fact]
        public void LimitErrorExceptionTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            Calculator.Calculation(TestFunctions.TestFunction, 1, 0, 1000);

            Assert.Contains("Заданы неправильные параметры начала и конца отрезка интегрирования!", output.ToString());
        }

        [Fact]
        public void StepErrorExceptionTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            Calculator.Calculation(TestFunctions.TestFunction, 0, 1, 0);

            Assert.Contains("Заданы неправильное количество интервалов разбиения!", output.ToString());
        }
    }
}
