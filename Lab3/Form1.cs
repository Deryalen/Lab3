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
            Cylinder r1 = new Cylinder(250, 100, 200, 20);
            c1.Move(0, 100);
            Brush b1 = new SolidBrush(Color.Silver);
            Pen p1 = new Pen(Color.DarkViolet);
            r1.Draw(picture, p1, b1);
        }
    }
}
