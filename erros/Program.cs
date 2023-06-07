// See https://aka.ms/new-console-template for more information
using erros.Entities;
using erros.Entities.Exceptions;

try
{
    Console.WriteLine("Enter accout data");

    Console.WriteLine("type the number");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("type the holder");
    string name = Console.ReadLine();

    Console.WriteLine("type the initial balance");
    double balance = double.Parse(Console.ReadLine());

    Console.WriteLine("type the Withdraw limit: ");
    double limit = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine());

    Account account = new Account(number, name, balance, limit);
    account.withdraw(withdraw);

    Console.WriteLine($"New balance: {account.Balance}");
}
catch (InsufficientFunds e)
{
    Console.WriteLine(e.Message);
}
catch (ExceedTheLimit e)
{
    Console.WriteLine(e.Message);
}





