// Напишите цикл , который принимает на вход два числа (А и В) и возводит
// число А в натуральную степень В.

Console.WriteLine("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите степень В: ");
int b = Convert.ToInt32(Console.ReadLine());

double result = 1;

for (int i = 0; i < b; i++){
    result *=a;
}

Console.WriteLine("Результат: " + result);