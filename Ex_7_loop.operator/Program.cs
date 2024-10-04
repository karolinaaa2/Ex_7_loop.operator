using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть максимальне число для послідовності Фібоначчі: ");
        int maxNumber = int.Parse(Console.ReadLine());

        int a = 0, b = 1, sum = 0, count = 0;

        while (a < maxNumber)
        {
            sum += a;
            count++;
            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"Сума чисел Фібоначчі, менших за {maxNumber}: {sum}");
        Console.WriteLine($"Кількість елементів: {count}");
    }
}

