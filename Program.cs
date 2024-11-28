using SDLab7.Interfaces;
using SDLab7.Models;

namespace SDLab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfectioneryFactory chocolateFactory = new ChocolateFactory();
            Console.WriteLine(chocolateFactory.CreateCandy().GetCandyInfo());
            Console.WriteLine(chocolateFactory.CreateCake().GetCakeInfo());

            IConfectioneryFactory caramelFactory = new CaramelFactory();
            Console.WriteLine(caramelFactory.CreateCandy().GetCandyInfo());
            Console.WriteLine(caramelFactory.CreateCake().GetCakeInfo());
        }
    }
}
