namespace QuizAssignment
{
    class program
    {
        static void Main(string[] args)
        {
            Quizquestion Animal1 = new Quizquestion();
            Animal1.Name = "Goat";
            Animal1.Mode_of_nutrirtion = "Herbivorios";
            Animal1.Habitat = "Pen";
            Animal1.Herbivorios = true;
            Animal1.Movement = true;
            Animal1.Horn = 2;
            Animal1.Classes = "Mamal";
            Console.WriteLine(Animal1.Classes);

            Quizquestion Animal2 = new Quizquestion();
            Animal2.Name = "Snake";
            Animal2.Mode_of_nutrirtion = "Canivorios";
            Animal2.Habitat = "Burrow";
            Animal2.Herbivorios = false;
            Animal2.Movement = true;
            Animal2.Horn = 0;
            Animal2.Classes = "Reptile";
            Console.WriteLine(Animal2.Movement);


            Quizquestion Animal3 = new Quizquestion();
            Animal3.Name = "Dog";
            Animal3.Mode_of_nutrirtion = "Carnivorios";
            Animal3.Habitat = "Kernel";
            Animal3.Herbivorios = false;
            Animal3.Movement = true;
            Animal3.Horn = 0;
            Animal3.Classes = "Mamal"; 
            Console.WriteLine(Animal3.Horn);

            Quizquestion Animal4 = new Quizquestion();
            Animal4.Name = "Lion";
            Animal4.Mode_of_nutrirtion = "Canivorios";
            Animal4.Habitat = "Den";
            Animal4.Herbivorios = false;
            Animal4.Movement = true;
            Animal4.Horn = 0;
            Animal4.Classes = "Mamal";
            Console.WriteLine(Animal4.Movement);


            Quizquestion Animal5 = new Quizquestion();
            Animal5.Name = "Fish";
            Animal5.Mode_of_nutrirtion = "heterotrophic";
            Animal5.Habitat = "Pond";
            Animal5.Herbivorios = false;
            Animal5.Movement = true;
            Animal5.Horn = 0;
            Animal5.Classes = "pisces";
            Console.WriteLine(Animal5.Movement);
        }
    }
}