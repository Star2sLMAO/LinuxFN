namespace EclipticLauncher
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002EB4 File Offset: 0x000010B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002EEC File Offset: 0x000010EC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::EclipticLauncher.Form1));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2HtmlLabel1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2HtmlLabel2 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2HtmlLabel3 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel1.BackgroundImage");
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new global::System.Drawing.Point(208, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(313, 150);
			this.panel1.TabIndex = 0;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.White;
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button2.Location = new global::System.Drawing.Point(46, 145);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(129, 51);
			this.guna2Button2.TabIndex = 4;
			this.guna2Button2.Text = "Open S13 Hybrid";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Panel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Panel1.BackgroundImage");
			this.guna2Panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
			this.guna2Panel1.Controls.Add(this.guna2Button2);
			this.guna2Panel1.Location = new global::System.Drawing.Point(22, 214);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(228, 211);
			this.guna2Panel1.TabIndex = 5;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.guna2HtmlLabel1.BackColor = global::System.Drawing.Color.Black;
			this.guna2HtmlLabel1.Font = new global::System.Drawing.Font("Segoe UI", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2HtmlLabel1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2HtmlLabel1.Location = new global::System.Drawing.Point(20, 16);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new global::System.Drawing.Size(155, 42);
			this.guna2HtmlLabel1.TabIndex = 6;
			this.guna2HtmlLabel1.Text = "S13 Hybrid";
			this.guna2Panel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Panel2.BackgroundImage");
			this.guna2Panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
			this.guna2Panel2.Controls.Add(this.guna2Button1);
			this.guna2Panel2.Location = new global::System.Drawing.Point(293, 214);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(228, 211);
			this.guna2Panel2.TabIndex = 7;
			this.guna2HtmlLabel2.BackColor = global::System.Drawing.Color.Black;
			this.guna2HtmlLabel2.Font = new global::System.Drawing.Font("Segoe UI", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2HtmlLabel2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2HtmlLabel2.Location = new global::System.Drawing.Point(8, 13);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new global::System.Drawing.Size(217, 42);
			this.guna2HtmlLabel2.TabIndex = 6;
			this.guna2HtmlLabel2.Text = "OG Fortnite MP";
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.White;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button1.Location = new global::System.Drawing.Point(49, 142);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(117, 54);
			this.guna2Button1.TabIndex = 4;
			this.guna2Button1.Text = "Open OG MP";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click_1);
			this.guna2Panel3.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Panel3.BackgroundImage");
			this.guna2Panel3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.guna2Panel3.Controls.Add(this.guna2HtmlLabel3);
			this.guna2Panel3.Controls.Add(this.guna2Button3);
			this.guna2Panel3.Location = new global::System.Drawing.Point(560, 214);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new global::System.Drawing.Size(228, 211);
			this.guna2Panel3.TabIndex = 8;
			this.guna2HtmlLabel3.BackColor = global::System.Drawing.Color.Black;
			this.guna2HtmlLabel3.Font = new global::System.Drawing.Font("Segoe UI", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2HtmlLabel3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2HtmlLabel3.Location = new global::System.Drawing.Point(8, 13);
			this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
			this.guna2HtmlLabel3.Size = new global::System.Drawing.Size(181, 42);
			this.guna2HtmlLabel3.TabIndex = 6;
			this.guna2HtmlLabel3.Text = "20.40 Hybrid";
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = global::System.Drawing.Color.White;
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button3.Location = new global::System.Drawing.Point(58, 142);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new global::System.Drawing.Size(117, 54);
			this.guna2Button3.TabIndex = 4;
			this.guna2Button3.Text = "Open Hybrid";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.guna2Button4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = global::System.Drawing.Color.White;
			this.guna2Button4.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button4.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button4.Location = new global::System.Drawing.Point(723, 12);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new global::System.Drawing.Size(65, 54);
			this.guna2Button4.TabIndex = 7;
			this.guna2Button4.Text = "X";
			this.guna2Button4.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.guna2Button5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button5.FillColor = global::System.Drawing.Color.White;
			this.guna2Button5.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button5.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button5.Location = new global::System.Drawing.Point(638, 12);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new global::System.Drawing.Size(65, 54);
			this.guna2Button5.TabIndex = 9;
			this.guna2Button5.Text = "-";
			this.guna2Button5.Click += new global::System.EventHandler(this.guna2Button5_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.guna2Button5);
			base.Controls.Add(this.guna2Button4);
			base.Controls.Add(this.guna2Panel3);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			this.Text = "Ecliptic";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000C RID: 12
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x0400000D RID: 13
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x0400000E RID: 14
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400000F RID: 15
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

		// Token: 0x04000010 RID: 16
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel3;

		// Token: 0x04000011 RID: 17
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;

		// Token: 0x04000012 RID: 18
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000013 RID: 19
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x04000014 RID: 20
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;

		// Token: 0x04000015 RID: 21
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000016 RID: 22
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;

		// Token: 0x04000017 RID: 23
		private global::Guna.UI2.WinForms.Guna2Button guna2Button5;
	}
}
