using System;

namespace Nini.Config
{
	// Token: 0x02000C1B RID: 3099
	public sealed class ConfigEventArgs : EventArgs
	{
		// Token: 0x06004D4B RID: 19787 RVA: 0x00030B82 File Offset: 0x0002ED82
		public ConfigEventArgs(IConfig config)
		{
			this.config = config;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x002FB284 File Offset: 0x002F9484
		public IConfig Config
		{
			get
			{
				return this.config;
			}
		}

		// Token: 0x0400307C RID: 12412
		private IConfig config = null;
	}
}
