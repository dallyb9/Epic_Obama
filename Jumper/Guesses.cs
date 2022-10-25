class Guesses
{
    int numGuesses = 4;
    List<string> guessedChar = new List<string>() {};

    public void AddGuess(string playerGuess) {
        guessedChar.Add(playerGuess);
        Console.WriteLine(guessedChar);
    }

    public bool testGuess(string playerGuess){
        //if (playerGuess in word)
        return true;
    }
    public int badGuess()
    {
        numGuesses -= 1;
        return numGuesses;
    }
}