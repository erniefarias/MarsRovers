using MarsRovers;
using MarsRovers.Rovers;
using Xunit;

namespace MarsRoversTests
{
    public class RoverTests
    {
        [Fact]
        public void NoParameterInitializeTest()
        {
            // Base rover with no parameters should start at (0,0), facing north
            var rover = new Rover();
            Assert.True(rover.XCoordinate == 0 && rover.YCoordinate == 0 &&
                rover.Direction == Direction.North);
        }

        [Fact]
        public void CoordinateAndDirectionInitializeTest()
        {
            // Base rover with coordinates and direction should start with the
            // given coordinates and direction
            var rover = new Rover(6, 12, Direction.West);
            Assert.True(rover.XCoordinate == 6 && rover.YCoordinate == 12 &&
                rover.Direction == Direction.West);
        }

        [Fact]
        public void TurnLeftTest()
        {
            var rover = new Rover();
            rover.Direction = Direction.West;
            rover.TurnLeft();
            Assert.True(rover.Direction == Direction.South);
        }

        [Fact]
        public void TurnRightTest()
        {
            var rover = new Rover();
            rover.TurnRight();
            rover.TurnRight();
            rover.TurnRight();
            Assert.True(rover.Direction == Direction.West);
        }

        [Fact]
        public void MoveFowardAndTurnRightTest()
        {
            var rover = new Rover();
            rover.MoveForward();
            rover.MoveForward();
            rover.TurnRight();
            rover.MoveForward();
            Assert.True(rover.XCoordinate == 1 && rover.YCoordinate == 2 &&
                rover.Direction == Direction.East);
        }
    }
}