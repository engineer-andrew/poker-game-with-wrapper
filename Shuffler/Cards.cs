using System;
using System.Collections.Generic;

namespace Shuffler
{
    public class Cards
    {
        private readonly Dictionary<int, string> _deck = new Dictionary<int, string>
        {
            {1, "AH"},
            {2, "2H"},
            {3, "3H"},
            {4, "4H"},
            {5, "5H"},
            {6, "6H"},
            {7, "7H"},
            {8, "8H"},
            {9, "9H"},
            {10, "10H"},
            {11, "JH"},
            {12, "QH"},
            {13, "KH"},
            {14, "AD"},
            {15, "2D"},
            {16, "3D"},
            {17, "4D"},
            {18, "5D"},
            {19, "6D"},
            {20, "7D"},
            {21, "8D"},
            {22, "9D"},
            {23, "10D"},
            {24, "JD"},
            {25, "QD"},
            {26, "KD"},
            {27, "AC"},
            {28, "2C"},
            {29, "3C"},
            {30, "4C"},
            {31, "5C"},
            {32, "6C"},
            {33, "7C"},
            {34, "8C"},
            {35, "9C"},
            {36, "10C"},
            {37, "JC"},
            {38, "QC"},
            {39, "KC"},
            {40, "AS"},
            {41, "2S"},
            {42, "3S"},
            {43, "4S"},
            {44, "5S"},
            {45, "6S"},
            {46, "7S"},
            {47, "8S"},
            {48, "9S"},
            {49, "10S"},
            {50, "JS"},
            {51, "QS"},
            {52, "KS"}
        };

        public void Shuffle()
        {
            var deck = new Deck { Cards = new List<string>(), IsShuffled = false };

            while (deck.Cards.Count < 52)
            {
                var position = Randomizer.Cards.GetRandomCardNumber();
                if (!deck.Cards.Contains(_deck[position]))
                {
                    deck.Cards.Add(_deck[position]);
                }
            }

            deck.Cards.ForEach(Console.WriteLine);
        }
    }
}