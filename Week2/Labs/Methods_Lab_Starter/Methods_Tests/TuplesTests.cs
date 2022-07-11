using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [Test]
        public void GivenANegativeNumber_PowerRoot_ThrowsAnException()
        {
            Assert.That(() => Methods.PowerRoot(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("number cannot be negative"));
        }
        [TestCase(1,1, 1, 1.0)]
        [TestCase(4,16, 64, 2.0)]
        public void GivenANumber_PowerRoot_GivesAnswer(
            int number, int square, int cube, double root)
        {
            var answer = Methods.PowerRoot(number);
            Assert.That(answer.square, Is.EqualTo(square));
            Assert.That(answer.cube, Is.EqualTo(cube));
            Assert.That(answer.root, Is.EqualTo(root));
        }
    }
}