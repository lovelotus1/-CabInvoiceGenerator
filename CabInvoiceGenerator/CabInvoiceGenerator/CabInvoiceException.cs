using System.Runtime.Serialization;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Custom exception for cab invoice program
    /// </summary>
    public class CabInvoiceException : Exception
    {
        // Enum for defining different type of custom exception
        /// Enum of exception type. <summary>
        /// Enum of exception type.
        public enum ExceptionType
        {
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }
        /// creating type variable of type ExceptionType
        public ExceptionType type;
        // Initializes a new instance of the class.
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}