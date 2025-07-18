using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIF_Monitor
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();    
        }

        public Func<string, string> getLogDir = (x) => $"D:\\Logs\\{x}\\ezControl\\System\\VARIABLE_TRACE";

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();

            Dictionary<int, string> dic = new Dictionary<int, string>();

            Process[] localAll = Process.GetProcesses();

            int i = 1;
            foreach (Process p in localAll.Where( a => a.ProcessName.Contains("LGCNS.ezControl.Console")))
            {
                dic.Add(i++, p.MainWindowTitle.Split(' ')[0]);
            }

            foreach (KeyValuePair<int, string> item in dic.OrderBy(a => a.Value))
            {
                CreateItem(item.Value);
            }
        }

        

        private void CreateItem(string eqp)
        {
            try
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo($"D:\\Logs\\{eqp}\\ezControl\\System");

                int fileCnt = 0;

                foreach (System.IO.FileInfo File in di.GetFiles())
                {
                    FileInfo info = new FileInfo(File.FullName);

                    if (rb1Gb.Checked)
                    {
                        if (info.Length > 1000000000) fileCnt++;
                    }
                    else if (rb100mb.Checked)
                    {
                        if (info.LastAccessTime < DateTime.Now.AddDays(-1)) continue;
                        if (info.Length > 100000000) fileCnt++;
                    }
                }


                DirectoryInfo gtDir = new DirectoryInfo(getLogDir(eqp));
                FileInfo[] gtFile = gtDir.GetFiles().OrderByDescending(p => p.LastAccessTime).ToArray();

                int iStatus = 0;
                bool bLotRunning = false;
                string strLotId = string.Empty;

                if (chkSearch.Checked)
                {
                    int.TryParse(FindValue(gtFile, "I_W_EQP_STAT"), out iStatus);

                    bLotRunning = FindValue(gtFile, "I_B_LOT_RUNNING").Equals("ON") ? true : false;

                    strLotId = FindValue(gtFile, "I_W_CURRENT_LOT_ID");

                }

                int cnt = pnMain.Controls.Count;

                eif_console eif = new eif_console(eqp, iStatus, bLotRunning, strLotId, getLogDir(eqp), fileCnt);

                eif.Location = new System.Drawing.Point(5, 5 + cnt * 30);

                pnMain.Controls.Add(eif);
            }
            catch { }

        }

        private string FindValue(FileInfo[] gtFile, string Code)
        {
            foreach(FileInfo info in gtFile)
            {

                DateTime time;
                string tagName;
                string value;

                FileStream ReadData = new FileStream(info.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                StreamReader r = new StreamReader(ReadData);

                List<string> line = new List<string>();

                while (r.EndOfStream == false)
                {
                    line.Add(r.ReadLine());
                }

                ReadData.Close();
                r.Close();

                for (int i = line.Count - 1; i >= 0; i--)
                {
                    try
                    {
                        tagName = line[i].Split(' ')[4].Replace("[", "").Replace("]", "");
                        value = line[i].Split(' ')[7];
                        time = Convert.ToDateTime(line[i].Substring(0, 22));

                        if (tagName.Split(':')[1].Equals(Code)) return value;
                    }
                    catch { }
                }
            }

            return string.Empty;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnReLoad_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EIF_Monitor.AZS.AZS_Monitor frm = new EIF_Monitor.AZS.AZS_Monitor();
            frm.Show();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log log = new Log(string.Empty);
            log.Show();
        }
    }
}



