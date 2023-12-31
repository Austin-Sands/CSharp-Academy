namespace MyMathGame
{
    internal class Menu
    {
        GameEngine engine = new();

        internal void ShowMenu(string name, DateTime date)
        {
            var gameIsOn = true;
            var totalScore = 0;

            Console.WriteLine(
            "----------------------------------------\n" +
            $"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. It's great that you're working on improving yourself\n"
            );

            String menu =
                $"What game would you like to play today? Choose from the following options:\n" +
                "V - View Previous Games\n" +
                "A — Addition\n" +
                "S — Subtraction\n" +
                "M — Multiplication\n" +
                "D — Division\n" +
                "Q — Quit the program\n" +
                "----------------------------------------\n"
                ;

            do
            {
                Console.WriteLine(menu);

                var gameSelected = Console.ReadLine();

                Console.Clear();

                if (gameSelected != null)
                {
                    switch (gameSelected.Trim().ToLower())
                    {
                        case "v":
                            Helpers.GetGames();
                            break;
                        case "a":
                            totalScore += engine.AdditionGame();
                            break;
                        case "s":
                            totalScore += engine.SubtractionGame();
                            break;
                        case "m":
                            totalScore += engine.MultiplicationGame();
                            break;
                        case "d":
                            totalScore += engine.DivisionGame();
                            break;
                        case "q":
                            Console.WriteLine($"Total score this session: {totalScore}.\n\n Goodbye...\n");
                            gameIsOn = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            } while (gameIsOn);
        }

    }
}
