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
        }
    }
