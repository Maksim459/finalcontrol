using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int SumOfElements(int[] array)
    {
        return array.Sum();
    }

    static void Main()
    {
        int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int totalSum = SumOfElements(numbersArray);
        Console.WriteLine($"Сумма: {totalSum}");

 
        List<int> evenNumbersList = numbersArray.Where(x => x % 2 == 0).ToList();
        Console.WriteLine($"Четные числа: {string.Join(", ", evenNumbersList)}");
    }
}
