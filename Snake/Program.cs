using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Points p1 = new Points();
            p1.x = 1;
            p1.y = 3;
            p1.symb = '!';
            p1.Draw();

            Points p2 = new Points();
            p2.x = 4;
            p2.y = 5;
            p2.symb = '$';
            p2.Draw();
                     
            Console.ReadLine();

        }

    }
}
