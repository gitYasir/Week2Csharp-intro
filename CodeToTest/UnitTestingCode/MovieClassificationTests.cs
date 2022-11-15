using CodeToTest;

namespace UnitTestingCode {
    internal class MovieClassificationTests {

        [TestCase( 3 )]
        [TestCase( -1 )]
        public void GivenAgeOfViewerUnder4( int age ) {
            Assert.That( "Enter age 4 and over", Is.EqualTo( Program.AvailableClassifications( age ) ) );
            }

        [TestCase( 4 )]
        [TestCase( 11 )]
        public void GivenAgeOfViewerBetween4And11Inc( int age ) {
            Assert.That( "U & PG films are available.", Is.EqualTo( Program.AvailableClassifications( age ) ) );
            }

        [TestCase( 12 )]
        [TestCase( 14 )]
        public void GivenAgeOfViewerBetween12To14Inc( int age ) {
            Assert.That( "U, PG & 12 films are available.", Is.EqualTo( Program.AvailableClassifications( age ) ) );
            }

        [TestCase( 15 )]
        [TestCase( 17 )]
        public void GivenAgeOfViewerBetween15To17Inc( int age ) {
            Assert.That( "U, PG, 12 & 15 films are available.", Is.EqualTo( Program.AvailableClassifications( age ) ) );
            }

        [TestCase( 18 )]
        [TestCase( 58 )]
        public void GivenAgeOfViewer18AndOver( int age ) {
            Assert.That( "All films are available.", Is.EqualTo( Program.AvailableClassifications( age ) ) );
            }
        }
    }
