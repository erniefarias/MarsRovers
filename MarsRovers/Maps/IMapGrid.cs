namespace MarsRovers.Maps
{
    /// <summary>
    /// Represents a map grid with boundaries.
    /// </summary>
    public interface IMapGrid
    {
        /// <summary>
        /// Gets this map's width.
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Gets this map's height.
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Indicates whether the given coordinate point is within this map's
        /// boundaries.
        /// </summary>
        /// <param name="X">X coordinate</param>
        /// <param name="Y">Y coordinate</param>
        bool ContainsPoint(int X, int Y);
    }
}