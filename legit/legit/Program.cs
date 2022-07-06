namespace legit
{
    class program
    {
        static void Main(string[] args)
        {
            List<legit> list = new List<legit>()
            {
                new legit("RFTOMSCIO?","microsoft","micro","soft"),
                new legit("TSAREE","sdf","asdfs","asdf"),
                new legit("How may seconds are in a minute?", "20", "60", "50")
            };

             Console.WriteLine("ENTER POSSIBLE WORD FORM FROM THE WORD ABOVE");
           string input = Console.ReadLine();
            static int mymethod(string Answer1, string Answer2, string Answer3, string input)
            {

                Answers[0] = Answer1;
                Answers[1] = Answer2;
                Answers[2] = Answer3;

                if (input == Answer1 || input == Answer2 || input == Answer3)
                {
                    Console.WriteLine("PASS! You have gotten 1 point");
                    return 1;
                }
                else
                {

                    Console.WriteLine("FAILED");
                    return 0;

                }
            //static void AskQuestion(legit question)
            //{
            //    Console.WriteLine( question.Question);
            //    //Console.WriteLine(question.first_attempt);
            //    //Console.WriteLine(question.second_attempt);
            //    //Console.WriteLine(question.third_attempt);
            //    //Console.WriteLine("" + question.Answer);
            //}

        }
    }
}