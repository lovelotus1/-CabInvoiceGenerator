using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class CustomException : Exception
    {
        public Exceptions type;
        public enum Exceptions
        {
            TimeSmallerThaOneMin,
            DistanceSmallerThanFive,
            InvalidUserId
        }
        public CustomException(Exceptions type, string message) : base(message)
        {
            this.type = type;
        }
    }
}