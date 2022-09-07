using System.Runtime.Serialization;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        // Enum for defining different type of custom exception       
        public ExceptionType type;

        // Initializes a new instance of the class.

        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDES, INVALID_USER_ID
        }
    }
}