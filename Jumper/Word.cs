class Word

{
    // static void Main(string[] args);
    string[] words = { "e i g h t", "w h a l e", "o b a m a", "s t i n k", 
    "o n i o n", "s n a k e", "t r a i n", "f r i e s" };

    public string ChooseWord()
    {
        Random random = new Random();
        int wordindex = random.Next(0, words.Length);
        return words[wordindex];
    }
 
    // trying to get a method to pick a word then split it into
    // a list with each letter taking oen index
    public List<string> SplitWord(string winningWordSplit){
        string word = winningWordSplit;
        List<string> list = new List<string>();
        list = word.Split(' ').ToList();
        foreach(string letter in list){
            Console.Write(letter);
        }
        return list;
        }
   
    public List<string> removeLetter(string playerGuess, List<string> winningWordSplit) {
        //List<string> fakeWordList = new List<string> (winningWordSplit);
        int lettercount = 0;
        foreach (string letter in winningWordSplit){
            if (playerGuess == letter){
                lettercount++;
            }
        }
        if (lettercount > 0){
            // foreach (string letter in winningWordSplit){
            // Console.Write(letter);}
            for(int i = 0; i < lettercount; i++){
                winningWordSplit.Remove(playerGuess);
            }
            // foreach (string letter in winningWordSplit){
            // Console.Write(letter);}
        }
        return winningWordSplit;
    }  
}