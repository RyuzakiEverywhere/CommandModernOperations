using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Command_Core;
using DarkUI.Collections;
using Microsoft.VisualBasic.CompilerServices;
using ns13;
using ns14;
using ns3;
using ns5;
using ns8;

namespace Command.Tacview
{
	// Token: 0x02000D69 RID: 3433
	[StandardModule]
	internal sealed class TacviewServer
	{
		// Token: 0x06005A05 RID: 23045 RVA: 0x0003A3CE File Offset: 0x000385CE
		[CompilerGenerated]
		public static ObservableList<TacviewClient> smethod_0()
		{
			return TacviewServer.observableList_0;
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x00316A9C File Offset: 0x00314C9C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static void smethod_1(ObservableList<TacviewClient> observableList_1)
		{
			EventHandler<EventArgs5<TacviewClient>> eventHandler_ = new EventHandler<EventArgs5<TacviewClient>>(TacviewServer.smethod_8);
			EventHandler<EventArgs5<TacviewClient>> eventHandler_2 = new EventHandler<EventArgs5<TacviewClient>>(TacviewServer.smethod_9);
			ObservableList<TacviewClient> observableList = TacviewServer.observableList_0;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
				observableList.method_3(eventHandler_2);
			}
			TacviewServer.observableList_0 = observableList_1;
			observableList = TacviewServer.observableList_0;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
				observableList.method_2(eventHandler_2);
			}
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x00316AF8 File Offset: 0x00314CF8
		static TacviewServer()
		{
			TacviewServer.smethod_1(new ObservableList<TacviewClient>());
			TacviewServer.class425_0 = new Class425(IEventExporter.Enum141.const_0);
			Class429.smethod_20(ref Class428.ieventExporter_0, TacviewServer.class425_0);
			TacviewServer.class425_0.method_5(new Class425.Delegate57(TacviewServer.smethod_2));
			TacviewServer.class425_0.imethod_7();
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x00316B58 File Offset: 0x00314D58
		public static void smethod_2(List<Tuple<string, IEventExporter.EventExportNotification>> list_0)
		{
			try
			{
				foreach (TacviewClient tacviewClient in TacviewServer.smethod_0())
				{
					tacviewClient.concurrentQueue_0.Enqueue(list_0);
				}
			}
			finally
			{
				List<TacviewClient>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x00316BB0 File Offset: 0x00314DB0
		public static Process smethod_3(string string_0, string string_1, IntPtr intptr_0)
		{
			new Stopwatch().Start();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.StartInfo.Arguments = string_1;
			process.Start();
			return process;
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x00316BFC File Offset: 0x00314DFC
		public static void smethod_4()
		{
			TacviewServer.class425_0.method_4();
			int count = TacviewServer.smethod_0().Count;
			try
			{
				foreach (TacviewClient tacviewClient in Enumerable.ToList<TacviewClient>(TacviewServer.smethod_0()))
				{
					tacviewClient.method_0();
				}
			}
			finally
			{
				List<TacviewClient>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (count != 0)
			{
				TacviewServer.smethod_7();
			}
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x00316C70 File Offset: 0x00314E70
		public static void smethod_5()
		{
			if (Client.smethod_54() != null && Enumerable.Any<TacviewClient>(TacviewServer.smethod_0()))
			{
				ActiveUnit activeUnit;
				if (Client.smethod_54().bool_1)
				{
					activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(((Group)Client.smethod_54()).vmethod_141().Values, 0);
				}
				else if (Client.smethod_54().bool_0)
				{
					activeUnit = (ActiveUnit)Client.smethod_54();
				}
				else
				{
					if (!Client.smethod_54().method_14())
					{
						return;
					}
					activeUnit = ((Contact)Client.smethod_54()).activeUnit_0;
				}
				if (!TacviewServer.smethod_0()[0].bool_0)
				{
					TacviewServer.smethod_0()[0].method_6(activeUnit.string_0, (int)Math.Round((double)(2f * activeUnit.float_13)));
					TacviewServer.smethod_0()[0].bool_0 = true;
					return;
				}
				TacviewServer.smethod_0()[0].method_6(activeUnit.string_0, 0);
			}
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x00316D58 File Offset: 0x00314F58
		public static void smethod_6()
		{
			if (Client.smethod_54() != null && !Client.smethod_54().bool_1 && Client.smethod_54().bool_0 && ((ActiveUnit)Client.smethod_54()).vmethod_86().vmethod_3() != null)
			{
				TacviewServer.smethod_0()[0].method_7(Client.smethod_54().string_0, ((ActiveUnit)Client.smethod_54()).vmethod_86().vmethod_3().activeUnit_0.string_0);
			}
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x00316DD4 File Offset: 0x00314FD4
		public static void smethod_7()
		{
			if (!Class2420.smethod_0(Class570.class280_0.method_62()))
			{
				DarkMessageBox.smethod_2("It appears that the Tacview executable you have specified is invalid. Please use a valid executable. For assistance please contact WarfareSims or Raia Software.", "Invalid Tacview exe!", Enum11.const_0);
				return;
			}
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Class570.class280_0.method_62());
			if (versionInfo.FileMajorPart < 2 && versionInfo.FileMinorPart < 8)
			{
				DarkMessageBox.smethod_2("It appears that you are using an older version of Tacview. Please download & install at least version 1.8.0. For assistance please contact WarfareSims or Raia Software.", "Out-of-date Tacview version!", Enum11.const_0);
				return;
			}
			if (!Enumerable.Any<TacviewClient>(TacviewServer.smethod_0()))
			{
				TacviewClient.smethod_2();
			}
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x0003A3D5 File Offset: 0x000385D5
		private static void smethod_8(object sender, EventArgs5<TacviewClient> e)
		{
			TacviewServer.class425_0.bool_14 = true;
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x0003A3E2 File Offset: 0x000385E2
		private static void smethod_9(object sender, EventArgs5<TacviewClient> e)
		{
			if (TacviewServer.smethod_0().Count == 0)
			{
				TacviewServer.class425_0.bool_14 = false;
				TacviewServer.class425_0.method_4();
				return;
			}
			TacviewServer.class425_0.bool_14 = true;
		}

		// Token: 0x04003470 RID: 13424
		public static readonly Class425 class425_0;

		// Token: 0x04003471 RID: 13425
		[CompilerGenerated]
		[AccessedThroughProperty("Clients")]
		private static ObservableList<TacviewClient> observableList_0;

		// Token: 0x04003472 RID: 13426
		public static readonly object object_0 = RuntimeHelpers.GetObjectValue(new object());
	}
}
