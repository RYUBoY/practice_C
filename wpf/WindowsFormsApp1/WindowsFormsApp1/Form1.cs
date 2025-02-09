﻿using OpenTK.Graphics.OpenGL;
using ScottPlot;
using ScottPlot.Hatches;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        public double[] dates;
        public double[] avg;
        public double[] min;
        public double[] max;
        public string Title => "Mouse Tracker";
        public string Description => "Demonstrates how to interact with the mouse " +
        "and convert between screen units (pixels) and axis units (coordinates)";

        readonly ScottPlot.Plottables.Crosshair CH;

        public Form1()
        {
            InitializeComponent();
            CH = FormsPlot1.Plot.Add.Crosshair(0, 0);
            CH.TextColor = Colors.White;
            CH.TextBackgroundColor = CH.HorizontalLine.Color;



            FormsPlot1.MouseMove += (s, e) =>
            {
                Pixel mousePixel = new(e.X, e.Y);
                Coordinates mouseCoordinates = FormsPlot1.Plot.GetCoordinates(mousePixel);
                this.Text = $"X={mouseCoordinates.X:N3}, Y={mouseCoordinates.Y:N3}";
                CH.Position = mouseCoordinates;
                CH.VerticalLine.Text = $"{mouseCoordinates.X:N3}";
                CH.HorizontalLine.Text = $"{mouseCoordinates.Y:N3}";
                FormsPlot1.Refresh();
            };

            

            // Add the FormsPlot to the panel
            panel1.Controls.Add(FormsPlot1);

            double[] dates = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            double[] avgs = { 26.3, 23.2, 24.7, 26.8, 23.4, 25.1, 24.4, 23.8, 24.5, 26.6, 25.7, 25.6, 28.1, 28.4, 28.4, 27, 25.4, 24.3, 27, 27.2, 26.5, 26.6, 26.4, 28.1, 28.8, 28.7, 28.9, 29.2 };
            double[] mins = { 22, 21.9, 23.6, 23.2, 21.3, 22.1, 21.5, 23.1, 22.7, 22.7, 23.3, 21.8, 23.5, 24.9, 24.5, 24.6, 24.1, 23.1, 24.2, 25.1, 22.5, 24.3, 25.8, 26, 25.4, 25.2, 27.5, 27.3 };
            double[] maxs = { 31.3, 25.2, 25.9, 30.6, 26.1, 30, 28.2, 24.5, 26.7, 31.1, 28.9, 30.2, 33.3, 32.1, 31.3, 30.7, 28.1, 25.6, 30.8, 30.6, 29.8, 27.9, 27.3, 30.9, 32.2, 32.7, 31.7, 32.2 };


            //DateTime[] dates = Generate.ConsecutiveDays(15);
            //double[] ys1 = Generate.RandomWalk(15);
            //double[] ys2 = Generate.RandomWalk(15);


            var scat1 = FormsPlot1.Plot.Add.Scatter(dates, mins);
            var scat2 = FormsPlot1.Plot.Add.Scatter(dates, maxs);
            var yAxis2 = FormsPlot1.Plot.Axes.AddLeftAxis();

            scat1.Axes.YAxis = FormsPlot1.Plot.Axes.Left;
            scat2.Axes.YAxis = FormsPlot1.Plot.Axes.Right;

            scat1.Axes.XAxis = FormsPlot1.Plot.Axes.Bottom; // standard X axis
            scat1.Axes.YAxis = FormsPlot1.Plot.Axes.Left; // standard Y axis
            FormsPlot1.Plot.Axes.Left.Label.Text = "Primary Y Axis";

            scat2.Axes.XAxis = FormsPlot1.Plot.Axes.Bottom; // standard X axis
            scat2.Axes.YAxis = yAxis2; // custom Y axis
            yAxis2.LabelText = "Secondary Y Axis";

            //FormsPlot1.Plot.Axes.Left.Label.Text = "Low Temperature";
            //FormsPlot1.Plot.Axes.Right.Label.Text = "High Temperature";
            //FormsPlot1.Plot.Axes.Left.Label.ForeColor = scat1.Color;
            //FormsPlot1.Plot.Axes.Right.Label.ForeColor = scat2.Color;

            double min_num = mins.Min();
            int min_index = Array.IndexOf(mins, min_num);
            double max_num = maxs.Max();
            int max_index = Array.IndexOf(maxs, max_num);
            FormsPlot1.Plot.Add.Callout("Hello", dates[min_index], min_num + 10, dates[min_index], min_num);
            FormsPlot1.Plot.Add.Callout("Hello", dates[max_index], max_num + 10, dates[max_index], max_num);
            label2.Text += $"{min_num}, {max_num}";


            


            FormsPlot1.Refresh();




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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
