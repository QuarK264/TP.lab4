namespace TP.lab4
{
    using System;

    //[global::System.Serializable]
    public class KIsNotNaturalException : Exception
    {
        //public KIsNotNatural() { }
        public KIsNotNaturalException(string message) : base(message) { }
        //public KIsNotNatural(string message, Exception inner) : base(message, inner) { }
        //protected KIsNotNatural(
        //  System.Runtime.Serialization.SerializationInfo info,
        //  System.Runtime.Serialization.StreamingContext context)
        //    : base(info, context) { }
    }
}
