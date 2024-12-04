using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try {
               
                Console.WriteLine("Введите адрес здания");
                string a = Console.ReadLine();
                Console.WriteLine("Введите длину здания");
                int l =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину здания");
                int w = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите высоту здания");
                int h = Convert.ToInt32(Console.ReadLine());

                Building building = new Building(a,l,w,h);
                Console.WriteLine(building.Print()); 

                Console.WriteLine("Введите адрес мультиздания");
                string a_m = Console.ReadLine();
                Console.WriteLine("Введите длину мультиздания");
                int l_m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ширину мультиздания");
                int w_m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите высоту мультиздания");
                int h_m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите этажность мультиздания");
                int f_m = Convert.ToInt32(Console.ReadLine());

                MultiBuilding multiBuilding=new MultiBuilding(a_m,l_m, w_m, h_m, f_m);
                Console.WriteLine(multiBuilding.Print()); 
            }
            catch  (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            }
    }
}
