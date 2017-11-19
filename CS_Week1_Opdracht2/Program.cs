using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CS_Week1_Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {

            IList<Question> lijstMetVragen = new List<Question>()
            {
                new Question()
                {
                    Text = "Wat is de naam van deze opleiding?",
                    CorrectResponse = "HBO-ICT",
                    Category = Category.Overig,
                    Difficulty = Difficulty.Easy
                },
                new Question()
                {
                    Text = "Welke maand is het?",
                    CorrectResponse = "November",
                    Category = Category.Overig,
                    Difficulty = Difficulty.Easy
                },
                new Question()
                {
                    Text = "Wat is 2 + 2?",
                    CorrectResponse = "4",
                    Category = Category.Wiskunde,
                    Difficulty = Difficulty.Easy
                },
                new Question()
                {
                    Text = "Wat is 22 + 22?",
                    CorrectResponse = "4",
                    Category = Category.Wiskunde,
                    Difficulty = Difficulty.Hard
                },
                new Question()
                {
                    Text = "In welk land wonen wij?",
                    CorrectResponse = "Nederland",
                    Category = Category.Aardrijkskunde,
                    Difficulty = Difficulty.Normal
                }
               
            };

            Console.WriteLine("Druk op een knop om de Quiz af te sluiten");
            Console.ReadKey();

        }

    }
}
