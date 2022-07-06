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
        public static string[] Answers = new string[4];
        public static string[] studentAnswers = new string[4];


        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SCRAMBLED WORD APPLICATION WHERE THE USER IS FIRST GOING TO SET UP A TEST AND ANSWERS" +
                 "\nTHEN LATER ON THE USER IS GING TO LET THE STUDENT TAKE THE TEST\n\n  press enter ");
            Console.ReadLine();

            int choose;

            Console.Write("Enter [1] to set up the test or [2] to exit the program");
            choose = Convert.ToInt32(Console.ReadLine());

            try
            {
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:

                        
                        setTest();

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
            string question1, question2, question3, question4, question5;

            Console.Write("\nEnter question 1: ");
            question1 = Console.ReadLine();

            Console.Write("\nEnter question 2: ");
            question2 = Console.ReadLine();

            Console.Write("\nEnter question 3: ");
            question3 = Console.ReadLine();

            Console.Write("\nEnter question 4: ");
            question4 = Console.ReadLine();

            Console.Write("\nEnter question 5: ");
            question5 = Console.ReadLine();


            Questions[0] = question1;
            Questions[1] = question2;
            Questions[2] = question3;
            Questions[3] = question4;
            Questions[4] = question5;

            Console.WriteLine("QUESTION HERE:" + Questions[0] + "\nQUESTION 2:" + Questions[1] + "\nQUESTION 3:" + Questions[2] + "\nQUESTION 4:" + Questions[3] + "\nQUESTION 5:" + Questions[4]);



        }
    }
}