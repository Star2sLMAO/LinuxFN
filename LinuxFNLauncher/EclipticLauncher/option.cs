using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using VexFN;

namespace EclipticLauncher
{
	// Token: 0x02000007 RID: 7
	public partial class option : Form
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0000499F File Offset: 0x00002B9F
		public option()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000049B8 File Offset: 0x00002BB8
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3();
			form.Show();
			base.Hide();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000049DC File Offset: 0x00002BDC
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Form2 form = new Form2();
			form.Show();
			base.Hide();
		}
	}
}
