class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite um número: ");

        int N = int.Parse(Console.ReadLine());

        if (N % 2 == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("IMPAR");
        }
    }
}