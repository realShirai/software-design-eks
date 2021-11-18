using System;
using System.Collections.Generic;
namespace QuizGame
{
    public class Quiz
    {
        public string category;
        
        public List<Question> Questions = new List<Question>();
        public Quiz(string category, List<Question> Questions)
        {
            this.category = category;
            this.Questions = Questions;
        }
    }
}
