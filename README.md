### Практическую работу №1 выполнил студент  группы П25-2.1. Бандурин Дмитрий
//  assets+ > screens >  md файл оформить как у С.М


```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача: Вычислите результат выражения int x = 17 / 5; int y = 17 % 5;. Ответ: x = 3, y = 2.
            int x = 17 / 5;
            int y = 17 % 5;
            Console.WriteLine("x = " + x);   
            Console.WriteLine("y = " + y);
        }
    }
}
```
---

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Каково значение res после выполнения int a = 5; int res = ++a * 2;? Ответ: res = 12 (префиксный инкремент увеличивает a до 6, затем умножение)
            int a = 5;
            int res = ++a * 2;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"res = {res}");
        }
    }
}

```
