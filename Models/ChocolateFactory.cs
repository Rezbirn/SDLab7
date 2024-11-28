using SDLab7.Interfaces;

namespace SDLab7.Models
{
    internal class ChocolateFactory : IConfectioneryFactory
    {
        public ICake CreateCake()
        {
            return new ChocolateCake();
        }

        public ICandy CreateCandy()
        {
            return new ChocolateCandy();
        }
    }
}
