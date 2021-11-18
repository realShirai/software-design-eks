using System;
using System.Linq;
using System.Threading;

namespace QuizGame
{
    public class QuizGame
    {
		public static void Main()
        {
            QuizBase.QuizRegister();
            MenuRegister();
        }

        public static void MenuRegister()
        {
            UI.ClearScreen();
            UI.SetTitle("Register a user");
            UI.DisplayMessage("Please input your desired username:");
            UserBase.CurrentUser = Console.ReadLine();
            int nameLength = UserBase.CurrentUser.Length;
            if (nameLength > 10)
            {
                UI.DisplayMessage("That username is longer than 10 characters, please choose another name.");
                Thread.Sleep(1000);
                MenuRegister();
            }
            foreach (string user in UserBase.Users)
            {
                if (user.ToLower() == UserBase.CurrentUser.ToLower())
                {
                    UI.DisplayMessage("That user already exists, please choose another name.");
                    Thread.Sleep(1000);
                    MenuRegister();
                }
            }
            UserBase.Users.Add(UserBase.CurrentUser);
            MenuMain();
        }

        public static void MenuMain()
        {
            UI.ClearScreen();
            UI.SetTitle("Quizgame");
            UI.DisplayMessage($"Hello {UserBase.CurrentUser}! Please choose one of the following options:\n" +
                "1. Play a quiz\n" +
                "2. User list\n" +
                "3. Log out\n" +
                "...\n" +
                "9. Quit");
            do
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MenuQuiz();
                        break;
                    case "2":
                        MenuUserlist();
                        break;
                    case "3":
                        MenuLoginScreen();
                        break;
                    case "9":
                        Environment.Exit(404);
                        break;
                    default:
                        UI.DisplayMessage("Your input is invalid, please try again.");
                        break;
                }
            } while (true);

        }
        public static void MenuQuiz()
        {
            UI.ClearScreen();
            UI.DisplayMessage("Please choose one of the following options:\n");
            for (int i = 0; i < QuizBase.Quizzes.Count(); i++)
            {
                UI.DisplayMessage($"{i + 1}. {QuizBase.Quizzes[i].category}");
            }
            do
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MenuDifficulty(QuizBase.Quizzes[0].category);
                        break;
                    case "2":
                        //quiz2
                        break;
                    case "8":
                        MenuMain();
                        break;
                    case "9":
                        Environment.Exit(404);
                        break;
                    default:
                        UI.DisplayMessage("Your input is invalid, please try again.");
                        break;
                }
            } while (true);
        }
        public static void MenuDifficulty(string category)
        {
            UI.ClearScreen();
            UI.DisplayMessage("Please choose one of the following options:\n");
            UI.DisplayMessage($"1. Easy {category}");
            UI.DisplayMessage($"2. Intermediate {category}");
            UI.DisplayMessage($"3. Hard {category}");
            UI.DisplayMessage("...\n" +
                "8. Go back" +
                "9. Quit");
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PlayQuiz(category, Question.difficulty.Easy);
                        break;
                    case "2":
                        //quiz2
                        break;
                    case "3":
                        //quiz3
                        break;
                    case "8":
                        MenuQuiz();
                        break;
                    case "9":
                        Environment.Exit(404);
                        break;
                    default:
                        UI.DisplayMessage("Your input is invalid, please try again.");
                        break;
                }
            } while (true);
        }

        public static void PlayQuiz(string category, Question.difficulty _difficulty)
        {
            UI.ClearScreen();
            for (int i = 0; i < QuizBase.Quizzes.Count(); i++)
            {
                if (QuizBase.Quizzes[i].category == category)
                {
                    for (int j = 0; j < QuizBase.Quizzes[i].Questions.Count(); j++)
                    {
                        if (QuizBase.Quizzes[i].Questions[j]._difficulty == _difficulty)
                        {
                            UI.DisplayMessage($"{QuizBase.Quizzes[i].Questions[j]._Question}");
                            for (int k = 0; k < QuizBase.Quizzes[i].Questions[j].Answers.Count(); k++)
                            {
                                UI.DisplayMessage($"{k}. {QuizBase.Quizzes[i].Questions[j].Answers[k]}");
                                
                            }
                            Console.ReadLine();
                            UI.ClearScreen();
                        }
                    }
                }
            }
            UI.ClearScreen();
            UI.DisplayMessage("You finished quiz");
        }

        public static void MenuLoginScreen()
        {
            UI.ClearScreen();
            UI.DisplayMessage("Please choose one of the following options:\n" +
                "1. Log in to an existing user\n" +
                "2. Register a new user\n" +
                "...\n" +
                "9. Quit");
            do
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MenuLogin();
                        break;
                    case "2":
                        MenuRegister();
                        break;
                    case "9":
                        Environment.Exit(404);
                        break;
                    default:
                        UI.DisplayMessage("Your input is invalid, please try again.");
                        break;
                }
            } while (true);
        }
        public static void MenuUserlist()
        {
            UI.ClearScreen();
            UI.DisplayMessage("1. Go back\n\n" +
                "These are our existing users:");

            foreach (string user in UserBase.Users)
            {
                UI.DisplayMessage($"{user}");
            }

            do
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MenuMain();
                        break;
                    default:
                        UI.DisplayMessage("Your input is invalid, please try again.");
                        break;
                }
            } while (true);
        }

        public static void MenuLogin()
        {
            do
            {
                UI.ClearScreen();
                UI.DisplayMessage("Please input your username:");
                UserBase.CurrentUser = Console.ReadLine();
                foreach (string user in UserBase.Users)
                {
                    if (user.ToLower() == UserBase.CurrentUser.ToLower())
                    {
                        UI.DisplayMessage($"Succesfully logged in to {user}!.");
                        Thread.Sleep(1000);
                        MenuMain();
                        break;
                    }
                    UI.DisplayMessage("That user does not exist, please try again!");
                    Thread.Sleep(1000);
                }
            } while (true);
        }
    }
}
