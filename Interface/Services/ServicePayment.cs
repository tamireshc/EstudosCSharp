using Interface.Entities;

namespace Interface.Service;

public class ServicePayment
{
    public ITax ServiceTax { get; set; }
    public Contract Contract { get; set; }

    public ServicePayment(ITax serviceTax, Contract contract)
    {
        ServiceTax = serviceTax;
        Contract = contract;
    }

    private List<double> InstallmentsValues()
    {
        List<double> installmentsValuesList = new List<double>();
        var baseParcel = Contract.Value / Contract.Installments;

        for (int i = 1; i <= Contract.Installments; i++)
        {
            var installmentValue = baseParcel * (1 + (ServiceTax.MensalTax * i)) * (1 + ServiceTax.TaxPerPayment);
            installmentsValuesList.Add(installmentValue);
        }
        return installmentsValuesList;
    }

    public void GetInstallments()
    {
        var installmentsValuesList = InstallmentsValues();
        for (int i = 1; i <= Contract.Installments; i++)
        {
            Console.WriteLine($"{Contract.Date.AddMonths(i):dd/MM/yyyy} - {installmentsValuesList[i - 1]}");
        }
    }
}