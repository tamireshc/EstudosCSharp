using readAndWriteFiles.Entities;
using System.Globalization;

string path = @"/Users/tamireshc/Desktop/CursoCSharp/readAndWriteFiles/source.csv";
string outPath = @"/Users/tamireshc/Desktop/CursoCSharp/readAndWriteFiles/out/summary.csv";

List<Product> listProducts = new List<Product>();

try
{
    string[] lines = File.ReadAllLines(path);
    foreach (string line in lines)
    {
        var productDetails = line.Split(";");
        var product = new Product(productDetails[0], double.Parse(productDetails[1], CultureInfo.InvariantCulture), int.Parse(productDetails[2]));
        listProducts.Add(product);

    }
    Console.WriteLine(listProducts[0].Name);
    Console.WriteLine(listProducts[1].Price);

    Directory.CreateDirectory(@"/Users/tamireshc/Desktop/CursoCSharp/readAndWriteFiles/out");

    using (StreamWriter sw = File.AppendText(outPath))
    {
        foreach (Product product in listProducts)
        {
            sw.WriteLine($"{product.Name};{product.TotalValue()}");
            Console.WriteLine($"product:{product.Name};{product.TotalValue()}");
        }
    }

}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
