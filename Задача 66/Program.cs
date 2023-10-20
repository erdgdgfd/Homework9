// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        if (m <= n)
        {
            int sum = CalculateSumOfNaturalNumbers(m, n);
            Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {sum}");
        }
        else
        {
            Console.WriteLine("M должно быть меньше или равно N.");
        }
    }

    static int CalculateSumOfNaturalNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }

        return n + CalculateSumOfNaturalNumbers(m, n - 1);
    }
}