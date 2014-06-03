// -----------------------------------------------------------------------
// <copyright file="GlobalSingleton.cs" company="Microsoft">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class GlobalSingleton
    {
        // object which needs to be shared globally
        public Country Countries = new Country();

        // use static variable to create a single 
        //instance of the object
        static readonly GlobalSingleton INSTANCE = new GlobalSingleton();

        //This is a private constructor, meaning 
        //no outsides have access.
        private GlobalSingleton() { }

        public static GlobalSingleton Instance
        {
            get
            {
                return INSTANCE;
            }
        }       

    }
}
