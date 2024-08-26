using IntegralCalculation.Interfaces;
using IntegralCalculation.Classes;

namespace IntegralCalculationTests
{
    /// <summary>
    /// ������������ ������� ������� �� �������� �� ���������.
    /// </summary>
    public class FunctionTests
    {
        /// <summary>
        /// ������������ ������� ������� ��������� �� ������� ��������.
        /// ����������� ����.
        /// </summary>
        [Fact]
        public void StandardTestSimpsonCalculation()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new SimpsonCalculation(messageThrowable);

            /*
             * 
             * 0,7848980800641157
             * */
            double testResult = 0.785;
            double factResult = Math.Round(calculator.Calculation(TestFunctions.MyFunction, 0, 1, 1000), 3);
            Assert.Equal(testResult, factResult);
        }

        /// <summary>
        /// ������������ ������� ������� ��������� ������� ��������.
        /// ����������� ����.
        /// </summary>
        [Fact]
        public void StandardTestTrapezoidCalculation()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new TrapezoidCalculation(messageThrowable);

            /*
             * 
             * 0,7853981217307819
             * */
            double testResult = 0.785;
            double factResult = Math.Round(calculator.Calculation(TestFunctions.MyFunction, 0, 1, 1000), 3);
            Assert.Equal(testResult, factResult);
        }

        /// <summary>
        /// ������������ ������� ������� ��������� ������� ������� ���������������.
        /// ����������� ����.
        /// </summary>
        [Fact]
        public void StandardTestRectangleCalculation()
        {
            IMessageThrowable messageThrowable = new ThrowMessages();
            IIntegralCalculator calculator = new RectangleCalculation(messageThrowable);

            /*
             * 
             * 0,7853981842307827
             * */
            double testResult = 0.785;
            double factResult = Math.Round(calculator.Calculation(TestFunctions.MyFunction, 0, 1, 1000), 3);
            Assert.Equal(testResult, factResult);
        }
    }
}