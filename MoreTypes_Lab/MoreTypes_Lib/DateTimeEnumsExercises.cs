using System;

namespace MoreTypes_Lib {
    public enum Suit {
        HEARTS, CLUBS, DIAMONDS, SPADES
        }
    public class DateTimeEnumsExercises {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt( DateTime birthDate, DateTime date ) {
            var age = date.Year - birthDate.Year;
            if ( date.Month < birthDate.Month || ( date.Month == birthDate.Month && date.Day < birthDate.Day ) ) {
                age--;
                if ( age < 0 ) {
                    throw new ArgumentException( "Error - birthDate is in the future" );
                    }
                }
            return age;
            }

        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate( DateTime date ) {
            return date.ToString( "yy/dd/MMM" );
            }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString( DateTime date ) {
            return date.ToString( "MMMM" );
            }

        // see unit tests for requirements
        public static string Fortune( Suit suit ) {
            if ( suit == Suit.HEARTS ) {
                return "You've broken my heart";
                }
            else if ( suit == Suit.DIAMONDS ) {
                return "Diamonds are a girls best friend";
                }
            else if ( suit == Suit.SPADES ) {
                return "Bucket and spade";
                }
            else if ( suit == Suit.CLUBS ) {
                return "And the seventh rule is if this is your first night at fight club, you have to fight.";
                }
            else {
                throw new ArgumentException( "Choose from the four suits." );
                }
            }
        }
    }
