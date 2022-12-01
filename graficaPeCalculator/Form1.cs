using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace graficaPeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public Graphics g;
       
        public Pen p = new Pen(Color.Black);
        public Brush b = new SolidBrush(Color.Black);
        public Font f;

        public int x1, y1, x2, y2;
       

        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            while( i < 50){
                
                g.Clear(Color.White);

                g.FillRectangle(b, x1=x1+i, y1=y1+i, x2=x2+i*2, y2=y2+i*2);
                        
                i += 5;
                        
                Thread.Sleep(20);
                        
            };

           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
           
            f = Font;
            x1 = y1 = 1;
            y2 = x2 = 2;
           

           

           
        }

        private void decreaseSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 50;
            while (i > 5)
            {

                g.Clear(Color.White);

                g.FillRectangle(b, x1 = x1 - i, y1 = y1 - i, x2 = x2 - i * 2, y2 = y2 - i * 2);

                i-= 5;

                Thread.Sleep(20);

            };
        }
    }
}
