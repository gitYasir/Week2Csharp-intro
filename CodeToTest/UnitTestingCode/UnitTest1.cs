using CodeToTest;

namespace UnitTests {
    public class GreetingTests {
        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening() {
            var time = 21;
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting( time );
            Assert.That( result, Is.EqualTo( expectedGreeting ) );
            }
        [Test]
        public void GivenATimeOf4_Greeting_ReturnsGoodEvening() {
            var time = 4;
            var expectedGreeting = "Good evening!";
            var result = Program.Greeting( time );
            Assert.That( result, Is.EqualTo( expectedGreeting ) );
            }
        [Test]
        public void GivenATimeOf13_Greeting_ReturnsGoodAfternoon() {
            var time = 13;
            var expectedGreeting = "Good afternoon!";
            var result = Program.Greeting( time );
            Assert.That( result, Is.EqualTo( expectedGreeting ) );
            }
        [Test]
        public void GivenATimeOf6_Greeting_ReturnsGoodMorning() {
            var time = 6;
            var expectedGreeting = "Good morning!";
            var result = Program.Greeting( time );
            Assert.That( result, Is.EqualTo( expectedGreeting ) );
            }
        }
    }