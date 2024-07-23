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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiThread_Race
{
    public partial class Form1 : Form
    {
        private static Random rd = new Random();
        static int Data1 = 0;
        static int Data2 = 0;
        static int Data3 = 0;
        static int Data4 = 0;
        static int Data5 = 0;
        public Form1()
        {
            InitializeComponent();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += $" 시작 시간 : {DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")}\r\n";
            Thread thread1 = new Thread(UpdateData1);
            Thread thread2 = new Thread(UpdateData2);
            Thread thread3 = new Thread(UpdateData3);
            Thread thread4 = new Thread(UpdateData4);
            Thread thread5 = new Thread(UpdateData5);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

            //thread1.Join();
            //thread2.Join();
            //thread3.Join();
            //thread4.Join();
            //thread5.Join();
            
        }

        void RandomSleep()
        {
            int sleepTime = (int)(rd.NextDouble() * 1000.0);
            Thread.Sleep(sleepTime);
        }
        void UpdateData1()
        {
            for (int i = 0; i < 10; i++)
            {
                
                RandomSleep();
                Data1++;
            }
            if (Data1 == 10)
            {
                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke(new MethodInvoker(() =>
                    {
                        textBox1.Text += $" 1번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                    }));
                }
                else
                {
                    textBox1.Text += $" 1번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                }
            }
        }

        void UpdateData2()
        {
            for (int i = 0; i < 10; i++)
            {
                
                RandomSleep();
                Data2++;


            }
            if (Data2 == 10)
            {
                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke(new MethodInvoker(() =>
                    {
                        textBox1.Text += $" 2번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                    }));
                }
                else
                {
                    textBox1.Text += $" 2번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                }
            }
        }
        void UpdateData3()
        {
            for (int i = 0; i < 10; i++)
            {
                
                RandomSleep();
                Data3++;




            }
            if (Data3 == 10)
            {
                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke(new MethodInvoker(() =>
                    {
                        textBox1.Text += $" 3번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                    }));
                }
                else
                {
                    textBox1.Text += $" 3번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                }
            }
        }
        void UpdateData4()
        {
            for (int i = 0; i < 10; i++)
            {
               
                RandomSleep();
                Data4++;




            }
            if (Data4 == 10)
            {
                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke(new MethodInvoker(() =>
                    {
                        textBox1.Text += $" 4번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                    }));
                }
                else
                {
                    textBox1.Text += $" 4번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                }
            }
        }
        void UpdateData5()
        {
            for (int i = 0; i < 10; i++)
            {
                
                RandomSleep();
                Data5++;



            }
            if (Data5 == 10)
            {
                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke(new MethodInvoker(() =>
                    {
                        textBox1.Text += $" 5번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                    }));
                }
                else
                {
                    textBox1.Text += $" 5번 도착 완료! {DateTime.Now.ToString("HH:mm:ss.fff")}\r\n";
                }
            }
        }
    }

}
