using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalRunner
{
    public partial class main : Form
    {
        private GraphicInterfaceImplementation graphicInterface;
        PocketWorld.World _world;

        public main()
        {
            InitializeComponent();

            _world = new PocketWorld.World(100, 100);

            var players = new List<PocketWorld.IPlayer> { new DemoPlayer.DemoPlayer() };

            graphicInterface = new GraphicInterfaceImplementation(this.point, 100, 100);

            _world.SetPlayers(players, graphicInterface);
        }

        private void main_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _world.PlayTurn(graphicInterface);
        }
    }
}
