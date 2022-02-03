using FactoryDesignPattern.Entities;
using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();

           IGame atariGame = creator.Factory(GameType.Atari);
           IGame pcGame = creator.Factory(GameType.PC);
           IGame psGame = creator.Factory(GameType.PS);

            atariGame.Platform();
            pcGame.Platform();
            psGame.Platform();

            Console.ReadLine();
        }
    }
}
