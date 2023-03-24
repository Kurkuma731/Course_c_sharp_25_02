// Напишите программу, которая найдет точку пересечения двух прямых, заданных 
// уравнением  y=k1*x+b1, y=k2*x+b2; значенияии1бл1би2 и k2 задаются пользователем.

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine()); // считываем k1
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine()); // считываем b1
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine()); // считываем k2
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine()); // считываем b2

// вычисляем координаты точки пересечения двух прямых
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения: ({x}, {y})"); // выводим результат