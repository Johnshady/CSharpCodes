
namespace scramble
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                  WELCOME TO THE SCRAMBLED WORD APPLICATION \n\n");

            int choose;

            Console.Write("                             Enter [1] to set up the test or [2] to exit the program\n");



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
                        break;
                }
            }
            catch
            {
                Console.WriteLine("string not allowed");
              

            }
            static void easter()
            {
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
                    Console.WriteLine("\nALL THE ANSWERS FOR THE WORD ABOVE\n");
                    Console.WriteLine(check.answer);
                }
                static void Askquestion(scramblegame question)
                {
                    Console.WriteLine(question.question);
                    Console.WriteLine("ENTER THE POSSIBLE WORD FROM THE WORD ABOVE");
                }

                static int CheckAnswer(string attempt, string attempt2, string attempt3, string attempt4)
                {
                    string answer = Console.ReadLine();

                    if (answer.Equals(attempt, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(attempt2, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(attempt3, StringComparison.InvariantCultureIgnoreCase) || answer.Equals(attempt4, StringComparison.InvariantCultureIgnoreCase))
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
                if (totalgrade > 15 && totalgrade <= 20 )
                {
                    Console.WriteLine($"BRAVO, YOU SCORED {totalgrade}!! GOOD JOB  ");
                }
                else if(totalgrade == 21)
                {
                    Console.WriteLine($"CONGRATULATION YOUR SCORE IS {totalgrade} YOU DID GREAT");
                }

                else
                {
                    Console.WriteLine($"NICE TRY, BUT IMPROVE ON YOURSELF, YOU SCORED {totalgrade}");
                }
            }
        }

    }

}








