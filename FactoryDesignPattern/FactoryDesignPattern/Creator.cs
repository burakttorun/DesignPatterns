using FactoryDesignPattern.Entities;
namespace FactoryDesignPattern
{
    public enum GameType
    {
        Atari,
        PC,
        PS
    }
    public class Creator
    {
        public IGame Factory(GameType gameType)
        {
            IGame game = null;
            switch (gameType)
            {
                case GameType.Atari:
                    game = new Atari();
                    break;

                case GameType.PC:
                    game = new PC();
                    break;

                case GameType.PS:
                    game = new PS();
                    break;
            }
            return game;
        }
    }
}
