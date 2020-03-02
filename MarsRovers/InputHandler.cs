using System;
using MarsRovers.Maps;
using MarsRovers.Rovers;

namespace MarsRovers
{
    /// <summary>
    /// Provides methods corresponding to user inputs
    /// </summary>
    public static class InputHandler
    {

        public static MapGrid CreateMap(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Dimensions not provided", nameof(input));
            else if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Unexpected input. Dimensions must be" +
                    " separated by a space");

            string[] parts = input.Split(' ');
            int width = int.Parse(parts[0]);
            int height = int.Parse(parts[0]);

            return new MapGrid(width, height);
        }

        public static MappedRover CreateRover(IMapGrid map, string input)
        {
            if (map == null)
                throw new ArgumentNullException(nameof(map));
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Coordinates not provided", nameof(input));
            else if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Unexpected input. X coordinate, Y" +
                    " coordinate, and direction must be separated by a space");

            string[] parts = input.Split(' ');
            int xCoordinate = int.Parse(parts[0]);
            int yCoordinate = int.Parse(parts[1]);

            // Verify coordinates
            if (!map.ContainsPoint(xCoordinate, yCoordinate))
            {
                Console.WriteLine("Rover could not be created at given coordinates");
                return null;
            }

            // Parse direction (default to North)
            char directionChar = parts[2][0];
            Direction direction = Direction.North;

            if (directionChar == 'W')
                direction = Direction.West;
            else if (directionChar == 'E')
                direction = Direction.East;
            else if (directionChar == 'S')
                direction = Direction.South;

            return new MappedRover(map, xCoordinate, yCoordinate, direction);
        }

        public static string CommandRover(MappedRover rover, string input)
        {
            if (rover == null)
                throw new ArgumentNullException(nameof(rover));
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Commands not provided", nameof(input));

            foreach (char command in input)
            {
                if (command == 'M')
                    rover.TryMoveForward();
                else if (command == 'L')
                    rover.TurnLeft();
                else if (command == 'R')
                    rover.TurnRight();
            }

            char directionChar = rover.Direction.ToString()[0];
            string status = $"{rover.XCoordinate} {rover.YCoordinate} {directionChar}";
            return status;
        }
    }
}
