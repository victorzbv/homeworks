// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру дня недели: ");
int weekday = int.Parse(Console.ReadLine()!);

if (weekday == 6 || weekday == 7)
{
    Console.WriteLine(weekday + " -> Отдых!");

}

else
{
    Console.WriteLine(weekday + " -> Опять работа!");

}
