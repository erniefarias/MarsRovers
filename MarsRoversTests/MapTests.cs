using MarsRovers;
using MarsRovers.Maps;
using Xunit;

namespace MarsRoversTests
{
    public class MapTests
    {
        [Fact]
        public void ValidCoordinateTest()
        {
            // 10x12 map should have coordinate (1,12)
            var map = new MapGrid(10, 12);
            Assert.True(map.ContainsPoint(1, 12));
        }

        [Fact]
        public void InvalidCoordinateTest()
        {
            // 6x10 map should not have coordinate (10,6)
            var map = new MapGrid(6, 10);
            Assert.False(map.ContainsPoint(10, 6));
        }
    }
}