using System;
public class Program {
    public static void Main() 
    {
        int N = int.Parse(Console.ReadLine());

        VddREC(N, "");
    }

    public static void VddREC(int N, string num )
    {

        if (N == 0) 
            {
                Console.WriteLine(num); 
                return;
            }    

            VddREC(N - 1, num + "0 ");
            VddREC(N - 1, num + "1 ");
    }
}
