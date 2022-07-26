using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ;

namespace LINQ
{
    internal class program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1, Name="Isama Michael", Email="isamamichael2005@gmail.com"},
                 new Employee(){Id=1, Name="Adikwu Maria", Email="marigoldperi294@gmail.com"},
                  new Employee(){Id=1, Name="Olofu Emmanuel", Email="emacoolofu@gmail.com"}
            };

            var selectMethod = employees.SelectMany(emp => emp.Name).ToList();

            var ms



            Console.ReadLine();
           
        }
    }
}
