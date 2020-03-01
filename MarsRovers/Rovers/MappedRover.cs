using System;
using MarsRovers.Maps;

namespace MarsRovers.Rovers
{
    public class MappedRover : Rover
    {
        private IMapGrid _map;

        public MappedRover(IMapGrid map)
        {
            _map = map;
        }

        public override void MoveForward()
        {
            if (CanMoveForward())
                base.MoveForward();
            else
                throw new Exception("Cannot move forward due to map boundaries");
        }

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
