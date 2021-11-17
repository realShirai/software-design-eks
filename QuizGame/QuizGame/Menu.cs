using System;

namespace QuizGame
{
    public class Menu
    {
        public static void MenuRegister()
        {
            UI.ClearScreen();
            UI.DisplayMessage("Please input your desired username:");
            UserBase.CurrentUser = Console.ReadLine();
            UserBase.Users.Add(UserBase.CurrentUser);
        }

        public static string MenuMain()
        {
            
            UI.ClearScreen();
            UI.DisplayMessage($"Hello {UserBase.CurrentUser}! Please choose one of the following options:\n" +
                "1. Play a quiz\n" +
                "2. Log out\n" +
                "...\n" +
                "9. Quit");
            do
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //Quiz
                        return "1";
                    case "2":
                        MenuLogin();
                        return "2";
                    case "9":
                        Environment.Exit(404);
                        return "9";
                    default:
                        UI.DisplayMessage("Your input is invalid, please try again.");
                        break;
                }
            } while (true);

        }

        public static string MenuLogin()
        {
            UI.ClearScreen();
            UI.DisplayMessage("Please choose one of the following options:\n" +
                "1. Log in to an existing user\n" +
                "2. Register a new user\n" +
                "...\n" +
                "9. Quit");
            return Console.ReadLine();
        }
    }
}
