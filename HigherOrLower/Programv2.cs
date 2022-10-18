using System;
using System.Collections.Generic;

class Program
{
     Deck deck = new Deck();
        int points = 300;
    
    public void drawRandomCard();

    static void Main(string[] args){
        DisplayWelcomeMessage();

    }

    static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome");
        Thread.Sleep(250);
        Console.WriteLine("to");
        Thread.Sleep(250);
        Console.WriteLine("Our");
        Thread.Sleep(250);
        Console.WriteLine("Card");
        Thread.Sleep(250);
        Console.WriteLine("Game!");
    }
}