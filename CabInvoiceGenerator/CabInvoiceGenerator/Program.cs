using System;

namespace CabInvoiceGenerator
{
    class Program
    {
       public static void Main(string[] args)
       {
            Console.WriteLine(" Welcome to CabInvoiceGenerator");
            //Creating Object
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            //Calculate Fare double
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare: {fare}");
            Console.ReadLine();
        }
    }
}
