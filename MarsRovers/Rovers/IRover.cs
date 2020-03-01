namespace MarsRovers.Rovers
{
    /// <summary>
    /// Represents a rover that can move or rotate.
    /// </summary>
    public interface IRover
    {
        /// <summary>
        /// Gets or sets the X coordinate (North/South).
        /// </summary>
        int XCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate (West/East).
        /// </summary>
        int YCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the direction this rover is facing.
        /// </summary>
        Direction Direction { get; set; }

        /// <summary>
        /// Moves the rover forward.
        /// </summary>
        void MoveForward();

        /// <summary>
        /// Makes the rover turn left 90 degrees.
        /// </summary>
        void TurnLeft();

        /// <summary>
        /// Makes the rover turn right 90 degrees.
        /// </summary>
        void TurnRight();
    }
}