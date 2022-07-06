namespace Quiz_Project_Classes 
{
    class program
    {
       static void Main(string[] args)
       {

            List<QuizQuestion> list = new List<QuizQuestion>()
            {
                new QuizQuestion("How many days are in a week?","7","6","8","2","A"),
                new QuizQuestion("How many days are in a year?","526","246","365","648","C"),
                new QuizQuestion("How may seconds are in a minute?", "20", "60", "50", "12", "B")
            };

            int totalgrade = 0;

            foreach (var objects in list)
            {
                AskQuestion(objects);
                totalgrade +=  CheckAnswer(objects.Answer);
            }

            Console.WriteLine("YOUR RESULT IS: " + totalgrade);

            static int CheckAnswer(string correctAnswer)
            {
                string answer = Console.ReadLine();
                if(answer.Equals(correctAnswer, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("PASS! You have gotten 1 point");
                    return 1;
                }
                else
                {
                    Console.WriteLine("FAILED");
                    return 0;
                }
            }


            static void AskQuestion(QuizQuestion question)
            {
                Console.WriteLine(question.Question);
                Console.WriteLine("A " + question.OptionA);
                Console.WriteLine("B " + question.OptionB);
                Console.WriteLine("C " + question.OptionC);
                Console.WriteLine("D " + question.OptionD);
            }                        















            //QuizQuestion question1 = new QuizQuestion();
            //question1.Question = "How many days are in a week?";
            //question1.OptionA = "7";
            //question1.OptionB = "6";
            //question1.OptionC = "8";
            //question1.OptionD = "2";
            //question1.Answer = "7";

            //Console.WriteLine(question1.Question);   

            //QuizQuestion question2 = new QuizQuestion();
            //question2.Question = "How many days are in a year?";
            //question2.OptionA = "526";
            //question2.OptionB = "246";
            //question2.OptionC = "365";
            //question2.OptionD = "648";
            //question2.Answer = "365";


            //QuizQuestion question3 = new QuizQuestion("How may seconds are in a minute?", "20", "60", "50", "12", "60");

            //Console.WriteLine(question3.Question);

        }
    }
}

