using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellularAutomata
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] ruleSets = { 30, 90, 110, 184, 222 };
            
            for (int i = 0; i < ruleSets.Length; i++)
            {
                RulesLbl.Text += ruleSets[i].ToString();
                RulesLbl.Text += (i != ruleSets.Length - 1) ? ", " : "";
            }            
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(RuleTb.Text);
            f.Show();
        }
    }
}
