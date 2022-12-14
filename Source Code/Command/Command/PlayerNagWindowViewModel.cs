using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Command_Core;
using Microsoft.VisualBasic.CompilerServices;
using Nini.Config;
using ns14;

namespace Command
{
	// Token: 0x02000DD7 RID: 3543
	[Attribute0]
	[Attribute2]
	[Attribute3]
	public sealed class PlayerNagWindowViewModel : INotifyPropertyChanged
	{
		// Token: 0x060066A3 RID: 26275 RVA: 0x00040E44 File Offset: 0x0003F044
		public PlayerNagWindowViewModel()
		{
			this.string_3 = Path.Combine(GameGeneral.string_11, "PlayerDialogOptions.ini");
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x00040E61 File Offset: 0x0003F061
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x00040E69 File Offset: 0x0003F069
		public string INI_String
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_0 = value;
				this.vmethod_0("NeverShowAgain");
				this.vmethod_0("INI_String");
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x00040E98 File Offset: 0x0003F098
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x00040EA0 File Offset: 0x0003F0A0
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_1 = value;
				this.vmethod_0("Title");
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x00040EC4 File Offset: 0x0003F0C4
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x00040ECC File Offset: 0x0003F0CC
		public string Message
		{
			[CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_2, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_2 = value;
				this.vmethod_0("Message");
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060066AA RID: 26282 RVA: 0x003866BC File Offset: 0x003848BC
		// (set) Token: 0x060066AB RID: 26283 RVA: 0x00386728 File Offset: 0x00384928
		public bool NeverShowAgain
		{
			get
			{
				IniConfigSource iniConfigSource;
				if (!File.Exists(this.string_3))
				{
					iniConfigSource = new IniConfigSource();
					iniConfigSource.Save(this.string_3);
				}
				iniConfigSource = new IniConfigSource(this.string_3);
				IConfig config = iniConfigSource.Configs[this.INI_String];
				string text = (config != null) ? config.Get("NeverShowAgain") : null;
				return text != null && Conversions.ToBoolean(text);
			}
			set
			{
				if (this.NeverShowAgain == value)
				{
					return;
				}
				IniConfigSource iniConfigSource;
				if (!File.Exists(this.string_3))
				{
					iniConfigSource = new IniConfigSource();
					iniConfigSource.Save(this.string_3);
				}
				iniConfigSource = new IniConfigSource(this.string_3);
				if (iniConfigSource.Configs[this.INI_String] == null)
				{
					iniConfigSource.AddConfig(this.INI_String);
				}
				iniConfigSource.Configs[this.INI_String].Set("NeverShowAgain", value);
				iniConfigSource.Save(this.string_3);
				this.vmethod_0("NeverShowAgain");
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060066AC RID: 26284 RVA: 0x003867C4 File Offset: 0x003849C4
		// (remove) Token: 0x060066AD RID: 26285 RVA: 0x003867FC File Offset: 0x003849FC
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x00386834 File Offset: 0x00384A34
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003A87 RID: 14983
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003A88 RID: 14984
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003A89 RID: 14985
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04003A8A RID: 14986
		private string string_3;

		// Token: 0x04003A8B RID: 14987
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
