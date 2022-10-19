class Word

{
    static void Main(string[] args);
    string[] words = { "eight", "whale", "Obama", "Stink", "Onion", "Snake", "Train", "Fries" };

    public string ChooseWord()
    {
        Random random = new Random();
        int wordindex = random.Next(0, words.Length);
        return words[wordindex];
    }


    // trying to get a method to pick a word then split it into
    // a list with each letter taking oen index
    public void splitWord(){

    char[] seperator = {' '};
    String[] wordlist = words.Split(seperator);
    }
   
}