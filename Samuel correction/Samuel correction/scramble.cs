using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scramble
{
    internal class scramblegame
    {
        public string word { get; set; }

        public string answer { get; set; }
       



        public scramblegame()
        {

        }
        public scramblegame(string Theword, string ans1)
        {
            word = Theword;
            answer = ans1;
          
        }
    }
}

