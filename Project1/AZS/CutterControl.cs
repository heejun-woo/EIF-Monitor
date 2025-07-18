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

namespace EIF_Monitor.AZS
{
    public partial class CutterControl : UserControl
    {
        public string strFilePath = string.Empty;
        List<string> line;
        DateTime dt;

        public CutterControl()
        {
            InitializeComponent();
        }

        public void SetName(string name)
        {
            lbEQP_Name.Text = name;
        }

        public void SetLotRunning(bool value)
        {
            if (value)
            {
                lbLotRunning.Text = "On";
                lbLotRunning.BackColor = Color.Green;
            }
            else
            {
                lbLotRunning.Text = "Off";
                lbLotRunning.BackColor = Color.Gray;
            }
        }
        public void SeLotID(string name)
        {
            lbLotID.Text = name;
        }

        public void SetLotStart(bool value)
        {
            chkLOT_START_RPT_TRIGGER.Checked = value;
            chkLOT_START_RPT_TRIGGER.ForeColor = value ? Color.Red : Color.Black;
        }

        public void SetLotEnd(bool value)
        {
            chkLOT_END_RPT_TRIGGER.Checked = value;
            chkLOT_END_RPT_TRIGGER.ForeColor = value ? Color.Red : Color.Black;
        }

        public void SetLotInfo(bool value)
        {
            chkLOT_INFO_REQ_TRIGGER.Checked = value;
            chkLOT_INFO_REQ_TRIGGER.ForeColor = value ? Color.Red : Color.Black;
        }

        public void SetEndBusy(bool value)
        {
            chkLOT_END_BUSY.Checked = value;
            chkLOT_END_BUSY.ForeColor = value ? Color.Red : Color.Black;
        }

        public void SetLogFile(string path)
        {
            strFilePath = path;

            FileStream ReadData = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            StreamReader r = new StreamReader(ReadData);

            line = new List<string>();

            while (r.EndOfStream == false)
            {
                line.Add(r.ReadLine());
            }

            ReadData.Close();
            r.Close();
        }

        private string TimeFindValue(List<string> line, string Code)
        {
            DateTime time;
            string tagName;
            string value;

            for (int i = line.Count - 1; i >= 0; i--)
            {
                try
                {
                    tagName = line[i].Split(' ')[4].Replace("[", "").Replace("]", "");
                    value = line[i].Split(' ')[7];
                    time = Convert.ToDateTime(line[i].Substring(0, 22));

                    if (dt.Ticks < time.Ticks) continue;

                    if (tagName.Split(':')[1].Equals(Code))
                        return value;
                    else if (tagName.Contains(Code))
                        return value;
                }
                catch { }
            }

            return string.Empty;
        }

        public void Exe(DateTime value)
        {
            dt = value;
            new Action(delegate ()
            {
                SetLotRunning(TimeFindValue(line, "I_B_LOT_RUNNING").Equals("ON") ? true : false);
                SeLotID(TimeFindValue(line, "EQP_STAT_CHG_RPT:I_W_CURRENT_LOT_ID"));
                SetLotStart(TimeFindValue(line, "G3_2_LOT_START_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false);
                SetLotEnd(TimeFindValue(line, "G3_3_LOT_END_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false);
                SetLotInfo(TimeFindValue(line, "G3_1_LOT_INFO_REQ:I_B_TRIGGER_REPORT").Equals("ON") ? true : false);
                SetEndBusy(TimeFindValue(line, "I_B_LOT_END_BUSY").Equals("ON") ? true : false);

            }).BeginInvoke(null, null);
        }
    }
}
