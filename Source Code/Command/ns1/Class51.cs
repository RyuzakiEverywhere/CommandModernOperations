using System;

namespace ns1
{
	// Token: 0x02000055 RID: 85
	internal sealed class Class51 : IEquatable<Class51>
	{
		// Token: 0x06000170 RID: 368 RVA: 0x0000378E File Offset: 0x0000198E
		public Class51(double x, double y, double z = 0.0)
		{
			this.double_0 = x;
			this.double_1 = y;
			this.double_2 = z;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000578F8 File Offset: 0x00055AF8
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || ((!(obj.GetType() != typeof(Class51)) || !(obj.GetType() != typeof(Class51))) && this.Equals(obj as Class51)));
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0005794C File Offset: 0x00055B4C
		public bool Equals(Class51 other)
		{
			return other != null && (this == other || (other.double_0.Equals(this.double_0) && other.double_1.Equals(this.double_1) && other.double_2.Equals(this.double_2)));
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000037AB File Offset: 0x000019AB
		public override int GetHashCode()
		{
			return this.double_0.GetHashCode() * 397 ^ this.double_1.GetHashCode() ^ this.double_2.GetHashCode();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000037D6 File Offset: 0x000019D6
		public override string ToString()
		{
			return string.Format("{0} {1} {2}", this.double_0, this.double_1, this.double_2);
		}

		// Token: 0x040000CF RID: 207
		public double double_0;

		// Token: 0x040000D0 RID: 208
		public double double_1;

		// Token: 0x040000D1 RID: 209
		public double double_2;
	}
}
