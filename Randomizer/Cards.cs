using System;

namespace Randomizer
{
    public static class Cards
    {
        public static int GetRandomCardNumber()
        {
            var random = new Random();
            return random.Next(1, 53);
        }
    }
}