using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les13
{
    class Building
    {
        //поля
        string adress;
        int length;
        int width;
        int height;
        //свойства
        public string Adress
        { 
        get { return adress; } 
        set { adress = value; }
        }

        public int Length
        {
            get { return length; }
            set 
            {
                if (value <= 0)
                    length = 0;
                else length = value;
            }
        }
        public int Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                    width = 0;
                else width = value;
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                    height = 0;
                else height = value;
            }
        }

        //конструктор
        public Building(string adress, int length, int width, int height)
        {
        this.Adress = adress;
        this.Length = length;
        this.Width = width;
        this.Height = height;
        }

        //метод
        public string Print()
        {
            return $"{Adress} {Length} {Width} {Height}";
        }
    }
}
