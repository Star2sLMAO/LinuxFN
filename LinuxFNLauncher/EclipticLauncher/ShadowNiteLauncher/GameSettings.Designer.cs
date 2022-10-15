using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ShadowNiteLauncher
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	internal sealed partial class GameSettings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000021A0 File Offset: 0x000003A0
		public static GameSettings Default
		{
			get
			{
				return GameSettings.defaultInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021B8 File Offset: 0x000003B8
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000021DA File Offset: 0x000003DA
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string key
		{
			get
			{
				return (string)this["key"];
			}
			set
			{
				this["key"] = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021EC File Offset: 0x000003EC
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000220E File Offset: 0x0000040E
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Name
		{
			get
			{
				return (string)this["Name"];
			}
			set
			{
				this["Name"] = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002242 File Offset: 0x00000442
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Path
		{
			get
			{
				return (string)this["Path"];
			}
			set
			{
				this["Path"] = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static GameSettings defaultInstance = (GameSettings)SettingsBase.Synchronized(new GameSettings());
	}
}
