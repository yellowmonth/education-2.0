using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr0gram4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            int dlina = int.Parse(Console.ReadLine());

            int volume = dlina * dlina * dlina;
            Console.WriteLine($"Объём куба:{volume}  ");

            int square = dlina * dlina * 6;
            Console.WriteLine($"Площадь куба: {square}");
        }
    }
}
