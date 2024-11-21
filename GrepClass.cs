using Newtonsoft.Json;
public class GrepClass
{
 /*    public string Class_fileDirectory { get; set; }

    GrepClass(string class_fileDirectory)
    {
        Class_fileDirectory = class_fileDirectory;
    }*/
    public string Deserialize()
    {
        Console.WriteLine("Enter a txt file in the project directory with its extension");
        string? Input = Console.ReadLine();
        string InputCheck = string.IsNullOrWhiteSpace(Input) ? "Text.txt" : Input;
        string TextFile = File.ReadAllText(InputCheck);
        return TextFile;
    }
}
