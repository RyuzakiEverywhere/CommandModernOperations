using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns1
{
	// Token: 0x02000057 RID: 87
	internal sealed class Class53
	{
		// Token: 0x0600017C RID: 380 RVA: 0x00057D40 File Offset: 0x00055F40
		public static void smethod_0(Form form, Action function, Keys key, bool ctrl = false, bool shift = false, bool alt = false)
		{
			Class53.Class54 @class = new Class53.Class54();
			@class.keys_0 = key;
			@class.bool_0 = ctrl;
			@class.bool_1 = shift;
			@class.bool_2 = alt;
			@class.action_0 = function;
			form.KeyPreview = true;
			form.KeyDown += @class.method_0;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00003812 File Offset: 0x00001A12
		public static bool smethod_1(KeyEventArgs eventData, Keys key, bool ctrl = false, bool shift = false, bool alt = false)
		{
			return eventData.KeyCode == key && eventData.Control == ctrl && eventData.Shift == shift && eventData.Alt == alt;
		}

		// Token: 0x040000D2 RID: 210
		public static bool bool_0 = true;

		// Token: 0x02000058 RID: 88
		[CompilerGenerated]
		private sealed class Class54
		{
			// Token: 0x06000181 RID: 385 RVA: 0x00003843 File Offset: 0x00001A43
			internal void method_0(object sender, KeyEventArgs e)
			{
				if (Class53.smethod_1(e, this.keys_0, this.bool_0, this.bool_1, this.bool_2))
				{
					this.action_0();
				}
			}

			// Token: 0x040000D3 RID: 211
			public Keys keys_0;

			// Token: 0x040000D4 RID: 212
			public bool bool_0;

			// Token: 0x040000D5 RID: 213
			public bool bool_1;

			// Token: 0x040000D6 RID: 214
			public bool bool_2;

			// Token: 0x040000D7 RID: 215
			public Action action_0;
		}
	}
}
