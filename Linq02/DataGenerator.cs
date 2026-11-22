using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq02
{
    using System.Collections.Generic;

    namespace LinqAssignment
    {
        public static class DataGenerator
        {
            public static List<Product> GetProducts()
            {
                return new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
                new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
                new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 13 },
                new Product { ProductID = 4, ProductName = "Chef Anton's Seasoning", Category = "Condiments", UnitPrice = 22.00m, UnitsInStock = 53 },
                new Product { ProductID = 5, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00m, UnitsInStock = 31 },
                new Product { ProductID = 6, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.00m, UnitsInStock = 24 },
                new Product { ProductID = 7, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 },
                new Product { ProductID = 8, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.45m, UnitsInStock = 29 },
                new Product { ProductID = 9, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.00m, UnitsInStock = 0 },
                new Product { ProductID = 10, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.50m, UnitsInStock = 42 },
                new Product { ProductID = 11, ProductName = "Teatime Biscuits", Category = "Confections", UnitPrice = 9.20m, UnitsInStock = 25 },
                new Product { ProductID = 12, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.00m, UnitsInStock = 40 },
                new Product { ProductID = 13, ProductName = "Sir Rodney's Scones", Category = "Confections", UnitPrice = 10.00m, UnitsInStock = 3 },
                new Product { ProductID = 18, ProductName = "Cote de Blaye", Category = "Beverages", UnitPrice = 263.50m, UnitsInStock = 17 },
                new Product { ProductID = 20, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.00m, UnitsInStock = 17 }
            };
            }

            public static List<Customer> GetCustomers()
            {
                return new List<Customer>
            {
                new Customer { CustomerID = "ALFKI", CompanyName = "Alfreds Futterkiste", Country = "Germany", TotalOrderValue = 4500m },
                new Customer { CustomerID = "ANATR", CompanyName = "Ana Trujillo", Country = "Mexico", TotalOrderValue = 1400m },
                new Customer { CustomerID = "ANTON", CompanyName = "Antonio Moreno", Country = "Mexico", TotalOrderValue = 7500m },
                new Customer { CustomerID = "AROUT", CompanyName = "Around the Horn", Country = "UK", TotalOrderValue = 13800m },
                new Customer { CustomerID = "BERGS", CompanyName = "Berglunds snabbkop", Country = "Sweden", TotalOrderValue = 26900m },
                new Customer { CustomerID = "BLAUS", CompanyName = "Blauer See Delikatessen", Country = "Germany", TotalOrderValue = 3200m }
            };
            }
        }
    }
}
