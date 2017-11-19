using System;

namespace CS_Week1_Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question()
            {
                Text = "Wat is de naam van deze opleiding?",
                CorrectResponse = "HBO-ICT",
                Category = Category.Overig,
                Difficulty = Difficulty.Easy
            };

            Question q2 = new Question()
            {
                Text = "Welke maand is het?",
                CorrectResponse = "November",
                Category = Category.Overig,
                Difficulty = Difficulty.Easy
            };

            q1.Display();
            Console.Write("Wat is uw antwoord? ");
            var answer1 = Console.ReadLine();
            Console.WriteLine(q1.CheckAnswer(answer1));

            q2.Display();
            Console.Write("Wat is uw antwoord? ");
            var answer2 = Console.ReadLine();
            Console.WriteLine(q2.CheckAnswer(answer2));

            Console.WriteLine("Druk op een knop om de Quiz af te sluiten");
            Console.ReadKey();

        }
    }
}
