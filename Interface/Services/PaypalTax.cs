namespace Interface.Service;

public class PaypalTax : ITax
{
    public double TaxPerPayment { get; set; } = 0.02;
    public double MensalTax { get; set; } = 0.01;
}