using System;
using Nini.Util;

namespace Nini.Config
{
	// Token: 0x02000C16 RID: 3094
	public sealed class ArgvConfigSource : ConfigSourceBase
	{
		// Token: 0x06004D14 RID: 19732 RVA: 0x00030A81 File Offset: 0x0002EC81
		public ArgvConfigSource(string[] arguments)
		{
			this.parser = new ArgvParser(arguments);
			this.arguments = arguments;
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x00030AAA File Offset: 0x0002ECAA
		public override void Save()
		{
			throw new ArgumentException("Source is read only");
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00030AB6 File Offset: 0x0002ECB6
		public override void Reload()
		{
			throw new ArgumentException("Source cannot be reloaded");
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x00030AC2 File Offset: 0x0002ECC2
		public void AddSwitch(string configName, string longName)
		{
			this.AddSwitch(configName, longName, null);
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x002FAAC0 File Offset: 0x002F8CC0
		public void AddSwitch(string configName, string longName, string shortName)
		{
			IConfig config = this.GetConfig(configName);
			if (shortName != null && (shortName.Length < 1 || shortName.Length > 2))
			{
				throw new ArgumentException("Short name may only be 1 or 2 characters");
			}
			if (this.parser[longName] != null)
			{
				config.Set(longName, this.parser[longName]);
			}
			else if (shortName != null && this.parser[shortName] != null)
			{
				config.Set(longName, this.parser[shortName]);
			}
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x002FAB50 File Offset: 0x002F8D50
		public string[] GetArguments()
		{
			string[] array = new string[this.arguments.Length];
			Array.Copy(this.arguments, 0, array, 0, this.arguments.Length);
			return array;
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x002FAB84 File Offset: 0x002F8D84
		private IConfig GetConfig(string name)
		{
			IConfig config;
			if (base.Configs[name] == null)
			{
				config = new ConfigBase(name, this);
				base.Configs.Add(config);
			}
			else
			{
				config = base.Configs[name];
			}
			return config;
		}

		// Token: 0x04003071 RID: 12401
		private ArgvParser parser = null;

		// Token: 0x04003072 RID: 12402
		private string[] arguments = null;
	}
}
