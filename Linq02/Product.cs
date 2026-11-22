using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq02
{
    namespace LinqAssignment
    {
        public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }

            public override string ToString()
            {
                return $"ID: {ProductID} | {ProductName} | {Category} | Price: ${UnitPrice} | Stock: {UnitsInStock}";
            }
        }
    }
}
