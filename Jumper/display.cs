class Display
{
    List<string> jumpGuy = new List<string>() { @" ___  ", @"/___\ ", @"\   / ", @" \ / ", "  O ", @" /|\ ", @" / \ " };

    public void DisplayJumper()
    {
        foreach (string line in jumpGuy){
            Console.WriteLine(line);
              }
    //     Console.WriteLine(" ___  ");
    //     Console.WriteLine("/___\ ");
    //     Console.WriteLine("\   / ");
    //     Console.WriteLine(" \ / ");
    //     Console.WriteLine("  O ");
    //     Console.WriteLine(" /|\ ");
    //     Console.WriteLine(" / \ ");
    // }
    }
    public void DisplayWord()
    {
        // String[] word =     ["E ","I ","G ","H ","T "];
        String[] wordDisplay = {"_ ", "_ ", "_ ", "_ ", "_ "};
        Console.WriteLine($"{wordDisplay}");
    }

    //string word = Word.ChooseWord(word);


}