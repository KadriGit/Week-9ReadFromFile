
string fileDrirectoryPath = @"C:\Users\Lenovo\Desktop\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDrirectoryPath, fileName);

if (File.Exists(fullFilePath))
{
    Console.WriteLine($"File{fileName} exists in {fileName}");
   String[] chuckJokes =  File.ReadAllLines(fullFilePath);
    Console.WriteLine($"There are {chuckJokes.Length} jokes about chuck Norris in the filr.");

    foreach(string joke in chuckJokes)
    {
        Console.WriteLine(joke);
    }
}
else
{
    Console.WriteLine($"File{fileName} was not found");
}