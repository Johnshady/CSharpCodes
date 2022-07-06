namespace Carclass
{
    class program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.Brand = "Toyota";
            Car1.Model = "Corolla s";
            Car1.Color = "Black";
            Car1.Petrol = true;
            Car1.Transmition = "Automatic";

            Console.WriteLine(Car1.Brand);

            Car Car2 = new Car();
            Car2.Brand = "Koenisegg";
            Car2.Model = "Agera";
            Car2.Color = "Red";
            Car2.Petrol = true;
            Car2.Transmition = "Manual";

            Console.WriteLine(Car2.Brand);

            Car Car3 = new Car("W motors", "Lykan", "Red", true, "Manual");

            Console.WriteLine(Car3.Brand);

        }
    }
}

