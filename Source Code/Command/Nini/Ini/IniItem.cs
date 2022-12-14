using System;

namespace Nini.Ini
{
	// Token: 0x02000C0D RID: 3085
	public sealed class IniItem
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x002F9A44 File Offset: 0x002F7C44
		// (set) Token: 0x06004C99 RID: 19609 RVA: 0x0003063A File Offset: 0x0002E83A
		public IniType Type
		{
			get
			{
				return this.iniType;
			}
			set
			{
				this.iniType = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06004C9A RID: 19610 RVA: 0x002F9A5C File Offset: 0x002F7C5C
		// (set) Token: 0x06004C9B RID: 19611 RVA: 0x00030643 File Offset: 0x0002E843
		public string Value
		{
			get
			{
				return this.iniValue;
			}
			set
			{
				this.iniValue = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06004C9C RID: 19612 RVA: 0x002F9A74 File Offset: 0x002F7C74
		public string Name
		{
			get
			{
				return this.iniName;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06004C9D RID: 19613 RVA: 0x002F9A8C File Offset: 0x002F7C8C
		// (set) Token: 0x06004C9E RID: 19614 RVA: 0x0003064C File Offset: 0x0002E84C
		public string Comment
		{
			get
			{
				return this.iniComment;
			}
			set
			{
				this.iniComment = value;
			}
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x002F9AA4 File Offset: 0x002F7CA4
		protected internal IniItem(string name, string value, IniType type, string comment)
		{
			this.iniName = name;
			this.iniValue = value;
			this.iniType = type;
			this.iniComment = comment;
		}

		// Token: 0x0400303C RID: 12348
		private IniType iniType = IniType.Empty;

		// Token: 0x0400303D RID: 12349
		private string iniName = "";

		// Token: 0x0400303E RID: 12350
		private string iniValue = "";

		// Token: 0x0400303F RID: 12351
		private string iniComment = null;
	}
}
