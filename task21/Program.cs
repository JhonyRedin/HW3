// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] coordA = new int[3];
int[] coordB = new int[3];

System.Console.WriteLine("Введите начение точки X для коордниты A");
coordA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите начение точки Y для коордниты A");
coordA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите начение точки Z для коордниты A");
coordA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите начение точки X для коордниты B");
coordB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите начение точки Y для коордниты B");
coordB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите начение точки Z для коордниты B");
coordB[2] = Convert.ToInt32(Console.ReadLine());

double distance =Math.Round(Math.Sqrt(Math .Pow(coordA[0] - coordB[0], 2) + Math.Pow(coordA[1] - coordB[1], 2) + Math.Pow(coordA[2] - coordB[2], 2)),3);
System.Console.WriteLine($"Расстояние между точек: {distance}");