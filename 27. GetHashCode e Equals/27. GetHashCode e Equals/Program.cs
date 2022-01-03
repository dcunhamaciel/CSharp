public class Program
{
    public static void Main(string[] args)
    {
        Client a = new Client { Name = "Alex", Email = "alex@gmail.com" };
        Client b = new Client { Name = "Maria Flávia", Email = "maria@gmail.com" };
        Client c = new Client { Name = "Maria Luiza", Email = "maria@gmail.com" };

        Console.WriteLine("a.Equals(b) = " + a.Equals(b));
        Console.WriteLine("b.Equals(c) = " + b.Equals(c));

        Console.WriteLine();

        Console.WriteLine("a.GetHashCode() = " + a.GetHashCode());
        Console.WriteLine("b.GetHashCode() = " + b.GetHashCode());
        Console.WriteLine("c.GetHashCode() = " + c.GetHashCode());
    }
}