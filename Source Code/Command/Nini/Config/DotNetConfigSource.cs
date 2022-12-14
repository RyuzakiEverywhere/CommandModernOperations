using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Nini.Config
{
	// Token: 0x02000C1E RID: 3102
	public sealed class DotNetConfigSource : ConfigSourceBase
	{
		// Token: 0x06004D7E RID: 19838 RVA: 0x00030D0D File Offset: 0x0002EF0D
		public DotNetConfigSource(string[] sections)
		{
			this.sections = sections;
			this.Load();
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x002FB948 File Offset: 0x002F9B48
		public DotNetConfigSource()
		{
			this.configDoc = new XmlDocument();
			this.configDoc.LoadXml("<configuration><configSections/></configuration>");
			this.PerformLoad(this.configDoc);
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x00030D37 File Offset: 0x0002EF37
		public DotNetConfigSource(string path)
		{
			this.Load(path);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00030D5B File Offset: 0x0002EF5B
		public DotNetConfigSource(XmlReader reader)
		{
			this.Load(reader);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06004D82 RID: 19842 RVA: 0x002FB998 File Offset: 0x002F9B98
		public string SavePath
		{
			get
			{
				return this.savePath;
			}
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x00030D7F File Offset: 0x0002EF7F
		public void Load(string path)
		{
			this.savePath = path;
			this.configDoc = new XmlDocument();
			this.configDoc.Load(this.savePath);
			this.PerformLoad(this.configDoc);
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x00030DB0 File Offset: 0x0002EFB0
		public void Load(XmlReader reader)
		{
			this.configDoc = new XmlDocument();
			this.configDoc.Load(reader);
			this.PerformLoad(this.configDoc);
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x00030DD5 File Offset: 0x0002EFD5
		public override void Save()
		{
			if (!this.IsSavable())
			{
				throw new ArgumentException("Source cannot be saved in this state");
			}
			this.MergeConfigsIntoDocument();
			this.configDoc.Save(this.savePath);
			base.Save();
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x00030E0A File Offset: 0x0002F00A
		public void Save(string path)
		{
			if (!this.IsSavable())
			{
				throw new ArgumentException("Source cannot be saved in this state");
			}
			this.savePath = path;
			this.Save();
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00030E2F File Offset: 0x0002F02F
		public void Save(TextWriter writer)
		{
			if (!this.IsSavable())
			{
				throw new ArgumentException("Source cannot be saved in this state");
			}
			this.MergeConfigsIntoDocument();
			this.configDoc.Save(writer);
			this.savePath = null;
			base.OnSaved(new EventArgs());
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x00030E6B File Offset: 0x0002F06B
		public void Save(Stream stream)
		{
			if (!this.IsSavable())
			{
				throw new ArgumentException("Source cannot be saved in this state");
			}
			this.MergeConfigsIntoDocument();
			this.configDoc.Save(stream);
			this.savePath = null;
			base.OnSaved(new EventArgs());
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x00030EA7 File Offset: 0x0002F0A7
		public override void Reload()
		{
			if (this.savePath == null)
			{
				throw new ArgumentException("Error reloading: You must have the loaded the source from a file");
			}
			this.configDoc = new XmlDocument();
			this.configDoc.Load(this.savePath);
			this.MergeDocumentIntoConfigs();
			base.Reload();
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x002FB9B0 File Offset: 0x002F9BB0
		public override string ToString()
		{
			this.MergeConfigsIntoDocument();
			StringWriter stringWriter = new StringWriter();
			this.configDoc.Save(stringWriter);
			return stringWriter.ToString();
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x002FB9E0 File Offset: 0x002F9BE0
		public static string GetFullConfigPath()
		{
			return Assembly.GetCallingAssembly().Location + ".config";
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x002FBA04 File Offset: 0x002F9C04
		private void MergeConfigsIntoDocument()
		{
			this.RemoveSections();
			foreach (object obj in base.Configs)
			{
				IConfig config = (IConfig)obj;
				string[] keys = config.GetKeys();
				this.RemoveKeys(config.Name);
				XmlNode xmlNode = this.GetChildElement(config.Name);
				if (xmlNode == null)
				{
					xmlNode = this.SectionNode(config.Name);
				}
				for (int i = 0; i < keys.Length; i++)
				{
					this.SetKey(xmlNode, keys[i], config.Get(keys[i]));
				}
			}
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x002FBABC File Offset: 0x002F9CBC
		private void Load()
		{
			base.Merge(this);
			for (int i = 0; i < this.sections.Length; i++)
			{
				this.LoadCollection(this.sections[i], (NameValueCollection)ConfigurationSettings.GetConfig(this.sections[i]));
			}
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x002FBB08 File Offset: 0x002F9D08
		private void PerformLoad(XmlDocument document)
		{
			base.Configs.Clear();
			base.Merge(this);
			if (document.DocumentElement.Name != "configuration")
			{
				throw new ArgumentException("Did not find configuration node");
			}
			this.LoadSections(document.DocumentElement);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x002FBB58 File Offset: 0x002F9D58
		private void LoadSections(XmlNode rootNode)
		{
			this.LoadOtherSection(rootNode, "appSettings");
			XmlNode childElement = this.GetChildElement(rootNode, "configSections");
			if (childElement != null)
			{
				foreach (object obj in childElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "section")
					{
						ConfigBase config = new ConfigBase(xmlNode.Attributes["name"].Value, this);
						base.Configs.Add(config);
						this.LoadKeys(rootNode, config);
					}
				}
			}
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x002FBC20 File Offset: 0x002F9E20
		private void LoadOtherSection(XmlNode rootNode, string nodeName)
		{
			XmlNode childElement = this.GetChildElement(rootNode, nodeName);
			if (childElement != null)
			{
				ConfigBase config = new ConfigBase(childElement.Name, this);
				base.Configs.Add(config);
				this.LoadKeys(rootNode, config);
			}
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x002FBC60 File Offset: 0x002F9E60
		private void LoadKeys(XmlNode rootNode, ConfigBase config)
		{
			XmlNode childElement = this.GetChildElement(rootNode, config.Name);
			foreach (object obj in childElement.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "add")
				{
					config.Add(xmlNode.Attributes["key"].Value, xmlNode.Attributes["value"].Value);
				}
			}
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x002FBD10 File Offset: 0x002F9F10
		private void RemoveSections()
		{
			XmlNode childElement = this.GetChildElement("configSections");
			if (childElement != null)
			{
				foreach (object obj in childElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "section")
					{
						XmlAttribute xmlAttribute = xmlNode.Attributes["name"];
						if (xmlAttribute == null)
						{
							throw new ArgumentException("Section name attribute not found");
						}
						if (base.Configs[xmlAttribute.Value] == null)
						{
							xmlNode.ParentNode.RemoveChild(xmlNode);
							XmlNode childElement2 = this.GetChildElement(xmlAttribute.Value);
							if (childElement2 != null)
							{
								this.configDoc.DocumentElement.RemoveChild(childElement2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x002FBE10 File Offset: 0x002FA010
		private void RemoveKeys(string sectionName)
		{
			XmlNode childElement = this.GetChildElement(sectionName);
			if (childElement != null)
			{
				foreach (object obj in childElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "add")
					{
						XmlAttribute xmlAttribute = xmlNode.Attributes["key"];
						if (xmlAttribute == null)
						{
							throw new ArgumentException("Key attribute not found in node");
						}
						if (base.Configs[sectionName].Get(xmlAttribute.Value) == null)
						{
							childElement.RemoveChild(xmlNode);
						}
					}
				}
			}
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x002FBEE0 File Offset: 0x002FA0E0
		private void SetKey(XmlNode sectionNode, string key, string value)
		{
			XmlNode key2 = this.GetKey(sectionNode, key);
			if (key2 == null)
			{
				this.CreateKey(sectionNode, key, value);
			}
			else
			{
				key2.Attributes["value"].Value = value;
			}
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x002FBF20 File Offset: 0x002FA120
		private XmlNode GetKey(XmlNode sectionNode, string keyName)
		{
			XmlNode result = null;
			foreach (object obj in sectionNode.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "add" && xmlNode.Attributes["key"].Value == keyName)
				{
					result = xmlNode;
					break;
				}
			}
			return result;
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x002FBFBC File Offset: 0x002FA1BC
		private void CreateKey(XmlNode sectionNode, string key, string value)
		{
			XmlNode xmlNode = this.configDoc.CreateElement("add");
			XmlAttribute xmlAttribute = this.configDoc.CreateAttribute("key");
			XmlAttribute xmlAttribute2 = this.configDoc.CreateAttribute("value");
			xmlAttribute.Value = key;
			xmlAttribute2.Value = value;
			xmlNode.Attributes.Append(xmlAttribute);
			xmlNode.Attributes.Append(xmlAttribute2);
			sectionNode.AppendChild(xmlNode);
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x002FC02C File Offset: 0x002FA22C
		private void LoadCollection(string name, NameValueCollection collection)
		{
			ConfigBase configBase = new ConfigBase(name, this);
			if (collection == null)
			{
				throw new ArgumentException("Section was not found");
			}
			if (collection != null)
			{
				for (int i = 0; i < collection.Count; i++)
				{
					configBase.Add(collection.Keys[i], collection[i]);
				}
				base.Configs.Add(configBase);
			}
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x002FC090 File Offset: 0x002FA290
		private XmlNode SectionNode(string name)
		{
			XmlNode xmlNode = this.configDoc.CreateElement("section");
			XmlAttribute xmlAttribute = this.configDoc.CreateAttribute("name");
			xmlAttribute.Value = name;
			xmlNode.Attributes.Append(xmlAttribute);
			xmlAttribute = this.configDoc.CreateAttribute("type");
			xmlAttribute.Value = "System.Configuration.NameValueSectionHandler";
			xmlNode.Attributes.Append(xmlAttribute);
			XmlNode childElement = this.GetChildElement("configSections");
			childElement.AppendChild(xmlNode);
			XmlNode xmlNode2 = this.configDoc.CreateElement(name);
			this.configDoc.DocumentElement.AppendChild(xmlNode2);
			return xmlNode2;
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00030EE7 File Offset: 0x0002F0E7
		private bool IsSavable()
		{
			return this.savePath != null || this.configDoc != null;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x002FC134 File Offset: 0x002FA334
		private XmlNode GetChildElement(XmlNode parentNode, string name)
		{
			XmlNode result = null;
			foreach (object obj in parentNode.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == name)
				{
					result = xmlNode;
					break;
				}
			}
			return result;
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x002FC1AC File Offset: 0x002FA3AC
		private XmlNode GetChildElement(string name)
		{
			return this.GetChildElement(this.configDoc.DocumentElement, name);
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x002FC1D0 File Offset: 0x002FA3D0
		private void MergeDocumentIntoConfigs()
		{
			this.RemoveConfigs();
			XmlNode childElement = this.GetChildElement("configSections");
			if (childElement != null)
			{
				foreach (object obj in childElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "section")
					{
						string value = xmlNode.Attributes["name"].Value;
						IConfig config = base.Configs[value];
						if (config == null)
						{
							config = new ConfigBase(value, this);
							base.Configs.Add(config);
						}
						this.RemoveConfigKeys(config);
					}
				}
			}
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x002FC2A8 File Offset: 0x002FA4A8
		private void RemoveConfigs()
		{
			for (int i = base.Configs.Count - 1; i > -1; i--)
			{
				IConfig config = base.Configs[i];
				if (this.GetChildElement(config.Name) == null)
				{
					base.Configs.Remove(config);
				}
			}
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x002FC2FC File Offset: 0x002FA4FC
		private void RemoveConfigKeys(IConfig config)
		{
			XmlNode childElement = this.GetChildElement(config.Name);
			string[] keys = config.GetKeys();
			foreach (string text in keys)
			{
				if (this.GetKey(childElement, text) == null)
				{
					config.Remove(text);
				}
			}
			foreach (object obj in childElement.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "add")
				{
					config.Set(xmlNode.Attributes["key"].Value, xmlNode.Attributes["value"].Value);
				}
			}
		}

		// Token: 0x04003087 RID: 12423
		private string[] sections = null;

		// Token: 0x04003088 RID: 12424
		private XmlDocument configDoc = null;

		// Token: 0x04003089 RID: 12425
		private string savePath = null;
	}
}
