using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les13
{
    class MultiBuilding:Building
    {
        int floor;

        public int Floor { get; set; }

        public MultiBuilding(string adress, int length, int width, int height, int floor)
            :base(adress, length, width, height)
        { this.Floor = floor; }
        
        public string Print()
        { 
        string str=base.Print();
            str += $" {Floor}";
            return str;
        }

    }
}
