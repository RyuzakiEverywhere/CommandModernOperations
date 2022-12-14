using System;
using System.Collections.Generic;

namespace ns1
{
	// Token: 0x02000085 RID: 133
	internal static class Class82
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x000603B8 File Offset: 0x0005E5B8
		public static string smethod_0(long long_0)
		{
			if (long_0 < 0L)
			{
				throw new Exception("Input cannot be negative.");
			}
			char[] array = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
			Stack<char> stack = new Stack<char>();
			while (long_0 != 0L)
			{
				stack.Push(array[(int)(checked((IntPtr)(long_0 % 36L)))]);
				long_0 /= 36L;
			}
			return new string(stack.ToArray());
		}
	}
}
