using Interface.Entities;
using Interface.Service;

Console.WriteLine("Enter contract data");

Console.WriteLine("Enter the number");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the date dd/MM/yyyy");
DateTime date = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter the value");
double value = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the installments");
int installments = int.Parse(Console.ReadLine());

var contract = new Contract(number, date, value, installments);
var tax = new PaypalTax();

var servicePayment = new ServicePayment(tax, contract);

Console.WriteLine("Installments:");
servicePayment.GetInstallments();


