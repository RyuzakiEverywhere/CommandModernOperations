using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Command_Core;
using Microsoft.VisualBasic;
using ns5;

namespace ns7
{
	// Token: 0x02000F41 RID: 3905
	internal sealed class Class2559
	{
		// Token: 0x06008BF1 RID: 35825 RVA: 0x0005386E File Offset: 0x00051A6E
		public Class2559()
		{
			this.string_0 = Class2413.smethod_1().Info.DirectoryPath + "\\Sound\\Music\\";
			this.vmethod_1(new MediaPlayer());
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x000538A0 File Offset: 0x00051AA0
		[CompilerGenerated]
		public MediaPlayer vmethod_0()
		{
			return this.mediaPlayer_0;
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x004B5F84 File Offset: 0x004B4184
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_1(MediaPlayer mediaPlayer_1)
		{
			EventHandler value = new EventHandler(this.method_4);
			MediaPlayer mediaPlayer = this.mediaPlayer_0;
			if (mediaPlayer != null)
			{
				mediaPlayer.MediaEnded -= value;
			}
			this.mediaPlayer_0 = mediaPlayer_1;
			mediaPlayer = this.mediaPlayer_0;
			if (mediaPlayer != null)
			{
				mediaPlayer.MediaEnded += value;
			}
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x000538A8 File Offset: 0x00051AA8
		public void method_0()
		{
			this.bool_0 = false;
			if (File.Exists(this.string_0 + "Title.mp3"))
			{
				this.method_2(this.string_0 + "Title.mp3");
			}
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x000538DE File Offset: 0x00051ADE
		public void method_1()
		{
			this.bool_0 = true;
			if (!Information.IsNothing(this.vmethod_0()))
			{
				this.vmethod_0().Stop();
			}
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x004B5FC8 File Offset: 0x004B41C8
		private void method_2(string string_1)
		{
			Class2559.Class2560 @class = new Class2559.Class2560();
			@class.class2559_0 = this;
			@class.string_0 = string_1;
			try
			{
				this.vmethod_0().Dispatcher.Invoke(new VB$AnonymousDelegate_0(@class.method_0), new object[0]);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200422", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x004B6058 File Offset: 0x004B4258
		private void method_3()
		{
			if (!this.bool_0)
			{
				List<string> list = Enumerable.ToList<string>(Directory.GetFiles(this.string_0));
				if (list.Count != 0)
				{
					Misc.smethod_18<string>(list);
					this.method_2(list[0]);
				}
			}
		}

		// Token: 0x06008BF8 RID: 35832 RVA: 0x000538FF File Offset: 0x00051AFF
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x04004BD7 RID: 19415
		private string string_0;

		// Token: 0x04004BD8 RID: 19416
		private bool bool_0;

		// Token: 0x04004BD9 RID: 19417
		[CompilerGenerated]
		[AccessedThroughProperty("MusicPlayer")]
		private MediaPlayer mediaPlayer_0;

		// Token: 0x02000F42 RID: 3906
		[CompilerGenerated]
		internal sealed class Class2560
		{
			// Token: 0x06008BFA RID: 35834 RVA: 0x00053907 File Offset: 0x00051B07
			internal void method_0()
			{
				this.class2559_0.vmethod_0().Open(new Uri(this.string_0));
				this.class2559_0.vmethod_0().Play();
			}

			// Token: 0x04004BDA RID: 19418
			public string string_0;

			// Token: 0x04004BDB RID: 19419
			public Class2559 class2559_0;
		}
	}
}
