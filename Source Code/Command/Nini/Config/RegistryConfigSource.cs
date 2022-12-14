using System;
using Microsoft.Win32;

namespace Nini.Config
{
	// Token: 0x02000C24 RID: 3108
	public sealed class RegistryConfigSource : ConfigSourceBase
	{
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06004DEB RID: 19947 RVA: 0x002FC8A0 File Offset: 0x002FAAA0
		// (set) Token: 0x06004DEC RID: 19948 RVA: 0x0003114A File Offset: 0x0002F34A
		public RegistryKey DefaultKey
		{
			get
			{
				return this.defaultKey;
			}
			set
			{
				this.defaultKey = value;
			}
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x002FC8B8 File Offset: 0x002FAAB8
		public override IConfig AddConfig(string name)
		{
			if (this.DefaultKey == null)
			{
				throw new ApplicationException("You must set DefaultKey");
			}
			return this.AddConfig(name, this.DefaultKey);
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x002FC8EC File Offset: 0x002FAAEC
		public IConfig AddConfig(string name, RegistryKey key)
		{
			RegistryConfigSource.RegistryConfig registryConfig = new RegistryConfigSource.RegistryConfig(name, this);
			registryConfig.Key = key;
			registryConfig.ParentKey = true;
			base.Configs.Add(registryConfig);
			return registryConfig;
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x002FC920 File Offset: 0x002FAB20
		public void AddMapping(RegistryKey registryKey, string path)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(path, true);
			if (registryKey2 == null)
			{
				throw new ArgumentException("The specified key does not exist");
			}
			this.LoadKeyValues(registryKey2, this.ShortKeyName(registryKey2));
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x002FC958 File Offset: 0x002FAB58
		public void AddMapping(RegistryKey registryKey, string path, RegistryRecurse recurse)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(path, true);
			if (registryKey2 == null)
			{
				throw new ArgumentException("The specified key does not exist");
			}
			if (recurse == RegistryRecurse.Namespacing)
			{
				this.LoadKeyValues(registryKey2, path);
			}
			else
			{
				this.LoadKeyValues(registryKey2, this.ShortKeyName(registryKey2));
			}
			string[] subKeyNames = registryKey2.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				switch (recurse)
				{
				case RegistryRecurse.Flattened:
					this.AddMapping(registryKey2, subKeyNames[i], recurse);
					break;
				case RegistryRecurse.Namespacing:
					this.AddMapping(registryKey, path + "\\" + subKeyNames[i], recurse);
					break;
				}
			}
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x002FC9F4 File Offset: 0x002FABF4
		public override void Save()
		{
			this.MergeConfigsIntoDocument();
			for (int i = 0; i < base.Configs.Count; i++)
			{
				if (base.Configs[i] is RegistryConfigSource.RegistryConfig)
				{
					RegistryConfigSource.RegistryConfig registryConfig = (RegistryConfigSource.RegistryConfig)base.Configs[i];
					string[] keys = registryConfig.GetKeys();
					for (int j = 0; j < keys.Length; j++)
					{
						registryConfig.Key.SetValue(keys[j], registryConfig.Get(keys[j]));
					}
				}
			}
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00031153 File Offset: 0x0002F353
		public override void Reload()
		{
			this.ReloadKeys();
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x002FCA78 File Offset: 0x002FAC78
		private void LoadKeyValues(RegistryKey key, string keyName)
		{
			RegistryConfigSource.RegistryConfig registryConfig = new RegistryConfigSource.RegistryConfig(keyName, this);
			registryConfig.Key = key;
			string[] valueNames = key.GetValueNames();
			foreach (string text in valueNames)
			{
				registryConfig.Add(text, key.GetValue(text).ToString());
			}
			base.Configs.Add(registryConfig);
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x002FCAD4 File Offset: 0x002FACD4
		private void MergeConfigsIntoDocument()
		{
			foreach (object obj in base.Configs)
			{
				IConfig config = (IConfig)obj;
				if (config is RegistryConfigSource.RegistryConfig)
				{
					RegistryConfigSource.RegistryConfig registryConfig = (RegistryConfigSource.RegistryConfig)config;
					if (registryConfig.ParentKey)
					{
						registryConfig.Key = registryConfig.Key.CreateSubKey(registryConfig.Name);
					}
					this.RemoveKeys(registryConfig);
					string[] keys = config.GetKeys();
					for (int i = 0; i < keys.Length; i++)
					{
						registryConfig.Key.SetValue(keys[i], config.Get(keys[i]));
					}
					registryConfig.Key.Flush();
				}
			}
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x002FCBA8 File Offset: 0x002FADA8
		private void ReloadKeys()
		{
			RegistryKey[] array = new RegistryKey[base.Configs.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = ((RegistryConfigSource.RegistryConfig)base.Configs[i]).Key;
			}
			base.Configs.Clear();
			for (int j = 0; j < array.Length; j++)
			{
				this.LoadKeyValues(array[j], this.ShortKeyName(array[j]));
			}
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x002FCC1C File Offset: 0x002FAE1C
		private void RemoveKeys(RegistryConfigSource.RegistryConfig config)
		{
			foreach (string text in config.Key.GetValueNames())
			{
				if (!config.Contains(text))
				{
					config.Key.DeleteValue(text);
				}
			}
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x002FCC60 File Offset: 0x002FAE60
		private string ShortKeyName(RegistryKey key)
		{
			int num = key.Name.LastIndexOf("\\");
			return (num == -1) ? key.Name : key.Name.Substring(num + 1);
		}

		// Token: 0x04003092 RID: 12434
		private RegistryKey defaultKey = null;

		// Token: 0x02000C25 RID: 3109
		private sealed class RegistryConfig : ConfigBase
		{
			// Token: 0x06004DF9 RID: 19961 RVA: 0x0003116A File Offset: 0x0002F36A
			public RegistryConfig(string name, IConfigSource source) : base(name, source)
			{
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06004DFA RID: 19962 RVA: 0x00031182 File Offset: 0x0002F382
			// (set) Token: 0x06004DFB RID: 19963 RVA: 0x0003118A File Offset: 0x0002F38A
			public bool ParentKey
			{
				get
				{
					return this.parentKey;
				}
				set
				{
					this.parentKey = value;
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06004DFC RID: 19964 RVA: 0x002FCC9C File Offset: 0x002FAE9C
			// (set) Token: 0x06004DFD RID: 19965 RVA: 0x00031193 File Offset: 0x0002F393
			public RegistryKey Key
			{
				get
				{
					return this.key;
				}
				set
				{
					this.key = value;
				}
			}

			// Token: 0x04003093 RID: 12435
			private RegistryKey key = null;

			// Token: 0x04003094 RID: 12436
			private bool parentKey = false;
		}
	}
}
