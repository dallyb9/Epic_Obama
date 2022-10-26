class Program{

public static void Main(){

    Player player = new Player();
    Guesses Guesses = new Guesses();
    Word word = new Word();
    Display display = new Display();


    string winningWord = word.ChooseWord();
    var keepPlaying = true;
    int numGuesses = 4;
    //var winningWord = ChooseWord();
    List<string> winningWordSplit = new List<string>();
    winningWordSplit = word.SplitWord(winningWord); 
    //List<string> backupWordList = display.BackupList(winningWordSplit);
    List<string> backupWordList = winningWordSplit;
    while (keepPlaying)
        {
        // current letters
        display.DisplayWord(backupWordList, winningWordSplit);
        // jumpguy
        display.DisplayJumper(numGuesses);
        // player guesses input
        string playerGuess = player.Guess();
        // add said guess to guessed list
        Guesses.AddGuess(playerGuess);
        // Removes correct guesses from winning word 
        bool test = Guesses.testGuess(playerGuess, winningWordSplit);
        //List<string> fixedWordSplit = new List<string>();
        //winningWordSplit = word.removeLetter(playerGuess, winningWordSplit);
        //winningWordSplit = fixedWordSplit;
        if (test) {
            winningWordSplit = word.removeLetter(playerGuess, winningWordSplit);
        }
        else {
            numGuesses = Guesses.badGuess(numGuesses);}
        if (numGuesses == 0){
            Console.WriteLine("YOU DIED");
            keepPlaying = false;
        }
        List<string> empty = new List<string>();
        if (!winningWordSplit.Any()){
            Console.WriteLine("YOU WON!");
            keepPlaying = false;
        }
        }
    }
}