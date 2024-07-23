using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //MO mo = new MO();

            //textBox1.Text += mo.GetNumber(10).ToString() + "\r\n";
            //textBox1.Text += mo.GetNumber(10,20).ToString() + "\r\n";
            //textBox1.Text += mo.GetNumber((long)100).ToString() + "\r\n";

            //Square square = new Square();

            //textBox1.Text += square.Say();
            //textBox1.Text += square.Go();
            //textBox1.Text += square.getShape();

            //Shape shape = new Shape();

            //textBox1.Text += shape.Say();
            //textBox1.Text += shape.Go();
            //textBox1.Text += shape.getShape();

            //Shape shape2 = new Square();

            //textBox1.Text += shape2.Say();
            //textBox1.Text += shape2.Go();
            //textBox1.Text += shape2.getShape();

            //Square square = new Square();

            //textBox1.Text += square.Say();
            //textBox1.Text += square.Go();
            //textBox1.Text += square.getShape();

            //Triangle triangle = new Triangle();

            //textBox1.Text += triangle.Say();
            //textBox1.Text += triangle.Go();
            //textBox1.Text += triangle.getShape();

            //Circle circle = new Circle();

            //textBox1.Text += circle.Say();
            //textBox1.Text += circle.Go();
            //textBox1.Text += circle.getShape();

            Shape shape = new Shape();
            Square square = new Square();
            Triangle triangle = new Triangle();
            Circle circle = new Circle();

            List<Shape> list = new List<Shape>();
            list.Add(new Square());
            list.Add(new Triangle());
            list.Add(new Circle());

            foreach (Shape s in list)
            {
                textBox1.Text += s.getShape()+"\r\n";
            }

            //Shape shape = new Square();
            //Square square1 = new Square();
            //Square square2= new Square();
            //Square square3 = new Square();
            //Triangle triangle1 = new Triangle(); 
            //Triangle triangle2 = new Triangle(); 
            //Triangle triangle3 = new Triangle();
            //Circle circle1 = new Circle();
            //Circle circle2 = new Circle();
            //Circle circle3 = new Circle();

            //textBox1.Text += shape.getShape();
            //textBox1.Text += square1.getShape();
            //textBox1.Text += square2.getShape();
            //textBox1.Text += square3.getShape();
            //textBox1.Text += triangle1.getShape();
            //textBox1.Text += triangle2.getShape();
            //textBox1.Text += triangle3.getShape();
            //textBox1.Text += circle1.getShape();
            //textBox1.Text += circle2.getShape();
            //textBox1.Text += circle3.getShape();


        }
    }
}
