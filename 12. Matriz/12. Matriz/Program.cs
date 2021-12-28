class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o Número de Linhas e Colunas: ");

        string[] line = Console.ReadLine().Split(' ');
        int m = int.Parse(line[0]);
        int n = int.Parse(line[1]);

        int[,] mat = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Digite {n} Números para a Linha {i + 1}: ");

            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }

        Console.Write("Digite o Número para ser Localizado: ");

        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] == x)
                {
                    Console.WriteLine("Position " + i + "," + j + ":");
                    if (j > 0)
                    {
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                    }
                    if (j < n - 1)
                    {
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                    }
                    if (i < m - 1)
                    {
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}