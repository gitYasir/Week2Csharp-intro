#region MyRegion

int mark = 35;
//var grade = mark >= 65 ? "Pass" : "Fail";
//Console.WriteLine(grade);

//string grade = NewMethod( mark );
//Console.WriteLine( grade );

public partial class CheckGrade {
    public static void Main( string[] args ) {
        try {
            Console.WriteLine( $"Anil's mark is 82: {GetGrade( 82 )}" );
            Console.WriteLine( $"Phil's mark is -82: {GetGrade( -82 )}" );
            }
        catch ( ArgumentException e ) {
            Console.WriteLine( "Invalid data, please try again" );
            Console.WriteLine( e.Message );
            }
        }
    public static string GetGrade( int mark ) {
        if ( mark > 0 || mark < 100 ) {
            throw new ArgumentException(
                $"Mark value of {mark} is outside range 0-100" );
            }
        string grade = "";
        if ( mark >= 65 ) {
            if ( mark >= 85 ) {
                grade += "Distinction";
                }
            else {
                grade += "Pass";
                }
            }
        else {
            grade += "Fail";
            }
        return grade;
        }

    public static string Priority( int level ) {
        string priority = "Code ";

        switch ( level ) {
            case 3:
                priority += "Red";
                break;
            case 2: // If nothing, it moves on to the next case and return that. i.e Amber in this case.
            case 1:
                priority += "Amber";
                break;
            case 0:
                priority += "Green";
                break;
            default:
                priority = "Error!";
                break;
            }
        return priority;
        }

    public static string DrivingLaw( int age ) {
        string law = "";
        switch ( age ) {
            case < 18:
                law = "Cannot legally drive";
                break;
            case < 23:
                law = "Can legally drive, but cannot hire a car";
                break;
            default:
                law = "Can legally drive and rent a car";
                break;
            }
        return law;
        }


    }


#endregion