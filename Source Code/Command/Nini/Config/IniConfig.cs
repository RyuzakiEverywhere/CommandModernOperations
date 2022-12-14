using System;

namespace Nini.Config
{
	// Token: 0x02000C21 RID: 3105
	public sealed class IniConfig : ConfigBase
	{
		// Token: 0x06004DCC RID: 19916 RVA: 0x00030EFD File Offset: 0x0002F0FD
		public IniConfig(string name, IConfigSource source) : base(name, source)
		{
			this.parent = (IniConfigSource)source;
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x002FC3E8 File Offset: 0x002FA5E8
		public override string Get(string key)
		{
			if (!this.parent.CaseSensitive)
			{
				key = this.CaseInsensitiveKeyName(key);
			}
			return base.Get(key);
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x00030F1A File Offset: 0x0002F11A
		public override void Set(string key, object value)
		{
			if (!this.parent.CaseSensitive)
			{
				key = this.CaseInsensitiveKeyName(key);
			}
			base.Set(key, value);
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x00030F3D File Offset: 0x0002F13D
		public override void Remove(string key)
		{
			if (!this.parent.CaseSensitive)
			{
				key = this.CaseInsensitiveKeyName(key);
			}
			base.Remove(key);
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x002FC418 File Offset: 0x002FA618
		private string CaseInsensitiveKeyName(string key)
		{
			string text = null;
			string b = key.ToLower();
			foreach (object obj in this.keys.Keys)
			{
				string text2 = (string)obj;
				if (text2.ToLower() == b)
				{
					text = text2;
					break;
				}
			}
			return (text == null) ? key : text;
		}

		// Token: 0x0400308A RID: 12426
		private IniConfigSource parent = null;
	}
}
