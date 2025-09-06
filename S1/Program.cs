
using S1.Data;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static S1.Data.ListGenrator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.

            //var Result = ProductList.Where(P => P.UnitsInStock == 0);

            //foreach (var Unit in Result)
            //    Console.WriteLine(Unit);
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3M);

            //foreach (var Unit in Result)
            //    Console.WriteLine(Unit);

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((N, I) => N.Length < I);

            //foreach (var N in Result )
            //    Console.WriteLine(N);

            #endregion


            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 


            //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            //Console.WriteLine(Result);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.


            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000M);

            //Console.WriteLine(Result);

            //// Return null if No Product doesn't match the condition

            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(Number => Number > 5).ElementAtOrDefault(1);

            //Console.WriteLine(Result);
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Count(Number => Number % 2 == 1);

            //Console.WriteLine(Result);

            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var Result = CustomerList.Select(C => new
            //{
            //    C.CustomerID,
            //    C.CustomerName,
            //    NumberOfOrders = C.Orders.Count()

            //});

            //foreach (var Customer in Result)
            //    Console.WriteLine(Customer);

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var Result = ProductList.GroupBy(P => P.Category).Select(P => new
            //{
            //    CategoryName = P.Key,
            //    NumberProduct = P.Count(),

            //});

            //foreach (var Category in Result)
            //    Console.WriteLine(Category);




            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();

            //Console.WriteLine(Result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] StringFirst = File.ReadAllLines("dictionary_english.txt ");

            //var Result = StringFirst.Sum(Word => Word.Length);
            //Console.WriteLine(Result);

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] StringFirst = File.ReadAllLines("dictionary_english.txt ");

            //var Result = StringFirst.Min(Word => Word.Length);
            //Console.WriteLine(Result);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] StringFirst = File.ReadAllLines("dictionary_english.txt ");

            //var Result = StringFirst.Max(Word => Word.Length);
            //Console.WriteLine(Result);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] StringFirst = File.ReadAllLines("dictionary_english.txt ");

            //var Result = StringFirst.Average(Word => Word.Length);
            //Console.WriteLine(Result);

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var Result = ProductList.OrderBy(P => P.ProductName);

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(Word => Word,new StringIComparer());

            //foreach (var str in Result)
            //    Console.WriteLine(str);

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var Result = ProductList.OrderByDescending(P => P.UnitPrice);

            //foreach (var result in Result)
            //    Console.WriteLine(result);


            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result = Arr.OrderBy(Number => Number.Length).ThenBy(Number => Number);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(Word => Word.Length).ThenBy(Word => Word,new StringIComparer());

            //foreach (var str in Result)
            //    Console.WriteLine(str);
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var Result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //foreach (var item in Result)
            //    Console.WriteLine(item);



            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var Result = Arr.OrderBy(Word => Word.Length).ThenByDescending(Word => Word,new StringIComparer());

            //foreach(var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var Result = Arr.Where(Number => Number[1] == 'i').Reverse();

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion
            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var Result = ProductList.Select(P => new
            //{
            //    P.ProductName
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Result = words.Select(Word => new
            //{
            //    UpperCase = Word.ToUpper(),
            //    LowerCase = Word.ToLower()
            //});

            //foreach (var word in Result) 
            //    Console.WriteLine(word);

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Result = ProductList.Select(P => new
            //{
            //    P.ProductID,
            //    P.ProductName,
            //    Price = P.UnitPrice
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Select((Number, I) => new
            //{
            //    Number = Number,
            //    IfMatchesTheIndex = Number == I

            //});

            //foreach (var item in Result)
            //    Console.WriteLine($"{item.Number}: {item.IfMatchesTheIndex}");
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };


            //var Result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //foreach (var item in Result)
            //    Console.WriteLine($"{item.A} is Less than {item.B}");


            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500M);

            //foreach (var result in Result)
            //    Console.WriteLine(result);

            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            
            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.OrderDate >= new DateTime(1998,1,1));

            //foreach (var result in Result)
            //    Console.WriteLine(result);

            #endregion
            #endregion
        }
    }
}
