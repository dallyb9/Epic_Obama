class Program
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();

        while (deck.hasCards)
        {
            board.print();

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        board.print();
        Console.WriteLine("Good game. Thanks for playing!");
    }

}

Console.WriteLine(" ___ ");
Console.WriteLine("/___\");
Console.WriteLine("\   /");
Console.WriteLine(" \ /");
Console.WriteLine("  O ");
Console.WriteLine(" /|\");
Console.WriteLine(" / \");