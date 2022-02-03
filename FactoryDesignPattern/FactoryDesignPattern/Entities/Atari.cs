using System;


namespace FactoryDesignPattern.Entities
{
    public class Atari : IGame
    {
        public void Platform()
        {
            Console.WriteLine("This game runs on Atari platform.");
        }
    }
}
