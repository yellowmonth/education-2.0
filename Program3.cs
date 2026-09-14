using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру в градусах Цельсия: ");
            double celsis = Convert.ToDouble(Console.ReadLine());
            
            // основные переменные (celsis and farengeit), их и буду исп. ниже

            double farengeit = celsis * 9 / 5 + 32;

            Console.WriteLine($"Температура в градусах Фаренгейта: {farengeit}");
        }
    }
}
