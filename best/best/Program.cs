using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SA
{
    class PROJECT
    {
        public static string[] Questions = new string[5];
        public static string[] Answers = new string[3];
        public static string[] studentAnswers = new string[4];


        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SCRAMBLED WORD APPLICATION WHERE THE USER IS FIRST GOING TO SET UP A TEST AND ANSWERS" +
                 "\nTHEN LATER ON THE USER IS GING TO LET THE STUDENT TAKE THE TEST\n\n");
             

            int choose;

            Console.Write("Enter [1] to set up the test or [2] to exit the program\n");
            

            try
            {
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:


                        setTest();

                        setAnswer();

                        break;

                    case 2:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("invalid entry.");
                        Console.ReadLine();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("string not allowed");
                Console.ReadLine();

            }
        }
        private static void setTest()
        {
            string question1 /*question2, question3, question4, question5*/;

            Console.Write("\nFirst word : ");
           /* question1 =*/ Console.WriteLine ("microsoft");

            //Console.Write("\nEnter question 2: ");
            //question2 = Console.ReadLine();

            //Console.Write("\nEnter question 3: ");
            //question3 = Console.ReadLine();

            //Console.Write("\nEnter question 4: ");
            //question4 = Console.ReadLine();

            //Console.Write("\nEnter question 5: ");
            //question5 = Console.ReadLine();


            ////Questions[0] = question1;
            //Questions[1] = question2;
            //Questions[2] = question3;
            //Questions[3] = question4;
            //Questions[4] = question5;

            //Console.WriteLine("QUESTION HERE:" + Questions[0] + "\nQUESTION 2:" + Questions[1] + "\nQUESTION 3:" + Questions[2] + "\nQUESTION 4:" + Questions[3] + "\nQUESTION 5:" + Questions[4]);



        }
        private static void setAnswer()
        {
            string Answer1/* Answer2, Answer3*/;

            //Console.Write("\nEnter possible answer 1: ");
            Answer1 = Console.ReadLine();

            //Console.Write("\nEnter possible answer 2: ");
            //Answer2 = Console.ReadLine();

            //Console.Write("\nEnter possible answer 3: ");
            //Answer3 = Console.ReadLine();





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
            }

        }
    }
}