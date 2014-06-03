using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IInvoice invoice;
            int invType;
            Console.WriteLine("Inter the invoice type");
            invType = Convert.ToInt16(Console.ReadLine());
            invoice = clsFactoryInvoice.getInvoice(invType);
            invoice.Print();
            Console.ReadLine();
        }
    }
}
