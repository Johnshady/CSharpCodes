
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
                new scramblegame("\nRFTOMSCIO?","microsoft" ),
                new scramblegame("\nTSAREE","easter"),
                new scramblegame("\nPORMUTEC", "computer"),
                new scramblegame("\nHATLAPBHE", "alphabet"),
                new scramblegame("\nMERMCSLAEBGA", "scramblegame"),
                new scramblegame("\nBHTILBGUL", "lightbulb"),
                new scramblegame("\nDODARNI", "android")
                };

                int totalgrade = 0;
                //int att


                foreach (var check in list)
                {
                    Askquestion(check);

                   
                    for (int i = 1; i <= 3; i = i + 1)
                    {
                        if (CheckAnswer(check.answer) == 0 )
                        {

                            Console.WriteLine("try again");

                        }
                        else
                        {
                            totalgrade++;
                            break;

                        }
                    }
                   



                }
                static void Askquestion(scramblegame question)
                {
                    Console.WriteLine(question.word);
                    Console.WriteLine("ENTER THE POSSIBLE WORD FROM THE WORD ABOVE");
                }

                static int CheckAnswer(string attempt)
                {
                    string answer = Console.ReadLine();

                    if (answer.Equals(attempt, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("PASS! You have gotten 1 point");
                            return 1;


                        }

                        else
                        {
                        return 0;

                        }
                   
                }

                if (totalgrade > 5 && totalgrade <= 6)
                {
                    Console.WriteLine($"BRAVO, YOU SCORED {totalgrade}!! GOOD JOB  ");
                }
                else if (totalgrade == 7)
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








//Console.WriteLine(i);
//CheckAnswer(check.answer);
