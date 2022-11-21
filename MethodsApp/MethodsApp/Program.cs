namespace MethodsApp
{
    internal class Program
    {
        static void Main( string[] args )
        {
            //var res = DoThis( 10, "sad" );
            //var res2 = DoThis( 10 );
            //var res3 = DoThis( 5, "sleepy", 'o' );

            //var myPizza = OrderPizza( true, false );
            //var myPizza2 = OrderPizza( pineapple: true, mushrooms: false, anchovies: false );
            //var myPizza3 = OrderPizza( false, pineapple: true, mushrooms: false, "sweetcorn" );

            //var johnSmith = (fName: "John", lName: "Smith", age: 22);
            //Console.WriteLine( johnSmith );
            //Console.WriteLine( johnSmith.Item1 );
            //Console.WriteLine( johnSmith.Item2 );

            //string firstName = "Jane";
            //string lastName = "Doe";
            //int age = 150;

            //var janeDoe = (firstName, lastName, age);
            //Console.WriteLine(janeDoe);

            //        var maths = MultiReturn( 10, 5 );
            //        Console.WriteLine( maths );
            //        Console.WriteLine( $"Multiple is {maths.multiply}" );
            //        }

            //    public static int DoThis( int x, string y = "happy", char c = 'x' ) {
            //        Console.WriteLine( $"I'm feeling {y} {c}" );
            //        return x * x;
            //        }
            //    public static string OrderPizza( bool anchovies, bool pineapple, bool mushrooms = false, string x = "" ) {
            //        var pizza = "Pizza with tomato sauce, cheese, ";
            //        string custom = x;
            //        if ( anchovies )
            //            pizza += "anchovies, ";
            //        if ( pineapple )
            //            pizza += "pineapple, ";
            //        if ( mushrooms )
            //            pizza += "mushrooms, ";
            //        if ( custom.Length > 0 ) {
            //            pizza = $"{pizza}{x}.";
            //            }
            //        Console.WriteLine( pizza );
            //        return pizza;
            //        }

            //    public static (int multiply, int divide) MultiReturn( int x, int y ) {
            //        int multiply = x * y;
            //        int divide = x / y;

            //        return (multiply, divide);
            //        }

            //    }
            //}
            //Test();
            //static void Test()
            //{
            //    Random x = new Random( 5 );
            //    int y = x.Next( 1, 7 );
            //    int z = x.Next( 1, 7 );
            //    Console.WriteLine( y );
            //    Console.WriteLine( z );
            //}
            Random rng = new Random( 5 );
            RollDice( rng );
            static int RollDice( Random rng )
            {
                var num1 = rng.Next( 1, 7 );
                var num2 = rng.Next( 1, 7 );
                Console.WriteLine( num1 + num2 );
                return num1 + num2;
            }
        }
    }
}
