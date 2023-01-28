// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное чисо: ");
string? text = Console.ReadLine();
if (text!.Length == 5)
{
    if (text[0] == text[4] && text[1] == text[3])
    {
        System.Console.WriteLine($"{text} -> полиндром");
    }
    else System.Console.WriteLine($"{text} -> не полиндром");
}
else System.Console.WriteLine("Введено неверное число");