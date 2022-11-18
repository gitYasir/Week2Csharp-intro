//static string StringExercise( string myString ) {
//    string trim = myString.Trim();
//    string upper = trim.ToUpper();
//    string replace = upper.Replace( "T", "*" ).Replace( 'L', '*' );
//    int index = replace.IndexOf( "N" );
//    string remove = replace.Remove( index + 1 );

//    return remove;
//    }

//var myString = " C# list fundementals";
//Console.WriteLine( StringExercise( myString ) );

//static string StringBuilderExercise( string myString ) {
//    var trimmedUpper = myString.Trim().ToUpper();
//    StringBuilder sb = new StringBuilder( trimmedUpper );
//    sb.Replace( "L", "*" ).Replace( "T", "*" );

//    var nPos = sb.ToString().IndexOf( "N" );

//    return sb.Remove( nPos + 1, sb.Length - nPos - 1 ).ToString();
//    }

//Console.WriteLine( StringBuilderExercise( myString ) );

//static void StringInterpolation( string name ) {
//    Console.WriteLine( "Hello, " + name + " - concatenation operator" );
//    Console.WriteLine( String.Concat( "Hello, ", name, " - static String.Concat method" ) );
//    Console.WriteLine( $"Hello, {name} - string interpolation" );

//    var cashPrize = 10000.00;
//    var numberOfWinners = 6000;
//    var cashEach = $"You will receive {cashPrize / numberOfWinners:C}!";

//    }

//StringInterpolation( "Yasir" );

static void ParsingStrings() {
    Console.Write( "How many apples? " );
    var input = Console.ReadLine() ?? "0";
    int numApples;
    bool success = Int32.TryParse( input, out numApples ); // Parse or TryParse
    }

ParsingStrings();

