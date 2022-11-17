namespace ExceptionsApp {
    internal class Program {
        static void Main( string[] args ) {
            string text;
            string fileName = "HelloWorld.txt";
            try {
                text = File.ReadAllText( fileName );
                Console.WriteLine( text );
                }
            catch ( FileNotFoundException e ) {
                Console.WriteLine( $"Sorry {fileName} could not be found" );
                }
            catch ( Exception e ) {
                Console.WriteLine( "General handle for all exceptions" );
                }
            finally {
                Console.WriteLine( "We made it here!" );
                }
            }
        }
    }