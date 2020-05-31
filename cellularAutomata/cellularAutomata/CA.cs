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
        int[] ruleSet = { 0, 1, 0, 1, 1, 0, 1, 0 };
        int[] cells;
        int cellSize;
        int generation = 0;

        public CA(int size, int width)
        {            
            cells = new int[width];

            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = 0;
            }

            cells[cells.Length / 2] = 1;
            cellSize = size;
        }

        public void generate()
        {
            int[] nextGen = new int[cells.Length];

            for (int i = 1; i < cells.Length - 1; i++)
            {
                int left = cells[i - 1];
                int mid = cells[i];
                int right = cells[i + 1];

                nextGen[i] = rules(left, mid, right);
            }

            cells = nextGen;
            generation++;
        }

        private int rules(int a, int b, int c)
        {
            int[] bits = { a, b, c };

            // 2^2 + 2^1 + 2^0
            int index = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                index = (index << 1) | bits[i];
            }

            //Console.Write(a + ", " + b + ", " + c + " = ");
            //Console.WriteLine(index);
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
