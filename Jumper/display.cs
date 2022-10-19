class Display{

public void displayJumper(){
    Console.WriteLine(" ___  ");
    Console.WriteLine("/___\ ");
    Console.WriteLine("\   / ");
    Console.WriteLine(" \ / ");
    Console.WriteLine("  O ");
    Console.WriteLine(" /|\ ");
    Console.WriteLine(" / \ ");
    }

    private void displayWord(){
        // String[] word =     ["E ","I ","G ","H ","T "];
        String[] wordDisplay = ["_ ","_ ", "_ ","_ ","_ "];
        Console.WriteLine($"{wordDisplay}");
    }
    
    string word = Word.ChooseWord(word);

    
}