using System;

namespace Nini.Config
{
	// Token: 0x02000C20 RID: 3104
	public interface IConfigSource
	{
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06004DBD RID: 19901
		ConfigCollection Configs { get; }

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06004DBE RID: 19902
		// (set) Token: 0x06004DBF RID: 19903
		bool AutoSave { get; set; }

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06004DC0 RID: 19904
		AliasText Alias { get; }

		// Token: 0x06004DC1 RID: 19905
		void Merge(IConfigSource source);

		// Token: 0x06004DC2 RID: 19906
		void Save();

		// Token: 0x06004DC3 RID: 19907
		void Reload();

		// Token: 0x06004DC4 RID: 19908
		IConfig AddConfig(string name);

		// Token: 0x06004DC5 RID: 19909
		string GetExpanded(IConfig config, string key);

		// Token: 0x06004DC6 RID: 19910
		void ExpandKeyValues();

		// Token: 0x06004DC7 RID: 19911
		void ReplaceKeyValues();

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06004DC8 RID: 19912
		// (remove) Token: 0x06004DC9 RID: 19913
		event EventHandler Reloaded;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06004DCA RID: 19914
		// (remove) Token: 0x06004DCB RID: 19915
		event EventHandler Saved;
	}
}
