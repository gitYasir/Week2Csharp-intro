namespace NumericDataTypesApp {
    internal class Program {
        static void Main( string[] args ) {
            #region var
            int x = 3; // explicitly typed
            var y = 2; // implicitly typed

            var name = "Yasir";
            var isClean = true;
            var letter = "A";
            var uLongNum = 52uL;

            //  List<decimal> prices = new List<decimal>();
            var prices = new List<decimal>();
            #endregion

            #region integer literals

            var n1 = -65;
            var n2 = 65;
            var n3 = 100_000;
            var n4 = 100_000;
            var n5 = 4_000_000_000;
            var n6 = -5_000_000_000;
            var n7 = 5_000_000_000;

            #endregion

            #region floating-point type

            float sum = 0;
            for ( int i = 0; i < 100_000; i++ ) {
                sum += 2 / 5.0f;
                }
            Console.WriteLine( "2/5 added 100,000 times: " + sum );
            Console.WriteLine( "2/5 multiplied by 100,000: " + 2 / 5.0f * 100_000 );

            #endregion

            #region conversions

            var result = 5.5 / 5;

            #endregion
            }
        }
    }