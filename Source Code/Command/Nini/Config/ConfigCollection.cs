using System;
using System.Collections;
using System.Diagnostics;

namespace Nini.Config
{
	// Token: 0x02000C1C RID: 3100
	public sealed class ConfigCollection : IEnumerable, IList, ICollection
	{
		// Token: 0x06004D4D RID: 19789 RVA: 0x00030B98 File Offset: 0x0002ED98
		public ConfigCollection(ConfigSourceBase owner)
		{
			this.owner = owner;
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x002FB29C File Offset: 0x002F949C
		public int Count
		{
			get
			{
				return this.configList.Count;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06004D4F RID: 19791 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x002F9380 File Offset: 0x002F7580
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700040D RID: 1037
		public IConfig this[int index]
		{
			get
			{
				return (IConfig)this.configList[index];
			}
		}

		// Token: 0x1700040E RID: 1038
		object IList.this[int index]
		{
			get
			{
				return this.configList[index];
			}
			set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		public IConfig this[string configName]
		{
			get
			{
				IConfig result = null;
				foreach (object obj in this.configList)
				{
					IConfig config = (IConfig)obj;
					if (config.Name == configName)
					{
						result = config;
						break;
					}
				}
				return result;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x002FB360 File Offset: 0x002F9560
		public void Add(IConfig config)
		{
			if (this.configList.Contains(config))
			{
				throw new ArgumentException("IConfig already exists");
			}
			IConfig config2 = this[config.Name];
			if (config2 != null)
			{
				string[] keys = config.GetKeys();
				for (int i = 0; i < keys.Length; i++)
				{
					config2.Set(keys[i], config.Get(keys[i]));
				}
			}
			else
			{
				this.configList.Add(config);
				this.OnConfigAdded(new ConfigEventArgs(config));
			}
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x002FB3E0 File Offset: 0x002F95E0
		int IList.Add(object config)
		{
			IConfig config2 = config as IConfig;
			if (config2 == null)
			{
				throw new Exception("Must be an IConfig");
			}
			this.Add(config2);
			return this.IndexOf(config2);
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x002FB418 File Offset: 0x002F9618
		public IConfig Add(string name)
		{
			if (this[name] != null)
			{
				throw new ArgumentException("An IConfig of that name already exists");
			}
			ConfigBase configBase = new ConfigBase(name, this.owner);
			this.configList.Add(configBase);
			this.OnConfigAdded(new ConfigEventArgs(configBase));
			return configBase;
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00030BB9 File Offset: 0x0002EDB9
		public void Remove(IConfig config)
		{
			this.configList.Remove(config);
			this.OnConfigRemoved(new ConfigEventArgs(config));
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x00030BD3 File Offset: 0x0002EDD3
		public void Remove(object config)
		{
			this.configList.Remove(config);
			this.OnConfigRemoved(new ConfigEventArgs((IConfig)config));
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x002FB468 File Offset: 0x002F9668
		public void RemoveAt(int index)
		{
			IConfig config = (IConfig)this.configList[index];
			this.configList.RemoveAt(index);
			this.OnConfigRemoved(new ConfigEventArgs(config));
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00030BF2 File Offset: 0x0002EDF2
		public void Clear()
		{
			this.configList.Clear();
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x002FB4A0 File Offset: 0x002F96A0
		public IEnumerator GetEnumerator()
		{
			return this.configList.GetEnumerator();
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00030BFF File Offset: 0x0002EDFF
		public void CopyTo(Array array, int index)
		{
			this.configList.CopyTo(array, index);
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00030C0E File Offset: 0x0002EE0E
		public void CopyTo(IConfig[] array, int index)
		{
			((ICollection)this.configList).CopyTo(array, index);
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00030C1D File Offset: 0x0002EE1D
		public bool Contains(object config)
		{
			return this.configList.Contains(config);
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x002FB4BC File Offset: 0x002F96BC
		public int IndexOf(object config)
		{
			return this.configList.IndexOf(config);
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00030C2B File Offset: 0x0002EE2B
		public void Insert(int index, object config)
		{
			this.configList.Insert(index, config);
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06004D64 RID: 19812 RVA: 0x002FB4D8 File Offset: 0x002F96D8
		// (remove) Token: 0x06004D65 RID: 19813 RVA: 0x002FB510 File Offset: 0x002F9710
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ConfigEventHandler ConfigAdded;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06004D66 RID: 19814 RVA: 0x002FB548 File Offset: 0x002F9748
		// (remove) Token: 0x06004D67 RID: 19815 RVA: 0x002FB580 File Offset: 0x002F9780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ConfigEventHandler ConfigRemoved;

		// Token: 0x06004D68 RID: 19816 RVA: 0x00030C3A File Offset: 0x0002EE3A
		protected void OnConfigAdded(ConfigEventArgs e)
		{
			if (this.ConfigAdded != null)
			{
				this.ConfigAdded(this, e);
			}
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00030C54 File Offset: 0x0002EE54
		protected void OnConfigRemoved(ConfigEventArgs e)
		{
			if (this.ConfigRemoved != null)
			{
				this.ConfigRemoved(this, e);
			}
		}

		// Token: 0x0400307D RID: 12413
		private ArrayList configList = new ArrayList();

		// Token: 0x0400307E RID: 12414
		private ConfigSourceBase owner = null;
	}
}
