//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace scrambledapp
//{
//    internal class scrambled
//    {

//        public string word { get; set; }

//        public string answer1 { get; set; }
//        public string answer2 { get; set; }
//        public string answer3 { get; set; }



//        public scrambled()
//        {

//        }
//        public scrambled(string Theword, string Theanswer,string ans2,string ans3)
//        {
//            word = Theword;
//            answer1 = Theanswer;
//            answer2 = ans2;
//            answer3 = ans3;



//        }
//    }
// }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRAMBLED_APP_APP
{
    internal class Scramble
    {

        public string Question;
        public string OptionA;
        public string OptionB;
        public string OptionC;
        public string Answers;


        public Scramble(string quest, string optA, string optB, string optC, string optD, string ans)
        {
            Question = quest;
            OptionA = optA;
            OptionB = optB;
            OptionC = optC;
            Answers = ans;


        }

        public Scramble()
        {

        }

    }
}
