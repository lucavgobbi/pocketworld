using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketWorld;
using PocketWorld.Auxiliar;

namespace DemoPlayer
{
    public class DemoPlayer : IPlayer
    {
        public Move DoMove()
        {
            return new Move(1, 1);
        }

        public void Generate()
        {
            
        }
    }
}
