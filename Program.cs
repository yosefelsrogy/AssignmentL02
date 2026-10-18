using LINQ.DataSources;
using LINQ.Models;

namespace AssignmentL02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //var result = Source.ProductList
            //                    .OrderByDescending(p => p.UnitPrice)
            //                    .Take(3);
            #endregion
            #region q2
            //var result = Source.ProductList
            //                    .Skip(5)
            //                    .Take(5);
            #endregion
            #region q3
            //var result = Source.ProductList
            //                    .OrderByDescending(p => p.UnitPrice)
            //                    .TakeWhile(p => p.UnitPrice <= 25);

            #endregion
            #region q4
            // var result = Source.ProductList
            //                    .Where(p=>p.Category == "Seafood")
            //                    .All(p=>p.UnitsInStock > 0);

            #endregion
            #region q5
            //int[] ids = { 3, 9, 13, 18 };
            //ids.Contains(9);
            #endregion
            #region q6
            //var result = Source.ProductList
            //                  .GroupBy(p=>p.Category)
            //                 .Select(p => new 
            //                 {
            //                     Category = p.Key,
            //                     Count = p.Count()
            //                 });
            #endregion
            #region q7            
            //var result = Source.ProductList
            //                  .GroupBy(p => p.Category)
            //                 .Select(p => new
            //                 {
            //                     Category = p.Key,
            //                     ProductName= p.Select(x => x.ProductName)
            //                 });
            #endregion
            #region q8
            //var result = Source.ProductList
            //    .GroupBy(p=>p.Category )
            //    .Where(p => p.Count() > 3)
            //    .Select(p => p.Key);

            #endregion
            #region q10
            //var result = Source.ProductList
            //                    .Where(p => p.UnitsInStock > 0)
            //                    .Count();
            //Console.WriteLine(result);
            #endregion
            #region q11
            //var result = Source.ProductList
            //                  .Max(p=>p.UnitPrice);
            //                  .Min(p => p.UnitPrice);
            //Console.WriteLine(result);
            #endregion
            #region q12

            //var result = Source.ProductList
            //                    .Select(p=>p.Category)
            //                    .Distinct();

            #endregion
            #region q13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            #endregion
            #region q14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Intersect(list2, StringComparer.OrdinalIgnoreCase);
            #endregion
            #region q16
            //var result = Source.ProductList
            //    .First(p => p.UnitPrice > 50);
            #endregion
            #region q17
            //var result = Source.ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 50);
            #endregion
            #region q19
            //var result = Enumerable.Range(1, 30)
            //                    .Where(n => n % 2 == 0);
            //Console.WriteLine(result);               
            #endregion

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    foreach (var in}) 
            //        {
            //}
            //}
        }
    }
}
