using System.Diagnostics;
using System.IO;
using System.Security.Policy;
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

namespace Web_Browser_실습
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> urls = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            
        }
        

        private void Go_Button_Click(object sender, RoutedEventArgs e)
        {
            Web.CoreWebView2.Navigate(Url.Text);
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Web.GoBack();
        }

        private void Forward_Button_Click(object sender, RoutedEventArgs e)
        {
            Web.GoForward();
        }

        

        private void Favorite_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Add_Button.IsChecked == true)
            {
                listBox.Items.Add(Url.Text);
                urls.Add(Url.Text);
               
            }
            else 
            {
                Web.CoreWebView2.Navigate(listBox.SelectedItem.ToString());
            }
        }

        private void Web_Browser(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter("favorite.fvr");
            int nCount = urls.Count;
            for (int i = 0; i < nCount; i++)
            {
                //urls[i] += "\r\n";
                sw.WriteLine(urls[i]);
            }
            sw.Close();
        
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var filePath = "favorite.fvr";
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                   while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listBox.Items.Add(line);
                        urls.Add(line);
                    }
                }
            }
        }
    }
}