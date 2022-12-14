using System;
using System.Collections;
using Nini.Util;

namespace Nini.Ini
{
	// Token: 0x02000C11 RID: 3089
	public sealed class IniSection
	{
		// Token: 0x06004CD0 RID: 19664 RVA: 0x000307B3 File Offset: 0x0002E9B3
		public IniSection(string name, string comment)
		{
			this.name = name;
			this.comment = comment;
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x000307ED File Offset: 0x0002E9ED
		public IniSection(string name) : this(name, null)
		{
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x002FA35C File Offset: 0x002F855C
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06004CD3 RID: 19667 RVA: 0x002FA374 File Offset: 0x002F8574
		public string Comment
		{
			get
			{
				return this.comment;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x002FA38C File Offset: 0x002F858C
		public int ItemCount
		{
			get
			{
				return this.configList.Count;
			}
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x002FA3A8 File Offset: 0x002F85A8
		public string GetValue(string key)
		{
			string result = null;
			if (this.Contains(key))
			{
				IniItem iniItem = (IniItem)this.configList[key];
				result = iniItem.Value;
			}
			return result;
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x002FA3DC File Offset: 0x002F85DC
		public IniItem GetItem(int index)
		{
			return (IniItem)this.configList[index];
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x002FA3FC File Offset: 0x002F85FC
		public string[] GetKeys()
		{
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < this.configList.Count; i++)
			{
				IniItem iniItem = (IniItem)this.configList[i];
				if (iniItem.Type == IniType.Key)
				{
					arrayList.Add(iniItem.Name);
				}
			}
			string[] array = new string[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x000307F7 File Offset: 0x0002E9F7
		public bool Contains(string key)
		{
			return this.configList[key] != null;
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x002FA46C File Offset: 0x002F866C
		public void Set(string key, string value, string comment)
		{
			if (this.Contains(key))
			{
				IniItem iniItem = (IniItem)this.configList[key];
				iniItem.Value = value;
				iniItem.Comment = comment;
			}
			else
			{
				IniItem iniItem = new IniItem(key, value, IniType.Key, comment);
				this.configList.Add(key, iniItem);
			}
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00030808 File Offset: 0x0002EA08
		public void Set(string key, string value)
		{
			this.Set(key, value, null);
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x002FA4C0 File Offset: 0x002F86C0
		public void Set(string comment)
		{
			string key = "#comment" + this.commentCount;
			IniItem value = new IniItem(key, null, IniType.Empty, comment);
			this.configList.Add(key, value);
			this.commentCount++;
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00030813 File Offset: 0x0002EA13
		public void Set()
		{
			this.Set(null);
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x0003081C File Offset: 0x0002EA1C
		public void Remove(string key)
		{
			if (this.Contains(key))
			{
				this.configList.Remove(key);
			}
		}

		// Token: 0x0400305B RID: 12379
		private OrderedList configList = new OrderedList();

		// Token: 0x0400305C RID: 12380
		private string name = "";

		// Token: 0x0400305D RID: 12381
		private string comment = null;

		// Token: 0x0400305E RID: 12382
		private int commentCount = 0;
	}
}
