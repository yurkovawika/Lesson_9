﻿// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int Prompt(string length) 
{
    System.Console.Write (length);
    return int.Parse(Console.ReadLine());
}

void PrintNumbers (int n,int m)
{   
    if (n <= m)
    {
        
        System.Console.Write($"{n}'");
        PrintNumbers (n+1,m);
    }
    
}
int n = Prompt("Введите первое число: ");
int m = Prompt("Введите второе число: ");
PrintNumbers(n,m);