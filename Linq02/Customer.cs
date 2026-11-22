using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq02
{
    namespace LinqAssignment
    {
        public class Customer
        {
            public string CustomerID { get; set; } = string.Empty;
            public string CompanyName { get; set; } = string.Empty;
            public string Country { get; set; } = string.Empty;
            public decimal TotalOrderValue { get; set; }
        }
    }
}
