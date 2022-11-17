namespace LoopsApp {
    internal class Program {
        static void Main( string[] args ) {
            List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            Console.WriteLine( "Highest foreach loop: " + LoopTypes.HighestForEachLoop( nums ) );
            Console.WriteLine( "Highest for- loop: " + LoopTypes.HighestForLoop( nums ) );
            Console.WriteLine( "Highest while- loop: " + LoopTypes.HighestWhileLoop( nums ) );
            Console.WriteLine( "Highest do-while loop: " + LoopTypes.HighestDoWhileLoop( nums ) );
            }
        }
    }