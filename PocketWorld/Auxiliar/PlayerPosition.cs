using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld.Auxiliar
{
    public class PlayerPosition
    {
        public IPlayer Player { get; set; }
        public Position Position { get; set; }

        public PlayerPosition(IPlayer player, Position position)
        {
            Player = player;
            Position = position;
        }
    }
}
