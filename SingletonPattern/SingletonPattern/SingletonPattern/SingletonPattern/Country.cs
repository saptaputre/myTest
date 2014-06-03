// -----------------------------------------------------------------------
// <copyright file="Country.cs" company="Microsoft">
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
    public class Country
    {
        List<string> oCountries = new List<string>();
        public Country()
        {
            oCountries.Add("India");
            oCountries.Add("Nepal");
            oCountries.Add("USA");
            oCountries.Add("UK");
        }
        public IEnumerable<string> getCounties()
        {
            return (IEnumerable<string>) oCountries;
        }

    }
}
