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
        int ruleSetNum;
        int[] ruleSets = { 30, 90, 110, 184, 222 };

        public Form1(string number)
        {
            InitializeComponent();

            for (int r = 0; r < ruleSets.Length; r++)
            {
                if (ruleSets[r] == int.Parse(number))
                { 
                    ruleSetNum = r; 
                    break;
                }
                else
                {
                    ruleSetNum = -1;
                }               
            }

            Console.WriteLine(int.Parse(number));
            Console.WriteLine(ruleSetNum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutomateCellularly();
        }

        private void AutomateCellularly()
        {
            int cellSize = 8;
            int generations = 40;
            int defaultWidth = Canvas.Width;
            int defaultHeight = Canvas.Height;

            Bitmap bm = new Bitmap(defaultWidth, defaultHeight);
            ECA ca;

            if (ruleSetNum >= 0)
                ca = new ECA(cellSize, Canvas.Width / cellSize, ruleSets[ruleSetNum]);
            else
                ca = new ECA(cellSize, Canvas.Width / cellSize, 0);

            for (int i = 0; i < generations; i++)
            {
                Canvas.Image = ca.drawCA(bm);
                ca.generate();
            }
        }
    }
}
