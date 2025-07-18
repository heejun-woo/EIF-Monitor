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
    public partial class AZS_Monitor : Form
    {
        Common common = new Common();
        List<CutterControl> ListCutter = new List<CutterControl>();
        List<TextBox> ListCutterName = new List<TextBox>();

        public AZS_Monitor()
        {
            InitializeComponent();

            #region 초기값
            cutter1.SetName("Cutter 01");
            cutter2.SetName("Cutter 02");
            cutter3.SetName("Cutter 03");
            cutter4.SetName("Cutter 04");
            ListCutter.Add(cutter1);
            ListCutter.Add(cutter2);
            ListCutter.Add(cutter3);
            ListCutter.Add(cutter4);

            ListCutterName.Add(txtCutterName1);
            ListCutterName.Add(txtCutterName2);
            ListCutterName.Add(txtCutterName3);
            ListCutterName.Add(txtCutterName4);
            #endregion

            comboBox1.SelectedIndex = 1;


        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            txtLogFileName.Text = $"VARIABLE_TRACE_{dateTimePicker1.Value.Month:D2}{dateTimePicker1.Value.Day:D2}.log";

            try
            {
                AZS_STK.InitData();
                AZS_STK.SetLogFile(new FileInfo(common.getLogDir(txtStackingName.Text) + "\\" + txtLogFileName.Text).FullName);
                AZS_STK.SetLogFile(new FileInfo(common.getLogDir(txtStackingName.Text + "_STK1") + "\\" + txtLogFileName.Text).FullName);
                AZS_STK.SetLogFile(new FileInfo(common.getLogDir(txtStackingName.Text + "_STK2") + "\\" + txtLogFileName.Text).FullName);
            }
            catch { }

            for (int i = 0; i < ListCutter.Count; i++)
            {
                try
                {
                    ListCutter[i].SetLogFile(new FileInfo(common.getLogDir(ListCutterName[i].Text) + "\\" + txtLogFileName.Text).FullName);
                }
                catch
                { }
            }

            dateTimePicker1.Value = AZS_STK.getTime();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbMiliSec.Text = dateTimePicker1.Value.Millisecond.ToString();

            AZS_STK.Exe(dateTimePicker1.Value);

            for (int i = 0; i < ListCutter.Count; i++)
            {
                ListCutter[i].Exe(dateTimePicker1.Value);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           dateTimePicker1.Value = dateTimePicker1.Value.AddMilliseconds(100);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMilliseconds(-100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMilliseconds(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Value = dateTimePicker1.Value.AddMilliseconds(-1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = AZS_STK.getTime(dateTimePicker1.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Value = AZS_STK.getTime2(dateTimePicker1.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(-1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    txtCutterName1.Text = "B1AAZS011";
                    txtCutterName2.Text = "B1AAZS012";
                    txtCutterName3.Text = "B1AAZS013";
                    txtCutterName4.Text = "B1AAZS014";
                    txtStackingName.Text = "B1AAZS101";
                    break;
                case 1:
                    txtCutterName1.Text = "B1AAZS015";
                    txtCutterName2.Text = "B1AAZS016";
                    txtCutterName3.Text = "B1AAZS017";
                    txtCutterName4.Text = "B1AAZS018";
                    txtStackingName.Text = "B1AAZS102";
                    break;
                case 2:
                    txtCutterName1.Text = "B1AAZS021";
                    txtCutterName2.Text = "B1AAZS022";
                    txtCutterName3.Text = "B1AAZS023";
                    txtCutterName4.Text = "B1AAZS024";
                    txtStackingName.Text = "B1AAZS201";
                    break;
                case 3:
                    txtCutterName1.Text = "B1AAZS025";
                    txtCutterName2.Text = "B1AAZS026";
                    txtCutterName3.Text = "B1AAZS027";
                    txtCutterName4.Text = "B1AAZS028";
                    txtStackingName.Text = "B1AAZS202";
                    break;

            }

        }
    }
}
