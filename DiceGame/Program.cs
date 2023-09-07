int randomNum;
int randomAiNum;
Random random = new Random();

int playerScore = 0;
int aiScore = 0;


for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press Any Key To Roll The Dice.");
    Console.ReadKey();
    Console.WriteLine();
    randomNum = random.Next(1, 7);
    Console.WriteLine("You Rolled A " + randomNum);

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    randomAiNum = random.Next(1, 7);
    Console.WriteLine("The AI Rolled A " + randomAiNum);
    if (randomAiNum > randomNum)
    {
        Console.WriteLine("Ai Wins!");
        Console.WriteLine();
        aiScore++;
        Console.WriteLine("Player: " + playerScore + " / " + "AI: " + aiScore);
    }
    else if (randomNum > randomAiNum)
    {
        Console.WriteLine("You Win!");
        Console.WriteLine();
        playerScore++;
        Console.WriteLine("Player: " + playerScore + " / " + "AI: " + aiScore);
    }
    else
    {
        Console.WriteLine("Draw!");
        Console.WriteLine("Player: " + playerScore + " / " + "AI: " + aiScore);
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------");
}

if (playerScore > aiScore)
{
    Console.WriteLine("Player Wins!");
}
else if (aiScore > playerScore)
{
    Console.WriteLine("AI Wins!");
}
else
{
    Console.WriteLine("Draw!");
}