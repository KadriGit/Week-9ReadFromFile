
string fileDrirectoryPath = @"C:\Users\Lenovo\Desktop\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDrirectoryPath, fileName);

ReadFromFile(fullFilePath);

static void DisplayDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

static void ReadFromFile(string filePath)
{
    if (File.Exists(filePath))
    {
        String[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines in the file.");

        DisplayDataFromArray(tempArray);
    }
    else
    {
        Console.WriteLine($"File was not found");
    }
}