
namespace EIF_Monitor
{
    partial class eif_console
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
            this.lbEQP_Name = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbLotRunning = new System.Windows.Forms.Label();
            this.lbLotID = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEQP_Name
            // 
            this.lbEQP_Name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbEQP_Name.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbEQP_Name.ForeColor = System.Drawing.Color.Blue;
            this.lbEQP_Name.Location = new System.Drawing.Point(1, 7);
            this.lbEQP_Name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbEQP_Name.Name = "lbEQP_Name";
            this.lbEQP_Name.Size = new System.Drawing.Size(199, 25);
            this.lbEQP_Name.TabIndex = 0;
            this.lbEQP_Name.Text = "EQP_ID_123";
            this.lbEQP_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbEQP_Name.Click += new System.EventHandler(this.lbEQP_Name_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.lbStatus.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(206, 7);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(125, 25);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Wait";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLotRunning
            // 
            this.lbLotRunning.BackColor = System.Drawing.SystemColors.Window;
            this.lbLotRunning.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLotRunning.ForeColor = System.Drawing.Color.Black;
            this.lbLotRunning.Location = new System.Drawing.Point(335, 7);
            this.lbLotRunning.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLotRunning.Name = "lbLotRunning";
            this.lbLotRunning.Size = new System.Drawing.Size(64, 25);
            this.lbLotRunning.TabIndex = 1;
            this.lbLotRunning.Text = "OFF";
            this.lbLotRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLotID
            // 
            this.lbLotID.BackColor = System.Drawing.SystemColors.Window;
            this.lbLotID.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLotID.ForeColor = System.Drawing.Color.Black;
            this.lbLotID.Location = new System.Drawing.Point(405, 7);
            this.lbLotID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbLotID.Name = "lbLotID";
            this.lbLotID.Size = new System.Drawing.Size(132, 25);
            this.lbLotID.TabIndex = 0;
            this.lbLotID.Text = "Lot ID 123";
            this.lbLotID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLog.Location = new System.Drawing.Point(540, 7);
            this.btnLog.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(91, 25);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "LOG";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click_1);
            this.btnLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLog_MouseDown);
            // 
            // eif_console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lbLotRunning);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbLotID);
            this.Controls.Add(this.lbEQP_Name);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "eif_console";
            this.Size = new System.Drawing.Size(640, 39);
            this.Load += new System.EventHandler(this.eif_console_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEQP_Name;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbLotRunning;
        private System.Windows.Forms.Label lbLotID;
        private System.Windows.Forms.Button btnLog;
    }
}
