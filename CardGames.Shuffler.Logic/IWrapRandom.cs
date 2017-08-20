namespace CardGames.Shuffler.Logic
{
    public interface IWrapRandom
    {
        void Create();

        int Next(int minValue, int maxValue);
    }
}