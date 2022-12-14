using System;
using System.IO;
using System.Xml;

namespace Nini.Config
{
	// Token: 0x02000C26 RID: 3110
	public sealed class XmlConfigSource : ConfigSourceBase
	{
		// Token: 0x06004DFE RID: 19966 RVA: 0x0003119C File Offset: 0x0002F39C
		public XmlConfigSource()
		{
			this.configDoc = new XmlDocument();
			this.configDoc.LoadXml("<Nini/>");
			this.PerformLoad(this.configDoc);
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x000311D9 File Offset: 0x0002F3D9
		public XmlConfigSource(string path)
		{
			this.Load(path);
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x000311F6 File Offset: 0x0002F3F6
		public XmlConfigSource(XmlReader reader)
		{
			this.Load(reader);
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06004E01 RID: 19969 RVA: 0x002FCCB4 File Offset: 0x002FAEB4
		public string SavePath
		{
			get
			{
				return this.savePath;
			}
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x00031213 File Offset: 0x0002F413
		public void Load(string path)
		{
			this.savePath = path;
			this.configDoc = new XmlDocument();
			this.configDoc.Load(path);
			this.PerformLoad(this.configDoc);
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x0003123F File Offset: 0x0002F43F
		public void Load(XmlReader reader)
		{
			this.configDoc = new XmlDocument();
			this.configDoc.Load(reader);
			this.PerformLoad(this.configDoc);
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x00031264 File Offset: 0x0002F464
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

		// Token: 0x06004E05 RID: 19973 RVA: 0x00031299 File Offset: 0x0002F499
		public void Save(string path)
		{
			this.savePath = path;
			this.Save();
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x000312A8 File Offset: 0x0002F4A8
		public void Save(TextWriter writer)
		{
			this.MergeConfigsIntoDocument();
			this.configDoc.Save(writer);
			this.savePath = null;
			base.OnSaved(new EventArgs());
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x000312CE File Offset: 0x0002F4CE
		public void Save(Stream stream)
		{
			this.MergeConfigsIntoDocument();
			this.configDoc.Save(stream);
			this.savePath = null;
			base.OnSaved(new EventArgs());
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x000312F4 File Offset: 0x0002F4F4
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

		// Token: 0x06004E09 RID: 19977 RVA: 0x002FCCCC File Offset: 0x002FAECC
		public override string ToString()
		{
			this.MergeConfigsIntoDocument();
			StringWriter stringWriter = new StringWriter();
			this.configDoc.Save(stringWriter);
			return stringWriter.ToString();
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x002FCCFC File Offset: 0x002FAEFC
		private void MergeConfigsIntoDocument()
		{
			this.RemoveSections();
			foreach (object obj in base.Configs)
			{
				IConfig config = (IConfig)obj;
				string[] keys = config.GetKeys();
				XmlNode xmlNode = this.GetSectionByName(config.Name);
				if (xmlNode == null)
				{
					xmlNode = this.SectionNode(config.Name);
					this.configDoc.DocumentElement.AppendChild(xmlNode);
				}
				this.RemoveKeys(config.Name);
				for (int i = 0; i < keys.Length; i++)
				{
					this.SetKey(xmlNode, keys[i], config.Get(keys[i]));
				}
			}
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x002FCDCC File Offset: 0x002FAFCC
		private void RemoveSections()
		{
			foreach (object obj in this.configDoc.DocumentElement.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Section")
				{
					XmlAttribute xmlAttribute = xmlNode.Attributes["Name"];
					if (xmlAttribute == null)
					{
						throw new ArgumentException("Section name attribute not found");
					}
					if (base.Configs[xmlAttribute.Value] == null)
					{
						this.configDoc.DocumentElement.RemoveChild(xmlNode);
					}
				}
			}
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x002FCE98 File Offset: 0x002FB098
		private void RemoveKeys(string sectionName)
		{
			XmlNode sectionByName = this.GetSectionByName(sectionName);
			if (sectionByName != null)
			{
				foreach (object obj in sectionByName.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Key")
					{
						XmlAttribute xmlAttribute = xmlNode.Attributes["Name"];
						if (xmlAttribute == null)
						{
							throw new ArgumentException("Name attribute not found in key");
						}
						if (base.Configs[sectionName].Get(xmlAttribute.Value) == null)
						{
							sectionByName.RemoveChild(xmlNode);
						}
					}
				}
			}
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x002FCF68 File Offset: 0x002FB168
		private void PerformLoad(XmlDocument document)
		{
			base.Configs.Clear();
			base.Merge(this);
			if (document.DocumentElement.Name != "Nini")
			{
				throw new ArgumentException("Did not find Nini XML root node");
			}
			this.LoadSections(document.DocumentElement);
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x002FCFB8 File Offset: 0x002FB1B8
		private void LoadSections(XmlNode rootNode)
		{
			foreach (object obj in rootNode.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Section")
				{
					ConfigBase config = new ConfigBase(xmlNode.Attributes["Name"].Value, this);
					base.Configs.Add(config);
					this.LoadKeys(xmlNode, config);
				}
			}
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x002FD05C File Offset: 0x002FB25C
		private void LoadKeys(XmlNode node, ConfigBase config)
		{
			foreach (object obj in node.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Key")
				{
					config.Add(xmlNode.Attributes["Name"].Value, xmlNode.Attributes["Value"].Value);
				}
			}
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x002FD100 File Offset: 0x002FB300
		private void SetKey(XmlNode sectionNode, string key, string value)
		{
			XmlNode keyByName = this.GetKeyByName(sectionNode, key);
			if (keyByName == null)
			{
				this.CreateKey(sectionNode, key, value);
			}
			else
			{
				keyByName.Attributes["Value"].Value = value;
			}
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x002FD140 File Offset: 0x002FB340
		private void CreateKey(XmlNode sectionNode, string key, string value)
		{
			XmlNode xmlNode = this.configDoc.CreateElement("Key");
			XmlAttribute xmlAttribute = this.configDoc.CreateAttribute("Name");
			XmlAttribute xmlAttribute2 = this.configDoc.CreateAttribute("Value");
			xmlAttribute.Value = key;
			xmlAttribute2.Value = value;
			xmlNode.Attributes.Append(xmlAttribute);
			xmlNode.Attributes.Append(xmlAttribute2);
			sectionNode.AppendChild(xmlNode);
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x002FD1B0 File Offset: 0x002FB3B0
		private XmlNode SectionNode(string name)
		{
			XmlNode xmlNode = this.configDoc.CreateElement("Section");
			XmlAttribute xmlAttribute = this.configDoc.CreateAttribute("Name");
			xmlAttribute.Value = name;
			xmlNode.Attributes.Append(xmlAttribute);
			return xmlNode;
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x002FD1F8 File Offset: 0x002FB3F8
		private XmlNode GetSectionByName(string name)
		{
			XmlNode result = null;
			foreach (object obj in this.configDoc.DocumentElement.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Section" && xmlNode.Attributes["Name"].Value == name)
				{
					result = xmlNode;
					break;
				}
			}
			return result;
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x002FD29C File Offset: 0x002FB49C
		private XmlNode GetKeyByName(XmlNode sectionNode, string name)
		{
			XmlNode result = null;
			foreach (object obj in sectionNode.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Key" && xmlNode.Attributes["Name"].Value == name)
				{
					result = xmlNode;
					break;
				}
			}
			return result;
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x00031334 File Offset: 0x0002F534
		private bool IsSavable()
		{
			return this.savePath != null && this.configDoc != null;
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x002FD338 File Offset: 0x002FB538
		private void MergeDocumentIntoConfigs()
		{
			this.RemoveConfigs();
			foreach (object obj in this.configDoc.DocumentElement.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Section")
				{
					string value = xmlNode.Attributes["Name"].Value;
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

		// Token: 0x06004E17 RID: 19991 RVA: 0x002FD400 File Offset: 0x002FB600
		private void RemoveConfigs()
		{
			for (int i = base.Configs.Count - 1; i > -1; i--)
			{
				IConfig config = base.Configs[i];
				if (this.GetSectionByName(config.Name) == null)
				{
					base.Configs.Remove(config);
				}
			}
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x002FD454 File Offset: 0x002FB654
		private void RemoveConfigKeys(IConfig config)
		{
			XmlNode sectionByName = this.GetSectionByName(config.Name);
			string[] keys = config.GetKeys();
			foreach (string text in keys)
			{
				if (this.GetKeyByName(sectionByName, text) == null)
				{
					config.Remove(text);
				}
			}
			foreach (object obj in sectionByName.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.Name == "Key")
				{
					config.Set(xmlNode.Attributes["Name"].Value, xmlNode.Attributes["Value"].Value);
				}
			}
		}

		// Token: 0x04003095 RID: 12437
		private XmlDocument configDoc = null;

		// Token: 0x04003096 RID: 12438
		private string savePath = null;
	}
}
