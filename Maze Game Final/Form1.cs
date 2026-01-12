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
    }
}

