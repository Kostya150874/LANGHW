﻿// Задача 13. Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет

int Prompt(string msg)
{
    Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Ведите число: ");

int fnumber(int number)
{
    while(number > 999)
{
    number /=10;
}
    return number % 10;
}
bool check(int number);
{
    if (number < 100)
    return false;
    return true;
}
if (check(number) ! = true);
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($ "Третья цифра числа {number} является {fnumber(number)}");