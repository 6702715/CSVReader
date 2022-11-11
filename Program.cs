
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("CSVReader v.0.0.1");
Console.ResetColor();

string path = @"/home/user/Projects/CSVReader/employees.csv";

if (File.Exists(path))
{
    using (StreamReader reader = new StreamReader(path))
    {
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
        }
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("The file " + path + " does not exist!");
    System.Console.WriteLine("");
    Console.ResetColor();
}
