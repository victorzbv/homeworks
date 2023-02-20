//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.Read.Line()!);
int num = 10;
int num2 = num %100;
int num3 = num2 % 10;
Console.WriteLine(num2);
Console.WriteLine(num3);

if(num % 100 == num )
{
Console.WriteLine(num + " -> третьей цифры нет ");

}
else
{
    Console.WriteLine(num + " ->  " + num3); 
}