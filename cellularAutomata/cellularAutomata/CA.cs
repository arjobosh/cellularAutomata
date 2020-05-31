using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cellularAutomata
{
    class CA
    {
        int[] cells;
        int cellSize;
        int ruleSet;
        int generation;

        public CA(int size, int width, int setNumber)
        {            
            cells = new int[width];

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = 0;
            }

            cells[cells.Length / 2] = 1;
            cellSize = size;
            ruleSet = setNumber;
            generation = 0;
        }

        public void generate()
        {            
            int[] nextGen = new int[cells.Length];

            for (int i = 1; i < cells.Length - 1; i++)
            {
                int left = cells[i - 1];
                int mid = cells[i];
                int right = cells[i + 1];

                nextGen[i] = rules(left, mid, right, ruleSet);
            }

            cells = nextGen;
            generation++;
        }

        private int rules(int a, int b, int c, int set)
        {            
            int[] bits = { a, b, c };   // neighborhood of left, middle, and right cells
            int index = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                // getting the bits as int
                index = (index << 1) | bits[i];
            }

            //Console.Write(a + ", " + b + ", " + c + " = ");
            //Console.WriteLine(index);

            int[] ruleSet;

            switch (set)
            {
                case 30:
                    ruleSet = new int[8] { 0, 1, 1, 1, 1, 0, 0, 0 };
                    break;
                case 90:
                    ruleSet = new int[8] { 0, 1, 0, 1, 1, 0, 1, 0 };                    
                    break;
                case 110:
                    ruleSet = new int[8] { 0, 1, 1, 0, 1, 1, 1, 0 };
                    break;
                case 184:
                    ruleSet = new int[8] { 1, 0, 1, 1, 1, 0, 0, 0 };
                    break;
                case 222:
                    ruleSet = new int[8] { 1, 1, 0, 1, 1, 1, 1, 0 };
                    break;                
                default:
                    ruleSet = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
                    break;
            }

            return ruleSet[index];
        }
        
        public Bitmap drawCA(Bitmap bm)
        {
            using (Graphics g = Graphics.FromImage(bm))
            {
                Color c;
                for (int i = 0; i < cells.Length; i++)
                {
                    if (cells[i] == 1)
                    {
                        c = Color.Black;
                    }
                    else
                    {
                        c = Color.White;
                    }
                    
                    Rectangle r = new Rectangle(i * cellSize, generation * cellSize, cellSize, cellSize);
                    g.DrawRectangle(new Pen(c), r);
                    g.FillRectangle(new SolidBrush(c), r);
                }
            }

            return bm;
        }
    }
}
