﻿class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um Número: ");

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int primeiro = i;
            int segundo = i * i;
            int terceiro = i * i * i;

            Console.WriteLine($"{primeiro} {segundo} {terceiro}");
        }
    }
}