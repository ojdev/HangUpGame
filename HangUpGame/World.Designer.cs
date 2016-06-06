/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 20:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace HangUpGame
{
	partial class World
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtLeadName;
		private System.Windows.Forms.Button btnGoWorld;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbLog;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtLeadName = new System.Windows.Forms.TextBox();
            this.btnGoWorld = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentBloodLabel = new System.Windows.Forms.Label();
            this.TotaleBloodLabel = new System.Windows.Forms.Label();
            this.CurrentXPLabel = new System.Windows.Forms.Label();
            this.UpgradeXPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLeadName
            // 
            this.txtLeadName.Location = new System.Drawing.Point(74, 12);
            this.txtLeadName.Name = "txtLeadName";
            this.txtLeadName.Size = new System.Drawing.Size(108, 21);
            this.txtLeadName.TabIndex = 0;
            // 
            // btnGoWorld
            // 
            this.btnGoWorld.Location = new System.Drawing.Point(188, 12);
            this.btnGoWorld.Name = "btnGoWorld";
            this.btnGoWorld.Size = new System.Drawing.Size(75, 23);
            this.btnGoWorld.TabIndex = 1;
            this.btnGoWorld.Text = "进入世界";
            this.btnGoWorld.UseVisualStyleBackColor = true;
            this.btnGoWorld.Click += new System.EventHandler(this.btnGoWorld_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "名字：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLog
            // 
            this.lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 12;
            this.lbLog.Location = new System.Drawing.Point(0, 42);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(1056, 580);
            this.lbLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(278, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "血量：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentBloodLabel
            // 
            this.CurrentBloodLabel.Location = new System.Drawing.Point(340, 12);
            this.CurrentBloodLabel.Name = "CurrentBloodLabel";
            this.CurrentBloodLabel.Size = new System.Drawing.Size(56, 23);
            this.CurrentBloodLabel.TabIndex = 5;
            this.CurrentBloodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotaleBloodLabel
            // 
            this.TotaleBloodLabel.Location = new System.Drawing.Point(402, 12);
            this.TotaleBloodLabel.Name = "TotaleBloodLabel";
            this.TotaleBloodLabel.Size = new System.Drawing.Size(56, 23);
            this.TotaleBloodLabel.TabIndex = 6;
            this.TotaleBloodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentXPLabel
            // 
            this.CurrentXPLabel.Location = new System.Drawing.Point(464, 12);
            this.CurrentXPLabel.Name = "CurrentXPLabel";
            this.CurrentXPLabel.Size = new System.Drawing.Size(112, 23);
            this.CurrentXPLabel.TabIndex = 7;
            this.CurrentXPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpgradeXPLabel
            // 
            this.UpgradeXPLabel.Location = new System.Drawing.Point(582, 12);
            this.UpgradeXPLabel.Name = "UpgradeXPLabel";
            this.UpgradeXPLabel.Size = new System.Drawing.Size(112, 23);
            this.UpgradeXPLabel.TabIndex = 8;
            this.UpgradeXPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // World
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 622);
            this.Controls.Add(this.UpgradeXPLabel);
            this.Controls.Add(this.CurrentXPLabel);
            this.Controls.Add(this.TotaleBloodLabel);
            this.Controls.Add(this.CurrentBloodLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoWorld);
            this.Controls.Add(this.txtLeadName);
            this.Name = "World";
            this.Text = "World";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentBloodLabel;
        private System.Windows.Forms.Label TotaleBloodLabel;
        private System.Windows.Forms.Label CurrentXPLabel;
        private System.Windows.Forms.Label UpgradeXPLabel;
    }
}
