namespace Heranca.Entities;

public class ImportedProduct : Product
{
  public double CustomFee { get; set; }

  public ImportedProduct() { }

  public ImportedProduct(string name, double price, double customFee)
    : base(name, price)
  {
    CustomFee = customFee;
  }

  public override string PriceTag()
  {
    Price += CustomFee;
    return base.PriceTag() + $" (Customs fee: $ {CustomFee})";
  }

}