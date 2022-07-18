//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Prompt(string length) 
{
    System.Console.Write (length);
    return int.Parse(Console.ReadLine());
}
int Ackermann( int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }       
    else if ((m > 0) && (n == 0))
    {
        return Ackermann(m-1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ackermann(m-1, Ackermann(m, n-1));
    }
    else
    {
        return n + 1;
    }
}

int m = Prompt("Число m: ");
int n = Prompt("Число n: ");
if (n<0 || m<0)
{
    Console.WriteLine("Вы ввели отрицательное число");
}
else   Console.WriteLine(Ackermann(m,n));