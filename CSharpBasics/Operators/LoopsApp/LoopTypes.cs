namespace LoopsApp {
    internal class LoopTypes {
        internal static int HighestForEachLoop( List<int> nums ) {
            int highest = nums[ 0 ];
            // or int highest = int.MinValue;
            foreach ( int x in nums ) {
                if ( x > highest ) {
                    highest = x;
                    }
                }
            return highest;
            }

        internal static int HighestForLoop( List<int> nums ) {
            int highest = nums[ 0 ];
            // or int highest = int.MinValue;
            for ( int i = 0; i < 5; i++ ) {
                if ( nums[ i ] > highest ) {
                    highest = nums[ i ];
                    }
                }
            return highest;
            }

        internal static int HighestWhileLoop( List<int> nums ) {
            int highest = nums[ 0 ];
            // or int highest = int.MinValue;
            int i = 0;
            while ( i < nums.Count ) {
                if ( nums[ i ] > highest ) {
                    highest = nums[ i ];
                    }
                i++;
                }
            return highest;
            }

        internal static int HighestDoWhileLoop( List<int> nums ) {
            int highest = nums[ 0 ];
            // or int highest = int.MinValue;
            int i = 0;
            do {
                if ( nums[ i ] > highest ) {
                    highest = nums[ i ];
                    }
                i++;
                } while ( i < nums.Count );
            return highest;
            }

        }

    }
