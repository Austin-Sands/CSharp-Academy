using MyMathGame.Models;

namespace MyMathGame
{
    internal class GameEngine
    {
        internal int AdditionGame()
        {
            Console.WriteLine("Addition game selected\n");
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                var correct = firstNumber + secondNumber;

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var answer = Console.ReadLine();

                score += Helpers.checkAnswer(correct, answer);
            }
            Helpers.printScore(score, GameType.Addition);
            return score;
        }

        internal int SubtractionGame()
        {
            Console.WriteLine("Subtraction game selected\n");
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                var correct = firstNumber - secondNumber;

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var answer = Console.ReadLine();

                score += Helpers.checkAnswer(correct, answer);
            }
            Helpers.printScore(score, GameType.Subtraction);
            return score;
        }

        internal int MultiplicationGame()
        {
            Console.WriteLine("Multiplication game selected\n");
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                var correct = firstNumber * secondNumber;

                Console.WriteLine($"{firstNumber} x {secondNumber}");
                var answer = Console.ReadLine();

                score += Helpers.checkAnswer(correct, answer);
            }
            Helpers.printScore(score, GameType.Multiplication);
            return score;
        }

        internal int DivisionGame()
        {
            Console.WriteLine("Division game selected\n");
            var random = new Random();
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var correct = divisionNumbers[0] / divisionNumbers[1];

                Console.WriteLine($"{divisionNumbers[0]} / {divisionNumbers[1]}");
                var answer = Console.ReadLine();

                score += Helpers.checkAnswer(correct, answer);
            }
            Helpers.printScore(score, GameType.Division);
            return score;
        }

    }

}
