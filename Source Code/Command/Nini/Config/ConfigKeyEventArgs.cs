using System;

namespace Nini.Config
{
	// Token: 0x02000C18 RID: 3096
	public sealed class ConfigKeyEventArgs : EventArgs
	{
		// Token: 0x06004D1F RID: 19743 RVA: 0x00030ACD File Offset: 0x0002ECCD
		public ConfigKeyEventArgs(string keyName, string keyValue)
		{
			this.keyName = keyName;
			this.keyValue = keyValue;
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06004D20 RID: 19744 RVA: 0x002FABCC File Offset: 0x002F8DCC
		public string KeyName
		{
			get
			{
				return this.keyName;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x002FABE4 File Offset: 0x002F8DE4
		public string KeyValue
		{
			get
			{
				return this.keyValue;
			}
		}

		// Token: 0x04003073 RID: 12403
		private string keyName = null;

		// Token: 0x04003074 RID: 12404
		private string keyValue = null;
	}
}
