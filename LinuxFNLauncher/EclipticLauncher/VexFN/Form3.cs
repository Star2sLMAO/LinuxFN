using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VexFN
{
	// Token: 0x02000004 RID: 4
	public partial class Form3 : Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002273 File Offset: 0x00000473
		public Form3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000228C File Offset: 0x0000048C
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

		// Token: 0x0600001A RID: 26 RVA: 0x000022E0 File Offset: 0x000004E0
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
			foreach (Process process in processesByName)
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Shadownite";
				Process process2 = new Process();
				ProcessStartInfo startInfo = process2.StartInfo;
				string format = "\"{0}\" \"{1}\"";
				object arg = process.Id;
				string text2 = text;
				startInfo.Arguments = string.Format(format, arg, ((text2 != null) ? text2.ToString() : null) + "\\Lawin\\uws.dll");
				process2.StartInfo.CreateNoWindow = true;
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.FileName = text + "\\Lawin/Injector.exe";
				process2.Start();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000023A0 File Offset: 0x000005A0
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
			foreach (Process process in processesByName)
			{
				string currentDirectory = Directory.GetCurrentDirectory();
				Process process2 = new Process();
				ProcessStartInfo startInfo = process2.StartInfo;
				string format = "\"{0}\" \"{1}\"";
				object arg = process.Id;
				string text = currentDirectory;
				startInfo.Arguments = string.Format(format, arg, ((text != null) ? text.ToString() : null) + "\\Lawin\\raider.dll");
				process2.StartInfo.CreateNoWindow = true;
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.FileName = currentDirectory + "\\Lawin/Injector.exe";
				process2.Start();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002454 File Offset: 0x00000654
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
			foreach (Process process in processesByName)
			{
				string currentDirectory = Directory.GetCurrentDirectory();
				Process process2 = new Process();
				ProcessStartInfo startInfo = process2.StartInfo;
				string format = "\"{0}\" \"{1}\"";
				object arg = process.Id;
				string text = currentDirectory;
				startInfo.Arguments = string.Format(format, arg, ((text != null) ? text.ToString() : null) + "\\Lawin\\nova.dll");
				process2.StartInfo.CreateNoWindow = true;
				process2.StartInfo.UseShellExecute = false;
				process2.StartInfo.FileName = currentDirectory + "\\Lawin/Injector.exe";
				process2.Start();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002507 File Offset: 0x00000707
		private void Form2_Load(object sender, EventArgs e)
		{
		}
	}
}
