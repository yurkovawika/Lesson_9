//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от N до M с помощью рекурсии.
int Prompt(string length) 
{
    System.Console.Write (length);
    return int.Parse(Console.ReadLine());
}

int SumNumbers(int n,int m,int sum)
{  
    if (n <= m)
    {
    sum = sum+n;
    n++;
    sum = SumNumbers(n,m,sum );
    }
    return sum;
}
int n = Prompt("Введите первое число: ");
int m = Prompt("Введите второе число: ");
int sum = SumNumbers(n,m,0);
System.Console.Write($"Сумма чисел от {n} + {m} = {sum}");

