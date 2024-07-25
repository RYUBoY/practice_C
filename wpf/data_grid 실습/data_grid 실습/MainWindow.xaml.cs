using Microsoft.Win32;
using System.Data.Common;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Emit;
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

namespace data_grid_실습
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    List<Data> datas = new List<Data>();
                    string filePath = openFileDialog.FileName;
                    openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                    string[] check = filePath.Split(".");
                    if (check[1] != "csv")
                    {
                        throw new Exception("잘못된 파일입니다.");
                    }
                    label.Content = System.IO.Path.GetFullPath(filePath);

                    StreamReader sr = new StreamReader(filePath);

                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        if (i == 0)
                        {
                            string line = sr.ReadLine();
                        }
                        else
                        {
                            string line = sr.ReadLine();
                            string[] data = line.Split(",");
                            datas.Add(new Data { name = data[0], age = data[1], etc = data[2] });
                        }
                        i++;
                    }
                    GridList.ItemsSource = datas;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public class Data
        {
            public string name { get; set; }
            public string age { get; set; }
            public string etc { get; set; }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string names = string.Empty;
            foreach (Data data in GridList.SelectedItems)
            {
                names += data.name + "\r\n";
            }
            MessageBox.Show($"{names}선택됨.");
        }
    }


}