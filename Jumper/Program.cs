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
        display.DisplayWord();
        display.DisplayJumper();
        display.something(winningWord);
        var playerGuess = player.Guess();
        
        }
    }
}