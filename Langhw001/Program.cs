﻿// Большее из двух чисел

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Большее число:" +a+ ",меньшее число:" +b);
}
else 
{
    Console.WriteLine("Большее число:" +b+ ",меньшее число:" +a);
}
