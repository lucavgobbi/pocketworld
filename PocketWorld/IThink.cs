using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketWorld.Auxiliar;

namespace PocketWorld
{
    public interface IThing
    {
        Move DoMove();

        void Generate();
    }
}
