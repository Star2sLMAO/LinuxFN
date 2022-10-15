using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json.Linq;
using RiftLauncher.Helpers;
using VexFN;

namespace EclipticLauncher
{
	// Token: 0x02000006 RID: 6
	public partial class Form2 : Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003B56 File Offset: 0x00001D56
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003B70 File Offset: 0x00001D70
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

		// Token: 0x0600002E RID: 46 RVA: 0x00003BC4 File Offset: 0x00001DC4
		private void Form2_Load(object sender, EventArgs e)
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

		// Token: 0x0600002F RID: 47 RVA: 0x00003C3C File Offset: 0x00001E3C
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string json = webClient.DownloadString("https://eclipticapi.raxterxpsycho.repl.co/configss");
			JObject jobject = JObject.Parse(json);
			string text = (string)jobject["HostIp"];
			Clipboard.SetText(text);
			MessageBox.Show("Copied!", "Ecliptic");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003C8C File Offset: 0x00001E8C
		private void guna2Button7_Click(object sender, EventArgs e)
		{
			base.Hide();
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ecliptic";
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				WorkingDirectory = text + "\\Lawin\\",
				FileName = text + "\\Lawin\\start.bat",
				Arguments = "",
				CreateNoWindow = false
			};
			Process.Start(startInfo);
			Process.Start(text + "\\Lawin\\proxy.exe");
			Process process = ProcessHelper.StartProcess(this.GamePathText.Text + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
			Process process2 = ProcessHelper.StartProcess(this.GamePathText.Text + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
			Process process3 = ProcessHelper.StartProcess(this.GamePathText.Text + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-skippatchcheck -epicportal -epiclocale -fromfl=be -fltoken=6969 -NOSSLPINNING -HTTP=WinINet -log -AUTH_TYPE=epic -AUTH_LOGIN=" + this.guna2TextBox1.Text + " -AUTH_PASSWORD=unused");
			process3.WaitForInputIdle();
			string text2 = Assembly.GetExecutingAssembly().Location + "\\Lawin\\Cumar.dll";
			Process process4 = new Process();
			ProcessStartInfo startInfo2 = process4.StartInfo;
			string format = "\"{0}\" \"{1}\"";
			object arg = process3.Id;
			string text3 = text;
			startInfo2.Arguments = string.Format(format, arg, ((text3 != null) ? text3.ToString() : null) + "\\Lawin\\cumar.dll");
			process4.StartInfo.CreateNoWindow = true;
			process4.StartInfo.UseShellExecute = false;
			process4.StartInfo.FileName = text + "\\Lawin/Injector.exe";
			process4.Start();
			MessageBox.Show(new Form
			{
				TopMost = true
			}, "Press ok when you reach the lobby");
			Process process5 = new Process();
			ProcessStartInfo startInfo3 = process5.StartInfo;
			string format2 = "\"{0}\" \"{1}\"";
			object arg2 = process3.Id;
			string text4 = text;
			startInfo3.Arguments = string.Format(format2, arg2, ((text4 != null) ? text4.ToString() : null) + "\\Lawin\\console.dll");
			process5.StartInfo.CreateNoWindow = true;
			process5.StartInfo.UseShellExecute = false;
			process5.StartInfo.FileName = text + "\\Lawin/Injector.exe";
			process5.Start();
			Thread.Sleep(1000);
			process3.WaitForExit();
			base.Show();
			process.Kill();
			process2.Kill();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003ECC File Offset: 0x000020CC
		private void guna2Button9_Click(object sender, EventArgs e)
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
			commonOpenFileDialog.IsFolderPicker = true;
			commonOpenFileDialog.Title = "Select Fortnite Path";
			bool flag = commonOpenFileDialog.ShowDialog() == 1;
			if (flag)
			{
				this.GamePathText.Text = commonOpenFileDialog.FileName;
			}
			bool flag2 = !File.Exists(this.GamePathText.Text + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe");
			if (flag2)
			{
				MessageBox.Show("Invalid path! Please input valid path that contains FortniteGame and Engine");
				this.GamePathText.Text = string.Empty;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003F54 File Offset: 0x00002154
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3();
			form.ShowDialog();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002507 File Offset: 0x00000707
		private void guna2Button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002507 File Offset: 0x00000707
		private void guna2Button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003F70 File Offset: 0x00002170
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			base.Hide();
			Process process = Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Ecliptic\\S13\\EclipticLauncher.exe");
			process.WaitForExit();
			base.Show();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002507 File Offset: 0x00000707
		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003FAA File Offset: 0x000021AA
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
