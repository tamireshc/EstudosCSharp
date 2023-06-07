namespace abstracao.Entities;

public abstract class Person
{
    public string Name { get; set; }
    public double AnnualIncome { get; set; }
    public Person() { }
    public Person(string name, double annualIncome)
    {
        Name = name;
        AnnualIncome = annualIncome;
    }

    public abstract double TaxesPaid();
}