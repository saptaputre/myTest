// -----------------------------------------------------------------------
// <copyright file="clsFactoryInvoice.cs" company="Microsoft">
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
    public class clsFactoryInvoice
    {
        public static IInvoice getInvoice(int invoiceType)
        {
            IInvoice invoice;
            if (invoiceType == 1)
            {
                invoice = new clsInvoiceWithHeader();
            }
            else if (invoiceType == 2)
            {
                invoice = new clsInvoiceWithOutHeader();
            }
            else
                return null;

            return invoice;
        }
    }
}
