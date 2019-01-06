using System;

namespace Invoice_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string partNumber, partDescr;
            int qty;
            decimal price;

            Console.WriteLine("Please enter part number ");
            partNumber = Console.ReadLine();

            Console.WriteLine("Please enter part description ");
            partDescr = Console.ReadLine();

            Console.WriteLine("Please enter quantity ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter part number ");
            price = Convert.ToDecimal(Console.ReadLine());

            Invoice invoice = new Invoice(partNumber, partDescr, qty, price);

            Console.WriteLine("Your order is: ");
            Console.WriteLine("Part numner is: {0}", invoice.PartNumber);
            Console.WriteLine("Part description: {0}", invoice.PartDescr);
            Console.WriteLine("Quantity: {0}", invoice.Qty);
            Console.WriteLine("Price: {0}", invoice.Price);
            Console.WriteLine("Total: {0}", invoice.GetInvoiceAmount());

            Console.ReadLine();






        }
    }
}
