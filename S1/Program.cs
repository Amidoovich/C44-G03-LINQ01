
namespace S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implictly Type Local Variable [var , Dynamic]


            #region Var
            ////string Data = "Ahmed";

            //var Data = "Ahmed"; // Implicitly typed
            //                    // Compiler will detect DataType of variable at compilation time
            //                    // Based on intial Value
            //                    //var x = null; // invalid

            //Data = null;

            //Data = "Mostafa";

            ////Data = 10; // invalid 
            #endregion


            #region Dynamic

            //dynamic Data = "Ali";
            //// CLR will Detect DataType of variable At Runtime
            //// Based on it is Last Assign Value

            //dynamic X;

            //dynamic Y = null;

            //Data = 10;

            //Data = true;

            //foreach (var i in collection)




            #endregion

            // var x  null;
            //dynamic x = null;
            //Console.WriteLine(x);


            #endregion

            #region Extension Methods

            //int X = 12345;
            ////int Y = IntExtension.Reverse(X);

            //int Y;
            //Y = X.Reverse();

            //Console.WriteLine(Y);

            //long Z = 12346789156;
            //long A = Z.Reverse();
            #endregion

            #region Anonymous Type

            //Employee employee = new Employee() { Id = 10 , Name = "Mona" , Salary = 8000 };


            //object Emp01 = new { Id = 10, Name = "Mona", Salary = 8000 };

            //Console.WriteLine(Emp01.Salary);
            //int x = 5;

            //Console.WriteLine(x.GetType().Name);

            //var Emp03 = new { Id = 10, Name = "Mona", Salary = 8000 };
            ////Console.WriteLine(Emp03.GetType().Name); //<>f__AnonymousType0`3
            ////Console.WriteLine(Emp03.Id);


            //var Emp04 = new { Id = Emp03.Id, Name = Emp03.Name, Salary = 5000 }; //C# 09

            //var Emp05 = Emp03 with { Salary = 2000 }; //C# 10

            //Console.WriteLine($"Emp 03 = {Emp03.GetType().Name}"); //<>f__AnonymousType0`3
            //Console.WriteLine($"Emp 04 = {Emp04.GetType().Name}"); //<>f__AnonymousType0`3
            //Console.WriteLine($"Emp 05 = {Emp05.GetType().Name}"); //<>f__AnonymousType0`3

            //// The Same Anonymous Type as long as :
            //// 1. same properties Name [Case Senstive]
            //// 2. same properties Order

            //var Emp06 = new { Name = "Mona", Id = 10 };
            //Console.WriteLine($"Emp 06 = {Emp06.GetType().Name}");
            #endregion

            #region What Is LINQ


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> OddNumbers = Numbers.Where(Number => Number % 2 != 0).ToList();

            //foreach (int number in OddNumbers)
            //    Console.WriteLine(number);

            #endregion

            #region LINQ Syntax [fluent syntax - query syntax]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            #region Fluent Syntax
            // 1.1 Call "LINQ Operators" as static method
            //List<int> OddNumbers = Enumerable.Where(Numbers,Number => Number % 2 != 0).ToList();

            // 1.2 Call "LINQ Operators" as Method Extension [Recommended]
            //List<int> OddNumbers = Numbers.Where(Number => Number % 2 != 0).ToList();
            //foreach (int number in OddNumbers)
            //    Console.WriteLine(number); 
            #endregion

            #region Query Syntax - like sql server style

            // select *
            // from Numbers N
            // where N % 2 == 1

            //var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;

            //foreach(var N in Numbers)
            //    Console.WriteLine(N);
            #endregion





            #endregion

            #region LINQ Executon Ways

            #region Deferred Execution [Latest Version of Data]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(Number => Number % 2 != 0);

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (int number in OddNumbers)
            //    Console.Write($"{number} "); // 1 3 5 7 9 11 13 15

            #endregion

            #region Immediate Execution


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(Number => Number % 2 != 0).ToList();

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (int number in OddNumbers)
            //    Console.Write($"{number} "); // 1 3 5 7 9 

            #endregion

            #endregion

        }
    }
}
