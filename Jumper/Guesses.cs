class Guesses
{
    List<string> guessedChar = new List<string>() {};

    public void AddGuess(string playerGuess) {
        guessedChar.Add(playerGuess);
        Console.WriteLine(guessedChar);
    }

//List<string>
    public bool testGuess(string playerGuess, List<string> winningWordSplit){
        Console.Write(winningWordSplit);
        foreach (string letter in winningWordSplit){
            Console.WriteLine(letter);
            if (playerGuess == letter){
                return true;
            }
        }
        return false;
    }
    public int badGuess(int numGuesses)
    {
        numGuesses -= 1;
        return numGuesses;
    }
}