class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Soma: " + Calculator.Sum(10, 20 , 30 ,40));

        int a = 10;
        Calculator.Triple(ref a);
        Console.WriteLine("Triplo ref: " + a);

        int triple;
        Calculator.Triple(a, out triple);
        Console.WriteLine("Triplo out: " + triple);
    }
}