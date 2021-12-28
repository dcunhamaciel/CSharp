public static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um Número entre 1 e 7: ");

        int x = int.Parse(Console.ReadLine());
        string day;

        switch (x)
        {
            case 1:
                day = "Sunday";
                break;
            case 2:
                day = "Monday";
                break;
            case 3:
                day = "Tuesday";
                break;
            case 4:
                day = "Wednesday";
                break;
            case 5:
                day = "Thursday";
                break;
            case 6:
                day = "Friday";
                break;
            case 7:
                day = "Saturday";
                break;
            default:
                day = "Invalid value";
                break;
        }
        Console.WriteLine("Day: " + day);
    }
}