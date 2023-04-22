//  Задайте значения M и N. Напишите программу, которая найдёт сумму 
//  натуральных элементов в промежутке от M до N.

int GetNum(string arg)
{
    System.Console.Write($"Enter {arg}: ");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int PrintNum(int m, int n)
{
    if (m < n) return PrintNum(m + 1, n) + m;        
    else return m;
}
System.Console.WriteLine($"Sum of int = {PrintNum(GetNum("N"), GetNum("M"))}");  

 