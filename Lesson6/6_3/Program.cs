// Не используя рекурсию , выведите первые N чисел Фибоначи.
//Перва два числа Фибоначи : 0  и 1.

void Fibnch (int num)
{
int A = 0;
int B = 1;
for (int i = 0; i < num; i++){
Console.Write(A+" ");
(A, B) = (B, A+B);
}
}
int G = int.Parse(Console.ReadLine()!);
Fibnch(G);