using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketWorld.Auxiliar
{
    public abstract class GraphicsInterface
    {
        public virtual void AfterPlayerTurn(IEnumerable<IThing>[,] map, PlayerPosition position) { }

        public virtual void AfterTurn(IEnumerable<IThing>[,] map) { }

        public virtual void Init(IEnumerable<IThing>[,] map) { }
    }
}
