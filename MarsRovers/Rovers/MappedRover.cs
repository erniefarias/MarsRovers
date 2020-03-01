using System;
using MarsRovers.Maps;

namespace MarsRovers.Rovers
{
    /// <summary>
    /// Represents a rover that is positioned on a map
    /// </summary>
    public class MappedRover : Rover
    {
        /// <summary>
        /// The instance of a map that this rover is moving on.
        /// </summary>
        private IMapGrid _map;

        /// <summary>
        /// Initializes an instance of the <see cref="MappedRover"/> class on
        /// the given map. The rover will start at the southwest corner of the
        /// map.
        /// </summary>
        /// <param name="map">Map to place rover on</param>
        public MappedRover(IMapGrid map)
        {
            _map = map;
        }

        /// <summary>
        /// Moves the rover forward, when possible.
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public override void MoveForward()
        {
            if (CanMoveForward())
                base.MoveForward();
            else
                throw new InvalidOperationException("Rover cannot move forward" +
                    " due to the boundaries on its map.");
        }

        /// <summary>
        /// Attempts to move the rover forward; returns true is successful;
        /// </summary>
        public bool TryMoveForward()
        {
            try
            {
                MoveForward();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Indicates whether the rover can move forward without crossing the
        /// map's boundaries.
        /// </summary>
        public bool CanMoveForward()
        {
            int newX = XCoordinate;
            int newY = YCoordinate;

            // Set the coordinates to what they'll be if the rover moves forward
            if (Direction == Direction.South)
                newY++;
            else if (Direction == Direction.South)
                newY--;
            else if (Direction == Direction.West)
                newX--;
            else if (Direction == Direction.East)
                newY++;

            // Check if the map contains the new point
            return _map.ContainsPoint(newX, newY);
        }
    }
}