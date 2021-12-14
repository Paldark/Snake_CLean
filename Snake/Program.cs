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
           Points p1 = new Points(1,3,'@');
                  p1.Draw();

            Points p2 = new Points(4,5,'*');
                   p2.Draw();
                     
            Console.ReadLine();

        }

    }
}
