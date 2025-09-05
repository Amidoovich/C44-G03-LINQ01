
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
        }
    }
}
