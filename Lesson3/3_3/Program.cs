// Напишите программу , которая принимает на вход число(N)
// И выдает таблицу квадратов чисел от 1 до N.

void Kvad(int num){
    for(int i = 0; 1<=num; i++){
        Console.WriteLine(i * i +" ,");
    }
}
int x = int.Parse(Console.ReadLine()!);
Kvad(x);