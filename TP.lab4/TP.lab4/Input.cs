namespace TP.lab4
{
    using System;

    class Input
    {
        public static double InputX(string VariableName)
        {
            Console.Write("Введите {0}:", VariableName);
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
        public static int InputK(string VariableName)
        {
            Console.Write("Введите {0}:", VariableName);

            string strValue = Console.ReadLine();
            int Value;
            if (!int.TryParse(strValue, out Value))
            {
                Value = checked(int.Parse(strValue));
                throw new FormatException("Нельзя использовать букву вместо цифры.");
            }
            else
            {
                return int.Parse(strValue);
            }
        }
    }
}
