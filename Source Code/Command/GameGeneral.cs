using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Command_Core.Lua;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns20;
using ns21;
using ns9;
using SevenZip;

namespace Command_Core
{
	// Token: 0x02000470 RID: 1136
	[StandardModule]
	public sealed class GameGeneral
	{
		// Token: 0x0600230A RID: 8970 RVA: 0x002907C0 File Offset: 0x0028E9C0
		[CompilerGenerated]
		public static void smethod_0(GameGeneral.Delegate62 delegate62_1)
		{
			GameGeneral.Delegate62 @delegate = GameGeneral.delegate62_0;
			GameGeneral.Delegate62 delegate2;
			do
			{
				delegate2 = @delegate;
				GameGeneral.Delegate62 value = (GameGeneral.Delegate62)Delegate.Combine(delegate2, delegate62_1);
				@delegate = Interlocked.CompareExchange<GameGeneral.Delegate62>(ref GameGeneral.delegate62_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x002907F4 File Offset: 0x0028E9F4
		internal static void smethod_1(string string_14)
		{
			GameGeneral.Delegate62 @delegate = GameGeneral.delegate62_0;
			if (@delegate != null)
			{
				@delegate(string_14);
			}
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00290814 File Offset: 0x0028EA14
		public static string smethod_2()
		{
			string result;
			if (!GameGeneral.smethod_8() && !GameGeneral.smethod_7() && !GameGeneral.smethod_6() && !GameGeneral.smethod_9())
			{
				result = "Command - Build 1115.6";
			}
			else
			{
				switch (GameGeneral.smethod_3())
				{
				case GameGeneral.Enum144.const_1:
					result = "Command MilGov Edition 1115.6";
					break;
				case GameGeneral.Enum144.const_2:
					result = "Command Student Edition 1115.6";
					break;
				case GameGeneral.Enum144.const_3:
					result = "Command Academic Edition 1115.6";
					break;
				case GameGeneral.Enum144.const_4:
					result = "Command Professional (Standard) Edition 1115.6";
					break;
				case GameGeneral.Enum144.const_5:
					result = "Command Professional (Premium) Edition 1115.6";
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = "Command - Build 1115.6";
					break;
				}
			}
			return result;
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x00010F1C File Offset: 0x0000F11C
		public static GameGeneral.Enum144 smethod_3()
		{
			return GameGeneral.enum144_0;
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x00010F23 File Offset: 0x0000F123
		public static void smethod_4(GameGeneral.Enum144 enum144_1)
		{
			GameGeneral.enum144_0 = enum144_1;
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x002908A4 File Offset: 0x0028EAA4
		public static Random smethod_5()
		{
			int managedThreadId = Thread.CurrentThread.ManagedThreadId;
			if (!GameGeneral.concurrentDictionary_0.ContainsKey(managedThreadId))
			{
				object obj = GameGeneral.object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					if (!GameGeneral.concurrentDictionary_0.ContainsKey(managedThreadId))
					{
						byte[] array = new byte[5];
						GameGeneral.rngcryptoServiceProvider_0.GetBytes(array);
						int seed = BitConverter.ToInt32(array, 0);
						Random random = new Random(seed);
						GameGeneral.concurrentDictionary_0[managedThreadId] = random;
					}
				}
			}
			return GameGeneral.concurrentDictionary_0[managedThreadId];
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x00010F2B File Offset: 0x0000F12B
		public static bool smethod_6()
		{
			return GameGeneral.smethod_3() == GameGeneral.Enum144.const_4 || GameGeneral.smethod_3() == GameGeneral.Enum144.const_5;
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x00010F3F File Offset: 0x0000F13F
		public static bool smethod_7()
		{
			return GameGeneral.smethod_3() == GameGeneral.Enum144.const_3;
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x00010F49 File Offset: 0x0000F149
		public static bool smethod_8()
		{
			return GameGeneral.smethod_3() == GameGeneral.Enum144.const_2;
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00010F53 File Offset: 0x0000F153
		public static bool smethod_9()
		{
			return GameGeneral.smethod_3() == GameGeneral.Enum144.const_1;
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x00010F5D File Offset: 0x0000F15D
		public static void smethod_10()
		{
			GC.Collect(2, GCCollectionMode.Forced);
			GC.WaitForPendingFinalizers();
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00290944 File Offset: 0x0028EB44
		public static MemoryStream smethod_11(Scenario scenario_0)
		{
			MemoryStream result;
			if (scenario_0 == null)
			{
				result = new MemoryStream();
			}
			else
			{
				while (scenario_0.ExecutionInProgress)
				{
					Thread.Sleep(10);
				}
				scenario_0.SerializationInProgress = true;
				MemoryStream memoryStream = new MemoryStream();
				scenario_0.method_12(memoryStream, true);
				scenario_0.SerializationInProgress = false;
				result = memoryStream;
			}
			return result;
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x0029098C File Offset: 0x0028EB8C
		public static void smethod_12(ref Scenario scenario_0, bool bool_7)
		{
			checked
			{
				try
				{
					List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(scenario_0.method_42());
					try
					{
						foreach (ActiveUnit activeUnit in list)
						{
							if (activeUnit != null)
							{
								GameGeneral.smethod_13(ref activeUnit);
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					Side[] array = scenario_0.method_44();
					for (int i = 0; i < array.Length; i++)
					{
						List<Contact> list2 = array[i].method_44();
						try
						{
							foreach (Contact contact in list2)
							{
								GameGeneral.smethod_14(ref contact);
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
					if (bool_7)
					{
						scenario_0.method_10().ClearStats();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 999999", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00290AA4 File Offset: 0x0028ECA4
		public static void smethod_13(ref ActiveUnit activeUnit_0)
		{
			checked
			{
				try
				{
					if (activeUnit_0 != null)
					{
						if (activeUnit_0.vmethod_51() != null)
						{
							try
							{
								foreach (Mount mount in activeUnit_0.vmethod_51())
								{
									try
									{
										foreach (WeaponRec weaponRec in mount.vmethod_10())
										{
											weaponRec.method_13();
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									try
									{
										foreach (WeaponRec weaponRec2 in mount.method_32().vmethod_10())
										{
											weaponRec2.method_13();
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator3;
										((IDisposable)enumerator3).Dispose();
									}
								}
							}
							finally
							{
								List<Mount>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						if (activeUnit_0.vmethod_117() != null)
						{
							foreach (Magazine magazine in activeUnit_0.vmethod_117())
							{
								try
								{
									foreach (WeaponRec weaponRec3 in magazine.vmethod_10())
									{
										weaponRec3.method_13();
									}
								}
								finally
								{
									List<WeaponRec>.Enumerator enumerator4;
									((IDisposable)enumerator4).Dispose();
								}
							}
						}
						if (activeUnit_0.bool_3)
						{
							Aircraft aircraft = (Aircraft)activeUnit_0;
							if (aircraft.method_167() != null)
							{
								WeaponRec[] weaponRec_ = aircraft.method_167().weaponRec_0;
								for (int j = 0; j < weaponRec_.Length; j++)
								{
									weaponRec_[j].method_13();
								}
							}
						}
						if (activeUnit_0.vmethod_99() != null && activeUnit_0.vmethod_99().Length > 0)
						{
							AirFacility[] array2 = activeUnit_0.vmethod_99();
							for (int k = 0; k < array2.Length; k++)
							{
								array2[k].method_24().Clear();
							}
						}
						if (activeUnit_0.vmethod_100() != null && activeUnit_0.vmethod_100().Length > 0)
						{
							DockFacility[] array3 = activeUnit_0.vmethod_100();
							for (int l = 0; l < array3.Length; l++)
							{
								array3[l].lazy_0.Value.Clear();
							}
						}
						try
						{
							foreach (PlatformComponent platformComponent in activeUnit_0.vmethod_120())
							{
								if (platformComponent.method_18() != null)
								{
									platformComponent.method_19(null);
								}
							}
						}
						finally
						{
							IEnumerator<PlatformComponent> enumerator5;
							if (enumerator5 != null)
							{
								enumerator5.Dispose();
							}
						}
						activeUnit_0.vmethod_88().method_74();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101226", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00010F6B File Offset: 0x0000F16B
		public static void smethod_14(ref Contact contact_0)
		{
			if (contact_0.activeUnit_0 != null)
			{
				contact_0.activeUnit_0 = null;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00290DAC File Offset: 0x0028EFAC
		public static void smethod_15(bool bool_7)
		{
			try
			{
				GameGeneral.smethod_4(GameGeneral.Enum144.const_0);
				if (!Directory.Exists(GameGeneral.string_5))
				{
					Directory.CreateDirectory(GameGeneral.string_5);
				}
				if (Class570.class280_0.method_50())
				{
					string text = "Starting initializing Sim Core.";
					GameGeneral.smethod_26(ref text);
				}
				Misc.smethod_2(GameGeneral.string_5);
				Class522.smethod_2();
				DBOps.bool_2 = bool_7;
				Task.Factory.StartNew(new Action(DBOps.smethod_6));
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully started database scan.";
					GameGeneral.smethod_26(ref text);
				}
				Terrain.smethod_0();
				LandCover.smethod_0();
				Task.Factory.StartNew(new Action(Class444.smethod_2));
				Class442.smethod_0();
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully loaded terrain grids and initialized store.";
					GameGeneral.smethod_26(ref text);
				}
				if (!Directory.Exists(GameGeneral.string_6))
				{
					Directory.CreateDirectory(GameGeneral.string_6);
				}
				SevenZipBase.SetLibraryPath(Class160.smethod_1().Info.DirectoryPath + "\\7z.dll");
				Class1874.class1854_0.method_45(true);
				GameGeneral.class1874_0 = Class1883.smethod_0();
				if (Class570.class280_0.method_50())
				{
					string text = "Successfully created Sim World.";
					GameGeneral.smethod_26(ref text);
				}
				Misc.double_0 = Math2.smethod_13(5.0);
				if (Class570.class280_0.method_50())
				{
					string text = "Done initializing Sim Core.";
					GameGeneral.smethod_26(ref text);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200577", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00290F58 File Offset: 0x0028F158
		public static void smethod_16(ref Scenario scenario_0, float float_1)
		{
			try
			{
				if (DateTime.Compare(scenario_0.method_31(), scenario_0.method_27().Add(scenario_0.method_29())) > 0 && !scenario_0.method_25())
				{
					scenario_0.method_48();
				}
				scenario_0.ExecutionInProgress = true;
				GameGeneral.exception_0 = null;
				scenario_0.method_32(false, scenario_0.method_31().AddSeconds((double)float_1));
				GameGeneral.smethod_18(ref scenario_0, float_1);
				scenario_0.ExecutionInProgress = false;
			}
			catch (Exception ex)
			{
				scenario_0.ExecutionInProgress = false;
				GameGeneral.exception_0 = ex;
				ex.Data.Add("Error at 300000", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00291028 File Offset: 0x0028F228
		private static void smethod_17(ActiveUnit activeUnit_0, ActiveUnit[] activeUnit_1, float float_1)
		{
			if (activeUnit_0 != null)
			{
				try
				{
					bool flag = activeUnit_0.vmethod_127();
					ActiveUnit_Weaponry activeUnit_Weaponry = activeUnit_0.vmethod_89();
					if (flag)
					{
						ActiveUnit_Navigator activeUnit_Navigator = activeUnit_0.vmethod_85();
						ActiveUnit_AI activeUnit_AI = activeUnit_0.vmethod_86();
						ActiveUnit_Sensory activeUnit_Sensory = activeUnit_0.vmethod_88();
						try
						{
							if (!activeUnit_0.method_8())
							{
								if (activeUnit_Navigator != null)
								{
									activeUnit_Navigator.method_11(float_1);
								}
								Sensor[] array = activeUnit_0.method_78();
								if (activeUnit_Sensory != null && activeUnit_0.scenario_0 != null && activeUnit_0.scenario_0.SecondIsChangingOnThisPulse && array.Length > 0)
								{
									ActiveUnit_Sensory activeUnit_Sensory2 = activeUnit_Sensory;
									activeUnit_Sensory2.vmethod_5(array);
									activeUnit_Sensory2.vmethod_7(array, activeUnit_1, float_1);
								}
							}
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 101263", "");
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						try
						{
							activeUnit_0.vmethod_87().vmethod_46(float_1, true, false, activeUnit_0.scenario_0.method_31());
							if (!activeUnit_0.method_8() && !activeUnit_0.bool_1)
							{
								activeUnit_0.vmethod_137(float_1);
							}
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 1320945888121", "");
							GameGeneral.smethod_25(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						try
						{
							if (!activeUnit_0.method_8() && !activeUnit_0.bool_25)
							{
								ActiveUnit_AI activeUnit_AI2 = activeUnit_AI;
								ref float ptr = ref activeUnit_AI2.float_1;
								activeUnit_AI2.float_1 = ptr - float_1;
								if (activeUnit_AI.float_1 > 0f)
								{
									activeUnit_0.bool_15 = false;
								}
								else
								{
									activeUnit_0.bool_15 = true;
									if (activeUnit_0.short_1 == 0)
									{
										activeUnit_AI.float_1 = (float)GameGeneral.smethod_5().Next(10, 21);
									}
									else
									{
										activeUnit_AI.float_1 = (float)((int)activeUnit_0.method_62() + GameGeneral.smethod_5().Next(-1, 2));
									}
								}
								ActiveUnit_AI activeUnit_AI3 = activeUnit_AI;
								ptr = ref activeUnit_AI3.float_2;
								activeUnit_AI3.float_2 = ptr - float_1;
								if (activeUnit_AI.float_2 > 0f)
								{
									activeUnit_0.bool_16 = false;
								}
								else
								{
									activeUnit_0.bool_16 = true;
									if (activeUnit_0.short_2 == 0)
									{
										activeUnit_AI.float_2 = (float)GameGeneral.smethod_5().Next(10, 21);
									}
									else
									{
										activeUnit_AI.float_2 = (float)((int)activeUnit_0.short_2 + GameGeneral.smethod_5().Next(-1, 2));
									}
								}
								if (activeUnit_0.scenario_0.SecondIsChangingOnThisPulse && activeUnit_AI != null && (!activeUnit_0.bool_25 || !activeUnit_0.method_5()))
								{
									activeUnit_AI.method_1(activeUnit_0.vmethod_88().method_0());
									int count = activeUnit_AI.method_0().Count;
									activeUnit_AI.tuple_0 = new Tuple<Contact, Misc.PostureStance>[count - 1 + 1];
									activeUnit_AI.vmethod_25();
									if (activeUnit_AI.bool_9 && activeUnit_0.bool_15)
									{
										activeUnit_AI.vmethod_10(float_1, false, false);
									}
								}
							}
						}
						catch (Exception ex3)
						{
							ex3.Data.Add("Error at 101264", "");
							GameGeneral.smethod_25(ref ex3);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						try
						{
							if (!activeUnit_0.method_8() && !activeUnit_0.bool_25 && activeUnit_AI != null)
							{
								if (!activeUnit_0.bool_8 && !activeUnit_0.bool_6 && !activeUnit_0.bool_5)
								{
									activeUnit_AI.vmethod_26(float_1);
									if (activeUnit_0.bool_3 && activeUnit_0.vmethod_6() && !activeUnit_AI.bool_6)
									{
										((Aircraft)activeUnit_0).method_158().method_123(null, float_1);
									}
								}
								else if (activeUnit_0.scenario_0 != null && activeUnit_0.scenario_0.SecondIsChangingOnThisPulse)
								{
									activeUnit_AI.vmethod_26(float_1);
									if (activeUnit_0.bool_5 && activeUnit_0.vmethod_40() != 0f)
									{
										((Submarine)activeUnit_0).method_153().method_119();
									}
								}
								activeUnit_AI.vmethod_16();
							}
						}
						catch (Exception ex4)
						{
							ex4.Data.Add("Error at 101265", "");
							GameGeneral.smethod_25(ref ex4);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						try
						{
							if (!activeUnit_0.method_8())
							{
								if (activeUnit_Weaponry != null && !activeUnit_0.bool_1 && activeUnit_0.scenario_0.SecondIsChangingOnThisPulse)
								{
									activeUnit_Weaponry.method_20();
									activeUnit_Weaponry.vmethod_7(1f);
									activeUnit_Weaponry.method_35();
								}
								ActiveUnit_Damage activeUnit_Damage = activeUnit_0.vmethod_91();
								if (activeUnit_Damage != null && flag)
								{
									activeUnit_Damage.vmethod_14(float_1);
								}
								if (activeUnit_Navigator.double_0 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator2 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator2.double_0;
									activeUnit_Navigator2.double_0 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_1 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator3 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator3.double_1;
									activeUnit_Navigator3.double_1 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_2 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator4 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator4.double_2;
									activeUnit_Navigator4.double_2 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_3 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator5 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator5.double_3;
									activeUnit_Navigator5.double_3 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_4 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator6 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator6.double_4;
									activeUnit_Navigator6.double_4 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_5 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator7 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator7.double_5;
									activeUnit_Navigator7.double_5 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_6 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator8 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator8.double_6;
									activeUnit_Navigator8.double_6 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_7 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator9 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator9.double_7;
									activeUnit_Navigator9.double_7 = ptr2 - (double)float_1;
								}
								if (activeUnit_Navigator.double_8 > 0.0)
								{
									ActiveUnit_Navigator activeUnit_Navigator10 = activeUnit_Navigator;
									ref double ptr2 = ref activeUnit_Navigator10.double_8;
									activeUnit_Navigator10.double_8 = ptr2 - (double)float_1;
								}
							}
							goto IL_567;
						}
						catch (Exception ex5)
						{
							ex5.Data.Add("Error at 101266", "");
							GameGeneral.smethod_25(ref ex5);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							goto IL_567;
						}
					}
					if (!activeUnit_0.bool_1 && !activeUnit_0.vmethod_127())
					{
						activeUnit_0.vmethod_130();
						activeUnit_Weaponry.vmethod_7(float_1);
					}
					IL_567:;
				}
				catch (Exception ex6)
				{
					ex6.Data.Add("Error at 300001", "");
					GameGeneral.smethod_25(ref ex6);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0029166C File Offset: 0x0028F86C
		public static void smethod_18(ref Scenario scenario_0, float float_1)
		{
			GameGeneral.Class529 @class = new GameGeneral.Class529(@class);
			@class.float_0 = float_1;
			GameGeneral.smethod_19(scenario_0, @class.float_0);
			GameGeneral.list_0.Clear();
			try
			{
				foreach (KeyValuePair<string, ActiveUnit> keyValuePair in scenario_0.vmethod_0())
				{
					GameGeneral.list_0.Add(keyValuePair.Value);
				}
			}
			finally
			{
				IEnumerator<KeyValuePair<string, ActiveUnit>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			Random random = GameGeneral.smethod_5();
			GameGeneral.int_3 = 0;
			GameGeneral.int_4 = 0;
			try
			{
				if (GameGeneral.list_0.Count > 0)
				{
					try
					{
						GameGeneral.Class528 class2 = new GameGeneral.Class528(class2);
						class2.class529_0 = @class;
						class2.activeUnit_0 = new ActiveUnit[0];
						try
						{
							foreach (ActiveUnit activeUnit in GameGeneral.list_0)
							{
								if (activeUnit != null && activeUnit.vmethod_127() && !activeUnit.vmethod_90().vmethod_1())
								{
									Class429.smethod_0(ref class2.activeUnit_0, activeUnit);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						List<Task> list = new List<Task>();
						try
						{
							List<ActiveUnit>.Enumerator enumerator3 = GameGeneral.list_0.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								GameGeneral.Class527 class3 = new GameGeneral.Class527(class3);
								class3.class528_0 = class2;
								class3.activeUnit_0 = enumerator3.Current;
								Task item = Task.Factory.StartNew(new Action(class3.method_0));
								list.Add(item);
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						Task.WaitAll(list.ToArray());
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200492", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						if (typeof(Exception) == typeof(AggregateException))
						{
							ex.Data.Add("Error at 300020 ", ((AggregateException)ex).InnerExceptions[0].Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						else
						{
							ex.Data.Add("Error at 300002", "");
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
					}
					try
					{
						Scenario.CargoMovement.Clear();
						try
						{
							foreach (ActiveUnit activeUnit2 in GameGeneral.list_0)
							{
								try
								{
									if (activeUnit2 != null)
									{
										if (activeUnit2.vmethod_7(false) != null)
										{
											if (!scenario_0.method_46().Contains(activeUnit2))
											{
												if (activeUnit2.bool_6 && ((Ship)activeUnit2).method_152())
												{
													if (!activeUnit2.method_8())
													{
														activeUnit2.vmethod_64(false, null, (float)((double)activeUnit2.vmethod_63(false, null) - (double)activeUnit2.method_60() / (double)(300 * GameGeneral.smethod_5().Next(1, 7)) * (double)@class.float_0));
														if (activeUnit2.vmethod_63(false, null) <= (float)(-(float)activeUnit2.method_60()))
														{
															scenario_0.method_65(activeUnit2);
														}
													}
												}
												else
												{
													if (!activeUnit2.method_8())
													{
														activeUnit2.vmethod_126(@class.float_0, ref random);
													}
													if (!activeUnit2.method_8() && scenario_0.FifteenthSecondIsChangingOnThisPulse && activeUnit2.vmethod_127())
													{
														if (scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_4))
														{
															activeUnit2.vmethod_90().method_7();
														}
														else if (scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_5))
														{
															activeUnit2.vmethod_90().method_6();
														}
													}
													if (!activeUnit2.method_8() && scenario_0.SecondIsChangingOnThisPulse && !activeUnit2.bool_1 && activeUnit2.vmethod_127())
													{
														if (activeUnit2.method_78().Length > 0)
														{
															ActiveUnit_Sensory activeUnit_Sensory = activeUnit2.vmethod_88();
															if (activeUnit2.vmethod_90().vmethod_1())
															{
																activeUnit_Sensory.vmethod_8();
															}
															else
															{
																activeUnit_Sensory.method_21();
															}
															activeUnit_Sensory.method_62();
														}
														else
														{
															activeUnit2.vmethod_88().method_68();
														}
													}
													ActiveUnit_AI activeUnit_AI = activeUnit2.vmethod_86();
													if (!activeUnit2.bool_25 && activeUnit2.vmethod_127() && !activeUnit2.method_8() && scenario_0.SecondIsChangingOnThisPulse)
													{
														activeUnit_AI.vmethod_18();
														if (activeUnit_AI.bool_10)
														{
															activeUnit_AI.vmethod_17(1f, false, true);
														}
														if (scenario_0.FifthSecondIsChangingOnThisPulse)
														{
															activeUnit_AI.method_10();
														}
														activeUnit2.vmethod_86().vmethod_11(@class.float_0, false, false);
													}
													if (!activeUnit2.method_8() && scenario_0.FifthSecondIsChangingOnThisPulse && activeUnit2.vmethod_127())
													{
														activeUnit2.vmethod_92().method_9();
														activeUnit2.vmethod_92().method_12();
													}
													if (!activeUnit2.method_8() && !activeUnit2.bool_1 && activeUnit2.vmethod_127() && scenario_0.SecondIsChangingOnThisPulse)
													{
														activeUnit2.vmethod_91().vmethod_12(@class.float_0);
													}
													if (!activeUnit2.method_8() && !activeUnit2.bool_25 && !activeUnit2.bool_2 && !activeUnit2.bool_1 && activeUnit2.vmethod_127() && scenario_0.SecondIsChangingOnThisPulse)
													{
														activeUnit2.vmethod_89().vmethod_6(@class.float_0);
														if (activeUnit_AI.activeUnit_0 == null)
														{
															activeUnit_AI.activeUnit_0 = activeUnit2;
														}
														activeUnit_AI.vmethod_22(@class.float_0);
													}
												}
											}
										}
									}
								}
								catch (Exception ex2)
								{
									ex2.Data.Add("Error at 300003", "");
									GameGeneral.smethod_25(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					catch (Exception ex3)
					{
						ex3.Data.Add("Error at 300004", "");
						GameGeneral.smethod_25(ref ex3);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				try
				{
					GameGeneral.smethod_23(ref scenario_0, @class.float_0, ref random);
				}
				catch (Exception ex4)
				{
					ex4.Data.Add("Error at 300005", "");
					GameGeneral.smethod_25(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					GameGeneral.smethod_20(scenario_0, @class.float_0);
				}
				catch (Exception ex5)
				{
					ex5.Data.Add("Error at 300006", "");
					GameGeneral.smethod_25(ref ex5);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					if (scenario_0.SecondIsChangingOnThisPulse)
					{
						bool flag = false;
						if (GameGeneral.float_0 <= 3.4028235E+38f)
						{
							GameGeneral.float_0 += 1f;
						}
						if (scenario_0.method_47() == 1)
						{
							if (GameGeneral.float_0 >= 1f)
							{
								flag = true;
							}
						}
						else if (scenario_0.method_47() == 5)
						{
							if (GameGeneral.float_0 >= 5f)
							{
								flag = true;
							}
						}
						else if (scenario_0.method_47() == 15)
						{
							if (GameGeneral.float_0 >= 15f)
							{
								flag = true;
							}
						}
						else if (scenario_0.method_47() == 30)
						{
							if (GameGeneral.float_0 >= 30f)
							{
								flag = true;
							}
						}
						else if (GameGeneral.float_0 >= 60f)
						{
							flag = true;
						}
						if (Scenario.CargoMovement.Count > 0)
						{
							try
							{
								foreach (EventTrigger eventTrigger in scenario_0.vmethod_4().Values)
								{
									if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.unitCargoMoved)
									{
										((Class330)eventTrigger).method_8();
									}
								}
							}
							finally
							{
								IEnumerator<EventTrigger> enumerator5;
								if (enumerator5 != null)
								{
									enumerator5.Dispose();
								}
							}
						}
						List<EventTrigger> list2 = new List<EventTrigger>();
						try
						{
							foreach (EventTrigger eventTrigger2 in scenario_0.vmethod_4().Values)
							{
								if (eventTrigger2.eventTriggerType_0 == EventTrigger.EventTriggerType.unitCargoMoved && ((Class330)eventTrigger2).method_9())
								{
									list2.Add(eventTrigger2);
								}
							}
						}
						finally
						{
							IEnumerator<EventTrigger> enumerator6;
							if (enumerator6 != null)
							{
								enumerator6.Dispose();
							}
						}
						if (flag)
						{
							try
							{
								foreach (EventTrigger eventTrigger3 in scenario_0.vmethod_4().Values)
								{
									if (eventTrigger3.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitRemainsInArea && ((Class333)eventTrigger3).method_8(scenario_0, GameGeneral.float_0))
									{
										list2.Add(eventTrigger3);
									}
								}
							}
							finally
							{
								IEnumerator<EventTrigger> enumerator7;
								if (enumerator7 != null)
								{
									enumerator7.Dispose();
								}
							}
							GameGeneral.float_0 = 0f;
						}
						scenario_0.method_24(list2);
					}
				}
				catch (Exception ex6)
				{
					ex6.Data.Add("Error at 300007", "");
					GameGeneral.smethod_25(ref ex6);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					try
					{
						foreach (CMANO.Class446 class4 in CMANO.list_0)
						{
							class4.luaFunction_0.Call(class4.list_0.ToArray());
						}
					}
					finally
					{
						List<CMANO.Class446>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
				}
				catch (Exception ex7)
				{
				}
			}
			catch (Exception ex8)
			{
				ex8.Data.Add("Error at 300009", "");
				GameGeneral.smethod_25(ref ex8);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x002920DC File Offset: 0x002902DC
		private static void smethod_19(Scenario scenario_0, float float_1)
		{
			GameGeneral.Class530 @class = new GameGeneral.Class530(@class);
			@class.scenario_0 = scenario_0;
			@class.float_0 = float_1;
			try
			{
				GameGeneral.Class532 class2 = new GameGeneral.Class532(class2);
				class2.class530_0 = @class;
				class2.class530_0.scenario_0.method_18(null);
				class2.class530_0.scenario_0.method_20(null);
				class2.class530_0.scenario_0.method_22(null);
				class2.class530_0.scenario_0.method_17();
				GameGeneral.dictionary_0 = new Dictionary<string, HashSet<string>>();
				Parallel.ForEach<Side>(class2.class530_0.scenario_0.method_44(), new Action<Side>(class2.class530_0.method_0));
				foreach (Side side in class2.class530_0.scenario_0.method_44())
				{
					HashSet<string> hashSet = new HashSet<string>();
					side.method_70(class2.class530_0.scenario_0, hashSet);
					hashSet.Remove(side.string_0);
					GameGeneral.dictionary_0.Add(side.string_0, hashSet);
				}
				if (class2.class530_0.scenario_0.vmethod_20().Count > 0)
				{
					int count = class2.class530_0.scenario_0.vmethod_20().Count;
					List<UnguidedWeapon> list = Enumerable.ToList<UnguidedWeapon>(class2.class530_0.scenario_0.vmethod_20().Values);
					for (int j = count - 1; j >= 0; j += -1)
					{
						UnguidedWeapon unguidedWeapon = list[j];
					}
				}
				class2.class530_0.scenario_0.Cache_TimeOfDay = new Weather.TTimeOfDayType?[360][];
				class2.class530_0.scenario_0.method_43(null);
				Side[] array2 = class2.class530_0.scenario_0.method_44();
				checked
				{
					for (int k = 0; k < array2.Length; k++)
					{
						GameGeneral.Class531 class3 = new GameGeneral.Class531(class3);
						class3.class532_0 = class2;
						class3.side_0 = array2[k];
						Parallel.ForEach<Contact>(class3.side_0.method_44(), new Action<Contact>(class3.method_0));
					}
					GameGeneral.dictionary_1.Clear();
					try
					{
						foreach (ActiveUnit key in class2.class530_0.scenario_0.method_42())
						{
							GameGeneral.dictionary_1.Add(key, false);
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
					Parallel.ForEach<ActiveUnit>(class2.class530_0.scenario_0.method_42(), new Action<ActiveUnit>(class2.method_0));
					class2.class530_0.scenario_0.Cache_FacilitiesWithPiers.Clear();
					try
					{
						foreach (ActiveUnit item in class2.concurrentBag_0)
						{
							class2.class530_0.scenario_0.Cache_FacilitiesWithPiers.Add(item);
						}
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					GameGeneral.smethod_21(ref class2.class530_0.scenario_0);
				}
				new ActiveUnit[class2.class530_0.scenario_0.vmethod_0().Count - 1 + 1];
				class2.class530_0.scenario_0.method_42().ToArray();
				foreach (Side side2 in class2.class530_0.scenario_0.method_44())
				{
					if (side2.vmethod_4() == null)
					{
						side2.vmethod_5(new List<ActiveUnit>(class2.class530_0.scenario_0.vmethod_0().Count));
					}
					if (side2.vmethod_6() == null)
					{
						side2.vmethod_7(new List<ActiveUnit>(class2.class530_0.scenario_0.vmethod_0().Count));
					}
					side2.vmethod_4().Clear();
					side2.vmethod_6().Clear();
					foreach (Side side3 in class2.class530_0.scenario_0.method_44())
					{
						if (side3 != side2 && !GameGeneral.dictionary_0[side3.string_0].Contains(side2.string_0))
						{
							foreach (ActiveUnit activeUnit in side3.activeUnit_0)
							{
								if (!activeUnit.bool_1)
								{
									if (GameGeneral.dictionary_1[activeUnit])
									{
										side2.vmethod_4().Add(activeUnit);
									}
								}
								else
								{
									Group group = (Group)activeUnit;
									if (group.method_143() == Group.GroupType.AirBase || group.method_143() == Group.GroupType.Installation || group.method_143() == Group.GroupType.NavalBase || group.method_143() == Group.GroupType.MobileGroup)
									{
										bool flag = false;
										try
										{
											foreach (Unit unit in group.vmethod_141().Values)
											{
												if (side2.method_11().ContainsKey(unit.string_0))
												{
													flag = true;
													break;
												}
											}
										}
										finally
										{
											IEnumerator<ActiveUnit> enumerator3;
											if (enumerator3 != null)
											{
												enumerator3.Dispose();
											}
										}
										if (flag)
										{
											side2.vmethod_6().Add(activeUnit);
										}
									}
								}
							}
						}
					}
					if (class2.class530_0.scenario_0.SecondIsChangingOnThisPulse)
					{
						try
						{
							foreach (Weapon weapon in class2.class530_0.scenario_0.method_21())
							{
								weapon.method_189().method_16(class2.class530_0.float_0);
							}
						}
						finally
						{
							List<Weapon>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
					if (class2.class530_0.scenario_0.MinuteIsChangingOnThisPulse)
					{
						GameGeneral.Class530 class530_ = class2.class530_0;
						Mission mission = null;
						GameGeneral.smethod_27(ref class530_.scenario_0, ref side2, ref mission, false, true, true);
					}
					if (class2.class530_0.scenario_0.FifteenthSecondIsChangingOnThisPulse)
					{
						float num = class2.class530_0.float_0;
						GameGeneral.Class530 class530_2 = class2.class530_0;
						ActiveUnit activeUnit2 = null;
						Class514.smethod_66(num, ref class530_2.scenario_0, ref side2, ref activeUnit2);
					}
				}
				Parallel.ForEach<Side>(class2.class530_0.scenario_0.method_44(), new Action<Side>(class2.class530_0.method_1));
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 300010", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00292774 File Offset: 0x00290974
		private static void smethod_20(Scenario scenario_0, float float_1)
		{
			GameGeneral.Class535 @class = new GameGeneral.Class535(@class);
			@class.scenario_0 = scenario_0;
			@class.float_0 = float_1;
			try
			{
				@class.scenario_0.method_63();
				checked
				{
					try
					{
						List<ActiveUnit> list = Enumerable.ToList<ActiveUnit>(@class.scenario_0.method_46());
						try
						{
							foreach (ActiveUnit activeUnit_ in list)
							{
								Side[] array = @class.scenario_0.method_44();
								for (int i = 0; i < array.Length; i++)
								{
									Class429.smethod_1(ref array[i].activeUnit_0, activeUnit_);
								}
							}
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						Dictionary<string, HashSet<string>> dictionary = new Dictionary<string, HashSet<string>>();
						foreach (Side side in @class.scenario_0.method_44())
						{
							HashSet<string> hashSet = new HashSet<string>();
							side.method_70(@class.scenario_0, hashSet);
							hashSet.Remove(side.string_0);
							dictionary.Add(side.string_0, hashSet);
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 101255", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					GameGeneral.smethod_24(@class.scenario_0, GameGeneral.dictionary_0);
				}
				try
				{
					GameGeneral.Class533 class2 = new GameGeneral.Class533(class2);
					class2.class535_0 = @class;
					Side[] array3 = class2.class535_0.scenario_0.method_44();
					int k = 0;
					while (k < array3.Length)
					{
						Side side2 = array3[k];
						side2.method_50(class2.class535_0.scenario_0, null);
						side2.method_20(class2.class535_0.scenario_0);
						side2.method_21(class2.class535_0.scenario_0);
						bool flag = side2.list_6.Count > 0;
						try
						{
							try
							{
								foreach (Contact contact in side2.method_44())
								{
									contact.method_62(class2.class535_0.float_0, side2, class2.class535_0.scenario_0);
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							goto IL_1177;
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 200291", "");
							GameGeneral.smethod_25(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							goto IL_1177;
						}
						List<Contact> list2;
						try
						{
							IL_24B:
							list2.AddRange(side2.method_44());
						}
						catch (Exception ex3)
						{
							ex3.Data.Add("Error at 200003", "");
							GameGeneral.smethod_25(ref ex3);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							list2.AddRange(side2.method_44());
						}
						ActiveUnit[] array4 = null;
						List<Contact> list3;
						try
						{
							foreach (Contact contact2 in list2)
							{
								if (contact2.activeUnit_0 != null)
								{
									if (contact2.activeUnit_0.method_5() && contact2.method_125() < Contact_Base.IdentificationStatus.PreciseID && contact2.activeUnit_0.method_92(side2))
									{
										contact2.method_126(class2.class535_0.scenario_0, side2, null, null, false, true, false, true, Contact_Base.IdentificationStatus.PreciseID);
									}
									if (contact2 != null && !contact2.activeUnit_0.method_92(side2) && contact2.side_1 != null)
									{
										if (contact2.side_1 != side2)
										{
											if (contact2.side_1.activeUnit_0.Length != 0 && GameGeneral.dictionary_0[contact2.side_1.string_0].Contains(side2.string_0))
											{
												continue;
											}
											if (contact2.side_1.activeUnit_0.Length > 0)
											{
												HashSet<string> hashSet2 = new HashSet<string>();
												side2.method_70(class2.class535_0.scenario_0, hashSet2);
												try
												{
													foreach (string key in hashSet2)
													{
														GameGeneral.dictionary_0[key].Contains(contact2.side_1.string_0);
													}
												}
												finally
												{
													HashSet<string>.Enumerator enumerator4;
													enumerator4.Dispose();
												}
												list3.Add(contact2);
												continue;
											}
											list3.Add(contact2);
											continue;
										}
										else if (contact2.activeUnit_0.vmethod_7(false) == side2)
										{
											if (array4 == null)
											{
												array4 = new ActiveUnit[0];
												foreach (Side side3 in class2.class535_0.scenario_0.method_44())
												{
													if (side3 == side2 | side3.method_68(side2) == Misc.PostureStance.Friendly)
													{
														foreach (ActiveUnit activeUnit in side3.activeUnit_0)
														{
															if (!activeUnit.vmethod_90().vmethod_1())
															{
																array4 = (ActiveUnit[])Utils.CopyArray(array4, new ActiveUnit[array4.Length + 1]);
																array4[array4.Length - 1] = activeUnit;
															}
														}
													}
												}
											}
											if (!Enumerable.Contains<ActiveUnit>(array4, contact2.activeUnit_0))
											{
												list3.Add(contact2);
												class2.class535_0.scenario_0.method_59(string.Concat(new string[]
												{
													"Contact ",
													contact2.Name,
													" detected by ",
													contact2.side_1.method_51(),
													" droppped - ",
													GameGeneral.dictionary_0[contact2.activeUnit_0.vmethod_7(false).string_0].Contains(side2.string_0) ? "for known friendly unit " : "",
													(contact2.activeUnit_0.vmethod_7(false) == side2) ? "for my unit" : ""
												}), "Contact dropped deliberately", LoggedMessage.MessageType.ContactChange, 0, null, side2, new Geopoint_Struct(contact2.vmethod_28(null), contact2.vmethod_30(null)));
												continue;
											}
											continue;
										}
										else if (GameGeneral.dictionary_0[contact2.activeUnit_0.vmethod_7(false).string_0].Contains(side2.string_0))
										{
											if (array4 == null)
											{
												array4 = new ActiveUnit[0];
												foreach (Side side4 in class2.class535_0.scenario_0.method_44())
												{
													if (side4 == side2 | side4.method_68(side2) == Misc.PostureStance.Friendly)
													{
														foreach (ActiveUnit activeUnit2 in side4.activeUnit_0)
														{
															if (!activeUnit2.vmethod_90().vmethod_1())
															{
																array4 = (ActiveUnit[])Utils.CopyArray(array4, new ActiveUnit[array4.Length + 1]);
																array4[array4.Length - 1] = activeUnit2;
															}
														}
													}
												}
											}
											if (!Enumerable.Contains<ActiveUnit>(array4, contact2.activeUnit_0))
											{
												list3.Add(contact2);
												class2.class535_0.scenario_0.method_59(string.Concat(new string[]
												{
													"Contact ",
													contact2.Name,
													" detected by ",
													contact2.side_1.method_51(),
													" droppped - ",
													GameGeneral.dictionary_0[contact2.activeUnit_0.vmethod_7(false).string_0].Contains(side2.string_0) ? "for known friendly unit " : "",
													(contact2.activeUnit_0.vmethod_7(false) == side2) ? "for my unit" : ""
												}), "Contact dropped deliberately", LoggedMessage.MessageType.ContactChange, 0, null, side2, new Geopoint_Struct(contact2.vmethod_28(null), contact2.vmethod_30(null)));
												continue;
											}
											continue;
										}
									}
									if (class2.class535_0.scenario_0.SecondIsChangingOnThisPulse)
									{
										side2.method_64(class2.class535_0.scenario_0, contact2);
									}
									if (class2.class535_0.scenario_0.FifthSecondIsChangingOnThisPulse && flag)
									{
										if (contact2.bool_21)
										{
											continue;
										}
										if (contact2.activeUnit_0 == null || !contact2.activeUnit_0.bool_6 || !((Ship)contact2.activeUnit_0).method_152())
										{
											Misc.PostureStance postureStance;
											if (!side2.dictionary_4.TryGetValue(contact2.string_0, out postureStance))
											{
												postureStance = contact2.method_130(side2);
											}
											if (postureStance != Misc.PostureStance.Hostile && postureStance != Misc.PostureStance.Friendly)
											{
												try
												{
													List<ExclusionZone>.Enumerator enumerator5 = side2.list_6.GetEnumerator();
													IL_C3B:
													while (enumerator5.MoveNext())
													{
														ExclusionZone exclusionZone = enumerator5.Current;
														if (postureStance != Misc.PostureStance.Hostile && exclusionZone.list_0.Count != 0 && contact2.activeUnit_0 != null && exclusionZone.method_8(contact2.activeUnit_0) && contact2.activeUnit_0.vmethod_46(exclusionZone.list_0, class2.class535_0.scenario_0, true) && contact2.vmethod_46(exclusionZone.list_0, class2.class535_0.scenario_0, true))
														{
															Misc.PostureStance postureStance_ = exclusionZone.postureStance_0;
															if (postureStance != postureStance_)
															{
																if (postureStance_ != Misc.PostureStance.Unfriendly)
																{
																	if (postureStance_ == Misc.PostureStance.Hostile)
																	{
																		if (array4 == null)
																		{
																			array4 = new ActiveUnit[0];
																			foreach (Side side5 in class2.class535_0.scenario_0.method_44())
																			{
																				if (side5 == side2 | side5.method_68(side2) == Misc.PostureStance.Friendly)
																				{
																					foreach (ActiveUnit activeUnit3 in side5.activeUnit_0)
																					{
																						if (!activeUnit3.vmethod_90().vmethod_1())
																						{
																							array4 = (ActiveUnit[])Utils.CopyArray(array4, new ActiveUnit[array4.Length + 1]);
																							array4[array4.Length - 1] = activeUnit3;
																						}
																					}
																				}
																			}
																		}
																		checked
																		{
																			if (array4.Length > 0)
																			{
																				bool flag2 = false;
																				ActiveUnit[] array8 = array4;
																				int num4 = 0;
																				while (num4 < array8.Length)
																				{
																					ActiveUnit activeUnit4 = array8[num4];
																					bool isAttached = Debugger.IsAttached;
																					if (((activeUnit4.bool_3 && contact2.method_104()) || (activeUnit4.bool_6 && contact2.method_108()) || (activeUnit4.bool_5 && contact2.method_136()) || (activeUnit4.bool_8 && contact2.contactType_0 == Contact_Base.ContactType.Facility_Mobile)) && contact2.method_25(activeUnit4.method_56().Value, activeUnit4.method_58().Value) < 10f && postureStance != Misc.PostureStance.Unfriendly)
																					{
																						class2.class535_0.scenario_0.method_59(string.Concat(new string[]
																						{
																							"Contact: ",
																							contact2.Name,
																							" has violated Exclusion Zone: ",
																							exclusionZone.string_2,
																							" but is near the last reported location of ",
																							activeUnit4.Name,
																							", so marking as UNFRIENDLY for further investigation"
																						}), contact2.Name + " is unfriendly", LoggedMessage.MessageType.ContactChange, 0, null, side2, new Geopoint_Struct(contact2.vmethod_28(null), contact2.vmethod_30(null)));
																						flag2 = true;
																						IL_AF8:
																						if (flag2)
																						{
																							contact2.method_131(side2, false, Misc.PostureStance.Unfriendly);
																							contact2.bool_21 = true;
																							goto IL_C3B;
																						}
																						goto IL_B14;
																					}
																					else
																					{
																						num4++;
																					}
																				}
																				goto IL_AF8;
																			}
																			IL_B14:
																			class2.class535_0.scenario_0.method_59(string.Concat(new string[]
																			{
																				"Contact: ",
																				contact2.Name,
																				" has violated Exclusion Zone: ",
																				exclusionZone.string_2,
																				" and is now considered HOSTILE"
																			}), contact2.Name + "is HOSTILE!", LoggedMessage.MessageType.ContactChange, 0, null, side2, new Geopoint_Struct(contact2.vmethod_28(null), contact2.vmethod_30(null)));
																			contact2.method_131(side2, false, postureStance_);
																		}
																	}
																}
																else
																{
																	class2.class535_0.scenario_0.method_59(string.Concat(new string[]
																	{
																		"Contact: ",
																		contact2.Name,
																		" has violated Exclusion Zone: ",
																		exclusionZone.string_2,
																		" and is now considered UNFRIENDLY"
																	}), contact2.Name + " is UNFRIENDLY", LoggedMessage.MessageType.ContactChange, 0, null, side2, new Geopoint_Struct(contact2.vmethod_28(null), contact2.vmethod_30(null)));
																	contact2.method_131(side2, false, postureStance_);
																}
															}
														}
													}
												}
												finally
												{
													List<ExclusionZone>.Enumerator enumerator5;
													((IDisposable)enumerator5).Dispose();
												}
											}
										}
									}
									if (contact2.activeUnit_0 != null && !class2.class535_0.scenario_0.vmethod_0().ContainsKey(contact2.activeUnit_0.string_0))
									{
										side2.method_15(contact2, ref class2.class535_0.scenario_0, true);
									}
									if (contact2.activeUnit_0 == null)
									{
										side2.method_15(contact2, ref class2.class535_0.scenario_0, true);
									}
									if (contact2.activeUnit_0 != null)
									{
										if (contact2.activeUnit_0.method_92(side2))
										{
											ActiveUnit_Sensory.smethod_3(ref contact2, contact2.activeUnit_0, false, null);
										}
										if (!contact2.activeUnit_0.vmethod_127())
										{
											side2.method_15(contact2, ref class2.class535_0.scenario_0, true);
										}
									}
									if (contact2.method_57() == 0f)
									{
										Contact contact3 = contact2;
										ref float ptr = ref contact3.float_16;
										contact3.float_16 = ptr + class2.class535_0.float_0;
									}
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						try
						{
							foreach (Contact contact4 in side2.method_46())
							{
								if (contact4.activeUnit_0 != null)
								{
									if (contact4.activeUnit_0 != null && !class2.class535_0.scenario_0.vmethod_0().ContainsKey(contact4.activeUnit_0.string_0))
									{
										side2.method_17(contact4, ref class2.class535_0.scenario_0, true);
									}
									if (contact4.activeUnit_0 == null)
									{
										side2.method_17(contact4, ref class2.class535_0.scenario_0, true);
									}
									else if (contact4.contactType_0 == Contact_Base.ContactType.MobileGroup)
									{
										bool flag3 = false;
										try
										{
											foreach (Unit unit in ((Group)contact4.activeUnit_0).vmethod_141().Values)
											{
												if (side2.method_11().ContainsKey(unit.string_0))
												{
													flag3 = true;
													break;
												}
											}
										}
										finally
										{
											IEnumerator<ActiveUnit> enumerator7;
											if (enumerator7 != null)
											{
												enumerator7.Dispose();
											}
										}
										if (!flag3)
										{
											side2.method_17(contact4, ref class2.class535_0.scenario_0, true);
										}
									}
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator6;
							((IDisposable)enumerator6).Dispose();
						}
						int count = side2.vmethod_12().Count;
						List<ReferencePoint> list4 = new List<ReferencePoint>(count);
						int num5 = count - 1;
						for (int num6 = 0; num6 <= num5; num6++)
						{
							list4.Add(side2.vmethod_12()[num6]);
						}
						try
						{
							foreach (ExclusionZone exclusionZone2 in side2.list_6)
							{
								try
								{
									foreach (ReferencePoint referencePoint in exclusionZone2.list_0)
									{
										if (referencePoint.unit_0 != null && !side2.vmethod_12().Contains(referencePoint))
										{
											list4.Add(referencePoint);
										}
									}
								}
								finally
								{
									List<ReferencePoint>.Enumerator enumerator9;
									((IDisposable)enumerator9).Dispose();
								}
							}
						}
						finally
						{
							List<ExclusionZone>.Enumerator enumerator8;
							((IDisposable)enumerator8).Dispose();
						}
						try
						{
							foreach (NoNavZone noNavZone in side2.list_7)
							{
								try
								{
									foreach (ReferencePoint referencePoint2 in noNavZone.list_0)
									{
										if (referencePoint2.unit_0 != null && !side2.vmethod_12().Contains(referencePoint2))
										{
											list4.Add(referencePoint2);
										}
									}
								}
								finally
								{
									List<ReferencePoint>.Enumerator enumerator11;
									((IDisposable)enumerator11).Dispose();
								}
							}
						}
						finally
						{
							List<NoNavZone>.Enumerator enumerator10;
							((IDisposable)enumerator10).Dispose();
						}
						try
						{
							foreach (ReferencePoint referencePoint3 in list4)
							{
								if (referencePoint3 != null && referencePoint3.unit_0 != null)
								{
									if (referencePoint3.unit_0.bool_0 && !class2.class535_0.scenario_0.vmethod_0().ContainsKey(referencePoint3.unit_0.string_0))
									{
										referencePoint3.unit_0 = null;
									}
									else if (referencePoint3.unit_0.method_14() && !side2.method_11().ContainsKey(referencePoint3.unit_0.string_0))
									{
										referencePoint3.unit_0 = null;
									}
									else
									{
										ReferencePoint.OrientationType orientationType_ = referencePoint3.orientationType_0;
										float num7;
										if (orientationType_ != ReferencePoint.OrientationType.Fixed)
										{
											if (orientationType_ == ReferencePoint.OrientationType.Rotating)
											{
												num7 = Math2.smethod_7(referencePoint3.unit_0.vmethod_9() + referencePoint3.float_1);
											}
										}
										else
										{
											num7 = referencePoint3.float_1;
										}
										double double_ = referencePoint3.unit_0.vmethod_28(null);
										double double_2 = referencePoint3.unit_0.vmethod_30(null);
										ReferencePoint referencePoint4;
										double double_3 = (referencePoint4 = referencePoint3).imethod_0();
										ReferencePoint referencePoint5;
										double double_4 = (referencePoint5 = referencePoint3).imethod_2();
										Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)referencePoint3.float_2, (double)num7);
										referencePoint5.imethod_3(double_4);
										referencePoint4.imethod_1(double_3);
									}
								}
							}
						}
						finally
						{
							List<ReferencePoint>.Enumerator enumerator12;
							((IDisposable)enumerator12).Dispose();
						}
						try
						{
							foreach (Contact contact_ in list3)
							{
								side2.method_15(contact_, ref class2.class535_0.scenario_0, true);
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator13;
							((IDisposable)enumerator13).Dispose();
						}
						checked
						{
							k++;
							continue;
							IL_1177:
							list3 = new List<Contact>();
							list2 = new List<Contact>();
							goto IL_24B;
						}
					}
					Task[] array9 = new Task[GameGeneral.int_2 - 1 + 1];
					class2.list_0 = Misc.smethod_66<ActiveUnit>(class2.class535_0.scenario_0.method_42(), GameGeneral.int_2);
					int num8 = GameGeneral.int_2 - 1;
					for (int num9 = 0; num9 <= num8; num9++)
					{
						GameGeneral.Class534 class3 = new GameGeneral.Class534(class3);
						class3.class533_0 = class2;
						class3.int_0 = num9;
						array9[num9] = Task.Factory.StartNew(new Action(class3.method_0));
					}
					Task.WaitAll(array9);
				}
				catch (Exception ex4)
				{
					ex4.Data.Add("Error at 101254", "");
					GameGeneral.smethod_25(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				@class.scenario_0.method_43(null);
				@class.scenario_0.method_18(null);
				@class.scenario_0.method_20(null);
				@class.scenario_0.method_22(null);
				@class.scenario_0.method_60();
				@class.scenario_0.method_61();
				if (@class.scenario_0.CurrentlyInsertingMessages)
				{
					@class.scenario_0.EventWaitHandle_FinishPulse.WaitOne();
				}
			}
			catch (Exception ex5)
			{
				ex5.Data.Add("Error at 300012", "");
				GameGeneral.smethod_25(ref ex5);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00293C24 File Offset: 0x00291E24
		private static void smethod_21(ref Scenario scenario_0)
		{
			try
			{
				scenario_0.Groups.Clear();
				try
				{
					foreach (ActiveUnit activeUnit in scenario_0.method_42())
					{
						if (activeUnit != null && activeUnit.bool_1)
						{
							scenario_0.Groups.Add((Group)activeUnit);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 300013", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00010F7E File Offset: 0x0000F17E
		public static void smethod_22(ref ActiveUnit activeUnit_0, ref Scenario scenario_0)
		{
			scenario_0.vmethod_0().Add(activeUnit_0.string_0, activeUnit_0);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00293CE0 File Offset: 0x00291EE0
		private static void smethod_23(ref Scenario scenario_0, float float_1, ref Random random_0)
		{
			try
			{
				if (scenario_0.vmethod_12().Count > 0)
				{
					for (int i = scenario_0.vmethod_12().Count - 1; i >= 0; i += -1)
					{
						scenario_0.vmethod_12()[i].method_65(ref scenario_0, float_1);
					}
				}
				if (scenario_0.vmethod_14().Count > 0)
				{
					for (int j = scenario_0.vmethod_14().Count - 1; j >= 0; j += -1)
					{
						scenario_0.vmethod_14()[j].method_56(ref scenario_0, float_1);
					}
				}
				if (scenario_0.ChaffClouds.Count > 0)
				{
					for (int k = scenario_0.ChaffClouds.Count - 1; k >= 0; k += -1)
					{
						ChaffCorridorCloud chaffCorridorCloud = scenario_0.ChaffClouds[k];
						chaffCorridorCloud.method_56(float_1);
						if (chaffCorridorCloud.vmethod_14(false) < 0f || (int)Terrain.smethod_7(chaffCorridorCloud.vmethod_30(null), chaffCorridorCloud.vmethod_28(null), false) > chaffCorridorCloud.method_59())
						{
							scenario_0.ChaffClouds.Remove(chaffCorridorCloud);
						}
					}
				}
				if (scenario_0.vmethod_16().Count > 0)
				{
					for (int l = scenario_0.vmethod_16().Count - 1; l >= 0; l += -1)
					{
						scenario_0.vmethod_16()[l].method_56(scenario_0, float_1);
					}
				}
				if (scenario_0.vmethod_18().Count > 0)
				{
					for (int m = scenario_0.vmethod_18().Count - 1; m >= 0; m += -1)
					{
						scenario_0.vmethod_18()[m].method_56(scenario_0, float_1);
					}
				}
				scenario_0.CandidatesForDetectionByMines = new ActiveUnit[0];
				List<ActiveUnit> list = scenario_0.method_42();
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						if (activeUnit != null && (activeUnit.bool_6 || activeUnit.bool_5 || activeUnit.vmethod_59()) && activeUnit.vmethod_127())
						{
							Class429.smethod_0(ref scenario_0.CandidatesForDetectionByMines, activeUnit);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (scenario_0.vmethod_20().Count > 0)
				{
					int count = scenario_0.vmethod_20().Count;
					List<UnguidedWeapon> list2 = Enumerable.ToList<UnguidedWeapon>(scenario_0.vmethod_20().Values);
					for (int n = count - 1; n >= 0; n += -1)
					{
						list2[n].method_73(ref scenario_0, float_1, ref random_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 300016", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00293FAC File Offset: 0x002921AC
		public static void smethod_24(Scenario scenario_0, Dictionary<string, HashSet<string>> dictionary_2)
		{
			checked
			{
				try
				{
					Side[] array = scenario_0.method_44();
					int i = 0;
					while (i < array.Length)
					{
						Side side = array[i];
						List<Contact> list = new List<Contact>();
						try
						{
							list.AddRange(side.method_44());
							goto IL_10E;
						}
						catch (Exception ex)
						{
							list.AddRange(side.method_44());
							goto IL_10E;
						}
						List<Contact> list2;
						try
						{
							IL_4B:
							foreach (Contact contact in list)
							{
								if (contact.bool_12 && !Information.IsNothing(contact.activeUnit_0) && !contact.activeUnit_0.method_67(side) && dictionary_2[contact.activeUnit_0.vmethod_7(false).string_0].Contains(side.string_0))
								{
									list2.Add(contact);
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						try
						{
							foreach (Contact contact_ in list2)
							{
								side.method_15(contact_, ref scenario_0, false);
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						i++;
						continue;
						IL_10E:
						list2 = new List<Contact>();
						goto IL_4B;
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 300019", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00294170 File Offset: 0x00292370
		public static void smethod_25(ref Exception exception_1)
		{
			try
			{
				if (Class570.class280_0 == null || Class570.class280_0.method_50())
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(DateAndTime.Now).Append(" -- B").Append("1115.6").Append(" -- ").Append(exception_1.Message).Append("\r\n").Append("Exception: ").Append(exception_1.Message).Append("\r\n").Append("Stack Trace: ").Append(exception_1.StackTrace).Append("\r\n");
					if (exception_1.InnerException != null)
					{
						stringBuilder.Append("Inner Exception: ").Append(exception_1.InnerException.Message).Append("\r\n").Append("Inner StackTrace: ").Append(exception_1.InnerException.StackTrace).Append("\r\n");
					}
					if (exception_1.Data.Count > 0)
					{
						stringBuilder.Append("Call Stack & Error details: ");
						foreach (object obj in exception_1.Data)
						{
							DictionaryEntry dictionaryEntry = (obj != null) ? ((DictionaryEntry)obj) : default(DictionaryEntry);
							stringBuilder.Append("\r\n").Append(Conversions.ToString(dictionaryEntry.Key)).Append(", ").Append(Conversions.ToString(dictionaryEntry.Value));
						}
					}
					try
					{
						StreamWriter streamWriter = File.AppendText(Class160.smethod_1().Info.DirectoryPath + "\\Logs\\ExceptionLog.txt");
						streamWriter.Write("\r\n\r\n" + stringBuilder.ToString());
						streamWriter.Close();
					}
					catch (Exception ex)
					{
					}
					stringBuilder.Clear();
					stringBuilder = null;
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

		// Token: 0x06002324 RID: 8996 RVA: 0x0029439C File Offset: 0x0029259C
		public static void smethod_26(ref string string_14)
		{
			try
			{
				if (Information.IsNothing(Class570.class280_0) || Class570.class280_0.method_50())
				{
					try
					{
						StreamWriter streamWriter = File.AppendText(Class160.smethod_1().Info.DirectoryPath + "\\Logs\\ExceptionLog.txt");
						streamWriter.Write("\r\n\r\n" + string_14);
						streamWriter.Close();
					}
					catch (Exception ex)
					{
					}
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

		// Token: 0x06002325 RID: 8997 RVA: 0x00294440 File Offset: 0x00292640
		public static void smethod_27(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, bool bool_7, bool bool_8, bool bool_9)
		{
			try
			{
				if (!Information.IsNothing(side_0.method_35()))
				{
					try
					{
						foreach (Mission mission in side_0.method_36(scenario_0))
						{
							if (!Information.IsNothing(mission))
							{
								bool flag = false;
								if (Information.IsNothing(mission_0) || mission == mission_0)
								{
									if (mission.method_10(scenario_0) == Mission.Enum89.const_1)
									{
										if (mission.method_24() != null)
										{
											DateTime? dateTime = mission.method_24();
											DateTime t = scenario_0.method_31();
											if (((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t) <= 0) : null).GetValueOrDefault() && (mission.method_27() == null || (mission.method_27() != null && DateTime.Compare(mission.method_27().Value, scenario_0.method_31()) > 0)))
											{
												mission.method_11(scenario_0, Mission.Enum89.const_0);
												scenario_0.method_59("Mission " + mission.Name + " has been activated.", mission.Name + "is activated", LoggedMessage.MessageType.UnitAI, 0, null, side_0, default(Geopoint_Struct));
											}
										}
									}
									else
									{
										if (mission.method_24() != null)
										{
											DateTime? dateTime = mission.method_24();
											DateTime t = scenario_0.method_31();
											if (((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t) > 0) : null).GetValueOrDefault())
											{
												mission.method_11(scenario_0, Mission.Enum89.const_1);
												continue;
											}
										}
										if (mission.method_27() != null)
										{
											DateTime? dateTime = mission.method_27();
											DateTime t = scenario_0.method_31();
											if (((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t) <= 0) : null).GetValueOrDefault())
											{
												mission.method_11(scenario_0, Mission.Enum89.const_1);
												flag = true;
												scenario_0.method_59("Mission " + mission.Name + " has been deactivated.", mission.Name + "is deactivated", LoggedMessage.MessageType.UnitAI, 0, null, side_0, default(Geopoint_Struct));
											}
										}
									}
									if (flag)
									{
										try
										{
											foreach (ActiveUnit activeUnit in scenario_0.method_42())
											{
												if (!Information.IsNothing(activeUnit) && !activeUnit.bool_1 && activeUnit.vmethod_127() && activeUnit.vmethod_101() == mission)
												{
													if (activeUnit.bool_3)
													{
														if (activeUnit.vmethod_92().vmethod_7(true, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, false, true))
														{
															string str = "";
															if (Operators.CompareString(activeUnit.Name, activeUnit.string_2, false) != 0)
															{
																str = " (" + activeUnit.string_2 + ")";
															}
															string str2 = "";
															ActiveUnit activeUnit2 = ((Aircraft)activeUnit).method_164().method_21();
															if (!Information.IsNothing(activeUnit2))
															{
																str2 = " (" + activeUnit2.Name + ")";
															}
															activeUnit.scenario_0.method_59(activeUnit.Name + str + " is returning to base" + str2, activeUnit.Name + "is RTB", LoggedMessage.MessageType.AirOps, 5, activeUnit.string_0, activeUnit.vmethod_7(false), new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
														}
													}
													else if ((activeUnit.bool_6 || activeUnit.bool_5) && activeUnit.vmethod_93().method_5(true, ActiveUnit._ActiveUnitStatus.RTB_Manual, false, ActiveUnit._ActiveUnitStatus.Unassigned, false, true))
													{
														string str3 = "";
														ActiveUnit activeUnit3 = activeUnit.vmethod_93().method_2();
														if (!Information.IsNothing(activeUnit3))
														{
															str3 = " (" + activeUnit3.Name + ")";
														}
														activeUnit.scenario_0.method_59(activeUnit.Name + " is returning to docking unit" + str3, activeUnit.Name + "is RTB", LoggedMessage.MessageType.DockingOps, 5, activeUnit.string_0, activeUnit.vmethod_7(false), default(Geopoint_Struct));
													}
												}
											}
											continue;
										}
										finally
										{
											List<ActiveUnit>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
										}
									}
									if (mission.method_10(scenario_0) == Mission.Enum89.const_0 || !bool_8)
									{
										List<Group> list = new List<Group>();
										List<Aircraft> list2 = new List<Aircraft>();
										List<Aircraft> list3 = new List<Aircraft>();
										List<Aircraft> list4 = new List<Aircraft>();
										double num = 120.0;
										bool flag2 = false;
										if (mission.int_0 >= 30)
										{
											mission.int_0 = 1;
										}
										else
										{
											Mission mission2 = mission;
											ref int ptr = ref mission2.int_0;
											mission2.int_0 = ptr + 1;
										}
										List<Aircraft> list5 = new List<Aircraft>();
										List<Aircraft> list6 = new List<Aircraft>();
										List<Aircraft> list7 = new List<Aircraft>();
										List<Aircraft> list8 = new List<Aircraft>();
										List<ActiveUnit> list9 = new List<ActiveUnit>();
										List<int> list10 = new List<int>();
										List<int> list11 = new List<int>();
										List<ActiveUnit> list12 = new List<ActiveUnit>();
										List<ActiveUnit> list13 = new List<ActiveUnit>();
										List<int> list14 = new List<int>();
										List<ActiveUnit> list_ = new List<ActiveUnit>();
										int num2 = 0;
										int num3 = 0;
										int num4 = 0;
										int num5 = 0;
										int num6 = 0;
										int num7 = 0;
										List<Mission.Flight> list15 = new List<Mission.Flight>();
										List<Mission.Flight> list16 = new List<Mission.Flight>();
										List<Mission.Flight> list17 = new List<Mission.Flight>();
										bool flag3 = false;
										float num8 = 0f;
										float num9 = 0f;
										List<Aircraft> list18 = new List<Aircraft>();
										List<Aircraft> list19 = new List<Aircraft>();
										List<Aircraft> list20 = new List<Aircraft>();
										int num10 = 0;
										int num11 = 0;
										int num12 = 0;
										if (bool_7 && !Information.IsNothing(mission.list_2) && mission.list_2.Count > 0)
										{
											int num13 = 1;
											try
											{
												foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in mission.list_2)
												{
													if (emptyAircraftSlot.int_0 != 0)
													{
														Mission mission3 = mission;
														int int_ = emptyAircraftSlot.int_0;
														int int_2 = emptyAircraftSlot.int_1;
														Mission.EmptyAircraftSlot emptyAircraftSlot2;
														Scenario scenario_;
														ActiveUnit activeUnit_ = (emptyAircraftSlot2 = emptyAircraftSlot).method_3(scenario_ = scenario_0);
														Mission.EmptyAircraftSlot emptyAircraftSlot3;
														Scenario scenario_2;
														Mission.Flight flight_ = (emptyAircraftSlot3 = emptyAircraftSlot).method_5(scenario_2 = scenario_0);
														Aircraft aircraft = mission3.method_64(ref scenario_0, ref side_0, int_, int_2, ref activeUnit_, ref flight_, emptyAircraftSlot.bool_2, num13);
														emptyAircraftSlot3.method_6(scenario_2, flight_);
														emptyAircraftSlot2.method_4(scenario_, activeUnit_);
														Aircraft aircraft2 = aircraft;
														emptyAircraftSlot.method_2(scenario_0, null, aircraft2);
														list18.Add(aircraft2);
														num13++;
													}
												}
											}
											finally
											{
												List<Mission.EmptyAircraftSlot>.Enumerator enumerator3;
												((IDisposable)enumerator3).Dispose();
											}
										}
										if (Information.IsNothing(mission_0) && scenario_0.FifteenthMinuteIsChangingOnThisPulse)
										{
											Class514.smethod_65(ref scenario_0, ref mission);
										}
										bool flag4 = false;
										bool flag5 = false;
										bool flag6 = false;
										Mission.Enum99 enum99_;
										if (mission._MissionClass_0 == Mission._MissionClass.Patrol)
										{
											Class343 @class = (Class343)mission;
											flag4 = @class.bool_30;
											flag5 = @class.bool_31;
											enum99_ = @class.enum99_0;
										}
										if (mission._MissionClass_0 == Mission._MissionClass.Support)
										{
											Class344 class2 = (Class344)mission;
											flag4 = class2.bool_28;
											flag5 = class2.bool_29;
											enum99_ = class2.enum99_0;
										}
										if (flag4)
										{
											switch (enum99_)
											{
											case Mission.Enum99.const_0:
												if (scenario_0.FifthMinuteIsChangingOnThisPulse)
												{
													flag6 = true;
												}
												break;
											case Mission.Enum99.const_1:
												if (scenario_0.FifteenthMinuteIsChangingOnThisPulse)
												{
													flag6 = true;
												}
												break;
											case Mission.Enum99.const_2:
												if (scenario_0.ThirtiethMinuteIsChangingOnThisPulse)
												{
													flag6 = true;
												}
												break;
											default:
												if (scenario_0.HourIsChangingOnThisPulse)
												{
													flag6 = true;
												}
												break;
											}
											if (flag6 || !Information.IsNothing(mission_0) || mission.list_1.Count == 0)
											{
												GameGeneral.smethod_29(ref scenario_0, ref side_0, ref mission, !Information.IsNothing(mission_0), num, !Information.IsNothing(mission_0), !Information.IsNothing(mission_0));
												if (flag5)
												{
													GameGeneral.smethod_30(ref scenario_0, ref side_0, ref mission, !Information.IsNothing(mission_0), num, !Information.IsNothing(mission_0), !Information.IsNothing(mission_0));
												}
											}
										}
										if (bool_9)
										{
											GameGeneral.smethod_28(ref scenario_0, ref side_0, ref mission, ref list, ref list2, ref list3, ref list4, num, ref flag2, true, false);
										}
										mission.method_19(ref scenario_0, ref side_0, null);
										if (!mission.bool_15 || (!Information.IsNothing(mission_0) && !flag4))
										{
											mission.method_18(scenario_0, ref list10, ref list11, ref list5, ref list6, ref list7, ref list8, ref list9, ref num2, ref num3, ref num4, ref num5, ref num6, ref num7, ref list14, ref list12, ref list13, list_, ref list18, ref list19, ref list20, ref num10, ref num11, ref num12, ref list15, ref list16, ref list17, bool_8, bool_7, false);
											if (num5 > 0 || (bool_7 && num10 > 0) || ((bool_7 || flag2) && (num6 > 0 || num7 > 0 || num11 > 0 || num12 > 0)))
											{
												List<Aircraft> list21 = new List<Aircraft>();
												List<Aircraft> list22 = new List<Aircraft>();
												List<Aircraft> list23 = new List<Aircraft>();
												int num14 = 0;
												int num15 = 0;
												int num16 = 0;
												int num17 = 0;
												int num18 = 0;
												int num19 = 0;
												Doctrine.Enum56? @enum = mission.doctrine_0.method_152(scenario_0, false, false, false, false);
												string text = "";
												int num20 = 0;
												int num21 = 0;
												bool? flag7;
												bool? flag8;
												if (Information.IsNothing(mission_0) && !Information.IsNothing(@enum))
												{
													byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
													flag7 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
													flag8 = ((flag7 != null) ? new bool?(!flag7.GetValueOrDefault()) : flag7);
												}
												else
												{
													flag8 = new bool?(false);
												}
												flag7 = flag8;
												if (flag7.GetValueOrDefault() && mission.tankerMethod_0 == Mission.TankerMethod.Mission)
												{
													if (Information.IsNothing(mission.list_4) || mission.list_4.Count == 0)
													{
														scenario_0.method_59("Mission " + mission.Name + " requires tankers from specified missions, however no tanker missions have been selected! The strike mission will not launch!", mission.Name + " not launching (no tankers!)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
														continue;
													}
													if (mission.int_1 > 0 || mission.int_2 > 0 || mission.int_3 > 0)
													{
														int num22 = 0;
														int num23 = 0;
														int num24 = 0;
														try
														{
															foreach (Mission mission4 in mission.list_4)
															{
																try
																{
																	foreach (ActiveUnit activeUnit4 in mission4.method_15(scenario_0))
																	{
																		if (activeUnit4.bool_3)
																		{
																			Aircraft aircraft3 = (Aircraft)activeUnit4;
																			if (aircraft3.method_146() && (aircraft3.vmethod_7(false) == side_0 || aircraft3.vmethod_7(false).method_67(side_0)))
																			{
																				if (aircraft3.vmethod_7(false) != side_0)
																				{
																					Doctrine._RefuelAlliedUnits? refuelAlliedUnits = aircraft3.doctrine_0.method_240(scenario_0, false, false, false);
																					byte? b = (refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null;
																					if (((b != null) ? new bool?(b.GetValueOrDefault() == 3) : null).GetValueOrDefault())
																					{
																						continue;
																					}
																					b = ((refuelAlliedUnits != null) ? new byte?((byte)refuelAlliedUnits.GetValueOrDefault()) : null);
																					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
																					{
																						continue;
																					}
																				}
																				num22++;
																				if (aircraft3.vmethod_127())
																				{
																					num23++;
																					if (mission4._MissionClass_0 == Mission._MissionClass.Support && !aircraft3.method_157().method_15())
																					{
																						num24++;
																					}
																				}
																			}
																		}
																	}
																}
																finally
																{
																	List<ActiveUnit>.Enumerator enumerator5;
																	((IDisposable)enumerator5).Dispose();
																}
															}
														}
														finally
														{
															List<Mission>.Enumerator enumerator4;
															((IDisposable)enumerator4).Dispose();
														}
														if (mission.int_1 > 0)
														{
															if (num22 == 0)
															{
																if (mission.int_0 == 1)
																{
																	scenario_0.method_59(string.Concat(new string[]
																	{
																		"Mission ",
																		mission.Name,
																		" requires ",
																		Conversions.ToString(mission.int_1),
																		" tankers in total, however none are available! The mission will not launch!"
																	}), mission.Name + " not launching (no tankers!)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
																	continue;
																}
																continue;
															}
															else if (num22 < mission.int_1)
															{
																if (mission.int_0 == 1)
																{
																	scenario_0.method_59(string.Concat(new string[]
																	{
																		"Mission ",
																		mission.Name,
																		" requires ",
																		Conversions.ToString(mission.int_1),
																		" tankers in total, however only ",
																		Conversions.ToString(num22),
																		" tankers are available! The mission will not launch!"
																	}), mission.Name + " not launching (not enough tankers!)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
																	continue;
																}
																continue;
															}
														}
														if (mission.int_2 > 0)
														{
															if (num23 == 0)
															{
																if (mission.int_0 == 1)
																{
																	scenario_0.method_59(string.Concat(new string[]
																	{
																		"Mission ",
																		mission.Name,
																		" requires ",
																		Conversions.ToString(mission.int_2),
																		" airborne tankers, however none are currently airborne! The mission will not launch!"
																	}), mission.Name + " not launching (no tankers up!)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
																	continue;
																}
																continue;
															}
															else if (num23 < mission.int_2)
															{
																if (mission.int_0 == 1)
																{
																	scenario_0.method_59(string.Concat(new string[]
																	{
																		"Mission ",
																		mission.Name,
																		" requires ",
																		Conversions.ToString(mission.int_2),
																		" airborne tankers, however only ",
																		Conversions.ToString(num23),
																		" tankers are currently airborne! The mission will not launch!"
																	}), mission.Name + " not launching (not enough tankers up!)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
																	continue;
																}
																continue;
															}
														}
														if (mission.int_3 > 0)
														{
															if (num24 == 0)
															{
																if (mission.int_0 == 1)
																{
																	scenario_0.method_59(string.Concat(new string[]
																	{
																		"Mission ",
																		mission.Name,
																		" requires ",
																		Conversions.ToString(mission.int_3),
																		" tankers on station, however none are currently on station! The mission will not launch!"
																	}), mission.Name + " not launching (no tankers on station!)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
																	continue;
																}
																continue;
															}
															else if (num24 < mission.int_3)
															{
																if (mission.int_0 == 1)
																{
																	scenario_0.method_59(string.Concat(new string[]
																	{
																		"Mission ",
																		mission.Name,
																		" requires ",
																		Conversions.ToString(mission.int_3),
																		" tankers on station, however only ",
																		Conversions.ToString(num24),
																		" tankers are currently on station! The mission will not launch!"
																	}), mission.Name + " not launching (not enough tankers on station!)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
																	continue;
																}
																continue;
															}
														}
													}
												}
												try
												{
													foreach (Aircraft aircraft4 in list6)
													{
														aircraft4.method_159().vmethod_7();
													}
												}
												finally
												{
													List<Aircraft>.Enumerator enumerator6;
													((IDisposable)enumerator6).Dispose();
												}
												DateTime? nullable_;
												DateTime? nullable_2;
												Mission.Flight.smethod_2(ref scenario_0, ref mission, ref nullable_, ref nullable_2);
												Mission._FlightSize flightSize;
												Mission._FlightSize flightSize2;
												Mission._FlightSize flightSize3;
												bool flag9;
												bool flag10;
												if (!GameGeneral.smethod_32(ref scenario_0, ref side_0, ref mission, !Information.IsNothing(mission_0), ref list5, ref flightSize, ref flightSize2, ref flightSize3, ref flag9, ref flag10, ref num14, ref num15, ref num16, ref num17, ref num18, ref num19, ref num2, ref num3, ref num4, ref num5, ref num6, ref num7, ref list6, ref list21, ref list22, ref list23, ref @enum, ref flag3, ref list10, ref list11, ref num8, ref num9, ref text, ref num20, ref num21, !Information.IsNothing(mission_0), nullable_, nullable_2, false, ref list9, !Information.IsNothing(mission_0)))
												{
													continue;
												}
												if (list21.Count > 0 || ((bool_7 || flag2) && (list22.Count > 0 || list23.Count > 0)))
												{
													bool bool_10 = !Information.IsNothing(mission_0);
													double double_ = num;
													bool bool_11 = !Information.IsNothing(mission_0);
													bool bool_12 = false;
													Mission.Flight flight_ = null;
													if (!GameGeneral.smethod_37(ref scenario_0, ref side_0, ref mission, bool_10, ref list5, ref flightSize, ref flightSize2, ref flightSize3, ref flag9, ref flag10, ref num14, ref num15, ref num16, ref num17, ref num18, ref num19, ref list21, ref list22, ref list23, ref @enum, ref flag3, ref list10, ref num8, ref num9, bool_8, ref list, ref list2, ref list3, ref list4, ref list9, ref list18, ref text, double_, ref flag2, bool_7, bool_11, bool_12, ref flight_, !Information.IsNothing(mission_0)))
													{
														continue;
													}
												}
											}
										}
										if (bool_9 && mission._MissionClass_0 == Mission._MissionClass.Strike)
										{
											GameGeneral.smethod_28(ref scenario_0, ref side_0, ref mission, ref list, ref list2, ref list3, ref list4, num, ref flag2, false, true);
										}
										if (bool_9 && (mission._MissionClass_0 == Mission._MissionClass.Patrol || mission._MissionClass_0 == Mission._MissionClass.Support))
										{
											GameGeneral.smethod_31(ref scenario_0, ref side_0, ref mission, num);
										}
										if (list13.Count > 0)
										{
											List<ActiveUnit> list24 = new List<ActiveUnit>();
											List<ActiveUnit> list25 = new List<ActiveUnit>();
											List<ActiveUnit> list26 = new List<ActiveUnit>();
											List<ActiveUnit> list27 = new List<ActiveUnit>();
											Mission._GroupSize groupSize;
											Mission._GroupSize groupSize2;
											bool flag11;
											bool flag12;
											if (GameGeneral.smethod_42(ref scenario_0, ref side_0, mission, !Information.IsNothing(mission_0), ref list24, ref list25, ref list26, ref list27, ref groupSize, ref groupSize2, ref flag11, ref flag12, ref list12, ref list13, ref list14) && list24.Count > 0)
											{
												GameGeneral.smethod_43(ref scenario_0, ref side_0, mission, !Information.IsNothing(mission_0), ref list24, ref list25, ref list26, ref list27, ref groupSize, ref groupSize2, ref flag11, ref flag12, ref list_);
											}
										}
									}
								}
							}
						}
					}
					finally
					{
						IEnumerator<Mission> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101246", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x002955DC File Offset: 0x002937DC
		private static void smethod_28(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref List<Group> list_1, ref List<Aircraft> list_2, ref List<Aircraft> list_3, ref List<Aircraft> list_4, double double_0, ref bool bool_7, bool bool_8, bool bool_9)
		{
			try
			{
				if (mission_0.method_54())
				{
					Mission mission = mission_0;
					Scenario scenario_ = scenario_0;
					bool flag = false;
					mission.method_22(scenario_, ref side_0, ref flag, null, true);
					int count = mission_0.list_1.Count;
					List<Mission.Flight> list = new List<Mission.Flight>();
					list_1.Clear();
					list_2.Clear();
					list_3.Clear();
					list_4.Clear();
					if (bool_8)
					{
						for (int i = count - 1; i >= 0; i += -1)
						{
							Mission.Flight flight = mission_0.list_1[i];
							ActiveUnit activeUnit = scenario_0.vmethod_0()[flight.string_5];
							if (flight.bool_11)
							{
								scenario_0.method_59(string.Concat(new string[]
								{
									"Flight ",
									flight.string_4,
									" on mission ",
									mission_0.Name,
									" flying from ",
									flight.string_6,
									", aircraft type ",
									flight.string_12,
									" and loadout type ",
									flight.method_13(scenario_0),
									" has one or more flightplan errors that prevents it from taking off!"
								}), flight.string_4 + " cannot take off (flightplan errors)", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
							}
							else if (flight._FlightTask_0 != Mission._FlightTask.const_48 && !flight.bool_12 && !flight.method_12())
							{
								double num;
								if (!Information.IsNothing(flight.method_15()) && Enumerable.Count<Waypoint>(flight.method_15()) > 0)
								{
									Waypoint waypoint = flight.method_15()[0];
									if (Information.IsNothing(waypoint.nullable_7))
									{
										num = -1.0;
									}
									else
									{
										double totalSeconds = (waypoint.nullable_7.Value - scenario_0.method_31()).TotalSeconds;
										if (totalSeconds < -300.0)
										{
											list.Add(flight);
											scenario_0.method_59(string.Concat(new string[]
											{
												"Flight ",
												flight.string_4,
												" on mission ",
												mission_0.Name,
												" flying from ",
												flight.string_6,
												", aircraft type ",
												flight.string_12,
												" and loadout type ",
												flight.method_13(scenario_0),
												" is more than 5 minutes past its scheduled take-off time. The flight has been cancelled."
											}), flight.string_4 + " cancelled", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
											goto IL_632;
										}
										if (totalSeconds < -double_0 - 60.0)
										{
											scenario_0.method_59(string.Concat(new string[]
											{
												"Flight ",
												flight.string_4,
												" on mission ",
												mission_0.Name,
												" flying from ",
												flight.string_6,
												", aircraft type ",
												flight.string_12,
												" and loadout type ",
												flight.method_13(scenario_0),
												" is scheduled to take off but something has gotten in the way. The flight will be cancelled When it is 5 minutes past its scheduled take-off time."
											}), flight.string_4 + " delayed, danger of cancel", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
										}
										num = totalSeconds - double_0 - 60.0;
									}
								}
								else
								{
									num = -1.0;
								}
								if (flight.int_1 >= (int)flight._FlightSize_1 && flight.int_1 >= flight.int_0 && num < 0.0)
								{
									List<ActiveUnit> list2 = new List<ActiveUnit>();
									foreach (ActiveUnit activeUnit2 in side_0.activeUnit_0)
									{
										if (!Information.IsNothing(activeUnit2.vmethod_101()) && !Information.IsNothing(activeUnit2.vmethod_85().method_7()) && flight == activeUnit2.vmethod_85().method_7() && activeUnit2.bool_3 && !activeUnit2.vmethod_127())
										{
											Aircraft aircraft = (Aircraft)activeUnit2;
											Aircraft aircraft2 = aircraft;
											string text = null;
											if (aircraft2.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && aircraft.vmethod_123())
											{
												list2.Add(activeUnit2);
												list_2.Add((Aircraft)activeUnit2);
											}
										}
									}
									if (list2.Count != 0)
									{
										if (list2.Count > 0)
										{
											if (list2.Count < (int)flight._FlightSize_1)
											{
												try
												{
													foreach (ActiveUnit activeUnit3 in list2)
													{
														list_2.Remove((Aircraft)activeUnit3);
													}
												}
												finally
												{
													List<ActiveUnit>.Enumerator enumerator;
													((IDisposable)enumerator).Dispose();
												}
												if (mission_0.int_0 == 1)
												{
													scenario_0.method_59(string.Concat(new string[]
													{
														"Flight ",
														flight.string_4,
														" requires minimum ",
														Conversions.ToString((int)flight._FlightSize_1),
														" aircraft, however only ",
														Conversions.ToString(list2.Count),
														" are ready for take-off! The flight will not launch!"
													}), flight.string_4 + " not launching (not enough AC ready)", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
													goto IL_632;
												}
												goto IL_632;
											}
											else
											{
												Mission.Flight flight2 = list2[0].vmethod_85().method_7();
												if (list2.Count > 1)
												{
													Group group = new Group(ref scenario_0, ref side_0, list2, true, null, mission_0);
													list_1.Add(group);
													int num2 = 2;
													try
													{
														foreach (ActiveUnit activeUnit4 in group.vmethod_141().Values)
														{
															if (activeUnit4.method_122())
															{
																activeUnit4.method_123(flight2, 1);
																group.Name = "Flight " + flight2.string_4;
															}
															else
															{
																activeUnit4.method_123(flight2, num2);
																num2++;
															}
														}
														goto IL_62E;
													}
													finally
													{
														IEnumerator<ActiveUnit> enumerator2;
														if (enumerator2 != null)
														{
															enumerator2.Dispose();
														}
													}
												}
												list2[0].method_123(flight2, 1);
											}
										}
										IL_62E:
										bool_7 = true;
									}
								}
							}
							IL_632:;
						}
					}
					if (bool_9)
					{
						for (int k = count - 1; k >= 0; k += -1)
						{
							Mission.Flight flight = mission_0.list_1[k];
							ActiveUnit activeUnit5 = scenario_0.vmethod_0()[flight.string_5];
							if (flight.bool_11)
							{
								scenario_0.method_59(string.Concat(new string[]
								{
									"Flight ",
									flight.string_4,
									" on mission ",
									mission_0.Name,
									" flying from ",
									flight.string_6,
									", aircraft type ",
									flight.string_12,
									" and loadout type ",
									flight.method_13(scenario_0),
									" has one or more flightplan errors that prevents it from taking off!"
								}), flight.string_4 + " not launching (flightplan errors)", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit5.vmethod_28(null), activeUnit5.vmethod_30(null)));
							}
							else if (flight._FlightTask_0 != Mission._FlightTask.const_48 && flight.bool_12 && !flight.method_12())
							{
								double num3;
								if (!Information.IsNothing(flight.method_15()) && Enumerable.Count<Waypoint>(flight.method_15()) > 0)
								{
									Waypoint waypoint = flight.method_15()[0];
									if (Information.IsNothing(waypoint.nullable_7))
									{
										if (bool_7)
										{
											num3 = -1.0;
										}
										else
										{
											num3 = double.MaxValue;
										}
									}
									else
									{
										double totalSeconds2 = (waypoint.nullable_7.Value - scenario_0.method_31()).TotalSeconds;
										if (totalSeconds2 < -300.0)
										{
											list.Add(flight);
											scenario_0.method_59(string.Concat(new string[]
											{
												"Flight ",
												flight.string_4,
												" on mission ",
												mission_0.Name,
												" flying from ",
												flight.string_6,
												", aircraft type ",
												flight.string_12,
												" and loadout type ",
												flight.method_13(scenario_0),
												" is more than 5 minutes past its scheduled take-off time. The flight has been cancelled."
											}), flight.string_4 + " cancelled (5 mins overdue)", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit5.vmethod_28(null), activeUnit5.vmethod_30(null)));
											goto IL_C83;
										}
										if (totalSeconds2 < -double_0 - 60.0)
										{
											scenario_0.method_59(string.Concat(new string[]
											{
												"Flight ",
												flight.string_4,
												" on mission ",
												mission_0.Name,
												" flying from ",
												flight.string_6,
												", aircraft type ",
												flight.string_12,
												" and loadout type ",
												flight.method_13(scenario_0),
												" is scheduled to take off but something has gotten in the way. The flight will be cancelled When it is 5 minutes past its scheduled take-off time."
											}), flight.string_4 + " delayed (5-min warning)", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit5.vmethod_28(null), activeUnit5.vmethod_30(null)));
										}
										num3 = totalSeconds2 - double_0 - 60.0;
									}
								}
								else if (bool_7)
								{
									num3 = -1.0;
								}
								else
								{
									num3 = double.MaxValue;
								}
								if (flight.int_1 >= (int)flight._FlightSize_1 && flight.int_1 >= flight.int_0 && num3 < 0.0)
								{
									List<ActiveUnit> list3 = new List<ActiveUnit>();
									foreach (ActiveUnit activeUnit6 in side_0.activeUnit_0)
									{
										if (!Information.IsNothing(activeUnit6.vmethod_101()) && !Information.IsNothing(activeUnit6.vmethod_85().method_7()) && flight == activeUnit6.vmethod_85().method_7() && activeUnit6.bool_3 && !activeUnit6.vmethod_127())
										{
											Aircraft aircraft3 = (Aircraft)activeUnit6;
											Aircraft aircraft4 = aircraft3;
											string text = null;
											if (aircraft4.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && aircraft3.vmethod_123())
											{
												list3.Add(activeUnit6);
												if (aircraft3.method_167().method_12())
												{
													list_4.Add(aircraft3);
												}
												else
												{
													list_3.Add(aircraft3);
												}
											}
										}
									}
									if (list3.Count != 0 && list3.Count > 0)
									{
										if (list3.Count < (int)flight._FlightSize_1)
										{
											try
											{
												foreach (ActiveUnit activeUnit7 in list3)
												{
													if (((Aircraft)activeUnit7).method_167().method_12())
													{
														list_4.Remove((Aircraft)activeUnit7);
													}
													else
													{
														list_3.Remove((Aircraft)activeUnit7);
													}
												}
											}
											finally
											{
												List<ActiveUnit>.Enumerator enumerator3;
												((IDisposable)enumerator3).Dispose();
											}
											if (mission_0.int_0 == 1)
											{
												scenario_0.method_59(string.Concat(new string[]
												{
													"Flight ",
													flight.string_4,
													" requires minimum ",
													Conversions.ToString((int)flight._FlightSize_1),
													" aircraft, however only ",
													Conversions.ToString(list3.Count),
													" are ready For take-off! The flight will Not launch!"
												}), flight.string_4 + " not launching (not enough AC ready)", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit5.vmethod_28(null), activeUnit5.vmethod_30(null)));
											}
										}
										else
										{
											Mission.Flight flight3 = list3[0].vmethod_85().method_7();
											if (list3.Count > 1)
											{
												Group group2 = new Group(ref scenario_0, ref side_0, list3, true, null, mission_0);
												list_1.Add(group2);
												int num4 = 2;
												try
												{
													foreach (ActiveUnit activeUnit8 in group2.vmethod_141().Values)
													{
														if (activeUnit8.method_122())
														{
															activeUnit8.method_123(flight3, 1);
															group2.Name = "Flight " + flight3.string_4;
														}
														else
														{
															activeUnit8.method_123(flight3, num4);
															num4++;
														}
													}
													goto IL_C83;
												}
												finally
												{
													IEnumerator<ActiveUnit> enumerator4;
													if (enumerator4 != null)
													{
														enumerator4.Dispose();
													}
												}
											}
											list3[0].method_123(flight3, 1);
										}
									}
								}
							}
							IL_C83:;
						}
					}
					try
					{
						foreach (Mission.Flight flight4 in list)
						{
							mission_0.method_57(ref scenario_0, ref side_0, ref flight4, flight4.string_0);
						}
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
					mission_0.method_43(ref scenario_0, list_1, list_2, list_3, list_4);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x0029639C File Offset: 0x0029459C
		private static void smethod_29(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, bool bool_7, double double_0, bool bool_8, bool bool_9)
		{
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				List<Aircraft> list2 = new List<Aircraft>();
				List<ActiveUnit> list3 = new List<ActiveUnit>();
				List<int> list4 = new List<int>();
				List<int> list5 = new List<int>();
				List<Mission.Class287> list6;
				Mission.Enum96 enum96_;
				Mission.Enum97 enum97_;
				Mission.Enum98 enum98_;
				Mission.Enum99 enum99_;
				int int_;
				bool bool_10;
				if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
				{
					Class343 @class = (Class343)mission_0;
					list6 = @class.list_21;
					enum96_ = @class.enum96_0;
					enum97_ = @class.enum97_0;
					enum98_ = @class.enum98_0;
					enum99_ = @class.enum99_0;
					int_ = @class.int_7;
					bool_10 = @class.bool_22;
				}
				if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
				{
					Class344 class2 = (Class344)mission_0;
					list6 = class2.list_11;
					enum96_ = class2.enum96_0;
					enum97_ = class2.enum97_0;
					enum98_ = class2.enum98_0;
					enum99_ = class2.enum99_0;
					int_ = class2.int_7;
					bool_10 = class2.bool_22;
				}
				if (enum96_ != Mission.Enum96.const_0)
				{
					if (enum96_ == Mission.Enum96.const_1)
					{
						Mission._FlightSize flightSize_ = mission_0._FlightSize_0;
						bool bool_11 = mission_0.bool_12;
						int num = 0;
						List<Mission.Flight> list7 = new List<Mission.Flight>();
						List<Mission.Flight> list8 = new List<Mission.Flight>();
						try
						{
							foreach (Mission.Flight flight in mission_0.list_1)
							{
								if (flight._FlightTask_0 != Mission._FlightTask.const_48)
								{
									if (flight.enum93_0 == Mission.Enum93.const_1)
									{
										if (!Information.IsNothing(flight.method_15()) && Enumerable.Count<Waypoint>(flight.method_15()) != 0)
										{
											bool flag = false;
											bool flag2 = true;
											foreach (Waypoint waypoint in flight.method_15())
											{
												if (waypoint.method_39())
												{
													flag = true;
												}
												if (waypoint.method_41() && waypoint.float_25 <= 0f)
												{
													GameGeneral.smethod_1("Flightplan " + flight.string_4 + " has no station time set!");
													flag2 = false;
												}
											}
											if (flag2)
											{
												if (!flag)
												{
													GameGeneral.smethod_1("Flightplan " + flight.string_4 + " has no station start / End waypoints! Flightplans must have station waypoints When used As templates For continuous coverage.");
												}
												else
												{
													list7.Add(flight);
												}
											}
										}
										else
										{
											GameGeneral.smethod_1("Flightplan " + flight.string_4 + " has no waypoints! Add waypoints And Try again.");
										}
									}
									else
									{
										list8.Add(flight);
									}
								}
							}
						}
						finally
						{
							List<Mission.Flight>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (list7.Count > 0)
						{
							List<Mission.Class287> list9 = null;
							if (list8.Count == 0 && !Information.IsNothing(list6))
							{
								if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
								{
									((Class343)mission_0).list_21.Clear();
								}
								if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
								{
									((Class344)mission_0).list_11.Clear();
								}
							}
							if (!Information.IsNothing(list6) && list6.Count > 0)
							{
								list9 = Enumerable.ToList<Mission.Class287>(list6);
							}
							int num2;
							if (!Information.IsNothing(list9))
							{
								int count = list9.Count;
								num2 = list8.Count;
								int j = count - 1;
								IL_334:
								while (j >= 0)
								{
									Mission.Class287 class3 = list9[j];
									bool flag3 = false;
									for (int k = num2 - 1; k >= 0; k += -1)
									{
										Mission.Flight flight2 = list8[k];
										if (Operators.CompareString(flight2.string_0, class3.string_0, false) == 0)
										{
											flag3 = true;
											IL_2EE:
											if (!flag3)
											{
												if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
												{
													((Class343)mission_0).list_21.Remove(class3);
												}
												if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
												{
													((Class344)mission_0).list_11.Remove(class3);
												}
											}
											j += -1;
											goto IL_334;
										}
									}
									goto IL_2EE;
								}
							}
							if (!Information.IsNothing(list6) && list6.Count > 0)
							{
								list9 = Enumerable.ToList<Mission.Class287>(list6);
							}
							int count2 = list7.Count;
							if (Information.IsNothing(list9))
							{
								num2 = 0;
							}
							else
							{
								num2 = list9.Count;
							}
							for (int l = count2 - 1; l >= 0; l += -1)
							{
								Mission.Flight flight2 = list7[l];
								bool flag4 = false;
								if (!Information.IsNothing(list9))
								{
									for (int m = num2 - 1; m >= 0; m += -1)
									{
										Mission.Class287 class3 = list9[m];
										if (Operators.CompareString(flight2.string_0, class3.string_2, false) == 0)
										{
											flag4 = true;
											break;
										}
									}
								}
								if (!flag4)
								{
									int dbid;
									int num3;
									string text;
									if (!Information.IsNothing(flight2.method_32(scenario_0)))
									{
										Aircraft aircraft = (Aircraft)flight2.method_32(scenario_0);
										dbid = aircraft.DBID;
										num3 = aircraft.method_166();
										if (!Information.IsNothing(aircraft.method_164().method_30()))
										{
											text = aircraft.method_164().method_30().string_0;
										}
										else if (!Information.IsNothing(aircraft.method_164().method_32(false)))
										{
											text = aircraft.method_164().method_32(false).string_0;
										}
									}
									else
									{
										dbid = flight2.int_2;
										num3 = flight2.int_3;
										text = flight2.string_5;
									}
									Mission.Class287 item = new Mission.Class287("", dbid, num3, text, new DateTime?(scenario_0.method_31()), new DateTime?(scenario_0.method_31()), flight2.string_0);
									if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
									{
										Class343 class4 = (Class343)mission_0;
										if (Information.IsNothing(class4.list_21))
										{
											class4.list_21 = new List<Mission.Class287>();
										}
										class4.list_21.Add(item);
									}
									if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
									{
										Class344 class5 = (Class344)mission_0;
										if (Information.IsNothing(class5.list_11))
										{
											class5.list_11 = new List<Mission.Class287>();
										}
										class5.list_11.Add(item);
									}
								}
							}
							if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
							{
								list6 = ((Class343)mission_0).list_21;
							}
							if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
							{
								list6 = ((Class344)mission_0).list_11;
							}
							DateTime t = scenario_0.method_31().AddHours((double)mission_0.method_50((int)enum99_));
							for (int n = list6.Count - 1; n >= 0; n += -1)
							{
								Mission.Class287 class6 = list6[n];
								DateTime? dateTime = class6.nullable_0;
								if (((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t) < 0) : null).GetValueOrDefault())
								{
									if (Information.IsNothing(class6.string_1))
									{
										list6.Remove(class6);
									}
									else
									{
										int num4 = 0;
										Doctrine.Enum56? @enum = mission_0.doctrine_0.method_152(scenario_0, false, false, false, false);
										string text2 = "";
										if (!scenario_0.vmethod_0().ContainsKey(class6.string_1))
										{
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class6);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class6);
											}
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
										else
										{
											ActiveUnit activeUnit = scenario_0.vmethod_0()[class6.string_1];
											if (Information.IsNothing(activeUnit))
											{
												if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
												{
													((Class343)mission_0).list_21.Remove(class6);
												}
												if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
												{
													((Class344)mission_0).list_11.Remove(class6);
												}
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
											}
											else
											{
												Mission.Flight flight3 = null;
												try
												{
													foreach (Mission.Flight flight4 in mission_0.list_1)
													{
														if (Operators.CompareString(flight4.string_0, class6.string_2, false) == 0)
														{
															flight3 = flight4;
														}
													}
												}
												finally
												{
													List<Mission.Flight>.Enumerator enumerator2;
													((IDisposable)enumerator2).Dispose();
												}
												if (Information.IsNothing(flight3))
												{
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
												}
												else
												{
													if (Information.IsNothing(list3))
													{
														list3 = new List<ActiveUnit>();
													}
													list3.Clear();
													list3.Add(activeUnit);
													int item2 = class6.int_1;
													if (Information.IsNothing(list4))
													{
														list4 = new List<int>();
													}
													list4.Clear();
													list4.Add(item2);
													DateTime dateTime2 = class6.nullable_1.Value;
													bool bool_12 = true;
													Mission.Flight flight5 = null;
													DateTime dateTime4;
													for (;;)
													{
														IL_D4B:
														List<Aircraft> list10 = new List<Aircraft>();
														List<Mission.EmptyAircraftSlot> list11 = new List<Mission.EmptyAircraftSlot>();
														int num5 = 1;
														int num6 = (int)flightSize_;
														for (int num7 = 1; num7 <= num6; num7++)
														{
															Mission mission = mission_0;
															int int_2 = class6.int_0;
															int int_3 = class6.int_1;
															Mission.Flight flight6 = null;
															Aircraft aircraft2 = mission.method_64(ref scenario_0, ref side_0, int_2, int_3, ref activeUnit, ref flight6, false, num5);
															Mission.EmptyAircraftSlot item3 = new Mission.EmptyAircraftSlot(aircraft2, aircraft2.DBID, aircraft2.string_2, aircraft2.method_166(), aircraft2.method_165(), ref activeUnit, activeUnit.string_0, activeUnit.Name, false);
															list10.Add(aircraft2);
															list11.Add(item3);
															num5++;
														}
														List<Aircraft> list12 = Enumerable.ToList<Aircraft>(list10);
														flight5 = null;
														Mission.Flight flight7 = new Mission.Flight();
														Mission.Flight flight8 = flight3;
														bool bool_13 = false;
														Mission mission2 = null;
														int num8 = 0;
														int num9 = 0;
														flight8.method_31(ref scenario_0, ref flight3, ref flight7, bool_13, ref mission2, ref num8, ref num9, false, false);
														flight7.enum93_0 = Mission.Enum93.const_0;
														mission_0.list_0.Clear();
														mission_0.list_0.Add(flight7);
														flight3.bool_13 = false;
														if (list12.Count <= 0)
														{
															goto IL_F7C;
														}
														Mission._FlightSize flightSize = Mission._FlightSize.None;
														Mission._FlightSize flightSize2 = Mission._FlightSize.None;
														bool flag5 = false;
														num9 = 0;
														num8 = 0;
														int num10 = 0;
														int num11 = 0;
														List<Aircraft> list13 = new List<Aircraft>();
														List<Aircraft> list14 = new List<Aircraft>();
														bool flag6 = false;
														float num12 = 0f;
														float num13 = 0f;
														bool bool_14 = false;
														List<Group> list15 = null;
														List<Aircraft> list16 = null;
														List<Aircraft> list17 = null;
														List<Aircraft> list18 = null;
														List<Aircraft> list19 = new List<Aircraft>();
														bool flag7 = false;
														if (!GameGeneral.smethod_37(ref scenario_0, ref side_0, ref mission_0, bool_7, ref list, ref flightSize_, ref flightSize, ref flightSize2, ref bool_11, ref flag5, ref num4, ref num, ref num9, ref num8, ref num10, ref num11, ref list12, ref list13, ref list14, ref @enum, ref flag6, ref list4, ref num12, ref num13, bool_14, ref list15, ref list16, ref list17, ref list18, ref list3, ref list19, ref text2, double_0, ref flag7, false, bool_8, bool_12, ref flight5, bool_9))
														{
															break;
														}
														if (Information.IsNothing(flight5))
														{
															goto IL_DB8;
														}
														if (!Information.IsNothing(flight5.method_15()) && Enumerable.Count<Waypoint>(flight5.method_15()) != 0)
														{
															int num14 = mission_0.method_48((int)enum98_);
															foreach (Waypoint waypoint2 in flight5.method_15())
															{
																if (waypoint2.method_41())
																{
																	double value = (double)waypoint2.float_25;
																	IL_99B:
																	DateTime dateTime3 = dateTime2;
																	DateTime date = dateTime3.Date;
																	TimeSpan value2 = TimeSpan.FromMinutes(Math.Floor((dateTime3.TimeOfDay.TotalMinutes + 2.5) / 5.0) * 5.0);
																	dateTime2 = date.Add(value2);
																	dateTime4 = dateTime2.AddSeconds(value);
																	dateTime2 = dateTime2.AddMinutes((double)(-(double)num14));
																	if (Information.IsNothing(mission_0.list_2))
																	{
																		mission_0.list_2 = new List<Mission.EmptyAircraftSlot>();
																	}
																	try
																	{
																		foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in list11)
																		{
																			emptyAircraftSlot.method_6(scenario_0, flight5);
																			emptyAircraftSlot.string_2 = flight5.string_0;
																			emptyAircraftSlot.method_4(scenario_0, activeUnit);
																			emptyAircraftSlot.string_3 = activeUnit.string_0;
																			emptyAircraftSlot.string_4 = activeUnit.Name;
																			emptyAircraftSlot.string_2 = flight5.string_0;
																			mission_0.list_2.Add(emptyAircraftSlot);
																		}
																	}
																	finally
																	{
																		List<Mission.EmptyAircraftSlot>.Enumerator enumerator3;
																		((IDisposable)enumerator3).Dispose();
																	}
																	foreach (Waypoint waypoint3 in flight5.method_15())
																	{
																		if (waypoint3.method_40())
																		{
																			Waypoint waypoint4 = waypoint3;
																		}
																		else if (waypoint3.method_41())
																		{
																			Waypoint waypoint5 = waypoint3;
																			IL_AEA:
																			Waypoint waypoint4;
																			if (Information.IsNothing(waypoint4))
																			{
																				goto IL_E08;
																			}
																			if (Information.IsNothing(waypoint5))
																			{
																				goto IL_E4C;
																			}
																			waypoint4.nullable_7 = new DateTime?(dateTime2);
																			waypoint4.enum82_0 = Waypoint.Enum82.const_1;
																			waypoint5.nullable_7 = new DateTime?(dateTime4);
																			waypoint5.enum82_0 = Waypoint.Enum82.const_1;
																			Scenario scenario_ = scenario_0;
																			Mission mission_ = mission_0;
																			ActiveUnit activeUnit_ = flight5.method_32(scenario_0);
																			Mission.Flight flight_ = flight5;
																			Mission.Flight flight6;
																			Waypoint[] array4 = (flight6 = flight5).method_15();
																			num13 = 0f;
																			num12 = 0f;
																			Class514.smethod_28(scenario_, mission_, activeUnit_, flight_, ref array4, ref num13, ref num12, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, true);
																			flight6.method_16(array4);
																			for (;;)
																			{
																				IL_D11:
																				dateTime = flight5.method_15()[0].nullable_7;
																				DateTime t2 = scenario_0.method_31();
																				if (((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t2) < 0) : null).GetValueOrDefault())
																				{
																					TimeSpan value3 = TimeSpan.FromMinutes(Math.Floor(((scenario_0.method_31() - flight5.method_15()[0].nullable_7.Value).TotalMinutes + 2.5) / 5.0) * 5.0 + 5.0);
																					dateTime2 = dateTime2.Add(value3);
																					dateTime4 = dateTime4.Add(value3);
																					foreach (Waypoint waypoint6 in flight5.method_15())
																					{
																						if (waypoint6.method_40())
																						{
																							waypoint6.nullable_7 = new DateTime?(dateTime2);
																						}
																						else if (waypoint6.method_41())
																						{
																							waypoint6.nullable_7 = new DateTime?(dateTime4);
																							IL_C8F:
																							Scenario scenario_2 = scenario_0;
																							Mission mission_2 = mission_0;
																							ActiveUnit activeUnit_2 = flight5.method_32(scenario_0);
																							Mission.Flight flight_2 = flight5;
																							Waypoint[] waypoint_ = (flight6 = flight5).method_15();
																							num12 = 0f;
																							num13 = 0f;
																							Class514.smethod_28(scenario_2, mission_2, activeUnit_2, flight_2, ref waypoint_, ref num12, ref num13, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, true);
																							flight6.method_16(waypoint_);
																							goto IL_D11;
																						}
																					}
																					goto IL_C8F;
																				}
																				break;
																			}
																			if (DateTime.Compare(dateTime2, t) <= 0)
																			{
																				dateTime2 = dateTime4;
																				goto IL_D4B;
																			}
																			goto IL_E90;
																		}
																	}
																	goto IL_AEA;
																}
															}
															goto IL_99B;
														}
														goto IL_F32;
													}
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														((Class343)mission_0).list_21.Remove(class6);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														((Class344)mission_0).list_11.Remove(class6);
														goto IL_FC4;
													}
													goto IL_FC4;
													IL_DB8:
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														((Class343)mission_0).list_21.Remove(class6);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														((Class344)mission_0).list_11.Remove(class6);
														goto IL_FC4;
													}
													goto IL_FC4;
													IL_E08:
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														((Class343)mission_0).list_21.Remove(class6);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														((Class344)mission_0).list_11.Remove(class6);
														goto IL_FC4;
													}
													goto IL_FC4;
													IL_E4C:
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														((Class343)mission_0).list_21.Remove(class6);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														((Class344)mission_0).list_11.Remove(class6);
														goto IL_FC4;
													}
													goto IL_FC4;
													IL_E90:
													Mission.Class287 class7 = new Mission.Class287(flight5.string_0, flight5.int_2, flight5.int_3, activeUnit.string_0, new DateTime?(dateTime2), new DateTime?(dateTime4), class6.string_2);
													if (Information.IsNothing(class7))
													{
														goto IL_FC4;
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														Class343 class8 = (Class343)mission_0;
														class8.list_21.Remove(class6);
														class8.list_21.Add(class7);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														Class344 class9 = (Class344)mission_0;
														class9.list_11.Remove(class6);
														class9.list_11.Add(class7);
														goto IL_FC4;
													}
													goto IL_FC4;
													IL_F32:
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														((Class343)mission_0).list_21.Remove(class6);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														((Class344)mission_0).list_11.Remove(class6);
														goto IL_FC4;
													}
													goto IL_FC4;
													IL_F7C:
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														((Class343)mission_0).list_21.Remove(class6);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														((Class344)mission_0).list_11.Remove(class6);
													}
												}
											}
										}
									}
								}
								IL_FC4:;
							}
						}
						else
						{
							GameGeneral.smethod_1("No valid flightplan templates exist For this mission. Create one or more flightplan templates And Try again.");
						}
					}
				}
				else
				{
					Mission mission3 = mission_0;
					Scenario scenario_3 = scenario_0;
					List<Aircraft> list14 = null;
					List<Aircraft> list16 = null;
					int num15 = 0;
					int num16 = 0;
					int num8 = 0;
					int num9 = 0;
					int num10 = 0;
					int num11 = 0;
					List<int> list20 = null;
					List<ActiveUnit> list21 = null;
					List<ActiveUnit> list22 = null;
					List<ActiveUnit> list_ = null;
					List<Aircraft> list19 = new List<Aircraft>();
					List<Aircraft> list18 = new List<Aircraft>();
					List<Aircraft> list17 = new List<Aircraft>();
					int num17 = 0;
					int num18 = 0;
					int num19 = 0;
					List<Mission.Flight> list23 = null;
					List<Mission.Flight> list24 = null;
					List<Mission.Flight> list25 = null;
					mission3.method_18(scenario_3, ref list4, ref list5, ref list, ref list2, ref list14, ref list16, ref list3, ref num15, ref num16, ref num8, ref num9, ref num10, ref num11, ref list20, ref list21, ref list22, list_, ref list19, ref list18, ref list17, ref num17, ref num18, ref num19, ref list23, ref list24, ref list25, false, false, true);
					List<Aircraft> list26 = new List<Aircraft>();
					Mission._FlightSize flightSize_2 = mission_0._FlightSize_0;
					bool bool_15 = mission_0.bool_12;
					int num20 = 0;
					GameGeneral.smethod_33(true, ref list26, bool_10, int_, ref list3, ref list5, ref list, ref list4, ref list2, ref flightSize_2, ref bool_15);
					if (list26.Count > 0)
					{
						List<Mission.Flight> list27 = new List<Mission.Flight>();
						try
						{
							foreach (Mission.Flight flight9 in mission_0.list_1)
							{
								if (flight9._FlightTask_0 != Mission._FlightTask.const_48 && flight9.enum93_0 != Mission.Enum93.const_1)
								{
									list27.Add(flight9);
								}
							}
						}
						finally
						{
							List<Mission.Flight>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						List<Mission.Class287> list28 = null;
						if (list27.Count == 0 && !Information.IsNothing(list6))
						{
							if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
							{
								((Class343)mission_0).list_21.Clear();
							}
							if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
							{
								((Class344)mission_0).list_11.Clear();
							}
						}
						if (!Information.IsNothing(list6) && list6.Count > 0)
						{
							list28 = Enumerable.ToList<Mission.Class287>(list6);
						}
						if (!Information.IsNothing(list28))
						{
							int count3 = list28.Count;
							int count4 = list27.Count;
							int num21 = count3 - 1;
							IL_1218:
							while (num21 >= 0)
							{
								Mission.Class287 class10 = list28[num21];
								bool flag8 = false;
								for (int num22 = count4 - 1; num22 >= 0; num22 += -1)
								{
									if (Operators.CompareString(list27[num22].string_0, class10.string_0, false) == 0)
									{
										flag8 = true;
										IL_11D2:
										if (!flag8)
										{
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class10);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class10);
											}
										}
										num21 += -1;
										goto IL_1218;
									}
								}
								goto IL_11D2;
							}
						}
						if (!Information.IsNothing(list6) && list6.Count > 0)
						{
							list28 = Enumerable.ToList<Mission.Class287>(list6);
						}
						if (!Information.IsNothing(list28))
						{
							for (int num23 = list28.Count - 1; num23 >= 0; num23 += -1)
							{
								Mission.Class287 class10 = list28[num23];
								if (Information.IsNothing(class10.string_1))
								{
									list6.Remove(class10);
								}
								else
								{
									if (list26.Count == 0)
									{
										break;
									}
									int count5 = list26.Count;
									for (int num24 = count5 - 1; num24 >= 0; num24 += -1)
									{
										Aircraft aircraft3 = list26[num24];
										int num25 = (int)mission_0._FlightSize_0;
										if (class10.int_0 == aircraft3.DBID)
										{
											if (class10.int_1 == aircraft3.method_166())
											{
												string text3 = null;
												if (!Information.IsNothing(aircraft3.method_164().method_30()))
												{
													text3 = aircraft3.method_164().method_30().string_0;
												}
												else if (!Information.IsNothing(aircraft3.method_164().method_32(false)))
												{
													text3 = aircraft3.method_164().method_32(false).string_0;
												}
												if (!Information.IsNothing(text3) && Operators.CompareString(class10.string_1, text3, false) == 0)
												{
													list26.Remove(aircraft3);
													count5 = list26.Count;
													num25--;
													if (num25 > 0)
													{
														int count6 = list26.Count;
														for (int num26 = count5 - 1; num26 >= 0; num26 += -1)
														{
															Aircraft aircraft4 = list26[num26];
															if (class10.int_0 == aircraft4.DBID && class10.int_1 == aircraft4.method_166())
															{
																string text4 = null;
																if (!Information.IsNothing(aircraft4.method_164().method_30()))
																{
																	text4 = aircraft4.method_164().method_30().string_0;
																}
																else if (!Information.IsNothing(aircraft4.method_164().method_32(false)))
																{
																	text4 = aircraft4.method_164().method_32(false).string_0;
																}
																if (Information.IsNothing(text4))
																{
																	list26.Remove(aircraft3);
																	break;
																}
																if (Operators.CompareString(class10.string_1, text4, false) == 0)
																{
																	list26.Remove(aircraft4);
																	num24--;
																	num25--;
																	if (num25 == 0)
																	{
																		break;
																	}
																}
															}
														}
													}
													if (num25 == 0)
													{
														break;
													}
												}
											}
											else
											{
												list26.Remove(aircraft3);
											}
										}
										if (list26.Count == 0)
										{
											break;
										}
									}
									list28.Remove(class10);
								}
							}
						}
						if (!Information.IsNothing(list28) && list28.Count > 0 && !Information.IsNothing(list28))
						{
							int count4 = list28.Count;
							for (int num27 = count4 - 1; num27 >= 0; num27 += -1)
							{
								Mission.Class287 class10 = list28[num27];
								if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
								{
									((Class343)mission_0).list_21.Remove(class10);
								}
								if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
								{
									((Class344)mission_0).list_11.Remove(class10);
								}
							}
						}
						for (int num28 = list26.Count - 1; num28 >= 0; num28 += -1)
						{
							Aircraft aircraft5 = list26[num28];
							int num29 = (int)mission_0._FlightSize_0;
							int dbid2 = aircraft5.DBID;
							int num30 = aircraft5.method_166();
							string left;
							if (!Information.IsNothing(aircraft5.method_164().method_30()))
							{
								left = aircraft5.method_164().method_30().string_0;
							}
							else if (!Information.IsNothing(aircraft5.method_164().method_32(false)))
							{
								left = aircraft5.method_164().method_32(false).string_0;
							}
							Mission.Class287 item4 = new Mission.Class287("", dbid2, num30, left, new DateTime?(scenario_0.method_31()), new DateTime?(scenario_0.method_31()), "");
							if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
							{
								Class343 class11 = (Class343)mission_0;
								if (Information.IsNothing(class11.list_21))
								{
									class11.list_21 = new List<Mission.Class287>();
								}
								class11.list_21.Add(item4);
							}
							if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
							{
								Class344 class12 = (Class344)mission_0;
								if (Information.IsNothing(class12.list_11))
								{
									class12.list_11 = new List<Mission.Class287>();
								}
								class12.list_11.Add(item4);
							}
							num29--;
							if (num29 > 0)
							{
								for (int num31 = list26.Count - 1; num31 >= 0; num31 += -1)
								{
									Aircraft aircraft6 = list26[num31];
									if (dbid2 == aircraft6.DBID && num30 == aircraft6.method_166())
									{
										string text5 = null;
										if (!Information.IsNothing(aircraft6.method_164().method_30()))
										{
											text5 = aircraft6.method_164().method_30().string_0;
										}
										else if (!Information.IsNothing(aircraft6.method_164().method_32(false)))
										{
											text5 = aircraft6.method_164().method_32(false).string_0;
										}
										if (!Information.IsNothing(text5) && Operators.CompareString(left, text5, false) == 0)
										{
											num29--;
											num28--;
											if (num29 == 0)
											{
												break;
											}
										}
									}
								}
							}
						}
						if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							list6 = ((Class343)mission_0).list_21;
						}
						if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
						{
							list6 = ((Class344)mission_0).list_11;
						}
						DateTime t3 = scenario_0.method_31().AddHours((double)mission_0.method_50((int)enum99_));
						for (int num32 = list6.Count - 1; num32 >= 0; num32 += -1)
						{
							Mission.Class287 class13 = list6[num32];
							if (Information.IsNothing(class13.string_1))
							{
								list6.Remove(class13);
							}
							else
							{
								DateTime? dateTime = class13.nullable_0;
								if (((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t3) < 0) : null).GetValueOrDefault())
								{
									int num33 = 0;
									Doctrine.Enum56? enum2 = mission_0.doctrine_0.method_152(scenario_0, false, false, false, false);
									string text6 = "";
									int num34 = 0;
									int num35 = 0;
									if (!scenario_0.vmethod_0().ContainsKey(class13.string_1))
									{
										if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
										{
											((Class343)mission_0).list_21.Remove(class13);
										}
										if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
										{
											((Class344)mission_0).list_11.Remove(class13);
										}
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
									else
									{
										ActiveUnit activeUnit2 = scenario_0.vmethod_0()[class13.string_1];
										if (Information.IsNothing(activeUnit2))
										{
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class13);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class13);
											}
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
										else
										{
											DateTime value4 = class13.nullable_1.Value;
											int num36 = mission_0.method_46((int)enum97_);
											int num37 = mission_0.method_48((int)enum98_);
											DateTime dateTime5 = value4;
											bool flag9 = true;
											Mission.Flight flight10 = null;
											DateTime dateTime7;
											for (;;)
											{
												IL_1EFD:
												List<Aircraft> list29 = new List<Aircraft>();
												List<Mission.EmptyAircraftSlot> list30 = new List<Mission.EmptyAircraftSlot>();
												int num38 = 1;
												num19 = (int)flightSize_2;
												for (int num39 = 1; num39 <= num19; num39++)
												{
													Mission mission4 = mission_0;
													int int_4 = class13.int_0;
													int int_5 = class13.int_1;
													Mission.Flight flight6 = null;
													Aircraft aircraft7 = mission4.method_64(ref scenario_0, ref side_0, int_4, int_5, ref activeUnit2, ref flight6, false, num38);
													Mission.EmptyAircraftSlot item5 = new Mission.EmptyAircraftSlot(aircraft7, aircraft7.DBID, aircraft7.string_2, aircraft7.method_166(), aircraft7.method_165(), ref activeUnit2, activeUnit2.string_0, activeUnit2.Name, false);
													list29.Add(aircraft7);
													list30.Add(item5);
													num38++;
												}
												List<Aircraft> list31 = Enumerable.ToList<Aircraft>(list29);
												DateTime dateTime6 = dateTime5;
												DateTime date2 = dateTime6.Date;
												TimeSpan value5 = TimeSpan.FromMinutes(Math.Floor((dateTime6.TimeOfDay.TotalMinutes + 2.5) / 5.0) * 5.0);
												dateTime5 = date2.Add(value5);
												dateTime7 = dateTime5.AddMinutes((double)num36);
												dateTime5 = dateTime5.AddMinutes((double)(-(double)num37));
												flight10 = null;
												Mission._FlightSize flightSize = Mission._FlightSize.None;
												Mission._FlightSize flightSize2 = Mission._FlightSize.None;
												bool flag6 = false;
												num18 = 0;
												num17 = 0;
												num11 = 0;
												num10 = 0;
												num9 = 0;
												num8 = 0;
												num16 = 0;
												num15 = 0;
												int i = 0;
												int num6 = 0;
												list17 = Enumerable.ToList<Aircraft>(list29);
												list18 = new List<Aircraft>();
												list19 = new List<Aircraft>();
												bool flag7 = false;
												float num12 = 0f;
												float num13 = 0f;
												if (!GameGeneral.smethod_32(ref scenario_0, ref side_0, ref mission_0, bool_7, ref list29, ref flightSize_2, ref flightSize, ref flightSize2, ref bool_15, ref flag6, ref num33, ref num20, ref num18, ref num17, ref num11, ref num10, ref num9, ref num8, ref num16, ref num15, ref i, ref num6, ref list17, ref list31, ref list18, ref list19, ref enum2, ref flag7, ref list4, ref list5, ref num12, ref num13, ref text6, ref num34, ref num35, bool_8, null, null, flag9, ref list3, bool_9))
												{
													break;
												}
												if (list31.Count <= 0)
												{
													goto IL_2176;
												}
												flightSize2 = Mission._FlightSize.None;
												flightSize = Mission._FlightSize.None;
												flag7 = false;
												num6 = 0;
												i = 0;
												num15 = 0;
												num16 = 0;
												list19 = new List<Aircraft>();
												list18 = new List<Aircraft>();
												flag6 = false;
												num13 = 0f;
												num12 = 0f;
												bool bool_16 = false;
												List<Group> list15 = null;
												list17 = null;
												list16 = null;
												list14 = null;
												List<Aircraft> list13 = new List<Aircraft>();
												bool flag5 = false;
												if (!GameGeneral.smethod_37(ref scenario_0, ref side_0, ref mission_0, bool_7, ref list, ref flightSize_2, ref flightSize2, ref flightSize, ref bool_15, ref flag7, ref num33, ref num20, ref num6, ref i, ref num15, ref num16, ref list31, ref list19, ref list18, ref enum2, ref flag6, ref list4, ref num13, ref num12, bool_16, ref list15, ref list17, ref list16, ref list14, ref list3, ref list13, ref text6, double_0, ref flag5, false, bool_8, flag9, ref flight10, bool_9))
												{
													goto IL_1F6A;
												}
												if (Information.IsNothing(flight10))
												{
													goto IL_1FBA;
												}
												if (!Information.IsNothing(flight10.method_15()) && Enumerable.Count<Waypoint>(flight10.method_15()) != 0)
												{
													if (Information.IsNothing(mission_0.list_2))
													{
														mission_0.list_2 = new List<Mission.EmptyAircraftSlot>();
													}
													try
													{
														foreach (Mission.EmptyAircraftSlot emptyAircraftSlot2 in list30)
														{
															emptyAircraftSlot2.method_6(scenario_0, flight10);
															emptyAircraftSlot2.string_2 = flight10.string_0;
															emptyAircraftSlot2.method_4(scenario_0, activeUnit2);
															emptyAircraftSlot2.string_3 = activeUnit2.string_0;
															emptyAircraftSlot2.string_4 = activeUnit2.Name;
															emptyAircraftSlot2.string_2 = flight10.string_0;
															mission_0.list_2.Add(emptyAircraftSlot2);
														}
													}
													finally
													{
														List<Mission.EmptyAircraftSlot>.Enumerator enumerator5;
														((IDisposable)enumerator5).Dispose();
													}
													foreach (Waypoint waypoint7 in flight10.method_15())
													{
														if (waypoint7.method_40())
														{
															Waypoint waypoint8 = waypoint7;
														}
														else if (waypoint7.method_41())
														{
															Waypoint waypoint9 = waypoint7;
															IL_1C5A:
															Waypoint waypoint8;
															if (Information.IsNothing(waypoint8))
															{
																goto IL_200A;
															}
															if (Information.IsNothing(waypoint9))
															{
																goto IL_204E;
															}
															waypoint8.nullable_7 = new DateTime?(dateTime5);
															waypoint8.enum82_0 = Waypoint.Enum82.const_1;
															waypoint9.nullable_7 = new DateTime?(dateTime7);
															waypoint9.enum82_0 = Waypoint.Enum82.const_1;
															waypoint9.float_25 = (float)((long)Math.Round(Math.Max((waypoint9.nullable_7.Value - waypoint8.nullable_7.Value).TotalSeconds, 0.0)));
															Scenario scenario_4 = scenario_0;
															Mission mission_3 = mission_0;
															ActiveUnit activeUnit_3 = flight10.method_32(scenario_0);
															Mission.Flight flight_3 = flight10;
															Mission.Flight flight6;
															Waypoint[] array6 = (flight6 = flight10).method_15();
															num12 = 0f;
															num13 = 0f;
															Class514.smethod_28(scenario_4, mission_3, activeUnit_3, flight_3, ref array6, ref num12, ref num13, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, true);
															flight6.method_16(array6);
															for (;;)
															{
																IL_1EC3:
																dateTime = flight10.method_15()[0].nullable_7;
																DateTime t2 = scenario_0.method_31();
																if (((dateTime != null) ? new bool?(DateTime.Compare(dateTime.GetValueOrDefault(), t2) < 0) : null).GetValueOrDefault())
																{
																	TimeSpan value6 = TimeSpan.FromMinutes(Math.Floor(((scenario_0.method_31() - flight10.method_15()[0].nullable_7.Value).TotalMinutes + 2.5) / 5.0) * 5.0 + 5.0);
																	dateTime5 = dateTime5.Add(value6);
																	dateTime7 = dateTime7.Add(value6);
																	foreach (Waypoint waypoint10 in flight10.method_15())
																	{
																		if (waypoint10.method_40())
																		{
																			waypoint10.nullable_7 = new DateTime?(dateTime5);
																		}
																		else if (waypoint10.method_41())
																		{
																			waypoint10.nullable_7 = new DateTime?(dateTime7);
																			IL_1E41:
																			Scenario scenario_5 = scenario_0;
																			Mission mission_4 = mission_0;
																			ActiveUnit activeUnit_4 = flight10.method_32(scenario_0);
																			Mission.Flight flight_4 = flight10;
																			Waypoint[] array = (flight6 = flight10).method_15();
																			num13 = 0f;
																			num12 = 0f;
																			Class514.smethod_28(scenario_5, mission_4, activeUnit_4, flight_4, ref array, ref num13, ref num12, false, true, true, true, false, true, true, 0f, 0f, Misc.Enum143.const_0, null, false, false, null, null, true);
																			flight6.method_16(array);
																			goto IL_1EC3;
																		}
																	}
																	goto IL_1E41;
																}
																break;
															}
															if (DateTime.Compare(dateTime5, t3) <= 0)
															{
																dateTime5 = dateTime7;
																goto IL_1EFD;
															}
															goto IL_2092;
														}
													}
													goto IL_1C5A;
												}
												goto IL_212E;
											}
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class13);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class13);
												goto IL_2176;
											}
											goto IL_2176;
											IL_1F6A:
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class13);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class13);
												goto IL_2176;
											}
											goto IL_2176;
											IL_1FBA:
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class13);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class13);
												goto IL_2176;
											}
											goto IL_2176;
											IL_200A:
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class13);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class13);
												goto IL_2176;
											}
											goto IL_2176;
											IL_204E:
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class13);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class13);
												goto IL_2176;
											}
											goto IL_2176;
											IL_2092:
											Mission.Class287 class14 = new Mission.Class287(flight10.string_0, flight10.int_2, flight10.int_3, activeUnit2.string_0, new DateTime?(dateTime5), new DateTime?(dateTime7), class13.string_2);
											if (Information.IsNothing(class14))
											{
												goto IL_2176;
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												Class343 class15 = (Class343)mission_0;
												class15.list_21.Remove(class13);
												class15.list_21.Add(class14);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												Class344 class16 = (Class344)mission_0;
												class16.list_11.Remove(class13);
												class16.list_11.Add(class14);
												goto IL_2176;
											}
											goto IL_2176;
											IL_212E:
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_21.Remove(class13);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_11.Remove(class13);
											}
										}
									}
								}
							}
							IL_2176:;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x002985FC File Offset: 0x002967FC
		private static void smethod_30(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, bool bool_7, double double_0, bool bool_8, bool bool_9)
		{
			try
			{
				List<Aircraft> list = new List<Aircraft>();
				List<Aircraft> list2 = new List<Aircraft>();
				List<ActiveUnit> list3 = new List<ActiveUnit>();
				List<int> list4 = new List<int>();
				List<int> list5 = new List<int>();
				List<Mission.Class287> list6;
				Mission.Enum96 enum96_;
				if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
				{
					Class343 @class = (Class343)mission_0;
					list6 = @class.list_22;
					enum96_ = @class.enum96_1;
				}
				if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
				{
					Class344 class2 = (Class344)mission_0;
					list6 = class2.list_12;
					enum96_ = class2.enum96_1;
				}
				if (enum96_ != Mission.Enum96.const_0)
				{
					if (enum96_ == Mission.Enum96.const_1)
					{
						Mission._FlightSize flightSize_ = mission_0._FlightSize_0;
						bool bool_10 = mission_0.bool_12;
						int num = 0;
						List<Mission.Flight> list7 = new List<Mission.Flight>();
						List<Mission.Flight> list8 = new List<Mission.Flight>();
						try
						{
							foreach (Mission.Flight flight in mission_0.list_1)
							{
								if (flight._FlightTask_0 == Mission._FlightTask.const_48)
								{
									if (flight.enum93_0 == Mission.Enum93.const_1)
									{
										list7.Add(flight);
									}
									else
									{
										list8.Add(flight);
									}
								}
							}
						}
						finally
						{
							List<Mission.Flight>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (list7.Count > 0)
						{
							List<Mission.Class287> list9 = null;
							if (list8.Count == 0 && !Information.IsNothing(list6))
							{
								if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
								{
									((Class343)mission_0).list_22.Clear();
								}
								if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
								{
									((Class344)mission_0).list_12.Clear();
								}
							}
							if (!Information.IsNothing(list6) && list6.Count > 0)
							{
								list9 = Enumerable.ToList<Mission.Class287>(list6);
							}
							int num2;
							Mission.Class287 class3;
							if (!Information.IsNothing(list9))
							{
								int count = list9.Count;
								num2 = list8.Count;
								int i = count - 1;
								IL_20C:
								while (i >= 0)
								{
									class3 = list9[i];
									bool flag = false;
									for (int j = num2 - 1; j >= 0; j += -1)
									{
										Mission.Flight flight2 = list8[j];
										if (Operators.CompareString(flight2.string_0, class3.string_0, false) == 0)
										{
											flag = true;
											IL_1C6:
											if (!flag)
											{
												if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
												{
													((Class343)mission_0).list_22.Remove(class3);
												}
												if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
												{
													((Class344)mission_0).list_12.Remove(class3);
												}
											}
											i += -1;
											goto IL_20C;
										}
									}
									goto IL_1C6;
								}
							}
							if (!Information.IsNothing(list6) && list6.Count > 0)
							{
								list9 = Enumerable.ToList<Mission.Class287>(list6);
							}
							if (!Information.IsNothing(list6))
							{
								num2 = list6.Count;
							}
							else
							{
								num2 = 0;
							}
							for (int k = list7.Count - 1; k >= 0; k += -1)
							{
								Mission.Flight flight2 = list7[k];
								bool flag2 = false;
								if (!Information.IsNothing(list9))
								{
									for (int l = num2 - 1; l >= 0; l += -1)
									{
										class3 = list9[l];
										if (Operators.CompareString(flight2.string_0, class3.string_2, false) == 0)
										{
											flag2 = true;
											break;
										}
									}
								}
								if (!flag2)
								{
									if (Information.IsNothing(flight2))
									{
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
									else
									{
										int num3 = 0;
										Doctrine.Enum56? @enum = mission_0.doctrine_0.method_152(scenario_0, false, false, false, false);
										string text = "";
										if (!scenario_0.vmethod_0().ContainsKey(flight2.string_5))
										{
											if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
											{
												((Class343)mission_0).list_22.Remove(class3);
											}
											if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
											{
												((Class344)mission_0).list_12.Remove(class3);
											}
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
										else
										{
											ActiveUnit activeUnit = scenario_0.vmethod_0()[flight2.string_5];
											if (Information.IsNothing(activeUnit))
											{
												if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
												{
													((Class343)mission_0).list_22.Remove(class3);
												}
												if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
												{
													((Class344)mission_0).list_12.Remove(class3);
												}
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
											}
											else
											{
												if (Information.IsNothing(list3))
												{
													list3 = new List<ActiveUnit>();
												}
												list3.Clear();
												list3.Add(activeUnit);
												int item = flight2.int_3;
												if (Information.IsNothing(list4))
												{
													list4 = new List<int>();
												}
												list4.Clear();
												list4.Add(item);
												Mission.Flight flight3 = null;
												List<Aircraft> list10 = new List<Aircraft>();
												List<Mission.EmptyAircraftSlot> list11 = new List<Mission.EmptyAircraftSlot>();
												int num4 = 1;
												int num5 = (int)flightSize_;
												for (int m = 1; m <= num5; m++)
												{
													Mission mission = mission_0;
													int int_ = flight2.int_2;
													int int_2 = flight2.int_3;
													Mission.Flight flight4 = null;
													Aircraft aircraft = mission.method_64(ref scenario_0, ref side_0, int_, int_2, ref activeUnit, ref flight4, false, num4);
													Mission.EmptyAircraftSlot item2 = new Mission.EmptyAircraftSlot(aircraft, aircraft.DBID, aircraft.string_2, aircraft.method_166(), aircraft.method_165(), ref activeUnit, activeUnit.string_0, activeUnit.Name, false);
													list10.Add(aircraft);
													list11.Add(item2);
													num4++;
												}
												List<Aircraft> list12 = Enumerable.ToList<Aircraft>(list10);
												flight3 = null;
												Mission.Flight flight5 = new Mission.Flight();
												Mission.Flight flight6 = flight2;
												bool bool_11 = false;
												Mission mission2 = null;
												int num6 = 0;
												int num7 = 0;
												flight6.method_31(ref scenario_0, ref flight2, ref flight5, bool_11, ref mission2, ref num6, ref num7, false, false);
												flight5.enum93_0 = Mission.Enum93.const_0;
												mission_0.list_0.Clear();
												mission_0.list_0.Add(flight5);
												flight2.bool_13 = false;
												if (list12.Count > 0)
												{
													Mission._FlightSize flightSize = Mission._FlightSize.None;
													Mission._FlightSize flightSize2 = Mission._FlightSize.None;
													bool flag3 = false;
													num7 = 0;
													num6 = 0;
													int num8 = 0;
													int num9 = 0;
													List<Aircraft> list13 = new List<Aircraft>();
													List<Aircraft> list14 = new List<Aircraft>();
													bool flag4 = false;
													float num10 = 0f;
													float num11 = 0f;
													bool bool_12 = false;
													List<Group> list15 = null;
													List<Aircraft> list16 = null;
													List<Aircraft> list17 = null;
													List<Aircraft> list18 = null;
													List<Aircraft> list19 = new List<Aircraft>();
													bool flag5 = false;
													if (!GameGeneral.smethod_37(ref scenario_0, ref side_0, ref mission_0, bool_7, ref list, ref flightSize_, ref flightSize, ref flightSize2, ref bool_10, ref flag3, ref num3, ref num, ref num7, ref num6, ref num8, ref num9, ref list12, ref list13, ref list14, ref @enum, ref flag4, ref list4, ref num10, ref num11, bool_12, ref list15, ref list16, ref list17, ref list18, ref list3, ref list19, ref text, double_0, ref flag5, false, bool_8, true, ref flight3, bool_9))
													{
														if (Debugger.IsAttached)
														{
															Debugger.Break();
														}
														if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
														{
															((Class343)mission_0).list_22.Remove(class3);
														}
														if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
														{
															((Class344)mission_0).list_12.Remove(class3);
														}
													}
													else if (!Information.IsNothing(flight3))
													{
														flight3._FlightTask_0 = Mission._FlightTask.const_48;
														if (Information.IsNothing(mission_0.list_2))
														{
															mission_0.list_2 = new List<Mission.EmptyAircraftSlot>();
														}
														try
														{
															foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in list11)
															{
																emptyAircraftSlot.method_6(scenario_0, flight3);
																emptyAircraftSlot.string_2 = flight3.string_0;
																emptyAircraftSlot.method_4(scenario_0, activeUnit);
																emptyAircraftSlot.string_3 = activeUnit.string_0;
																emptyAircraftSlot.string_4 = activeUnit.Name;
																emptyAircraftSlot.string_2 = flight3.string_0;
																mission_0.list_2.Add(emptyAircraftSlot);
															}
														}
														finally
														{
															List<Mission.EmptyAircraftSlot>.Enumerator enumerator2;
															((IDisposable)enumerator2).Dispose();
														}
														Mission.Class287 item3 = new Mission.Class287(flight3.string_0, flight2.int_2, item, activeUnit.string_0, new DateTime?(scenario_0.method_31()), new DateTime?(scenario_0.method_31()), flight2.string_0);
														if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
														{
															Class343 class4 = (Class343)mission_0;
															if (Information.IsNothing(class4.list_22))
															{
																class4.list_22 = new List<Mission.Class287>();
															}
															class4.list_22.Add(item3);
														}
														if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
														{
															Class344 class5 = (Class344)mission_0;
															if (Information.IsNothing(class5.list_12))
															{
																class5.list_12 = new List<Mission.Class287>();
															}
															class5.list_12.Add(item3);
														}
													}
												}
												else
												{
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
													{
														((Class343)mission_0).list_22.Remove(class3);
													}
													if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
													{
														((Class344)mission_0).list_12.Remove(class3);
													}
												}
											}
										}
									}
								}
							}
						}
						else
						{
							if (bool_9)
							{
								GameGeneral.smethod_1("No QRA (Quick Reaction Alert) flightplan templates exist For this mission. Create one or more QRA flightplan templates And Try again.");
							}
							scenario_0.method_59("No QRA (Quick Reaction Alert) flightplan templates exist For mission " + mission_0.Name + ". Create one or more QRA flightplan templates And Try again.", "No QRA templates for " + mission_0.Name, LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
					}
				}
				else
				{
					Mission._FlightSize flightSize_2 = mission_0._FlightSize_0;
					bool bool_13 = mission_0.bool_12;
					int num12 = 0;
					int num13;
					if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						Class343 class6 = (Class343)mission_0;
						num13 = mission_0.method_33(ref class6._FlightQty_3);
					}
					if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
					{
						Class344 class7 = (Class344)mission_0;
						num13 = mission_0.method_33(ref class7._FlightQty_1);
					}
					List<Mission.Flight> list20 = new List<Mission.Flight>();
					try
					{
						foreach (Mission.Flight flight7 in mission_0.list_1)
						{
							if (flight7._FlightTask_0 == Mission._FlightTask.const_48 && flight7.enum93_0 != Mission.Enum93.const_1)
							{
								list20.Add(flight7);
							}
						}
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					if (list20.Count == 0 && !Information.IsNothing(list6))
					{
						if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
						{
							((Class343)mission_0).list_22.Clear();
						}
						if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
						{
							((Class344)mission_0).list_12.Clear();
						}
					}
					Mission mission3 = mission_0;
					Scenario scenario_ = scenario_0;
					List<Aircraft> list14 = null;
					List<Aircraft> list16 = null;
					int num6 = 0;
					int num5 = 0;
					int num9 = 0;
					int num14 = 0;
					int num15 = 0;
					int num16 = 0;
					List<int> list21 = null;
					List<ActiveUnit> list22 = null;
					List<ActiveUnit> list23 = null;
					List<ActiveUnit> list_ = null;
					List<Aircraft> list19 = new List<Aircraft>();
					List<Aircraft> list18 = new List<Aircraft>();
					List<Aircraft> list17 = new List<Aircraft>();
					int num17 = 0;
					int num18 = 0;
					int num19 = 0;
					List<Mission.Flight> list24 = null;
					List<Mission.Flight> list25 = null;
					List<Mission.Flight> list26 = null;
					mission3.method_18(scenario_, ref list4, ref list5, ref list, ref list2, ref list14, ref list16, ref list3, ref num6, ref num5, ref num9, ref num14, ref num15, ref num16, ref list21, ref list22, ref list23, list_, ref list19, ref list18, ref list17, ref num17, ref num18, ref num19, ref list24, ref list25, ref list26, false, false, true);
					int count2 = list3.Count;
					int count3 = list5.Count;
					int count4 = list4.Count;
					for (int n = count2 - 1; n >= 0; n += -1)
					{
						ActiveUnit activeUnit2 = list3[n];
						for (int num20 = count3 - 1; num20 >= 0; num20 += -1)
						{
							int num21 = list5[num20];
							for (int num22 = count4 - 1; num22 >= 0; num22 += -1)
							{
								int num23 = list4[num22];
								List<Mission.Flight> list27 = new List<Mission.Flight>();
								try
								{
									foreach (Mission.Flight flight8 in mission_0.list_1)
									{
										if (flight8.enum93_0 != Mission.Enum93.const_1 && flight8._FlightTask_0 == Mission._FlightTask.const_48 && Operators.CompareString(flight8.string_5, activeUnit2.string_0, false) == 0 && flight8.int_2 == num21 && flight8.int_3 == num23)
										{
											list27.Add(flight8);
										}
									}
								}
								finally
								{
									List<Mission.Flight>.Enumerator enumerator4;
									((IDisposable)enumerator4).Dispose();
								}
								int num24 = list27.Count;
								if (num24 < num13)
								{
									for (;;)
									{
										int num25 = 0;
										Doctrine.Enum56? enum2 = mission_0.doctrine_0.method_152(scenario_0, false, false, false, false);
										string text2 = "";
										int num26 = 0;
										int num27 = 0;
										List<ActiveUnit> list28 = new List<ActiveUnit>();
										list28.Add(activeUnit2);
										List<int> list29 = new List<int>();
										list29.Add(num23);
										Mission.Flight flight9 = null;
										List<Aircraft> list30 = new List<Aircraft>();
										List<Mission.EmptyAircraftSlot> list31 = new List<Mission.EmptyAircraftSlot>();
										int num28 = 1;
										num19 = (int)flightSize_2;
										for (int num29 = 1; num29 <= num19; num29++)
										{
											Mission mission4 = mission_0;
											int int_3 = num21;
											int int_4 = num23;
											Mission.Flight flight4 = null;
											Aircraft aircraft2 = mission4.method_64(ref scenario_0, ref side_0, int_3, int_4, ref activeUnit2, ref flight4, false, num28);
											Mission.EmptyAircraftSlot item4 = new Mission.EmptyAircraftSlot(aircraft2, aircraft2.DBID, aircraft2.string_2, aircraft2.method_166(), aircraft2.method_165(), ref activeUnit2, activeUnit2.string_0, activeUnit2.Name, false);
											list30.Add(aircraft2);
											list31.Add(item4);
											num28++;
										}
										List<Aircraft> list32 = Enumerable.ToList<Aircraft>(list30);
										flight9 = null;
										Mission._FlightSize flightSize = Mission._FlightSize.None;
										Mission._FlightSize flightSize2 = Mission._FlightSize.None;
										bool flag4 = false;
										num18 = 0;
										num17 = 0;
										num16 = 0;
										num15 = 0;
										num14 = 0;
										num9 = 0;
										num5 = 0;
										num6 = 0;
										int num7 = 0;
										int num8 = 0;
										list17 = Enumerable.ToList<Aircraft>(list30);
										list18 = new List<Aircraft>();
										list19 = new List<Aircraft>();
										bool flag5 = false;
										float num10 = 0f;
										float num11 = 0f;
										if (!GameGeneral.smethod_32(ref scenario_0, ref side_0, ref mission_0, bool_7, ref list30, ref flightSize_2, ref flightSize, ref flightSize2, ref bool_13, ref flag4, ref num25, ref num12, ref num18, ref num17, ref num16, ref num15, ref num14, ref num9, ref num5, ref num6, ref num7, ref num8, ref list17, ref list32, ref list18, ref list19, ref enum2, ref flag5, ref list4, ref list5, ref num10, ref num11, ref text2, ref num26, ref num27, bool_8, null, null, true, ref list3, bool_9))
										{
											break;
										}
										if (list32.Count <= 0)
										{
											goto IL_D9B;
										}
										flightSize2 = Mission._FlightSize.None;
										flightSize = Mission._FlightSize.None;
										flag5 = false;
										num8 = 0;
										num7 = 0;
										num6 = 0;
										num5 = 0;
										list19 = new List<Aircraft>();
										list18 = new List<Aircraft>();
										flag4 = false;
										num11 = 0f;
										num10 = 0f;
										bool bool_14 = false;
										List<Group> list15 = null;
										list17 = null;
										list16 = null;
										list14 = null;
										List<Aircraft> list13 = new List<Aircraft>();
										bool flag3 = false;
										if (!GameGeneral.smethod_37(ref scenario_0, ref side_0, ref mission_0, bool_7, ref list, ref flightSize_2, ref flightSize2, ref flightSize, ref bool_13, ref flag5, ref num25, ref num12, ref num8, ref num7, ref num6, ref num5, ref list32, ref list19, ref list18, ref enum2, ref flag4, ref list29, ref num11, ref num10, bool_14, ref list15, ref list17, ref list16, ref list14, ref list28, ref list13, ref text2, double_0, ref flag3, false, bool_8, true, ref flight9, bool_9))
										{
											goto IL_D8D;
										}
										if (Information.IsNothing(flight9))
										{
											goto IL_DA7;
										}
										flight9._FlightTask_0 = Mission._FlightTask.const_48;
										if (Information.IsNothing(mission_0.list_2))
										{
											mission_0.list_2 = new List<Mission.EmptyAircraftSlot>();
										}
										try
										{
											foreach (Mission.EmptyAircraftSlot emptyAircraftSlot2 in list31)
											{
												emptyAircraftSlot2.method_6(scenario_0, flight9);
												emptyAircraftSlot2.string_2 = flight9.string_0;
												emptyAircraftSlot2.method_4(scenario_0, activeUnit2);
												emptyAircraftSlot2.string_3 = activeUnit2.string_0;
												emptyAircraftSlot2.string_4 = activeUnit2.Name;
												emptyAircraftSlot2.string_2 = flight9.string_0;
												mission_0.list_2.Add(emptyAircraftSlot2);
											}
										}
										finally
										{
											List<Mission.EmptyAircraftSlot>.Enumerator enumerator5;
											((IDisposable)enumerator5).Dispose();
										}
										num24++;
										if (num24 >= num13)
										{
											goto IL_DA7;
										}
									}
									if (Debugger.IsAttached)
									{
										Debugger.Break();
										goto IL_DA7;
									}
									goto IL_DA7;
									IL_D8D:
									if (Debugger.IsAttached)
									{
										Debugger.Break();
										goto IL_DA7;
									}
									goto IL_DA7;
									IL_D9B:
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
								IL_DA7:;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x002994A8 File Offset: 0x002976A8
		private static void smethod_31(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, double double_0)
		{
			try
			{
				if (mission_0.method_54())
				{
					bool flag = false;
					if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol)
					{
						flag = ((Class343)mission_0).bool_31;
					}
					if (mission_0._MissionClass_0 == Mission._MissionClass.Support)
					{
						flag = ((Class344)mission_0).bool_29;
					}
					if (flag)
					{
						List<Mission.Flight> list = new List<Mission.Flight>();
						List<Mission.Flight> list2 = new List<Mission.Flight>();
						try
						{
							foreach (Mission.Flight flight in mission_0.list_1)
							{
								if (flight.enum93_0 != Mission.Enum93.const_1)
								{
									if (flight._FlightTask_0 == Mission._FlightTask.const_48)
									{
										if (flight.method_10(scenario_0) == Mission.Enum102.const_0 && flight.int_1 >= (int)flight._FlightSize_1 && flight.int_1 >= flight.int_0)
										{
											list.Add(flight);
										}
									}
									else if (flight.int_0 >= (int)flight._FlightSize_0)
									{
										list2.Add(flight);
									}
								}
							}
						}
						finally
						{
							List<Mission.Flight>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (list.Count != 0)
						{
							if (list2.Count == 0)
							{
								try
								{
									foreach (Mission.Flight flight2 in list)
									{
										mission_0.method_20(ref scenario_0, ref side_0, ref flight2);
									}
								}
								finally
								{
									List<Mission.Flight>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
							else
							{
								List<Group> list3 = new List<Group>();
								List<Aircraft> list4 = new List<Aircraft>();
								bool flag2 = false;
								List<ActiveUnit> list5 = mission_0.method_15(scenario_0);
								int count = list5.Count;
								if (mission_0._MissionClass_0 == Mission._MissionClass.Patrol && !flag2)
								{
									int i = count - 1;
									while (i >= 0)
									{
										ActiveUnit activeUnit = list5[i];
										if (activeUnit.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedOffensive)
										{
											if (activeUnit.vmethod_108() != ActiveUnit._ActiveUnitStatus.EngagedDefensive)
											{
												if (activeUnit.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester && activeUnit.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO && activeUnit.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsShotgun)
												{
													if (activeUnit.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO)
													{
														i += -1;
														continue;
													}
												}
												flag2 = true;
												break;
											}
										}
										flag2 = true;
										break;
									}
								}
								if (!flag2)
								{
									for (int j = count - 1; j >= 0; j += -1)
									{
										ActiveUnit activeUnit = list5[j];
										if ((activeUnit.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsBingo || activeUnit.vmethod_110() == ActiveUnit._ActiveUnitFuelState.IsJoker) && activeUnit.method_86())
										{
											flag2 = true;
											break;
										}
									}
								}
								if (flag2)
								{
									for (int k = list.Count - 1; k >= 0; k += -1)
									{
										Mission.Flight flight3 = list[k];
										ActiveUnit activeUnit2 = scenario_0.vmethod_0()[flight3.string_5];
										if (!flight3.method_12())
										{
											List<ActiveUnit> list6 = new List<ActiveUnit>();
											foreach (ActiveUnit activeUnit3 in side_0.activeUnit_0)
											{
												if (!Information.IsNothing(activeUnit3.vmethod_101()) && !Information.IsNothing(activeUnit3.vmethod_85().method_7()) && flight3 == activeUnit3.vmethod_85().method_7() && activeUnit3.bool_3 && !activeUnit3.vmethod_127())
												{
													Aircraft aircraft = (Aircraft)activeUnit3;
													Aircraft aircraft2 = aircraft;
													string text = null;
													if (aircraft2.method_147(ref text) == Aircraft_AirOps.Enum44.const_0 && aircraft.vmethod_123())
													{
														list6.Add(activeUnit3);
														list4.Add((Aircraft)activeUnit3);
													}
												}
											}
											if (list6.Count != 0 && list6.Count > 1)
											{
												if (list6.Count < (int)flight3._FlightSize_1)
												{
													try
													{
														foreach (ActiveUnit activeUnit4 in list6)
														{
															list4.Remove((Aircraft)activeUnit4);
														}
													}
													finally
													{
														List<ActiveUnit>.Enumerator enumerator3;
														((IDisposable)enumerator3).Dispose();
													}
													if (mission_0.int_0 == 1)
													{
														scenario_0.method_59(string.Concat(new string[]
														{
															"Flight ",
															flight3.string_4,
															" requires minimum ",
															Conversions.ToString((int)flight3._FlightSize_1),
															" aircraft, however only ",
															Conversions.ToString(list6.Count),
															" are ready For take-off! The flight will Not launch!"
														}), flight3.string_4 + " not launching (not enough AC ready)", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit2.vmethod_28(null), activeUnit2.vmethod_30(null)));
													}
												}
												else
												{
													Mission.Flight flight4 = list6[0].vmethod_85().method_7();
													Group group = new Group(ref scenario_0, ref side_0, list6, true, null, mission_0);
													list3.Add(group);
													int num = 2;
													try
													{
														foreach (ActiveUnit activeUnit5 in group.vmethod_141().Values)
														{
															if (activeUnit5.method_122())
															{
																activeUnit5.method_123(flight4, 1);
																group.Name = "Flight " + flight4.string_4;
															}
															else
															{
																activeUnit5.method_123(flight4, num);
																num++;
															}
														}
													}
													finally
													{
														IEnumerator<ActiveUnit> enumerator4;
														if (enumerator4 != null)
														{
															enumerator4.Dispose();
														}
													}
												}
											}
										}
									}
								}
								mission_0.method_43(ref scenario_0, list3, list4, null, null);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00299A38 File Offset: 0x00297C38
		private static bool smethod_32(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, bool bool_7, ref List<Aircraft> list_1, ref Mission._FlightSize _FlightSize_0, ref Mission._FlightSize _FlightSize_1, ref Mission._FlightSize _FlightSize_2, ref bool bool_8, ref bool bool_9, ref int int_5, ref int int_6, ref int int_7, ref int int_8, ref int int_9, ref int int_10, ref int int_11, ref int int_12, ref int int_13, ref int int_14, ref int int_15, ref int int_16, ref List<Aircraft> list_2, ref List<Aircraft> list_3, ref List<Aircraft> list_4, ref List<Aircraft> list_5, ref Doctrine.Enum56? nullable_0, ref bool bool_10, ref List<int> list_6, ref List<int> list_7, ref float float_1, ref float float_2, ref string string_14, ref int int_17, ref int int_18, bool bool_11, DateTime? nullable_1, DateTime? nullable_2, bool bool_12, ref List<ActiveUnit> list_8, bool bool_13)
		{
			bool result;
			try
			{
				List<Mission.Flight> list = new List<Mission.Flight>();
				try
				{
					foreach (Mission.Flight flight in mission_0.list_0)
					{
						if (Information.IsNothing(flight))
						{
							list.Add(flight);
						}
						else
						{
							flight.method_17();
							flight.bool_13 = false;
							if (mission_0._MissionClass_0 == Mission._MissionClass.Strike && Information.IsNothing(flight.contact_0))
							{
								Mission.Flight flight2 = flight;
								Waypoint[] waypoint_ = flight2.method_18();
								Class429.smethod_38(ref waypoint_);
								flight2.method_19(waypoint_);
							}
							if (flight.int_4 > 120)
							{
								flight.int_4 = 0;
								Mission.Flight flight3 = flight;
								Waypoint[] waypoint_ = flight3.method_18();
								Class429.smethod_38(ref waypoint_);
								flight3.method_19(waypoint_);
								flight.bool_14 = false;
							}
							else if (flight.int_4 > 10 && !flight.bool_14)
							{
								flight.int_4 = 0;
								Mission.Flight flight4 = flight;
								Waypoint[] waypoint_ = flight4.method_18();
								Class429.smethod_38(ref waypoint_);
								flight4.method_19(waypoint_);
							}
							else if (!bool_12)
							{
								Mission.Flight flight5 = flight;
								ref int ptr = ref flight5.int_4;
								flight5.int_4 = ptr + 1;
							}
							if (Enumerable.Count<Waypoint>(flight.method_15()) == 0 && Enumerable.Count<Waypoint>(flight.method_18()) == 0 && !flight.bool_14 && !flight.bool_16)
							{
								list.Add(flight);
							}
							flight.bool_16 = false;
						}
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Mission.Flight item in list)
					{
						mission_0.list_0.Remove(item);
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				switch (mission_0._MissionClass_0)
				{
				case Mission._MissionClass.Strike:
				{
					Strike strike = (Strike)mission_0;
					bool_8 = mission_0.bool_12;
					bool_9 = strike.bool_28;
					if (strike.bool_25 && strike.bool_26)
					{
						if (mission_0.int_0 == 1 || bool_13)
						{
							scenario_0.method_59("***WARNING*** Mission " + mission_0.Name + " is only allowed to be executed once. This mission has been flown and will not take off again. Removing aircraft from mission.", mission_0.Name + " is one-time and now over", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_13)
						{
							GameGeneral.smethod_1("***WARNING*** Mission " + mission_0.Name + " is only allowed to be executed once. This mission has been flown and will not take off again. Removing aircraft from mission.");
						}
						try
						{
							foreach (Aircraft aircraft in list_1)
							{
								if (!aircraft.vmethod_127() && !aircraft.method_164().method_22())
								{
									ActiveUnit activeUnit = aircraft;
									Mission value = null;
									bool setMissionOnly = false;
									Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
									activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
								}
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						return false;
					}
					if (strike.bool_27 && strike.hashSet_0.Count == 0)
					{
						if (mission_0.int_0 == 1 || bool_13)
						{
							scenario_0.method_59("Mission " + mission_0.Name + " is only allowed to attack targets In the target list, and the list is empty. As such the mission will not launch. Either add targets or uncheck Pre-Planned Targets Only", mission_0.Name + " not launching (no defined targets)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_13)
						{
							GameGeneral.smethod_1("Mission " + mission_0.Name + " is only allowed to attack targets In the target list, and the list is empty. As such the mission will not launch. Either add targets or uncheck Pre-Planned Targets Only");
						}
						return false;
					}
					_FlightSize_0 = mission_0._FlightSize_0;
					_FlightSize_1 = strike._FlightSize_1;
					_FlightSize_2 = strike._FlightSize_2;
					int_6 = mission_0.method_34(ref _FlightSize_0, ref strike._FlightQty_3);
					int_8 = mission_0.method_34(ref _FlightSize_1, ref strike._FlightQty_4);
					int_10 = mission_0.method_34(ref _FlightSize_2, ref strike._FlightQty_5);
					int_5 = mission_0.method_34(ref _FlightSize_0, ref strike._FlightQty_0);
					int_7 = mission_0.method_34(ref _FlightSize_1, ref strike._FlightQty_1);
					int_9 = mission_0.method_34(ref _FlightSize_2, ref strike._FlightQty_2);
					if (!GameGeneral.smethod_44(ref scenario_0, ref side_0, ref mission_0, ref list_1, ref list_2, new int?(int_5), _FlightSize_0))
					{
						return false;
					}
					if (!Information.IsNothing(int_5) && list_2.Count < int_5)
					{
						if (mission_0.int_0 == 1 || bool_13)
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								(strike._FlightQty_0 == Mission._FlightQty.All) ? "All" : int_5.ToString(),
								" aircraft, however only ",
								Conversions.ToString(list_2.Count),
								" are available"
							}), "Not enough AC available", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_13)
						{
							GameGeneral.smethod_1(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								(strike._FlightQty_0 == Mission._FlightQty.All) ? "All" : int_5.ToString(),
								" aircraft, however only ",
								Conversions.ToString(list_2.Count),
								" are available"
							}));
						}
						return false;
					}
					if (int_6 > 0 && int_11 > 0)
					{
						return false;
					}
					if (int_8 > 0 && int_12 > 0)
					{
						return false;
					}
					if (_FlightSize_2 != Mission._FlightSize.None && int_10 > 0 && int_13 > 0)
					{
						return false;
					}
					Strike.StrikeType strikeType_ = strike.strikeType_0;
					if (strikeType_ != Strike.StrikeType.Air_Intercept)
					{
						if (strikeType_ - Strike.StrikeType.Land_Strike <= 2)
						{
							Contact contact_;
							GameGeneral.smethod_35(ref scenario_0, ref side_0, ref mission_0, ref strike, bool_7, ref _FlightSize_0, ref _FlightSize_1, ref _FlightSize_2, ref list_3, ref list_4, ref list_5, ref list_2, contact_, ref string_14, ref int_17, ref float_1, ref float_2, ref int_18, ref nullable_0, ref bool_10, bool_11, nullable_1, nullable_2, bool_12, bool_13);
						}
					}
					else
					{
						GameGeneral.smethod_34(ref scenario_0, ref side_0, ref mission_0, ref strike, bool_7, ref _FlightSize_0, ref _FlightSize_1, ref _FlightSize_2, ref list_3, ref list_4, ref list_5, ref list_2, ref string_14, ref int_17, ref int_18, ref nullable_0, bool_11, nullable_1, nullable_2, bool_12, bool_13);
					}
					if (mission_0.list_0.Count <= 0)
					{
						goto IL_130C;
					}
					try
					{
						foreach (Mission.Flight flight6 in mission_0.list_0)
						{
							ActiveUnit activeUnit2 = scenario_0.vmethod_0()[flight6.string_5];
							if (flight6.bool_17 && !Information.IsNothing(flight6.method_32(scenario_0)) && !string.IsNullOrEmpty(flight6.string_21))
							{
								if (mission_0.int_0 == 1 || bool_13)
								{
									scenario_0.method_59(string.Concat(new string[]
									{
										"Mission ",
										strike.Name,
										", aircraft type ",
										flight6.method_32(scenario_0).string_2,
										" With loadout ",
										((Aircraft)flight6.method_32(scenario_0)).method_165(),
										" based On ",
										flight6.string_6,
										" cannot launch! Reason: ",
										flight6.string_21
									}), strike.Name + " cannot launch", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit2.vmethod_28(null), activeUnit2.vmethod_30(null)));
								}
								if (bool_13)
								{
									GameGeneral.smethod_1(string.Concat(new string[]
									{
										"Mission ",
										strike.Name,
										", aircraft type ",
										flight6.method_32(scenario_0).string_2,
										" with loadout ",
										((Aircraft)flight6.method_32(scenario_0)).method_165(),
										" based on ",
										flight6.string_6,
										" cannot launch! Reason: ",
										flight6.string_21
									}));
								}
							}
						}
						goto IL_130C;
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					break;
				}
				case Mission._MissionClass.Patrol:
					break;
				case Mission._MissionClass.Support:
					goto IL_B0C;
				case Mission._MissionClass.Ferry:
					goto IL_E86;
				case Mission._MissionClass.Mining:
					goto IL_FF4;
				case Mission._MissionClass.MineClearing:
				{
					Class341 @class = (Class341)mission_0;
					_FlightSize_0 = mission_0._FlightSize_0;
					bool_8 = mission_0.bool_12;
					int_5 = @class.method_34(ref _FlightSize_0, ref @class._FlightQty_0);
					if (!GameGeneral.smethod_44(ref scenario_0, ref side_0, ref mission_0, ref list_1, ref list_2, new int?(int_5), _FlightSize_0))
					{
						return false;
					}
					if (!Information.IsNothing(int_5) && list_1.Count < int_5)
					{
						if (mission_0.int_0 == 1 || bool_13)
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_1.Count),
								"are available"
							}), mission_0.Name + " does not have enough AC", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_13)
						{
							GameGeneral.smethod_1(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_1.Count),
								"are available"
							}));
						}
						return false;
					}
					bool bool_14 = ((Class341)mission_0).bool_22;
					GameGeneral.smethod_33(false, ref list_3, bool_14, 0, ref list_8, ref list_7, ref list_1, ref list_6, ref list_2, ref _FlightSize_0, ref bool_8);
					goto IL_130C;
				}
				case Mission._MissionClass.Escort:
					_FlightSize_0 = mission_0._FlightSize_0;
					bool_8 = mission_0.bool_12;
					goto IL_130C;
				default:
					goto IL_130C;
				}
				Class343 class2 = (Class343)mission_0;
				_FlightSize_0 = mission_0._FlightSize_0;
				bool_8 = mission_0.bool_12;
				if (!bool_12)
				{
					int_5 = class2.method_34(ref _FlightSize_0, ref class2._FlightQty_0);
					if (!GameGeneral.smethod_44(ref scenario_0, ref side_0, ref mission_0, ref list_1, ref list_2, new int?(int_5), _FlightSize_0))
					{
						return false;
					}
					if (!Information.IsNothing(int_5) && list_1.Count < int_5)
					{
						if (mission_0.int_0 == 1 || bool_13)
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_1.Count),
								"are available"
							}), mission_0.Name + " does not have enough AC", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_13)
						{
							GameGeneral.smethod_1(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_1.Count),
								"are available"
							}));
						}
						return false;
					}
					int int_19 = ((Class343)mission_0).int_7;
					bool bool_15 = ((Class343)mission_0).bool_22;
					GameGeneral.smethod_33(false, ref list_3, bool_15, int_19, ref list_8, ref list_7, ref list_1, ref list_6, ref list_2, ref _FlightSize_0, ref bool_8);
				}
				if (mission_0.list_0.Count <= 0)
				{
					goto IL_130C;
				}
				try
				{
					foreach (Mission.Flight flight7 in mission_0.list_0)
					{
						ActiveUnit activeUnit3 = scenario_0.vmethod_0()[flight7.string_5];
						if (flight7.bool_17 && !Information.IsNothing(flight7.method_32(scenario_0)) && !string.IsNullOrEmpty(flight7.string_21))
						{
							if (mission_0.int_0 == 1 || bool_13)
							{
								scenario_0.method_59(string.Concat(new string[]
								{
									"Mission ",
									class2.Name,
									", aircraft type ",
									flight7.method_32(scenario_0).string_2,
									" with loadout ",
									((Aircraft)flight7.method_32(scenario_0)).method_165(),
									" based on ",
									flight7.string_6,
									" cannot launch! Reason: ",
									flight7.string_21
								}), class2.Name + " cannot launch", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit3.vmethod_28(null), activeUnit3.vmethod_30(null)));
							}
							if (bool_13)
							{
								GameGeneral.smethod_1(string.Concat(new string[]
								{
									"Mission ",
									class2.Name,
									", aircraft type ",
									flight7.method_32(scenario_0).string_2,
									" with loadout ",
									((Aircraft)flight7.method_32(scenario_0)).method_165(),
									" based on ",
									flight7.string_6,
									" cannot launch! Reason: ",
									flight7.string_21
								}));
							}
						}
					}
					goto IL_130C;
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator5;
					((IDisposable)enumerator5).Dispose();
				}
				IL_B0C:
				Class344 class3 = (Class344)mission_0;
				_FlightSize_0 = mission_0._FlightSize_0;
				bool_8 = mission_0.bool_12;
				if (!bool_12)
				{
					int_5 = class3.method_34(ref _FlightSize_0, ref class3._FlightQty_0);
					if (!GameGeneral.smethod_44(ref scenario_0, ref side_0, ref mission_0, ref list_1, ref list_2, new int?(int_5), _FlightSize_0))
					{
						return false;
					}
					if (!Information.IsNothing(int_5) && list_1.Count < int_5)
					{
						if (mission_0.int_0 == 1 || bool_13)
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_1.Count),
								"are available"
							}), mission_0.Name + " does not have enough AC", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_13)
						{
							GameGeneral.smethod_1(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_1.Count),
								"are available"
							}));
						}
						return false;
					}
					int int_20 = ((Class344)mission_0).int_7;
					bool bool_16 = ((Class344)mission_0).bool_22;
					GameGeneral.smethod_33(false, ref list_3, bool_16, int_20, ref list_8, ref list_7, ref list_1, ref list_6, ref list_2, ref _FlightSize_0, ref bool_8);
				}
				if (mission_0.list_0.Count <= 0)
				{
					goto IL_130C;
				}
				try
				{
					foreach (Mission.Flight flight8 in mission_0.list_0)
					{
						ActiveUnit activeUnit4 = scenario_0.vmethod_0()[flight8.string_5];
						if (flight8.bool_17 && !Information.IsNothing(flight8.method_32(scenario_0)) && !string.IsNullOrEmpty(flight8.string_21))
						{
							if (mission_0.int_0 == 1 || bool_13)
							{
								scenario_0.method_59(string.Concat(new string[]
								{
									"Mission ",
									class3.Name,
									", aircraft type ",
									flight8.method_32(scenario_0).string_2,
									" with loadout ",
									((Aircraft)flight8.method_32(scenario_0)).method_165(),
									" based on ",
									flight8.string_6,
									" cannot launch! Reason: ",
									flight8.string_21
								}), class3.Name + " cannot launch", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit4.vmethod_28(null), activeUnit4.vmethod_30(null)));
							}
							if (bool_13)
							{
								GameGeneral.smethod_1(string.Concat(new string[]
								{
									"Mission ",
									class3.Name,
									", aircraft type ",
									flight8.method_32(scenario_0).string_2,
									" with loadout ",
									((Aircraft)flight8.method_32(scenario_0)).method_165(),
									" based on ",
									flight8.string_6,
									" cannot launch! Reason: ",
									flight8.string_21
								}));
							}
						}
					}
					goto IL_130C;
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				IL_E86:
				FerryMission ferryMission = (FerryMission)mission_0;
				_FlightSize_0 = mission_0._FlightSize_0;
				bool_8 = mission_0.bool_12;
				int_5 = ferryMission.method_34(ref _FlightSize_0, ref ferryMission._FlightQty_0);
				if (!GameGeneral.smethod_44(ref scenario_0, ref side_0, ref mission_0, ref list_1, ref list_2, new int?(int_5), _FlightSize_0))
				{
					if (mission_0.int_0 == 1 || bool_13)
					{
						scenario_0.method_59(string.Concat(new string[]
						{
							"Mission ",
							mission_0.Name,
							" requires a minimum of ",
							Conversions.ToString(int_5),
							" aircraft, however only ",
							Conversions.ToString(list_1.Count),
							"are available"
						}), mission_0.Name + " does not have enough AC", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
					}
					if (bool_13)
					{
						GameGeneral.smethod_1(string.Concat(new string[]
						{
							"Mission ",
							mission_0.Name,
							" requires a minimum of ",
							Conversions.ToString(int_5),
							" aircraft, however only ",
							Conversions.ToString(list_1.Count),
							"are available"
						}));
					}
					return false;
				}
				try
				{
					foreach (Aircraft item2 in list_2)
					{
						list_3.Add(item2);
					}
					goto IL_130C;
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator7;
					((IDisposable)enumerator7).Dispose();
				}
				IL_FF4:
				Class340 class4 = (Class340)mission_0;
				_FlightSize_0 = mission_0._FlightSize_0;
				bool_8 = mission_0.bool_12;
				int_5 = mission_0.method_34(ref _FlightSize_0, ref class4._FlightQty_0);
				if (!GameGeneral.smethod_44(ref scenario_0, ref side_0, ref mission_0, ref list_1, ref list_2, new int?(int_5), _FlightSize_0))
				{
					return false;
				}
				if (!Information.IsNothing(int_5) && list_1.Count < int_5)
				{
					if (mission_0.int_0 == 1 || bool_13)
					{
						scenario_0.method_59(string.Concat(new string[]
						{
							"Mission ",
							mission_0.Name,
							" requires a minimum of ",
							Conversions.ToString(int_5),
							" aircraft, however only ",
							Conversions.ToString(list_1.Count),
							"are available"
						}), mission_0.Name + " does not have enough AC", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
					}
					if (bool_13)
					{
						GameGeneral.smethod_1(string.Concat(new string[]
						{
							"Mission ",
							mission_0.Name,
							" requires a minimum of ",
							Conversions.ToString(int_5),
							" aircraft, however only ",
							Conversions.ToString(list_1.Count),
							"are available"
						}));
					}
					return false;
				}
				bool bool_17 = ((Class340)mission_0).bool_22;
				GameGeneral.smethod_33(false, ref list_3, bool_17, 0, ref list_8, ref list_7, ref list_1, ref list_6, ref list_2, ref _FlightSize_0, ref bool_8);
				IL_130C:
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x0029AE58 File Offset: 0x00299058
		private static void smethod_33(bool bool_7, ref List<Aircraft> list_1, bool bool_8, int int_5, ref List<ActiveUnit> list_2, ref List<int> list_3, ref List<Aircraft> list_4, ref List<int> list_5, ref List<Aircraft> list_6, ref Mission._FlightSize _FlightSize_0, ref bool bool_9)
		{
			try
			{
				int num = int_5;
				if (!bool_8 && num <= 0)
				{
					try
					{
						foreach (Aircraft item in list_6)
						{
							list_1.Add(item);
						}
						goto IL_348;
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				try
				{
					List<int>.Enumerator enumerator2 = list_3.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						GameGeneral.Class536 @class = new GameGeneral.Class536(@class);
						@class.int_0 = enumerator2.Current;
						if (bool_8)
						{
							num = int_5;
						}
						List<Aircraft> list = Enumerable.ToList<Aircraft>(Enumerable.Where<Aircraft>(list_4, new Func<Aircraft, bool>(@class.method_0)));
						List<Aircraft> list2 = new List<Aircraft>();
						if (list.Count > 0)
						{
							try
							{
								List<int>.Enumerator enumerator3 = list_5.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									GameGeneral.Class537 class2 = new GameGeneral.Class537(class2);
									class2.class536_0 = @class;
									class2.int_0 = enumerator3.Current;
									try
									{
										List<ActiveUnit>.Enumerator enumerator4 = list_2.GetEnumerator();
										while (enumerator4.MoveNext())
										{
											GameGeneral.Class538 class3 = new GameGeneral.Class538(class3);
											class3.class537_0 = class2;
											class3.activeUnit_0 = enumerator4.Current;
											List<Aircraft> list3;
											if (bool_7)
											{
												list3 = Enumerable.ToList<Aircraft>(Enumerable.Where<Aircraft>(list, new Func<Aircraft, bool>(class3.method_0)));
											}
											else
											{
												list3 = Enumerable.ToList<Aircraft>(Enumerable.Where<Aircraft>(list_6, new Func<Aircraft, bool>(class3.method_1)));
											}
											if (list3.Count > 0 && !(bool_9 & list3.Count < (int)_FlightSize_0))
											{
												if (bool_8 && num > 0)
												{
													num = (int)Math.Round(Math.Ceiling(Math.Max((double)list.Count / (double)_FlightSize_0 / 3.0, (double)num / (double)_FlightSize_0)) * (double)_FlightSize_0);
												}
												else if (bool_8 && num == 0)
												{
													num = (int)Math.Round(Math.Ceiling((double)list.Count / (double)_FlightSize_0 / 3.0) * (double)_FlightSize_0);
												}
												else if (!bool_8 && num > 0)
												{
													num = (int)Math.Round(Math.Ceiling((double)num / (double)_FlightSize_0) * (double)_FlightSize_0);
												}
												int num2;
												if (bool_7)
												{
													num2 = (int)Math.Round(Math.Ceiling((double)(num - list2.Count) / (double)_FlightSize_0) * (double)_FlightSize_0);
												}
												else
												{
													List<Aircraft> list4 = Enumerable.ToList<Aircraft>(Enumerable.Where<Aircraft>(list, (GameGeneral._Closure$__.$I95-3 == null) ? (GameGeneral._Closure$__.$I95-3 = new Func<Aircraft, bool>(GameGeneral._Closure$__.$I.method_0)) : GameGeneral._Closure$__.$I95-3));
													list4.AddRange(list2);
													num2 = (int)Math.Round(Math.Ceiling((double)(num - list4.Count) / (double)_FlightSize_0) * (double)_FlightSize_0);
												}
												if (!Information.IsNothing(num2) && num2 > 0)
												{
													int num3 = num2 - 1;
													while (num3 >= 0 && (!bool_9 || list3.Count >= (int)_FlightSize_0))
													{
														int num4 = (int)_FlightSize_0;
														for (int i = 1; i <= num4; i++)
														{
															if (list3.Count > 0)
															{
																list_1.Add(list3[0]);
																list2.Add(list3[0]);
																list3.Remove(list3[0]);
																if (i > 1)
																{
																	num3--;
																}
															}
														}
														num3 += -1;
													}
												}
											}
										}
									}
									finally
									{
										List<ActiveUnit>.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
								}
							}
							finally
							{
								List<int>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
					}
				}
				finally
				{
					List<int>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				IL_348:;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x0029B264 File Offset: 0x00299464
		private static void smethod_34(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref Strike strike_0, bool bool_7, ref Mission._FlightSize _FlightSize_0, ref Mission._FlightSize _FlightSize_1, ref Mission._FlightSize _FlightSize_2, ref List<Aircraft> list_1, ref List<Aircraft> list_2, ref List<Aircraft> list_3, ref List<Aircraft> list_4, ref string string_14, ref int int_5, ref int int_6, ref Doctrine.Enum56? nullable_0, bool bool_8, DateTime? nullable_1, DateTime? nullable_2, bool bool_9, bool bool_10)
		{
			try
			{
				List<Mission.Class286> list = new List<Mission.Class286>();
				try
				{
					foreach (Aircraft aircraft in list_4)
					{
						if (list.Count > 0)
						{
							bool flag = false;
							try
							{
								foreach (Mission.Class286 @class in list)
								{
									if (Operators.CompareString(@class.string_0, aircraft.method_164().method_30().string_0, false) == 0 && @class.int_0 == aircraft.DBID && @class.int_1 == aircraft.method_167().DBID)
									{
										flag = true;
									}
								}
							}
							finally
							{
								List<Mission.Class286>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							if (flag)
							{
								continue;
							}
						}
						bool flag2 = true;
						if (aircraft.method_158().bool_2)
						{
							if (aircraft.method_167().method_12() && _FlightSize_2 != Mission._FlightSize.None)
							{
								list_3.Add(aircraft);
							}
							else
							{
								list_2.Add(aircraft);
							}
						}
						else
						{
							Doctrine.Enum59? nullable_3 = aircraft.doctrine_0.method_162(scenario_0, false, false, false);
							try
							{
								foreach (Contact contact in side_0.method_44())
								{
									if (aircraft.method_158().method_39(contact, mission_0, nullable_3, false, false, true, null, ref string_14, ref int_5) && aircraft.method_158().method_31(ref strike_0, contact.method_130(aircraft.vmethod_7(false))) && aircraft.method_158().method_27(contact, strike_0.int_10, strike_0.int_11, nullable_0, mission_0.bool_17, ref string_14) && contact.method_120(scenario_0, side_0, false, null).Count < (int)_FlightSize_0)
									{
										aircraft.method_158().vmethod_4(contact);
										list_1.Add(aircraft);
										flag2 = false;
										break;
									}
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							if (flag2)
							{
								Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
								Mission.Class286 item = new Mission.Class286(aircraft_AirOps.method_30().string_0, aircraft_AirOps.method_30().Name, aircraft.DBID, aircraft.string_2, aircraft.method_167().DBID, aircraft.method_167().Name);
								list.Add(item);
							}
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list.Count > 0)
				{
					try
					{
						foreach (Mission.Class286 class2 in list)
						{
							if (!string.IsNullOrEmpty(string_14))
							{
								if (mission_0.int_0 == 1 || bool_10)
								{
									ActiveUnit activeUnit = scenario_0.vmethod_0()[class2.string_0];
									scenario_0.method_59(string.Concat(new string[]
									{
										"Mission ",
										strike_0.Name,
										", aircraft type ",
										class2.string_2,
										" with loadout ",
										class2.string_3,
										" based on ",
										class2.string_1,
										" cannot launch! Reason: ",
										string_14
									}), strike_0.Name + " cannot launch", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
								}
								if (bool_10)
								{
									GameGeneral.smethod_1(string.Concat(new string[]
									{
										"Mission ",
										strike_0.Name,
										", aircraft type ",
										class2.string_2,
										" with loadout ",
										class2.string_3,
										" based on ",
										class2.string_1,
										" cannot launch! Reason: ",
										string_14
									}));
								}
							}
						}
					}
					finally
					{
						List<Mission.Class286>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x0029B6E0 File Offset: 0x002998E0
		private static void smethod_35(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref Strike strike_0, bool bool_7, ref Mission._FlightSize _FlightSize_0, ref Mission._FlightSize _FlightSize_1, ref Mission._FlightSize _FlightSize_2, ref List<Aircraft> list_1, ref List<Aircraft> list_2, ref List<Aircraft> list_3, ref List<Aircraft> list_4, Contact contact_0, ref string string_14, ref int int_5, ref float float_1, ref float float_2, ref int int_6, ref Doctrine.Enum56? nullable_0, ref bool bool_8, bool bool_9, DateTime? nullable_1, DateTime? nullable_2, bool bool_10, bool bool_11)
		{
			try
			{
				try
				{
					foreach (Aircraft aircraft in list_4)
					{
						if (aircraft.method_158().bool_2)
						{
							if (aircraft.method_167().method_12() && _FlightSize_2 != Mission._FlightSize.None)
							{
								list_3.Add(aircraft);
							}
							else
							{
								list_2.Add(aircraft);
							}
						}
						else
						{
							Mission.Flight flight = null;
							if (!GameGeneral.smethod_36(ref mission_0, ref aircraft, ref list_1, ref contact_0, ref flight, bool_9))
							{
								bool flag = true;
								Doctrine.Enum59? nullable_3 = aircraft.doctrine_0.method_162(scenario_0, false, false, false);
								if (strike_0.hashSet_0.Count > 0)
								{
									try
									{
										foreach (Contact contact in side_0.method_44())
										{
											if (contact.method_92(strike_0) && aircraft.method_158().method_31(ref strike_0, contact.method_130(side_0)) && aircraft.method_161().method_6(contact, true, aircraft.doctrine_0, ref string_14, ref int_6, null))
											{
												if (Information.IsNothing(flight))
												{
													Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
													string string_15;
													if (strike_0.strikeType_0 == Strike.StrikeType.Sub_Strike)
													{
														string_15 = "Master Flightplan";
													}
													else
													{
														string_15 = "Master Flightplan AircraftDBID: " + Conversions.ToString(aircraft.DBID) + " LoadoutDBID: " + Conversions.ToString(aircraft.method_166());
													}
													Mission.Flight flight2 = null;
													flight = new Mission.Flight(ref scenario_0, ref mission_0, ref flight2, string_15, aircraft_AirOps.method_30().string_0, aircraft_AirOps.method_30().Name, aircraft.method_167().DBID, contact, aircraft, _FlightSize_0, false);
												}
												ActiveUnit_AI activeUnit_AI = aircraft.method_158();
												int int_7 = strike_0.int_10;
												int int_8 = strike_0.int_11;
												Doctrine.Enum56? nullable_4 = nullable_0;
												bool bool_12 = mission_0.bool_17;
												Mission.Enum92 enum92_ = strike_0.enum92_0;
												bool bool_13 = true;
												bool bool_14 = false;
												bool bool_15 = false;
												bool bool_16 = strike_0.bool_22;
												float num = 0f;
												if (activeUnit_AI.method_30(ref scenario_0, ref side_0, ref mission_0, ref flight, ref contact, int_7, int_8, nullable_4, bool_12, enum92_, bool_13, bool_14, bool_15, bool_16, ref num, ref string_14, bool_7, ref bool_8, bool_8, ref float_1, ref float_2, true, null, bool_9, nullable_1, nullable_2, bool_10, true))
												{
													flag = false;
													flight.bool_17 = false;
													flight.string_21 = "";
													mission_0.method_61(ref flight);
												}
												bool flag2 = false;
												if (strike_0.strikeType_0 == Strike.StrikeType.Sub_Strike)
												{
													flag2 = true;
												}
												else if (Enumerable.Count<Waypoint>(flight.method_15()) > 0 || Enumerable.Count<Waypoint>(flight.method_18()) > 0)
												{
													flag2 = true;
												}
												if (!flag2)
												{
													if (flag)
													{
														continue;
													}
												}
												else
												{
													list_1.Add(aircraft);
													contact_0 = contact;
													aircraft.method_158().vmethod_4(contact_0);
												}
												IL_250:
												goto IL_55A;
											}
										}
										goto IL_250;
									}
									finally
									{
										List<Contact>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									goto IL_263;
								}
								goto IL_263;
								IL_489:
								if (Information.IsNothing(flight))
								{
									Aircraft_AirOps aircraft_AirOps2 = aircraft.method_164();
									string string_16;
									if (strike_0.strikeType_0 == Strike.StrikeType.Sub_Strike)
									{
										string_16 = "Master Flightplan";
									}
									else
									{
										string_16 = "Master Flightplan AircraftDBID: " + Conversions.ToString(aircraft.DBID) + " LoadoutDBID: " + Conversions.ToString(aircraft.method_166());
									}
									Mission.Flight flight2 = null;
									flight = new Mission.Flight(ref scenario_0, ref mission_0, ref flight2, string_16, aircraft_AirOps2.method_30().string_0, aircraft_AirOps2.method_30().Name, aircraft.method_167().DBID, null, aircraft, _FlightSize_0, false);
									if (bool_11)
									{
										flight.string_21 = "No targets available.";
									}
								}
								if (mission_0.list_0.Contains(flight))
								{
									continue;
								}
								mission_0.method_61(ref flight);
								flight.bool_17 = true;
								if (!string.IsNullOrEmpty(string_14))
								{
									flight.string_21 = string_14;
									continue;
								}
								continue;
								IL_263:
								List<Contact> list = new List<Contact>();
								for (int i = side_0.method_44().Count - 1; i >= 0; i += -1)
								{
									Contact contact2 = side_0.method_44()[i];
									if (aircraft.method_158().method_39(contact2, mission_0, nullable_3, false, false, true, null, ref string_14, ref int_5) && aircraft.method_161().method_6(contact2, true, aircraft.doctrine_0, ref string_14, ref int_6, null))
									{
										list.Add(contact2);
									}
								}
								try
								{
									foreach (Contact contact3 in list)
									{
										if (aircraft.method_158().method_31(ref strike_0, contact3.method_130(side_0)))
										{
											if (Information.IsNothing(flight))
											{
												Aircraft_AirOps aircraft_AirOps3 = aircraft.method_164();
												string string_17;
												if (strike_0.strikeType_0 == Strike.StrikeType.Sub_Strike)
												{
													string_17 = "Master Flightplan";
												}
												else
												{
													string_17 = "Master Flightplan AircraftDBID: " + Conversions.ToString(aircraft.DBID) + " LoadoutDBID: " + Conversions.ToString(aircraft.method_166());
												}
												Mission.Flight flight2 = null;
												flight = new Mission.Flight(ref scenario_0, ref mission_0, ref flight2, string_17, aircraft_AirOps3.method_30().string_0, aircraft_AirOps3.method_30().Name, aircraft.method_167().DBID, contact3, aircraft, _FlightSize_0, false);
											}
											ActiveUnit_AI activeUnit_AI2 = aircraft.method_158();
											int int_9 = strike_0.int_10;
											int int_10 = strike_0.int_11;
											Doctrine.Enum56? nullable_5 = nullable_0;
											bool bool_17 = mission_0.bool_17;
											Mission.Enum92 enum92_2 = strike_0.enum92_0;
											bool bool_18 = true;
											bool bool_19 = false;
											bool bool_20 = false;
											bool bool_21 = strike_0.bool_22;
											float num = 0f;
											if (activeUnit_AI2.method_30(ref scenario_0, ref side_0, ref mission_0, ref flight, ref contact3, int_9, int_10, nullable_5, bool_17, enum92_2, bool_18, bool_19, bool_20, bool_21, ref num, ref string_14, bool_7, ref bool_8, bool_8, ref float_1, ref float_2, true, null, bool_9, nullable_1, nullable_2, bool_10, true))
											{
												flag = false;
												flight.bool_17 = false;
												flight.string_21 = "";
												mission_0.method_61(ref flight);
											}
											bool flag3 = false;
											if (strike_0.strikeType_0 == Strike.StrikeType.Sub_Strike)
											{
												if (!flag)
												{
													flag3 = true;
												}
											}
											else if (Enumerable.Count<Waypoint>(flight.method_15()) > 0 || Enumerable.Count<Waypoint>(flight.method_18()) > 0)
											{
												flag3 = true;
											}
											if (!flag3)
											{
												if (flag)
												{
													continue;
												}
											}
											else
											{
												list_1.Add(aircraft);
												contact_0 = contact3;
												aircraft.method_158().vmethod_4(contact_0);
											}
											IL_476:
											goto IL_55A;
										}
									}
									goto IL_476;
								}
								finally
								{
									List<Contact>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								goto IL_489;
								IL_55A:
								if (flag)
								{
									goto IL_489;
								}
							}
						}
					}
				}
				finally
				{
					List<Aircraft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0029BD00 File Offset: 0x00299F00
		private static bool smethod_36(ref Mission mission_0, ref Aircraft aircraft_0, ref List<Aircraft> list_1, ref Contact contact_0, ref Mission.Flight flight_0, bool bool_7)
		{
			bool result;
			try
			{
				if (mission_0.list_0.Count != 0)
				{
					try
					{
						foreach (Mission.Flight flight in mission_0.list_0)
						{
							if (aircraft_0.method_166() == flight.int_3 && Operators.CompareString(aircraft_0.method_164().method_30().string_0, flight.string_5, false) == 0)
							{
								if (flight.bool_16)
								{
									return true;
								}
								if (flight.bool_17)
								{
									return true;
								}
								if (Enumerable.Count<Waypoint>(flight.method_15()) > 0)
								{
									list_1.Add(aircraft_0);
									aircraft_0.method_158().vmethod_4(contact_0);
									return true;
								}
								if (Enumerable.Count<Waypoint>(flight.method_18()) > 0)
								{
									if (flight.method_18()[0].waypointType_0 == Waypoint.WaypointType.PathfindingPoint)
									{
										flight_0 = flight;
									}
									else
									{
										ActiveUnit activeUnit = aircraft_0;
										Mission.Flight flight2;
										Waypoint[] waypoint_ = (flight2 = flight).method_18();
										bool flag = Class514.smethod_5(ref activeUnit.scenario_0, ref waypoint_, bool_7);
										flight2.method_19(waypoint_);
										if (flag)
										{
											list_1.Add(aircraft_0);
											aircraft_0.method_158().vmethod_4(contact_0);
											return true;
										}
										Mission.Flight flight3 = flight;
										waypoint_ = flight3.method_18();
										Class429.smethod_38(ref waypoint_);
										flight3.method_19(waypoint_);
										flight.bool_17 = true;
									}
								}
								else if (flight.bool_14)
								{
									return true;
								}
								break;
							}
						}
					}
					finally
					{
						List<Mission.Flight>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0029BED0 File Offset: 0x0029A0D0
		private static bool smethod_37(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, bool bool_7, ref List<Aircraft> list_1, ref Mission._FlightSize _FlightSize_0, ref Mission._FlightSize _FlightSize_1, ref Mission._FlightSize _FlightSize_2, ref bool bool_8, ref bool bool_9, ref int int_5, ref int int_6, ref int int_7, ref int int_8, ref int int_9, ref int int_10, ref List<Aircraft> list_2, ref List<Aircraft> list_3, ref List<Aircraft> list_4, ref Doctrine.Enum56? nullable_0, ref bool bool_10, ref List<int> list_5, ref float float_1, ref float float_2, bool bool_11, ref List<Group> list_6, ref List<Aircraft> list_7, ref List<Aircraft> list_8, ref List<Aircraft> list_9, ref List<ActiveUnit> list_10, ref List<Aircraft> list_11, ref string string_14, double double_0, ref bool bool_12, bool bool_13, bool bool_14, bool bool_15, ref Mission.Flight flight_0, bool bool_16)
		{
			bool result;
			try
			{
				if (mission_0._MissionClass_0 == Mission._MissionClass.Strike)
				{
					if (!Information.IsNothing(int_5) && list_2.Count < int_5)
					{
						if (mission_0.int_0 == 1 || bool_16)
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_2.Count),
								" are available. The mission will not launch."
							}), mission_0.Name + " cannot launch (not enough AC)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_16)
						{
							GameGeneral.smethod_1(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_5),
								" aircraft, however only ",
								Conversions.ToString(list_2.Count),
								" are available. The mission will not launch."
							}));
						}
						return false;
					}
					if (!Information.IsNothing(int_7) && list_3.Count < int_7)
					{
						if (mission_0.int_0 == 1 || bool_16)
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_7),
								" shooting (armed) escorts, however only ",
								Conversions.ToString(list_3.Count),
								" are available. The mission will not launch."
							}), mission_0.Name + " not launching (not enough escorts)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_16)
						{
							GameGeneral.smethod_1(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_7),
								" shooting (armed) escorts, however only ",
								Conversions.ToString(list_3.Count),
								" are available. The mission will not launch."
							}));
						}
						return false;
					}
					if (!Information.IsNothing(int_9) && list_4.Count < int_9 && _FlightSize_2 != Mission._FlightSize.None)
					{
						if (mission_0.int_0 == 1 || bool_16)
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_9),
								" non-shooting escorts (unarmed), however only ",
								Conversions.ToString(list_4.Count),
								" are available. The mission will not launch."
							}), mission_0.Name + " not launching (not enough unarmed escorts)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						if (bool_16)
						{
							GameGeneral.smethod_1(string.Concat(new string[]
							{
								"Mission ",
								mission_0.Name,
								" requires a minimum of ",
								Conversions.ToString(int_9),
								" non-shooting escorts (unarmed), however only ",
								Conversions.ToString(list_4.Count),
								" are available. The mission will not launch."
							}));
						}
						return false;
					}
				}
				else if (!Information.IsNothing(int_5) && list_1.Count < int_5)
				{
					if (mission_0.int_0 == 1 || bool_16)
					{
						scenario_0.method_59(string.Concat(new string[]
						{
							"Mission ",
							mission_0.Name,
							" requires a minimum of ",
							Conversions.ToString(int_5),
							" aircraft, however only ",
							Conversions.ToString(list_1.Count),
							" are available. The mission will not launch."
						}), mission_0.Name + " not launching (not enough AC)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
					}
					if (bool_16)
					{
						GameGeneral.smethod_1(string.Concat(new string[]
						{
							"Mission ",
							mission_0.Name,
							" requires a minimum of ",
							Conversions.ToString(int_5),
							" aircraft, however only ",
							Conversions.ToString(list_1.Count),
							" are available. The mission will not launch."
						}));
					}
					return false;
				}
				int num = 0;
				bool flag = false;
				try
				{
					List<ActiveUnit>.Enumerator enumerator = list_10.GetEnumerator();
					while (enumerator.MoveNext())
					{
						GameGeneral.Class540 @class = new GameGeneral.Class540(@class);
						@class.activeUnit_0 = enumerator.Current;
						if (flag)
						{
							break;
						}
						try
						{
							List<int>.Enumerator enumerator2 = list_5.GetEnumerator();
							IL_A0E:
							while (enumerator2.MoveNext())
							{
								GameGeneral.Class539 class2 = new GameGeneral.Class539(class2);
								class2.class540_0 = @class;
								class2.int_0 = enumerator2.Current;
								if (flag)
								{
									break;
								}
								int num2 = 0;
								IEnumerable<Aircraft> enumerable = Enumerable.Where<Aircraft>(list_2, new Func<Aircraft, bool>(class2.method_0));
								if (Enumerable.Count<Aircraft>(enumerable) > 0)
								{
									if ((Enumerable.Count<Aircraft>(enumerable) >= (int)_FlightSize_0 || !bool_8) && !flag)
									{
										if (_FlightSize_0 > Mission._FlightSize.SingleAircraft)
										{
											int num3 = Enumerable.Count<Aircraft>(enumerable);
											do
											{
												if (bool_8)
												{
													if (num3 < (int)_FlightSize_0)
													{
														goto Block_70;
													}
												}
												else if (num3 == 0)
												{
													goto IL_A0E;
												}
												List<ActiveUnit> list = new List<ActiveUnit>();
												int num4 = (int)_FlightSize_0;
												int num5 = 1;
												while (num5 <= num4 && num2 < Enumerable.Count<Aircraft>(enumerable))
												{
													if (!Information.IsNothing(Enumerable.ElementAtOrDefault<Aircraft>(enumerable, num2)))
													{
														list.Add(Enumerable.ElementAtOrDefault<Aircraft>(enumerable, num2));
														if (bool_11)
														{
															list_7.Add(Enumerable.ElementAtOrDefault<Aircraft>(enumerable, num2));
														}
														num++;
														num3--;
														num2++;
													}
													num5++;
												}
												if (bool_11)
												{
													Group item = new Group(ref scenario_0, ref side_0, list, false, null, mission_0);
													list_6.Add(item);
													if (mission_0.list_0.Count > 0)
													{
														GameGeneral.smethod_39(ref scenario_0, ref side_0, ref mission_0, ref list, ref item, ref list_11, ref bool_10, ref _FlightSize_0, ref nullable_0, ref string_14, ref float_1, ref float_2, ref bool_11, false, bool_14, bool_15, ref flight_0);
													}
													else
													{
														GameGeneral.smethod_38(ref scenario_0, ref mission_0, ref list, ref item, ref list_11, ref _FlightSize_0, ref bool_11, false, bool_14, bool_15, ref flight_0);
													}
												}
												else if (mission_0.list_0.Count > 0 && list.Count > 0)
												{
													Group group = null;
													GameGeneral.smethod_39(ref scenario_0, ref side_0, ref mission_0, ref list, ref group, ref list_11, ref bool_10, ref _FlightSize_0, ref nullable_0, ref string_14, ref float_1, ref float_2, ref bool_11, false, bool_14, bool_15, ref flight_0);
												}
												else
												{
													Group group = null;
													GameGeneral.smethod_38(ref scenario_0, ref mission_0, ref list, ref group, ref list_11, ref _FlightSize_0, ref bool_11, false, bool_14, bool_15, ref flight_0);
												}
											}
											while (mission_0._MissionClass_0 != Mission._MissionClass.Strike || int_6 <= 0 || num < int_6);
											flag = true;
											Block_70:
											continue;
										}
										try
										{
											foreach (Aircraft item2 in enumerable)
											{
												if (bool_11)
												{
													list_7.Add(item2);
												}
												if (bool_11)
												{
													if (mission_0.list_0.Count > 0)
													{
														GameGeneral.smethod_40(ref scenario_0, ref side_0, ref mission_0, ref item2, ref list_11, ref bool_10, ref _FlightSize_0, ref nullable_0, ref string_14, ref float_1, ref float_2, ref bool_11, false, bool_14, bool_15, ref flight_0);
													}
													else
													{
														GameGeneral.smethod_41(ref scenario_0, ref mission_0, ref item2, ref list_11, ref _FlightSize_0, ref bool_11, false, bool_14, bool_15, ref flight_0);
													}
												}
												else if (mission_0.list_0.Count > 0)
												{
													GameGeneral.smethod_40(ref scenario_0, ref side_0, ref mission_0, ref item2, ref list_11, ref bool_10, ref _FlightSize_0, ref nullable_0, ref string_14, ref float_1, ref float_2, ref bool_11, false, bool_14, bool_15, ref flight_0);
												}
												else
												{
													GameGeneral.smethod_41(ref scenario_0, ref mission_0, ref item2, ref list_11, ref _FlightSize_0, ref bool_11, false, bool_14, bool_15, ref flight_0);
												}
												num++;
												if (mission_0._MissionClass_0 == Mission._MissionClass.Strike && int_6 > 0 && num >= int_6)
												{
													flag = true;
													break;
												}
											}
											continue;
										}
										finally
										{
											IEnumerator<Aircraft> enumerator3;
											if (enumerator3 != null)
											{
												enumerator3.Dispose();
											}
										}
									}
									if (Enumerable.Count<Aircraft>(enumerable) < (int)_FlightSize_0 && !flag)
									{
										if (mission_0.int_0 == 1 || bool_16)
										{
											if (mission_0.enum88_0 == Mission.Enum88.const_0)
											{
												scenario_0.method_59(string.Concat(new string[]
												{
													"Mission ",
													mission_0.Name,
													", aircraft type ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).string_2,
													" with loadout ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).method_165(),
													" on host ",
													class2.class540_0.activeUnit_0.Name,
													" cannot launch. When divided by base/ship, aircraft type and loadout, there isn't enough aircraft to create the minimum number of flights. Possible solutions would be to add more strike aircraft and/or escorts, load aircraft with identical loadouts, or use aircraft from the same base/ship. Alternatively, re-configure the mission and reduce the minimum number of required strike aircraft and/or escorts, or reduce the flight size."
												}), mission_0.Name + " cannot launch", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(class2.class540_0.activeUnit_0.vmethod_28(null), class2.class540_0.activeUnit_0.vmethod_30(null)));
											}
											else
											{
												scenario_0.method_59(string.Concat(new string[]
												{
													mission_0.Name,
													", aircraft type ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).string_2,
													" with loadout ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).method_165(),
													" on host ",
													class2.class540_0.activeUnit_0.Name,
													" has problems. One or more aircraft has not been assigned to a flight, and the aircraft will not launch. Possible solutions would be to remove the aircraft from the package, change the flight size, or manually create the flight."
												}), mission_0.Name + " cannot launch", LoggedMessage.MessageType.AirOps, 0, null, side_0, new Geopoint_Struct(class2.class540_0.activeUnit_0.vmethod_28(null), class2.class540_0.activeUnit_0.vmethod_30(null)));
											}
										}
										if (bool_16)
										{
											if (mission_0.enum88_0 == Mission.Enum88.const_0)
											{
												GameGeneral.smethod_1(string.Concat(new string[]
												{
													"Mission ",
													mission_0.Name,
													", aircraft type ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).string_2,
													" with loadout ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).method_165(),
													" on host ",
													class2.class540_0.activeUnit_0.Name,
													" cannot launch. When divided by base/ship, aircraft type and loadout, there isn't enough aircraft to create the minimum number of flights. Possible solutions would be to add more strike aircraft and/or escorts, load aircraft with identical loadouts, or use aircraft from the same base/ship. Alternatively, re-configure the mission and reduce the minimum number of required strike aircraft and/or escorts, or reduce the flight size."
												}));
											}
											else
											{
												GameGeneral.smethod_1(string.Concat(new string[]
												{
													mission_0.Name,
													", aircraft type ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).string_2,
													" with loadout ",
													Enumerable.ElementAtOrDefault<Aircraft>(enumerable, 0).method_165(),
													" on host ",
													class2.class540_0.activeUnit_0.Name,
													" has problems. One or more aircraft has not been assigned to a flight, and the aircraft will not launch. Possible solutions would be to remove the aircraft from the package, change the flight size, or manually create the flight."
												}));
											}
										}
									}
								}
							}
						}
						finally
						{
							List<int>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (!Information.IsNothing(list_7) && (list_7.Count > 0 || bool_12 || bool_13))
				{
					int num6 = 0;
					int num7 = 0;
					bool flag2 = false;
					bool flag3 = false;
					try
					{
						List<ActiveUnit>.Enumerator enumerator4 = list_10.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							GameGeneral.Class542 class3 = new GameGeneral.Class542(class3);
							class3.activeUnit_0 = enumerator4.Current;
							if (flag2 && flag3)
							{
								break;
							}
							try
							{
								List<int>.Enumerator enumerator5 = list_5.GetEnumerator();
								while (enumerator5.MoveNext())
								{
									GameGeneral.Class541 class4 = new GameGeneral.Class541(class4);
									class4.class542_0 = class3;
									class4.int_0 = enumerator5.Current;
									if (flag2 && flag3)
									{
										break;
									}
									int num8 = 0;
									IEnumerable<Aircraft> enumerable2;
									IEnumerable<Aircraft> enumerable3;
									if (_FlightSize_2 == Mission._FlightSize.None)
									{
										enumerable2 = Enumerable.Where<Aircraft>(list_3, new Func<Aircraft, bool>(class4.method_0));
										enumerable3 = null;
									}
									else
									{
										enumerable2 = Enumerable.Where<Aircraft>(list_3, new Func<Aircraft, bool>(class4.method_1));
										enumerable3 = Enumerable.Where<Aircraft>(list_4, new Func<Aircraft, bool>(class4.method_2));
									}
									if (!Information.IsNothing(enumerable2) && Enumerable.Count<Aircraft>(enumerable2) > 0 && (!bool_9 || Enumerable.Count<Aircraft>(enumerable2) >= (int)_FlightSize_1) && !flag2)
									{
										if (_FlightSize_1 > Mission._FlightSize.SingleAircraft)
										{
											int num9 = Enumerable.Count<Aircraft>(enumerable2);
											do
											{
												if (bool_9)
												{
													if (num9 < (int)_FlightSize_1)
													{
														goto Block_109;
													}
												}
												else if (num9 == 0)
												{
													goto IL_D06;
												}
												List<ActiveUnit> list2 = new List<ActiveUnit>();
												int num10 = (int)_FlightSize_1;
												int num11 = 1;
												while (num11 <= num10 && num8 < Enumerable.Count<Aircraft>(enumerable2))
												{
													if (!Information.IsNothing(Enumerable.ElementAtOrDefault<Aircraft>(enumerable2, num8)))
													{
														list2.Add(Enumerable.ElementAtOrDefault<Aircraft>(enumerable2, num8));
														if (bool_11)
														{
															list_8.Add(Enumerable.ElementAtOrDefault<Aircraft>(enumerable2, num8));
														}
														num6++;
														num9--;
														num8++;
													}
													num11++;
												}
												if (bool_11)
												{
													Group item3 = new Group(ref scenario_0, ref side_0, list2, false, null, mission_0);
													list_6.Add(item3);
													bool bool_17 = true;
													bool bool_18 = false;
													Mission.Flight flight = null;
													GameGeneral.smethod_38(ref scenario_0, ref mission_0, ref list2, ref item3, ref list_11, ref _FlightSize_1, ref bool_11, bool_17, bool_14, bool_18, ref flight);
												}
												else
												{
													Group group = null;
													bool bool_19 = true;
													bool bool_20 = false;
													Mission.Flight flight = null;
													GameGeneral.smethod_38(ref scenario_0, ref mission_0, ref list2, ref group, ref list_11, ref _FlightSize_1, ref bool_11, bool_19, bool_14, bool_20, ref flight);
												}
											}
											while (mission_0._MissionClass_0 != Mission._MissionClass.Strike || int_8 <= 0 || num6 < int_8);
											flag2 = true;
											Block_109:;
										}
										else
										{
											try
											{
												foreach (Aircraft item4 in enumerable2)
												{
													if (bool_11)
													{
														list_8.Add(item4);
													}
													num++;
													if (bool_11)
													{
														bool bool_21 = true;
														bool bool_22 = false;
														Mission.Flight flight = null;
														GameGeneral.smethod_41(ref scenario_0, ref mission_0, ref item4, ref list_11, ref _FlightSize_1, ref bool_11, bool_21, bool_14, bool_22, ref flight);
													}
													else
													{
														bool bool_23 = true;
														bool bool_24 = false;
														Mission.Flight flight = null;
														GameGeneral.smethod_41(ref scenario_0, ref mission_0, ref item4, ref list_11, ref _FlightSize_1, ref bool_11, bool_23, bool_14, bool_24, ref flight);
													}
													if (int_8 > 0 && num6 >= int_8)
													{
														break;
													}
												}
											}
											finally
											{
												IEnumerator<Aircraft> enumerator6;
												if (enumerator6 != null)
												{
													enumerator6.Dispose();
												}
											}
										}
									}
									IL_D06:
									if (!Information.IsNothing(enumerable3) && Enumerable.Count<Aircraft>(enumerable3) > 0 && (!bool_9 || Enumerable.Count<Aircraft>(enumerable3) >= (int)_FlightSize_2) && !flag3 && _FlightSize_2 <= Mission._FlightSize.SingleAircraft)
									{
										try
										{
											foreach (Aircraft item5 in enumerable3)
											{
												if (bool_11)
												{
													list_9.Add(item5);
												}
												num++;
												if (bool_11)
												{
													bool bool_25 = true;
													bool bool_26 = false;
													Mission.Flight flight = null;
													GameGeneral.smethod_41(ref scenario_0, ref mission_0, ref item5, ref list_11, ref _FlightSize_2, ref bool_11, bool_25, bool_14, bool_26, ref flight);
												}
												else
												{
													bool bool_27 = true;
													bool bool_28 = false;
													Mission.Flight flight = null;
													GameGeneral.smethod_41(ref scenario_0, ref mission_0, ref item5, ref list_11, ref _FlightSize_2, ref bool_11, bool_27, bool_14, bool_28, ref flight);
												}
												if (int_10 > 0 && num7 >= int_10)
												{
													break;
												}
											}
										}
										finally
										{
											IEnumerator<Aircraft> enumerator7;
											if (enumerator7 != null)
											{
												enumerator7.Dispose();
											}
										}
									}
								}
							}
							finally
							{
								List<int>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
						}
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
				}
				if (bool_11 && mission_0._MissionClass_0 == Mission._MissionClass.Strike && ((!Information.IsNothing(int_5) && list_7.Count < int_5) || (!Information.IsNothing(int_7) && list_8.Count < int_7) || (_FlightSize_2 != Mission._FlightSize.None && !Information.IsNothing(int_9) && list_9.Count < int_9)))
				{
					try
					{
						foreach (Group group2 in list_6)
						{
							group2.vmethod_133(false, false, false);
						}
					}
					finally
					{
						List<Group>.Enumerator enumerator8;
						((IDisposable)enumerator8).Dispose();
					}
					if (mission_0.int_0 == 1 || bool_16)
					{
						if (mission_0.enum88_0 == Mission.Enum88.const_0)
						{
							scenario_0.method_59("Mission " + mission_0.Name + " does not fulfill the minimum aircraft requirements. The mission will not launch. When divided by base/ship, aircraft type and loadout, there isn't enough aircraft to create the minimum number of flights. Possible solutions would be to add more strike aircraft and/or escorts, load aircraft with identical loadouts, or use aircraft from the same base/ship. Alternatively, re-configure the mission and reduce the minimum number of required strike aircraft and/or escorts, or reduce the flight size.", mission_0.Name + " cannot launch (not enough AC)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
						else
						{
							scenario_0.method_59(mission_0.Name + " does not fulfill the minimum aircraft requirements. Possible solutions would be to remove the aircraft from the package, change the flight size, or manually create the flight.", mission_0.Name + " cannot launch (not enough AC)", LoggedMessage.MessageType.AirOps, 0, null, side_0, default(Geopoint_Struct));
						}
					}
					if (bool_16)
					{
						if (mission_0.enum88_0 == Mission.Enum88.const_0)
						{
							GameGeneral.smethod_1("Mission " + mission_0.Name + " does not fulfill the minimum aircraft requirements. The mission will not launch. When divided by base/ship, aircraft type and loadout, there isn't enough aircraft to create the minimum number of flights. Possible solutions would be to add more strike aircraft and/or escorts, load aircraft with identical loadouts, or use aircraft from the same base/ship. Alternatively, re-configure the mission and reduce the minimum number of required strike aircraft and/or escorts, or reduce the flight size.");
						}
						else
						{
							GameGeneral.smethod_1(mission_0.Name + " does not fulfill the minimum aircraft requirements. Possible solutions would be to remove the aircraft from the package, change the flight size, or manually create the flight.");
						}
					}
				}
				else if (bool_11)
				{
					for (int i = list_6.Count - 1; i >= 0; i += -1)
					{
						Group group3 = list_6[i];
						if (!Information.IsNothing(group3.vmethod_141().Values) && group3.vmethod_141().Values.Count > 0)
						{
							ActiveUnit activeUnit = Enumerable.ElementAtOrDefault<ActiveUnit>(group3.vmethod_141().Values, 0);
							if (activeUnit.vmethod_85().method_49())
							{
								Waypoint waypoint = activeUnit.vmethod_85().method_7().method_15()[0];
								if (!Information.IsNothing(waypoint.nullable_7) && (waypoint.nullable_7.Value - scenario_0.method_31()).TotalSeconds - double_0 - 60.0 >= 0.0)
								{
									try
									{
										foreach (ActiveUnit activeUnit2 in group3.vmethod_141().Values)
										{
											Aircraft item6 = (Aircraft)activeUnit2;
											if (list_7.Contains(item6))
											{
												list_7.Remove(item6);
											}
											else if (list_8.Contains(item6))
											{
												list_8.Remove(item6);
											}
											else if (list_9.Contains(item6))
											{
												list_9.Remove(item6);
											}
										}
									}
									finally
									{
										IEnumerator<ActiveUnit> enumerator9;
										if (enumerator9 != null)
										{
											enumerator9.Dispose();
										}
									}
									list_6.Remove(group3);
									group3.vmethod_133(false, false, false);
								}
							}
						}
					}
					List<Aircraft> list3 = new List<Aircraft>();
					list3.AddRange(list_7);
					list3.AddRange(list_8);
					list3.AddRange(list_9);
					try
					{
						foreach (Aircraft aircraft in list3)
						{
							if (aircraft.method_157().method_49())
							{
								Waypoint waypoint2 = aircraft.method_157().method_7().method_15()[0];
								if (!Information.IsNothing(waypoint2.nullable_7) && (waypoint2.nullable_7.Value - scenario_0.method_31()).TotalSeconds - double_0 - 60.0 >= 0.0)
								{
									if (list_7.Contains(aircraft))
									{
										list_7.Remove(aircraft);
									}
									else if (list_8.Contains(aircraft))
									{
										list_8.Remove(aircraft);
									}
									else if (list_9.Contains(aircraft))
									{
										list_9.Remove(aircraft);
									}
								}
							}
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator10;
						((IDisposable)enumerator10).Dispose();
					}
					if (list_7.Count == 0 && (list_8.Count > 0 || list_9.Count > 0))
					{
						for (int j = list_6.Count - 1; j >= 0; j += -1)
						{
							Group group3 = list_6[j];
							if (!Information.IsNothing(group3.vmethod_141().Values) && group3.vmethod_141().Values.Count > 0)
							{
								try
								{
									foreach (ActiveUnit activeUnit3 in group3.vmethod_141().Values)
									{
										Aircraft item7 = (Aircraft)activeUnit3;
										if (list_8.Contains(item7))
										{
											list_8.Remove(item7);
										}
										else if (list_9.Contains(item7))
										{
											list_9.Remove(item7);
										}
									}
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator11;
									if (enumerator11 != null)
									{
										enumerator11.Dispose();
									}
								}
								list_6.Remove(group3);
								group3.vmethod_133(false, false, false);
							}
						}
						list3.AddRange(list_8);
						list3.AddRange(list_9);
						try
						{
							foreach (Aircraft item8 in list3)
							{
								if (list_8.Contains(item8))
								{
									list_8.Remove(item8);
								}
								else if (list_9.Contains(item8))
								{
									list_9.Remove(item8);
								}
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator12;
							((IDisposable)enumerator12).Dispose();
						}
					}
					if (!bool_12 && list_7.Count > 0)
					{
						bool_12 = true;
					}
					mission_0.method_43(ref scenario_0, list_6, list_7, list_8, list_9);
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0029D404 File Offset: 0x0029B604
		private static void smethod_38(ref Scenario scenario_0, ref Mission mission_0, ref List<ActiveUnit> list_1, ref Group group_0, ref List<Aircraft> list_2, ref Mission._FlightSize _FlightSize_0, ref bool bool_7, bool bool_8, bool bool_9, bool bool_10, ref Mission.Flight flight_0)
		{
			try
			{
				Aircraft aircraft = (Aircraft)list_1[0];
				Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
				Mission.Flight flight = null;
				Mission.Flight flight2 = new Mission.Flight(ref scenario_0, ref mission_0, ref flight, Class163.smethod_6(ref mission_0), aircraft_AirOps.method_30().string_0, aircraft_AirOps.method_30().Name, aircraft.method_167().DBID, null, aircraft, _FlightSize_0, bool_8);
				mission_0.method_60(ref flight2);
				int num = 2;
				if (bool_7)
				{
					try
					{
						foreach (ActiveUnit activeUnit in group_0.vmethod_141().Values)
						{
							if (activeUnit.method_122())
							{
								activeUnit.method_123(flight2, 1);
								group_0.Name = "Flight " + flight2.string_4;
							}
							else
							{
								activeUnit.method_123(flight2, num);
								num++;
							}
						}
						goto IL_194;
					}
					finally
					{
						IEnumerator<ActiveUnit> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				try
				{
					foreach (ActiveUnit activeUnit2 in list_1)
					{
						if (list_2.Contains((Aircraft)activeUnit2))
						{
							if (Information.IsNothing(mission_0.list_2))
							{
								continue;
							}
							try
							{
								foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in mission_0.list_2)
								{
									if (!Information.IsNothing(emptyAircraftSlot.method_1(scenario_0, null)) && emptyAircraftSlot.method_1(scenario_0, null) == activeUnit2)
									{
										emptyAircraftSlot.method_7(scenario_0, flight2, num);
										num++;
										break;
									}
								}
								continue;
							}
							finally
							{
								List<Mission.EmptyAircraftSlot>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
						activeUnit2.method_123(flight2, num);
						num++;
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				IL_194:
				if (bool_10)
				{
					flight_0 = flight2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0029D64C File Offset: 0x0029B84C
		private static void smethod_39(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref List<ActiveUnit> list_1, ref Group group_0, ref List<Aircraft> list_2, ref bool bool_7, ref Mission._FlightSize _FlightSize_0, ref Doctrine.Enum56? nullable_0, ref string string_14, ref float float_1, ref float float_2, ref bool bool_8, bool bool_9, bool bool_10, bool bool_11, ref Mission.Flight flight_0)
		{
			try
			{
				Aircraft aircraft = (Aircraft)list_1[0];
				try
				{
					foreach (Mission.Flight flight in mission_0.list_0)
					{
						if (aircraft.method_166() == flight.int_3 && Operators.CompareString(aircraft.method_164().method_30().string_0, flight.string_5, false) == 0)
						{
							if (Enumerable.Count<Waypoint>(flight.method_18()) == 0 && !flight.bool_13)
							{
								Mission.Flight flight2 = new Mission.Flight();
								Mission.Flight flight3 = flight2;
								bool bool_12 = false;
								int i = 0;
								int j = 0;
								flight3.method_31(ref scenario_0, ref flight, ref flight2, bool_12, ref mission_0, ref i, ref j, false, false);
								flight.bool_13 = true;
								flight2.method_30(ref scenario_0, ref flight);
								if (!Information.IsNothing(flight.list_1) && flight.list_1.Count > 0)
								{
									ActiveUnit activeUnit = scenario_0.vmethod_0()[flight2.string_5];
									try
									{
										foreach (string messageText in flight.list_1)
										{
											scenario_0.method_59(messageText, flight.Name + " notification", LoggedMessage.MessageType.AirOps, 0, "", side_0, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
										}
									}
									finally
									{
										List<string>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
								int num = 2;
								try
								{
									foreach (ActiveUnit activeUnit2 in list_1)
									{
										if (bool_8)
										{
											if (Information.IsNothing(group_0))
											{
												continue;
											}
											try
											{
												foreach (ActiveUnit activeUnit3 in group_0.vmethod_141().Values)
												{
													if (activeUnit3.method_122())
													{
														activeUnit3.method_123(flight2, 1);
														group_0.Name = "Flight " + flight2.string_4;
													}
													else
													{
														activeUnit3.method_123(flight2, num);
														num++;
													}
												}
												continue;
											}
											finally
											{
												IEnumerator<ActiveUnit> enumerator4;
												if (enumerator4 != null)
												{
													enumerator4.Dispose();
												}
											}
										}
										if (list_2.Contains((Aircraft)activeUnit2))
										{
											if (Information.IsNothing(mission_0.list_2))
											{
												continue;
											}
											try
											{
												foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in mission_0.list_2)
												{
													if (!Information.IsNothing(emptyAircraftSlot.method_1(scenario_0, null)) && emptyAircraftSlot.method_1(scenario_0, null) == activeUnit2)
													{
														emptyAircraftSlot.method_7(scenario_0, flight2, num);
														num++;
														break;
													}
												}
												continue;
											}
											finally
											{
												List<Mission.EmptyAircraftSlot>.Enumerator enumerator5;
												((IDisposable)enumerator5).Dispose();
											}
										}
										activeUnit2.method_123(flight2, num);
										num++;
									}
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
								if (bool_11)
								{
									flight_0 = flight2;
								}
							}
							else if (Enumerable.Count<Waypoint>(flight.method_18()) > 0)
							{
								Mission.Flight flight4 = new Mission.Flight();
								Mission.Flight flight5 = flight4;
								bool bool_13 = false;
								int j = 0;
								int i = 0;
								flight5.method_31(ref scenario_0, ref flight, ref flight4, bool_13, ref mission_0, ref j, ref i, false, false);
								flight4.method_30(ref scenario_0, ref flight);
								if (!Information.IsNothing(flight.list_1) && flight.list_1.Count > 0)
								{
									ActiveUnit activeUnit4 = scenario_0.vmethod_0()[flight4.string_5];
									try
									{
										foreach (string messageText2 in flight.list_1)
										{
											scenario_0.method_59(messageText2, flight.Name + " notification", LoggedMessage.MessageType.AirOps, 0, "", side_0, new Geopoint_Struct(activeUnit4.vmethod_28(null), activeUnit4.vmethod_30(null)));
										}
									}
									finally
									{
										List<string>.Enumerator enumerator6;
										((IDisposable)enumerator6).Dispose();
									}
								}
								Strike strike;
								if (mission_0._MissionClass_0 == Mission._MissionClass.Strike)
								{
									strike = (Strike)mission_0;
									if (strike.enum94_0 == Mission.Enum94.const_15)
									{
										bool_7 = !bool_7;
									}
								}
								if (mission_0._MissionClass_0 == Mission._MissionClass.Strike && (Information.IsNothing(strike) || (strike.enum94_0 == Mission.Enum94.const_15 && !bool_7 && !Information.IsNothing(flight4.method_20()) && Enumerable.Count<Waypoint>(flight4.method_20()) != 0)))
								{
									if (Enumerable.Count<Waypoint>(flight4.method_20()) > 0 && Enumerable.Count<Waypoint>(flight4.method_15()) == 0)
									{
										Waypoint[] array2;
										foreach (Waypoint waypoint in flight4.method_20())
										{
											Mission.Flight flight6 = flight4;
											array2 = flight6.method_15();
											bool bool_14 = true;
											bool bool_15 = true;
											Doctrine doctrine = null;
											Class429.smethod_36(ref array2, Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_14, bool_15, ref doctrine));
											flight6.method_16(array2);
										}
										Mission.Flight flight7 = flight4;
										array2 = flight7.method_20();
										Class429.smethod_38(ref array2);
										flight7.method_21(array2);
										Mission.Flight flight8 = flight4;
										array2 = flight8.method_24();
										Class429.smethod_38(ref array2);
										flight8.method_25(array2);
										if (!Information.IsNothing(flight4.method_18()) || Enumerable.Count<Waypoint>(flight4.method_18()) > 0)
										{
											Mission.Flight flight9 = flight4;
											array2 = flight9.method_18();
											Class429.smethod_38(ref array2);
											flight9.method_19(array2);
											Mission.Flight flight10 = flight4;
											array2 = flight10.method_22();
											Class429.smethod_38(ref array2);
											flight10.method_23(array2);
										}
									}
								}
								else if (Enumerable.Count<Waypoint>(flight4.method_18()) > 0 && Enumerable.Count<Waypoint>(flight4.method_15()) == 0)
								{
									Waypoint[] array;
									foreach (Waypoint waypoint2 in flight4.method_18())
									{
										Mission.Flight flight11 = flight4;
										array = flight11.method_15();
										bool bool_16 = true;
										bool bool_17 = true;
										Doctrine doctrine = null;
										Class429.smethod_36(ref array, Waypoint.smethod_14(ref scenario_0, ref waypoint2, bool_16, bool_17, ref doctrine));
										flight11.method_16(array);
									}
									Mission.Flight flight12 = flight4;
									array = flight12.method_18();
									Class429.smethod_38(ref array);
									flight12.method_19(array);
									Mission.Flight flight13 = flight4;
									array = flight13.method_22();
									Class429.smethod_38(ref array);
									flight13.method_23(array);
									if (!Information.IsNothing(flight4.method_20()) || Enumerable.Count<Waypoint>(flight4.method_20()) > 0)
									{
										Mission.Flight flight14 = flight4;
										array = flight14.method_20();
										Class429.smethod_38(ref array);
										flight14.method_21(array);
										Mission.Flight flight15 = flight4;
										array = flight15.method_24();
										Class429.smethod_38(ref array);
										flight15.method_25(array);
									}
								}
								int num2 = 2;
								if (bool_8)
								{
									try
									{
										foreach (ActiveUnit activeUnit5 in group_0.vmethod_141().Values)
										{
											if (activeUnit5.method_122())
											{
												activeUnit5.method_123(flight4, 1);
												group_0.Name = "Flight " + flight4.string_4;
											}
											else
											{
												activeUnit5.method_123(flight4, num2);
												num2++;
											}
										}
										goto IL_747;
									}
									finally
									{
										IEnumerator<ActiveUnit> enumerator7;
										if (enumerator7 != null)
										{
											enumerator7.Dispose();
										}
									}
								}
								try
								{
									foreach (ActiveUnit activeUnit6 in list_1)
									{
										if (list_2.Contains((Aircraft)activeUnit6))
										{
											if (Information.IsNothing(mission_0.list_2))
											{
												continue;
											}
											try
											{
												foreach (Mission.EmptyAircraftSlot emptyAircraftSlot2 in mission_0.list_2)
												{
													if (!Information.IsNothing(emptyAircraftSlot2.method_1(scenario_0, null)) && emptyAircraftSlot2.method_1(scenario_0, null) == activeUnit6)
													{
														emptyAircraftSlot2.method_7(scenario_0, flight4, num2);
														num2++;
														break;
													}
												}
												continue;
											}
											finally
											{
												List<Mission.EmptyAircraftSlot>.Enumerator enumerator9;
												((IDisposable)enumerator9).Dispose();
											}
										}
										activeUnit6.method_123(flight4, num2);
										num2++;
									}
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator8;
									((IDisposable)enumerator8).Dispose();
								}
								IL_747:
								if (bool_11)
								{
									flight_0 = flight4;
								}
							}
							else
							{
								Aircraft_AirOps aircraft_AirOps = aircraft.method_164();
								Mission.Flight flight16 = null;
								Mission.Flight flight17 = new Mission.Flight(ref scenario_0, ref mission_0, ref flight16, Class163.smethod_6(ref mission_0), aircraft_AirOps.method_30().string_0, aircraft_AirOps.method_30().Name, aircraft.method_167().DBID, flight.contact_0, aircraft, _FlightSize_0, bool_9);
								if (mission_0._MissionClass_0 == Mission._MissionClass.Strike)
								{
									Strike strike2 = (Strike)mission_0;
									ActiveUnit_AI activeUnit_AI = aircraft.method_158();
									Mission.Flight flight18 = flight;
									int int_ = strike2.int_10;
									int int_2 = strike2.int_11;
									Doctrine.Enum56? nullable_ = nullable_0;
									bool bool_18 = mission_0.bool_17;
									Mission.Enum92 enum92_ = strike2.enum92_0;
									bool bool_19 = false;
									bool bool_20 = false;
									bool bool_21 = false;
									bool bool_22 = strike2.bool_22;
									float num3 = 0f;
									activeUnit_AI.method_30(ref scenario_0, ref side_0, ref mission_0, ref flight17, ref flight18.contact_0, int_, int_2, nullable_, bool_18, enum92_, bool_19, bool_20, bool_21, bool_22, ref num3, ref string_14, false, ref bool_7, bool_7, ref float_1, ref float_2, true, null, bool_10, null, null, false, false);
								}
								else
								{
									Mission.Flight flight19 = flight17;
									bool bool_23 = false;
									int num4 = 0;
									int k = 0;
									flight19.method_31(ref scenario_0, ref flight, ref flight17, bool_23, ref mission_0, ref num4, ref k, false, false);
									flight.bool_13 = true;
									flight17.method_30(ref scenario_0, ref flight);
									if (!Information.IsNothing(flight.list_1) && flight.list_1.Count > 0)
									{
										ActiveUnit activeUnit7 = scenario_0.vmethod_0()[flight17.string_5];
										try
										{
											foreach (string messageText3 in flight.list_1)
											{
												scenario_0.method_59(messageText3, flight.Name + " notification", LoggedMessage.MessageType.AirOps, 0, "", side_0, new Geopoint_Struct(activeUnit7.vmethod_28(null), activeUnit7.vmethod_30(null)));
											}
										}
										finally
										{
											List<string>.Enumerator enumerator10;
											((IDisposable)enumerator10).Dispose();
										}
									}
									int num5 = 1;
									try
									{
										foreach (ActiveUnit activeUnit8 in list_1)
										{
											if (bool_8)
											{
												if (Information.IsNothing(group_0))
												{
													continue;
												}
												try
												{
													foreach (ActiveUnit activeUnit9 in group_0.vmethod_141().Values)
													{
														if (activeUnit9.method_122())
														{
															activeUnit9.method_123(flight17, 1);
															group_0.Name = "Flight " + flight17.string_4;
														}
														else
														{
															activeUnit9.method_123(flight17, num5);
															num5++;
														}
													}
													continue;
												}
												finally
												{
													IEnumerator<ActiveUnit> enumerator12;
													if (enumerator12 != null)
													{
														enumerator12.Dispose();
													}
												}
											}
											if (list_2.Contains((Aircraft)activeUnit8))
											{
												if (Information.IsNothing(mission_0.list_2))
												{
													continue;
												}
												try
												{
													foreach (Mission.EmptyAircraftSlot emptyAircraftSlot3 in mission_0.list_2)
													{
														if (!Information.IsNothing(emptyAircraftSlot3.method_1(scenario_0, null)) && emptyAircraftSlot3.method_1(scenario_0, null) == activeUnit8)
														{
															emptyAircraftSlot3.method_7(scenario_0, flight17, num5);
															num5++;
															break;
														}
													}
													continue;
												}
												finally
												{
													List<Mission.EmptyAircraftSlot>.Enumerator enumerator13;
													((IDisposable)enumerator13).Dispose();
												}
											}
											activeUnit8.method_123(flight17, num5);
											num5++;
										}
									}
									finally
									{
										List<ActiveUnit>.Enumerator enumerator11;
										((IDisposable)enumerator11).Dispose();
									}
								}
								if (Enumerable.Count<Waypoint>(flight17.method_15()) == 0)
								{
									foreach (Waypoint waypoint3 in flight.method_15())
									{
										Mission.Flight flight20 = flight17;
										Waypoint[] waypoint_ = flight20.method_15();
										bool bool_24 = true;
										bool bool_25 = true;
										Doctrine doctrine = null;
										Class429.smethod_36(ref waypoint_, Waypoint.smethod_14(ref scenario_0, ref waypoint3, bool_24, bool_25, ref doctrine));
										flight20.method_16(waypoint_);
									}
								}
								mission_0.method_60(ref flight17);
								int num6 = 2;
								if (bool_8)
								{
									try
									{
										foreach (ActiveUnit activeUnit10 in group_0.vmethod_141().Values)
										{
											if (activeUnit10.method_122())
											{
												activeUnit10.method_123(flight17, 1);
												group_0.Name = "Flight " + flight17.string_4;
											}
											else
											{
												activeUnit10.method_123(flight17, num6);
												num6++;
											}
										}
										goto IL_C13;
									}
									finally
									{
										IEnumerator<ActiveUnit> enumerator14;
										if (enumerator14 != null)
										{
											enumerator14.Dispose();
										}
									}
								}
								try
								{
									foreach (ActiveUnit activeUnit11 in list_1)
									{
										if (list_2.Contains((Aircraft)activeUnit11))
										{
											if (Information.IsNothing(mission_0.list_2))
											{
												continue;
											}
											try
											{
												foreach (Mission.EmptyAircraftSlot emptyAircraftSlot4 in mission_0.list_2)
												{
													if (!Information.IsNothing(emptyAircraftSlot4.method_1(scenario_0, null)) && emptyAircraftSlot4.method_1(scenario_0, null) == activeUnit11)
													{
														emptyAircraftSlot4.method_7(scenario_0, flight17, num6);
														num6++;
														break;
													}
												}
												continue;
											}
											finally
											{
												List<Mission.EmptyAircraftSlot>.Enumerator enumerator16;
												((IDisposable)enumerator16).Dispose();
											}
										}
										activeUnit11.method_123(flight17, num6);
										num6++;
									}
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator15;
									((IDisposable)enumerator15).Dispose();
								}
								IL_C13:
								if (bool_11)
								{
									flight_0 = flight17;
								}
							}
							break;
						}
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0029E45C File Offset: 0x0029C65C
		private static void smethod_40(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref Aircraft aircraft_0, ref List<Aircraft> list_1, ref bool bool_7, ref Mission._FlightSize _FlightSize_0, ref Doctrine.Enum56? nullable_0, ref string string_14, ref float float_1, ref float float_2, ref bool bool_8, bool bool_9, bool bool_10, bool bool_11, ref Mission.Flight flight_0)
		{
			try
			{
				try
				{
					foreach (Mission.Flight flight in mission_0.list_0)
					{
						if (aircraft_0.method_166() == flight.int_3 && Operators.CompareString(aircraft_0.method_164().method_30().string_0, flight.string_5, false) == 0)
						{
							if (Enumerable.Count<Waypoint>(flight.method_18()) == 0 && !flight.bool_13)
							{
								Mission.Flight flight2 = new Mission.Flight();
								Mission.Flight flight3 = flight2;
								bool bool_12 = false;
								int i = 0;
								int num = 0;
								flight3.method_31(ref scenario_0, ref flight, ref flight2, bool_12, ref mission_0, ref i, ref num, false, false);
								flight2.method_30(ref scenario_0, ref flight);
								if (!Information.IsNothing(flight.list_1) && flight.list_1.Count > 0)
								{
									ActiveUnit activeUnit = scenario_0.vmethod_0()[flight2.string_5];
									try
									{
										foreach (string messageText in flight.list_1)
										{
											scenario_0.method_59(messageText, flight2.Name + " notification", LoggedMessage.MessageType.AirOps, 0, "", side_0, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
										}
									}
									finally
									{
										List<string>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
								if (bool_8)
								{
									aircraft_0.method_123(flight2, 0);
								}
								else
								{
									if (list_1.Contains(aircraft_0))
									{
										if (Information.IsNothing(mission_0.list_2))
										{
											goto IL_1DA;
										}
										try
										{
											foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in mission_0.list_2)
											{
												if (!Information.IsNothing(emptyAircraftSlot.method_1(scenario_0, null)) && emptyAircraftSlot.method_1(scenario_0, null) == aircraft_0)
												{
													emptyAircraftSlot.method_7(scenario_0, flight2, 0);
													IL_1C1:
													goto IL_1DA;
												}
											}
											goto IL_1C1;
										}
										finally
										{
											List<Mission.EmptyAircraftSlot>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
									aircraft_0.method_123(flight2, 0);
								}
								IL_1DA:
								flight.bool_13 = true;
								if (bool_11)
								{
									flight_0 = flight2;
								}
							}
							else if (Enumerable.Count<Waypoint>(flight.method_18()) > 0)
							{
								Mission.Flight flight4 = new Mission.Flight();
								Mission.Flight flight5 = flight4;
								bool bool_13 = false;
								int num = 0;
								int i = 0;
								flight5.method_31(ref scenario_0, ref flight, ref flight4, bool_13, ref mission_0, ref num, ref i, false, false);
								flight4.method_30(ref scenario_0, ref flight);
								if (!Information.IsNothing(flight.list_1) && flight.list_1.Count > 0)
								{
									ActiveUnit activeUnit2 = scenario_0.vmethod_0()[flight4.string_5];
									try
									{
										foreach (string messageText2 in flight.list_1)
										{
											scenario_0.method_59(messageText2, flight.Name + " notification", LoggedMessage.MessageType.AirOps, 0, "", side_0, new Geopoint_Struct(activeUnit2.vmethod_28(null), activeUnit2.vmethod_30(null)));
										}
									}
									finally
									{
										List<string>.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
								}
								if (Enumerable.Count<Waypoint>(flight4.method_18()) > 0 && Enumerable.Count<Waypoint>(flight4.method_15()) == 0)
								{
									Waypoint[] array2;
									foreach (Waypoint waypoint in flight4.method_18())
									{
										Mission.Flight flight6 = flight4;
										array2 = flight6.method_15();
										bool bool_14 = true;
										bool bool_15 = true;
										Doctrine doctrine = null;
										Class429.smethod_36(ref array2, Waypoint.smethod_14(ref scenario_0, ref waypoint, bool_14, bool_15, ref doctrine));
										flight6.method_16(array2);
									}
									Mission.Flight flight7 = flight4;
									array2 = flight7.method_18();
									Class429.smethod_38(ref array2);
									flight7.method_19(array2);
									Mission.Flight flight8 = flight4;
									array2 = flight8.method_22();
									Class429.smethod_38(ref array2);
									flight8.method_23(array2);
									if (!Information.IsNothing(flight4.method_20()) || Enumerable.Count<Waypoint>(flight4.method_20()) > 0)
									{
										Mission.Flight flight9 = flight4;
										array2 = flight9.method_20();
										Class429.smethod_38(ref array2);
										flight9.method_21(array2);
										Mission.Flight flight10 = flight4;
										array2 = flight10.method_24();
										Class429.smethod_38(ref array2);
										flight10.method_25(array2);
									}
								}
								if (bool_8)
								{
									aircraft_0.method_123(flight4, 0);
								}
								else
								{
									if (list_1.Contains(aircraft_0))
									{
										if (Information.IsNothing(mission_0.list_2))
										{
											goto IL_45A;
										}
										try
										{
											foreach (Mission.EmptyAircraftSlot emptyAircraftSlot2 in mission_0.list_2)
											{
												if (!Information.IsNothing(emptyAircraftSlot2.method_1(scenario_0, null)) && emptyAircraftSlot2.method_1(scenario_0, null) == aircraft_0)
												{
													emptyAircraftSlot2.method_7(scenario_0, flight4, 0);
													IL_440:
													goto IL_45A;
												}
											}
											goto IL_440;
										}
										finally
										{
											List<Mission.EmptyAircraftSlot>.Enumerator enumerator5;
											((IDisposable)enumerator5).Dispose();
										}
									}
									aircraft_0.method_123(flight4, 0);
								}
								IL_45A:
								if (bool_11)
								{
									flight_0 = flight4;
								}
							}
							else
							{
								Aircraft_AirOps aircraft_AirOps = aircraft_0.method_164();
								Mission.Flight flight11 = null;
								Mission.Flight flight12 = new Mission.Flight(ref scenario_0, ref mission_0, ref flight11, Class163.smethod_6(ref mission_0), aircraft_AirOps.method_30().string_0, aircraft_AirOps.method_30().Name, aircraft_0.method_167().DBID, flight.contact_0, aircraft_0, _FlightSize_0, bool_9);
								if (mission_0._MissionClass_0 == Mission._MissionClass.Strike)
								{
									Strike strike = (Strike)mission_0;
									ActiveUnit_AI activeUnit_AI = aircraft_0.method_158();
									Mission.Flight flight13 = flight;
									int int_ = strike.int_10;
									int int_2 = strike.int_11;
									Doctrine.Enum56? nullable_ = nullable_0;
									bool bool_16 = mission_0.bool_17;
									Mission.Enum92 enum92_ = strike.enum92_0;
									bool bool_17 = false;
									bool bool_18 = false;
									bool bool_19 = false;
									bool bool_20 = strike.bool_22;
									float num2 = 0f;
									activeUnit_AI.method_30(ref scenario_0, ref side_0, ref mission_0, ref flight12, ref flight13.contact_0, int_, int_2, nullable_, bool_16, enum92_, bool_17, bool_18, bool_19, bool_20, ref num2, ref string_14, false, ref bool_7, bool_7, ref float_1, ref float_2, true, null, bool_10, null, null, false, false);
								}
								else
								{
									Mission.Flight flight14 = flight12;
									bool bool_21 = false;
									int num = 0;
									int j = 0;
									flight14.method_31(ref scenario_0, ref flight, ref flight12, bool_21, ref mission_0, ref num, ref j, false, false);
									flight12.method_30(ref scenario_0, ref flight);
									if (!Information.IsNothing(flight.list_1) && flight.list_1.Count > 0)
									{
										ActiveUnit activeUnit3 = scenario_0.vmethod_0()[flight12.string_5];
										try
										{
											foreach (string messageText3 in flight.list_1)
											{
												scenario_0.method_59(messageText3, flight.Name + " notification", LoggedMessage.MessageType.AirOps, 0, "", side_0, new Geopoint_Struct(activeUnit3.vmethod_28(null), activeUnit3.vmethod_30(null)));
											}
										}
										finally
										{
											List<string>.Enumerator enumerator6;
											((IDisposable)enumerator6).Dispose();
										}
									}
								}
								if (Enumerable.Count<Waypoint>(flight12.method_15()) == 0)
								{
									foreach (Waypoint waypoint2 in flight.method_15())
									{
										Mission.Flight flight15 = flight12;
										Waypoint[] waypoint_ = flight15.method_15();
										bool bool_22 = true;
										bool bool_23 = true;
										Doctrine doctrine = null;
										Class429.smethod_36(ref waypoint_, Waypoint.smethod_14(ref scenario_0, ref waypoint2, bool_22, bool_23, ref doctrine));
										flight15.method_16(waypoint_);
									}
								}
								mission_0.method_60(ref flight12);
								if (bool_8)
								{
									aircraft_0.method_123(flight12, 0);
								}
								else
								{
									if (list_1.Contains(aircraft_0))
									{
										if (Information.IsNothing(mission_0.list_2))
										{
											goto IL_715;
										}
										try
										{
											foreach (Mission.EmptyAircraftSlot emptyAircraftSlot3 in mission_0.list_2)
											{
												if (!Information.IsNothing(emptyAircraftSlot3.method_1(scenario_0, null)) && emptyAircraftSlot3.method_1(scenario_0, null) == aircraft_0)
												{
													emptyAircraftSlot3.method_7(scenario_0, flight12, 0);
													IL_6FB:
													goto IL_715;
												}
											}
											goto IL_6FB;
										}
										finally
										{
											List<Mission.EmptyAircraftSlot>.Enumerator enumerator7;
											((IDisposable)enumerator7).Dispose();
										}
									}
									aircraft_0.method_123(flight12, 0);
								}
								IL_715:
								if (bool_11)
								{
									flight_0 = flight12;
								}
							}
							break;
						}
					}
				}
				finally
				{
					List<Mission.Flight>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0029EC98 File Offset: 0x0029CE98
		private static void smethod_41(ref Scenario scenario_0, ref Mission mission_0, ref Aircraft aircraft_0, ref List<Aircraft> list_1, ref Mission._FlightSize _FlightSize_0, ref bool bool_7, bool bool_8, bool bool_9, bool bool_10, ref Mission.Flight flight_0)
		{
			try
			{
				Aircraft_AirOps aircraft_AirOps = aircraft_0.method_164();
				Mission.Flight flight = null;
				Mission.Flight flight2 = new Mission.Flight(ref scenario_0, ref mission_0, ref flight, Class163.smethod_6(ref mission_0), aircraft_AirOps.method_30().string_0, aircraft_AirOps.method_30().Name, aircraft_0.method_167().DBID, null, aircraft_0, _FlightSize_0, bool_8);
				mission_0.method_60(ref flight2);
				if (bool_7)
				{
					aircraft_0.method_123(flight2, 0);
				}
				else
				{
					if (list_1.Contains(aircraft_0))
					{
						if (Information.IsNothing(mission_0.list_2))
						{
							goto IL_E1;
						}
						try
						{
							foreach (Mission.EmptyAircraftSlot emptyAircraftSlot in mission_0.list_2)
							{
								if (!Information.IsNothing(emptyAircraftSlot.method_1(scenario_0, null)) && emptyAircraftSlot.method_1(scenario_0, null) == aircraft_0)
								{
									emptyAircraftSlot.method_7(scenario_0, flight2, 0);
									IL_C8:
									goto IL_E1;
								}
							}
							goto IL_C8;
						}
						finally
						{
							List<Mission.EmptyAircraftSlot>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					aircraft_0.method_123(flight2, 0);
				}
				IL_E1:
				if (bool_10)
				{
					flight_0 = flight2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0029EDE4 File Offset: 0x0029CFE4
		private static bool smethod_42(ref Scenario scenario_0, ref Side side_0, Mission mission_0, bool bool_7, ref List<ActiveUnit> list_1, ref List<ActiveUnit> list_2, ref List<ActiveUnit> list_3, ref List<ActiveUnit> list_4, ref Mission._GroupSize _GroupSize_0, ref Mission._GroupSize _GroupSize_1, ref bool bool_8, ref bool bool_9, ref List<ActiveUnit> list_5, ref List<ActiveUnit> list_6, ref List<int> list_7)
		{
			GameGeneral.Class544 @class = new GameGeneral.Class544(@class);
			@class.mission_0 = mission_0;
			bool result;
			try
			{
				GameGeneral.Class543 class2 = new GameGeneral.Class543(class2);
				class2.class544_0 = @class;
				switch (class2.class544_0.mission_0._MissionClass_0)
				{
				case Mission._MissionClass.Strike:
				{
					Strike strike = (Strike)class2.class544_0.mission_0;
					strike = (Strike)class2.class544_0.mission_0;
					bool flag = strike.hashSet_0.Count > 0;
					_GroupSize_0 = strike._GroupSize_0;
					_GroupSize_1 = strike._GroupSize_1;
					bool_8 = strike.bool_13;
					bool_9 = strike.bool_29;
					switch (strike.strikeType_0)
					{
					case Strike.StrikeType.Air_Intercept:
						try
						{
							foreach (ActiveUnit activeUnit_ in list_6)
							{
								class2.activeUnit_0 = activeUnit_;
								if (class2.activeUnit_0.vmethod_86().method_82())
								{
									if (class2.activeUnit_0.vmethod_86().bool_2)
									{
										list_2.Add(class2.activeUnit_0);
									}
									else
									{
										double num = (double)class2.activeUnit_0.vmethod_87().vmethod_26();
										Weapon weapon = class2.activeUnit_0.vmethod_89().method_54();
										if (!Information.IsNothing(weapon))
										{
											num += (double)weapon.float_29;
										}
										Doctrine.Enum59? @enum = class2.activeUnit_0.doctrine_0.method_162(scenario_0, false, false, false);
										try
										{
											foreach (Contact contact in side_0.method_44())
											{
												ActiveUnit_AI activeUnit_AI = class2.activeUnit_0.vmethod_86();
												Contact contact_ = contact;
												Mission mission_ = class2.class544_0.mission_0;
												Doctrine.Enum59? nullable_ = @enum;
												bool bool_10 = false;
												bool bool_11 = false;
												bool bool_12 = true;
												Misc.PostureStance? nullable_2 = null;
												string text = "";
												int num2 = 0;
												if (activeUnit_AI.method_39(contact_, mission_, nullable_, bool_10, bool_11, bool_12, nullable_2, ref text, ref num2) && class2.activeUnit_0.vmethod_86().method_31(ref strike, contact.method_130(class2.activeUnit_0.vmethod_7(false))) && (double)class2.activeUnit_0.method_36(contact) <= num && contact.method_120(scenario_0, side_0, false, null).Count < 2)
												{
													class2.activeUnit_0.vmethod_86().vmethod_4(contact);
													list_1.Add(class2.activeUnit_0);
													break;
												}
											}
										}
										finally
										{
											List<Contact>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
										}
									}
								}
							}
							goto IL_152D;
						}
						finally
						{
							List<ActiveUnit>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						break;
					case Strike.StrikeType.Land_Strike:
						break;
					case Strike.StrikeType.Maritime_Strike:
						goto IL_4BB;
					case Strike.StrikeType.Sub_Strike:
						goto IL_6F4;
					default:
						goto IL_152D;
					}
					try
					{
						foreach (ActiveUnit activeUnit_2 in list_6)
						{
							class2.activeUnit_0 = activeUnit_2;
							GameGeneral.Class545 class3 = new GameGeneral.Class545(class3);
							class3.class543_0 = class2;
							if (class3.class543_0.activeUnit_0.vmethod_86().method_82())
							{
								if (class3.class543_0.activeUnit_0.vmethod_86().bool_2)
								{
									list_2.Add(class3.class543_0.activeUnit_0);
								}
								else
								{
									double num3 = (double)class3.class543_0.activeUnit_0.vmethod_87().vmethod_26();
									Weapon weapon2 = class3.class543_0.activeUnit_0.vmethod_89().method_56(false);
									if (!Information.IsNothing(weapon2))
									{
										num3 += (double)weapon2.float_33;
									}
									class3.nullable_0 = class3.class543_0.activeUnit_0.doctrine_0.method_162(scenario_0, false, false, false);
									if (flag)
									{
										try
										{
											foreach (Contact contact2 in side_0.method_44())
											{
												if (contact2.method_92(strike) && class3.class543_0.activeUnit_0.vmethod_86().method_31(ref strike, contact2.method_130(side_0)) && (double)class3.class543_0.activeUnit_0.method_36(contact2) <= num3)
												{
													list_1.Add(class3.class543_0.activeUnit_0);
													break;
												}
											}
											continue;
										}
										finally
										{
											List<Contact>.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
									}
									List<Contact> list = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(side_0.method_44(), new Func<Contact, bool>(class3.method_0)));
									try
									{
										foreach (Contact contact3 in list)
										{
											if (class3.class543_0.activeUnit_0.vmethod_86().method_31(ref strike, contact3.method_130(side_0)) && (double)class3.class543_0.activeUnit_0.method_36(contact3) <= num3)
											{
												list_1.Add(class3.class543_0.activeUnit_0);
												break;
											}
										}
									}
									finally
									{
										List<Contact>.Enumerator enumerator5;
										((IDisposable)enumerator5).Dispose();
									}
								}
							}
						}
						goto IL_152D;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					IL_4BB:
					try
					{
						foreach (ActiveUnit activeUnit_3 in list_6)
						{
							class2.activeUnit_0 = activeUnit_3;
							GameGeneral.Class546 class4 = new GameGeneral.Class546(class4);
							class4.class543_0 = class2;
							if (class4.class543_0.activeUnit_0.vmethod_86().method_82())
							{
								if (class4.class543_0.activeUnit_0.vmethod_86().bool_2)
								{
									list_2.Add(class4.class543_0.activeUnit_0);
								}
								else
								{
									double num4 = (double)class4.class543_0.activeUnit_0.vmethod_87().vmethod_26();
									Weapon weapon3 = class4.class543_0.activeUnit_0.vmethod_89().method_55(false);
									if (!Information.IsNothing(weapon3))
									{
										num4 += (double)weapon3.float_31;
									}
									class4.nullable_0 = class4.class543_0.activeUnit_0.doctrine_0.method_162(scenario_0, false, false, false);
									if (flag)
									{
										try
										{
											foreach (Contact contact4 in side_0.method_44())
											{
												if (contact4.method_92(strike) && class4.class543_0.activeUnit_0.vmethod_86().method_31(ref strike, contact4.method_130(side_0)) && (double)class4.class543_0.activeUnit_0.method_36(contact4) <= num4)
												{
													list_1.Add(class4.class543_0.activeUnit_0);
													break;
												}
											}
											continue;
										}
										finally
										{
											List<Contact>.Enumerator enumerator7;
											((IDisposable)enumerator7).Dispose();
										}
									}
									List<Contact> list2 = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(side_0.method_44(), new Func<Contact, bool>(class4.method_0)));
									try
									{
										foreach (Contact contact5 in list2)
										{
											if (class4.class543_0.activeUnit_0.vmethod_86().method_31(ref strike, contact5.method_130(side_0)) && (double)class4.class543_0.activeUnit_0.method_36(contact5) <= num4)
											{
												list_1.Add(class4.class543_0.activeUnit_0);
												break;
											}
										}
									}
									finally
									{
										List<Contact>.Enumerator enumerator8;
										((IDisposable)enumerator8).Dispose();
									}
								}
							}
						}
						goto IL_152D;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
					IL_6F4:
					try
					{
						foreach (ActiveUnit activeUnit_4 in list_6)
						{
							class2.activeUnit_0 = activeUnit_4;
							GameGeneral.Class547 class5 = new GameGeneral.Class547(class5);
							class5.class543_0 = class2;
							if (class5.class543_0.activeUnit_0.vmethod_86().method_82())
							{
								if (class5.class543_0.activeUnit_0.vmethod_86().bool_2)
								{
									list_2.Add(class5.class543_0.activeUnit_0);
								}
								else
								{
									double num5 = (double)class5.class543_0.activeUnit_0.vmethod_87().vmethod_26();
									Weapon weapon4 = class5.class543_0.activeUnit_0.vmethod_89().method_57();
									if (!Information.IsNothing(weapon4))
									{
										num5 += (double)weapon4.float_35;
									}
									class5.nullable_0 = class5.class543_0.activeUnit_0.doctrine_0.method_162(scenario_0, false, false, false);
									if (flag)
									{
										try
										{
											foreach (Contact contact6 in side_0.method_44())
											{
												if (!contact6.method_72() && (!class5.class543_0.activeUnit_0.bool_6 || !Class442.smethod_1(contact6.vmethod_28(null), contact6.vmethod_30(null))) && contact6.method_92(strike) && class5.class543_0.activeUnit_0.vmethod_86().method_31(ref strike, contact6.method_130(side_0)) && (double)class5.class543_0.activeUnit_0.method_36(contact6) <= num5)
												{
													list_1.Add(class5.class543_0.activeUnit_0);
													break;
												}
											}
											continue;
										}
										finally
										{
											List<Contact>.Enumerator enumerator10;
											((IDisposable)enumerator10).Dispose();
										}
									}
									List<Contact> list3 = Enumerable.ToList<Contact>(Enumerable.Where<Contact>(side_0.method_44(), new Func<Contact, bool>(class5.method_0)));
									try
									{
										foreach (Contact contact7 in list3)
										{
											if (!contact7.method_72() && (!class5.class543_0.activeUnit_0.bool_6 || !Class442.smethod_1(contact7.vmethod_28(null), contact7.vmethod_30(null))) && class5.class543_0.activeUnit_0.vmethod_86().method_31(ref strike, contact7.method_130(side_0)) && (double)class5.class543_0.activeUnit_0.method_36(contact7) <= num5)
											{
												list_1.Add(class5.class543_0.activeUnit_0);
												break;
											}
										}
									}
									finally
									{
										List<Contact>.Enumerator enumerator11;
										((IDisposable)enumerator11).Dispose();
									}
								}
							}
						}
						goto IL_152D;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator9;
						((IDisposable)enumerator9).Dispose();
					}
					break;
				}
				case Mission._MissionClass.Patrol:
					break;
				case Mission._MissionClass.Support:
					goto IL_C1C;
				case Mission._MissionClass.Ferry:
					goto IL_E73;
				case Mission._MissionClass.Mining:
					goto IL_ED6;
				case Mission._MissionClass.MineClearing:
					goto IL_10BA;
				default:
					goto IL_152D;
				}
				Class343 class6 = (Class343)class2.class544_0.mission_0;
				int num6 = ((Class343)class2.class544_0.mission_0).int_7;
				bool bool_13 = ((Class343)class2.class544_0.mission_0).bool_22;
				_GroupSize_0 = class6._GroupSize_0;
				bool_8 = class6.bool_13;
				if (!bool_13 && num6 <= 0)
				{
					try
					{
						foreach (ActiveUnit activeUnit_5 in list_6)
						{
							class2.activeUnit_0 = activeUnit_5;
							if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
							{
								list_1.Add(class2.activeUnit_0);
							}
						}
						goto IL_152D;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator12;
						((IDisposable)enumerator12).Dispose();
					}
				}
				try
				{
					List<int>.Enumerator enumerator13 = list_7.GetEnumerator();
					while (enumerator13.MoveNext())
					{
						GameGeneral.Class551 class7 = new GameGeneral.Class551(class7);
						class7.int_0 = enumerator13.Current;
						List<ActiveUnit> list4 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_5, new Func<ActiveUnit, bool>(class7.method_0)));
						if (bool_13 && num6 > 0)
						{
							num6 = (int)Math.Round(Math.Max(Math.Ceiling((double)list4.Count / 3.0), (double)num6));
						}
						else if (bool_13 && num6 == 0)
						{
							num6 = (int)Math.Ceiling((double)list4.Count / 3.0);
						}
						else if (!bool_13 && num6 > 0)
						{
							num6 = num6;
						}
						List<ActiveUnit> list5 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list4, (GameGeneral._Closure$__.$I106-12 == null) ? (GameGeneral._Closure$__.$I106-12 = new Func<ActiveUnit, bool>(GameGeneral._Closure$__.$I.method_4)) : GameGeneral._Closure$__.$I106-12));
						List<ActiveUnit> list6 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_6, new Func<ActiveUnit, bool>(class7.method_1)));
						if ((!bool_8 || list6.Count >= (int)_GroupSize_0) && list6.Count > 0)
						{
							int num7 = num6 - list5.Count;
							if (num7 > 0)
							{
								int num8 = 0;
								while (num7 > 0 && num8 < list6.Count)
								{
									class2.activeUnit_0 = list6[num8];
									if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
									{
										list_1.Add(class2.activeUnit_0);
										num7--;
									}
									num8++;
								}
							}
						}
					}
					goto IL_152D;
				}
				finally
				{
					List<int>.Enumerator enumerator13;
					((IDisposable)enumerator13).Dispose();
				}
				IL_C1C:
				Class344 class8 = (Class344)class2.class544_0.mission_0;
				bool_13 = ((Class344)class2.class544_0.mission_0).bool_22;
				_GroupSize_0 = class8._GroupSize_0;
				bool_8 = class8.bool_13;
				if (!bool_13 && num6 <= 0)
				{
					try
					{
						foreach (ActiveUnit activeUnit_6 in list_6)
						{
							class2.activeUnit_0 = activeUnit_6;
							if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
							{
								list_1.Add(class2.activeUnit_0);
							}
						}
						goto IL_152D;
					}
					finally
					{
						List<ActiveUnit>.Enumerator enumerator14;
						((IDisposable)enumerator14).Dispose();
					}
				}
				try
				{
					List<int>.Enumerator enumerator15 = list_7.GetEnumerator();
					while (enumerator15.MoveNext())
					{
						GameGeneral.Class552 class9 = new GameGeneral.Class552(class9);
						class9.int_0 = enumerator15.Current;
						num6 = ((Class344)class2.class544_0.mission_0).int_7;
						List<ActiveUnit> list7 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_5, new Func<ActiveUnit, bool>(class9.method_0)));
						if (bool_13 && num6 > 0)
						{
							num6 = (int)Math.Round(Math.Max(Math.Ceiling((double)list7.Count / 3.0), (double)num6));
						}
						else if (bool_13 && num6 == 0)
						{
							num6 = (int)Math.Ceiling((double)list7.Count / 3.0);
						}
						else if (!bool_13 && num6 > 0)
						{
							num6 = num6;
						}
						List<ActiveUnit> list8 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list7, (GameGeneral._Closure$__.$I106-15 == null) ? (GameGeneral._Closure$__.$I106-15 = new Func<ActiveUnit, bool>(GameGeneral._Closure$__.$I.method_5)) : GameGeneral._Closure$__.$I106-15));
						List<ActiveUnit> list9 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_6, new Func<ActiveUnit, bool>(class9.method_1)));
						if ((!bool_8 || list9.Count >= (int)_GroupSize_0) && list9.Count > 0)
						{
							int num9 = num6 - list8.Count;
							if (num9 > 0)
							{
								int num10 = 0;
								while (num9 > 0 && num10 < list9.Count)
								{
									class2.activeUnit_0 = list9[num10];
									if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
									{
										list_1.Add(class2.activeUnit_0);
										num9--;
									}
									num10++;
								}
							}
						}
					}
					goto IL_152D;
				}
				finally
				{
					List<int>.Enumerator enumerator15;
					((IDisposable)enumerator15).Dispose();
				}
				IL_E73:
				try
				{
					foreach (ActiveUnit activeUnit_7 in list_6)
					{
						class2.activeUnit_0 = activeUnit_7;
						if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
						{
							list_1.Add(class2.activeUnit_0);
						}
					}
					goto IL_152D;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator16;
					((IDisposable)enumerator16).Dispose();
				}
				IL_ED6:
				Class340 class10 = (Class340)class2.class544_0.mission_0;
				bool_13 = ((Class340)class2.class544_0.mission_0).bool_22;
				_GroupSize_0 = class10._GroupSize_0;
				bool_8 = class10.bool_13;
				if (bool_13)
				{
					try
					{
						List<int>.Enumerator enumerator17 = list_7.GetEnumerator();
						while (enumerator17.MoveNext())
						{
							GameGeneral.Class548 class11 = new GameGeneral.Class548(class11);
							class11.int_0 = enumerator17.Current;
							List<ActiveUnit> list10 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_5, new Func<ActiveUnit, bool>(class11.method_0)));
							List<ActiveUnit> list11 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_6, new Func<ActiveUnit, bool>(class11.method_1)));
							if ((!bool_8 || list11.Count >= (int)_GroupSize_0) && list11.Count > 0)
							{
								num6 = (int)Math.Ceiling((double)list10.Count / 3.0);
								List<ActiveUnit> list12 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list10, (GameGeneral._Closure$__.$I106-5 == null) ? (GameGeneral._Closure$__.$I106-5 = new Func<ActiveUnit, bool>(GameGeneral._Closure$__.$I.method_1)) : GameGeneral._Closure$__.$I106-5));
								int num11 = num6 - list12.Count;
								if (num11 > 0)
								{
									int num12 = 0;
									while (num11 > 0 && num12 < list11.Count)
									{
										class2.activeUnit_0 = list11[num12];
										if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
										{
											list_1.Add(class2.activeUnit_0);
											num11--;
										}
										num12++;
									}
								}
							}
						}
						goto IL_152D;
					}
					finally
					{
						List<int>.Enumerator enumerator17;
						((IDisposable)enumerator17).Dispose();
					}
				}
				try
				{
					foreach (ActiveUnit activeUnit in list_6)
					{
						if (activeUnit.vmethod_86().method_82())
						{
							list_1.Add(activeUnit);
						}
					}
					goto IL_152D;
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator18;
					((IDisposable)enumerator18).Dispose();
				}
				IL_10BA:
				Class341 class12 = (Class341)class2.class544_0.mission_0;
				bool_13 = ((Class341)class2.class544_0.mission_0).bool_22;
				_GroupSize_0 = class12._GroupSize_0;
				bool_8 = class12.bool_13;
				if (bool_13)
				{
					try
					{
						List<int>.Enumerator enumerator19 = list_7.GetEnumerator();
						while (enumerator19.MoveNext())
						{
							GameGeneral.Class549 class13 = new GameGeneral.Class549(class13);
							class13.int_0 = enumerator19.Current;
							List<ActiveUnit> list13 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_5, new Func<ActiveUnit, bool>(class13.method_0)));
							List<ActiveUnit> list14 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_6, new Func<ActiveUnit, bool>(class13.method_1)));
							if ((!bool_8 || list14.Count >= (int)_GroupSize_0) && list14.Count > 0)
							{
								num6 = (int)Math.Ceiling((double)list13.Count / 3.0);
								List<ActiveUnit> list15 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list13, (GameGeneral._Closure$__.$I106-8 == null) ? (GameGeneral._Closure$__.$I106-8 = new Func<ActiveUnit, bool>(GameGeneral._Closure$__.$I.method_2)) : GameGeneral._Closure$__.$I106-8));
								int num13 = num6 - list15.Count;
								if (num13 > 0)
								{
									int num14 = 0;
									while (num13 > 0 && num14 < list14.Count)
									{
										class2.activeUnit_0 = list14[num14];
										if (!Information.IsNothing(class2.activeUnit_0))
										{
											if (class2.activeUnit_0.bool_5 && (((Submarine)class2.activeUnit_0)._SubmarineType_0 == Submarine._SubmarineType.ROV || ((Submarine)class2.activeUnit_0)._SubmarineType_0 == Submarine._SubmarineType.UUV))
											{
												try
												{
													if (class2.activeUnit_0.vmethod_93().method_17().vmethod_85().method_40(ref class12.list_5, ref class12.list_5, ref class12.list_5, 1, false, false))
													{
														list_1.Add(class2.activeUnit_0);
														num13--;
													}
													goto IL_130D;
												}
												catch (Exception ex)
												{
													ex.Data.Add("Error at 200493", ex.Message);
													GameGeneral.smethod_25(ref ex);
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
													goto IL_130D;
												}
											}
											if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
											{
												list_1.Add(class2.activeUnit_0);
												num13--;
											}
										}
										IL_130D:
										num14++;
									}
								}
							}
						}
						goto IL_152D;
					}
					finally
					{
						List<int>.Enumerator enumerator19;
						((IDisposable)enumerator19).Dispose();
					}
				}
				List<ActiveUnit> list16 = new List<ActiveUnit>();
				List<int> list17 = new List<int>();
				try
				{
					foreach (ActiveUnit activeUnit2 in list_6)
					{
						if (activeUnit2.bool_5 && (((Submarine)activeUnit2)._SubmarineType_0 == Submarine._SubmarineType.ROV || ((Submarine)activeUnit2)._SubmarineType_0 == Submarine._SubmarineType.UUV))
						{
							list16.Add(activeUnit2);
							if (!list17.Contains(activeUnit2.DBID))
							{
								list17.Add(activeUnit2.DBID);
							}
						}
						else if (!Information.IsNothing(class2.activeUnit_0) && class2.activeUnit_0.vmethod_86().method_82())
						{
							list_1.Add(class2.activeUnit_0);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator20;
					((IDisposable)enumerator20).Dispose();
				}
				if (list16.Count > 0)
				{
					try
					{
						List<int>.Enumerator enumerator21 = list17.GetEnumerator();
						while (enumerator21.MoveNext())
						{
							GameGeneral.Class550 class14 = new GameGeneral.Class550(class14);
							class14.int_0 = enumerator21.Current;
							List<ActiveUnit> list18 = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list_5, new Func<ActiveUnit, bool>(class14.method_0)));
							IEnumerable<ActiveUnit> enumerable = Enumerable.ToList<ActiveUnit>(Enumerable.Where<ActiveUnit>(list18, (GameGeneral._Closure$__.$I106-10 == null) ? (GameGeneral._Closure$__.$I106-10 = new Func<ActiveUnit, bool>(GameGeneral._Closure$__.$I.method_3)) : GameGeneral._Closure$__.$I106-10));
							num6 = (int)Math.Ceiling((double)Enumerable.Count<ActiveUnit>(list18) / 3.0);
							int num15 = num6 - Enumerable.Count<ActiveUnit>(enumerable);
							if (num15 > 0)
							{
								int num16 = 0;
								while (num15 > 0 && num16 < list16.Count)
								{
									if (list16[num16].vmethod_93().method_17().vmethod_85().method_40(ref class12.list_5, ref class12.list_5, ref class12.list_5, 1, false, false))
									{
										if (!Information.IsNothing(list16[num16]))
										{
											list_1.Add(list16[num16]);
										}
										num15--;
									}
									num16++;
								}
							}
						}
					}
					finally
					{
						List<int>.Enumerator enumerator21;
						((IDisposable)enumerator21).Dispose();
					}
				}
				IL_152D:
				result = true;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x002A058C File Offset: 0x0029E78C
		private static bool smethod_43(ref Scenario scenario_0, ref Side side_0, Mission mission_0, bool bool_7, ref List<ActiveUnit> list_1, ref List<ActiveUnit> list_2, ref List<ActiveUnit> list_3, ref List<ActiveUnit> list_4, ref Mission._GroupSize _GroupSize_0, ref Mission._GroupSize _GroupSize_1, ref bool bool_8, ref bool bool_9, ref List<ActiveUnit> list_5)
		{
			bool result;
			try
			{
				int num = 0;
				List<Group> list = new List<Group>();
				try
				{
					List<ActiveUnit>.Enumerator enumerator = list_5.GetEnumerator();
					while (enumerator.MoveNext())
					{
						GameGeneral.Class553 @class = new GameGeneral.Class553(@class);
						@class.activeUnit_0 = enumerator.Current;
						int num2 = 0;
						int num3 = 0;
						IEnumerable<ActiveUnit> enumerable = Enumerable.Where<ActiveUnit>(list_1, new Func<ActiveUnit, bool>(@class.method_0));
						IEnumerable<ActiveUnit> enumerable2 = Enumerable.Where<ActiveUnit>(list_2, new Func<ActiveUnit, bool>(@class.method_1));
						if (Enumerable.Count<ActiveUnit>(enumerable) > 0)
						{
							if (Enumerable.Count<ActiveUnit>(enumerable) < (int)_GroupSize_0 && bool_8)
							{
								if (Enumerable.Count<ActiveUnit>(enumerable) < (int)_GroupSize_0 && mission_0.int_0 == 1)
								{
									scenario_0.method_59(string.Concat(new string[]
									{
										"Mission ",
										mission_0.Name,
										" ships and/or submarines on host ",
										@class.activeUnit_0.Name,
										" cannot deploy. When divided by base/ship there isn't enough vessels to create the minimum number of groups. A possible solution would be to add more vessels. Alternatively, re-configure the mission and reduce the minimum number of required vessels and/or escorts, or reduce the group size."
									}), mission_0.Name + " cannot deploy", LoggedMessage.MessageType.DockingOps, 0, null, side_0, default(Geopoint_Struct));
								}
							}
							else if (_GroupSize_0 > Mission._GroupSize.SingleVessel)
							{
								int num4 = Enumerable.Count<ActiveUnit>(enumerable);
								for (;;)
								{
									if (bool_8)
									{
										if (num4 < (int)_GroupSize_0)
										{
											break;
										}
									}
									else if (num4 == 0)
									{
										break;
									}
									List<ActiveUnit> list2 = new List<ActiveUnit>();
									int num5 = (int)_GroupSize_0;
									int num6 = 1;
									while (num6 <= num5 && num2 < Enumerable.Count<ActiveUnit>(enumerable))
									{
										if (!Information.IsNothing(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, num2)))
										{
											list2.Add(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, num2));
											list_3.Add(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable, num2));
											num++;
											num4--;
											num2++;
										}
										num6++;
									}
									Group item = new Group(ref scenario_0, ref side_0, list2, false, null, mission_0);
									list.Add(item);
								}
							}
							else
							{
								try
								{
									foreach (ActiveUnit item2 in enumerable)
									{
										list_3.Add(item2);
									}
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
						}
						if (!Information.IsNothing(enumerable2) && Enumerable.Count<ActiveUnit>(enumerable2) > 0)
						{
							if (Enumerable.Count<ActiveUnit>(enumerable2) < (int)_GroupSize_1 && bool_9)
							{
								if (Enumerable.Count<ActiveUnit>(enumerable2) < (int)_GroupSize_1 && mission_0.int_0 == 1)
								{
									scenario_0.method_59(string.Concat(new string[]
									{
										"Mission ",
										mission_0.Name,
										" ships and/or submarines on host ",
										@class.activeUnit_0.Name,
										" cannot deploy. When divided by base/ship there isn't enough vessels to create the minimum number of groups. A possible solution would be to add more vessels. Alternatively, re-configure the mission and reduce the minimum number of required vessels and/or escorts, or reduce the group size."
									}), mission_0.Name + " cannot deploy", LoggedMessage.MessageType.DockingOps, 0, null, side_0, default(Geopoint_Struct));
								}
							}
							else if (_GroupSize_1 > Mission._GroupSize.SingleVessel)
							{
								int num7 = Enumerable.Count<ActiveUnit>(enumerable2);
								for (;;)
								{
									if (bool_9)
									{
										if (num7 < (int)_GroupSize_1)
										{
											break;
										}
									}
									else if (num7 == 0)
									{
										break;
									}
									List<ActiveUnit> list3 = new List<ActiveUnit>();
									int num8 = (int)_GroupSize_1;
									int num9 = 1;
									while (num9 <= num8 && num3 < Enumerable.Count<ActiveUnit>(enumerable2))
									{
										if (!Information.IsNothing(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, num3)))
										{
											list3.Add(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, num3));
											list_4.Add(Enumerable.ElementAtOrDefault<ActiveUnit>(enumerable2, num3));
											num++;
											num7--;
											num3++;
										}
										num9++;
									}
									Group item3 = new Group(ref scenario_0, ref side_0, list3, false, null, mission_0);
									list.Add(item3);
								}
							}
							else
							{
								try
								{
									foreach (ActiveUnit item4 in enumerable2)
									{
										list_4.Add(item4);
									}
								}
								finally
								{
									IEnumerator<ActiveUnit> enumerator3;
									if (enumerator3 != null)
									{
										enumerator3.Dispose();
									}
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
				try
				{
					foreach (Group group in list)
					{
						if (group.vmethod_141().Values.Count == 1)
						{
							Enumerable.ElementAtOrDefault<ActiveUnit>(group.vmethod_141().Values, 0).vmethod_66(true, null);
							group.vmethod_133(false, false, false);
						}
					}
				}
				finally
				{
					List<Group>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
				try
				{
					foreach (ActiveUnit activeUnit in list_4)
					{
						if (activeUnit.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.Docked)
						{
							activeUnit.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator5;
					((IDisposable)enumerator5).Dispose();
				}
				try
				{
					foreach (ActiveUnit activeUnit2 in list_3)
					{
						if (activeUnit2.vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.Docked)
						{
							activeUnit2.vmethod_93().method_9(ActiveUnit_DockingOps._DockingOpsCondition.DeployingUnderway);
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator6;
					((IDisposable)enumerator6).Dispose();
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x002A0B2C File Offset: 0x0029ED2C
		private static bool smethod_44(ref Scenario scenario_0, ref Side side_0, ref Mission mission_0, ref List<Aircraft> list_1, ref List<Aircraft> list_2, int? nullable_0, Mission._FlightSize _FlightSize_0)
		{
			if (list_1.Count == list_2.Count)
			{
				if (!Information.IsNothing(nullable_0))
				{
					int count = list_1.Count;
					if (((nullable_0 != null) ? new bool?(count < nullable_0.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						scenario_0.method_59(string.Concat(new string[]
						{
							"***WARNING*** The total number of aircraft available for mission: ",
							mission_0.Name,
							" (",
							Conversions.ToString(list_1.Count),
							") is smaller than the minimum number of aircraft required to trigger mission (",
							(nullable_0 != null) ? Conversions.ToString(nullable_0.GetValueOrDefault()) : null,
							"). This mission will never take off. Removing aircraft from mission."
						}), mission_0.Name + " cannot launch; removes its AC", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
						try
						{
							foreach (ActiveUnit activeUnit in list_1)
							{
								Mission value = null;
								bool setMissionOnly = false;
								Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
								activeUnit.vmethod_102(value, setMissionOnly, ref missionAssignmentAttemptResult);
							}
						}
						finally
						{
							List<Aircraft>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						return false;
					}
				}
				if (Information.IsNothing(nullable_0) && list_1.Count < (int)_FlightSize_0 && mission_0.bool_12)
				{
					scenario_0.method_59(string.Concat(new string[]
					{
						"***WARNING*** The total number of aircraft available for mission: ",
						mission_0.Name,
						" (",
						Conversions.ToString(list_1.Count),
						") is smaller than the specified flight size (",
						Conversions.ToString((int)_FlightSize_0),
						") or minimum number of aircraft required to trigger mission. This mission will never take off. Removing aircraft from mission."
					}), mission_0.Name + " cannot launch; removes its AC", LoggedMessage.MessageType.SpecialMessage, 0, null, side_0, default(Geopoint_Struct));
					try
					{
						foreach (ActiveUnit activeUnit2 in list_1)
						{
							Mission value2 = null;
							bool setMissionOnly2 = false;
							Mission.MissionAssignmentAttemptResult missionAssignmentAttemptResult = Mission.MissionAssignmentAttemptResult.None;
							activeUnit2.vmethod_102(value2, setMissionOnly2, ref missionAssignmentAttemptResult);
						}
					}
					finally
					{
						List<Aircraft>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x002A0D54 File Offset: 0x0029EF54
		public static bool smethod_45(Side side_0, Unit unit_0, bool bool_7, ref string string_14, string string_15)
		{
			bool result;
			try
			{
				if (!unit_0.bool_0)
				{
					result = false;
				}
				else if (unit_0.method_8())
				{
					result = false;
				}
				else if (unit_0.vmethod_7(false) != side_0)
				{
					result = false;
				}
				else if (!string.IsNullOrEmpty(string_15) && Operators.CompareString(unit_0.string_0, string_15, false) == 0)
				{
					result = true;
				}
				else if (!((ActiveUnit)unit_0).vmethod_90().vmethod_1())
				{
					string_14 = "Unit is out of comms";
					result = false;
				}
				else if (unit_0.bool_1)
				{
					try
					{
						foreach (ActiveUnit activeUnit in ((Group)unit_0).vmethod_141().Values)
						{
							Unit unit_ = activeUnit;
							string text = null;
							if (GameGeneral.smethod_45(side_0, unit_, bool_7, ref text, string_15))
							{
								return true;
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
					string_14 = "Cannot issue orders to any member of this group";
					result = false;
				}
				else
				{
					if (unit_0.bool_2)
					{
						Weapon weapon = (Weapon)unit_0;
						if (weapon.method_179() == null)
						{
							return false;
						}
						if (!bool_7 && weapon.method_167() == Weapon._WeaponType.Sonobuoy)
						{
							return false;
						}
						if (weapon.method_199())
						{
							return false;
						}
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200361", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00010F95 File Offset: 0x0000F195
		public static void smethod_46(ref DateTime dateTime_1, ref string string_14)
		{
			GameGeneral.smethod_48(ref dateTime_1, ref string_14, true);
			GameGeneral.smethod_47(ref dateTime_1, ref string_14);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x002A0EE4 File Offset: 0x0029F0E4
		public static void smethod_47(ref DateTime dateTime_1, ref string string_14)
		{
			if (dateTime_1.Hour < 10)
			{
				string_14 = string_14 + "0" + dateTime_1.Hour.ToString() + ":";
			}
			else
			{
				string_14 = string_14 + dateTime_1.Hour.ToString() + ":";
			}
			if (dateTime_1.Minute < 10)
			{
				string_14 = string_14 + "0" + dateTime_1.Minute.ToString() + ":";
			}
			else
			{
				string_14 = string_14 + dateTime_1.Minute.ToString() + ":";
			}
			if (dateTime_1.Second < 10)
			{
				string_14 = string_14 + "0" + dateTime_1.Second.ToString();
				return;
			}
			string_14 += dateTime_1.Second.ToString();
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x002A0FC4 File Offset: 0x0029F1C4
		public static void smethod_48(ref DateTime dateTime_1, ref string string_14, bool bool_7)
		{
			string_14 = dateTime_1.Year.ToString() + "-";
			if (dateTime_1.Month < 10)
			{
				string_14 = string_14 + "0" + dateTime_1.Month.ToString() + "-";
			}
			else
			{
				string_14 = string_14 + dateTime_1.Month.ToString() + "-";
			}
			if (dateTime_1.Day < 10)
			{
				string_14 = string_14 + "0" + dateTime_1.Day.ToString();
			}
			else
			{
				string_14 += dateTime_1.Day.ToString();
			}
			if (bool_7)
			{
				string_14 += ", ";
			}
		}

		// Token: 0x04001D85 RID: 7557
		public static DateTime dateTime_0 = new DateTime(2019, 11, 15);

		// Token: 0x04001D86 RID: 7558
		public static int int_0 = 14;

		// Token: 0x04001D87 RID: 7559
		public static bool bool_0 = true;

		// Token: 0x04001D88 RID: 7560
		public static bool bool_1 = false;

		// Token: 0x04001D89 RID: 7561
		public static bool bool_2 = false;

		// Token: 0x04001D8A RID: 7562
		public static int int_1 = 7777;

		// Token: 0x04001D8B RID: 7563
		public static bool bool_3 = false;

		// Token: 0x04001D8C RID: 7564
		public static bool bool_4 = false;

		// Token: 0x04001D8D RID: 7565
		public static bool bool_5 = false;

		// Token: 0x04001D8E RID: 7566
		public static bool bool_6 = false;

		// Token: 0x04001D8F RID: 7567
		public static Exception exception_0;

		// Token: 0x04001D90 RID: 7568
		public static Class1874 class1874_0;

		// Token: 0x04001D91 RID: 7569
		internal static Dictionary<string, HashSet<string>> dictionary_0;

		// Token: 0x04001D92 RID: 7570
		private static string string_0 = "sellAr";

		// Token: 0x04001D93 RID: 7571
		private static string string_1 = "ebUnag";

		// Token: 0x04001D94 RID: 7572
		private static string string_2 = "oolaB";

		// Token: 0x04001D95 RID: 7573
		internal static string string_3 = GameGeneral.string_0 + GameGeneral.string_1 + GameGeneral.string_2;

		// Token: 0x04001D96 RID: 7574
		public static string string_4 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "Scenarios");

		// Token: 0x04001D97 RID: 7575
		public static string string_5 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "Temp");

		// Token: 0x04001D98 RID: 7576
		public static string string_6 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "AttachmentRepo");

		// Token: 0x04001D99 RID: 7577
		public static string string_7 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "DB");

		// Token: 0x04001D9A RID: 7578
		public static string string_8 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "GIS");

		// Token: 0x04001D9B RID: 7579
		public static string string_9 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "WW");

		// Token: 0x04001D9C RID: 7580
		public static string string_10 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "Logs");

		// Token: 0x04001D9D RID: 7581
		public static string string_11 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "Config");

		// Token: 0x04001D9E RID: 7582
		public static string string_12 = Path.Combine(Class160.smethod_1().Info.DirectoryPath, "Resources");

		// Token: 0x04001D9F RID: 7583
		private static float float_0 = 0f;

		// Token: 0x04001DA0 RID: 7584
		internal static int int_2 = Environment.ProcessorCount;

		// Token: 0x04001DA1 RID: 7585
		public static string string_13 = string.Empty;

		// Token: 0x04001DA2 RID: 7586
		private static ConcurrentDictionary<int, Random> concurrentDictionary_0 = new ConcurrentDictionary<int, Random>();

		// Token: 0x04001DA3 RID: 7587
		private static RNGCryptoServiceProvider rngcryptoServiceProvider_0 = new RNGCryptoServiceProvider();

		// Token: 0x04001DA4 RID: 7588
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04001DA5 RID: 7589
		[CompilerGenerated]
		private static GameGeneral.Delegate62 delegate62_0;

		// Token: 0x04001DA6 RID: 7590
		private static GameGeneral.Enum144 enum144_0;

		// Token: 0x04001DA7 RID: 7591
		public static int int_3;

		// Token: 0x04001DA8 RID: 7592
		public static int int_4;

		// Token: 0x04001DA9 RID: 7593
		private static List<ActiveUnit> list_0 = new List<ActiveUnit>();

		// Token: 0x04001DAA RID: 7594
		private static Dictionary<ActiveUnit, bool> dictionary_1 = new Dictionary<ActiveUnit, bool>();

		// Token: 0x02000471 RID: 1137
		// (Invoke) Token: 0x0600233E RID: 9022
		internal delegate void Delegate62(string theMessage);

		// Token: 0x02000472 RID: 1138
		internal enum Enum144
		{
			// Token: 0x04001DAC RID: 7596
			const_0,
			// Token: 0x04001DAD RID: 7597
			const_1,
			// Token: 0x04001DAE RID: 7598
			const_2,
			// Token: 0x04001DAF RID: 7599
			const_3,
			// Token: 0x04001DB0 RID: 7600
			const_4,
			// Token: 0x04001DB1 RID: 7601
			const_5
		}

		// Token: 0x02000473 RID: 1139
		[CompilerGenerated]
		internal sealed class Class527
		{
			// Token: 0x0600233F RID: 9023 RVA: 0x00010FA6 File Offset: 0x0000F1A6
			public Class527(GameGeneral.Class527 class527_0)
			{
				if (class527_0 != null)
				{
					this.activeUnit_0 = class527_0.activeUnit_0;
				}
			}

			// Token: 0x06002340 RID: 9024 RVA: 0x002A1084 File Offset: 0x0029F284
			internal void method_0()
			{
				ActiveUnit activeUnit = this.activeUnit_0;
				if (activeUnit != null)
				{
					GameGeneral.smethod_17(activeUnit, this.class528_0.activeUnit_0, this.class528_0.class529_0.float_0);
				}
			}

			// Token: 0x04001DB2 RID: 7602
			public ActiveUnit activeUnit_0;

			// Token: 0x04001DB3 RID: 7603
			public GameGeneral.Class528 class528_0;
		}

		// Token: 0x02000474 RID: 1140
		[CompilerGenerated]
		internal sealed class Class528
		{
			// Token: 0x06002341 RID: 9025 RVA: 0x00010FBD File Offset: 0x0000F1BD
			public Class528(GameGeneral.Class528 class528_0)
			{
				if (class528_0 != null)
				{
					this.activeUnit_0 = class528_0.activeUnit_0;
				}
			}

			// Token: 0x04001DB4 RID: 7604
			public ActiveUnit[] activeUnit_0;

			// Token: 0x04001DB5 RID: 7605
			public GameGeneral.Class529 class529_0;
		}

		// Token: 0x02000475 RID: 1141
		[CompilerGenerated]
		internal sealed class Class529
		{
			// Token: 0x06002342 RID: 9026 RVA: 0x00010FD4 File Offset: 0x0000F1D4
			public Class529(GameGeneral.Class529 class529_0)
			{
				if (class529_0 != null)
				{
					this.float_0 = class529_0.float_0;
				}
			}

			// Token: 0x04001DB6 RID: 7606
			public float float_0;
		}

		// Token: 0x02000476 RID: 1142
		[CompilerGenerated]
		internal sealed class Class530
		{
			// Token: 0x06002343 RID: 9027 RVA: 0x00010FEB File Offset: 0x0000F1EB
			public Class530(GameGeneral.Class530 class530_0)
			{
				if (class530_0 != null)
				{
					this.scenario_0 = class530_0.scenario_0;
					this.float_0 = class530_0.float_0;
				}
			}

			// Token: 0x06002344 RID: 9028 RVA: 0x0001100E File Offset: 0x0000F20E
			internal void method_0(Side side_0)
			{
				side_0.method_16(this.scenario_0);
			}

			// Token: 0x06002345 RID: 9029 RVA: 0x002A10BC File Offset: 0x0029F2BC
			internal void method_1(Side side_0)
			{
				try
				{
					side_0.method_65(this.scenario_0);
					int i = side_0.activeUnit_0.Length - 1;
					while (i >= 0)
					{
						ActiveUnit activeUnit;
						try
						{
							if (i < side_0.activeUnit_0.Length)
							{
								activeUnit = side_0.activeUnit_0[i];
								if (activeUnit != null)
								{
									goto IL_53;
								}
								Class429.smethod_1(ref side_0.activeUnit_0, activeUnit);
							}
							goto IL_67;
						}
						catch (Exception ex)
						{
							goto IL_67;
						}
						goto IL_53;
						IL_67:
						i += -1;
						continue;
						IL_53:
						if (activeUnit.method_82())
						{
							Class429.smethod_1(ref side_0.activeUnit_0, activeUnit);
							goto IL_67;
						}
						goto IL_67;
					}
					Parallel.ForEach<Contact>(side_0.method_11().Values, (this.action_0 == null) ? (this.action_0 = new Action<Contact>(this.method_2)) : this.action_0);
					side_0.method_19(ref this.scenario_0);
					side_0.method_18(this.scenario_0, this.float_0);
					side_0.method_41(true);
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 101293", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x06002346 RID: 9030 RVA: 0x002A11E8 File Offset: 0x0029F3E8
			internal void method_2(Contact contact_0)
			{
				if (contact_0.method_68() == null)
				{
					contact_0.method_69(new ObservableDictionary<int, EmissionContainer>());
				}
				contact_0.method_122(false);
				contact_0.method_123(false);
				try
				{
					foreach (KeyValuePair<int, EmissionContainer> keyValuePair in contact_0.method_68())
					{
						keyValuePair.Value.float_0 = keyValuePair.Value.float_0 + this.float_0;
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<int, EmissionContainer>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}

			// Token: 0x04001DB7 RID: 7607
			public Scenario scenario_0;

			// Token: 0x04001DB8 RID: 7608
			public float float_0;

			// Token: 0x04001DB9 RID: 7609
			public Action<Contact> action_0;
		}

		// Token: 0x02000477 RID: 1143
		[CompilerGenerated]
		internal sealed class Class531
		{
			// Token: 0x06002347 RID: 9031 RVA: 0x0001101C File Offset: 0x0000F21C
			public Class531(GameGeneral.Class531 class531_0)
			{
				if (class531_0 != null)
				{
					this.side_0 = class531_0.side_0;
				}
			}

			// Token: 0x06002348 RID: 9032 RVA: 0x002A1270 File Offset: 0x0029F470
			internal void method_0(Contact contact_0)
			{
				if (this.class532_0.class530_0.scenario_0.SecondIsChangingOnThisPulse)
				{
					contact_0.method_65(this.side_0, 1f, this.class532_0.class530_0.scenario_0);
				}
				contact_0.vmethod_44(this.class532_0.class530_0.float_0, this.class532_0.class530_0.scenario_0);
			}

			// Token: 0x04001DBA RID: 7610
			public Side side_0;

			// Token: 0x04001DBB RID: 7611
			public GameGeneral.Class532 class532_0;
		}

		// Token: 0x02000478 RID: 1144
		[CompilerGenerated]
		internal sealed class Class532
		{
			// Token: 0x06002349 RID: 9033 RVA: 0x00011033 File Offset: 0x0000F233
			public Class532(GameGeneral.Class532 class532_0)
			{
				if (class532_0 != null)
				{
					this.weapon_0 = class532_0.weapon_0;
					this.concurrentBag_0 = class532_0.concurrentBag_0;
				}
			}

			// Token: 0x0600234A RID: 9034 RVA: 0x002A12DC File Offset: 0x0029F4DC
			internal void method_0(ActiveUnit activeUnit_0)
			{
				try
				{
					if (activeUnit_0 != null)
					{
						if (activeUnit_0.vmethod_127())
						{
							GameGeneral.dictionary_1[activeUnit_0] = true;
						}
						activeUnit_0.double_2 = activeUnit_0.vmethod_28(null);
						activeUnit_0.double_3 = activeUnit_0.vmethod_30(null);
						activeUnit_0.vmethod_86().bool_6 = false;
						ActiveUnit_Sensory activeUnit_Sensory = activeUnit_0.vmethod_88();
						ActiveUnit_Weaponry activeUnit_Weaponry = activeUnit_0.vmethod_89();
						activeUnit_0.vmethod_44(this.class530_0.float_0, this.class530_0.scenario_0);
						activeUnit_Sensory.method_69(this.class530_0.float_0);
						if (this.class530_0.scenario_0.SecondIsChangingOnThisPulse && !activeUnit_0.bool_1 && GameGeneral.dictionary_1[activeUnit_0])
						{
							Sensor[] sensor_ = activeUnit_0.method_78();
							activeUnit_Sensory.method_44(sensor_);
							activeUnit_0.vmethod_90().vmethod_2();
						}
						if (!activeUnit_0.bool_2)
						{
							activeUnit_0.doctrine_0.method_4();
							Doctrine doctrine_ = activeUnit_0.doctrine_0;
							Scenario scenario_ = this.class530_0.scenario_0;
							bool flag = true;
							doctrine_.method_3(scenario_, ref flag);
						}
						activeUnit_Sensory.method_70(this.class530_0.float_0);
						activeUnit_Weaponry.method_3();
						if (activeUnit_0.bool_2)
						{
							this.weapon_0 = (Weapon)activeUnit_0;
							this.weapon_0.bool_29 = this.weapon_0.vmethod_145(this.class530_0.float_0);
							this.weapon_0.bool_30 = this.weapon_0.method_259(this.class530_0.float_0);
						}
						if (activeUnit_0.bool_8 && ActiveUnit_DockingOps.smethod_10(activeUnit_0))
						{
							this.concurrentBag_0.Add(activeUnit_0);
						}
					}
				}
				catch (Exception ex)
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
			}

			// Token: 0x04001DBC RID: 7612
			public Weapon weapon_0;

			// Token: 0x04001DBD RID: 7613
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x04001DBE RID: 7614
			public GameGeneral.Class530 class530_0;
		}

		// Token: 0x02000479 RID: 1145
		[CompilerGenerated]
		internal sealed class Class533
		{
			// Token: 0x0600234B RID: 9035 RVA: 0x00011056 File Offset: 0x0000F256
			public Class533(GameGeneral.Class533 class533_0)
			{
				if (class533_0 != null)
				{
					this.list_0 = class533_0.list_0;
				}
			}

			// Token: 0x04001DBF RID: 7615
			public List<ActiveUnit>[] list_0;

			// Token: 0x04001DC0 RID: 7616
			public GameGeneral.Class535 class535_0;
		}

		// Token: 0x0200047A RID: 1146
		[CompilerGenerated]
		internal sealed class Class534
		{
			// Token: 0x0600234C RID: 9036 RVA: 0x0001106D File Offset: 0x0000F26D
			public Class534(GameGeneral.Class534 class534_0)
			{
				if (class534_0 != null)
				{
					this.int_0 = class534_0.int_0;
				}
			}

			// Token: 0x0600234D RID: 9037 RVA: 0x002A14A0 File Offset: 0x0029F6A0
			internal void method_0()
			{
				List<ActiveUnit> list = this.class533_0.list_0[this.int_0];
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						if (activeUnit == null)
						{
							break;
						}
						ActiveUnit_Sensory activeUnit_Sensory = activeUnit.vmethod_88();
						activeUnit.vmethod_89();
						activeUnit.vmethod_5();
						activeUnit_Sensory.method_71(this.class533_0.class535_0.float_0);
						if (!activeUnit.bool_1)
						{
							if (this.class533_0.class535_0.scenario_0.SecondIsChangingOnThisPulse)
							{
								activeUnit_Sensory.method_45(activeUnit.method_78());
								if (activeUnit.bool_5)
								{
									ActiveUnit activeUnit2 = activeUnit;
									ref float ptr = ref activeUnit2.float_24;
									activeUnit2.float_24 = ptr + 1f;
								}
							}
							activeUnit.method_79(null);
						}
						if (activeUnit.bool_2)
						{
							Contact contact = activeUnit.vmethod_86().vmethod_3();
							if (contact != null && contact.activeUnit_0 != null && contact.method_96() > 0f)
							{
								contact.method_58(0f);
								ActiveUnit_Sensory.smethod_3(ref contact, contact.activeUnit_0, false, null);
							}
						}
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}

			// Token: 0x04001DC1 RID: 7617
			public int int_0;

			// Token: 0x04001DC2 RID: 7618
			public GameGeneral.Class533 class533_0;
		}

		// Token: 0x0200047B RID: 1147
		[CompilerGenerated]
		internal sealed class Class535
		{
			// Token: 0x0600234E RID: 9038 RVA: 0x00011084 File Offset: 0x0000F284
			public Class535(GameGeneral.Class535 class535_0)
			{
				if (class535_0 != null)
				{
					this.float_0 = class535_0.float_0;
					this.scenario_0 = class535_0.scenario_0;
				}
			}

			// Token: 0x04001DC3 RID: 7619
			public float float_0;

			// Token: 0x04001DC4 RID: 7620
			public Scenario scenario_0;
		}

		// Token: 0x0200047C RID: 1148
		[CompilerGenerated]
		internal sealed class Class536
		{
			// Token: 0x0600234F RID: 9039 RVA: 0x000110A7 File Offset: 0x0000F2A7
			public Class536(GameGeneral.Class536 class536_0)
			{
				if (class536_0 != null)
				{
					this.int_0 = class536_0.int_0;
				}
			}

			// Token: 0x06002350 RID: 9040 RVA: 0x000110BE File Offset: 0x0000F2BE
			internal bool method_0(Aircraft aircraft_0)
			{
				return aircraft_0.DBID == this.int_0;
			}

			// Token: 0x04001DC5 RID: 7621
			public int int_0;
		}

		// Token: 0x0200047D RID: 1149
		[CompilerGenerated]
		internal sealed class Class537
		{
			// Token: 0x06002351 RID: 9041 RVA: 0x000110CE File Offset: 0x0000F2CE
			public Class537(GameGeneral.Class537 class537_0)
			{
				if (class537_0 != null)
				{
					this.int_0 = class537_0.int_0;
				}
			}

			// Token: 0x04001DC6 RID: 7622
			public int int_0;

			// Token: 0x04001DC7 RID: 7623
			public GameGeneral.Class536 class536_0;
		}

		// Token: 0x0200047E RID: 1150
		[CompilerGenerated]
		internal sealed class Class538
		{
			// Token: 0x06002352 RID: 9042 RVA: 0x000110E5 File Offset: 0x0000F2E5
			public Class538(GameGeneral.Class538 class538_0)
			{
				if (class538_0 != null)
				{
					this.activeUnit_0 = class538_0.activeUnit_0;
				}
			}

			// Token: 0x06002353 RID: 9043 RVA: 0x002A15CC File Offset: 0x0029F7CC
			internal bool method_0(Aircraft aircraft_0)
			{
				return aircraft_0.DBID == this.class537_0.class536_0.int_0 && !Information.IsNothing(aircraft_0.method_167()) && aircraft_0.method_167().DBID == this.class537_0.int_0 && !Information.IsNothing(aircraft_0.method_164().method_30()) && aircraft_0.method_164().method_30() == this.activeUnit_0;
			}

			// Token: 0x06002354 RID: 9044 RVA: 0x002A15CC File Offset: 0x0029F7CC
			internal bool method_1(Aircraft aircraft_0)
			{
				return aircraft_0.DBID == this.class537_0.class536_0.int_0 && !Information.IsNothing(aircraft_0.method_167()) && aircraft_0.method_167().DBID == this.class537_0.int_0 && !Information.IsNothing(aircraft_0.method_164().method_30()) && aircraft_0.method_164().method_30() == this.activeUnit_0;
			}

			// Token: 0x04001DC8 RID: 7624
			public ActiveUnit activeUnit_0;

			// Token: 0x04001DC9 RID: 7625
			public GameGeneral.Class537 class537_0;
		}

		// Token: 0x02000480 RID: 1152
		[CompilerGenerated]
		internal sealed class Class539
		{
			// Token: 0x0600235D RID: 9053 RVA: 0x0001111D File Offset: 0x0000F31D
			public Class539(GameGeneral.Class539 class539_0)
			{
				if (class539_0 != null)
				{
					this.int_0 = class539_0.int_0;
				}
			}

			// Token: 0x0600235E RID: 9054 RVA: 0x002A16E8 File Offset: 0x0029F8E8
			internal bool method_0(Aircraft aircraft_0)
			{
				return !Information.IsNothing(aircraft_0.method_167()) && aircraft_0.method_167().DBID == this.int_0 && !Information.IsNothing(aircraft_0.method_164().method_30()) && aircraft_0.method_164().method_30() == this.class540_0.activeUnit_0;
			}

			// Token: 0x04001DD1 RID: 7633
			public int int_0;

			// Token: 0x04001DD2 RID: 7634
			public GameGeneral.Class540 class540_0;
		}

		// Token: 0x02000481 RID: 1153
		[CompilerGenerated]
		internal sealed class Class540
		{
			// Token: 0x0600235F RID: 9055 RVA: 0x00011134 File Offset: 0x0000F334
			public Class540(GameGeneral.Class540 class540_0)
			{
				if (class540_0 != null)
				{
					this.activeUnit_0 = class540_0.activeUnit_0;
				}
			}

			// Token: 0x04001DD3 RID: 7635
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000482 RID: 1154
		[CompilerGenerated]
		internal sealed class Class541
		{
			// Token: 0x06002360 RID: 9056 RVA: 0x0001114B File Offset: 0x0000F34B
			public Class541(GameGeneral.Class541 class541_0)
			{
				if (class541_0 != null)
				{
					this.int_0 = class541_0.int_0;
				}
			}

			// Token: 0x06002361 RID: 9057 RVA: 0x002A1744 File Offset: 0x0029F944
			internal bool method_0(Aircraft aircraft_0)
			{
				return !Information.IsNothing(aircraft_0.method_167()) && aircraft_0.method_167().DBID == this.int_0 && !Information.IsNothing(aircraft_0.method_164().method_30()) && aircraft_0.method_164().method_30() == this.class542_0.activeUnit_0;
			}

			// Token: 0x06002362 RID: 9058 RVA: 0x002A17A0 File Offset: 0x0029F9A0
			internal bool method_1(Aircraft aircraft_0)
			{
				return !Information.IsNothing(aircraft_0.method_167()) && aircraft_0.method_167().DBID == this.int_0 && !Information.IsNothing(aircraft_0.method_164().method_30()) && aircraft_0.method_164().method_30() == this.class542_0.activeUnit_0 && !aircraft_0.method_167().method_12();
			}

			// Token: 0x06002363 RID: 9059 RVA: 0x002A1808 File Offset: 0x0029FA08
			internal bool method_2(Aircraft aircraft_0)
			{
				return !Information.IsNothing(aircraft_0.method_167()) && aircraft_0.method_167().DBID == this.int_0 && !Information.IsNothing(aircraft_0.method_164().method_30()) && aircraft_0.method_164().method_30() == this.class542_0.activeUnit_0 && aircraft_0.method_167().method_12();
			}

			// Token: 0x04001DD4 RID: 7636
			public int int_0;

			// Token: 0x04001DD5 RID: 7637
			public GameGeneral.Class542 class542_0;
		}

		// Token: 0x02000483 RID: 1155
		[CompilerGenerated]
		internal sealed class Class542
		{
			// Token: 0x06002364 RID: 9060 RVA: 0x00011162 File Offset: 0x0000F362
			public Class542(GameGeneral.Class542 class542_0)
			{
				if (class542_0 != null)
				{
					this.activeUnit_0 = class542_0.activeUnit_0;
				}
			}

			// Token: 0x04001DD6 RID: 7638
			public ActiveUnit activeUnit_0;
		}

		// Token: 0x02000484 RID: 1156
		[CompilerGenerated]
		internal sealed class Class543
		{
			// Token: 0x06002365 RID: 9061 RVA: 0x00011179 File Offset: 0x0000F379
			public Class543(GameGeneral.Class543 class543_0)
			{
				if (class543_0 != null)
				{
					this.activeUnit_0 = class543_0.activeUnit_0;
				}
			}

			// Token: 0x04001DD7 RID: 7639
			public ActiveUnit activeUnit_0;

			// Token: 0x04001DD8 RID: 7640
			public GameGeneral.Class544 class544_0;
		}

		// Token: 0x02000485 RID: 1157
		[CompilerGenerated]
		internal sealed class Class544
		{
			// Token: 0x06002366 RID: 9062 RVA: 0x00011190 File Offset: 0x0000F390
			public Class544(GameGeneral.Class544 class544_0)
			{
				if (class544_0 != null)
				{
					this.mission_0 = class544_0.mission_0;
				}
			}

			// Token: 0x04001DD9 RID: 7641
			public Mission mission_0;
		}

		// Token: 0x02000486 RID: 1158
		[CompilerGenerated]
		internal sealed class Class545
		{
			// Token: 0x06002367 RID: 9063 RVA: 0x000111A7 File Offset: 0x0000F3A7
			public Class545(GameGeneral.Class545 class545_0)
			{
				if (class545_0 != null)
				{
					this.nullable_0 = class545_0.nullable_0;
				}
			}

			// Token: 0x06002368 RID: 9064 RVA: 0x002A186C File Offset: 0x0029FA6C
			internal bool method_0(Contact contact_0)
			{
				ActiveUnit_AI activeUnit_AI = this.class543_0.activeUnit_0.vmethod_86();
				Mission mission_ = this.class543_0.class544_0.mission_0;
				Doctrine.Enum59? nullable_ = this.nullable_0;
				bool bool_ = false;
				bool bool_2 = false;
				bool bool_3 = true;
				Misc.PostureStance? nullable_2 = null;
				string text = "";
				int num = 0;
				return activeUnit_AI.method_39(contact_0, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num);
			}

			// Token: 0x04001DDA RID: 7642
			public Doctrine.Enum59? nullable_0;

			// Token: 0x04001DDB RID: 7643
			public GameGeneral.Class543 class543_0;
		}

		// Token: 0x02000487 RID: 1159
		[CompilerGenerated]
		internal sealed class Class546
		{
			// Token: 0x06002369 RID: 9065 RVA: 0x000111BE File Offset: 0x0000F3BE
			public Class546(GameGeneral.Class546 class546_0)
			{
				if (class546_0 != null)
				{
					this.nullable_0 = class546_0.nullable_0;
				}
			}

			// Token: 0x0600236A RID: 9066 RVA: 0x002A18C0 File Offset: 0x0029FAC0
			internal bool method_0(Contact contact_0)
			{
				ActiveUnit_AI activeUnit_AI = this.class543_0.activeUnit_0.vmethod_86();
				Mission mission_ = this.class543_0.class544_0.mission_0;
				Doctrine.Enum59? nullable_ = this.nullable_0;
				bool bool_ = false;
				bool bool_2 = false;
				bool bool_3 = true;
				Misc.PostureStance? nullable_2 = null;
				string text = "";
				int num = 0;
				return activeUnit_AI.method_39(contact_0, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num);
			}

			// Token: 0x04001DDC RID: 7644
			public Doctrine.Enum59? nullable_0;

			// Token: 0x04001DDD RID: 7645
			public GameGeneral.Class543 class543_0;
		}

		// Token: 0x02000488 RID: 1160
		[CompilerGenerated]
		internal sealed class Class547
		{
			// Token: 0x0600236B RID: 9067 RVA: 0x000111D5 File Offset: 0x0000F3D5
			public Class547(GameGeneral.Class547 class547_0)
			{
				if (class547_0 != null)
				{
					this.nullable_0 = class547_0.nullable_0;
				}
			}

			// Token: 0x0600236C RID: 9068 RVA: 0x002A1914 File Offset: 0x0029FB14
			internal bool method_0(Contact contact_0)
			{
				ActiveUnit_AI activeUnit_AI = this.class543_0.activeUnit_0.vmethod_86();
				Mission mission_ = this.class543_0.class544_0.mission_0;
				Doctrine.Enum59? nullable_ = this.nullable_0;
				bool bool_ = false;
				bool bool_2 = false;
				bool bool_3 = true;
				Misc.PostureStance? nullable_2 = null;
				string text = "";
				int num = 0;
				return activeUnit_AI.method_39(contact_0, mission_, nullable_, bool_, bool_2, bool_3, nullable_2, ref text, ref num);
			}

			// Token: 0x04001DDE RID: 7646
			public Doctrine.Enum59? nullable_0;

			// Token: 0x04001DDF RID: 7647
			public GameGeneral.Class543 class543_0;
		}

		// Token: 0x02000489 RID: 1161
		[CompilerGenerated]
		internal sealed class Class548
		{
			// Token: 0x0600236D RID: 9069 RVA: 0x000111EC File Offset: 0x0000F3EC
			public Class548(GameGeneral.Class548 class548_0)
			{
				if (class548_0 != null)
				{
					this.int_0 = class548_0.int_0;
				}
			}

			// Token: 0x0600236E RID: 9070 RVA: 0x00011203 File Offset: 0x0000F403
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x0600236F RID: 9071 RVA: 0x00011203 File Offset: 0x0000F403
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001DE0 RID: 7648
			public int int_0;
		}

		// Token: 0x0200048A RID: 1162
		[CompilerGenerated]
		internal sealed class Class549
		{
			// Token: 0x06002370 RID: 9072 RVA: 0x00011213 File Offset: 0x0000F413
			public Class549(GameGeneral.Class549 class549_0)
			{
				if (class549_0 != null)
				{
					this.int_0 = class549_0.int_0;
				}
			}

			// Token: 0x06002371 RID: 9073 RVA: 0x0001122A File Offset: 0x0000F42A
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06002372 RID: 9074 RVA: 0x0001122A File Offset: 0x0000F42A
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001DE1 RID: 7649
			public int int_0;
		}

		// Token: 0x0200048B RID: 1163
		[CompilerGenerated]
		internal sealed class Class550
		{
			// Token: 0x06002373 RID: 9075 RVA: 0x0001123A File Offset: 0x0000F43A
			public Class550(GameGeneral.Class550 class550_0)
			{
				if (class550_0 != null)
				{
					this.int_0 = class550_0.int_0;
				}
			}

			// Token: 0x06002374 RID: 9076 RVA: 0x00011251 File Offset: 0x0000F451
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001DE2 RID: 7650
			public int int_0;
		}

		// Token: 0x0200048C RID: 1164
		[CompilerGenerated]
		internal sealed class Class551
		{
			// Token: 0x06002375 RID: 9077 RVA: 0x00011261 File Offset: 0x0000F461
			public Class551(GameGeneral.Class551 class551_0)
			{
				if (class551_0 != null)
				{
					this.int_0 = class551_0.int_0;
				}
			}

			// Token: 0x06002376 RID: 9078 RVA: 0x00011278 File Offset: 0x0000F478
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x06002377 RID: 9079 RVA: 0x00011278 File Offset: 0x0000F478
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001DE3 RID: 7651
			public int int_0;
		}

		// Token: 0x0200048D RID: 1165
		[CompilerGenerated]
		internal sealed class Class552
		{
			// Token: 0x06002378 RID: 9080 RVA: 0x00011288 File Offset: 0x0000F488
			public Class552(GameGeneral.Class552 class552_0)
			{
				if (class552_0 != null)
				{
					this.int_0 = class552_0.int_0;
				}
			}

			// Token: 0x06002379 RID: 9081 RVA: 0x0001129F File Offset: 0x0000F49F
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x0600237A RID: 9082 RVA: 0x0001129F File Offset: 0x0000F49F
			internal bool method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.DBID == this.int_0;
			}

			// Token: 0x04001DE4 RID: 7652
			public int int_0;
		}

		// Token: 0x0200048E RID: 1166
		[CompilerGenerated]
		internal sealed class Class553
		{
			// Token: 0x0600237B RID: 9083 RVA: 0x000112AF File Offset: 0x0000F4AF
			public Class553(GameGeneral.Class553 class553_0)
			{
				if (class553_0 != null)
				{
					this.activeUnit_0 = class553_0.activeUnit_0;
				}
			}

			// Token: 0x0600237C RID: 9084 RVA: 0x000112C6 File Offset: 0x0000F4C6
			internal bool method_0(ActiveUnit activeUnit_1)
			{
				return activeUnit_1.vmethod_93().method_17() == this.activeUnit_0;
			}

			// Token: 0x0600237D RID: 9085 RVA: 0x000112C6 File Offset: 0x0000F4C6
			internal bool method_1(ActiveUnit activeUnit_1)
			{
				return activeUnit_1.vmethod_93().method_17() == this.activeUnit_0;
			}

			// Token: 0x04001DE5 RID: 7653
			public ActiveUnit activeUnit_0;
		}
	}
}
