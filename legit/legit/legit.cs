using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legit
{
    internal class legit
    {
        string Question { get; set; }

        public static string[] Answers = new string[3];


        public legit(string Theword, string Theanswer, string answer1, string answer2)
        {
            Question = Theword;
            Answers[0] = Theanswer ;
            Answers[1] = answer1 ;
            Answers[2] = answer2 ;  

             
        }
    }
}
