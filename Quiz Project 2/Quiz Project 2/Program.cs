// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<string, string> Quiz = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("Select your subject English Language, Mathematics, Physics, Chemistry");
    string op = Console.ReadLine();

    if (op == "English Language")
    {
        Console.WriteLine("You selected English Language");
        Console.WriteLine("1. How many vowels are there in the English Alphabet");
        Console.WriteLine("Select an option");

        Dictionary<int, string> Answer = new Dictionary<int, string>();
        Answer.Add(1, "5");
        Answer.Add(2, "26");
        Answer.Add(3, "7");
        Answer.Add(4, "19");

        for (int i = 1; i <= Answer.Count; i++)
            Console.WriteLine(Answer[i]);

        string number = Console.ReadLine();
        
     if (number == "5")
     {
        Console.WriteLine("Correct");
        Console.WriteLine("you scored 2 points");
     }

        else
        {
            Console.WriteLine("You failed");
        }
    }

    else if (op == "Mathematics")
    {
        Console.WriteLine("You selected Mathematics");
        Console.WriteLine("1. 100 % 75");
        Console.WriteLine("Select an option");

        Dictionary<int, string> Answer = new Dictionary<int, string>();
        Answer.Add(1, "5");
        Answer.Add(2, "25");
        Answer.Add(3, "7");
        Answer.Add(4, "19");

        for (int i = 1; i <= Answer.Count; i++)
            Console.WriteLine(Answer[i]);

        string number = Console.ReadLine();

        if (number == "25")
        {
            Console.WriteLine("Correct");
            Console.WriteLine("you scored 2 points");
        }

        else
        {
            Console.WriteLine("You failed");
        }
    }

    else if (op == "Chemistry")
    {
        Console.WriteLine("You selected Chemistry");
        Console.WriteLine("1. What is the chemical formula for water");
        Console.WriteLine("Select an option");

        Dictionary<int, string> Answer = new Dictionary<int, string>();
        Answer.Add(1, "H2");
        Answer.Add(2, "O2");
        Answer.Add(3, "H2O");
        Answer.Add(4, "O4");

        for (int i = 1; i <= Answer.Count; i++)
            Console.WriteLine(Answer[i]);

        string number = Console.ReadLine();

        if (number == "H2O")
        {
            Console.WriteLine("Correct");
            Console.WriteLine("you scored 2 points");
        }

        else
        {
            Console.WriteLine("You failed");
        }
    }

    else if (op == "Physics")
    {
        Console.WriteLine("You selected Physics");
        Console.WriteLine("1. What is ");
        Console.WriteLine("Select an option");

        Dictionary<int, string> Answer = new Dictionary<int, string>();
        Answer.Add(1, "H2");
        Answer.Add(2, "O2");
        Answer.Add(3, "H2O");
        Answer.Add(4, "O4");

        for (int i = 1; i <= Answer.Count; i++)
            Console.WriteLine(Answer[i]);

        string number = Console.ReadLine();

        if (number == "H2O")
        {
            Console.WriteLine("Correct");
            Console.WriteLine("you scored 2 points");
        }

        else
        {
            Console.WriteLine("You failed");
        }
    }


    else if (op == "English Language")
    {
        Console.WriteLine("You selected English Language");

        Console.WriteLine("Enter question number");
        string numberr = Console.ReadLine();

        Quiz.Add(numberr, numberr);
        Console.WriteLine("" + numberr + " sucessfully saved");



        Console.WriteLine("1. 100 % 75");
        Console.WriteLine("Select an option");

        Dictionary<int, string> Answer = new Dictionary<int, string>();
        Answer.Add(1, "5");
        Answer.Add(2, "25");
        Answer.Add(3, "7");
        Answer.Add(4, "19");

        for (int i = 1; i <= Answer.Count; i++)
            Console.WriteLine(Answer[i]);

        string number = Console.ReadLine();

        if (number == "25")
        {
            Console.WriteLine("Correct");
            Console.WriteLine("you scored 2 points");
        }

    }

}