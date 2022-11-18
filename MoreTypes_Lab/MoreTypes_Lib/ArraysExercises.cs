using System;
using System.Collections.Generic;

namespace MoreTypes_Lib {
    public class ArraysExercises {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray( List<string> contents ) {
            return contents.ToArray();
            }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray( int length1, int length2, int length3, List<string> contents ) {
            int i, j, k, p;
            string[,,] Arr = new string[ length1, length2, length3 ];

            try {
                p = 0;
                for ( i = 0; i < length1; i++ ) {
                    for ( j = 0; j < length2; j++ ) {
                        for ( k = 0; k < length3; k++ ) {
                            Arr[ i, j, k ] = contents[ p++ ];
                            }
                        }
                    }
                }
            catch ( ArgumentException ) {
                throw new ArgumentException( "Number of elements in list must match array size" );
                ;
                }

            return Arr;
            }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray( int countRow1, int countRow2, List<string> contents ) {
            string[][] strArr = new string[ 2 ][];
            strArr[ 0 ] = new string[ countRow1 ];
            strArr[ 1 ] = new string[ countRow2 ];
            int i, j, p;
            try {
                p = 0;
                for ( i = 0; i < strArr.Length; i++ ) {
                    for ( j = 0; j < strArr[ i ].Length; j++ ) {
                        strArr[ i ][ j ] = contents[ p++ ];
                        }
                    }
                }
            catch ( ArgumentException ) {
                throw new ArgumentException( "Number of elements in list must match array size" );
                ;
                }

            return strArr;

            }
        }
    }
