using MyMathGame.Models;
using static System.Formats.Asn1.AsnWriter;

namespace MyMathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("----------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} — {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Press any key to return to main menu...");
            Console.ReadLine();
            Console.Clear();
        }

        internal static int checkAnswer(int correct, string answer)
        {
            Console.Clear();
            if (int.Parse(answer.Trim()) == correct)
            {
                Console.WriteLine("Your answer was correct! Press another key to continue...\n");
                return 1;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Press another key to continue...\n");
                return 0;
            }
        }

        internal static void printScore(int score, GameType gameType)
        {
            AddToHistory(score, gameType);
            Console.WriteLine($"Game over. Your final score is {score}. ");
            Console.WriteLine($"Press any key to go back to the main menu...");
            Console.ReadLine();
            Console.Clear();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType

            }) ;
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);
            var divisionNumbers = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            divisionNumbers[0] = firstNumber;
            divisionNumbers[1] = secondNumber;

            return divisionNumbers;
        }
    }
}
