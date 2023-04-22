//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

int GetNum(string arg)
{
    int a;
    System.Console.Write($"Enter {arg}: ");
    while(!int.TryParse(Console.ReadLine(), out a) || a < 0)
    {
        System.Console.WriteLine("It's not a number or incorrect data!");
        System.Console.WriteLine();
        System.Console.Write($"Enter {arg}: ");
    }
    return a;
}

int AkkermanFunc(int m, int n)
{
    if(m == 0) return n + 1;
    else
    {
        if((m != 0) && (n == 0)) return AkkermanFunc(m -1, 1);
        else return AkkermanFunc(m - 1, AkkermanFunc(m, n -1));
    }
}
System.Console.WriteLine($"Result = {AkkermanFunc(GetNum("N"), GetNum("M"))}");