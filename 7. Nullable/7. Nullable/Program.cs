class Program
{
    static void Main(string[] args)
    {
        double? x = null;
        double? y = 10.0;

        Console.WriteLine(x.GetValueOrDefault());
        Console.WriteLine(y.GetValueOrDefault());
        Console.WriteLine(x.HasValue);
        Console.WriteLine(y.HasValue);

        if (x.HasValue)
            Console.WriteLine(x.Value);
        else
            Console.WriteLine("X is null");
        if (y.HasValue)
            Console.WriteLine(y.Value);
        else
            Console.WriteLine("Y is null");

        double? a = null;
        double? b = 10.4;
        
        double c = a ?? 0.0;
        double d = b ?? 0.0;

        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
    }
}