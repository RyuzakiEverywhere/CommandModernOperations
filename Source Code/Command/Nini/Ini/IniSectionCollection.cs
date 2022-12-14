using System;
using System.Collections;
using Nini.Util;

namespace Nini.Ini
{
	// Token: 0x02000C12 RID: 3090
	public sealed class IniSectionCollection : IEnumerable, ICollection
	{
		// Token: 0x170003F9 RID: 1017
		public IniSection this[int index]
		{
			get
			{
				return (IniSection)this.list[index];
			}
		}

		// Token: 0x170003FA RID: 1018
		public IniSection this[string configName]
		{
			get
			{
				return (IniSection)this.list[configName];
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x002FA548 File Offset: 0x002F8748
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x002FA564 File Offset: 0x002F8764
		public object SyncRoot
		{
			get
			{
				return this.list.SyncRoot;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x00030833 File Offset: 0x0002EA33
		public bool IsSynchronized
		{
			get
			{
				return this.list.IsSynchronized;
			}
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x00030840 File Offset: 0x0002EA40
		public void Add(IniSection section)
		{
			if (this.list.Contains(section))
			{
				throw new ArgumentException("IniSection already exists");
			}
			this.list.Add(section.Name, section);
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x0003086D File Offset: 0x0002EA6D
		public void Remove(string config)
		{
			this.list.Remove(config);
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x0003087B File Offset: 0x0002EA7B
		public void CopyTo(Array array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x0003088A File Offset: 0x0002EA8A
		public void CopyTo(IniSection[] array, int index)
		{
			((ICollection)this.list).CopyTo(array, index);
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x002FA580 File Offset: 0x002F8780
		public IEnumerator GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x0400305F RID: 12383
		private OrderedList list = new OrderedList();
	}
}
