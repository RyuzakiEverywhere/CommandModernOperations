using System;
using System.Globalization;

namespace ns5
{
	// Token: 0x02000D4E RID: 3406
	internal static class Class2403
	{
		// Token: 0x06005922 RID: 22818 RVA: 0x00314D10 File Offset: 0x00312F10
		public static ArgumentOutOfRangeException smethod_0(string string_0, object object_0, string string_1)
		{
			string message = string_1 + Environment.NewLine + Class2407.smethod_0("Actual value was {0}.", CultureInfo.InvariantCulture, new object[]
			{
				object_0
			});
			return new ArgumentOutOfRangeException(string_0, message);
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x00314D4C File Offset: 0x00312F4C
		public static bool smethod_1<T>(Delegate74<T> creator, out T output)
		{
			Class2409.smethod_4(creator, "creator");
			bool result;
			try
			{
				output = creator();
				result = true;
			}
			catch
			{
				output = default(T);
				result = false;
			}
			return result;
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00002E47 File Offset: 0x00001047
		public static string smethod_2(object object_0)
		{
			if (object_0 == null)
			{
				return "{null}";
			}
			if (!(object_0 is string))
			{
				return object_0.ToString();
			}
			return "\"" + object_0.ToString() + "\"";
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x00314D94 File Offset: 0x00312F94
		public static bool smethod_3(byte[] byte_0, byte[] byte_1)
		{
			if (byte_0.Length != byte_1.Length)
			{
				return false;
			}
			for (int i = 0; i < byte_0.Length; i++)
			{
				if (byte_0[i] != byte_1[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00314DC8 File Offset: 0x00312FC8
		public static string smethod_4(string string_0)
		{
			string result;
			string text;
			Class2403.smethod_6(string_0, out result, out text);
			return result;
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00314DE0 File Offset: 0x00312FE0
		public static string smethod_5(string string_0)
		{
			string text;
			string result;
			Class2403.smethod_6(string_0, out text, out result);
			return result;
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00314DF8 File Offset: 0x00312FF8
		public static void smethod_6(string qualifiedName, out string prefix, out string localName)
		{
			int num = qualifiedName.IndexOf(':');
			if (num != -1 && num != 0)
			{
				if (qualifiedName.Length - 1 != num)
				{
					prefix = qualifiedName.Substring(0, num);
					localName = qualifiedName.Substring(num + 1);
					return;
				}
			}
			prefix = null;
			localName = qualifiedName;
		}
	}
}
