using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EIF_Monitor.AZS
{
    public partial class STKControl : UserControl
    {
        public STKControl()
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
        public void SetEndBusy(bool value)
        {
            chkLOT_END_BUSY.Checked = value;
            chkLOT_END_BUSY.ForeColor = value ? Color.Red : Color.Black;
        }
    }
}
