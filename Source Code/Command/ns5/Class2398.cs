using System;

namespace ns5
{
	// Token: 0x02000D48 RID: 3400
	internal sealed class Class2398
	{
		// Token: 0x060058DF RID: 22751 RVA: 0x000392A3 File Offset: 0x000374A3
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x000392AB File Offset: 0x000374AB
		public void method_1(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x000392B4 File Offset: 0x000374B4
		public Class2398()
		{
			this.char_0 = Class2398.char_1;
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x000392C7 File Offset: 0x000374C7
		public Class2398(int int_1)
		{
			this.char_0 = new char[int_1];
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00314630 File Offset: 0x00312830
		public void method_2(char char_2)
		{
			if (this.int_0 == this.char_0.Length)
			{
				this.method_4(1);
			}
			this.char_0[this.int_0++] = char_2;
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x000392DB File Offset: 0x000374DB
		public void method_3()
		{
			this.char_0 = Class2398.char_1;
			this.int_0 = 0;
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00314670 File Offset: 0x00312870
		private void method_4(int int_1)
		{
			char[] destinationArray = new char[(this.int_0 + int_1) * 2];
			Array.Copy(this.char_0, destinationArray, this.int_0);
			this.char_0 = destinationArray;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x000392EF File Offset: 0x000374EF
		public override string ToString()
		{
			return this.method_5(0, this.int_0);
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x000392FE File Offset: 0x000374FE
		public string method_5(int int_1, int int_2)
		{
			return new string(this.char_0, int_1, int_2);
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x0003930D File Offset: 0x0003750D
		public char[] method_6()
		{
			return this.char_0;
		}

		// Token: 0x04003401 RID: 13313
		private char[] char_0;

		// Token: 0x04003402 RID: 13314
		private int int_0;

		// Token: 0x04003403 RID: 13315
		private static readonly char[] char_1 = new char[0];
	}
}
