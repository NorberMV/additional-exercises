
using System;

class Program
{
    private static void Main(string[] args)
    {
        int maxNum = 15;
        int cont = 0;
        int num = 1;
        Console.WriteLine("Este programa imprime los primeros 15 numeros primos!\n");

        while (cont < maxNum)
        {
            if (!IsPrime(num))
            {
                // No es primo, continuar.
                num++;
                continue;
            }
            // Es primo, imprimir
            Console.WriteLine(num);
            // Incremetar el numero
            num++;
            cont++;

        }
    }
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}