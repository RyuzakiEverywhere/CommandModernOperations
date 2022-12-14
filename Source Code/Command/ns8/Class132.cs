using System;
using System.Collections;
using System.Collections.Generic;

namespace ns8
{
	// Token: 0x020000E7 RID: 231
	internal sealed class Class132<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x000065B2 File Offset: 0x000047B2
		public Class132() : this(4)
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000065BB File Offset: 0x000047BB
		public Class132(int int_2)
		{
			this.int_1 = int_2;
			this.gparam_0 = new T[int_2];
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000065D6 File Offset: 0x000047D6
		public Class132(Class132<T> class132_1)
		{
			this.int_1 = class132_1.int_1;
			this.gparam_0 = (T[])class132_1.gparam_0.Clone();
			this.int_0 = class132_1.int_0;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000660C File Offset: 0x0000480C
		public IEnumerator<T> GetEnumerator()
		{
			Class132<T>.Class133 @class = new Class132<T>.Class133(0);
			@class.class132_0 = this;
			return @class;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000661B File Offset: 0x0000481B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x1700002B RID: 43
		public T this[int int_2]
		{
			get
			{
				return this.gparam_0[int_2];
			}
			internal set
			{
				this.gparam_0[int_2] = value;
			}
		}

		// Token: 0x04000400 RID: 1024
		public static readonly Class132<T> class132_0 = new Class132<T>();

		// Token: 0x04000401 RID: 1025
		private T[] gparam_0;

		// Token: 0x04000402 RID: 1026
		private int int_0;

		// Token: 0x04000403 RID: 1027
		private int int_1;
	}
}
