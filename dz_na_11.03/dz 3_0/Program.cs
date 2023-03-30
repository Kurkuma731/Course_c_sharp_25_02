//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
int[] digits = new int[5]; // создаем массив для хранения цифр числа 
int temp = number;

for (int i = 0; i < 5; i++){
    digits[i] = temp % 10; // Сохраняем последнюю чифру числа в массиве
    temp /= 10; // удаляем последнюю цифру из числа 
}

bool isPalindrome = true;

for (int i = 0; i < 2; i++){
    if (digits[i] != digits[4-i]){
        isPalindrome = false;
        break;
    }
}

if (isPalindrome){
    Console.WriteLine("Число является палиндромом.");
}
else{
    Console.WriteLine("Число не является палиндромом.");

}
Console.ReadKey();