using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    internal class LinqArray
    {
        static string[] countries = { "India", "USA", "UK", "Japan" };
        public static void PrintCountry()
        {
            var selectedCountries = from country in countries where country.Contains('I') select country;

            foreach (var country in selectedCountries)
            {
                Console.WriteLine("Selected country is:" + country);
            }
        }
    }
}
