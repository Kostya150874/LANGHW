﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string msg)
{
   Console.WriteLine($"{msg}");
   return Convert.ToInt32(Console.ReadLine()); 
}
    int number = Prompt("Введите трехзначное число: ");
    if (number >= 100 && number < 100);
{
    int mid = (number % 100 - number % 10)/10;
    Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}

