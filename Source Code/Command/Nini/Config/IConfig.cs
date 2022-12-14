using System;

namespace Nini.Config
{
	// Token: 0x02000C1F RID: 3103
	public interface IConfig
	{
		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06004D9F RID: 19871
		IConfigSource ConfigSource { get; }

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06004DA0 RID: 19872
		// (set) Token: 0x06004DA1 RID: 19873
		string Name { get; set; }

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06004DA2 RID: 19874
		AliasText Alias { get; }

		// Token: 0x06004DA3 RID: 19875
		bool Contains(string key);

		// Token: 0x06004DA4 RID: 19876
		string Get(string key);

		// Token: 0x06004DA5 RID: 19877
		string Get(string key, string defaultValue);

		// Token: 0x06004DA6 RID: 19878
		string GetExpanded(string key);

		// Token: 0x06004DA7 RID: 19879
		string GetString(string key);

		// Token: 0x06004DA8 RID: 19880
		string GetString(string key, string defaultValue);

		// Token: 0x06004DA9 RID: 19881
		int GetInt(string key);

		// Token: 0x06004DAA RID: 19882
		int GetInt(string key, bool fromAlias);

		// Token: 0x06004DAB RID: 19883
		int GetInt(string key, int defaultValue);

		// Token: 0x06004DAC RID: 19884
		int GetInt(string key, int defaultValue, bool fromAlias);

		// Token: 0x06004DAD RID: 19885
		long GetLong(string key);

		// Token: 0x06004DAE RID: 19886
		long GetLong(string key, long defaultValue);

		// Token: 0x06004DAF RID: 19887
		bool GetBoolean(string key);

		// Token: 0x06004DB0 RID: 19888
		bool GetBoolean(string key, bool defaultValue);

		// Token: 0x06004DB1 RID: 19889
		float GetFloat(string key);

		// Token: 0x06004DB2 RID: 19890
		float GetFloat(string key, float defaultValue);

		// Token: 0x06004DB3 RID: 19891
		double GetDouble(string key);

		// Token: 0x06004DB4 RID: 19892
		double GetDouble(string key, double defaultValue);

		// Token: 0x06004DB5 RID: 19893
		string[] GetKeys();

		// Token: 0x06004DB6 RID: 19894
		string[] GetValues();

		// Token: 0x06004DB7 RID: 19895
		void Set(string key, object value);

		// Token: 0x06004DB8 RID: 19896
		void Remove(string key);

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06004DB9 RID: 19897
		// (remove) Token: 0x06004DBA RID: 19898
		event ConfigKeyEventHandler KeySet;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06004DBB RID: 19899
		// (remove) Token: 0x06004DBC RID: 19900
		event ConfigKeyEventHandler KeyRemoved;
	}
}
