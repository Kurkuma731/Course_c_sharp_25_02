// Задача 2 : Напишите программу , которая на вход принимает два числа и выдает , 
//какое число большее , а какое меньшее.

    {
 
        int a, b;
 
        Console.WriteLine("Введите два числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} наибольшее число", a);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} наибольшее число ", b);
 
        }
 
        Console.ReadLine();
 
    }