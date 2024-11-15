
string fileDrirectoryPath = @"C:\Users\Lenovo\Desktop\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDrirectoryPath, fileName);

if (File.Exists(fullFilePath))
{
    Console.WriteLine($"File{fileName} exists in {fileName}");
}
else
{
    Console.WriteLine($"File{fileName} was not found");
}