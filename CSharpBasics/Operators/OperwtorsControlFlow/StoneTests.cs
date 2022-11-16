using Operators;

namespace OperwtorsControlFlow {
    public class StoneTests {
        [TestCase( 14 )]
        public void GivenPounds_GetStones_ReturnStones( int pounds ) {
            Assert.That( 1, Is.EqualTo( Methods.GetStones( pounds ) ) );
            }
        [TestCase( 156 )]
        public void GivenPounds_GetPounds_Returnpounds( int pounds ) {
            Assert.That( 2, Is.EqualTo( Methods.GetPounds( pounds ) ) );
            }
        }
    }
