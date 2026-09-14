using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите баланс мобильного телефона (руб.): ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите стоимость одной минуты разговора (руб.): ");
            double costOneMinute = Convert.ToDouble(Console.ReadLine());

            if (costOneMinute <= 0)
            {
                Console.WriteLine("Стоимость минуты должна быть больше нуля!");
                return;
            }

            int fullMinutes = (int)(balance / costOneMinute);

            Console.WriteLine($"Абоненту доступно полных минут разговора: {fullMinutes}");
        }
    }
}
