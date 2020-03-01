using MarsRovers.Rovers;
using Xunit;

namespace MarsRoversTests
{
    public class RoverTests
    {
        [Fact]
        public void BaseRoverDefaultValueTest()
        {
            // Base rover with no parameters should start at (0,0), facing north
            var rover = new Rover();
            Assert.True(rover.XCoordinate == 0 && rover.YCoordinate == 0 &&
                rover.Direction == MarsRovers.Direction.North);
        }

        [Fact]
        public void BaseRoverCoordinateTest()
        {
            // Base rover with coordinates should start with the given
            // coordinates, facing north
            var rover = new Rover(5, 10);
            Assert.True(rover.XCoordinate == 5 && rover.YCoordinate == 10 &&
                rover.Direction == MarsRovers.Direction.North);
        }
    }
}