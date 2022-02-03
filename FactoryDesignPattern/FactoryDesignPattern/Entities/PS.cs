using System;

namespace FactoryDesignPattern.Entities
{
   public class PS : IGame
    {
        public void Platform()
        {
            Console.WriteLine("This game runs on PS platform.");
        }
    }
}
