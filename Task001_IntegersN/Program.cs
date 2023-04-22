//  Задайте значение N. Напишите программу, которая выведет 
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int NumberN()
{
    System.Console.Write("Enter N: ");
    int N = int.Parse(Console.ReadLine());
    return N;
}

void PrintNum(int m)
{
if (m >= 1)
{
    Console.Write(m + " ");
    PrintNum(m-1);
}
}
PrintNum(NumberN());