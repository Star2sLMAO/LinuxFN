namespace EclipticLauncher
{
	// Token: 0x02000006 RID: 6
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00003FB4 File Offset: 0x000021B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003FEC File Offset: 0x000021EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::EclipticLauncher.Form2));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.GamePathText = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button7 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button9 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			base.SuspendLayout();
			this.panel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel1.BackgroundImage");
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new global::System.Drawing.Point(236, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(373, 167);
			this.panel1.TabIndex = 1;
			this.GamePathText.BackColor = global::System.Drawing.Color.White;
			this.GamePathText.BorderColor = global::System.Drawing.Color.Black;
			this.GamePathText.BorderThickness = 3;
			this.GamePathText.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.GamePathText.DefaultText = "";
			this.GamePathText.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.GamePathText.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.GamePathText.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.GamePathText.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.GamePathText.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.GamePathText.Font = new global::System.Drawing.Font("Segoe UI Semibold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GamePathText.ForeColor = global::System.Drawing.SystemColors.MenuText;
			this.GamePathText.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.GamePathText.Location = new global::System.Drawing.Point(138, 389);
			this.GamePathText.Margin = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
			this.GamePathText.Name = "GamePathText";
			this.GamePathText.PasswordChar = '\0';
			this.GamePathText.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.GamePathText.PlaceholderText = "Fortnite Path";
			this.GamePathText.ReadOnly = true;
			this.GamePathText.SelectedText = "";
			this.GamePathText.Size = new global::System.Drawing.Size(573, 61);
			this.GamePathText.TabIndex = 6;
			this.guna2Button7.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button7.BorderRadius = 3;
			this.guna2Button7.BorderThickness = 5;
			this.guna2Button7.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button7.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button7.FillColor = global::System.Drawing.Color.White;
			this.guna2Button7.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button7.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.guna2Button7.Location = new global::System.Drawing.Point(2, 387);
			this.guna2Button7.Name = "guna2Button7";
			this.guna2Button7.PressedColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button7.Size = new global::System.Drawing.Size(128, 63);
			this.guna2Button7.TabIndex = 25;
			this.guna2Button7.Text = "Launch";
			this.guna2Button7.Click += new global::System.EventHandler(this.guna2Button7_Click);
			this.guna2Button9.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button9.BorderThickness = 3;
			this.guna2Button9.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button9.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button9.FillColor = global::System.Drawing.Color.White;
			this.guna2Button9.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button9.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.guna2Button9.Location = new global::System.Drawing.Point(719, 389);
			this.guna2Button9.Name = "guna2Button9";
			this.guna2Button9.Size = new global::System.Drawing.Size(69, 61);
			this.guna2Button9.TabIndex = 26;
			this.guna2Button9.Text = "...";
			this.guna2Button9.Click += new global::System.EventHandler(this.guna2Button9_Click);
			this.guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Location = new global::System.Drawing.Point(236, 325);
			this.guna2TextBox1.Margin = new global::System.Windows.Forms.Padding(6);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.guna2TextBox1.PlaceholderText = "Custom Username";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new global::System.Drawing.Size(369, 53);
			this.guna2TextBox1.TabIndex = 28;
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
			this.guna2Button1.Location = new global::System.Drawing.Point(688, 35);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.Size = new global::System.Drawing.Size(128, 63);
			this.guna2Button1.TabIndex = 29;
			this.guna2Button1.Text = "Back to Menu";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(843, 450);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.guna2TextBox1);
			base.Controls.Add(this.guna2Button9);
			base.Controls.Add(this.guna2Button7);
			base.Controls.Add(this.GamePathText);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form2";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001A RID: 26
		private global::Guna.UI2.WinForms.Guna2TextBox GamePathText;

		// Token: 0x0400001B RID: 27
		private global::Guna.UI2.WinForms.Guna2Button guna2Button7;

		// Token: 0x0400001C RID: 28
		private global::Guna.UI2.WinForms.Guna2Button guna2Button9;

		// Token: 0x0400001D RID: 29
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;

		// Token: 0x0400001E RID: 30
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}
