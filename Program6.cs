using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Исходные значения: a = {a}, b = {b}");

            //  Способ первый: С использованием третьей переменной 
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"После обмена через третью переменную: a = {a}, b = {b}");

            // Способ второй: арифметический без третьей переменной 
            a = a + b;  
            b = a - b;  
            a = a - b;

            Console.WriteLine($"После обмена без третьей переменно: a = {a}, b = {b}");

        }
    }
}
