using System;
namespace QuizGame
{
    public class Question
    {
        public string _Question;
        public string[] Answers = new string[4];
        public int RightAnswer;
        public enum difficulty { Easy, Intermediate, Hard }
        public difficulty _difficulty;

        public Question(string question, difficulty _difficulty, string[] answers, int rightAnswer)
        {
            _Question = question;
            Answers = answers;
            RightAnswer = rightAnswer;
            this._difficulty = _difficulty;
        }
    }
}
