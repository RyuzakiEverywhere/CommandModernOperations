using System;
using Microsoft.Win32;

namespace ns8
{
	// Token: 0x020000E9 RID: 233
	internal static class Class134
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
		public static int smethod_0()
		{
			if (Class134.smethod_1())
			{
				return 10;
			}
			string text = Class134.smethod_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentVersion", "");
			if (!string.IsNullOrEmpty(text))
			{
				return int.Parse(text.Split(new char[]
				{
					'.'
				})[0]);
			}
			return Environment.OSVersion.Version.Major;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00006670 File Offset: 0x00004870
		private static bool smethod_1()
		{
			return Class134.smethod_2("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "").StartsWith("Windows 10", StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0006D4FC File Offset: 0x0006B6FC
		private static string smethod_2(string string_0, string string_1, string string_2)
		{
			string result = "";
			string str = "";
			string text = "";
			try
			{
				RegistryKey registryKey = null;
				string[] array = string_0.Split(new char[]
				{
					'\\'
				});
				if (array.Length != 0)
				{
					array[0] = array[0].ToUpper();
					if (array[0] == "HKEY_CLASSES_ROOT")
					{
						registryKey = Registry.ClassesRoot;
					}
					else if (array[0] == "HKEY_CURRENT_USER")
					{
						registryKey = Registry.CurrentUser;
					}
					else if (array[0] == "HKEY_LOCAL_MACHINE")
					{
						registryKey = Registry.LocalMachine;
					}
					else if (array[0] == "HKEY_USERS")
					{
						registryKey = Registry.Users;
					}
					else if (array[0] == "HKEY_CURRENT_CONFIG")
					{
						registryKey = Registry.CurrentConfig;
					}
					if (registryKey != null)
					{
						for (int i = 1; i < array.Length; i++)
						{
							text = text + str + array[i];
							str = "\\";
						}
						if (text != "")
						{
							registryKey = registryKey.OpenSubKey(text);
							result = (string)registryKey.GetValue(string_1, string_2);
							registryKey.Close();
						}
					}
				}
			}
			catch
			{
			}
			return result;
		}
	}
}
