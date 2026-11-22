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


        }
    }
}
