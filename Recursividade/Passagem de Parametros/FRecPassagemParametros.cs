using System;
public class Program {
    public static void Main() 
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("RECURSIVA = " + funcREC(N,M));
    }

    public static int funcREC(int N, int M)
    {
        if(N == 1)  return M;
        
        return (N * M) + funcREC(N - 1, M); 
    }
}
