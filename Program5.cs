using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество секунд:  ");
            int seconds = int.Parse(Console.ReadLine());

            int hours = seconds / 3600;
            int minutes = ( seconds % 3600 ) / 60  ;
            int secondes = seconds % 60;

            Console.WriteLine($"Ваше : {hours} ч., {minutes} мин., {secondes} сек.");
         
        }
    }
}
