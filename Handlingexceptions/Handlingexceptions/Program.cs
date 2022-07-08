
try
{

    string num1;
    string num2;

    Console.WriteLine("Enter first number");
    num1 = Console.ReadLine();
    Console.WriteLine("Enter second number");
    num2 = Console.ReadLine();
    Console.WriteLine((decimal)int.Parse(num1) / int.Parse(num2));

}
catch(FormatException)
{
    Console.WriteLine("Only numbers allowed");
}

for (int i = 0; i <= 1000000000000; i++)
{
    Console.WriteLine(i);
}