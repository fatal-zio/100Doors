using System;
using _100Doors.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _100Doors
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_DOORS = 100;
            var doors = new List<Door>();
            var sb = new StringBuilder();

            //create collection of doors
            for (var i = 0; i < NUMBER_OF_DOORS; i++)
            {
                doors.Add(new Door(i + 1));
            }

            //outer loop, for each iterator
            for (var i = 0; i < NUMBER_OF_DOORS; i++)
            {
                Iterate(i + 1, ref doors);
            }

            var openDoors = doors.Where(o => o.Open).ToList();

            sb.AppendLine($"Number of open doors: {openDoors.Count}");

            foreach (var openDoor in openDoors)
            {
                sb.Append($"{openDoor.DoorNumber}, ");
            }

            Console.Write(sb.ToString());
            Console.ReadKey();
        }

        private static void Iterate(int modulus, ref List<Door> doors)
        {
            var index = 1;
            foreach (var door in doors)
            {
                if (index % modulus == 0)
                {
                    door.ToggleOpen();
                }

                index++;
            }
        }
    }
}
