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
            //Запросите у пользователя два целых числа. Выведите их сумму, разность, произведение, а также целочисленное частное и остаток от деления.

            Console.Write("Введите первое целое число: ");
            int name1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int name2 = int.Parse(Console.ReadLine());

            double sum = name1 + name2;

            Console.WriteLine($"Сумма: {sum}");

            double ruz = name1 / name2;
            Console.WriteLine($"Разность: {ruz}");

            double proz = name1 * name2;
            Console.WriteLine($"Произведение: {proz}");

            // Остаток от деления

            double ost = name1 % name2;
            Console.WriteLine($"Остаток от деления: {ost}");
            // осталось допилить целочисленное частное ????

            // Вычисление и вывод целочисленного частного
            int quotient = name1 / name2;
            Console.WriteLine($"Целочисленное частное: {name1} / {name2} = {quotient}");


            // 16 и 18 строка должно быть  double name{} = double.parse
            // 38 строка int quiotinent доделать
        }
    }
}
