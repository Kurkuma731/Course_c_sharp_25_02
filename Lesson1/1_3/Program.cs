﻿// 3. Напишите программу, которая на вход принимает одно число
// (N) , а на выход показывет все целые в проемужтке от -N  до N.

string s_a = Console.ReadLine()!;

int a = int.Parse(s_a);

int b = -a;

while (b <= a)
{
    Console.Write(b+ " ");
    b++;
}