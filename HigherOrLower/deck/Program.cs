class Program {

    static void Main(string[] args) {
        DisplayWelcomeMessage();

        // Create a new Deck object
        Deck deckOfCards = new Deck();

        // Loop continuously until the deck no longer has any cards
        while (deckOfCards.HasMoreCards()) {

            // Draw a random card from the deck
            Card randomCard = deckOfCards.DrawRandomCard();
            
            // Print the card description to the console
            Console.WriteLine(randomCard.Description());

            // Wait .25 seconds so that this process goes slowly
            Thread.Sleep(250);
        }

        Console.WriteLine("");
        Console.WriteLine("The Deck is now out of cards...");
        Console.WriteLine("This concludes our demo. Have a nice day!");
    }

    static void DisplayWelcomeMessage() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("############################");
        Console.WriteLine("Deck of Cards demo commence!");
        Console.WriteLine("############################");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }
}
