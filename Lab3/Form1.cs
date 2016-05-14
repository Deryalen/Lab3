using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics picture = e.Graphics;
            Circle c1 = new Circle(10, 10, 50);
            c1.move(10, 10);
            Draw(picture, c1);
        }

        void Draw(Graphics g, Circle toDraw)
        {
            Pen p1 = new Pen(Color.DarkMagenta);
            Pen p2 = new Pen(Color.Black);

            g.DrawEllipse(p1, toDraw.X, toDraw.Y, toDraw.X + toDraw.Radius, toDraw.Y + toDraw.Radius);
        }
    }
}
