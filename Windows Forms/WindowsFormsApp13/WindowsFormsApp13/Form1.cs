using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        static int sharedData = 0;
        static object lockObject = new object();
        public Form1()
        {
            InitializeComponent();

            //textBox1.Text += "1번 스레드 시작!\r\n";

            //var new_thread = new Thread(new ThreadStart(Mythread));
            //new_thread.Start();

            //textBox1.Text += "1번 스레드 끝!\r\n";

            Thread thread1 = new Thread(UpdateData1);
            Thread thread2 = new Thread(UpdateData2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

        }

        void UpdateData1()
        {
            lock (lockObject) 
            {
                for (int i = 0; i < 10; i++)
                {
                    sharedData++;
                    Thread.Sleep(100);
                    textBox1.Text += $"1: " + sharedData + "\r\n";
                }

            }
        }
        void UpdateData2()
        {
            lock (lockObject)
                {
                for (int i = 0; i < 10; i++)
                {
                    sharedData++;
                    Thread.Sleep(100);
                    textBox1.Text += $"2: " + sharedData + "\r\n";
                }

            }
            //private void Mythread()
            //{
            //    textBox1.Text += "2번 스레드 시작!\r\n";
            //    Thread.Sleep(1000);
            //    textBox1.Text += "2번 스레드 끝!\r\n";
            //}
        }

    }
}
