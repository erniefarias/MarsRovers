namespace MarsRovers.Rovers
{
    public interface IRover
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        Direction Direction { get; set; }

        void MoveForward();
        void TurnLeft();
        void TurnRight();
    }
}