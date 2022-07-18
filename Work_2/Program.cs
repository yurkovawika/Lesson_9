//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int Prompt(string length) 
{
    System.Console.Write (length);
    return int.Parse(Console.ReadLine());
}

void SumNumbers(int n,int m)
{   
int sum = 0;
    for (n = n ; n <= m;n++)
    {
        sum =sum + n;
    }
    System.Console.Write($"Сумма чисел = {sum}");
}
int n = Prompt("Введите первое число: ");
int m = Prompt("Введите второе число: ");
SumNumbers(n,m);