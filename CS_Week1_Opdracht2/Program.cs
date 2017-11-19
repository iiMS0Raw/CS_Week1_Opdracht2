using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;


namespace CS_Week1_Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Question q = new Question();
            // Dit is een lijst met random vragen
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
                    CorrectResponse = "44",
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

            Console.WriteLine("Je krijgt nu automatisch alle vragen gesteld");
            // Presenteer alle vragen, ongeacht categorie of moeilijkheidsgraad
            foreach (Question question in lijstMetVragen)
            {
                q.PresentQuestion(question);

            }

            // Mbv LINQ de makkelijke vragen vinden
            var diffQuestions = from quest in lijstMetVragen
                                where quest.Difficulty == Difficulty.Easy
                                select quest;

            Console.WriteLine("Nu krijg je alleen de makkelijke vragen gesteld");
            // Stelt alleen de makkelijke vragen
            foreach (Question question in diffQuestions)
            {
                q.PresentQuestion(question);
            }

            // Mbv LINQ de normale vragen vinden
            var diffQuestions1 = from quest in lijstMetVragen
                                 where quest.Difficulty == Difficulty.Normal
                                 select quest;

            Console.WriteLine("Dit zijn de normale vragen alleen");
            // Stelt alleen de normale vragen
            foreach (Question question in diffQuestions1)
            {
                q.PresentQuestion(question);
            }

            // Mbv LINQ de moeilijke vragen vinden
            var diffQuestions2 = from quest in lijstMetVragen
                where quest.Difficulty == Difficulty.Hard
                select quest;

            Console.WriteLine("Dit zijn de normale vragen alleen");
            // Stelt alleen de moeilijke vragen
            foreach (Question question in diffQuestions2)
            {
                q.PresentQuestion(question);
            }

            Console.WriteLine("Druk op een knop om de Quiz af te sluiten");
            Console.ReadKey();

        }

    }
}
