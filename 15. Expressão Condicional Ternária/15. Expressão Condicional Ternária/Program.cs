public class Program
{
    public static void Main(string[] args)
    {
        double preco = 34.5;
        double desconto;

        if (preco < 20.0)
        {
            desconto = preco * 0.1;
        }
        else
        {
            desconto = preco * 0.05;
        }

        double precoTernaria = 34.5;
        double descontoTernaria = (precoTernaria < 20.0) ? precoTernaria * 0.1 : precoTernaria * 0.05;

        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Preço Ternária: " + precoTernaria);
    }
}