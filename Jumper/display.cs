class Display
{
    List<string> jumpGuy = new List<string>() { "\n", @" ___  ", @"/___\ ", @"\   / ", @" \ / ", "  O ", @" /|\ ", @" / \ " };
    int lastGuess = 4;
    //List<string> backupWordList = new List<string> {};

    public List<string> BackupList(List<string> winningWordSplit) {
        List<string> backupWordList = new List<string> {};
        backupWordList = winningWordSplit;
        return backupWordList;
    }
    public void DisplayJumper(int numGuesses)
    {
        
        if (lastGuess > numGuesses) {
            Console.WriteLine("lost point");
            jumpGuy.RemoveAt(1);}
        foreach (string line in jumpGuy){
            Console.WriteLine(line);}
        lastGuess = numGuesses;
    }
    public void DisplayWord(List<string> winningWordSplit, List<string> backupWordList)
    {

        // string wordAppend = "";
        // if plyaerGuess = 
        // wordAppend += playerGuess
        List<string> blankDisplay = new List<string> {"_ ", "_ ", "_ ", "_ ", "_ "};
    
        Console.Write("\n");
        foreach(string letter in backupWordList){
            // Console.Write(letter);
            bool missingletter = false;
            if (winningWordSplit.Contains(letter)){
                missingletter = true;
            }
            
            if (missingletter == false){
                Console.Write(letter);
                //blankDisplay[index] = (letter1);
                }
            else {Console.Write("_ ");}
            //index++;
            }

        }
        private void changeWord();
        
}