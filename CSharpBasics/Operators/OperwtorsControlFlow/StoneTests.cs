using Operators;
namespace OperwtorsControlFlow {
    internal class StoneTests {
        [TestCase( 14 )]
        public void GivenPounds_GetStones_ReturnStones( int pounds ) {
            Assert.That( 1, Is.EqualTo( Methods.GetStones( pounds ) ) );
            }
        }
    }
