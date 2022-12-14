using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Command;
using Command_Core;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns3;

namespace ns7
{
	// Token: 0x02000F3B RID: 3899
	[StandardModule]
	internal sealed class Class2557
	{
		// Token: 0x06008BC8 RID: 35784 RVA: 0x00053796 File Offset: 0x00051996
		// Note: this type is marked as 'beforefieldinit'.
		static Class2557()
		{
			Class2557.smethod_1(new Timer());
		}

		// Token: 0x06008BC9 RID: 35785 RVA: 0x000537AC File Offset: 0x000519AC
		[CompilerGenerated]
		private static Timer smethod_0()
		{
			return Class2557.timer_0;
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x004B4D98 File Offset: 0x004B2F98
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_1(Timer timer_1)
		{
			EventHandler value = new EventHandler(Class2557.smethod_6);
			Timer timer = Class2557.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			Class2557.timer_0 = timer_1;
			timer = Class2557.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x004B4DD8 File Offset: 0x004B2FD8
		public static void smethod_2()
		{
			PrivateMethods.smethod_0(new PrivateMethods.Delegate58(Class2557.smethod_3));
			PrivateMethods.smethod_2(new PrivateMethods.Delegate60(Class2557.smethod_5));
			PrivateMethods.smethod_1(new PrivateMethods.Delegate59(Class2557.smethod_4));
			Class2557.smethod_0().Interval = 100;
			Class2557.smethod_0().Start();
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x004B4E30 File Offset: 0x004B3030
		private static void smethod_3(string string_0, int int_0, bool bool_0, ref string string_1)
		{
			if (!bool_0)
			{
				bool flag;
				if (flag = (Client.smethod_0().method_0() == Class279.Enum68.const_1))
				{
					Client.smethod_0().method_4();
				}
				Enum11 buttons;
				switch (int_0)
				{
				case 1:
					buttons = Enum11.const_2;
					break;
				case 2:
					buttons = Enum11.const_5;
					break;
				case 3:
					buttons = Enum11.const_4;
					break;
				case 4:
					buttons = Enum11.const_3;
					break;
				case 5:
					buttons = Enum11.const_6;
					break;
				default:
					buttons = Enum11.const_0;
					break;
				}
				string_1 = DarkMessageBox.smethod_0(string_0, "Incoming message", buttons).ToString();
				if (flag)
				{
					Client.smethod_0().method_3();
				}
			}
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x004B4EB8 File Offset: 0x004B30B8
		private static void smethod_4(string string_0, ref string string_1)
		{
			bool flag = Client.smethod_0().method_0() == Class279.Enum68.const_1;
			if (flag)
			{
				Client.smethod_0().method_4();
			}
			string_1 = Interaction.InputBox(string_0, "", "", -1, -1).ToString();
			if (flag)
			{
				Client.smethod_0().method_3();
			}
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x000537B3 File Offset: 0x000519B3
		private static void smethod_5(string string_0, bool bool_0, int int_0)
		{
			Class2557.concurrentQueue_0.Enqueue(new Tuple<string, bool, int>(string_0, bool_0, int_0));
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x004B4F04 File Offset: 0x004B3104
		private static void smethod_6(object sender, EventArgs e)
		{
			if (Class2557.concurrentQueue_0.Count > 0 && !Client.videoWindow_0.bool_0)
			{
				Tuple<string, bool, int> tuple;
				Class2557.concurrentQueue_0.TryDequeue(out tuple);
				if (!Information.IsNothing(tuple))
				{
					try
					{
						Client.videoWindow_0.tuple_0 = tuple;
						Client.videoWindow_0.Show();
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200418", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
			}
		}

		// Token: 0x04004BD1 RID: 19409
		private static ConcurrentQueue<Tuple<string, bool, int>> concurrentQueue_0 = new ConcurrentQueue<Tuple<string, bool, int>>();

		// Token: 0x04004BD2 RID: 19410
		[AccessedThroughProperty("TheTimer")]
		[CompilerGenerated]
		private static Timer timer_0;
	}
}
