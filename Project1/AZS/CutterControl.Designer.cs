
namespace EIF_Monitor.AZS
{
    partial class CutterControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLotRunning = new System.Windows.Forms.Label();
            this.lbLotID = new System.Windows.Forms.Label();
            this.lbEQP_Name = new System.Windows.Forms.Label();
            this.chkLOT_END_RPT_TRIGGER = new System.Windows.Forms.CheckBox();
            this.chkLOT_START_RPT_TRIGGER = new System.Windows.Forms.CheckBox();
            this.chkLOT_INFO_REQ_TRIGGER = new System.Windows.Forms.CheckBox();
            this.chkLOT_END_BUSY = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbLotRunning
            // 
            this.lbLotRunning.BackColor = System.Drawing.SystemColors.Window;
            this.lbLotRunning.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLotRunning.ForeColor = System.Drawing.Color.Black;
            this.lbLotRunning.Location = new System.Drawing.Point(165, 12);
            this.lbLotRunning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotRunning.Name = "lbLotRunning";
            this.lbLotRunning.Size = new System.Drawing.Size(74, 32);
            this.lbLotRunning.TabIndex = 4;
            this.lbLotRunning.Text = "OFF";
            this.lbLotRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLotID
            // 
            this.lbLotID.BackColor = System.Drawing.SystemColors.Window;
            this.lbLotID.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLotID.ForeColor = System.Drawing.Color.Black;
            this.lbLotID.Location = new System.Drawing.Point(243, 12);
            this.lbLotID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLotID.Name = "lbLotID";
            this.lbLotID.Size = new System.Drawing.Size(150, 32);
            this.lbLotID.TabIndex = 2;
            this.lbLotID.Text = "Lot ID 123";
            this.lbLotID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEQP_Name
            // 
            this.lbEQP_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbEQP_Name.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbEQP_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbEQP_Name.Location = new System.Drawing.Point(16, 12);
            this.lbEQP_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEQP_Name.Name = "lbEQP_Name";
            this.lbEQP_Name.Size = new System.Drawing.Size(144, 32);
            this.lbEQP_Name.TabIndex = 3;
            this.lbEQP_Name.Text = "EQP_ID_123";
            this.lbEQP_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkLOT_END_RPT_TRIGGER
            // 
            this.chkLOT_END_RPT_TRIGGER.AutoSize = true;
            this.chkLOT_END_RPT_TRIGGER.Location = new System.Drawing.Point(19, 107);
            this.chkLOT_END_RPT_TRIGGER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLOT_END_RPT_TRIGGER.Name = "chkLOT_END_RPT_TRIGGER";
            this.chkLOT_END_RPT_TRIGGER.Size = new System.Drawing.Size(199, 19);
            this.chkLOT_END_RPT_TRIGGER.TabIndex = 16;
            this.chkLOT_END_RPT_TRIGGER.Text = "LOT_END_RPT_TRIGGER";
            this.chkLOT_END_RPT_TRIGGER.UseVisualStyleBackColor = true;
            // 
            // chkLOT_START_RPT_TRIGGER
            // 
            this.chkLOT_START_RPT_TRIGGER.AutoSize = true;
            this.chkLOT_START_RPT_TRIGGER.Location = new System.Drawing.Point(19, 83);
            this.chkLOT_START_RPT_TRIGGER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLOT_START_RPT_TRIGGER.Name = "chkLOT_START_RPT_TRIGGER";
            this.chkLOT_START_RPT_TRIGGER.Size = new System.Drawing.Size(216, 19);
            this.chkLOT_START_RPT_TRIGGER.TabIndex = 15;
            this.chkLOT_START_RPT_TRIGGER.Text = "LOT_START_RPT_TRIGGER";
            this.chkLOT_START_RPT_TRIGGER.UseVisualStyleBackColor = true;
            // 
            // chkLOT_INFO_REQ_TRIGGER
            // 
            this.chkLOT_INFO_REQ_TRIGGER.AutoSize = true;
            this.chkLOT_INFO_REQ_TRIGGER.Location = new System.Drawing.Point(19, 60);
            this.chkLOT_INFO_REQ_TRIGGER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLOT_INFO_REQ_TRIGGER.Name = "chkLOT_INFO_REQ_TRIGGER";
            this.chkLOT_INFO_REQ_TRIGGER.Size = new System.Drawing.Size(206, 19);
            this.chkLOT_INFO_REQ_TRIGGER.TabIndex = 17;
            this.chkLOT_INFO_REQ_TRIGGER.Text = "LOT_INFO_REQ_TRIGGER";
            this.chkLOT_INFO_REQ_TRIGGER.UseVisualStyleBackColor = true;
            // 
            // chkLOT_END_BUSY
            // 
            this.chkLOT_END_BUSY.AutoSize = true;
            this.chkLOT_END_BUSY.Location = new System.Drawing.Point(254, 107);
            this.chkLOT_END_BUSY.Margin = new System.Windows.Forms.Padding(2);
            this.chkLOT_END_BUSY.Name = "chkLOT_END_BUSY";
            this.chkLOT_END_BUSY.Size = new System.Drawing.Size(139, 19);
            this.chkLOT_END_BUSY.TabIndex = 18;
            this.chkLOT_END_BUSY.Text = "LOT_END_BUSY";
            this.chkLOT_END_BUSY.UseVisualStyleBackColor = true;
            // 
            // CutterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkLOT_END_BUSY);
            this.Controls.Add(this.chkLOT_INFO_REQ_TRIGGER);
            this.Controls.Add(this.chkLOT_END_RPT_TRIGGER);
            this.Controls.Add(this.chkLOT_START_RPT_TRIGGER);
            this.Controls.Add(this.lbLotRunning);
            this.Controls.Add(this.lbLotID);
            this.Controls.Add(this.lbEQP_Name);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CutterControl";
            this.Size = new System.Drawing.Size(443, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLotRunning;
        private System.Windows.Forms.Label lbLotID;
        private System.Windows.Forms.Label lbEQP_Name;
        private System.Windows.Forms.CheckBox chkLOT_END_RPT_TRIGGER;
        private System.Windows.Forms.CheckBox chkLOT_START_RPT_TRIGGER;
        private System.Windows.Forms.CheckBox chkLOT_INFO_REQ_TRIGGER;
        private System.Windows.Forms.CheckBox chkLOT_END_BUSY;
    }
}
