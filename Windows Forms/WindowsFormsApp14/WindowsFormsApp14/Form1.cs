using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        void Hi() => textBox1.Text += "Hi\r\n";
        delegate void CallDelegate();
        delegate void Move(int value);
        delegate void Runner();
        void RunnerCall(Runner runner) => runner();
        void Go() => textBox1.Text += "달려\r\n";
        void Stop() => textBox1.Text += "멈춰\r\n";

        internal class Tank
        {
            public string result { get; set; } = string.Empty;
            public void Forward(int length) => result += $"{length}만큼 전진\r\n";
            public void Backward(int length) => result += $"{length}만큼 후진\r\n";
            public void Rotate(int angle) => result += $"{angle}도 만큼 회전\r\n";
        }

        public Form1()
        {
            InitializeComponent();

            //CallDelegate callDelegate = new CallDelegate(Hi);
            //callDelegate();
            //callDelegate.Invoke();

            //Tank tank = new Tank();

            //Move move;
            //move = tank.Forward;
            //move += tank.Backward;
            //move += tank.Rotate;

            //move -= tank.Rotate;
            //move(20);

            //textBox1.Text += tank.result;

            Runner runner = new Runner(Go);
            RunnerCall(runner);
            RunnerCall(new Runner(Stop));
            RunnerCall(Stop);
            RunnerCall(() => textBox1.Text += "익명\r\n");
        }
    }
}
