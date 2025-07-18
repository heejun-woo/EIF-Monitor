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
    public partial class AZS_STK_Console : UserControl
    {
        public string strFilePath = string.Empty;
        List<string> Inspline;
        List<List<string>> StkLine;
        List<string> UnloadLine;

        DateTime dt;

        List<STKControl> ListSTK = new List<STKControl>();

        public AZS_STK_Console()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();

            #region 초기값
            ListSTK.Add(stk01);
            ListSTK.Add(stk02);
            ListSTK.Add(stk03);
            ListSTK.Add(stk04);
            ListSTK.Add(stk05);
            ListSTK.Add(stk06);
            ListSTK.Add(stk07);
            ListSTK.Add(stk08);
            ListSTK.Add(stk09);
            ListSTK.Add(stk10);
            ListSTK.Add(stk11);
            ListSTK.Add(stk12);

            stk01.SetName("StackingElm_01");
            stk02.SetName("StackingElm_02");
            stk03.SetName("StackingElm_03");
            stk04.SetName("StackingElm_04");
            stk05.SetName("StackingElm_05");
            stk06.SetName("StackingElm_06");
            stk07.SetName("StackingElm_07");
            stk08.SetName("StackingElm_08");
            stk09.SetName("StackingElm_09");
            stk10.SetName("StackingElm_10");
            stk11.SetName("StackingElm_11");
            stk12.SetName("StackingElm_12");

            unloader.SetName("UnloaderElm");
            #endregion
        }

        public void InitData()
        {
            Inspline = new List<string>();
            StkLine = new List<List<string>>();
            for (int i = 0; i < 12; i++) StkLine.Add(new List<string>());
            UnloadLine = new List<string>();
        }

        public void SetLogFile(string path)
        {
            strFilePath = path;

            FileStream ReadData = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            StreamReader r = new StreamReader(ReadData);

            while (r.EndOfStream == false)
            {
                string line = r.ReadLine();

                if (line.Contains(".InspectionElm]"))
                    Inspline.Add(line);

                else if (line.Contains(".StackingElm_01]"))
                {
                    StkLine[0].Add(line);
                }
                else if (line.Contains(".StackingElm_02]"))
                {
                    StkLine[1].Add(line);
                }
                else if (line.Contains(".StackingElm_03]"))
                {
                    StkLine[2].Add(line);
                }
                else if (line.Contains(".StackingElm_04]"))
                {
                    StkLine[3].Add(line);
                }
                else if (line.Contains(".StackingElm_05]"))
                {
                    StkLine[4].Add(line);
                }
                else if (line.Contains(".StackingElm_06]"))
                {
                    StkLine[5].Add(line);
                }
                else if (line.Contains(".StackingElm_07]"))
                {
                    StkLine[6].Add(line);
                }
                else if (line.Contains(".StackingElm_08]"))
                {
                    StkLine[7].Add(line);
                }
                else if (line.Contains(".StackingElm_09]"))
                {
                    StkLine[8].Add(line);
                }
                else if (line.Contains(".StackingElm_10]"))
                {
                    StkLine[9].Add(line);
                }
                else if (line.Contains(".StackingElm_11]"))
                {
                    StkLine[10].Add(line);
                }
                else if (line.Contains(".StackingElm_12]"))
                {
                    StkLine[11].Add(line);
                }
                else if (line.Contains(".UnloaderElm]"))
                {
                    UnloadLine.Add(line);
                }
            }

            ReadData.Close();
            r.Close();
        }

        public DateTime getTime(DateTime dt)
        {
            DateTime time = DateTime.Now;
            string value;
            string tagName;

            for (int i = Inspline.Count - 1; i >= 0; i--)
            {
                try
                {
                    tagName = Inspline[i].Split(' ')[4].Replace("[", "").Replace("]", "");
                    time = Convert.ToDateTime(Inspline[i].Substring(0, 22));
                    value = Inspline[i].Split(' ')[7];


                    if (dt.Ticks <= time.Ticks) continue;

                    if (tagName.Split(':')[1].Equals("I_B_TRIGGER_REPORT") && value.Equals("ON") && tagName.Split(':')[0].Contains("LOT"))
                        return time;
                }
                catch { }
            }

            return time;
        }

        public DateTime getTime2(DateTime dt)
        {
            DateTime time = DateTime.Now;
            string value;
            string tagName;

            for (int i = 0 ; i < Inspline.Count ; i++)
            {
                try
                {
                    tagName = Inspline[i].Split(' ')[4].Replace("[", "").Replace("]", "");
                    time = Convert.ToDateTime(Inspline[i].Substring(0, 22));
                    value = Inspline[i].Split(' ')[7];


                    if (dt.Ticks >= time.Ticks) continue;

                    if (tagName.Split(':')[1].Equals("I_B_TRIGGER_REPORT") && value.Equals("ON") && tagName.Split(':')[0].Contains("LOT"))
                        return time;
                }
                catch { }
            }

            return time;
        }

        public DateTime getTime()
        {
            DateTime time = DateTime.Now;
            string value;
            string tagName;

            for (int i = Inspline.Count - 1; i >= 0; i--)
            {
                try
                {
                    tagName = Inspline[i].Split(' ')[4].Replace("[", "").Replace("]", "");
                    time = Convert.ToDateTime(Inspline[i].Substring(0, 22));
                    value = Inspline[i].Split(' ')[7];

                    if (tagName.Split(':')[1].Equals("I_B_TRIGGER_REPORT") && value.Equals("ON") && tagName.Split(':')[0].Contains("LOT"))
                        return time;
                }
                catch { }
            }

            return time;
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
                chkLOT_RUNNING.Checked = TimeFindValue(Inspline, "I_B_LOT_RUNNING").Equals("ON") ? true : false;
                chkLOT_RUNNING.ForeColor = chkLOT_RUNNING.Checked ? Color.Red : Color.Black;

                chkLOT_END_BUSY.Checked = TimeFindValue(Inspline, "I_B_LOT_END_BUSY").Equals("ON") ? true : false;
                chkLOT_END_BUSY.ForeColor = chkLOT_END_BUSY.Checked ? Color.Red : Color.Black;

                chkLOT_INFO_REQ_TRIGGER.Checked = TimeFindValue(Inspline, "G3_1_LOT_INFO_REQ:I_B_TRIGGER_REPORT").Equals("ON") ? true : false;
                chkLOT_INFO_REQ_TRIGGER.ForeColor = chkLOT_INFO_REQ_TRIGGER.Checked ? Color.Red : Color.Black;

                chkLOT_START_RPT_TRIGGER.Checked = TimeFindValue(Inspline, "G3_2_LOT_START_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false;
                chkLOT_START_RPT_TRIGGER.ForeColor = chkLOT_START_RPT_TRIGGER.Checked ? Color.Red : Color.Black;

                chkLOT_END_RPT_TRIGGER.Checked = TimeFindValue(Inspline, "G3_3_LOT_END_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false;
                chkLOT_END_RPT_TRIGGER.ForeColor = chkLOT_END_RPT_TRIGGER.Checked ? Color.Red : Color.Black;

                chkLOT_START_RPT_TRIGGER.Checked = TimeFindValue(Inspline, "G3_2_LOT_START_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false;
                chkLOT_START_RPT_TRIGGER.ForeColor = chkLOT_START_RPT_TRIGGER.Checked ? Color.Red : Color.Black;

                txtNextLot.Text = TimeFindValue(Inspline, "G3_2_LOT_START_RPT:I_W_NEXT_LOT_ID");
                txtCurrentLot.Text = TimeFindValue(Inspline, "EQP_STAT_CHG_RPT:I_W_CURRENT_LOT_ID");
                txtHistLot.Text = TimeFindValue(Inspline, "G3_3_LOT_END_RPT:I_W_HIST_LOT_ID");

            }).BeginInvoke(null, null);

            new Action(delegate ()
            {
                chkCUTTER_LOT_INFO_REQ.Checked = TimeFindValue(Inspline, "I_B_CUTTER_LOT_INFO_REQ").Equals("ON") ? true : false;
                chkCUTTER_LOT_INFO_REQ.ForeColor = chkCUTTER_LOT_INFO_REQ.Checked ? Color.Red : Color.Black;

                chkCUTTER_LOT_START_REQ.Checked = TimeFindValue(Inspline, "I_B_CUTTER_LOT_START_REQ").Equals("ON") ? true : false;
                chkCUTTER_LOT_START_REQ.ForeColor = chkCUTTER_LOT_START_REQ.Checked ? Color.Red : Color.Black;

                chkCUTTER_LOT_START_ENABLE.Checked = TimeFindValue(Inspline, "I_B_CUTTER_LOT_START_ENABLE").Equals("ON") ? true : false;
                chkCUTTER_LOT_START_ENABLE.ForeColor = chkCUTTER_LOT_START_ENABLE.Checked ? Color.Red : Color.Black;

                chkCUTTER_LOT_CHANGE_REQ.Checked = TimeFindValue(Inspline, "I_B_CUTTER_LOT_CHANGE_REQ").Equals("ON") ? true : false;
                chkCUTTER_LOT_CHANGE_REQ.ForeColor = chkCUTTER_LOT_CHANGE_REQ.Checked ? Color.Red : Color.Black;

                chkCUTTER_LOT_END_REQ.Checked = TimeFindValue(Inspline, "I_B_CUTTER_LOT_END_REQ").Equals("ON") ? true : false;
                chkCUTTER_LOT_END_REQ.ForeColor = chkCUTTER_LOT_END_REQ.Checked ? Color.Red : Color.Black;


                chkSTACKING_LOT_START_REQ.Checked = TimeFindValue(Inspline, "I_B_STACKING_LOT_START_REQ").Equals("ON") ? true : false;
                chkSTACKING_LOT_START_REQ.ForeColor = chkSTACKING_LOT_START_REQ.Checked ? Color.Red : Color.Black;

                chkSTACKING_LOT_START_ENABLE.Checked = TimeFindValue(Inspline, "I_B_STACKING_LOT_START_ENABLE").Equals("ON") ? true : false;
                chkSTACKING_LOT_START_ENABLE.ForeColor = chkSTACKING_LOT_START_ENABLE.Checked ? Color.Red : Color.Black;

                chkSTACKING_LOT_END_REQ.Checked = TimeFindValue(Inspline, "I_B_STACKING_LOT_END_REQ").Equals("ON") ? true : false;
                chkSTACKING_LOT_END_REQ.ForeColor = chkSTACKING_LOT_END_REQ.Checked ? Color.Red : Color.Black;

                chkSTACKING_LOT_END_ENABLE.Checked = TimeFindValue(Inspline, "I_B_STACKING_LOT_END_ENABLE").Equals("ON") ? true : false;
                chkSTACKING_LOT_END_ENABLE.ForeColor = chkSTACKING_LOT_END_ENABLE.Checked ? Color.Red : Color.Black;


                chkUNLOADER_LOT_CHANGE_REQ.Checked = TimeFindValue(Inspline, "I_B_UNLOADER_LOT_CHANGE_REQ").Equals("ON") ? true : false;
                chkUNLOADER_LOT_CHANGE_REQ.ForeColor = chkUNLOADER_LOT_CHANGE_REQ.Checked ? Color.Red : Color.Black;

                chkUNLOADER_LOT_CHANGE_ENABLE.Checked = TimeFindValue(Inspline, "I_B_UNLOADER_LOT_CHANGE_ENABLE").Equals("ON") ? true : false;
                chkUNLOADER_LOT_CHANGE_ENABLE.ForeColor = chkUNLOADER_LOT_CHANGE_ENABLE.Checked ? Color.Red : Color.Black;

                chkUNLOADER_LOT_END_REQ.Checked = TimeFindValue(Inspline, "I_B_UNLOADER_LOT_END_REQ").Equals("ON") ? true : false;
                chkUNLOADER_LOT_END_REQ.ForeColor = chkUNLOADER_LOT_END_REQ.Checked ? Color.Red : Color.Black;

                chkUNLOADER_LOT_END_ENABLE.Checked = TimeFindValue(Inspline, "I_B_UNLOADER_LOT_END_ENABLE").Equals("ON") ? true : false;
                chkUNLOADER_LOT_END_ENABLE.ForeColor = chkUNLOADER_LOT_END_ENABLE.Checked ? Color.Red : Color.Black;

            }).BeginInvoke(null, null);


            for (int x = 0; x < 12; x++)
            {
                VIewSTK(x);
            }

            new Action(delegate ()
            {
                unloader.SetLotRunning(TimeFindValue(UnloadLine, "I_B_LOT_RUNNING").Equals("ON") ? true : false);
                unloader.SeLotID(TimeFindValue(UnloadLine, "EQP_STAT_CHG_RPT:I_W_CURRENT_LOT_ID"));
                unloader.SetLotStart(TimeFindValue(UnloadLine, "G3_2_LOT_START_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false);
                unloader.SetLotEnd(TimeFindValue(UnloadLine, "G3_3_LOT_END_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false);
                unloader.SetEndBusy(TimeFindValue(UnloadLine, "I_B_LOT_END_BUSY").Equals("ON") ? true : false);

            }).BeginInvoke(null, null);
        }

        public void VIewSTK(int x)
        {
            new Action(delegate ()
            {
                ListSTK[x].SetLotRunning(TimeFindValue(StkLine[x], "I_B_LOT_RUNNING").Equals("ON") ? true : false);
                ListSTK[x].SeLotID(TimeFindValue(StkLine[x], "EQP_STAT_CHG_RPT:I_W_CURRENT_LOT_ID"));
                ListSTK[x].SetLotStart(TimeFindValue(StkLine[x], "G3_2_LOT_START_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false);
                ListSTK[x].SetLotEnd(TimeFindValue(StkLine[x], "G3_3_LOT_END_RPT:I_B_TRIGGER_REPORT").Equals("ON") ? true : false);
                ListSTK[x].SetEndBusy(TimeFindValue(StkLine[x], "I_B_LOT_END_BUSY").Equals("ON") ? true : false);

            }).BeginInvoke(null, null);
        }

    }
}
