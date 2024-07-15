using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int[] array1 = new int[5];
            //int[] array2 = {1, 2, 3, 4, 5, 6}; // new int[6] 
            //int[,] multiDimensionalArray1 = new int[2, 3];
            //int[,] multiDimensionalArray2 = { { 1, 2, 3,}, { 4, 5, 6, } };
            //int[][]  jaggedArray = new int[6][];
            //jaggedArray[0] = new int[4]{1, 2, 3, 4};


            //for (int i = 5; i >= 0; i--)
            //{
            //    textBox1.Text += array2[i].ToString();
            //    textBox1.Text += "\r\n";
            //}

            //for (int i = 0; i < multiDimensionalArray2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multiDimensionalArray2.GetLength(1); j++)
            //    {
            //        textBox1.Text += multiDimensionalArray2[i,j].ToString();
            //        textBox1.Text += "\r\n";
            //    }


            //}

            //string codingon = "codingon";
            string[] a = "1 + 2 + 3".Split(' ');
            //textBox1.Text += a[0] + "\r\n";
            //textBox1.Text += a[1] + "\r\n";
            //textBox1.Text += a[2] + "\r\n";

            //textBox1.Text += codingon.IndexOf('o').ToString();
            //textBox1.Text += codingon.Replace("on", "off").ToString();



            //textBox1.Text += codingon.Remove(6) + "off".ToString();
            //string[] b = "string 5".Split();
            //for (int i = 0; i < int.Parse(b[1]); i++)
            //{

            //    textBox1.Text += b[0].ToString();
            //}


            void Calculation(double a, string b, double c)
            {
                double result = 0;

                if (b == "+")
                {
                    result = a + c;
                    textBox1.Text += result.ToString();
                }

                else if (b == "-")
                {
                    result = a - c;
                    textBox1.Text += result.ToString();
                }

                else if (b == "*")
                {
                    result = a * c;
                    textBox1.Text += result.ToString();
                }

                else if (b == "/")
                {
                    if (c == 0)
                    {
                        textBox1.Text += "Error";
                    }
                    
                                        
                    else
                    {
                        result = a / c;
                        textBox1.Text += result.ToString();
                    }
                }

                else 
                {
                    MessageBox.Show("잘못된 계산식입니다.");
                }
                textBox1.Text += "\r\n계산 완료";
            }
            Calculation(1,"*",2);

            

        }
    }
}
