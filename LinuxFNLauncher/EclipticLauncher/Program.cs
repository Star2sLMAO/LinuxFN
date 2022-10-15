using System;
using System.Windows.Forms;

namespace EclipticLauncher
{
	// Token: 0x02000008 RID: 8
	internal static class Program
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00004EB6 File Offset: 0x000030B6
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
