using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalSingleton oSingle1 = GlobalSingleton.Instance;
            Country count1 = oSingle1.Countries;

            GlobalSingleton oSingle2 = GlobalSingleton.Instance;
            Country count2 = oSingle2.Countries;
           


            if (oSingle1 == oSingle2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user 
            Console.Read();

        }
    }
}
