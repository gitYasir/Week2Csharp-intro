#region MyRegion

int mark = 35;
//var grade = mark >= 65 ? "Pass" : "Fail";
//Console.WriteLine(grade);

//string grade = NewMethod( mark );
//Console.WriteLine( grade );

public partial class CheckGrade {
    public static string GetGrade( int mark ) {
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
    }


#endregion