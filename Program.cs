using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите вашу Фамилию: ");
        string surname = Console.ReadLine();

        Console.WriteLine("Введите ваше имя: ");
        string name = Console.ReadLine();

        Console.WriteLine("Введите ваше отчество: ");
        string patronymic = Console.ReadLine();

        Console.WriteLine($"Ваше Фамилия И.О {surname} {name[0]}. {patronymic[0]}.");
    }
}

// БЛОК №1 , ЗАДАНИЕ №1 П25-2.1 БАНДУРИН