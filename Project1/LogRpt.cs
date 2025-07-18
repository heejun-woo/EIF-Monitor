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
    public partial class LogRpt : Form
    {
        string dir;
        public LogRpt(string eqp)
        {
            InitializeComponent();

            dir = eqp;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string ss = string.Empty;

            DirectoryInfo gtDir = new DirectoryInfo(dir);
            FileInfo[] gtFile = gtDir.GetFiles().ToArray();

            for(int i = 0; i < gtFile.Length; i++)
            {
                if (i < gtFile.Length - num.Value) continue;

                FileStream ReadData = new FileStream(gtFile[i].FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                StreamReader r = new StreamReader(ReadData);

                List<string> lst = new List<string>();
                while (r.EndOfStream == false)
                {
                    lst.Add(r.ReadLine());
                }

                for (int a = 0; a < lst.Count; a++)
                {
                    string str = lst[a];

                    if (CheckLine(str))
                    {
                        string StartTime = str.Substring(0, 23);
                        string EndTime = string.Empty;
                        string ElmName = str.Split('[')[2].Replace("]", "").Trim();
                        string ServerName = ElmName.Split('.')[0];
                        ElmName = ElmName.Split('.')[1];

                        string CategoryName = str.Split('[')[3].Split(':')[0];

                        string ConfStr = string.Empty;

                        DateTime dt1 = Convert.ToDateTime(StartTime);
                        DateTime dt2;

                        for (int b = a; b < lst.Count; b++)
                        {
                            EndTime = lst[b].Substring(0, 23);
                            dt2 = Convert.ToDateTime(EndTime);

                            TimeSpan s = dt2 - dt1;
                            if (s.Seconds > 60) break;

                            if (CheckLine(lst[b], true, CategoryName))
                            {
                                ConfStr = lst[b];
                                break;
                            }
                        }

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = StartTime;
                        row.Cells[1].Value = EndTime;
                        row.Cells[2].Value = ServerName;
                        row.Cells[3].Value = ElmName;
                        row.Cells[4].Value = CategoryName;
                        row.Cells[5].Value = str;

                        dataGridView1.Rows.Add(row);
                    }
                }

            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSize = true;

        }

        private bool CheckLine(string str, bool Conf = false, string CategoryName = "")
        {
            List<string> lst = tbTxt.Text.Split('|').ToList();

            if (Conf) lst.Add(CategoryName + ":O_B_TRIGGER_REPORT_CONF] (Boolean) : ON");
            else lst.Add(":I_B_TRIGGER_REPORT] (Boolean) : ON");

            foreach(string i in lst)
            {
                if (i.Length < 1) continue; // 너무 짧은 단어는 취급 안함

                if (str.Contains(i))
                {               
                    return true;
                }
            }

            return false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((dataGridView1.Rows[e.RowIndex].Cells[0].Value + "").ToString())) return;

            DateTime dt1 = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            DateTime dt2 = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);


            #region Trace 로그
            txtTrace.Text = "";
            string strFile = $"{dir}\\VARIABLE_TRACE_{dt1.Month:D2}{dt1.Day:D2}.log";

            FileStream ReadData = new FileStream(strFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader r = new StreamReader(ReadData);

            while (r.EndOfStream == false)
            {
                string str = r.ReadLine() + Environment.NewLine;

                DateTime dt = Convert.ToDateTime(str.Substring(0, 23));

                if (dt1 <= dt && dt2 >= dt) txtTrace.AppendText(str);
                if (dt2 < dt) break;
            } 
            #endregion

            #region 컨트롤서버 로그
            txtServer.Text = "";
            strFile = $"{dir.Replace("System\\VARIABLE_TRACE", "")}{dataGridView1.Rows[e.RowIndex].Cells[2].Value}_{dt1.Month:D2}{dt1.Day:D2}.log";

            ReadData = new FileStream(strFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            r = new StreamReader(ReadData);

            DateTime old = DateTime.Now;
            while (r.EndOfStream == false)
            {
                string str = r.ReadLine() + Environment.NewLine;

                try
                {
                    DateTime dt = Convert.ToDateTime(str.Substring(0, 23));
                    old = dt;
                }
                catch { }

                if (dt1 <= old && dt2 >= old) txtServer.AppendText(str);
                if (dt2 < old) break;
            } 
            #endregion

            #region Elm 로그 
            txtElm.Text = "";
            strFile = $"{dir.Replace("System\\VARIABLE_TRACE", "")}{dataGridView1.Rows[e.RowIndex].Cells[3].Value}_{dt1.Month:D2}{dt1.Day:D2}.log";

            ReadData = new FileStream(strFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            r = new StreamReader(ReadData);

            while (r.EndOfStream == false)
            {
                string str = r.ReadLine() + Environment.NewLine;

                try
                {
                    DateTime dt = Convert.ToDateTime(str.Substring(0, 23));
                    old = dt;
                }
                catch { }

                if (dt1 <= old && dt2 >= old) txtElm.AppendText(str);
                if (dt2 < old) break;
            } 
            #endregion

        }
    }
}
