using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //List<string> list = new List<string>();
            //list.Add("일");
            //list.Add("이");
            //list.Add("삼");

            //point(list);


            //void point(List<string> arr)
            //{
            //    if (arr.Count == 0)
            //        return;

            //    int length = arr.Count-1;
            //    textBox1.Text += arr[length] + "\r\n";
            //    arr.RemoveAt(length);


            //    point(arr);

            //}

            //Hashtable hashtable = new Hashtable();

            //List<string> list = new List<string>();
            //list.Add("1");
            //list.Add("2");
            //string[] arr = ;
            //hashtable[0] = 999;
            //hashtable["이름"] = "조은";
            //hashtable["취미"] = "게에이임";

            //textBox1.Text += $"{hashtable[0]}\r\n";
            //textBox1.Text += $"{hashtable["이름"]}\r\n";
            //textBox1.Text += $"{hashtable["취미"]}\r\n";

            //Stack<int> i_stack = new Stack<int>();
            //i_stack.Push(1);
            //int num = i_stack.Pop();
            //textBox1.Text += $"{num}\r\n";

            //List<double> d_list = new List<double>();
            //d_list.Add(30.409);
            //d_list.Add(329.329);

            //foreach (double d in d_list)
            //{
            //    textBox1.Text += $"{d}\r\n";
            //}

            //Weekday today = Weekday.Monday;

            //int size = 10;
            //var numbers = Enumerable.Range(1, size);
            //var same_numbers = Enumerable.Repeat(0, size);
            //var numbers_array = Enumerable.Range(1, size).ToArray();

            //textBox1.Text += $"{numbers} \r\n";
            //textBox1.Text += $"{same_numbers} \r\n";

            //foreach ( var number in numbers )
            //{
            //    textBox1.Text += $"{number} ";
            //}

            //textBox1.Text += "\r\n" + string.Join(" ", same_numbers);
            //textBox1.Text += "\r\n";

            //foreach (var number in Enumerable.Range(1,10))
            //{
            //    textBox1.Text += $"{number} ";
            //}

            //IDictionary<string, string> data1 = new Dictionary<string, string>();
            //var data2 = new Dictionary<string, string>();

            //data1.Add("오리온", "고래밥");
            //data1.Add("농심", "신라면");

            //data1.Remove("오리온");
            //data2["농심"] = "너구리";

            //try
            //{
            //    data2.Add("농심", "짜파게티");
            //}
            //catch(Exception ex)
            //{
            //    textBox1.Text = ex.Message;
            //}
            //finally
            //{
            //    textBox1.Text = data2["농심"];
            //}

            //if (!data1.ContainsKey("오리온"))
            //{
            //    data1.Add("오리온", "초코파이");
            //}

            //if (data1.TryGetValue("오리온", out string value))
            //{
            //    textBox1.Text += $"{value}\r\n";
            //}

            //foreach (KeyValuePair<string, string> item in data1)
            //{
            //    textBox1.Text += $"{item.Key}에서 {item.Value}를 만듭니다.\r\n";
            //}

            
        }
        IDictionary<string,ID> IDPW = new Dictionary<string, ID>();
        //IDictionary<string, string> IDPN = new Dictionary<string, string>();
        

        public enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        struct ID
        {
            public string x;
            public string y;
            
        }
        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                var fileStream = ofd.OpenFile();

                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        ID ID = new ID();
                        string[] words = line.Split(',');
                        ID.x = words[1];
                        if(words[2] == "")
                        {
                            ID.y = null;
                        }
                        else
                        {
                            ID.y = words[2];
                        }

                        IDPW.Add(words[0], ID);
                    }
                
                }
                
            }
        }

        private void login_Click(object sender, EventArgs e)
        {



            if (!IDPW.ContainsKey(id.Text))
            {
                MessageBox.Show("아이디가 없습니다.");
            }
            else
            {
                if (IDPW[id.Text].x != pw.Text)
                {
                    MessageBox.Show("비밀번호가 틀렸습니다.");
                }
                else
                {

                    MessageBox.Show($"로그인 성공 \r\n\n 아이디 : {id.Text} \r\n 전화번호 : {IDPW[id.Text].y}");
                }

            }
        }
    }
}
