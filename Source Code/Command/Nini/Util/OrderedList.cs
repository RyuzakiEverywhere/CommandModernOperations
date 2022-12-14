using System;
using System.Collections;

namespace Nini.Util
{
	// Token: 0x02000C08 RID: 3080
	public sealed class OrderedList : IEnumerable, ICollection, IDictionary
	{
		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x002F91BC File Offset: 0x002F73BC
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06004C5B RID: 19547 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06004C5D RID: 19549 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003D7 RID: 983
		public object this[int index]
		{
			get
			{
				return ((DictionaryEntry)this.list[index]).Value;
			}
			set
			{
				if (index < 0 || index >= this.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				object key = ((DictionaryEntry)this.list[index]).Key;
				this.list[index] = new DictionaryEntry(key, value);
				this.table[key] = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		public object this[object key]
		{
			get
			{
				return this.table[key];
			}
			set
			{
				if (this.table.Contains(key))
				{
					this.table[key] = value;
					this.table[this.IndexOf(key)] = new DictionaryEntry(key, value);
				}
				else
				{
					this.Add(key, value);
				}
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x002F92E0 File Offset: 0x002F74E0
		public ICollection Keys
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < this.list.Count; i++)
				{
					arrayList.Add(((DictionaryEntry)this.list[i]).Key);
				}
				return arrayList;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x002F9330 File Offset: 0x002F7530
		public ICollection Values
		{
			get
			{
				ArrayList arrayList = new ArrayList();
				for (int i = 0; i < this.list.Count; i++)
				{
					arrayList.Add(((DictionaryEntry)this.list[i]).Value);
				}
				return arrayList;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x002F9380 File Offset: 0x002F7580
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x000302D3 File Offset: 0x0002E4D3
		public void Add(object key, object value)
		{
			this.table.Add(key, value);
			this.list.Add(new DictionaryEntry(key, value));
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x000302FA File Offset: 0x0002E4FA
		public void Clear()
		{
			this.table.Clear();
			this.list.Clear();
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00030312 File Offset: 0x0002E512
		public bool Contains(object key)
		{
			return this.table.Contains(key);
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00030320 File Offset: 0x0002E520
		public void CopyTo(Array array, int index)
		{
			this.table.CopyTo(array, index);
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00030320 File Offset: 0x0002E520
		public void CopyTo(DictionaryEntry[] array, int index)
		{
			this.table.CopyTo(array, index);
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x0003032F File Offset: 0x0002E52F
		public void Insert(int index, object key, object value)
		{
			if (index > this.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this.table.Add(key, value);
			this.list.Insert(index, new DictionaryEntry(key, value));
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x0003036C File Offset: 0x0002E56C
		public void Remove(object key)
		{
			this.table.Remove(key);
			this.list.RemoveAt(this.IndexOf(key));
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x002F9390 File Offset: 0x002F7590
		public void RemoveAt(int index)
		{
			if (index >= this.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this.table.Remove(((DictionaryEntry)this.list[index]).Key);
			this.list.RemoveAt(index);
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x002F93E8 File Offset: 0x002F75E8
		public IEnumerator GetEnumerator()
		{
			return new OrderedListEnumerator(this.list);
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x002F9404 File Offset: 0x002F7604
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new OrderedListEnumerator(this.list);
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x002F93E8 File Offset: 0x002F75E8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new OrderedListEnumerator(this.list);
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x002F9420 File Offset: 0x002F7620
		private int IndexOf(object key)
		{
			for (int i = 0; i < this.list.Count; i++)
			{
				if (((DictionaryEntry)this.list[i]).Key.Equals(key))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0400302D RID: 12333
		private Hashtable table = new Hashtable();

		// Token: 0x0400302E RID: 12334
		private ArrayList list = new ArrayList();
	}
}
