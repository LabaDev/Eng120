namespace StringCalculatorTest
{
    public class Tests
    {
        

        [Test]
        public void GivenNothingToCalculator_ReturnsZero()
        {
            Assert.That(Program.Calculator(""), Is.EqualTo(0));
        }

        [Test]
        public void GivenInputAsOne_Calculator_ReturnsOne()
        { 
            Assert.That(Program.Calculator("1"), Is.EqualTo(1));
        }

        [Test]
        public void GivenInputAsOneAndTwo_Calculator_ReturnsThree()
        {
            Assert.That(Program.Calculator("1,2"), Is.EqualTo(3));
        }

        [Test]
        public void GivenInputAsOne_Slash_NTwoThree_Calculator_ReturnsSix()
        {
            Assert.That(Program.Calculator("1\n2,3"), Is.EqualTo(6));
        }

        [Test]
        public void GivenInputAsOne_Slash_N_Calculator_Returns0()
        {
            Assert.That(Program.Calculator("1,\n"), Is.EqualTo(0));
        }

        
        [Test]
        public void GivenInputAsSlashSlashDelimiterSlashNOneAndTwo_N_Calculator_Returns3()
        {
            Assert.That(Program.Calculator("//;\n1;2"), Is.EqualTo(3));
        }

        [Test]
        public void GivenInputAsNegativeNumbersOrNumber_Calculator_ThrowsArgumentError()
        {
            Assert.That(() => Program.Calculator("//;\n1;-2"), Throws.TypeOf<ArgumentException>().With.Message.Contains("Negative Numbers not Allowed!"));
        }

        [Test]
        public void GivenInputAsHundred_Calculator_Retruns100()
        {
            Assert.That(() => Program.Calculator("100"), Is.EqualTo(100));
        }

        [Test]
        public void GivenInputAsHundredAnd200_Calculator_Retruns300()
        {
            Assert.That(() => Program.Calculator("100,,,,,;;;;200"), Is.EqualTo(300));
        }


        [Test]
        public void GivenInputAs1001And2_Calculator_Retruns2()
        {
            Assert.That(() => Program.Calculator("1001,,,,,;;;;2"), Is.EqualTo(2));
        }

        [Test]
        public void GivenInputAs1001And2000_Calculator_Retruns0()
        {
            Assert.That(() => Program.Calculator("1001,,,,,;;;;2000"), Is.EqualTo(0));
        }

        [Test]
        public void GivenInputAs999And999_Calculator_Retruns1998()
        {
            Assert.That(() => Program.Calculator("999,999"), Is.EqualTo(1998));
        }

        [Test]
        public void GivenMultipleDelimitersAsInputWithNumbersOneTwoAndThree_Calculator_Retruns6()
        {
            Assert.That(() => Program.Calculator("//[***]\n1***2***3"), Is.EqualTo(6));
            Assert.That(() => Program.Calculator("//[*][%]\n1*2%3"), Is.EqualTo(6));
        }

        
    }

}