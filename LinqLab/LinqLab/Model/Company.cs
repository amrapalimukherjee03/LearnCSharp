using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Model
{
    internal class Company
    {
        public string CompanyName { get; set; } = String.Empty;
        public int CompanyID { get; set; }
        public string? CompanyType { get; set; }
    }
}
