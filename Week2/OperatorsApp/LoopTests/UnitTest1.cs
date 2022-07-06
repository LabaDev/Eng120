using ControlFlowApp;


namespace LoopTests
{
    public class Tests
    {
        List<int> list1 = new List<int> { 1,6,9,2,14,50 };
        List<int> list2 = new List<int> { -1,-6,-9,-2,-14,-50 };
        List<int> list3 = new List<int> { -1,-6,9,-2,-14,-100,50,0, 100 };


        // For each loop
        [Test]
        public void Givenlist1_ForEachLoop_Returns_50()
        {
            Assert.That(50, Is.EqualTo(LoopTypes.HighestForEachLoop(list1)));
        }

        [Test]
        public void Givenlist1_ForEachLoop_Returns_Minus1()
        {
            Assert.That(-1, Is.EqualTo(LoopTypes.HighestForEachLoop(list2)));
        }

        [Test]
        public void Givenlist1_ForEachLoop_Returns_100()
        {
            Assert.That(100, Is.EqualTo(LoopTypes.HighestForEachLoop(list3)));
        }


        //For loop
        [Test]
        public void Givenlist1_ForLoop_Returns_50()
        {
            Assert.That(50, Is.EqualTo(LoopTypes.HighestForLoop(list1)));
        }

        [Test]
        public void Givenlist1_ForLoop_Returns_Minus1()
        {
            Assert.That(-1, Is.EqualTo(LoopTypes.HighestForLoop(list2)));
        }

        [Test]
        public void Givenlist1_ForLoop_Returns_100()
        {
            Assert.That(100, Is.EqualTo(LoopTypes.HighestForLoop(list3)));
        }

        //While loop
        [Test]
        public void Givenlist1_WhileLoop_Returns_50()
        {
            Assert.That(50, Is.EqualTo(LoopTypes.HighestWhileLoop(list1)));
        }

        [Test]
        public void Givenlist1_WhileLoop_Returns_Minus1()
        {
            Assert.That(-1, Is.EqualTo(LoopTypes.HighestWhileLoop(list2)));
        }

        [Test]
        public void Givenlist1_WhileLoop_Returns_100()
        {
            Assert.That(100, Is.EqualTo(LoopTypes.HighestWhileLoop(list3)));
        }

        //Do While loop
        [Test]
        public void Givenlist1_DoWhileLoop_Returns_50()
        {
            Assert.That(50, Is.EqualTo(LoopTypes.HighestDoWhileLoop(list1)));
        }

        [Test]
        public void Givenlist1_DoWhileLoop_Returns_Minus1()
        {
            Assert.That(-1, Is.EqualTo(LoopTypes.HighestDoWhileLoop(list2)));
        }

        [Test]
        public void Givenlist1_DoWhileLoop_Returns_100()
        {
            Assert.That(100, Is.EqualTo(LoopTypes.HighestDoWhileLoop(list3)));
        }

    }
}