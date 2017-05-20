using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace PictureBox
{
    public partial class Form1 : Form
    {

        GraphicsPath gp = new GraphicsPath();
        Graphics g;
        Bitmap bmp;
        Brush brush;
        Pen p = new Pen(Color.Red);
        public static int x;
        public static int y;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
            brush = new SolidBrush(Color.Red);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            gp.Reset();
            gp.AddEllipse(x, y, 50, 50);
            g.FillEllipse(brush, x, y, 50, 50);


            g.DrawPath(p, gp);
            pictureBox1.Refresh();

        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }
      /*  public static void Points()
        {
            int x1 = x;
            int y1 = y;
        }
        */
        private void timer1_Tick(object sender, EventArgs e)
        {
           /* Points();
            y1 += 10;
       
            Refresh(); */
        }
        
    }
}
