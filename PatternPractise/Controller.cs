using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractise
{
    class Controller
    {
        public Controller()
        {
            //int firstRoomCoordinates = 0;
            //Console.Write("Enter first room coordinates: ");
            //firstRoomCoordinates = Convert.ToInt32(Console.ReadLine());

            //Room room1 = new Room(firstRoomCoordinates);

            //Room room2 = new Room();
            //Console.Write("Enter second room coordinates: ");
            //int secondRoomCoordinates = Convert.ToInt32(Console.ReadLine());
            // Using property to set the name of the dog
            //room2.Coordinates = secondRoomCoordinates;
            

            Room room1 = new Room();
            Room room2 = new Room();
            Room room3 = new Room();
            Room room4 = new Room();
            Room room5 = new Room();
            Room room6 = new Room();
            Room room7 = new Room();
            Room room8 = new Room();
           
            Room[] rooms = new Room[] { room1, room2 , room3, room4, room5, room6, room7, room8 };
            rooms[rooms.Length -1].SetGoalRoom();
            foreach (Room room in rooms)
            {
                room.ShowCoordinates();
                room.GetGoalRoom();
            }
            Sprite dude = new Sprite();

            dude.DudeCoordinates = dude.SetDudeCoordinates(rooms[0].Coordinates);
            Console.WriteLine(dude.DudeCoordinates);
            Console.WriteLine(rooms[0].Coordinates);

            


        }
    }
    
}
