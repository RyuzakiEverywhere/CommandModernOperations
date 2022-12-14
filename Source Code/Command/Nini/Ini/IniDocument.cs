using System;
using System.Collections;
using System.IO;

namespace Nini.Ini
{
	// Token: 0x02000C0B RID: 3083
	public sealed class IniDocument
	{
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x002F95A0 File Offset: 0x002F77A0
		// (set) Token: 0x06004C7B RID: 19579 RVA: 0x000303C9 File Offset: 0x0002E5C9
		public IniFileType FileType
		{
			get
			{
				return this.fileType;
			}
			set
			{
				this.fileType = value;
			}
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x000303D2 File Offset: 0x0002E5D2
		public IniDocument(string filePath)
		{
			this.fileType = IniFileType.Standard;
			this.Load(filePath);
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x00030405 File Offset: 0x0002E605
		public IniDocument(string filePath, IniFileType type)
		{
			this.fileType = type;
			this.Load(filePath);
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00030438 File Offset: 0x0002E638
		public IniDocument(TextReader reader)
		{
			this.fileType = IniFileType.Standard;
			this.Load(reader);
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x0003046B File Offset: 0x0002E66B
		public IniDocument(TextReader reader, IniFileType type)
		{
			this.fileType = type;
			this.Load(reader);
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x0003049E File Offset: 0x0002E69E
		public IniDocument(Stream stream)
		{
			this.fileType = IniFileType.Standard;
			this.Load(stream);
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x000304D1 File Offset: 0x0002E6D1
		public IniDocument(Stream stream, IniFileType type)
		{
			this.fileType = type;
			this.Load(stream);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x00030504 File Offset: 0x0002E704
		public IniDocument(IniReader reader)
		{
			this.fileType = IniFileType.Standard;
			this.Load(reader);
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x00030537 File Offset: 0x0002E737
		public IniDocument()
		{
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x0003055C File Offset: 0x0002E75C
		public void Load(string filePath)
		{
			this.Load(new StreamReader(filePath));
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x0003056A File Offset: 0x0002E76A
		public void Load(TextReader reader)
		{
			this.Load(this.GetIniReader(reader, this.fileType));
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x0003057F File Offset: 0x0002E77F
		public void Load(Stream stream)
		{
			this.Load(new StreamReader(stream));
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x0003058D File Offset: 0x0002E78D
		public void Load(IniReader reader)
		{
			this.LoadReader(reader);
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06004C88 RID: 19592 RVA: 0x002F95B8 File Offset: 0x002F77B8
		public IniSectionCollection Sections
		{
			get
			{
				return this.sections;
			}
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x002F95D0 File Offset: 0x002F77D0
		public void Save(TextWriter textWriter)
		{
			IniWriter iniWriter = this.GetIniWriter(textWriter, this.fileType);
			foreach (object obj in this.initialComment)
			{
				string comment = (string)obj;
				iniWriter.WriteEmpty(comment);
			}
			for (int i = 0; i < this.sections.Count; i++)
			{
				IniSection iniSection = this.sections[i];
				iniWriter.WriteSection(iniSection.Name, iniSection.Comment);
				for (int j = 0; j < iniSection.ItemCount; j++)
				{
					IniItem item = iniSection.GetItem(j);
					IniType type = item.Type;
					IniType iniType = type;
					if (iniType != IniType.Key)
					{
						if (iniType == IniType.Empty)
						{
							iniWriter.WriteEmpty(item.Comment);
						}
					}
					else
					{
						iniWriter.WriteKey(item.Name, item.Value, item.Comment);
					}
				}
			}
			iniWriter.Close();
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x002F96E8 File Offset: 0x002F78E8
		public void Save(string filePath)
		{
			StreamWriter streamWriter = new StreamWriter(filePath);
			this.Save(streamWriter);
			streamWriter.Close();
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x00030596 File Offset: 0x0002E796
		public void Save(Stream stream)
		{
			this.Save(new StreamWriter(stream));
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x002F970C File Offset: 0x002F790C
		private void LoadReader(IniReader reader)
		{
			reader.IgnoreComments = false;
			bool flag = false;
			IniSection iniSection = null;
			try
			{
				while (reader.Read())
				{
					switch (reader.Type)
					{
					case IniType.Section:
						flag = true;
						if (this.sections[reader.Name] != null)
						{
							this.sections.Remove(reader.Name);
						}
						iniSection = new IniSection(reader.Name, reader.Comment);
						this.sections.Add(iniSection);
						break;
					case IniType.Key:
						if (iniSection.GetValue(reader.Name) == null)
						{
							iniSection.Set(reader.Name, reader.Value, reader.Comment);
						}
						break;
					case IniType.Empty:
						if (!flag)
						{
							this.initialComment.Add(reader.Comment);
						}
						else
						{
							iniSection.Set(reader.Comment);
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				reader.Close();
			}
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x002F981C File Offset: 0x002F7A1C
		private IniReader GetIniReader(TextReader reader, IniFileType type)
		{
			IniReader iniReader = new IniReader(reader);
			switch (type)
			{
			case IniFileType.PythonStyle:
				iniReader.AcceptCommentAfterKey = false;
				iniReader.SetCommentDelimiters(new char[]
				{
					';',
					'#'
				});
				iniReader.SetAssignDelimiters(new char[]
				{
					':'
				});
				break;
			case IniFileType.SambaStyle:
				iniReader.AcceptCommentAfterKey = false;
				iniReader.SetCommentDelimiters(new char[]
				{
					';',
					'#'
				});
				iniReader.LineContinuation = true;
				break;
			case IniFileType.MysqlStyle:
				iniReader.AcceptCommentAfterKey = false;
				iniReader.AcceptNoAssignmentOperator = true;
				iniReader.SetCommentDelimiters(new char[]
				{
					'#'
				});
				iniReader.SetAssignDelimiters(new char[]
				{
					':',
					'='
				});
				break;
			case IniFileType.WindowsStyle:
				iniReader.ConsumeAllKeyText = true;
				break;
			}
			return iniReader;
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x002F98EC File Offset: 0x002F7AEC
		private IniWriter GetIniWriter(TextWriter reader, IniFileType type)
		{
			IniWriter iniWriter = new IniWriter(reader);
			switch (type)
			{
			case IniFileType.PythonStyle:
				iniWriter.AssignDelimiter = ':';
				iniWriter.CommentDelimiter = '#';
				break;
			case IniFileType.SambaStyle:
			case IniFileType.MysqlStyle:
				iniWriter.AssignDelimiter = '=';
				iniWriter.CommentDelimiter = '#';
				break;
			}
			return iniWriter;
		}

		// Token: 0x04003037 RID: 12343
		private IniSectionCollection sections = new IniSectionCollection();

		// Token: 0x04003038 RID: 12344
		private ArrayList initialComment = new ArrayList();

		// Token: 0x04003039 RID: 12345
		private IniFileType fileType = IniFileType.Standard;
	}
}
