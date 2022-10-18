class Word
{
    string[] words = { "eight", "whale", "Obama", "Stink", "Onion", "Snake", "Train", "Fries" };

    public string chooseword()
    {
        Random random = new Random();
        int wordindex = random.Next(0, words.Length);
        return words[wordindex];
    }
}