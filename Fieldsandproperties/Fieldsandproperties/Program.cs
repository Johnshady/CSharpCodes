namespace Fieldsandproperties
{
    class Program
    {
        static void Main(String[] args)
        {
            Car cars = new Car();
            cars.SpeedProperty = 5000;
            cars.WheelsProperty = 5;
            cars.color = "black";

            Console.WriteLine(cars.SpeedProperty);
            Console.WriteLine(cars.WheelsProperty);
        }
    }
}