namespace Ch19_RockPaperScissorsProgram;

public static class Prorgam
{
    public static void Main()
    {
        Random random = new Random();
        bool playAgain = true;
        String player;
        String computer;
        string answer;

        while( playAgain){
            player = "";
            computer = "";
            answer = "";

            while(player != "ROCK" && player!= "PAPER" && player!= "SCISSORS"){
                    Console.WriteLine("Enter either ROCK, PAPER, OR SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
            }
            // int randomNum = random.Next(1, 4);
            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                 case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }
            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);

            switch (player){
                case "ROCK":
                    if(computer == "ROCK"){
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "PAPER"){
                        Console.WriteLine("You lose!");
                    }
                    else{
                        Console.WriteLine("You win!");
                    }
                        break;
                case "PAPER":
                    if (computer == "ROCK"){
                        Console.WriteLine("You win!");
                    }
                    else if (computer == "PAPER"){
                        Console.WriteLine("It's a draw!");
                    }
                    else{
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "ROCK"){
                        Console.WriteLine("You lose!");
                    }
                    else if (computer == "PAPER"){
                        Console.WriteLine("You win!");
                    }
                    else{
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }

            Console.WriteLine("Would you like to play again? (Y/N): ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y" ){
                playAgain = true;
            }
            else{
                playAgain = false;
            }
        }

        Console.WriteLine("Thank you for playing!");
        Console.ReadKey();
    }
}