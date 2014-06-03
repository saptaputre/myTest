﻿// -----------------------------------------------------------------------
// <copyright file="ConcretePrototype2.cs" company="Microsoft">
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
    public class ConcretePrototype2 : PrototypeInterface
    {
        // Constructor 
        public ConcretePrototype2(string id)
            : base(id)
        {
        }

        public override PrototypeInterface Clone()
        {
            // Shallow copy 
            return (PrototypeInterface)this.MemberwiseClone();
        }
    }
}
