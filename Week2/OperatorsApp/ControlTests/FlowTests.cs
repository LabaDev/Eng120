using ControlFlowApp;

namespace ControlTests
{
    public class FlowTests
    {
        [Test]

        public void GivenMark25_Gives_Fail()
        {
            Assert.That("Fail", Is.EqualTo(ControlMethods.Grade(25)));
        }
        [Test]

        public void GivenMark100_Gives_Fail()
        {
            Assert.That("Distinction", Is.EqualTo(ControlMethods.Grade(100)));
        }
        [Test]

        public void GivenMark65_Gives_Fail()
        {
            Assert.That("Pass", Is.EqualTo(ControlMethods.Grade(65)));
        }

        
    }
}