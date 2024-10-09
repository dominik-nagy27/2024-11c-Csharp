using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100,
                y = 11;

            Console.WriteLine($"Az 1. iratás x={x} kiírása előtt:{x++}");
            Console.WriteLine($"A 2.iratás y={x} kiírása előtt:++y = {x++}");
            Console.WriteLine($"Az 1. iratás y={y} kiírása előtt:{y++}");
            Console.WriteLine($"A 2.iratás y={y} kiírása előtt:++y = {y++}");
            Console.ReadKey();


        }
    }
}
