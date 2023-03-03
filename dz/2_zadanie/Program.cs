//4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа : ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (max < num_3) 
{
    max = num_2;
}

if (max < num_3)
{
    max = num_3;
}

Console.WriteLine("Наибольшее из введенных чисел -> " + max);
