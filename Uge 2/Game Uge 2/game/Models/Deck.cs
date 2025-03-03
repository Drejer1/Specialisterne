using game.Models;
using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class Deck
{
    private List<Card> cards = new List<Card>();

    private Random rand = new Random();
	private List<Card> Standarddeck = new List<Card>(); 
    
    public Deck()
	{
		List<string> colors = new List<string>{"Club","Spade","Diamond","Heart"};
		List<string> values = new List<string>{ "Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"};
		
		
		foreach(string color in colors)
		{
			foreach(string value in values)
			{
				cards.Add(new Card(color,value));
                
            }
		}
		Console.WriteLine(cards.Count());
	}

	public void shuffleDeck()
	{
		int n = cards.Count();
		while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            Card temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }
	public Card hit()
	{
		Card draw = cards[0];
		cards.RemoveAt(0);
		return draw;
	}
	public void resetDeck()
	{
		cards = new List<Card>(Standarddeck);
	}




	
}
