using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game_Final
{
    public partial class mazeForm : Form

    {
        
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);


        public mazeForm()
        {
            InitializeComponent();
        }

        private void mazeForm_Load(object sender, EventArgs e)
        {

        }

        private void mazeForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen wallPen = new Pen(Color.Yellow, 4);
            
            g.DrawLine(wallPen, 100, 30, 100, 200);
            g.DrawLine(wallPen, 100, 200, 200, 200);
            g.DrawLine(wallPen, 200, 200, 200, 100);
            g.DrawLine(wallPen, 200, 100, 300, 100);
            g.DrawLine(wallPen, 300, 100, 300, 300);
            g.DrawLine(wallPen, 300, 300, 500, 300);
            g.DrawLine(wallPen, 0, 300, 200, 300);
            g.DrawLine(wallPen, 200, 300, 200, 400);
            g.DrawLine(wallPen, 200, 400, 500, 400);
            g.DrawLine(wallPen, 100, 200, 100, 30);

            Pen pen = new Pen(Color.Black);
            Brush bodybrush = new SolidBrush(Color.LightGray);
            Brush earBrush = new SolidBrush(Color.Pink);
            Brush eyebrush = new SolidBrush(Color.Black);
            g.FillEllipse(bodybrush, 100, 300, 200, 100);
            g.DrawEllipse(pen, 100, 300, 200, 100);
            g.FillEllipse(bodybrush, 50, 280, 80, 80);
            g.FillEllipse(earBrush, 80, 360, 40, 40);
            g.FillEllipse(earBrush, 40, 260, 40, 40);
            g.FillEllipse(earBrush, 80, 260, 40, 40);
            g.FillEllipse(eyebrush, 80, 310, 8, 8);
            g.FillEllipse(Brushes.Pink, 45, 320, 6, 6);
            





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
            }
        }

        private void mazeForm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

