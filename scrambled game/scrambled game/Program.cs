
// See https://aka.ms/new-console-template for more information
namespace scrambled_app
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                            WELCOME TO THE SCRAMBLED WORD APPLICATION \n\n");

            int choose;

            Console.Write("Enter [1] to set up the test or [2] to exit the program\n");



            try
            {
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:

                        easter();

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
            static void easter()
            {
                int attemptleft = 3;
                int num1 = 3;
                List<scramblegame> list = new List<scramblegame>()
            {
                new scramblegame("\nRFTOMSCIO?","microsoft","soft","micro","micro microsoft soft" ),
                new scramblegame("\nTSAREE","eat","rest","easter", "eat rest easter"),
                new scramblegame("\nCOMPUTER", "put", "come", "mute", "put come mute"),
                new scramblegame("\nALPHABET", "hat","alpha", "let", "hat alpha let" ),
                new scramblegame("\nSCRAMBLEGAME", "scramble","game", "same", "scramble game same" ),
                new scramblegame("\nLIGHTBULB", "bulb","lit", "light", "light bulb lit" ),
                new scramblegame("\nANDRIOD", "rod","nod", "and", "rod nod and" )
            };

                int totalgrade = 0;


                foreach (var check in list)
                {
                    Askquestion(check);
                    totalgrade += CheckAnswer((check.answer1), (check.answer2), (check.answer3), (check.answer));
                    totalgrade += CheckAnswer((check.answer1), (check.answer2), (check.answer3), (check.answer));
                    totalgrade += CheckAnswer((check.answer1), (check.answer2), (check.answer3), (check.answer));
                    Console.WriteLine("\nALL THE ANSWERS\n");
                    Console.WriteLine(check.answer);


                }
                static void Askquestion(scramblegame question)
                {
                    Console.WriteLine(question.question);
                    Console.WriteLine("ENTER THE POSSIBLE WORD FORM THE WORD ABOVE");
                }

                static int CheckAnswer(string test, string test2, string test3, string test4)
                {
                    string answer = Console.ReadLine();

                    if (answer.Equals(test, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(test2, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(test3, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(test4, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("PASS! You have gotten 1 point");
                        return 1;
                    }

                    else
                    {
                        Console.WriteLine("FAILED");
                        return 0;
                        //Console.WriteLine($" You have {attemptleft = attemptleft - 1} attempt left");

                    }
                }
                if (totalgrade > 15)
                {
                    Console.WriteLine($"BRAVO, YOU SCORED {totalgrade}!! GOOD JOB  ");
                }

                else
                {
                    Console.WriteLine($"NICE TRY, BUT IMPROVE ON YOURSELF, YOU SCORED {totalgrade}");
                }
            }
        }

    }

}








