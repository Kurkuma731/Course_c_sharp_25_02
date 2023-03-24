// Напишите программу , которая задает массив из 8 элементов случайными числами
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции
//(пригодится в следующих задачах)

int[] arr = GenerateRandomArray(8);
    Console.WriteLine("Сгенерированный массив: ");
    PrintArray(arr);


  static int[] GenerateRandomArray(int size) {
    int[] arr = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++) {
      arr[i] = rand.Next(100); // генерируем случайное число от 0 до 99
    }

    return arr;
  }

  static void PrintArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
      Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
  }