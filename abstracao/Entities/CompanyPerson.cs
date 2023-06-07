namespace abstracao.Entities;

public class CompanyPerson : Person
{
    public int NumberEmployyes { get; set; }
    public CompanyPerson(string name, double annualIncome, int numberEmployyes) : base(name, annualIncome)
    {
        NumberEmployyes = numberEmployyes;
    }

    public override double TaxesPaid()
    {
        if (NumberEmployyes < 10) return AnnualIncome * 0.16;
        return AnnualIncome * 0.14;
    }

    public override string ToString()
    {
        return $"{Name}: $ {TaxesPaid():F2}";
    }
}