using System;

namespace ns8
{
	// Token: 0x02000105 RID: 261
	internal sealed class Class148
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x000742C4 File Offset: 0x000724C4
		public Class148(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("headerBytes");
			}
			if (byte_0.Length != 100)
			{
				throw new InvalidOperationException(string.Format("headerBytes must be {0} bytes long", 100));
			}
			this.int_0 = Class147.smethod_0(byte_0, 0, Enum26.const_0);
			if (this.int_0 != 9994)
			{
				throw new InvalidOperationException(string.Format("Header File code is {0}, expected {1}", this.int_0, 9994));
			}
			this.int_2 = Class147.smethod_0(byte_0, 28, Enum26.const_1);
			if (this.int_2 != 1000)
			{
				throw new InvalidOperationException(string.Format("Header version is {0}, expected {1}", this.int_2, 1000));
			}
			this.int_1 = Class147.smethod_0(byte_0, 24, Enum26.const_0);
			this.enum27_0 = (Enum27)Class147.smethod_0(byte_0, 32, Enum26.const_1);
			this.double_0 = Class147.smethod_1(byte_0, 36, Enum26.const_1);
			this.double_1 = Class147.smethod_1(byte_0, 44, Enum26.const_1);
			this.double_2 = Class147.smethod_1(byte_0, 52, Enum26.const_1);
			this.double_3 = Class147.smethod_1(byte_0, 60, Enum26.const_1);
			this.double_4 = Class147.smethod_1(byte_0, 68, Enum26.const_1);
			this.double_5 = Class147.smethod_1(byte_0, 76, Enum26.const_1);
			this.double_6 = Class147.smethod_1(byte_0, 84, Enum26.const_1);
			this.double_7 = Class147.smethod_1(byte_0, 92, Enum26.const_1);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00006AEF File Offset: 0x00004CEF
		public int method_0()
		{
			return this.int_1;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00006AF7 File Offset: 0x00004CF7
		public Enum27 method_1()
		{
			return this.enum27_0;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00006AFF File Offset: 0x00004CFF
		public double method_2()
		{
			return this.double_0;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00006B07 File Offset: 0x00004D07
		public double method_3()
		{
			return this.double_1;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00006B0F File Offset: 0x00004D0F
		public double method_4()
		{
			return this.double_2;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00006B17 File Offset: 0x00004D17
		public double method_5()
		{
			return this.double_3;
		}

		// Token: 0x04000493 RID: 1171
		private int int_0;

		// Token: 0x04000494 RID: 1172
		private int int_1;

		// Token: 0x04000495 RID: 1173
		private int int_2;

		// Token: 0x04000496 RID: 1174
		private Enum27 enum27_0;

		// Token: 0x04000497 RID: 1175
		private double double_0;

		// Token: 0x04000498 RID: 1176
		private double double_1;

		// Token: 0x04000499 RID: 1177
		private double double_2;

		// Token: 0x0400049A RID: 1178
		private double double_3;

		// Token: 0x0400049B RID: 1179
		private double double_4;

		// Token: 0x0400049C RID: 1180
		private double double_5;

		// Token: 0x0400049D RID: 1181
		private double double_6;

		// Token: 0x0400049E RID: 1182
		private double double_7;
	}
}
