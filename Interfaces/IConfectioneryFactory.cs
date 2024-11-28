namespace SDLab7.Interfaces
{
    internal interface IConfectioneryFactory
    {
        ICandy CreateCandy();
        ICake CreateCake();
    }
}
