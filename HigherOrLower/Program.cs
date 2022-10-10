using System;
using System.Collections.Generic;

// class Program
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();
        int points = 300;
        Random rnd = new Random();
        int test = deck.deckOfCards[0];
        int randCardIndex = rnd.Next(deckOfCards.Count);
        int randomCard = deckOfCards[randCardIndex];

        while (!IsGameOver(points))
        {

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        board.print();
        Console.WriteLine("Good game. Thanks for playing!");
    }
    public object pickRandomCard(){
        Random rnd = new Random();
        int randCardIndex = rnd.Next(deck.deckOfCards.Count);
        int randomCard = deckOfCards[randCardIndex];
        return randomCard;
    }
    int previousCard = Convert.ToInt16(pickRandomCard());
    static bool IsGameOver(int points)
    {
        bool isGameOver = false;
        if (points <= 0)
        {
            isGameOver = true;
        }
        return isGameOver;
    }

    static bool IsWinner(List<int> deck, int points)
    {
        bool isWinner = false;
        int decklength = deck.Count();
    if (decklength == 0 || points > 0){
        isWinner = true;
        }
    return isWinner;
    }

    

    public object GuessCard(){
        int randomCard = Convert.ToInt16(pickRandomCard());
        Console.WriteLine($"your number is :{randomCard}");
        Console.WriteLine($"Is the next card Higher or Lower?");
        string? playerGuess = Console.ReadLine();
        return playerGuess;
      
    }
    public object pickNextCard(){
        Random rnd = new Random();
        int randCardIndex = rnd.Next(deckOfCards.Count);
        int nextCard = deckOfCards[randCardIndex];  
        return nextCard;
}
}