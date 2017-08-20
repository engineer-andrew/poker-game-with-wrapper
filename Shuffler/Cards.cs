using System;
using System.Collections.Generic;

namespace POC.Shuffler
{
    public class Cards
    {
        private readonly Dictionary<int, string> _deck = new Dictionary<int, string>
        {
            {1, "AH"}, //0
            {2, "2H"}, //1
            {3, "3H"}, //2
            {4, "4H"}, //3
            {5, "5H"}, //4
            {6, "6H"}, //5
            {7, "7H"}, //6
            {8, "8H"}, //7
            {9, "9H"}, //8
            {10, "10H"}, //9
            {11, "JH"}, //10
            {12, "QH"}, //11
            {13, "KH"}, //12
            {14, "AD"}, //13
            {15, "2D"}, //14
            {16, "3D"}, //15
            {17, "4D"}, //16
            {18, "5D"}, //17
            {19, "6D"}, //18
            {20, "7D"}, //19
            {21, "8D"}, //20
            {22, "9D"}, //21
            {23, "10D"}, //22
            {24, "JD"}, //23
            {25, "QD"}, //24
            {26, "KD"}, //25
            {27, "AC"}, //26
            {28, "2C"}, //27
            {29, "3C"}, //28
            {30, "4C"}, //29
            {31, "5C"}, //30
            {32, "6C"}, //31
            {33, "7C"}, //32
            {34, "8C"}, //33
            {35, "9C"}, //34
            {36, "10C"}, //35
            {37, "JC"}, //36
            {38, "QC"}, //37
            {39, "KC"}, //38
            {40, "AS"}, //39
            {41, "2S"}, //40
            {42, "3S"}, //41
            {43, "4S"}, //42
            {44, "5S"}, //43
            {45, "6S"}, //44
            {46, "7S"}, //45
            {47, "8S"}, //46
            {48, "9S"}, //47
            {49, "10S"}, //48
            {50, "JS"}, //49
            {51, "QS"}, //50
            {52, "KS"} //51
        };

        public void Shuffle()
        {
            var deck = new Deck { Cards = new List<string>(), IsShuffled = false };

            while (deck.Cards.Count < 52)
            {
                var random = new Random();
                var position = random.Next(1, 53);

                if (!deck.Cards.Contains(_deck[position]))
                {
                    deck.Cards.Add(_deck[position]);
                }
            }

            deck.Cards.ForEach(Console.WriteLine);
        }
    }
}