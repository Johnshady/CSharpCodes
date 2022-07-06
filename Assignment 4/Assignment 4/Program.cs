// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Dictionary<string, string> phonebook = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("What would u like to do SAVE, VIEW, UPDATE, DELETE");
    string op = Console.ReadLine();

    if (op == "SAVE")
    {
        Console.WriteLine("You entered SAVE");
        Console.WriteLine("Enter contact name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter contact number");
        string number = Console.ReadLine();

        phonebook.Add(name, number);
        Console.WriteLine("" + name + " sucessfully saved");
    }


    else if (op == "VIEW")
    {

        Console.WriteLine("You entered VIEW");
        Console.WriteLine("Enter contact name to view");
        string contactname = Console.ReadLine();
        if (phonebook.ContainsKey(contactname))
        {
            Console.WriteLine(phonebook[contactname]);
        }
        else
        {
            Console.WriteLine("Invalid contact");
        }

    }


    else if (op == "UPDATE")
    {

        Console.WriteLine("You entered UPDATE");
        Console.WriteLine("Enter contact name to update");
        string name = Console.ReadLine();
        Console.WriteLine("Enter new number  to update");
        string number = Console.ReadLine();
        phonebook[name] = number;
        Console.WriteLine(phonebook[name]);
        Console.WriteLine("Number updated sucessfully");

    }


    else if (op == "DELETE")
    {
        Console.WriteLine("You entered DELETE");
        Console.WriteLine("Enter contact name to delete");
        string name = Console.ReadLine();
        phonebook.Remove(name);
        Console.WriteLine("Number deleted sucessfully");
    }

    else
    {
        Console.WriteLine("Invalid command");
    }
}
