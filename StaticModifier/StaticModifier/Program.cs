namespace StaticModifier
{
    class program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();

            Console.WriteLine(Car.numberofcars);
            Car.addcars();
        }
    }
}
