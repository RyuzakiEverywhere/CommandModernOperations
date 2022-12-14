using System;
using System.Collections.Generic;
using System.Globalization;

namespace ns1
{
	// Token: 0x0200007C RID: 124
	internal sealed class Class80
	{
		// Token: 0x0600024F RID: 591 RVA: 0x00004017 File Offset: 0x00002217
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000401F File Offset: 0x0000221F
		public string method_1()
		{
			return this.method_6(Class80.Enum4.const_0, false);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0005D948 File Offset: 0x0005BB48
		public Class74 method_2()
		{
			int num = (int)this.method_4(Class80.Enum4.const_3);
			double double_ = this.method_4(Class80.Enum4.const_4);
			if (num < 57)
			{
				num += 2000;
			}
			else
			{
				num += 1900;
			}
			return new Class74(num, double_);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00004029 File Offset: 0x00002229
		public Class80(string string_3, string string_4, string string_5)
		{
			this.string_0 = string_3;
			this.string_1 = string_4;
			this.string_2 = string_5;
			this.method_3();
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0005D984 File Offset: 0x0005BB84
		private void method_3()
		{
			this.dictionary_0 = new Dictionary<Class80.Enum4, string>();
			this.dictionary_1 = new Dictionary<int, double>();
			this.dictionary_0[Class80.Enum4.const_0] = this.string_1.Substring(2, 5);
			this.dictionary_0[Class80.Enum4.const_1] = this.string_1.Substring(9, 8);
			this.dictionary_0[Class80.Enum4.const_3] = this.string_1.Substring(18, 2);
			this.dictionary_0[Class80.Enum4.const_4] = this.string_1.Substring(20, 12);
			if (this.string_1[33] == '-')
			{
				this.dictionary_0[Class80.Enum4.const_12] = "-0";
			}
			else
			{
				this.dictionary_0[Class80.Enum4.const_12] = "0";
			}
			Dictionary<Class80.Enum4, string> dictionary = this.dictionary_0;
			dictionary[Class80.Enum4.const_12] = dictionary[Class80.Enum4.const_12] + this.string_1.Substring(34, 10);
			this.dictionary_0[Class80.Enum4.const_13] = Class80.smethod_3(this.string_1.Substring(44, 8));
			this.dictionary_0[Class80.Enum4.const_14] = Class80.smethod_3(this.string_1.Substring(53, 8));
			this.dictionary_0[Class80.Enum4.const_2] = this.string_1.Substring(64, 4).TrimStart(new char[0]);
			this.dictionary_0[Class80.Enum4.const_6] = this.string_2.Substring(8, 8).TrimStart(new char[0]);
			this.dictionary_0[Class80.Enum4.const_7] = this.string_2.Substring(17, 8).TrimStart(new char[0]);
			this.dictionary_0[Class80.Enum4.const_8] = "0." + this.string_2.Substring(26, 7);
			this.dictionary_0[Class80.Enum4.const_9] = this.string_2.Substring(34, 8).TrimStart(new char[0]);
			this.dictionary_0[Class80.Enum4.const_10] = this.string_2.Substring(43, 8).TrimStart(new char[0]);
			this.dictionary_0[Class80.Enum4.const_11] = this.string_2.Substring(52, 11).TrimStart(new char[0]);
			this.dictionary_0[Class80.Enum4.const_5] = this.string_2.Substring(63, 5).TrimStart(new char[0]);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000404C File Offset: 0x0000224C
		public double method_4(Class80.Enum4 enum4_0)
		{
			return this.method_5(enum4_0, Class80.Enum5.const_2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0005DBDC File Offset: 0x0005BDDC
		public double method_5(Class80.Enum4 enum4_0, Class80.Enum5 enum5_0)
		{
			int key = Class80.smethod_0(enum5_0, enum4_0);
			if (this.dictionary_1.ContainsKey(key))
			{
				return this.dictionary_1[key];
			}
			double num = Class80.smethod_1(double.Parse(this.dictionary_0[enum4_0].ToString(), CultureInfo.InvariantCulture), enum4_0, enum5_0);
			this.dictionary_1[key] = num;
			return num;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0005DC40 File Offset: 0x0005BE40
		public string method_6(Class80.Enum4 enum4_0, bool bool_0)
		{
			string text = this.dictionary_0[enum4_0].ToString();
			if (bool_0)
			{
				text += Class80.smethod_2(enum4_0);
			}
			return text.Trim();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00004056 File Offset: 0x00002256
		private static int smethod_0(Class80.Enum5 enum5_0, Class80.Enum4 enum4_0)
		{
			return (int)(enum5_0 * (Class80.Enum5)100 + (int)enum4_0);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000405E File Offset: 0x0000225E
		protected static double smethod_1(double double_0, Class80.Enum4 enum4_0, Class80.Enum5 enum5_0)
		{
			if ((enum4_0 == Class80.Enum4.const_6 || enum4_0 == Class80.Enum4.const_7 || enum4_0 == Class80.Enum4.const_9 || enum4_0 == Class80.Enum4.const_10) && enum5_0 == Class80.Enum5.const_0)
			{
				return Class73.smethod_4(double_0);
			}
			return double_0;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000407D File Offset: 0x0000227D
		protected static string smethod_2(Class80.Enum4 enum4_0)
		{
			switch (enum4_0)
			{
			case Class80.Enum4.const_6:
			case Class80.Enum4.const_7:
			case Class80.Enum4.const_9:
			case Class80.Enum4.const_10:
				return " degrees";
			default:
				return string.Empty;
			case Class80.Enum4.const_11:
				return " revs / day";
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0005DC78 File Offset: 0x0005BE78
		protected static string smethod_3(string string_3)
		{
			string text = string_3.Substring(0, 1);
			string text2 = string_3.Substring(1, 5);
			string text3 = string_3.Substring(6, 2).TrimStart(new char[0]);
			double num = double.Parse(string.Concat(new string[]
			{
				text,
				"0.",
				text2,
				"e",
				text3
			}), CultureInfo.InvariantCulture);
			int num2 = text2.Length + Math.Abs(int.Parse(text3, CultureInfo.InvariantCulture));
			return num.ToString("F" + num2, CultureInfo.InvariantCulture);
		}

		// Token: 0x040001CA RID: 458
		private string string_0;

		// Token: 0x040001CB RID: 459
		private string string_1;

		// Token: 0x040001CC RID: 460
		private string string_2;

		// Token: 0x040001CD RID: 461
		private Dictionary<Class80.Enum4, string> dictionary_0;

		// Token: 0x040001CE RID: 462
		private Dictionary<int, double> dictionary_1;

		// Token: 0x0200007D RID: 125
		internal enum Enum4
		{
			// Token: 0x040001D0 RID: 464
			const_0,
			// Token: 0x040001D1 RID: 465
			const_1,
			// Token: 0x040001D2 RID: 466
			const_2,
			// Token: 0x040001D3 RID: 467
			const_3,
			// Token: 0x040001D4 RID: 468
			const_4,
			// Token: 0x040001D5 RID: 469
			const_5,
			// Token: 0x040001D6 RID: 470
			const_6,
			// Token: 0x040001D7 RID: 471
			const_7,
			// Token: 0x040001D8 RID: 472
			const_8,
			// Token: 0x040001D9 RID: 473
			const_9,
			// Token: 0x040001DA RID: 474
			const_10,
			// Token: 0x040001DB RID: 475
			const_11,
			// Token: 0x040001DC RID: 476
			const_12,
			// Token: 0x040001DD RID: 477
			const_13,
			// Token: 0x040001DE RID: 478
			const_14
		}

		// Token: 0x0200007E RID: 126
		internal enum Enum5
		{
			// Token: 0x040001E0 RID: 480
			const_0,
			// Token: 0x040001E1 RID: 481
			const_1,
			// Token: 0x040001E2 RID: 482
			const_2
		}
	}
}
