﻿using Miapo_Rybalkin;

Functions functions = new();

double a = 0;
double b = 0;

Console.WriteLine("Введите первое число: ");
a = double.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите второе число: ");

b = double.Parse(Console.ReadLine() ?? string.Empty);

 //Вызов функции Multiplication с помощью try-catch
    try
    {
        Console.WriteLine($"Результат {functions.Multiplication(a, b)}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e);
    }


