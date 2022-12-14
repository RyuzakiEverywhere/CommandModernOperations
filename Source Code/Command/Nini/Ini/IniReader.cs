using System;
using System.IO;
using System.Text;

namespace Nini.Ini
{
	// Token: 0x02000C10 RID: 3088
	public sealed class IniReader : IDisposable
	{
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06004CA0 RID: 19616 RVA: 0x002F9AF8 File Offset: 0x002F7CF8
		public string Name
		{
			get
			{
				return this.name.ToString();
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06004CA1 RID: 19617 RVA: 0x002F9B14 File Offset: 0x002F7D14
		public string Value
		{
			get
			{
				return this.value.ToString();
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06004CA2 RID: 19618 RVA: 0x002F9B30 File Offset: 0x002F7D30
		public IniType Type
		{
			get
			{
				return this.iniType;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06004CA3 RID: 19619 RVA: 0x002F9B48 File Offset: 0x002F7D48
		public string Comment
		{
			get
			{
				return this.hasComment ? this.comment.ToString() : null;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06004CA4 RID: 19620 RVA: 0x002F9B70 File Offset: 0x002F7D70
		public int LineNumber
		{
			get
			{
				return this.lineNumber;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06004CA5 RID: 19621 RVA: 0x002F9B88 File Offset: 0x002F7D88
		public int LinePosition
		{
			get
			{
				return this.column;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x00030655 File Offset: 0x0002E855
		// (set) Token: 0x06004CA7 RID: 19623 RVA: 0x0003065D File Offset: 0x0002E85D
		public bool IgnoreComments
		{
			get
			{
				return this.ignoreComments;
			}
			set
			{
				this.ignoreComments = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06004CA8 RID: 19624 RVA: 0x002F9BA0 File Offset: 0x002F7DA0
		public IniReadState ReadState
		{
			get
			{
				return this.readState;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06004CA9 RID: 19625 RVA: 0x00030666 File Offset: 0x0002E866
		// (set) Token: 0x06004CAA RID: 19626 RVA: 0x0003066E File Offset: 0x0002E86E
		public bool LineContinuation
		{
			get
			{
				return this.lineContinuation;
			}
			set
			{
				this.lineContinuation = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06004CAB RID: 19627 RVA: 0x00030677 File Offset: 0x0002E877
		// (set) Token: 0x06004CAC RID: 19628 RVA: 0x0003067F File Offset: 0x0002E87F
		public bool AcceptCommentAfterKey
		{
			get
			{
				return this.acceptCommentAfterKey;
			}
			set
			{
				this.acceptCommentAfterKey = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06004CAD RID: 19629 RVA: 0x00030688 File Offset: 0x0002E888
		// (set) Token: 0x06004CAE RID: 19630 RVA: 0x00030690 File Offset: 0x0002E890
		public bool AcceptNoAssignmentOperator
		{
			get
			{
				return this.acceptNoAssignmentOperator;
			}
			set
			{
				this.acceptNoAssignmentOperator = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06004CAF RID: 19631 RVA: 0x00030699 File Offset: 0x0002E899
		// (set) Token: 0x06004CB0 RID: 19632 RVA: 0x000306A1 File Offset: 0x0002E8A1
		public bool ConsumeAllKeyText
		{
			get
			{
				return this.consumeAllKeyText;
			}
			set
			{
				this.consumeAllKeyText = value;
			}
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x002F9BB8 File Offset: 0x002F7DB8
		public IniReader(string filePath)
		{
			this.textReader = new StreamReader(filePath);
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x002F9C70 File Offset: 0x002F7E70
		public IniReader(TextReader reader)
		{
			this.textReader = reader;
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x000306AA File Offset: 0x0002E8AA
		public IniReader(Stream stream) : this(new StreamReader(stream))
		{
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x002F9D24 File Offset: 0x002F7F24
		public bool Read()
		{
			bool result = false;
			if (this.readState != IniReadState.EndOfFile || this.readState > IniReadState.Closed)
			{
				this.readState = IniReadState.Interactive;
				result = this.ReadNext();
			}
			return result;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x002F9D5C File Offset: 0x002F7F5C
		public bool MoveToNextSection()
		{
			bool flag;
			do
			{
				flag = this.Read();
			}
			while (this.iniType != IniType.Section && flag);
			return flag;
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x002F9D8C File Offset: 0x002F7F8C
		public bool MoveToNextKey()
		{
			bool flag;
			for (;;)
			{
				flag = this.Read();
				if (this.iniType == IniType.Section)
				{
					break;
				}
				if (this.iniType == IniType.Key || !flag)
				{
					return flag;
				}
			}
			flag = false;
			return flag;
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x000306B8 File Offset: 0x0002E8B8
		public void Close()
		{
			this.Reset();
			this.readState = IniReadState.Closed;
			if (this.textReader != null)
			{
				this.textReader.Close();
			}
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x000306DD File Offset: 0x0002E8DD
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x002F9DC4 File Offset: 0x002F7FC4
		public char[] GetCommentDelimiters()
		{
			char[] array = new char[this.commentDelimiters.Length];
			Array.Copy(this.commentDelimiters, 0, array, 0, this.commentDelimiters.Length);
			return array;
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x000306E6 File Offset: 0x0002E8E6
		public void SetCommentDelimiters(char[] delimiters)
		{
			if (delimiters.Length < 1)
			{
				throw new ArgumentException("Must supply at least one delimiter");
			}
			this.commentDelimiters = delimiters;
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x002F9DF8 File Offset: 0x002F7FF8
		public char[] GetAssignDelimiters()
		{
			char[] array = new char[this.assignDelimiters.Length];
			Array.Copy(this.assignDelimiters, 0, array, 0, this.assignDelimiters.Length);
			return array;
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00030702 File Offset: 0x0002E902
		public void SetAssignDelimiters(char[] delimiters)
		{
			if (delimiters.Length < 1)
			{
				throw new ArgumentException("Must supply at least one delimiter");
			}
			this.assignDelimiters = delimiters;
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x0003071E File Offset: 0x0002E91E
		protected void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				this.textReader.Close();
				this.disposed = true;
				if (disposing)
				{
					GC.SuppressFinalize(this);
				}
			}
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x002F9E2C File Offset: 0x002F802C
		~IniReader()
		{
			this.Dispose(false);
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x002F9E5C File Offset: 0x002F805C
		private void Reset()
		{
			this.name.Remove(0, this.name.Length);
			this.value.Remove(0, this.value.Length);
			this.comment.Remove(0, this.comment.Length);
			this.iniType = IniType.Empty;
			this.hasComment = false;
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x002F9EC0 File Offset: 0x002F80C0
		private bool ReadNext()
		{
			bool flag = true;
			int num = this.PeekChar();
			this.Reset();
			bool result;
			if (this.IsComment(num))
			{
				this.iniType = IniType.Empty;
				this.ReadChar();
				this.ReadComment();
				result = flag;
			}
			else
			{
				int num2 = num;
				int num3 = num2;
				if (num3 <= 13)
				{
					if (num3 == -1)
					{
						this.readState = IniReadState.EndOfFile;
						flag = false;
						goto IL_9D;
					}
					switch (num3)
					{
					case 9:
					case 13:
						goto IL_90;
					case 10:
						this.ReadChar();
						goto IL_9D;
					}
				}
				else
				{
					if (num3 == 32)
					{
						goto IL_90;
					}
					if (num3 == 91)
					{
						this.ReadSection();
						goto IL_9D;
					}
				}
				this.ReadKey();
				goto IL_9D;
				IL_90:
				this.SkipWhitespace();
				this.ReadNext();
				IL_9D:
				result = flag;
			}
			return result;
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x002F9F70 File Offset: 0x002F8170
		private void ReadComment()
		{
			this.SkipWhitespace();
			this.hasComment = true;
			int num;
			do
			{
				num = this.ReadChar();
				this.comment.Append((char)num);
			}
			while (!this.EndOfLine(num));
			this.RemoveTrailingWhitespace(this.comment);
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x002F9FBC File Offset: 0x002F81BC
		private void RemoveTrailingWhitespace(StringBuilder builder)
		{
			string text = builder.ToString();
			builder.Remove(0, builder.Length);
			builder.Append(text.TrimEnd(null));
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x002F9FEC File Offset: 0x002F81EC
		private void ReadKey()
		{
			this.iniType = IniType.Key;
			for (;;)
			{
				int ch = this.PeekChar();
				if (this.IsAssign(ch))
				{
					break;
				}
				if (this.EndOfLine(ch))
				{
					goto IL_40;
				}
				this.name.Append((char)this.ReadChar());
			}
			this.ReadChar();
			goto IL_66;
			IL_40:
			if (!this.acceptNoAssignmentOperator)
			{
				throw new IniException(this, string.Format("Expected assignment operator ({0})", this.assignDelimiters[0]));
			}
			IL_66:
			this.ReadKeyValue();
			this.SearchForComment();
			this.RemoveTrailingWhitespace(this.name);
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x002FA078 File Offset: 0x002F8278
		private void ReadKeyValue()
		{
			bool flag = false;
			int num = 0;
			this.SkipWhitespace();
			for (;;)
			{
				int num2 = this.PeekChar();
				if (!this.IsWhitespace(num2))
				{
					num++;
				}
				if (!this.ConsumeAllKeyText && num2 == 34)
				{
					this.ReadChar();
					if (flag || num != 1)
					{
						goto IL_159;
					}
					flag = true;
				}
				else
				{
					if (flag && this.EndOfLine(num2))
					{
						break;
					}
					if (this.lineContinuation && num2 == 92)
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.Append((char)this.ReadChar());
						while (this.PeekChar() != 10 && this.IsWhitespace(this.PeekChar()))
						{
							if (this.PeekChar() != 13)
							{
								stringBuilder.Append((char)this.ReadChar());
							}
							else
							{
								this.ReadChar();
							}
						}
						if (this.PeekChar() == 10)
						{
							this.ReadChar();
							continue;
						}
						this.value.Append(stringBuilder.ToString());
					}
					if ((!this.ConsumeAllKeyText && (this.acceptCommentAfterKey && this.IsComment(num2)) && !flag) || this.EndOfLine(num2))
					{
						goto IL_159;
					}
					this.value.Append((char)this.ReadChar());
				}
			}
			throw new IniException(this, "Expected closing quote (\")");
			IL_159:
			if (!flag)
			{
				this.RemoveTrailingWhitespace(this.value);
			}
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x002FA1F0 File Offset: 0x002F83F0
		private void ReadSection()
		{
			this.iniType = IniType.Section;
			int num = this.ReadChar();
			for (;;)
			{
				num = this.PeekChar();
				if (num == 93)
				{
					break;
				}
				if (this.EndOfLine(num))
				{
					goto IL_3E;
				}
				this.name.Append((char)this.ReadChar());
			}
			this.ConsumeToEnd();
			this.RemoveTrailingWhitespace(this.name);
			return;
			IL_3E:
			throw new IniException(this, "Expected section end (])");
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x002FA25C File Offset: 0x002F845C
		private void SearchForComment()
		{
			int ch = this.ReadChar();
			while (!this.EndOfLine(ch))
			{
				if (this.IsComment(ch))
				{
					if (this.ignoreComments)
					{
						this.ConsumeToEnd();
					}
					else
					{
						this.ReadComment();
					}
					return;
				}
				ch = this.ReadChar();
			}
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x002FA2A8 File Offset: 0x002F84A8
		private void ConsumeToEnd()
		{
			int ch;
			do
			{
				ch = this.ReadChar();
			}
			while (!this.EndOfLine(ch));
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x002FA2CC File Offset: 0x002F84CC
		private int ReadChar()
		{
			int num = this.textReader.Read();
			if (num == 10)
			{
				this.lineNumber++;
				this.column = 1;
			}
			else
			{
				this.column++;
			}
			return num;
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x002FA314 File Offset: 0x002F8514
		private int PeekChar()
		{
			return this.textReader.Peek();
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x00030746 File Offset: 0x0002E946
		private bool IsComment(int ch)
		{
			return this.HasCharacter(this.commentDelimiters, ch);
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x00030755 File Offset: 0x0002E955
		private bool IsAssign(int ch)
		{
			return this.HasCharacter(this.assignDelimiters, ch);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x002FA330 File Offset: 0x002F8530
		private bool HasCharacter(char[] characters, int ch)
		{
			bool result = false;
			for (int i = 0; i < characters.Length; i++)
			{
				if (ch == (int)characters[i])
				{
					result = true;
					return result;
				}
			}
			return result;
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x00030764 File Offset: 0x0002E964
		private bool IsWhitespace(int ch)
		{
			return ch == 32 || ch == 9 || ch == 13 || ch == 10;
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x0003077D File Offset: 0x0002E97D
		private void SkipWhitespace()
		{
			while (this.IsWhitespace(this.PeekChar()) && !this.EndOfLine(this.PeekChar()))
			{
				this.ReadChar();
			}
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x000307A5 File Offset: 0x0002E9A5
		private bool EndOfLine(int ch)
		{
			return ch == 10 || ch == -1;
		}

		// Token: 0x0400304A RID: 12362
		private int lineNumber = 1;

		// Token: 0x0400304B RID: 12363
		private int column = 1;

		// Token: 0x0400304C RID: 12364
		private IniType iniType = IniType.Empty;

		// Token: 0x0400304D RID: 12365
		private TextReader textReader = null;

		// Token: 0x0400304E RID: 12366
		private bool ignoreComments = false;

		// Token: 0x0400304F RID: 12367
		private StringBuilder name = new StringBuilder();

		// Token: 0x04003050 RID: 12368
		private StringBuilder value = new StringBuilder();

		// Token: 0x04003051 RID: 12369
		private StringBuilder comment = new StringBuilder();

		// Token: 0x04003052 RID: 12370
		private IniReadState readState = IniReadState.Initial;

		// Token: 0x04003053 RID: 12371
		private bool hasComment = false;

		// Token: 0x04003054 RID: 12372
		private bool disposed = false;

		// Token: 0x04003055 RID: 12373
		private bool lineContinuation = false;

		// Token: 0x04003056 RID: 12374
		private bool acceptCommentAfterKey = true;

		// Token: 0x04003057 RID: 12375
		private bool acceptNoAssignmentOperator = false;

		// Token: 0x04003058 RID: 12376
		private bool consumeAllKeyText = false;

		// Token: 0x04003059 RID: 12377
		private char[] commentDelimiters = new char[]
		{
			';'
		};

		// Token: 0x0400305A RID: 12378
		private char[] assignDelimiters = new char[]
		{
			'='
		};
	}
}
