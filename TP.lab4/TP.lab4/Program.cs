namespace TP.lab4
{
    using System;

    class Program
    {
        private static string SumResult(double x, int k)
        {
            double Sum = 0;
            try
            {
                for (int i = 1; i <= k; i++)
                {
                    Sum += (Math.Pow(3.0, i) + Math.Pow(4.0, i)) / Math.Pow(x, 3.0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Sum.ToString();
        }

        static void Main(string[] args)
        {
            try
            {
                double x = Input.InputX("x");
                int k = Input.InputK("k");
                if (x == 0)
                {
                    throw new DivideByZeroException("На ноль делить нельзя.");
                }
                if (k < 0)
                {
                    throw new KIsNotNaturalException("k < 0. k должно быть натуральным.");
                }
                Console.WriteLine(SumResult(x, k));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Нажмите любую клавишу для завершения программы");
            Console.ReadKey();
        }
    }
}
