using MarsRovers;
using MarsRovers.Rovers;
using Xunit;

namespace MarsRoversTests
{
    public class HandlerTests
    {
        [Fact]
        public void CreateMapTest()
        {
            // Map should be created with the given dimensions
            var map = InputHandler.CreateMap("5 10");
            Assert.True(map.Width == 5 && map.Height == 10);
        }

        [Fact]
        public void CreateRoverTest()
        {
            // Rover should start with the given coordinates and direction
            var map = InputHandler.CreateMap("5 5");
            var rover = InputHandler.CreateRover(map, "3 2 E");
            Assert.True(rover.XCoordinate == 3 && rover.YCoordinate == 2 &&
                rover.Direction == Direction.East);
        }

        [Fact]
        public void CommandRoverTest()
        {
            var map = InputHandler.CreateMap("5 5");
            var rover = InputHandler.CreateRover(map, "1 2 N");
            string result = InputHandler.CommandRover(rover, "LMLMLMLMM");
            Assert.Equal<string>("1 3 N", result);
        }
    }
}