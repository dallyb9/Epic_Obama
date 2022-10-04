using System;
using System.Collections.Generic;

class Deck {
    // Make four suits with 13 cards each

    // List<string> spaces = new List<string>();
    IDictionary<int, int> deckOfCards = new Dictionary<int, int>();
    public Deck(){
    
    
    deckOfCards.Add(1,  1);
    deckOfCards.Add(2,  2);
    deckOfCards.Add(3,  3);
    deckOfCards.Add(4,  4);
    deckOfCards.Add(5,  5);
    deckOfCards.Add(6,  6);
    deckOfCards.Add(7,  7);
    deckOfCards.Add(8,  8);
    deckOfCards.Add(9,  9);
    deckOfCards.Add(10, 10);
    deckOfCards.Add(11, 11);
    deckOfCards.Add(12, 12);
    deckOfCards.Add(13, 13);

    deckOfCards.Add(14,  1);
    deckOfCards.Add(15,  2);
    deckOfCards.Add(16,  3);
    deckOfCards.Add(17,  4);
    deckOfCards.Add(18,  5);
    deckOfCards.Add(19,  6);
    deckOfCards.Add(20,  7);
    deckOfCards.Add(21,  8);
    deckOfCards.Add(22,  9);
    deckOfCards.Add(23, 10);
    deckOfCards.Add(24, 11);
    deckOfCards.Add(25, 12);
    deckOfCards.Add(26, 13);

    deckOfCards.Add(27,  1);
    deckOfCards.Add(28,  2);
    deckOfCards.Add(29,  3);
    deckOfCards.Add(30,  4);
    deckOfCards.Add(31,  5);
    deckOfCards.Add(32,  6);
    deckOfCards.Add(33,  7);
    deckOfCards.Add(34,  8);
    deckOfCards.Add(35,  9);
    deckOfCards.Add(36, 10);
    deckOfCards.Add(37, 11);
    deckOfCards.Add(38, 12);
    deckOfCards.Add(39, 13);

    deckOfCards.Add(40,  1);
    deckOfCards.Add(41,  2);
    deckOfCards.Add(42,  3);
    deckOfCards.Add(43,  4);
    deckOfCards.Add(44,  5);
    deckOfCards.Add(45,  6);
    deckOfCards.Add(46,  7);
    deckOfCards.Add(47,  8);
    deckOfCards.Add(48,  9);
    deckOfCards.Add(49, 10);
    deckOfCards.Add(50, 11);
    deckOfCards.Add(51, 12);
    deckOfCards.Add(52, 13);
}
public object pickRandomCard(){
     Random rnd = new Random();
        int randCardIndex = rnd.Next(deckOfCards.Count);
        int randomCard = deckOfCards[randCardIndex];
        return randomCard;
    

        
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

public object points(){

    int previousCard = Convert.ToInt16(pickRandomCard());
    int nextCard = Convert.ToInt16(pickNextCard());
    string playerGuess = Convert.ToString(GuessCard());
    // string correctAnswer = ("");
    if (previousCard > nextCard){
        string correctAnswer = "Lower";
        return correctAnswer;
    };
    if (previousCard < nextCard){
        string correctAnswer = "Higher";
        return correctAnswer;
    };

    if  (playerGuess = correctAnswer){
        //  Add 100 points
        return playerGuess;
    }
    else if (playerGuess != correctAnswer){
        // remove 75 points
    }
    return correctAnswer;
    }

    int randomCard = Convert.ToInt16(pickRandomCard());

}
public void discard(){
    previousCard = pickRandomCard()
    deckOfCards.Remove(randCardIndex);
}
    spades.Remove(index)

   }
       
       
         // Make a function to randomly pick a suit and then randomly pick
    // a card within the suit, then remove that card from the list

    // Make a higher or lower guessing function for the player
    // And add/ subtract points when they get it right or wrong


    // Make a win condition when the player goes through all the cards
    // or when they get a certain amount of points

    // Make a lose conditinon when the player loses all their points
}

// make class with two attributes or properties suit and number
// object is the cards 

   
//     List<int> hearts = new List<int>(){
//         1,2,3,4,5,6,7,8,9,10,11,12,13
//     };
//     List<int> diamonds = new List<int>(){
//         1,2,3,4,5,6,7,8,9,10,11,12,13
//     };
//      List<int> clubs = new List<int>(){
//          1,2,3,4,5,6,7,8,9,10,11,12,13
//     };
//      List<int> spades = new List<int>(){
//          1,2,3,4,5,6,7,8,9,10,11,12,13
//     };
// List<string> suits = new List<string>(){
//         "hearts","diamonds","clubs","spades"
//     };



//    public void suitRandomizer(){
//         Random rnd = new Random();
//         int randSuitIndex = rnd.Next(suits.Count);
        
//         string randomSuit = suits[randSuitIndex];

//         int randCardIndex = rnd.Next(randomSuit.Count);
//    }
// public void cardRandomizer(){
// Random rnd = new Random();
 

  