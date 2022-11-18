using System;

namespace DataTypes_Lib {
    public static class IntegerCalc {
        public static int Add( int num1, int num2 ) {
            int x = num1 + num2;

            return Convert.ToInt16( x );
            }

        public static int Subtract( int num1, int num2 ) {
            int num3 = num1 - num2;
            return Convert.ToInt16( num3 );
            }

        public static int Multiply( int num1, int num2 ) {
            int y = num1 * num2;
            return Convert.ToInt32( y );
            }

        public static int Divide( int num1, int num2 ) {
            if ( num2 == 0 ) {
                throw new ArgumentException( "Can't divide by zero" );
                }
            int z = num1 / num2;
            return Convert.ToInt16( z );
            }

        public static int Modulus( int num1, int num2 ) {
            if ( num2 == 0 ) {
                throw new ArgumentException( "Can't modulo by zero" );
                }
            int a = num1 % num2;
            return Convert.ToInt16( a );
            }
        }
    }
