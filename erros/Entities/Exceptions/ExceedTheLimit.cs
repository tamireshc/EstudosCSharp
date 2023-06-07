namespace erros.Entities.Exceptions;

public class ExceedTheLimit : ApplicationException
{
    public ExceedTheLimit(string message) : base(message) { }
}