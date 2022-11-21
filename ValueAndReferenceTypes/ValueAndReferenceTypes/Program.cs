//// Reference types
//using System.Text;

//StringBuilder sb = new StringBuilder(); // mutable
//sb.Append( "Hello" );
//string st = "Hello"; // immutable

//// Value types
//int number = 10; // mutable

//StringBuilder sbCopy = sb;
//sbCopy.Append( ", World!" );

//string stCopy = st;
//stCopy += ", World!";
//int numberCopy = number;
//numberCopy += 5;

//Console.WriteLine( $"Original sb: {sb.ToString()}" );
//Console.WriteLine( $"Original st: {st}" );
//Console.WriteLine( $"Original number: {number}" );

//AddMessageToSb( sb );
//Console.WriteLine( $"Original sb after AddMessageToSb: {sb.ToString()}" );



//static void AddMessageToSb( StringBuilder sb ) {
//    sb.Append( " - and anyone else I may have forgotten." );
//    }

//MakeSbNull( ref sb );
//Console.WriteLine( $"Original sb after MakeSbNull: {sb.ToString()}" );

//static void MakeSbNull( ref StringBuilder? sb ) {
//    sb = null;
//    }

var numToSwap1 = 5;
var numToSwap2 = 10;
Console.WriteLine( $"Original num1:{numToSwap1}, Original num2:{numToSwap2}" );

Swap( ref numToSwap1, ref numToSwap2 );
Console.WriteLine( $"swapped num1:{numToSwap1}, swapped num2:{numToSwap2}" );

static void Swap( ref int numToSwap1, ref int numToSwap2 ) {
    var temp = numToSwap1;
    numToSwap1 = numToSwap2;
    numToSwap2 = temp;
    }