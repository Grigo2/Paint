using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cslab4
{
    public partial class Form1 : Form
    {
        
        abstract public class Shape
        {
            public int x, y;
            public Pen pen;          
            public static Graphics g;

            public Shape()
            {              
                pen = new Pen(Color.Black, 4);
            }

            virtual public void StartDraw(MouseEventArgs e)
            {
                x = e.X;
                y = e.Y;
            }

            virtual public void MoveDraw(MouseEventArgs e)
            {

            }

            abstract public void DrawShape(MouseEventArgs e);
        }

        public class Line : Shape
        {          
            override public void DrawShape(MouseEventArgs e)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
            }
        }

        public class Points : Shape
        {
            private bool move = false;

            override public void StartDraw(MouseEventArgs e)
            {
                base.StartDraw(e);
                move = true;
            }

            override public void MoveDraw(MouseEventArgs e)
            {
                if (move) 
                {
                    g.DrawLine(pen, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }
            }

            override public void DrawShape(MouseEventArgs e)
            {
                move = false;
                x = -1;
                y = -1;
            }
        }

        public class Square : Shape
        {
            override public void DrawShape(MouseEventArgs e)
            {
                g.DrawRectangle(pen, x, y, Math.Abs(e.X - x), Math.Abs(e.Y - y));
            }
        }

        Shape s = new Line();      

        public Form1()
        {
            InitializeComponent();
            Shape.g = panel1.CreateGraphics();
            showBox.Text = s.pen.Width.ToString();
        }


        private void color1_Click(object sender, EventArgs e)
        {
            s.pen.Color = color1.BackColor;
            
        }

        private void color2_Click(object sender, EventArgs e)
        {
            s.pen.Color = color2.BackColor;
        }

        private void color3_Click(object sender, EventArgs e)
        {
            s.pen.Color = color3.BackColor;
        }

        private void color4_Click(object sender, EventArgs e)
        {
            s.pen.Color = color4.BackColor;
        }

        private void shape1_Click(object sender, EventArgs e)
        {
            s = new Line();
            
        }

        private void shape2_Click(object sender, EventArgs e)
        {
            s = new Points();
        }

        private void shape3_Click(object sender, EventArgs e)
        {
            s = new Square();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            s.StartDraw(e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            s.MoveDraw(e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            s.DrawShape(e);    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //size-
        private void button1_Click(object sender, EventArgs e)
        {
            if (s.pen.Width <= 2)
                button1.Enabled = false;
            else
                button1.Enabled = true;
            s.pen.Width -= 1;

            showBox.Text = s.pen.Width.ToString();

            if (s.pen.Width < 15)
                button2.Enabled = true;
        }

        //size+
        private void button2_Click(object sender, EventArgs e)
        {
            if (s.pen.Width >= 14)
                button2.Enabled = false;
            else
                button2.Enabled = true;
            s.pen.Width += 1;

            showBox.Text = s.pen.Width.ToString();

            if (s.pen.Width > 1)
                button1.Enabled = true;
        }

        private void showBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
