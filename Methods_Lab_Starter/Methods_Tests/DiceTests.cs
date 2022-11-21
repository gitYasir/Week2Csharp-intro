using Methods_Lib;
using NUnit.Framework;
using System;

namespace Methods_Tests
{
    public class DiceTests
    {

        [TestCase( 5, 5 )]
        [TestCase( 6, 10 )]
        public void GivenARandNumber_RollDice_ReturnsNumberBetween0And13( int seed, int expected )
        {
            Random x = new Random( seed );

            Assert.That( expected, Is.EqualTo( Methods.RollDice( x ) ) );


        }
    }
}
