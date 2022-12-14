using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Command_Core
{
	// Token: 0x0200026A RID: 618
	[Serializable]
	public sealed class GroupsCollection : KeyedCollection<string, Group>
	{
		// Token: 0x060012D3 RID: 4819 RVA: 0x0000AB46 File Offset: 0x00008D46
		protected override string GetKeyForItem(Group item)
		{
			return item.string_0;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0016FF1C File Offset: 0x0016E11C
		protected override void InsertItem(int index, Group item)
		{
			base.InsertItem(index, item);
			GroupsCollection.CollectionChangedEventHandler collectionChangedEvent = GroupsCollection.CollectionChangedEvent;
			if (collectionChangedEvent != null)
			{
				collectionChangedEvent();
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0016FF40 File Offset: 0x0016E140
		protected override void SetItem(int index, Group item)
		{
			base.SetItem(index, item);
			GroupsCollection.CollectionChangedEventHandler collectionChangedEvent = GroupsCollection.CollectionChangedEvent;
			if (collectionChangedEvent != null)
			{
				collectionChangedEvent();
			}
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0016FF64 File Offset: 0x0016E164
		protected override void RemoveItem(int index)
		{
			base.RemoveItem(index);
			GroupsCollection.CollectionChangedEventHandler collectionChangedEvent = GroupsCollection.CollectionChangedEvent;
			if (collectionChangedEvent != null)
			{
				collectionChangedEvent();
			}
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0016FF88 File Offset: 0x0016E188
		protected override void ClearItems()
		{
			base.ClearItems();
			GroupsCollection.CollectionChangedEventHandler collectionChangedEvent = GroupsCollection.CollectionChangedEvent;
			if (collectionChangedEvent != null)
			{
				collectionChangedEvent();
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0016FFAC File Offset: 0x0016E1AC
		public Group method_0(string string_0)
		{
			GroupsCollection.Class282 @class = new GroupsCollection.Class282();
			@class.string_0 = string_0;
			return Enumerable.ElementAtOrDefault<Group>(Enumerable.Where<Group>(Enumerable.Select<Group, Group>(this, (GroupsCollection._Closure$__.$I11-0 == null) ? (GroupsCollection._Closure$__.$I11-0 = new Func<Group, Group>(GroupsCollection._Closure$__.$I.method_0)) : GroupsCollection._Closure$__.$I11-0), new Func<Group, bool>(@class.method_0)), 0);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00170008 File Offset: 0x0016E208
		public bool method_1(string string_0)
		{
			GroupsCollection.Class283 @class = new GroupsCollection.Class283();
			@class.string_0 = string_0;
			return Enumerable.Count<Group>(Enumerable.Where<Group>(Enumerable.Select<Group, Group>(this, (GroupsCollection._Closure$__.$I12-0 == null) ? (GroupsCollection._Closure$__.$I12-0 = new Func<Group, Group>(GroupsCollection._Closure$__.$I.method_1)) : GroupsCollection._Closure$__.$I12-0), new Func<Group, bool>(@class.method_0))) > 0;
		}

		// Token: 0x04000DC3 RID: 3523
		[CompilerGenerated]
		private static GroupsCollection.CollectionChangedEventHandler CollectionChangedEvent;

		// Token: 0x0200026B RID: 619
		// (Invoke) Token: 0x060012DD RID: 4829
		public delegate void CollectionChangedEventHandler();

		// Token: 0x0200026C RID: 620
		[CompilerGenerated]
		internal sealed class Class282
		{
			// Token: 0x060012DF RID: 4831 RVA: 0x0000AB4E File Offset: 0x00008D4E
			internal bool method_0(Group group_0)
			{
				return Operators.CompareString(group_0.Name, this.string_0, false) == 0;
			}

			// Token: 0x04000DC4 RID: 3524
			public string string_0;
		}

		// Token: 0x0200026E RID: 622
		[CompilerGenerated]
		internal sealed class Class283
		{
			// Token: 0x060012E5 RID: 4837 RVA: 0x0000AB71 File Offset: 0x00008D71
			internal bool method_0(Group group_0)
			{
				return Operators.CompareString(group_0.Name, this.string_0, false) == 0;
			}

			// Token: 0x04000DC8 RID: 3528
			public string string_0;
		}
	}
}
