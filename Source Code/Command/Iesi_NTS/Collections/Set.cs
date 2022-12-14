using System;
using System.Collections;

namespace Iesi_NTS.Collections
{
	// Token: 0x02000504 RID: 1284
	[Serializable]
	public abstract class Set : IEnumerable, ICollection, ICloneable, ISet
	{
		// Token: 0x060025A5 RID: 9637
		public abstract bool Add(object object_0);

		// Token: 0x060025A6 RID: 9638
		public abstract bool vmethod_0(ICollection icollection_0);

		// Token: 0x060025A7 RID: 9639
		public abstract void Clear();

		// Token: 0x060025A8 RID: 9640
		public abstract bool Contains(object object_0);

		// Token: 0x060025A9 RID: 9641
		public abstract bool imethod_0(object object_0);

		// Token: 0x060025AA RID: 9642 RVA: 0x002BCDE4 File Offset: 0x002BAFE4
		public virtual object Clone()
		{
			Set set = (Set)Activator.CreateInstance(base.GetType());
			set.vmethod_0(this);
			return set;
		}

		// Token: 0x060025AB RID: 9643
		public abstract void CopyTo(Array array, int index);

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060025AC RID: 9644
		public abstract int Count { get; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060025AD RID: 9645
		public abstract bool IsSynchronized { get; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060025AE RID: 9646
		public abstract object SyncRoot { get; }

		// Token: 0x060025AF RID: 9647
		public abstract IEnumerator GetEnumerator();
	}
}
