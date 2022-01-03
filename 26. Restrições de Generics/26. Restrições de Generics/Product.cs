using System.Globalization;

class Product : IComparable
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public int CompareTo(object obj)
    {
        if (!(obj is Product))
        {
            throw new ArgumentException("Comparing error: argument is not an Product");
        }
        Product other = obj as Product;
        return Price.CompareTo(other.Price);
    }

    public override string ToString()
    {
        return Name
            + ", "
            + Price.ToString("F2", CultureInfo.InvariantCulture);
    }
}