using ScottPlot;
using ScottPlot.WinForms;

namespace ScottPlot_실습
{
    public partial class Form1 : Form
    {
        readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };
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

            panel1.Controls.Add(FormsPlot1);

            double[] dates = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            double[] avgs = { 26.3, 23.2, 24.7, 26.8, 23.4, 25.1, 24.4, 23.8, 24.5, 26.6, 25.7, 25.6, 28.1, 28.4, 28.4, 27, 25.4, 24.3, 27, 27.2, 26.5, 26.6, 26.4, 28.1, 28.8, 28.7, 28.9, 29.2 };
            double[] mins = { 22, 21.9, 23.6, 23.2, 21.3, 22.1, 21.5, 23.1, 22.7, 22.7, 23.3, 21.8, 23.5, 24.9, 24.5, 24.6, 24.1, 23.1, 24.2, 25.1, 22.5, 24.3, 25.8, 26, 25.4, 25.2, 27.5, 27.3 };
            double[] maxs = { 31.3, 25.2, 25.9, 30.6, 26.1, 30, 28.2, 24.5, 26.7, 31.1, 28.9, 30.2, 33.3, 32.1, 31.3, 30.7, 28.1, 25.6, 30.8, 30.6, 29.8, 27.9, 27.3, 30.9, 32.2, 32.7, 31.7, 32.2 };

            var scat1 = FormsPlot1.Plot.Add.Scatter(dates, mins);
            var scat2 = FormsPlot1.Plot.Add.Scatter(dates, maxs);

            scat1.Axes.YAxis = FormsPlot1.Plot.Axes.Left;
            scat2.Axes.YAxis = FormsPlot1.Plot.Axes.Right;

            FormsPlot1.Plot.Axes.Left.Label.Text = "Low Temperature";
            FormsPlot1.Plot.Axes.Right.Label.Text = "High Temperature";
            FormsPlot1.Plot.Axes.Left.Label.ForeColor = scat1.Color;
            FormsPlot1.Plot.Axes.Right.Label.ForeColor = scat2.Color;

            double min_num = mins.Min();
            int min_index = Array.IndexOf(mins, min_num);
            double max_num = maxs.Max();
            int max_index = Array.IndexOf(maxs, max_num);
            FormsPlot1.Plot.Add.Callout("Hello", dates[min_index], min_num + 10, dates[min_index], min_num);
            FormsPlot1.Plot.Add.Callout("Bye", dates[max_index], max_num + 10, dates[max_index], max_num);
            FormsPlot1.Plot.HideGrid();
            FormsPlot1.Refresh();
        }
    }
}
