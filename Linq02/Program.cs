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

            #region Q12

            // 12. Get a distinct list of all product categories
            //var q12 = products.Select(p => p.Category).Distinct();
            //foreach (var cat in q12) Console.WriteLine(cat);

            #endregion

            #region Q13

            // 13. find product IDs that are in setA but NOT in setB
            // int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            // int[] setB = { 3, 6, 9, 12, 15, 13 };
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var q13 = setA.Except(setB);
            //Console.WriteLine(string.Join(", ", q13));

            #endregion

            #region Q14

            // 14. Find countries that appear in list1 but NOT in list2 (case-insensitive).
            // string[] list1 = { "Germany", "France", "UK", "Spain" };
            // string[] list2 = { "france", "SPAIN", "Italy" };
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var q14 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine(string.Join(", ", q14));

            #endregion

            #region Q15

            // 15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //Dictionary<int, Product> productDict = products.ToDictionary(p => p.ProductID);
            //if (productDict.TryGetValue(18, out Product? prod18))
            //    Console.WriteLine(prod18);

            #endregion

            #region Q16

            // 16. Get the first product whose price is greater than $50.
            //var q16 = products.First(p => p.UnitPrice > 50m);
            //Console.WriteLine(q16);

            #endregion

            #region Q17

            // 17. Try to get the first product with a price > $500. it returns null instead of throwing.
            //var q17 = products.FirstOrDefault(p => p.UnitPrice > 500m);
            //Console.WriteLine(q17 == null ? "null (Not Found)" : q17.ToString());

            #endregion

            #region Q18

            // 18. Generate a multiplication table row for 7
            //var q18 = Enumerable.Range(1, 10).Select(n => n * 7);
            //Console.WriteLine(string.Join(", ", q18));

            #endregion

            #region Q19

            // 19. Generate even numbers between 1 and 30.
            //var q19 = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            //Console.WriteLine(string.Join(", ", q19));

            #endregion
        }
    }
}
