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

namespace WpfApp5
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

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            //if (RadioButton1.IsChecked == true)
            {
                MessageBox.Show($"good! {radioButton.IsChecked}");
            }
        }

        private void RadioButton1_Unchecked(object sender, RoutedEventArgs e)
        {
            //if(RadioButton1.IsChecked == false)
            {
                MessageBox.Show("Bad!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////Button button = (Button)sender;
            ////MessageBox.Show($"Button Check {button.Content}");
            //comboBox.Items.Add("tomato juice"); 
            //ComboBoxItem item = (ComboBoxItem)comboBox.SelectedValue;
            //string item_name = item.Content.ToString();
            //comboBox.Items.Remove(comboBox.SelectedItem);
            listBox.Items.Add("악어");
            //listBox.Items.Add("병아리");
            //listBox.Items.Add("펭귄");

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider slider = (Slider)sender;
            label1.Content = slider.Value.ToString();
        }

        private void web_button_Click(object sender, RoutedEventArgs e)
        {
            //web.Navigate("http://naver.com");
            //web.GoBack();
            //web.GoForward();
            //web.CoreWebView2.Navigate("http://www.naver.com");
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            
            web.CoreWebView2.Navigate(url.Text);
        }
    }
}