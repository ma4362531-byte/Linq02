using Linq02.LinqAssignment;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = DataGenerator.GetProducts();
            List<Customer> customers = DataGenerator.GetCustomers();

            #region Q1
            //List<Product> products = DataGenerator.GetProducts();
            //List<Customer> customers = DataGenerator.GetCustomers();

            //// 1. Get top 3 most expensive products
            //var q1 = products.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var p in q1) Console.WriteLine(p); 
            #endregion

            #region Q2

            //// 2. show page 2 of products, with page size = 5
            //var q2 = products.Skip(5).Take(5);
            //foreach (var p in q2) Console.WriteLine(p);

            #endregion

            #region Q3

            // 3. Take products from the list as long as Their UnitPrice is less than $25 (list is ordered by price).
            //var orderedProducts = products.OrderBy(p => p.UnitPrice);
            //var q3 = orderedProducts.TakeWhile(p => p.UnitPrice < 25m);
            //foreach (var p in q3) Console.WriteLine(p);
            #endregion

            #region Q4

            // 4. Check if ALL products in the "Seafood" category are in stock
            //bool q4 = products.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(q4);
            #endregion


        }
    }
}
