class Guesses
{
    int numGuesses = 4;

    public int badGues()
    {
        numGuesses -= 1;
        return numGuesses;
    }
}