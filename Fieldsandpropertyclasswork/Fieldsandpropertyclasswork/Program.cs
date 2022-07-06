namespace Fieldsandpropertyclasswork
{
    class Program
    {
        static void Main(String[] args)
        {
            Human humans = new Human();
            humans.EyeproPerty = 1;
            humans.TeethproPerty = 9;
            humans.legproPerty = 1;
            humans.color = "fair";

            Console.WriteLine(humans.EyeproPerty);
            Console.WriteLine(humans.legproPerty);
            Console.WriteLine(humans.TeethproPerty);
            Console.WriteLine(humans.color);
        }
    }
}