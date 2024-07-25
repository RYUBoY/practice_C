using Microsoft.Win32;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool btn_image_cat = true;
        Uri uriCatImage;
        Uri uriDogImage;
        
        public MainWindow()
        {
            InitializeComponent();

            this.uriCatImage = new Uri(@"pack://application:,,,/Resources/cat.jpg", UriKind.Absolute);
            this.uriDogImage = new Uri(@"pack://application:,,,/Resources/dog.jpg", UriKind.Absolute);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.btn_image_cat)
            {
                Btn1.Background = new ImageBrush(new BitmapImage(this.uriCatImage));
                ImageBox1.Source = new BitmapImage(this.uriDogImage);
                this.btn_image_cat = false;
            }
            else
            {
                Btn1.Background = new ImageBrush(new BitmapImage(this.uriDogImage));
                ImageBox1.Source = new BitmapImage(this.uriCatImage);
                this.btn_image_cat = true;
            }

        }

        private void ImageFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png 혹은 *.jpg )|*.png;*.jpg|All files (*.*)|*.*";
            
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                ImageFile.Background = new ImageBrush(new BitmapImage(new Uri(filePath)));

                var x = new BitmapImage(new Uri(filePath)).Width;
                var y = new BitmapImage(new Uri(filePath)).Height;

                
                ImageFile.Height = y;
                ImageFile.Width = x;
                
            }
        }
    }
}