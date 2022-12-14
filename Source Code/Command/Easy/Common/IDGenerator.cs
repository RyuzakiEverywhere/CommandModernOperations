using System;
using System.Runtime.CompilerServices;
using System.Threading;
using ns1;

namespace Easy.Common
{
	// Token: 0x02000086 RID: 134
	public sealed class IDGenerator
	{
		// Token: 0x060002C8 RID: 712 RVA: 0x00060420 File Offset: 0x0005E620
		static IDGenerator()
		{
			IDGenerator.smethod_2();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002977 File Offset: 0x00000B77
		private IDGenerator()
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000048EC File Offset: 0x00002AEC
		[CompilerGenerated]
		public static IDGenerator smethod_0()
		{
			return IDGenerator.idgenerator_0;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000048F3 File Offset: 0x00002AF3
		public string method_0()
		{
			return IDGenerator.smethod_1(Interlocked.Increment(ref IDGenerator.long_0));
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00060474 File Offset: 0x0005E674
		private static string smethod_1(long long_1)
		{
			char[] value = IDGenerator.threadLocal_0.Value;
			value[7] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 60) & 31];
			value[8] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 55) & 31];
			value[9] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 50) & 31];
			value[10] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 45) & 31];
			value[11] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 40) & 31];
			value[12] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 35) & 31];
			value[13] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 30) & 31];
			value[14] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 25) & 31];
			value[15] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 20) & 31];
			value[16] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 15) & 31];
			value[17] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 10) & 31];
			value[18] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)(long_1 >> 5) & 31];
			value[19] = "0123456789ABCDEFGHIJKLMNOPQRSTUV"[(int)long_1 & 31];
			return new string(value, 0, value.Length);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000605B0 File Offset: 0x0005E7B0
		private static void smethod_2()
		{
			string text = Class82.smethod_0((long)Math.Abs(Environment.MachineName.GetHashCode()));
			int i = IDGenerator.char_0.Length - 1;
			int num = 0;
			while (i >= 0)
			{
				if (num < text.Length)
				{
					IDGenerator.char_0[i] = text[num];
					num++;
				}
				else
				{
					IDGenerator.char_0[i] = '0';
				}
				i--;
			}
		}

		// Token: 0x04000228 RID: 552
		private static readonly char[] char_0 = new char[6];

		// Token: 0x04000229 RID: 553
		private static long long_0 = DateTime.UtcNow.Ticks;

		// Token: 0x0400022A RID: 554
		private static readonly ThreadLocal<char[]> threadLocal_0 = new ThreadLocal<char[]>(new Func<char[]>(IDGenerator.<>c.<>9.method_0));

		// Token: 0x0400022B RID: 555
		[CompilerGenerated]
		private static readonly IDGenerator idgenerator_0 = new IDGenerator();
	}
}
