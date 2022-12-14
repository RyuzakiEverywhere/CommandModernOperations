using System;
using System.IO;

namespace ns5
{
	// Token: 0x02000D44 RID: 3396
	internal static class Class2397
	{
		// Token: 0x060058DD RID: 22749 RVA: 0x00314454 File Offset: 0x00312654
		public static void smethod_0(TextWriter textWriter_0, string string_0, char char_0, bool bool_0)
		{
			if (bool_0)
			{
				textWriter_0.Write(char_0);
			}
			if (string_0 != null)
			{
				int num = 0;
				int num2 = 0;
				char[] array = null;
				int i = 0;
				while (i < string_0.Length)
				{
					char c = string_0[i];
					char c2 = c;
					string text;
					if (c2 <= '\'')
					{
						switch (c2)
						{
						case '\b':
							text = "\\b";
							break;
						case '\t':
							text = "\\t";
							break;
						case '\n':
							text = "\\n";
							break;
						case '\v':
							goto IL_DB;
						case '\f':
							text = "\\f";
							break;
						case '\r':
							text = "\\r";
							break;
						default:
							if (c2 != '"')
							{
								if (c2 != '\'')
								{
									goto IL_DB;
								}
								text = ((char_0 == '\'') ? "\\'" : null);
							}
							else
							{
								text = ((char_0 == '"') ? "\\\"" : null);
							}
							break;
						}
					}
					else if (c2 != '\\')
					{
						if (c2 != '\u0085')
						{
							switch (c2)
							{
							case '\u2028':
								text = "\\u2028";
								goto IL_111;
							case '\u2029':
								text = "\\u2029";
								goto IL_111;
							}
							goto IL_DB;
						}
						text = "\\u0085";
					}
					else
					{
						text = "\\\\";
					}
					IL_111:
					if (text != null)
					{
						if (array == null)
						{
							array = string_0.ToCharArray();
						}
						if (num2 > 0)
						{
							textWriter_0.Write(array, num, num2);
							num2 = 0;
						}
						textWriter_0.Write(text);
						num = i + 1;
					}
					else
					{
						num2++;
					}
					i++;
					continue;
					IL_DB:
					text = ((c <= '\u001f') ? Class2407.smethod_3(c) : null);
					goto IL_111;
				}
				if (num2 > 0)
				{
					if (num == 0)
					{
						textWriter_0.Write(string_0);
					}
					else
					{
						textWriter_0.Write(array, num, num2);
					}
				}
			}
			if (bool_0)
			{
				textWriter_0.Write(char_0);
			}
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x003145D4 File Offset: 0x003127D4
		public static string smethod_1(string string_0, char char_0, bool bool_0)
		{
			string result;
			using (StringWriter stringWriter = Class2407.smethod_1(Class2407.smethod_2(string_0) ?? 16))
			{
				Class2397.smethod_0(stringWriter, string_0, char_0, bool_0);
				result = stringWriter.ToString();
			}
			return result;
		}
	}
}
