using System;
public class Program 
{
    public static void Main() 
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(fatorial(N));
    }

    public static int fatorial(int n)
    {
        if(n == 0 || n == 1) return 1;
        return n * fatorial(n-1);
    }
}
