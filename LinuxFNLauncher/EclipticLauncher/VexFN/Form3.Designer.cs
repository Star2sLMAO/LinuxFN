namespace VexFN
{
	// Token: 0x02000004 RID: 4
	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000250C File Offset: 0x0000070C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002544 File Offset: 0x00000744
		private void InitializeComponent()
		{
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new global::System.Drawing.Point(83, 42);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(586, 37);
			this.label2.TabIndex = 37;
			this.label2.Text = "What gameserver do you want to host with?";
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 3;
			this.guna2Button1.BorderThickness = 5;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.White;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.guna2Button1.Location = new global::System.Drawing.Point(484, 143);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.Size = new global::System.Drawing.Size(128, 63);
			this.guna2Button1.TabIndex = 38;
			this.guna2Button1.Text = "Nova V2(4.5)";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.BorderRadius = 3;
			this.guna2Button2.BorderThickness = 5;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.White;
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.guna2Button2.Location = new global::System.Drawing.Point(305, 143);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.PressedColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.Size = new global::System.Drawing.Size(128, 63);
			this.guna2Button2.TabIndex = 39;
			this.guna2Button2.Text = "Raider(3.5)";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Button3.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button3.BorderRadius = 3;
			this.guna2Button3.BorderThickness = 5;
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = global::System.Drawing.Color.White;
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.guna2Button3.Location = new global::System.Drawing.Point(99, 143);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.PressedColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.Size = new global::System.Drawing.Size(150, 63);
			this.guna2Button3.TabIndex = 40;
			this.guna2Button3.Text = "UWS (S3 to S18)";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new global::System.Drawing.Point(74, 284);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(656, 37);
			this.label1.TabIndex = 41;
			this.label1.Text = "MORE GAMESERVERS WILL BE ADDED IN FUTURE!";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form2";
			this.Text = "Form2";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000004 RID: 4
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000005 RID: 5
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000006 RID: 6
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label1;
	}
}
