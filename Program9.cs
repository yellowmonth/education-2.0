using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость товара: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Введите процент скидки (от 0 до 100): ");
            decimal skidka = decimal.Parse(Console.ReadLine());

            if (skidka < 0 || skidka > 100)
            {
                Console.WriteLine("$Введите: от 0 до 100.");
                return;
            }

            decimal sumskidka = price * skidka / 100m;
            decimal finalny = price - skidka;

            Console.WriteLine($"Сумма скидки: {sumskidka:F2}");
            Console.WriteLine($"Итоговая цена: {finalny:F2}");

        }
    }
}
