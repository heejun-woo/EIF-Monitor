
namespace EIF_Monitor.AZS
{
    partial class AZS_Monitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogFileName = new System.Windows.Forms.TextBox();
            this.txtCutterName4 = new System.Windows.Forms.TextBox();
            this.txtCutterName3 = new System.Windows.Forms.TextBox();
            this.txtCutterName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCutterName1 = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lbMiliSec = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStackingName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AZS_STK = new EIF_Monitor.AZS.AZS_STK_Console();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cutter4 = new EIF_Monitor.AZS.CutterControl();
            this.cutter3 = new EIF_Monitor.AZS.CutterControl();
            this.cutter2 = new EIF_Monitor.AZS.CutterControl();
            this.cutter1 = new EIF_Monitor.AZS.CutterControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLogFileName);
            this.panel1.Controls.Add(this.txtCutterName4);
            this.panel1.Controls.Add(this.txtCutterName3);
            this.panel1.Controls.Add(this.txtCutterName2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCutterName1);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.lbMiliSec);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnExe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStackingName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1778, 112);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(1374, 60);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "-1M";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(1302, 61);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 25);
            this.button6.TabIndex = 17;
            this.button6.Text = "+1M";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1136, 22);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "다음 찾기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(1231, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "-1S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(1159, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "+1S";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Log File Name :";
            // 
            // txtLogFileName
            // 
            this.txtLogFileName.Location = new System.Drawing.Point(437, 63);
            this.txtLogFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogFileName.Name = "txtLogFileName";
            this.txtLogFileName.Size = new System.Drawing.Size(201, 25);
            this.txtLogFileName.TabIndex = 12;
            this.txtLogFileName.Text = "VARIABLE_TRACE_0320.log";
            // 
            // txtCutterName4
            // 
            this.txtCutterName4.Location = new System.Drawing.Point(770, 24);
            this.txtCutterName4.Margin = new System.Windows.Forms.Padding(2);
            this.txtCutterName4.Name = "txtCutterName4";
            this.txtCutterName4.Size = new System.Drawing.Size(219, 25);
            this.txtCutterName4.TabIndex = 11;
            this.txtCutterName4.Text = "B1AAZS018";
            // 
            // txtCutterName3
            // 
            this.txtCutterName3.Location = new System.Drawing.Point(546, 24);
            this.txtCutterName3.Margin = new System.Windows.Forms.Padding(2);
            this.txtCutterName3.Name = "txtCutterName3";
            this.txtCutterName3.Size = new System.Drawing.Size(219, 25);
            this.txtCutterName3.TabIndex = 10;
            this.txtCutterName3.Text = "B1AAZS017";
            // 
            // txtCutterName2
            // 
            this.txtCutterName2.Location = new System.Drawing.Point(323, 24);
            this.txtCutterName2.Margin = new System.Windows.Forms.Padding(2);
            this.txtCutterName2.Name = "txtCutterName2";
            this.txtCutterName2.Size = new System.Drawing.Size(219, 25);
            this.txtCutterName2.TabIndex = 9;
            this.txtCutterName2.Text = "B1AAZS016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cutter :";
            // 
            // txtCutterName1
            // 
            this.txtCutterName1.Location = new System.Drawing.Point(91, 24);
            this.txtCutterName1.Margin = new System.Windows.Forms.Padding(2);
            this.txtCutterName1.Name = "txtCutterName1";
            this.txtCutterName1.Size = new System.Drawing.Size(219, 25);
            this.txtCutterName1.TabIndex = 7;
            this.txtCutterName1.Text = "B1AAZS015";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(1086, 64);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(69, 25);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-0.1S";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lbMiliSec
            // 
            this.lbMiliSec.AutoSize = true;
            this.lbMiliSec.Location = new System.Drawing.Point(959, 68);
            this.lbMiliSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMiliSec.Name = "lbMiliSec";
            this.lbMiliSec.Size = new System.Drawing.Size(0, 15);
            this.lbMiliSec.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1014, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "이전 찾기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(1014, 65);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(69, 25);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+0.1S";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(846, 62);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 25);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(726, 60);
            this.btnExe.Margin = new System.Windows.Forms.Padding(2);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(98, 31);
            this.btnExe.TabIndex = 2;
            this.btnExe.Text = "선택";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stacking :";
            // 
            // txtStackingName
            // 
            this.txtStackingName.Location = new System.Drawing.Point(91, 65);
            this.txtStackingName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStackingName.Name = "txtStackingName";
            this.txtStackingName.Size = new System.Drawing.Size(219, 25);
            this.txtStackingName.TabIndex = 0;
            this.txtStackingName.Text = "B1AAZS102";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AZS_STK);
            this.groupBox1.Location = new System.Drawing.Point(455, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1215, 894);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stacking";
            // 
            // AZS_STK
            // 
            this.AZS_STK.Location = new System.Drawing.Point(18, 22);
            this.AZS_STK.Margin = new System.Windows.Forms.Padding(2);
            this.AZS_STK.Name = "AZS_STK";
            this.AZS_STK.Size = new System.Drawing.Size(1201, 852);
            this.AZS_STK.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cutter4);
            this.groupBox2.Controls.Add(this.cutter3);
            this.groupBox2.Controls.Add(this.cutter2);
            this.groupBox2.Controls.Add(this.cutter1);
            this.groupBox2.Location = new System.Drawing.Point(10, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(430, 888);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cutter";
            // 
            // cutter4
            // 
            this.cutter4.Location = new System.Drawing.Point(10, 462);
            this.cutter4.Margin = new System.Windows.Forms.Padding(2);
            this.cutter4.Name = "cutter4";
            this.cutter4.Size = new System.Drawing.Size(413, 154);
            this.cutter4.TabIndex = 3;
            // 
            // cutter3
            // 
            this.cutter3.Location = new System.Drawing.Point(10, 318);
            this.cutter3.Margin = new System.Windows.Forms.Padding(2);
            this.cutter3.Name = "cutter3";
            this.cutter3.Size = new System.Drawing.Size(413, 154);
            this.cutter3.TabIndex = 2;
            // 
            // cutter2
            // 
            this.cutter2.Location = new System.Drawing.Point(10, 179);
            this.cutter2.Margin = new System.Windows.Forms.Padding(2);
            this.cutter2.Name = "cutter2";
            this.cutter2.Size = new System.Drawing.Size(413, 154);
            this.cutter2.TabIndex = 1;
            // 
            // cutter1
            // 
            this.cutter1.Location = new System.Drawing.Point(10, 32);
            this.cutter1.Margin = new System.Windows.Forms.Padding(2);
            this.cutter1.Name = "cutter1";
            this.cutter1.Size = new System.Drawing.Size(413, 154);
            this.cutter1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-1",
            "1-2",
            "2-1",
            "2-2"});
            this.comboBox1.Location = new System.Drawing.Point(653, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 23);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AZS_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1132);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AZS_Monitor";
            this.Text = "AZS_Monitor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStackingName;
        private System.Windows.Forms.Button btnExe;
        private AZS_STK_Console AZS_STK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lbMiliSec;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CutterControl cutter1;
        private CutterControl cutter4;
        private CutterControl cutter3;
        private CutterControl cutter2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCutterName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogFileName;
        private System.Windows.Forms.TextBox txtCutterName4;
        private System.Windows.Forms.TextBox txtCutterName3;
        private System.Windows.Forms.TextBox txtCutterName2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}