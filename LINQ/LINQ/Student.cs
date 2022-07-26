using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Student
    {
        public string _FirstName { get; set; }
        public string _SurName { get; set; }
        public string _CurrentClass { get; set; }
        public double _ResultAverage { get; set; }

        public Student(string first, string sur, string curr, double result)
        {
            _FirstName = first;
            _SurName = sur;
            _CurrentClass = curr;  
            _ResultAverage=result;
        }
    }
   
}
