using OperatorsApp;

namespace UnitTests
{
    
    public class StoneTests
    {

        //PoundToStone
        [Test]

        public void Given_156_Pounds_Gives_2Pounds()
        {
            var pounds = 156;
            var expected = 2;
            var result = Methods.GetPounds(pounds);
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(-1)]
        [TestCase(-100)]
        public void GivenNegativeValueTo_GetStones_ThrowsOutOfRangeException(int pound)
        {
            Assert.That(() => Methods.GetStones(pound), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("The value of totalPound is negative"));
        }


        // Pound to pound after stones

        [Test]
        public void Given_156Pounds_Gives_11Stones()
        {
            Assert.That(Methods.GetStones(156), Is.EqualTo(11));
        }

        [TestCase(-1)]
        [TestCase(-100)]
        public void GivenNegativeValueTo_GetPound_ThrowsOutOfRangeException(int pound)
        {
            Assert.That(() => Methods.GetPounds(pound), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("The value of totalPound is negative"));
        }
    }
    


        

    

}