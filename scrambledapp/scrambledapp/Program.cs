// See https://aka.ms/new-console-template for more information
//namespace scrambledapp
//{ 
//    class program
//    {
//        static void Main(string[] args)
//        {
//            //bool finish = false;
//            List<scrambled> list = new List<scrambled>()
//            {

//                new scrambled("RFTOMSCIO?","microsoft","soft","micro"),
//                new scrambled("How many days are in a year?","526","alkd","ahflal"),
//                new scrambled("How may seconds are in a minute?", "20","alkd","akd")
//            };


//            int totalgrade = 0;
//            int attempt = 3;

//            foreach (var objects in list)
//            {
//                AskQuestion(objects);
//                //totalgrade += CheckAnswer(objects.Answer[0]);
//            }

//            Console.WriteLine("YOUR RESULT IS: " + totalgrade);

//            // static int CheckAnswer(string correctAnswer)
//            //{
//                string answer = Console.ReadLine();


//                {
//                    if (/*answer.Equals(correctAnswer, StringComparison.InvariantCultureIgnoreCase) &&*/ answer.Equals(answer[0]) || answer.Equals(answer[1]) || answer.Equals(answer[2]))
//                    {
//                        Console.WriteLine("PASS! You have gotten 1 point");
//                        //return 1;


//                    }
//                    else
//                    {

//                        Console.WriteLine("FAILED");
//                        //return 0;


//                    }
//                //}
//                //bool finish = true;

//            }


//            static void AskQuestion(scrambled question)
//            {
//                Console.WriteLine(question.word);

//            }
//        }
//    }
//}
namespace SCRAMBLED_APP_APP
{
    class Program
    {
        static void Main(String[] args)
        {

            List<Scramble> questions = new List<Scramble>();
            {
                questions.Add(new Scramble("UESTIONQ", "QUESTION", "TO", "ON", "SON", " QUESTION TO ON SON"));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER","micro"));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER", ""));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER", ""));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER", ""));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER", ""));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER", ""));
                questions.Add(new Scramble("QWERTYUIOP", "TYPE", "YOUR", "WRITE", "TYPEWRITER", ""));

            }

            int totalgrade = 0;

            foreach (var check in questions)
            {
                Askquestion(check);
                totalgrade += CheckAnswer((check.OptionA,OptionB,Optionc)/*, (check.OptionB), (check.OptionC), (check.Answers)*/);
                totalgrade += CheckAnswer((check.OptionA), (check.OptionB), (check.OptionC), (check.Answers));
                totalgrade += CheckAnswer((check.OptionA), (check.OptionB), (check.OptionC), (check.Answers));
                totalgrade += CheckAnswer((check.OptionA), (check.OptionB), (check.OptionC), (check.Answers));
            }
            static void Askquestion(Scramble question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("Enter option: ");
            }
            Console.WriteLine($"you scored {totalgrade}");

            static int CheckAnswer(string test, string test2, string test3, string test4)
            {
                string answer = Console.ReadLine();

                if (answer.Equals(test, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(test2, StringComparison.InvariantCultureIgnoreCase) || answer.Contains(test3, StringComparison.InvariantCultureIgnoreCase) || answer.Contains(test4, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("u pass u have 1 point");
                    return 1;
                }

                else
                {
                    Console.WriteLine("failed");
                    return 0;
                }

            }

        }

    }
}

