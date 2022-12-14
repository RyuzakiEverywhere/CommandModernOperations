using System;
using System.Collections;

namespace Nini.Config
{
	// Token: 0x02000C15 RID: 3093
	public sealed class AliasText
	{
		// Token: 0x06004D09 RID: 19721 RVA: 0x000309D8 File Offset: 0x0002EBD8
		public AliasText()
		{
			this.intAlias = this.InsensitiveHashtable();
			this.booleanAlias = this.InsensitiveHashtable();
			this.DefaultAliasLoad();
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x002FA960 File Offset: 0x002F8B60
		public void AddAlias(string key, string alias, int value)
		{
			if (this.intAlias.Contains(key))
			{
				Hashtable hashtable = (Hashtable)this.intAlias[key];
				hashtable[alias] = value;
			}
			else
			{
				Hashtable hashtable2 = this.InsensitiveHashtable();
				hashtable2[alias] = value;
				this.intAlias.Add(key, hashtable2);
			}
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00030A0C File Offset: 0x0002EC0C
		public void AddAlias(string alias, bool value)
		{
			this.booleanAlias[alias] = value;
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00030A20 File Offset: 0x0002EC20
		public void AddAlias(string key, Enum enumAlias)
		{
			this.SetAliasTypes(key, enumAlias);
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00030A2A File Offset: 0x0002EC2A
		public bool ContainsBoolean(string key)
		{
			return this.booleanAlias.Contains(key);
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x002FA9C0 File Offset: 0x002F8BC0
		public bool ContainsInt(string key, string alias)
		{
			bool result = false;
			if (this.intAlias.Contains(key))
			{
				Hashtable hashtable = (Hashtable)this.intAlias[key];
				result = hashtable.Contains(alias);
			}
			return result;
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00030A38 File Offset: 0x0002EC38
		public bool GetBoolean(string key)
		{
			if (!this.booleanAlias.Contains(key))
			{
				throw new ArgumentException("Alias does not exist for text");
			}
			return (bool)this.booleanAlias[key];
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x002FA9F8 File Offset: 0x002F8BF8
		public int GetInt(string key, string alias)
		{
			if (!this.intAlias.Contains(key))
			{
				throw new ArgumentException("Alias does not exist for key");
			}
			Hashtable hashtable = (Hashtable)this.intAlias[key];
			if (!hashtable.Contains(alias))
			{
				throw new ArgumentException("Config value does not match a supplied alias");
			}
			return (int)hashtable[alias];
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00030A67 File Offset: 0x0002EC67
		private void DefaultAliasLoad()
		{
			this.AddAlias("true", true);
			this.AddAlias("false", false);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x002FAA58 File Offset: 0x002F8C58
		private void SetAliasTypes(string key, Enum enumAlias)
		{
			string[] names = Enum.GetNames(enumAlias.GetType());
			int[] array = (int[])Enum.GetValues(enumAlias.GetType());
			for (int i = 0; i < names.Length; i++)
			{
				this.AddAlias(key, names[i], array[i]);
			}
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x002FAAA0 File Offset: 0x002F8CA0
		private Hashtable InsensitiveHashtable()
		{
			return new Hashtable(CaseInsensitiveHashCodeProvider.Default, CaseInsensitiveComparer.Default);
		}

		// Token: 0x0400306F RID: 12399
		private Hashtable intAlias = null;

		// Token: 0x04003070 RID: 12400
		private Hashtable booleanAlias = null;
	}
}
