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

namespace Color_Slider
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

        private void r_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            red.Content = r_slider.Value.ToString();
            bacground_color();
        }

        private void g_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            green.Content = g_slider.Value.ToString();
            bacground_color();
        }

        private void b_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            blue.Content = b_slider.Value.ToString();
            bacground_color();
        }

        private void bacground_color()
        {
            double r = r_slider.Value;
            double g = g_slider.Value;
            double b = b_slider.Value;
            if (Original.IsChecked == true)
            {
                
                Main.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            }
            
            else if (Gray_Tone.IsChecked == true)
            {
                double avg = (r + g + b) / 3;
                Main.Background = new SolidColorBrush(Color.FromRgb((byte)avg, (byte)avg, (byte)avg));
            }
            else if (Invert.IsChecked == true)
            {
                r = 255 - r;
                g = 255 - g;
                b = 255 - b;
                Main.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
            }
        }

        private void Original_Checked(object sender, RoutedEventArgs e)
        {
            r_slider.Value = 0;
            g_slider.Value = 0;
            b_slider.Value = 0;
            Main.Background = new SolidColorBrush(Color.FromRgb((byte)r_slider.Value, (byte)g_slider.Value, (byte)b_slider.Value));
        }

        private void Gray_Tone_Checked(object sender, RoutedEventArgs e)
        {
            r_slider.Value = 0;
            g_slider.Value = 0;
            b_slider.Value = 0;
            Main.Background = new SolidColorBrush(Color.FromRgb((byte)r_slider.Value, (byte)g_slider.Value, (byte)b_slider.Value));
        }

        private void Invert_Checked(object sender, RoutedEventArgs e)
        {
            r_slider.Value = 0;
            g_slider.Value = 0;
            b_slider.Value = 0;
            Main.Background = new SolidColorBrush(Color.FromRgb((byte)r_slider.Value, (byte)g_slider.Value, (byte)b_slider.Value));
        }
    }
}