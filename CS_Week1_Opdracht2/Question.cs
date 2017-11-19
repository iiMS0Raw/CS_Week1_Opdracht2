using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Week1_Opdracht2
{
    class Question
    {
        public string Text { get; set; }
        public string CorrectResponse { get; set; }
        public Category Category { get; set; }
        public Difficulty Difficulty { get; set; }

        public void Display()
        {
            Console.WriteLine(Text);
        }

        public bool CheckAnswer(string answer)
        {
            return answer == CorrectResponse;
        }


    }
  
}
