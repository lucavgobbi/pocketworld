using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = new PocketWorld.World(100, 100);

            var players = new List<PocketWorld.IPlayer> { new DemoPlayer.DemoPlayer() };

            world.SetPlayers(players);

            for(int i = 0; i < 10; i++)
            {
                world.PlayTurn();
            }
           
        }
    }
}
