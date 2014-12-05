namespace TP.lab4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        private static double InputValue(string VariablesName)
        {
            Console.Write("Введите {0}:", VariablesName);
            string strValue = Console.ReadLine();
            double Value;
            if (!double.TryParse(strValue, out Value))
            {
                throw new FormatException("Нельзя использовать букву вместо цифры.");
            }
            else
            {
                return double.Parse(strValue);
            }            
        }

        private static string SumResult(double x, int k)
        {
            double Sum = 0;
            for (int i = 1; i < k; i++)
            {
                Sum += (Math.Pow(3, i) + Math.Pow(4, i)) / Math.Pow(x, 3);
            }
            return Sum.ToString();
        }

        static void Main(string[] args)
        {
            try
            {
                double x = InputValue("x");
                int k = (int)InputValue("k");
                if (x == 0)
                {
                    throw new DivideByZeroException("На ноль делить нельзя.");
                }                
                if (k < 0)
                {
                    throw new Exception("k < 0. Число суммирований не может быть отрицательным.");
                }
                Console.WriteLine(SumResult(x, k));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
            Console.ReadLine();
        }
    }
}
