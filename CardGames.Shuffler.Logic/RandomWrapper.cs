using System;

namespace CardGames.Shuffler.Logic
{
    public class RandomWrapper : IWrapRandom
    {
        private Random _random;

        public void Create()
        {
            _random = new Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }
    }
}