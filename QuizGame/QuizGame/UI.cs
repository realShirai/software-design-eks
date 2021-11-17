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


        public static void NewParagraph(int lineBreaks = 1)
        {
            for (int i = 0; i < lineBreaks; i++)
            {
                Console.WriteLine();
            }
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

        public static char ReadChoice(string validChars = null)
        {
            char input;

            do
            {
                input = Console.ReadKey().KeyChar;
            } while (validChars is not null && !validChars.Contains(input));

            return input;
        }
    }
}


