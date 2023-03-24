// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

        Console.WriteLine("Введите координаты первой точки (x1 y1 z1):");
        string[] point1 = Console.ReadLine().Split(' '); // вводим координаты первой точки

        Console.WriteLine("Введите координаты второй точки (x2 y2 z2):");
        string[] point2 = Console.ReadLine().Split(' '); // вводим координаты второй точки

        double x1 = double.Parse(point1[0]);
        double y1 = double.Parse(point1[1]);
        double z1 = double.Parse(point1[2]);

        double x2 = double.Parse(point2[0]);
        double y2 = double.Parse(point2[1]);
        double z2 = double.Parse(point2[2]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine("Расстояние между двумя точками: " + distance);

        Console.ReadKey();