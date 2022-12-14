using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Threading;
using Command.Tacview;
using Command_Core;
using Command_Core.Lua;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns13;
using ns14;
using ns21;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns9;
using WorldWind;

namespace Command
{
	// Token: 0x02000D6D RID: 3437
	[StandardModule]
	public sealed class Client
	{
		// Token: 0x06005A23 RID: 23075 RVA: 0x0003A431 File Offset: 0x00038631
		[CompilerGenerated]
		public static Class279 smethod_0()
		{
			return Client.class279_0;
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x0003A438 File Offset: 0x00038638
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static void smethod_1(Class279 class279_1)
		{
			Client.class279_0 = class279_1;
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x0003A440 File Offset: 0x00038640
		[CompilerGenerated]
		private static Scenario smethod_2()
		{
			return Client.scenario_0;
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0003A447 File Offset: 0x00038647
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_3(Scenario scenario_1)
		{
			Client.scenario_0 = scenario_1;
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x0003A44F File Offset: 0x0003864F
		[CompilerGenerated]
		private static Side smethod_4()
		{
			return Client.side_0;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x0003A456 File Offset: 0x00038656
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_5(Side side_1)
		{
			Client.side_0 = side_1;
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x0003A45E File Offset: 0x0003865E
		[CompilerGenerated]
		private static Timer smethod_6()
		{
			return Client.timer_0;
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00317F00 File Offset: 0x00316100
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_7(Timer timer_2)
		{
			EventHandler value = new EventHandler(Client.smethod_101);
			Timer timer = Client.timer_0;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			Client.timer_0 = timer_2;
			timer = Client.timer_0;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x0003A465 File Offset: 0x00038665
		[CompilerGenerated]
		private static Timer smethod_8()
		{
			return Client.timer_1;
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x00317F40 File Offset: 0x00316140
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_9(Timer timer_2)
		{
			EventHandler value = new EventHandler(Client.smethod_109);
			Timer timer = Client.timer_1;
			if (timer != null)
			{
				timer.Tick -= value;
			}
			Client.timer_1 = timer_2;
			timer = Client.timer_1;
			if (timer != null)
			{
				timer.Tick += value;
			}
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x0003A46C File Offset: 0x0003866C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_10(BackgroundWorker backgroundWorker_2)
		{
			Client.backgroundWorker_0 = backgroundWorker_2;
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x0003A474 File Offset: 0x00038674
		[CompilerGenerated]
		private static BackgroundWorker smethod_11()
		{
			return Client.backgroundWorker_1;
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x00317F80 File Offset: 0x00316180
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		private static void smethod_12(BackgroundWorker backgroundWorker_2)
		{
			DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(Client.smethod_78);
			RunWorkerCompletedEventHandler runWorkerCompletedEventHandler = new RunWorkerCompletedEventHandler(Client.smethod_80);
			BackgroundWorker backgroundWorker = Client.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted -= runWorkerCompletedEventHandler;
			}
			Client.backgroundWorker_1 = backgroundWorker_2;
			backgroundWorker = Client.backgroundWorker_1;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += doWorkEventHandler;
				backgroundWorker.RunWorkerCompleted += runWorkerCompletedEventHandler;
			}
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x00317FDC File Offset: 0x003161DC
		[CompilerGenerated]
		public static void smethod_13(Client.Delegate77 delegate77_1)
		{
			Client.Delegate77 @delegate = Client.delegate77_0;
			Client.Delegate77 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate77 value = (Client.Delegate77)Delegate.Combine(delegate2, delegate77_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate77>(ref Client.delegate77_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x00318010 File Offset: 0x00316210
		[CompilerGenerated]
		public static void smethod_14(Client.Delegate78 delegate78_1)
		{
			Client.Delegate78 @delegate = Client.delegate78_0;
			Client.Delegate78 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate78 value = (Client.Delegate78)Delegate.Combine(delegate2, delegate78_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate78>(ref Client.delegate78_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x00318044 File Offset: 0x00316244
		[CompilerGenerated]
		public static void smethod_15(Client.Delegate78 delegate78_1)
		{
			Client.Delegate78 @delegate = Client.delegate78_0;
			Client.Delegate78 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate78 value = (Client.Delegate78)Delegate.Remove(delegate2, delegate78_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate78>(ref Client.delegate78_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x00318078 File Offset: 0x00316278
		[CompilerGenerated]
		public static void smethod_16(Client.Delegate80 delegate80_1)
		{
			Client.Delegate80 @delegate = Client.delegate80_0;
			Client.Delegate80 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate80 value = (Client.Delegate80)Delegate.Combine(delegate2, delegate80_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate80>(ref Client.delegate80_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x003180AC File Offset: 0x003162AC
		[CompilerGenerated]
		public static void smethod_17(Client.Delegate80 delegate80_1)
		{
			Client.Delegate80 @delegate = Client.delegate80_0;
			Client.Delegate80 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate80 value = (Client.Delegate80)Delegate.Remove(delegate2, delegate80_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate80>(ref Client.delegate80_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x003180E0 File Offset: 0x003162E0
		[CompilerGenerated]
		public static void smethod_18(Client.Delegate81 delegate81_1)
		{
			Client.Delegate81 @delegate = Client.delegate81_0;
			Client.Delegate81 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate81 value = (Client.Delegate81)Delegate.Combine(delegate2, delegate81_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate81>(ref Client.delegate81_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00318114 File Offset: 0x00316314
		[CompilerGenerated]
		public static void smethod_19(Client.Delegate81 delegate81_1)
		{
			Client.Delegate81 @delegate = Client.delegate81_0;
			Client.Delegate81 delegate2;
			do
			{
				delegate2 = @delegate;
				Client.Delegate81 value = (Client.Delegate81)Delegate.Remove(delegate2, delegate81_1);
				@delegate = Interlocked.CompareExchange<Client.Delegate81>(ref Client.delegate81_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x0003A47B File Offset: 0x0003867B
		public static bool smethod_20()
		{
			return Client.bool_7;
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x0003A482 File Offset: 0x00038682
		public static void smethod_21(bool bool_9)
		{
			Client.bool_7 = bool_9;
			if (bool_9 && Client.startGameMenuWindow_0 != null && Client.startGameMenuWindow_0.IsVisible)
			{
				Client.startGameMenuWindow_0.method_0();
			}
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x0003A4AA File Offset: 0x000386AA
		public static FlightPlanEditorTargets smethod_22()
		{
			if (Information.IsNothing(Client.flightPlanEditorTargets_0))
			{
				Client.flightPlanEditorTargets_0 = new FlightPlanEditorTargets();
			}
			return Client.flightPlanEditorTargets_0;
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x0003A4C7 File Offset: 0x000386C7
		public static FlightPlanEditorTargetsArea smethod_23()
		{
			if (Information.IsNothing(Client.flightPlanEditorTargetsArea_0))
			{
				Client.flightPlanEditorTargetsArea_0 = new FlightPlanEditorTargetsArea();
			}
			return Client.flightPlanEditorTargetsArea_0;
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x0003A4E4 File Offset: 0x000386E4
		public static FlightPlanEditorTargetsPreliminary smethod_24()
		{
			if (Information.IsNothing(Client.flightPlanEditorTargetsPreliminary_0))
			{
				Client.flightPlanEditorTargetsPreliminary_0 = new FlightPlanEditorTargetsPreliminary();
			}
			return Client.flightPlanEditorTargetsPreliminary_0;
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x0003A501 File Offset: 0x00038701
		public static FlightPlanEditorWeaponRoute smethod_25()
		{
			if (Information.IsNothing(Client.flightPlanEditorWeaponRoute_0))
			{
				Client.flightPlanEditorWeaponRoute_0 = new FlightPlanEditorWeaponRoute();
			}
			return Client.flightPlanEditorWeaponRoute_0;
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x0003A51E File Offset: 0x0003871E
		public static AttackTarget smethod_26()
		{
			if (Information.IsNothing(Client.attackTarget_0))
			{
				Client.attackTarget_0 = new AttackTarget();
			}
			return Client.attackTarget_0;
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x0003A53B File Offset: 0x0003873B
		public static void smethod_27(AttackTarget attackTarget_1)
		{
			Client.attackTarget_0 = attackTarget_1;
		}

		// Token: 0x06005A3F RID: 23103 RVA: 0x0003A543 File Offset: 0x00038743
		public static LuaSandBox smethod_28()
		{
			if (Information.IsNothing(Client.luaSandBox_0))
			{
				Client.luaSandBox_0 = new LuaSandBox();
			}
			return Client.luaSandBox_0;
		}

		// Token: 0x06005A40 RID: 23104 RVA: 0x00318148 File Offset: 0x00316348
		internal static Color smethod_29(Misc.PostureStance postureStance_0)
		{
			Color result;
			switch (postureStance_0)
			{
			case Misc.PostureStance.Neutral:
				result = Client.color_2;
				break;
			case Misc.PostureStance.Friendly:
				result = Client.color_0;
				break;
			case Misc.PostureStance.Unfriendly:
				result = Client.color_3;
				break;
			case Misc.PostureStance.Hostile:
				result = Client.color_4;
				break;
			case Misc.PostureStance.Unknown:
				result = Client.color_1;
				break;
			}
			return result;
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x0003A560 File Offset: 0x00038760
		public static MissionEditor smethod_30()
		{
			if (Information.IsNothing(Client.missionEditor_0))
			{
				Client.missionEditor_0 = new MissionEditor();
			}
			return Client.missionEditor_0;
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x0003A57D File Offset: 0x0003877D
		public static AirTaskingOrder smethod_31()
		{
			if (Information.IsNothing(Client.airTaskingOrder_0))
			{
				Client.airTaskingOrder_0 = new AirTaskingOrder();
			}
			return Client.airTaskingOrder_0;
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x0003A59A File Offset: 0x0003879A
		public static FlightPlanEditor smethod_32()
		{
			if (Information.IsNothing(Client.flightPlanEditor_0))
			{
				Client.flightPlanEditor_0 = new FlightPlanEditor();
			}
			return Client.flightPlanEditor_0;
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x0003A5B7 File Offset: 0x000387B7
		public static WeaponsWindow smethod_33()
		{
			return Client.lazy_0.Value;
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x0031819C File Offset: 0x0031639C
		public static void smethod_34()
		{
			try
			{
				PlatformComponent.smethod_0(new PlatformComponent.Delegate46(Client.smethod_72));
				ActiveUnit_Damage.smethod_0(new ActiveUnit_Damage.Delegate16(Client.smethod_73));
				Scenario.smethod_2(new Scenario.CurrentSideChangedEventHandler(Client.smethod_70));
				Scenario.smethod_3(new Scenario.SidesChangedEventHandler(Client.smethod_71));
				Scenario.smethod_15(new Scenario.ScenCompletedEventHandler(Client.smethod_65));
				Scenario.smethod_1(new Scenario.CurrentScenarioChangedEventHandler(Client.smethod_35));
				Side.smethod_0(new Side.Delegate48(Client.smethod_108));
				Class263.smethod_2(new Class263.Delegate27(Client.smethod_107));
				GameGeneral.smethod_0(new GameGeneral.Delegate62(Client.smethod_36));
				if (Class570.class280_0.method_50())
				{
					string text = "Initialization started.";
					GameGeneral.smethod_26(ref text);
				}
				Client.smethod_7(new Timer());
				Client.smethod_6().Interval = 1000;
				Client.smethod_6().Start();
				Class2413.smethod_2().method_41().bitmap_2 = null;
				if (!Directory.Exists(Client.string_4))
				{
					Directory.CreateDirectory(Client.string_4);
				}
				if (!Directory.Exists(GameGeneral.string_6))
				{
					Directory.CreateDirectory(GameGeneral.string_6);
				}
				GameGeneral.smethod_15(Class2472.hashSet_0.Contains(Class2472.Enum202.const_1));
				Class2556.smethod_0(Client.smethod_38());
				Class2564.smethod_1();
				if (!Directory.Exists(GameGeneral.string_10))
				{
					Directory.CreateDirectory(GameGeneral.string_10);
				}
				Class2561.smethod_0();
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully initialized Sim Core.";
					GameGeneral.smethod_26(ref text);
				}
				if (Class2473.smethod_2() && Class570.class280_0.method_58())
				{
					Class2473.smethod_0();
					if (Class570.class280_0.method_50())
					{
						string text = "Successfully switched to High Performance power plan.";
						GameGeneral.smethod_26(ref text);
					}
				}
				Class2557.smethod_2();
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully loaded Lua UI Handlers.";
					GameGeneral.smethod_26(ref text);
				}
				Client.smethod_1(new Class279());
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully created new game.";
					GameGeneral.smethod_26(ref text);
				}
				string text2 = Class570.string_0;
				if (Information.IsNothing(text2))
				{
					text2 = DBOps.smethod_12(1);
					Class570.string_0 = text2;
				}
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully set database hash value.";
					GameGeneral.smethod_26(ref text);
				}
				if (Versioned.IsNumeric(text2))
				{
					text2 = DBOps.smethod_12(Conversions.ToInteger(text2));
				}
				try
				{
					Client.smethod_47(new Scenario(text2), false);
				}
				catch (Exception ex)
				{
					DarkMessageBox.smethod_2("Error: " + ex.Message + "\r\n\r\nAborting...", "Error", Enum11.const_0);
					try
					{
						Client.smethod_66();
						Environment.Exit(0);
					}
					catch (Exception ex2)
					{
					}
				}
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully completed Set Current Scenario.";
					GameGeneral.smethod_26(ref text);
				}
				Client.smethod_37();
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully initialized Lua.";
					GameGeneral.smethod_26(ref text);
				}
				Client.double_2 = 20.0;
				Client.smethod_69();
				Client.smethod_76();
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully created scenario.";
					GameGeneral.smethod_26(ref text);
				}
				Client.smethod_12(new BackgroundWorker());
				Client.smethod_11().WorkerSupportsCancellation = true;
				Client.smethod_9(new Timer());
				Client.smethod_8().Interval = 60000;
				Client.smethod_8().Start();
				Class2413.smethod_2().method_66().Show();
				Class2413.smethod_2().method_66().Hide();
				if (Class570.class280_0.method_50())
				{
					string text = "Initialization completed.";
					GameGeneral.smethod_26(ref text);
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200576", ex3.Message);
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x0003A5C3 File Offset: 0x000387C3
		private static void smethod_35(Scenario scenario_1)
		{
			Client.smethod_47(scenario_1, false);
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x0003A5CC File Offset: 0x000387CC
		private static void smethod_36(string string_7)
		{
			DarkMessageBox.smethod_0(string_7, string.Empty, Enum11.const_0);
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x0031857C File Offset: 0x0031677C
		private static void smethod_37()
		{
			try
			{
				Client.smethod_46().method_10();
			}
			catch (Exception ex)
			{
				DarkMessageBox.smethod_2("Failed to load Lua! Error: " + ex.Message, "Error", Enum11.const_0);
				Environment.Exit(0);
			}
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x0003A5DB File Offset: 0x000387DB
		public static bool smethod_38()
		{
			return Client.bool_4;
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x0003A5E2 File Offset: 0x000387E2
		public static void smethod_39(bool bool_9)
		{
			Client.bool_4 = bool_9;
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x0003A5EA File Offset: 0x000387EA
		public static DBRecord smethod_40()
		{
			return Client.dbrecord_0;
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x003185D8 File Offset: 0x003167D8
		public static void smethod_41(DBRecord dbrecord_1)
		{
			bool flag = dbrecord_1 != Client.dbrecord_0;
			DBRecord dbrecord_2 = Client.dbrecord_0;
			Client.dbrecord_0 = dbrecord_1;
			if (flag)
			{
				Client.smethod_68(dbrecord_2);
			}
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x0003A5F1 File Offset: 0x000387F1
		internal static Unit smethod_42()
		{
			return Client.unit_0;
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00318604 File Offset: 0x00316804
		internal static void smethod_43(Unit unit_1)
		{
			bool flag;
			if (Information.IsNothing(Client.unit_0))
			{
				flag = !Information.IsNothing(unit_1);
			}
			else
			{
				flag = (Client.unit_0 != unit_1);
			}
			if (flag && !Information.IsNothing(Client.unit_0) && Client.unit_0.method_14() && ((Contact)Client.unit_0).bool_16)
			{
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
			Client.unit_0 = unit_1;
			if (flag)
			{
				Class2413.smethod_2().method_41().method_164();
			}
			if (flag && !Information.IsNothing(Client.unit_0) && Client.unit_0.method_14() && ((Contact)Client.unit_0).bool_16)
			{
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
			}
			if (flag)
			{
				Class2413.smethod_2().method_41().method_85();
			}
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x0003A5F8 File Offset: 0x000387F8
		internal static bool smethod_44()
		{
			return Client.bool_2;
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x003186E8 File Offset: 0x003168E8
		internal static void smethod_45(bool bool_9)
		{
			Client.bool_2 = bool_9;
			if (bool_9)
			{
				Class2413.smethod_2().method_41().vmethod_224().Checked = true;
				Class2413.smethod_2().method_41().vmethod_224().Text = "Stop rec";
				Class2413.smethod_2().method_41().vmethod_224().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\Stop_16.gif");
				return;
			}
			Class2413.smethod_2().method_41().vmethod_224().Checked = false;
			Class2413.smethod_2().method_41().vmethod_224().Text = "Record";
			Class2413.smethod_2().method_41().vmethod_224().Image = Image.FromFile(Application.StartupPath + "\\Symbols\\Menu\\record_button_16.png");
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x0003A5FF File Offset: 0x000387FF
		public static Scenario smethod_46()
		{
			return Client.smethod_2();
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x003187AC File Offset: 0x003169AC
		public static void smethod_47(Scenario scenario_1, bool bool_9)
		{
			try
			{
				Scenario scenario = Client.smethod_2();
				ConcurrentDictionary<int, Weapon> cache_Weapons;
				if (scenario != null)
				{
					cache_Weapons = scenario.Cache_Weapons;
				}
				bool flag = scenario_1 != Client.smethod_2();
				Client.smethod_3(scenario_1);
				bool bool_10;
				bool flag2;
				if (Client.smethod_50() != null)
				{
					bool_10 = Client.smethod_52().method_1();
					flag2 = flag;
					if (!flag)
					{
						goto IL_49;
					}
				}
				else
				{
					flag2 = flag;
					if (!flag)
					{
						goto IL_49;
					}
				}
				if (bool_9)
				{
					Client.smethod_2().Cache_Weapons = cache_Weapons;
				}
				IL_49:
				if (flag2)
				{
					Dispatcher.CurrentDispatcher.InvokeAsync((Client._Closure$__.$I200-0 == null) ? (Client._Closure$__.$I200-0 = new Action(Client._Closure$__.$I.method_0)) : Client._Closure$__.$I200-0);
					if (scenario != null)
					{
						GameGeneral.smethod_12(ref scenario, true);
					}
					Client.unitSensors_0 = null;
					Client.damageControlWindow_0 = null;
					Client.videoWindow_0 = null;
					Client.smethod_10(null);
					Client.newMission_0 = null;
					Client.dictionary_5 = null;
					Client.unitSensors_0 = new UnitSensors();
					Client.damageControlWindow_0 = new DamageControlWindow();
					Client.videoWindow_0 = new VideoWindow();
					Client.smethod_10(new BackgroundWorker());
					Client.newMission_0 = new NewMission();
					Client.dictionary_5 = new Dictionary<LoggedMessage.MessageType, NewMessageForm>();
					Client.double_2 = 20000.0;
					Client.smethod_56(null, true);
					if (Client.list_0 != null)
					{
						try
						{
							foreach (Class1870 @class in Client.list_0)
							{
								Class2413.smethod_2().method_41().vmethod_796().method_4().method_5().vmethod_20(@class.Name);
							}
						}
						finally
						{
							List<Class1870>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						Client.list_0.Clear();
					}
					Client.list_0 = null;
					Client.queue_0 = null;
					Client.list_0 = new List<Class1870>();
					Client.queue_0 = new Queue<string>();
					Class434.smethod_0(scenario);
					scenario = null;
					DBOps.DBFileCheckResult dbfileCheckResult_;
					Client.smethod_41(DBOps.smethod_10(Client.smethod_2().method_7(), ref dbfileCheckResult_, true, true));
					if (Client.smethod_40() == null)
					{
						throw new Exception(DBOps.smethod_7(dbfileCheckResult_));
					}
					Class279.Enum67 enum67_ = Client.smethod_0().method_1();
					Client.smethod_1(new Class279());
					Client.smethod_0().method_2(enum67_);
					if (Client.bool_0)
					{
						Client.smethod_46().method_52(Scenario.enumTimeCompression.OneSec);
					}
					if (Client.bool_0)
					{
						Class2413.smethod_2().method_41().method_353();
					}
					if (Client.smethod_46() != null)
					{
						if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
						{
							Client.smethod_48(Client.smethod_46());
						}
						if (Information.IsNothing(Client.smethod_2().method_54()))
						{
							if (Enumerable.Any<Side>(Client.smethod_2().method_44()))
							{
								Client.smethod_51(Client.smethod_2().method_44()[0]);
							}
							else
							{
								Client.smethod_51(null);
							}
						}
						else
						{
							Side side_ = Client.smethod_2().method_54();
							if (bool_9)
							{
								Client.smethod_52().method_2(bool_10);
							}
							Client.smethod_51(side_);
						}
						if (GameGeneral.bool_0)
						{
							if (bool_9)
							{
								if (TacviewServer.smethod_0().Count > 0)
								{
									TacviewServer.smethod_0()[0].method_0();
								}
							}
							else
							{
								TacviewServer.smethod_4();
							}
						}
						if (Client.smethod_50() != null && !bool_9)
						{
							if (Client.smethod_50().double_0 != 0.0)
							{
								Class2413.smethod_2().method_41().method_153((int)Math.Round(Client.smethod_50().double_0));
							}
							if (Client.smethod_50().method_26() != null)
							{
								Class2413.smethod_2().method_41().method_161(true, Client.smethod_50().method_26());
							}
						}
						else
						{
							Client.bool_1 = true;
						}
						if (Class2413.smethod_2().method_41().method_97() != null)
						{
							Class2413.smethod_2().method_41().method_97().method_2(Client.smethod_46(), Client.smethod_50(), Client.smethod_54(), false);
						}
						try
						{
							if (Client.bool_0)
							{
								Class2413.smethod_2().method_41().method_234();
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200359", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						Client.Delegate77 @delegate = Client.delegate77_0;
						if (@delegate != null)
						{
							@delegate();
						}
						if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
						{
							Client.smethod_0().method_4();
						}
						Client.smethod_46().method_11(Client.smethod_28());
						Client.smethod_46().method_10().RefreshStats(Client.smethod_46());
						Client.smethod_46().method_15();
						if (!bool_9)
						{
							Scenario scenario_2 = Client.smethod_46();
							bool bool_11 = false;
							string text = "";
							Client.smethod_49(scenario_2, bool_11, ref text);
						}
						Task.Factory.StartNew((Client._Closure$__.$I200-1 == null) ? (Client._Closure$__.$I200-1 = new Action(Client._Closure$__.$I.method_1)) : Client._Closure$__.$I200-1);
						if (bool_9)
						{
							try
							{
								foreach (object obj in Class2413.smethod_1().OpenForms)
								{
									Form form = (Form)obj;
									if (form is Interface66 && form.Visible)
									{
										((Interface66)form).imethod_0();
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200516", ex2.Message);
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00318CF0 File Offset: 0x00316EF0
		private static void smethod_48(Scenario scenario_1)
		{
			int count = scenario_1.vmethod_0().Count;
			List<ActiveUnit> list = scenario_1.method_42();
			if (count != 0)
			{
				try
				{
					for (int i = count - 1; i >= 0; i += -1)
					{
						ActiveUnit activeUnit = list[i];
						if (!Information.IsNothing(activeUnit) && activeUnit.int_5 != 0 && activeUnit.int_5 != 100 && GameGeneral.smethod_5().Next(0, 101) > activeUnit.int_5)
						{
							scenario_1.method_66(activeUnit.string_0, true);
						}
					}
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00318D94 File Offset: 0x00316F94
		public static void smethod_49(Scenario scenario_1, bool bool_9, ref string string_7)
		{
			try
			{
				foreach (Side side in scenario_1.method_44())
				{
					try
					{
						foreach (Zone zone in side.list_7)
						{
							string text = "";
							if (!ActiveUnit_Navigator.smethod_7(ref zone.list_0, ref text, side, scenario_1, "No-Navigation Zone '" + zone.string_2 + "'"))
							{
								if (bool_9)
								{
									string_7 = string_7 + "    " + text + "\r\n";
								}
								else
								{
									DarkMessageBox.smethod_1(text + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
								}
							}
						}
					}
					finally
					{
						List<NoNavZone>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					try
					{
						foreach (Zone zone2 in side.list_6)
						{
							string text2 = "";
							if (!ActiveUnit_Navigator.smethod_7(ref zone2.list_0, ref text2, side, scenario_1, "Exclusion Zone '" + zone2.string_2 + "'"))
							{
								if (bool_9)
								{
									string_7 = string_7 + "    " + text2 + "\r\n";
								}
								else
								{
									DarkMessageBox.smethod_1(text2 + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
								}
							}
						}
					}
					finally
					{
						List<ExclusionZone>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					try
					{
						foreach (Mission mission in side.method_35())
						{
							string text3 = "";
							if (mission._MissionClass_0 == Mission._MissionClass.Patrol)
							{
								if (!ActiveUnit_Navigator.smethod_7(ref ((Class343)mission).list_5, ref text3, side, scenario_1, "patrol mission '" + mission.Name + "'"))
								{
									if (bool_9)
									{
										string_7 = string_7 + "    " + text3 + "\r\n";
									}
									else
									{
										DarkMessageBox.smethod_1(text3 + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
									}
								}
							}
							else if (mission._MissionClass_0 == Mission._MissionClass.Support)
							{
								if (!ActiveUnit_Navigator.smethod_7(ref ((Class344)mission).list_5, ref text3, side, scenario_1, "support mission '" + mission.Name + "'"))
								{
									if (bool_9)
									{
										string_7 = string_7 + "    " + text3 + "\r\n";
									}
									else
									{
										DarkMessageBox.smethod_1(text3 + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
									}
								}
							}
							else if (mission._MissionClass_0 == Mission._MissionClass.Mining)
							{
								if (!ActiveUnit_Navigator.smethod_7(ref ((Class340)mission).list_5, ref text3, side, scenario_1, "mining mission '" + mission.Name + "'"))
								{
									if (bool_9)
									{
										string_7 = string_7 + "    " + text3 + "\r\n";
									}
									else
									{
										DarkMessageBox.smethod_1(text3 + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
									}
								}
							}
							else if (mission._MissionClass_0 == Mission._MissionClass.MineClearing && !ActiveUnit_Navigator.smethod_7(ref ((Class341)mission).list_5, ref text3, side, scenario_1, "mine clearing mission '" + mission.Name + "'"))
							{
								if (bool_9)
								{
									string_7 = string_7 + "    " + text3 + "\r\n";
								}
								else
								{
									DarkMessageBox.smethod_1(text3 + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
								}
							}
						}
					}
					finally
					{
						IEnumerator<Mission> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				try
				{
					foreach (EventTrigger eventTrigger in scenario_1.vmethod_4().Values)
					{
						EventTrigger.EventTriggerType eventTriggerType_ = eventTrigger.eventTriggerType_0;
						if (eventTriggerType_ != EventTrigger.EventTriggerType.UnitRemainsInArea)
						{
							if (eventTriggerType_ == EventTrigger.EventTriggerType.UnitEntersArea)
							{
								string text4 = "";
								if (!ActiveUnit_Navigator.smethod_7(ref ((Class332)eventTrigger).list_0, ref text4, null, scenario_1, "Unit Remains In Area trigger '" + eventTrigger.string_2 + "'"))
								{
									if (bool_9)
									{
										string_7 = string_7 + "    " + text4 + "\r\n";
									}
									else
									{
										DarkMessageBox.smethod_1(text4 + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
									}
								}
							}
						}
						else
						{
							string text5 = "";
							if (!ActiveUnit_Navigator.smethod_7(ref ((Class333)eventTrigger).list_0, ref text5, null, scenario_1, "Unit Remains In Area trigger '" + eventTrigger.string_2 + "'"))
							{
								if (bool_9)
								{
									string_7 = string_7 + "    " + text5 + "\r\n";
								}
								else
								{
									DarkMessageBox.smethod_1(text5 + " Contact the scenario designer to have the problem rectified.", "Warning", Enum11.const_0);
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator<EventTrigger> enumerator4;
					if (enumerator4 != null)
					{
						enumerator4.Dispose();
					}
				}
				try
				{
					foreach (EventAction eventAction in scenario_1.vmethod_8().Values)
					{
						EventAction.EventActionType eventActionType_ = eventAction.eventActionType_0;
						if (eventActionType_ == EventAction.EventActionType.TeleportInArea)
						{
							string text6 = "";
							if (!ActiveUnit_Navigator.smethod_7(ref ((EventAction_TeleportInArea)eventAction).list_0, ref text6, null, scenario_1, "Teleport In Area action '" + eventAction.string_2 + "'"))
							{
								if (bool_9)
								{
									string_7 = string_7 + "    " + text6 + "\r\n";
								}
								else
								{
									DarkMessageBox.smethod_0(text6 + " Contact the scenario designer to have the problem rectified.", "", Enum11.const_0);
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator<EventAction> enumerator5;
					if (enumerator5 != null)
					{
						enumerator5.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101269", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x0003A606 File Offset: 0x00038806
		public static Side smethod_50()
		{
			return Client.smethod_4();
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00319384 File Offset: 0x00317584
		public static void smethod_51(Side side_1)
		{
			Side side = Client.smethod_4();
			Client.smethod_5(side_1);
			if (side != side_1)
			{
				Client.smethod_56(null, true);
				if (side != null)
				{
					side.bool_11 = false;
				}
				if (side_1 != null)
				{
					side_1.bool_11 = true;
					if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
					{
						side_1.method_40(Client.smethod_46());
					}
					if (!Class570.class280_0.bool_19)
					{
						Client.smethod_53(side_1.method_42());
					}
					try
					{
						Class2413.smethod_2().method_41().method_314();
					}
					catch (Exception ex)
					{
					}
					Client.smethod_46().method_59("Switched side to: " + side_1.method_51(), "Switched side", LoggedMessage.MessageType.UI, 0, null, null, default(Geopoint_Struct));
				}
				Client.smethod_62(Client.Enum197.const_0);
				Client.Delegate82 @delegate = Client.delegate82_0;
				if (@delegate != null)
				{
					@delegate();
				}
			}
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x00319464 File Offset: 0x00317664
		public static Class285 smethod_52()
		{
			Class285 result;
			if (Class570.class280_0.bool_19)
			{
				result = Class570.class280_0.method_64();
			}
			else
			{
				if (Client.class285_0 == null)
				{
					Client.class285_0 = Class285.smethod_2();
				}
				result = Client.class285_0;
			}
			return result;
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x003194A4 File Offset: 0x003176A4
		public static void smethod_53(Class285 class285_1)
		{
			Client.class285_0 = class285_1;
			try
			{
				Class2413.smethod_2().method_41().method_307();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x003194E8 File Offset: 0x003176E8
		public static Unit smethod_54()
		{
			Unit result;
			try
			{
				if (string.IsNullOrEmpty(Client.string_6))
				{
					result = null;
				}
				else if (Client.smethod_46().vmethod_0().TryGetValue(Client.string_6, ref Client.activeUnit_0))
				{
					result = Client.activeUnit_0;
				}
				else
				{
					if (Client.smethod_50() != null)
					{
						int num = Client.smethod_50().method_11().Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								Contact contact = Client.smethod_50().method_44()[i];
								if (Operators.CompareString(contact.string_0, Client.string_6, false) == 0)
								{
									return contact;
								}
							}
							catch (Exception ex)
							{
							}
						}
						int num2 = Client.smethod_50().method_46().Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							try
							{
								Contact contact = Client.smethod_50().method_46()[j];
								if (Operators.CompareString(contact.string_0, Client.string_6, false) == 0)
								{
									return contact;
								}
							}
							catch (Exception ex2)
							{
							}
						}
					}
					result = null;
				}
			}
			catch (Exception ex3)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x0031963C File Offset: 0x0031783C
		public static void smethod_55(object object_1, IEnumerable<ActiveUnit> ienumerable_0, ref Mission mission_0, ref bool bool_9)
		{
			try
			{
				foreach (ActiveUnit activeUnit in ienumerable_0)
				{
					Scenario scenario = Client.smethod_46();
					Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = ActiveUnit.smethod_8(ref scenario, ref activeUnit, ref mission_0, ref bool_9);
					if (missionAssignmentAttemptResult != Mission.MissionAssignmentAttemptResult.Success)
					{
						DarkMessageBox.smethod_1("It was not possible to assign " + activeUnit.Name + " to the mission. Reason: " + Misc.smethod_51(missionAssignmentAttemptResult), "Unable to assign mission", Enum11.const_0);
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			mission_0.int_0 = 0;
			Client.bool_1 = true;
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x003196C8 File Offset: 0x003178C8
		public static void smethod_56(Unit unit_1, bool bool_9)
		{
			try
			{
				if (Client.smethod_50() != null)
				{
					if (bool_9)
					{
						Client.smethod_50().method_62();
					}
					if (unit_1 != null)
					{
						Client.smethod_50().method_60(unit_1);
					}
					if (bool_9)
					{
						Client.smethod_57(bool_9, unit_1);
					}
					if (unit_1 != null)
					{
						if (!unit_1.bool_1 && !Information.IsNothing(unit_1.vmethod_7(false)))
						{
							if (unit_1.vmethod_7(false) == Client.smethod_50())
							{
								if (Client.unitSensors_0.Visible)
								{
									Client.unitSensors_0.method_5();
								}
								if (Client.smethod_33().Visible)
								{
									Client.smethod_33().method_19();
								}
							}
							else
							{
								if (Client.unitSensors_0.Visible)
								{
									Client.unitSensors_0.Visible = false;
								}
								if (Client.smethod_33().Visible)
								{
									Client.smethod_33().Visible = false;
								}
							}
						}
						if (Class2413.smethod_2().method_66().Visible && Client.smethod_54().vmethod_7(false) == Client.smethod_50())
						{
							Side side = Client.smethod_50();
							Unit unit = Client.smethod_54();
							bool flag = false;
							string text = null;
							if (GameGeneral.smethod_45(side, unit, flag, ref text, Client.smethod_52().method_59()) && Client.smethod_54().bool_0)
							{
								Class2413.smethod_2().method_66().waypoint_0 = null;
								Class2413.smethod_2().method_66().activeUnit_0 = (ActiveUnit)Client.smethod_54();
								Class2413.smethod_2().method_66().flight_0 = null;
								Class2413.smethod_2().method_66().mission_0 = null;
								Class2413.smethod_2().method_66().method_3();
							}
						}
					}
					else if (Class2413.smethod_2().method_66().Visible)
					{
						Class2413.smethod_2().method_66().Hide();
					}
					Client.bool_1 = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200587", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A5C RID: 23132 RVA: 0x003198BC File Offset: 0x00317ABC
		private static void smethod_57(bool ThisUnitOnly = true, Unit value)
		{
			Unit unit = Client.smethod_54();
			bool flag = Information.IsNothing(value) || Information.IsNothing(unit) || unit.string_0 != value.string_0;
			if (flag)
			{
				Client.Delegate80 @delegate = Client.delegate80_0;
				if (@delegate != null)
				{
					@delegate();
				}
			}
			Unit unit_ = unit;
			if (!Information.IsNothing(value))
			{
				Client.string_6 = value.string_0;
			}
			if (flag)
			{
				Client.Delegate78 delegate2 = Client.delegate78_0;
				if (delegate2 != null)
				{
					delegate2(value);
				}
				if (GameGeneral.bool_0 && value != null)
				{
					TacviewServer.smethod_5();
				}
			}
			if (ThisUnitOnly && flag && Client.smethod_20())
			{
				try
				{
					Class2413.smethod_2().method_41().method_97().method_3(value, unit_);
				}
				catch (Exception ex)
				{
				}
			}
			if (value != null && flag)
			{
				if (Class2413.smethod_2().method_31().Visible)
				{
					if (Client.smethod_54() == null)
					{
						return;
					}
					ActiveUnit activeUnit;
					if (Client.smethod_54().bool_0)
					{
						activeUnit = (ActiveUnit)Client.smethod_54();
					}
					if (Client.smethod_54().method_14() && ((Contact)Client.smethod_54()).method_125() >= Contact_Base.IdentificationStatus.KnownClass)
					{
						activeUnit = ((Contact)Client.smethod_54()).activeUnit_0;
					}
					if (Client.smethod_54().bool_1 && ((Group)Client.smethod_54()).method_143() == Group.GroupType.AirGroup)
					{
						activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(((Group)Client.smethod_54()).vmethod_141().Values, 0);
					}
					if (activeUnit != null)
					{
						Client.smethod_64(activeUnit, null);
					}
				}
				if (!Client.bool_8)
				{
					Class2413.smethod_2().method_41().method_102();
					Client.bool_8 = true;
				}
			}
			Client.bool_1 = true;
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x0003A60D File Offset: 0x0003880D
		public static Waypoint smethod_58()
		{
			return Client.waypoint_0;
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00319A5C File Offset: 0x00317C5C
		public static void smethod_59(Waypoint waypoint_1)
		{
			try
			{
				bool flag = Information.IsNothing(waypoint_1) || Information.IsNothing(Client.waypoint_0) || Client.waypoint_0.string_0 != waypoint_1.string_0;
				if (flag)
				{
					Client.Delegate81 @delegate = Client.delegate81_0;
					if (@delegate != null)
					{
						@delegate();
					}
				}
				Client.waypoint_0 = waypoint_1;
				if (flag)
				{
					Client.Delegate79 delegate2 = Client.delegate79_0;
					if (delegate2 != null)
					{
						delegate2(waypoint_1);
					}
				}
				Client.bool_1 = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200629", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00319B14 File Offset: 0x00317D14
		public static List<ReferencePoint> smethod_60()
		{
			List<ReferencePoint> result;
			if (Information.IsNothing(Client.smethod_50()))
			{
				result = null;
			}
			else
			{
				List<ReferencePoint> list = new List<ReferencePoint>();
				try
				{
					foreach (ReferencePoint referencePoint in Client.smethod_50().vmethod_12())
					{
						if (!Information.IsNothing(referencePoint) && referencePoint.method_19())
						{
							list.Add(referencePoint);
						}
					}
				}
				finally
				{
					List<ReferencePoint>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06005A60 RID: 23136 RVA: 0x0003A614 File Offset: 0x00038814
		public static Client.Enum197 smethod_61()
		{
			return Client.enum197_0;
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x00319B94 File Offset: 0x00317D94
		public static void smethod_62(Client.Enum197 enum197_1)
		{
			Client.Enum197 @enum = Client.enum197_0;
			bool flag = Client.enum197_0 != enum197_1;
			Client.enum197_0 = enum197_1;
			if (flag)
			{
				if (Client.enum197_0 == Client.Enum197.const_23)
				{
					Client.bool_1 = true;
					Client.smethod_26().Hide();
				}
				if (@enum == Client.Enum197.const_23 && !Client.smethod_26().IsDisposed)
				{
					Client.smethod_26().imethod_0();
					Client.smethod_26().Show();
				}
				Class2413.smethod_2().method_41().method_163();
			}
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x0003A61B File Offset: 0x0003881B
		public static void smethod_63(string SelectedObjectType, int selectedObjectID, string HighlightTarget = null)
		{
			Class2452.smethod_1(SelectedObjectType, selectedObjectID, HighlightTarget);
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x00319C08 File Offset: 0x00317E08
		public static void smethod_64(ActiveUnit theAU, string HighlightTarget = null)
		{
			if (!Information.IsNothing(theAU) && !theAU.bool_1)
			{
				string selectedObjectType;
				if (theAU.bool_3)
				{
					selectedObjectType = "Aircraft";
				}
				else if (theAU.bool_6)
				{
					selectedObjectType = "Ship";
				}
				else if (theAU.bool_5)
				{
					selectedObjectType = "Submarine";
				}
				else if (theAU.bool_8)
				{
					selectedObjectType = "Facility";
				}
				else if (theAU.method_1())
				{
					selectedObjectType = "Satellite";
				}
				else if (theAU.bool_2)
				{
					selectedObjectType = "Weapon";
				}
				Client.smethod_63(selectedObjectType, theAU.DBID, HighlightTarget);
			}
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x0003A625 File Offset: 0x00038825
		private static void smethod_65(Scenario scenario_1)
		{
			if (Client.smethod_46() == scenario_1 && Client.smethod_46().method_44().Length > 0)
			{
				Client.bool_5 = true;
			}
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x0003A644 File Offset: 0x00038844
		public static void smethod_66()
		{
			if (!Information.IsNothing(Client.smethod_11()))
			{
				Client.smethod_11().CancelAsync();
			}
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00319C90 File Offset: 0x00317E90
		public static void smethod_67(int int_4)
		{
			try
			{
				Client.smethod_88((float)int_4);
				if (!Information.IsNothing(Client.smethod_0()))
				{
					if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
					{
						Client.smethod_89();
						if (!Client.smethod_11().IsBusy)
						{
							if (!Information.IsNothing(GameGeneral.exception_0))
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								throw GameGeneral.exception_0;
							}
							Client.smethod_11().RunWorkerAsync();
						}
					}
				}
			}
			catch (Exception ex)
			{
				try
				{
					ex.Data.Add("Error at 200593", ex.Message);
				}
				catch (Exception ex2)
				{
				}
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x0003A65C File Offset: 0x0003885C
		private static void smethod_68(DBRecord dbrecord_1)
		{
			if (!Information.IsNothing(dbrecord_1))
			{
				Class2413.smethod_2().method_41().method_313();
			}
			Client.bool_1 = true;
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00319D60 File Offset: 0x00317F60
		public static void smethod_69()
		{
			Client.dictionary_2.Clear();
			Client.dictionary_3.Clear();
			Client.dictionary_4.Clear();
			Dictionary<string, Bitmap> dictionary = new Dictionary<string, Bitmap>();
			string str = "";
			switch (Class570.class280_0.method_22())
			{
			case Class279.Class280.Enum73.const_0:
				str = "NTDS";
				break;
			case Class279.Class280.Enum73.const_1:
				str = "Stylized";
				break;
			case Class279.Class280.Enum73.const_2:
				str = "Directional";
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				break;
			}
			foreach (string text in Directory.GetFiles(Application.StartupPath + "\\Symbols\\" + str))
			{
				if (text.EndsWith(".png") | text.EndsWith(".gif"))
				{
					Bitmap original = new Bitmap(text);
					Bitmap bitmap = new Bitmap(original);
					Bitmap value = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format32bppArgb);
					dictionary.Add(Path.GetFileName(text), value);
				}
			}
			if (Class570.class280_0.method_22() == Class279.Class280.Enum73.const_2)
			{
				foreach (string text2 in Directory.GetFiles(Application.StartupPath + "\\Symbols\\Stylized"))
				{
					if ((text2.EndsWith(".png") | text2.EndsWith(".gif")) && !dictionary.ContainsKey(Path.GetFileName(text2)))
					{
						Client.bitmap_0 = (Bitmap)Image.FromFile(text2);
						dictionary.Add(Path.GetFileName(text2), Client.bitmap_0);
					}
				}
			}
			Client.dictionary_0 = dictionary;
			Class2413.smethod_2().method_41().bitmap_2 = dictionary["hosted_units.png"];
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x00319F10 File Offset: 0x00318110
		private static void smethod_70(Scenario scenario_1)
		{
			if (scenario_1 == Client.smethod_46())
			{
				Client.smethod_51(Client.smethod_46().method_54());
				if (Client.smethod_50() == null)
				{
					try
					{
						Class2413.smethod_2().method_41().Invoke((Client._Closure$__.$I235-0 == null) ? (Client._Closure$__.$I235-0 = new VB$AnonymousDelegate_0(Client._Closure$__.$I.method_2)) : Client._Closure$__.$I235-0);
					}
					catch (Exception ex)
					{
					}
					Client.bool_1 = true;
				}
			}
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x00319F98 File Offset: 0x00318198
		private static void smethod_71(Scenario scenario_1, Scenario.Enum117 enum117_0)
		{
			if (enum117_0 == Scenario.Enum117.const_1 && !Enumerable.Contains<Side>(Client.smethod_46().method_44(), Client.smethod_50()))
			{
				if (Client.smethod_46().method_44().Length > 0)
				{
					Client.smethod_46().method_53(Client.smethod_46().method_44()[0]);
				}
				else
				{
					Client.smethod_46().method_53(null);
				}
			}
			if (Client.smethod_46().method_44().Length == 1)
			{
				Client.smethod_46().method_53(Client.smethod_46().method_44()[0]);
			}
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x0031A018 File Offset: 0x00318218
		private static void smethod_72(PlatformComponent platformComponent_0)
		{
			if (platformComponent_0.GetType() == typeof(Sensor) && ((Sensor)platformComponent_0).method_18() == Client.smethod_54() && Client.unitSensors_0.Visible)
			{
				Client.unitSensors_0.vmethod_16().Start();
			}
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x0003A67B File Offset: 0x0003887B
		private static void smethod_73(ActiveUnit activeUnit_1)
		{
			if (activeUnit_1 == Client.smethod_54() && Client.unitSensors_0.Visible)
			{
				Client.unitSensors_0.vmethod_16().Start();
			}
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x0031A064 File Offset: 0x00318264
		public static void smethod_74(string string_7, ref Scenario scenario_1)
		{
			Side side_ = new Side(string_7, ref scenario_1);
			Client.smethod_46().method_69(side_);
			if (Client.smethod_46().method_44().Length == 1)
			{
				Client.smethod_51(side_);
			}
			if (Class2413.smethod_2().method_64().Visible)
			{
				Class2413.smethod_2().method_64().imethod_0();
			}
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x0031A0BC File Offset: 0x003182BC
		public static void smethod_75(bool SBR, string CustomFileName = "", bool MarkAsCampaignCheckpoint = false)
		{
			bool flag;
			if (flag = (Client.smethod_0().method_0() == Class279.Enum68.const_1))
			{
				Client.smethod_0().method_4();
			}
			Client.smethod_46().method_8(Client.smethod_40().string_0);
			Client.smethod_46().LastSavedInScenEdit = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
			int num = 0;
			do
			{
				try
				{
					if (string.IsNullOrEmpty(CustomFileName))
					{
						Class434.smethod_1(Client.smethod_46(), Client.smethod_50(), Class2413.smethod_2().method_41().vmethod_28().FileName, SBR, MarkAsCampaignCheckpoint);
					}
					else
					{
						Class434.smethod_1(Client.smethod_46(), Client.smethod_50(), CustomFileName, SBR, MarkAsCampaignCheckpoint);
					}
					break;
				}
				catch (Exception ex)
				{
					GC.Collect();
					ex.Data.Add("Error at 200360", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				num++;
			}
			while (num <= 4);
			if (flag)
			{
				Client.smethod_0().method_3();
			}
			Class2413.smethod_2().method_41().Enabled = true;
			Client.smethod_62(Client.Enum197.const_0);
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x0031A1D8 File Offset: 0x003183D8
		public static void smethod_76()
		{
			Client.smethod_47(new Scenario(Client.smethod_40().string_0), false);
			MainForm mainForm = Class2413.smethod_2().method_41();
			if (mainForm != null)
			{
				MessageLogControlViewModel messageLogControlViewModel_ = mainForm.messageLogControlViewModel_0;
				if (messageLogControlViewModel_ != null)
				{
					messageLogControlViewModel_.method_2();
				}
			}
			Client.smethod_46().method_32(false, DateAndTime.Now.ToUniversalTime());
			Client.smethod_46().method_41(1f);
			Client.smethod_46().method_52(Scenario.enumTimeCompression.OneSec);
			Client.smethod_46().LastSavedInScenEdit = true;
			Client.smethod_46().FileName = null;
			Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_3);
			Client.smethod_46().DeclaredFeatures.Add(Scenario.ScenarioFeatureOption.const_10);
			Client.string_3 = null;
			Client.smethod_51(null);
			Client.bool_1 = true;
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x0031A298 File Offset: 0x00318498
		public static bool smethod_77(Unit unit_1)
		{
			return Client.smethod_52().method_1() || (unit_1.bool_0 && ((unit_1.bool_2 && !Information.IsNothing(((Weapon)unit_1).method_179()) && Class2558.smethod_17(((Weapon)unit_1).method_179())) || ((((ActiveUnit)unit_1).vmethod_90().vmethod_1() || Operators.CompareString(unit_1.string_0, Client.smethod_52().method_59(), false) == 0) && (Information.IsNothing(Client.smethod_52().method_59()) || Operators.CompareString(unit_1.string_0, Client.smethod_52().method_59(), false) == 0) && unit_1.vmethod_7(false) == Client.smethod_50())));
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x0003A6A0 File Offset: 0x000388A0
		private static void smethod_78(object sender, DoWorkEventArgs e)
		{
			Client.smethod_79();
			Client.bool_1 = true;
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x0031A368 File Offset: 0x00318568
		public static void smethod_79()
		{
			try
			{
				Client.int_0 = Client.smethod_46().method_42().Count;
				Client.double_0 = (double)Class522.smethod_5();
				Client.string_1 = Class522.smethod_6();
				int num = Client.smethod_46().method_47();
				int i = 1;
				while (i <= num)
				{
					if (Client.nullable_0 != null)
					{
						DateTime t = Client.smethod_46().method_31();
						DateTime? dateTime = Client.nullable_0;
						if (((dateTime != null) ? new bool?(DateTime.Compare(t, dateTime.GetValueOrDefault()) >= 0) : null).GetValueOrDefault())
						{
							Client.smethod_0().method_4();
							break;
						}
					}
					if (Client.smethod_0().method_0() != Class279.Enum68.const_0)
					{
						Client.smethod_81(Client.smethod_46(), ref Client.float_0);
						if (Client.smethod_46().FifteenthSecondIsChangingOnThisPulse)
						{
							Client.smethod_85(Client.smethod_46(), true);
						}
						try
						{
							Queue<LoggedMessage>.Enumerator enumerator = Client.smethod_46().UnhandledPopUpMessages.GetEnumerator();
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.side_0 == Client.smethod_50())
								{
									Client.smethod_0().method_4();
									break;
								}
							}
						}
						finally
						{
							Queue<LoggedMessage>.Enumerator enumerator;
							enumerator.Dispose();
						}
						if (Client.smethod_46().method_47() > 1)
						{
							Client.bool_1 = true;
						}
						i++;
						continue;
					}
					IL_140:
					Client.smethod_85(Client.smethod_46(), true);
					return;
				}
				goto IL_140;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200658", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x0003A6AD File Offset: 0x000388AD
		private static void smethod_80(object sender, RunWorkerCompletedEventArgs e)
		{
			Client.bool_1 = true;
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x0031A530 File Offset: 0x00318730
		internal static void smethod_81(Scenario scenario_1, ref float float_2)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				try
				{
					GameGeneral.smethod_16(ref scenario_1, scenario_1.method_40());
				}
				catch (Exception ex)
				{
					if (ex.GetType() == typeof(OutOfMemoryException))
					{
						GameGeneral.smethod_10();
					}
					ex.Data.Add("Error at 200362 GC.Collect 1", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					if (Class570.class280_0.method_52())
					{
						Class434.smethod_0(scenario_1);
						string theXMLText = Misc.smethod_45(GameGeneral.smethod_11(scenario_1));
						string text = "";
						double num = 0.0;
						scenario_1 = Scenario.smethod_19(theXMLText, ref text, ref num, false, true);
						try
						{
							GameGeneral.smethod_16(ref scenario_1, scenario_1.method_40());
						}
						catch (Exception ex2)
						{
							if (ex2.GetType() == typeof(OutOfMemoryException))
							{
								GameGeneral.smethod_10();
							}
							ex2.Data.Add("Error at 200363 GC.Collect 2", ex2.Message);
							GameGeneral.smethod_25(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							Class434.smethod_0(scenario_1);
							string theXMLText2 = Misc.smethod_45(GameGeneral.smethod_11(scenario_1));
							text = "";
							num = 0.0;
							scenario_1 = Scenario.smethod_19(theXMLText2, ref text, ref num, false, true);
							try
							{
								GameGeneral.smethod_16(ref scenario_1, scenario_1.method_40());
							}
							catch (Exception ex3)
							{
								if (ex3.GetType() == typeof(OutOfMemoryException))
								{
									GameGeneral.smethod_10();
								}
								ex3.Data.Add("Error at 200364 GC.Collect 3", ex3.Message);
								GameGeneral.smethod_25(ref ex3);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								Class434.smethod_0(scenario_1);
								string theXMLText3 = Misc.smethod_45(GameGeneral.smethod_11(scenario_1));
								text = "";
								num = 0.0;
								scenario_1 = Scenario.smethod_19(theXMLText3, ref text, ref num, false, true);
								try
								{
									GameGeneral.smethod_16(ref scenario_1, scenario_1.method_40());
								}
								catch (Exception ex4)
								{
									ex3.Data.Add("Error at 101163", ex4.Message);
									GameGeneral.smethod_25(ref ex3);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
									throw;
								}
							}
							Client.smethod_82(ref scenario_1);
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ex5.Data.Add("Error at 101163", ex5.Message);
				GameGeneral.smethod_25(ref ex5);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			stopwatch.Stop();
			float_2 = (float)stopwatch.ElapsedMilliseconds;
			Client.bool_1 = true;
			Client.Delegate83 @delegate = Client.delegate83_0;
			if (@delegate != null)
			{
				@delegate(scenario_1);
			}
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x0003A6B5 File Offset: 0x000388B5
		public static void smethod_82(ref Scenario scenario_1)
		{
			scenario_1.Navigation_FinegrainedMaxDistance = Class570.class280_0.method_38();
			scenario_1.Navigation_FinegrainedThresholdDistance = Class570.class280_0.method_40();
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x0003A6D9 File Offset: 0x000388D9
		public static void smethod_83(ref Scenario scenario_1, bool bool_9)
		{
			scenario_1.UserIsPlottingCourse = bool_9;
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x0003A6E3 File Offset: 0x000388E3
		private static List<LoggedMessage> smethod_84()
		{
			return Enumerable.ToList<LoggedMessage>(Enumerable.Where<LoggedMessage>(Client.smethod_46().MessageLog, (Client._Closure$__.$I250-0 == null) ? (Client._Closure$__.$I250-0 = new Func<LoggedMessage, bool>(Client._Closure$__.$I.method_3)) : Client._Closure$__.$I250-0));
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x0031A830 File Offset: 0x00318A30
		internal static void smethod_85(Scenario scenario_1, bool bool_9)
		{
			try
			{
				if (bool_9 && scenario_1.SecondIsChangingOnThisPulse)
				{
					StringBuilder stringBuilder = new StringBuilder();
					List<LoggedMessage> list = Client.smethod_84();
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							LoggedMessage loggedMessage = list[i];
							string text;
							if (loggedMessage.side_0 == null)
							{
								text = "";
							}
							else
							{
								text = "[" + loggedMessage.side_0.method_51() + "] ";
							}
							stringBuilder.Append(string.Concat(new string[]
							{
								loggedMessage.dateTime_0.ToString(),
								" - ",
								text,
								loggedMessage.string_2,
								"\r\n\r\n"
							}));
							loggedMessage.bool_11 = true;
						}
						catch (Exception ex)
						{
						}
					}
					StreamWriter streamWriter = File.AppendText(Path.Combine(GameGeneral.string_10, Client.smethod_0().string_0 + ".txt"));
					streamWriter.Write(stringBuilder.ToString());
					streamWriter.Close();
				}
				int count = scenario_1.MessageLog.Count;
				List<LoggedMessage> list2 = new List<LoggedMessage>(count);
				int num2 = count - 1;
				for (int j = 0; j <= num2; j++)
				{
					try
					{
						LoggedMessage loggedMessage2 = scenario_1.MessageLog[j];
						if (loggedMessage2 != null)
						{
							list2.Add(loggedMessage2);
						}
					}
					catch (Exception ex2)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				list2 = Enumerable.ToList<LoggedMessage>(Enumerable.OrderByDescending<LoggedMessage, long>(list2, (Client._Closure$__.$I251-0 == null) ? (Client._Closure$__.$I251-0 = new Func<LoggedMessage, long>(Client._Closure$__.$I.method_4)) : Client._Closure$__.$I251-0));
				List<LoggedMessage> list3 = new List<LoggedMessage>();
				count = list2.Count;
				int num3;
				foreach (Side side in scenario_1.method_44())
				{
					num3 = 0;
					int num4 = count - 1;
					for (int l = 0; l <= num4; l++)
					{
						LoggedMessage loggedMessage = list2[l];
						if (loggedMessage.side_0 != null && loggedMessage.side_0 == side)
						{
							num3++;
							if (num3 > Client.int_3)
							{
								list3.Add(loggedMessage);
							}
						}
					}
				}
				num3 = 0;
				int num5 = count - 1;
				for (int m = 0; m <= num5; m++)
				{
					LoggedMessage loggedMessage = list2[m];
					if (loggedMessage.side_0 == null && num3 > Client.int_3)
					{
						list3.Add(loggedMessage);
					}
				}
				if (list3.Count > 0)
				{
					try
					{
						foreach (LoggedMessage loggedMessage in list3)
						{
							scenario_1.MessageLog.Remove(loggedMessage);
						}
					}
					finally
					{
						List<LoggedMessage>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 200367", ex3.Message);
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x0031AB7C File Offset: 0x00318D7C
		public static bool smethod_86(ref ActiveUnit activeUnit_1, bool bool_9, Contact contact_0, Unit unit_1)
		{
			bool result;
			if (bool_9)
			{
				result = true;
			}
			else if (!activeUnit_1.method_120())
			{
				result = true;
			}
			else
			{
				Class285.Enum87 enum87_ = Client.smethod_52().enum87_0;
				if (enum87_ != Class285.Enum87.const_0)
				{
					if (enum87_ == Class285.Enum87.const_1)
					{
						return true;
					}
				}
				else
				{
					if (Class570.class280_0.method_28() == Class279.Class280.Enum74.const_0)
					{
						return true;
					}
					if (Class570.class280_0.method_28() == Class279.Class280.Enum74.const_1)
					{
						if (contact_0 == null)
						{
							return activeUnit_1.vmethod_65(false) == unit_1;
						}
						return !activeUnit_1.bool_8 || (!Information.IsNothing(unit_1) && unit_1.method_14() && activeUnit_1.vmethod_65(false) == ((Contact)unit_1).activeUnit_0);
					}
					else if (Class570.class280_0.method_28() == Class279.Class280.Enum74.const_2)
					{
						return contact_0 != null && !activeUnit_1.bool_8;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x0031AC50 File Offset: 0x00318E50
		private static bool smethod_87()
		{
			return Client.smethod_46().method_47() != 1 || Client.smethod_46().method_31().Millisecond - 100 <= 0;
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x0031AC90 File Offset: 0x00318E90
		private static void smethod_88(float float_2)
		{
			try
			{
				if (!Information.IsNothing(Client.smethod_0()))
				{
					if (Client.smethod_46().method_44().Length != 0)
					{
						if (!Client.bool_3)
						{
							if (Class570.class280_0.method_0() && Client.double_2 <= 0.0)
							{
								Client.double_2 = 20000.0;
								Task.Factory.StartNew((Client._Closure$__.$I254-0 == null) ? (Client._Closure$__.$I254-0 = new Action(Client._Closure$__.$I.method_5)) : Client._Closure$__.$I254-0);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200656", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x0031AD70 File Offset: 0x00318F70
		private static void smethod_89()
		{
			try
			{
				if (Client.smethod_44() && Client.smethod_87())
				{
					Client.Class2421 @class = new Client.Class2421(@class);
					while (Client.smethod_46().SerializationInProgress)
					{
						Thread.Sleep(20);
					}
					@class.memoryStream_0 = GameGeneral.smethod_11(Client.smethod_46());
					@class.dateTime_0 = Client.smethod_46().method_31();
					if (@class.memoryStream_0.Length > 0L)
					{
						Task.Factory.StartNew(new Action(@class.method_0));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200657", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x0031AE40 File Offset: 0x00319040
		public static void smethod_90()
		{
			try
			{
				if (Client.smethod_0().method_0() != Class279.Enum68.const_0)
				{
					Client.smethod_46().LastSavedInScenEdit = (Client.smethod_0().method_1() == Class279.Enum67.const_2);
					ScenContainer scenContainer = new ScenContainer(Client.smethod_46());
					scenContainer.method_4(GameGeneral.smethod_11(Client.smethod_46()));
					if (File.Exists(GameGeneral.string_4 + "\\Autosave_100sec.scen"))
					{
						File.Delete(GameGeneral.string_4 + "\\Autosave_100sec.scen");
					}
					if (File.Exists(GameGeneral.string_4 + "\\Autosave_80sec.scen"))
					{
						File.Move(GameGeneral.string_4 + "\\Autosave_80sec.scen", GameGeneral.string_4 + "\\Autosave_100sec.scen");
					}
					if (File.Exists(GameGeneral.string_4 + "\\Autosave_60sec.scen"))
					{
						File.Move(GameGeneral.string_4 + "\\Autosave_60sec.scen", GameGeneral.string_4 + "\\Autosave_80sec.scen");
					}
					if (File.Exists(GameGeneral.string_4 + "\\Autosave_40sec.scen"))
					{
						File.Move(GameGeneral.string_4 + "\\Autosave_40sec.scen", GameGeneral.string_4 + "\\Autosave_60sec.scen");
					}
					if (File.Exists(GameGeneral.string_4 + "\\Autosave_20sec.scen"))
					{
						File.Move(GameGeneral.string_4 + "\\Autosave_20sec.scen", GameGeneral.string_4 + "\\Autosave_40sec.scen");
					}
					if (File.Exists(GameGeneral.string_4 + "\\Autosave.scen"))
					{
						File.Move(GameGeneral.string_4 + "\\Autosave.scen", GameGeneral.string_4 + "\\Autosave_20sec.scen");
					}
					scenContainer.method_5(GameGeneral.string_4 + "\\Autosave.scen", false);
				}
			}
			catch (Exception ex)
			{
				Client.exception_0 = ex;
				Client.bool_1 = true;
			}
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x0031B024 File Offset: 0x00319224
		public static void smethod_91(ref float float_2, ref int int_4, ActiveUnit activeUnit_1)
		{
			Class285.Enum87 enum87_ = Client.smethod_52().enum87_0;
			if (enum87_ != Class285.Enum87.const_0)
			{
				if (enum87_ == Class285.Enum87.const_1)
				{
					if (activeUnit_1.bool_1)
					{
						float_2 = (float)Client.double_1;
						int_4 = (int)Client.byte_0;
					}
					else
					{
						float_2 = 1f;
						int_4 = 255;
					}
				}
			}
			else if (activeUnit_1.bool_1)
			{
				float_2 = 1f;
				int_4 = 255;
			}
			else if (activeUnit_1.method_120())
			{
				float_2 = (float)Client.double_1;
				int_4 = (int)Client.byte_0;
			}
			else
			{
				float_2 = 1f;
				int_4 = 255;
			}
			if (activeUnit_1 != null && !activeUnit_1.vmethod_90().vmethod_1() && !Client.smethod_52().method_1() && !Class2558.smethod_17(activeUnit_1))
			{
				int_4 = 128;
				float_2 = 0.25f;
			}
			if (activeUnit_1.bool_2 && ((Weapon)activeUnit_1).method_167() == Weapon._WeaponType.Sonobuoy && Class570.class280_0.method_16() == Class279.Class280.Enum69.const_1)
			{
				int_4 = 128;
				float_2 = 0.25f;
			}
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x0031B114 File Offset: 0x00319314
		public static void smethod_92()
		{
			Client.smethod_76();
			string string_ = "NATO";
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(string_, ref scenario);
			string string_2 = "WP";
			scenario = Client.smethod_46();
			Client.smethod_74(string_2, ref scenario);
			Client.smethod_46().method_44()[0].method_69(Client.smethod_46().method_44()[1], Misc.PostureStance.Hostile);
			Client.smethod_46().method_44()[1].method_69(Client.smethod_46().method_44()[0], Misc.PostureStance.Hostile);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Raptor 1", 5.0, 5.0, 691, 4521, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Raptor 2", 5.0, 4.95, 691, 4521, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Flanker 1", 5.8, 5.8, 2099, 2368, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Flanker 2", 5.8, 5.7, 2099, 2368, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Flanker 3", 5.8, 5.6, 2099, 2368, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Flanker 4", 5.8, 5.5, 2099, 2368, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Mainstay 1", 5.82, 5.52, 2149, 8060, 10000f, Unit.Enum122.const_0, null);
			try
			{
				foreach (ActiveUnit activeUnit in Client.smethod_46().method_42())
				{
					if (activeUnit.vmethod_7(false) == Client.smethod_46().method_44()[1])
					{
						foreach (Sensor sensor in activeUnit.method_78())
						{
							if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								sensor.method_77();
							}
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Client.smethod_51(Client.smethod_46().method_44()[0]);
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x0031B3EC File Offset: 0x003195EC
		public static void smethod_93()
		{
			Client.smethod_76();
			string string_ = "NATO";
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(string_, ref scenario);
			string string_2 = "WP";
			scenario = Client.smethod_46();
			Client.smethod_74(string_2, ref scenario);
			Client.smethod_46().method_44()[0].method_69(Client.smethod_46().method_44()[1], Misc.PostureStance.Hostile);
			Client.smethod_46().method_44()[1].method_69(Client.smethod_46().method_44()[0], Misc.PostureStance.Hostile);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 1447, "Perry 1", 5.0, 5.0, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 259, "Tanker 1", 4.9, 5.1, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 42, "Tico 1", 4.85, 5.15, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 1", 8.1, 5.8, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 2", 7.6, 5.7, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 3", 8.2, 5.6, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 4", 7.5, 5.5, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 5", 8.3, 5.4, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 6", 7.4, 5.3, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 7", 8.4, 5.2, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 8", 7.3, 5.1, 1669, 2423, 10000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_75(Client.smethod_46().method_44()[1], 185, "Tomsk", 2.5731, 3.5107, false, Unit.Enum122.const_0, null);
			Client.smethod_51(Client.smethod_46().method_44()[0]);
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x0031B74C File Offset: 0x0031994C
		public static void smethod_94()
		{
			Client.smethod_76();
			string string_ = "Australia";
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(string_, ref scenario);
			string string_2 = "OPFOR";
			scenario = Client.smethod_46();
			Client.smethod_74(string_2, ref scenario);
			Client.smethod_46().method_44()[0].method_69(Client.smethod_46().method_44()[1], Misc.PostureStance.Hostile);
			Client.smethod_46().method_44()[1].method_69(Client.smethod_46().method_44()[0], Misc.PostureStance.Hostile);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 956, "Adelaide 1", 5.0, 5.0, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 592, "Anzac 1", 4.85, 5.15, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[1], 1832, "Luhai 1", 5.0, 4.0, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[1], 690, "Guangzhou 1", 4.85, 4.0, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 1", 8.1, 5.8, 1669, 2423, 5000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Backfire 2", 7.6, 5.7, 1669, 2423, 5000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Mirage F.1 #1", 6.1, 5.8, 1203, 7545, 1000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Mirage F.1 #2", 5.6, 5.7, 1203, 7545, 1000f, Unit.Enum122.const_0, null);
			Client.smethod_51(Client.smethod_46().method_44()[0]);
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x0031B9B4 File Offset: 0x00319BB4
		public static void smethod_95()
		{
			Client.smethod_76();
			string string_ = "USN";
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(string_, ref scenario);
			string string_2 = "OPFOR";
			scenario = Client.smethod_46();
			Client.smethod_74(string_2, ref scenario);
			Client.smethod_46().method_44()[0].method_69(Client.smethod_46().method_44()[1], Misc.PostureStance.Hostile);
			Client.smethod_46().method_44()[1].method_69(Client.smethod_46().method_44()[0], Misc.PostureStance.Hostile);
			Ship ship = Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 272, "Enterprise", -76.1, 37.2, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 42, "Yorktown", -76.11, 37.19, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 521, "Truxtun", -76.2, 37.3, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 761, "King", -76.15, 37.0, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 116, "Underwood", -76.3, 37.25, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 1812, "Wichita", -76.09, 37.21, false, Unit.Enum122.const_0, null);
			Aircraft aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Tomcat 1", -76.12, 37.2, 10, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Tomcat 2", -76.12, 37.2, 10, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Hornet 1", -76.12, 37.2, 47, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Hornet 2", -76.12, 37.2, 47, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Hornet 3", -76.12, 37.2, 47, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Hornet 4", -76.12, 37.2, 47, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Intruder 1", -76.12, 37.2, 221, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Intruder 2", -76.12, 37.2, 221, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "SeaHawk 1", -76.12, 37.2, 237, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Sea King 1", -76.12, 37.2, 55, 0, 1000f, Unit.Enum122.const_0, null);
			if (ship.vmethod_92().vmethod_8(aircraft_))
			{
				ship.vmethod_92().method_18(aircraft_, false);
			}
			Client.smethod_51(Client.smethod_46().method_44()[0]);
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x0031BECC File Offset: 0x0031A0CC
		public static void smethod_96()
		{
			Client.smethod_76();
			string string_ = "US";
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(string_, ref scenario);
			string string_2 = "Iran";
			scenario = Client.smethod_46();
			Client.smethod_74(string_2, ref scenario);
			Client.smethod_46().method_44()[0].method_69(Client.smethod_46().method_44()[1], Misc.PostureStance.Hostile);
			Client.smethod_46().method_44()[1].method_69(Client.smethod_46().method_44()[0], Misc.PostureStance.Hostile);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Natanz 2008.inst", Client.smethod_46().method_44()[1]);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Bandar Abbas.inst", Client.smethod_46().method_44()[1]);
			Group group = Client.smethod_46().Groups.method_0("Bandar Abbas International/TAB 9");
			int num = 1;
			do
			{
				Aircraft aircraft_ = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Falcon 50 #" + Conversions.ToString(num), -76.12, 37.2, 639, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_))
				{
					group.vmethod_92().method_18(aircraft_, false);
				}
				num++;
			}
			while (num <= 4);
			num = 1;
			do
			{
				Aircraft aircraft_2 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "F.27 #" + Conversions.ToString(num), -76.12, 37.2, 2091, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_2))
				{
					group.vmethod_92().method_18(aircraft_2, false);
				}
				num++;
			}
			while (num <= 4);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Bushehr.inst", Client.smethod_46().method_44()[1]);
			Client.smethod_46().method_44()[1].method_38(new Strike(Client.smethod_46().method_44()[1], Client.smethod_46(), "Mission 1", Mission.Enum88.const_0, Strike.StrikeType.Air_Intercept));
			group = Client.smethod_46().Groups.method_0("Bushehr Airport/TAB 6");
			Mission mission = Client.smethod_46().method_44()[1].method_36(Client.smethod_46())[0];
			num = 1;
			do
			{
				Aircraft aircraft = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Bushehr Phantom-D #" + Conversions.ToString(num), -76.12, 37.2, 229, 2173, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft))
				{
					group.vmethod_92().method_18(aircraft, false);
				}
				ActiveUnit activeUnit = aircraft;
				Mission value = mission;
				bool setMissionOnly = false;
				Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
				activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
				num++;
			}
			while (num <= 6);
			num = 1;
			do
			{
				Aircraft aircraft2 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Bushehr Phantom-E #" + Conversions.ToString(num), -76.12, 37.2, 1309, 332, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft2))
				{
					group.vmethod_92().method_18(aircraft2, false);
				}
				ActiveUnit activeUnit2 = aircraft2;
				Mission value2 = mission;
				bool setMissionOnly2 = false;
				Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
				activeUnit2.vmethod_102(value2, setMissionOnly2, ref missionAssignmentAttemptResult);
				num++;
			}
			while (num <= 18);
			num = 1;
			do
			{
				Aircraft aircraft3 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Bushehr Tomcat #" + Conversions.ToString(num), -76.12, 37.2, 1312, 770, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft3))
				{
					group.vmethod_92().method_18(aircraft3, false);
				}
				ActiveUnit activeUnit3 = aircraft3;
				Mission value3 = mission;
				bool setMissionOnly3 = false;
				Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
				activeUnit3.vmethod_102(value3, setMissionOnly3, ref missionAssignmentAttemptResult);
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft_3 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Bushehr Falcon 50 #" + Conversions.ToString(num), -76.12, 37.2, 639, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_3))
				{
					group.vmethod_92().method_18(aircraft_3, false);
				}
				num++;
			}
			while (num <= 2);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Dezful.inst", Client.smethod_46().method_44()[1]);
			group = Client.smethod_46().Groups.method_0("Dezful");
			num = 1;
			do
			{
				Aircraft aircraft_4 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Dezful Tiger #" + Conversions.ToString(num), -76.12, 37.2, 1310, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_4))
				{
					group.vmethod_92().method_18(aircraft_4, false);
				}
				num++;
			}
			while (num <= 36);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Esfahan.inst", Client.smethod_46().method_44()[1]);
			group = Client.smethod_46().Groups.method_0("Esfahan");
			num = 1;
			do
			{
				Aircraft aircraft_5 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Esfahan Tiger #" + Conversions.ToString(num), -76.12, 37.2, 1310, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_5))
				{
					group.vmethod_92().method_18(aircraft_5, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft_6 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Esfahan Fencer #" + Conversions.ToString(num), -76.12, 37.2, 1327, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_6))
				{
					group.vmethod_92().method_18(aircraft_6, false);
				}
				num++;
			}
			while (num <= 2);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Hamadan.inst", Client.smethod_46().method_44()[1]);
			group = Client.smethod_46().Groups.method_0("Hamadan");
			num = 1;
			do
			{
				Aircraft aircraft_7 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Hamadan Phantom-D #" + Conversions.ToString(num), -76.12, 37.2, 229, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_7))
				{
					group.vmethod_92().method_18(aircraft_7, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft_8 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Hamadan Phantom-E #" + Conversions.ToString(num), -76.12, 37.2, 1309, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_8))
				{
					group.vmethod_92().method_18(aircraft_8, false);
				}
				num++;
			}
			while (num <= 12);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Mehrabad.inst", Client.smethod_46().method_44()[1]);
			group = Client.smethod_46().Groups.method_0("Mehrabad");
			num = 1;
			do
			{
				Aircraft aircraft_9 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Mehrabad Fulcrum #" + Conversions.ToString(num), -76.12, 37.2, 1346, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_9))
				{
					group.vmethod_92().method_18(aircraft_9, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft_10 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Mehrabad Fencer #" + Conversions.ToString(num), -76.12, 37.2, 1327, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_10))
				{
					group.vmethod_92().method_18(aircraft_10, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft_11 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Mehrabad Tanker-707 #" + Conversions.ToString(num), -76.12, 37.2, 2423, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_11))
				{
					group.vmethod_92().method_18(aircraft_11, false);
				}
				num++;
			}
			while (num <= 10);
			num = 1;
			do
			{
				Aircraft aircraft_12 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Mehrabad Tanker-747 #" + Conversions.ToString(num), -76.12, 37.2, 1660, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_12))
				{
					group.vmethod_92().method_18(aircraft_12, false);
				}
				num++;
			}
			while (num <= 5);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Omidiyeh.inst", Client.smethod_46().method_44()[1]);
			group = Client.smethod_46().Groups.method_0("Omidiyeh");
			num = 1;
			do
			{
				Aircraft aircraft_13 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Omidiyeh Airguard #" + Conversions.ToString(num), -76.12, 37.2, 1354, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_13))
				{
					group.vmethod_92().method_18(aircraft_13, false);
				}
				num++;
			}
			while (num <= 36);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Shiraz.inst", Client.smethod_46().method_44()[1]);
			group = Client.smethod_46().Groups.method_0("Shiraz");
			num = 1;
			do
			{
				Aircraft aircraft_14 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Shiraz Fencer #" + Conversions.ToString(num), -76.12, 37.2, 1327, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_14))
				{
					group.vmethod_92().method_18(aircraft_14, false);
				}
				num++;
			}
			while (num <= 12);
			num = 1;
			do
			{
				Aircraft aircraft_15 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Shiraz Frogfoot #" + Conversions.ToString(num), -76.12, 37.2, 133, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_15))
				{
					group.vmethod_92().method_18(aircraft_15, false);
				}
				num++;
			}
			while (num <= 12);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Tabriz.inst", Client.smethod_46().method_44()[1]);
			group = Client.smethod_46().Groups.method_0("Tabriz");
			num = 1;
			do
			{
				Aircraft aircraft_16 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Tabriz Tiger #" + Conversions.ToString(num), -76.12, 37.2, 1310, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_16))
				{
					group.vmethod_92().method_18(aircraft_16, false);
				}
				num++;
			}
			while (num <= 24);
			num = 1;
			do
			{
				Aircraft aircraft_17 = Client.smethod_46().method_71(Client.smethod_46().method_44()[1], "Tabriz Fulcrum #" + Conversions.ToString(num), -76.12, 37.2, 1346, 0, 1000f, Unit.Enum122.const_0, null);
				if (group.vmethod_92().vmethod_8(aircraft_17))
				{
					group.vmethod_92().method_18(aircraft_17, false);
				}
				num++;
			}
			while (num <= 12);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Iran EW.inst", Client.smethod_46().method_44()[1]);
			Client.smethod_46().method_81(Application.StartupPath + "\\ImportExport\\Iran\\Iran AD.inst", Client.smethod_46().method_44()[1]);
			Ship ship = Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 1215, "Roosevelt", 51.144952, 27.025, false, Unit.Enum122.const_0, null);
			num = 1;
			do
			{
				Aircraft aircraft_18 = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Super Bug #" + Conversions.ToString(num), -76.12, 37.2, 1089, 0, 1000f, Unit.Enum122.const_0, null);
				if (ship.vmethod_92().vmethod_8(aircraft_18))
				{
					ship.vmethod_92().method_18(aircraft_18, false);
				}
				num++;
			}
			while (num <= 24);
			num = 1;
			do
			{
				Aircraft aircraft_19 = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Classic Bug #" + Conversions.ToString(num), -76.12, 37.2, 2039, 0, 1000f, Unit.Enum122.const_0, null);
				if (ship.vmethod_92().vmethod_8(aircraft_19))
				{
					ship.vmethod_92().method_18(aircraft_19, false);
				}
				num++;
			}
			while (num <= 24);
			num = 1;
			do
			{
				Aircraft aircraft_20 = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Prowler #" + Conversions.ToString(num), -76.12, 37.2, 601, 0, 1000f, Unit.Enum122.const_0, null);
				if (ship.vmethod_92().vmethod_8(aircraft_20))
				{
					ship.vmethod_92().method_18(aircraft_20, false);
				}
				num++;
			}
			while (num <= 4);
			num = 1;
			do
			{
				Aircraft aircraft_21 = Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "Hawkeye #" + Conversions.ToString(num), -76.12, 37.2, 694, 0, 1000f, Unit.Enum122.const_0, null);
				if (ship.vmethod_92().vmethod_8(aircraft_21))
				{
					ship.vmethod_92().method_18(aircraft_21, false);
				}
				num++;
			}
			while (num <= 4);
			try
			{
				foreach (ActiveUnit activeUnit4 in Client.smethod_46().method_42())
				{
					if (activeUnit4.vmethod_7(false) == Client.smethod_46().method_44()[1])
					{
						foreach (Sensor sensor in activeUnit4.method_78())
						{
							if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								sensor.method_77();
							}
						}
					}
				}
			}
			finally
			{
				List<ActiveUnit>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Client.smethod_51(Client.smethod_46().method_44()[0]);
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x0031CE5C File Offset: 0x0031B05C
		public static void smethod_97()
		{
			Client.smethod_76();
			string string_ = "Blue";
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(string_, ref scenario);
			string string_2 = "Red";
			scenario = Client.smethod_46();
			Client.smethod_74(string_2, ref scenario);
			Client.smethod_46().method_44()[0].method_69(Client.smethod_46().method_44()[1], Misc.PostureStance.Hostile);
			Client.smethod_46().method_44()[1].method_69(Client.smethod_46().method_44()[0], Misc.PostureStance.Hostile);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "BUFF 1", Class437.smethod_7(24.143), Class437.smethod_7(34.5059), 14, 6995, 1000f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_71(Client.smethod_46().method_44()[0], "BUFF 2", Class437.smethod_7(24.1714), Class437.smethod_7(35.243), 14, 6995, 100f, Unit.Enum122.const_0, null);
			Client.smethod_46().method_76(Client.smethod_46().method_44()[1], 691, "IHAWK Bty", Class437.smethod_7(24.1454), Class437.smethod_7(35.1115), false, Unit.Enum122.const_0, null);
			try
			{
				foreach (ActiveUnit activeUnit in Client.smethod_46().vmethod_0().Values)
				{
					foreach (Sensor sensor in activeUnit.method_78())
					{
						if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
						{
							sensor.method_77();
						}
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			Client.smethod_51(Client.smethod_46().method_44()[1]);
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x0031D02C File Offset: 0x0031B22C
		public static void smethod_98()
		{
			Client.smethod_76();
			string string_ = "Blue";
			Scenario scenario = Client.smethod_46();
			Client.smethod_74(string_, ref scenario);
			string string_2 = "Red";
			scenario = Client.smethod_46();
			Client.smethod_74(string_2, ref scenario);
			Client.smethod_46().method_44()[0].method_69(Client.smethod_46().method_44()[1], Misc.PostureStance.Hostile);
			Client.smethod_46().method_44()[1].method_69(Client.smethod_46().method_44()[0], Misc.PostureStance.Hostile);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 503, "Ticonderoga", -6.572490124848907, 35.951348412451246, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 1079, "Underwood", -7.059152405025491, 36.3974394215724, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[0], 1079, "Doyle", -6.932765660676145, 35.63246282727665, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[1], 1734, "Charles De Gaulle", -11.548334045232812, 34.5312840865825, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[1], 49, "Tourville", -8.895807599043964, 35.93845658162015, false, Unit.Enum122.const_0, null);
			Client.smethod_46().method_73(Client.smethod_46().method_44()[1], 49, "De Grasse", -8.655607102274335, 34.57332893690153, false, Unit.Enum122.const_0, null);
			try
			{
				foreach (ActiveUnit activeUnit in Client.smethod_46().vmethod_0().Values)
				{
					if (activeUnit.vmethod_7(false) == Client.smethod_46().method_44()[1])
					{
						foreach (Sensor sensor in activeUnit.method_78())
						{
							if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								sensor.method_77();
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator<ActiveUnit> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			Client.smethod_51(Client.smethod_46().method_44()[0]);
			Class2413.smethod_2().method_41().method_84();
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x0031D288 File Offset: 0x0031B488
		public static void smethod_99()
		{
			StringBuilder stringBuilder = new StringBuilder();
			List<LoggedMessage> list = Client.smethod_50().method_55(Client.smethod_46());
			if (!Information.IsNothing(list))
			{
				try
				{
					foreach (LoggedMessage loggedMessage in list)
					{
						stringBuilder.Append(loggedMessage.dateTime_0.ToString() + ": " + loggedMessage.string_2 + "\r\n\r\n");
					}
				}
				finally
				{
					List<LoggedMessage>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			StreamWriter streamWriter = File.CreateText(Application.StartupPath + "\\AALog.txt");
			streamWriter.Write(stringBuilder.ToString());
			streamWriter.Close();
			stringBuilder = null;
			DarkMessageBox.smethod_0("AALog exported!", "", Enum11.const_0);
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x0031D34C File Offset: 0x0031B54C
		internal static void smethod_100(string string_7)
		{
			if (Versioned.IsNumeric(string_7))
			{
				string_7 = DBOps.smethod_12(Conversions.ToInteger(string_7));
			}
			DBOps.DBFileCheckResult dbfileCheckResult_;
			Client.smethod_41(DBOps.smethod_10(string_7, ref dbfileCheckResult_, true, true));
			if (Information.IsNothing(Client.smethod_40()))
			{
				DarkMessageBox.smethod_2("Error: " + DBOps.smethod_7(dbfileCheckResult_) + "\r\nAborting...", "Error", Enum11.const_0);
				return;
			}
			Client.smethod_46().method_8(string_7);
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x0003A71D File Offset: 0x0003891D
		private static void smethod_101(object sender, EventArgs e)
		{
			if (Client.bool_5)
			{
				Client.smethod_0().method_4();
				Client.bool_5 = false;
				DarkMessageBox.smethod_0("The scenario has concluded. You will now be presented with the evaluation of your performance.", "Scenario End", Enum11.const_0);
				Class2413.smethod_2().method_25().Show();
			}
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x0031D3B8 File Offset: 0x0031B5B8
		public static void smethod_102(string string_7)
		{
			if (Client.list_1.Contains(string_7))
			{
				int index = Client.list_1.IndexOf(string_7);
				Client.list_1.RemoveAt(index);
				Client.list_1.Insert(0, string_7);
			}
			else
			{
				Client.list_1.Insert(0, string_7);
				if (Client.list_1.Count > 10)
				{
					Client.list_1.Remove(Enumerable.Last<string>(Client.list_1));
				}
			}
			Class570.smethod_2(Class2566.dictionary_0, Client.list_1);
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x0031D438 File Offset: 0x0031B638
		public static void smethod_103(Scenario scenario_1, string string_7)
		{
			Client.smethod_102(string_7);
			scenario_1.method_9();
			List<Scenario.ScenarioFeatureOption> list = new List<Scenario.ScenarioFeatureOption>();
			try
			{
				foreach (Scenario.ScenarioFeatureOption scenarioFeatureOption in scenario_1.DeclaredFeatures)
				{
					if (!Class2556.smethod_11(scenarioFeatureOption))
					{
						list.Add(scenarioFeatureOption);
					}
				}
			}
			finally
			{
				HashSet<Scenario.ScenarioFeatureOption>.Enumerator enumerator;
				enumerator.Dispose();
			}
			if (list.Count > 0)
			{
				if (Client.smethod_0().method_1() != Class279.Enum67.const_2)
				{
					new UnlicensedFeaturesWindow
					{
						DataContext = new LicenseDialogViewModel(list)
					}.Show();
					return;
				}
				if (DarkMessageBox.smethod_1("This scenario contains features that aren't licenced, would you like to remove any content that isn't licenced? (This likely will make the scenario unplayable, press No if you are unsure)", "Warning", Enum11.const_3) == DialogResult.No)
				{
					new UnlicensedFeaturesWindow
					{
						DataContext = new LicenseDialogViewModel(list)
					}.Show();
					return;
				}
				Client.smethod_104(scenario_1);
				scenario_1.method_9();
				List<Scenario.ScenarioFeatureOption> list2 = new List<Scenario.ScenarioFeatureOption>();
				try
				{
					foreach (Scenario.ScenarioFeatureOption scenarioFeatureOption2 in scenario_1.DeclaredFeatures)
					{
						if (!Class2556.smethod_11(scenarioFeatureOption2))
						{
							list2.Add(scenarioFeatureOption2);
						}
					}
				}
				finally
				{
					HashSet<Scenario.ScenarioFeatureOption>.Enumerator enumerator2;
					enumerator2.Dispose();
				}
				if (list2.Count > 0)
				{
					DarkMessageBox.smethod_2("Unable to completely remove unlicenced features.", "Error", Enum11.const_0);
					new UnlicensedFeaturesWindow
					{
						DataContext = new LicenseDialogViewModel(list)
					}.Show();
					return;
				}
			}
			if (scenario_1.LastSavedInScenEdit)
			{
				Class2413.smethod_2().method_13().scenario_0 = scenario_1;
				Class2413.smethod_2().method_13().string_0 = string_7;
				Class2413.smethod_2().method_13().Show();
			}
			else
			{
				Client.smethod_47(scenario_1, false);
				Client.smethod_51(Client.smethod_46().method_54());
				if (Information.IsNothing(Client.smethod_50()))
				{
					Class2413.smethod_2().method_41().method_153(4000000);
				}
				else
				{
					Class2413.smethod_2().method_41().method_153((int)Math.Round(Client.smethod_50().double_0));
					Class2413.smethod_2().method_41().method_161(true, Client.smethod_50().method_26());
				}
				Client.smethod_0().method_4();
				Client.bool_1 = true;
				Class2413.smethod_2().method_41().method_84();
				Class2413.smethod_2().method_41().method_234();
				if (Client.smethod_0().method_0() == Class279.Enum68.const_1)
				{
					Client.smethod_0().method_4();
				}
				Class2413.smethod_2().method_41().method_316();
				Class2413.smethod_2().method_41().Enabled = true;
				StartGameMenuWindow.smethod_2();
			}
			if (!string.IsNullOrEmpty(Client.string_2))
			{
				DarkMessageBox.smethod_2(Client.string_2, "Error", Enum11.const_0);
				Client.string_2 = "";
			}
			if (Client.smethod_0().method_1() == Class279.Enum67.const_2)
			{
				List<string> list3 = new List<string>();
				int num = 4;
				int num2 = 1;
				foreach (Side side in scenario_1.method_44())
				{
					if (!Information.IsNothing(side.method_35()))
					{
						try
						{
							foreach (Mission mission in side.method_36(scenario_1))
							{
								list3.AddRange(scenario_1.method_96(ref side, ref mission));
							}
						}
						finally
						{
							IEnumerator<Mission> enumerator3;
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
							}
						}
					}
				}
				string text = "";
				if (list3.Count > 0)
				{
					text = "WARNING! SOME AIRCRAFT IN THIS SCENARIO WILL NOT BE ABLE TO TAKE OFF DUE TO THE MISSION'S FLIGHT SIZE RESTRICTIONS!\r\n\r\nTo rectify this, you can change the flight size of the mission, add more aircraft to the mission, change loadouts on existing aircraft so there are enough aircraft armed with identical loadouts, or uncheck the flag Aircraft numbers below Flight Size do not take off.\r\n\r\n";
					try
					{
						foreach (string str in list3)
						{
							text = text + "\r\n" + str;
							num2++;
							if (num2 == num)
							{
								break;
							}
						}
					}
					finally
					{
						List<string>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					if (list3.Count > num)
					{
						text = text + "\r\n+" + Conversions.ToString(list3.Count - num) + " more...";
					}
					if (!string.IsNullOrEmpty(text))
					{
						DarkMessageBox.smethod_2(text, "Error", Enum11.const_0);
					}
				}
			}
			Client.string_0 = string_7;
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x0031D82C File Offset: 0x0031BA2C
		private static void smethod_104(Scenario scenario_1)
		{
			StringBuilder stringBuilder = new StringBuilder();
			DarkMessageBox.smethod_0(string.Format("Removed the following items from the scenario: {0}{1}{2}", "\r\n", "\r\n", stringBuilder.ToString()), "", Enum11.const_0);
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x0031D868 File Offset: 0x0031BA68
		public static void smethod_105()
		{
			Class2413.smethod_2().method_41().vmethod_102().InitialDirectory = Application.StartupPath;
			if (Class2413.smethod_2().method_41().vmethod_102().ShowDialog() == DialogResult.OK)
			{
				foreach (string string_ in Class2413.smethod_2().method_41().vmethod_102().FileNames)
				{
					try
					{
						Client.smethod_106(string_);
					}
					catch (Exception ex)
					{
						DarkMessageBox.smethod_2(ex.Message, "Error", Enum11.const_0);
					}
				}
			}
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x0031D904 File Offset: 0x0031BB04
		public static void smethod_106(string string_7)
		{
			new CultureInfo("en-US");
			string text = Path.GetExtension(string_7);
			if (text.Length == 4)
			{
				text = Conversions.ToString(text[0]) + Conversions.ToString(text[1]) + Conversions.ToString(text[text.Length - 1]) + "w";
			}
			else
			{
				text += "w";
			}
			string path = Path.ChangeExtension(string_7, text);
			if (File.Exists(path))
			{
				string text2 = File.ReadAllText(path);
				text2 = text2.Replace(",", ".");
				File.WriteAllText(path, text2);
				TextReader textReader = File.OpenText(path);
				double num;
				double num2;
				double num3;
				double num4;
				try
				{
					num = Math2.smethod_33(textReader.ReadLine());
					Math2.smethod_33(textReader.ReadLine());
					Math2.smethod_33(textReader.ReadLine());
					num2 = Math2.smethod_33(textReader.ReadLine());
					num3 = Math2.smethod_33(textReader.ReadLine());
					num4 = Math2.smethod_33(textReader.ReadLine());
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200369", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					return;
				}
				finally
				{
					textReader.Close();
				}
				ImageInformation imageInformation = TextureLoader.ImageInformationFromFile(string_7);
				double double_ = (double)imageInformation.Height * num2 + num4;
				double double_2 = (double)imageInformation.Width * num + num3;
				Class1875 @class = new Class1875(string_7, Class2413.smethod_2().method_41().vmethod_796().method_4(), 0.0, string_7, double_, num4, num3, double_2, 100.0, Class2413.smethod_2().method_41().vmethod_796().method_4().method_3());
				@class.vmethod_9(byte.MaxValue);
				@class.method_0(Color.Black.ToArgb());
				@class.vmethod_0(Class2413.smethod_2().method_41().vmethod_796().method_7());
				@class.Name = Path.GetFileName(string_7);
				Class2413.smethod_2().method_41().vmethod_796().method_4().method_5().vmethod_19(@class);
				Client.list_0.Add(@class);
				Class2413.smethod_2().method_41().method_219();
			}
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x0003A756 File Offset: 0x00038956
		private static void smethod_107(string string_7)
		{
			Client.queue_0.Enqueue(string_7);
			Client.bool_1 = true;
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x0031DB54 File Offset: 0x0031BD54
		private static void smethod_108(Side side_1)
		{
			if (side_1 == Client.smethod_50() && Client.smethod_46().method_16())
			{
				int? num = Class264.smethod_5(Client.smethod_46());
				if (num != null)
				{
					int num2 = side_1.method_22(Client.smethod_46(), null);
					if (((num != null) ? new bool?(num2 >= num.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						Client.smethod_46().method_48();
					}
				}
			}
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x0003A769 File Offset: 0x00038969
		private static void smethod_109(object sender, EventArgs e)
		{
			Task.Factory.StartNew((Client._Closure$__.$I278-0 == null) ? (Client._Closure$__.$I278-0 = new Action(Client._Closure$__.$I.method_6)) : Client._Closure$__.$I278-0);
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x0031DBD0 File Offset: 0x0031BDD0
		public static void smethod_110()
		{
			if (!Directory.Exists(GameGeneral.string_11))
			{
				Directory.CreateDirectory(GameGeneral.string_11);
			}
			foreach (string text in Directory.GetFiles(Class2413.smethod_1().Info.DirectoryPath))
			{
				if (Operators.CompareString(Path.GetExtension(text).ToLower(), ".ini", false) == 0)
				{
					string text2 = Path.Combine(GameGeneral.string_11, Path.GetFileNameWithoutExtension(text)) + ".ini";
					if (File.Exists(text2))
					{
						File.Delete(text2);
					}
					File.Move(text, text2);
				}
			}
		}

		// Token: 0x0400348C RID: 13452
		internal static Struct15 struct15_0;

		// Token: 0x0400348D RID: 13453
		internal static bool bool_0 = false;

		// Token: 0x0400348E RID: 13454
		public static bool bool_1;

		// Token: 0x0400348F RID: 13455
		public static Dictionary<string, Bitmap> dictionary_0;

		// Token: 0x04003490 RID: 13456
		[CompilerGenerated]
		[AccessedThroughProperty("CurrentGame")]
		private static Class279 class279_0;

		// Token: 0x04003491 RID: 13457
		[CompilerGenerated]
		[AccessedThroughProperty("_CurrentScenario")]
		private static Scenario scenario_0;

		// Token: 0x04003492 RID: 13458
		internal static string string_0;

		// Token: 0x04003493 RID: 13459
		[CompilerGenerated]
		[AccessedThroughProperty("_CurrentSide")]
		private static Side side_0;

		// Token: 0x04003494 RID: 13460
		private static Client.Enum197 enum197_0;

		// Token: 0x04003495 RID: 13461
		private static DBRecord dbrecord_0;

		// Token: 0x04003496 RID: 13462
		internal static Class581 class581_0;

		// Token: 0x04003497 RID: 13463
		private static bool bool_2;

		// Token: 0x04003498 RID: 13464
		internal static RecorderForm recorderForm_0 = new RecorderForm();

		// Token: 0x04003499 RID: 13465
		internal static bool bool_3;

		// Token: 0x0400349A RID: 13466
		private static bool bool_4;

		// Token: 0x0400349B RID: 13467
		internal static int int_0;

		// Token: 0x0400349C RID: 13468
		internal static float float_0;

		// Token: 0x0400349D RID: 13469
		internal static double double_0;

		// Token: 0x0400349E RID: 13470
		internal static string string_1;

		// Token: 0x0400349F RID: 13471
		[AccessedThroughProperty("Timer1")]
		[CompilerGenerated]
		private static Timer timer_0;

		// Token: 0x040034A0 RID: 13472
		[AccessedThroughProperty("SteamDownloadCheckTimer")]
		[CompilerGenerated]
		private static Timer timer_1;

		// Token: 0x040034A1 RID: 13473
		private static bool bool_5;

		// Token: 0x040034A2 RID: 13474
		internal static ReferencePoint.OrientationType orientationType_0;

		// Token: 0x040034A3 RID: 13475
		internal static List<Class1870> list_0;

		// Token: 0x040034A4 RID: 13476
		internal static float float_1;

		// Token: 0x040034A5 RID: 13477
		internal static string string_2 = "";

		// Token: 0x040034A6 RID: 13478
		private static Unit unit_0;

		// Token: 0x040034A7 RID: 13479
		internal static bool bool_6;

		// Token: 0x040034A8 RID: 13480
		internal static WorldWindow worldWindow_0;

		// Token: 0x040034A9 RID: 13481
		public static int int_1;

		// Token: 0x040034AA RID: 13482
		internal static Mount mount_0;

		// Token: 0x040034AB RID: 13483
		internal static Class316 class316_0;

		// Token: 0x040034AC RID: 13484
		internal static int int_2;

		// Token: 0x040034AD RID: 13485
		private static bool bool_7 = false;

		// Token: 0x040034AE RID: 13486
		internal static Exception exception_0;

		// Token: 0x040034AF RID: 13487
		internal static Queue<string> queue_0;

		// Token: 0x040034B0 RID: 13488
		public static string string_3;

		// Token: 0x040034B1 RID: 13489
		internal static string string_4 = Path.Combine(Application.StartupPath, "Scenarios", "Steam Workshop");

		// Token: 0x040034B2 RID: 13490
		private static Bitmap bitmap_0;

		// Token: 0x040034B3 RID: 13491
		internal static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x040034B4 RID: 13492
		public static Dictionary<Image, IntPtr> dictionary_1 = new Dictionary<Image, IntPtr>();

		// Token: 0x040034B5 RID: 13493
		internal static System.Drawing.Font font_0 = new System.Drawing.Font("Verdana", 9f, FontStyle.Bold);

		// Token: 0x040034B6 RID: 13494
		public static System.Drawing.Font font_1 = new System.Drawing.Font("Segoe UI", 9f, FontStyle.Regular);

		// Token: 0x040034B7 RID: 13495
		public static DateTime? nullable_0;

		// Token: 0x040034B8 RID: 13496
		public static List<string> list_1 = new List<string>();

		// Token: 0x040034B9 RID: 13497
		private static int int_3 = 300;

		// Token: 0x040034BA RID: 13498
		private static LuaSandBox luaSandBox_0;

		// Token: 0x040034BB RID: 13499
		internal static Dictionary<string, Image> dictionary_2 = new Dictionary<string, Image>();

		// Token: 0x040034BC RID: 13500
		internal static Dictionary<Image, Image> dictionary_3 = new Dictionary<Image, Image>();

		// Token: 0x040034BD RID: 13501
		internal static Dictionary<Image, Image> dictionary_4 = new Dictionary<Image, Image>();

		// Token: 0x040034BE RID: 13502
		internal static Color color_0 = Color.FromArgb(255, 82, 255, 255);

		// Token: 0x040034BF RID: 13503
		internal static Color color_1 = Color.Yellow;

		// Token: 0x040034C0 RID: 13504
		internal static Color color_2 = Color.LightGreen;

		// Token: 0x040034C1 RID: 13505
		internal static Color color_3 = Color.Orange;

		// Token: 0x040034C2 RID: 13506
		internal static Color color_4 = Color.Red;

		// Token: 0x040034C3 RID: 13507
		internal static Color color_5 = Color.FromArgb(75, Color.DodgerBlue);

		// Token: 0x040034C4 RID: 13508
		private static Class285 class285_0;

		// Token: 0x040034C5 RID: 13509
		private static Waypoint waypoint_0;

		// Token: 0x040034C6 RID: 13510
		public static double double_1 = 0.6;

		// Token: 0x040034C7 RID: 13511
		public static byte byte_0 = 100;

		// Token: 0x040034C8 RID: 13512
		public static byte byte_1 = 55;

		// Token: 0x040034C9 RID: 13513
		public static double double_2;

		// Token: 0x040034CA RID: 13514
		private static Lazy<WeaponsWindow> lazy_0 = new Lazy<WeaponsWindow>();

		// Token: 0x040034CB RID: 13515
		public static UnitSensors unitSensors_0;

		// Token: 0x040034CC RID: 13516
		public static DamageControlWindow damageControlWindow_0;

		// Token: 0x040034CD RID: 13517
		public static Magazines magazines_0 = new Magazines();

		// Token: 0x040034CE RID: 13518
		public static CampaignEditorWindow campaignEditorWindow_0 = new CampaignEditorWindow();

		// Token: 0x040034CF RID: 13519
		public static VideoWindow videoWindow_0;

		// Token: 0x040034D0 RID: 13520
		public static StartGameMenuWindow startGameMenuWindow_0;

		// Token: 0x040034D1 RID: 13521
		[CompilerGenerated]
		[AccessedThroughProperty("BW_ShowLoadingDB")]
		private static BackgroundWorker backgroundWorker_0;

		// Token: 0x040034D2 RID: 13522
		[AccessedThroughProperty("BW_Core_Pulse")]
		[CompilerGenerated]
		private static BackgroundWorker backgroundWorker_1;

		// Token: 0x040034D3 RID: 13523
		public static NewMission newMission_0;

		// Token: 0x040034D4 RID: 13524
		public static FlightPlanErrors flightPlanErrors_0 = new FlightPlanErrors();

		// Token: 0x040034D5 RID: 13525
		public static FlightPlanTime flightPlanTime_0 = new FlightPlanTime();

		// Token: 0x040034D6 RID: 13526
		public static FlightPlanAircraftLoadout flightPlanAircraftLoadout_0 = new FlightPlanAircraftLoadout();

		// Token: 0x040034D7 RID: 13527
		internal static string string_5;

		// Token: 0x040034D8 RID: 13528
		internal static byte? nullable_1;

		// Token: 0x040034D9 RID: 13529
		internal static int? nullable_2;

		// Token: 0x040034DA RID: 13530
		private static bool bool_8 = false;

		// Token: 0x040034DB RID: 13531
		public static Dictionary<LoggedMessage.MessageType, NewMessageForm> dictionary_5;

		// Token: 0x040034DC RID: 13532
		[CompilerGenerated]
		private static Client.Delegate77 delegate77_0;

		// Token: 0x040034DD RID: 13533
		[CompilerGenerated]
		private static Client.Delegate78 delegate78_0;

		// Token: 0x040034DE RID: 13534
		[CompilerGenerated]
		private static Client.Delegate79 delegate79_0;

		// Token: 0x040034DF RID: 13535
		[CompilerGenerated]
		private static Client.Delegate80 delegate80_0;

		// Token: 0x040034E0 RID: 13536
		[CompilerGenerated]
		private static Client.Delegate81 delegate81_0;

		// Token: 0x040034E1 RID: 13537
		[CompilerGenerated]
		private static Client.Delegate82 delegate82_0;

		// Token: 0x040034E2 RID: 13538
		[CompilerGenerated]
		private static Client.Delegate83 delegate83_0;

		// Token: 0x040034E3 RID: 13539
		public static Dispatcher dispatcher_0;

		// Token: 0x040034E4 RID: 13540
		public static ElementHost elementHost_0;

		// Token: 0x040034E5 RID: 13541
		private static FlightPlanEditorTargets flightPlanEditorTargets_0;

		// Token: 0x040034E6 RID: 13542
		private static FlightPlanEditorTargetsArea flightPlanEditorTargetsArea_0;

		// Token: 0x040034E7 RID: 13543
		private static FlightPlanEditorTargetsPreliminary flightPlanEditorTargetsPreliminary_0;

		// Token: 0x040034E8 RID: 13544
		private static FlightPlanEditorWeaponRoute flightPlanEditorWeaponRoute_0;

		// Token: 0x040034E9 RID: 13545
		private static AttackTarget attackTarget_0;

		// Token: 0x040034EA RID: 13546
		public static OrbitAnchor orbitAnchor_0 = new OrbitAnchor();

		// Token: 0x040034EB RID: 13547
		public static LicenseTweaker licenseTweaker_0 = new LicenseTweaker();

		// Token: 0x040034EC RID: 13548
		public static ScenarioFeatures scenarioFeatures_0;

		// Token: 0x040034ED RID: 13549
		public static List<Geopoint_Struct[]> list_2;

		// Token: 0x040034EE RID: 13550
		private static MissionEditor missionEditor_0;

		// Token: 0x040034EF RID: 13551
		private static AirTaskingOrder airTaskingOrder_0;

		// Token: 0x040034F0 RID: 13552
		private static FlightPlanEditor flightPlanEditor_0;

		// Token: 0x040034F1 RID: 13553
		private static string string_6;

		// Token: 0x040034F2 RID: 13554
		private static ActiveUnit activeUnit_0;

		// Token: 0x02000D6E RID: 3438
		// (Invoke) Token: 0x06005A95 RID: 23189
		internal delegate void Delegate77();

		// Token: 0x02000D6F RID: 3439
		// (Invoke) Token: 0x06005A99 RID: 23193
		internal delegate void Delegate78(Unit theUnit);

		// Token: 0x02000D70 RID: 3440
		// (Invoke) Token: 0x06005A9D RID: 23197
		internal delegate void Delegate79(Waypoint theWaypoint);

		// Token: 0x02000D71 RID: 3441
		// (Invoke) Token: 0x06005AA1 RID: 23201
		internal delegate void Delegate80();

		// Token: 0x02000D72 RID: 3442
		// (Invoke) Token: 0x06005AA5 RID: 23205
		internal delegate void Delegate81();

		// Token: 0x02000D73 RID: 3443
		// (Invoke) Token: 0x06005AA9 RID: 23209
		internal delegate void Delegate82();

		// Token: 0x02000D74 RID: 3444
		// (Invoke) Token: 0x06005AAD RID: 23213
		internal delegate void Delegate83(Scenario theScen);

		// Token: 0x02000D75 RID: 3445
		internal enum Enum197
		{
			// Token: 0x040034F4 RID: 13556
			const_0,
			// Token: 0x040034F5 RID: 13557
			const_1,
			// Token: 0x040034F6 RID: 13558
			const_2,
			// Token: 0x040034F7 RID: 13559
			const_3,
			// Token: 0x040034F8 RID: 13560
			const_4,
			// Token: 0x040034F9 RID: 13561
			const_5,
			// Token: 0x040034FA RID: 13562
			const_6,
			// Token: 0x040034FB RID: 13563
			const_7,
			// Token: 0x040034FC RID: 13564
			const_8,
			// Token: 0x040034FD RID: 13565
			const_9,
			// Token: 0x040034FE RID: 13566
			const_10,
			// Token: 0x040034FF RID: 13567
			const_11,
			// Token: 0x04003500 RID: 13568
			const_12,
			// Token: 0x04003501 RID: 13569
			const_13,
			// Token: 0x04003502 RID: 13570
			const_14,
			// Token: 0x04003503 RID: 13571
			const_15,
			// Token: 0x04003504 RID: 13572
			const_16,
			// Token: 0x04003505 RID: 13573
			const_17,
			// Token: 0x04003506 RID: 13574
			const_18,
			// Token: 0x04003507 RID: 13575
			const_19,
			// Token: 0x04003508 RID: 13576
			const_20,
			// Token: 0x04003509 RID: 13577
			const_21,
			// Token: 0x0400350A RID: 13578
			const_22,
			// Token: 0x0400350B RID: 13579
			const_23,
			// Token: 0x0400350C RID: 13580
			const_24,
			// Token: 0x0400350D RID: 13581
			const_25,
			// Token: 0x0400350E RID: 13582
			const_26
		}

		// Token: 0x02000D77 RID: 3447
		[CompilerGenerated]
		internal sealed class Class2421
		{
			// Token: 0x06005AB7 RID: 23223 RVA: 0x0003A802 File Offset: 0x00038A02
			public Class2421(Client.Class2421 class2421_0)
			{
				if (class2421_0 != null)
				{
					this.dateTime_0 = class2421_0.dateTime_0;
					this.memoryStream_0 = class2421_0.memoryStream_0;
				}
			}

			// Token: 0x06005AB8 RID: 23224 RVA: 0x0003A825 File Offset: 0x00038A25
			internal void method_0()
			{
				Client.class581_0.method_0(this.dateTime_0, this.memoryStream_0);
			}

			// Token: 0x04003517 RID: 13591
			public DateTime dateTime_0;

			// Token: 0x04003518 RID: 13592
			public MemoryStream memoryStream_0;
		}
	}
}
