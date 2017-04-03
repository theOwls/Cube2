using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPractise
{
    class Sprite
    {
        
        private string name;
        public int DudeCoordinates;
        

        public Sprite()
        {
            this.name = "Dan";
            this.DudeCoordinates = 1;
        }

        public int SetDudeCoordinates(int value)
        {
            this.DudeCoordinates = value;
            return DudeCoordinates;
        }



        
    }
}
