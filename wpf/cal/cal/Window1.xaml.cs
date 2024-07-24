using Calculator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cal
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        history history = new history();
        public Window1()
        {
            InitializeComponent();
        }

        public void AddHistory(string historyOutput)
        {
            listBox.Items.Clear();
            string[] historyEntries = historyOutput.Split(new[] { '\n' }, StringSplitOptions.None);
            foreach (var entry in historyEntries)
            {
                if (!string.IsNullOrWhiteSpace(entry))
                {
                    listBox.Items.Add(entry.Trim());
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("writeTest.txt", false);
            sw.WriteLine("");
            sw.Close();
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
            MessageBox.Show("삭제되었습니다.");
            history.historyClear();
            string historyOutput = history.AllHistory();
            AddHistory(historyOutput);


        }
    }
}
