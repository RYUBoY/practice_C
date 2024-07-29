using ScottPlot;
using ScottPlot.WPF;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            chart1();
            chart2();
            chart3();
            chart4();






        }
        public void chart1()
        {
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };
            WpfPlot1.Plot.Add.Scatter(dataX, dataY);
            WpfPlot1.Refresh();
        }
        public void chart2()
        {
            double[] sin = Generate.Sin(51);
            double[] cos = Generate.Cos(51);
            WpfPlot2.Plot.Add.Signal(sin);
            WpfPlot2.Plot.Add.Signal(cos);


            var sig1 = WpfPlot2.Plot.Add.Signal(Generate.Sin(51));
            sig1.LegendText = "Sin";

            var sig2 = WpfPlot2.Plot.Add.Signal(Generate.Cos(51));
            sig2.LegendText = "Cos";

            WpfPlot2.Plot.ShowLegend();
            WpfPlot2.Refresh();
        }

        public void chart3()
        {
           

            var sig1 = WpfPlot3.Plot.Add.Signal(Generate.Sin(mult: 0.01));
            var sig2 = WpfPlot3.Plot.Add.Signal(Generate.Cos(mult: 100));

            
            sig1.Axes.YAxis = WpfPlot3.Plot.Axes.Left;
            sig2.Axes.YAxis = WpfPlot3.Plot.Axes.Right;

            
            WpfPlot3.Plot.Axes.Left.Label.Text = "Left Axis";
            WpfPlot3.Plot.Axes.Right.Label.Text = "Right Axis";
            WpfPlot3.Plot.Axes.Left.Label.ForeColor = sig1.Color;
            WpfPlot3.Plot.Axes.Right.Label.ForeColor = sig2.Color;

            WpfPlot3.Refresh();
        }

        public void chart4()
        {


            var sig1 = WpfPlot4.Plot.Add.Signal(ScottPlot.Generate.Sin(51, mult: 0.01));
            sig1.Axes.XAxis = WpfPlot4.Plot.Axes.Bottom; // standard X axis
            sig1.Axes.YAxis = WpfPlot4.Plot.Axes.Left; // standard Y axis
            WpfPlot4.Plot.Axes.Left.Label.Text = "Primary Y Axis";

            var yAxis2 = WpfPlot4.Plot.Axes.AddLeftAxis();

           var sig2 = WpfPlot4.Plot.Add.Signal(ScottPlot.Generate.Cos(51, mult: 100));
            sig2.Axes.XAxis = WpfPlot4.Plot.Axes.Bottom; // standard X axis
            sig2.Axes.YAxis = yAxis2; // custom Y axis
            yAxis2.LabelText = "Secondary Y Axis";

            WpfPlot4.Refresh();
        }
    }
}