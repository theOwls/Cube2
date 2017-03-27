using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest2
{
    class Room
    {
        private int coordinates;
        private bool isGoalRoom;

        public Room(int coordinates)
        {
            this.coordinates = coordinates;
            
        }

        public void GoalRoomQuery()
        {
            if (isGoalRoom)
            {
                Console.WriteLine("This is the goal room");
            }
            else
            {
                Console.WriteLine("This is not the goal room");

            }
        }

        public void SetGoalRoom()
        {
            this.isGoalRoom = true;
        }

        
    }
}
