class Program
{
    static void Main(string[] args)
    {
        string Rock = "rock";
        string Paper = "paper";
        string Scissors = "scissors";

        Console.WriteLine("Choose your move: rock, paper, or scissors");
        string playerMove = Console.ReadLine().ToLower();

        if (playerMove == "r" || playerMove == "rock")
        {
            playerMove = Rock;
        }
        else if (playerMove == "p" || playerMove == "paper")
        {
            playerMove = Paper;
        }
        else if (playerMove == "s" || playerMove == "scissors")
        {
            playerMove = Scissors;
        }
        else
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Random random = new Random();
        int computerIndex = random.Next(1, 4);
        string computerMove;

        if (computerIndex == 1)
        {
            computerMove = Rock;
        }
        else if (computerIndex == 2)
        {
            computerMove = Paper;
        }
        else
        {
            computerMove = Scissors;
        }

        Console.WriteLine($"The computer chose {computerMove}.");

        if (playerMove == Rock && computerMove == Paper ||
            playerMove == Paper && computerMove == Scissors ||
            playerMove == Scissors && computerMove == Rock)
        {
            Console.WriteLine("Computer wins!");
        }
        else if (playerMove == computerMove)
        {
            Console.WriteLine("It's a tie!");
        }
        else
        {
            Console.WriteLine("You win!");
        }
    }
}
