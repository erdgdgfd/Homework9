// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            PrintNaturalNumbers(n);
        }
        else
        {
            Console.WriteLine("N должно быть больше или равно 1.");
        }
    }

    static void PrintNaturalNumbers(int n)
    {
        if (n > 1)
        {
            Console.Write(n + " ");
            PrintNaturalNumbers(n - 1);
        }
        else
        {
            Console.Write("1");
        }
    }
}