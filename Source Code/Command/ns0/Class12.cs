using System;

namespace ns0
{
	// Token: 0x0200001D RID: 29
	internal static class Class12
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000552D4 File Offset: 0x000534D4
		static Class12()
		{
			Class12.bool_0 = new bool[128];
			Class12.char_0 = new char[128];
			Class12.char_1 = new char[128];
			int num = 0;
			while ((long)num < 128L)
			{
				Class12.char_0[num] = (Class12.char_1[num] = (char)num);
				num++;
			}
			for (int i = 0; i < Class12.char_2.GetLength(0); i++)
			{
				char c = Class12.char_2[i, 0];
				char c2 = Class12.char_2[i, 1];
				Class12.bool_0[(int)c] = true;
				Class12.char_0[(int)c] = c2;
				Class12.char_1[(int)c2] = c;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002A87 File Offset: 0x00000C87
		public static bool smethod_0(char char_3)
		{
			return char_3 < '\u0080' && Class12.bool_0[(int)char_3];
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A9A File Offset: 0x00000C9A
		public static char smethod_1(char char_3)
		{
			if (char_3 >= '\u0080')
			{
				return char_3;
			}
			return Class12.char_0[(int)char_3];
		}

		// Token: 0x0400005A RID: 90
		private static readonly bool[] bool_0;

		// Token: 0x0400005B RID: 91
		private static readonly char[] char_0;

		// Token: 0x0400005C RID: 92
		private static readonly char[] char_1;

		// Token: 0x0400005D RID: 93
		private static readonly char[,] char_2 = new char[,]
		{
			{
				'\n',
				'n'
			},
			{
				'\t',
				't'
			},
			{
				'\v',
				'v'
			},
			{
				'\b',
				'b'
			},
			{
				'\r',
				'r'
			},
			{
				'\f',
				'f'
			},
			{
				'\a',
				'a'
			},
			{
				'\\',
				'\\'
			},
			{
				'?',
				'?'
			},
			{
				'\'',
				'\''
			},
			{
				'"',
				'"'
			}
		};
	}
}
