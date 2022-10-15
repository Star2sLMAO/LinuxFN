using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using DiscordRpcDemo;
using Guna.UI2.WinForms;

namespace EclipticLauncher
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public Form1()
		{
			this.InitializeComponent();
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("1030054598372773910", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("1030054598372773910", ref this.handlers, true, null);
			this.presence.details = "LinuxFN";
			this.presence.state = "dsc.gg/linuxfn";
			this.presence.largeImageKey = "linux_png";
			this.presence.smallImageKey = "linux_png";
			DiscordRpc.UpdatePresence(ref this.presence);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002C98 File Offset: 0x00000E98
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			int num = msg;
			if (num != 132)
			{
				base.WndProc(ref m);
			}
			else
			{
				base.WndProc(ref m);
				bool flag = (int)m.Result == 1;
				if (flag)
				{
					m.Result = (IntPtr)2;
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002CEA File Offset: 0x00000EEA
		public void Msg(string TEXT)
		{
			MessageBox.Show(TEXT, "Ecliptic");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002CFC File Offset: 0x00000EFC
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ecliptic";
			bool flag = !File.Exists(str + "\\s13\\s13.exe");
			if (flag)
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/1019134010213011466/1030917253677465660/s13.zip", str + "\\S13\\test.zip");
				ZipFile.ExtractToDirectory(str + "\\S13\\test.zip", str + "\\S13");
			}
			Process.Start(str + "\\S13\\s13.exe");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D80 File Offset: 0x00000F80
		private void Form1_Load(object sender, EventArgs e)
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ecliptic";
			bool flag = !Directory.Exists(text);
			if (flag)
			{
				Directory.CreateDirectory(text);
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://ShadowNiteBot.raxterxpsycho.repl.co/Yes.zip", text + "\\b.zip");
				ZipFile.ExtractToDirectory(text + "\\b.zip", text);
				File.Delete(text + "\\b.zip");
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002507 File Offset: 0x00000707
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002DF8 File Offset: 0x00000FF8
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			option option = new option();
			base.Hide();
			option.Show();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E1C File Offset: 0x0000101C
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ecliptic";
			bool flag = !File.Exists(str + "\\Lawin\\dev.exe");
			if (flag)
			{
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/1020740735756148810/1030047242670833684/Testing.zip", str + "\\Lawin\\test.zip");
				ZipFile.ExtractToDirectory(str + "\\Lawin\\test.zip", str + "\\Lawin");
			}
			Process.Start(str + "\\Lawin\\dev.exe");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E9F File Offset: 0x0000109F
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002EA8 File Offset: 0x000010A8
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x04000008 RID: 8
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x04000009 RID: 9
		private DiscordRpc.RichPresence presence;
	}
}
