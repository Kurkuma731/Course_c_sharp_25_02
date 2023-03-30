// Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        PrintEvenNumbers(m, n);

        Console.ReadKey();
    }

    static void PrintEvenNumbers(int m, int n)
    {
        if (m <= n)
        {
            if (m % 2 == 0)
            {
                Console.Write(m + " ");
            }

            PrintEvenNumbers(m + 1, n);
        }
    }
}