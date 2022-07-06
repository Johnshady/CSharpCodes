// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//static int MyMethod(int x)
//{
//    return  x * x * x;
//}

//Console.WriteLine(MyMethod(10));





//DateTime now = DateTime.Now;

//Console.WriteLine(now.ToString("ddd MMM %d, yyyy"));
//Console.WriteLine(now.ToString("hh:mm:ss tt"));






//static void AddMethod()
//{
//    DateTime now = DateTime.Now;
//    Console.WriteLine("Today is " + now.ToString("ddd") + " and the time is " + now.ToString("hh:mm:ss tt") + " the year " + now.ToString("yyyy"));

//}
//AddMethod();



static int maxmethod(int x, int y)
{
   

    if (y > x)
    {
        return y;
    }
    else if (y < x)
    {
        return x;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine(maxmethod(50, 40));


