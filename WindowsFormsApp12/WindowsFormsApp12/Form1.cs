using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Stack stack = new Stack();

            //stack.Push("일");
            //stack.Push("이");
            //stack.Push("삼");

            //try
            //{
            //    int stack_size = stack.Count;
            //    for(int i = 0; i < stack_size+1; i++)
            //    {
            //        textBox1.Text += $"{stack.Peek()}\r\n";
            //        textBox1.Text += $"{stack.Pop()}\r\n";

            //    }
            //} catch(Exception e)
            //{
            //    textBox1.Text += e.Message;
            //}

            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //try
            //{
            //    int queue_size = queue.Count;
            //    for (int i = 0; i < queue_size + 1; i++)
            //    {
            //        textBox1.Text += $"{queue.Dequeue()}\r\n";
            //    }
            //}
            //catch (Exception e)
            //{
            //    textBox1.Text += e.Message;
            //}
            
            List<string> list = new List<string>();
            list.Add("일");
            list.Add("이");
            list.Add("삼");
            
            point(list);
            

            void point(List<string> arr)
            {
                if (arr.Count == 0)
                    return;

                int length = arr.Count-1;
                textBox1.Text += arr[length] + "\r\n";
                arr.RemoveAt(length);

               
                point(arr);

            }

        }
    }
}
