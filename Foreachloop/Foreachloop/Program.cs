// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> list = new List<string>();
list.Add("Samuel");
list.Add("Esther");
list.Add("John");

foreach (var item in list)
{
    Console.WriteLine(item);
}