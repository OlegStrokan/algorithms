namespace data_structures.files;
using System.IO;
using System.Text;

public class Files
{
    public void WriteToGile()
    {
        string file = Console.ReadLine();
        Console.WriteLine(File.ReadAllText(file));

        string line = Console.ReadLine();
        File.WriteAllText(file, line);
        Console.WriteLine(File.ReadAllText(file));
    }

    public void StreamsRead()
    {
        string name = "streams.txt";

        StreamReader sr = new StreamReader(name);
        
        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
    }
    
    public void StreamsWrite()
    {
        string name = "streams.txt";
        string text = Console.ReadLine();
        StreamWriter sr = new StreamWriter(name);
        sr.Write(text);
        Console.WriteLine(File.ReadAllText(name));
        sr.Close();
    }
}