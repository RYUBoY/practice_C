using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Weapon weapon = new Weapon();
            //Rifle rifle = new Rifle();
            //Knife knife = new Knife();
            //weapon.setCombatPoint(5);
            //weapon.setCombatPoint(50, 60);
            //rifle.setCombatPoint(1, 2, 3);
            //knife.setCombatPoint(2, 4, 8);

            //textBox1.Text += weapon.getinfo();
            //textBox1.Text += rifle.getinfo();
            //textBox1.Text += knife.getinfo();

            //textBox1.Text += $"라이플의 전투력은 {rifle.combatPoint()} 입니다.\r\n";
            //textBox1.Text += $"나이프의 전투력은 {knife.combatPoint()} 입니다.\r\n";

            //textBox1.Text += Dog.voice + "\r\n";
            //Dog.voice = "멍뭉";
            //textBox1.Text += Dog.Vox() + "\r\n";

            //Dog_check dog1 = new Dog_check();
            //Dog_check dog2 = new Dog_check();




            //textBox1.Text = Dog_check.Count.ToString();

            //int num1 = 1;
            //setThree(out num1);
            //textBox1.Text = num1.ToString();

            //int length1 = 10;
            //int[] numbers1 = new int[length1];
            
            //makeInstance1(ref numbers1);
            //for (int i = 0; i < length1; i++) { 
            //    textBox1.Text += numbers1[i].ToString() + " ";
            //}
            //int[] numbers2;
            //makeInstance2(out numbers2, length1);
            //textBox1.Text += "\r\n" + numbers2.Length;
            //int a = 1; int b = 2;
            int result = 0;
            Add(3, 4, ref result);
            textBox1.Text = result.ToString();

        }
        int minusOne(int x) => x - 1;
        void setThree(out int x) => x = 3; 

        void makeInstance1(ref int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i+1;
            }
        }
        void makeInstance2(out int[] x, int y)
        {
            x = new int[y];
        }
        void Add(int x, int y, ref int z)
        {
            z = x + y;
        }
        int Add1(int a, int b) => a + b;
    }
}
