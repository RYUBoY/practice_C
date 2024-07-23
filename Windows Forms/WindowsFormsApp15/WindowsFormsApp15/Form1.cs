using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp15
{
    
    public partial class Form1 : Form
    {
        void Hello() => textBox1.Text += "Hello\r\n";
        void Bye() => textBox1.Text += "Bye\r\n";
        Mybutton button;

        public Form1()
        {
            InitializeComponent();

            button = new Mybutton();
            button.Click += new Mybutton.EventHandler(Hello);
            button.Click += new Mybutton.EventHandler(Bye);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button.OnClick();
        }
    }

    internal class Mybutton
    {
        public delegate void EventHandler();

        public event EventHandler Click;

        public void OnClick()
        {
            if (Click != null)
            {
                Click();
            }
        }
    }
    
    



}
