// See https://aka.ms/new-console-template for more information
using game.Models;

Console.WriteLine("Hello, World!");


var player = new Player();
player.drawCard(new Card("Red", "Ace"));
player.drawCard(new Card("Red", "King"));
player.drawCard(new Card("Red", "Queen"));
Console.WriteLine(player.countPoints());

Deck dec = new Deck();

int two = 1 + 1;
