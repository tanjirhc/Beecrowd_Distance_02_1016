using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_Distance_02_1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, distance;

            x = int.Parse(Console.ReadLine());

            distance = (x *2);

            Console.WriteLine("{0} minutos", distance);
            Console.ReadKey();
        }
    }
}
