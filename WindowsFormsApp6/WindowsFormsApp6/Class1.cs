using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    internal partial class Square
    {
        string MyName = "사각형";
        public string GetName() => MyName;

        public Square() 
        {
            MessageBox.Show("생성자");
        }
        
        public Square(string Text) 
        { 
            MessageBox.Show(Text);
        }

        ~Square()
        {
            MessageBox.Show("소멸자");
        }
    }
}
