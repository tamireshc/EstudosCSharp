using abstracao.Entities;

Console.WriteLine("Enter the number of tax payers:");
int numberTaxPlayers = int.Parse(Console.ReadLine());
List<Person> personsList = new List<Person>();
double totalTaxes = 0.0;

for (int i = 1; i <= numberTaxPlayers; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.WriteLine("Individual or company (i/c)?");
    char typeOfPayer = char.Parse(Console.ReadLine());

    if (typeOfPayer == 'i')
    {
        Console.WriteLine("Type the name");
        string name = Console.ReadLine();

        Console.WriteLine("Type the Annual Income");
        double annualIncome = double.Parse(Console.ReadLine());

        Console.WriteLine("Type the health expenses");
        double healthExpenses = double.Parse(Console.ReadLine());

        IndividualPerson individualPerson = new IndividualPerson(name, annualIncome, healthExpenses);
        personsList.Add(individualPerson);
    }
    else if (typeOfPayer == 'c')
    {
        Console.WriteLine("Type the name");
        string name = Console.ReadLine();

        Console.WriteLine("Type the Annual Income");
        double annualIncome = double.Parse(Console.ReadLine());

        Console.WriteLine("Type the number of employees");
        int numberEmployees = int.Parse(Console.ReadLine());

        CompanyPerson companyPerson = new CompanyPerson(name, annualIncome, numberEmployees);
        personsList.Add(companyPerson);
    }
    else
    {
        Console.WriteLine("incorrect option");
    }
}

foreach (Person person in personsList)
{
    totalTaxes += person.TaxesPaid();
    Console.WriteLine(person.ToString().ToString());
}

Console.WriteLine($"TOTAL TAXES: $ {totalTaxes}");