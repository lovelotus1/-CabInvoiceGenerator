using System;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Design Principle 
    /// </summary>
    class Program
    {
       public static void Main(string[] args)
       {
            /// <summary>
            /// Defines Entry point of application
            /// </summary>
            /// <param name="args"></param>
            Console.WriteLine(" Welcome to CabInvoiceGenerator");
            //Creating Object
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator((RideType.NORMAL));
            //Calculate Fare double
            double fare = invoiceGenerator.CalculateFare(2.0, 3);
            Console.WriteLine($"Fare: {fare}");
            Console.ReadLine();
        }
    }
}
