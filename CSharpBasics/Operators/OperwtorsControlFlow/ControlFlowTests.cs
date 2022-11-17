namespace OperwtorsControlFlow {
    internal class ControlFlowTests {
        [TestCase( 67 )]
        public void GivenGrade_Checkgrade_ReturnsPass( int mark ) {
            string grade = CheckGrade.GetGrade( mark );
            string expected = "Pass";
            Assert.That( expected, Is.EqualTo( grade ) );
            }
        [TestCase( 64 )]
        public void GivenGrade_Checkgrade_ReturnsFail( int mark ) {
            string grade = CheckGrade.GetGrade( mark );
            string expected = "Fail";
            Assert.That( expected, Is.EqualTo( grade ) );
            }

        [TestCase( -34 )]
        [TestCase( -1 )]
        public void MarkLessThanZero_Grade_ThrowsArgumentException( int mark ) {
            Assert.That( () => {
                return CheckGrade.GetGrade( mark );
            }, Throws.TypeOf<ArgumentException>()
            .With.Message.Contain( "is outside range 0-100" ) );
            }

        [TestCase( 101 )]
        [TestCase( 144 )]
        public void MarkMoreThan100_Grade_ThrowsArgumentException( int mark ) {
            Assert.That( () => {
                return CheckGrade.GetGrade( mark );
            }, Throws.TypeOf<ArgumentException>() );
            }
        }
    }
