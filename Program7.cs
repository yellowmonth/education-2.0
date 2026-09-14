using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double pervoe = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double vtoroe = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double third = double.Parse(Console.ReadLine());

            double avg = (pervoe + vtoroe + third) / 3;

            Console.WriteLine($"Среднее арифметическое: {avg:F2}");
        }
    }
}
