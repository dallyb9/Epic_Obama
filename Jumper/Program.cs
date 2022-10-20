class Program{

public static void Main(){

    Player player = new Player();
    Guesses Guesses = new Guesses();
    Word word = new Word();
    Display display = new Display();


    string winningWord = word.ChooseWord();
    var keepPlaying = true;
    //var winningWord = ChooseWord();
    while (keepPlaying)
        {
        // current letters
        word.SplitWord(winningWord);
        display.DisplayWord();
        // jumpguy
        display.DisplayJumper();
        // player guesses input
        string playerGuess = player.Guess();
        // add said guess to guessed list
        Guesses.AddGuess(playerGuess);
        }
    }
}