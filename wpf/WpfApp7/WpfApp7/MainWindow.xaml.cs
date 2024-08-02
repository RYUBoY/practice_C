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
using System.IO;
using System.Linq;
using Microsoft.Data.Analysis;
using ScottPlot.Plottables;
using System.Diagnostics;
using System.Threading;

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
            //StreamReader sr = new StreamReader(@"한국서부발전(주)_태양광 발전 현황_20230630.csv");
            var dataPath = System.IO.Path.GetFullPath(@"한국서부발전(주)_태양광 발전 현황_20230630.csv");
            var df = DataFrame.LoadCsv(dataPath);
            var df_1 = df.Rows.Where(row => row["발전기명"].ToString().Contains("태양광1") == true).ToList();
            List<int> list = new List<int>();
            List<int> values = Enumerable.Range(1, 25).ToList();

            for (int i = 3; i < df_1[0].Count(); i++)
            {

                list.Add(Convert.ToInt32(df_1[0][i]));
                WpfPlot1.Plot.Add.Scatter(values, list);
                myPlot.SavePng("demo{}.png", 400, 300);

            }
            
           
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