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
        Image mouseCute = Properties.Resources.mouseCute;
        //initial location of my hero (Han Solo)
        Rectangle mouse = new Rectangle(20, 50, 70, 70);
        //make booleans for movement
        Boolean wPressed = false;
        Boolean sPressed = false;
        Boolean aPressed = false;
        Boolean dPressed = false;

        int stepSize = 20;
        Rectangle cheese = new Rectangle(520, 300, 70, 70);
        Image cheesePic = Properties.Resources.cheesePic;

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

            g.DrawImage(cheesePic, cheese);
            g.DrawImage(mouseCute, mouse);
          





        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mazeForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
            }

        }

        private void mazeForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            mouseMovement();
            Invalidate();
        }
    

private void mouseMovement()
        {
            //The rectangle object has .X and .Y .Width and .Height parameters
            // this is how we change the .X and .Y
            // You could try to add code to change the size when 
            // a user hits a particular key!
            if (wPressed)
                mouse.Y -= stepSize;
            if (sPressed)
                mouse.Y += stepSize;
            if (aPressed)
                mouse.X -= stepSize;
            if (dPressed)
                mouse.X += stepSize;

        }

    }
}


