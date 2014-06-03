// -----------------------------------------------------------------------
// <copyright file="Prototype.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace PrototypePattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public abstract class PrototypeInterface
    {
        private string id;

        // Constructor 
        public PrototypeInterface(string id)
        {
            this.id = id;
        }

        // Property 
        public string Id
        {
            get { return id; }
            set { this.id = value; }
        }
        

        public abstract PrototypeInterface Clone();
    }
}
