using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EIF_Monitor
{
    public partial class eif_console : UserControl
    {
        string dir;

        public eif_console(string strEQPID, int iStatus, bool bLotRunning, string strLotID, string strdir)
        {
            InitializeComponent();

            dir = strdir;

            lbEQP_Name.Text = strEQPID;

            switch(iStatus)
            {
                case 1:
                    lbStatus.Text = "Run";
                    lbStatus.BackColor = Color.Green;
                    break;

                case 2:
                    lbStatus.Text = "Wait";
                    lbStatus.BackColor = Color.Yellow;
                    break;

                case 4:
                    lbStatus.Text = "Trouble";
                    lbStatus.BackColor = Color.Red;
                    break;

                case 8:
                    lbStatus.Text = "User Stop";
                    lbStatus.BackColor = Color.Blue;
                    break;

                default:
                    lbStatus.Text = "Error";
                    break;

            }
            if (bLotRunning)
            {
                lbLotRunning.Text = "On";
                lbLotRunning.BackColor = Color.Green;
            }
            else
            {
                lbLotRunning.Text = "Off";
                lbLotRunning.BackColor = Color.Gray;
            }

            lbLotID.Text = strLotID;
        }


        public eif_console(string strEQPID, int iStatus, bool bLotRunning, string strLotID, string strdir, int fileCnt)
        {
            InitializeComponent();

            dir = strdir;

            lbEQP_Name.Text = strEQPID;

            switch (iStatus)
            {
                case 1:
                    lbStatus.Text = "Run";
                    lbStatus.BackColor = Color.Green;
                    break;

                case 2:
                    lbStatus.Text = "Wait";
                    lbStatus.BackColor = Color.Yellow;
                    break;

                case 4:
                    lbStatus.Text = "Trouble";
                    lbStatus.BackColor = Color.Red;
                    break;

                case 8:
                    lbStatus.Text = "User Stop";
                    lbStatus.BackColor = Color.Blue;
                    break;

                default:
                    lbStatus.Text = "Error";
                    break;

            }
            if (bLotRunning)
            {
                lbLotRunning.Text = "On";
                lbLotRunning.BackColor = Color.Green;
            }
            else
            {
                lbLotRunning.Text = "Off";
                lbLotRunning.BackColor = Color.Gray;
            }

            lbLotID.Text = strLotID;

            if (fileCnt > 0) lbEQP_Name.BackColor = Color.Red;
        }

        private void eif_console_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {


        }

        private void lbEQP_Name_Click(object sender, EventArgs e)
        {
            Process.Start($"D:\\Logs\\{lbEQP_Name.Text}\\ezControl\\System");
        }



        private void btnLog_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Log log = new Log(dir);
                    log.Show();
                    break;

                case MouseButtons.Middle:
                    break;

                case MouseButtons.Right:
                    LogRpt log1 = new LogRpt(dir);
                    log1.Show();
                    break;
            }
        }
    }
}
