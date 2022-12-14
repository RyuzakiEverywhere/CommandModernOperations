using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ns3
{
	// Token: 0x02000092 RID: 146
	internal static class Class87
	{
		// Token: 0x060002ED RID: 749 RVA: 0x00060958 File Offset: 0x0005EB58
		public static bool smethod_0()
		{
			int platform = (int)Environment.OSVersion.Platform;
			return platform == 4 || platform == 6 || platform == 128;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00060984 File Offset: 0x0005EB84
		public static void smethod_1(string string_0)
		{
			try
			{
				if (Directory.Exists(string_0))
				{
					Class87.smethod_4(string_0);
				}
				else if (File.Exists(string_0))
				{
					Class87.smethod_3(string_0);
				}
			}
			catch
			{
				Class87.smethod_2();
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000378C File Offset: 0x0000198C
		private static void smethod_2()
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000609CC File Offset: 0x0005EBCC
		private static void smethod_3(string string_0)
		{
			if (Class87.smethod_0())
			{
				Class94.smethod_0(string_0, Enum10.flag_15);
				return;
			}
			FileSecurity accessControl = File.GetAccessControl(string_0);
			SecurityIdentifier identity = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadData | FileSystemRights.WriteData | FileSystemRights.AppendData | FileSystemRights.ReadExtendedAttributes | FileSystemRights.WriteExtendedAttributes | FileSystemRights.ExecuteFile | FileSystemRights.ReadAttributes | FileSystemRights.WriteAttributes | FileSystemRights.Delete | FileSystemRights.ReadPermissions | FileSystemRights.Synchronize, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
			File.SetAccessControl(string_0, accessControl);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00060A18 File Offset: 0x0005EC18
		private static void smethod_4(string string_0)
		{
			if (Class87.smethod_0())
			{
				Class94.smethod_0(string_0, Enum10.flag_15);
				return;
			}
			DirectorySecurity accessControl = Directory.GetAccessControl(string_0);
			SecurityIdentifier identity = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.ReadData | FileSystemRights.WriteData | FileSystemRights.AppendData | FileSystemRights.ReadExtendedAttributes | FileSystemRights.WriteExtendedAttributes | FileSystemRights.ExecuteFile | FileSystemRights.ReadAttributes | FileSystemRights.WriteAttributes | FileSystemRights.Delete | FileSystemRights.ReadPermissions | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			Directory.SetAccessControl(string_0, accessControl);
		}
	}
}
