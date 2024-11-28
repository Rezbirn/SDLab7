using SDLab7.Interfaces;

namespace SDLab7.Models
{
    internal class CaramelFactory : IConfectioneryFactory
    {
        public ICake CreateCake()
        {
            return new CaramelCake();
        }

        public ICandy CreateCandy()
        {
            return new CaramelCandy();
        }
    }
}
