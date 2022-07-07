using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;
using System;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {     
        // write unit test(s) for MyMethod here
        //Average

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }



        [Test]
        public void WhenListIsEmpty_Average_ThrowsAnDivisionByZeroError()
        {
            var myList = new List<int>() {};
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<DivideByZeroException>().With.Message.Contain("List is empty!"));
        }

        //Ticket Type

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }


        [TestCase(-1)]
        [TestCase(150)]
        public void GivenOutOfBoundValue_TicketType_ThrowsAnArgumentOutOfRangeException(int age)
        {
            Assert.That(() => Exercises.TicketType(age), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Age is out of range."));
        }


        //Grade
        [Test]
        public void GivenMarks_Returns_Grades()
        {
            var mark1 = 89;
            Assert.That(Exercises.Grade(mark1), Is.EqualTo("Distinction"));
        }


        [TestCase(-1)]
        [TestCase(101)]
        public void GivenOutOfBoundValue_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Mark is out of range."));
        }


        // Scottish wedding
        [TestCase(-1)]
        [TestCase(150)]
        public void GivenOutOfBoundValue_GetScottishMaxWeddingNumbers_ThrowsAnArgumentOutOfRangeException(int covidLevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Covid level is out of range"));
        }

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3,50)]
        [TestCase(4,20)]

        public void GivenValidValues_Covid_GetScottishMaxWeddingNumbers_GivesCasesForLevel(int covidLevel, int result)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(covidLevel), Is.EqualTo(result));
        }

    }
}
