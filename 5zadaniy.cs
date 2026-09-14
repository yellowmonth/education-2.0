using System;
class Program
{
    static void Main()
    {
        #region Первые пять заданий
        //Console.WriteLine("Введите ваше имя: ");
        //string name = Console.ReadLine();

        //Console.WriteLine("Введите ваш год рождения: ");
        //int birthYear = Convert.ToInt32(Console.ReadLine());

        //const int CurrentYear = 2026;
        //int age = CurrentYear - birthYear;

        //Console.WriteLine($"Здравствуйте, {name}! Ваш примерный возраст: {age} лет.");

        // -----

        //Console.Write("Введите ширину прямоугольника: ");
        //double width = double.Parse(Console.ReadLine());

        //Console.Write("Введите высоту прямоугольника: ");
        //double height = double.Parse(Console.ReadLine());

        //double area = width * height;
        //double perimeter = 2 * (width + height);

        //Console.WriteLine($"Площадь: {area:F2}");
        //Console.WriteLine($"Периметр: {perimeter:F2}");

        // ----------

        //const double Pi = 3.141592653589793;

        //Console.Write("Введите радиус круга: ");
        //double radius = Convert.ToDouble(Console.ReadLine());

        //double circumference = 2 * Pi * radius;
        //double area = Pi * radius * radius;

        //Console.WriteLine($"Длина окружности: {circumference:F3}");
        //Console.WriteLine($"Площадь круга: {area:F3}");

        // ------------

        //Console.Write("Введите число с плавающей точкой: ");
        //double originalValue = Convert.ToDouble(Console.ReadLine());

        //// Явное усечение дробной части
        //int truncatedValue = (int)originalValue;

        //// Явное сужение диапазона
        //byte byteValue = (byte)truncatedValue;

        //Console.WriteLine($"Исходное значение (double): {originalValue}");
        //Console.WriteLine($"После приведения к int: {truncatedValue}");
        //Console.WriteLine($"После приведения к byte (переполнение при > 255): {byteValue}");

        // -----------------


        #endregion

        const decimal UsdToRubRate = 84.25m;

        Console.Write("Введите сумму в долларах США (USD): ");
        decimal dollars = decimal.Parse(Console.ReadLine());

        decimal rubles = dollars * UsdToRubRate;

        Console.WriteLine($"Сумма в рублях: {rubles:C2}");
    }
}