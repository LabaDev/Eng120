namespace HomeWorkTest
{
    public class AirplaneTests
    {



        [Test]
        public void WhenADefaultAirplaneWithNoSpeed_Ascends300meters_ItsAltitudeIs300()
        {
            Airplane a = new Airplane(200) { NumOfPassengers = 150 };
            a.Ascend(300);
            var result = a.Move();

            Assert.AreEqual(300, a.Altitude);
            Assert.AreEqual($"Moving along at an altitude of 300 meters.", result);
        }

        [Test]
        public void WhenADefaultAirplane_Ascends1000mthenDescends500m_ItsAltitudeIs500()
        {
            Airplane a = new Airplane(200) { NumOfPassengers = 150 };
            a.Ascend(1000);
            a.Descend(500);
            var result = a.Move();

            Assert.AreEqual(500, a.Altitude);
            Assert.AreEqual($"Moving along at an altitude of 500 meters.", result);
        }

        [Test]
        public void WhenAAirplaneMovesTrice_PlaneMoves3Times()
        {
            Airplane a = new Airplane(200,100,"Jets") { NumOfPassengers = 150 };
            a.Ascend(1000);
            a.Descend(500);
            var result = a.Move(3);

            Assert.AreEqual(500, a.Altitude);
            Assert.AreEqual($"Moving along 3 times at an altitude of 500 meters.", result);
        }

        [TestCase(-3)]
        public void WhenAAirplaneMovesNegativeAmountOfTimes_ThrowsArgumentError(int times)
        {
            Airplane a = new Airplane(200, 100, "Jets") { NumOfPassengers = 150 };
                    
                      
            Assert.That(()=> a.Move(times), Throws.TypeOf<ArgumentException>().With.Message.Contain("Cannot move backwards!"));
        }
        
    }
}