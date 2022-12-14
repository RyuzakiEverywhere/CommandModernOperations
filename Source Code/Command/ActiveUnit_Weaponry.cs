using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x0200016D RID: 365
	public class ActiveUnit_Weaponry
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x00008148 File Offset: 0x00006348
		[CompilerGenerated]
		protected virtual List<Class357> vmethod_0()
		{
			return this.list_0;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00008150 File Offset: 0x00006350
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		protected virtual void vmethod_1(List<Class357> list_3)
		{
			this.list_0 = list_3;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x000BC840 File Offset: 0x000BAA40
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_Weaponry.Delegate22 delegate22_1)
		{
			ActiveUnit_Weaponry.Delegate22 @delegate = ActiveUnit_Weaponry.delegate22_0;
			ActiveUnit_Weaponry.Delegate22 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_Weaponry.Delegate22 value = (ActiveUnit_Weaponry.Delegate22)Delegate.Combine(delegate2, delegate22_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_Weaponry.Delegate22>(ref ActiveUnit_Weaponry.delegate22_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000BC874 File Offset: 0x000BAA74
		public virtual void vmethod_2(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("ActiveUnit_Weaponry");
				if (this.vmethod_0().Count > 0)
				{
					xmlWriter_0.WriteStartElement("WeaponAssignments");
					try
					{
						foreach (Class357 @class in this.vmethod_0())
						{
							@class.method_8(ref xmlWriter_0, ref hashSet_1);
						}
					}
					finally
					{
						List<Class357>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.bool_1)
				{
					xmlWriter_0.WriteElementString("LCS", "True");
				}
				if (this.bool_2)
				{
					xmlWriter_0.WriteElementString("IDLZ", "True");
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100284", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00008159 File Offset: 0x00006359
		private ActiveUnit_Weaponry()
		{
			this.vmethod_1(new List<Class357>());
			this.hashSet_0 = new HashSet<string>();
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00008177 File Offset: 0x00006377
		public ActiveUnit_Weaponry(ActiveUnit activeUnit_1)
		{
			this.vmethod_1(new List<Class357>());
			this.hashSet_0 = new HashSet<string>();
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x000BC970 File Offset: 0x000BAB70
		public List<WeaponRec> method_0(bool bool_9)
		{
			List<WeaponRec> list = new List<WeaponRec>();
			List<WeaponRec> result;
			try
			{
				ObservableList<Mount> observableList = this.activeUnit_0.vmethod_51();
				if (observableList.Count > 0)
				{
					int num = observableList.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = observableList[i];
						ObservableList<WeaponRec> observableList2 = mount.vmethod_10();
						int num2 = observableList2.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							WeaponRec item = observableList2[j];
							list.Add(item);
						}
						ObservableList<WeaponRec> observableList3 = mount.method_32().vmethod_10();
						int num3 = observableList3.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							WeaponRec item = observableList3[k];
							list.Add(item);
						}
					}
				}
				Magazine[] array = this.activeUnit_0.vmethod_117();
				if (!Information.IsNothing(array))
				{
					int num4 = array.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						Magazine magazine = array[l];
						if (bool_9 || !magazine.bool_11)
						{
							ObservableList<WeaponRec> observableList4 = magazine.vmethod_10();
							int num5 = observableList4.Count - 1;
							for (int m = 0; m <= num5; m++)
							{
								WeaponRec item = observableList4[m];
								list.Add(item);
							}
						}
					}
				}
				if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
				{
					WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
					int num6 = weaponRec_.Length - 1;
					for (int n = 0; n <= num6; n++)
					{
						WeaponRec item = weaponRec_[n];
						list.Add(item);
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101300", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000BCB6C File Offset: 0x000BAD6C
		public Dictionary<int, WeaponRec> method_1(bool bool_9)
		{
			Dictionary<int, WeaponRec> dictionary = new Dictionary<int, WeaponRec>();
			Dictionary<int, WeaponRec> result;
			try
			{
				ObservableList<Mount> observableList = this.activeUnit_0.vmethod_51();
				if (observableList.Count > 0)
				{
					int num = observableList.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = observableList[i];
						ObservableList<WeaponRec> observableList2 = mount.vmethod_10();
						int num2 = observableList2.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							WeaponRec weaponRec = observableList2[j];
							if (!dictionary.ContainsKey(weaponRec.int_5))
							{
								dictionary.Add(weaponRec.int_5, weaponRec);
							}
						}
						ObservableList<WeaponRec> observableList3 = mount.method_32().vmethod_10();
						int num3 = observableList3.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							WeaponRec weaponRec = observableList3[k];
							if (!dictionary.ContainsKey(weaponRec.int_5))
							{
								dictionary.Add(weaponRec.int_5, weaponRec);
							}
						}
					}
				}
				Magazine[] array = this.activeUnit_0.vmethod_117();
				if (!Information.IsNothing(array))
				{
					int num4 = array.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						Magazine magazine = array[l];
						if (bool_9 || !magazine.bool_11)
						{
							ObservableList<WeaponRec> observableList4 = magazine.vmethod_10();
							int num5 = observableList4.Count - 1;
							for (int m = 0; m <= num5; m++)
							{
								WeaponRec weaponRec = observableList4[m];
								if (!dictionary.ContainsKey(weaponRec.int_5))
								{
									dictionary.Add(weaponRec.int_5, weaponRec);
								}
							}
						}
					}
				}
				if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
				{
					WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
					int num6 = weaponRec_.Length - 1;
					for (int n = 0; n <= num6; n++)
					{
						WeaponRec weaponRec = weaponRec_[n];
						if (!dictionary.ContainsKey(weaponRec.int_5))
						{
							dictionary.Add(weaponRec.int_5, weaponRec);
						}
					}
				}
				result = dictionary;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101301", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x000BCDB8 File Offset: 0x000BAFB8
		public Dictionary<int, Weapon> method_2(bool bool_9)
		{
			Dictionary<int, Weapon> dictionary = new Dictionary<int, Weapon>();
			Dictionary<int, Weapon> result;
			try
			{
				ObservableList<Mount> observableList = this.activeUnit_0.vmethod_51();
				if (observableList.Count > 0)
				{
					int num = observableList.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						Mount mount = observableList[i];
						ObservableList<WeaponRec> observableList2 = mount.vmethod_10();
						int num2 = observableList2.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							WeaponRec weaponRec = observableList2[j];
							if (!dictionary.ContainsKey(weaponRec.int_5))
							{
								dictionary.Add(weaponRec.int_5, weaponRec.method_12(this.activeUnit_0.scenario_0));
							}
						}
						ObservableList<WeaponRec> observableList3 = mount.method_32().vmethod_10();
						int num3 = observableList3.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							WeaponRec weaponRec = observableList3[k];
							if (!dictionary.ContainsKey(weaponRec.int_5))
							{
								dictionary.Add(weaponRec.int_5, weaponRec.method_12(this.activeUnit_0.scenario_0));
							}
						}
					}
				}
				Magazine[] array = this.activeUnit_0.vmethod_117();
				if (!Information.IsNothing(array))
				{
					int num4 = array.Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						Magazine magazine = array[l];
						if (bool_9 || !magazine.bool_11)
						{
							ObservableList<WeaponRec> observableList4 = magazine.vmethod_10();
							int num5 = observableList4.Count - 1;
							for (int m = 0; m <= num5; m++)
							{
								WeaponRec weaponRec = observableList4[m];
								if (!dictionary.ContainsKey(weaponRec.int_5))
								{
									dictionary.Add(weaponRec.int_5, weaponRec.method_12(this.activeUnit_0.scenario_0));
								}
							}
						}
					}
				}
				if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
				{
					WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
					int num6 = weaponRec_.Length - 1;
					for (int n = 0; n <= num6; n++)
					{
						WeaponRec weaponRec = weaponRec_[n];
						if (!dictionary.ContainsKey(weaponRec.int_5))
						{
							dictionary.Add(weaponRec.int_5, weaponRec.method_12(this.activeUnit_0.scenario_0));
						}
					}
				}
				result = dictionary;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100287", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0000819C File Offset: 0x0000639C
		public void method_3()
		{
			if (this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse)
			{
				this.vmethod_3();
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x000BD044 File Offset: 0x000BB244
		public virtual void vmethod_3()
		{
			this.list_1 = null;
			this.list_2 = null;
			this.weapon_2 = null;
			this.weapon_1 = null;
			this.bool_5 = false;
			this.bool_4 = false;
			this.weapon_0 = null;
			this.bool_3 = false;
			this.weapon_4 = null;
			this.weapon_3 = null;
			this.bool_7 = false;
			this.bool_6 = false;
			this.weapon_5 = null;
			this.bool_8 = false;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x000BD0B4 File Offset: 0x000BB2B4
		public virtual List<Weapon> vmethod_4()
		{
			if (Information.IsNothing(this.list_1))
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				List<Weapon> list = new List<Weapon>();
				try
				{
					ObservableList<Mount> observableList = this.activeUnit_0.vmethod_51();
					if (observableList.Count > 0)
					{
						int num = observableList.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							Mount mount = observableList[i];
							ObservableList<WeaponRec> observableList2 = mount.vmethod_10();
							int num2 = observableList2.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								WeaponRec weaponRec = observableList2[j];
								if (weaponRec.method_9() > 0 && !dictionary.ContainsKey(weaponRec.int_5))
								{
									dictionary.Add(weaponRec.int_5, 0);
									list.Add(weaponRec.method_12(this.activeUnit_0.scenario_0));
								}
							}
							ObservableList<WeaponRec> observableList3 = mount.method_32().vmethod_10();
							int num3 = observableList3.Count - 1;
							for (int k = 0; k <= num3; k++)
							{
								WeaponRec weaponRec = observableList3[k];
								if (weaponRec.method_9() > 0 && !dictionary.ContainsKey(weaponRec.int_5))
								{
									dictionary.Add(weaponRec.int_5, 0);
									list.Add(weaponRec.method_12(this.activeUnit_0.scenario_0));
								}
							}
						}
					}
					Magazine[] array = this.activeUnit_0.vmethod_117();
					if (!Information.IsNothing(array))
					{
						int num4 = array.Length - 1;
						for (int l = 0; l <= num4; l++)
						{
							Magazine magazine = array[l];
							if (!magazine.bool_11)
							{
								ObservableList<WeaponRec> observableList4 = magazine.vmethod_10();
								int num5 = observableList4.Count - 1;
								for (int m = 0; m <= num5; m++)
								{
									WeaponRec weaponRec = observableList4[m];
									if (weaponRec.method_9() > 0 && !dictionary.ContainsKey(weaponRec.int_5))
									{
										dictionary.Add(weaponRec.int_5, 0);
										list.Add(weaponRec.method_12(this.activeUnit_0.scenario_0));
									}
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100288", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				this.list_1 = list;
			}
			return this.list_1;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000BD310 File Offset: 0x000BB510
		public int method_4(int int_0)
		{
			int result;
			try
			{
				int num;
				try
				{
					foreach (Mount mount in this.activeUnit_0.vmethod_51())
					{
						if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							try
							{
								foreach (WeaponRec weaponRec in mount.vmethod_10())
								{
									if (weaponRec.int_5 == int_0)
									{
										num += weaponRec.int_0;
									}
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
									if (weaponRec2.int_5 == int_0)
									{
										num += weaponRec2.int_0;
									}
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				foreach (Magazine magazine in this.activeUnit_0.vmethod_117())
				{
					if (magazine.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						try
						{
							foreach (WeaponRec weaponRec3 in magazine.vmethod_10())
							{
								if (weaponRec3.int_5 == int_0)
								{
									num += weaponRec3.int_2;
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
				}
				if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
				{
					foreach (WeaponRec weaponRec4 in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
					{
						if (weaponRec4.int_5 == int_0)
						{
							num += weaponRec4.int_0;
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100290", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000BD58C File Offset: 0x000BB78C
		public int method_5(int int_0, bool bool_9)
		{
			int result;
			try
			{
				int num;
				try
				{
					foreach (Mount mount in this.activeUnit_0.vmethod_51())
					{
						if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational || bool_9)
						{
							try
							{
								foreach (WeaponRec weaponRec in mount.vmethod_10())
								{
									if (weaponRec.int_5 == int_0)
									{
										num += weaponRec.method_9();
									}
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
									if (weaponRec2.int_5 == int_0)
									{
										num += weaponRec2.method_9();
									}
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				foreach (Magazine magazine in this.activeUnit_0.vmethod_117())
				{
					if (magazine.vmethod_5() == PlatformComponent._ComponentStatus.Operational || bool_9)
					{
						try
						{
							foreach (WeaponRec weaponRec3 in magazine.vmethod_10())
							{
								if (weaponRec3.int_5 == int_0)
								{
									num += weaponRec3.method_9();
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
				}
				if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
				{
					foreach (WeaponRec weaponRec4 in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
					{
						if (weaponRec4.int_5 == int_0)
						{
							num += weaponRec4.method_9();
						}
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100292", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000BD810 File Offset: 0x000BBA10
		public bool method_6(Contact theTarget, bool CheckWRA, Doctrine theDoc, ref string Feedback, ref int FeedbackSeverity, Weapon[] AvailableWeapons = null)
		{
			bool result;
			try
			{
				Weapon[] array;
				if (AvailableWeapons == null)
				{
					List<Weapon> list = this.vmethod_4();
					array = new Weapon[list.Count - 1 + 1];
					int num = list.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						array[i] = list[i];
					}
				}
				else
				{
					array = AvailableWeapons;
				}
				if (array.Length == 0)
				{
					result = false;
				}
				else
				{
					bool? flag = new bool?(theTarget.method_124(this.activeUnit_0.scenario_0));
					bool? flag2 = flag;
					if (((flag2 != null) ? new bool?(flag2.GetValueOrDefault()) : null).GetValueOrDefault())
					{
						result = false;
					}
					else
					{
						int num2 = array.Length - 1;
						int j = 0;
						while (j <= num2)
						{
							Weapon weapon = array[j];
							if (!this.activeUnit_0.bool_3 || !theTarget.method_134() || weapon.method_167() != Weapon._WeaponType.Gun)
							{
								goto IL_178;
							}
							Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets;
							if (gunStrafeGroundTargets == null)
							{
								gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
							}
							byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
							if (!((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								goto IL_178;
							}
							if (FeedbackSeverity < 2)
							{
								Feedback = "No contacts can be engaged by the available weapons (the only suitable weapon is gun, but doctrine forbids gun strafing).";
								FeedbackSeverity = 2;
							}
							IL_2A6:
							j++;
							continue;
							IL_178:
							if (weapon.method_253(this.activeUnit_0.scenario_0, ref theTarget, ref flag))
							{
								if (CheckWRA && theDoc != null && theDoc.method_239(ref weapon))
								{
									Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = Doctrine.smethod_7(ref theTarget);
									Doctrine._WRA_WeaponTargetType wra_WeaponTargetType2 = Doctrine.smethod_6(ref weapon, ref theTarget, ref wra_WeaponTargetType);
									Scenario scenario_ = weapon.scenario_0;
									Weapon theWeapon = weapon;
									Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wra_WeaponTargetType2;
									bool findInheritedValuesOnly = false;
									int? num3 = null;
									int? num4 = null;
									num4 = theDoc.method_9(scenario_, theWeapon, selectedNodeTargetType, findInheritedValuesOnly, ref num3, ref num4);
									if (((num4 != null) ? new bool?(num4.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										if (FeedbackSeverity < 4)
										{
											Feedback = "No contacts can be engaged by the available weapons (Weapon Release Authorization - Target Type).";
											FeedbackSeverity = 4;
											goto IL_2A6;
										}
										goto IL_2A6;
									}
									else
									{
										Scenario scenario_2 = weapon.scenario_0;
										int dbid = weapon.DBID;
										Doctrine._WRA_WeaponTargetType selectedNodeTargetType2 = wra_WeaponTargetType2;
										bool findInheritedValuesOnly2 = false;
										num4 = null;
										num3 = null;
										int? num5 = theDoc.method_23(scenario_2, dbid, selectedNodeTargetType2, findInheritedValuesOnly2, ref num4, ref num3);
										if (num5 != null)
										{
											num3 = num5;
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												if (FeedbackSeverity < 5)
												{
													Feedback = "No contacts can be engaged by the available weapons (Weapon Release Authorization - Firing Range).";
													FeedbackSeverity = 5;
													goto IL_2A6;
												}
												goto IL_2A6;
											}
										}
									}
								}
								return true;
							}
							goto IL_2A6;
						}
						if (FeedbackSeverity < 3)
						{
							Feedback = "No contacts can be engaged by the available weapons (not suitable).";
							FeedbackSeverity = 3;
						}
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100293", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000BDB44 File Offset: 0x000BBD44
		public void method_7(float float_0, long long_0)
		{
			List<WeaponRec> list = new List<WeaponRec>();
			List<Mount> list2 = new List<Mount>();
			List<Mount> list3 = new List<Mount>();
			List<Mount> list4 = new List<Mount>();
			try
			{
				try
				{
					foreach (Mount mount in this.activeUnit_0.vmethod_51())
					{
						try
						{
							foreach (WeaponRec weaponRec in mount.vmethod_10())
							{
								weaponRec.mount_0 = mount;
								Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
								if (weapon.method_155())
								{
									if (mount.hashSet_0.Count == 0 && !list4.Contains(mount))
									{
										list4.Add(mount);
									}
									if (this.activeUnit_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(this.activeUnit_0.scenario_0.method_39()) && weapon.float_40 == 0f && weapon.float_39 == 0f)
									{
										if (weapon.float_44 < this.activeUnit_0.vmethod_14(false))
										{
											continue;
										}
										if (weapon.float_43 > this.activeUnit_0.vmethod_14(false))
										{
											continue;
										}
									}
									else if (this.activeUnit_0.bool_3)
									{
										if (weapon.float_40 < this.activeUnit_0.vmethod_14(false))
										{
											continue;
										}
										if (weapon.float_39 > this.activeUnit_0.vmethod_14(false))
										{
											continue;
										}
									}
									else if (weapon.float_44 < this.activeUnit_0.vmethod_14(false) || weapon.float_43 > this.activeUnit_0.vmethod_14(false))
									{
										continue;
									}
									if (weaponRec.method_9() != 0 && mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
									{
										if (mount.hashSet_0.Count == 0 && !list3.Contains(mount))
										{
											list3.Add(mount);
										}
										if (mount.method_28() == 0f && weaponRec.float_0 == 0f)
										{
											if (mount.hashSet_0.Count == 0 && !list2.Contains(mount))
											{
												list2.Add(mount);
											}
											UnguidedWeapon unguidedWeapon = new UnguidedWeapon(weapon, null, null, 0.0, 0.0, 0L);
											string text = UnguidedWeapon.smethod_3(ref unguidedWeapon, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (float)this.activeUnit_0.method_9(false, false, false), this.activeUnit_0.scenario_0);
											if (string.CompareOrdinal(text, "OK") != 0)
											{
												string text2 = "";
												if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
												{
													text2 = " (" + this.activeUnit_0.string_2 + ")";
												}
												this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
												{
													this.activeUnit_0.Name,
													text2,
													" can not lay mine of type ",
													weapon.Name,
													": ",
													text
												}), this.activeUnit_0.Name + " cannot lay mine", LoggedMessage.MessageType.WeaponEndgame, 0, null, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
											}
											else
											{
												list.Add(weaponRec);
											}
										}
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.activeUnit_0.bool_3)
				{
					if (!Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
					{
						foreach (WeaponRec weaponRec in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
						{
							weaponRec.mount_0 = null;
							Weapon weapon2 = weaponRec.method_12(this.activeUnit_0.scenario_0);
							if (weapon2.method_155())
							{
								if (this.activeUnit_0.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(this.activeUnit_0.scenario_0.method_39()) && weapon2.float_40 == 0f)
								{
									if (weapon2.float_44 < this.activeUnit_0.vmethod_14(false))
									{
										goto IL_507;
									}
								}
								else if (weapon2.float_40 < this.activeUnit_0.vmethod_14(false))
								{
									goto IL_507;
								}
								if (weaponRec.method_9() != 0 && weaponRec.float_0 <= 0f)
								{
									UnguidedWeapon unguidedWeapon2 = new UnguidedWeapon(weapon2, null, null, 0.0, 0.0, 0L);
									if (string.CompareOrdinal(UnguidedWeapon.smethod_3(ref unguidedWeapon2, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (float)this.activeUnit_0.method_9(false, false, false), this.activeUnit_0.scenario_0), "OK") == 0)
									{
										list.Add(weaponRec);
									}
								}
							}
							IL_507:;
						}
					}
					if (list.Count == 0)
					{
						return;
					}
				}
				if (!this.activeUnit_0.bool_3)
				{
					if (list.Count == 0 && list4.Count == 0)
					{
						return;
					}
					if (list.Count == 0 && list3.Count == list2.Count)
					{
						Mount mount2 = list4[GameGeneral.smethod_5().Next(0, list4.Count)];
						WeaponRec weaponRec2 = Enumerable.FirstOrDefault<WeaponRec>(mount2.vmethod_10(), (ActiveUnit_Weaponry._Closure$__.$I33-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I33-0 = new Func<WeaponRec, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_0)) : ActiveUnit_Weaponry._Closure$__.$I33-0);
						WeaponRec weaponRec3 = Enumerable.FirstOrDefault<WeaponRec>(mount2.vmethod_10(), new Func<WeaponRec, bool>(this.method_61));
						if (weaponRec2 != null && weaponRec3 != null)
						{
							this.method_36(ref mount2, ref weaponRec2);
							this.method_37(ref mount2, ref weaponRec3);
						}
						return;
					}
					if (list.Count == 0)
					{
						return;
					}
				}
				WeaponRec weaponRec4;
				if (list.Count == 1)
				{
					weaponRec4 = list[0];
				}
				else
				{
					weaponRec4 = list[GameGeneral.smethod_5().Next(0, list.Count)];
				}
				Contact theTarget = null;
				int num = 0;
				int specificNumberOfWeaponsToFire = 0;
				float initialHeading = 0f;
				ActiveUnit.Throttle throttleSetting = ActiveUnit.Throttle.Flank;
				Mount firingMount = null;
				Class568.Enum154 sonobuoyDepthSetting = Class568.Enum154.const_0;
				Class316 @class = null;
				this.method_43(float_0, ref weaponRec4, theTarget, ref num, specificNumberOfWeaponsToFire, initialHeading, throttleSetting, firingMount, sonobuoyDepthSetting, long_0, ref @class);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100294", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x000BE224 File Offset: 0x000BC424
		public virtual ActiveUnit._ActiveUnitWeaponState vmethod_5()
		{
			ActiveUnit._ActiveUnitWeaponState result;
			if (this.activeUnit_0.vmethod_51().Count == 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else
			{
				try
				{
					Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (ActiveUnit_Weaponry._Closure$__.$I34-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I34-0 = new Func<Mount, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_1)) : ActiveUnit_Weaponry._Closure$__.$I34-0));
					if (this.activeUnit_0.vmethod_51().Count == 0)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100295", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000BE2E4 File Offset: 0x000BC4E4
		public Doctrine.Enum52 method_8(Contact_Base.ContactType contactType_0)
		{
			switch (contactType_0)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
			case Contact_Base.ContactType.Decoy_Air:
				return this.activeUnit_0.doctrine_0.method_63(this.activeUnit_0.scenario_0, false, null, false, false).Value;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.Decoy_Surface:
			case Contact_Base.ContactType.ActivationPoint:
				return this.activeUnit_0.doctrine_0.method_68(this.activeUnit_0.scenario_0, false, null, false, false).Value;
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Torpedo:
			case Contact_Base.ContactType.Decoy_Sub:
				return this.activeUnit_0.doctrine_0.method_73(this.activeUnit_0.scenario_0, false, null, false, false).Value;
			case Contact_Base.ContactType.Aimpoint:
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
			case Contact_Base.ContactType.Decoy_Land:
			case Contact_Base.ContactType.Installation:
			case Contact_Base.ContactType.AirBase:
			case Contact_Base.ContactType.NavalBase:
			case Contact_Base.ContactType.MobileGroup:
				return this.activeUnit_0.doctrine_0.method_78(this.activeUnit_0.scenario_0, false, null, false, false).Value;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000BE434 File Offset: 0x000BC634
		public virtual void vmethod_6(float float_0)
		{
			if (this.activeUnit_0.vmethod_7(false).class316_0.Length != 0)
			{
				bool flag = false;
				Dictionary<string, Class316> dictionary = new Dictionary<string, Class316>();
				List<Class316> list = new List<Class316>();
				try
				{
					this.bool_0 = false;
					List<Class316> list2 = new List<Class316>(Enumerable.Count<Class316>(this.activeUnit_0.vmethod_7(false).class316_0));
					foreach (Class316 @class in this.activeUnit_0.vmethod_7(false).class316_0)
					{
						if (Information.IsNothing(@class))
						{
							list.Add(@class);
						}
						else if (@class.class273_0.Length == 0)
						{
							if (@class.method_8() == 0 && @class.method_9() == 0)
							{
								list.Add(@class);
							}
						}
						else
						{
							list2.Add(@class);
						}
					}
					if (list.Count > 0)
					{
						try
						{
							foreach (Class316 class316_2 in list)
							{
								Class429.smethod_43(ref this.activeUnit_0.vmethod_7(false).class316_0, class316_2);
							}
						}
						finally
						{
							List<Class316>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						list.Clear();
					}
					Dictionary<Contact_Base.ContactType, Doctrine.Enum52> dictionary2 = new Dictionary<Contact_Base.ContactType, Doctrine.Enum52>();
					try
					{
						List<Class316>.Enumerator enumerator2 = list2.GetEnumerator();
						IL_11D:
						while (enumerator2.MoveNext())
						{
							Class316 class2 = enumerator2.Current;
							Doctrine.Enum52 @enum;
							if (!dictionary2.TryGetValue(class2.contact_0.contactType_0, out @enum))
							{
								@enum = this.method_8(class2.contact_0.contactType_0);
								dictionary2.Add(class2.contact_0.contactType_0, @enum);
							}
							Class316.Class273 class3 = null;
							Class316.Class273[] array = new Class316.Class273[class2.class273_0.Length - 1 + 1];
							int num = array.Length - 1;
							for (int j = 0; j <= num; j++)
							{
								array[j] = class2.class273_0[j];
							}
							Class316.Class273[] array2 = array;
							int k = 0;
							while (k < array2.Length)
							{
								Class316.Class273 class4 = array2[k];
								if (string.CompareOrdinal(this.activeUnit_0.string_0, class4.string_0) != 0)
								{
									checked
									{
										k++;
									}
								}
								else
								{
									class3 = class4;
									IL_1EC:
									if (Information.IsNothing(class3))
									{
										goto IL_11D;
									}
									if (class3.int_3 >= 40 && !class2.bool_12)
									{
										if (Class570.class280_0.method_44())
										{
											if (!dictionary.ContainsKey(class3.string_0))
											{
												dictionary.Add(class3.string_0, class2);
												goto IL_11D;
											}
											goto IL_11D;
										}
									}
									else if (Enumerable.Count<string>(class2.string_2) == 0)
									{
										if (!class3.bool_0)
										{
											class3.int_3 = 1;
										}
										else
										{
											Class316.Class273 class5 = class3;
											ref int ptr = ref class5.int_3;
											class5.int_3 = ptr + 1;
										}
									}
									else
									{
										class3.int_3 = 0;
									}
									if (!class2.bool_12 && @enum == Doctrine.Enum52.const_2)
									{
										Side side = this.activeUnit_0.vmethod_7(false);
										ActiveUnit activeUnit = this.activeUnit_0;
										Contact contact = null;
										side.method_83(ref activeUnit.scenario_0, ref this.activeUnit_0, ref contact, ref class2);
										goto IL_11D;
									}
									if (!class2.bool_12 && class3.int_0 == 0 && class3.int_1 == 0)
									{
										list.Add(class2);
										goto IL_11D;
									}
									int num2 = class3.int_0 - class3.int_1;
									if (num2 <= 0)
									{
										this.activeUnit_0.vmethod_7(false).method_89(ref this.activeUnit_0.scenario_0, class2);
										goto IL_11D;
									}
									if (class2.contact_0.method_108())
									{
										Contact.Enum47? enum2 = class2.contact_0.method_74(this.activeUnit_0.vmethod_7(false));
										byte? b = (enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null;
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
										{
											Side side2 = this.activeUnit_0.vmethod_7(false);
											ActiveUnit activeUnit2 = this.activeUnit_0;
											Contact contact = null;
											side2.method_83(ref activeUnit2.scenario_0, ref this.activeUnit_0, ref contact, ref class2);
											goto IL_11D;
										}
									}
									if (!class2.bool_11 && (class2.contact_0.bool_8 || class2.contact_0.bool_6 || class2.contact_0.bool_5))
									{
										this.bool_0 = true;
									}
									if (class3.int_2 > 1)
									{
										class3.int_2--;
										goto IL_11D;
									}
									short? num3;
									if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
									{
										WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
										IEnumerable<WeaponRec> enumerable;
										checked
										{
											for (int l = 0; l < weaponRec_.Length; l++)
											{
												weaponRec_[l].method_12(this.activeUnit_0.scenario_0).vmethod_10(this.activeUnit_0.vmethod_9());
											}
											enumerable = Enumerable.Select(Enumerable.GroupBy(Enumerable.OrderByDescending<WeaponRec, int>(((Aircraft)this.activeUnit_0).method_167().weaponRec_0, (ActiveUnit_Weaponry._Closure$__.$I37-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I37-0 = new Func<WeaponRec, int>(ActiveUnit_Weaponry._Closure$__.$I.method_2)) : ActiveUnit_Weaponry._Closure$__.$I37-0), (ActiveUnit_Weaponry._Closure$__.$I37-1 == null) ? (ActiveUnit_Weaponry._Closure$__.$I37-1 = new Func<WeaponRec, int>(ActiveUnit_Weaponry._Closure$__.$I.method_3)) : ActiveUnit_Weaponry._Closure$__.$I37-1, (ActiveUnit_Weaponry._Closure$__.$I37-2 == null) ? (ActiveUnit_Weaponry._Closure$__.$I37-2 = new Func<int, IEnumerable<WeaponRec>, VB$AnonymousType_0<int, IEnumerable<WeaponRec>>>(ActiveUnit_Weaponry._Closure$__.$I.method_4)) : ActiveUnit_Weaponry._Closure$__.$I37-2), (ActiveUnit_Weaponry._Closure$__.$I37-3 == null) ? (ActiveUnit_Weaponry._Closure$__.$I37-3 = new Func<VB$AnonymousType_0<int, IEnumerable<WeaponRec>>, WeaponRec>(ActiveUnit_Weaponry._Closure$__.$I.method_5)) : ActiveUnit_Weaponry._Closure$__.$I37-3);
										}
										try
										{
											foreach (WeaponRec weaponRec in enumerable)
											{
												Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
												if ((!weapon.method_0() || this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse) && class2.int_0 == weaponRec.int_5)
												{
													if (weaponRec.method_9() == 0)
													{
														if (this.activeUnit_0.vmethod_89().method_5(weapon.DBID, false) > 0)
														{
															class3.bool_0 = false;
														}
														else
														{
															class3.bool_0 = true;
														}
													}
													else if (weaponRec.float_0 != 0f)
													{
														class3.bool_0 = false;
													}
													else
													{
														class3.bool_0 = true;
														if (class3.int_3 <= 1 && !class2.bool_12)
														{
															bool flag2 = class3.int_1 == 0;
														}
														ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
														Weapon theWeapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
														Contact contact_ = class2.contact_0;
														bool bool_ = class2.bool_12;
														bool ignoreAircraftOrientation = false;
														Mount theMount = null;
														Sensor sensor = null;
														if (activeUnit_Weaponry.method_23(theWeapon, contact_, ref num3, bool_, ignoreAircraftOrientation, theMount, ref sensor).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
														{
															int num4 = 0;
															this.activeUnit_0.vmethod_89().method_43(float_0, ref weaponRec, class2.contact_0, ref num4, num2, 0f, ActiveUnit.Throttle.Flank, null, Class568.Enum154.const_0, 0L, ref class2);
															class3.int_1 += num4;
															if (num4 == 0)
															{
																flag = true;
															}
															if (num4 > 0 && !class2.bool_11)
															{
																return;
															}
														}
													}
												}
											}
										}
										finally
										{
											IEnumerator<WeaponRec> enumerator3;
											if (enumerator3 != null)
											{
												enumerator3.Dispose();
											}
										}
									}
									try
									{
										if (!flag)
										{
											try
											{
												foreach (Mount mount in this.activeUnit_0.vmethod_51())
												{
													if (Operators.CompareString(class3.string_1, "", false) == 0 || Operators.CompareString(mount.string_0, class3.string_1, false) == 0)
													{
														try
														{
															foreach (WeaponRec weaponRec2 in mount.vmethod_10())
															{
																if (class2.int_0 == weaponRec2.int_5 && weaponRec2.method_9() != 0)
																{
																	if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
																	{
																		if (mount.method_28() == 0f)
																		{
																			if (mount.method_32().method_24() == 0f)
																			{
																				if (weaponRec2.float_0 != 0f || (weaponRec2.method_12(this.activeUnit_0.scenario_0).method_0() && !this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse))
																				{
																					continue;
																				}
																				class3.bool_0 = true;
																				if (class3.int_3 <= 1 && !class2.bool_12)
																				{
																					bool flag3 = class3.int_1 == 0;
																				}
																				ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
																				Weapon theWeapon2 = weaponRec2.method_12(this.activeUnit_0.scenario_0);
																				Contact contact_2 = class2.contact_0;
																				bool bool_2 = class2.bool_12;
																				bool ignoreAircraftOrientation2 = false;
																				Mount theMount2 = mount;
																				Sensor sensor = null;
																				if (activeUnit_Weaponry2.method_23(theWeapon2, contact_2, ref num3, bool_2, ignoreAircraftOrientation2, theMount2, ref sensor).Item2 != ActiveUnit_Weaponry.Enum36.const_0)
																				{
																					continue;
																				}
																				int num5;
																				this.activeUnit_0.vmethod_89().method_43(float_0, ref weaponRec2, class2.contact_0, ref num5, num2, 0f, ActiveUnit.Throttle.Flank, mount, Class568.Enum154.const_0, 0L, ref class2);
																				if (!Information.IsNothing(weaponRec2.mount_0))
																				{
																					weaponRec2.mount_0.method_29((float)weaponRec2.mount_0.int_0);
																				}
																				class3.int_1 += num5;
																				if (num5 == 0)
																				{
																					flag = true;
																				}
																				if (num5 > 0)
																				{
																					if (weaponRec2.method_9() != 0)
																					{
																						goto IL_8F0;
																					}
																					Mount mount2 = mount;
																					int num6 = 0;
																					int num7 = 0;
																					if (mount2.method_35(ref num6, ref num7) != 0)
																					{
																						goto IL_8F0;
																					}
																					mount.method_31(0f);
																					IL_912:
																					if (!class2.bool_12 && mount.bool_15 && weaponRec2.method_9() == 0 && class2.contact_0.method_103())
																					{
																						Side side3 = this.activeUnit_0.vmethod_7(false);
																						ActiveUnit activeUnit3 = this.activeUnit_0;
																						Contact contact = null;
																						side3.method_83(ref activeUnit3.scenario_0, ref this.activeUnit_0, ref contact, ref class2);
																						return;
																					}
																					if (class2.bool_11)
																					{
																						goto IL_944;
																					}
																					num2 = class3.int_0 - class3.int_1;
																					if (num2 > 0)
																					{
																						if (weaponRec2.method_9() == 0)
																						{
																							class3.string_1 = "";
																							class3.int_2 = (int)Math.Round((double)weaponRec2.float_0);
																						}
																						else
																						{
																							class3.string_1 = mount.string_0;
																							class3.int_2 = (int)Math.Round((double)weaponRec2.float_0);
																						}
																					}
																					else
																					{
																						class3.string_1 = mount.string_0;
																						class3.int_2 = 0;
																					}
																					return;
																					IL_8F0:
																					if (mount.method_30() < 300f)
																					{
																						mount.method_31(mount.method_28() + 300f);
																						goto IL_912;
																					}
																					goto IL_912;
																				}
																				IL_944:
																				num2 = class3.int_0 - class3.int_1;
																				if (num2 > 0)
																				{
																					continue;
																				}
																				break;
																			}
																		}
																		class3.bool_0 = false;
																	}
																	break;
																}
															}
														}
														finally
														{
															List<WeaponRec>.Enumerator enumerator5;
															((IDisposable)enumerator5).Dispose();
														}
														if (num2 <= 0)
														{
															break;
														}
													}
												}
											}
											finally
											{
												List<Mount>.Enumerator enumerator4;
												((IDisposable)enumerator4).Dispose();
											}
										}
										goto IL_AC2;
									}
									catch (Exception ex)
									{
										ex.Data.Add("Error at 101210", "");
										GameGeneral.smethod_25(ref ex);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										goto IL_AC2;
									}
									IL_A91:
									if (flag && class3.int_3 == 1 && Enumerable.Count<string>(class2.string_2) == 0)
									{
										list.Add(class2);
										goto IL_11D;
									}
									goto IL_11D;
									IL_AC2:
									if (!class2.bool_12)
									{
										goto IL_A91;
									}
									goto IL_11D;
								}
							}
							goto IL_1EC;
						}
					}
					finally
					{
						List<Class316>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					try
					{
						foreach (KeyValuePair<string, Class316> keyValuePair in dictionary)
						{
							Side side4 = this.activeUnit_0.vmethod_7(false);
							ActiveUnit activeUnit4 = this.activeUnit_0;
							string key = keyValuePair.Key;
							Class316 value = keyValuePair.Value;
							side4.method_88(ref activeUnit4.scenario_0, key, ref value);
						}
					}
					finally
					{
						Dictionary<string, Class316>.Enumerator enumerator6;
						((IDisposable)enumerator6).Dispose();
					}
					if (list.Count > 0)
					{
						try
						{
							foreach (Class316 class316_3 in list)
							{
								Class429.smethod_43(ref this.activeUnit_0.vmethod_7(false).class316_0, class316_3);
							}
						}
						finally
						{
							List<Class316>.Enumerator enumerator7;
							((IDisposable)enumerator7).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 200578", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000BF0E4 File Offset: 0x000BD2E4
		private bool method_9(Weapon weapon_6, Contact contact_0)
		{
			bool flag = false;
			bool result;
			try
			{
				Weapon._WeaponType weaponType = weapon_6.method_167();
				float num;
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					num = 40f;
					if (weapon_6.struct36_0.bool_7)
					{
						num += 20f;
					}
					if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).bool_38)
					{
						num += 30f;
					}
					if (this.activeUnit_0.bool_3)
					{
						flag = true;
						goto IL_10B;
					}
					goto IL_10B;
				case Weapon._WeaponType.Rocket:
					num = 30f;
					goto IL_10B;
				case Weapon._WeaponType.IronBomb:
					break;
				case Weapon._WeaponType.Gun:
					num = 8f;
					if (this.activeUnit_0.bool_3)
					{
						flag = true;
						goto IL_10B;
					}
					goto IL_10B;
				case Weapon._WeaponType.Decoy_Expendable:
				case Weapon._WeaponType.Decoy_Towed:
					goto IL_FD;
				case Weapon._WeaponType.Decoy_Vehicle:
					num = 135f;
					goto IL_10B;
				default:
					switch (weaponType)
					{
					case Weapon._WeaponType.Torpedo:
						num = 90f;
						goto IL_10B;
					case Weapon._WeaponType.DepthCharge:
						num = 20f;
						goto IL_10B;
					case Weapon._WeaponType.Sonobuoy:
						num = 4f;
						goto IL_10B;
					case Weapon._WeaponType.BottomMine:
					case Weapon._WeaponType.MooredMine:
					case Weapon._WeaponType.FloatingMine:
					case Weapon._WeaponType.MovingMine:
					case Weapon._WeaponType.RisingMine:
						break;
					default:
						goto IL_FD;
					}
					break;
				}
				num = 30f;
				goto IL_10B;
				IL_FD:
				num = 20f;
				IL_10B:
				if (flag)
				{
					result = (Math.Abs(contact_0.method_47(this.activeUnit_0)) < num);
				}
				else
				{
					result = (Math.Abs(contact_0.method_46(this.activeUnit_0, true)) < num);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100298", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000BF284 File Offset: 0x000BD484
		public bool method_10(Contact contact_0, bool bool_9, bool bool_10)
		{
			checked
			{
				short? num;
				if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
				{
					WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
					for (int i = 0; i < weaponRec_.Length; i++)
					{
						weaponRec_[i].method_12(this.activeUnit_0.scenario_0).vmethod_10(this.activeUnit_0.vmethod_9());
					}
					foreach (WeaponRec weaponRec in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
					{
						if (weaponRec.method_9() != 0 && (bool_10 || weaponRec.float_0 <= 0f))
						{
							ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
							Weapon theWeapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
							bool manualFire = false;
							Mount theMount = null;
							Sensor sensor = null;
							if (activeUnit_Weaponry.method_23(theWeapon, contact_0, ref num, manualFire, bool_9, theMount, ref sensor).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
							{
								return true;
							}
						}
					}
				}
				try
				{
					foreach (Mount mount in this.activeUnit_0.vmethod_51())
					{
						try
						{
							foreach (WeaponRec weaponRec2 in mount.vmethod_10())
							{
								if (weaponRec2.method_9() != 0 && (bool_10 || weaponRec2.float_0 <= 0f))
								{
									ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
									Weapon theWeapon2 = weaponRec2.method_12(this.activeUnit_0.scenario_0);
									bool manualFire2 = false;
									Mount theMount2 = mount;
									Sensor sensor = null;
									if (activeUnit_Weaponry2.method_23(theWeapon2, contact_0, ref num, manualFire2, bool_9, theMount2, ref sensor).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
									{
										return true;
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return false;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000BF46C File Offset: 0x000BD66C
		public bool method_11(Contact contact_0, int int_0, int int_1, bool bool_9, ref Doctrine._GunStrafeGroundTargets? nullable_0, DateTime dateTime_0)
		{
			ActiveUnit_Weaponry.Class230 @class = new ActiveUnit_Weaponry.Class230(@class);
			@class.activeUnit_Weaponry_0 = this;
			@class.contact_0 = contact_0;
			if (!bool_9)
			{
				if (this.method_8(@class.contact_0.contactType_0) == Doctrine.Enum52.const_2)
				{
					return false;
				}
			}
			else
			{
				this.activeUnit_0.vmethod_86().method_53(ref @class.contact_0, bool_9);
			}
			bool? flag = null;
			bool result2;
			try
			{
				switch (@class.contact_0.contactType_0)
				{
				case Contact_Base.ContactType.Surface:
				case Contact_Base.ContactType.Submarine:
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
					if (this.bool_0)
					{
						return false;
					}
					break;
				case Contact_Base.ContactType.Decoy_Air:
					if (this.bool_0)
					{
						return false;
					}
					break;
				case Contact_Base.ContactType.Decoy_Surface:
				case Contact_Base.ContactType.Decoy_Land:
				case Contact_Base.ContactType.Decoy_Sub:
					return false;
				}
				if (@class.contact_0.method_74(this.activeUnit_0.vmethod_7(false)) != null)
				{
					Contact.Enum47? @enum = @class.contact_0.method_74(this.activeUnit_0.vmethod_7(false));
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 4) : null).GetValueOrDefault())
					{
						return false;
					}
				}
				List<Class316> list = this.activeUnit_0.vmethod_7(false).method_73(@class.contact_0);
				bool flag2 = false;
				bool flag3 = false;
				if (!bool_9)
				{
					try
					{
						foreach (Class316 class2 in list)
						{
							if (class2.contact_0 == @class.contact_0)
							{
								List<Class316.Class273> list2 = Enumerable.ToList<Class316.Class273>(class2.class273_0);
								try
								{
									List<Class316.Class273>.Enumerator enumerator2 = list2.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										if (Operators.CompareString(enumerator2.Current.string_0, this.activeUnit_0.string_0, false) == 0)
										{
											if (this.activeUnit_0.bool_3)
											{
												return false;
											}
											flag3 = true;
										}
									}
								}
								finally
								{
									List<Class316.Class273>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								if (!class2.bool_11)
								{
									flag2 = true;
								}
							}
						}
						goto IL_2E3;
					}
					finally
					{
						List<Class316>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				Class316 class4;
				try
				{
					foreach (Class316 class3 in list)
					{
						if (class3.contact_0 == @class.contact_0 && int_0 == class3.int_0)
						{
							List<Class316.Class273> list3 = Enumerable.ToList<Class316.Class273>(class3.class273_0);
							try
							{
								List<Class316.Class273>.Enumerator enumerator4 = list3.GetEnumerator();
								while (enumerator4.MoveNext())
								{
									if (Operators.CompareString(enumerator4.Current.string_0, this.activeUnit_0.string_0, false) == 0)
									{
										class4 = class3;
										break;
									}
								}
							}
							finally
							{
								List<Class316.Class273>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
						}
						if (!Information.IsNothing(class4))
						{
							break;
						}
					}
				}
				finally
				{
					List<Class316>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				IL_2E3:
				Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = Doctrine.smethod_7(ref @class.contact_0);
				Dictionary<int, ActiveUnit_Weaponry.Class229> dictionary = new Dictionary<int, ActiveUnit_Weaponry.Class229>();
				WeaponRec weaponRec = null;
				float? num = null;
				float? num2 = null;
				float? num3 = null;
				bool result = true;
				bool flag4 = false;
				List<WeaponRec> list4 = new List<WeaponRec>();
				try
				{
					int? num7;
					float? num11;
					int? num13;
					short? num16;
					if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
					{
						foreach (WeaponRec weaponRec2 in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
						{
							WeaponRec weaponRec2;
							weaponRec2.method_12(this.activeUnit_0.scenario_0).vmethod_10(this.activeUnit_0.vmethod_9());
						}
						WeaponRec[] weaponRec_2 = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
						int j = 0;
						while (j < weaponRec_2.Length)
						{
							WeaponRec weaponRec2 = weaponRec_2[j];
							if (!Information.IsNothing(class4))
							{
								if (weaponRec2.int_5 == class4.int_0)
								{
									goto IL_3F1;
								}
							}
							else if (!bool_9 || weaponRec2.int_5 == int_0)
							{
								goto IL_3F1;
							}
							IL_CF9:
							checked
							{
								j++;
								continue;
								IL_3F1:
								weaponRec2.mount_0 = null;
							}
							if (!bool_9)
							{
								if (weaponRec2.method_9() == 0 || weaponRec2.float_0 > 0f)
								{
									goto IL_CF9;
								}
								if (dictionary.ContainsKey(weaponRec2.int_5))
								{
									int? num4 = dictionary[weaponRec2.int_5].nullable_1;
									if (!Information.IsNothing(num4))
									{
										int? num5 = num4;
										int k = weaponRec2.method_9();
										if (num5 == null)
										{
											int? num6 = null;
										}
										else
										{
											new int?(num5.GetValueOrDefault() + k);
										}
										goto IL_CF9;
									}
									num4 = new int?(weaponRec2.method_9());
									goto IL_CF9;
								}
								else
								{
									num7 = new int?(weaponRec2.method_9());
									if (dictionary.ContainsKey(weaponRec2.int_5))
									{
										int? num8 = dictionary[weaponRec2.int_5].nullable_1;
										if (!Information.IsNothing(num8))
										{
											int? num9;
											if (!(num8 != null & num7 != null))
											{
												int? num5 = null;
												num9 = num5;
											}
											else
											{
												num9 = new int?(num8.GetValueOrDefault() + num7.GetValueOrDefault());
											}
											num8 = num9;
										}
										else
										{
											num8 = num7;
										}
										dictionary[weaponRec2.int_5].nullable_1 = num8;
										goto IL_CF9;
									}
									if (!Information.IsNothing(class4))
									{
										goto IL_CF9;
									}
									Weapon weapon = weaponRec2.method_12(this.activeUnit_0.scenario_0);
									if (weapon.method_167() == Weapon._WeaponType.Gun && @class.contact_0.method_134())
									{
										if (nullable_0 == null)
										{
											nullable_0 = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
										}
										Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = nullable_0;
										byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
										if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											goto IL_CF9;
										}
									}
									if (!weapon.method_253(this.activeUnit_0.scenario_0, ref @class.contact_0, ref flag))
									{
										goto IL_CF9;
									}
									float num10 = this.method_19(ref this.activeUnit_0, ref weapon, ref @class.contact_0, false);
									if (weapon.method_167() == Weapon._WeaponType.Gun && Information.IsNothing(num2))
									{
										num2 = new float?(this.activeUnit_0.method_37(@class.contact_0, 0f));
									}
									else if (Information.IsNothing(num))
									{
										num11 = new float?(this.activeUnit_0.method_36(@class.contact_0));
										num = num11;
									}
									float? num12;
									if (weapon.method_167() == Weapon._WeaponType.Gun)
									{
										num12 = num2;
										if (((num12 != null) ? new bool?(num12.GetValueOrDefault() > num10) : null).GetValueOrDefault())
										{
											goto IL_CF9;
										}
									}
									num12 = num;
									if (((num12 != null) ? new bool?(num12.GetValueOrDefault() > num10) : null).GetValueOrDefault())
									{
										goto IL_CF9;
									}
									if (weapon.method_167() == Weapon._WeaponType.Gun)
									{
										num3 = num2;
									}
									else
									{
										num3 = num;
									}
									if (this.activeUnit_0.doctrine_0.method_239(ref weapon))
									{
										Doctrine._WRA_WeaponTargetType wra_WeaponTargetType2 = Doctrine.smethod_6(ref weapon, ref @class.contact_0, ref wra_WeaponTargetType);
										Doctrine doctrine_ = this.activeUnit_0.doctrine_0;
										Scenario scenario_ = this.activeUnit_0.scenario_0;
										Weapon theWeapon = weapon;
										Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wra_WeaponTargetType2;
										bool findInheritedValuesOnly = false;
										int? num5 = null;
										int? num6 = null;
										num13 = doctrine_.method_9(scenario_, theWeapon, selectedNodeTargetType, findInheritedValuesOnly, ref num5, ref num6);
										num6 = num13;
										if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											goto IL_CF9;
										}
										num6 = num13;
										if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == -99) : null).GetValueOrDefault())
										{
											num13 = new int?(int.MaxValue);
										}
										Doctrine doctrine_2 = this.activeUnit_0.doctrine_0;
										Scenario scenario_2 = this.activeUnit_0.scenario_0;
										int dbid = weapon.DBID;
										Doctrine._WRA_WeaponTargetType selectedNodeTargetType2 = wra_WeaponTargetType2;
										bool findInheritedValuesOnly2 = false;
										num6 = null;
										num5 = null;
										int? num14 = doctrine_2.method_23(scenario_2, dbid, selectedNodeTargetType2, findInheritedValuesOnly2, ref num6, ref num5);
										if (Information.IsNothing(num14))
										{
											num14 = new int?(-99);
										}
										num5 = num14;
										if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
										{
											goto IL_CF9;
										}
										num5 = num14;
										bool? flag5 = (num5 != null) ? new bool?(num5.GetValueOrDefault() == -99) : null;
										bool? flag6 = flag5 = ((flag5 != null) ? new bool?(!flag5.GetValueOrDefault()) : flag5);
										bool? flag7;
										if (flag5 != null && !flag6.GetValueOrDefault())
										{
											flag7 = new bool?(false);
										}
										else
										{
											num12 = ((num14 != null) ? new float?((float)num14.GetValueOrDefault()) : null);
											flag5 = ((num12 != null & num3 != null) ? new bool?(num12.GetValueOrDefault() < num3.GetValueOrDefault()) : null);
											flag7 = (flag6 & flag5.GetValueOrDefault());
										}
										flag6 = flag7;
										if (flag6.GetValueOrDefault())
										{
											goto IL_CF9;
										}
										if (list.Count > 0)
										{
											if (@class.contact_0.method_103())
											{
												bool flag8 = false;
												try
												{
													List<Class316>.Enumerator enumerator5 = list.GetEnumerator();
													while (enumerator5.MoveNext())
													{
														if (enumerator5.Current.int_0 == weapon.DBID)
														{
															flag8 = true;
															break;
														}
													}
												}
												finally
												{
													List<Class316>.Enumerator enumerator5;
													((IDisposable)enumerator5).Dispose();
												}
												if (flag8)
												{
													goto IL_CF9;
												}
											}
											Doctrine doctrine_3 = this.activeUnit_0.doctrine_0;
											Scenario scenario_3 = this.activeUnit_0.scenario_0;
											Weapon theWeapon2 = weapon;
											Doctrine._WRA_WeaponTargetType selectedNodeTargetType3 = wra_WeaponTargetType2;
											bool findInheritedValuesOnly3 = false;
											num5 = null;
											num6 = null;
											int? num15 = doctrine_3.method_18(scenario_3, theWeapon2, selectedNodeTargetType3, findInheritedValuesOnly3, ref num5, ref num6);
											num6 = num15;
											if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == -99) : null).GetValueOrDefault())
											{
												num15 = new int?((int)Math.Round((double)num10));
											}
											num6 = num15;
											bool? flag10;
											if (!((num6 != null) ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
											{
												num6 = num15;
												bool? flag9;
												flag6 = (flag9 = ((num6 != null) ? new bool?(num6.GetValueOrDefault() > 0) : null));
												if (flag9 != null && !flag6.GetValueOrDefault())
												{
													flag10 = new bool?(false);
												}
												else
												{
													num12 = ((num15 != null) ? new float?((float)num15.GetValueOrDefault()) : null);
													flag5 = (flag9 = ((num12 != null & num3 != null) ? new bool?(num12.GetValueOrDefault() < num3.GetValueOrDefault()) : null));
													flag10 = ((flag9 != null) ? (flag6 & flag5.GetValueOrDefault()) : null);
												}
											}
											else
											{
												flag10 = new bool?(true);
											}
											flag5 = flag10;
											if (flag5.GetValueOrDefault())
											{
												bool flag11 = false;
												try
												{
													foreach (Class316 class5 in list)
													{
														if (class5.int_0 == weapon.DBID && class5.class273_0.Length < class5.int_1 && (class5.int_2 == 2147483647 || class5.int_2 > class5.method_8()))
														{
															flag11 = true;
															break;
														}
													}
												}
												finally
												{
													List<Class316>.Enumerator enumerator6;
													((IDisposable)enumerator6).Dispose();
												}
												if (!flag11)
												{
													goto IL_CF9;
												}
											}
										}
									}
									checked
									{
										if (list.Count > 0)
										{
											bool flag12 = false;
											try
											{
												foreach (Class316 class6 in list)
												{
													if (class6.int_0 == weapon.DBID)
													{
														if (class6.method_8() >= class6.int_2 && class6.int_2 != 2147483647)
														{
															flag12 = true;
														}
														if (!flag12)
														{
															Class316.Class273[] class273_ = class6.class273_0;
															for (int k = 0; k < class273_.Length; k++)
															{
																if (Operators.CompareString(class273_[k].string_0, this.activeUnit_0.string_0, false) == 0)
																{
																	flag12 = true;
																	break;
																}
															}
														}
														if (!flag12 && class6.class273_0.Length < class6.int_1)
														{
															class4 = class6;
															break;
														}
													}
												}
											}
											finally
											{
												List<Class316>.Enumerator enumerator7;
												((IDisposable)enumerator7).Dispose();
											}
											if (flag12)
											{
												goto IL_CF9;
											}
										}
										ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
										Weapon theWeapon3 = weapon;
										Contact contact_ = @class.contact_0;
										bool ignoreAircraftOrientation = false;
										Mount theMount = null;
										Sensor sensor = null;
										if (activeUnit_Weaponry.method_23(theWeapon3, contact_, ref num16, bool_9, ignoreAircraftOrientation, theMount, ref sensor).Item2 != ActiveUnit_Weaponry.Enum36.const_0)
										{
											goto IL_CF9;
										}
									}
								}
							}
							list4.Add(weaponRec2);
							if (!bool_9)
							{
								ActiveUnit_Weaponry.Class229 value = new ActiveUnit_Weaponry.Class229(num13, num7);
								dictionary.Add(weaponRec2.int_5, value);
								goto IL_CF9;
							}
							break;
						}
					}
					if (list4.Count == 0)
					{
						try
						{
							foreach (Mount mount in this.activeUnit_0.vmethod_51())
							{
								if (bool_9 || (mount.method_28() == 0f && mount.method_32().method_24() == 0f))
								{
									try
									{
										foreach (WeaponRec weaponRec2 in mount.vmethod_10())
										{
											if (!Information.IsNothing(class4))
											{
												if (weaponRec2.int_5 != class4.int_0)
												{
													continue;
												}
											}
											else if (bool_9 && weaponRec2.int_5 != int_0)
											{
												continue;
											}
											weaponRec2.mount_0 = mount;
											if (!bool_9)
											{
												if (mount.vmethod_5() != PlatformComponent._ComponentStatus.Operational || weaponRec2.float_0 != 0f || weaponRec2.method_9() == 0)
												{
													continue;
												}
												num7 = new int?(weaponRec2.method_9());
												int? num6;
												if (mount.method_32().vmethod_10().Count > 0)
												{
													bool flag13 = false;
													if (mount.method_32().vmethod_10().Count > 1)
													{
														try
														{
															List<WeaponRec>.Enumerator enumerator10 = mount.vmethod_10().GetEnumerator();
															while (enumerator10.MoveNext())
															{
																if (enumerator10.Current.method_11(mount))
																{
																	flag13 = true;
																	break;
																}
															}
														}
														finally
														{
															List<WeaponRec>.Enumerator enumerator10;
															((IDisposable)enumerator10).Dispose();
														}
													}
													if (!flag13)
													{
														num6 = num7;
														int l = this.method_34(mount, weaponRec2.int_5);
														int? num17;
														if (num6 == null)
														{
															int? num5 = null;
															num17 = num5;
														}
														else
														{
															num17 = new int?(num6.GetValueOrDefault() + l);
														}
														num7 = num17;
													}
												}
												num6 = num7;
												if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
												{
													continue;
												}
												if (dictionary.ContainsKey(weaponRec2.int_5))
												{
													int? num18 = dictionary[weaponRec2.int_5].nullable_1;
													if (!Information.IsNothing(num18))
													{
														int? num19;
														if (!(num18 != null & num7 != null))
														{
															num6 = null;
															num19 = num6;
														}
														else
														{
															num19 = new int?(num18.GetValueOrDefault() + num7.GetValueOrDefault());
														}
														num18 = num19;
													}
													else
													{
														num18 = num7;
													}
													dictionary[weaponRec2.int_5].nullable_1 = num18;
													continue;
												}
												if (!Information.IsNothing(class4))
												{
													continue;
												}
												Weapon weapon2 = weaponRec2.method_12(this.activeUnit_0.scenario_0);
												if (this.activeUnit_0.bool_3 && weapon2.method_167() == Weapon._WeaponType.Gun && @class.contact_0.method_134())
												{
													if (Information.IsNothing(nullable_0))
													{
														nullable_0 = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
													}
													Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = nullable_0;
													byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
													if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
													{
														continue;
													}
												}
												if (!weapon2.method_253(this.activeUnit_0.scenario_0, ref @class.contact_0, ref flag))
												{
													continue;
												}
												float num20 = this.method_19(ref this.activeUnit_0, ref weapon2, ref @class.contact_0, false);
												if (weapon2.method_167() == Weapon._WeaponType.Gun && Information.IsNothing(num2))
												{
													num2 = new float?(this.activeUnit_0.method_37(@class.contact_0, 0f));
												}
												else if (Information.IsNothing(num))
												{
													if (num11 == null)
													{
														num11 = new float?(this.activeUnit_0.method_36(@class.contact_0));
													}
													num = num11;
												}
												float? num12;
												if (weapon2.method_167() == Weapon._WeaponType.Gun)
												{
													num12 = num2;
													if (((num12 != null) ? new bool?(num12.GetValueOrDefault() > num20) : null).GetValueOrDefault())
													{
														continue;
													}
												}
												num12 = num;
												if (((num12 != null) ? new bool?(num12.GetValueOrDefault() > num20) : null).GetValueOrDefault())
												{
													continue;
												}
												if (weapon2.method_167() == Weapon._WeaponType.Gun)
												{
													num3 = num2;
												}
												else
												{
													num3 = num;
												}
												if (this.activeUnit_0.doctrine_0.method_239(ref weapon2))
												{
													Doctrine._WRA_WeaponTargetType wra_WeaponTargetType2 = Doctrine.smethod_6(ref weapon2, ref @class.contact_0, ref wra_WeaponTargetType);
													Doctrine doctrine_4 = this.activeUnit_0.doctrine_0;
													Scenario scenario_4 = this.activeUnit_0.scenario_0;
													Weapon theWeapon4 = weapon2;
													Doctrine._WRA_WeaponTargetType selectedNodeTargetType4 = wra_WeaponTargetType2;
													bool findInheritedValuesOnly4 = false;
													num6 = null;
													int? num5 = null;
													num13 = doctrine_4.method_9(scenario_4, theWeapon4, selectedNodeTargetType4, findInheritedValuesOnly4, ref num6, ref num5);
													num5 = num13;
													if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
													{
														continue;
													}
													num5 = num13;
													if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -99) : null).GetValueOrDefault())
													{
														num13 = new int?(int.MaxValue);
													}
													Doctrine doctrine_5 = this.activeUnit_0.doctrine_0;
													Scenario scenario_5 = this.activeUnit_0.scenario_0;
													int dbid2 = weapon2.DBID;
													Doctrine._WRA_WeaponTargetType selectedNodeTargetType5 = wra_WeaponTargetType2;
													bool findInheritedValuesOnly5 = false;
													num5 = null;
													num6 = null;
													int? num14 = doctrine_5.method_23(scenario_5, dbid2, selectedNodeTargetType5, findInheritedValuesOnly5, ref num5, ref num6);
													if (num14 == null)
													{
														num14 = new int?(-99);
													}
													num6 = num14;
													if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == 0) : null).GetValueOrDefault())
													{
														continue;
													}
													num6 = num14;
													bool? flag6 = (num6 != null) ? new bool?(num6.GetValueOrDefault() == -99) : null;
													bool? flag5 = flag6 = ((flag6 != null) ? new bool?(!flag6.GetValueOrDefault()) : flag6);
													bool? flag14;
													if (flag6 != null && !flag5.GetValueOrDefault())
													{
														flag14 = new bool?(false);
													}
													else
													{
														num12 = ((num14 != null) ? new float?((float)num14.GetValueOrDefault()) : null);
														flag6 = ((num12 != null & num3 != null) ? new bool?(num12.GetValueOrDefault() < num3.GetValueOrDefault()) : null);
														flag14 = (flag5 & flag6.GetValueOrDefault());
													}
													flag5 = flag14;
													if (flag5.GetValueOrDefault())
													{
														continue;
													}
													if (list.Count > 0)
													{
														if (@class.contact_0.method_103())
														{
															bool flag15 = false;
															try
															{
																List<Class316>.Enumerator enumerator11 = list.GetEnumerator();
																while (enumerator11.MoveNext())
																{
																	if (enumerator11.Current.int_0 == weapon2.DBID)
																	{
																		flag15 = true;
																		break;
																	}
																}
															}
															finally
															{
																List<Class316>.Enumerator enumerator11;
																((IDisposable)enumerator11).Dispose();
															}
															if (flag15)
															{
																continue;
															}
														}
														Doctrine doctrine_6 = this.activeUnit_0.doctrine_0;
														Scenario scenario_6 = this.activeUnit_0.scenario_0;
														Weapon theWeapon5 = weapon2;
														Doctrine._WRA_WeaponTargetType selectedNodeTargetType6 = wra_WeaponTargetType2;
														bool findInheritedValuesOnly6 = false;
														num6 = null;
														num5 = null;
														int? num15 = doctrine_6.method_18(scenario_6, theWeapon5, selectedNodeTargetType6, findInheritedValuesOnly6, ref num6, ref num5);
														num5 = num15;
														if (((num5 != null) ? new bool?(num5.GetValueOrDefault() == -99) : null).GetValueOrDefault())
														{
															num15 = new int?((int)Math.Round((double)num20));
														}
														num5 = num15;
														bool? flag16;
														if (!((num5 != null) ? new bool?(num5.GetValueOrDefault() == 0) : null).GetValueOrDefault())
														{
															num5 = num15;
															bool? flag9;
															flag5 = (flag9 = ((num5 != null) ? new bool?(num5.GetValueOrDefault() > 0) : null));
															if (flag9 != null && !flag5.GetValueOrDefault())
															{
																flag16 = new bool?(false);
															}
															else
															{
																num12 = ((num15 != null) ? new float?((float)num15.GetValueOrDefault()) : null);
																flag6 = (flag9 = ((num12 != null & num3 != null) ? new bool?(num12.GetValueOrDefault() < num3.GetValueOrDefault()) : null));
																flag16 = ((flag9 != null) ? (flag5 & flag6.GetValueOrDefault()) : null);
															}
														}
														else
														{
															flag16 = new bool?(true);
														}
														flag6 = flag16;
														if (flag6.GetValueOrDefault())
														{
															if (flag2 || (!weapon2.method_0() && !weapon2.bool_7))
															{
																bool flag17 = false;
																try
																{
																	foreach (Class316 class7 in list)
																	{
																		if (class7.int_0 == weapon2.DBID && class7.class273_0.Length < class7.int_1 && (class7.int_2 == 2147483647 || class7.int_2 > class7.method_8()))
																		{
																			flag17 = true;
																			break;
																		}
																	}
																}
																finally
																{
																	List<Class316>.Enumerator enumerator12;
																	((IDisposable)enumerator12).Dispose();
																}
																if (!flag17)
																{
																	continue;
																}
															}
														}
														else if (flag3 && (weapon2.method_0() || weapon2.bool_7))
														{
															continue;
														}
													}
												}
												checked
												{
													if (list.Count > 0)
													{
														bool flag18 = false;
														try
														{
															foreach (Class316 class8 in list)
															{
																if (class8.int_0 == weapon2.DBID)
																{
																	if (class8.method_8() >= class8.int_2 && class8.int_2 != 2147483647)
																	{
																		flag18 = true;
																	}
																	if (!flag18)
																	{
																		Class316.Class273[] class273_2 = class8.class273_0;
																		for (int l = 0; l < class273_2.Length; l++)
																		{
																			if (Operators.CompareString(class273_2[l].string_0, this.activeUnit_0.string_0, false) == 0)
																			{
																				flag18 = true;
																				break;
																			}
																		}
																	}
																	if (!flag18 && class8.class273_0.Length < class8.int_1)
																	{
																		class4 = class8;
																		break;
																	}
																}
															}
														}
														finally
														{
															List<Class316>.Enumerator enumerator13;
															((IDisposable)enumerator13).Dispose();
														}
														if (flag18)
														{
															continue;
														}
													}
													ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
													Weapon theWeapon6 = weapon2;
													Contact contact_2 = @class.contact_0;
													bool ignoreAircraftOrientation2 = false;
													Mount theMount2 = mount;
													Sensor sensor = null;
													if (activeUnit_Weaponry2.method_23(theWeapon6, contact_2, ref num16, bool_9, ignoreAircraftOrientation2, theMount2, ref sensor).Item2 != ActiveUnit_Weaponry.Enum36.const_0)
													{
														continue;
													}
													if (!flag4 && weapon2.method_0() && (weapon2.struct36_0.bool_1 || weapon2.struct36_0.bool_0 || Enumerable.Count<CommDevice>(weapon2.vmethod_94()) > 0))
													{
														flag4 = true;
														result = true;
													}
													num12 = num3;
													if (((num12 != null) ? new bool?(num12.GetValueOrDefault() < 5f) : null).GetValueOrDefault() && !flag4)
													{
														result = false;
													}
												}
											}
											list4.Add(weaponRec2);
											if (bool_9)
											{
												break;
											}
											ActiveUnit_Weaponry.Class229 value2 = new ActiveUnit_Weaponry.Class229(num13, num7);
											dictionary.Add(weaponRec2.int_5, value2);
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator9;
										((IDisposable)enumerator9).Dispose();
									}
									if (bool_9 && list4.Count > 0)
									{
										break;
									}
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator8;
							((IDisposable)enumerator8).Dispose();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101238", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					if (!bool_9 && this.activeUnit_0.bool_3 && !Information.IsNothing(nullable_0))
					{
						Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = nullable_0;
						byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault() && list4.Count > 1 && @class.contact_0.method_134() && Enumerable.Count<Weapon>(Enumerable.Where<Weapon>(Enumerable.Select<Weapon, Weapon>(this.method_13(@class.contact_0, ref nullable_0), (ActiveUnit_Weaponry._Closure$__.$I41-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I41-0 = new Func<Weapon, Weapon>(ActiveUnit_Weaponry._Closure$__.$I.method_6)) : ActiveUnit_Weaponry._Closure$__.$I41-0), (ActiveUnit_Weaponry._Closure$__.$I41-1 == null) ? (ActiveUnit_Weaponry._Closure$__.$I41-1 = new Func<Weapon, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_7)) : ActiveUnit_Weaponry._Closure$__.$I41-1)) > 0)
						{
							List<WeaponRec> list5 = new List<WeaponRec>();
							list5.AddRange(list4);
							try
							{
								foreach (WeaponRec weaponRec3 in list5)
								{
									if (weaponRec3.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun)
									{
										list4.Remove(weaponRec3);
									}
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator14;
								((IDisposable)enumerator14).Dispose();
							}
						}
					}
					Weapon weapon3 = null;
					int? num21;
					if (list4.Count > 0)
					{
						if (!bool_9)
						{
							if (list4.Count > 1)
							{
								Enumerable.ThenBy<WeaponRec, float>(Enumerable.OrderByDescending<WeaponRec, int>(Enumerable.Select<WeaponRec, WeaponRec>(list4, (ActiveUnit_Weaponry._Closure$__.$I41-2 == null) ? (ActiveUnit_Weaponry._Closure$__.$I41-2 = new Func<WeaponRec, WeaponRec>(ActiveUnit_Weaponry._Closure$__.$I.method_8)) : ActiveUnit_Weaponry._Closure$__.$I41-2), new Func<WeaponRec, int>(@class.method_0)), new Func<WeaponRec, float>(@class.method_1));
								weaponRec = list4[0];
							}
							else
							{
								weaponRec = list4[0];
							}
							weapon3 = weaponRec.method_12(this.activeUnit_0.scenario_0);
							int? num6;
							if (Information.IsNothing(num21))
							{
								Doctrine._WRA_WeaponTargetType wra_WeaponTargetType2 = Doctrine.smethod_6(ref weapon3, ref @class.contact_0, ref wra_WeaponTargetType);
								Doctrine doctrine_7 = this.activeUnit_0.doctrine_0;
								Scenario scenario_7 = this.activeUnit_0.scenario_0;
								Weapon theWeapon7 = weapon3;
								Doctrine._WRA_WeaponTargetType selectedNodeTargetType7 = wra_WeaponTargetType2;
								bool findInheritedValuesOnly7 = false;
								int? num5 = null;
								num6 = null;
								num21 = doctrine_7.method_13(scenario_7, theWeapon7, selectedNodeTargetType7, findInheritedValuesOnly7, ref num5, ref num6);
							}
							num6 = num21;
							if (((num6 != null) ? new bool?(num6.GetValueOrDefault() == -99) : null).GetValueOrDefault())
							{
								num21 = new int?(int.MaxValue);
							}
						}
						else
						{
							weaponRec = list4[0];
							weapon3 = weaponRec.method_12(this.activeUnit_0.scenario_0);
						}
					}
					if (!Information.IsNothing(weaponRec))
					{
						int? num7;
						int? num13;
						if (!bool_9)
						{
							num13 = dictionary[weaponRec.int_5].nullable_0;
							num7 = dictionary[weaponRec.int_5].nullable_1;
							int? num6 = num13;
							bool? flag6;
							bool? flag19;
							if (!((num6 != null) ? new bool?(num6.GetValueOrDefault() < 0) : null).GetValueOrDefault())
							{
								flag19 = new bool?(false);
							}
							else
							{
								num6 = num13;
								flag6 = ((num6 != null) ? new bool?(num6.GetValueOrDefault() == -99) : null);
								flag19 = ((flag6 != null) ? new bool?(!flag6.GetValueOrDefault()) : flag6);
							}
							flag6 = flag19;
							if (flag6.GetValueOrDefault())
							{
								num13 = this.activeUnit_0.vmethod_7(false).method_80(num13, ref this.activeUnit_0, ref @class.contact_0, ref weapon3);
							}
							num6 = num13;
							if (((num6 != null) ? new bool?(num6.GetValueOrDefault() < 1) : null).GetValueOrDefault())
							{
								num13 = new int?(1);
							}
							bool? flag20;
							if (!((num7 != null & num13 != null) ? new bool?(num7.GetValueOrDefault() > num13.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								flag20 = new bool?(false);
							}
							else
							{
								num6 = num13;
								flag6 = ((num6 != null) ? new bool?(num6.GetValueOrDefault() == -99) : null);
								flag20 = ((flag6 != null) ? new bool?(!flag6.GetValueOrDefault()) : flag6);
							}
							flag6 = flag20;
							if (flag6.GetValueOrDefault())
							{
								num7 = num13;
							}
						}
						else
						{
							num13 = new int?(int_1);
							num7 = new int?(int_1);
						}
						if (Information.IsNothing(class4))
						{
							Side side = this.activeUnit_0.vmethod_7(false);
							Scenario scenario_8 = this.activeUnit_0.scenario_0;
							Weapon weapon4 = weaponRec.method_12(this.activeUnit_0.scenario_0);
							side.method_81(scenario_8, ref weapon4, ref @class.contact_0, num13, 0, num7, bool_9, ref this.activeUnit_0.string_0, ref num21, DateTime.MinValue);
						}
						else
						{
							this.activeUnit_0.vmethod_7(false).method_82(ref class4, num13, 0, num7, bool_9, ref this.activeUnit_0.string_0);
						}
						return result;
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 101239", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				result2 = false;
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100299", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result2 = false;
			}
			return result2;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000C1438 File Offset: 0x000BF638
		public int method_12(ref Contact contact_0)
		{
			if (!Information.IsNothing(contact_0.activeUnit_0))
			{
				if (contact_0.activeUnit_0.bool_6)
				{
					return (int)((Ship)contact_0.activeUnit_0).short_5;
				}
				if (contact_0.activeUnit_0.bool_8)
				{
					return ((Facility)contact_0.activeUnit_0).int_8;
				}
			}
			return 0;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000C149C File Offset: 0x000BF69C
		public List<Weapon> method_13(Contact contact_0, ref Doctrine._GunStrafeGroundTargets? nullable_0)
		{
			List<Weapon> result;
			try
			{
				List<Weapon> list = this.vmethod_4();
				List<Weapon> list2 = new List<Weapon>();
				bool? flag = null;
				try
				{
					foreach (Weapon weapon in list)
					{
						if (weapon.method_253(this.activeUnit_0.scenario_0, ref contact_0, ref flag))
						{
							if (this.activeUnit_0.bool_3 && weapon.method_167() == Weapon._WeaponType.Gun && contact_0.method_134())
							{
								if (Information.IsNothing(nullable_0))
								{
									nullable_0 = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
								}
								Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = nullable_0;
								byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
								if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									list2.Add(weapon);
								}
							}
							else
							{
								list2.Add(weapon);
							}
						}
					}
				}
				finally
				{
					List<Weapon>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = list2;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100300", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000C164C File Offset: 0x000BF84C
		public int method_14(ref Weapon weapon_6, ref Contact contact_0, bool bool_9)
		{
			int result;
			try
			{
				Weapon weapon = weapon_6;
				Scenario scenario_ = this.activeUnit_0.scenario_0;
				bool? flag = null;
				if (!weapon.method_253(scenario_, ref contact_0, ref flag))
				{
					result = 0;
				}
				else
				{
					bool? flag2;
					if (!weapon_6.method_191())
					{
						flag2 = new bool?(false);
					}
					else
					{
						Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
						byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
						flag = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
						flag2 = ((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag);
					}
					flag = flag2;
					if (flag.GetValueOrDefault())
					{
						result = 0;
					}
					else
					{
						if (bool_9)
						{
							float float_;
							if (weapon_6.method_167() == Weapon._WeaponType.Gun)
							{
								float_ = this.activeUnit_0.method_37(contact_0, 0f);
							}
							else
							{
								float_ = this.activeUnit_0.method_36(contact_0);
							}
							if (!weapon_6.method_254(float_, contact_0))
							{
								return 0;
							}
							if (weapon_6.method_256(float_, contact_0))
							{
								return 0;
							}
						}
						int num = 1;
						if (this.activeUnit_0.bool_3 && weapon_6.method_167() == Weapon._WeaponType.Gun)
						{
							num -= 2;
						}
						if (weapon_6.warhead_0.Length > 0)
						{
							Warhead warhead = weapon_6.warhead_0[0];
							switch (contact_0.contactType_0)
							{
							case Contact_Base.ContactType.Air:
							{
								if (weapon_6.method_167() == Weapon._WeaponType.Gun && weapon_6.method_199() && !weapon_6.method_195() && !weapon_6.method_196())
								{
									num++;
								}
								Warhead.WarheadType warheadType_ = warhead.warheadType_0;
								if (warheadType_ <= Warhead.WarheadType.ContinuousRod)
								{
									if (warheadType_ != Warhead.WarheadType.Fragmentation && warheadType_ != Warhead.WarheadType.ContinuousRod)
									{
										break;
									}
								}
								else
								{
									if (warheadType_ == Warhead.WarheadType.Fragmentation_ABM)
									{
										num += 2;
										break;
									}
									if (warheadType_ != Warhead.WarheadType.Nuclear)
									{
										break;
									}
								}
								num++;
								break;
							}
							case Contact_Base.ContactType.Missile:
							{
								if (weapon_6.method_167() == Weapon._WeaponType.Gun && weapon_6.method_199() && !weapon_6.method_195() && !weapon_6.method_196())
								{
									num++;
								}
								Warhead.WarheadType warheadType_2 = warhead.warheadType_0;
								if (warheadType_2 <= Warhead.WarheadType.ContinuousRod)
								{
									if (warheadType_2 != Warhead.WarheadType.ArmorPiercing && warheadType_2 != Warhead.WarheadType.Fragmentation && warheadType_2 != Warhead.WarheadType.ContinuousRod)
									{
										break;
									}
								}
								else if (warheadType_2 <= Warhead.WarheadType.LongRodPenetrator)
								{
									if (warheadType_2 == Warhead.WarheadType.Fragmentation_ABM)
									{
										num += 2;
										break;
									}
									if (warheadType_2 != Warhead.WarheadType.LongRodPenetrator)
									{
										break;
									}
								}
								else if (warheadType_2 - Warhead.WarheadType.Laser_COIL > 3 && warheadType_2 != Warhead.WarheadType.Kinetic)
								{
									break;
								}
								num++;
								break;
							}
							case Contact_Base.ContactType.Surface:
							{
								if (weapon_6.method_196() && !weapon_6.method_199())
								{
									num++;
								}
								Warhead.WarheadType warheadType_3 = warhead.warheadType_0;
								if (warheadType_3 <= Warhead.WarheadType.Nuclear)
								{
									switch (warheadType_3)
									{
									case Warhead.WarheadType.HE_BlastFrag:
									case Warhead.WarheadType.ArmorPiercing:
									case Warhead.WarheadType.HEAT:
									case Warhead.WarheadType.SemiAP:
									case Warhead.WarheadType.HESH:
									case Warhead.WarheadType.HardTargetPenetrator:
										break;
									case Warhead.WarheadType.Incendiary:
									case Warhead.WarheadType.Fragmentation:
									case Warhead.WarheadType.ContinuousRod:
										goto IL_50A;
									default:
										if (warheadType_3 != Warhead.WarheadType.Nuclear)
										{
											goto IL_50A;
										}
										break;
									}
								}
								else if (warheadType_3 != Warhead.WarheadType.LongRodPenetrator && warheadType_3 != Warhead.WarheadType.Kinetic)
								{
									break;
								}
								num++;
								break;
							}
							case Contact_Base.ContactType.Submarine:
							{
								Warhead.WarheadType warheadType_4 = warhead.warheadType_0;
								if (warheadType_4 == Warhead.WarheadType.HEAT || warheadType_4 == Warhead.WarheadType.HESH || warheadType_4 - Warhead.WarheadType.Torpedo <= 1)
								{
									num++;
								}
								break;
							}
							case Contact_Base.ContactType.Facility_Fixed:
							{
								if (weapon_6.method_195() && !weapon_6.method_199())
								{
									num += 2;
								}
								Warhead.WarheadType warheadType_5 = warhead.warheadType_0;
								if (warheadType_5 <= Warhead.WarheadType.Nuclear)
								{
									switch (warheadType_5)
									{
									case Warhead.WarheadType.HE_BlastFrag:
									case Warhead.WarheadType.ArmorPiercing:
									case Warhead.WarheadType.HEAT:
									case Warhead.WarheadType.Incendiary:
									case Warhead.WarheadType.SemiAP:
									case Warhead.WarheadType.HESH:
									case Warhead.WarheadType.HardTargetPenetrator:
										break;
									case Warhead.WarheadType.Fragmentation:
									case Warhead.WarheadType.ContinuousRod:
										goto IL_3FE;
									default:
										if (warheadType_5 != Warhead.WarheadType.Nuclear)
										{
											goto IL_3FE;
										}
										break;
									}
								}
								else if (warheadType_5 != Warhead.WarheadType.Cluster_Penetrator && warheadType_5 != Warhead.WarheadType.LongRodPenetrator && warheadType_5 != Warhead.WarheadType.Kinetic)
								{
									goto IL_3FE;
								}
								num++;
								IL_3FE:
								if (!Information.IsNothing(contact_0.activeUnit_0) && contact_0.activeUnit_0.method_6() && warhead.method_9())
								{
									num += 3;
								}
								break;
							}
							case Contact_Base.ContactType.Facility_Mobile:
							{
								if (weapon_6.method_195() && !weapon_6.method_199())
								{
									num++;
								}
								Warhead.WarheadType warheadType_6 = warhead.warheadType_0;
								if (warheadType_6 <= Warhead.WarheadType.Cluster_AT)
								{
									switch (warheadType_6)
									{
									case Warhead.WarheadType.HE_BlastFrag:
									case Warhead.WarheadType.ArmorPiercing:
									case Warhead.WarheadType.HEAT:
									case Warhead.WarheadType.Incendiary:
									case Warhead.WarheadType.Fragmentation:
									case Warhead.WarheadType.HESH:
									case Warhead.WarheadType.SuperFrag:
										break;
									case Warhead.WarheadType.SemiAP:
									case Warhead.WarheadType.ContinuousRod:
									case Warhead.WarheadType.HardTargetPenetrator:
									case Warhead.WarheadType.FAE:
										goto IL_4E1;
									default:
										if (warheadType_6 != Warhead.WarheadType.Nuclear && warheadType_6 - Warhead.WarheadType.Cluster_AP > 1)
										{
											goto IL_4E1;
										}
										break;
									}
								}
								else if (warheadType_6 <= Warhead.WarheadType.Landmine_AT)
								{
									if (warheadType_6 != Warhead.WarheadType.Cluster_SmartSubs && warheadType_6 - Warhead.WarheadType.Landmine_AP > 1)
									{
										goto IL_4E1;
									}
								}
								else if (warheadType_6 != Warhead.WarheadType.LongRodPenetrator && warheadType_6 != Warhead.WarheadType.Kinetic)
								{
									goto IL_4E1;
								}
								num++;
								IL_4E1:
								if (!Information.IsNothing(contact_0.activeUnit_0) && contact_0.activeUnit_0.method_6() && warhead.method_9())
								{
									num += 3;
								}
								break;
							}
							}
							IL_50A:
							if (contact_0.method_125() >= Contact_Base.IdentificationStatus.KnownClass)
							{
								GlobalVariables.ArmorRating armorRating;
								switch (contact_0.contactType_0)
								{
								case Contact_Base.ContactType.Air:
								case Contact_Base.ContactType.Missile:
								case Contact_Base.ContactType.Orbital:
								case Contact_Base.ContactType.Torpedo:
								case Contact_Base.ContactType.Mine:
									armorRating = GlobalVariables.ArmorRating.None;
									goto IL_655;
								case Contact_Base.ContactType.Surface:
								{
									ActiveUnit activeUnit = contact_0.activeUnit_0;
									if (activeUnit.bool_6)
									{
										armorRating = ((Ship)activeUnit).armorRating_2;
										goto IL_655;
									}
									if (activeUnit.bool_5)
									{
										armorRating = GlobalVariables.ArmorRating.Light;
										goto IL_655;
									}
									if (activeUnit.bool_8)
									{
										armorRating = ((Facility)activeUnit).armorRating_0;
										goto IL_655;
									}
									goto IL_655;
								}
								case Contact_Base.ContactType.Submarine:
									if (((Submarine)contact_0.activeUnit_0).struct35_0.bool_5)
									{
										armorRating = GlobalVariables.ArmorRating.Medium;
										goto IL_655;
									}
									armorRating = GlobalVariables.ArmorRating.Light;
									goto IL_655;
								case Contact_Base.ContactType.Facility_Fixed:
								case Contact_Base.ContactType.Facility_Mobile:
									if (!contact_0.activeUnit_0.method_6())
									{
										armorRating = ((Facility)contact_0.activeUnit_0).armorRating_0;
										goto IL_655;
									}
									if (contact_0.activeUnit_0.vmethod_51().Count > 0)
									{
										armorRating = contact_0.activeUnit_0.vmethod_51()[0].armorRating_0;
										goto IL_655;
									}
									armorRating = ((Facility)contact_0.activeUnit_0).armorRating_0;
									goto IL_655;
								}
								armorRating = GlobalVariables.ArmorRating.Light;
								IL_655:
								if (armorRating != GlobalVariables.ArmorRating.None)
								{
									if (armorRating != GlobalVariables.ArmorRating.Light)
									{
										Warhead.WarheadType warheadType_7 = warhead.warheadType_0;
										if (warheadType_7 <= Warhead.WarheadType.Cluster_SmartSubs)
										{
											switch (warheadType_7)
											{
											case Warhead.WarheadType.ArmorPiercing:
											case Warhead.WarheadType.HEAT:
											case Warhead.WarheadType.SemiAP:
											case Warhead.WarheadType.HESH:
											case Warhead.WarheadType.HardTargetPenetrator:
												break;
											case Warhead.WarheadType.Incendiary:
											case Warhead.WarheadType.Fragmentation:
											case Warhead.WarheadType.ContinuousRod:
												goto IL_6E1;
											default:
												if (warheadType_7 - Warhead.WarheadType.Cluster_AT > 1 && warheadType_7 != Warhead.WarheadType.Cluster_SmartSubs)
												{
													goto IL_6E1;
												}
												break;
											}
										}
										else if (warheadType_7 != Warhead.WarheadType.Landmine_AT && warheadType_7 != Warhead.WarheadType.LongRodPenetrator && warheadType_7 != Warhead.WarheadType.Kinetic)
										{
											goto IL_6E1;
										}
										num++;
										IL_6E1:
										if (weapon_6.method_167() == Weapon._WeaponType.Gun)
										{
											if (warhead.warheadCaliber_0 > Warhead.WarheadCaliber.Gun_61_80mm)
											{
												num++;
											}
											else
											{
												num--;
											}
										}
									}
									else if (warhead.warheadType_0 == Warhead.WarheadType.SuperFrag)
									{
										num++;
									}
								}
								else
								{
									Warhead.WarheadType warheadType_8 = warhead.warheadType_0;
									if (warheadType_8 <= Warhead.WarheadType.Fragmentation_ABM)
									{
										if (warheadType_8 <= Warhead.WarheadType.Fragmentation)
										{
											if (warheadType_8 != Warhead.WarheadType.HE_BlastFrag && warheadType_8 - Warhead.WarheadType.Incendiary > 1)
											{
												goto IL_7A4;
											}
										}
										else if (warheadType_8 != Warhead.WarheadType.ContinuousRod && warheadType_8 != Warhead.WarheadType.Fragmentation_ABM)
										{
											goto IL_7A4;
										}
									}
									else if (warheadType_8 <= Warhead.WarheadType.Nuclear)
									{
										if (warheadType_8 != Warhead.WarheadType.DepthCharge && warheadType_8 != Warhead.WarheadType.Nuclear)
										{
											goto IL_7A4;
										}
									}
									else if (warheadType_8 != Warhead.WarheadType.Cluster_AP && warheadType_8 != Warhead.WarheadType.Landmine_AP)
									{
										goto IL_7A4;
									}
									num++;
									IL_7A4:
									if (weapon_6.method_167() == Weapon._WeaponType.Gun)
									{
										if (warhead.warheadCaliber_0 <= Warhead.WarheadCaliber.Gun_61_80mm)
										{
											num++;
										}
										else
										{
											num--;
										}
									}
								}
							}
						}
						result = num;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100301", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000C1E7C File Offset: 0x000C007C
		public Weapon method_15(Contact contact_0)
		{
			ActiveUnit_Weaponry.Class231 @class = new ActiveUnit_Weaponry.Class231();
			@class.activeUnit_Weaponry_0 = this;
			@class.contact_0 = contact_0;
			Weapon result;
			try
			{
				Contact contact_ = @class.contact_0;
				Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
				IEnumerable<Weapon> enumerable = this.method_13(contact_, ref gunStrafeGroundTargets);
				if (Enumerable.Count<Weapon>(enumerable) == 0)
				{
					result = null;
				}
				else
				{
					int num = Enumerable.Count<Weapon>(enumerable);
					if (num != 0)
					{
						if (num != 1)
						{
							result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(enumerable, new Func<Weapon, float>(@class.method_0)), 0);
						}
						else
						{
							result = Enumerable.ElementAtOrDefault<Weapon>(enumerable, 0);
						}
					}
					else
					{
						result = null;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100302", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x000C1F44 File Offset: 0x000C0144
		public Weapon method_16(Contact contact_0, bool bool_9, bool bool_10, bool bool_11, Doctrine doctrine_0)
		{
			ActiveUnit_Weaponry.Class232 @class = new ActiveUnit_Weaponry.Class232();
			@class.activeUnit_Weaponry_0 = this;
			@class.contact_0 = contact_0;
			@class.bool_0 = bool_9;
			@class.doctrine_0 = doctrine_0;
			Weapon result;
			try
			{
				ActiveUnit_Weaponry.Class233 class2 = new ActiveUnit_Weaponry.Class233();
				class2.class232_0 = @class;
				if (this.activeUnit_0.bool_2)
				{
					result = null;
				}
				else
				{
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = class2.class232_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
					List<Weapon> list = this.method_13(class2.class232_0.contact_0, ref gunStrafeGroundTargets);
					if (list.Count == 0)
					{
						result = null;
					}
					else
					{
						class2.float_0 = this.activeUnit_0.method_36(class2.class232_0.contact_0);
						IEnumerable<Weapon> enumerable;
						if (bool_11 && class2.class232_0.bool_0)
						{
							if (bool_10 && class2.class232_0.contact_0.bool_19)
							{
								enumerable = Enumerable.Where<Weapon>(list, new Func<Weapon, bool>(class2.method_0));
							}
							else
							{
								enumerable = Enumerable.Where<Weapon>(list, new Func<Weapon, bool>(class2.method_1));
							}
						}
						else if (bool_11 && !class2.class232_0.bool_0)
						{
							if (bool_10 && class2.class232_0.contact_0.bool_19)
							{
								enumerable = Enumerable.Where<Weapon>(list, new Func<Weapon, bool>(class2.class232_0.method_0));
							}
							else
							{
								enumerable = Enumerable.Where<Weapon>(list, new Func<Weapon, bool>(class2.class232_0.method_1));
							}
						}
						else if (!bool_11 && class2.class232_0.bool_0)
						{
							if (bool_10 && class2.class232_0.contact_0.bool_19)
							{
								enumerable = Enumerable.Where<Weapon>(list, new Func<Weapon, bool>(class2.method_2));
							}
							else
							{
								enumerable = Enumerable.Where<Weapon>(list, new Func<Weapon, bool>(class2.method_3));
							}
						}
						else
						{
							enumerable = list;
						}
						int num = Enumerable.Count<Weapon>(enumerable);
						if (num != 0)
						{
							if (num != 1)
							{
								result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.ThenByDescending<Weapon, float>(Enumerable.OrderByDescending<Weapon, int>(enumerable, new Func<Weapon, int>(class2.class232_0.method_2)), (ActiveUnit_Weaponry._Closure$__.$I46-7 == null) ? (ActiveUnit_Weaponry._Closure$__.$I46-7 = new Func<Weapon, float>(ActiveUnit_Weaponry._Closure$__.$I.method_9)) : ActiveUnit_Weaponry._Closure$__.$I46-7), 0);
							}
							else
							{
								result = Enumerable.ElementAtOrDefault<Weapon>(enumerable, 0);
							}
						}
						else
						{
							result = null;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100303", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000C21C8 File Offset: 0x000C03C8
		public virtual void vmethod_7(float float_0)
		{
			int count = this.activeUnit_0.vmethod_51().Count;
			try
			{
				int num = count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						Mount mount = this.activeUnit_0.vmethod_51()[i];
						if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
						{
							float num2 = 0f;
							if (mount.method_28() > 0f)
							{
								mount.method_29(Math.Max(0f, mount.method_28() - float_0));
								num2 = mount.method_28();
							}
							if (mount.method_32().method_24() > 0f && mount.method_32().method_24() > num2)
							{
								num2 = mount.method_32().method_24();
							}
							int num3 = mount.vmethod_10().Count - 1;
							for (int j = 0; j <= num3; j++)
							{
								try
								{
									WeaponRec weaponRec = mount.vmethod_10()[j];
									WeaponRec weaponRec2 = weaponRec;
									if (weaponRec2.float_0 > 0f)
									{
										weaponRec2.float_0 -= float_0;
										if (weaponRec2.float_0 < 0f)
										{
											weaponRec2.float_0 = 0f;
										}
										if (weaponRec2.float_0 > num2)
										{
											num2 = weaponRec2.float_0;
										}
									}
								}
								catch (Exception ex)
								{
									ex.Data.Add("Error at 200437", ex.Message);
									GameGeneral.smethod_25(ref ex);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
							}
							if (mount.method_32().method_24() > 0f)
							{
								mount.method_32().method_25(Math.Max(0f, mount.method_32().method_24() - float_0));
							}
							int num4 = mount.method_32().vmethod_10().Count - 1;
							for (int j = 0; j <= num4; j++)
							{
								try
								{
									WeaponRec weaponRec = mount.method_32().vmethod_10()[j];
									WeaponRec weaponRec3 = weaponRec;
									if (weaponRec3.float_0 > 0f)
									{
										weaponRec3.float_0 -= float_0;
										if (weaponRec3.float_0 < 0f)
										{
											weaponRec3.float_0 = 0f;
										}
										if (weaponRec3.float_0 > num2)
										{
											num2 = weaponRec3.float_0;
										}
									}
								}
								catch (Exception ex2)
								{
									ex2.Data.Add("Error at 200438", ex2.Message);
									GameGeneral.smethod_25(ref ex2);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
							}
							if (num2 <= 0f)
							{
								mount.enum113_0 = Mount.Enum113.const_0;
							}
						}
					}
					catch (Exception ex3)
					{
						ex3.Data.Add("Error at 200439", ex3.Message);
						GameGeneral.smethod_25(ref ex3);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				if (this.activeUnit_0.vmethod_43())
				{
					foreach (Magazine magazine in ((Class350)this.activeUnit_0).magazine_0)
					{
						int num5 = magazine.vmethod_10().Count - 1;
						for (int j = 0; j <= num5; j++)
						{
							try
							{
								WeaponRec weaponRec = magazine.vmethod_10()[j];
								if (weaponRec.float_0 > 0f)
								{
									weaponRec.float_0 -= float_0;
									if (weaponRec.float_0 < 0f)
									{
										weaponRec.float_0 = 0f;
									}
								}
								goto IL_390;
							}
							catch (Exception ex4)
							{
								ex4.Data.Add("Error at 200440", ex4.Message);
								GameGeneral.smethod_25(ref ex4);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								goto IL_390;
							}
							break;
							IL_390:;
						}
					}
				}
			}
			catch (Exception ex5)
			{
				ex5.Data.Add("Error at 100304", "");
				GameGeneral.smethod_25(ref ex5);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000C2628 File Offset: 0x000C0828
		public bool method_17(Contact contact_0, bool bool_9)
		{
			bool result;
			try
			{
				if (contact_0.activeUnit_0.bool_6 || contact_0.activeUnit_0.bool_8 || contact_0.activeUnit_0.bool_5)
				{
					List<Weapon> list = this.vmethod_4();
					if (list.Count > 0)
					{
						bool? flag = null;
						try
						{
							foreach (Weapon weapon in list)
							{
								if (weapon.method_253(this.activeUnit_0.scenario_0, ref contact_0, ref flag) && string.CompareOrdinal(this.method_18(weapon, contact_0), "OK") == 0)
								{
									if (bool_9)
									{
										Weapon theWeapon = weapon;
										Contact theTarget = contact_0;
										short? num = null;
										bool manualFire = false;
										bool ignoreAircraftOrientation = false;
										Mount theMount = null;
										Sensor sensor = null;
										if (this.method_23(theWeapon, theTarget, ref num, manualFire, ignoreAircraftOrientation, theMount, ref sensor).Item2 != ActiveUnit_Weaponry.Enum36.const_0)
										{
											continue;
										}
									}
									return true;
								}
							}
						}
						finally
						{
							List<Weapon>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100305", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000C2754 File Offset: 0x000C0954
		public string method_18(Weapon weapon_6, Contact contact_0)
		{
			string result;
			try
			{
				byte? b;
				if (weapon_6.method_191())
				{
					Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
					b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
					if (((b != null) ? new bool?(b.GetValueOrDefault() != 1) : null).GetValueOrDefault())
					{
						return "Nuclear weapons not authorized";
					}
				}
				Doctrine.Enum51? enum2 = this.activeUnit_0.doctrine_0.method_88(this.activeUnit_0.scenario_0, false, false, false);
				b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
				if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
				{
					result = "OK";
				}
				else
				{
					b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
					int num;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
					{
						num = 3;
					}
					else
					{
						b = ((enum2 != null) ? new byte?((byte)enum2.GetValueOrDefault()) : null);
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 2) : null).GetValueOrDefault())
						{
							num = 1;
						}
					}
					if (contact_0.method_136())
					{
						if (num == 1)
						{
							if (contact_0.method_57() > 120f)
							{
								return "The target's last known location is outdated (" + Misc.smethod_11((long)Math.Round((double)contact_0.method_57()), Aircraft_AirOps.Enum44.const_0, false, false) + " seconds). (Pessimistic)";
							}
						}
						else if (contact_0.method_57() > 600f)
						{
							return "The target's last known location is outdated (" + Misc.smethod_11((long)Math.Round((double)contact_0.method_57()), Aircraft_AirOps.Enum44.const_0, false, false) + " seconds). (Optimistic)";
						}
					}
					float num2 = contact_0.method_94(this.activeUnit_0);
					float num3 = (float)Math.Round((double)weapon_6.method_163(), 1);
					string text = (num > 1) ? " " : (" " + Conversions.ToString(num) + "x ");
					if (Math.Round((double)num2, 1) > Math.Round((double)(num3 * (float)num), 1))
					{
						result = string.Concat(new string[]
						{
							"The target's downrange ambiguity (",
							string.Format("{0:0.0}", num2),
							"nm) is larger than",
							text,
							"the weapon's acceptable limit (",
							string.Format("{0:0.0}", num3),
							"nm)"
						});
					}
					else
					{
						float num4 = contact_0.method_93(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null));
						float num5 = (float)Math.Round((double)weapon_6.method_161(), 1);
						if (Math.Round((double)num4, 1) > Math.Round((double)num5, 1))
						{
							result = string.Concat(new string[]
							{
								"The target's cross-range ambiguity (",
								string.Format("{0:0.0}", num4),
								"nm) is larger than",
								text,
								"the weapon's acceptable limit (",
								string.Format("{0:0.0}", num5),
								"nm)"
							});
						}
						else
						{
							result = "OK";
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100306", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error";
			}
			return result;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000C2B50 File Offset: 0x000C0D50
		public float method_19(ref ActiveUnit activeUnit_1, ref Weapon weapon_6, ref Contact contact_0, bool bool_9)
		{
			float result;
			if (weapon_6.method_2() && this.method_28(weapon_6, contact_0) && contact_0.vmethod_40() != 0f)
			{
				if (!contact_0.method_134() && !contact_0.method_135())
				{
					if (!contact_0.method_91() && !contact_0.activeUnit_0.method_1())
					{
						if (contact_0.method_104())
						{
							result = weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false);
						}
						else
						{
							result = (float)((double)weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false) * 1.5);
						}
					}
					else
					{
						result = weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false) * 10f;
					}
				}
				else
				{
					result = weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false);
				}
			}
			else
			{
				bool? flag;
				bool? flag5;
				if (!weapon_6.bool_7)
				{
					flag = new bool?(false);
				}
				else
				{
					Doctrine.Enum55? @enum = this.activeUnit_0.doctrine_0.method_216(this.activeUnit_0.scenario_0, false, false, false);
					byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
					bool? flag3;
					bool? flag2 = flag3 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
					if (flag3 != null && flag2.GetValueOrDefault())
					{
						flag = new bool?(true);
					}
					else
					{
						bool? flag4;
						if (!bool_9)
						{
							flag4 = new bool?(false);
						}
						else
						{
							@enum = this.activeUnit_0.doctrine_0.method_216(this.activeUnit_0.scenario_0, false, false, false);
							b = ((@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null);
							flag4 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null);
						}
						flag5 = (flag3 = flag4);
						flag = ((flag3 != null) ? (flag2 | flag5.GetValueOrDefault()) : null);
					}
				}
				flag5 = flag;
				if (flag5.GetValueOrDefault())
				{
					result = Math.Max(weapon_6.float_37, weapon_6.float_38);
				}
				else if (weapon_6.method_167() == Weapon._WeaponType.Gun && contact_0.method_111() && !Information.IsNothing(contact_0.activeUnit_0) && !Information.IsNothing(contact_0.activeUnit_0.vmethod_86().vmethod_3()) && !Information.IsNothing(contact_0.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0) && contact_0.activeUnit_0.vmethod_86().vmethod_3().activeUnit_0 == activeUnit_1)
				{
					if (contact_0.vmethod_14(false) < 650f)
					{
						result = (float)Math.Min((double)weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false) * 1.5, 1.5);
					}
					else
					{
						float num;
						if (contact_0.vmethod_40() < 1000f)
						{
							num = 1.5f;
						}
						else
						{
							num = 2f;
						}
						float num2 = (float)((double)Math.Abs(this.activeUnit_0.vmethod_14(false) - contact_0.vmethod_14(false)) / 1852.0);
						result = (float)Math.Sqrt((double)(num * num + num2 * num2));
					}
				}
				else
				{
					result = weapon_6.method_181(this.activeUnit_0, contact_0, false, this.activeUnit_0.doctrine_0, bool_9);
				}
			}
			return result;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x000C2ECC File Offset: 0x000C10CC
		public void method_20()
		{
			ActiveUnit_Weaponry.Class234 @class = new ActiveUnit_Weaponry.Class234(@class);
			Weapon weapon = null;
			Contact contact = null;
			if (!this.activeUnit_0.bool_1 && this.concurrentDictionary_0 != null && !Misc.smethod_14(this.concurrentDictionary_0))
			{
				this.concurrentDictionary_0.Clear();
			}
			try
			{
				foreach (string text in this.hashSet_0)
				{
					int num = Conversions.ToInteger(Enumerable.ToList<string>(text.Split(Conversions.ToCharArrayRankOne("_")))[0]);
					@class.string_0 = Enumerable.ToList<string>(text.Split(Conversions.ToCharArrayRankOne("_")))[1];
					try
					{
						contact = Enumerable.ElementAtOrDefault<Contact>(Enumerable.Where<Contact>(this.activeUnit_0.vmethod_86().method_12(), (@class.func_0 == null) ? (@class.func_0 = new Func<Contact, bool>(@class.method_0)) : @class.func_0), 0);
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200441", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						continue;
					}
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
					try
					{
						foreach (Weapon weapon2 in this.method_13(contact, ref gunStrafeGroundTargets))
						{
							if (weapon2.DBID == num)
							{
								weapon = weapon2;
							}
						}
					}
					finally
					{
						List<Weapon>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					if (!Information.IsNothing(weapon) && !Information.IsNothing(contact))
					{
						string text2 = this.method_25(contact, weapon);
						if (this.concurrentDictionary_0 == null)
						{
							this.concurrentDictionary_0 = new ConcurrentDictionary<Tuple<int, string>, string>();
						}
						this.concurrentDictionary_0.TryAdd(new Tuple<int, string>(num, @class.string_0), text2);
					}
				}
			}
			finally
			{
				HashSet<string>.Enumerator enumerator;
				enumerator.Dispose();
			}
			this.hashSet_0.Clear();
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x000C3110 File Offset: 0x000C1310
		private string method_21(Weapon weapon_6, Contact contact_0)
		{
			string result;
			try
			{
				if (!contact_0.method_91() && contact_0.contactType_0 != Contact_Base.ContactType.Surface)
				{
					if (weapon_6.float_42 > 0f)
					{
						float num;
						if (this.activeUnit_0.bool_8)
						{
							num = this.activeUnit_0.vmethod_14(false) + weapon_6.float_42;
						}
						else
						{
							num = weapon_6.float_42;
						}
						if (contact_0.vmethod_13() > num && contact_0.method_15())
						{
							if (Class570.class280_0.method_12())
							{
								return string.Concat(new string[]
								{
									"Target altitude (",
									Conversions.ToString((int)Math.Round((double)(contact_0.vmethod_13() * 3.28084f))),
									" ft AGL) is higher than the weapon's ceiling (",
									Conversions.ToString((int)Math.Round((double)(num * 3.28084f))),
									" ft AGL)"
								});
							}
							return string.Concat(new string[]
							{
								"Target altitude (",
								Conversions.ToString((int)Math.Round((double)contact_0.vmethod_13())),
								" m AGL) is higher than the weapon's ceiling (",
								Conversions.ToString(num),
								" m AGL)"
							});
						}
					}
					if (weapon_6.float_46 > 0f && contact_0.vmethod_14(false) > weapon_6.float_46)
					{
						if (Class570.class280_0.method_12())
						{
							return string.Concat(new string[]
							{
								"Target altitude (",
								Conversions.ToString((int)Math.Round((double)(contact_0.vmethod_14(false) * 3.28084f))),
								" ft ASL) is higher than the weapon's ceiling (",
								Conversions.ToString((int)Math.Round((double)(weapon_6.float_46 * 3.28084f))),
								" ft ASL)"
							});
						}
						return string.Concat(new string[]
						{
							"Target altitude (",
							Conversions.ToString((int)Math.Round((double)contact_0.vmethod_14(false))),
							" m ASL) is higher than the weapon's ceiling (",
							Conversions.ToString(weapon_6.float_46),
							" m ASL)"
						});
					}
					else
					{
						if (weapon_6.float_41 > 0f)
						{
							float float_ = weapon_6.float_41;
							if (contact_0.vmethod_13() < float_ && contact_0.contactType_0 != Contact_Base.ContactType.ActivationPoint)
							{
								if (Class570.class280_0.method_12())
								{
									return string.Concat(new string[]
									{
										"Target altitude (",
										Conversions.ToString((int)Math.Round((double)(contact_0.vmethod_13() * 3.28084f))),
										" ft AGL) is lower than the weapon's minimum engagement altitude (",
										Conversions.ToString((int)Math.Round((double)(float_ * 3.28084f))),
										" ft AGL)"
									});
								}
								return string.Concat(new string[]
								{
									"Target altitude (",
									Conversions.ToString((int)Math.Round((double)contact_0.vmethod_13())),
									" m AGL) is lower than the weapon's minimum engagement altitude (",
									Conversions.ToString(float_),
									" m AGL)"
								});
							}
						}
						if (weapon_6.float_45 > 0f && contact_0.vmethod_14(false) < weapon_6.float_45)
						{
							if (Class570.class280_0.method_12())
							{
								return string.Concat(new string[]
								{
									"Target altitude (",
									Conversions.ToString((int)Math.Round((double)(contact_0.vmethod_14(false) * 3.28084f))),
									" ft ASL) is lower than the weapon's minimum engagement altitude (",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_45 * 3.28084f))),
									" ft ASL)"
								});
							}
							return string.Concat(new string[]
							{
								"Target altitude (",
								Conversions.ToString((int)Math.Round((double)contact_0.vmethod_14(false))),
								" m ASL) is lower than the weapon's minimum engagement altitude (",
								Conversions.ToString(weapon_6.float_45),
								" m ASL)"
							});
						}
					}
				}
				result = "OK";
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error";
			}
			return result;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x000C3524 File Offset: 0x000C1724
		public string method_22(Weapon weapon_6, Contact contact_0, ref short? nullable_0)
		{
			string result;
			try
			{
				if (this.activeUnit_0.bool_3 && !contact_0.method_109() && (weapon_6.float_39 != 0f || weapon_6.float_40 != 0f || weapon_6.float_43 != 0f || weapon_6.float_44 != 0f))
				{
					if (nullable_0 == null)
					{
						nullable_0 = new short?((short)Math.Max(0, this.activeUnit_0.method_9(false, false, false)));
					}
					short value = nullable_0.Value;
					if (weapon_6.float_40 > 0f && (double)(this.activeUnit_0.vmethod_14(false) - (float)value) > (double)weapon_6.float_40 + 0.1)
					{
						if (Class570.class280_0.method_12())
						{
							if (value > 0)
							{
								if (weapon_6.float_39 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
										" ft AGL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								if (weapon_6.float_43 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
										" ft AGL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
									" ft AGL maximum, terrain elevation ",
									Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
									" ft)"
								});
							}
							else
							{
								if (weapon_6.float_39 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
										" ft AGL)"
									});
								}
								if (weapon_6.float_43 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
										" ft AGL)"
									});
								}
								return "Aircraft altitude too high (Valid: " + Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))) + " ft AGL maximum)";
							}
						}
						else if (value > 0)
						{
							if (weapon_6.float_39 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_40)),
									" m AGL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							if (weapon_6.float_43 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_40)),
									" m AGL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							return string.Concat(new string[]
							{
								"Aircraft altitude too high (Valid: ",
								Conversions.ToString((int)Math.Round((double)weapon_6.float_40)),
								" m AGL maximum, terrain elevation ",
								Conversions.ToString((int)value),
								" m)"
							});
						}
						else
						{
							if (weapon_6.float_39 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_40)),
									" m AGL)"
								});
							}
							if (weapon_6.float_43 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_40)),
									" m AGL)"
								});
							}
							return "Aircraft altitude too high (Valid: " + Conversions.ToString((int)Math.Round((double)weapon_6.float_40)) + " m AGL maximum)";
						}
					}
					else if (weapon_6.float_44 > 0f && (double)this.activeUnit_0.vmethod_14(false) > (double)weapon_6.float_44 + 0.1)
					{
						if (Class570.class280_0.method_12())
						{
							if (value > 0)
							{
								if (weapon_6.float_39 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
										" ft ASL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								if (weapon_6.float_43 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
										" ft ASL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
									" ft ASL maximum, terrain elevation ",
									Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
									" ft)"
								});
							}
							else
							{
								if (weapon_6.float_39 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
										" ft ASL)"
									});
								}
								if (weapon_6.float_43 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too high (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
										" ft ASL)"
									});
								}
								return "Aircraft altitude too high (Valid: " + Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))) + " ft ASL maximum)";
							}
						}
						else if (value > 0)
						{
							if (weapon_6.float_39 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_44)),
									" m ASL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							if (weapon_6.float_43 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_44)),
									" m ASL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							return string.Concat(new string[]
							{
								"Aircraft altitude too high (Valid: ",
								Conversions.ToString((int)Math.Round((double)weapon_6.float_44)),
								" m ASL maximum, terrain elevation ",
								Conversions.ToString((int)value),
								" m)"
							});
						}
						else
						{
							if (weapon_6.float_39 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_44)),
									" m ASL)"
								});
							}
							if (weapon_6.float_43 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too high (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_44)),
									" m ASL)"
								});
							}
							return "Aircraft altitude too high (Valid: " + Conversions.ToString((int)Math.Round((double)weapon_6.float_44)) + " m ASL maximum)";
						}
					}
					else if (weapon_6.float_39 > 0f && (double)this.activeUnit_0.vmethod_14(false) < (double)(weapon_6.float_39 + (float)value) - 0.1)
					{
						if (Class570.class280_0.method_12())
						{
							if (value > 0)
							{
								if (weapon_6.float_40 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
										" ft AGL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								if (weapon_6.float_44 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
										" ft ASL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
									" ft AGL minimum, terrain elevation ",
									Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
									" ft)"
								});
							}
							else
							{
								if (weapon_6.float_40 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
										" ft AGL)"
									});
								}
								if (weapon_6.float_44 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))),
										" ft AGL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
										" ft ASL)"
									});
								}
								return "Aircraft altitude too low (Valid: " + Conversions.ToString((int)Math.Round((double)(weapon_6.float_39 * 3.28084f))) + " ft AGL minimum)";
							}
						}
						else if (value > 0)
						{
							if (weapon_6.float_40 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_40)),
									" m AGL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							if (weapon_6.float_44 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_44)),
									" m ASL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							return string.Concat(new string[]
							{
								"Aircraft altitude too low (Valid: ",
								Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
								" m AGL minimum, terrain elevation ",
								Conversions.ToString((int)value),
								" m)"
							});
						}
						else
						{
							if (weapon_6.float_40 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_40)),
									" m AGL)"
								});
							}
							if (weapon_6.float_44 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_39)),
									" m AGL to ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_44)),
									" m ASL)"
								});
							}
							return "Aircraft altitude too low (Valid: " + Conversions.ToString((int)Math.Round((double)weapon_6.float_39)) + " m AGL minimum)";
						}
					}
					else if (weapon_6.float_43 > 0f && (double)this.activeUnit_0.vmethod_14(false) < (double)weapon_6.float_43 - 0.1)
					{
						if (Class570.class280_0.method_12())
						{
							if (value > 0)
							{
								if (weapon_6.float_40 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)((weapon_6.float_40 + (float)value) * 3.28084f))),
										" ft AGL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								if (weapon_6.float_44 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)((weapon_6.float_44 + (float)value) * 3.28084f))),
										" ft ASL, terrain elevation ",
										Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
										" ft)"
									});
								}
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
									" ft ASL minimum, terrain elevation ",
									Conversions.ToString((int)Math.Round((double)((float)value * 3.28084f))),
									" ft)"
								});
							}
							else
							{
								if (weapon_6.float_40 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 * 3.28084f))),
										" ft AGL)"
									});
								}
								if (weapon_6.float_44 > 0f)
								{
									return string.Concat(new string[]
									{
										"Aircraft altitude too low (Valid: ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))),
										" ft ASL to ",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 * 3.28084f))),
										" ft ASL)"
									});
								}
								return "Aircraft altitude too low (Valid: " + Conversions.ToString((int)Math.Round((double)(weapon_6.float_43 * 3.28084f))) + " ft ASL minimum)";
							}
						}
						else if (value > 0)
						{
							if (weapon_6.float_40 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 + (float)value))),
									" m AGL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							if (weapon_6.float_44 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 + (float)value))),
									" m ASL, terrain elevation ",
									Conversions.ToString((int)value),
									" m)"
								});
							}
							return string.Concat(new string[]
							{
								"Aircraft altitude too low (Valid: ",
								Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
								" m ASL minimum, terrain elevation ",
								Conversions.ToString((int)value),
								" m)"
							});
						}
						else
						{
							if (weapon_6.float_40 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_40 + (float)value))),
									" m AGL)"
								});
							}
							if (weapon_6.float_44 > 0f)
							{
								return string.Concat(new string[]
								{
									"Aircraft altitude too low (Valid: ",
									Conversions.ToString((int)Math.Round((double)weapon_6.float_43)),
									" m ASL to ",
									Conversions.ToString((int)Math.Round((double)(weapon_6.float_44 + (float)value))),
									" m ASL)"
								});
							}
							return "Aircraft altitude too low (Valid: " + Conversions.ToString((int)Math.Round((double)weapon_6.float_43)) + " m ASL minimum)";
						}
					}
				}
				result = "OK";
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 999999", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error";
			}
			return result;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000C4984 File Offset: 0x000C2B84
		public ValueTuple<string, ActiveUnit_Weaponry.Enum36> method_23(Weapon theWeapon, Contact theTarget, ref short? ASL_atFiringUnit, bool ManualFire, bool IgnoreAircraftOrientation, Mount theMount = null, ref Sensor SuitableDirectorSensor = null)
		{
			ValueTuple<string, ActiveUnit_Weaponry.Enum36> result;
			try
			{
				if (theTarget == null)
				{
					result = new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is null", ActiveUnit_Weaponry.Enum36.const_2);
				}
				else if (theWeapon == null)
				{
					result = new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is null", ActiveUnit_Weaponry.Enum36.const_2);
				}
				else if (theWeapon.warhead_0.Length > 0 && theWeapon.warhead_0[0].warheadType_0 == Warhead.WarheadType.EMP_Directed && !GameGeneral.smethod_7() && !GameGeneral.smethod_6())
				{
					result = new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Directed-EMP weapons are available only in the Academic & Professional versions.", ActiveUnit_Weaponry.Enum36.const_2);
				}
				else if (theWeapon.warhead_0.Length > 0 && theWeapon.warhead_0[0].method_17(this.activeUnit_0.scenario_0) != null && theWeapon.warhead_0[0].method_17(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.HGV && !GameGeneral.smethod_7() && !GameGeneral.smethod_6())
				{
					result = new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("HGVs are available only in the Academic & Professional versions.", ActiveUnit_Weaponry.Enum36.const_2);
				}
				else if (theWeapon.method_169() == Weapon.WeaponGuidanceType.CommandGuided_Datalinked && theTarget.method_57() > 0f)
				{
					result = new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Cannot fire command-guided weapon against aged target.", ActiveUnit_Weaponry.Enum36.const_2);
				}
				else
				{
					if (theWeapon.method_167() != Weapon._WeaponType.Decoy_Expendable)
					{
						if (theWeapon.method_167() != Weapon._WeaponType.Decoy_Towed)
						{
							if (theWeapon.method_155())
							{
								UnguidedWeapon unguidedWeapon = new UnguidedWeapon(theWeapon, null, null, 0.0, 0.0, 0L);
								Unit unit = theTarget;
								bool? flag = null;
								double double_ = unit.vmethod_30(flag);
								Unit unit2 = theTarget;
								flag = null;
								string text = UnguidedWeapon.smethod_3(ref unguidedWeapon, double_, unit2.vmethod_28(flag), (float)theTarget.method_9(false, false, false), this.activeUnit_0.scenario_0);
								if (string.CompareOrdinal(text, "OK") != 0)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(text, ActiveUnit_Weaponry.Enum36.const_2);
								}
								return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Can lay mine here. Assign unit to Mine Laying mission.", ActiveUnit_Weaponry.Enum36.const_2);
							}
							else
							{
								Weapon weapon = theWeapon;
								Scenario scenario_ = this.activeUnit_0.scenario_0;
								bool? flag = null;
								if (!weapon.method_253(scenario_, ref theTarget, ref flag))
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is not suitable for this target", ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (theMount != null)
								{
									if (theMount.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon mount is not operational", ActiveUnit_Weaponry.Enum36.const_2);
									}
									if (theMount.enum113_0 == Mount.Enum113.const_1)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is reloading", ActiveUnit_Weaponry.Enum36.const_2);
									}
									if (theMount.enum113_0 == Mount.Enum113.const_2)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is unloading", ActiveUnit_Weaponry.Enum36.const_2);
									}
									if (this.activeUnit_0.vmethod_14(false) < 0f && theWeapon.method_167() == Weapon._WeaponType.Gun)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Guns cannot fire underwater", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								if (theWeapon.method_191() && this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false).Value != Doctrine.Enum65.const_1 && !this.activeUnit_0.vmethod_3())
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Unit is not authorized to use nuclear weapons", ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (theWeapon.method_156() && theTarget.contactType_0 == Contact_Base.ContactType.Facility_Mobile && theTarget.vmethod_40() > 0f && theTarget.method_57() > 5f)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target age is more than 5 secs - need current targeting data to use unguided weapon", ActiveUnit_Weaponry.Enum36.const_2);
								}
								float num = this.activeUnit_0.method_36(theTarget);
								float num2 = this.activeUnit_0.method_37(theTarget, num);
								if (theWeapon.method_167() == Weapon._WeaponType.Dispenser && num * 1852f > (float)theWeapon.warhead_0[0].short_1)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is out of weapon range", ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (theWeapon.bool_7 && this.activeUnit_0.bool_3 && theTarget.contactType_0 == Contact_Base.ContactType.Submarine && (double)num > 0.4)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("ASW torpedo must be dropped within 0.4nm of contact/aimpoint", ActiveUnit_Weaponry.Enum36.const_2);
								}
								float num3 = this.method_19(ref this.activeUnit_0, ref theWeapon, ref theTarget, ManualFire);
								if (theWeapon.method_167() == Weapon._WeaponType.Gun)
								{
									if (num3 < num2)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is out of weapon range", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								else if (num3 < num)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is out of weapon range", ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (theWeapon.method_167() == Weapon._WeaponType.Gun)
								{
									if (theWeapon.method_256(num2, theTarget))
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is within weapon minimum range", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								else if (theWeapon.method_256(num, theTarget))
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is within weapon minimum range", ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (this.activeUnit_0.bool_3 && !theTarget.method_103() && !theTarget.method_136() && theWeapon.method_156())
								{
									float num4 = theWeapon.method_158(this.activeUnit_0.vmethod_14(false), theTarget.contactType_0);
									if (num4 >= 0f && num > num4)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
										{
											"Horizontal range to target (",
											Conversions.ToString(Math.Round((double)num, 1)),
											"nm) is greater than the weapon's downrange at this altitude (",
											Conversions.ToString(Math.Round((double)num4, 1)),
											"nm)"
										}), ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								if (theWeapon.method_2() && theWeapon.method_199())
								{
									Contact_Base.ContactType contactType_ = theTarget.contactType_0;
									if (contactType_ == Contact_Base.ContactType.Surface && this.activeUnit_0.doctrine_0.method_167(this.activeUnit_0.scenario_0, false, false, false).Value != Doctrine.Enum58.const_1)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Unit is not authorized to use SAMs against surface targets", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								if (theWeapon.int_20 > 0 && theTarget.vmethod_40() > (float)theWeapon.int_20 * 1.2f && theTarget.contactType_0 != Contact_Base.ContactType.Orbital)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
									{
										"Target speed (",
										Conversions.ToString((int)Math.Round((double)theTarget.vmethod_40())),
										" kts) is much higher than the weapon's maximum target speed (",
										Conversions.ToString(theWeapon.int_20),
										" kts)"
									}), ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (theTarget.contactType_0 == Contact_Base.ContactType.ActivationPoint && !theWeapon.struct36_0.bool_14)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is not BOL-capable", ActiveUnit_Weaponry.Enum36.const_2);
								}
								string text2 = this.method_21(theWeapon, theTarget);
								if (string.CompareOrdinal(text2, "OK") != 0)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(text2, ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (!theTarget.method_91() && this.activeUnit_0.scenario_0.FeatureCompatibility.get_WeaponSnapUpDown(this.activeUnit_0.scenario_0.method_39()) && theWeapon.float_47 > 0f && theTarget.method_103())
								{
									float num5 = Math.Abs(theTarget.vmethod_14(false) - this.activeUnit_0.vmethod_14(false));
									if (num5 > theWeapon.float_47)
									{
										if (Class570.class280_0.method_12())
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
											{
												"Difference in altitude (",
												Conversions.ToString((int)Math.Round((double)(num5 * 3.28084f))),
												" ft) is larger than the weapon's snap-up/down ability (",
												Conversions.ToString((int)Math.Round((double)(theWeapon.float_47 * 3.28084f))),
												" ft)"
											}), ActiveUnit_Weaponry.Enum36.const_2);
										}
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
										{
											"Difference in altitude (",
											Conversions.ToString((int)Math.Round((double)num5)),
											" m) is larger than the weapon's snap-up/down ability (",
											Conversions.ToString((int)Math.Round((double)theWeapon.float_47)),
											" m)"
										}), ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								if (!theWeapon.method_191() && theTarget.contactType_0 == Contact_Base.ContactType.Submarine && (theWeapon.method_167() == Weapon._WeaponType.DepthCharge || theWeapon.method_167() == Weapon._WeaponType.Rocket) && theTarget.method_112() != null)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon needs a precise target location", ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (theMount != null)
								{
									int num6;
									try
									{
										foreach (WeaponRec weaponRec in theMount.vmethod_10())
										{
											if (weaponRec.int_5 == theWeapon.DBID)
											{
												num6 += weaponRec.method_9();
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									if (num6 == 0)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is not loaded on mount", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								Weapon weapon2 = theWeapon;
								flag = null;
								bool? hintIsOperating = flag;
								ActiveUnit activeUnit = this.activeUnit_0;
								flag = null;
								weapon2.vmethod_31(hintIsOperating, activeUnit.vmethod_30(flag));
								Weapon weapon3 = theWeapon;
								flag = null;
								bool? hintIsOperating2 = flag;
								ActiveUnit activeUnit2 = this.activeUnit_0;
								flag = null;
								weapon3.vmethod_29(hintIsOperating2, activeUnit2.vmethod_28(flag));
								theWeapon.vmethod_15(false, this.activeUnit_0.vmethod_14(false));
								if (this.activeUnit_0.bool_3)
								{
									theWeapon.vmethod_10(this.activeUnit_0.vmethod_9());
								}
								else if (!this.activeUnit_0.bool_8 && !this.activeUnit_0.bool_6)
								{
									if (this.activeUnit_0.bool_5)
									{
										if (theWeapon.method_199())
										{
											Weapon weapon4 = theWeapon;
											ActiveUnit activeUnit3 = this.activeUnit_0;
											flag = null;
											double double_2 = activeUnit3.vmethod_30(flag);
											ActiveUnit activeUnit4 = this.activeUnit_0;
											flag = null;
											double double_3 = activeUnit4.vmethod_28(flag);
											Unit unit3 = theTarget;
											flag = null;
											double double_4 = unit3.vmethod_30(flag);
											Unit unit4 = theTarget;
											flag = null;
											weapon4.vmethod_10(Math2.smethod_17(double_2, double_3, double_4, unit4.vmethod_28(flag)));
										}
										else
										{
											theWeapon.vmethod_10(this.activeUnit_0.vmethod_9());
										}
									}
								}
								else
								{
									Weapon weapon5 = theWeapon;
									ActiveUnit activeUnit5 = this.activeUnit_0;
									flag = null;
									double double_5 = activeUnit5.vmethod_30(flag);
									ActiveUnit activeUnit6 = this.activeUnit_0;
									flag = null;
									double double_6 = activeUnit6.vmethod_28(flag);
									Unit unit5 = theTarget;
									flag = null;
									double double_7 = unit5.vmethod_30(flag);
									Unit unit6 = theTarget;
									flag = null;
									weapon5.vmethod_10(Math2.smethod_17(double_5, double_6, double_7, unit6.vmethod_28(flag)));
								}
								text2 = this.method_22(theWeapon, theTarget, ref ASL_atFiringUnit);
								if (string.CompareOrdinal(text2, "OK") != 0)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(text2, ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (this.activeUnit_0.bool_5)
								{
									if (!theWeapon.scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(theWeapon.scenario_0.method_39()))
									{
										if ((double)this.activeUnit_0.vmethod_14(false) > (double)theWeapon.float_40 + 0.1)
										{
											if (Class570.class280_0.method_12())
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
												{
													"Submarine too shallow to launch (Valid: ",
													Conversions.ToString((int)Math.Round((double)(theWeapon.float_39 * 3.28084f))),
													" to ",
													Conversions.ToString((int)Math.Round((double)(theWeapon.float_40 * 3.28084f))),
													" ft)"
												}), ActiveUnit_Weaponry.Enum36.const_2);
											}
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
											{
												"Submarine too shallow to launch (Valid: ",
												Conversions.ToString((int)Math.Round((double)theWeapon.float_39)),
												" to ",
												Conversions.ToString((int)Math.Round((double)theWeapon.float_40)),
												" m)"
											}), ActiveUnit_Weaponry.Enum36.const_2);
										}
										else if ((double)this.activeUnit_0.vmethod_14(false) < (double)theWeapon.float_39 - 0.1)
										{
											if (Class570.class280_0.method_12())
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
												{
													"Submarine too deep to launch (Valid: ",
													Conversions.ToString((int)Math.Round((double)(theWeapon.float_39 * 3.28084f))),
													" to ",
													Conversions.ToString((int)Math.Round((double)(theWeapon.float_40 * 3.28084f))),
													" ft)"
												}), ActiveUnit_Weaponry.Enum36.const_2);
											}
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
											{
												"Submarine too deep to launch (Valid: ",
												Conversions.ToString((int)Math.Round((double)theWeapon.float_39)),
												" to ",
												Conversions.ToString((int)Math.Round((double)theWeapon.float_40)),
												" m)"
											}), ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									else if ((double)this.activeUnit_0.vmethod_14(false) > (double)theWeapon.float_44 + 0.1)
									{
										if (Class570.class280_0.method_12())
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
											{
												"Submarine too shallow to launch (Valid: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.float_43 * 3.28084f))),
												" to ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.float_44 * 3.28084f))),
												" ft)"
											}), ActiveUnit_Weaponry.Enum36.const_2);
										}
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
										{
											"Submarine too shallow to launch (Valid: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.float_43)),
											" to ",
											Conversions.ToString((int)Math.Round((double)theWeapon.float_44)),
											" m)"
										}), ActiveUnit_Weaponry.Enum36.const_2);
									}
									else if ((double)this.activeUnit_0.vmethod_14(false) < (double)theWeapon.float_43 - 0.1)
									{
										if (Class570.class280_0.method_12())
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
											{
												"Submarine too deep to launch (Valid: ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.float_43 * 3.28084f))),
												" to ",
												Conversions.ToString((int)Math.Round((double)(theWeapon.float_44 * 3.28084f))),
												" ft)"
											}), ActiveUnit_Weaponry.Enum36.const_2);
										}
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(string.Concat(new string[]
										{
											"Submarine too deep to launch (Valid: ",
											Conversions.ToString((int)Math.Round((double)theWeapon.float_43)),
											" to ",
											Conversions.ToString((int)Math.Round((double)theWeapon.float_44)),
											" m)"
										}), ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								if (!IgnoreAircraftOrientation && this.activeUnit_0.bool_3 && this.activeUnit_0.vmethod_40() > 0f)
								{
									bool bool_;
									if (theMount != null)
									{
										bool_ = theMount.bool_14;
										if (!theMount.method_20(theTarget, null))
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is outside the weapon mount's engagement arc (within 5nm)", ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									else if (!this.method_9(theWeapon, theTarget) && !bool_)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is outside weapon boresight limits", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								if (theTarget.contactType_0 == Contact_Base.ContactType.Air)
								{
									if (theWeapon.struct36_0.bool_4)
									{
										float num7 = theWeapon.method_46(theTarget, true);
										if (Math.Abs(num7) < 130f)
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target aspect (" + Conversions.ToString(Math.Abs((int)Math.Round((double)num7))) + " deg) is out of envelope for a stern-chase weapon", ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									if (theWeapon.struct36_0.bool_5)
									{
										float num8 = theWeapon.method_46(theTarget, true);
										if (Math.Abs(num8) < 100f)
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target aspect (" + Conversions.ToString(Math.Abs((int)Math.Round((double)num8))) + " deg) is out of envelope for a rear-aspect weapon", ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
								}
								if (this.activeUnit_0.bool_3)
								{
									float num9 = this.activeUnit_0.vmethod_86().method_19(theTarget);
									if (num9 > 0f)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon cannot engage this target for another " + Conversions.ToString(Math.Round((double)num9, 1)) + "sec (OODA loop limitation)", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								else if (theMount != null && !theMount.bool_11)
								{
									float num10 = this.activeUnit_0.vmethod_86().method_19(theTarget);
									if (num10 > 0f)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon cannot engage this target for another " + Conversions.ToString(Math.Round((double)num10, 1)) + "sec (OODA loop limitation)", ActiveUnit_Weaponry.Enum36.const_2);
									}
								}
								if (theMount != null && num <= 5f && !theMount.method_20(theTarget, null))
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is outside the weapon mount's engagement arc (within 5nm)", ActiveUnit_Weaponry.Enum36.const_2);
								}
								if (theTarget.contactType_0 == Contact_Base.ContactType.ActivationPoint)
								{
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("OK", ActiveUnit_Weaponry.Enum36.const_0);
								}
								if (theTarget.activeUnit_0 == null)
								{
									if (!this.activeUnit_0.bool_2)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Contact vanished", ActiveUnit_Weaponry.Enum36.const_2);
									}
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("OK", ActiveUnit_Weaponry.Enum36.const_0);
								}
								else
								{
									if (theTarget.activeUnit_0.bool_6 || theTarget.activeUnit_0.bool_5 || theTarget.activeUnit_0.bool_8)
									{
										string text3 = this.method_18(theWeapon, theTarget);
										if (string.CompareOrdinal(text3, "OK") != 0)
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(text3, ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									Unit unit7 = theTarget;
									flag = null;
									double double_8 = unit7.vmethod_28(flag);
									Unit unit8 = theTarget;
									flag = null;
									if (Class442.smethod_1(double_8, unit8.vmethod_30(flag)))
									{
										if ((this.activeUnit_0.vmethod_14(false) > 0f && theTarget.activeUnit_0.vmethod_14(false) < 0f) || (this.activeUnit_0.vmethod_14(false) < 0f && theTarget.activeUnit_0.vmethod_14(false) > 0f))
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Cannot fire weapon through ice", ActiveUnit_Weaponry.Enum36.const_2);
										}
										if (this.activeUnit_0.vmethod_14(false) < 0f && theWeapon.method_2())
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Cannot fire missile while under ice", ActiveUnit_Weaponry.Enum36.const_2);
										}
										if (this.activeUnit_0.vmethod_14(false) > 0f && theWeapon.bool_7)
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Cannot use torpedo on ice", ActiveUnit_Weaponry.Enum36.const_2);
										}
										if (theTarget.method_136() && this.activeUnit_0.bool_6 && theWeapon.method_2())
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Cannot use missiles against under-ice submarine", ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									if (theWeapon.method_167() == Weapon._WeaponType.Laser && theTarget.activeUnit_0 != null && this.activeUnit_0.method_43(theTarget.activeUnit_0, ref this.activeUnit_0.scenario_0, true) != Unit.Enum123.const_1)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Laser weapon has no visual LOS to target", ActiveUnit_Weaponry.Enum36.const_2);
									}
									bool bool_2 = false;
									if (this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_1))
									{
										if (!this.activeUnit_0.bool_3 && theWeapon.method_167() == Weapon._WeaponType.Gun && theTarget.contactType_0 != Contact_Base.ContactType.Facility_Fixed && theTarget.contactType_0 != Contact_Base.ContactType.Facility_Mobile && theMount != null && !theMount.bool_13)
										{
											if (this.method_27(theMount, theTarget).Count == 0)
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Gun has no local control and no available directors", ActiveUnit_Weaponry.Enum36.const_2);
											}
											bool_2 = true;
										}
									}
									else
									{
										bool_2 = true;
									}
									List<ActiveUnit> list;
									if (!theTarget.method_133() && !theWeapon.method_255(theTarget, bool_2))
									{
										if (!theTarget.activeUnit_0.bool_6 && !theTarget.activeUnit_0.bool_8 && !theTarget.activeUnit_0.bool_5)
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is unable to engage imprecise target", ActiveUnit_Weaponry.Enum36.const_2);
										}
										foreach (Sensor sensor in this.activeUnit_0.method_78())
										{
											if (sensor.method_42(num2))
											{
												if (list == null)
												{
													list = this.activeUnit_0.vmethod_88().method_10(false);
												}
												float num11;
												if (theWeapon.method_167() == Weapon._WeaponType.Gun)
												{
													num11 = num2;
												}
												else
												{
													num11 = num;
												}
												Sensor sensor2 = sensor;
												Sensor.Enum114 enum114_ = Sensor.Enum114.const_2;
												ActiveUnit activeUnit_ = this.activeUnit_0;
												ActiveUnit activeUnit_2 = theTarget.activeUnit_0;
												List<GeoPoint> list2 = null;
												float float_ = num11;
												Lazy<ObservableDictionary<int, EmissionContainer>> lazy = null;
												List<ActiveUnit> list_ = list;
												flag = null;
												bool? flag2 = null;
												Unit.Enum123? @enum = null;
												bool? flag3 = null;
												if (sensor2.method_87(enum114_, activeUnit_, activeUnit_2, ref list2, float_, ref lazy, list_, ref flag, ref flag2, ref @enum, ref flag3))
												{
													if (theWeapon.method_167() == Weapon._WeaponType.Dispenser && num11 * 1852f > (float)theWeapon.warhead_0[0].short_1)
													{
														return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is unable to engage imprecise target that is out of weapon range", ActiveUnit_Weaponry.Enum36.const_2);
													}
													if (theWeapon.bool_7 && this.activeUnit_0.bool_3 && theTarget.contactType_0 == Contact_Base.ContactType.Submarine && (double)num11 > 0.4)
													{
														return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is unable to engage imprecise target since ASW torpedo must be dropped within 0.4nm of contact/aimpoint", ActiveUnit_Weaponry.Enum36.const_2);
													}
													if (this.method_19(ref this.activeUnit_0, ref theWeapon, ref theTarget, ManualFire) < num11)
													{
														return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is unable to engage imprecise target that is out of weapon range", ActiveUnit_Weaponry.Enum36.const_2);
													}
													if (theWeapon.method_256(num11, theTarget))
													{
														return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is unable to engage imprecise target that is within weapon minimum range", ActiveUnit_Weaponry.Enum36.const_2);
													}
													bool flag4 = true;
													IL_1362:
													if (!flag4)
													{
														return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is unable to engage imprecise target", ActiveUnit_Weaponry.Enum36.const_2);
													}
													goto IL_1377;
												}
											}
										}
										goto IL_1362;
									}
									IL_1377:
									Lazy<ObservableDictionary<int, EmissionContainer>> lazy2 = new Lazy<ObservableDictionary<int, EmissionContainer>>();
									if (theWeapon.method_169() == Weapon.WeaponGuidanceType.Passive && (!theWeapon.method_2() || theTarget.contactType_0 != Contact_Base.ContactType.Air || !this.activeUnit_0.bool_3 || !((Aircraft)this.activeUnit_0).bool_38))
									{
										Sensor sensor3 = theWeapon.vmethod_96()[0];
										Sensor.Enum114 enum114_2 = Sensor.Enum114.const_2;
										ActiveUnit activeUnit_3 = theWeapon;
										ActiveUnit activeUnit_4 = theTarget.activeUnit_0;
										List<GeoPoint> list2 = null;
										float float_2 = num;
										List<ActiveUnit> list_2 = null;
										bool? flag3 = null;
										bool? flag2 = null;
										Unit.Enum123? @enum = null;
										flag = null;
										if (!sensor3.method_87(enum114_2, activeUnit_3, activeUnit_4, ref list2, float_2, ref lazy2, list_2, ref flag3, ref flag2, ref @enum, ref flag))
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon must detect target prior to firing", ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									CommDevice[] array2 = theWeapon.vmethod_94();
									if (array2.Length > 0 && !array2[0].bool_11 && theWeapon.method_189().method_11(array2, this.activeUnit_0) == null)
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Unable to connect to firing unit with mandatory datalink", ActiveUnit_Weaponry.Enum36.const_2);
									}
									if (theWeapon.struct36_0.bool_0 || theWeapon.struct36_0.bool_1)
									{
										bool flag5 = false;
										bool flag6 = false;
										bool flag7 = false;
										List<Sensor> list3 = new List<Sensor>();
										foreach (Sensor sensor4 in this.activeUnit_0.method_78())
										{
											if (sensor4.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor4.method_79(ref theWeapon))
											{
												list3.Add(sensor4);
											}
										}
										if (list3.Count > 0)
										{
											flag5 = true;
											List<Sensor> list4 = new List<Sensor>();
											try
											{
												foreach (Sensor sensor5 in list3)
												{
													if (theWeapon.method_169() == Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive)
													{
														list4.Add(sensor5);
													}
													else if (sensor5.method_41().Count < sensor5.int_0 || sensor5.method_82(ref theTarget))
													{
														list4.Add(sensor5);
													}
												}
											}
											finally
											{
												List<Sensor>.Enumerator enumerator2;
												((IDisposable)enumerator2).Dispose();
											}
											if (list4.Count > 0)
											{
												flag6 = true;
												new List<Sensor>();
												Unit.Enum123? enum2 = null;
												bool? flag8 = null;
												bool? flag9 = null;
												bool? flag10 = null;
												try
												{
													foreach (Sensor sensor6 in list4)
													{
														if (sensor6.sensor_Type_0 == Sensor.Sensor_Type.Radar && list == null)
														{
															list = this.activeUnit_0.vmethod_88().method_10(false);
														}
														if (sensor6.method_118(this.activeUnit_0, ref theTarget, ref this.activeUnit_0.scenario_0, num, list, this.activeUnit_0.bool_6, false, ref flag8, ref flag9, ref enum2, ref flag10) == Sensor.Enum115.const_1)
														{
															SuitableDirectorSensor = sensor6;
															flag7 = true;
															break;
														}
													}
												}
												finally
												{
													List<Sensor>.Enumerator enumerator3;
													((IDisposable)enumerator3).Dispose();
												}
											}
										}
										if ((!flag5 || !flag6 || !flag7) && theWeapon.struct36_0.bool_2)
										{
											List<ActiveUnit> list5 = theWeapon.method_244(this.activeUnit_0.vmethod_7(false), theTarget);
											try
											{
												foreach (ActiveUnit activeUnit7 in list5)
												{
													if (activeUnit7 != null)
													{
														ActiveUnit_Sensory activeUnit_Sensory = activeUnit7.vmethod_88();
														Contact contact_ = theTarget;
														Weapon weapon6 = theWeapon;
														flag = null;
														bool? flag2 = null;
														Unit.Enum123? @enum = null;
														bool? flag3 = null;
														Sensor sensor7;
														if (activeUnit_Sensory.method_41(contact_, weapon6, ref sensor7, ref flag, ref flag2, ref @enum, ref flag3))
														{
															SuitableDirectorSensor = sensor7;
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
										if (SuitableDirectorSensor == null)
										{
											if (!flag5)
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("No weapons director available to illuminate the target", ActiveUnit_Weaponry.Enum36.const_2);
											}
											if (!flag6)
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("All illumination channels suitable for this weapon are in use", ActiveUnit_Weaponry.Enum36.const_2);
											}
											if (!flag7)
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("No directors are able to illuminate this target (insufficient reflection, no LOS etc)", ActiveUnit_Weaponry.Enum36.const_2);
											}
										}
									}
									if (theWeapon.method_169() == Weapon.WeaponGuidanceType.BeamRiding)
									{
										bool flag11 = false;
										bool flag12 = false;
										foreach (Sensor sensor8 in this.activeUnit_0.vmethod_96())
										{
											if (sensor8.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor8.method_79(ref theWeapon))
											{
												flag11 = true;
												if (sensor8.method_41().Count < sensor8.int_0 || sensor8.method_82(ref theTarget))
												{
													SuitableDirectorSensor = sensor8;
													flag12 = true;
												}
											}
										}
										if (!flag11)
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("No weapons director available to illuminate the target", ActiveUnit_Weaponry.Enum36.const_2);
										}
										if (!flag12)
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("All illumination channels suitable for this weapon are in use", ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									if (!this.bool_2 && this.method_28(theWeapon, theTarget))
									{
										Tuple<int, string> tuple = new Tuple<int, string>(theWeapon.DBID, theTarget.string_0);
										this.hashSet_0.Add(Conversions.ToString(theWeapon.DBID) + "_" + theTarget.string_0);
										if (this.concurrentDictionary_0 != null && this.concurrentDictionary_0.ContainsKey(tuple))
										{
											if (Operators.CompareString(this.concurrentDictionary_0[tuple], "OK", false) != 0)
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(this.concurrentDictionary_0[tuple], ActiveUnit_Weaponry.Enum36.const_2);
											}
										}
										else
										{
											string text4 = this.method_25(theTarget, theWeapon);
											if (this.concurrentDictionary_0 == null)
											{
												this.concurrentDictionary_0 = new ConcurrentDictionary<Tuple<int, string>, string>();
											}
											this.concurrentDictionary_0.TryAdd(tuple, text4);
											if (Operators.CompareString(text4, "OK", false) != 0)
											{
												return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>(text4, ActiveUnit_Weaponry.Enum36.const_2);
											}
										}
									}
									if (theWeapon.method_0() && theWeapon.method_201() && theTarget.method_103() && !this.activeUnit_0.vmethod_88().method_1(theTarget, 5f, ActiveUnit_Sensory.Enum34.const_1) && !this.method_24(theWeapon, theTarget))
									{
										return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Firing unit must obtain (from itself or another CEC-enabled platform) a high-quality track on the target before firing", ActiveUnit_Weaponry.Enum36.const_1);
									}
									if (theWeapon.class394_0.bool_5)
									{
										if (!theTarget.method_67())
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Target is not radiating", ActiveUnit_Weaponry.Enum36.const_2);
										}
										Weapon weapon7 = theWeapon;
										ObservableDictionary<int, EmissionContainer> observableDictionary_ = theTarget.method_68();
										Side side_ = this.activeUnit_0.vmethod_7(false);
										Contact contact_2 = theTarget;
										bool bool_3 = false;
										Random random = GameGeneral.smethod_5();
										if (!weapon7.method_217(observableDictionary_, side_, contact_2, bool_3, ref random))
										{
											return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("No threat emitters are currently radiating", ActiveUnit_Weaponry.Enum36.const_2);
										}
									}
									return new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("OK", ActiveUnit_Weaponry.Enum36.const_0);
								}
							}
						}
					}
					result = new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Weapon is decoy, will deploy automatically", ActiveUnit_Weaponry.Enum36.const_2);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101240", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ValueTuple<string, ActiveUnit_Weaponry.Enum36>("Error occured", ActiveUnit_Weaponry.Enum36.const_2);
			}
			return result;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x000C6390 File Offset: 0x000C4590
		private bool method_24(Weapon weapon_6, Contact contact_0)
		{
			bool result;
			if (!weapon_6.struct36_0.bool_19)
			{
				result = false;
			}
			else if (contact_0.method_112() != null)
			{
				result = false;
			}
			else
			{
				foreach (ActiveUnit activeUnit in this.activeUnit_0.vmethod_7(false).activeUnit_0)
				{
					if (activeUnit.vmethod_88().method_1(contact_0, 5f, ActiveUnit_Sensory.Enum34.const_1) && weapon_6.method_189().method_11(weapon_6.vmethod_94(), activeUnit) != null)
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000C6410 File Offset: 0x000C4610
		public string method_25(Contact contact_0, Weapon weapon_6)
		{
			string result;
			if (Information.IsNothing(contact_0))
			{
				result = "Target is undefined";
			}
			else
			{
				float num;
				if (this.activeUnit_0.bool_3)
				{
					num = this.activeUnit_0.vmethod_9();
				}
				else
				{
					num = 0f;
				}
				GeoPoint geoPoint = null;
				weapon_6.method_178(this.activeUnit_0);
				Weapon.smethod_15(weapon_6, this.activeUnit_0.scenario_0, this.activeUnit_0.bool_3 || this.activeUnit_0.method_2());
				string text;
				if (contact_0.method_91())
				{
					Scenario scenario_ = this.activeUnit_0.scenario_0;
					int dbid = weapon_6.DBID;
					ActiveUnit firingUnit = this.activeUnit_0;
					double launchLongitude = this.activeUnit_0.vmethod_28(null);
					double launchLatitude = this.activeUnit_0.vmethod_30(null);
					float launchAltitude = (float)((int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
					int launchSpeed = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
					float initialHeading = num;
					ActiveUnit.Throttle throttleSetting = ActiveUnit.Throttle.Cruise;
					GeoPoint geoPoint2 = null;
					float num2 = 0f;
					text = this.method_52(scenario_, dbid, firingUnit, launchLongitude, launchLatitude, launchAltitude, launchSpeed, contact_0, initialHeading, throttleSetting, ref geoPoint2, ref num2);
				}
				else if (contact_0.method_109())
				{
					Scenario scenario_2 = this.activeUnit_0.scenario_0;
					int dbid2 = weapon_6.DBID;
					ActiveUnit theFiringUnit = this.activeUnit_0;
					double launchLongitude2 = this.activeUnit_0.vmethod_28(null);
					double launchLatitude2 = this.activeUnit_0.vmethod_30(null);
					float launchAltitude2 = (float)((int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
					int launchSpeed2 = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
					float initialHeading2 = 0f;
					ActiveUnit.Throttle throttleSetting2 = ActiveUnit.Throttle.Cruise;
					float num2 = 0f;
					text = this.method_53(scenario_2, dbid2, theFiringUnit, launchLongitude2, launchLatitude2, launchAltitude2, launchSpeed2, contact_0, initialHeading2, throttleSetting2, ref num2);
				}
				else
				{
					float num3 = 0.1f;
					int num4;
					if (weapon_6.vmethod_49()[0].enum112_0 == Engine.Enum112.const_9)
					{
						num4 = int.MaxValue;
					}
					else
					{
						num4 = (int)Math.Round((double)((float)weapon_6.vmethod_67()[0].int_0 * (1f - num3)));
					}
					Scenario scenario_3 = this.activeUnit_0.scenario_0;
					int dbid3 = weapon_6.DBID;
					ActiveUnit firingUnit2 = this.activeUnit_0;
					double launchLongitude3 = this.activeUnit_0.vmethod_28(null);
					double launchLatitude3 = this.activeUnit_0.vmethod_30(null);
					float launchAltitude3 = (float)((int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
					int launchSpeed3 = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
					double targetLongitude = contact_0.vmethod_28(null);
					double targetLatitude = contact_0.vmethod_30(null);
					float targetHeading = contact_0.vmethod_9();
					bool bool_ = contact_0.bool_18;
					int targetSpeed = (int)Math.Round((double)contact_0.vmethod_40());
					bool bool_2 = contact_0.bool_17;
					float targetAltitude = contact_0.vmethod_14(false);
					bool bool_3 = contact_0.bool_19;
					Contact_Base.ContactType contactType_ = contact_0.contactType_0;
					string text2 = null;
					float initialHeading3 = num;
					ActiveUnit.Throttle throttleSetting3 = ActiveUnit.Throttle.Full;
					int customWeaponFuel = num4;
					List<float> xdat = null;
					List<float> ydat = null;
					float num2 = 0f;
					text = ActiveUnit_Weaponry.smethod_5(scenario_3, dbid3, firingUnit2, launchLongitude3, launchLatitude3, launchAltitude3, launchSpeed3, targetLongitude, targetLatitude, targetHeading, bool_, targetSpeed, bool_2, targetAltitude, bool_3, contactType_, ref geoPoint, ref text2, initialHeading3, throttleSetting3, customWeaponFuel, xdat, ydat, ref num2);
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000C66C8 File Offset: 0x000C48C8
		public string method_26(Weapon weapon_6, Contact contact_0)
		{
			string result;
			try
			{
				if (Information.IsNothing(contact_0))
				{
					result = "Target is null";
				}
				else
				{
					if (weapon_6.method_2() && weapon_6.method_199())
					{
						Contact_Base.ContactType contactType_ = contact_0.contactType_0;
						if ((contactType_ == Contact_Base.ContactType.Surface || contactType_ - Contact_Base.ContactType.Facility_Fixed <= 1) && this.activeUnit_0.doctrine_0.method_167(this.activeUnit_0.scenario_0, false, false, false).Value != Doctrine.Enum58.const_1)
						{
							return "Unit is not authorized to use SAMs against surface targets";
						}
					}
					if (weapon_6.int_20 > 0 && contact_0.vmethod_40() > (float)weapon_6.int_20 * 1.2f)
					{
						result = string.Concat(new string[]
						{
							"Target speed (",
							Conversions.ToString((int)Math.Round((double)contact_0.vmethod_40())),
							" kts) is much higher than the weapon's maximum target speed (",
							Conversions.ToString(weapon_6.int_20),
							" kts)"
						});
					}
					else
					{
						if (!contact_0.method_91() && contact_0.contactType_0 != Contact_Base.ContactType.Surface)
						{
							if (weapon_6.float_42 > 0f && contact_0.vmethod_14(false) > weapon_6.float_42)
							{
								if (Class570.class280_0.method_12())
								{
									return string.Concat(new string[]
									{
										"Target altitude (",
										Conversions.ToString((int)Math.Round((double)(contact_0.vmethod_14(false) * 3.28084f))),
										" ft) is higher than the weapon's ceiling (",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_42 * 3.28084f))),
										" ft)"
									});
								}
								return string.Concat(new string[]
								{
									"Target altitude (",
									Conversions.ToString((int)Math.Round((double)contact_0.vmethod_14(false))),
									" m) is higher than the weapon's ceiling (",
									Conversions.ToString(weapon_6.float_42),
									" m)"
								});
							}
							else if (weapon_6.float_41 > 0f && contact_0.vmethod_14(false) < weapon_6.float_41)
							{
								if (Class570.class280_0.method_12())
								{
									return string.Concat(new string[]
									{
										"Target altitude (",
										Conversions.ToString((int)Math.Round((double)(contact_0.vmethod_14(false) * 3.28084f))),
										" ft) is lower than the weapon's minimum engagement altitude (",
										Conversions.ToString((int)Math.Round((double)(weapon_6.float_41 * 3.28084f))),
										" ft)"
									});
								}
								return string.Concat(new string[]
								{
									"Target altitude (",
									Conversions.ToString((int)Math.Round((double)contact_0.vmethod_14(false))),
									" m) is lower than the weapon's minimum engagement altitude (",
									Conversions.ToString(weapon_6.float_41),
									" m)"
								});
							}
						}
						if (contact_0.contactType_0 == Contact_Base.ContactType.ActivationPoint && !weapon_6.struct36_0.bool_14)
						{
							result = "Weapon is not BOL-capable";
						}
						else if (!weapon_6.method_191() && contact_0.contactType_0 == Contact_Base.ContactType.Submarine && (weapon_6.method_167() == Weapon._WeaponType.DepthCharge || weapon_6.method_167() == Weapon._WeaponType.Rocket) && contact_0.method_112() != null)
						{
							result = "Weapon needs a precise target location";
						}
						else
						{
							Weapon weapon = weapon_6;
							Scenario scenario_ = this.activeUnit_0.scenario_0;
							bool? hintIsOperating = null;
							if (!weapon.method_253(scenario_, ref contact_0, ref hintIsOperating))
							{
								result = "Weapon is not suitable for this target";
							}
							else
							{
								float num;
								if (weapon_6.method_167() == Weapon._WeaponType.Gun)
								{
									num = this.activeUnit_0.method_37(contact_0, 0f);
								}
								else
								{
									num = this.activeUnit_0.method_36(contact_0);
								}
								if (weapon_6.method_167() == Weapon._WeaponType.Dispenser && (double)(num * 1852f) > (double)weapon_6.warhead_0[0].short_1 / 2.0)
								{
									result = "Target is out of weapon range";
								}
								else
								{
									float num2;
									if (weapon_6.method_2() && this.method_28(weapon_6, contact_0) && contact_0.vmethod_40() != 0f)
									{
										if (contact_0.contactType_0 == Contact_Base.ContactType.Surface)
										{
											num2 = weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false);
										}
										else
										{
											num2 = (float)((double)weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false) * 1.5);
										}
									}
									else
									{
										num2 = weapon_6.method_181(this.activeUnit_0, contact_0, false, null, false);
									}
									if (num2 < num)
									{
										result = "Target is out of weapon range";
									}
									else if (contact_0.contactType_0 == Contact_Base.ContactType.ActivationPoint)
									{
										result = "OK";
									}
									else if (Information.IsNothing(contact_0.activeUnit_0))
									{
										result = "Unit vanished";
									}
									else
									{
										if (contact_0.activeUnit_0.bool_6 || contact_0.activeUnit_0.bool_8 || contact_0.activeUnit_0.bool_5)
										{
											string text = this.method_18(weapon_6, contact_0);
											if (string.CompareOrdinal(text, "OK") != 0)
											{
												return text;
											}
										}
										if (!contact_0.method_133() && !weapon_6.method_255(contact_0, false))
										{
											result = "Weapon is unable to engage imprecise target";
										}
										else
										{
											Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
											if (weapon_6.method_169() == Weapon.WeaponGuidanceType.Passive)
											{
												Sensor sensor = weapon_6.vmethod_96()[0];
												Sensor.Enum114 enum114_ = Sensor.Enum114.const_2;
												ActiveUnit activeUnit_ = weapon_6;
												ActiveUnit activeUnit_2 = contact_0.activeUnit_0;
												List<GeoPoint> list = null;
												float float_ = num;
												List<ActiveUnit> list_ = null;
												hintIsOperating = null;
												bool? flag = null;
												Unit.Enum123? @enum = null;
												bool? flag2 = null;
												if (!sensor.method_87(enum114_, activeUnit_, activeUnit_2, ref list, float_, ref lazy, list_, ref hintIsOperating, ref flag, ref @enum, ref flag2))
												{
													return "Weapon must detect target prior to firing";
												}
											}
											if (weapon_6.struct36_0.bool_0 || weapon_6.struct36_0.bool_1)
											{
												bool flag3 = false;
												bool flag4 = false;
												bool flag5 = false;
												List<Sensor> list2 = new List<Sensor>();
												foreach (Sensor sensor2 in this.activeUnit_0.vmethod_96())
												{
													if (sensor2.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor2.method_79(ref weapon_6))
													{
														list2.Add(sensor2);
													}
												}
												Sensor expression;
												if (list2.Count > 0)
												{
													flag3 = true;
													List<Sensor> list3 = new List<Sensor>();
													try
													{
														foreach (Sensor sensor3 in list2)
														{
															if (weapon_6.method_169() == Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive)
															{
																list3.Add(sensor3);
															}
															else if (sensor3.method_41().Count < sensor3.int_0 || sensor3.method_82(ref contact_0))
															{
																list3.Add(sensor3);
															}
														}
													}
													finally
													{
														List<Sensor>.Enumerator enumerator;
														((IDisposable)enumerator).Dispose();
													}
													if (list3.Count > 0)
													{
														flag4 = true;
														new List<Sensor>();
														Unit.Enum123? enum2 = null;
														bool? flag6 = null;
														bool? flag7 = null;
														bool? flag8 = null;
														try
														{
															foreach (Sensor sensor4 in list3)
															{
																List<ActiveUnit> list4;
																if (sensor4.sensor_Type_0 == Sensor.Sensor_Type.Radar && Information.IsNothing(list4))
																{
																	list4 = this.activeUnit_0.vmethod_88().method_10(false);
																}
																if (sensor4.method_118(this.activeUnit_0, ref contact_0, ref this.activeUnit_0.scenario_0, num, list4, this.activeUnit_0.bool_6, false, ref flag6, ref flag7, ref enum2, ref flag8) == Sensor.Enum115.const_1)
																{
																	expression = sensor4;
																	flag5 = true;
																	break;
																}
															}
														}
														finally
														{
															List<Sensor>.Enumerator enumerator2;
															((IDisposable)enumerator2).Dispose();
														}
													}
												}
												if ((!flag3 || !flag4 || !flag5) && weapon_6.struct36_0.bool_2)
												{
													List<ActiveUnit> list5 = weapon_6.method_244(this.activeUnit_0.vmethod_7(false), contact_0);
													try
													{
														foreach (ActiveUnit activeUnit in list5)
														{
															if (!Information.IsNothing(activeUnit))
															{
																ActiveUnit_Sensory activeUnit_Sensory = activeUnit.vmethod_88();
																Contact contact_ = contact_0;
																Weapon weapon2 = weapon_6;
																bool? flag2 = null;
																bool? flag = null;
																Unit.Enum123? @enum = null;
																hintIsOperating = null;
																Sensor sensor5;
																if (activeUnit_Sensory.method_41(contact_, weapon2, ref sensor5, ref flag2, ref flag, ref @enum, ref hintIsOperating))
																{
																	expression = sensor5;
																}
															}
														}
													}
													finally
													{
														List<ActiveUnit>.Enumerator enumerator3;
														((IDisposable)enumerator3).Dispose();
													}
												}
												if (Information.IsNothing(expression))
												{
													if (!flag3)
													{
														return "No weapons director available to illuminate the target";
													}
													if (!flag4)
													{
														return "All illumination channels suitable for this weapon are in use";
													}
													if (!flag5)
													{
														return "All directors are unable to illuminate this target (insufficient reflection, no LOS etc)";
													}
												}
											}
											if (weapon_6.method_169() == Weapon.WeaponGuidanceType.BeamRiding)
											{
												bool flag9 = false;
												bool flag10 = false;
												foreach (Sensor sensor6 in this.activeUnit_0.vmethod_96())
												{
													if (sensor6.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor6.method_79(ref weapon_6))
													{
														flag9 = true;
														if (sensor6.method_41().Count < sensor6.int_0 || sensor6.method_82(ref contact_0))
														{
															Sensor expression = sensor6;
															flag10 = true;
														}
													}
												}
												if (!flag9)
												{
													return "No weapons director available to illuminate the target";
												}
												if (!flag10)
												{
													return "All illumination channels suitable for this weapon are in use";
												}
											}
											float num3;
											if (this.activeUnit_0.bool_3)
											{
												num3 = this.activeUnit_0.vmethod_9();
											}
											else
											{
												num3 = 0f;
											}
											GeoPoint geoPoint = null;
											if (this.method_28(weapon_6, contact_0))
											{
												Tuple<int, string> tuple = new Tuple<int, string>(weapon_6.DBID, contact_0.string_0);
												if (this.concurrentDictionary_0 != null && this.concurrentDictionary_0.ContainsKey(tuple))
												{
													if (Operators.CompareString(this.concurrentDictionary_0[tuple], "OK", false) != 0)
													{
														return this.concurrentDictionary_0[tuple];
													}
												}
												else
												{
													string text2;
													if (contact_0.method_91())
													{
														Scenario scenario_2 = this.activeUnit_0.scenario_0;
														int dbid = weapon_6.DBID;
														ActiveUnit firingUnit = this.activeUnit_0;
														ActiveUnit activeUnit2 = this.activeUnit_0;
														hintIsOperating = null;
														double launchLongitude = activeUnit2.vmethod_28(hintIsOperating);
														ActiveUnit activeUnit3 = this.activeUnit_0;
														hintIsOperating = null;
														double launchLatitude = activeUnit3.vmethod_30(hintIsOperating);
														float launchAltitude = (float)((int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
														int launchSpeed = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
														Contact theTarget = contact_0;
														float initialHeading = num3;
														ActiveUnit.Throttle throttleSetting = ActiveUnit.Throttle.Cruise;
														GeoPoint geoPoint2 = null;
														float num4 = 0f;
														text2 = this.method_52(scenario_2, dbid, firingUnit, launchLongitude, launchLatitude, launchAltitude, launchSpeed, theTarget, initialHeading, throttleSetting, ref geoPoint2, ref num4);
													}
													else if (contact_0.method_109())
													{
														Scenario scenario_3 = this.activeUnit_0.scenario_0;
														int dbid2 = weapon_6.DBID;
														ActiveUnit theFiringUnit = this.activeUnit_0;
														ActiveUnit activeUnit4 = this.activeUnit_0;
														hintIsOperating = null;
														double launchLongitude2 = activeUnit4.vmethod_28(hintIsOperating);
														ActiveUnit activeUnit5 = this.activeUnit_0;
														hintIsOperating = null;
														double launchLatitude2 = activeUnit5.vmethod_30(hintIsOperating);
														float launchAltitude2 = (float)((int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
														int launchSpeed2 = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
														Contact theTarget2 = contact_0;
														float initialHeading2 = 0f;
														ActiveUnit.Throttle throttleSetting2 = ActiveUnit.Throttle.Cruise;
														float num4 = 0f;
														text2 = this.method_53(scenario_3, dbid2, theFiringUnit, launchLongitude2, launchLatitude2, launchAltitude2, launchSpeed2, theTarget2, initialHeading2, throttleSetting2, ref num4);
													}
													else
													{
														Scenario scenario_4 = this.activeUnit_0.scenario_0;
														int dbid3 = weapon_6.DBID;
														ActiveUnit firingUnit2 = this.activeUnit_0;
														ActiveUnit activeUnit6 = this.activeUnit_0;
														hintIsOperating = null;
														double launchLongitude3 = activeUnit6.vmethod_28(hintIsOperating);
														ActiveUnit activeUnit7 = this.activeUnit_0;
														hintIsOperating = null;
														double launchLatitude3 = activeUnit7.vmethod_30(hintIsOperating);
														float launchAltitude3 = (float)((int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
														int launchSpeed3 = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
														Unit unit = contact_0;
														hintIsOperating = null;
														double targetLongitude = unit.vmethod_28(hintIsOperating);
														Unit unit2 = contact_0;
														hintIsOperating = null;
														double targetLatitude = unit2.vmethod_30(hintIsOperating);
														float targetHeading = contact_0.vmethod_9();
														bool bool_ = contact_0.bool_18;
														int targetSpeed = (int)Math.Round((double)contact_0.vmethod_40());
														bool bool_2 = contact_0.bool_17;
														float targetAltitude = contact_0.vmethod_14(false);
														bool bool_3 = contact_0.bool_19;
														Contact_Base.ContactType contactType_2 = contact_0.contactType_0;
														string text3 = null;
														float initialHeading3 = num3;
														ActiveUnit.Throttle throttleSetting3 = ActiveUnit.Throttle.Cruise;
														int customWeaponFuel = (int)Math.Round((double)((float)weapon_6.vmethod_67()[0].int_0) * 0.8999999985098839);
														List<float> xdat = null;
														List<float> ydat = null;
														float num4 = 0f;
														text2 = ActiveUnit_Weaponry.smethod_5(scenario_4, dbid3, firingUnit2, launchLongitude3, launchLatitude3, launchAltitude3, launchSpeed3, targetLongitude, targetLatitude, targetHeading, bool_, targetSpeed, bool_2, targetAltitude, bool_3, contactType_2, ref geoPoint, ref text3, initialHeading3, throttleSetting3, customWeaponFuel, xdat, ydat, ref num4);
													}
													if (this.concurrentDictionary_0 == null)
													{
														this.concurrentDictionary_0 = new ConcurrentDictionary<Tuple<int, string>, string>();
													}
													this.concurrentDictionary_0.TryAdd(tuple, text2);
													if (Operators.CompareString(text2, "OK", false) != 0)
													{
														return text2;
													}
												}
											}
											if (weapon_6.class394_0.bool_5)
											{
												if (!contact_0.method_67())
												{
													return "Target is not radiating";
												}
												Weapon weapon3 = weapon_6;
												ObservableDictionary<int, EmissionContainer> observableDictionary_ = contact_0.method_68();
												Side side_ = this.activeUnit_0.vmethod_7(false);
												Contact contact_2 = contact_0;
												bool bool_4 = false;
												Random random = GameGeneral.smethod_5();
												if (!weapon3.method_217(observableDictionary_, side_, contact_2, bool_4, ref random))
												{
													return "No threat emitters are currently radiating";
												}
											}
											result = "OK";
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100307", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error occured";
			}
			return result;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x000C72D8 File Offset: 0x000C54D8
		private List<Sensor> method_27(Mount mount_0, Contact contact_0)
		{
			List<Sensor> list = new List<Sensor>();
			Unit.Enum123? @enum = null;
			bool? flag = null;
			bool? flag2 = null;
			bool? flag3 = null;
			List<Sensor> result;
			try
			{
				List<ActiveUnit> list2 = null;
				foreach (Sensor sensor in this.activeUnit_0.vmethod_96())
				{
					if (sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational && mount_0.hashSet_1.Contains(sensor.DBID) && (sensor.method_85() || sensor.method_41().Contains(contact_0)))
					{
						if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar && Information.IsNothing(list2))
						{
							list2 = this.activeUnit_0.vmethod_88().method_10(false);
						}
						Sensor sensor2 = sensor;
						Sensor.Enum114 enum114_ = Sensor.Enum114.const_2;
						ActiveUnit activeUnit_ = this.activeUnit_0;
						ActiveUnit activeUnit_2 = contact_0.activeUnit_0;
						List<GeoPoint> list3 = null;
						float float_ = this.activeUnit_0.method_36(contact_0);
						Lazy<ObservableDictionary<int, EmissionContainer>> lazy = null;
						if (sensor2.method_87(enum114_, activeUnit_, activeUnit_2, ref list3, float_, ref lazy, list2, ref flag, ref flag2, ref @enum, ref flag3))
						{
							list.Add(sensor);
						}
					}
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100308", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000C742C File Offset: 0x000C562C
		private bool method_28(Weapon weapon_6, Contact contact_0)
		{
			bool result;
			try
			{
				Weapon._WeaponType weaponType = weapon_6.method_167();
				if (weaponType != Weapon._WeaponType.GuidedWeapon)
				{
					if (weaponType != Weapon._WeaponType.Torpedo)
					{
						if (weaponType != Weapon._WeaponType.RV)
						{
							result = false;
						}
						else
						{
							result = true;
						}
					}
					else
					{
						result = true;
					}
				}
				else if (weapon_6.vmethod_3() && weapon_6.method_276())
				{
					result = false;
				}
				else if (weapon_6.method_152())
				{
					result = false;
				}
				else
				{
					Contact_Base.ContactType contactType_ = contact_0.contactType_0;
					if (contactType_ > Contact_Base.ContactType.Missile)
					{
						if (contactType_ != Contact_Base.ContactType.Orbital)
						{
							if (weapon_6.struct36_0.bool_15 && weapon_6.warhead_0.Length > 0 && weapon_6.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon)
							{
								return false;
							}
							if (this.activeUnit_0.bool_3)
							{
								return true;
							}
							if (weapon_6.method_199())
							{
								Contact_Base.ContactType contactType_2 = contact_0.contactType_0;
								if (contactType_2 == Contact_Base.ContactType.Surface || contactType_2 - Contact_Base.ContactType.Facility_Fixed <= 1)
								{
									return true;
								}
							}
							return false;
						}
					}
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100309", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000C7554 File Offset: 0x000C5754
		public void method_29(float float_0, ref Weapon weapon_6)
		{
			if (weapon_6.method_141() <= 0f)
			{
				List<string> list = new List<string>();
				ActiveUnit_Weaponry.Enum37 @enum = ActiveUnit_Weaponry.Enum37.const_0;
				int num = 0;
				int num2 = 0;
				try
				{
					if (weapon_6.vmethod_96().Length > 0)
					{
						Sensor[] array = weapon_6.vmethod_96();
						int i = 0;
						while (i < array.Length)
						{
							Sensor sensor = array[i];
							if (sensor.sensor_Type_0 == Sensor.Sensor_Type.ESM)
							{
								if (weapon_6.class394_0.bool_5)
								{
									goto IL_7B;
								}
							}
							else if (sensor.sensor_Type_0 != Sensor.Sensor_Type.ECM && sensor.method_63(this.activeUnit_0))
							{
								goto IL_7B;
							}
							IL_81:
							checked
							{
								i++;
								continue;
								IL_7B:;
							}
							num2++;
							goto IL_81;
						}
					}
					if ((weapon_6.vmethod_96().Length > 0 || weapon_6.method_169() == Weapon.WeaponGuidanceType.TVM) && weapon_6.vmethod_142().vmethod_3().activeUnit_0.vmethod_7(false).method_66(weapon_6))
					{
						List<ActiveUnit_Weaponry.FireQueueEntry> list2 = new List<ActiveUnit_Weaponry.FireQueueEntry>();
						try
						{
							foreach (Mount mount in this.activeUnit_0.vmethod_51())
							{
								if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational && mount.method_28() <= 1f)
								{
									try
									{
										foreach (WeaponRec weaponRec in mount.vmethod_10())
										{
											if (weaponRec.method_9() > 0)
											{
												weaponRec.mount_0 = mount;
												if (this.method_30(weaponRec, mount, weapon_6))
												{
													ActiveUnit activeUnit_ = this.activeUnit_0;
													ActiveUnit activeUnit = weapon_6;
													ActiveUnit_Weaponry.FireQueueEntry item = new ActiveUnit_Weaponry.FireQueueEntry(ref float_0, activeUnit_, ref weaponRec, ref activeUnit, ref mount);
													list2.Add(item);
												}
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
						{
							foreach (WeaponRec weaponRec in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
							{
								if (weaponRec.method_9() > 0)
								{
									Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
									if (weapon.method_215())
									{
										try
										{
											foreach (WeaponRec weaponRec2 in weapon.vmethod_139())
											{
												if (weaponRec2.method_9() > 0 && this.method_31(weaponRec2, weapon_6))
												{
													ActiveUnit activeUnit_2 = this.activeUnit_0;
													ActiveUnit activeUnit = weapon_6;
													Mount mount2 = null;
													ActiveUnit_Weaponry.FireQueueEntry item2 = new ActiveUnit_Weaponry.FireQueueEntry(ref float_0, activeUnit_2, ref weaponRec2, ref activeUnit, ref mount2);
													list2.Add(item2);
												}
											}
											goto IL_2A5;
										}
										finally
										{
											List<WeaponRec>.Enumerator enumerator3;
											((IDisposable)enumerator3).Dispose();
										}
									}
									if (this.method_31(weaponRec, weapon_6))
									{
										ActiveUnit activeUnit_3 = this.activeUnit_0;
										ActiveUnit activeUnit = weapon_6;
										Mount mount2 = null;
										ActiveUnit_Weaponry.FireQueueEntry item3 = new ActiveUnit_Weaponry.FireQueueEntry(ref float_0, activeUnit_3, ref weaponRec, ref activeUnit, ref mount2);
										list2.Add(item3);
									}
								}
								IL_2A5:;
							}
						}
						if (list2.Count > 0)
						{
							IEnumerable<ActiveUnit_Weaponry.FireQueueEntry> enumerable = Enumerable.OrderByDescending<ActiveUnit_Weaponry.FireQueueEntry, float>(Enumerable.Select<ActiveUnit_Weaponry.FireQueueEntry, ActiveUnit_Weaponry.FireQueueEntry>(list2, (ActiveUnit_Weaponry._Closure$__.$I62-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I62-0 = new Func<ActiveUnit_Weaponry.FireQueueEntry, ActiveUnit_Weaponry.FireQueueEntry>(ActiveUnit_Weaponry._Closure$__.$I.method_10)) : ActiveUnit_Weaponry._Closure$__.$I62-0), new Func<ActiveUnit_Weaponry.FireQueueEntry, float>(this.method_62));
							HashSet<int> hashSet_ = new HashSet<int>();
							Contact contact = null;
							try
							{
								foreach (Contact contact2 in this.activeUnit_0.vmethod_7(false).method_44())
								{
									if (contact2.activeUnit_0 == weapon_6)
									{
										contact = contact2;
										break;
									}
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							try
							{
								foreach (ActiveUnit_Weaponry.FireQueueEntry fireQueueEntry in enumerable)
								{
									ActiveUnit_Weaponry.FireQueueEntry fireQueueEntry2 = fireQueueEntry;
									Contact contact_ = contact;
									int k = 0;
									this.method_44(ref fireQueueEntry2.weaponRec_0, contact_, ref list, ref k, hashSet_);
									if (fireQueueEntry.mount_0 != null)
									{
										if (fireQueueEntry.weaponRec_0.method_9() == 0)
										{
											Mount mount_ = fireQueueEntry.mount_0;
											k = 0;
											int l = 0;
											if (mount_.method_35(ref k, ref l) == 0)
											{
												fireQueueEntry.mount_0.method_31(0f);
												continue;
											}
										}
										if (fireQueueEntry.mount_0.method_30() < 300f)
										{
											fireQueueEntry.mount_0.method_31(fireQueueEntry.mount_0.method_28() + 300f);
										}
									}
								}
							}
							finally
							{
								IEnumerator<ActiveUnit_Weaponry.FireQueueEntry> enumerator5;
								if (enumerator5 != null)
								{
									enumerator5.Dispose();
								}
							}
						}
					}
					Sensor sensor3;
					if (weapon_6.vmethod_96().Length > 0)
					{
						Sensor[] array2 = weapon_6.vmethod_96();
						int l = 0;
						while (l < array2.Length)
						{
							Sensor sensor2 = array2[l];
							if (sensor2.sensor_Type_0 == Sensor.Sensor_Type.ESM)
							{
								if (weapon_6.class394_0.bool_5)
								{
									goto IL_477;
								}
							}
							else if (sensor2.sensor_Type_0 != Sensor.Sensor_Type.ECM && sensor2.method_63(this.activeUnit_0))
							{
								goto IL_477;
							}
							IL_48F:
							checked
							{
								l++;
								continue;
								IL_477:;
							}
							if (sensor2.method_45().GetValueOrDefault())
							{
								num++;
								goto IL_48F;
							}
							goto IL_48F;
						}
						if (num >= num2 && num2 > 0)
						{
							this.activeUnit_0.scenario_0.method_59("All weapon seekers were spoofed - weapon missed target", weapon_6.Name + " spoofed/jammed", LoggedMessage.MessageType.WeaponEndgame, 1, weapon_6.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							if (weapon_6.struct36_0.bool_57)
							{
								this.activeUnit_0.scenario_0.method_59("Weapon: " + weapon_6.Name + " will re-attack", "Weapon will re-attack", LoggedMessage.MessageType.WeaponEndgame, 1, weapon_6.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
								if (list != null)
								{
									list.Add("Weapon: " + weapon_6.Name + " will re-attack");
								}
								ActiveUnit_Weaponry.smethod_1(weapon_6, this.activeUnit_0, ActiveUnit_Weaponry.Enum37.const_1, list);
								weapon_6.method_275(this.activeUnit_0);
								return;
							}
							weapon_6.scenario_0.method_65(weapon_6);
						}
					}
					else if (weapon_6.method_169() == Weapon.WeaponGuidanceType.TVM)
					{
						sensor3 = weapon_6.method_170();
						if (sensor3 == null)
						{
							this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
							{
								"No radar providing guidance for weapon: ",
								weapon_6.Name,
								" (",
								weapon_6.string_2,
								") - cannot impact"
							}), weapon_6.Name + " missed (no guidance)", LoggedMessage.MessageType.WeaponEndgame, 1, this.activeUnit_0.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						else if (sensor3.method_45().GetValueOrDefault())
						{
							this.activeUnit_0.scenario_0.method_59("Radar providing guidance for TVM/SAGG-guided weapon was spoofed - cannot impact", weapon_6.Name + " spoofed/jammed", LoggedMessage.MessageType.WeaponEndgame, 1, this.activeUnit_0.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							if (weapon_6.struct36_0.bool_57)
							{
								if (list != null)
								{
									list.Add("Weapon will re-attack");
								}
								ActiveUnit_Weaponry.smethod_1(weapon_6, this.activeUnit_0, ActiveUnit_Weaponry.Enum37.const_1, list);
								weapon_6.method_275(this.activeUnit_0);
								return;
							}
							weapon_6.scenario_0.method_65(weapon_6);
						}
					}
					if (this.activeUnit_0.scenario_0.method_46().Contains(weapon_6))
					{
						@enum = ActiveUnit_Weaponry.Enum37.const_1;
					}
					if (@enum != ActiveUnit_Weaponry.Enum37.const_1)
					{
						if (weapon_6.vmethod_96().Length > 0)
						{
							foreach (Sensor sensor4 in weapon_6.vmethod_96())
							{
								if (!sensor4.method_45().GetValueOrDefault())
								{
									if (sensor4.sensor_Type_0 == Sensor.Sensor_Type.ESM)
									{
										if (!weapon_6.class394_0.bool_5)
										{
											goto IL_877;
										}
									}
									else if (sensor4.sensor_Type_0 == Sensor.Sensor_Type.ECM || !sensor4.method_63(this.activeUnit_0))
									{
										goto IL_877;
									}
									HashSet<int> hashSet = new HashSet<int>();
									foreach (Sensor sensor5 in this.activeUnit_0.vmethod_96())
									{
										if (sensor5.method_69() && !hashSet.Contains(sensor5.DBID))
										{
											hashSet.Add(sensor5.DBID);
											if (sensor5.method_35(sensor4) && sensor5.method_76(ref sensor4, ref this.activeUnit_0, list))
											{
												num++;
												sensor4.method_44(new bool?(true));
											}
										}
									}
								}
								IL_877:;
							}
						}
						else if (weapon_6.method_169() == Weapon.WeaponGuidanceType.TVM)
						{
							sensor3 = weapon_6.method_170();
							bool? flag;
							bool? flag2;
							if (sensor3 == null)
							{
								flag = new bool?(false);
							}
							else
							{
								flag2 = sensor3.method_45();
								flag = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
							}
							flag2 = flag;
							checked
							{
								if (flag2.GetValueOrDefault())
								{
									Sensor[] array5 = this.activeUnit_0.vmethod_96();
									int n = 0;
									while (n < array5.Length)
									{
										Sensor sensor6 = array5[n];
										if (!sensor6.method_69() || !sensor6.method_35(sensor3) || !sensor6.method_76(ref sensor3, ref this.activeUnit_0, list))
										{
											n++;
										}
										else
										{
											sensor3.method_44(new bool?(true));
											this.activeUnit_0.scenario_0.method_59("Radar providing guidance for TVM/SAGG-guided weapon was spoofed - cannot impact", weapon_6.Name + " spoofed/jammed", LoggedMessage.MessageType.WeaponEndgame, 1, this.activeUnit_0.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
											if (list != null)
											{
												list.Add("Radar providing guidance for TVM/SAGG-guided weapon was spoofed - cannot impact");
												break;
											}
											break;
										}
									}
								}
							}
						}
						if (weapon_6.vmethod_96().Length > 0)
						{
							if (num >= num2 && num2 > 0)
							{
								this.activeUnit_0.scenario_0.method_59("All weapon seekers were spoofed - weapon missed target", weapon_6.Name + " spoofed/jammed", LoggedMessage.MessageType.WeaponEndgame, 1, this.activeUnit_0.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
								if (list != null)
								{
									list.Add("All weapon seekers were spoofed - weapon missed target");
								}
								ActiveUnit_Weaponry.smethod_1(weapon_6, this.activeUnit_0, ActiveUnit_Weaponry.Enum37.const_1, list);
								if (weapon_6.struct36_0.bool_57)
								{
									if (list != null)
									{
										list.Add("Weapon will re-attack");
									}
									ActiveUnit_Weaponry.smethod_1(weapon_6, this.activeUnit_0, ActiveUnit_Weaponry.Enum37.const_1, list);
									weapon_6.method_275(this.activeUnit_0);
									return;
								}
								weapon_6.scenario_0.method_65(weapon_6);
							}
							else
							{
								if (num > 0)
								{
									this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
									{
										"Only ",
										Conversions.ToString(num),
										" out of ",
										Conversions.ToString(num2),
										" weapon sensors spoofed"
									}), "Attempt to spoof/jam " + weapon_6.Name + " failed", LoggedMessage.MessageType.WeaponEndgame, 1, this.activeUnit_0.string_0, null, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
									if (list != null)
									{
										list.Add(string.Concat(new string[]
										{
											"Only ",
											Conversions.ToString(num),
											" out of ",
											Conversions.ToString(num2),
											" weapon sensors spoofed"
										}));
									}
								}
								ActiveUnit_Weaponry.smethod_1(weapon_6, this.activeUnit_0, ActiveUnit_Weaponry.Enum37.const_2, list);
								Weapon weapon2 = weapon_6;
								ActiveUnit activeUnit_4 = this.activeUnit_0;
								Scenario scenario_ = this.activeUnit_0.scenario_0;
								bool bool_ = false;
								List<string> list3 = null;
								weapon2.vmethod_146(activeUnit_4, scenario_, bool_, ref list3);
							}
						}
						else if (((!Information.IsNothing(sensor3)) ? sensor3.method_45() : new bool?(false)).GetValueOrDefault())
						{
							ActiveUnit_Weaponry.smethod_1(weapon_6, this.activeUnit_0, ActiveUnit_Weaponry.Enum37.const_1, list);
						}
						else
						{
							ActiveUnit_Weaponry.smethod_1(weapon_6, this.activeUnit_0, ActiveUnit_Weaponry.Enum37.const_2, list);
							Weapon weapon3 = weapon_6;
							ActiveUnit activeUnit_5 = this.activeUnit_0;
							Scenario scenario_2 = this.activeUnit_0.scenario_0;
							bool bool_2 = false;
							List<string> list3 = null;
							weapon3.vmethod_146(activeUnit_5, scenario_2, bool_2, ref list3);
						}
					}
					if (weapon_6.method_169() == Weapon.WeaponGuidanceType.TVM)
					{
						if (!Information.IsNothing(sensor3) && !Information.IsNothing(sensor3.method_45()))
						{
							sensor3.method_44(null);
						}
					}
					else
					{
						foreach (Sensor sensor7 in weapon_6.vmethod_96())
						{
							if (!Information.IsNothing(sensor7.method_45()))
							{
								sensor7.method_44(null);
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100310", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0000378C File Offset: 0x0000198C
		public static void smethod_1(Weapon weapon_6, Unit unit_0, ActiveUnit_Weaponry.Enum37 enum37_0, List<string> list_3)
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000C82C4 File Offset: 0x000C64C4
		private bool method_30(WeaponRec weaponRec_0, Mount mount_0, Weapon weapon_6)
		{
			bool result;
			try
			{
				Weapon._WeaponType weaponType = weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167();
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					return false;
				case Weapon._WeaponType.Rocket:
					return false;
				case Weapon._WeaponType.IronBomb:
					break;
				case Weapon._WeaponType.Gun:
					return false;
				default:
					if (weaponType == Weapon._WeaponType.Laser)
					{
						return false;
					}
					break;
				}
				if (mount_0.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
				{
					result = false;
				}
				else if (weaponRec_0.method_9() == 0)
				{
					result = false;
				}
				else
				{
					Weapon weapon = weaponRec_0.method_12(this.activeUnit_0.scenario_0);
					float num = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), weapon_6.vmethod_30(null), weapon_6.vmethod_28(null));
					Weapon._WeaponType weaponType2 = weapon_6.method_167();
					float num2;
					if (weaponType2 == Weapon._WeaponType.Torpedo)
					{
						num2 = weapon.float_36;
					}
					else
					{
						num2 = weapon.float_30;
					}
					if (num < num2)
					{
						result = false;
					}
					else if (!mount_0.bool_11 && !mount_0.method_33())
					{
						result = false;
					}
					else
					{
						if (weapon.method_167() != Weapon._WeaponType.Decoy_Expendable)
						{
							if (weapon.method_167() != Weapon._WeaponType.Decoy_Towed)
							{
								if (weaponRec_0.float_0 > 0f)
								{
									return false;
								}
								goto IL_156;
							}
						}
						if (weaponRec_0.float_0 > 1f)
						{
							return false;
						}
						IL_156:
						if (mount_0.method_28() > 0f)
						{
							result = false;
						}
						else if (!this.method_32(weaponRec_0, weapon_6))
						{
							result = false;
						}
						else
						{
							result = true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100311", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000C84A8 File Offset: 0x000C66A8
		private bool method_31(WeaponRec weaponRec_0, Weapon weapon_6)
		{
			bool result;
			try
			{
				float num = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), weapon_6.vmethod_30(null), weapon_6.vmethod_28(null));
				if (weaponRec_0.method_9() == 0)
				{
					result = false;
				}
				else if (num < weaponRec_0.method_12(this.activeUnit_0.scenario_0).float_30)
				{
					result = false;
				}
				else if (!this.method_32(weaponRec_0, weapon_6))
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100312", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000C8588 File Offset: 0x000C6788
		private bool method_32(WeaponRec weaponRec_0, Weapon weapon_6)
		{
			bool result;
			try
			{
				Weapon weapon = weaponRec_0.method_12(this.activeUnit_0.scenario_0);
				if (weapon.method_208())
				{
					if (weapon.method_167() == Weapon._WeaponType.Decoy_Vehicle)
					{
						result = false;
					}
					else
					{
						bool flag;
						switch (weapon_6.vmethod_142().vmethod_3().contactType_0)
						{
						case Contact_Base.ContactType.Air:
						case Contact_Base.ContactType.Missile:
							flag = weapon.class394_0.bool_2;
							break;
						case Contact_Base.ContactType.Surface:
							flag = weapon.class394_0.bool_0;
							break;
						case Contact_Base.ContactType.Submarine:
							flag = weapon.class394_0.bool_1;
							break;
						case Contact_Base.ContactType.Facility_Fixed:
							flag = (weapon.class394_0.bool_7 || weapon.class394_0.bool_8);
							break;
						case Contact_Base.ContactType.Facility_Mobile:
							flag = (weapon.class394_0.bool_12 || weapon.class394_0.bool_13);
							break;
						}
						if (!flag)
						{
							result = false;
						}
						else
						{
							bool flag2 = false;
							if (weapon_6.method_169() == Weapon.WeaponGuidanceType.TVM)
							{
								if (weapon.method_211())
								{
									flag2 = true;
								}
							}
							else
							{
								foreach (Sensor sensor in weapon_6.vmethod_96())
								{
									if (sensor.method_74())
									{
										if (weapon.method_210())
										{
											flag2 = true;
										}
									}
									else
									{
										switch (sensor.sensor_Type_0)
										{
										case Sensor.Sensor_Type.Radar:
										case Sensor.Sensor_Type.SemiActive:
											if (weapon.method_211())
											{
												flag2 = true;
											}
											break;
										case Sensor.Sensor_Type.Visual:
											if (weapon.method_213())
											{
												flag2 = true;
											}
											break;
										case Sensor.Sensor_Type.Infrared:
											if (weapon.method_212())
											{
												flag2 = true;
											}
											break;
										}
									}
								}
							}
							if (!flag2)
							{
								result = false;
							}
							else
							{
								result = true;
							}
						}
					}
				}
				else
				{
					Weapon._WeaponType weaponType = weapon_6.method_167();
					if (weaponType != Weapon._WeaponType.GuidedWeapon)
					{
						if (weaponType == Weapon._WeaponType.Torpedo)
						{
							result = weapon.class394_0.bool_9;
						}
					}
					else
					{
						result = (weapon.class394_0.bool_3 && !weapon_6.class394_0.bool_2 && !weapon_6.class394_0.bool_3);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100313", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000C87D4 File Offset: 0x000C69D4
		public int method_33(Mount mount_0, int int_0)
		{
			int num = 0;
			int result;
			try
			{
				try
				{
					foreach (WeaponRec weaponRec in mount_0.vmethod_10())
					{
						if (weaponRec.int_5 == int_0)
						{
							num += weaponRec.method_9();
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (WeaponRec weaponRec2 in mount_0.method_32().vmethod_10())
					{
						if (weaponRec2.int_5 == int_0)
						{
							num += weaponRec2.method_9();
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100314", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000C88D4 File Offset: 0x000C6AD4
		public int method_34(Mount mount_0, int int_0)
		{
			int num = 0;
			int result;
			try
			{
				try
				{
					foreach (WeaponRec weaponRec in mount_0.method_32().vmethod_10())
					{
						if (weaponRec.int_5 == int_0)
						{
							num += weaponRec.method_9();
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100315", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000C8984 File Offset: 0x000C6B84
		public virtual int vmethod_8(int int_0)
		{
			int num = 0;
			int result;
			try
			{
				Magazine[] array;
				if (this.activeUnit_0.method_120() && this.activeUnit_0.vmethod_65(false).method_140())
				{
					array = this.activeUnit_0.vmethod_65(false).vmethod_117();
				}
				else
				{
					array = this.activeUnit_0.vmethod_117();
				}
				foreach (Magazine magazine in array)
				{
					try
					{
						foreach (WeaponRec weaponRec in magazine.vmethod_10())
						{
							if (weaponRec.int_5 == int_0)
							{
								num += weaponRec.method_9();
							}
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100316", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x000C8A8C File Offset: 0x000C6C8C
		public virtual int vmethod_9(Loadout loadout_0, int int_0)
		{
			int num = 0;
			int result;
			try
			{
				foreach (WeaponRec weaponRec in loadout_0.weaponRec_0)
				{
					if (weaponRec.int_5 == int_0)
					{
						num += weaponRec.method_9();
					}
				}
				result = num;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100317", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x000C8B18 File Offset: 0x000C6D18
		public void method_35()
		{
			try
			{
				if (!this.activeUnit_0.bool_3 && !this.activeUnit_0.bool_2)
				{
					if (this.activeUnit_0.vmethod_51().Count != 0)
					{
						int count = this.activeUnit_0.vmethod_51().Count;
						int num = this.activeUnit_0.vmethod_117().Length;
						Dictionary<int, Class316.Class273> dictionary = new Dictionary<int, Class316.Class273>();
						Doctrine.Enum52 value = this.activeUnit_0.doctrine_0.method_63(this.activeUnit_0.scenario_0, false, null, false, false).Value;
						List<Class316> list = new List<Class316>();
						List<Class316> list2 = new List<Class316>();
						Class316[] class316_ = this.activeUnit_0.vmethod_7(false).class316_0;
						for (int i = class316_.Length - 1; i >= 0; i += -1)
						{
							Class316 @class = class316_[i];
							if (!Information.IsNothing(@class) && (@class.bool_12 || value != Doctrine.Enum52.const_2))
							{
								int j = @class.class273_0.Length - 1;
								while (j >= 0)
								{
									Class316.Class273 class2 = @class.class273_0[j];
									if (Operators.CompareString(this.activeUnit_0.string_0, class2.string_0, false) != 0)
									{
										j += -1;
									}
									else
									{
										if (class2.int_1 >= class2.int_0 || dictionary.ContainsKey(@class.int_0))
										{
											break;
										}
										dictionary.Add(@class.int_0, class2);
										list2.Add(@class);
										if (@class.bool_12)
										{
											list.Add(@class);
											break;
										}
										break;
									}
								}
							}
						}
						int num2 = count - 1;
						for (int k = 0; k <= num2; k++)
						{
							Mount mount = this.activeUnit_0.vmethod_51()[k];
							if (mount.method_30() > 0f && mount.vmethod_10().Count != Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(mount.vmethod_10(), new Func<WeaponRec, bool>(this.method_63))))
							{
								mount.method_31(mount.method_30() - 1f);
							}
							else if (this.activeUnit_0.bool_8 || num != 0 || mount.method_32().vmethod_10().Count != 0)
							{
								List<WeaponRec> list3 = new List<WeaponRec>();
								List<WeaponRec> list4 = new List<WeaponRec>();
								List<WeaponRec> list5 = new List<WeaponRec>();
								if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational && mount.method_32().method_24() <= 0f)
								{
									bool flag = false;
									try
									{
										List<WeaponRec>.Enumerator enumerator = mount.vmethod_10().GetEnumerator();
										while (enumerator.MoveNext())
										{
											if (enumerator.Current.int_2 == mount.int_1)
											{
												flag = true;
												break;
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									int num5;
									if (mount.vmethod_10().Count > 1 && flag)
									{
										int num3 = mount.vmethod_10().Count - 1;
										for (int l = 0; l <= num3; l++)
										{
											WeaponRec weaponRec = mount.vmethod_10()[l];
											if (weaponRec.method_11(mount))
											{
												if (weaponRec.method_9() < weaponRec.int_2)
												{
													bool flag2 = false;
													try
													{
														foreach (WeaponRec weaponRec2 in mount.method_32().vmethod_10())
														{
															if (weaponRec2.int_5 == weaponRec.int_5 && weaponRec2.method_9() > 0)
															{
																flag2 = true;
																break;
															}
														}
													}
													finally
													{
														List<WeaponRec>.Enumerator enumerator2;
														((IDisposable)enumerator2).Dispose();
													}
													if (!flag2)
													{
														foreach (Magazine magazine in ((Class350)this.activeUnit_0).magazine_0)
														{
															if (magazine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed)
															{
																try
																{
																	foreach (WeaponRec weaponRec3 in magazine.vmethod_10())
																	{
																		if (weaponRec3.int_5 == weaponRec.int_5 && weaponRec3.method_9() > 0)
																		{
																			flag2 = true;
																			break;
																		}
																	}
																}
																finally
																{
																	List<WeaponRec>.Enumerator enumerator3;
																	((IDisposable)enumerator3).Dispose();
																}
																if (flag2)
																{
																	break;
																}
															}
														}
													}
													if (flag2)
													{
														list4.Add(weaponRec);
													}
												}
												list3.Add(weaponRec);
											}
											else
											{
												list5.Add(weaponRec);
											}
										}
										int num8;
										try
										{
											foreach (WeaponRec weaponRec4 in list4)
											{
												if (weaponRec4.method_9() < weaponRec4.int_2)
												{
													if (list5.Count > 0)
													{
														int num4 = list5.Count - 1;
														for (int n = 0; n <= num4; n++)
														{
															WeaponRec weaponRec5 = list5[n];
															if (weaponRec5.method_9() > 0)
															{
																Mount mount2 = mount;
																num5 = 0;
																int num6 = 0;
																if (mount2.method_35(ref num5, ref num6) >= mount.int_1 && this.method_36(ref mount, ref weaponRec5))
																{
																	this.method_37(ref mount, ref weaponRec4);
																}
															}
														}
													}
													if (list3.Count > 1)
													{
														int num6 = list3.Count - 1;
														for (int num7 = 0; num7 <= num6; num7++)
														{
															WeaponRec weaponRec5 = list3[num7];
															if (weaponRec5 != weaponRec4 && (double)weaponRec5.method_9() / (double)weaponRec5.int_4 - 1.0 > (double)weaponRec4.method_9())
															{
																Mount mount3 = mount;
																num5 = 0;
																num8 = 0;
																if (mount3.method_35(ref num5, ref num8) >= mount.int_1 && this.method_36(ref mount, ref weaponRec5))
																{
																	this.method_37(ref mount, ref weaponRec4);
																}
															}
														}
													}
													int num9;
													int num10;
													mount.method_35(ref num9, ref num10);
													if (num10 <= 0 || weaponRec4.int_4 != 1 || num9 + num10 < mount.int_1)
													{
														this.method_37(ref mount, ref weaponRec4);
													}
												}
											}
										}
										finally
										{
											List<WeaponRec>.Enumerator enumerator4;
											((IDisposable)enumerator4).Dispose();
										}
										bool flag3 = false;
										if (dictionary.Count <= 0 || list3.Count != 0)
										{
											goto IL_1096;
										}
										if (mount.method_32().vmethod_10().Count > 0)
										{
											try
											{
												foreach (WeaponRec weaponRec6 in mount.vmethod_10())
												{
													if (!weaponRec6.method_11(mount) && !weaponRec6.method_12(this.activeUnit_0.scenario_0).method_208() && this.method_34(mount, weaponRec6.int_5) != 0 && dictionary.ContainsKey(weaponRec6.int_5))
													{
														Class316.Class273 class3 = dictionary[weaponRec6.int_5];
														if (Operators.CompareString(class3.string_1, "", false) == 0 || Operators.CompareString(class3.string_1, mount.string_0, false) == 0)
														{
															Mount mount4 = mount;
															num8 = 0;
															num5 = 0;
															if (mount4.method_35(ref num8, ref num5) >= mount.int_1)
															{
																try
																{
																	foreach (WeaponRec weaponRec7 in mount.vmethod_10())
																	{
																		if (weaponRec7 != weaponRec6 && this.method_36(ref mount, ref weaponRec7))
																		{
																			this.method_37(ref mount, ref weaponRec6);
																			IL_6A2:
																			goto IL_6BD;
																		}
																	}
																	goto IL_6A2;
																}
																finally
																{
																	List<WeaponRec>.Enumerator enumerator6;
																	((IDisposable)enumerator6).Dispose();
																}
															}
															this.method_37(ref mount, ref weaponRec6);
															IL_6BD:
															dictionary.Remove(weaponRec6.int_5);
															flag3 = true;
															IL_6CF:
															goto IL_1096;
														}
													}
												}
												goto IL_6CF;
											}
											finally
											{
												List<WeaponRec>.Enumerator enumerator5;
												((IDisposable)enumerator5).Dispose();
											}
										}
										if (list.Count > 0)
										{
											Mount mount5 = mount;
											num5 = 0;
											num8 = 0;
											if (mount5.method_35(ref num5, ref num8) >= mount.int_1)
											{
												try
												{
													foreach (WeaponRec weaponRec8 in mount.vmethod_10())
													{
														try
														{
															foreach (Class316 class4 in list)
															{
																if (weaponRec8.method_12(this.activeUnit_0.scenario_0).DBID == class4.int_0 && weaponRec8.method_9() > 0)
																{
																	flag3 = true;
																	break;
																}
															}
														}
														finally
														{
															List<Class316>.Enumerator enumerator8;
															((IDisposable)enumerator8).Dispose();
														}
														if (flag3)
														{
															break;
														}
													}
												}
												finally
												{
													List<WeaponRec>.Enumerator enumerator7;
													((IDisposable)enumerator7).Dispose();
												}
											}
											if (flag3)
											{
												goto IL_108B;
											}
											try
											{
												foreach (WeaponRec weaponRec9 in mount.vmethod_10())
												{
													if (!weaponRec9.method_11(mount) && !weaponRec9.method_12(this.activeUnit_0.scenario_0).method_208() && this.vmethod_8(weaponRec9.int_5) != 0)
													{
														try
														{
															List<Class316>.Enumerator enumerator10 = list.GetEnumerator();
															while (enumerator10.MoveNext())
															{
																if (enumerator10.Current.int_0 == weaponRec9.int_5 && dictionary.ContainsKey(weaponRec9.int_5))
																{
																	Class316.Class273 class5 = dictionary[weaponRec9.int_5];
																	if (Operators.CompareString(class5.string_1, "", false) == 0 || Operators.CompareString(class5.string_1, mount.string_0, false) == 0)
																	{
																		Mount mount6 = mount;
																		num8 = 0;
																		num5 = 0;
																		if (mount6.method_35(ref num8, ref num5) >= mount.int_1)
																		{
																			try
																			{
																				foreach (WeaponRec weaponRec10 in mount.vmethod_10())
																				{
																					if (weaponRec10.method_9() != 0 && weaponRec10 != weaponRec9 && this.method_36(ref mount, ref weaponRec10))
																					{
																						this.method_37(ref mount, ref weaponRec9);
																						IL_8D2:
																						goto IL_8FD;
																					}
																				}
																				goto IL_8D2;
																			}
																			finally
																			{
																				List<WeaponRec>.Enumerator enumerator11;
																				((IDisposable)enumerator11).Dispose();
																			}
																		}
																		if (weaponRec9.method_9() < weaponRec9.int_2)
																		{
																			this.method_37(ref mount, ref weaponRec9);
																		}
																		IL_8FD:
																		flag3 = true;
																		break;
																	}
																}
															}
														}
														finally
														{
															List<Class316>.Enumerator enumerator10;
															((IDisposable)enumerator10).Dispose();
														}
														if (flag3)
														{
															break;
														}
													}
												}
												goto IL_1096;
											}
											finally
											{
												List<WeaponRec>.Enumerator enumerator9;
												((IDisposable)enumerator9).Dispose();
											}
										}
										if (list2.Count <= 0)
										{
											goto IL_1096;
										}
										Mount mount7 = mount;
										num5 = 0;
										num8 = 0;
										if (mount7.method_35(ref num5, ref num8) >= mount.int_1)
										{
											try
											{
												foreach (WeaponRec weaponRec11 in mount.vmethod_10())
												{
													try
													{
														foreach (Class316 class6 in list2)
														{
															if (weaponRec11.method_12(this.activeUnit_0.scenario_0).DBID == class6.int_0 && weaponRec11.method_9() > 0)
															{
																flag3 = true;
																break;
															}
														}
													}
													finally
													{
														List<Class316>.Enumerator enumerator13;
														((IDisposable)enumerator13).Dispose();
													}
													if (flag3)
													{
														break;
													}
												}
											}
											finally
											{
												List<WeaponRec>.Enumerator enumerator12;
												((IDisposable)enumerator12).Dispose();
											}
										}
										if (flag3)
										{
											goto IL_108B;
										}
										try
										{
											foreach (WeaponRec weaponRec12 in mount.vmethod_10())
											{
												if (!weaponRec12.method_11(mount) && !weaponRec12.method_12(this.activeUnit_0.scenario_0).method_208() && this.vmethod_8(weaponRec12.int_5) != 0)
												{
													try
													{
														List<Class316>.Enumerator enumerator15 = list2.GetEnumerator();
														while (enumerator15.MoveNext())
														{
															if (enumerator15.Current.int_0 == weaponRec12.int_5 && dictionary.ContainsKey(weaponRec12.int_5))
															{
																Class316.Class273 class7 = dictionary[weaponRec12.int_5];
																if (Operators.CompareString(class7.string_1, "", false) == 0 || Operators.CompareString(class7.string_1, mount.string_0, false) == 0)
																{
																	Mount mount8 = mount;
																	num8 = 0;
																	num5 = 0;
																	if (mount8.method_35(ref num8, ref num5) >= mount.int_1)
																	{
																		try
																		{
																			foreach (WeaponRec weaponRec13 in mount.vmethod_10())
																			{
																				if (weaponRec13.method_9() != 0 && weaponRec13 != weaponRec12 && this.method_36(ref mount, ref weaponRec13))
																				{
																					this.method_37(ref mount, ref weaponRec12);
																					IL_B23:
																					goto IL_B4E;
																				}
																			}
																			goto IL_B23;
																		}
																		finally
																		{
																			List<WeaponRec>.Enumerator enumerator16;
																			((IDisposable)enumerator16).Dispose();
																		}
																	}
																	if (weaponRec12.method_9() < weaponRec12.int_2)
																	{
																		this.method_37(ref mount, ref weaponRec12);
																	}
																	IL_B4E:
																	flag3 = true;
																	break;
																}
															}
														}
													}
													finally
													{
														List<Class316>.Enumerator enumerator15;
														((IDisposable)enumerator15).Dispose();
													}
													if (flag3)
													{
														break;
													}
												}
											}
											goto IL_1096;
										}
										finally
										{
											List<WeaponRec>.Enumerator enumerator14;
											((IDisposable)enumerator14).Dispose();
										}
										IL_B84:
										bool flag4 = false;
										if (!flag3 && list3.Count == 0 && (!Information.IsNothing(this.activeUnit_0.vmethod_86().vmethod_3()) || this.activeUnit_0.vmethod_86().method_12().Length > 0))
										{
											List<WeaponRec> list7;
											if (this.activeUnit_0.vmethod_86().vmethod_3() != null)
											{
												List<WeaponRec> list6 = new List<WeaponRec>();
												bool? flag5 = null;
												try
												{
													foreach (WeaponRec weaponRec14 in mount.vmethod_10())
													{
														Weapon weapon = weaponRec14.method_12(this.activeUnit_0.scenario_0);
														if (!weapon.method_208() && !weapon.method_209())
														{
															Weapon weapon2 = weapon;
															Scenario scenario_ = this.activeUnit_0.scenario_0;
															ActiveUnit_AI activeUnit_AI;
															Contact contact_ = (activeUnit_AI = this.activeUnit_0.vmethod_86()).vmethod_3();
															bool flag6 = weapon2.method_253(scenario_, ref contact_, ref flag5);
															activeUnit_AI.vmethod_4(contact_);
															if (flag6)
															{
																list6.Add(weaponRec14);
															}
														}
													}
												}
												finally
												{
													List<WeaponRec>.Enumerator enumerator17;
													((IDisposable)enumerator17).Dispose();
												}
												list7 = Enumerable.ToList<WeaponRec>(Enumerable.OrderByDescending<WeaponRec, int>(list6, new Func<WeaponRec, int>(this.method_64)));
											}
											else
											{
												List<WeaponRec> list8 = new List<WeaponRec>();
												try
												{
													foreach (WeaponRec weaponRec15 in mount.vmethod_10())
													{
														Weapon weapon3 = weaponRec15.method_12(this.activeUnit_0.scenario_0);
														if (!weapon3.method_208() && !weapon3.method_209() && weapon3.method_199())
														{
															list8.Add(weaponRec15);
														}
													}
												}
												finally
												{
													List<WeaponRec>.Enumerator enumerator18;
													((IDisposable)enumerator18).Dispose();
												}
												list7 = Enumerable.ToList<WeaponRec>(Enumerable.OrderByDescending<WeaponRec, float>(list8, new Func<WeaponRec, float>(this.method_65)));
											}
											if (list7.Count > 0)
											{
												try
												{
													foreach (WeaponRec weaponRec16 in list7)
													{
														if (this.method_34(mount, weaponRec16.int_5) != 0 || this.vmethod_8(weaponRec16.int_5) != 0)
														{
															Mount mount9 = mount;
															num5 = 0;
															num8 = 0;
															if (mount9.method_35(ref num5, ref num8) < mount.int_1)
															{
																this.method_37(ref mount, ref weaponRec16);
																flag4 = true;
																break;
															}
															try
															{
																foreach (WeaponRec weaponRec17 in mount.vmethod_10())
																{
																	if (weaponRec17 != weaponRec16 && !weaponRec17.method_11(mount) && weaponRec17.method_9() > 0 && !weaponRec17.method_12(this.activeUnit_0.scenario_0).method_208())
																	{
																		Weapon weapon4 = weaponRec17.method_12(this.activeUnit_0.scenario_0);
																		ActiveUnit_AI activeUnit_AI;
																		Contact contact_ = (activeUnit_AI = this.activeUnit_0.vmethod_86()).vmethod_3();
																		int num11 = this.method_14(ref weapon4, ref contact_, true);
																		activeUnit_AI.vmethod_4(contact_);
																		weapon4 = weaponRec16.method_12(this.activeUnit_0.scenario_0);
																		contact_ = (activeUnit_AI = this.activeUnit_0.vmethod_86()).vmethod_3();
																		int num12 = this.method_14(ref weapon4, ref contact_, true);
																		activeUnit_AI.vmethod_4(contact_);
																		if (num11 < num12 && this.method_36(ref mount, ref weaponRec17))
																		{
																			this.method_37(ref mount, ref weaponRec16);
																			flag4 = true;
																			break;
																		}
																	}
																}
															}
															finally
															{
																List<WeaponRec>.Enumerator enumerator20;
																((IDisposable)enumerator20).Dispose();
															}
														}
													}
												}
												finally
												{
													List<WeaponRec>.Enumerator enumerator19;
													((IDisposable)enumerator19).Dispose();
												}
											}
										}
										if (flag4 || flag3)
										{
											goto IL_FBC;
										}
										int num13;
										int num14;
										mount.method_35(ref num13, ref num14);
										if (num13 < mount.int_1 && list4.Count <= 0)
										{
											num8 = list5.Count - 1;
											for (int num15 = 0; num15 <= num8; num15++)
											{
												WeaponRec weaponRec5 = list5[num15];
												if ((num14 <= 0 || weaponRec5.int_4 != 1 || num13 + num14 < mount.int_1) && !weaponRec5.method_12(this.activeUnit_0.scenario_0).method_209() && weaponRec5.method_9() < weaponRec5.int_2)
												{
													this.method_37(ref mount, ref weaponRec5);
												}
											}
											goto IL_FBC;
										}
										goto IL_FBC;
										IL_1096:
										if (!flag3)
										{
											goto IL_B84;
										}
										goto IL_108B;
									}
									else
									{
										try
										{
											foreach (WeaponRec weaponRec18 in mount.vmethod_10())
											{
												if (weaponRec18.method_9() < weaponRec18.int_2 && this.method_37(ref mount, ref weaponRec18))
												{
													break;
												}
											}
										}
										finally
										{
											List<WeaponRec>.Enumerator enumerator21;
											((IDisposable)enumerator21).Dispose();
										}
									}
									IL_FBC:
									num5 = mount.method_32().vmethod_10().Count - 1;
									for (int num16 = 0; num16 <= num5; num16++)
									{
										WeaponRec weaponRec5 = mount.method_32().vmethod_10()[num16];
										if (!weaponRec5.method_12(this.activeUnit_0.scenario_0).method_209() && weaponRec5.method_9() < weaponRec5.int_2)
										{
											while (weaponRec5.method_9() < weaponRec5.int_2)
											{
												float num17 = 0f;
												if (string.CompareOrdinal(this.vmethod_12(weaponRec5.int_5, false, ref num17), "OK") != 0)
												{
													break;
												}
												weaponRec5.method_10(weaponRec5.method_9() + 1);
												Mount mount10;
												(mount10 = mount).method_29(mount10.method_28() + num17);
												Mount mount11 = mount;
												int num18 = 0;
												int num19 = 0;
												if (mount11.method_35(ref num18, ref num19) >= mount.int_1)
												{
													break;
												}
											}
										}
									}
								}
							}
							IL_108B:;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100318", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000C9E14 File Offset: 0x000C8014
		private bool method_36(ref Mount mount_0, ref WeaponRec weaponRec_0)
		{
			Mount mount = mount_0;
			int num = 0;
			int num2 = 0;
			bool result;
			if (mount.method_35(ref num, ref num2) == 0)
			{
				result = false;
			}
			else if (weaponRec_0.method_9() == 0)
			{
				result = false;
			}
			else if (weaponRec_0.float_0 > 0f)
			{
				result = false;
			}
			else
			{
				try
				{
					try
					{
						foreach (WeaponRec weaponRec in mount_0.method_32().vmethod_10())
						{
							if (weaponRec.int_5 == weaponRec_0.int_5 && string.CompareOrdinal(this.method_39(ref weaponRec), "OK") == 0)
							{
								if (weaponRec_0.int_4 > 1)
								{
									num2 = weaponRec_0.int_4;
									for (int i = 1; i <= num2; i++)
									{
										weaponRec_0.method_10(weaponRec_0.method_9() - 1);
										float num3 = (float)weaponRec_0.method_9() / (float)weaponRec_0.int_4;
										if (num3 == (float)((int)Math.Round((double)num3)))
										{
											break;
										}
									}
								}
								else
								{
									weaponRec_0.method_10(weaponRec_0.method_9() - 1);
								}
								weaponRec_0.method_15();
								mount_0.enum113_0 = Mount.Enum113.const_2;
								mount_0.method_32().ResetTimeToFire();
								return true;
							}
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (string.CompareOrdinal(this.vmethod_11(weaponRec_0.int_5, false, true), "OK") == 0)
					{
						if (weaponRec_0.int_4 > 1)
						{
							num = weaponRec_0.int_4;
							for (int j = 1; j <= num; j++)
							{
								weaponRec_0.method_10(weaponRec_0.method_9() - 1);
								float num4 = (float)weaponRec_0.method_9() / (float)weaponRec_0.int_4;
								if (num4 == (float)((int)Math.Round((double)num4)))
								{
									break;
								}
							}
						}
						else
						{
							weaponRec_0.method_10(weaponRec_0.method_9() - 1);
						}
						mount_0.enum113_0 = Mount.Enum113.const_2;
						weaponRec_0.method_15();
						result = true;
					}
					else
					{
						result = false;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100320", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000CA040 File Offset: 0x000C8240
		private bool method_37(ref Mount mount_0, ref WeaponRec weaponRec_0)
		{
			Mount mount = mount_0;
			int num = 0;
			int num2;
			mount.method_35(ref num2, ref num);
			bool result;
			if (num2 < mount_0.int_1)
			{
				try
				{
					while (weaponRec_0.method_9() < weaponRec_0.int_2)
					{
						if (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_207() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).warhead_0[0].method_18() == Warhead.Enum125.const_2 && this.activeUnit_0.scenario_0.FifteenthSecondIsChangingOnThisPulse && (this.activeUnit_0.bool_8 || this.activeUnit_0.vmethod_49().Count > 0 || Enumerable.Count<Engine>(Enumerable.Where<Engine>(this.activeUnit_0.vmethod_49(), (ActiveUnit_Weaponry._Closure$__.$I75-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I75-0 = new Func<Engine, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_11)) : ActiveUnit_Weaponry._Closure$__.$I75-0)) > 0))
						{
							weaponRec_0.method_10(weaponRec_0.method_9() + 1);
							result = true;
							break;
						}
						Mount mount2;
						int num4;
						try
						{
							foreach (WeaponRec weaponRec in mount_0.method_32().vmethod_10())
							{
								if (weaponRec.int_5 == weaponRec_0.int_5 && string.CompareOrdinal(this.method_38(ref weaponRec), "OK") == 0)
								{
									if (weaponRec_0.int_4 > 1)
									{
										num = weaponRec_0.int_4;
										for (int i = 1; i <= num; i++)
										{
											weaponRec_0.method_10(weaponRec_0.method_9() + 1);
											float num3 = (float)weaponRec_0.method_9() / (float)weaponRec_0.int_4;
											if (num3 == (float)((int)Math.Round((double)num3)))
											{
												break;
											}
										}
									}
									else
									{
										weaponRec_0.method_10(weaponRec_0.method_9() + 1);
									}
									(mount2 = mount_0).method_29(mount2.method_28() + (float)mount_0.method_32().int_0);
									if (mount_0.method_28() > (float)(mount_0.int_1 * mount_0.method_32().int_0))
									{
										mount_0.method_29((float)(mount_0.int_1 * mount_0.method_32().int_0));
									}
									mount_0.enum113_0 = Mount.Enum113.const_1;
									Mount mount3 = mount_0;
									num4 = 0;
									int num5 = 0;
									if (mount3.method_35(ref num4, ref num5) >= mount_0.int_1)
									{
										return true;
									}
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						float num6 = 0f;
						bool flag = false;
						if (weaponRec_0.int_4 > 1)
						{
							int num5 = weaponRec_0.int_4;
							for (int j = 1; j <= num5; j++)
							{
								if (string.CompareOrdinal(this.vmethod_12(weaponRec_0.int_5, false, ref num6), "OK") == 0)
								{
									flag = true;
									weaponRec_0.method_10(weaponRec_0.method_9() + 1);
									float num7 = (float)weaponRec_0.method_9() / (float)weaponRec_0.int_4;
									if (num7 == (float)((int)Math.Round((double)num7)))
									{
										break;
									}
								}
							}
						}
						else if (string.CompareOrdinal(this.vmethod_12(weaponRec_0.int_5, false, ref num6), "OK") == 0)
						{
							flag = true;
							weaponRec_0.method_10(weaponRec_0.method_9() + 1);
						}
						if (!flag)
						{
							result = false;
							break;
						}
						(mount2 = mount_0).method_29(mount2.method_28() + num6);
						if (mount_0.method_28() > (float)mount_0.int_1 * num6)
						{
							mount_0.method_29((float)mount_0.int_1 * num6);
						}
						mount_0.enum113_0 = Mount.Enum113.const_1;
						Mount mount4 = mount_0;
						num4 = 0;
						mount4.method_35(ref num2, ref num4);
						if (num2 == mount_0.int_1)
						{
							result = true;
							break;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100321", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000CA418 File Offset: 0x000C8618
		public virtual string vmethod_10(int int_0, bool bool_9, bool bool_10)
		{
			string result;
			try
			{
				if (Operators.CompareString(this.vmethod_11(int_0, bool_9, bool_10), "OK", false) == 0)
				{
					result = "OK";
				}
				else
				{
					try
					{
						foreach (Mount mount in this.activeUnit_0.vmethod_51())
						{
							Mount mount2 = mount;
							int num = 0;
							int num2 = 0;
							if (mount2.method_35(ref num, ref num2) < mount.int_1)
							{
								try
								{
									foreach (WeaponRec weaponRec in mount.vmethod_10())
									{
										if (weaponRec.int_5 == int_0 && weaponRec.method_9() < weaponRec.int_2)
										{
											WeaponRec weaponRec2;
											(weaponRec2 = weaponRec).method_10(weaponRec2.method_9() + 1);
											return "OK";
										}
									}
								}
								finally
								{
									List<WeaponRec>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						List<Mount>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = "Failed";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100322", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000CA568 File Offset: 0x000C8768
		public virtual string vmethod_11(int int_0, bool bool_9, bool bool_10)
		{
			checked
			{
				string result;
				try
				{
					Magazine[] array = this.activeUnit_0.method_91();
					Magazine[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (string.CompareOrdinal(array2[i].method_26(int_0), "OK") == 0)
						{
							return "OK";
						}
					}
					if (bool_10 && ((Class350)this.activeUnit_0).vmethod_117().Length > 0)
					{
						array = ((Class350)this.activeUnit_0).vmethod_117();
						if (bool_9)
						{
							array = Enumerable.ToArray<Magazine>(Enumerable.OrderByDescending<Magazine, string>(array, (ActiveUnit_Weaponry._Closure$__.$I77-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I77-0 = new Func<Magazine, string>(ActiveUnit_Weaponry._Closure$__.$I.method_12)) : ActiveUnit_Weaponry._Closure$__.$I77-0));
						}
						array[0].vmethod_10().method_4(new WeaponRec(ref this.activeUnit_0.scenario_0, int_0, 0, array[0].int_1, 1, 1, false, false));
						if (string.CompareOrdinal(array[0].method_26(int_0), "OK") == 0)
						{
							array[0].method_21();
							return "OK";
						}
					}
					result = "Failed";
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100323", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x000CA6B4 File Offset: 0x000C88B4
		public virtual string vmethod_12(int int_0, bool bool_9, ref float float_0)
		{
			string result;
			try
			{
				if (bool_9 && this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_2))
				{
					result = "OK";
				}
				else
				{
					foreach (Magazine magazine in ((Class350)this.activeUnit_0).magazine_0)
					{
						if (magazine.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && Operators.CompareString(magazine.method_28(int_0, bool_9, ref float_0), "OK", false) == 0)
						{
							float_0 = (float)magazine.int_0;
							return "OK";
						}
					}
					result = "Weapon not found in magazines";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100324", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x000CA78C File Offset: 0x000C898C
		private string method_38(ref WeaponRec weaponRec_0)
		{
			string result;
			try
			{
				if (weaponRec_0.float_0 > 0f)
				{
					result = "Cannot yet load/fire from this weapon record (TimeToFire > 0)";
				}
				else if (weaponRec_0.method_9() == 0)
				{
					result = "Weapon record is empty";
				}
				else
				{
					weaponRec_0.method_10(weaponRec_0.method_9() - 1);
					result = "OK";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100325", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x000CA820 File Offset: 0x000C8A20
		private string method_39(ref WeaponRec weaponRec_0)
		{
			string result;
			try
			{
				if (weaponRec_0.method_9() == weaponRec_0.int_2)
				{
					result = "Weapon record is full";
				}
				else
				{
					weaponRec_0.method_10(weaponRec_0.method_9() + 1);
					result = "OK";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100326", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000CA8A4 File Offset: 0x000C8AA4
		public void method_40(float float_0)
		{
			List<WeaponRec> list = new List<WeaponRec>();
			try
			{
				try
				{
					foreach (Mount mount in this.activeUnit_0.vmethod_51())
					{
						try
						{
							foreach (WeaponRec weaponRec in mount.vmethod_10())
							{
								weaponRec.mount_0 = mount;
								if (weaponRec.method_9() != 0 && weaponRec.method_12(this.activeUnit_0.scenario_0).method_154() && mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational && mount.method_28() == 0f && weaponRec.float_0 == 0f)
								{
									list.Add(weaponRec);
								}
							}
						}
						finally
						{
							List<WeaponRec>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
					}
				}
				finally
				{
					List<Mount>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_167() != null)
				{
					foreach (WeaponRec weaponRec in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
					{
						weaponRec.mount_0 = null;
						if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Sonobuoy && weaponRec.method_9() != 0 && weaponRec.float_0 <= 0f)
						{
							list.Add(weaponRec);
						}
					}
				}
				int count = list.Count;
				if (count != 0)
				{
					if (count != 1)
					{
						WeaponRec weaponRec2 = list[GameGeneral.smethod_5().Next(0, list.Count)];
						Contact theTarget = null;
						int num = 0;
						int specificNumberOfWeaponsToFire = 0;
						float initialHeading = 0f;
						ActiveUnit.Throttle throttleSetting = ActiveUnit.Throttle.Flank;
						Mount firingMount = null;
						Class568.Enum154 sonobuoyDepthSetting = Class568.Enum154.const_0;
						long armDelay_sec = 0L;
						Class316 @class = null;
						this.method_43(float_0, ref weaponRec2, theTarget, ref num, specificNumberOfWeaponsToFire, initialHeading, throttleSetting, firingMount, sonobuoyDepthSetting, armDelay_sec, ref @class);
					}
					else
					{
						List<WeaponRec> list2;
						WeaponRec value = (list2 = list)[0];
						Contact theTarget2 = null;
						int num = 0;
						int specificNumberOfWeaponsToFire2 = 0;
						float initialHeading2 = 0f;
						ActiveUnit.Throttle throttleSetting2 = ActiveUnit.Throttle.Flank;
						Mount firingMount2 = null;
						Class568.Enum154 sonobuoyDepthSetting2 = Class568.Enum154.const_0;
						long armDelay_sec2 = 0L;
						Class316 @class = null;
						this.method_43(float_0, ref value, theTarget2, ref num, specificNumberOfWeaponsToFire2, initialHeading2, throttleSetting2, firingMount2, sonobuoyDepthSetting2, armDelay_sec2, ref @class);
						list2[0] = value;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100476", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x000CAB20 File Offset: 0x000C8D20
		private void method_41(ActiveUnit activeUnit_1, ref UnguidedWeapon unguidedWeapon_0, StringBuilder stringBuilder_0)
		{
			try
			{
				if (activeUnit_1.bool_3)
				{
					switch (((Aircraft)activeUnit_1).enum39_0)
					{
					case Aircraft.Enum39.const_0:
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Basic-tech bombsight - accuracy unaffected. ");
						}
						break;
					case Aircraft.Enum39.const_1:
						unguidedWeapon_0.float_10 = (float)(0.75 * (double)unguidedWeapon_0.float_10);
						unguidedWeapon_0.float_9 = (float)(0.75 * (double)unguidedWeapon_0.float_9);
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Ballistic-tech bombsight - accuracy improved by 25%. ");
						}
						break;
					case Aircraft.Enum39.const_2:
						unguidedWeapon_0.float_10 = (float)(0.5 * (double)unguidedWeapon_0.float_10);
						unguidedWeapon_0.float_9 = (float)(0.5 * (double)unguidedWeapon_0.float_9);
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Computing-tech bombsight - accuracy improved by 50%. ");
						}
						break;
					case Aircraft.Enum39.const_3:
						unguidedWeapon_0.float_10 = (float)(0.2 * (double)unguidedWeapon_0.float_10);
						unguidedWeapon_0.float_9 = (float)(0.2 * (double)unguidedWeapon_0.float_9);
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Advanced-tech bombsight - accuracy improved by 80%. ");
						}
						break;
					}
					GlobalVariables.ProficiencyLevel? proficiencyLevel = activeUnit_1.vmethod_53();
					int? num = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						unguidedWeapon_0.float_10 *= 2f;
						unguidedWeapon_0.float_9 *= 2f;
						if (!Information.IsNothing(stringBuilder_0))
						{
							stringBuilder_0.Append("Crew is Novice - accuracy reduced by 100%. ");
						}
					}
					else
					{
						num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
						if (((num != null) ? new bool?(num.GetValueOrDefault() == 1) : null).GetValueOrDefault())
						{
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.5);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Crew is Cadet - accuracy reduced by 50%. ");
							}
						}
						else
						{
							num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
							if (((num != null) ? new bool?(num.GetValueOrDefault() == 2) : null).GetValueOrDefault())
							{
								unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.2);
								unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.2);
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Crew is Regular - accuracy reduced by 20%. ");
								}
							}
							else
							{
								num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
								if (((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null).GetValueOrDefault())
								{
									if (!Information.IsNothing(stringBuilder_0))
									{
										stringBuilder_0.Append("Crew is Veteran - accuracy unaffected. ");
									}
								}
								else
								{
									num = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
									{
										unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 0.5);
										unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 0.5);
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("Crew is Ace - accuracy improved by 100%. ");
										}
									}
								}
							}
						}
					}
					if (unguidedWeapon_0.method_63() == Weapon._WeaponType.IronBomb && activeUnit_1.vmethod_13() > 609.60004f)
					{
						float num2 = (activeUnit_1.vmethod_13() - 609.60004f) / 1500f;
						if (num2 > 0f)
						{
							switch (((Aircraft)activeUnit_1).enum39_0)
							{
							case Aircraft.Enum39.const_0:
								unguidedWeapon_0.float_10 += num2 * 100f;
								unguidedWeapon_0.float_9 += num2 * 100f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Basic-tech bombsight and ").Append(activeUnit_1.vmethod_14(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							case Aircraft.Enum39.const_1:
								unguidedWeapon_0.float_10 += num2 * 75f;
								unguidedWeapon_0.float_9 += num2 * 75f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Ballistic-tech bombsight and ").Append(activeUnit_1.vmethod_14(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							case Aircraft.Enum39.const_2:
								unguidedWeapon_0.float_10 += num2 * 50f;
								unguidedWeapon_0.float_9 += num2 * 50f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Computing-tech bombsight and ").Append(activeUnit_1.vmethod_14(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							case Aircraft.Enum39.const_3:
								unguidedWeapon_0.float_10 += num2 * 25f;
								unguidedWeapon_0.float_9 += num2 * 25f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Advanced-tech bombsight and ").Append(activeUnit_1.vmethod_14(false)).Append("m altitude - accuracy decreased by ").Append((int)Math.Round((double)num2)).Append("%. ");
								}
								break;
							}
						}
					}
				}
				else if (activeUnit_1.bool_6)
				{
					int int_ = Weather.smethod_0(activeUnit_1.scenario_0, activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_28(null), 0).int_0;
					switch (((Ship)activeUnit_1).vmethod_121())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						switch (int_)
						{
						case 0:
						case 1:
						case 2:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-2 & very small ship - accuracy unaffected. ");
							}
							break;
						case 3:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.1);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 3 & very small ship - accuracy decreased by 10%. ");
							}
							break;
						case 4:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.2);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 4 & very small ship - accuracy decreased by 20%. ");
							}
							break;
						case 5:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.3);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 5 & very small ship - accuracy decreased by 20%. ");
							}
							break;
						case 6:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.5);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & very small ship - accuracy decreased by 50%. ");
							}
							break;
						case 7:
							unguidedWeapon_0.float_10 *= 2f;
							unguidedWeapon_0.float_9 *= 2f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & very small ship - accuracy decreased by 100%. ");
							}
							break;
						case 8:
							unguidedWeapon_0.float_10 *= 3f;
							unguidedWeapon_0.float_9 *= 3f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & very small ship - accuracy decreased by 200%. ");
							}
							break;
						case 9:
							unguidedWeapon_0.float_10 *= 4f;
							unguidedWeapon_0.float_9 *= 4f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & very small ship - accuracy decreased by 300%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						switch (int_)
						{
						case 0:
						case 1:
						case 2:
						case 3:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-3 & small ship - accuracy unaffected. ");
							}
							break;
						case 4:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.1);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 4 & small ship - accuracy decreased by 10%. ");
							}
							break;
						case 5:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.2);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 5 & small ship - accuracy decreased by 20%. ");
							}
							break;
						case 6:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.3);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & small ship - accuracy decreased by 30%. ");
							}
							break;
						case 7:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.5);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & small ship - accuracy decreased by 50%. ");
							}
							break;
						case 8:
							unguidedWeapon_0.float_10 *= 2f;
							unguidedWeapon_0.float_9 *= 2f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & small ship - accuracy decreased by 100%. ");
							}
							break;
						case 9:
							unguidedWeapon_0.float_10 *= 3f;
							unguidedWeapon_0.float_9 *= 3f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & small ship - accuracy decreased by 200%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						switch (int_)
						{
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-4 & medium ship - accuracy unaffected. ");
							}
							break;
						case 5:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.1);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 5 & medium ship - accuracy decreased by 10%. ");
							}
							break;
						case 6:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.2);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & medium ship - accuracy decreased by 20%. ");
							}
							break;
						case 7:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.3);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & medium ship - accuracy decreased by 30%. ");
							}
							break;
						case 8:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.5);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & medium ship - accuracy decreased by 50%. ");
							}
							break;
						case 9:
							unguidedWeapon_0.float_10 *= 2f;
							unguidedWeapon_0.float_9 *= 2f;
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & medium ship - accuracy decreased by 100%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						switch (int_)
						{
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-5 & large ship - accuracy unaffected. ");
							}
							break;
						case 6:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.1);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 6 & large ship - accuracy decreased by 10%. ");
							}
							break;
						case 7:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.2);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & large ship - accuracy decreased by 20%. ");
							}
							break;
						case 8:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.3);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & large ship - accuracy decreased by 30%. ");
							}
							break;
						case 9:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.5);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.5);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & large ship - accuracy decreased by 50%. ");
							}
							break;
						}
						break;
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						switch (int_)
						{
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 0-6 & very large ship - accuracy unaffected. ");
							}
							break;
						case 7:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.1);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.1);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 7 & very large ship - accuracy decreased by 10%. ");
							}
							break;
						case 8:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.2);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.2);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 8 & very large ship - accuracy decreased by 20%. ");
							}
							break;
						case 9:
							unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.3);
							unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.3);
							if (!Information.IsNothing(stringBuilder_0))
							{
								stringBuilder_0.Append("Sea state 9 & very large ship - accuracy decreased by 30%. ");
							}
							break;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100328", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x000CBB64 File Offset: 0x000C9D64
		public bool method_42()
		{
			try
			{
				foreach (Mount mount in this.activeUnit_0.vmethod_51())
				{
					try
					{
						foreach (WeaponRec weaponRec in mount.vmethod_10())
						{
							weaponRec.mount_0 = mount;
							if (weaponRec.method_9() != 0 && weaponRec.method_12(this.activeUnit_0.scenario_0).method_154() && mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
							{
								return true;
							}
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			finally
			{
				List<Mount>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
			{
				foreach (WeaponRec weaponRec2 in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
				{
					weaponRec2.mount_0 = null;
					if (weaponRec2.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Sonobuoy)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x000CBCAC File Offset: 0x000C9EAC
		public List<Unit> method_43(float elapsedTime, ref WeaponRec theWeaponRec, Contact theTarget, ref int NumberOfWeaponsFired, int SpecificNumberOfWeaponsToFire = 0, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Flank, Mount FiringMount = null, Class568.Enum154 SonobuoyDepthSetting = Class568.Enum154.const_0, long ArmDelay_sec = 0L, ref Class316 theWeaponSalvo = null)
		{
			ActiveUnit_Weaponry.Class235 @class = new ActiveUnit_Weaponry.Class235(@class);
			@class.contact_0 = theTarget;
			float num;
			if (@class.contact_0 != null)
			{
				num = this.activeUnit_0.method_36(@class.contact_0);
			}
			Weapon weapon = theWeaponRec.method_12(this.activeUnit_0.scenario_0);
			List<Unit> list = new List<Unit>();
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				Weapon._WeaponType weaponType = weapon.method_167();
				if (weaponType <= Weapon._WeaponType.GuidedProjectile)
				{
					if (weaponType != Weapon._WeaponType.GuidedWeapon)
					{
						switch (weaponType)
						{
						case Weapon._WeaponType.Decoy_Expendable:
						{
							Weapon weapon2 = Weapon.smethod_16(ref this.activeUnit_0.scenario_0, theWeaponRec.int_5, null);
							if (weapon2.method_154())
							{
								ChaffCorridorCloud item = new ChaffCorridorCloud(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_9());
								this.activeUnit_0.scenario_0.ChaffClouds.Add(item);
							}
							theWeaponRec.method_10(theWeaponRec.method_9() - 1);
							theWeaponRec.method_15();
							NumberOfWeaponsFired = 1;
							list.Add(weapon2);
							goto IL_168C;
						}
						case Weapon._WeaponType.Decoy_Towed:
						case Weapon._WeaponType.TrainingRound:
						case Weapon._WeaponType.Dispenser:
							goto IL_869;
						case Weapon._WeaponType.Decoy_Vehicle:
						case Weapon._WeaponType.GuidedProjectile:
							break;
						case Weapon._WeaponType.ContactBomb_Suicide:
							theWeaponRec.method_10(theWeaponRec.method_9() - 1);
							theWeaponRec.method_15();
							this.activeUnit_0.scenario_0.method_65(this.activeUnit_0);
							foreach (Warhead warhead in weapon.warhead_0)
							{
								new Explosion(ref this.activeUnit_0.scenario_0, @class.contact_0.vmethod_28(null), @class.contact_0.vmethod_30(null), @class.contact_0.vmethod_28(null), @class.contact_0.vmethod_30(null), this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_14(false), weapon.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, @class.contact_0.activeUnit_0, null, this.activeUnit_0, null, null, warhead.short_1, warhead.short_2, (int)warhead.short_0, 0f, 0).vmethod_10(this.activeUnit_0.vmethod_9());
							}
							if (!Information.IsNothing(theWeaponSalvo))
							{
								foreach (Class316.Class273 class2 in theWeaponSalvo.class273_0)
								{
									if (Operators.CompareString(class2.string_0, this.activeUnit_0.string_0, false) == 0)
									{
										Class316.Class273 class3 = class2;
										ref int ptr = ref class3.int_1;
										class3.int_1 = ptr + 1;
									}
								}
								this.activeUnit_0.vmethod_7(false).method_89(ref this.activeUnit_0.scenario_0, theWeaponSalvo);
								goto IL_168C;
							}
							goto IL_168C;
						case Weapon._WeaponType.ContactBomb_Sabotage:
							theWeaponRec.method_10(theWeaponRec.method_9() - 1);
							theWeaponRec.method_15();
							foreach (Warhead warhead2 in weapon.warhead_0)
							{
								new Explosion(ref this.activeUnit_0.scenario_0, @class.contact_0.vmethod_28(null), @class.contact_0.vmethod_30(null), @class.contact_0.vmethod_28(null), @class.contact_0.vmethod_30(null), this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_14(false), weapon.method_167(), warhead2.float_0, warhead2.float_0, warhead2.warheadType_0, warhead2.enum126_0, @class.contact_0.activeUnit_0, null, this.activeUnit_0, null, null, warhead2.short_1, warhead2.short_2, (int)warhead2.short_0, warhead2.float_0, 0).vmethod_10(this.activeUnit_0.vmethod_9());
							}
							if (!Information.IsNothing(theWeaponSalvo))
							{
								foreach (Class316.Class273 class4 in theWeaponSalvo.class273_0)
								{
									if (Operators.CompareString(class4.string_0, this.activeUnit_0.string_0, false) == 0)
									{
										Class316.Class273 class5 = class4;
										ref int ptr = ref class5.int_1;
										class5.int_1 = ptr + 1;
									}
								}
								this.activeUnit_0.vmethod_7(false).method_89(ref this.activeUnit_0.scenario_0, theWeaponSalvo);
								goto IL_168C;
							}
							goto IL_168C;
						default:
							goto IL_869;
						}
					}
				}
				else
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.Torpedo:
						break;
					case Weapon._WeaponType.DepthCharge:
						goto IL_869;
					case Weapon._WeaponType.Sonobuoy:
					{
						Weapon weapon3 = Weapon.smethod_16(ref this.activeUnit_0.scenario_0, theWeaponRec.int_5, null);
						weapon3.method_173(weapon3.int_7);
						weapon3.method_175(weapon3.int_9);
						this.method_47(elapsedTime, this.activeUnit_0, weapon3, theWeaponRec.int_5, null, FiringMount, this.activeUnit_0.vmethod_9(), ActiveUnit.Throttle.Cruise, SonobuoyDepthSetting, null);
						theWeaponRec.method_10(theWeaponRec.method_9() - 1);
						theWeaponRec.method_15();
						NumberOfWeaponsFired = 1;
						list.Add(weapon3);
						goto IL_168C;
					}
					case Weapon._WeaponType.BottomMine:
					case Weapon._WeaponType.MooredMine:
					case Weapon._WeaponType.FloatingMine:
					case Weapon._WeaponType.MovingMine:
					case Weapon._WeaponType.RisingMine:
					{
						UnguidedWeapon unguidedWeapon = new UnguidedWeapon(weapon, null, null, 0.0, 0.0, ArmDelay_sec);
						unguidedWeapon.vmethod_8(false, this.activeUnit_0.vmethod_7(false));
						if (string.CompareOrdinal(UnguidedWeapon.smethod_3(ref unguidedWeapon, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (float)this.activeUnit_0.method_9(false, false, false), this.activeUnit_0.scenario_0), "OK") != 0)
						{
							goto IL_168C;
						}
						this.activeUnit_0.scenario_0.vmethod_20().Add(unguidedWeapon.string_0, unguidedWeapon);
						theWeaponRec.method_10(theWeaponRec.method_9() - 1);
						theWeaponRec.method_15();
						NumberOfWeaponsFired = 1;
						list.Add(unguidedWeapon);
						if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Mining && ((Class340)this.activeUnit_0.vmethod_101()).list_5.Count > 3)
						{
							this.activeUnit_0.vmethod_85().vmethod_9();
							goto IL_168C;
						}
						goto IL_168C;
					}
					default:
						if (weaponType - Weapon._WeaponType.BallisticMissile > 1 && weaponType != Weapon._WeaponType.HGV)
						{
							goto IL_869;
						}
						break;
					}
				}
				try
				{
					Weapon weapon4 = Weapon.smethod_16(ref this.activeUnit_0.scenario_0, theWeaponRec.int_5, null);
					weapon4.method_173(weapon4.int_7);
					weapon4.method_175(weapon4.int_9);
					try
					{
						if (Information.IsNothing(theWeaponSalvo))
						{
						}
						if (this.activeUnit_0.bool_3)
						{
							this.method_47(elapsedTime, this.activeUnit_0, weapon4, theWeaponRec.int_5, @class.contact_0, FiringMount, this.activeUnit_0.vmethod_9(), ActiveUnit.Throttle.Cruise, SonobuoyDepthSetting, theWeaponSalvo);
						}
						else
						{
							this.method_47(elapsedTime, this.activeUnit_0, weapon4, theWeaponRec.int_5, @class.contact_0, FiringMount, Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), @class.contact_0.vmethod_30(null), @class.contact_0.vmethod_28(null)), ActiveUnit.Throttle.Cruise, SonobuoyDepthSetting, theWeaponSalvo);
						}
						if (!Information.IsNothing(theWeaponSalvo))
						{
							string string_ = weapon4.string_0;
							Class429.smethod_32(ref theWeaponSalvo.string_2, string_);
						}
						else if (this.activeUnit_0.bool_2)
						{
							weapon4.method_178(((Weapon)this.activeUnit_0).method_177());
							if (@class.contact_0.contactType_0 == Contact_Base.ContactType.Aimpoint)
							{
								List<Contact> list2 = new List<Contact>();
								if (this.activeUnit_0.vmethod_86().method_12().Length > 0)
								{
									list2.AddRange(this.activeUnit_0.vmethod_86().method_12());
								}
								if (!Information.IsNothing(this.activeUnit_0.vmethod_86().vmethod_3()) && this.activeUnit_0.vmethod_86().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint)
								{
									list2.Add(this.activeUnit_0.vmethod_86().vmethod_3());
								}
								if (list2.Count != 0)
								{
									list2 = Enumerable.ToList<Contact>(Enumerable.OrderBy<Contact, double>(list2, new Func<Contact, double>(@class.method_0)));
									@class.contact_0 = list2[0];
								}
							}
							weapon4.method_250(ref weapon4, ref @class.contact_0, this.activeUnit_0.scenario_0);
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 100333", "");
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					theWeaponRec.method_10(theWeaponRec.method_9() - 1);
					theWeaponRec.method_15();
					if (weapon4.class394_0.bool_5 && !Information.IsNothing(weapon.keyValuePair_0) && weapon.keyValuePair_0.Key != 0)
					{
						weapon4.keyValuePair_0 = weapon.keyValuePair_0;
						weapon4.bool_28 = true;
					}
					if (weapon4.method_167() == Weapon._WeaponType.RV | weapon4.method_167() == Weapon._WeaponType.HGV)
					{
						weapon4.method_173(((Weapon)this.activeUnit_0).method_172());
						weapon4.method_175(((Weapon)this.activeUnit_0).method_174());
					}
					NumberOfWeaponsFired = 1;
					list.Add(weapon4);
					if (weapon4.struct36_0.bool_12)
					{
						if (this.activeUnit_0.bool_3 && weapon4.bool_7)
						{
							weapon4.enum127_0 = Weapon.Enum127.const_2;
						}
						else
						{
							weapon4.enum127_0 = Weapon.Enum127.const_1;
						}
					}
					goto IL_168C;
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100332", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					goto IL_168C;
				}
				IL_869:
				Weapon._WeaponType weaponType2 = weapon.method_167();
				double? num5;
				if (weaponType2 <= Weapon._WeaponType.Gun)
				{
					if (weaponType2 - Weapon._WeaponType.Rocket <= 1)
					{
						int num2 = 150;
						if (SpecificNumberOfWeaponsToFire > 0 && num2 > SpecificNumberOfWeaponsToFire)
						{
							num2 = SpecificNumberOfWeaponsToFire;
						}
						if (num2 > theWeaponRec.method_9())
						{
							num2 = theWeaponRec.method_9();
						}
						Sensor sensor_ = null;
						stringBuilder.Append(this.activeUnit_0.Name).Append(" attacks with unguided weapon(s): ").Append(num2).Append("x ").Append(theWeaponRec.method_12(this.activeUnit_0.scenario_0).Name).Append(". ");
						this.method_50(ref @class.contact_0, FiringMount, ref sensor_);
						int num3 = num2;
						for (int m = 1; m <= num3; m++)
						{
							if (theWeaponRec.method_9() == 0)
							{
								break;
							}
							UnguidedWeapon unguidedWeapon2 = new UnguidedWeapon(weapon, @class.contact_0, this.activeUnit_0, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), 0L);
							if (m == 1)
							{
								switch (@class.contact_0.contactType_0)
								{
								case Contact_Base.ContactType.Air:
								case Contact_Base.ContactType.Missile:
									stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon2.float_13).Append("%. ");
									break;
								case Contact_Base.ContactType.Surface:
									stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon2.float_9).Append("m. ");
									break;
								case Contact_Base.ContactType.Submarine:
									stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon2.float_16).Append("%. ");
									break;
								case Contact_Base.ContactType.Facility_Fixed:
								case Contact_Base.ContactType.Facility_Mobile:
									stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon2.float_10).Append("m. ");
									break;
								}
							}
							if (unguidedWeapon2.method_63() != Weapon._WeaponType.IronBomb && !this.activeUnit_0.bool_3)
							{
								double num4 = (double)(num / weapon.method_181(this.activeUnit_0, @class.contact_0, false, null, false));
								unguidedWeapon2.float_9 = (float)((int)Math.Round((double)weapon.method_172() * num4));
								unguidedWeapon2.float_10 = (float)((int)Math.Round((double)weapon.method_174() * num4));
								if (m == 1)
								{
									stringBuilder.Append("Range is ").Append((int)Math.Round(100.0 * num4)).Append("% of maximum, CEP adjusted to same. ");
								}
							}
							if (m == 1)
							{
								this.method_49(ref FiringMount, unguidedWeapon2, sensor_, @class.contact_0, theWeaponSalvo, stringBuilder);
							}
							else
							{
								this.method_49(ref FiringMount, unguidedWeapon2, sensor_, @class.contact_0, theWeaponSalvo, null);
							}
							this.method_41(this.activeUnit_0, ref unguidedWeapon2, stringBuilder);
							num5 = ActiveUnit_Navigator.smethod_5(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (double)this.activeUnit_0.vmethod_9(), @class.contact_0, unguidedWeapon2.vmethod_40());
							float? num6 = (num5 != null) ? new float?((float)num5.GetValueOrDefault()) : null;
							if (num6 == null)
							{
								ValueTuple<Geopoint_Struct, TimeSpan> valueTuple = ActiveUnit_Navigator.smethod_4(this.activeUnit_0, unguidedWeapon2.method_20(), @class.contact_0);
								if (!Information.IsNothing(valueTuple))
								{
									num6 = new float?(this.activeUnit_0.method_34(valueTuple.Item1.double_1, valueTuple.Item1.double_0));
								}
							}
							if (num6 != null)
							{
								unguidedWeapon2.vmethod_10(num6.Value);
							}
							else
							{
								unguidedWeapon2.vmethod_10(this.activeUnit_0.vmethod_86().method_68(@class.contact_0));
							}
							unguidedWeapon2.vmethod_8(false, this.activeUnit_0.vmethod_7(false));
							unguidedWeapon2.vmethod_15(false, this.activeUnit_0.vmethod_14(false));
							this.activeUnit_0.scenario_0.vmethod_20().Add(unguidedWeapon2.string_0, unguidedWeapon2);
							theWeaponRec.method_10(theWeaponRec.method_9() - 1);
							NumberOfWeaponsFired++;
							list.Add(unguidedWeapon2);
							unguidedWeapon2.method_59(this.activeUnit_0);
							unguidedWeapon2.string_4 = this.activeUnit_0.string_0;
							switch (@class.contact_0.contactType_0)
							{
							case Contact_Base.ContactType.Air:
							case Contact_Base.ContactType.Missile:
								stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon2.float_13).Append("%. ");
								break;
							case Contact_Base.ContactType.Surface:
								stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon2.float_9).Append("m. ");
								break;
							case Contact_Base.ContactType.Submarine:
								stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon2.float_16).Append("%. ");
								break;
							case Contact_Base.ContactType.Facility_Fixed:
							case Contact_Base.ContactType.Facility_Mobile:
								stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon2.float_10).Append("m. ");
								break;
							}
							this.activeUnit_0.method_124(stringBuilder.ToString(), unguidedWeapon2.Name + " being fired", LoggedMessage.MessageType.UnguidedWeaponModifiers, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							this.method_48(@class.contact_0, unguidedWeapon2.method_61());
							if (!Information.IsNothing(theWeaponSalvo))
							{
								string string_2 = unguidedWeapon2.string_0;
								Class429.smethod_32(ref theWeaponSalvo.string_2, string_2);
							}
						}
						goto IL_168C;
					}
					if (weaponType2 != Weapon._WeaponType.Gun)
					{
						goto IL_168C;
					}
				}
				else if (weaponType2 != Weapon._WeaponType.Dispenser)
				{
					if (weaponType2 != Weapon._WeaponType.DepthCharge && weaponType2 != Weapon._WeaponType.Laser)
					{
						goto IL_168C;
					}
				}
				else
				{
					Weapon weapon5 = Weapon.smethod_16(ref this.activeUnit_0.scenario_0, theWeaponRec.int_5, null);
					foreach (Warhead warhead3 in weapon5.warhead_0)
					{
						new Explosion(ref this.activeUnit_0.scenario_0, @class.contact_0.vmethod_28(null), @class.contact_0.vmethod_30(null), @class.contact_0.vmethod_28(null), @class.contact_0.vmethod_30(null), this.activeUnit_0.vmethod_9(), this.activeUnit_0.vmethod_14(false), weapon.method_167(), warhead3.float_0, warhead3.float_0, warhead3.warheadType_0, warhead3.enum126_0, null, null, this.activeUnit_0, null, new float?(10f), warhead3.short_1, warhead3.short_2, (int)warhead3.short_0, 0f, 0).vmethod_10(this.activeUnit_0.vmethod_9());
					}
					theWeaponRec.method_10(theWeaponRec.method_9() - 1);
					NumberOfWeaponsFired = 1;
					list.Add(weapon5);
					theWeaponRec.method_15();
					this.method_48(@class.contact_0, weapon5);
					if (!Information.IsNothing(theWeaponSalvo))
					{
						string string_3 = weapon5.string_0;
						Class429.smethod_32(ref theWeaponSalvo.string_2, string_3);
						goto IL_168C;
					}
					goto IL_168C;
				}
				UnguidedWeapon unguidedWeapon3 = new UnguidedWeapon(weapon, @class.contact_0, this.activeUnit_0, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), 0L);
				if (weapon.method_181(this.activeUnit_0, @class.contact_0, false, null, false) > 0f)
				{
					unguidedWeapon3.float_9 = (float)((int)Math.Round((double)((float)weapon.int_7 * num / weapon.method_181(this.activeUnit_0, @class.contact_0, false, null, false))));
					unguidedWeapon3.float_10 = (float)((int)Math.Round((double)((float)weapon.int_9 * num / weapon.method_181(this.activeUnit_0, @class.contact_0, false, null, false))));
				}
				Sensor sensor_2 = null;
				stringBuilder.Append(this.activeUnit_0.Name).Append(" attacks with unguided weapon: ").Append(theWeaponRec.method_12(this.activeUnit_0.scenario_0).Name).Append(". ");
				switch (@class.contact_0.contactType_0)
				{
				case Contact_Base.ContactType.Air:
				case Contact_Base.ContactType.Missile:
					stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon3.float_13).Append("%. ");
					break;
				case Contact_Base.ContactType.Surface:
					stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon3.float_9).Append("m. ");
					break;
				case Contact_Base.ContactType.Submarine:
					stringBuilder.Append("Nominal PoH: ").Append(unguidedWeapon3.float_16).Append("%. ");
					break;
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
					stringBuilder.Append("Nominal CEP: ").Append(unguidedWeapon3.float_10).Append("m. ");
					break;
				}
				this.method_50(ref @class.contact_0, FiringMount, ref sensor_2);
				this.method_49(ref FiringMount, unguidedWeapon3, sensor_2, @class.contact_0, theWeaponSalvo, stringBuilder);
				this.method_41(this.activeUnit_0, ref unguidedWeapon3, stringBuilder);
				num5 = ActiveUnit_Navigator.smethod_5(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (double)this.activeUnit_0.vmethod_9(), @class.contact_0, unguidedWeapon3.vmethod_40());
				float? num7 = (num5 != null) ? new float?((float)num5.GetValueOrDefault()) : null;
				if (num7 == null)
				{
					ValueTuple<Geopoint_Struct, TimeSpan> valueTuple2 = ActiveUnit_Navigator.smethod_4(this.activeUnit_0, unguidedWeapon3.vmethod_40(), @class.contact_0);
					if (!Information.IsNothing(valueTuple2))
					{
						num7 = new float?(this.activeUnit_0.method_34(valueTuple2.Item1.double_1, valueTuple2.Item1.double_0));
					}
				}
				if (num7 != null)
				{
					unguidedWeapon3.vmethod_10(num7.Value);
				}
				else
				{
					unguidedWeapon3.vmethod_10(this.activeUnit_0.vmethod_86().method_68(@class.contact_0));
				}
				unguidedWeapon3.vmethod_8(false, this.activeUnit_0.vmethod_7(false));
				this.activeUnit_0.scenario_0.vmethod_20().Add(unguidedWeapon3.string_0, unguidedWeapon3);
				theWeaponRec.method_10(theWeaponRec.method_9() - 1);
				NumberOfWeaponsFired = 1;
				list.Add(unguidedWeapon3);
				theWeaponRec.method_15();
				unguidedWeapon3.method_57(new GeoPoint(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_14(false)));
				unguidedWeapon3.method_59(this.activeUnit_0);
				unguidedWeapon3.string_4 = this.activeUnit_0.string_0;
				if (!Information.IsNothing(theWeaponSalvo))
				{
					string string_4 = unguidedWeapon3.string_0;
					Class429.smethod_32(ref theWeaponSalvo.string_2, string_4);
				}
				switch (@class.contact_0.contactType_0)
				{
				case Contact_Base.ContactType.Air:
				case Contact_Base.ContactType.Missile:
					stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon3.float_13).Append("%. ");
					break;
				case Contact_Base.ContactType.Surface:
					stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon3.float_9).Append("m. ");
					break;
				case Contact_Base.ContactType.Submarine:
					stringBuilder.Append("Final PoH at fire/launch point: ").Append(unguidedWeapon3.float_16).Append("%. ");
					break;
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
					stringBuilder.Append("Final CEP at fire/launch point: ").Append(unguidedWeapon3.float_10).Append("m. ");
					break;
				}
				this.activeUnit_0.method_124(stringBuilder.ToString(), unguidedWeapon3.Name + " being fired", LoggedMessage.MessageType.UnguidedWeaponModifiers, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
				this.method_48(@class.contact_0, unguidedWeapon3);
				IL_168C:
				if (this.activeUnit_0.bool_3 && weapon.int_0 > 0 && ((Aircraft)this.activeUnit_0).method_167().int_5 > 0)
				{
					this.method_45();
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100331", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			checked
			{
				try
				{
					Side[] array = this.activeUnit_0.scenario_0.method_44();
					for (int num8 = 0; num8 < array.Length; num8++)
					{
						array[num8].method_57(this.activeUnit_0, @class.contact_0, theWeaponRec);
					}
				}
				catch (Exception ex4)
				{
					ex4.Data.Add("Error at 100330", "");
					GameGeneral.smethod_25(ref ex4);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					if (NumberOfWeaponsFired > 0)
					{
						this.activeUnit_0.vmethod_7(false).class366_0.method_0(theWeaponRec.int_5, NumberOfWeaponsFired);
						ActiveUnit_Weaponry.Delegate22 @delegate = ActiveUnit_Weaponry.delegate22_0;
						if (@delegate != null)
						{
							@delegate(this.activeUnit_0.scenario_0, this.activeUnit_0, weapon);
						}
					}
				}
				catch (Exception ex5)
				{
					ex5.Data.Add("Error at 100328", "");
					GameGeneral.smethod_25(ref ex5);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return list;
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x000CD530 File Offset: 0x000CB730
		public List<Unit> method_44(ref WeaponRec weaponRec_0, Contact contact_0, ref List<string> list_3, ref int int_0, HashSet<int> hashSet_1)
		{
			if (contact_0 != null)
			{
				this.activeUnit_0.method_36(contact_0);
			}
			Weapon weapon = weaponRec_0.method_12(this.activeUnit_0.scenario_0);
			List<Unit> list = new List<Unit>();
			new StringBuilder();
			try
			{
				Weapon._WeaponType weaponType = weapon.method_167();
				bool flag;
				if (weaponType - Weapon._WeaponType.Decoy_Expendable <= 1)
				{
					if (hashSet_1.Contains(weapon.DBID))
					{
						flag = false;
					}
					else
					{
						Weapon weapon2 = weapon;
						Weapon weapon3 = (Weapon)contact_0.activeUnit_0;
						flag = weapon2.method_262(ref weapon3, ref this.activeUnit_0, ref list_3);
						hashSet_1.Add(weapon.DBID);
					}
				}
				else
				{
					new UnguidedWeapon(weapon, contact_0, this.activeUnit_0, this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), 0L);
					flag = weapon.vmethod_146(contact_0.activeUnit_0, this.activeUnit_0.scenario_0, true, ref list_3);
				}
				if (weapon.method_167() == Weapon._WeaponType.Decoy_Towed)
				{
					if (flag && GameGeneral.smethod_5().Next(0, 101) > 50)
					{
						weaponRec_0.method_10(weaponRec_0.method_9() - 1);
						int_0 = 1;
						list.Add(weapon);
					}
				}
				else
				{
					weaponRec_0.method_10(weaponRec_0.method_9() - 1);
					weaponRec_0.method_15();
					int_0 = 1;
					list.Add(weapon);
				}
				if (this.activeUnit_0.bool_3 && weapon.int_0 > 0 && ((Aircraft)this.activeUnit_0).method_167().int_5 > 0)
				{
					this.method_45();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 1003245023495023495", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			checked
			{
				try
				{
					Side[] array = this.activeUnit_0.scenario_0.method_44();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].method_57(this.activeUnit_0, contact_0, weaponRec_0);
					}
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 1023450923845902386524598", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				try
				{
					if (int_0 > 0)
					{
						this.activeUnit_0.vmethod_7(false).class366_0.method_0(weaponRec_0.int_5, int_0);
						ActiveUnit_Weaponry.Delegate22 @delegate = ActiveUnit_Weaponry.delegate22_0;
						if (@delegate != null)
						{
							@delegate(this.activeUnit_0.scenario_0, this.activeUnit_0, weapon);
						}
					}
				}
				catch (Exception ex3)
				{
					ex3.Data.Add("Error at 10354329054823906834905634", "");
					GameGeneral.smethod_25(ref ex3);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return list;
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000CD830 File Offset: 0x000CBA30
		public void method_45()
		{
			try
			{
				if (!Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
				{
					Loadout loadout = ((Aircraft)this.activeUnit_0).method_167();
					DBFunctions.smethod_51(ref this.activeUnit_0.scenario_0, ref loadout);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100334", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000CD8C0 File Offset: 0x000CBAC0
		private void method_46(Weapon weapon_6, Contact contact_0)
		{
			checked
			{
				try
				{
					if (!Information.IsNothing(contact_0) && weapon_6.method_2() && (contact_0.contactType_0 == Contact_Base.ContactType.Submarine || contact_0.contactType_0 == Contact_Base.ContactType.Submarine || contact_0.contactType_0 == Contact_Base.ContactType.ActivationPoint || weapon_6.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint) && weapon_6.method_231())
					{
						if (weapon_6.vmethod_96().Length > 0)
						{
							weapon_6.method_230();
							weapon_6.method_271();
						}
						if (weapon_6.vmethod_94().Length > 0)
						{
							weapon_6.method_229();
							weapon_6.method_271();
						}
					}
					if (!Information.IsNothing(contact_0) && !Information.IsNothing(contact_0.activeUnit_0) && weapon_6.method_2() && contact_0.contactType_0 == Contact_Base.ContactType.Facility_Fixed && weapon_6.vmethod_96().Length > 0)
					{
						bool flag = false;
						Sensor[] array = weapon_6.vmethod_96();
						int i = 0;
						while (i < array.Length)
						{
							if (!array[i].method_63(contact_0.activeUnit_0))
							{
								i++;
							}
							else
							{
								flag = true;
								IL_D1:
								if (!flag)
								{
									Sensor[] array2 = weapon_6.vmethod_96();
									Class429.smethod_26(ref array2);
									weapon_6.method_271();
									goto IL_E8;
								}
								goto IL_E8;
							}
						}
						goto IL_D1;
					}
					IL_E8:;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100335", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000CDA00 File Offset: 0x000CBC00
		private void method_47(float elapsedTime, ActiveUnit FiringUnit, Weapon theWeapon, int WeaponID, Contact theTarget, Mount FiringMount, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise, Class568.Enum154 SonobuoyDepthSetting = Class568.Enum154.const_0, Class316 ParentSalvo = null)
		{
			try
			{
				theWeapon.method_178(FiringUnit);
				if (!FiringUnit.vmethod_89().bool_2 && this.method_28(theWeapon, theTarget))
				{
					Weapon.smethod_15(theWeapon, FiringUnit.scenario_0, this.activeUnit_0.bool_3 || this.activeUnit_0.method_2());
				}
				FiringUnit.scenario_0.UnitsAutoIncrement = FiringUnit.scenario_0.UnitsAutoIncrement + 1;
				theWeapon.Name = theWeapon.Name + " #" + Conversions.ToString(FiringUnit.scenario_0.UnitsAutoIncrement);
				theWeapon.vmethod_8(false, FiringUnit.vmethod_7(false));
				theWeapon.vmethod_142().vmethod_4(theTarget);
				if (!Information.IsNothing(theTarget))
				{
					theWeapon.vmethod_142().vmethod_8(theTarget.contactType_0);
				}
				if (FiringUnit.vmethod_40() > 0f)
				{
					theWeapon.vmethod_29(null, FiringUnit.method_11(elapsedTime));
					theWeapon.vmethod_31(null, FiringUnit.method_12(elapsedTime));
				}
				else
				{
					theWeapon.vmethod_29(null, FiringUnit.vmethod_28(null));
					theWeapon.vmethod_31(null, FiringUnit.vmethod_30(null));
				}
				theWeapon.vmethod_15(true, FiringUnit.vmethod_14(false));
				if (theWeapon.bool_7 && theWeapon.vmethod_82() >= ActiveUnit.Throttle.Full)
				{
					Scenario scenario_ = this.activeUnit_0.scenario_0;
					int dbid = theWeapon.DBID;
					ActiveUnit firingUnit = this.activeUnit_0;
					double launchLongitude = this.activeUnit_0.vmethod_28(null);
					double launchLatitude = this.activeUnit_0.vmethod_30(null);
					float launchAltitude = (float)((int)Math.Round((double)this.activeUnit_0.vmethod_14(false)));
					int launchSpeed = (int)Math.Round((double)this.activeUnit_0.vmethod_40());
					double targetLongitude = theTarget.vmethod_28(null);
					double targetLatitude = theTarget.vmethod_30(null);
					float targetHeading = theTarget.vmethod_9();
					bool bool_ = theTarget.bool_18;
					int targetSpeed = (int)Math.Round((double)theTarget.vmethod_40());
					bool bool_2 = theTarget.bool_17;
					float targetAltitude = theTarget.vmethod_14(false);
					bool bool_3 = theTarget.bool_19;
					Contact_Base.ContactType contactType_ = theTarget.contactType_0;
					GeoPoint geoPoint = null;
					string key = null;
					float initialHeading = 0f;
					ActiveUnit.Throttle throttleSetting = ActiveUnit.Throttle.Full;
					int customWeaponFuel = (int)Math.Round((double)((float)theWeapon.vmethod_67()[0].int_0) * 0.8999999985098839);
					List<float> xdat = null;
					List<float> ydat = null;
					float num = 0f;
					if (Operators.CompareString(ActiveUnit_Weaponry.smethod_5(scenario_, dbid, firingUnit, launchLongitude, launchLatitude, launchAltitude, launchSpeed, targetLongitude, targetLatitude, targetHeading, bool_, targetSpeed, bool_2, targetAltitude, bool_3, contactType_, ref geoPoint, ref key, initialHeading, throttleSetting, customWeaponFuel, xdat, ydat, ref num), "OK", false) == 0)
					{
						ThrottleSetting = ActiveUnit.Throttle.Full;
					}
				}
				theWeapon.vmethod_134(ThrottleSetting, null);
				float float_ = (float)theWeapon.vmethod_143().vmethod_40(theWeapon.vmethod_14(false), ThrottleSetting, false);
				if (theWeapon.bool_7)
				{
					theWeapon.vmethod_41(float_);
				}
				else if (theWeapon.method_167() == Weapon._WeaponType.GuidedProjectile)
				{
					theWeapon.vmethod_41(float_);
				}
				else
				{
					theWeapon.vmethod_41(FiringUnit.vmethod_40() + theWeapon.vmethod_143().vmethod_8(theWeapon.vmethod_84(), this.activeUnit_0.vmethod_14(false), this.activeUnit_0.vmethod_40()));
				}
				if (theWeapon.method_167() == Weapon._WeaponType.Sonobuoy)
				{
					theWeapon.vmethod_41(0f);
				}
				if (Information.IsNothing(theWeapon.vmethod_70()))
				{
					theWeapon.vmethod_71(theWeapon.vmethod_40());
				}
				this.method_46(theWeapon, theTarget);
				if (InitialHeading == 0f)
				{
					if (FiringUnit.bool_3)
					{
						theWeapon.vmethod_10(FiringUnit.vmethod_9());
					}
					else if (FiringUnit.bool_5)
					{
						if (theWeapon.method_199())
						{
							theWeapon.vmethod_10(Math2.smethod_17(FiringUnit.vmethod_30(null), FiringUnit.vmethod_28(null), theWeapon.vmethod_142().vmethod_3().vmethod_30(null), theWeapon.vmethod_142().vmethod_3().vmethod_28(null)));
						}
						else
						{
							theWeapon.vmethod_10(FiringUnit.vmethod_9());
						}
					}
					else
					{
						theWeapon.vmethod_10(Math2.smethod_17(FiringUnit.vmethod_30(null), FiringUnit.vmethod_28(null), theWeapon.vmethod_142().vmethod_3().vmethod_30(null), theWeapon.vmethod_142().vmethod_3().vmethod_28(null)));
					}
				}
				else
				{
					theWeapon.vmethod_10(InitialHeading);
				}
				if (theWeapon.vmethod_68() == 0f)
				{
					theWeapon.vmethod_69(ActiveUnit.Enum28.const_0, theWeapon.vmethod_9());
				}
				if (theWeapon.vmethod_2() && !FiringUnit.bool_3)
				{
					double? num2 = ActiveUnit_Navigator.smethod_5(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), (double)this.activeUnit_0.vmethod_9(), theWeapon.vmethod_142().vmethod_3(), theWeapon.vmethod_40());
					if (num2 == null)
					{
						ValueTuple<Geopoint_Struct, TimeSpan> valueTuple = ActiveUnit_Navigator.smethod_4(this.activeUnit_0, theWeapon.vmethod_40(), theTarget);
						if (!Information.IsNothing(valueTuple))
						{
							num2 = new double?((double)this.activeUnit_0.method_34(valueTuple.Item1.double_1, valueTuple.Item1.double_0));
						}
					}
					if (!Information.IsNothing(num2))
					{
						theWeapon.vmethod_10((float)num2.Value);
						theWeapon.vmethod_69(ActiveUnit.Enum28.const_0, (float)num2.Value);
					}
				}
				checked
				{
					if (!Information.IsNothing(theWeapon.vmethod_142().vmethod_3()) && Enumerable.Count<CommDevice>(theWeapon.vmethod_94()) == 0 && theWeapon.vmethod_142().vmethod_3().method_135() && theWeapon.struct36_0.bool_29 && !theWeapon.class394_0.bool_5 && theWeapon.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.ActivationPoint && theWeapon.class394_0.bool_0)
					{
						Sensor[] array = theWeapon.vmethod_96();
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								theWeapon.method_235(false);
								break;
							}
						}
					}
				}
				if (!Information.IsNothing(theTarget))
				{
					if (theWeapon.method_153() && FiringUnit.bool_3 && ((FiringUnit.vmethod_85().method_32() && !Information.IsNothing(FiringUnit.vmethod_85().method_4()[0].nullable_7)) || (FiringUnit.method_120() && !Information.IsNothing(FiringUnit.vmethod_65(false).method_147()) && FiringUnit.vmethod_65(false).method_147().vmethod_85().method_32() && !Information.IsNothing(FiringUnit.vmethod_65(false).method_147().vmethod_85().method_4()[0].nullable_7))))
					{
						if (!Information.IsNothing(theWeapon.vmethod_142().vmethod_3()))
						{
							theWeapon.method_187().method_50(new Waypoint(theWeapon.vmethod_142().vmethod_3().vmethod_28(null), theWeapon.vmethod_142().vmethod_3().vmethod_30(null), 0f, Waypoint.WaypointType.TerminalPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0));
						}
					}
					else if (!Information.IsNothing(ParentSalvo) && !Information.IsNothing(ParentSalvo.waypoint_0))
					{
						if (Enumerable.Count<Waypoint>(ParentSalvo.waypoint_0) > 0)
						{
							float num3 = Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), ParentSalvo.waypoint_0[0].imethod_2(), ParentSalvo.waypoint_0[0].imethod_0());
							int num4 = Enumerable.Count<Waypoint>(ParentSalvo.waypoint_0) - 2;
							for (int j = 0; j <= num4; j++)
							{
								num3 += Math2.smethod_15(ParentSalvo.waypoint_0[j].imethod_2(), ParentSalvo.waypoint_0[j].imethod_0(), ParentSalvo.waypoint_0[j + 1].imethod_2(), ParentSalvo.waypoint_0[j + 1].imethod_0());
							}
							num3 += Math2.smethod_15(Enumerable.Last<Waypoint>(ParentSalvo.waypoint_0).imethod_2(), Enumerable.Last<Waypoint>(ParentSalvo.waypoint_0).imethod_0(), theTarget.vmethod_30(null), theTarget.vmethod_28(null));
							if (theWeapon.method_181(FiringUnit, theTarget, false, FiringUnit.doctrine_0, false) < num3)
							{
								theWeapon.method_187().method_63(FiringUnit);
							}
							else
							{
								foreach (Waypoint waypoint in ParentSalvo.waypoint_0)
								{
									theWeapon.method_187().method_50(new Waypoint(waypoint.imethod_0(), waypoint.imethod_2(), 0f, waypoint.waypointType_0, Waypoint.Enum80.const_2, Waypoint.Enum79.const_0));
								}
							}
						}
						else if (theWeapon.method_153())
						{
							theWeapon.method_187().method_63(FiringUnit);
							foreach (Waypoint waypoint2 in theWeapon.method_187().method_4())
							{
								Class429.smethod_36(ref ParentSalvo.waypoint_0, new Waypoint(waypoint2.imethod_0(), waypoint2.imethod_2(), 0f, waypoint2.waypointType_0, Waypoint.Enum80.const_2, Waypoint.Enum79.const_0));
							}
						}
					}
				}
				if (!Information.IsNothing(theTarget) && (theWeapon.method_205() || theWeapon.method_169() == Weapon.WeaponGuidanceType.Inertial || (theWeapon.method_231() && (theWeapon.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine || theWeapon.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint || theWeapon.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint))))
				{
					float num5 = theTarget.vmethod_14(false);
					float num6 = theWeapon.vmethod_143().vmethod_31();
					float num7 = theWeapon.vmethod_143().vmethod_30();
					if (num5 > num7)
					{
						num5 = num7;
					}
					if (num5 < num6)
					{
						num5 = num6;
					}
					float float_2;
					if (theWeapon.float_27 != 0f)
					{
						float_2 = (float)theWeapon.vmethod_143().vmethod_40(theWeapon.float_27, ThrottleSetting, false);
					}
					else if (theWeapon.method_145() != 0f)
					{
						float_2 = (float)theWeapon.vmethod_143().vmethod_40(theWeapon.method_145(), ThrottleSetting, false);
					}
					else
					{
						float_2 = (float)theWeapon.vmethod_143().vmethod_40(num5, ThrottleSetting, false);
					}
					theWeapon.method_187().method_64(float_2, FiringUnit.bool_3 && theWeapon.bool_7);
					if (!Information.IsNothing(ParentSalvo) && ParentSalvo.enum130_0 == Weapon.Enum130.const_1)
					{
						if (theWeapon.float_27 > 0f)
						{
							theWeapon.method_187().method_4()[0].imethod_5(theWeapon.float_27);
						}
						else if (theWeapon.method_145() > 0f)
						{
							theWeapon.method_187().method_4()[0].imethod_5(theWeapon.method_145());
						}
						else
						{
							theWeapon.method_187().method_4()[0].imethod_5(theWeapon.vmethod_143().vmethod_30());
						}
					}
					if (FiringUnit.vmethod_3() && FiringUnit.vmethod_85().method_47() && theWeapon.method_187().method_47())
					{
						Enumerable.Last<Waypoint>(theWeapon.method_187().method_4()).imethod_5(Math.Min(Enumerable.Last<Waypoint>(FiringUnit.vmethod_85().method_4()).imethod_4(), FiringUnit.vmethod_14(false)));
					}
					if (theWeapon.method_187().method_46())
					{
						theWeapon.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_17(theWeapon.vmethod_30(null), theWeapon.vmethod_28(null), theWeapon.method_187().method_4()[0].imethod_2(), theWeapon.method_187().method_4()[0].imethod_0()));
					}
				}
				if (theWeapon.method_167() == Weapon._WeaponType.Sonobuoy)
				{
					if (SonobuoyDepthSetting == Class568.Enum154.const_0)
					{
						theWeapon.vmethod_15(true, -40f);
						theWeapon.float_50 = 120f;
					}
					else
					{
						Class568.Class569 @class = Class568.smethod_2(theWeapon.vmethod_30(null), theWeapon.vmethod_28(null), theWeapon.method_9(false, false, false));
						theWeapon.vmethod_15(true, (float)(@class.int_1 - 20));
						theWeapon.float_50 = 240f;
					}
					theWeapon.vmethod_73(theWeapon.vmethod_14(false));
				}
				if (theWeapon.method_169() == Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active)
				{
					theWeapon.method_180(FiringUnit);
				}
				foreach (Warhead warhead in theWeapon.warhead_0)
				{
					if (warhead.warheadType_0 == Warhead.WarheadType.Weapon)
					{
						warhead.method_17(theWeapon.scenario_0).vmethod_142().vmethod_4(theWeapon.vmethod_142().vmethod_3());
						warhead.method_17(theWeapon.scenario_0).vmethod_142().vmethod_8(theWeapon.vmethod_142().vmethod_3().contactType_0);
					}
				}
				if (FiringUnit.bool_3 && theWeapon.bool_7)
				{
					foreach (Sensor sensor in theWeapon.vmethod_96())
					{
						if (sensor.method_58())
						{
							sensor.method_77();
						}
					}
				}
				if (theWeapon.method_219())
				{
					theWeapon.warhead_0[0].method_17(FiringUnit.scenario_0).vmethod_142().vmethod_4(theWeapon.vmethod_142().vmethod_3());
					theWeapon.warhead_0[0].method_17(FiringUnit.scenario_0).vmethod_142().vmethod_8(theWeapon.vmethod_142().vmethod_3().contactType_0);
					((Class168)theWeapon.vmethod_142()).method_133();
				}
				if (Enumerable.Any<Warhead>(theWeapon.warhead_0) && theWeapon.warhead_0[0].warheadType_0 == Warhead.WarheadType.EMP_Directed)
				{
					foreach (Contact contact in FiringUnit.vmethod_86().method_12())
					{
						if (contact != theTarget && FiringUnit.vmethod_86().method_73(theTarget))
						{
							theWeapon.vmethod_142().vmethod_12(contact, false, false, ActiveUnit_AI.TargetingEntry._TargetingBehavior.AutoTargeted);
						}
					}
				}
				theWeapon.vmethod_143().method_18(FiringUnit, theTarget);
				if (theWeapon.vmethod_3() && Enumerable.Any<Warhead>(theWeapon.warhead_0) && theWeapon.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon)
				{
					Weapon weapon = theWeapon.warhead_0[0].method_17(this.activeUnit_0.scenario_0);
					if (theWeapon.method_145() > 0f)
					{
						float num9 = weapon.vmethod_143().vmethod_30();
						if (theWeapon.method_145() > num9)
						{
							theWeapon.method_146(num9 - 10f);
						}
					}
				}
				if (theWeapon.vmethod_6())
				{
					if (this.activeUnit_0.bool_3 && !((Aircraft)this.activeUnit_0).method_169())
					{
						theWeapon.vmethod_19(this.activeUnit_0.vmethod_18());
					}
					else if ((theWeapon.method_195() || theWeapon.method_196()) && !Information.IsNothing(FiringMount))
					{
						if (theWeapon.vmethod_3())
						{
							theWeapon.vmethod_19(90f);
						}
						else if (FiringMount.method_24())
						{
							theWeapon.vmethod_19(90f);
						}
						else if (FiringMount.method_25() && theTarget.bool_19)
						{
							float num10 = (float)((double)Math2.smethod_15(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), theTarget.vmethod_30(null), theTarget.vmethod_28(null)) * 1852.0);
							theWeapon.vmethod_19((float)((int)Math.Round(Math2.smethod_5((double)(num10 / theTarget.vmethod_14(false))))));
							if (theWeapon.vmethod_18() < 0f)
							{
								theWeapon.vmethod_19(0f);
							}
						}
						else
						{
							theWeapon.vmethod_19(45f);
						}
					}
					if (theWeapon.method_167() == Weapon._WeaponType.RV)
					{
						theWeapon.vmethod_19(-(float)Class432.smethod_10((double)this.activeUnit_0.method_36(theTarget), (double)this.activeUnit_0.vmethod_14(false), (double)theTarget.vmethod_14(false)));
					}
				}
				this.method_51(ref FiringUnit, ref theWeapon, ref theTarget);
				ActiveUnit_Weaponry.smethod_4(FiringUnit, theWeapon, theTarget);
				theWeapon.geoPoint_0 = new GeoPoint(theWeapon.vmethod_28(null), theWeapon.vmethod_30(null), theWeapon.vmethod_14(false));
				FiringUnit.scenario_0.method_68(theWeapon);
				if (!Information.IsNothing(theTarget))
				{
					if (this.activeUnit_0.vmethod_7(false).dictionary_5.ContainsKey(theTarget.string_0))
					{
						string key;
						Dictionary<string, int> dictionary_;
						(dictionary_ = this.activeUnit_0.vmethod_7(false).dictionary_5)[key = theTarget.string_0] = dictionary_[key] + 1;
					}
					else
					{
						this.activeUnit_0.vmethod_7(false).dictionary_5.Add(theTarget.string_0, 1);
					}
				}
				this.method_48(theTarget, theWeapon);
				theWeapon.vmethod_143().method_16(true);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100336", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x000CEAB8 File Offset: 0x000CCCB8
		public void method_48(Contact contact_0, Unit unit_0)
		{
			if (contact_0 != null)
			{
				foreach (IEventExporter eventExporter in this.activeUnit_0.scenario_0.method_6())
				{
					if (eventExporter.imethod_8() && eventExporter.imethod_14())
					{
						Dictionary<string, IEventExporter.EventNotificationParameter> dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>();
						if (this.activeUnit_0.scenario_0.MonteCarloIteration > 0)
						{
							dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_0(), typeof(string), 500));
							dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.MonteCarloIteration, typeof(int), 0));
						}
						dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.TimelineID, typeof(string), 0));
						if (eventExporter.imethod_10())
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_31().Subtract(this.activeUnit_0.scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
						}
						else
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.activeUnit_0.scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + this.activeUnit_0.scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
						}
						dictionary.Add("FiringUnitID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.string_0, typeof(string), 40));
						dictionary.Add("FiringUnitDBID", new IEventExporter.EventNotificationParameter(this.activeUnit_0.DBID, typeof(string), 10));
						dictionary.Add("FiringUnitName", new IEventExporter.EventNotificationParameter(this.activeUnit_0.Name, typeof(string), 500));
						dictionary.Add("FiringUnitType", new IEventExporter.EventNotificationParameter(this.activeUnit_0.method_63(), typeof(string), 20));
						dictionary.Add("FiringUnitClass", new IEventExporter.EventNotificationParameter(this.activeUnit_0.string_2, typeof(string), 500));
						dictionary.Add("FiringUnitSide", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_7(false).method_51(), typeof(string), 500));
						dictionary.Add("FiringUnitLongitude", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_28(null), typeof(double), 0));
						dictionary.Add("FiringUnitLatitude", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_30(null), typeof(double), 0));
						dictionary.Add("FiringUnitCourse", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_9(), typeof(double), 0));
						dictionary.Add("FiringUnitSpeed_kts", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_40(), typeof(float), 0));
						dictionary.Add("FiringUnitAltitude_m", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_14(false), typeof(float), 0));
						dictionary.Add("FiringUnitAGL_m", new IEventExporter.EventNotificationParameter(this.activeUnit_0.vmethod_13(), typeof(float), 0));
						dictionary.Add("WeaponID", new IEventExporter.EventNotificationParameter(unit_0.string_0, typeof(string), 40));
						dictionary.Add("WeaponDBID", new IEventExporter.EventNotificationParameter(unit_0.bool_0 ? ((ActiveUnit)unit_0).DBID : ((UnguidedWeapon)unit_0).method_61().DBID, typeof(string), 10));
						string theValue;
						if (unit_0.bool_0)
						{
							theValue = ((Weapon)unit_0).method_151();
						}
						else
						{
							theValue = ((UnguidedWeapon)unit_0).method_61().method_151();
						}
						dictionary.Add("WeaponName", new IEventExporter.EventNotificationParameter(unit_0.Name, typeof(string), 500));
						dictionary.Add("WeaponType", new IEventExporter.EventNotificationParameter(theValue, typeof(string), 200));
						dictionary.Add("WeaponClass", new IEventExporter.EventNotificationParameter(unit_0.string_2, typeof(string), 500));
						dictionary.Add("TargetContactID", new IEventExporter.EventNotificationParameter(contact_0.string_0, typeof(string), 40));
						dictionary.Add("TargetContactLongitude", new IEventExporter.EventNotificationParameter(contact_0.vmethod_28(null), typeof(double), 0));
						dictionary.Add("TargetContactLatitude", new IEventExporter.EventNotificationParameter(contact_0.vmethod_30(null), typeof(double), 0));
						dictionary.Add("TargetContactHeading", new IEventExporter.EventNotificationParameter(Conversions.ToString(Interaction.IIf(contact_0.bool_18, contact_0.vmethod_9(), "")), typeof(float), 0));
						dictionary.Add("TargetContactSpeed", new IEventExporter.EventNotificationParameter(Conversions.ToString(Interaction.IIf(contact_0.bool_17, contact_0.vmethod_40(), "")), typeof(float), 0));
						dictionary.Add("TargetContactAltitude", new IEventExporter.EventNotificationParameter(Conversions.ToString(Interaction.IIf(contact_0.bool_19, contact_0.vmethod_14(false).ToString(), "")), typeof(float), 0));
						dictionary.Add("TargetContactRangeHoriz_nm", new IEventExporter.EventNotificationParameter(this.activeUnit_0.method_36(contact_0), typeof(float), 0));
						dictionary.Add("TargetContactRangeSlant_nm", new IEventExporter.EventNotificationParameter(this.activeUnit_0.method_37(contact_0, 0f), typeof(float), 0));
						if (contact_0.activeUnit_0 != null)
						{
							dictionary.Add("TargetContactActualUnitID", new IEventExporter.EventNotificationParameter(contact_0.activeUnit_0.string_0, typeof(string), 40));
							dictionary.Add("TargetContactActualUnitName", new IEventExporter.EventNotificationParameter(contact_0.activeUnit_0.Name, typeof(string), 500));
							dictionary.Add("TargetContactActualUnitClass", new IEventExporter.EventNotificationParameter(contact_0.activeUnit_0.string_2, typeof(string), 500));
							dictionary.Add("TargetContactActualUnitSide", new IEventExporter.EventNotificationParameter(contact_0.activeUnit_0.vmethod_7(false).method_51(), typeof(string), 500));
						}
						else
						{
							dictionary.Add("TargetContactActualUnitID", new IEventExporter.EventNotificationParameter("-", typeof(string), 40));
							dictionary.Add("TargetContactActualUnitName", new IEventExporter.EventNotificationParameter(contact_0.Name, typeof(string), 500));
							dictionary.Add("TargetContactActualUnitClass", new IEventExporter.EventNotificationParameter("-", typeof(string), 500));
							dictionary.Add("TargetContactActualUnitSide", new IEventExporter.EventNotificationParameter("-", typeof(string), 500));
						}
						eventExporter.imethod_6(IEventExporter.ExportedEventType.WeaponFired, dictionary, this.activeUnit_0.scenario_0);
					}
				}
				if (unit_0.bool_0)
				{
					((ActiveUnit)unit_0).vmethod_87().method_16(true);
					return;
				}
				((UnguidedWeapon)unit_0).method_84(this.activeUnit_0.scenario_0, true);
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000CF2A8 File Offset: 0x000CD4A8
		public static void smethod_2(Unit unit_0, bool bool_9, bool bool_10, ref string string_0)
		{
			if (!Information.IsNothing(unit_0) && unit_0.bool_3)
			{
				if (bool_9)
				{
					((Aircraft)unit_0).method_161().method_73(((ActiveUnit)unit_0).scenario_0.method_40(), bool_10, ref string_0, new Class568.Enum154?(Class568.Enum154.const_0), new bool?(false));
					return;
				}
				((Aircraft)unit_0).method_161().method_73(((ActiveUnit)unit_0).scenario_0.method_40(), bool_10, ref string_0, new Class568.Enum154?(Class568.Enum154.const_2), new bool?(false));
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000CF328 File Offset: 0x000CD528
		public static void smethod_3(Unit unit_0, bool bool_9, bool bool_10, ref string string_0)
		{
			if (!Information.IsNothing(unit_0) && unit_0.bool_3)
			{
				if (bool_9)
				{
					((Aircraft)unit_0).method_161().method_73(((ActiveUnit)unit_0).scenario_0.method_40(), bool_10, ref string_0, new Class568.Enum154?(Class568.Enum154.const_0), new bool?(true));
					return;
				}
				((Aircraft)unit_0).method_161().method_73(((ActiveUnit)unit_0).scenario_0.method_40(), bool_10, ref string_0, new Class568.Enum154?(Class568.Enum154.const_2), new bool?(true));
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000CF3A8 File Offset: 0x000CD5A8
		private void method_49(ref Mount mount_0, UnguidedWeapon unguidedWeapon_0, Sensor sensor_0, Contact contact_0, Class316 class316_0, StringBuilder stringBuilder_0)
		{
			try
			{
				bool flag = false;
				bool flag2 = false;
				if (this.activeUnit_0.scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_1))
				{
					if (!this.activeUnit_0.bool_3)
					{
						if (!Information.IsNothing(mount_0))
						{
							if (mount_0.bool_13 && mount_0.hashSet_1.Count == 0)
							{
								flag2 = true;
							}
							if (Information.IsNothing(sensor_0))
							{
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Not using any director (manual aiming). ");
								}
								flag = true;
								if (contact_0.vmethod_40() > 0f && contact_0.method_57() == 0f && !Information.IsNothing(contact_0.activeUnit_0) && unguidedWeapon_0.method_63() != Weapon._WeaponType.Laser)
								{
									double num = (double)contact_0.activeUnit_0.vmethod_87().vmethod_40(contact_0.vmethod_14(false), ActiveUnit.Throttle.Flank, false);
									if (num > 0.0)
									{
										double num2 = (double)contact_0.vmethod_40() / num;
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("Target is moving at ").Append((int)Math.Round(100.0 * num2)).Append("% of its maximum speed; accuracy adjusted to same. ");
										}
										unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * (1.0 + num2));
										unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * (1.0 + num2));
									}
								}
							}
							else if (unguidedWeapon_0.method_63() != Weapon._WeaponType.Laser)
							{
								Sensor.Sensor_Type sensor_Type_ = sensor_0.sensor_Type_0;
								if (sensor_Type_ != Sensor.Sensor_Type.Radar)
								{
									if (sensor_Type_ - Sensor.Sensor_Type.Visual > 1)
									{
										if (sensor_Type_ == Sensor.Sensor_Type.LaserDesignator)
										{
											unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.2);
											unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.2);
											unguidedWeapon_0.float_13 = (float)((double)((long)Math.Round((double)unguidedWeapon_0.float_13)) / 1.2);
											if (!Information.IsNothing(stringBuilder_0))
											{
												stringBuilder_0.Append("Director (").Append(sensor_0.Name).Append(") is laser; accuracy decreased by 20%. ");
											}
										}
									}
									else
									{
										unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 1.5);
										unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 1.5);
										unguidedWeapon_0.float_13 = (float)((double)unguidedWeapon_0.float_13 / 1.5);
										if (!Information.IsNothing(stringBuilder_0))
										{
											stringBuilder_0.Append("Director (").Append(sensor_0.Name).Append(") is visual/EO/IR; accuracy decreased by 50%. ");
										}
									}
								}
								else if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Director (").Append(sensor_0.Name).Append(") is radar; accuracy unaffected. ");
								}
							}
							if (!flag && !Information.IsNothing(class316_0))
							{
								foreach (Class316.Class273 @class in class316_0.class273_0)
								{
									if (Operators.CompareString(@class.string_0, this.activeUnit_0.string_0, false) == 0)
									{
										int int_ = @class.int_1;
										if (int_ >= 4)
										{
											if (int_ < 8)
											{
												unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 0.9);
												unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 0.9);
												unguidedWeapon_0.float_13 = (float)((double)unguidedWeapon_0.float_13 * 1.1);
												if (!Information.IsNothing(stringBuilder_0))
												{
													stringBuilder_0.Append("A few (less than 8) rounds already fired in salvo; accuracy improving slightly. ");
												}
											}
											else if (int_ < 12)
											{
												unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 0.8);
												unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 0.8);
												unguidedWeapon_0.float_13 = (float)((double)unguidedWeapon_0.float_13 * 1.25);
												if (!Information.IsNothing(stringBuilder_0))
												{
													stringBuilder_0.Append("Some (less than 12) rounds already fired in salvo; accuracy improving measurably. ");
												}
											}
											else if (int_ < 15)
											{
												unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 0.7);
												unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 0.7);
												unguidedWeapon_0.float_13 = (float)((double)unguidedWeapon_0.float_13 * 1.5);
												if (!Information.IsNothing(stringBuilder_0))
												{
													stringBuilder_0.Append("Quite a few (less than 15) rounds already fired in salvo; accuracy improving substantially. ");
												}
											}
											else
											{
												unguidedWeapon_0.float_9 = (float)((double)unguidedWeapon_0.float_9 * 0.2);
												unguidedWeapon_0.float_10 = (float)((double)unguidedWeapon_0.float_10 * 0.2);
												unguidedWeapon_0.float_13 *= 2f;
												if (!Information.IsNothing(stringBuilder_0))
												{
													stringBuilder_0.Append("Lots of rounds already fired in salvo; accuracy improving tremendously. ");
												}
											}
										}
									}
								}
							}
							if (flag && !flag2)
							{
								unguidedWeapon_0.float_9 *= 3f;
								unguidedWeapon_0.float_10 *= 3f;
								unguidedWeapon_0.float_13 /= 3f;
								unguidedWeapon_0.float_16 /= 3f;
								if (!Information.IsNothing(stringBuilder_0))
								{
									stringBuilder_0.Append("Aiming manually in system not primarily designed for local control; accuracy sharply reduced. ");
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100337", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000CF944 File Offset: 0x000CDB44
		private void method_50(ref Contact contact_0, Mount mount_0, ref Sensor sensor_0)
		{
			if (!Information.IsNothing(mount_0))
			{
				try
				{
					List<Sensor> list = this.method_27(mount_0, contact_0);
					if (list.Count > 0)
					{
						IEnumerable<Sensor> enumerable = Enumerable.Where<Sensor>(list, (ActiveUnit_Weaponry._Closure$__.$I94-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I94-0 = new Func<Sensor, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_13)) : ActiveUnit_Weaponry._Closure$__.$I94-0);
						if (Enumerable.Count<Sensor>(enumerable) > 0)
						{
							sensor_0 = Enumerable.ElementAtOrDefault<Sensor>(enumerable, 0);
							sensor_0.method_80(ref contact_0);
						}
						else
						{
							IEnumerable<Sensor> enumerable2 = Enumerable.Where<Sensor>(list, (ActiveUnit_Weaponry._Closure$__.$I94-1 == null) ? (ActiveUnit_Weaponry._Closure$__.$I94-1 = new Func<Sensor, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_14)) : ActiveUnit_Weaponry._Closure$__.$I94-1);
							if (Enumerable.Count<Sensor>(enumerable2) > 0)
							{
								sensor_0 = Enumerable.ElementAtOrDefault<Sensor>(enumerable2, 0);
								sensor_0.method_80(ref contact_0);
							}
							else
							{
								IEnumerable<Sensor> enumerable3 = Enumerable.Where<Sensor>(list, (ActiveUnit_Weaponry._Closure$__.$I94-2 == null) ? (ActiveUnit_Weaponry._Closure$__.$I94-2 = new Func<Sensor, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_15)) : ActiveUnit_Weaponry._Closure$__.$I94-2);
								if (Enumerable.Count<Sensor>(enumerable3) > 0)
								{
									sensor_0 = Enumerable.ElementAtOrDefault<Sensor>(enumerable3, 0);
									sensor_0.method_80(ref contact_0);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100338", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000CFA94 File Offset: 0x000CDC94
		private bool method_51(ref ActiveUnit activeUnit_1, ref Weapon weapon_6, ref Contact contact_0)
		{
			bool result;
			if (Information.IsNothing(contact_0))
			{
				result = false;
			}
			else
			{
				try
				{
					if (weapon_6.struct36_0.bool_0)
					{
						Unit.Enum123? @enum = null;
						bool? flag = null;
						bool? flag2 = null;
						bool? flag3 = null;
						foreach (Sensor sensor in activeUnit_1.vmethod_96())
						{
							if (sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor.method_79(ref weapon_6))
							{
								List<ActiveUnit> list;
								if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar && Information.IsNothing(list))
								{
									list = this.activeUnit_0.vmethod_88().method_10(false);
								}
								if (sensor.method_123(activeUnit_1, contact_0.activeUnit_0, activeUnit_1.method_37(contact_0, 0f), list, this.activeUnit_0.bool_6, false, ref flag, ref flag2, ref @enum, ref flag3) == Sensor.Enum115.const_1)
								{
									if (!sensor.method_82(ref contact_0))
									{
										if (!sensor.method_85())
										{
											goto IL_E1;
										}
										sensor.method_80(ref contact_0);
									}
									if (!sensor.list_1.Contains(weapon_6))
									{
										sensor.list_1.Add(weapon_6);
										weapon_6.method_171(sensor);
									}
									if (!sensor.method_43())
									{
										sensor.method_77();
									}
									return true;
								}
							}
							IL_E1:;
						}
					}
					result = false;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100339", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000CFC34 File Offset: 0x000CDE34
		private static bool smethod_4(ActiveUnit activeUnit_1, Weapon weapon_6, Contact contact_0)
		{
			ActiveUnit_Weaponry.Class236 @class = new ActiveUnit_Weaponry.Class236(@class);
			@class.activeUnit_0 = activeUnit_1;
			bool result;
			if (Information.IsNothing(contact_0))
			{
				result = false;
			}
			else
			{
				try
				{
					CommDevice[] array = weapon_6.vmethod_94();
					if (Enumerable.Count<CommDevice>(array) > 0)
					{
						if (weapon_6.struct36_0.bool_19 && weapon_6.method_199())
						{
							if (!Information.IsNothing(weapon_6.method_189().method_11(array, @class.activeUnit_0)) && @class.activeUnit_0.vmethod_88().method_1(contact_0, 5f, ActiveUnit_Sensory.Enum34.const_1))
							{
								weapon_6.method_180(@class.activeUnit_0);
								return true;
							}
							foreach (ActiveUnit activeUnit in Enumerable.ToArray<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, float>(@class.activeUnit_0.vmethod_7(false).activeUnit_0, new Func<ActiveUnit, float>(@class.method_0))))
							{
								if (activeUnit != @class.activeUnit_0 && !Information.IsNothing(weapon_6.method_189().method_11(array, activeUnit)) && activeUnit.vmethod_88().method_1(contact_0, 5f, ActiveUnit_Sensory.Enum34.const_1))
								{
									weapon_6.method_180(activeUnit);
									return true;
								}
							}
						}
						else if (!Information.IsNothing(weapon_6.method_189().method_11(array, @class.activeUnit_0)) && weapon_6.method_189().vmethod_3(null, @class.activeUnit_0, false))
						{
							weapon_6.method_180(@class.activeUnit_0);
							return true;
						}
					}
					result = false;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100340", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
			return result;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000CFDEC File Offset: 0x000CDFEC
		public string method_52(Scenario theScen, int WeaponID, ActiveUnit FiringUnit, double LaunchLongitude, double LaunchLatitude, float LaunchAltitude, int LaunchSpeed, Contact theTarget, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise, ref GeoPoint InterceptPoint = null, ref float FlightTime = 0f)
		{
			string result;
			try
			{
				Weapon weapon = Weapon.smethod_16(ref theScen, WeaponID, null);
				weapon.method_178(FiringUnit);
				weapon.bool_31 = true;
				Weapon.smethod_15(weapon, theScen, this.activeUnit_0.bool_3 || this.activeUnit_0.method_2());
				Weapon weapon2 = Weapon.smethod_16(ref theScen, theTarget.activeUnit_0.DBID, null);
				weapon2.vmethod_142().vmethod_4(theTarget.activeUnit_0.vmethod_86().vmethod_3());
				weapon2.vmethod_15(false, theTarget.activeUnit_0.vmethod_14(false));
				weapon2.vmethod_41(theTarget.activeUnit_0.vmethod_40());
				weapon2.vmethod_10(theTarget.activeUnit_0.vmethod_9());
				weapon2.vmethod_29(null, theTarget.vmethod_28(null));
				weapon2.vmethod_31(null, theTarget.vmethod_30(null));
				Weapon weapon3 = (Weapon)theTarget.activeUnit_0;
				weapon2.geoPoint_0 = new GeoPoint();
				weapon2.geoPoint_0.imethod_1(weapon3.geoPoint_0.imethod_0());
				weapon2.geoPoint_0.imethod_3(weapon3.geoPoint_0.imethod_2());
				weapon.vmethod_29(null, LaunchLongitude);
				weapon.vmethod_31(null, LaunchLatitude);
				weapon.vmethod_15(false, LaunchAltitude);
				weapon.vmethod_41((float)LaunchSpeed);
				weapon.vmethod_134(weapon.vmethod_82(), null);
				if (InitialHeading > 0f)
				{
					weapon.vmethod_10(InitialHeading);
				}
				else
				{
					weapon.vmethod_10(Math2.smethod_17(LaunchLatitude, LaunchLongitude, theTarget.vmethod_30(null), theTarget.vmethod_28(null)));
				}
				weapon.geoPoint_0 = new GeoPoint(weapon.vmethod_28(null), weapon.vmethod_30(null));
				float num = (float)((int)Math.Round((double)weapon.vmethod_67()[0].float_0));
				Contact contact = new Contact(weapon2, 0);
				contact.activeUnit_0 = null;
				contact.vmethod_15(false, weapon2.vmethod_14(false));
				contact.vmethod_41(weapon2.vmethod_40());
				contact.vmethod_10(weapon2.vmethod_9());
				contact.vmethod_29(null, weapon2.vmethod_28(null));
				contact.vmethod_31(null, weapon2.vmethod_30(null));
				contact.bool_18 = theTarget.bool_18;
				contact.bool_17 = theTarget.bool_17;
				contact.bool_19 = theTarget.bool_19;
				weapon.vmethod_142().vmethod_4(contact);
				weapon.method_180(this.activeUnit_0);
				if (weapon.method_205() || weapon.method_169() == Weapon.WeaponGuidanceType.Inertial)
				{
					weapon.method_187().method_64((float)weapon.vmethod_143().vmethod_40(weapon.vmethod_14(false), weapon.vmethod_82(), false), !Information.IsNothing(weapon.method_179()) && this.activeUnit_0.bool_3 && weapon.bool_7);
				}
				float num2 = 1f;
				float num3 = num - 1f;
				float num4 = num2;
				bool flag = num4 >= 0f;
				float num5 = 0f;
				bool flag3;
				while (flag ? (num5 <= num3) : (num5 >= num3))
				{
					weapon2.vmethod_142().vmethod_26(num2);
					weapon2.vmethod_134(weapon2.vmethod_82(), null);
					weapon2.vmethod_143().vmethod_46(num2, false, true, theScen.method_31().AddSeconds((double)num5));
					contact.vmethod_15(false, weapon2.vmethod_14(false));
					contact.vmethod_41(weapon2.vmethod_40());
					contact.vmethod_10(weapon2.vmethod_9());
					contact.vmethod_29(null, weapon2.vmethod_28(null));
					contact.vmethod_31(null, weapon2.vmethod_30(null));
					if (weapon.method_187().method_47())
					{
						weapon.method_187().method_4()[0].imethod_3(contact.vmethod_30(null));
						weapon.method_187().method_4()[0].imethod_1(contact.vmethod_28(null));
					}
					weapon.vmethod_142().vmethod_26(num2);
					weapon.vmethod_143().vmethod_46(num2, false, true, theScen.method_31().AddSeconds((double)num5));
					if (num5 != num)
					{
						bool flag2 = !this.activeUnit_0.scenario_0.FeatureCompatibility.get_WeaponSnapUpDown(this.activeUnit_0.scenario_0.method_39()) || weapon.float_47 <= 0f || (float)((int)Math.Round((double)Math.Abs(contact.vmethod_14(false) - this.activeUnit_0.vmethod_14(false)))) <= weapon.float_47;
						if (weapon.method_259(num2) && flag2)
						{
							double double_ = contact.vmethod_28(null);
							double double_2 = contact.vmethod_30(null);
							Contact contact2;
							Unit unit = contact2 = contact;
							bool? hintIsOperating = null;
							double value = unit.vmethod_28(hintIsOperating);
							Contact contact3;
							Unit unit2 = contact3 = contact;
							bool? hintIsOperating2 = null;
							double value2 = unit2.vmethod_30(hintIsOperating2);
							Class411.smethod_1(double_, double_2, ref value, ref value2, (double)(contact.vmethod_40() * num2 / 3600f), (double)contact.vmethod_9());
							contact3.vmethod_31(hintIsOperating2, value2);
							contact2.vmethod_29(hintIsOperating, value);
							weapon.vmethod_31(null, contact.vmethod_30(null));
							weapon.vmethod_29(null, contact.vmethod_28(null));
							weapon.vmethod_15(false, contact.vmethod_14(false));
							flag3 = true;
							FlightTime = num5;
							InterceptPoint = new GeoPoint(weapon.vmethod_28(null), weapon.vmethod_30(null));
							break;
						}
					}
					num5 += num4;
				}
				if (flag3)
				{
					result = "OK";
				}
				else
				{
					result = "Target is out of the weapon's DLZ";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100341", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000D049C File Offset: 0x000CE69C
		public string method_53(Scenario theScen, int WeaponID, ActiveUnit theFiringUnit, double LaunchLongitude, double LaunchLatitude, float LaunchAltitude, int LaunchSpeed, Contact theTarget, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise, ref float FlightTime = 0f)
		{
			try
			{
				Weapon weapon = Weapon.smethod_16(ref theScen, WeaponID, null);
				weapon.method_178(theFiringUnit);
				Weapon.smethod_15(weapon, theScen, this.activeUnit_0.bool_3 || this.activeUnit_0.method_2());
				Satellite satellite = new Satellite(ref theScen, null);
				int spacecraftNumber = Conversions.ToInteger(((Satellite)theTarget.activeUnit_0).string_9.Split(Conversions.ToCharArrayRankOne("_"))[1]);
				DBFunctions.smethod_74(ref theScen, ref satellite, theTarget.activeUnit_0.DBID, spacecraftNumber, true);
				satellite.vmethod_15(false, theTarget.activeUnit_0.vmethod_14(false));
				satellite.vmethod_41(theTarget.activeUnit_0.vmethod_40());
				satellite.vmethod_10(theTarget.activeUnit_0.vmethod_9());
				satellite.vmethod_29(null, theTarget.vmethod_28(null));
				satellite.vmethod_31(null, theTarget.vmethod_30(null));
				weapon.vmethod_29(null, LaunchLongitude);
				weapon.vmethod_31(null, LaunchLatitude);
				weapon.vmethod_15(false, LaunchAltitude);
				weapon.vmethod_41((float)LaunchSpeed);
				weapon.vmethod_134(weapon.vmethod_82(), null);
				if (InitialHeading > 0f)
				{
					weapon.vmethod_10(InitialHeading);
				}
				else
				{
					weapon.vmethod_10(Math2.smethod_17(LaunchLatitude, LaunchLongitude, theTarget.vmethod_30(null), theTarget.vmethod_28(null)));
				}
				Waypoint waypoint = new Waypoint();
				waypoint.imethod_1(weapon.vmethod_28(null));
				waypoint.imethod_3(weapon.vmethod_30(null));
				float num = (float)((int)Math.Round((double)weapon.vmethod_67()[0].float_0));
				Contact contact = new Contact(satellite, 0);
				contact.activeUnit_0 = null;
				contact.vmethod_15(false, satellite.vmethod_14(false));
				contact.vmethod_41(satellite.vmethod_40());
				contact.vmethod_10(satellite.vmethod_9());
				contact.vmethod_29(null, satellite.vmethod_28(null));
				contact.vmethod_31(null, satellite.vmethod_30(null));
				contact.bool_18 = theTarget.bool_18;
				contact.bool_17 = theTarget.bool_17;
				contact.bool_19 = theTarget.bool_19;
				weapon.vmethod_142().vmethod_4(contact);
				if (weapon.method_205() || weapon.method_169() == Weapon.WeaponGuidanceType.Inertial)
				{
					weapon.method_187().vmethod_24(contact.vmethod_30(null), contact.vmethod_28(null), 0f, Waypoint.WaypointType.TerminalPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
				}
				float num2 = num - 1f;
				float num3 = 0f;
				while (num3 <= num2)
				{
					satellite.vmethod_86().vmethod_26(1f);
					satellite.vmethod_134(satellite.vmethod_82(), null);
					satellite.method_142().vmethod_46(1f, false, true, theScen.method_31().AddSeconds((double)num3));
					contact.vmethod_15(false, satellite.vmethod_14(false));
					contact.vmethod_41(satellite.vmethod_40());
					contact.vmethod_10(satellite.vmethod_9());
					contact.vmethod_29(null, satellite.vmethod_28(null));
					contact.vmethod_31(null, satellite.vmethod_30(null));
					if (weapon.method_187().method_47())
					{
						weapon.method_187().method_4()[0].imethod_3(contact.vmethod_30(null));
						weapon.method_187().method_4()[0].imethod_1(contact.vmethod_28(null));
					}
					weapon.vmethod_142().vmethod_26(1f);
					weapon.vmethod_134(weapon.vmethod_82(), null);
					weapon.vmethod_143().vmethod_46(1f, false, true, theScen.method_31().AddSeconds((double)num3));
					if (num3 == num || !weapon.method_259(1f))
					{
						num3 += 1f;
					}
					else
					{
						double double_ = contact.vmethod_28(null);
						double double_2 = contact.vmethod_30(null);
						Contact contact2;
						Unit unit = contact2 = contact;
						bool? hintIsOperating = null;
						double value = unit.vmethod_28(hintIsOperating);
						Contact contact3;
						Unit unit2 = contact3 = contact;
						bool? hintIsOperating2 = null;
						double value2 = unit2.vmethod_30(hintIsOperating2);
						Class411.smethod_1(double_, double_2, ref value, ref value2, (double)(contact.vmethod_40() * 1f / 3600f), (double)contact.vmethod_9());
						contact3.vmethod_31(hintIsOperating2, value2);
						contact2.vmethod_29(hintIsOperating, value);
						weapon.vmethod_31(null, contact.vmethod_30(null));
						weapon.vmethod_29(null, contact.vmethod_28(null));
						weapon.vmethod_15(false, contact.vmethod_14(false));
						bool flag = true;
						FlightTime = num3;
						IL_53C:
						if (flag)
						{
							return "OK";
						}
						return "Target is out of the weapon's DLZ";
					}
				}
				goto IL_53C;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100342", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			string result;
			return result;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000D0A50 File Offset: 0x000CEC50
		public static string smethod_5(Scenario theScen, int WeaponID, ActiveUnit FiringUnit, double LaunchLongitude, double LaunchLatitude, float LaunchAltitude, int LaunchSpeed, double TargetLongitude, double TargetLatitude, float TargetHeading, bool TargetHeadingKnown, int TargetSpeed, bool TargetSpeedKnown, float TargetAltitude, bool TargetAltitudeKnown, Contact_Base.ContactType TargetType, ref GeoPoint InterceptPoint, ref string FeedbackText, float InitialHeading = 0f, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise, int CustomWeaponFuel = 0, List<float> XDAT = null, List<float> YDAT = null, ref float FlightTime = 0f)
		{
			InterceptPoint = null;
			string result;
			try
			{
				Weapon weapon = Weapon.smethod_16(ref theScen, WeaponID, null);
				weapon.bool_31 = true;
				if (weapon.vmethod_67().Length == 0)
				{
					weapon.method_105(new FuelRec(0, 0));
				}
				weapon.method_178(FiringUnit);
				Weapon.smethod_15(weapon, theScen, FiringUnit.bool_3 || FiringUnit.method_2());
				if (weapon.struct36_0.bool_12)
				{
					weapon.struct36_0.bool_12 = false;
				}
				ActiveUnit activeUnit;
				switch (TargetType)
				{
				case Contact_Base.ContactType.Air:
				case Contact_Base.ContactType.Decoy_Air:
					activeUnit = new Aircraft(ref theScen, null);
					goto IL_14D;
				case Contact_Base.ContactType.Missile:
					activeUnit = new Weapon(ref theScen);
					((Weapon)activeUnit).method_168(Weapon._WeaponType.GuidedWeapon);
					goto IL_14D;
				case Contact_Base.ContactType.Surface:
				case Contact_Base.ContactType.Aimpoint:
				case Contact_Base.ContactType.Decoy_Surface:
				case Contact_Base.ContactType.ActivationPoint:
					activeUnit = new Ship(ref theScen, null);
					goto IL_14D;
				case Contact_Base.ContactType.Submarine:
				case Contact_Base.ContactType.Decoy_Sub:
					activeUnit = new Submarine(ref theScen, null);
					goto IL_14D;
				case Contact_Base.ContactType.Orbital:
					activeUnit = new Satellite(ref theScen, null);
					goto IL_14D;
				case Contact_Base.ContactType.Facility_Fixed:
				case Contact_Base.ContactType.Facility_Mobile:
				case Contact_Base.ContactType.Decoy_Land:
				case Contact_Base.ContactType.Installation:
				case Contact_Base.ContactType.AirBase:
				case Contact_Base.ContactType.NavalBase:
					activeUnit = new Facility(ref theScen, null);
					goto IL_14D;
				case Contact_Base.ContactType.Torpedo:
					activeUnit = new Weapon(ref theScen);
					((Weapon)activeUnit).method_168(Weapon._WeaponType.Torpedo);
					goto IL_14D;
				}
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				activeUnit = new Facility(ref theScen, null);
				IL_14D:
				activeUnit.vmethod_29(null, TargetLongitude);
				activeUnit.vmethod_31(null, TargetLatitude);
				activeUnit.vmethod_10(TargetHeading);
				activeUnit.vmethod_41((float)TargetSpeed);
				activeUnit.vmethod_15(false, TargetAltitude);
				weapon.vmethod_29(null, LaunchLongitude);
				weapon.vmethod_31(null, LaunchLatitude);
				weapon.vmethod_15(false, LaunchAltitude);
				weapon.vmethod_41((float)LaunchSpeed);
				if (ThrottleSetting <= weapon.vmethod_82())
				{
					weapon.vmethod_134(ThrottleSetting, null);
				}
				else
				{
					weapon.vmethod_134(weapon.vmethod_82(), null);
				}
				if (InitialHeading > 0f)
				{
					weapon.vmethod_10(InitialHeading);
				}
				else
				{
					weapon.vmethod_10(Math2.smethod_17(LaunchLatitude, LaunchLongitude, TargetLatitude, TargetLongitude));
				}
				if (CustomWeaponFuel > 0)
				{
					weapon.vmethod_67()[0].float_0 = (float)CustomWeaponFuel;
				}
				weapon.geoPoint_0 = new GeoPoint(weapon.vmethod_28(null), weapon.vmethod_30(null));
				Contact contact = new Contact(activeUnit, 0);
				contact.vmethod_15(false, TargetAltitude);
				if (weapon.bool_7)
				{
					contact.bool_19 = true;
				}
				else
				{
					contact.bool_19 = TargetAltitudeKnown;
				}
				contact.vmethod_41((float)TargetSpeed);
				contact.bool_17 = TargetSpeedKnown;
				contact.vmethod_10(TargetHeading);
				contact.bool_18 = TargetHeadingKnown;
				contact.vmethod_29(null, TargetLongitude);
				contact.vmethod_31(null, TargetLatitude);
				weapon.vmethod_142().vmethod_4(contact);
				weapon.vmethod_143().method_18(FiringUnit, contact);
				if ((!weapon.method_205() && weapon.method_169() != Weapon.WeaponGuidanceType.Inertial) || weapon.method_187().method_64((float)weapon.vmethod_143().vmethod_40(contact.vmethod_14(false), ThrottleSetting, false), false))
				{
					float num = weapon.vmethod_98(weapon.vmethod_84(), null, null, null, false, false, false, false, false);
					if (num <= 0f)
					{
						num = 1f;
					}
					float num2 = weapon.vmethod_67()[0].float_0 / num - 1f;
					float num3 = num2 * 2f;
					float num4 = 0f;
					while (num4 <= num3)
					{
						bool flag;
						if (num4 <= num2 || (weapon.vmethod_6() && weapon.vmethod_18() < weapon.method_140()))
						{
							Contact contact2;
							bool? hintIsOperating;
							double value;
							Contact contact3;
							bool? hintIsOperating2;
							double value2;
							if (contact.vmethod_40() != 0f)
							{
								double double_ = contact.vmethod_28(null);
								double double_2 = contact.vmethod_30(null);
								Unit unit = contact2 = contact;
								hintIsOperating = null;
								value = unit.vmethod_28(hintIsOperating);
								Unit unit2 = contact3 = contact;
								hintIsOperating2 = null;
								value2 = unit2.vmethod_30(hintIsOperating2);
								Class411.smethod_1(double_, double_2, ref value, ref value2, (double)(contact.vmethod_40() * 1f / 3600f), (double)contact.vmethod_9());
								contact3.vmethod_31(hintIsOperating2, value2);
								contact2.vmethod_29(hintIsOperating, value);
								activeUnit.vmethod_29(null, contact.vmethod_28(null));
								activeUnit.vmethod_31(null, contact.vmethod_30(null));
							}
							weapon.vmethod_142().vmethod_26(1f);
							if (ThrottleSetting <= weapon.vmethod_82())
							{
								weapon.vmethod_134(ThrottleSetting, null);
							}
							else
							{
								weapon.vmethod_134(weapon.vmethod_82(), null);
							}
							weapon.vmethod_143().vmethod_46(1f, false, true, theScen.method_31().AddSeconds((double)num4));
							if (!Information.IsNothing(XDAT))
							{
								XDAT.Add(Math2.smethod_15(weapon.geoPoint_0.imethod_2(), weapon.geoPoint_0.imethod_0(), weapon.vmethod_30(null), weapon.vmethod_28(null)));
							}
							if (!Information.IsNothing(YDAT))
							{
								YDAT.Add(weapon.vmethod_14(false));
							}
							if (num4 == num2 || !weapon.method_259(1f) || weapon.method_36(contact) >= 1f)
							{
								num4 += 1f;
								continue;
							}
							double double_3 = contact.vmethod_28(null);
							double double_4 = contact.vmethod_30(null);
							Unit unit3 = contact3 = contact;
							hintIsOperating2 = null;
							value2 = unit3.vmethod_28(hintIsOperating2);
							Unit unit4 = contact2 = contact;
							hintIsOperating = null;
							value = unit4.vmethod_30(hintIsOperating);
							Class411.smethod_1(double_3, double_4, ref value2, ref value, (double)(contact.vmethod_40() * 1f / 3600f), (double)contact.vmethod_9());
							contact2.vmethod_31(hintIsOperating, value);
							contact3.vmethod_29(hintIsOperating2, value2);
							weapon.vmethod_31(null, contact.vmethod_30(null));
							weapon.vmethod_29(null, contact.vmethod_28(null));
							weapon.vmethod_15(false, contact.vmethod_14(false));
							InterceptPoint = new GeoPoint(weapon.vmethod_28(null), weapon.vmethod_30(null), weapon.vmethod_14(false));
							flag = true;
							FlightTime = num4;
						}
						IL_68B:
						if (flag)
						{
							if (flag)
							{
								FeedbackText = string.Concat(new string[]
								{
									"SUCCESS! Weapon reached target after ",
									Conversions.ToString(num4),
									" seconds. Distance from launch point is ",
									Conversions.ToString(Math.Round((double)Math2.smethod_15(weapon.geoPoint_0.imethod_2(), weapon.geoPoint_0.imethod_0(), weapon.vmethod_30(null), weapon.vmethod_28(null)), 2)),
									"nm."
								});
							}
						}
						else
						{
							FeedbackText = string.Concat(new string[]
							{
								"FAILURE! Weapon fell short of the target after ",
								Conversions.ToString(num4),
								" seconds, covering ",
								Conversions.ToString(Math.Round((double)Math2.smethod_15(weapon.geoPoint_0.imethod_2(), weapon.geoPoint_0.imethod_0(), weapon.vmethod_30(null), weapon.vmethod_28(null)), 2)),
								"nm. Remaining distance to target is ",
								Conversions.ToString(Math.Round((double)Math2.smethod_15(contact.vmethod_30(null), contact.vmethod_28(null), weapon.vmethod_30(null), weapon.vmethod_28(null)), 2)),
								"nm."
							});
						}
						if (flag)
						{
							return "OK";
						}
						return "Target is out of the weapon's DLZ.";
					}
					goto IL_68B;
				}
				result = "Unable to calculate intercept course";
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100343", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Error";
			}
			return result;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000D12C0 File Offset: 0x000CF4C0
		public Weapon method_54()
		{
			checked
			{
				Weapon result;
				try
				{
					if (Information.IsNothing(this.weapon_0) && !this.bool_3)
					{
						float float_;
						try
						{
							foreach (Mount mount in this.activeUnit_0.vmethod_51())
							{
								if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational && mount.method_32().method_24() <= 0f)
								{
									try
									{
										foreach (WeaponRec weaponRec in mount.vmethod_10())
										{
											WeaponRec weaponRec2;
											Weapon weapon = (weaponRec2 = weaponRec).method_12(this.activeUnit_0.scenario_0);
											if (!weapon.method_176())
											{
												if (weapon.method_191())
												{
													Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
													byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
													bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
													if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
													{
														continue;
													}
												}
												if (weapon.float_29 > float_ && weaponRec2.method_9() > 0 && (weapon.class394_0.bool_2 || weapon.class394_0.bool_3))
												{
													this.weapon_0 = weapon;
													float_ = weapon.float_29;
												}
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
						{
							WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
							for (int i = 0; i < weaponRec_.Length; i++)
							{
								WeaponRec weaponRec3;
								Weapon weapon2 = (weaponRec3 = weaponRec_[i]).method_12(this.activeUnit_0.scenario_0);
								if (!weapon2.method_176())
								{
									if (weapon2.method_191())
									{
										Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
										byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
										bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
										if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
										{
											goto IL_307;
										}
									}
									if (weapon2.float_29 > float_ && weaponRec3.method_9() > 0 && (weapon2.class394_0.bool_2 || weapon2.class394_0.bool_3 || weapon2.class394_0.bool_4))
									{
										this.weapon_0 = weapon2;
										float_ = weapon2.float_29;
									}
								}
								IL_307:;
							}
						}
						this.bool_3 = true;
					}
					result = this.weapon_0;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200296", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x000D1680 File Offset: 0x000CF880
		public Weapon method_55(bool bool_9)
		{
			checked
			{
				Weapon result;
				try
				{
					if ((Information.IsNothing(this.weapon_1) && !bool_9 && !this.bool_4) || (Information.IsNothing(this.weapon_2) && bool_9 && !this.bool_5))
					{
						float num2;
						try
						{
							foreach (Mount mount in this.activeUnit_0.vmethod_51())
							{
								if (mount.method_32().method_24() <= 0f && mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
								{
									try
									{
										foreach (WeaponRec weaponRec in mount.vmethod_10())
										{
											Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
											if (weapon.method_191())
											{
												Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
												byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
												bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
												if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
												{
													continue;
												}
											}
											if (!weapon.method_176() && (!bool_9 || weapon.float_31 <= 5400f))
											{
												float num;
												if (this.activeUnit_0.bool_3 && weapon.method_156())
												{
													num = weapon.method_158(this.activeUnit_0.vmethod_14(false), Contact_Base.ContactType.Surface);
												}
												else
												{
													num = weapon.float_31;
												}
												if (num > num2 && weaponRec.method_9() > 0 && (weapon.class394_0.bool_0 || weapon.class394_0.bool_5))
												{
													if (bool_9)
													{
														this.weapon_2 = weapon;
													}
													else
													{
														this.weapon_1 = weapon;
													}
													num2 = num;
												}
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
						{
							WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
							int i = 0;
							while (i < weaponRec_.Length)
							{
								WeaponRec weaponRec = weaponRec_[i];
								Weapon weapon2 = weaponRec.method_12(this.activeUnit_0.scenario_0);
								if (!weapon2.method_191())
								{
									goto IL_314;
								}
								Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
								byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
								bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
								if (!((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
								{
									goto IL_314;
								}
								IL_3AA:
								i++;
								continue;
								IL_314:
								if (weapon2.method_176() || (bool_9 && weapon2.float_31 > 5400f))
								{
									goto IL_3AA;
								}
								float num3;
								if (this.activeUnit_0.bool_3 && weapon2.method_156())
								{
									num3 = weapon2.method_158(this.activeUnit_0.vmethod_14(false), Contact_Base.ContactType.Surface);
								}
								else
								{
									num3 = weapon2.float_31;
								}
								if (num3 > num2 && weaponRec.method_9() > 0 && (weapon2.class394_0.bool_0 || weapon2.class394_0.bool_5))
								{
									if (bool_9)
									{
										this.weapon_2 = weapon2;
									}
									else
									{
										this.weapon_1 = weapon2;
									}
									num2 = num3;
									goto IL_3AA;
								}
								goto IL_3AA;
							}
						}
						if (bool_9)
						{
							this.bool_5 = true;
						}
						else
						{
							this.bool_4 = true;
						}
					}
					if (bool_9)
					{
						result = this.weapon_2;
					}
					else
					{
						result = this.weapon_1;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200297", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x000D1AFC File Offset: 0x000CFCFC
		public Weapon method_56(bool bool_9)
		{
			checked
			{
				Weapon result;
				try
				{
					if ((Information.IsNothing(this.weapon_3) && !bool_9 && !this.bool_6) || (Information.IsNothing(this.weapon_4) && bool_9 && !this.bool_7))
					{
						float num2;
						try
						{
							foreach (Mount mount in this.activeUnit_0.vmethod_51())
							{
								if (mount.method_32().method_24() <= 0f && mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
								{
									try
									{
										foreach (WeaponRec weaponRec in mount.vmethod_10())
										{
											Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
											if (weapon.method_191())
											{
												Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
												byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
												bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
												if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
												{
													continue;
												}
											}
											if (!weapon.method_176() && (!bool_9 || weapon.float_33 <= 5400f))
											{
												float num;
												if (this.activeUnit_0.bool_3 && weapon.method_156())
												{
													num = weapon.method_158(this.activeUnit_0.vmethod_14(false), Contact_Base.ContactType.Facility_Fixed);
												}
												else
												{
													num = weapon.float_33;
												}
												if (num > num2 && weaponRec.method_9() > 0 && (weapon.class394_0.bool_8 || weapon.class394_0.bool_13 || weapon.class394_0.bool_7 || weapon.class394_0.bool_5 || weapon.class394_0.bool_6 || weapon.class394_0.bool_12))
												{
													if (bool_9)
													{
														this.weapon_4 = weapon;
													}
													else
													{
														this.weapon_3 = weapon;
													}
													num2 = num;
												}
											}
										}
									}
									finally
									{
										List<WeaponRec>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
								}
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
						{
							WeaponRec[] weaponRec_ = ((Aircraft)this.activeUnit_0).method_167().weaponRec_0;
							int i = 0;
							while (i < weaponRec_.Length)
							{
								WeaponRec weaponRec = weaponRec_[i];
								Weapon weapon2 = weaponRec.method_12(this.activeUnit_0.scenario_0);
								if (!weapon2.method_191())
								{
									goto IL_34F;
								}
								Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
								byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
								bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
								if (!((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
								{
									goto IL_34F;
								}
								IL_420:
								i++;
								continue;
								IL_34F:
								if (weapon2.method_176() || (bool_9 && weapon2.float_33 > 5400f))
								{
									goto IL_420;
								}
								float num3;
								if (this.activeUnit_0.bool_3 && weapon2.method_156())
								{
									num3 = weapon2.method_158(this.activeUnit_0.vmethod_14(false), Contact_Base.ContactType.Facility_Fixed);
								}
								else
								{
									num3 = weapon2.float_33;
								}
								if (num3 > num2 && weaponRec.method_9() > 0 && (weapon2.class394_0.bool_8 || weapon2.class394_0.bool_13 || weapon2.class394_0.bool_7 || weapon2.class394_0.bool_5 || weapon2.class394_0.bool_6 || weapon2.class394_0.bool_12))
								{
									if (bool_9)
									{
										this.weapon_4 = weapon2;
									}
									else
									{
										this.weapon_3 = weapon2;
									}
									num2 = num3;
									goto IL_420;
								}
								goto IL_420;
							}
						}
						if (bool_9)
						{
							this.bool_7 = true;
						}
						else
						{
							this.bool_6 = true;
						}
					}
					if (bool_9)
					{
						result = this.weapon_4;
					}
					else
					{
						result = this.weapon_3;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200298", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				return result;
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x000D1FEC File Offset: 0x000D01EC
		public Weapon method_57()
		{
			Weapon result;
			try
			{
				if (Information.IsNothing(this.weapon_5) && !this.bool_8)
				{
					float float_;
					try
					{
						foreach (Mount mount in this.activeUnit_0.vmethod_51())
						{
							if (mount.method_32().method_24() <= 0f && mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
							{
								try
								{
									foreach (WeaponRec weaponRec in mount.vmethod_10())
									{
										Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
										if (!weapon.method_176())
										{
											if (weapon.method_191())
											{
												Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
												byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
												bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
												if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
												{
													continue;
												}
											}
											if (weapon.float_35 > float_ && weaponRec.method_9() > 0 && (weapon.class394_0.bool_10 || weapon.class394_0.bool_1 || weapon.class394_0.bool_9))
											{
												this.weapon_5 = weapon;
												float_ = weapon.float_35;
											}
										}
									}
								}
								finally
								{
									List<WeaponRec>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
							}
						}
					}
					finally
					{
						List<Mount>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (this.activeUnit_0.bool_3 && !Information.IsNothing(((Aircraft)this.activeUnit_0).method_167()))
					{
						foreach (WeaponRec weaponRec in ((Aircraft)this.activeUnit_0).method_167().weaponRec_0)
						{
							Weapon weapon2 = weaponRec.method_12(this.activeUnit_0.scenario_0);
							if (!weapon2.method_176())
							{
								if (weapon2.method_191())
								{
									Doctrine.Enum65? @enum = this.activeUnit_0.doctrine_0.method_31(this.activeUnit_0.scenario_0, false, false, false);
									byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
									bool? flag = (b != null) ? new bool?(b.GetValueOrDefault() == 1) : null;
									if (((flag != null) ? new bool?(!flag.GetValueOrDefault()) : flag).GetValueOrDefault())
									{
										goto IL_30B;
									}
								}
								if (weapon2.float_35 > float_ && weaponRec.method_9() > 0 && (weapon2.class394_0.bool_10 || weapon2.class394_0.bool_1 || weapon2.class394_0.bool_9))
								{
									this.weapon_5 = weapon2;
									float_ = weapon2.float_35;
								}
							}
							IL_30B:;
						}
					}
					this.bool_8 = true;
				}
				result = this.weapon_5;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200299", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x000D23B0 File Offset: 0x000D05B0
		public virtual Weapon vmethod_13()
		{
			List<WeaponRec> list = this.method_0(false);
			List<Weapon> list2 = new List<Weapon>();
			try
			{
				foreach (WeaponRec weaponRec in list)
				{
					if (weaponRec.int_0 != 0)
					{
						Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
						if (weapon.method_195() || weapon.method_196())
						{
							list2.Add(weapon);
						}
					}
				}
			}
			finally
			{
				List<WeaponRec>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Weapon result;
			if (list2.Count > 0)
			{
				if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Mining)
				{
					IEnumerable<Weapon> enumerable = Enumerable.Where<Weapon>(list2, (ActiveUnit_Weaponry._Closure$__.$I118-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I118-0 = new Func<Weapon, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_16)) : ActiveUnit_Weaponry._Closure$__.$I118-0);
					if (Enumerable.Count<Weapon>(enumerable) > 0)
					{
						result = Enumerable.ElementAtOrDefault<Weapon>(enumerable, 0);
					}
					else
					{
						result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list2, (ActiveUnit_Weaponry._Closure$__.$I118-1 == null) ? (ActiveUnit_Weaponry._Closure$__.$I118-1 = new Func<Weapon, float>(ActiveUnit_Weaponry._Closure$__.$I.method_17)) : ActiveUnit_Weaponry._Closure$__.$I118-1), 0);
					}
				}
				else
				{
					result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list2, (ActiveUnit_Weaponry._Closure$__.$I118-2 == null) ? (ActiveUnit_Weaponry._Closure$__.$I118-2 = new Func<Weapon, float>(ActiveUnit_Weaponry._Closure$__.$I.method_18)) : ActiveUnit_Weaponry._Closure$__.$I118-2), 0);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000D2518 File Offset: 0x000D0718
		public virtual Weapon vmethod_14()
		{
			List<Weapon> list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(this.vmethod_4(), (ActiveUnit_Weaponry._Closure$__.$I122-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I122-0 = new Func<Weapon, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_19)) : ActiveUnit_Weaponry._Closure$__.$I122-0));
			Weapon result;
			if (list.Count > 0)
			{
				result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (ActiveUnit_Weaponry._Closure$__.$I122-1 == null) ? (ActiveUnit_Weaponry._Closure$__.$I122-1 = new Func<Weapon, float>(ActiveUnit_Weaponry._Closure$__.$I.method_20)) : ActiveUnit_Weaponry._Closure$__.$I122-1), 0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000D259C File Offset: 0x000D079C
		public virtual Weapon vmethod_15()
		{
			List<Weapon> list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(this.vmethod_4(), (ActiveUnit_Weaponry._Closure$__.$I124-0 == null) ? (ActiveUnit_Weaponry._Closure$__.$I124-0 = new Func<Weapon, bool>(ActiveUnit_Weaponry._Closure$__.$I.method_21)) : ActiveUnit_Weaponry._Closure$__.$I124-0));
			Weapon result;
			if (list.Count > 0)
			{
				result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (ActiveUnit_Weaponry._Closure$__.$I124-1 == null) ? (ActiveUnit_Weaponry._Closure$__.$I124-1 = new Func<Weapon, float>(ActiveUnit_Weaponry._Closure$__.$I.method_22)) : ActiveUnit_Weaponry._Closure$__.$I124-1), 0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000D2620 File Offset: 0x000D0820
		public List<Weapon> method_58()
		{
			List<Weapon> list = new List<Weapon>();
			checked
			{
				List<Weapon> result;
				if (this.activeUnit_0.scenario_0.method_17().Count == 0)
				{
					result = list;
				}
				else
				{
					try
					{
						foreach (Weapon weapon in this.activeUnit_0.scenario_0.method_17())
						{
							if (!Information.IsNothing(weapon.method_179()) && weapon.method_179() == this.activeUnit_0)
							{
								list.Add(weapon);
							}
							else
							{
								Sensor[] array = this.activeUnit_0.method_78();
								for (int i = 0; i < array.Length; i++)
								{
									if (array[i].list_1.Contains(weapon))
									{
										list.Add(weapon);
									}
								}
							}
						}
					}
					finally
					{
						List<Weapon>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = list;
				}
				return result;
			}
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000D26FC File Offset: 0x000D08FC
		public bool method_59()
		{
			checked
			{
				bool result;
				if (this.activeUnit_0.scenario_0.method_17().Count == 0)
				{
					result = false;
				}
				else
				{
					try
					{
						foreach (Weapon weapon in this.activeUnit_0.scenario_0.method_17())
						{
							if (!Information.IsNothing(weapon.method_179()) && weapon.method_179() == this.activeUnit_0)
							{
								return true;
							}
							Sensor[] array = this.activeUnit_0.method_78();
							for (int i = 0; i < array.Length; i++)
							{
								if (array[i].list_1.Contains(weapon))
								{
									return true;
								}
							}
						}
					}
					finally
					{
						List<Weapon>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x000D27C8 File Offset: 0x000D09C8
		public bool method_60(Contact contact_0)
		{
			bool result;
			try
			{
				if (this.activeUnit_0.scenario_0.method_17().Count == 0)
				{
					result = false;
				}
				else if (this.activeUnit_0.vmethod_88().method_40(contact_0))
				{
					result = true;
				}
				else if (Information.IsNothing(contact_0.activeUnit_0))
				{
					result = false;
				}
				else
				{
					try
					{
						foreach (Weapon weapon in this.activeUnit_0.scenario_0.method_17())
						{
							if (!Information.IsNothing(weapon.vmethod_142().vmethod_3()) && Operators.CompareString(weapon.vmethod_142().vmethod_3().string_6, contact_0.string_6, false) == 0)
							{
								if (this.activeUnit_0.vmethod_88().method_40(contact_0))
								{
									return true;
								}
								if (!Information.IsNothing(weapon.method_179()) && weapon.method_179() == this.activeUnit_0)
								{
									return true;
								}
							}
						}
					}
					finally
					{
						List<Weapon>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100347", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x000081B6 File Offset: 0x000063B6
		[CompilerGenerated]
		private bool method_61(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_155();
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x000081CE File Offset: 0x000063CE
		[CompilerGenerated]
		private float method_62(ActiveUnit_Weaponry.FireQueueEntry fireQueueEntry_0)
		{
			return fireQueueEntry_0.weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_267();
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000081EB File Offset: 0x000063EB
		[CompilerGenerated]
		private bool method_63(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_207();
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x000D291C File Offset: 0x000D0B1C
		[CompilerGenerated]
		private int method_64(WeaponRec weaponRec_0)
		{
			Weapon weapon = weaponRec_0.method_12(this.activeUnit_0.scenario_0);
			ActiveUnit_AI activeUnit_AI;
			Contact contact_ = (activeUnit_AI = this.activeUnit_0.vmethod_86()).vmethod_3();
			int result = this.method_14(ref weapon, ref contact_, true);
			activeUnit_AI.vmethod_4(contact_);
			return result;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00008203 File Offset: 0x00006403
		[CompilerGenerated]
		private float method_65(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).float_29;
		}

		// Token: 0x04000715 RID: 1813
		protected ActiveUnit activeUnit_0;

		// Token: 0x04000716 RID: 1814
		[CompilerGenerated]
		[AccessedThroughProperty("WeaponAssignments")]
		private List<Class357> list_0;

		// Token: 0x04000717 RID: 1815
		protected ConcurrentDictionary<Tuple<int, string>, string> concurrentDictionary_0;

		// Token: 0x04000718 RID: 1816
		internal HashSet<string> hashSet_0;

		// Token: 0x04000719 RID: 1817
		[CompilerGenerated]
		private static ActiveUnit_Weaponry.Delegate22 delegate22_0;

		// Token: 0x0400071A RID: 1818
		private bool bool_0;

		// Token: 0x0400071B RID: 1819
		public bool bool_1;

		// Token: 0x0400071C RID: 1820
		public bool bool_2;

		// Token: 0x0400071D RID: 1821
		protected List<Weapon> list_1;

		// Token: 0x0400071E RID: 1822
		private List<Weapon> list_2;

		// Token: 0x0400071F RID: 1823
		private Weapon weapon_0;

		// Token: 0x04000720 RID: 1824
		private bool bool_3;

		// Token: 0x04000721 RID: 1825
		private Weapon weapon_1;

		// Token: 0x04000722 RID: 1826
		private Weapon weapon_2;

		// Token: 0x04000723 RID: 1827
		private bool bool_4;

		// Token: 0x04000724 RID: 1828
		private bool bool_5;

		// Token: 0x04000725 RID: 1829
		private Weapon weapon_3;

		// Token: 0x04000726 RID: 1830
		private Weapon weapon_4;

		// Token: 0x04000727 RID: 1831
		private bool bool_6;

		// Token: 0x04000728 RID: 1832
		private bool bool_7;

		// Token: 0x04000729 RID: 1833
		private Weapon weapon_5;

		// Token: 0x0400072A RID: 1834
		private bool bool_8;

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x06000B16 RID: 2838
		internal delegate void Delegate22(Scenario theScen, ActiveUnit theFiringUnit, Weapon theWeapon);

		// Token: 0x0200016F RID: 367
		private sealed class Class229
		{
			// Token: 0x06000B17 RID: 2839 RVA: 0x0000821B File Offset: 0x0000641B
			public Class229(int? nullable_2, int? nullable_3)
			{
				this.nullable_0 = nullable_2;
				this.nullable_1 = nullable_3;
			}

			// Token: 0x0400072B RID: 1835
			public int? nullable_0;

			// Token: 0x0400072C RID: 1836
			public int? nullable_1;
		}

		// Token: 0x02000170 RID: 368
		internal enum Enum36
		{
			// Token: 0x0400072E RID: 1838
			const_0,
			// Token: 0x0400072F RID: 1839
			const_1,
			// Token: 0x04000730 RID: 1840
			const_2
		}

		// Token: 0x02000171 RID: 369
		private sealed class FireQueueEntry
		{
			// Token: 0x06000B18 RID: 2840 RVA: 0x00008231 File Offset: 0x00006431
			public FireQueueEntry(ref float float_1, ActiveUnit activeUnit_2, ref WeaponRec weaponRec_1, ref ActiveUnit activeUnit_3, ref Mount mount_1)
			{
				this.float_0 = float_1;
				this.activeUnit_0 = activeUnit_2;
				this.weaponRec_0 = weaponRec_1;
				this.activeUnit_1 = activeUnit_3;
				this.mount_0 = mount_1;
			}

			// Token: 0x04000731 RID: 1841
			public float float_0;

			// Token: 0x04000732 RID: 1842
			public ActiveUnit activeUnit_0;

			// Token: 0x04000733 RID: 1843
			public WeaponRec weaponRec_0;

			// Token: 0x04000734 RID: 1844
			public ActiveUnit activeUnit_1;

			// Token: 0x04000735 RID: 1845
			public Mount mount_0;
		}

		// Token: 0x02000172 RID: 370
		internal enum Enum37
		{
			// Token: 0x04000737 RID: 1847
			const_0,
			// Token: 0x04000738 RID: 1848
			const_1,
			// Token: 0x04000739 RID: 1849
			const_2
		}

		// Token: 0x02000174 RID: 372
		[CompilerGenerated]
		internal sealed class Class230
		{
			// Token: 0x06000B32 RID: 2866 RVA: 0x00008333 File Offset: 0x00006533
			public Class230(ActiveUnit_Weaponry.Class230 class230_0)
			{
				if (class230_0 != null)
				{
					this.contact_0 = class230_0.contact_0;
				}
			}

			// Token: 0x06000B33 RID: 2867 RVA: 0x000D2960 File Offset: 0x000D0B60
			internal int method_0(WeaponRec weaponRec_0)
			{
				ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_Weaponry_0;
				Weapon weapon = weaponRec_0.method_12(this.activeUnit_Weaponry_0.activeUnit_0.scenario_0);
				return activeUnit_Weaponry.method_14(ref weapon, ref this.contact_0, false);
			}

			// Token: 0x06000B34 RID: 2868 RVA: 0x0000834A File Offset: 0x0000654A
			internal float method_1(WeaponRec weaponRec_0)
			{
				return weaponRec_0.method_12(this.activeUnit_Weaponry_0.activeUnit_0.scenario_0).method_181(this.activeUnit_Weaponry_0.activeUnit_0, this.contact_0, true, this.activeUnit_Weaponry_0.activeUnit_0.doctrine_0, false);
			}

			// Token: 0x04000753 RID: 1875
			public Contact contact_0;

			// Token: 0x04000754 RID: 1876
			public ActiveUnit_Weaponry activeUnit_Weaponry_0;
		}

		// Token: 0x02000175 RID: 373
		[CompilerGenerated]
		internal sealed class Class231
		{
			// Token: 0x06000B36 RID: 2870 RVA: 0x0000838A File Offset: 0x0000658A
			internal float method_0(Weapon weapon_0)
			{
				return weapon_0.method_181(this.activeUnit_Weaponry_0.activeUnit_0, this.contact_0, true, this.activeUnit_Weaponry_0.activeUnit_0.doctrine_0, false);
			}

			// Token: 0x04000755 RID: 1877
			public Contact contact_0;

			// Token: 0x04000756 RID: 1878
			public ActiveUnit_Weaponry activeUnit_Weaponry_0;
		}

		// Token: 0x02000176 RID: 374
		[CompilerGenerated]
		internal sealed class Class232
		{
			// Token: 0x06000B38 RID: 2872 RVA: 0x000D2998 File Offset: 0x000D0B98
			internal bool method_0(Weapon weapon_0)
			{
				if (weapon_0.method_181(this.activeUnit_Weaponry_0.activeUnit_0, this.contact_0, true, this.doctrine_0, false) > 0f && string.CompareOrdinal(this.activeUnit_Weaponry_0.method_21(weapon_0, this.contact_0), "OK") == 0)
				{
					ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_Weaponry_0;
					Contact contact = this.contact_0;
					short? num = null;
					return string.CompareOrdinal(activeUnit_Weaponry.method_22(weapon_0, contact, ref num), "OK") == 0;
				}
				return false;
			}

			// Token: 0x06000B39 RID: 2873 RVA: 0x000083B5 File Offset: 0x000065B5
			internal bool method_1(Weapon weapon_0)
			{
				return weapon_0.method_181(this.activeUnit_Weaponry_0.activeUnit_0, this.contact_0, true, this.doctrine_0, false) > 0f;
			}

			// Token: 0x06000B3A RID: 2874 RVA: 0x000D2A14 File Offset: 0x000D0C14
			internal int method_2(Weapon weapon_0)
			{
				ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_Weaponry_0;
				Weapon weapon = weapon_0;
				return activeUnit_Weaponry.method_14(ref weapon, ref this.contact_0, this.bool_0);
			}

			// Token: 0x04000757 RID: 1879
			public Contact contact_0;

			// Token: 0x04000758 RID: 1880
			public Doctrine doctrine_0;

			// Token: 0x04000759 RID: 1881
			public bool bool_0;

			// Token: 0x0400075A RID: 1882
			public ActiveUnit_Weaponry activeUnit_Weaponry_0;
		}

		// Token: 0x02000177 RID: 375
		[CompilerGenerated]
		internal sealed class Class233
		{
			// Token: 0x06000B3C RID: 2876 RVA: 0x000D2A3C File Offset: 0x000D0C3C
			internal bool method_0(Weapon weapon_0)
			{
				if (weapon_0.method_181(this.class232_0.activeUnit_Weaponry_0.activeUnit_0, this.class232_0.contact_0, true, this.class232_0.doctrine_0, false) >= this.float_0 && string.CompareOrdinal(this.class232_0.activeUnit_Weaponry_0.method_21(weapon_0, this.class232_0.contact_0), "OK") == 0)
				{
					ActiveUnit_Weaponry activeUnit_Weaponry_ = this.class232_0.activeUnit_Weaponry_0;
					Contact contact_ = this.class232_0.contact_0;
					short? num = null;
					return string.CompareOrdinal(activeUnit_Weaponry_.method_22(weapon_0, contact_, ref num), "OK") == 0;
				}
				return false;
			}

			// Token: 0x06000B3D RID: 2877 RVA: 0x000083DD File Offset: 0x000065DD
			internal bool method_1(Weapon weapon_0)
			{
				return weapon_0.method_181(this.class232_0.activeUnit_Weaponry_0.activeUnit_0, this.class232_0.contact_0, true, this.class232_0.doctrine_0, false) >= this.float_0;
			}

			// Token: 0x06000B3E RID: 2878 RVA: 0x000D2ADC File Offset: 0x000D0CDC
			internal bool method_2(Weapon weapon_0)
			{
				if (weapon_0.method_181(this.class232_0.activeUnit_Weaponry_0.activeUnit_0, this.class232_0.contact_0, false, this.class232_0.doctrine_0, false) >= this.float_0 && string.CompareOrdinal(this.class232_0.activeUnit_Weaponry_0.method_21(weapon_0, this.class232_0.contact_0), "OK") == 0)
				{
					ActiveUnit_Weaponry activeUnit_Weaponry_ = this.class232_0.activeUnit_Weaponry_0;
					Contact contact_ = this.class232_0.contact_0;
					short? num = null;
					return string.CompareOrdinal(activeUnit_Weaponry_.method_22(weapon_0, contact_, ref num), "OK") == 0;
				}
				return false;
			}

			// Token: 0x06000B3F RID: 2879 RVA: 0x00008418 File Offset: 0x00006618
			internal bool method_3(Weapon weapon_0)
			{
				return weapon_0.method_181(this.class232_0.activeUnit_Weaponry_0.activeUnit_0, this.class232_0.contact_0, false, this.class232_0.doctrine_0, false) >= this.float_0;
			}

			// Token: 0x0400075B RID: 1883
			public float float_0;

			// Token: 0x0400075C RID: 1884
			public ActiveUnit_Weaponry.Class232 class232_0;
		}

		// Token: 0x02000178 RID: 376
		[CompilerGenerated]
		internal sealed class Class234
		{
			// Token: 0x06000B40 RID: 2880 RVA: 0x00008453 File Offset: 0x00006653
			public Class234(ActiveUnit_Weaponry.Class234 class234_0)
			{
				if (class234_0 != null)
				{
					this.string_0 = class234_0.string_0;
				}
			}

			// Token: 0x06000B41 RID: 2881 RVA: 0x0000846A File Offset: 0x0000666A
			internal bool method_0(Contact contact_0)
			{
				return Operators.CompareString(contact_0.string_0, this.string_0, false) == 0;
			}

			// Token: 0x0400075D RID: 1885
			public string string_0;

			// Token: 0x0400075E RID: 1886
			public Func<Contact, bool> func_0;
		}

		// Token: 0x02000179 RID: 377
		[CompilerGenerated]
		internal sealed class Class235
		{
			// Token: 0x06000B42 RID: 2882 RVA: 0x00008481 File Offset: 0x00006681
			public Class235(ActiveUnit_Weaponry.Class235 class235_0)
			{
				if (class235_0 != null)
				{
					this.contact_0 = class235_0.contact_0;
				}
			}

			// Token: 0x06000B43 RID: 2883 RVA: 0x000D2B7C File Offset: 0x000D0D7C
			internal double method_0(Contact contact_1)
			{
				return Class410.smethod_2(contact_1.vmethod_30(null), contact_1.vmethod_28(null), this.contact_0.vmethod_30(null), this.contact_0.vmethod_28(null));
			}

			// Token: 0x0400075F RID: 1887
			public Contact contact_0;
		}

		// Token: 0x0200017A RID: 378
		[CompilerGenerated]
		internal sealed class Class236
		{
			// Token: 0x06000B44 RID: 2884 RVA: 0x00008498 File Offset: 0x00006698
			public Class236(ActiveUnit_Weaponry.Class236 class236_0)
			{
				if (class236_0 != null)
				{
					this.activeUnit_0 = class236_0.activeUnit_0;
				}
			}

			// Token: 0x06000B45 RID: 2885 RVA: 0x000084AF File Offset: 0x000066AF
			internal float method_0(ActiveUnit activeUnit_1)
			{
				return this.activeUnit_0.method_36(activeUnit_1);
			}

			// Token: 0x04000760 RID: 1888
			public ActiveUnit activeUnit_0;
		}
	}
}
