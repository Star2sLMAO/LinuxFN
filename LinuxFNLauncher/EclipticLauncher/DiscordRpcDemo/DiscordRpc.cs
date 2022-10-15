using System;
using System.Runtime.InteropServices;

namespace DiscordRpcDemo
{
	// Token: 0x0200000B RID: 11
	public class DiscordRpc
	{
		// Token: 0x06000047 RID: 71
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06000048 RID: 72
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x06000049 RID: 73
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x0600004A RID: 74
		[DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x0600004B RID: 75 RVA: 0x00004F72 File Offset: 0x00003172
		internal static void Initialize(string v1, ref object handlers, bool v2, object p)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600004E RID: 78
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000052 RID: 82
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x0200000E RID: 14
		public struct EventHandlers
		{
			// Token: 0x04000027 RID: 39
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x04000028 RID: 40
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x04000029 RID: 41
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000056 RID: 86
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x02000010 RID: 16
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x0400002A RID: 42
			public string state;

			// Token: 0x0400002B RID: 43
			public string details;

			// Token: 0x0400002C RID: 44
			public long startTimestamp;

			// Token: 0x0400002D RID: 45
			public long endTimestamp;

			// Token: 0x0400002E RID: 46
			public string largeImageKey;

			// Token: 0x0400002F RID: 47
			public string largeImageText;

			// Token: 0x04000030 RID: 48
			public string smallImageKey;

			// Token: 0x04000031 RID: 49
			public string smallImageText;

			// Token: 0x04000032 RID: 50
			public string partyId;

			// Token: 0x04000033 RID: 51
			public int partySize;

			// Token: 0x04000034 RID: 52
			public int partyMax;

			// Token: 0x04000035 RID: 53
			public string matchSecret;

			// Token: 0x04000036 RID: 54
			public string joinSecret;

			// Token: 0x04000037 RID: 55
			public string spectateSecret;

			// Token: 0x04000038 RID: 56
			public bool instance;
		}
	}
}
