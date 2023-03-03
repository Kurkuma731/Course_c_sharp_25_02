//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int i;
Console.WriteLine("Введите число : ");
i = int.Parse(Console.ReadLine());

if (i % 2 == 1)
{
    Console.WriteLine("Число " + i + " Является : Нечетным");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Число " + i + " Является : Четным");
    Console.ReadLine();
}