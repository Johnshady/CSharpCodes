// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hobbies Dictionary!");
Dictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "Making movies"); 
numberNames.Add(2, "Basket ball");
numberNames.Add(3, "Music");


/*foreach (KeyValuePair<int, string> kvp in numberNames)
	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
*/

var Names = new Dictionary<string, string>(){
	{"Samuel", "Football, Video games, Basket ball"},
	{"Patrick", "Eating, Basket ball, coding"},
	{"Isaac", "Sleeping, Reading, Analysis"}
};

foreach (var kvp in Names)
	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


for (int i = 1; i <= numberNames.Count; i++)
    Console.WriteLine(numberNames[i]);
