using NewTanks.Game.Interfaces;

namespace NewTanks.Models
{
    public class GameFieldModel
    {
        public int FieldHeight => 20;
        public int FieldWidth => 20;

        public GameFieldModel(IGameTanks game)
        {
        }

    }
}
