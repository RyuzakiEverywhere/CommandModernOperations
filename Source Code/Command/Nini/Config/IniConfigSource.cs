using System;
using System.IO;
using Nini.Ini;

namespace Nini.Config
{
	// Token: 0x02000C22 RID: 3106
	public sealed class IniConfigSource : ConfigSourceBase
	{
		// Token: 0x06004DD1 RID: 19921 RVA: 0x00030F5F File Offset: 0x0002F15F
		public IniConfigSource()
		{
			this.iniDocument = new IniDocument();
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00030F87 File Offset: 0x0002F187
		public IniConfigSource(string filePath)
		{
			this.Load(filePath);
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x00030FAB File Offset: 0x0002F1AB
		public IniConfigSource(TextReader reader)
		{
			this.Load(reader);
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x00030FCF File Offset: 0x0002F1CF
		public IniConfigSource(IniDocument document)
		{
			this.Load(document);
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x00030FF3 File Offset: 0x0002F1F3
		public IniConfigSource(Stream stream)
		{
			this.Load(stream);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06004DD6 RID: 19926 RVA: 0x00031017 File Offset: 0x0002F217
		// (set) Token: 0x06004DD7 RID: 19927 RVA: 0x0003101F File Offset: 0x0002F21F
		public bool CaseSensitive
		{
			get
			{
				return this.caseSensitive;
			}
			set
			{
				this.caseSensitive = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x002FC49C File Offset: 0x002FA69C
		public string SavePath
		{
			get
			{
				return this.savePath;
			}
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x00031028 File Offset: 0x0002F228
		public void Load(string filePath)
		{
			this.Load(new StreamReader(filePath));
			this.savePath = filePath;
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x0003103D File Offset: 0x0002F23D
		public void Load(TextReader reader)
		{
			this.Load(new IniDocument(reader));
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x0003104B File Offset: 0x0002F24B
		public void Load(IniDocument document)
		{
			base.Configs.Clear();
			base.Merge(this);
			this.iniDocument = document;
			this.Load();
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x0003106C File Offset: 0x0002F26C
		public void Load(Stream stream)
		{
			this.Load(new StreamReader(stream));
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x0003107A File Offset: 0x0002F27A
		public override void Save()
		{
			if (!this.IsSavable())
			{
				throw new ArgumentException("Source cannot be saved in this state");
			}
			this.MergeConfigsIntoDocument();
			this.iniDocument.Save(this.savePath);
			base.Save();
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x000310AF File Offset: 0x0002F2AF
		public void Save(string path)
		{
			this.savePath = path;
			this.Save();
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x000310BE File Offset: 0x0002F2BE
		public void Save(TextWriter writer)
		{
			this.MergeConfigsIntoDocument();
			this.iniDocument.Save(writer);
			this.savePath = null;
			base.OnSaved(new EventArgs());
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x000310E4 File Offset: 0x0002F2E4
		public void Save(Stream stream)
		{
			this.MergeConfigsIntoDocument();
			this.iniDocument.Save(stream);
			this.savePath = null;
			base.OnSaved(new EventArgs());
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x0003110A File Offset: 0x0002F30A
		public override void Reload()
		{
			if (this.savePath == null)
			{
				throw new ArgumentException("Error reloading: You must have the loaded the source from a file");
			}
			this.iniDocument = new IniDocument(this.savePath);
			this.MergeDocumentIntoConfigs();
			base.Reload();
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x002FC4B4 File Offset: 0x002FA6B4
		public override string ToString()
		{
			this.MergeConfigsIntoDocument();
			StringWriter stringWriter = new StringWriter();
			this.iniDocument.Save(stringWriter);
			return stringWriter.ToString();
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x002FC4E4 File Offset: 0x002FA6E4
		private void MergeConfigsIntoDocument()
		{
			this.RemoveSections();
			foreach (object obj in base.Configs)
			{
				IConfig config = (IConfig)obj;
				string[] keys = config.GetKeys();
				if (this.iniDocument.Sections[config.Name] == null)
				{
					IniSection section = new IniSection(config.Name);
					this.iniDocument.Sections.Add(section);
				}
				this.RemoveKeys(config.Name);
				for (int i = 0; i < keys.Length; i++)
				{
					this.iniDocument.Sections[config.Name].Set(keys[i], config.Get(keys[i]));
				}
			}
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x002FC5D0 File Offset: 0x002FA7D0
		private void RemoveSections()
		{
			for (int i = 0; i < this.iniDocument.Sections.Count; i++)
			{
				IniSection iniSection = this.iniDocument.Sections[i];
				if (base.Configs[iniSection.Name] == null)
				{
					this.iniDocument.Sections.Remove(iniSection.Name);
				}
			}
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x002FC63C File Offset: 0x002FA83C
		private void RemoveKeys(string sectionName)
		{
			IniSection iniSection = this.iniDocument.Sections[sectionName];
			if (iniSection != null)
			{
				foreach (string key in iniSection.GetKeys())
				{
					if (base.Configs[sectionName].Get(key) == null)
					{
						iniSection.Remove(key);
					}
				}
			}
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x002FC698 File Offset: 0x002FA898
		private void Load()
		{
			for (int i = 0; i < this.iniDocument.Sections.Count; i++)
			{
				IniSection iniSection = this.iniDocument.Sections[i];
				IniConfig iniConfig = new IniConfig(iniSection.Name, this);
				for (int j = 0; j < iniSection.ItemCount; j++)
				{
					IniItem item = iniSection.GetItem(j);
					if (item.Type == IniType.Key)
					{
						iniConfig.Add(item.Name, item.Value);
					}
				}
				base.Configs.Add(iniConfig);
			}
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x002FC734 File Offset: 0x002FA934
		private void MergeDocumentIntoConfigs()
		{
			this.RemoveConfigs();
			for (int i = 0; i < this.iniDocument.Sections.Count; i++)
			{
				IniSection iniSection = this.iniDocument.Sections[i];
				IConfig config = base.Configs[iniSection.Name];
				if (config == null)
				{
					config = new ConfigBase(iniSection.Name, this);
					base.Configs.Add(config);
				}
				this.RemoveConfigKeys(config);
			}
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x002FC7B0 File Offset: 0x002FA9B0
		private void RemoveConfigs()
		{
			for (int i = base.Configs.Count - 1; i > -1; i--)
			{
				IConfig config = base.Configs[i];
				if (this.iniDocument.Sections[config.Name] == null)
				{
					base.Configs.Remove(config);
				}
			}
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x002FC810 File Offset: 0x002FAA10
		private void RemoveConfigKeys(IConfig config)
		{
			IniSection iniSection = this.iniDocument.Sections[config.Name];
			string[] keys = config.GetKeys();
			foreach (string key in keys)
			{
				if (!iniSection.Contains(key))
				{
					config.Remove(key);
				}
			}
			string[] keys2 = iniSection.GetKeys();
			for (int j = 0; j < keys2.Length; j++)
			{
				string key2 = keys2[j];
				config.Set(key2, iniSection.GetItem(j).Value);
			}
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x0003113F File Offset: 0x0002F33F
		private bool IsSavable()
		{
			return this.savePath != null;
		}

		// Token: 0x0400308B RID: 12427
		private IniDocument iniDocument = null;

		// Token: 0x0400308C RID: 12428
		private string savePath = null;

		// Token: 0x0400308D RID: 12429
		private bool caseSensitive = true;
	}
}
