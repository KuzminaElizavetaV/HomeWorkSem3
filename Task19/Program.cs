﻿/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!

14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine();
Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 10000 > 0 && num / 10000 < 10)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
    {
        Console.WriteLine($"{num} -> да");
    }
    else Console.WriteLine($"{num} -> нет");
}
else Console.WriteLine("Вы ввели не пятизначное число!!!");
Console.WriteLine();