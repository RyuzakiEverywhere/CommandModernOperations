using System;
using System.Collections;

namespace Nini.Util
{
	// Token: 0x02000C09 RID: 3081
	public sealed class OrderedListEnumerator : IEnumerator, IDictionaryEnumerator
	{
		// Token: 0x06004C72 RID: 19570 RVA: 0x000303AA File Offset: 0x0002E5AA
		internal OrderedListEnumerator(ArrayList arrayList)
		{
			this.list = arrayList;
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x002F9470 File Offset: 0x002F7670
		object IEnumerator.Current
		{
			get
			{
				if (this.index < 0 || this.index >= this.list.Count)
				{
					throw new InvalidOperationException();
				}
				return this.list[this.index];
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x002F94BC File Offset: 0x002F76BC
		public DictionaryEntry Current
		{
			get
			{
				if (this.index < 0 || this.index >= this.list.Count)
				{
					throw new InvalidOperationException();
				}
				return (DictionaryEntry)this.list[this.index];
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06004C75 RID: 19573 RVA: 0x002F950C File Offset: 0x002F770C
		public DictionaryEntry Entry
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06004C76 RID: 19574 RVA: 0x002F9524 File Offset: 0x002F7724
		public object Key
		{
			get
			{
				return this.Entry.Key;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06004C77 RID: 19575 RVA: 0x002F9544 File Offset: 0x002F7744
		public object Value
		{
			get
			{
				return this.Entry.Value;
			}
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x002F9564 File Offset: 0x002F7764
		public bool MoveNext()
		{
			this.index++;
			return this.index < this.list.Count;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x000303C0 File Offset: 0x0002E5C0
		public void Reset()
		{
			this.index = -1;
		}

		// Token: 0x0400302F RID: 12335
		private int index = -1;

		// Token: 0x04003030 RID: 12336
		private ArrayList list;
	}
}
