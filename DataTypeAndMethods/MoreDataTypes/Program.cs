
using System.Text;

static string StringExercise( string myString ) {
    string trim = myString.Trim();
    string upper = trim.ToUpper();
    string replace = upper.Replace( "T", "*" ).Replace( 'L', '*' );
    int index = replace.IndexOf( "N" );
    string remove = replace.Remove( index + 1 );

    return remove;
    }

var myString = " C# list fundementals";
Console.WriteLine( StringExercise( myString ) );

static string StringBuilderExercise( string myString ) {
    var trimmedUpper = myString.Trim().ToUpper();
    StringBuilder sb = new StringBuilder( trimmedUpper );
    sb.Replace( "L", "*" ).Replace( "T", "*" );

    var nPos = sb.ToString().IndexOf( "N" );

    return sb.Remove( nPos + 1, sb.Length - nPos - 1 ).ToString();
    }

Console.WriteLine( StringBuilderExercise( myString ) );


