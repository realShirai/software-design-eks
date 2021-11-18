using System;

namespace QuizGame
{
    public class UI
    {
        public static void SetTitle(string title)
        {
            Console.Title = title;
        }


        public static void ClearScreen()
        {
            Console.Clear();
        }


        public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White, bool doLineBreak = true)
        {
            Console.ForegroundColor = color;
            if (doLineBreak)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.Write(message);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


