using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest2
{
    class Sprite
    {
        private int currentRoom;

        public Sprite()
        {
            this.currentRoom = 1;
        }

        public void ShowLocation()
        {
            Console.WriteLine("The player is currently in room {0}.", currentRoom);
        }

        public void ChangeCoordinates(int nextRoom)
        {
            this.currentRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("You are now in room {0}", this.currentRoom);
        }


    }
}
