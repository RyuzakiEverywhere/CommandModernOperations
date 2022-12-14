using System;
using System.IO;
using System.Text;

namespace Nini.Ini
{
	// Token: 0x02000C14 RID: 3092
	public sealed class IniWriter : IDisposable
	{
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x002FA59C File Offset: 0x002F879C
		// (set) Token: 0x06004CEA RID: 19690 RVA: 0x002FA5B4 File Offset: 0x002F87B4
		public int Indentation
		{
			get
			{
				return this.indentation;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Negative values are illegal");
				}
				this.indentation = value;
				this.indentationBuffer.Remove(0, this.indentationBuffer.Length);
				for (int i = 0; i < value; i++)
				{
					this.indentationBuffer.Append(' ');
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x000308AC File Offset: 0x0002EAAC
		// (set) Token: 0x06004CEC RID: 19692 RVA: 0x000308B4 File Offset: 0x0002EAB4
		public bool UseValueQuotes
		{
			get
			{
				return this.useValueQuotes;
			}
			set
			{
				this.useValueQuotes = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x002FA610 File Offset: 0x002F8810
		public IniWriteState WriteState
		{
			get
			{
				return this.writeState;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x002FA628 File Offset: 0x002F8828
		// (set) Token: 0x06004CEF RID: 19695 RVA: 0x000308BD File Offset: 0x0002EABD
		public char CommentDelimiter
		{
			get
			{
				return this.commentDelimiter;
			}
			set
			{
				this.commentDelimiter = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x002FA640 File Offset: 0x002F8840
		// (set) Token: 0x06004CF1 RID: 19697 RVA: 0x000308C6 File Offset: 0x0002EAC6
		public char AssignDelimiter
		{
			get
			{
				return this.assignDelimiter;
			}
			set
			{
				this.assignDelimiter = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x002FA658 File Offset: 0x002F8858
		public Stream BaseStream
		{
			get
			{
				return this.baseStream;
			}
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x000308CF File Offset: 0x0002EACF
		public IniWriter(string filePath) : this(new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
		{
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x002FA670 File Offset: 0x002F8870
		public IniWriter(TextWriter writer)
		{
			this.textWriter = writer;
			StreamWriter streamWriter = writer as StreamWriter;
			if (streamWriter != null)
			{
				this.baseStream = streamWriter.BaseStream;
			}
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x000308E0 File Offset: 0x0002EAE0
		public IniWriter(Stream stream) : this(new StreamWriter(stream))
		{
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x000308EE File Offset: 0x0002EAEE
		public void Close()
		{
			this.textWriter.Close();
			this.writeState = IniWriteState.Closed;
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00030902 File Offset: 0x0002EB02
		public void Flush()
		{
			this.textWriter.Flush();
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x002FA6F4 File Offset: 0x002F88F4
		public override string ToString()
		{
			return this.textWriter.ToString();
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x0003090F File Offset: 0x0002EB0F
		public void WriteSection(string section)
		{
			this.ValidateState();
			this.writeState = IniWriteState.Section;
			this.WriteLine("[" + section + "]");
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x00030934 File Offset: 0x0002EB34
		public void WriteSection(string section, string comment)
		{
			this.ValidateState();
			this.writeState = IniWriteState.Section;
			this.WriteLine("[" + section + "]" + this.Comment(comment));
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x002FA710 File Offset: 0x002F8910
		public void WriteKey(string key, string value)
		{
			this.ValidateStateKey();
			this.WriteLine(string.Concat(new string[]
			{
				key,
				" ",
				this.assignDelimiter.ToString(),
				" ",
				this.GetKeyValue(value)
			}));
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x002FA760 File Offset: 0x002F8960
		public void WriteKey(string key, string value, string comment)
		{
			this.ValidateStateKey();
			this.WriteLine(string.Concat(new string[]
			{
				key,
				" ",
				this.assignDelimiter.ToString(),
				" ",
				this.GetKeyValue(value),
				this.Comment(comment)
			}));
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x00030960 File Offset: 0x0002EB60
		public void WriteEmpty()
		{
			this.ValidateState();
			if (this.writeState == IniWriteState.Start)
			{
				this.writeState = IniWriteState.BeforeFirstSection;
			}
			this.WriteLine("");
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x002FA7BC File Offset: 0x002F89BC
		public void WriteEmpty(string comment)
		{
			this.ValidateState();
			if (this.writeState == IniWriteState.Start)
			{
				this.writeState = IniWriteState.BeforeFirstSection;
			}
			if (comment == null)
			{
				this.WriteLine("");
			}
			else
			{
				this.WriteLine(this.commentDelimiter.ToString() + " " + comment);
			}
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x00030985 File Offset: 0x0002EB85
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x002FA810 File Offset: 0x002F8A10
		protected void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (this.textWriter != null)
				{
					this.textWriter.Close();
				}
				if (this.baseStream != null)
				{
					this.baseStream.Close();
				}
				this.disposed = true;
				if (disposing)
				{
					GC.SuppressFinalize(this);
				}
			}
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x002FA864 File Offset: 0x002F8A64
		~IniWriter()
		{
			this.Dispose(false);
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x002FA894 File Offset: 0x002F8A94
		private string GetKeyValue(string text)
		{
			string result;
			if (this.useValueQuotes)
			{
				result = this.MassageValue("\"" + text + "\"");
			}
			else
			{
				result = this.MassageValue(text);
			}
			return result;
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x002FA8D0 File Offset: 0x002F8AD0
		private void ValidateStateKey()
		{
			this.ValidateState();
			IniWriteState iniWriteState = this.writeState;
			IniWriteState iniWriteState2 = iniWriteState;
			if (iniWriteState2 <= IniWriteState.BeforeFirstSection)
			{
				throw new InvalidOperationException("The WriteState is not Section");
			}
			if (iniWriteState2 != IniWriteState.Closed)
			{
				return;
			}
			throw new InvalidOperationException("The writer is closed");
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x0003098E File Offset: 0x0002EB8E
		private void ValidateState()
		{
			if (this.writeState == IniWriteState.Closed)
			{
				throw new InvalidOperationException("The writer is closed");
			}
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x002FA90C File Offset: 0x002F8B0C
		private string Comment(string text)
		{
			return (text == null) ? "" : (" " + this.commentDelimiter.ToString() + " " + text);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x000309A6 File Offset: 0x0002EBA6
		private void Write(string value)
		{
			this.textWriter.Write(this.indentationBuffer.ToString() + value);
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x000309C4 File Offset: 0x0002EBC4
		private void WriteLine(string value)
		{
			this.Write(value + this.eol);
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x002FA940 File Offset: 0x002F8B40
		private string MassageValue(string text)
		{
			return text.Replace("\n", "");
		}

		// Token: 0x04003065 RID: 12389
		private int indentation = 0;

		// Token: 0x04003066 RID: 12390
		private bool useValueQuotes = false;

		// Token: 0x04003067 RID: 12391
		private IniWriteState writeState = IniWriteState.Start;

		// Token: 0x04003068 RID: 12392
		private char commentDelimiter = ';';

		// Token: 0x04003069 RID: 12393
		private char assignDelimiter = '=';

		// Token: 0x0400306A RID: 12394
		private TextWriter textWriter = null;

		// Token: 0x0400306B RID: 12395
		private string eol = "\r\n";

		// Token: 0x0400306C RID: 12396
		private StringBuilder indentationBuffer = new StringBuilder();

		// Token: 0x0400306D RID: 12397
		private Stream baseStream = null;

		// Token: 0x0400306E RID: 12398
		private bool disposed = false;
	}
}
