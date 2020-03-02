using System;
using System.IO;
using MarsRovers.Maps;
using MarsRovers.Rovers;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = AppDomain.CurrentDomain.BaseDirectory + "Input.txt";

            try
            {
                var fileLines = File.ReadLines(inputFile).GetEnumerator();

                // Use the first line to create the map
                fileLines.MoveNext();
                MapGrid map = InputHandler.CreateMap(fileLines.Current);

                MappedRover rover = null;

                while (fileLines.MoveNext())
                {
                    string input = fileLines.Current;

                    if (rover == null)
                    {
                        rover = InputHandler.CreateRover(map, input);
                    }
                    else
                    {
                        string status = InputHandler.CommandRover(rover, input);
                        Console.WriteLine(status);
                        rover = null;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Input file could not be processed: {e.Message}");
            }
        }
    }
}