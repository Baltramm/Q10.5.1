using System;

namespace Q10._5._1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Logger log = new Logger();
            Calculator calc = new Calculator(log);
            try
            {
                Console.Write("Введите 1-е число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите 2-е число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                calc.Calculate(a, b);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }
    }
    public interface ICalculator
    {
        void Calculate(int a, int b);
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
