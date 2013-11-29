using PocketWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalRunner
{
    public class GraphicInterfaceImplementation : PocketWorld.Auxiliar.GraphicsInterface
    {
        PictureBox _obj;
        int _width;
        int _height;

        public GraphicInterfaceImplementation(PictureBox obj, int width, int height)
        {
            _width = width;
            _height = height;
            _obj = obj;
        }

        public override void AfterTurn(IEnumerable<IThing>[,] map) 
        { 
            for(int x = 0; x < _width; x++)
            {
                for(int y = 0; y < _height; y++)
                {
                    if (map[x, y] != null)
                    {
                        var player = map[x, y].FirstOrDefault();
                        if (player != null)
                        {
                            _obj.Top = 500 - y * 5;
                            _obj.Left = x * 5;
                        }
                    }
                }
            }
        }

        public override void AfterPlayerTurn(IEnumerable<IThing>[,] map, PocketWorld.Auxiliar.PlayerPosition position)
        {
            throw new NotImplementedException();
        }

        public override void Init(IEnumerable<IThing>[,] map)
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    if (map[x, y] != null)
                    {
                        var player = map[x, y].FirstOrDefault();
                        if (player != null)
                        {
                            _obj.Top = 500 - y * 5;
                            _obj.Left = x * 5;
                        }
                    }
                }
            }
        }
    }
}
