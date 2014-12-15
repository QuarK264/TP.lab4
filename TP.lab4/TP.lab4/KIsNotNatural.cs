namespace TP.lab4
{
    using System;

    //[global::System.Serializable]
    /// <summary>
    /// Пользовательское исключение
    /// </summary>
    public class KIsNotNaturalException : Exception
    {
        //public KIsNotNatural() { }
        /// <summary>
        /// Конструктор с пользовательским сообщением
        /// </summary>
        /// <param name="message">Вводится пользователем, выходится на экран при к не натуральном</param>
        public KIsNotNaturalException(string message) : base(message) { }
        //public KIsNotNatural(string message, Exception inner) : base(message, inner) { }
        //protected KIsNotNatural(
        //  System.Runtime.Serialization.SerializationInfo info,
        //  System.Runtime.Serialization.StreamingContext context)
        //    : base(info, context) { }
    }
}
