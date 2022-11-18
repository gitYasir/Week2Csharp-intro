using System;

namespace MoreTypes_Lib {
    public class StringExercises {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString( string input, int num ) {
            var upper = input.Trim().ToUpper();
            var numMinus = "";
            for ( int i = num; i > 0; i-- ) {
                var x = num - i;
                numMinus += x;
                }
            return $"{upper}{numMinus}";
            }

        // returns a formatted address string given its components
        public static string Address( int number, string street, string city, string postcode ) {
            return $"{number} {street}, {city} {postcode}.";
            }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer( int score, int outOf ) {
            double percentage = ( score / ( double ) outOf ) * 100;
            string finalScore = Math.Round( percentage, 1 ).ToString();
            return $"You got {score} out of {outOf}: {finalScore}%";
            }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum( string numString ) {
            //double result;
            bool success = double.TryParse( numString, out double result );
            if ( success == false ) {
                return -999;
                }
            return result;
            }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters( string input ) {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            foreach ( char l in input ) {
                if ( l == 'A' ) {
                    a += 1;
                    }
                if ( l == 'B' ) {
                    b += 1;
                    }
                if ( l == 'C' ) {
                    c += 1;
                    }
                if ( l == 'D' ) {
                    d += 1;
                    }
                }

            return $"A:{a} B:{b} C:{c} D:{d}";
            }
        }
    }
