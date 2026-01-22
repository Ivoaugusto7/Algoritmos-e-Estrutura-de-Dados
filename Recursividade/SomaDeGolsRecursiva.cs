using System;
public class Program {
    public static void Main() 
    {
        string []entrada = Console.ReadLine().Split(" ");
        int m = int.Parse(entrada[0]);
        int n = int.Parse(entrada[1]);

        golREC(m, n,"");
    }

    public static void golREC(int m, int n, string ordem)  // 3 , 1
    {
            if (m == 0 && n == 0) 
            {
                Console.WriteLine(ordem); 
                return;
            }    
          
            if(m > 0)
            {
                golREC(m-1 , n, ordem + "A ");     
            } 

            if (n > 0)
            {
                golREC(m, n-1, ordem + "B ");
            } 
            
    }
}
