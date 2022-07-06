namespace ExceptionsDataTypesTests
{
    public class Tests
    {
       

        [TestCase(-1)]
        [TestCase(-100)]
        public void WhenMarkIsLessThanZero_Grade_ThowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("\nMark: " + mark + "\nAllowed Range: 0 - 100"));
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void WhenMarkIsLessThanZero_Grade_ThowsAnArgumentOutOfRangeGeneralException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.InstanceOf<Exception>());
        }

        [TestCase(1000)]
        [TestCase(150)]
        [TestCase(101)]
        public void WhenMarkIsMoreThan100_Grade_ThowsAnArgumentOutOfRangeGeneralException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => Program.Grade(mark), Throws.InstanceOf<Exception>());
        }
    }
}