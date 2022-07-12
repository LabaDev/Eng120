namespace HomeWorkTest
{
    public class Tests
    {
        

      
        [Test] public void WhenADefaultVehicleMovesTwiceItsPositionIs20() 
        { 
            Vehicle v = new Vehicle();
            var result = v.Move(2); 
            Assert.AreEqual(20, v.Position); 
            Assert.AreEqual("Moving along 2 times", result); 
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40); 
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed50IsMovedTwiceItsPositionIs100()
        {
            Vehicle v = new Vehicle(5, 50);
            var result = v.Move(2);
            Assert.AreEqual(100, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        //[Test]
        //public void WhenAVehicleWithNumOfPassengerMoreTHanCapacity_ThrowsError()
        //{
        //    Vehicle v = new Vehicle(3, 50);
        //    var result1 = v.NumOfPassengers = -2;
        //    var result2 = v.NumOfPassengers = 8;

        //    var result = v.Move(2);
        //    Assert.T
        //    Assert.AreEqual("Moving along 2 times", result);
        //}
    }   

}