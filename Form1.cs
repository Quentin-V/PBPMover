using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBPMover
{
    public partial class Fenetre : Form
    {
        public Fenetre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void brnMoveClick(object sender, EventArgs e)
        {
            WindowScrape.Types.HwndObject pbpWindow = WindowScrape.Types.HwndObject.GetWindowByTitle("Penumbra");
            String sX = tbX.Text;
            String sY = tbY.Text;
            int x = Int16.Parse(sX) - 3;
            int y = Int16.Parse(sY) - 26;
            pbpWindow.Location = new Point(x, y);
        }
    }
}
