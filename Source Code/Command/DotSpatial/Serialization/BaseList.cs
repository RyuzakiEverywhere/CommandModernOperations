using System;
using System.Collections;
using System.Collections.Generic;
using ns29;

namespace DotSpatial.Serialization
{
	// Token: 0x02000BF7 RID: 3063
	[Serializable]
	public class BaseList<T> : Class2228<T>, IEnumerable<T>, IEnumerable, IList<T>, ICollection<!0> where T : class
	{
		// Token: 0x06004C0C RID: 19468 RVA: 0x0003011F File Offset: 0x0002E31F
		public int IndexOf(T item)
		{
			return base.method_0().IndexOf(item);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x0003012D File Offset: 0x0002E32D
		public virtual void Insert(int index, T item)
		{
			this.method_4(index, item);
		}

		// Token: 0x170003D0 RID: 976
		public T this[int index]
		{
			get
			{
				return base.method_0()[index];
			}
			set
			{
				base.method_3(base.method_0()[index]);
				base.method_2(value);
				base.method_0()[index] = value;
				this.vmethod_5(value);
			}
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x0000378C File Offset: 0x0000198C
		protected virtual void vmethod_7(int int_0, T gparam_0)
		{
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x00030174 File Offset: 0x0002E374
		private void method_4(int int_0, T gparam_0)
		{
			if (base.IsReadOnly)
			{
				throw new Exception24();
			}
			base.method_2(gparam_0);
			base.method_0().Insert(int_0, gparam_0);
			this.vmethod_7(int_0, gparam_0);
			this.vmethod_5(gparam_0);
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x002F510C File Offset: 0x002F330C
		public void RemoveAt(int index)
		{
			T gparam_ = base.method_0()[index];
			base.method_0().RemoveAt(index);
			this.vmethod_6(gparam_);
		}
	}
}
