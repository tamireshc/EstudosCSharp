Console.WriteLine("Total Voutes");
string path = "/Users/tamireshc/Desktop/CursoCSharp/dictionary/in.txt";

Dictionary<string, int> candidates = new Dictionary<string, int>();
StreamReader sr = null;
try
{
    sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(",");
        string name = line[0];
        int voute = int.Parse(line[1]);
        if (!candidates.ContainsKey(name))
        {
            candidates[name] = voute;
        }
        else
        {
            candidates[name] += voute;
        }
    }
    foreach (var item in candidates)
    {
        Console.WriteLine($"{item.Key} : {item.Value}");
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();
}


