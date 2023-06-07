namespace abstracao.Entities;

public class IndividualPerson : Person
{
    public double HealthExpenses { get; set; }
    public IndividualPerson(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
    {
        HealthExpenses = healthExpenses;
    }

    public override double TaxesPaid()
    {
        if (AnnualIncome < 20000) return (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
        return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
    }

    public override string ToString()
    {
        return $"{Name}: $ {TaxesPaid():F2}";
    }
}