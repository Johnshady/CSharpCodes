namespace Animal_assignment
{
    class program
    {
        static void Main(string[] args)
        {
            List<Animals> listquestions = new List<Animals>()
            {
                new Animals("Goat", "Heterotrophic", "Locker", true, true, 2, "Mamal"),
                new Animals("Dog", "Heterotrophic", "Kernel", false, true, 0, "Mamal"),
                new Animals("Lion", "Heterotrophic", "Den", false, true, 0, "Mamal")

            };
            for (int i = 0; i < listquestions.Count; i++)
            {
                Console.WriteLine(listquestions[i].Name);
            }
        }
    }
}