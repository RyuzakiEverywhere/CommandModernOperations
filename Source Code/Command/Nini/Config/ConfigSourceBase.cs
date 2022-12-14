using System;
using System.Collections;
using System.Diagnostics;

namespace Nini.Config
{
	// Token: 0x02000C1D RID: 3101
	public abstract class ConfigSourceBase : IConfigSource
	{
		// Token: 0x06004D6A RID: 19818 RVA: 0x00030C6E File Offset: 0x0002EE6E
		public ConfigSourceBase()
		{
			this.configList = new ConfigCollection(this);
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06004D6B RID: 19819 RVA: 0x002FB5B8 File Offset: 0x002F97B8
		public ConfigCollection Configs
		{
			get
			{
				return this.configList;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x00030CA6 File Offset: 0x0002EEA6
		// (set) Token: 0x06004D6D RID: 19821 RVA: 0x00030CAE File Offset: 0x0002EEAE
		public bool AutoSave
		{
			get
			{
				return this.autoSave;
			}
			set
			{
				this.autoSave = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x002FB5D0 File Offset: 0x002F97D0
		public AliasText Alias
		{
			get
			{
				return this.alias;
			}
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x002FB5E8 File Offset: 0x002F97E8
		public void Merge(IConfigSource source)
		{
			if (!this.sourceList.Contains(source))
			{
				this.sourceList.Add(source);
			}
			foreach (object obj in source.Configs)
			{
				IConfig config = (IConfig)obj;
				this.Configs.Add(config);
			}
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x002FB668 File Offset: 0x002F9868
		public virtual IConfig AddConfig(string name)
		{
			return this.configList.Add(name);
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x002FB684 File Offset: 0x002F9884
		public string GetExpanded(IConfig config, string key)
		{
			return this.Expand(config, key, false);
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00030CB7 File Offset: 0x0002EEB7
		public virtual void Save()
		{
			this.OnSaved(new EventArgs());
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00030CC4 File Offset: 0x0002EEC4
		public virtual void Reload()
		{
			this.OnReloaded(new EventArgs());
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x002FB69C File Offset: 0x002F989C
		public void ExpandKeyValues()
		{
			foreach (object obj in this.configList)
			{
				IConfig config = (IConfig)obj;
				string[] keys = config.GetKeys();
				for (int i = 0; i < keys.Length; i++)
				{
					this.Expand(config, keys[i], true);
				}
			}
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00030CD1 File Offset: 0x0002EED1
		public void ReplaceKeyValues()
		{
			this.ExpandKeyValues();
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06004D76 RID: 19830 RVA: 0x002FB718 File Offset: 0x002F9918
		// (remove) Token: 0x06004D77 RID: 19831 RVA: 0x002FB750 File Offset: 0x002F9950
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler Reloaded;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06004D78 RID: 19832 RVA: 0x002FB788 File Offset: 0x002F9988
		// (remove) Token: 0x06004D79 RID: 19833 RVA: 0x002FB7C0 File Offset: 0x002F99C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event EventHandler Saved;

		// Token: 0x06004D7A RID: 19834 RVA: 0x00030CD9 File Offset: 0x0002EED9
		protected void OnReloaded(EventArgs e)
		{
			if (this.Reloaded != null)
			{
				this.Reloaded(this, e);
			}
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x00030CF3 File Offset: 0x0002EEF3
		protected void OnSaved(EventArgs e)
		{
			if (this.Saved != null)
			{
				this.Saved(this, e);
			}
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x002FB7F8 File Offset: 0x002F99F8
		private string Expand(IConfig config, string key, bool setValue)
		{
			string text = config.Get(key);
			if (text == null)
			{
				throw new ArgumentException(string.Format("[{0}] not found in [{1}]", key, config.Name));
			}
			for (;;)
			{
				int num = text.IndexOf("${", 0);
				if (num == -1)
				{
					break;
				}
				int num2 = text.IndexOf("}", num + 2);
				if (num2 == -1)
				{
					break;
				}
				string text2 = text.Substring(num + 2, num2 - (num + 2));
				if (text2 == key)
				{
					goto IL_95;
				}
				string newValue = this.ExpandValue(config, text2);
				text = text.Replace("${" + text2 + "}", newValue);
			}
			if (setValue)
			{
				config.Set(key, text);
			}
			return text;
			IL_95:
			throw new ArgumentException("Key cannot have a expand value of itself: " + key);
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x002FB8B0 File Offset: 0x002F9AB0
		private string ExpandValue(IConfig config, string search)
		{
			string[] array = search.Split(new char[]
			{
				'|'
			});
			string text;
			if (array.Length > 1)
			{
				IConfig config2 = this.Configs[array[0]];
				if (config2 == null)
				{
					throw new ArgumentException("Expand config not found: " + array[0]);
				}
				text = config2.Get(array[1]);
				if (text == null)
				{
					throw new ArgumentException("Expand key not found: " + array[1]);
				}
			}
			else
			{
				text = config.Get(search);
				if (text == null)
				{
					throw new ArgumentException("Key not found: " + search);
				}
			}
			return text;
		}

		// Token: 0x04003081 RID: 12417
		private ArrayList sourceList = new ArrayList();

		// Token: 0x04003082 RID: 12418
		private ConfigCollection configList = null;

		// Token: 0x04003083 RID: 12419
		private bool autoSave = false;

		// Token: 0x04003084 RID: 12420
		private AliasText alias = new AliasText();
	}
}
