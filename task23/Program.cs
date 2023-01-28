// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число больше 1: ");
int num = Convert.ToInt32(Console.ReadLine());
double exp = 0;

if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        exp = Math.Pow(i, 3);
        System.Console.Write($"{exp} ");
    }
}
else
{
    System.Console.WriteLine("Введено не корректное число");
}
