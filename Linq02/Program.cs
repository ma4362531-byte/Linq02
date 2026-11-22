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

            #region Q5

            // 5. Check if the ID list contains 9
            // int[] ids = { 3, 9, 13, 18 };
            //int[] ids = { 3, 9, 13, 18 };
            //bool q5 = ids.Contains(9);
            //Console.WriteLine(q5);
            #endregion

            #region Q6

            // 6. Group all products by Category and print each group with its product count.
            //var q6 = products.GroupBy(p => p.Category);
            //foreach (var group in q6)
            //    Console.WriteLine($"{group.Key}: {group.Count()} products");

            #endregion

            #region Q7

            // 7. Group products by Category and project only product names per group
            //var q7 = products.GroupBy(p => p.Category, p => p.ProductName);
            //foreach (var group in q7)
            //    Console.WriteLine($"{group.Key} => {string.Join(", ", group)}");

            #endregion

            #region Q8

            // 8. Find all categories that have MORE THAN 3 products
            //var q8 = products.GroupBy(p => p.Category)
            //                 .Where(g => g.Count() > 3)
            //                 .Select(g => g.Key);
            //foreach (var cat in q8) Console.WriteLine(cat);

            #endregion

            #region Q9

            // 9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var q9 = from c in customers
            //         group c by c.Country into g
            //         select new
            //         {
            //             Country = g.Key,
            //             Count = g.Count(),
            //             TotalOrderValue = g.Sum(x => x.TotalOrderValue)
            //         };
            //foreach (var item in q9)
            //    Console.WriteLine($"{item.Country} | Count: {item.Count} | Total: ${item.TotalOrderValue}");

            #endregion

            #region Q10

            // 10. Calculate the total number of units in stock across all products
            //int q10 = products.Sum(p => p.UnitsInStock);
            //Console.WriteLine(q10);

            #endregion

            #region Q11

            // 11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //decimal cheapest = products.Min(p => p.UnitPrice);
            //decimal mostExpensive = products.Max(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest: ${cheapest}, Most Expensive: ${mostExpensive}");

            #endregion

        }
    }
}
