namespace MarsRovers.Maps
{
    public interface IMapGrid
    {
        int Width { get; }
        int Height { get; }
        bool ContainsPoint(int X, int Y);
    }
}