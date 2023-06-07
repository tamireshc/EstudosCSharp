using erros.Entities.Exceptions;

namespace erros.Entities;

public class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }

    public double WithdrawLimit { get; set; }

    public Account(int number, string holder, double balance, double withdrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withdrawLimit;
    }

    public void deposit(double value)
    {
        Balance += value;
    }

    public void withdraw(double value)
    {
        if (value > Balance) throw new InsufficientFunds("Withdraw error: Not enough balance");
        if (value > WithdrawLimit) throw new ExceedTheLimit("Withdraw error: The amount exceeds withdraw limit");
        Balance -= value;
    }
}