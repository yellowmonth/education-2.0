using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Введите первое целое число: ");
            int name1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int name2 = int.Parse(Console.ReadLine());

            int sum = name1 + name2;

            Console.WriteLine($"Сумма: {sum}");

            int ruz = name1 - name2;
            Console.WriteLine($"Разность: {ruz}");

            int proz = name1 * name2;
            Console.WriteLine($"Произведение: {proz}");

            int ost = name1 % name2;
            Console.WriteLine($"Остаток от деления: {ost}");

            int quotient = name1 / name2;
            Console.WriteLine($"Целочисленное частное: {quotient}");

        }
    }
}