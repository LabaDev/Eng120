using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    
    public class CounterTests
    {
        private Counter _sut = new Counter(6);

        [Test]
        public void Increment_IncreaseCountByOne()
        {
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }
    }
}
