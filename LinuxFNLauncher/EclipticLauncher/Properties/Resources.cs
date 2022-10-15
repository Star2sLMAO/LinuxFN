using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace EclipticLauncher.Properties
{
	// Token: 0x02000009 RID: 9
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002057 File Offset: 0x00000257
		internal Resources()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004ED4 File Offset: 0x000030D4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("EclipticLauncher.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004F1C File Offset: 0x0000311C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00004F33 File Offset: 0x00003133
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000024 RID: 36
		private static ResourceManager resourceMan;

		// Token: 0x04000025 RID: 37
		private static CultureInfo resourceCulture;
	}
}
