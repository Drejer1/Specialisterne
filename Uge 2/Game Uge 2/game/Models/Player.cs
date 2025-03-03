﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Models
{
    class Player
    {
        private static readonly Dictionary<string, int> pointSystem = new Dictionary<string, int>
        {
            {"Two",2},
            {"Three",3},
            {"Four",4},
            {"Five",5},
            {"Six",6},
            {"Seven",7},
            {"Eight",8},
            {"Nine",9},
            {"Ten",10},
            {"Jack",10},
            {"Queen",10},
            {"King",10},
            {"Ace",11}
        };
        private int numberOfAces = 0;
        public int Points { { } }
        List<Card> Hand = new List<Card>();
        public void drawCard(Card card)
        {   
            if (card.Number == "Ace")
            {
                numberOfAces++; 
            }
            Hand.Add(card);

        }
        public int countPoints()
        {
            int points = 0;
            foreach(Card card in Hand)
            {
                points += pointSystem[card.Number];
            }
            int availableAces = numberOfAces;
            
            while (points > 21 && availableAces > 0)
            {
                points -= 10;
                availableAces--;
            }
            return points;
        }
    }
}
