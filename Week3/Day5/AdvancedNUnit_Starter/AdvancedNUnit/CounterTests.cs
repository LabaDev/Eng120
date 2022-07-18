using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    
    public class CounterTests
    {
        //private Counter _sut = new Counter(6);
        private Counter _sut;
        //[SetUp]
        //public void Instantiate_SUT()
        //{
        //    _sut = new Counter(6);
        //}

        public void CreateNewCounter()
        {
            _sut = new Counter(6);
        }
        [Test]
        public void Increment_IncreaseCountByOne()
        {
            CreateNewCounter();
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            CreateNewCounter();
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }
    }
}
