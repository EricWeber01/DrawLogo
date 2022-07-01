using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace DrawLogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        void print(int x, int y, Color C)
        {
            Graphics g = CreateGraphics();
            Pen pen = new Pen(C, 5.0f);
            g.DrawLine(pen, x + 132, y + 10, x + 57, y + 65);
            g.DrawLine(pen, x + 57, y + 65, x + 43, y + 103);
            g.DrawLine(pen, x + 43, y + 103, x + 74, y + 197);
            g.DrawLine(pen, x + 74, y + 197, x + 106, y + 221);
            g.DrawLine(pen, x + 106, y + 221, x + 206, y + 221);
            g.DrawLine(pen, x + 206, y + 221, x + 239, y + 197);
            g.DrawLine(pen, x + 239, y + 197, x + 265, y + 103);
            g.DrawLine(pen, x + 265, y + 103, x + 254, y + 65);
            g.DrawLine(pen, x + 254, y + 65, x + 173, y + 10);
            g.DrawLine(pen, x + 173, y + 10, x + 132, y + 10);

            g.DrawLine(pen, x + 57, y + 65, x + 90, y + 170);
            g.DrawLine(pen, x + 90, y + 170, x + 118, y + 170);
            g.DrawLine(pen, x + 173, y + 10, x + 88, y + 74);
            g.DrawLine(pen, x + 88, y + 74, x + 94, y + 100);
            g.DrawLine(pen, x + 265, y + 103, x + 178, y + 43);
            g.DrawLine(pen, x + 178, y + 43, x + 157, y + 58);
            g.DrawLine(pen, x + 74, y + 197, x + 182, y + 197);
            g.DrawLine(pen, x + 182, y + 197, x + 191, y + 170);
            g.DrawLine(pen, x + 206, y + 221, x + 236, y + 116);
            g.DrawLine(pen, x + 236, y + 116, x + 213, y + 100);

            g.DrawLine(pen, x + 157, y + 58, x + 94, y + 100);
            g.DrawLine(pen, x + 94, y + 100, x + 118, y + 170);
            g.DrawLine(pen, x + 118, y + 170, x + 191, y + 170);
            g.DrawLine(pen, x + 191, y + 170, x + 213, y + 100);
            g.DrawLine(pen, x + 213, y + 100, x + 157, y + 58);
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = C;
            label1.Location = new Point(x + 53, y + 230);
            label1.Size = new Size(207, 42);
            label1.Text = "OverLight";
            Controls.Add(label1);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            print(50, 50, Color.Yellow);
        }
    }
}
