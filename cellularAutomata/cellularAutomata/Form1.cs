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
            int cellSize = 10;
            int generations = 40;

            Bitmap bm = new Bitmap(Canvas.Width, Canvas.Height);            
            CA ca = new CA(cellSize, Canvas.Width / cellSize);

            for (int i = 0; i < generations; i++)
            {
                Canvas.Image = ca.drawCA(bm);
                ca.generate();
            }
        }


    }
}
