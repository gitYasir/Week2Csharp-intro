namespace CodeToTest {
    public class Program {
        static void Main( string[] args ) {
            int timeOfDay = 21;
            var output = Greeting( timeOfDay );
            Console.WriteLine( output );
            }

        public static string Greeting( int timeOfDay ) {
            string greeting;

            if ( timeOfDay >= 5 && timeOfDay <= 12 ) {
                greeting = "Good morning!";
                }
            else if ( timeOfDay > 12 && timeOfDay <= 18 ) {
                greeting = "Good afternoon!";
                }
            else {
                greeting = "Good evening!";
                }
            return greeting;
            }

        public static string AvailableClassifications( int ageOfViewer ) {
            string result;
            if ( ageOfViewer >= 4 && ageOfViewer <= 11 ) {
                result = "U & PG films are available.";
                }
            else if ( ageOfViewer >= 12 && ageOfViewer <= 14 ) {
                result = "U, PG & 12 films are available.";
                }
            else if ( ageOfViewer >= 15 && ageOfViewer <= 17 ) {
                result = "U, PG, 12 & 15 films are available.";
                }
            else if ( ageOfViewer >= 18 ) {
                result = "All films are available.";
                }
            else {
                result = "Enter age 4 and over";
                }
            return result;
            }
        }
    }