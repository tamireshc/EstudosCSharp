namespace Heranca.Entities;

public class UsedProduct : Product
{
  public DateTime ManufatureDate { get; set; }

  public UsedProduct() { }

  public UsedProduct(string name, double price, DateTime manufatureDate)
    : base(name, price)
  {
    ManufatureDate = manufatureDate;
  }

  public override string PriceTag()
  {
    return base.PriceTag() + "(used)" + $"Manufature date: {ManufatureDate.ToString()}";
  }

}