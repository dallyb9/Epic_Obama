class Player
{

    public string Guess()
    {
        // string guess = Console.ReadLine() ?? "Guess a letter: ";
        // foreach (string letter in word){
        //      if guess = letter{
        //          wordDisplay[letter] = guess;
        //      }
        // }
        Console.Write("Guess a letter:");
        return Console.ReadLine() ?? "";
    }
    public bool KeepPlaying()
    {
        Console.Write("Keep Playing? (y/n)");
        string response = Console.ReadLine() ?? "";
        return response == "y";
    }
}
