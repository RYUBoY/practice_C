using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //MessageBox.Show("Hello World");

            /*
             * 텍스트 박스에 메세지 리턴
             */
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int Num = 0;
                foreach (int num in numbers)
                {
                    
                    Num += num;
                    
                }
                textBox_print.Text = Num.ToString();
            }
            
            

            
        }
    }
}
