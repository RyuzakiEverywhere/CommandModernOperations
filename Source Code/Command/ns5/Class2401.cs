using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace ns5
{
	// Token: 0x02000D4B RID: 3403
	internal sealed class Class2401<T> : IEnumerable<T>, IEnumerable, IList<T>, ICollection<!0>, IList, ICollection
	{
		// Token: 0x060058FA RID: 22778 RVA: 0x000393B4 File Offset: 0x000375B4
		public Class2401(IList ilist_2)
		{
			Class2409.smethod_4(ilist_2, "list");
			if (ilist_2 is IList<T>)
			{
				this.ilist_1 = (IList<T>)ilist_2;
				return;
			}
			this.ilist_0 = ilist_2;
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x000393E3 File Offset: 0x000375E3
		public Class2401(IList<T> ilist_2)
		{
			Class2409.smethod_4(ilist_2, "list");
			this.ilist_1 = ilist_2;
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x000393FD File Offset: 0x000375FD
		public int IndexOf(T item)
		{
			if (this.ilist_1 != null)
			{
				return this.ilist_1.IndexOf(item);
			}
			return this.ilist_0.IndexOf(item);
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x00039425 File Offset: 0x00037625
		public void Insert(int index, T item)
		{
			if (this.ilist_1 != null)
			{
				this.ilist_1.Insert(index, item);
				return;
			}
			this.ilist_0.Insert(index, item);
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x0003944F File Offset: 0x0003764F
		public void RemoveAt(int index)
		{
			if (this.ilist_1 != null)
			{
				this.ilist_1.RemoveAt(index);
				return;
			}
			this.ilist_0.RemoveAt(index);
		}

		// Token: 0x17000502 RID: 1282
		public T this[int index]
		{
			get
			{
				if (this.ilist_1 != null)
				{
					return this.ilist_1[index];
				}
				return (T)((object)this.ilist_0[index]);
			}
			set
			{
				if (this.ilist_1 != null)
				{
					this.ilist_1[index] = value;
					return;
				}
				this.ilist_0[index] = value;
			}
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x000394C4 File Offset: 0x000376C4
		public void Add(T item)
		{
			if (this.ilist_1 != null)
			{
				this.ilist_1.Add(item);
				return;
			}
			this.ilist_0.Add(item);
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x000394ED File Offset: 0x000376ED
		public void Clear()
		{
			if (this.ilist_1 != null)
			{
				this.ilist_1.Clear();
				return;
			}
			this.ilist_0.Clear();
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x0003950E File Offset: 0x0003770E
		public bool Contains(T item)
		{
			if (this.ilist_1 != null)
			{
				return this.ilist_1.Contains(item);
			}
			return this.ilist_0.Contains(item);
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x00039536 File Offset: 0x00037736
		public void CopyTo(T[] array, int arrayIndex)
		{
			if (this.ilist_1 != null)
			{
				this.ilist_1.CopyTo(array, arrayIndex);
				return;
			}
			this.ilist_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06005905 RID: 22789 RVA: 0x0003955B File Offset: 0x0003775B
		public int Count
		{
			get
			{
				if (this.ilist_1 != null)
				{
					return this.ilist_1.Count;
				}
				return this.ilist_0.Count;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06005906 RID: 22790 RVA: 0x0003957C File Offset: 0x0003777C
		public bool IsReadOnly
		{
			get
			{
				if (this.ilist_1 != null)
				{
					return this.ilist_1.IsReadOnly;
				}
				return this.ilist_0.IsReadOnly;
			}
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00314C24 File Offset: 0x00312E24
		public bool Remove(T item)
		{
			if (this.ilist_1 != null)
			{
				return this.ilist_1.Remove(item);
			}
			bool result;
			if (result = this.ilist_0.Contains(item))
			{
				this.ilist_0.Remove(item);
			}
			return result;
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x0003959D File Offset: 0x0003779D
		public IEnumerator<T> GetEnumerator()
		{
			if (this.ilist_1 != null)
			{
				return this.ilist_1.GetEnumerator();
			}
			return Enumerable.Cast<T>(this.ilist_0).GetEnumerator();
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x000395C3 File Offset: 0x000377C3
		IEnumerator IEnumerable.GetEnumerator()
		{
			if (this.ilist_1 != null)
			{
				return this.ilist_1.GetEnumerator();
			}
			return this.ilist_0.GetEnumerator();
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x000395E4 File Offset: 0x000377E4
		int IList.Add(object value)
		{
			Class2401<T>.smethod_0(value);
			this.Add((T)((object)value));
			return this.Count - 1;
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00039600 File Offset: 0x00037800
		bool IList.Contains(object value)
		{
			return Class2401<T>.smethod_1(value) && this.Contains((T)((object)value));
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00039618 File Offset: 0x00037818
		int IList.IndexOf(object value)
		{
			if (Class2401<T>.smethod_1(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00039630 File Offset: 0x00037830
		void IList.Insert(int index, object value)
		{
			Class2401<T>.smethod_0(value);
			this.Insert(index, (T)((object)value));
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600590E RID: 22798 RVA: 0x00003024 File Offset: 0x00001224
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x00039645 File Offset: 0x00037845
		void IList.Remove(object value)
		{
			if (Class2401<T>.smethod_1(value))
			{
				this.Remove((T)((object)value));
			}
		}

		// Token: 0x17000506 RID: 1286
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				Class2401<T>.smethod_0(value);
				this[index] = (T)((object)value);
			}
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x0003967F File Offset: 0x0003787F
		void ICollection.CopyTo(Array array, int index)
		{
			this.CopyTo((T[])array, index);
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x00003024 File Offset: 0x00001224
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06005914 RID: 22804 RVA: 0x0003968E File Offset: 0x0003788E
		object ICollection.SyncRoot
		{
			get
			{
				if (this.object_0 == null)
				{
					Interlocked.CompareExchange(ref this.object_0, new object(), null);
				}
				return this.object_0;
			}
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00314C70 File Offset: 0x00312E70
		private static void smethod_0(object object_1)
		{
			if (!Class2401<T>.smethod_1(object_1))
			{
				throw new ArgumentException(Class2407.smethod_0("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.", CultureInfo.InvariantCulture, new object[]
				{
					object_1,
					typeof(T)
				}), "value");
			}
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x00038D79 File Offset: 0x00036F79
		private static bool smethod_1(object object_1)
		{
			return object_1 is T || (object_1 == null && (!typeof(T).IsValueType || Class2404.smethod_8(typeof(T))));
		}

		// Token: 0x04003406 RID: 13318
		private readonly IList ilist_0;

		// Token: 0x04003407 RID: 13319
		private readonly IList<T> ilist_1;

		// Token: 0x04003408 RID: 13320
		private object object_0;
	}
}
