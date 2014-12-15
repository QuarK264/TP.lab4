namespace TP.lab4
{
    using System;

    /// <summary>
    /// Осуществляет ввод данных в программу обрабатывая исключения
    /// </summary>
    class Input
    {
        /// <summary>
        /// Ввод корректного x
        /// </summary>
        /// <returns>X, не вызвавший не одного исключения</returns>
        public static double InputX()
        {
            Console.Write("Введите x:");
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

        /// <summary>
        /// Ввод корректного k
        /// </summary>
        /// <returns>K, не вызвавший не одного исключения</returns>
        public static int InputK()
        {
            Console.Write("Введите k:");

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
