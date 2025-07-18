
namespace EIF_Monitor
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.rb1Gb = new System.Windows.Forms.RadioButton();
            this.rb100mb = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb100mb);
            this.panel1.Controls.Add(this.rb1Gb);
            this.panel1.Controls.Add(this.chkSearch);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnReLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 45);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "AZS - Monitor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(15, 8);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(112, 30);
            this.btnReLoad.TabIndex = 0;
            this.btnReLoad.Text = "새로고침";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 45);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(804, 674);
            this.pnMain.TabIndex = 2;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.Location = new System.Drawing.Point(329, 15);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(105, 19);
            this.chkSearch.TabIndex = 3;
            this.chkSearch.Text = "Log Search";
            this.chkSearch.UseVisualStyleBackColor = true;
            // 
            // rb1Gb
            // 
            this.rb1Gb.AutoSize = true;
            this.rb1Gb.Checked = true;
            this.rb1Gb.Location = new System.Drawing.Point(151, 14);
            this.rb1Gb.Name = "rb1Gb";
            this.rb1Gb.Size = new System.Drawing.Size(62, 19);
            this.rb1Gb.TabIndex = 4;
            this.rb1Gb.TabStop = true;
            this.rb1Gb.Text = "1 GB";
            this.rb1Gb.UseVisualStyleBackColor = true;
            // 
            // rb100mb
            // 
            this.rb100mb.AutoSize = true;
            this.rb100mb.Location = new System.Drawing.Point(219, 14);
            this.rb100mb.Name = "rb100mb";
            this.rb100mb.Size = new System.Drawing.Size(74, 19);
            this.rb100mb.TabIndex = 5;
            this.rb100mb.Text = "100MB";
            this.rb100mb.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 719);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkSearch;
        private System.Windows.Forms.RadioButton rb100mb;
        private System.Windows.Forms.RadioButton rb1Gb;
    }
}