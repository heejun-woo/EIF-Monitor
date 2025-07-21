using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIF_Monitor
{
    public partial class Log : Form
    {
        string dir;
        public Log(string eqp)
        {
            InitializeComponent();

            dir = eqp;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            string ss = string.Empty;

            DirectoryInfo gtDir = new DirectoryInfo(dir);
            FileInfo[] gtFile = gtDir.GetFiles().ToArray();

            for(int i = 0; i < gtFile.Length; i++)
            {
                if (i < gtFile.Length - num.Value) continue;

                FileStream ReadData = new FileStream(gtFile[i].FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                StreamReader r = new StreamReader(ReadData);

                while (r.EndOfStream == false)
                {
                    string str = r.ReadLine();
                    if (CheckLine(str)) ss += str + Environment.NewLine;  
                }
            }
            textBox1.AppendText(ss);
        }

        private bool CheckLine(string str)
        {
            string[] lst = tbTxt.Text.Split('|');

            string[] lst2 = tbTxt2.Text.Split('|');

            if (lst2.Any(keyword => str.Contains(keyword)))
                return false;

            foreach (string i in lst)
            {
                if (i.Length < 4) continue; // 너무 짧은 단어는 취급 안함
                
                if (str.Contains(i)) return true;
            }

            return false;
        }


        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            tbTxt.Text = "_REPORT]|_CONF]";

            string ss = string.Empty;

            DirectoryInfo gtDir = new DirectoryInfo(dir);
            FileInfo[] gtFile = gtDir.GetFiles().ToArray();

            List<string> lst = new List<string>();

            for (int i = 0; i < gtFile.Length; i++)
            {
                if (i < gtFile.Length - num.Value) continue;

                FileStream ReadData = new FileStream(gtFile[i].FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                StreamReader r = new StreamReader(ReadData);

                while (r.EndOfStream == false)
                {
                    string str = r.ReadLine();

                    if (str.Contains("OFF")) continue;
                    if (CheckLine(str)) lst.Add(str);
                }
            }


            for (int cnt = 0; cnt < lst.Count; cnt++)
            {
                if (!lst[cnt].Contains("_REPORT]")) continue;

                string time = lst[cnt].Trim().Substring(0, 22);

                string FindSTR = lst[cnt].Trim().Substring(24, lst[cnt].Trim().Length - 24).Split(':')[0];

                for (int i = cnt + 1; i < lst.Count; i++)
                {
                    if (!lst[i].Contains("_CONF]") && !lst[i].Contains(FindSTR)) continue;

                    string end_time = lst[i].Trim().Substring(0, 22);

                    DateTime dt1 = Convert.ToDateTime(time);
                    DateTime dt2 = Convert.ToDateTime(end_time);

                    if ((dt2 - dt1).TotalSeconds > Convert.ToInt32( numericUpDown1.Value))
                    {
                        ss += lst[cnt] + Environment.NewLine;
                        ss += lst[i] + Environment.NewLine;
                    }

                    break;
                }
            }

            textBox1.Text = ss;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dir = txtdir.Text;
        }
    }
}
