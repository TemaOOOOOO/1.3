using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
        var result = numbers.Where(x => x < 0 && x % 2 == 0).Reverse();
        Console.WriteLine("Парные отрицательные числа в обратном порядке:");
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}

