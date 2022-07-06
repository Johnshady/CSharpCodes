// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// C# program to illustrate how
// to create a dictionary

/*class GFG
{

	// Main Method
	static public void Main()
	{

		// Creating a dictionary
		// using Dictionary<TKey,TValue> class
		Dictionary<int, string> My_dict1 =
					new Dictionary<int, string>();

		// Adding key/value pairs
		// in the Dictionary
		// Using Add() method
		My_dict1.Add(1123, "Welcome");
		My_dict1.Add(1124, "to");
		My_dict1.Add(1125, "GeeksforGeeks");

		foreach (KeyValuePair<int, string> ele1 in My_dict1)
		{
			Console.WriteLine("{0} and {1}",
						ele1.Key, ele1.Value);
		}
		Console.WriteLine();

		// Creating another dictionary
		// using Dictionary<TKey,TValue> class
		// adding key/value pairs without
		// using Add method
		Dictionary<string, string> My_dict2 =
				new Dictionary<string, string>(){
								{"a.1", "Dog"},
								{"a.2", "Cat"},
								{"a.3", "Pig"} };

		foreach (KeyValuePair<string, string> ele2 in My_dict2)
		{
			Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
		}
	}
}
*/


/*
// Create a dictionary with string key and Int16 value pair
Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
AuthorList.Add("Music", 35);
AuthorList.Add("Eating", 25);
AuthorList.Add("Travelling", 29);
AuthorList.Add("Making movies", 21);
AuthorList.Add("Coding", 84);
// Count
Console.WriteLine("Count: {0}", AuthorList.Count);
// Set Item value
AuthorList["Neel Beniwal"] = 9;
if (!AuthorList.ContainsKey("Mahesh Chand"))
{
	AuthorList["Mahesh Chand"] = 20;
}
if (!AuthorList.ContainsValue(9))
{
	Console.WriteLine("Item found");
}
// Read all items
Console.WriteLine("Authors all items:");
foreach (KeyValuePair<string, Int16> author in AuthorList)
{
	Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
}
// Remove item with key = 'Mahesh Chand'
AuthorList.Remove("Mahesh Chand");
// Remove all items
AuthorList.Clear();


// Create a dictionary with string key and Int16 value pair
Dictionary < string, Int16 > AuthorList = new Dictionary < string, Int16 > ();
AuthorList.Add("Mahesh Chand", 35);
AuthorList.Add("Mike Gold", 25);
AuthorList.Add("Praveen Kumar", 29);
AuthorList.Add("Raj Beniwal", 21);
AuthorList.Add("Dinesh Beniwal", 84);
// Count
Console.WriteLine("Count: {0}", AuthorList.Count);
// Set Item value
AuthorList["Neel Beniwal"] = 9;
if (!AuthorList.ContainsKey("Mahesh Chand")) {
AuthorList["Mahesh Chand"] = 20;
}
if (!AuthorList.ContainsValue(9)) {
Console.WriteLine("Item found");
}
// Read all items
Console.WriteLine("Authors all items:");
foreach(KeyValuePair < string, Int16 > author in AuthorList) {
Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
}
// Remove item with key = 'Mahesh Chand'
AuthorList.Remove("Mahesh Chand");
// Remove all items
AuthorList.Clear();
*/
IDictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

//The following throws run-time exception: key already added.
//numberNames.Add(3, "Three"); 

foreach (KeyValuePair<int, string> kvp in numberNames)
	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

//creating a dictionary using collection-initializer syntax
var cities = new Dictionary<string, string>(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};

foreach (var kvp in cities)
	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);