using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        public string Name { get; set; }

        public string Description { get; set; } = string.Empty;

        int _num;

        public int Num
        {
            get { 
                return _num * 2; 
            }
            set { 
                _num = value;
                textBox1.Text += _num.ToString() + "\r\n";
            }
        }

        public decimal Money
        {
            get => Money;
            set => Money = value;
        }

        public Form1()
        {
            InitializeComponent();
            
            MessageBox.Show("Form1 생성자");

            //Square square = new Square();
            //textBox1.Text = square.GetName();

            //Square square = new Square("생성자 야호!");
            Square square = new Square();

            Num = 1;
            int a = Num;
            textBox1.Text += a.ToString() + "\r\n";
            Num = 3;
            a = Num;
            textBox1.Text += a.ToString() + "\r\n";

        }

        ~ Form1()
        {
            MessageBox.Show("Form1 소멸자");
        }
    }
}
