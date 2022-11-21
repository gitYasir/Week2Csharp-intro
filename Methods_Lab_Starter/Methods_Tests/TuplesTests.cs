using Methods_Lib;
using NUnit.Framework;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase( 25, 3, 4 )]
        [TestCase( 0, 0, 0 )]
        [TestCase( 33, 4, 5 )]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays )
        {
            var answer = Methods.DaysAndWeeks( totalDays );
            Assert.That( answer.weeks, Is.EqualTo( expectedWeeks ), "Weeks" );
            Assert.That( answer.days, Is.EqualTo( expectedDays ), "Days" );
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That( () => Methods.DaysAndWeeks( -1 ), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain( "totalDays must not be negative" ) );
        }

        [TestCase( 5, 25, 125, 2.23 )]
        [TestCase( 6, 36, 216, 2.44 )]
        public void GivenANumber_PowersRoot_ReturnsCorrectTuple(
           int num, int square, int cube, double root )
        {
            var answer = Methods.PowersRoot( num );
            Assert.That( answer.square, Is.EqualTo( square ), "square" );
            Assert.That( answer.cube, Is.EqualTo( cube ), "cube" );
            Assert.That( answer.root, Is.EqualTo( root ).Within( 0.01 ), "root" );
        }

    }

}