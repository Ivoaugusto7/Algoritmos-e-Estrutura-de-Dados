using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string texto = Console.ReadLine();
        string Texto = Regex.Replace(texto, @"[^a-zA-Z0-9]", "").ToLower();

        if (string.IsNullOrEmpty(Texto))
        {
            Console.WriteLine("SIM");
            return;
        }

        if (Palindromo(Texto, 0, Texto.Length - 1))
            Console.WriteLine("SIM");
        else
            Console.WriteLine("NAO");
    }

    static bool Palindromo(string texto, int i, int j)
    {
        if (i >= j)
            return true;

        if (texto[i] != texto[j])
            return false;

        return Palindromo(texto, i + 1, j - 1);
    }
}
