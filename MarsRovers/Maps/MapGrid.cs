namespace MarsRovers.Maps
{
    public class MapGrid : IMapGrid
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapGrid"/> class with
        /// the given dimensions.
        /// </summary>
        /// <param name="width">Grid width</param>
        /// <param name="height">Grid height</param>
        public MapGrid(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public virtual bool ContainsPoint(int X, int Y)
        {
            return X >= 0 && X <= Width && Y >= 0 && Y <= Height;
        }
    }
}
