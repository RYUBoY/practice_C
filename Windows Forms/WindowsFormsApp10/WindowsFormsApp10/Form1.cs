using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                //int[] arr = new int[2];
                //arr[4] = 0;
                textBox1.Text += "Try 실행\r\n";
                throw new Exception("에러 발생");

            }

            catch(Exception ex)
            { 
                textBox1.Text += ex.Message + "\r\n";
            }

            finally
            {
                textBox1.Text += "프로그램 종료\r\n";
            }
        }
    }
}
