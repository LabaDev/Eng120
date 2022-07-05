using OperatorsApp;

namespace UnitTests
{
    
    public class StoneTests
    {
        [Test]

        public void Given_156_Pounds_Gives_2Pounds()
        {
            var pounds = 156;
            var expected = 2;
            var result = Methods.GetPounds(pounds);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Given_156Pounds_Gives_11Stones()
        {
            Assert.That(Methods.GetStones(156), Is.EqualTo(11));
        }
    }
    


        

    

}