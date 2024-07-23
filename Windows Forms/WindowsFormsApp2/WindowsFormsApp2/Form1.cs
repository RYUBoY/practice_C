using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int num = -100;
            //string name = "300";

            ////name = num;

            //name = num.ToString();
            //name = 400.ToString();

            //num = name;
            //num = int.Parse(name);
            //num = int.Parse("200");
            //num = int.Parse("abc");

            //var name = "John";
            //var num = 1000;
            //var one_char = 'A';

            //textBox_print.Text += name.GetType();
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += num.GetType();
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += one_char.GetType();

            //int sum = Add(1, 2);
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += sum.ToString();

            //int sum = Add(-100, 2);
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += sum.ToString();
            //int sum2 = Add(1, 2);
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += sum2.ToString();
            //int sum3 = Add(100, 2);
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += sum3.ToString();
            //int sum4 = Add(100, 300);
            //textBox_print.Text += "\r\n";
            //textBox_print.Text += sum4.ToString();
            //IdentifyAnimal("Dog");

            //for (int i = 0; i < 10; i++)
            //{
            //    textBox_print.Text += i.ToString();
            //    textBox_print.Text += "\r\n";
            //}
            //textBox_print.Text += "\r\n";
            //for (int i = 9; i >= 0; i--)
            //{
            //    textBox_print.Text += i.ToString();
            //    textBox_print.Text += "\r\n";
            //}
            //textBox_print.Text += "\r\n";
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        textBox_print.Text += i.ToString();
            //        textBox_print.Text += "\r\n";
            //    }

            //}

            //int[] numbers = { 0,1,2,3,4,5,6,7,8,9,10 };


            //foreach(int number in numbers)
            //{
            //    if (number %2 == 1)
            //    {
            //        textBox_print.Text += number.ToString() + "\r\n";
            //    }

            //}

            int count = 0;
            while (true)
            {
                if (count == 0)
                {
                    count ++;
                    textBox_print.Text += "Loop Start!\r\n";
                }

                else if(count < 5)
                {
                    textBox_print.Text += count.ToString();
                    textBox_print.Text += "\r\n";
                    count++;
                }

                else
                {
                    break;
                }
            }

            int count1 = 1;
            textBox_print.Text += "Loop Start!\r\n";
            while (count1 < 5)
            {
                textBox_print.Text += count1.ToString();
                textBox_print.Text += "\r\n";
                count1++;
            }
        }

        //int Add(int x, int y)
        //{
        //    int a = x;
        //    int b = y;
        //    int result = a + b;
        //    return result;
        //}


        //void Add2(int x, int y)
        //{
        //    int sum = x + y;
        //    textBox_print.Text += "\r\n";
        //    textBox_print.Text = sum.ToString();
        //}

        /*
         * 0 이하면 return -1
         * 100까지는 return 1
         * 200까지는 return 2
         * 기타 return 0
         */

        int Add(int x, int y)
        {
            int a = x;
            int b = y;
            int result = a + b;

            if (result <= 0)
            {
                return -1;
            }

            else if (result <= 100)
            {
                return 1;
            }

            else if (result <= 200)
            {
                return 2;
            }

            else
            {
                return 0;
            }
        }

        public void IdentifyAnimal(string animal)
        {
            switch (animal)
            {
                case "Dog":
                    textBox_print.Text = $"This is {animal}.";
                    break;
                case "Cat":
                    textBox_print.Text = "This is Cat.";
                    break;
                case "Bird":
                    textBox_print.Text = "This is bird.";
                    break;
                default:
                    textBox_print.Text = "Unknown animal!";
                    break;
            }
        }
    }
}
