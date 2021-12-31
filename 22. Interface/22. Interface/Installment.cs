using System.Globalization;
public class Installment
{
    public DateTime DueDate { get; private set; }
    public double Amout { get; private set; }

    public Installment(DateTime dueDate, double amout)
    {
        DueDate = dueDate;
        Amout = amout;
    }

    public override string ToString()
    {
        return DueDate.ToString("dd/MM/yyyy") + " - " + Amout.ToString("F2", CultureInfo.InvariantCulture);
    }
}