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
        SolidBrush yellowBrush = 
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
            Pen wallPen = new Pen(Color.Black, 4);
            int cell = 40; //this is the size of each maze square

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

