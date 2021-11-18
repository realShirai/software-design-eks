using System;
using System.Collections.Generic;
using System.Data;

namespace QuizGame
{
    public static class QuizBase
    {
        public static List<Quiz> Quizzes = new List<Quiz>();
        public static void QuizRegister()
        {
            List<Question> _questions = new List<Question>();
            _questions.Add(new Question("World War 1 began in which year?", Question.difficulty.Easy, new string[4] { "1923", "1938", "1917", "1914" }, 3));
            _questions.Add(new Question("World War 1 began in which year?", Question.difficulty.Easy, new string[4] { "1923", "1938", "1917", "1914" }, 3));
            _questions.Add(new Question("World War 1 began in which year?", Question.difficulty.Easy, new string[4] { "1923", "1938", "1917", "1914" }, 3));
            _questions.Add(new Question("World War 1 began in which year?", Question.difficulty.Easy, new string[4] { "1923", "1938", "1917", "1914" }, 3));
            _questions.Add(new Question("World War 1 began in which year?", Question.difficulty.Easy, new string[4] { "1923", "1938", "1917", "1914" }, 3));
            _questions.Add(new Question("Adolf Hitler was born in which country?", Question.difficulty.Intermediate, new string[4] { "France", "Germany", "Austria", "Hungary" }, 2));
            _questions.Add(new Question("Adolf Hitler was born in which country?", Question.difficulty.Intermediate, new string[4] { "France", "Germany", "Austria", "Hungary" }, 2));
            _questions.Add(new Question("Adolf Hitler was born in which country?", Question.difficulty.Intermediate, new string[4] { "France", "Germany", "Austria", "Hungary" }, 2));
            _questions.Add(new Question("Adolf Hitler was born in which country?", Question.difficulty.Intermediate, new string[4] { "France", "Germany", "Austria", "Hungary" }, 2));
            _questions.Add(new Question("Adolf Hitler was born in which country?", Question.difficulty.Intermediate, new string[4] { "France", "Germany", "Austria", "Hungary" }, 2));
            Quizzes.Add(new Quiz("World History", _questions));

           
        }
    }
}
