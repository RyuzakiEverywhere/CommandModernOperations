using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Nini.Ini
{
	// Token: 0x02000C0C RID: 3084
	[Serializable]
	public sealed class IniException : SystemException
	{
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x002F9948 File Offset: 0x002F7B48
		public int LinePosition
		{
			get
			{
				return (this.iniReader == null) ? 0 : this.iniReader.LinePosition;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x002F9970 File Offset: 0x002F7B70
		public int LineNumber
		{
			get
			{
				return (this.iniReader == null) ? 0 : this.iniReader.LineNumber;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06004C91 RID: 19601 RVA: 0x002F9998 File Offset: 0x002F7B98
		public override string Message
		{
			get
			{
				string result;
				if (this.iniReader == null)
				{
					result = base.Message;
				}
				else
				{
					result = string.Format(CultureInfo.InvariantCulture, "{0} - Line: {1}, Position: {2}.", new object[]
					{
						this.message,
						this.LineNumber,
						this.LinePosition
					});
				}
				return result;
			}
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x000305A4 File Offset: 0x0002E7A4
		public IniException()
		{
			this.message = "An error has occurred";
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x000305C9 File Offset: 0x0002E7C9
		public IniException(string message, Exception exception) : base(message, exception)
		{
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x000305E5 File Offset: 0x0002E7E5
		public IniException(string message) : base(message)
		{
			this.message = message;
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x00030607 File Offset: 0x0002E807
		internal IniException(IniReader reader, string message) : this(message)
		{
			this.iniReader = reader;
			this.message = message;
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x0003061E File Offset: 0x0002E81E
		protected IniException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x002F99F8 File Offset: 0x002F7BF8
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (this.iniReader != null)
			{
				info.AddValue("lineNumber", this.iniReader.LineNumber);
				info.AddValue("linePosition", this.iniReader.LinePosition);
			}
		}

		// Token: 0x0400303A RID: 12346
		private IniReader iniReader = null;

		// Token: 0x0400303B RID: 12347
		private string message = "";
	}
}
