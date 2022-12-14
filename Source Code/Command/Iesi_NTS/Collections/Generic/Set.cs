using System;
using System.Collections;
using System.Collections.Generic;

namespace Iesi_NTS.Collections.Generic
{
	// Token: 0x02000527 RID: 1319
	[Serializable]
	public abstract class Set<T> : IEnumerable<T>, IEnumerable, ICollection<T>, ISet<T>, ICollection, ICloneable, ISet
	{
		// Token: 0x06002686 RID: 9862
		public abstract bool Add(T gparam_0);

		// Token: 0x06002687 RID: 9863
		public abstract bool vmethod_0(ICollection<T> icollection_0);

		// Token: 0x06002688 RID: 9864
		public abstract bool Remove(T item);

		// Token: 0x06002689 RID: 9865
		public abstract void Clear();

		// Token: 0x0600268A RID: 9866
		public abstract bool Contains(T item);

		// Token: 0x0600268B RID: 9867 RVA: 0x0001280F File Offset: 0x00010A0F
		bool ISet.Add(object object_0)
		{
			return this.Add((T)((object)object_0));
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x0001281D File Offset: 0x00010A1D
		bool ISet.Contains(object object_0)
		{
			return this.Contains((T)((object)object_0));
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0001282B File Offset: 0x00010A2B
		bool ISet.imethod_0(object object_0)
		{
			return this.Remove((T)((object)object_0));
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x002BF330 File Offset: 0x002BD530
		public virtual ISet<T> vmethod_1()
		{
			Set<T> set = (Set<T>)Activator.CreateInstance(base.GetType());
			set.vmethod_0(this);
			return set;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x002BF35C File Offset: 0x002BD55C
		object ICloneable.Clone()
		{
			return this.vmethod_1();
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x002BF374 File Offset: 0x002BD574
		void ICollection.CopyTo(Array array, int index)
		{
			this.method_0(array, index);
			T[] array2 = new T[this.Count];
			this.CopyTo(array2, index);
			Array.Copy(array2, 0, array, index, this.Count);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06002691 RID: 9873
		public abstract int Count { get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06002692 RID: 9874
		public abstract bool IsSynchronized { get; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06002693 RID: 9875
		public abstract object SyncRoot { get; }

		// Token: 0x06002694 RID: 9876 RVA: 0x00012839 File Offset: 0x00010A39
		void ICollection<!0>.Add(T item)
		{
			this.Add(item);
		}

		// Token: 0x06002695 RID: 9877
		public abstract void CopyTo(T[] array, int arrayIndex);

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002697 RID: 9879
		public abstract IEnumerator<T> GetEnumerator();

		// Token: 0x06002698 RID: 9880 RVA: 0x002BF3AC File Offset: 0x002BD5AC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x002BF3C4 File Offset: 0x002BD5C4
		private void method_0(Array array_0, int int_0)
		{
			if (array_0 == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array_0.Rank > 1)
			{
				throw new ArgumentException("Argument cannot be multidimensional.", "array");
			}
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", int_0, "Argument cannot be negative.");
			}
			if (int_0 >= array_0.Length)
			{
				throw new ArgumentException("Argument must be less than array length.", "arrayIndex");
			}
			if (this.Count > array_0.Length - int_0)
			{
				throw new ArgumentException("Argument section must be large enough for collection.", "array");
			}
		}
	}
}
