namespace readAndWriteFiles.Entities;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Qtd { get; set; }
    public Product(string name, double price, int qtd)
    {
        Name = name;
        Price = price;
        Qtd = qtd;
    }
    public double TotalValue()
    {
        return Price * Qtd;
    }
}