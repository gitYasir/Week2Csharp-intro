using CodeToTest;

namespace UnitTests {
    public class GreetingTests {
        [TestCase( 0 )]
        [TestCase( 4 )]
        [TestCase( 19 )]
        [TestCase( 24 )]
        public void GivenATime_Greeting_ReturnsGoodEvening( int time ) {
            Assert.That( "Good evening!", Is.EqualTo( Program.Greeting( time ) ) );
            }
        [TestCase( 13 )]
        [TestCase( 18 )]
        public void GivenATime_Greeting_ReturnsGoodAfternoon( int time ) {
            var expectedGreeting = "Good afternoon!";
            var result = Program.Greeting( time );
            Assert.That( result, Is.EqualTo( expectedGreeting ) );
            }
        [TestCase( 5 )]
        [TestCase( 12 )]
        public void GivenATime_Greeting_ReturnsGoodMorning( int time ) {
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting( time );
            Assert.That( result, Is.EqualTo( expectedGreeting ) );
            }
        }
    }