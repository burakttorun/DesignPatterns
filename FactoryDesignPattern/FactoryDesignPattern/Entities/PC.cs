using System;


namespace FactoryDesignPattern.Entities
{
   public class PC : IGame
    {
        public void Platform()
        {
            Console.WriteLine("This game runs on PC platform.");
        }
    }
}
