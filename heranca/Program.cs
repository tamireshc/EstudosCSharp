using System;
using Heranca.Entities;

namespace Heranca
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number of Products");
      int nProducts = int.Parse(Console.ReadLine());

      List<Product> list = new List<Product>();

      for (int i = 1; i <= 3; i++)
      {
        Console.WriteLine($"Product {i}");
        Console.WriteLine("Comom, used, or imported? (c/u/i)");
        string typeProduct = Console.ReadLine();

        if (typeProduct == "c")
        {
          Console.WriteLine("Digite o nome");
          string name = Console.ReadLine();
          Console.WriteLine("Digite o Preco");
          double price = double.Parse(Console.ReadLine());
          Product custom = new Product(name, price);
          list.Add(custom);
        }

        if (typeProduct == "u")
        {
          Console.WriteLine("Digite o nome");
          string name = Console.ReadLine();
          Console.WriteLine("Digite o Preco");
          double price = double.Parse(Console.ReadLine());
          Console.WriteLine("Digite o a data de manufatura");
          DateTime date = DateTime.Parse(Console.ReadLine());
          UsedProduct usedProduct = new UsedProduct(name, price, date);
          list.Add(usedProduct);
        }

        if (typeProduct == "i")
        {
          Console.WriteLine("Digite o nome");
          string name = Console.ReadLine();
          Console.WriteLine("Digite o Preco");
          double price = double.Parse(Console.ReadLine());
          Console.WriteLine("Digite a taxa");
          double tax = double.Parse(Console.ReadLine());
          ImportedProduct importedProduct = new ImportedProduct(name, price, tax);
          list.Add(importedProduct);
        }
      }
      Console.WriteLine("PRICE TAGS:");
      for (int j = 0; j < nProducts; j++)
      {
        Console.WriteLine(list[j].PriceTag());
      }


    }
  }
}
