using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            string content = File.ReadAllText(@"C:\Users\USER\Desktop\c#\WindowsFormsApp11\WindowsFormsApp11\empty.txt");
            string[] arr;

            try
            {
                
                getText(out arr, content);
                getType(ref arr);
                
                
            }

            catch (Exception ex)
            {
                textBox1.Text += ex.Message + "\r\n";
            }

            finally
            {
                textBox1.Text += "완료\r\n";
            }

            
        }

        void getText(out string[] x, string y)
        {
            x = y.Split('\n');

        }

        void getType(ref string[] type)
        {
            foreach (string str in type)
            {
                if (str.Contains(" "))
                {
                    throw new Exception(str + " => 이 문자열은 공백을 포함하고 있습니다");
                }
                int num = 0;
                bool isnum = int.TryParse(str, out num);
                if (isnum == true)
                {
                    textBox1.Text += "숫자 " + str + "\r\n";
                }
                else
                {
                    textBox1.Text += "문자 " + str + "\r\n";
                }
            }

        }
    }
}
