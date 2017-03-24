using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game");
            Controller start = new Controller();
            start.getReady();
        }
    }
}
