//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = ReadInt("Введите трехзначное число:");
int founder = number.ToString().Length;

if (founder < 3 || founder > 3)
{
    Console.WriteLine("Введите трехзначное число");

}
else
{
    Console.WriteLine(InCenter(number));

}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    int result = ((a / 10) % 10);
    return result;
}