using OpenTK.Graphics.OpenGL;
using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };
        double[] dates;
        double[] avg;
        double[] min;
        double[] max;
        
        public Form1()
        {
            InitializeComponent();

            // Add the FormsPlot to the panel
            panel1.Controls.Add(FormsPlot1);
            //DateTime[] dates = Generate.ConsecutiveDays(15);
            //double[] ys1 = Generate.RandomWalk(15);
            //double[] ys2 = Generate.RandomWalk(15);
            //var scat1 = FormsPlot1.Plot.Add.Scatter(dates, ys1);
            //var scat2 = FormsPlot1.Plot.Add.Scatter(dates, ys2);

            //scat1.Axes.YAxis = FormsPlot1.Plot.Axes.Left;
            //scat2.Axes.YAxis = FormsPlot1.Plot.Axes.Right;

            //FormsPlot1.Plot.Axes.Left.Label.Text = "Left Axis";
            //FormsPlot1.Plot.Axes.Right.Label.Text = "Right Axis";
            //FormsPlot1.Plot.Axes.Left.Label.ForeColor = scat1.Color;
            //FormsPlot1.Plot.Axes.Right.Label.ForeColor = scat2.Color;

            //double xValue = dates[5]; // 데이터 포인트의 X 값
            //double yValue = ys1[5]; // 데이터 포인트의 Y 값
            //FormsPlot1.Plot.Add.Callout();

            ////FormsPlot1.Plot.Add.Callout("World", textLocation: (10, 0), tipLocation: (xs[13], ys[13]));

            //// tell the plot to display dates on the bottom axis
            //FormsPlot1.Plot.Axes.DateTimeTicksBottom();

            
            //FormsPlot1.Refresh();




        }
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = Cursor.Position.X.ToString();
            label2.Text = Cursor.Position.Y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;

        }
    }
}
