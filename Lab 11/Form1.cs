using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.Silver);
            g.DrawEllipse(Pens.Black, 400, 20, 300, 200);
            g.DrawRectangle(Pens.Black, 410, 150, 100, 250);
            g.DrawLine(Pens.Black, 600, 600, 700, 300);


            g.FillRectangle(Brushes.Purple, 350, 100, 100, 200);
            g.FillEllipse(Brushes.Black, 500, 180, 400, 100);


            Brush blueBrush = new SolidBrush(Color.Blue);

            // Create points that define polygon.
            Point points1 = new Point(100, 100);
            Point points2 = new Point(200, 50);
            Point points3 = new Point(200, 5);
            Point points4 = new Point(250, 50);
            Point points5 = new Point(300, 100);
            Point points6 = new Point(350, 200);
            Point points7 = new Point(350, 350);
            Point[] curvePoints = {
                points1,
                points2,
                points3,
                points4,
                points5,
                points6,
                points7,
            };
        }
    }
}
