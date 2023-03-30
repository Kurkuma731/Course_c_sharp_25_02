// Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumNaturalNumbers(m, n);
        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", m, n, sum);

        Console.ReadKey();
    }

    static int SumNaturalNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }

        return m + SumNaturalNumbers(m + 1, n);
    }
}