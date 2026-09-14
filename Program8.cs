using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние (в метрах): ");
            // траим число, если неверное - пишем что число некорректно
            if (!double.TryParse(Console.ReadLine(), out double distancemetre))
             {
                    Console.WriteLine("Некорректное значение расстояния.");
                    return;
            }

            Console.Write("Введите время (в секундах): ");
            // траим число, если неверное - пишем что число некорректно
            if (!double.TryParse(Console.ReadLine(), out double timeinseconds))
            {
                Console.WriteLine("Некорректное значение времени.");
                return;
            }

            // прооверка на время , которое не может быть физически равно 0
            if (timeinseconds == 0)
            {
                Console.WriteLine($"Время не может быть равно нулю.");
            }

            double speedKilomHour = (distancemetre / 1000.0) / (timeinseconds / 3600.0);

            Console.WriteLine($"Скорость движения: {speedKilomHour:F2} км/ч");
        }
    }
}
