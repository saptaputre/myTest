// -----------------------------------------------------------------------
// <copyright file="clsInvoiceWithHeader.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace FactoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class clsInvoiceWithHeader : IInvoice
    {
        public void Print()
        {
            Console.WriteLine("Invoice will be printed without header");
        }
    }
}
