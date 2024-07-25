﻿using Calculator;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        string strNumber = "";
        List<string> list = new List<string>();
        double result = 0;
        history history = new history();

        public MainWindow()
        {
            InitializeComponent();

            //radioButton1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            //radioButton2.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            //radioButton3.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        //private void RadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButton1.Checked)
        //    {
        //        if (result >= 0)
        //        {
        //            textBox_input.Text = Convert.ToString((int)result, 2);
        //        }
        //        else
        //        {
        //            MessageBox.Show("음수는 2진수로 변환할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            radioButton2.Checked = true; // 10진수 선택으로 변경
        //        }
        //    }
        //    else if (radioButton2.Checked)
        //    {
        //        textBox_input.Text = result != 0 ? result.ToString() : "";
        //    }
        //    else if (radioButton3.Checked)
        //    {
        //        if (result >= 0)
        //        {
        //            textBox_input.Text = Convert.ToString((int)result, 16).ToUpper();
        //        }
        //        else
        //        {
        //            MessageBox.Show("음수는 16진수로 변환할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            radioButton2.Checked = true; // 10진수 선택으로 변경
        //        }
        //    }
        //}


        private void Clicknum(string num)
        {
            if (textBox_output.Text.Contains("="))
            {
                textBox_output.Text = "";
                //radioButton1.Enabled = false;
                //radioButton2.Enabled = false;
                //radioButton3.Enabled = false;
                textBox_input.Text = num;
            }
            else if (textBox_input.Text == "0")
            {
                textBox_input.Text = num;
            }
            else
            {
                textBox_input.Text += num;
            }

        }

        private void Clickop(string op)
        {
            if (!string.IsNullOrEmpty(textBox_input.Text) && !textBox_output.Text.Contains("="))
            {
                textBox_output.Text += textBox_input.Text + op;
                textBox_input.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_input.Text) || char.IsDigit(textBox_output.Text[textBox_output.Text.Length - 1]))
            {
                textBox_output.Text += textBox_input.Text + "=";
                string strCalc = textBox_output.Text.Substring(0, textBox_output.Text.Length - 1);
                char[] arrCalc = strCalc.ToCharArray();
                List<double> arrNum = new List<double>();
                List<char> arrOp = new List<char>();

                string currentNum = "";
                foreach (char ch in arrCalc)
                {
                    if (char.IsDigit(ch) || ch == '.' || (ch == '-' && currentNum == ""))
                    {
                        currentNum += ch;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(currentNum))
                        {
                            arrNum.Add(double.Parse(currentNum));
                            currentNum = "";
                        }
                        arrOp.Add(ch);
                    }
                }
                if (!string.IsNullOrEmpty(currentNum))
                {
                    arrNum.Add(double.Parse(currentNum));
                }

                // Calculator 클래스 인스턴스 생성 및 계산 메서드 호출
                Calculators calculator = new Calculators();
                result = calculator.Calculate(arrNum, arrOp);

                textBox_input.Text = result.ToString("N10").TrimEnd('0').TrimEnd('.');
                string historyEntry = $"{strCalc} = {result}";
                history.AddHistory(historyEntry);

                //radioButton1.Enabled = true;
                //radioButton2.Enabled = true;
                //radioButton3.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clickop("+");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_output.Text) && string.IsNullOrEmpty(textBox_input.Text))
            {
                textBox_input.Text += "-";
            }
            else if (!string.IsNullOrEmpty(textBox_input.Text) || !textBox_input.Text.Contains("-"))
            {
                textBox_output.Text += textBox_input.Text + "-";
                textBox_input.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clicknum("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clicknum("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clicknum("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clicknum("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clicknum("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clicknum("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Clicknum("7");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clicknum("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clicknum("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Clicknum("0");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_input.Text))
            {
                if (!textBox_input.Text.Contains("."))
                {
                    textBox_input.Text += ".";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Clickop("×");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Clickop("÷");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Clickop("%");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_input.Text))
            {
                string check = textBox_input.Text.ToString();
                textBox_input.Text = check.Substring(0, check.Length - 1);
                //radioButton1.Enabled = false;
                //radioButton2.Enabled = false;
                //radioButton3.Enabled = false;
                //radioButton2.Checked = true;
            }
            else if (!string.IsNullOrEmpty(textBox_output.Text))
            {
                textBox_output.Text = textBox_output.Text.Substring(0, textBox_output.Text.Length - 1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "";
            textBox_output.Text = ""; //
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Window1 form2 = new Window1();
            string historyOutput = history.AllHistory();
            form2.AddHistory(historyOutput);
            form2.Show();
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    StreamWriter writer;
        //    writer = File.CreateText("writeTest.txt");

        //    writer.WriteLine(history.AllHistory());
        //    writer.Close();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            Window1 form2 = new Window1();
            var filePath = "writeTest.txt";
            if (File.Exists(filePath))
            {
                //파일을 사용한 후 닫아주기위해 using으로 묶어준다.
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    //파일의 마지막까지 읽어 들였는지를 EndOfStream 속성을 보고 조사
                    while (!reader.EndOfStream)
                    {
                        //ReadLine 메서드로 한 행을 읽어 들여 line 변수에 대입
                        var line = reader.ReadLine();
                        history.AddHistory(line);
                    }
                }
            }
            string historyOutput = history.AllHistory();
            form2.AddHistory(historyOutput);
            form2.Owner = this;
            form2.Show();
        }

        
    }
}