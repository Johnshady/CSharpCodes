using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperationsinLinq
{
    class program
    {
        static void Main(string[] args)
        {

            // Distinct set operator

            List<student> students = new List<student>()
            {
                new student(){ Id = 1, Name = "John"},
                new student(){ Id = 2, Name = "Kim"},
                new student(){ Id = 3, Name = "John"},
                new student(){ Id = 4, Name = "Mark"}
            };

            var ms = students.Select(x => x.Name).Distinct().ToList();



            //List <int> numbers = new List<int>() { 1,2,3,1,2,3,4,3,4,5,5,5,5};

            //var ms = numbers.Distinct().ToList();

            //var qs = (from num in numbers select num).Distinct().ToList();


            // Except set operator

            //List<string> datasource1 = new List<string>() { "A", "B", "C", "D" };
            //List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };

            //var ms = datasource1.Except(datasource2).ToList();


            //List<student> students = new List<student>()
            //{
            //    new student(){ Id = 1, Name = "John"},
            //    new student(){ Id = 2, Name = "Kim"},
            //    new student(){ Id = 3, Name = "John"},
            //    new student(){ Id = 4, Name = "Mark"}
            //};


            //List<student> students1 = new List<student>()
            //{
            //    new student(){ Id = 1, Name = "John"},
            //    new student(){ Id = 2, Name = "Kim"},
            //    new student(){ Id = 3, Name = "John"},
            //    new student(){ Id = 4, Name = "Mark"}
            //};

            //var ms = students.Select(x => new { x.Id, x.Name }).Except(students1.Select(x => new { x.Id, x.Name })).ToList();


            // Intersect set operator


            //List<student> students1 = new List<student>()
            //{
            //    new student(){ Id = 1, Name = "John"},
            //    new student(){ Id = 2, Name = "Kim"},
            //    new student(){ Id = 3, Name = "John"},
            //    new student(){ Id = 4, Name = "Mark"}
            //};


            //List<student> students2 = new List<student>()
            //{
            //    new student(){ Id = 1, Name = "John"},
            //    new student(){ Id = 2, Name = "Kim"},
            //    new student(){ Id = 5, Name = "John"},
            //    new student(){ Id = 6, Name = "Mark"}
            //};

            //var ms = students1.Select(x => new { x.Id, x.Name }).Intersect(students2.Select(x => new { x.Id, x.Name })).ToList();


            // Union set operator

            //List<student> students1 = new List<student>()
            //{
            //    new student(){ Id = 1, Name = "John"},
            //    new student(){ Id = 2, Name = "Kim"},
            //    new student(){ Id = 3, Name = "John"},
            //    new student(){ Id = 4, Name = "Mark"}
            //};


            //List<student> students2 = new List<student>()
            //{
            //    new student(){ Id = 1, Name = "John"},
            //    new student(){ Id = 2, Name = "Kim"},
            //    new student(){ Id = 5, Name = "John"},
            //    new student(){ Id = 6, Name = "Mark"}
            //};

            //var ms = students1.Union(students2).ToList();

            Console.ReadLine();



        }

        class student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
