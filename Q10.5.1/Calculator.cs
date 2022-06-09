using System;

namespace Q10._5._1
{
    public class Calculator : ICalculator
    {
        public void Calculate(int a, int b)
        {
            log.Event("Результат:");
            Console.WriteLine("Сумма чисел ровна {0} ", a + b);
        }
        ILogger log { get; set; }
        public Calculator(ILogger log)
        {
            this.log = log;
        }
    }
}
