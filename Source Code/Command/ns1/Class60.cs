using System;
using System.Collections.Generic;

namespace ns1
{
	// Token: 0x0200005F RID: 95
	internal sealed class Class60<T> where T : Interface1
	{
		// Token: 0x06000195 RID: 405 RVA: 0x000038DF File Offset: 0x00001ADF
		public Class60()
		{
			this.icomparer_0 = Comparer<T>.Default;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000038FD File Offset: 0x00001AFD
		public Class60(IComparer<T> icomparer_1)
		{
			this.icomparer_0 = icomparer_1;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003917 File Offset: 0x00001B17
		public Class60(IComparer<T> icomparer_1, int int_0)
		{
			this.icomparer_0 = icomparer_1;
			this.list_0.Capacity = int_0;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00058048 File Offset: 0x00056248
		protected void method_0(int int_0, int int_1)
		{
			T value = this.list_0[int_0];
			this.list_0[int_0] = this.list_0[int_1];
			this.list_0[int_1] = value;
			T t = this.list_0[int_0];
			t.imethod_2(int_0);
			t = this.list_0[int_1];
			t.imethod_2(int_1);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000393D File Offset: 0x00001B3D
		protected int vmethod_0(int int_0, int int_1)
		{
			return this.icomparer_0.Compare(this.list_0[int_0], this.list_0[int_1]);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000580C0 File Offset: 0x000562C0
		public int method_1(T gparam_0)
		{
			int num = this.list_0.Count;
			gparam_0.imethod_2(this.list_0.Count);
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

		// Token: 0x0600019B RID: 411 RVA: 0x00058120 File Offset: 0x00056320
		public T method_2()
		{
			T result = this.list_0[0];
			int num = 0;
			this.list_0[0] = this.list_0[this.list_0.Count - 1];
			T t = this.list_0[0];
			t.imethod_2(0);
			this.list_0.RemoveAt(this.list_0.Count - 1);
			result.imethod_2(-1);
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

		// Token: 0x0600019C RID: 412 RVA: 0x00058200 File Offset: 0x00056400
		public void method_3(T gparam_0)
		{
			int count = this.list_0.Count;
			while (gparam_0.imethod_1() - 1 >= 0 && this.vmethod_0(gparam_0.imethod_1() - 1, gparam_0.imethod_1()) > 0)
			{
				this.method_0(gparam_0.imethod_1() - 1, gparam_0.imethod_1());
			}
			while (gparam_0.imethod_1() + 1 < count && this.vmethod_0(gparam_0.imethod_1() + 1, gparam_0.imethod_1()) < 0)
			{
				this.method_0(gparam_0.imethod_1() + 1, gparam_0.imethod_1());
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00003962 File Offset: 0x00001B62
		public void method_4()
		{
			this.list_0.Clear();
		}

		// Token: 0x040000E7 RID: 231
		protected List<T> list_0 = new List<T>();

		// Token: 0x040000E8 RID: 232
		protected IComparer<T> icomparer_0;
	}
}
