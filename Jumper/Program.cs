class Main
{
    Player player = new Player();
    Guesses Guesses = new Guesses();
    Word word = new Word();
    Display display = new Display();

public void Play()
    {
    var keepPlaying = true;
    var winningWord = word.ChooseWord();
    while (keepPlaying)
        {
        display.displayWord();
        display.displayJumper();
        display.something(winningWord);
        var playerGuess = player.Guess();
        
        }
    }
}