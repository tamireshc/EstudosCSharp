namespace erros.Entities.Exceptions;

public class InsufficientFunds : ApplicationException
{
    public InsufficientFunds(string message) : base(message) { }
}