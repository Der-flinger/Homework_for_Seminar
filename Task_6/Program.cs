﻿// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");           // Наше число 
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)                           // Проверка на четность
{
    Console.WriteLine("Число является четным");
    return;
}

else
{
    Console.WriteLine("Число является нечетным");
}