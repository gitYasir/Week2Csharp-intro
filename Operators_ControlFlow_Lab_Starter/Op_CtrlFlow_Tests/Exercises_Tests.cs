﻿using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests {
    public class Exercises_Tests {
        // write unit test(s) for MyMethod here
        [TestCase( 2, 2 )]
        [TestCase( 15, 2 )]
        public void Given2Nums_NotEqualNotModulos0_MyMethod_ShouldReturnFalse( int num1, int num2 ) {
            Assert.That( Exercises.MyMethod( num1, num2 ), Is.EqualTo( false ) );
            }

        [TestCase( 10, 2 )]
        [TestCase( 15, 5 )]
        public void Given2Nums_NotEqualButModulos0_MyMethod_ShouldReturnTrue( int num1, int num2 ) {
            Assert.That( Exercises.MyMethod( num1, num2 ), Is.EqualTo( true ) );
            }

        [Test]
        public void Average_ReturnsCorrectAverage() {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That( Exercises.Average( myList ), Is.EqualTo( 4.4 ) );
            }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero() {
            var myList = new List<int>() { };
            Assert.That( Exercises.Average( myList ), Is.EqualTo( 0 ) );
            }

        [TestCase( 100, "OAP" )]
        [TestCase( 60, "OAP" )]
        [TestCase( 59, "Standard" )]
        [TestCase( 18, "Standard" )]
        [TestCase( 17, "Student" )]
        [TestCase( 13, "Student" )]
        [TestCase( 12, "Child" )]
        [TestCase( 5, "Child" )]
        [TestCase( 4, "Free" )]
        [TestCase( 0, "Free" )]
        public void TicketTypeTest( int age, string expected ) {
            var result = Exercises.TicketType( age );
            Assert.That( result, Is.EqualTo( expected ) );
            }

        [TestCase( 101, "Error! Max Score is 100" )]
        [TestCase( 100, "Pass with Distinction" )]
        [TestCase( 75, "Pass with Distinction" )]
        [TestCase( 74, "Pass with Merit" )]
        [TestCase( 60, "Pass with Merit" )]
        [TestCase( 59, "Pass" )]
        [TestCase( 40, "Pass" )]
        [TestCase( 39, "Fail" )]
        [TestCase( 0, "Fail" )]
        [TestCase( -1, "Error! Max Score is 100" )]
        public void UniGradesTests( int mark, string expected ) {
            var result = Exercises.Grade( mark );
            Assert.That( result, Is.EqualTo( expected ) );
            }

        [TestCase( 4, 20 )]
        [TestCase( 3, 50 )]
        [TestCase( 2, 50 )]
        [TestCase( 1, 100 )]
        [TestCase( 0, 200 )]
        public void GetMaxAttendeesTests( int level, int expected ) {
            var result = Exercises.GetScottishMaxWeddingNumbers( level );
            Assert.That( result, Is.EqualTo( expected ) );
            }
        }
    }
