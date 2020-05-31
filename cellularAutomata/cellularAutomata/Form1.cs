using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellularAutomata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            int cellSize = 8;
            int generations = 40;
            int defaultWidth = Canvas.Width;
            int defaultHeight = Canvas.Height;
            int[] ruleSets = { 30, 90, 110, 184, 222 };

            Bitmap bm = new Bitmap(defaultWidth, defaultHeight);

            CA ca = new CA(cellSize, Canvas.Width / cellSize, ruleSets[2]);

            for (int i = 0; i < generations; i++)
            {
                Canvas.Image = ca.drawCA(bm);
                ca.generate();
            }
        }
    }
}
