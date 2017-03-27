using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest2
{
    class Controller
    {
        public Controller()
        {
            getReady();
            BuildGame();
            

        }

        public void BuildGame()
        {
            Console.WriteLine("Creating first room");
            System.Threading.Thread.Sleep(1000);
            Room room1 = new Room(1);

            Console.WriteLine("Creating second room");
            System.Threading.Thread.Sleep(1000);
            Room room2 = new Room(2);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Creating the player");
            Sprite player = new Sprite();

            
            Console.WriteLine("Setting Goal Room");
            System.Threading.Thread.Sleep(1000);
            room2.SetGoalRoom();

            
            Console.WriteLine("Querying first room");
            System.Threading.Thread.Sleep(1000);
            room1.GoalRoomQuery();

            
            Console.WriteLine("Querying second room");
            System.Threading.Thread.Sleep(1000);
            room2.GoalRoomQuery();
        }

        public void getReady()
        {
            Console.WriteLine("Welcome to the Cube");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Your skills will be tested. You are in room 1");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("There are 6 doors, choose a door.");

        }

        public void TestGoalRoom()
        {

        }
    }
}
