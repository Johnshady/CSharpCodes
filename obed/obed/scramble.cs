using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scramble
{
    internal class scramblegame
    {
        public string question { get; set; }

        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer { get; set; }



        public scramblegame()
        {

        }
        public scramblegame(string Theword, string ans1, string ans2, string ans3, string answer)
        {
            question = Theword;
            answer1 = ans1;
            answer2 = ans2;
            answer3 = ans3;
            this.answer = answer;
        }
    }
}
