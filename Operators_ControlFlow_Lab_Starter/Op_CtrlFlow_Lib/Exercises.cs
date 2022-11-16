using System;
using System.Collections.Generic;
using System.Linq;

namespace Op_CtrlFlow {
    public class Exercises {
        public static bool MyMethod( int num1, int num2 ) {
            return num1 == num2 ? false : ( num1 % num2 ) == 0;
            }

        // returns the average of the array nums
        public static double Average( List<int> nums ) {
            double length = nums.Count;

            double sum = nums.Sum() / length;
            return nums.Count != 0 ? Math.Round( sum, 1 ) : 0;
            }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType( int age ) {
            string ticketType = string.Empty;
            switch ( age ) {
                case < 5:
                    ticketType = "Free";
                    break;
                case < 13:
                    ticketType = "Child";
                    break;
                case < 18:
                    ticketType = "Student";
                    break;
                case >= 60:
                    ticketType = "OAP";
                    break;
                default:
                    ticketType = "Standard";
                    break;
                }
            return ticketType;
            }

        public static string Grade( int mark ) {
            var grade = "";
            if ( mark >= 75 && mark <= 100 ) {
                grade = "Pass with Distinction";
                }
            else if ( mark >= 60 && mark <= 74 ) {
                grade = "Pass with Merit";
                }
            else if ( mark >= 40 && mark <= 59 ) {
                grade = "Pass";
                }
            else if ( mark >= 0 && mark <= 39 ) {
                grade = "Fail";
                }
            else {
                grade = "Error! Max Score is 100";
                }
            return grade;
            }

        public static int GetScottishMaxWeddingNumbers( int covidLevel ) {
            int maxAttendees;
            switch ( covidLevel ) {
                case 4:
                    maxAttendees = 20;
                    break;
                case 3:
                    maxAttendees = 50;
                    break;
                case 2:
                    maxAttendees = 50;
                    break;
                case 1:
                    maxAttendees = 100;
                    break;
                default:
                    maxAttendees = 200;
                    break;
                }
            return maxAttendees;
            }
        }
    }
