using IronPython.Hosting;
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
using Microsoft.Data.Analysis;
using System.IO;
using System.Linq;

namespace practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var dataPath = System.IO.Path.GetFullPath(@"한국서부발전(주)_태양광 발전 현황_20230630.csv");

            // Load the data into the data frame
            var df = DataFrame.LoadCsv(dataPath);
            for (int i = 0; i < 10; i++)
            textBox1.Text += df.Rows.ToArray();
            //var peEngine = Python.CreateEngine();
            //var vScope = peEngine.CreateScope();

            //try
            //{
            //    var vSource = peEngine.CreateScriptSourceFromFile(@"Untitled1.py");
            //    vSource.Execute(vScope);

            //    var getReturnValue = vScope.GetVariable<Func<string>>("testPythonFunc");
            //    textBox1.Text = getReturnValue() + System.Environment.NewLine;

            //    var vSum = vScope.GetVariable<Func<int, int, int>>("testsum");
            //    textBox1.Text += vSum(5, 8).ToString();


            //}

            //catch(Exception ex)
            //{ 
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}