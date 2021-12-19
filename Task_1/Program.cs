namespace Task_1; 
using System;

class Game
    {
        public static int win_counter = 0;
        public static int loose_counter = 0;
        public static int draw_counter = 0;
        
        static void Main(string[] args)
        {
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Hi Player!");
                Console.WriteLine("Welcome to world popular game!");
                Console.WriteLine("If you want to see game rules type 'Rules'");
                Console.WriteLine("If you want to start game type 'Start'");
                Console.WriteLine("To quit type 'Cancel'");
                UserSelect();

            }
        }

        static void UserSelect()
                { 
                    string choise;
                    
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Type your choise:");
                        choise = Console.ReadLine();

                    } while (choise != "Rules" & choise != "Start" & choise != "Cancel");

                    if (choise == "Rules")
                    {
                        GameRules();
                    }
                    else if (choise == "Start")
                    {
                        Start();
                    }
                    else 
                    // if (choise == "Cancel")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Bye. We will waiting for you");
                        Environment.Exit(0);
                    }
                }

        static void GameRules()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The user enters one of the shape options (rock, scissors or paper), " +
                              "and the computer offers his version at random. Depending on the choice " +
                              "of the user and the computer, the result of the game is displayed: " +
                              " the victory of the user, loss of the user, draw.");
            Console.ResetColor();
            UserSelect();
        }

        private static void Start()
        {
            string win = "You win!";
            string loose = "You lose!";
            string draw = "Draw!";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your move: ");
            string user_move = Console.ReadLine();
            string computer_move = Randomizer();
            Console.WriteLine("Computer move: " + computer_move);
            Console.Write("Game Result: ");
            
            if (user_move == computer_move) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(draw);
                Console.ResetColor();
                draw_counter++;
            }
            else if (user_move == "rock" & computer_move == "scissors")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
                win_counter++;
            }
            else if (user_move == "paper" & computer_move == "rock")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
                win_counter++;

            }
            else if (user_move == "scissors" & computer_move == "paper")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You win!");
                Console.ResetColor();
                win_counter++;
            }
            else if (user_move == "rock" & computer_move == "paper")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!");
                Console.ResetColor();
                loose_counter++;
            }
            else if (user_move == "paper" & computer_move == "scissors")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!");
                Console.ResetColor();
                loose_counter++;
            }
            else if (user_move == "scissors" & computer_move == "rock")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lose!");
                Console.ResetColor();
                loose_counter++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Incorrect move. Choose one of: " +
                                  "rock, scissors, paper");
                Console.ResetColor();
            }
            StopGame();
            Start();
        }

        static void StopGame()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Do you want try again? yes/no");
            string stop_game_choise = Console.ReadLine();
            if (stop_game_choise == "yes")
            {
                Start();
            }
            else if (stop_game_choise == "no")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("See you soon!");
                Console.WriteLine("You win - " + win_counter + " times");
                Console.WriteLine("You loose - " + loose_counter + " times");
                Console.WriteLine("You draw - " + draw_counter + " times");
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Incorrect enter. Choose one of: " +
                                  "yes, no");
                Console.ResetColor();
                StopGame();
            }
        }
        
        static string Randomizer()
        {
            string computer_move = "";
            Random rnd = new Random();
            int random_value = rnd.Next(0, 3);
            
            switch (random_value)
            {
                case 0:
                    computer_move = "rock";
                    break;
                case 1:
                    computer_move = "scissors";
                    break;
                case 2:
                    computer_move = "paper";
                    break;
            } 
            return computer_move;
        }
    }
    