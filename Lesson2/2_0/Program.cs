// 1. Напишите программу которая принимает на вход 
// Трехзнначное число и на выходе показывает
// Последнюю цифру этого числа.
int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);