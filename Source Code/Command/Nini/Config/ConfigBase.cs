using System;
using System.Diagnostics;
using System.Globalization;
using Nini.Util;

namespace Nini.Config
{
	// Token: 0x02000C19 RID: 3097
	public class ConfigBase : IConfig
	{
		// Token: 0x06004D22 RID: 19746 RVA: 0x002FABFC File Offset: 0x002F8DFC
		public ConfigBase(string name, IConfigSource source)
		{
			this.configName = name;
			this.configSource = source;
			this.aliasText = new AliasText();
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x002FAC54 File Offset: 0x002F8E54
		// (set) Token: 0x06004D24 RID: 19748 RVA: 0x00030AF1 File Offset: 0x0002ECF1
		public string Name
		{
			get
			{
				return this.configName;
			}
			set
			{
				if (this.configName != value)
				{
					this.Rename(value);
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x002FAC6C File Offset: 0x002F8E6C
		public IConfigSource ConfigSource
		{
			get
			{
				return this.configSource;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06004D26 RID: 19750 RVA: 0x002FAC84 File Offset: 0x002F8E84
		public AliasText Alias
		{
			get
			{
				return this.aliasText;
			}
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x00030B08 File Offset: 0x0002ED08
		public bool Contains(string key)
		{
			return this.Get(key) != null;
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x002FAC9C File Offset: 0x002F8E9C
		public virtual string Get(string key)
		{
			string result = null;
			if (this.keys.Contains(key))
			{
				result = this.keys[key].ToString();
			}
			return result;
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x002FACD0 File Offset: 0x002F8ED0
		public string Get(string key, string defaultValue)
		{
			string text = this.Get(key);
			return (text == null) ? defaultValue : text;
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x002FACF0 File Offset: 0x002F8EF0
		public string GetExpanded(string key)
		{
			return this.ConfigSource.GetExpanded(this, key);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x002FAD0C File Offset: 0x002F8F0C
		public string GetString(string key)
		{
			return this.Get(key);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x002FAD24 File Offset: 0x002F8F24
		public string GetString(string key, string defaultValue)
		{
			return this.Get(key, defaultValue);
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x002FAD3C File Offset: 0x002F8F3C
		public int GetInt(string key)
		{
			string text = this.Get(key);
			if (text == null)
			{
				throw new ArgumentException("Value not found: " + key);
			}
			return Convert.ToInt32(text, this.format);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x002FAD78 File Offset: 0x002F8F78
		public int GetInt(string key, bool fromAlias)
		{
			int result;
			if (!fromAlias)
			{
				result = this.GetInt(key);
			}
			else
			{
				string text = this.Get(key);
				if (text == null)
				{
					throw new ArgumentException("Value not found: " + key);
				}
				result = this.GetIntAlias(key, text);
			}
			return result;
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x002FADC0 File Offset: 0x002F8FC0
		public int GetInt(string key, int defaultValue)
		{
			string text = this.Get(key);
			return (text == null) ? defaultValue : Convert.ToInt32(text, this.format);
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x002FADEC File Offset: 0x002F8FEC
		public int GetInt(string key, int defaultValue, bool fromAlias)
		{
			int result;
			if (!fromAlias)
			{
				result = this.GetInt(key, defaultValue);
			}
			else
			{
				string text = this.Get(key);
				result = ((text == null) ? defaultValue : this.GetIntAlias(key, text));
			}
			return result;
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x002FAE24 File Offset: 0x002F9024
		public long GetLong(string key)
		{
			string text = this.Get(key);
			if (text == null)
			{
				throw new ArgumentException("Value not found: " + key);
			}
			return Convert.ToInt64(text, this.format);
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x002FAE60 File Offset: 0x002F9060
		public long GetLong(string key, long defaultValue)
		{
			string text = this.Get(key);
			return (text == null) ? defaultValue : Convert.ToInt64(text, this.format);
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x002FAE8C File Offset: 0x002F908C
		public bool GetBoolean(string key)
		{
			string text = this.Get(key);
			if (text == null)
			{
				throw new ArgumentException("Value not found: " + key);
			}
			return this.GetBooleanAlias(text);
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x002FAEC0 File Offset: 0x002F90C0
		public bool GetBoolean(string key, bool defaultValue)
		{
			string text = this.Get(key);
			return (text == null) ? defaultValue : this.GetBooleanAlias(text);
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x002FAEE4 File Offset: 0x002F90E4
		public float GetFloat(string key)
		{
			string text = this.Get(key);
			if (text == null)
			{
				throw new ArgumentException("Value not found: " + key);
			}
			return Convert.ToSingle(text, this.format);
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x002FAF20 File Offset: 0x002F9120
		public float GetFloat(string key, float defaultValue)
		{
			string text = this.Get(key);
			return (text == null) ? defaultValue : Convert.ToSingle(text, this.format);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x002FAF4C File Offset: 0x002F914C
		public double GetDouble(string key)
		{
			string text = this.Get(key);
			if (text == null)
			{
				throw new ArgumentException("Value not found: " + key);
			}
			return Convert.ToDouble(text, this.format);
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x002FAF88 File Offset: 0x002F9188
		public double GetDouble(string key, double defaultValue)
		{
			string text = this.Get(key);
			return (text == null) ? defaultValue : Convert.ToDouble(text, this.format);
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x002FAFB4 File Offset: 0x002F91B4
		public string[] GetKeys()
		{
			string[] array = new string[this.keys.Keys.Count];
			this.keys.Keys.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x002FAFEC File Offset: 0x002F91EC
		public string[] GetValues()
		{
			string[] array = new string[this.keys.Values.Count];
			this.keys.Values.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x00030B14 File Offset: 0x0002ED14
		public void Add(string key, string value)
		{
			this.keys.Add(key, value);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x002FB024 File Offset: 0x002F9224
		public virtual void Set(string key, object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("Value cannot be null");
			}
			if (this.Get(key) == null)
			{
				this.Add(key, value.ToString());
			}
			else
			{
				this.keys[key] = value.ToString();
			}
			if (this.ConfigSource.AutoSave)
			{
				this.ConfigSource.Save();
			}
			this.OnKeySet(new ConfigKeyEventArgs(key, value.ToString()));
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x002FB09C File Offset: 0x002F929C
		public virtual void Remove(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException("Key cannot be null");
			}
			if (this.Get(key) != null)
			{
				string keyValue = null;
				if (this.KeySet != null)
				{
					keyValue = this.Get(key);
				}
				this.keys.Remove(key);
				this.OnKeyRemoved(new ConfigKeyEventArgs(key, keyValue));
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06004D3E RID: 19774 RVA: 0x002FB0F4 File Offset: 0x002F92F4
		// (remove) Token: 0x06004D3F RID: 19775 RVA: 0x002FB12C File Offset: 0x002F932C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ConfigKeyEventHandler KeySet;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06004D40 RID: 19776 RVA: 0x002FB164 File Offset: 0x002F9364
		// (remove) Token: 0x06004D41 RID: 19777 RVA: 0x002FB19C File Offset: 0x002F939C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event ConfigKeyEventHandler KeyRemoved;

		// Token: 0x06004D42 RID: 19778 RVA: 0x00030B23 File Offset: 0x0002ED23
		protected void OnKeySet(ConfigKeyEventArgs e)
		{
			if (this.KeySet != null)
			{
				this.KeySet(this, e);
			}
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00030B3D File Offset: 0x0002ED3D
		protected void OnKeyRemoved(ConfigKeyEventArgs e)
		{
			if (this.KeyRemoved != null)
			{
				this.KeyRemoved(this, e);
			}
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00030B57 File Offset: 0x0002ED57
		private void Rename(string name)
		{
			this.ConfigSource.Configs.Remove(this);
			this.configName = name;
			this.ConfigSource.Configs.Add(this);
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x002FB1D4 File Offset: 0x002F93D4
		private int GetIntAlias(string key, string alias)
		{
			int @int;
			if (this.aliasText.ContainsInt(key, alias))
			{
				@int = this.aliasText.GetInt(key, alias);
			}
			else
			{
				@int = this.ConfigSource.Alias.GetInt(key, alias);
			}
			return @int;
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x002FB218 File Offset: 0x002F9418
		private bool GetBooleanAlias(string key)
		{
			bool boolean;
			if (this.aliasText.ContainsBoolean(key))
			{
				boolean = this.aliasText.GetBoolean(key);
			}
			else
			{
				if (!this.ConfigSource.Alias.ContainsBoolean(key))
				{
					throw new ArgumentException("Alias value not found: " + key + ". Add it to the Alias property.");
				}
				boolean = this.ConfigSource.Alias.GetBoolean(key);
			}
			return boolean;
		}

		// Token: 0x04003075 RID: 12405
		private string configName = null;

		// Token: 0x04003076 RID: 12406
		private IConfigSource configSource = null;

		// Token: 0x04003077 RID: 12407
		private AliasText aliasText = null;

		// Token: 0x04003078 RID: 12408
		private IFormatProvider format = NumberFormatInfo.CurrentInfo;

		// Token: 0x04003079 RID: 12409
		protected OrderedList keys = new OrderedList();
	}
}
