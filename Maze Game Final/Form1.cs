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
        int seconds = 0;

        public mazeForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
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
            //this displays the mouse and cheese images in my form
          





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
                    //this allows the user to move the mouse with the "WASD" keys
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
            if (mouse.IntersectsWith(cheese))
                currentTimer.Enabled = false;
            //this will stop the timer when the mouse reaches the cheese

        }
    

private void mouseMovement()
        {
         
            if (wPressed)
                mouse.Y -= stepSize;
            if (sPressed)
                mouse.Y += stepSize;
            if (aPressed)
                mouse.X -= stepSize;
            if (dPressed)
                mouse.X += stepSize;

        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            label3.Text = currentTimer.ToString();
            seconds++;
            label3.Text = seconds.ToString();
            // this will display a counting of seconds on the timer label

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mouse.X = 20;
            mouse.Y = 50;
            Invalidate();
            currentTimer.Enabled = false;
            label3.Text = "0";wa

            
            
        }
    }
}


