namespace Interface.Entities;
public class Contract
{
    public int Number { get; set; }
    public DateTime Date { get; set; }
    public double Value { get; set; }
    public int Installments { get; set; }

    public Contract(int number, DateTime date, double value, int installments)
    {
        Number = number;
        Date = date;
        Value = value;
        Installments = installments;
    }
}