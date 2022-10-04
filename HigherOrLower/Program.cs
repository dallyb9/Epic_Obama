class Program
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();

        while (!IsGameOver(deck))
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