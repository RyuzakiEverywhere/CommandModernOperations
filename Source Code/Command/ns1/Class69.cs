using System;
using System.Collections.Generic;

namespace ns1
{
	// Token: 0x0200006F RID: 111
	internal sealed class Class69<T>
	{
		// Token: 0x060001EA RID: 490 RVA: 0x00003C07 File Offset: 0x00001E07
		public Class69()
		{
			this.icomparer_0 = Comparer<T>.Default;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00003C25 File Offset: 0x00001E25
		public Class69(IComparer<T> icomparer_1)
		{
			this.icomparer_0 = icomparer_1;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00003C3F File Offset: 0x00001E3F
		public Class69(IComparer<T> icomparer_1, int int_0)
		{
			this.icomparer_0 = icomparer_1;
			this.list_0.Capacity = int_0;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00059FE0 File Offset: 0x000581E0
		protected void method_0(int int_0, int int_1)
		{
			T value = this.list_0[int_0];
			this.list_0[int_0] = this.list_0[int_1];
			this.list_0[int_1] = value;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003C65 File Offset: 0x00001E65
		protected int vmethod_0(int int_0, int int_1)
		{
			return this.icomparer_0.Compare(this.list_0[int_0], this.list_0[int_1]);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0005A020 File Offset: 0x00058220
		public int vmethod_1(T gparam_0)
		{
			int num = this.list_0.Count;
			this.list_0.Add(gparam_0);
			while (num != 0)
			{
				int num2 = (num - 1) / 2;
				if (this.vmethod_0(num, num2) >= 0)
				{
					break;
				}
				this.method_0(num, num2);
				num = num2;
			}
			return num;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0005A068 File Offset: 0x00058268
		public T vmethod_2()
		{
			T result = this.list_0[0];
			int num = 0;
			this.list_0[0] = this.list_0[this.list_0.Count - 1];
			this.list_0.RemoveAt(this.list_0.Count - 1);
			for (;;)
			{
				int num2 = num;
				int num3 = 2 * num + 1;
				int num4 = 2 * num + 2;
				if (this.list_0.Count > num3 && this.vmethod_0(num, num3) > 0)
				{
					num = num3;
				}
				if (this.list_0.Count > num4 && this.vmethod_0(num, num4) > 0)
				{
					num = num4;
				}
				if (num == num2)
				{
					break;
				}
				this.method_0(num, num2);
			}
			return result;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0005A11C File Offset: 0x0005831C
		public void vmethod_3(int int_0)
		{
			int num;
			int num2;
			for (num = int_0; num != 0; num = num2)
			{
				num2 = (num - 1) / 2;
				if (this.vmethod_0(num, num2) >= 0)
				{
					break;
				}
				this.method_0(num, num2);
			}
			if (num < int_0)
			{
				return;
			}
			for (;;)
			{
				int num3 = num;
				int num4 = 2 * num + 1;
				num2 = 2 * num + 2;
				if (this.list_0.Count > num4 && this.vmethod_0(num, num4) > 0)
				{
					num = num4;
				}
				if (this.list_0.Count > num2 && this.vmethod_0(num, num2) > 0)
				{
					num = num2;
				}
				if (num == num3)
				{
					break;
				}
				this.method_0(num, num3);
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00003C8A File Offset: 0x00001E8A
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00003C97 File Offset: 0x00001E97
		public int method_2()
		{
			return this.list_0.Count;
		}

		// Token: 0x17000019 RID: 25
		public T this[int int_0]
		{
			get
			{
				return this.list_0[int_0];
			}
			set
			{
				this.list_0[int_0] = value;
				this.vmethod_3(int_0);
			}
		}

		// Token: 0x04000149 RID: 329
		protected List<T> list_0 = new List<T>();

		// Token: 0x0400014A RID: 330
		protected IComparer<T> icomparer_0;
	}
}
