using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
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
	// Token: 0x020001AD RID: 429
	public sealed class Aircraft_Weaponry : ActiveUnit_Weaponry
	{
		// Token: 0x06000D37 RID: 3383 RVA: 0x00008F23 File Offset: 0x00007123
		private Aircraft method_66()
		{
			if (Information.IsNothing(this.aircraft_0))
			{
				this.aircraft_0 = (Aircraft)this.activeUnit_0;
			}
			return this.aircraft_0;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00108F58 File Offset: 0x00107158
		public override void vmethod_2(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Weaponry");
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
				ex.Data.Add("Error at 100472", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00109054 File Offset: 0x00107254
		public static Aircraft_Weaponry smethod_6(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Aircraft_Weaponry result;
			try
			{
				Aircraft_Weaponry aircraft_Weaponry = new Aircraft_Weaponry(ref activeUnit_1);
				aircraft_Weaponry.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "WeaponAssignments", false) != 0)
						{
							if (Operators.CompareString(name, "HF", false) != 0)
							{
								if (Operators.CompareString(name, "LCS", false) != 0)
								{
									if (Operators.CompareString(name, "IDLZ", false) == 0)
									{
										aircraft_Weaponry.bool_2 = true;
									}
								}
								else
								{
									aircraft_Weaponry.bool_1 = true;
								}
							}
							else if (!Information.IsNothing(activeUnit_1.doctrine_0) && Conversions.ToBoolean(xmlNode.InnerText))
							{
								activeUnit_1.doctrine_0.method_64(activeUnit_1.scenario_0, false, null, false, false, new Doctrine.Enum52?(Doctrine.Enum52.const_2));
							}
						}
						else
						{
							try
							{
								foreach (object obj2 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode2 = (XmlNode)obj2;
									Class357 @class = Class357.smethod_0(ref xmlNode2, dictionary_0, ref activeUnit_1.scenario_0);
									if (!Information.IsNothing(@class.contact_0))
									{
										aircraft_Weaponry.vmethod_0().Add(@class);
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
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = aircraft_Weaponry;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100473", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Aircraft_Weaponry(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00008F49 File Offset: 0x00007149
		public Aircraft_Weaponry(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00109258 File Offset: 0x00107458
		public void method_67(bool bool_9, bool bool_10, bool bool_11, bool bool_12, bool bool_13, bool bool_14, bool bool_15)
		{
			if (bool_9 || this.activeUnit_0.scenario_0.FifthSecondIsChangingOnThisPulse)
			{
				if (!Information.IsNothing(this.method_66().method_167()))
				{
					Dictionary<Weapon, int> dictionary = new Dictionary<Weapon, int>();
					foreach (WeaponRec weaponRec in this.method_66().method_167().weaponRec_0)
					{
						if (weaponRec.method_9() != 0 && (bool_15 || !weaponRec.bool_12))
						{
							Weapon weapon = weaponRec.method_12(this.method_66().scenario_0);
							if ((bool_13 || !weapon.method_199()) && (bool_14 || weapon.method_167() != Weapon._WeaponType.SensorPod) && (bool_10 || weapon.method_167() != Weapon._WeaponType.DropTank) && (bool_11 || !weapon.method_156()) && (bool_12 || !weapon.method_0()))
							{
								if (dictionary.ContainsKey(weapon))
								{
									dictionary[weapon] += weaponRec.method_9();
								}
								else
								{
									dictionary.Add(weapon, weaponRec.method_9());
								}
								weaponRec.method_10(0);
							}
						}
					}
					if (dictionary.Count > 0)
					{
						List<string> list = new List<string>();
						try
						{
							foreach (KeyValuePair<Weapon, int> keyValuePair in dictionary)
							{
								this.method_66().vmethod_7(false).class366_0.method_0(keyValuePair.Key.DBID, keyValuePair.Value);
								list.Add(Conversions.ToString(keyValuePair.Value) + "x " + keyValuePair.Key.Name);
							}
						}
						finally
						{
							Dictionary<Weapon, int>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						this.method_66().method_124(string.Concat(new string[]
						{
							this.method_66().Name,
							" (",
							this.method_66().string_2,
							") has jettisoned external stores (",
							string.Join(", ", list),
							") "
						}), this.method_66().Name + " jettisoning", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.method_66().vmethod_28(null), this.method_66().vmethod_30(null)));
						this.vmethod_3();
					}
				}
				if (this.method_66().method_167().int_5 > 0)
				{
					base.method_45();
				}
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x001094D0 File Offset: 0x001076D0
		public override void vmethod_7(float float_0)
		{
			try
			{
				base.vmethod_7(float_0);
				if (this.activeUnit_0.GetType() == typeof(Aircraft) && !Information.IsNothing(this.method_66().method_167()))
				{
					foreach (WeaponRec weaponRec in this.method_66().method_167().weaponRec_0)
					{
						if (weaponRec.float_0 > 0f)
						{
							weaponRec.float_0 -= float_0;
							if (weaponRec.float_0 < 0f)
							{
								weaponRec.float_0 = 0f;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100474", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x001095AC File Offset: 0x001077AC
		public override List<Weapon> vmethod_4()
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
							ObservableList<WeaponRec> observableList4 = array[l].vmethod_10();
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
					if (!Information.IsNothing(this.method_66().method_167()))
					{
						WeaponRec[] weaponRec_ = this.method_66().method_167().weaponRec_0;
						int num6 = weaponRec_.Length - 1;
						for (int n = 0; n <= num6; n++)
						{
							WeaponRec weaponRec = weaponRec_[n];
							if (weaponRec.method_9() > 0 && !dictionary.ContainsKey(weaponRec.int_5))
							{
								dictionary.Add(weaponRec.int_5, 0);
								list.Add(weaponRec.method_12(this.activeUnit_0.scenario_0));
							}
						}
					}
					this.list_1 = list;
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
			}
			return this.list_1;
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00109874 File Offset: 0x00107A74
		public ActiveUnit._ActiveUnitWeaponState method_68(ref List<WeaponRec> list_3, bool bool_9, bool bool_10)
		{
			bool flag = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			float num5 = 0f;
			if (!Information.IsNothing(list_3) && list_3.Count > 0)
			{
				if (!Information.IsNothing(list_3) && list_3.Count > 0)
				{
					try
					{
						foreach (WeaponRec weaponRec in list_3)
						{
							if (bool_10)
							{
								if (!bool_10 || weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun)
								{
									if (!bool_9)
									{
										continue;
									}
									num += weaponRec.method_9();
									num3 += weaponRec.int_2;
									float num6 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
									if (weaponRec.method_9() > 0 && num5 < num6)
									{
										num5 = num6;
										continue;
									}
									continue;
								}
							}
							num2 += weaponRec.method_9();
							num4 += weaponRec.int_2;
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (num == 0 && num2 == 0)
				{
					return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				if (num2 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState result;
			if (flag)
			{
				if (this.activeUnit_0.vmethod_7(false).method_77(ref this.activeUnit_0) > 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.None;
				}
				else
				{
					Contact[] array = this.activeUnit_0.vmethod_86().method_12();
					int i = 0;
					float num7;
					checked
					{
						while (i < array.Length)
						{
							Contact contact_ = array[i];
							ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.activeUnit_0.vmethod_86().method_20(contact_);
							if (targetingBehavior != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted)
							{
								if (targetingBehavior != ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
								{
									i++;
									continue;
								}
							}
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						if (this.activeUnit_0.vmethod_86().method_12().Length == 1)
						{
							num7 = this.activeUnit_0.method_36(this.activeUnit_0.vmethod_86().method_12()[0]);
						}
						else
						{
							IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(this.activeUnit_0.vmethod_86().method_12(), new Func<Contact, double>(this.method_74));
							num7 = this.activeUnit_0.method_36(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
						}
						if (num > 0 && num5 < 5f)
						{
							num5 = 5f;
						}
					}
					if (num5 > 0f && (double)num7 > Math.Max((double)num5 * 1.2, (double)(num5 + 5f)))
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
					}
					else
					{
						if (!this.activeUnit_0.method_85() && this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo)
						{
							if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsJoker)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
							}
						}
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
				}
			}
			else
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			return result;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00109B04 File Offset: 0x00107D04
		public ActiveUnit._ActiveUnitWeaponState method_69(ref List<WeaponRec> list_3, ref bool bool_9, bool bool_10, bool bool_11, bool bool_12, bool bool_13, bool bool_14)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			float num7 = 0f;
			float num8 = 0f;
			if (!Information.IsNothing(list_3) && list_3.Count > 0)
			{
				try
				{
					foreach (WeaponRec weaponRec in list_3)
					{
						if (!bool_14 || (bool_14 && weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun))
						{
							num4 += weaponRec.method_9();
							num6 += weaponRec.int_2;
						}
						if (bool_9)
						{
							if (!weaponRec.method_12(this.activeUnit_0.scenario_0).method_192() && (!bool_11 || !weaponRec.method_12(this.activeUnit_0.scenario_0).method_193()))
							{
								if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun)
								{
									if (bool_13)
									{
										num3 += weaponRec.method_9();
										float num9 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
										if (weaponRec.method_9() > 0 && num8 < num9)
										{
											num8 = num9;
										}
									}
								}
								else if (bool_12)
								{
									num2 += weaponRec.method_9();
									float num10 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
									if (weaponRec.method_9() > 0 && num8 < num10)
									{
										num8 = num10;
									}
								}
							}
							else
							{
								if (!bool_10 && weaponRec.method_9() > 0)
								{
									return ActiveUnit._ActiveUnitWeaponState.None;
								}
								num += weaponRec.method_9();
								num5 += weaponRec.int_2;
								float num11 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
								if (weaponRec.method_9() > 0 && num7 < num11)
								{
									num7 = num11;
								}
							}
						}
						else
						{
							if (!weaponRec.method_12(this.activeUnit_0.scenario_0).method_194())
							{
								if (!bool_11 || weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun)
								{
									if (!bool_12)
									{
										continue;
									}
									num2 += weaponRec.method_9();
									float num12 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
									if (weaponRec.method_9() > 0 && num8 < num12)
									{
										num8 = num12;
										continue;
									}
									continue;
								}
							}
							if (!bool_10 && weaponRec.method_9() > 0)
							{
								return ActiveUnit._ActiveUnitWeaponState.None;
							}
							num += weaponRec.method_9();
							num5 += weaponRec.int_2;
							float num13 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
							if (weaponRec.method_9() > 0 && num7 < num13)
							{
								num7 = num13;
							}
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (num3 == 0 && num2 == 0 && num == 0)
				{
					return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				if (bool_10)
				{
					if (num < num5)
					{
						flag2 = true;
					}
				}
				else if (num == 0)
				{
					flag2 = true;
				}
				if (num4 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState result;
			if (!flag && !flag2)
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (this.activeUnit_0.vmethod_86().method_12().Length == 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			else if (this.activeUnit_0.vmethod_7(false).method_77(ref this.activeUnit_0) > 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
			}
			else
			{
				foreach (Contact contact_ in this.activeUnit_0.vmethod_86().method_12())
				{
					ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.activeUnit_0.vmethod_86().method_20(contact_);
					if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
						}
					}
				}
				float num14;
				if (this.activeUnit_0.vmethod_86().method_12().Length == 1)
				{
					num14 = this.activeUnit_0.method_36(this.activeUnit_0.vmethod_86().method_12()[0]);
				}
				else
				{
					IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(this.activeUnit_0.vmethod_86().method_12(), new Func<Contact, double>(this.method_75));
					num14 = this.activeUnit_0.method_36(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
				}
				if ((bool_13 || (!bool_11 && bool_12)) && (num2 > 0 || num3 > 0) && num8 < 5f)
				{
					num8 = 5f;
				}
				if (num > 0 && num7 > 0f)
				{
					if ((double)num14 > Math.Max((double)num7 * 1.2, (double)(num7 + 5f)))
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						}
					}
				}
				else if (num8 > 0f)
				{
					if ((double)num14 > Math.Max((double)num8 * 1.2, (double)(num8 + 5f)))
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						}
					}
				}
				else
				{
					if (flag)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
				}
				if (!this.activeUnit_0.method_85() && this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo)
				{
					if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsJoker)
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
					}
				}
				if (flag)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				else
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
				}
			}
			return result;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0010A034 File Offset: 0x00108234
		public ActiveUnit._ActiveUnitWeaponState method_70(ref List<WeaponRec> list_3, ref bool bool_9, bool bool_10, bool bool_11, bool bool_12)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			float num8 = 0f;
			float num9 = 0f;
			if (!Information.IsNothing(list_3) && list_3.Count > 0)
			{
				try
				{
					foreach (WeaponRec weaponRec in list_3)
					{
						if (!bool_12 || (bool_12 && weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun))
						{
							num4 += weaponRec.method_9();
							num7 += weaponRec.int_2;
						}
						if (bool_9)
						{
							if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_200())
							{
								if (!bool_10 && weaponRec.method_9() > 0)
								{
									return ActiveUnit._ActiveUnitWeaponState.None;
								}
								if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_192())
								{
									num += weaponRec.method_9();
									num5 += weaponRec.int_2;
								}
								else
								{
									num2 += weaponRec.method_9();
									num6 += weaponRec.int_2;
								}
								float num10 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
								if (num8 < num10)
								{
									num8 = num10;
								}
							}
							else if (bool_11)
							{
								num3 += weaponRec.method_9();
								float num11 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
								if (weaponRec.method_9() > 0 && num9 < num11)
								{
									num9 = num11;
								}
							}
						}
						else
						{
							if (!bool_10 && weaponRec.method_9() > 0)
							{
								return ActiveUnit._ActiveUnitWeaponState.None;
							}
							if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_194())
							{
								num += weaponRec.method_9();
								num5 += weaponRec.int_2;
							}
							else
							{
								num2 += weaponRec.method_9();
								num6 += weaponRec.int_2;
							}
							float num12 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
							if (num8 < num12)
							{
								num8 = num12;
							}
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (num3 == 0 && num2 == 0 && num == 0)
				{
					return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				if (bool_10)
				{
					if (num2 < num6)
					{
						flag2 = true;
					}
				}
				else if (num2 == 0)
				{
					flag2 = true;
				}
				if (num6 == 0 && num == 0)
				{
					flag = true;
				}
				if (num4 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState result;
			if (!flag && !flag2)
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (this.activeUnit_0.vmethod_86().method_12().Length == 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			else if (this.activeUnit_0.vmethod_7(false).method_77(ref this.activeUnit_0) > 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
			}
			else
			{
				foreach (Contact contact_ in this.activeUnit_0.vmethod_86().method_12())
				{
					ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.activeUnit_0.vmethod_86().method_20(contact_);
					if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
						}
					}
				}
				float num13;
				if (this.activeUnit_0.vmethod_86().method_12().Length == 1)
				{
					num13 = this.activeUnit_0.method_36(this.activeUnit_0.vmethod_86().method_12()[0]);
				}
				else
				{
					IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(this.activeUnit_0.vmethod_86().method_12(), new Func<Contact, double>(this.method_76));
					num13 = this.activeUnit_0.method_36(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
				}
				if (bool_11 && num3 > 0 && num9 < 5f)
				{
					num9 = 5f;
				}
				if (num2 > 0 && num8 < 5f)
				{
					num8 = 5f;
				}
				if ((num6 > 0 || num5 > 0) && num8 > 0f)
				{
					if ((double)num13 > Math.Max((double)num8 * 1.2, (double)(num8 + 5f)))
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						}
					}
				}
				else if (num9 > 0f && (double)num13 > Math.Max((double)num9 * 1.2, (double)(num9 + 5f)))
				{
					if (flag)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					if (flag2)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					}
				}
				if (!this.activeUnit_0.method_85() && this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo)
				{
					if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsJoker)
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
					}
				}
				if (flag)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				else
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
				}
			}
			return result;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0010A4B8 File Offset: 0x001086B8
		public ActiveUnit._ActiveUnitWeaponState method_71(ref List<WeaponRec> list_3, ref bool bool_9, bool bool_10, bool bool_11)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			float num7 = 0f;
			float num8 = 0f;
			if (!Information.IsNothing(list_3) && list_3.Count > 0)
			{
				try
				{
					foreach (WeaponRec weaponRec in list_3)
					{
						if (!bool_11 || (bool_11 && weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun))
						{
							num3 += weaponRec.method_9();
							num6 += weaponRec.int_2;
						}
						if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun)
						{
							num += weaponRec.method_9();
							num4 += weaponRec.int_2;
							float num9 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
							if (weaponRec.method_9() > 0 && num7 < num9)
							{
								num7 = num9;
							}
						}
						else
						{
							num2 += weaponRec.method_9();
							num5 += weaponRec.int_2;
							float num10 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
							if (weaponRec.method_9() > 0 && num8 < num10)
							{
								num8 = num10;
							}
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (num == 0 && num2 == 0)
				{
					return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				if (num < num4)
				{
					flag2 = true;
				}
				if (num4 == 0 && num2 == 0)
				{
					flag = true;
				}
				if (num3 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState result;
			if (!flag && !flag2)
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (this.activeUnit_0.vmethod_86().method_12().Length == 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			else if (this.activeUnit_0.vmethod_7(false).method_77(ref this.activeUnit_0) > 0)
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
			}
			else
			{
				foreach (Contact contact_ in this.activeUnit_0.vmethod_86().method_12())
				{
					ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.activeUnit_0.vmethod_86().method_20(contact_);
					if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
						}
					}
				}
				float num11;
				if (this.activeUnit_0.vmethod_86().method_12().Length == 1)
				{
					num11 = this.activeUnit_0.method_36(this.activeUnit_0.vmethod_86().method_12()[0]);
				}
				else
				{
					IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(this.activeUnit_0.vmethod_86().method_12(), new Func<Contact, double>(this.method_77));
					num11 = this.activeUnit_0.method_36(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
				}
				if (num > 0 && num7 < 5f)
				{
					num7 = 5f;
				}
				if (num8 > 0f)
				{
					if ((double)num11 > Math.Max((double)num8 * 1.2, (double)(num8 + 5f)))
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						}
					}
				}
				else if (num7 > 0f && (double)num11 > Math.Max((double)num7 * 1.2, (double)(num7 + 5f)))
				{
					if (flag)
					{
						if (bool_11 && !flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					else if (flag2)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					}
				}
				if (!this.activeUnit_0.method_85() && this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo)
				{
					if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsJoker)
					{
						if (flag)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
						}
						return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
					}
				}
				if (flag)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				else
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
				}
			}
			return result;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0010A844 File Offset: 0x00108A44
		public ActiveUnit._ActiveUnitWeaponState method_72(ref List<WeaponRec> list_3, ref bool bool_9, int int_0, bool bool_10, bool bool_11)
		{
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			float num7 = 0f;
			float num8 = 0f;
			if (!Information.IsNothing(list_3) && list_3.Count > 0)
			{
				if (!Information.IsNothing(list_3) && list_3.Count > 0)
				{
					try
					{
						foreach (WeaponRec weaponRec in list_3)
						{
							if (!bool_11 || (bool_11 && weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun))
							{
								num3 += weaponRec.method_9();
								num6 += weaponRec.int_2;
							}
							if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun)
							{
								num += weaponRec.method_9();
								num4 += weaponRec.int_2;
								if (bool_10)
								{
									float num9 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
									if (weaponRec.method_9() > 0 && num7 < num9)
									{
										num7 = num9;
									}
								}
							}
							else
							{
								num2 += weaponRec.method_9();
								num5 += weaponRec.int_2;
								if (bool_10)
								{
									float num10 = weaponRec.method_12(this.activeUnit_0.scenario_0).method_159();
									if (weaponRec.method_9() > 0 && num8 < num10)
									{
										num8 = num10;
									}
								}
							}
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (num == 0 && num2 == 0)
				{
					return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
				}
				if (bool_11)
				{
					if (num5 > 1 && (double)num2 <= (double)num5 * ((double)int_0 / 100.0))
					{
						flag2 = true;
					}
				}
				else if (num4 + num5 > 1 && (double)(num + num2) <= (double)(num4 + num5) * ((double)int_0 / 100.0))
				{
					flag2 = true;
				}
				if (num3 == 0)
				{
					flag = true;
				}
			}
			ActiveUnit._ActiveUnitWeaponState result;
			if (!flag && !flag2)
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else if (bool_10)
			{
				if (this.activeUnit_0.vmethod_86().method_12().Length == 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
				}
				else if (this.activeUnit_0.vmethod_7(false).method_77(ref this.activeUnit_0) > 0)
				{
					result = ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
				}
				else
				{
					foreach (Contact contact_ in this.activeUnit_0.vmethod_86().method_12())
					{
						ActiveUnit_AI.TargetingEntry._TargetingBehavior targetingBehavior = this.activeUnit_0.vmethod_86().method_20(contact_);
						if (targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualTargeted || targetingBehavior == ActiveUnit_AI.TargetingEntry._TargetingBehavior.ManualWeaponAlloc)
						{
							if (flag)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
							}
							if (flag2)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
							}
						}
					}
					float num11;
					if (this.activeUnit_0.vmethod_86().method_12().Length == 1)
					{
						num11 = this.activeUnit_0.method_36(this.activeUnit_0.vmethod_86().method_12()[0]);
					}
					else
					{
						IEnumerable<Contact> enumerable = Enumerable.OrderBy<Contact, double>(this.activeUnit_0.vmethod_86().method_12(), new Func<Contact, double>(this.method_78));
						num11 = this.activeUnit_0.method_36(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
					}
					if (num > 0 && num7 < 5f)
					{
						num7 = 5f;
					}
					if (num8 > 0f)
					{
						if ((double)num11 > Math.Max((double)num8 * 1.2, (double)(num8 + 5f)))
						{
							if (flag)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							}
							if (flag2)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
							}
						}
					}
					else if (num7 > 0f && (double)num11 > Math.Max((double)num7 * 1.2, (double)(num7 + 5f)))
					{
						if (flag)
						{
							if (bool_11 && !flag2)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
							}
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						else if (flag2)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun;
						}
					}
					if (!this.activeUnit_0.method_85() && this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsBingo)
					{
						if (this.activeUnit_0.vmethod_110() != ActiveUnit._ActiveUnitFuelState.IsJoker)
						{
							if (flag)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsWinchester_EngagingToO;
							}
							return ActiveUnit._ActiveUnitWeaponState.IsShotgun_EngagingToO;
						}
					}
					if (flag)
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					else
					{
						result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
					}
				}
			}
			else if (flag)
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsWinchester;
			}
			else
			{
				result = ActiveUnit._ActiveUnitWeaponState.IsShotgun;
			}
			return result;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0010AC38 File Offset: 0x00108E38
		public override ActiveUnit._ActiveUnitWeaponState vmethod_5()
		{
			ActiveUnit._ActiveUnitWeaponState result;
			if (Information.IsNothing(this.method_66().method_167()))
			{
				result = ActiveUnit._ActiveUnitWeaponState.None;
			}
			else
			{
				try
				{
					Doctrine._WeaponState? weaponState = this.activeUnit_0.doctrine_0.method_211(this.activeUnit_0.scenario_0, false, true, false, false);
					int? num = (weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null;
					bool flag;
					if (((num != null) ? new bool?(num.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						flag = true;
						if (!Information.IsNothing(this.method_66().method_167()))
						{
							weaponState = new Doctrine._WeaponState?(this.method_66().method_167()._WeaponState_0);
						}
					}
					else
					{
						flag = false;
					}
					Loadout.LoadoutRole loadoutRole_ = this.method_66().method_167().loadoutRole_0;
					bool flag2;
					bool flag3;
					if (loadoutRole_ <= Loadout.LoadoutRole.LandOnly_DEAD)
					{
						if (loadoutRole_ - Loadout.LoadoutRole.Intercept_BVR > 6)
						{
							switch (loadoutRole_)
							{
							case Loadout.LoadoutRole.LandNaval_Strike:
								break;
							case Loadout.LoadoutRole.LandNaval_Standoff:
								goto IL_2BB6;
							case Loadout.LoadoutRole.LandNaval_SEAD_ARM:
							case Loadout.LoadoutRole.LandNaval_DEAD:
								goto IL_3608;
							case Loadout.LoadoutRole.LandNaval_SEAD_TALD:
								goto IL_35D2;
							default:
								switch (loadoutRole_)
								{
								case Loadout.LoadoutRole.LandOnly_Strike:
									break;
								case Loadout.LoadoutRole.LandOnly_Standoff:
									goto IL_2BB6;
								case Loadout.LoadoutRole.LandOnly_SEAD_ARM:
								case Loadout.LoadoutRole.LandOnly_DEAD:
									goto IL_3608;
								case Loadout.LoadoutRole.LandOnly_SEAD_TALD:
									goto IL_35D2;
								default:
									goto IL_3F22;
								}
								break;
							}
						}
						else if (!this.method_66().scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(this.method_66().scenario_0.method_39()) && flag)
						{
							switch (this.method_66().method_167().loadoutRole_0)
							{
							case Loadout.LoadoutRole.Intercept_BVR:
							case Loadout.LoadoutRole.PointDefence_BVR:
								if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
								{
									if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_100))) == 0)
									{
										flag2 = true;
									}
									if (Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-24 == null) ? (Aircraft_Weaponry._Closure$__.$I14-24 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_2)) : Aircraft_Weaponry._Closure$__.$I14-24)) == 0)
									{
										flag3 = true;
									}
									if (flag2 && flag3)
									{
										return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									}
									return ActiveUnit._ActiveUnitWeaponState.None;
								}
								else
								{
									bool flag4 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_101))) > 0;
									Mission._MissionClass missionClass_ = this.activeUnit_0.vmethod_101()._MissionClass_0;
									if (missionClass_ != Mission._MissionClass.Strike)
									{
										if (missionClass_ != Mission._MissionClass.Patrol)
										{
											goto IL_36C4;
										}
										if (!flag4)
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
									else
									{
										if (((Strike)this.activeUnit_0.vmethod_101()).strikeType_0 != Strike.StrikeType.Air_Intercept)
										{
											goto IL_36C4;
										}
										if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_102))) == 0)
										{
											flag2 = true;
										}
										if (Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-27 == null) ? (Aircraft_Weaponry._Closure$__.$I14-27 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_3)) : Aircraft_Weaponry._Closure$__.$I14-27)) == 0)
										{
											flag3 = true;
										}
										if (flag2 && flag3)
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
								}
								break;
							case Loadout.LoadoutRole.Intercept_WVR:
							case Loadout.LoadoutRole.AirSuperiority_WVR:
							case Loadout.LoadoutRole.PointDefence_WVR:
								if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_103))) == 0)
								{
									flag2 = true;
								}
								if (Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-29 == null) ? (Aircraft_Weaponry._Closure$__.$I14-29 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_4)) : Aircraft_Weaponry._Closure$__.$I14-29)) == 0)
								{
									flag3 = true;
								}
								if (flag2 && flag3)
								{
									return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								}
								return ActiveUnit._ActiveUnitWeaponState.None;
							case Loadout.LoadoutRole.AirSuperiority_BVR:
								if (Information.IsNothing(this.activeUnit_0.vmethod_101()))
								{
									if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_97))) == 0)
									{
										flag2 = true;
									}
									if (Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-19 == null) ? (Aircraft_Weaponry._Closure$__.$I14-19 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_0)) : Aircraft_Weaponry._Closure$__.$I14-19)) == 0)
									{
										flag3 = true;
									}
									if (flag2 && flag3)
									{
										return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
									}
									return ActiveUnit._ActiveUnitWeaponState.None;
								}
								else
								{
									bool flag5 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_98))) > 0;
									Mission._MissionClass missionClass_2 = this.activeUnit_0.vmethod_101()._MissionClass_0;
									if (missionClass_2 != Mission._MissionClass.Strike)
									{
										if (missionClass_2 != Mission._MissionClass.Patrol)
										{
											goto IL_36C4;
										}
										if (!flag5)
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
									else
									{
										if (((Strike)this.activeUnit_0.vmethod_101()).strikeType_0 != Strike.StrikeType.Air_Intercept)
										{
											goto IL_36C4;
										}
										if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_99))) == 0)
										{
											flag2 = true;
										}
										if (Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-22 == null) ? (Aircraft_Weaponry._Closure$__.$I14-22 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_1)) : Aircraft_Weaponry._Closure$__.$I14-22)) == 0)
										{
											flag3 = true;
										}
										if (flag2 && flag3)
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
								}
								break;
							default:
								goto IL_36C4;
							}
						}
						else
						{
							bool flag6 = false;
							bool flag7 = false;
							if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.GunsOnly)
							{
								flag6 = true;
							}
							if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.AirSuperiority_WVR || this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.Intercept_WVR || this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.PointDefence_WVR)
							{
								flag7 = true;
							}
							num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
							{
								num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
								{
									num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
									if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
									{
										num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
										if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
										{
											num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
											if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
											{
												num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
												if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
												{
													num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
													if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
													{
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
															{
																num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
																{
																	num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																	if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																	{
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																		{
																			num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																			bool flag8;
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																			{
																				List<WeaponRec> list;
																				if (flag6)
																				{
																					list = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_89)));
																				}
																				else
																				{
																					list = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_90)));
																				}
																				try
																				{
																					foreach (Mount mount in this.activeUnit_0.vmethod_51())
																					{
																						if (mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
																						{
																							List<WeaponRec> list2;
																							if (flag6)
																							{
																								list2 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount.vmethod_10(), new Func<WeaponRec, bool>(this.method_91)));
																							}
																							else
																							{
																								list2 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount.vmethod_10(), new Func<WeaponRec, bool>(this.method_92)));
																							}
																							if (!Information.IsNothing(list2) && list2.Count > 0)
																							{
																								list.AddRange(list2);
																							}
																						}
																					}
																				}
																				finally
																				{
																					List<Mount>.Enumerator enumerator;
																					((IDisposable)enumerator).Dispose();
																				}
																				flag8 = true;
																				return this.method_71(ref list, ref flag8, true, !flag6);
																			}
																			List<WeaponRec> list3;
																			if (flag6)
																			{
																				list3 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_93)));
																			}
																			else
																			{
																				list3 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_94)));
																			}
																			try
																			{
																				foreach (Mount mount2 in this.activeUnit_0.vmethod_51())
																				{
																					if (mount2.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
																					{
																						List<WeaponRec> list4;
																						if (flag6)
																						{
																							list4 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount2.vmethod_10(), new Func<WeaponRec, bool>(this.method_95)));
																						}
																						else
																						{
																							list4 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount2.vmethod_10(), new Func<WeaponRec, bool>(this.method_96)));
																						}
																						if (!Information.IsNothing(list4) && list4.Count > 0)
																						{
																							list3.AddRange(list4);
																						}
																					}
																				}
																			}
																			finally
																			{
																				List<Mount>.Enumerator enumerator2;
																				((IDisposable)enumerator2).Dispose();
																			}
																			bool bool_ = false;
																			num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																			int int_;
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																			{
																				int_ = 25;
																			}
																			else
																			{
																				num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																				{
																					int_ = 25;
																					bool_ = true;
																				}
																				else
																				{
																					num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																					{
																						int_ = 50;
																					}
																					else
																					{
																						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																						{
																							int_ = 50;
																							bool_ = true;
																						}
																						else
																						{
																							num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																							if (((num != null) ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																							{
																								int_ = 75;
																							}
																							else
																							{
																								int_ = 75;
																								bool_ = true;
																							}
																						}
																					}
																				}
																			}
																			flag8 = true;
																			return this.method_72(ref list3, ref flag8, int_, bool_, !flag6);
																		}
																	}
																	if (!flag6)
																	{
																		List<WeaponRec> list5 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_87)));
																		try
																		{
																			foreach (Mount mount3 in this.activeUnit_0.vmethod_51())
																			{
																				if (mount3.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
																				{
																					List<WeaponRec> list6 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount3.vmethod_10(), new Func<WeaponRec, bool>(this.method_88)));
																					if (!Information.IsNothing(list6) && list6.Count > 0)
																					{
																						list5.AddRange(list6);
																					}
																				}
																			}
																		}
																		finally
																		{
																			List<Mount>.Enumerator enumerator3;
																			((IDisposable)enumerator3).Dispose();
																		}
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		bool value = ((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).Value;
																		bool flag8 = true;
																		return this.method_70(ref list5, ref flag8, true, value, true);
																	}
																	if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
																	{
																		string str = "";
																		if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
																		{
																			str = " (" + this.activeUnit_0.string_2 + ")";
																		}
																		this.activeUnit_0.method_124("Shotgun weapon state has been set to Beyond Visual Range (BVR) exhaustion, however aircraft " + this.activeUnit_0.Name + str + " is only armed with guns. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns, or use Winchester weapon state.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
																	}
																	if (this.activeUnit_0.vmethod_127())
																	{
																		return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
																	}
																	return ActiveUnit._ActiveUnitWeaponState.None;
																}
															}
														}
													}
												}
												if (flag6)
												{
													if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
													{
														string str2 = "";
														if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
														{
															str2 = " (" + this.activeUnit_0.string_2 + ")";
														}
														this.activeUnit_0.method_124("Shotgun weapon state has been set to one engagement with Beyond Visual Range (BVR) weapons, however aircraft " + this.activeUnit_0.Name + str2 + " is only armed with guns. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns, or use Winchester weapon state.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
													}
													if (this.activeUnit_0.vmethod_127())
													{
														return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
													}
													return ActiveUnit._ActiveUnitWeaponState.None;
												}
												else
												{
													if (!flag7)
													{
														List<WeaponRec> list7 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_85)));
														try
														{
															foreach (Mount mount4 in this.activeUnit_0.vmethod_51())
															{
																if (mount4.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
																{
																	List<WeaponRec> list8 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount4.vmethod_10(), new Func<WeaponRec, bool>(this.method_86)));
																	if (!Information.IsNothing(list8) && list8.Count > 0)
																	{
																		list7.AddRange(list8);
																	}
																}
															}
														}
														finally
														{
															List<Mount>.Enumerator enumerator4;
															((IDisposable)enumerator4).Dispose();
														}
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														bool flag9;
														if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).Value)
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).Value)
															{
																num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).Value)
																{
																	num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																	flag9 = ((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).Value;
																	goto IL_13F2;
																}
															}
														}
														flag9 = true;
														IL_13F2:
														bool bool_2 = flag9;
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														bool flag10;
														if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).Value)
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															flag10 = ((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).Value;
														}
														else
														{
															flag10 = true;
														}
														bool bool_3 = flag10;
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														bool flag11;
														if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).Value)
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															flag11 = ((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).Value;
														}
														else
														{
															flag11 = true;
														}
														bool bool_4 = flag11;
														bool flag8 = true;
														return this.method_69(ref list7, ref flag8, true, bool_4, bool_2, bool_3, true);
													}
													if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
													{
														string str3 = "";
														if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
														{
															str3 = " (" + this.activeUnit_0.string_2 + ")";
														}
														this.activeUnit_0.method_124("Shotgun weapon state has been set to one engagement with Beyond Visual Range (BVR) weapons, however aircraft " + this.activeUnit_0.Name + str3 + " is only armed with Within Visual Range (WVR) weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns or WVR, or use Winchester weapon state.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
													}
													if (this.activeUnit_0.vmethod_127())
													{
														return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
													}
													return ActiveUnit._ActiveUnitWeaponState.None;
												}
											}
										}
									}
									if (flag6)
									{
										if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
										{
											string str4 = "";
											if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
											{
												str4 = " (" + this.activeUnit_0.string_2 + ")";
											}
											this.activeUnit_0.method_124("Shotgun weapon state has been set to Beyond Visual Range (BVR) exhaustion, however aircraft " + this.activeUnit_0.Name + str4 + " is only armed with guns. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns, or use Winchester weapon state.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
										}
										if (this.activeUnit_0.vmethod_127())
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
									else
									{
										if (!flag7)
										{
											List<WeaponRec> list9 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_83)));
											try
											{
												foreach (Mount mount5 in this.activeUnit_0.vmethod_51())
												{
													if (mount5.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
													{
														List<WeaponRec> list10 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount5.vmethod_10(), new Func<WeaponRec, bool>(this.method_84)));
														if (!Information.IsNothing(list10) && list10.Count > 0)
														{
															list9.AddRange(list10);
														}
													}
												}
											}
											finally
											{
												List<Mount>.Enumerator enumerator5;
												((IDisposable)enumerator5).Dispose();
											}
											num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
											bool flag12;
											if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).Value)
											{
												num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
												flag12 = ((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).Value;
											}
											else
											{
												flag12 = true;
											}
											bool bool_5 = flag12;
											num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
											bool value2 = ((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).Value;
											bool flag8 = true;
											return this.method_69(ref list9, ref flag8, false, false, bool_5, value2, true);
										}
										if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
										{
											string str5 = "";
											if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
											{
												str5 = " (" + this.activeUnit_0.string_2 + ")";
											}
											this.activeUnit_0.method_124("Shotgun weapon state has been set to Beyond Visual Range (BVR) exhaustion, however aircraft " + this.activeUnit_0.Name + str5 + " is only armed with Within Visual Range (WVR) weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Guns or WVR, or use Winchester weapon state.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
										}
										if (this.activeUnit_0.vmethod_127())
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
								}
							}
							List<WeaponRec> list11;
							if (flag6)
							{
								list11 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_79)));
							}
							else
							{
								list11 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_80)));
							}
							try
							{
								foreach (Mount mount6 in this.activeUnit_0.vmethod_51())
								{
									if (mount6.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
									{
										List<WeaponRec> list12;
										if (flag6)
										{
											list12 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount6.vmethod_10(), new Func<WeaponRec, bool>(this.method_81)));
										}
										else
										{
											list12 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount6.vmethod_10(), new Func<WeaponRec, bool>(this.method_82)));
										}
										if (!Information.IsNothing(list12) && list12.Count > 0)
										{
											list11.AddRange(list12);
										}
									}
								}
							}
							finally
							{
								List<Mount>.Enumerator enumerator6;
								((IDisposable)enumerator6).Dispose();
							}
							if (!Information.IsNothing(this.activeUnit_0.vmethod_101()) && (this.activeUnit_0.vmethod_101()._MissionClass_0 != Mission._MissionClass.Strike || ((Strike)this.activeUnit_0.vmethod_101()).strikeType_0 != Strike.StrikeType.Air_Intercept) && !flag6)
							{
								num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								return this.method_68(ref list11, ((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).Value, !flag6);
							}
							return this.method_68(ref list11, false, false);
						}
					}
					else if (loadoutRole_ <= Loadout.LoadoutRole.BAI_CAS)
					{
						switch (loadoutRole_)
						{
						case Loadout.LoadoutRole.NavalOnly_Strike:
							break;
						case Loadout.LoadoutRole.NavalOnly_Standoff:
							goto IL_2BB6;
						case Loadout.LoadoutRole.NavalOnly_SEAD_ARM:
						case Loadout.LoadoutRole.NavalOnly_DEAD:
							goto IL_3608;
						case Loadout.LoadoutRole.NavalOnly_SEAD_TALD:
							goto IL_35D2;
						default:
							if (loadoutRole_ != Loadout.LoadoutRole.BAI_CAS)
							{
								goto IL_3F22;
							}
							break;
						}
					}
					else if (loadoutRole_ != Loadout.LoadoutRole.NavalMineLaying)
					{
						if (loadoutRole_ != Loadout.LoadoutRole.ASW_Patrol)
						{
							goto IL_3F22;
						}
						bool flag13 = true;
						WeaponRec[] weaponRec_ = this.method_66().method_167().weaponRec_0;
						int i = 0;
						checked
						{
							while (i < weaponRec_.Length)
							{
								if (weaponRec_[i].method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Sonobuoy)
								{
									flag13 = false;
									IL_3F79:
									if (flag13)
									{
										if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, (Aircraft_Weaponry._Closure$__.$I14-52 == null) ? (Aircraft_Weaponry._Closure$__.$I14-52 = new Func<WeaponRec, bool>(Aircraft_Weaponry._Closure$__.$I.method_9)) : Aircraft_Weaponry._Closure$__.$I14-52)) == 0)
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
									else
									{
										if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_122))) == 0)
										{
											return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
										}
										return ActiveUnit._ActiveUnitWeaponState.None;
									}
								}
								else
								{
									i++;
								}
							}
							goto IL_3F79;
						}
					}
					else
					{
						if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_130))) == 0)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						return ActiveUnit._ActiveUnitWeaponState.None;
					}
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets;
					byte? b;
					if (this.method_66().scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(this.method_66().scenario_0.method_39()) || !flag)
					{
						gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
						b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
						bool value3;
						List<WeaponRec> list13;
						if (value3 = ((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).Value)
						{
							if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.LandNaval_Strike)
							{
								list13 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_107)));
							}
							else if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.NavalOnly_Strike)
							{
								list13 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_108)));
							}
							else
							{
								list13 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_109)));
							}
							try
							{
								foreach (Mount mount7 in this.activeUnit_0.vmethod_51())
								{
									if (mount7.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
									{
										List<WeaponRec> list14;
										if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.LandNaval_Strike)
										{
											list14 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount7.vmethod_10(), new Func<WeaponRec, bool>(this.method_110)));
										}
										else if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.NavalOnly_Strike)
										{
											list14 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount7.vmethod_10(), new Func<WeaponRec, bool>(this.method_111)));
										}
										else
										{
											list14 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(mount7.vmethod_10(), new Func<WeaponRec, bool>(this.method_112)));
										}
										if (!Information.IsNothing(list14) && list14.Count > 0)
										{
											list13.AddRange(list14);
										}
									}
								}
								goto IL_22F9;
							}
							finally
							{
								List<Mount>.Enumerator enumerator7;
								((IDisposable)enumerator7).Dispose();
							}
						}
						if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.LandNaval_Strike)
						{
							list13 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_113)));
						}
						else if (this.method_66().method_167().loadoutRole_0 == Loadout.LoadoutRole.NavalOnly_Strike)
						{
							list13 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_114)));
						}
						else
						{
							list13 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_115)));
						}
						IL_22F9:
						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
						if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
						{
							num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
							{
								num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
								{
									num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
									if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
									{
										num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
										if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
										{
											num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
											if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
											{
												num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
												if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
												{
													num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
													if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
													{
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														bool flag8;
														if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
															{
																num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																{
																	num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																	if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																	{
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																		{
																			flag8 = false;
																			return this.method_71(ref list13, ref flag8, true, !value3);
																		}
																		bool bool_6 = false;
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		int int_2;
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																		{
																			int_2 = 25;
																		}
																		else
																		{
																			num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																			{
																				int_2 = 25;
																				bool_6 = true;
																			}
																			else
																			{
																				num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																				{
																					int_2 = 50;
																				}
																				else
																				{
																					num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																					{
																						int_2 = 50;
																						bool_6 = true;
																					}
																					else
																					{
																						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																						{
																							int_2 = 75;
																						}
																						else
																						{
																							int_2 = 75;
																							bool_6 = true;
																						}
																					}
																				}
																			}
																		}
																		flag8 = false;
																		return this.method_72(ref list13, ref flag8, int_2, bool_6, !value3);
																	}
																}
																flag8 = false;
																return this.method_70(ref list13, ref flag8, true, false, !value3);
															}
														}
														flag8 = false;
														return this.method_69(ref list13, ref flag8, true, true, false, false, value3);
													}
												}
											}
											if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
											{
												string str6 = "";
												if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
												{
													str6 = " (" + this.activeUnit_0.string_2 + ")";
												}
												this.activeUnit_0.method_124("Shotgun weapon state has been set to one engagement with Stand-Off weapons, however aircraft " + this.activeUnit_0.Name + str6 + " is only armed with short-range weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Short-Range weapons or Guns, or use Winchester weapon state.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
											}
											if (this.activeUnit_0.vmethod_127())
											{
												return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
											}
											return ActiveUnit._ActiveUnitWeaponState.None;
										}
									}
								}
								if (this.activeUnit_0.vmethod_112() != ActiveUnit._ActiveUnitWeaponState.IsWinchester || this.activeUnit_0.scenario_0.MinuteIsChangingOnThisPulse)
								{
									string str7 = "";
									if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
									{
										str7 = " (" + this.activeUnit_0.string_2 + ")";
									}
									this.activeUnit_0.method_124("Shotgun weapon state has been set to one engagement with Stand-Off weapons, however aircraft " + this.activeUnit_0.Name + str7 + " is only armed with short-range weapons. The aircraft will therefore return to base immediately. Change the Shotgun weapon state to Short-Range weapons or Guns, or use Winchester weapon state.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
								}
								if (this.activeUnit_0.vmethod_127())
								{
									return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
								}
								return ActiveUnit._ActiveUnitWeaponState.None;
							}
						}
						return this.method_68(ref list13, false, !value3);
					}
					Loadout.LoadoutRole loadoutRole_2 = this.method_66().method_167().loadoutRole_0;
					if (loadoutRole_2 <= Loadout.LoadoutRole.LandOnly_Strike)
					{
						if (loadoutRole_2 != Loadout.LoadoutRole.LandNaval_Strike)
						{
							if (loadoutRole_2 != Loadout.LoadoutRole.LandOnly_Strike)
							{
								goto IL_36C4;
							}
						}
						else
						{
							gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
							b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							int num2;
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num2 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_116)));
							}
							else
							{
								num2 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_117)));
							}
							if (num2 == 0)
							{
								flag2 = true;
							}
							gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
							b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							int num3;
							if (!((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num3 = Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-45 == null) ? (Aircraft_Weaponry._Closure$__.$I14-45 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_6)) : Aircraft_Weaponry._Closure$__.$I14-45));
							}
							if (num3 == 0)
							{
								flag3 = true;
							}
							if (flag2 && flag3)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							}
							return ActiveUnit._ActiveUnitWeaponState.None;
						}
					}
					else if (loadoutRole_2 != Loadout.LoadoutRole.NavalOnly_Strike)
					{
						if (loadoutRole_2 != Loadout.LoadoutRole.BAI_CAS)
						{
							goto IL_36C4;
						}
					}
					else
					{
						gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
						b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
						int num4;
						if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							num4 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_120)));
						}
						else
						{
							num4 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_121)));
						}
						if (num4 == 0)
						{
							flag2 = true;
						}
						gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
						b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
						int num5;
						if (!((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
						{
							num5 = Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-51 == null) ? (Aircraft_Weaponry._Closure$__.$I14-51 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_8)) : Aircraft_Weaponry._Closure$__.$I14-51));
						}
						if (num5 == 0)
						{
							flag3 = true;
						}
						if (flag2 && flag3)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						return ActiveUnit._ActiveUnitWeaponState.None;
					}
					gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
					b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					int num6;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num6 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_118)));
					}
					else
					{
						num6 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_119)));
					}
					if (num6 == 0)
					{
						flag2 = true;
					}
					gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
					b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					int num7;
					if (!((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num7 = Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-48 == null) ? (Aircraft_Weaponry._Closure$__.$I14-48 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_7)) : Aircraft_Weaponry._Closure$__.$I14-48));
					}
					if (num7 == 0)
					{
						flag3 = true;
					}
					if (flag2 && flag3)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					return ActiveUnit._ActiveUnitWeaponState.None;
					IL_2BB6:
					if (this.method_66().scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(this.method_66().scenario_0.method_39()) || !flag)
					{
						List<WeaponRec> list15 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_104)));
						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
						ActiveUnit._ActiveUnitWeaponState activeUnitWeaponState;
						if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
						{
							num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
							{
								num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								bool flag8;
								if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
								{
									num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
									if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
									{
										num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
										if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
										{
											num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
											if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
											{
												num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
												if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
												{
													num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
													if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
													{
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
															{
																num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																{
																	num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																	if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																	{
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																		{
																			flag8 = false;
																			activeUnitWeaponState = this.method_71(ref list15, ref flag8, true, true);
																			goto IL_3494;
																		}
																		bool bool_7 = false;
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		int int_3;
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																		{
																			int_3 = 25;
																		}
																		else
																		{
																			num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																			{
																				int_3 = 25;
																				bool_7 = true;
																			}
																			else
																			{
																				num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																				{
																					int_3 = 50;
																				}
																				else
																				{
																					num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																					{
																						int_3 = 50;
																						bool_7 = true;
																					}
																					else
																					{
																						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																						{
																							int_3 = 75;
																						}
																						else
																						{
																							int_3 = 75;
																							bool_7 = true;
																						}
																					}
																				}
																			}
																		}
																		flag8 = false;
																		activeUnitWeaponState = this.method_72(ref list15, ref flag8, int_3, bool_7, true);
																		goto IL_3494;
																	}
																}
																flag8 = false;
																activeUnitWeaponState = this.method_70(ref list15, ref flag8, true, false, true);
																goto IL_3494;
															}
														}
														flag8 = false;
														activeUnitWeaponState = this.method_69(ref list15, ref flag8, true, true, false, false, true);
														goto IL_3494;
													}
												}
											}
											flag8 = false;
											activeUnitWeaponState = this.method_69(ref list15, ref flag8, true, false, true, false, true);
											goto IL_3494;
										}
									}
								}
								flag8 = false;
								activeUnitWeaponState = this.method_69(ref list15, ref flag8, false, false, false, false, true);
								goto IL_3494;
							}
						}
						activeUnitWeaponState = this.method_68(ref list15, false, true);
						IL_3494:
						if (this.activeUnit_0.vmethod_112() != activeUnitWeaponState)
						{
							gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
							b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
							if (((b != null) ? new bool?(b.GetValueOrDefault() == 1) : null).GetValueOrDefault())
							{
								string str8 = "";
								if (Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
								{
									str8 = " (" + this.activeUnit_0.string_2 + ")";
								}
								this.activeUnit_0.method_124("Doctrine allows airto-ground strafing (gun), however aircraft " + this.activeUnit_0.Name + str8 + " is only armed with stand-off weapons. The aircraft will therefore return to base immediately rather than risk a close-in attack with guns. If you wish to use guns, switch to a loadout with short-range weapons, or alternatively attack manually.", this.activeUnit_0.Name + " RTBing immediately", LoggedMessage.MessageType.AirOps, 1, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
						return activeUnitWeaponState;
					}
					gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
					b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					int num8;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num8 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_105)));
					}
					else
					{
						num8 = Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_106)));
					}
					if (num8 == 0)
					{
						flag2 = true;
					}
					gunStrafeGroundTargets = this.activeUnit_0.doctrine_0.method_147(this.activeUnit_0.scenario_0, false, false, false);
					b = ((gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null);
					int num9;
					if (!((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						num9 = Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.activeUnit_0.vmethod_51(), (Aircraft_Weaponry._Closure$__.$I14-33 == null) ? (Aircraft_Weaponry._Closure$__.$I14-33 = new Func<Mount, bool>(Aircraft_Weaponry._Closure$__.$I.method_5)) : Aircraft_Weaponry._Closure$__.$I14-33));
					}
					if (num9 == 0)
					{
						flag3 = true;
					}
					if (flag2 && flag3)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					return ActiveUnit._ActiveUnitWeaponState.None;
					IL_35D2:
					if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_129))) == 0)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					return ActiveUnit._ActiveUnitWeaponState.None;
					IL_3608:
					if (this.method_66().scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(this.method_66().scenario_0.method_39()) || !flag)
					{
						Loadout.LoadoutRole loadoutRole_3 = this.method_66().method_167().loadoutRole_0;
						List<WeaponRec> list16;
						if (loadoutRole_3 <= Loadout.LoadoutRole.LandOnly_SEAD_ARM)
						{
							if (loadoutRole_3 == Loadout.LoadoutRole.LandNaval_SEAD_ARM || loadoutRole_3 == Loadout.LoadoutRole.LandNaval_DEAD)
							{
								list16 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_123)));
								goto IL_380B;
							}
							if (loadoutRole_3 != Loadout.LoadoutRole.LandOnly_SEAD_ARM)
							{
								goto IL_380B;
							}
						}
						else if (loadoutRole_3 != Loadout.LoadoutRole.LandOnly_DEAD)
						{
							if (loadoutRole_3 != Loadout.LoadoutRole.NavalOnly_SEAD_ARM && loadoutRole_3 != Loadout.LoadoutRole.NavalOnly_DEAD)
							{
								goto IL_380B;
							}
							list16 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_125)));
							goto IL_380B;
						}
						list16 = Enumerable.ToList<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_124)));
						IL_380B:
						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
						if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2001) : null).GetValueOrDefault())
						{
							num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
							if (!((num != null) ? new bool?(num.GetValueOrDefault() == 2002) : null).GetValueOrDefault())
							{
								num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
								bool flag8;
								if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3001) : null).GetValueOrDefault())
								{
									num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
									if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3002) : null).GetValueOrDefault())
									{
										num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
										if (!((num != null) ? new bool?(num.GetValueOrDefault() == 3003) : null).GetValueOrDefault())
										{
											num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
											if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5001) : null).GetValueOrDefault())
											{
												num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
												if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5002) : null).GetValueOrDefault())
												{
													num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
													if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5003) : null).GetValueOrDefault())
													{
														num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
														if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5005) : null).GetValueOrDefault())
														{
															num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
															if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5006) : null).GetValueOrDefault())
															{
																num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5011) : null).GetValueOrDefault())
																{
																	num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																	if (!((num != null) ? new bool?(num.GetValueOrDefault() == 5012) : null).GetValueOrDefault())
																	{
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 5021) : null).GetValueOrDefault())
																		{
																			flag8 = false;
																			return this.method_71(ref list16, ref flag8, true, true);
																		}
																		bool bool_8 = false;
																		num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																		int int_4;
																		if (((num != null) ? new bool?(num.GetValueOrDefault() == 4001) : null).GetValueOrDefault())
																		{
																			int_4 = 25;
																		}
																		else
																		{
																			num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																			if (((num != null) ? new bool?(num.GetValueOrDefault() == 4002) : null).GetValueOrDefault())
																			{
																				int_4 = 25;
																				bool_8 = true;
																			}
																			else
																			{
																				num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																				if (((num != null) ? new bool?(num.GetValueOrDefault() == 4011) : null).GetValueOrDefault())
																				{
																					int_4 = 50;
																				}
																				else
																				{
																					num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																					if (((num != null) ? new bool?(num.GetValueOrDefault() == 4012) : null).GetValueOrDefault())
																					{
																						int_4 = 50;
																						bool_8 = true;
																					}
																					else
																					{
																						num = ((weaponState != null) ? new int?((int)weaponState.GetValueOrDefault()) : null);
																						if (((num != null) ? new bool?(num.GetValueOrDefault() == 4021) : null).GetValueOrDefault())
																						{
																							int_4 = 75;
																						}
																						else
																						{
																							int_4 = 75;
																							bool_8 = true;
																						}
																					}
																				}
																			}
																		}
																		flag8 = false;
																		return this.method_72(ref list16, ref flag8, int_4, bool_8, true);
																	}
																}
																flag8 = false;
																return this.method_70(ref list16, ref flag8, true, false, true);
															}
														}
														flag8 = false;
														return this.method_69(ref list16, ref flag8, true, true, false, false, true);
													}
												}
											}
											flag8 = false;
											return this.method_69(ref list16, ref flag8, true, false, true, false, true);
										}
									}
								}
								flag8 = false;
								return this.method_69(ref list16, ref flag8, false, false, false, false, true);
							}
						}
						return this.method_68(ref list16, false, true);
					}
					Loadout.LoadoutRole loadoutRole_4 = this.method_66().method_167().loadoutRole_0;
					if (loadoutRole_4 <= Loadout.LoadoutRole.LandOnly_SEAD_ARM)
					{
						if (loadoutRole_4 != Loadout.LoadoutRole.LandNaval_SEAD_ARM && loadoutRole_4 != Loadout.LoadoutRole.LandNaval_DEAD)
						{
							if (loadoutRole_4 != Loadout.LoadoutRole.LandOnly_SEAD_ARM)
							{
								goto IL_36C4;
							}
						}
						else
						{
							if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_126))) == 0)
							{
								return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
							}
							return ActiveUnit._ActiveUnitWeaponState.None;
						}
					}
					else if (loadoutRole_4 != Loadout.LoadoutRole.LandOnly_DEAD)
					{
						if (loadoutRole_4 != Loadout.LoadoutRole.NavalOnly_SEAD_ARM && loadoutRole_4 != Loadout.LoadoutRole.NavalOnly_DEAD)
						{
							goto IL_36C4;
						}
						if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_128))) == 0)
						{
							return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
						}
						return ActiveUnit._ActiveUnitWeaponState.None;
					}
					if (Enumerable.Count<WeaponRec>(Enumerable.Where<WeaponRec>(this.method_66().method_167().weaponRec_0, new Func<WeaponRec, bool>(this.method_127))) == 0)
					{
						return ActiveUnit._ActiveUnitWeaponState.IsWinchester;
					}
					return ActiveUnit._ActiveUnitWeaponState.None;
					IL_36C4:
					return ActiveUnit._ActiveUnitWeaponState.None;
					IL_3F22:
					result = ActiveUnit._ActiveUnitWeaponState.None;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200295", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = ActiveUnit._ActiveUnitWeaponState.None;
				}
			}
			return result;
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0010ED74 File Offset: 0x0010CF74
		public void method_73(float elapsedTime, bool IsManual, ref string UserFeedback, Class568.Enum154? DepthSetting = null, bool? DropActive = null)
		{
			List<WeaponRec> list = new List<WeaponRec>();
			try
			{
				if (Class442.smethod_1(this.method_66().vmethod_28(null), this.method_66().vmethod_30(null)))
				{
					if (IsManual)
					{
						UserFeedback = "Cannot drop sonobuoy over ice!";
					}
				}
				else
				{
					try
					{
						foreach (Mount mount in this.method_66().vmethod_51())
						{
							try
							{
								foreach (WeaponRec weaponRec in mount.vmethod_10())
								{
									weaponRec.mount_0 = mount;
									if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Sonobuoy && weaponRec.method_9() != 0 && mount.vmethod_5() == PlatformComponent._ComponentStatus.Operational && mount.method_28() == 0f && weaponRec.float_0 == 0f)
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
					if (!Information.IsNothing(this.method_66().method_167()))
					{
						foreach (WeaponRec weaponRec in this.method_66().method_167().weaponRec_0)
						{
							weaponRec.mount_0 = null;
							if (weaponRec.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Sonobuoy && weaponRec.method_9() != 0 && weaponRec.float_0 <= 0f)
							{
								list.Add(weaponRec);
							}
						}
					}
					if (list.Count == 0)
					{
						if (IsManual)
						{
							UserFeedback = "No sonobuoys left!";
						}
					}
					else
					{
						if (DropActive != null)
						{
							List<WeaponRec> list2 = new List<WeaponRec>();
							if (DropActive.Value)
							{
								try
								{
									foreach (WeaponRec weaponRec2 in list)
									{
										if (!weaponRec2.method_12(this.activeUnit_0.scenario_0).vmethod_96()[0].method_46())
										{
											list2.Add(weaponRec2);
										}
									}
									goto IL_262;
								}
								finally
								{
									List<WeaponRec>.Enumerator enumerator3;
									((IDisposable)enumerator3).Dispose();
								}
							}
							try
							{
								foreach (WeaponRec weaponRec3 in list)
								{
									if (weaponRec3.method_12(this.activeUnit_0.scenario_0).vmethod_96()[0].method_46())
									{
										list2.Add(weaponRec3);
									}
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							IL_262:
							try
							{
								foreach (WeaponRec item in list2)
								{
									list.Remove(item);
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
						}
						if (list.Count == 0)
						{
							if (IsManual)
							{
								UserFeedback = "No sonobuoy of desired type left!";
							}
						}
						else
						{
							WeaponRec weaponRec4;
							if (list.Count == 1)
							{
								weaponRec4 = list[0];
							}
							else
							{
								weaponRec4 = list[GameGeneral.smethod_5().Next(0, list.Count)];
							}
							if (DepthSetting == null)
							{
								if (GameGeneral.smethod_5().Next(0, 1000) > 500)
								{
									DepthSetting = new Class568.Enum154?(Class568.Enum154.const_0);
								}
								else
								{
									DepthSetting = new Class568.Enum154?(Class568.Enum154.const_2);
								}
							}
							Contact theTarget = null;
							int num = 0;
							int specificNumberOfWeaponsToFire = 0;
							float initialHeading = 0f;
							ActiveUnit.Throttle throttleSetting = ActiveUnit.Throttle.Flank;
							Mount firingMount = null;
							Class568.Enum154 value = DepthSetting.Value;
							long armDelay_sec = 0L;
							Class316 @class = null;
							base.method_43(elapsedTime, ref weaponRec4, theTarget, ref num, specificNumberOfWeaponsToFire, initialHeading, throttleSetting, firingMount, value, armDelay_sec, ref @class);
						}
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

		// Token: 0x06000D45 RID: 3397 RVA: 0x00008F53 File Offset: 0x00007153
		[CompilerGenerated]
		private double method_74(Contact contact_0)
		{
			return this.activeUnit_0.method_31(contact_0);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00008F53 File Offset: 0x00007153
		[CompilerGenerated]
		private double method_75(Contact contact_0)
		{
			return this.activeUnit_0.method_31(contact_0);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00008F53 File Offset: 0x00007153
		[CompilerGenerated]
		private double method_76(Contact contact_0)
		{
			return this.activeUnit_0.method_31(contact_0);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00008F53 File Offset: 0x00007153
		[CompilerGenerated]
		private double method_77(Contact contact_0)
		{
			return this.activeUnit_0.method_31(contact_0);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00008F53 File Offset: 0x00007153
		[CompilerGenerated]
		private double method_78(Contact contact_0)
		{
			return this.activeUnit_0.method_31(contact_0);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00008F61 File Offset: 0x00007161
		[CompilerGenerated]
		private bool method_79(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_80(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00008F61 File Offset: 0x00007161
		[CompilerGenerated]
		private bool method_81(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_82(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_83(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_84(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_85(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_86(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_87(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_88(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00008F61 File Offset: 0x00007161
		[CompilerGenerated]
		private bool method_89(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_90(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00008F61 File Offset: 0x00007161
		[CompilerGenerated]
		private bool method_91(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_92(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00008F61 File Offset: 0x00007161
		[CompilerGenerated]
		private bool method_93(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_94(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00008F61 File Offset: 0x00007161
		[CompilerGenerated]
		private bool method_95(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() == Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00008F80 File Offset: 0x00007180
		[CompilerGenerated]
		private bool method_96(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199();
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00008F98 File Offset: 0x00007198
		[CompilerGenerated]
		private bool method_97(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00008FBD File Offset: 0x000071BD
		[CompilerGenerated]
		private bool method_98(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_2() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_192() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00008F98 File Offset: 0x00007198
		[CompilerGenerated]
		private bool method_99(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00008F98 File Offset: 0x00007198
		[CompilerGenerated]
		private bool method_100(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00008FFA File Offset: 0x000071FA
		[CompilerGenerated]
		private bool method_101(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_2() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00008F98 File Offset: 0x00007198
		[CompilerGenerated]
		private bool method_102(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00008F98 File Offset: 0x00007198
		[CompilerGenerated]
		private bool method_103(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_199() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0000901F File Offset: 0x0000721F
		[CompilerGenerated]
		private bool method_104(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_194();
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0010F18C File Offset: 0x0010D38C
		[CompilerGenerated]
		private bool method_105(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_194() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00009037 File Offset: 0x00007237
		[CompilerGenerated]
		private bool method_106(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_194() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0000905C File Offset: 0x0000725C
		[CompilerGenerated]
		private bool method_107(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195();
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0000908E File Offset: 0x0000728E
		[CompilerGenerated]
		private bool method_108(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196();
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x000090A6 File Offset: 0x000072A6
		[CompilerGenerated]
		private bool method_109(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195();
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0000905C File Offset: 0x0000725C
		[CompilerGenerated]
		private bool method_110(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195();
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0000908E File Offset: 0x0000728E
		[CompilerGenerated]
		private bool method_111(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196();
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x000090A6 File Offset: 0x000072A6
		[CompilerGenerated]
		private bool method_112(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195();
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0010F1DC File Offset: 0x0010D3DC
		[CompilerGenerated]
		private bool method_113(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000090BE File Offset: 0x000072BE
		[CompilerGenerated]
		private bool method_114(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000090FA File Offset: 0x000072FA
		[CompilerGenerated]
		private bool method_115(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0010F23C File Offset: 0x0010D43C
		[CompilerGenerated]
		private bool method_116(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00009136 File Offset: 0x00007336
		[CompilerGenerated]
		private bool method_117(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195()) && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0010F2A4 File Offset: 0x0010D4A4
		[CompilerGenerated]
		private bool method_118(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00009173 File Offset: 0x00007373
		[CompilerGenerated]
		private bool method_119(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0010F2F4 File Offset: 0x0010D4F4
		[CompilerGenerated]
		private bool method_120(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00009198 File Offset: 0x00007398
		[CompilerGenerated]
		private bool method_121(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000091BD File Offset: 0x000073BD
		[CompilerGenerated]
		private bool method_122(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_197() && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0010F344 File Offset: 0x0010D544
		[CompilerGenerated]
		private bool method_123(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_198()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0010F3BC File Offset: 0x0010D5BC
		[CompilerGenerated]
		private bool method_124(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_198()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0010F41C File Offset: 0x0010D61C
		[CompilerGenerated]
		private bool method_125(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_198()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0010F47C File Offset: 0x0010D67C
		[CompilerGenerated]
		private bool method_126(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_198()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0010F4FC File Offset: 0x0010D6FC
		[CompilerGenerated]
		private bool method_127(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_195() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_198()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0010F564 File Offset: 0x0010D764
		[CompilerGenerated]
		private bool method_128(WeaponRec weaponRec_0)
		{
			return (weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_196() || weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_198()) && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_167() != Weapon._WeaponType.Gun && weaponRec_0.method_9() > 0;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000091E2 File Offset: 0x000073E2
		[CompilerGenerated]
		private bool method_129(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_9() > 0 && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_87();
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00009205 File Offset: 0x00007405
		[CompilerGenerated]
		private bool method_130(WeaponRec weaponRec_0)
		{
			return weaponRec_0.method_9() > 0 && weaponRec_0.method_12(this.activeUnit_0.scenario_0).method_155();
		}

		// Token: 0x040008AD RID: 2221
		private Aircraft aircraft_0;
	}
}
