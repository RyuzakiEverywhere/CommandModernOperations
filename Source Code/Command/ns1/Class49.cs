using System;
using System.Collections;
using System.Collections.Generic;

namespace ns1
{
	// Token: 0x02000052 RID: 82
	internal sealed class Class49 : IList<Class48>, ICollection<Class48>, IEnumerable<Class48>, IEnumerable, IList, ICollection
	{
		// Token: 0x06000129 RID: 297 RVA: 0x000034CD File Offset: 0x000016CD
		internal Class49(Class48 class48_1)
		{
			this.class48_0 = class48_1;
			this.list_0 = new List<Class48>();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00057068 File Offset: 0x00055268
		public void Add(Class48 item)
		{
			item.treeGridView_0 = this.class48_0.treeGridView_0;
			bool flag = this.class48_0.vmethod_2();
			item.class49_0 = this;
			this.list_0.Add(item);
			this.class48_0.vmethod_6(item);
			if (!flag && this.class48_0.method_10())
			{
				this.class48_0.treeGridView_0.InvalidateRow(this.class48_0.method_1());
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000570DC File Offset: 0x000552DC
		public Class48 method_0(string string_0)
		{
			Class48 @class = new Class48();
			this.Add(@class);
			@class.Cells[0].Value = string_0;
			return @class;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0005710C File Offset: 0x0005530C
		public Class48 method_1(object[] object_0)
		{
			Class48 @class = new Class48();
			this.Add(@class);
			int num = 0;
			if (object_0.Length > @class.Cells.Count)
			{
				throw new ArgumentOutOfRangeException("values");
			}
			foreach (object value in object_0)
			{
				@class.Cells[num].Value = value;
				num++;
			}
			return @class;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000034E7 File Offset: 0x000016E7
		public void Insert(int index, Class48 item)
		{
			item.treeGridView_0 = this.class48_0.treeGridView_0;
			item.class49_0 = this;
			this.list_0.Insert(index, item);
			this.class48_0.vmethod_5(index, item);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000351C File Offset: 0x0000171C
		public bool Remove(Class48 item)
		{
			this.class48_0.vmethod_7(item);
			item.treeGridView_0 = null;
			return this.list_0.Remove(item);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00057170 File Offset: 0x00055370
		public void RemoveAt(int index)
		{
			Class48 @class = this.list_0[index];
			this.class48_0.vmethod_7(@class);
			@class.treeGridView_0 = null;
			this.list_0.RemoveAt(index);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000353E File Offset: 0x0000173E
		public void Clear()
		{
			this.class48_0.vmethod_8();
			this.list_0.Clear();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003557 File Offset: 0x00001757
		public int IndexOf(Class48 item)
		{
			return this.list_0.IndexOf(item);
		}

		// Token: 0x1700000E RID: 14
		public Class48 this[int index]
		{
			get
			{
				return this.list_0[index];
			}
			set
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000357F File Offset: 0x0000177F
		public bool Contains(Class48 item)
		{
			return this.list_0.Contains(item);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003573 File Offset: 0x00001773
		public void CopyTo(Class48[] array, int arrayIndex)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000358D File Offset: 0x0000178D
		public int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000359A File Offset: 0x0000179A
		void IList.Remove(object value)
		{
			this.Remove(value as Class48);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000571AC File Offset: 0x000553AC
		int IList.Add(object value)
		{
			Class48 @class = value as Class48;
			this.Add(@class);
			return @class.method_2();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000035A9 File Offset: 0x000017A9
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000035B2 File Offset: 0x000017B2
		void IList.Clear()
		{
			this.Clear();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000035BA File Offset: 0x000017BA
		bool IList.IsReadOnly
		{
			get
			{
				return this.IsReadOnly;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00003024 File Offset: 0x00001224
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000035C2 File Offset: 0x000017C2
		int IList.IndexOf(object value)
		{
			return this.IndexOf(value as Class48);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000035D0 File Offset: 0x000017D0
		void IList.Insert(int index, object value)
		{
			this.Insert(index, value as Class48);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000035DF File Offset: 0x000017DF
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000035E7 File Offset: 0x000017E7
		bool IList.Contains(object value)
		{
			return this.Contains(value as Class48);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003573 File Offset: 0x00001773
		void ICollection.CopyTo(Array array, int index)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		// Token: 0x17000014 RID: 20
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000035FE File Offset: 0x000017FE
		public IEnumerator<Class48> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003610 File Offset: 0x00001810
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00003573 File Offset: 0x00001773
		bool ICollection.IsSynchronized
		{
			get
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00003573 File Offset: 0x00001773
		object ICollection.SyncRoot
		{
			get
			{
				throw new Exception("The method or operation is not implemented.");
			}
		}

		// Token: 0x040000BE RID: 190
		internal List<Class48> list_0;

		// Token: 0x040000BF RID: 191
		internal Class48 class48_0;
	}
}
