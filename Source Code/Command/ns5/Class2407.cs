using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns5
{
	// Token: 0x02000D52 RID: 3410
	internal static class Class2407
	{
		// Token: 0x0600595A RID: 22874 RVA: 0x000398E4 File Offset: 0x00037AE4
		public static string smethod_0(string string_0, IFormatProvider iformatProvider_0, object[] object_0)
		{
			Class2409.smethod_4(string_0, "format");
			return string.Format(iformatProvider_0, string_0, object_0);
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x0031597C File Offset: 0x00313B7C
		public static StringWriter smethod_1(int int_0)
		{
			StringBuilder sb = new StringBuilder(int_0);
			return new StringWriter(sb, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x003159A0 File Offset: 0x00313BA0
		public static int? smethod_2(string string_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			return new int?(string_0.Length);
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x003159C8 File Offset: 0x00313BC8
		public static string smethod_3(char char_0)
		{
			char c = Class2402.smethod_1((int)(char_0 >> 12 & '\u000f'));
			char c2 = Class2402.smethod_1((int)(char_0 >> 8 & '\u000f'));
			char c3 = Class2402.smethod_1((int)(char_0 >> 4 & '\u000f'));
			char c4 = Class2402.smethod_1((int)(char_0 & '\u000f'));
			return new string(new char[]
			{
				'\\',
				'u',
				c,
				c2,
				c3,
				c4
			});
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x00315A34 File Offset: 0x00313C34
		public static TSource smethod_4<TSource>(IEnumerable<TSource> ienumerable_0, Func<TSource, string> func_0, string string_0)
		{
			Func<TSource, bool> func = null;
			Class2407.Class2408<TSource> @class = new Class2407.Class2408<TSource>();
			@class.func_0 = func_0;
			@class.string_0 = string_0;
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("source");
			}
			if (@class.func_0 == null)
			{
				throw new ArgumentNullException("valueSelector");
			}
			IEnumerable<TSource> enumerable = Enumerable.Where<TSource>(ienumerable_0, new Func<TSource, bool>(@class.method_0));
			if (Enumerable.Count<TSource>(enumerable) <= 1)
			{
				return Enumerable.SingleOrDefault<TSource>(enumerable);
			}
			if (func == null)
			{
				func = new Func<TSource, bool>(@class.method_1);
			}
			IEnumerable<TSource> enumerable2 = Enumerable.Where<TSource>(ienumerable_0, func);
			return Enumerable.SingleOrDefault<TSource>(enumerable2);
		}

		// Token: 0x02000D53 RID: 3411
		[CompilerGenerated]
		private sealed class Class2408<TSource>
		{
			// Token: 0x06005960 RID: 22880 RVA: 0x000398F9 File Offset: 0x00037AF9
			public bool method_0(TSource gparam_0)
			{
				return string.Compare(this.func_0(gparam_0), this.string_0, StringComparison.OrdinalIgnoreCase) == 0;
			}

			// Token: 0x06005961 RID: 22881 RVA: 0x00039916 File Offset: 0x00037B16
			public bool method_1(TSource gparam_0)
			{
				return string.Compare(this.func_0(gparam_0), this.string_0, StringComparison.Ordinal) == 0;
			}

			// Token: 0x0400340F RID: 13327
			public Func<TSource, string> func_0;

			// Token: 0x04003410 RID: 13328
			public string string_0;
		}
	}
}
