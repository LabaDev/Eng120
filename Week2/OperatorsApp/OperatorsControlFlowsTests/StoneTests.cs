using OperatorsApp;

namespace OperatorsControlFlowsTests
{
    public class StoneTests
    {
        [Test]
        public void Given_156_pounds_Gives_2Pounds()
        {
            var pounds = 156;
            var expected = "11 stones and 2 pounds";
            var result = Methods.GetPounds(pounds);
            Assert.That(result, Is.EqualTo(expected))
        }


    }

}