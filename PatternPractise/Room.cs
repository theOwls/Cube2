using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractise
{
    public class Room
    { // Opening bracket of the class body
      // Field declaration

        public static int roomCoordsCounter;
        private int coordinates;
        private bool isGoalRoom;
        // Constructor declaration (peremeterless empty constructor)
        public Room()
        {
            roomCoordsCounter++;
            this.coordinates = roomCoordsCounter;
            

        }
        // Another constructor declaration
        public Room(int coordinates)
        {
            this.coordinates = coordinates;
            roomCoordsCounter++;
        }

        
        // Property declaration
        public int Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }
        // Method declaration (non-static)
        public void ShowCoordinates()
        {
            Console.WriteLine("coordinates are {0}",
         coordinates, "[coord]");
        }

        public bool SetGoalRoom()
        {
            this.isGoalRoom = true;
            return isGoalRoom;
        }

        public bool GetGoalRoom()
        {
            Console.WriteLine(isGoalRoom);
            return (isGoalRoom);
        }





    } // Closing bracket of the class body
}

