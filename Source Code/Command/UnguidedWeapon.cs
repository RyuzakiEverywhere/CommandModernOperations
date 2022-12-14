using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns14;

namespace Command_Core
{
	// Token: 0x0200036D RID: 877
	public sealed class UnguidedWeapon : Unit
	{
		// Token: 0x060019F7 RID: 6647 RVA: 0x0000D360 File Offset: 0x0000B560
		public GeoPoint method_56()
		{
			return this.geoPoint_0;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0000D368 File Offset: 0x0000B568
		public void method_57(GeoPoint geoPoint_1)
		{
			this.geoPoint_0 = geoPoint_1;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x001D61FC File Offset: 0x001D43FC
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("UnguidedWeapon");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_0.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(this.string_0);
					xmlWriter_0.WriteElementString("DBID", this.int_0.ToString());
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.vmethod_9()));
					xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.vmethod_40()));
					xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.vmethod_14(false)));
					xmlWriter_0.WriteElementString("ImpactAltitude", XmlConvert.ToString(this.vmethod_16()));
					xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.vmethod_28(null)));
					xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.vmethod_30(null)));
					if (!Information.IsNothing(this.vmethod_7(false)))
					{
						xmlWriter_0.WriteElementString("Side", this.vmethod_7(false).method_51());
					}
					xmlWriter_0.WriteElementString("CEP_Surface", XmlConvert.ToString(this.float_9));
					xmlWriter_0.WriteElementString("CEP_Land", XmlConvert.ToString(this.float_10));
					if (!Information.IsNothing(this.contact_0))
					{
						xmlWriter_0.WriteElementString("Target", this.contact_0.string_0);
					}
					xmlWriter_0.WriteElementString("TimeToLive", XmlConvert.ToString(this.float_33));
					xmlWriter_0.WriteStartElement("LaunchPoint");
					xmlWriter_0.WriteRaw(this.method_56().method_8(hashSet_0));
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteElementString("TimeToDetonate", XmlConvert.ToString(this.float_34));
					if (!Information.IsNothing(this.method_58()))
					{
						xmlWriter_0.WriteElementString("FiringParent", this.method_58().string_0);
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100852", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0000D371 File Offset: 0x0000B571
		public static bool smethod_0(string string_5)
		{
			return string_5.ToLower().Contains("burst");
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0000D383 File Offset: 0x0000B583
		public static bool smethod_1(string string_5)
		{
			return string_5.ToLower().Contains("salvo");
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x001D6464 File Offset: 0x001D4664
		public ActiveUnit method_58()
		{
			ActiveUnit result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = null;
			}
			else if (this.activeUnit_0.method_82())
			{
				result = null;
			}
			else
			{
				result = this.activeUnit_0;
			}
			return result;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0000D395 File Offset: 0x0000B595
		public void method_59(ActiveUnit activeUnit_1)
		{
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x001D649C File Offset: 0x001D469C
		public void method_60(ref Scenario scenario_0)
		{
			try
			{
				if (!Information.IsNothing(this.string_4))
				{
					scenario_0.vmethod_0().TryGetValue(this.string_4, ref this.activeUnit_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101295", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x001D6518 File Offset: 0x001D4718
		public static UnguidedWeapon smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			UnguidedWeapon result;
			try
			{
				int num;
				if (Information.IsNothing(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID")))
				{
					num = DBFunctions.smethod_12(Misc.smethod_44(xmlNode_0.ChildNodes, "Name").InnerText, GlobalVariables.ActiveUnitType.Weapon, scenario_0.method_39());
				}
				else
				{
					num = Conversions.ToInteger(Misc.smethod_44(xmlNode_0.ChildNodes, "DBID").InnerText);
				}
				Weapon theReferenceWeapon = scenario_0.method_87(num);
				UnguidedWeapon unguidedWeapon = new UnguidedWeapon(theReferenceWeapon, null, null, 0.0, 0.0, 0L);
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num2 = Class582.smethod_0(name);
						if (num2 <= 2532358002U)
						{
							if (num2 <= 1458105184U)
							{
								if (num2 <= 441941816U)
								{
									if (num2 != 266367750U)
									{
										if (num2 != 441941816U)
										{
											continue;
										}
										if (Operators.CompareString(name, "CurrentAltitude", false) == 0)
										{
											unguidedWeapon.vmethod_15(false, XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											unguidedWeapon.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num2 != 1029238175U)
								{
									if (num2 != 1458105184U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										unguidedWeapon.vmethod_0(xmlNode.InnerText);
										dictionary_0.Add(unguidedWeapon.string_0, unguidedWeapon);
										continue;
									}
									return (UnguidedWeapon)dictionary_0[xmlNode.InnerText];
								}
								else if (Operators.CompareString(name, "CEP", false) != 0)
								{
									continue;
								}
							}
							else if (num2 <= 1836990821U)
							{
								if (num2 != 1729717486U)
								{
									if (num2 != 1836990821U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Latitude", false) == 0)
									{
										unguidedWeapon.vmethod_31(null, (double)XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Longitude", false) == 0)
									{
										unguidedWeapon.vmethod_29(null, (double)XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num2 != 2338845032U)
							{
								if (num2 != 2532358002U)
								{
									continue;
								}
								if (Operators.CompareString(name, "FiringParent", false) == 0)
								{
									unguidedWeapon.string_4 = xmlNode.InnerText;
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Target", false) == 0)
								{
									unguidedWeapon.contact_0 = Contact.smethod_0(xmlNode.InnerText, ref dictionary_0);
									continue;
								}
								continue;
							}
						}
						else if (num2 <= 2883730117U)
						{
							if (num2 <= 2590053246U)
							{
								if (num2 != 2545405656U)
								{
									if (num2 != 2590053246U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Side", false) == 0)
									{
										unguidedWeapon.vmethod_8(false, Side.smethod_10(xmlNode.InnerText, ref dictionary_0));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LaunchPoint", false) == 0)
									{
										UnguidedWeapon unguidedWeapon2 = unguidedWeapon;
										XmlNode xmlNode2 = xmlNode.ChildNodes[0];
										unguidedWeapon2.geoPoint_0 = GeoPoint.smethod_0(ref xmlNode2, ref dictionary_0);
										continue;
									}
									continue;
								}
							}
							else if (num2 != 2698398137U)
							{
								if (num2 != 2883730117U)
								{
									continue;
								}
								if (Operators.CompareString(name, "CEP_Land", false) == 0)
								{
									unguidedWeapon.float_10 = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "TimeToDetonate", false) == 0)
								{
									unguidedWeapon.float_34 = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num2 <= 3089922411U)
						{
							if (num2 != 3041073015U)
							{
								if (num2 != 3089922411U)
								{
									continue;
								}
								if (Operators.CompareString(name, "CEP_Surface", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "TimeToLive", false) == 0)
								{
									unguidedWeapon.float_33 = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num2 != 3283119613U)
						{
							if (num2 != 3644814505U)
							{
								if (num2 != 4152621540U)
								{
									continue;
								}
								if (Operators.CompareString(name, "CurrentHeading", false) == 0)
								{
									unguidedWeapon.vmethod_10(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "ImpactAltitude", false) == 0)
								{
									unguidedWeapon.vmethod_17(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
							{
								unguidedWeapon.vmethod_41(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						unguidedWeapon.float_9 = XmlConvert.ToSingle(xmlNode.InnerText);
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
				result = unguidedWeapon;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100853", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0000D39E File Offset: 0x0000B59E
		private UnguidedWeapon()
		{
			this.warhead_0 = new Warhead[0];
			this.struct36_0 = default(Weapon.Struct36);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0000D3BE File Offset: 0x0000B5BE
		public Weapon method_61()
		{
			return this.weapon_0;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000D3C6 File Offset: 0x0000B5C6
		public float method_62()
		{
			return this.float_34;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0000D3CE File Offset: 0x0000B5CE
		public Weapon._WeaponType method_63()
		{
			return this._WeaponType_0;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x001D6A5C File Offset: 0x001D4C5C
		public bool method_64()
		{
			return this.method_65() || this.method_63() == Weapon._WeaponType.DepthCharge;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x001D6A8C File Offset: 0x001D4C8C
		public bool method_65()
		{
			Weapon._WeaponType weaponType = this.method_63();
			return weaponType - Weapon._WeaponType.BottomMine <= 4;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x001D6AB4 File Offset: 0x001D4CB4
		public Class316 method_66(Scenario scenario_0)
		{
			Side[] array = scenario_0.method_44();
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					foreach (Class316 @class in array[i].class316_0)
					{
						if (Enumerable.Contains<string>(@class.string_2, this.string_0))
						{
							return @class;
						}
					}
				}
				return null;
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x001D6B14 File Offset: 0x001D4D14
		public Class316.Class273 method_67(Scenario scenario_0)
		{
			checked
			{
				if (!Information.IsNothing(this.activeUnit_0))
				{
					Side[] array = scenario_0.method_44();
					for (int i = 0; i < array.Length; i++)
					{
						foreach (Class316 @class in array[i].class316_0)
						{
							if (Enumerable.Contains<string>(@class.string_2, this.string_0))
							{
								foreach (Class316.Class273 class2 in @class.class273_0)
								{
									if (Operators.CompareString(class2.string_0, this.activeUnit_0.string_0, false) == 0)
									{
										return class2;
									}
								}
							}
						}
					}
				}
				return null;
			}
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x001D6BC4 File Offset: 0x001D4DC4
		public UnguidedWeapon(Weapon theReferenceWeapon, Contact theTarget, ActiveUnit FiringUnit, double theLatitude, double theLongitude, long ArmDelay_Sec = 0L)
		{
			this.warhead_0 = new Warhead[0];
			this.struct36_0 = default(Weapon.Struct36);
			try
			{
				this.int_0 = theReferenceWeapon.DBID;
				this.weapon_0 = theReferenceWeapon;
				this.string_2 = theReferenceWeapon.string_2;
				this.Name = theReferenceWeapon.Name;
				this._WeaponType_0 = theReferenceWeapon.method_167();
				this.float_11 = theReferenceWeapon.float_27;
				this.float_12 = theReferenceWeapon.method_145();
				this.float_14 = (float)theReferenceWeapon.int_14;
				this.float_15 = (float)theReferenceWeapon.int_15;
				this.float_16 = (float)theReferenceWeapon.int_16;
				this.float_13 = (float)theReferenceWeapon.int_13;
				this.float_17 = theReferenceWeapon.float_29;
				this.float_18 = theReferenceWeapon.float_30;
				this.float_19 = theReferenceWeapon.float_31;
				this.float_20 = theReferenceWeapon.float_32;
				this.float_21 = theReferenceWeapon.float_33;
				this.float_22 = theReferenceWeapon.float_34;
				this.float_23 = theReferenceWeapon.float_35;
				this.float_24 = theReferenceWeapon.float_36;
				this.float_26 = theReferenceWeapon.float_40;
				this.float_25 = theReferenceWeapon.float_39;
				this.float_30 = theReferenceWeapon.float_44;
				this.float_29 = theReferenceWeapon.float_43;
				this.float_28 = theReferenceWeapon.float_42;
				this.float_27 = theReferenceWeapon.float_41;
				this.float_32 = theReferenceWeapon.float_46;
				this.float_31 = theReferenceWeapon.float_45;
				this.float_10 = (float)theReferenceWeapon.method_174();
				this.float_9 = (float)theReferenceWeapon.method_172();
				if (ArmDelay_Sec == 0L)
				{
					this.float_34 = theReferenceWeapon.float_50;
				}
				else
				{
					this.float_34 = (float)ArmDelay_Sec;
				}
				if (!Information.IsNothing(FiringUnit))
				{
					this.string_4 = FiringUnit.string_0;
				}
				if (this._WeaponType_0 == Weapon._WeaponType.Laser)
				{
					this.float_34 = 2f;
				}
				DBFunctions.smethod_65(ref theReferenceWeapon, ref this.struct36_0);
				DBFunctions.smethod_88(ref this.warhead_0, ref theReferenceWeapon);
				this.contact_0 = theTarget;
				if (!Information.IsNothing(FiringUnit) && !Information.IsNothing(theTarget))
				{
					float num = FiringUnit.vmethod_40();
					double num2 = (double)GameGeneral.smethod_5().Next(95, 106) / 100.0;
					Weapon._WeaponType weaponType_ = this._WeaponType_0;
					switch (weaponType_)
					{
					case Weapon._WeaponType.Rocket:
						switch (theTarget.contactType_0)
						{
						case Contact_Base.ContactType.Air:
						case Contact_Base.ContactType.Missile:
						case Contact_Base.ContactType.Orbital:
							this.vmethod_41((float)((double)(num + this.float_17 * 100f) * num2));
							break;
						case Contact_Base.ContactType.Surface:
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Facility_Mobile:
							this.vmethod_41((float)((double)(num + this.float_19 * 100f) * num2));
							break;
						default:
							this.vmethod_41((float)((double)(num + this.float_23 * 100f) * num2));
							break;
						}
						break;
					case Weapon._WeaponType.IronBomb:
						if (this.struct36_0.bool_48)
						{
							this.vmethod_41((float)((double)num * 0.4 * num2));
						}
						else
						{
							this.vmethod_41((float)((double)num * 0.9 * num2));
						}
						break;
					case Weapon._WeaponType.Gun:
					{
						double num3 = UnguidedWeapon.smethod_4(theTarget.contactType_0, this.method_61().method_159(), this.method_71()) * 1.94384;
						this.vmethod_41((float)((double)num + num3 * num2));
						Warhead.WarheadType warheadType_ = this.warhead_0[0].warheadType_0;
						if (warheadType_ == Warhead.WarheadType.ArmorPiercing || warheadType_ == Warhead.WarheadType.LongRodPenetrator)
						{
							this.vmethod_41((float)((double)(this.vmethod_40() * 2f) * num2));
						}
						break;
					}
					default:
						if (weaponType_ == Weapon._WeaponType.DepthCharge)
						{
							if (theTarget.bool_17)
							{
								this.vmethod_41((float)((double)(num / 2f + theTarget.vmethod_40() * 2f) + (double)(this.float_23 * 5f) * num2));
							}
							else
							{
								this.vmethod_41((float)((double)(num / 2f) + (double)(this.float_23 * 5f) * num2));
							}
						}
						break;
					}
				}
				if (Information.IsNothing(FiringUnit))
				{
					this.geoPoint_0 = new GeoPoint(theLongitude, theLatitude, 0f);
				}
				else
				{
					this.geoPoint_0 = new GeoPoint(theLongitude, theLatitude, FiringUnit.vmethod_14(false));
				}
				this.vmethod_31(null, theLatitude);
				this.vmethod_29(null, theLongitude);
				if (!Information.IsNothing(theTarget))
				{
					if (this.method_63() == Weapon._WeaponType.IronBomb && !Information.IsNothing(FiringUnit) && !Information.IsNothing(theTarget))
					{
						float num4 = Math.Abs(FiringUnit.vmethod_14(false) - theTarget.vmethod_14(false));
						float num5;
						if (num4 > 5000f)
						{
							num5 = 33f + (num4 - 5000f) / 300f;
						}
						else
						{
							num5 = (float)Math.Sqrt((double)num4 / 4.5);
						}
						this.float_34 = Math.Max(num5, this.float_34);
						if (num5 > 0f)
						{
							this.vmethod_41(Math.Min(FiringUnit.vmethod_40() - 10f, 3600f * FiringUnit.method_36(theTarget) / num5));
						}
						this.float_33 = this.float_34 + 1f;
					}
					else
					{
						double val;
						if (theTarget.bool_17 && theTarget.vmethod_40() > 0f)
						{
							val = 3600.0 * this.method_69() * 2.0 / (double)this.vmethod_40();
						}
						else
						{
							val = 3600.0 * this.method_69() / (double)this.vmethod_40();
						}
						this.float_33 = (float)Math.Max(val, (double)(this.method_62() + 1f));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100854", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x001D7198 File Offset: 0x001D5398
		public float method_68()
		{
			float result;
			if (this.warhead_0.Length == 0)
			{
				result = 0f;
			}
			else if (this.warhead_0[0].method_13())
			{
				result = 800f;
			}
			else
			{
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000D3D6 File Offset: 0x0000B5D6
		private double method_69()
		{
			return (double)Math.Max(this.float_17, Math.Max(this.float_19, Math.Max(this.float_21, this.float_23)));
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x001D71D8 File Offset: 0x001D53D8
		public static string smethod_3(ref UnguidedWeapon unguidedWeapon_0, double double_2, double double_3, float float_36, Scenario scenario_0)
		{
			string result;
			try
			{
				if (float_36 > 0f)
				{
					result = "Cannot lay naval mines over land!";
				}
				else
				{
					switch (unguidedWeapon_0.method_63())
					{
					case Weapon._WeaponType.BottomMine:
						if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.method_39()))
						{
							if (float_36 < unguidedWeapon_0.float_31)
							{
								if (Class570.class280_0.method_12())
								{
									return string.Concat(new string[]
									{
										"Water is too deep. Maximum mine depth is ",
										Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.float_31 * 3.28084f))),
										" ft while water depth is ",
										Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
										" ft."
									});
								}
								return string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.float_31)),
									" m while water depth is ",
									Conversions.ToString((int)Math.Round((double)float_36)),
									" m."
								});
							}
							else if (float_36 > -5f)
							{
								if (Class570.class280_0.method_12())
								{
									return string.Concat(new string[]
									{
										"Water is too shallow. Minimum mine depth is ",
										Conversions.ToString(16),
										" ft while sea depth is ",
										Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
										" ft."
									});
								}
								return string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString(5),
									" m while sea depth is ",
									Conversions.ToString((int)Math.Round((double)float_36)),
									" m."
								});
							}
						}
						else if (float_36 < unguidedWeapon_0.float_27)
						{
							if (Class570.class280_0.method_12())
							{
								return string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.float_27 * 3.28084f))),
									" ft while water depth is ",
									Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
									" ft."
								});
							}
							return string.Concat(new string[]
							{
								"Water is too deep. Maximum mine depth is ",
								Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.float_27)),
								" m while water depth is ",
								Conversions.ToString((int)Math.Round((double)float_36)),
								" m."
							});
						}
						else if (float_36 > -5f)
						{
							if (Class570.class280_0.method_12())
							{
								return string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString(16),
									" ft while sea depth is ",
									Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
									" ft."
								});
							}
							return string.Concat(new string[]
							{
								"Water is too shallow. Minimum mine depth is ",
								Conversions.ToString(5),
								" m while sea depth is ",
								Conversions.ToString((int)Math.Round((double)float_36)),
								" m."
							});
						}
						unguidedWeapon_0.vmethod_15(false, float_36);
						break;
					case Weapon._WeaponType.MooredMine:
					case Weapon._WeaponType.MovingMine:
					case Weapon._WeaponType.RisingMine:
						if (scenario_0.FeatureCompatibility.get_WeaponAGL_ASL(scenario_0.method_39()))
						{
							if (float_36 < unguidedWeapon_0.float_31)
							{
								if (Class570.class280_0.method_12())
								{
									return string.Concat(new string[]
									{
										"Water is too deep. Maximum mine depth is ",
										Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.float_31 * 3.28084f))),
										" ft while water depth is ",
										Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
										" ft."
									});
								}
								return string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.float_31)),
									" m while water depth is ",
									Conversions.ToString((int)Math.Round((double)float_36)),
									" m."
								});
							}
							else if (float_36 > unguidedWeapon_0.float_32)
							{
								if (Class570.class280_0.method_12())
								{
									return string.Concat(new string[]
									{
										"Water is too shallow. Minimum mine depth is ",
										Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.float_32 * 3.28084f))),
										" ft while sea depth is ",
										Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
										" ft."
									});
								}
								return string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.float_32)),
									" m while sea depth is ",
									Conversions.ToString((int)Math.Round((double)float_36)),
									" m."
								});
							}
						}
						else if (float_36 < unguidedWeapon_0.float_27)
						{
							if (Class570.class280_0.method_12())
							{
								return string.Concat(new string[]
								{
									"Water is too deep. Maximum mine depth is ",
									Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.float_27 * 3.28084f))),
									" ft while water depth is ",
									Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
									" ft."
								});
							}
							return string.Concat(new string[]
							{
								"Water is too deep. Maximum mine depth is ",
								Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.float_27)),
								" m while water depth is ",
								Conversions.ToString((int)Math.Round((double)float_36)),
								" m."
							});
						}
						else if (float_36 > unguidedWeapon_0.float_28)
						{
							if (Class570.class280_0.method_12())
							{
								return string.Concat(new string[]
								{
									"Water is too shallow. Minimum mine depth is ",
									Conversions.ToString((int)Math.Round((double)(unguidedWeapon_0.float_28 * 3.28084f))),
									" ft while sea depth is ",
									Conversions.ToString((int)Math.Round((double)(float_36 * 3.28084f))),
									" ft."
								});
							}
							return string.Concat(new string[]
							{
								"Water is too shallow. Minimum mine depth is ",
								Conversions.ToString((int)Math.Round((double)unguidedWeapon_0.float_32)),
								" m while sea depth is ",
								Conversions.ToString((int)Math.Round((double)float_36)),
								" m."
							});
						}
						unguidedWeapon_0.vmethod_15(false, (float)((double)float_36 + GameGeneral.smethod_5().NextDouble() * (double)(-(double)float_36) - 5.0));
						break;
					case Weapon._WeaponType.FloatingMine:
						unguidedWeapon_0.vmethod_15(false, 0f);
						break;
					}
					unguidedWeapon_0.vmethod_31(null, double_2);
					unguidedWeapon_0.vmethod_29(null, double_3);
					result = "OK";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100855", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = "Can not lay mine here (Error!)";
			}
			return result;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x001D78F4 File Offset: 0x001D5AF4
		public void method_70(Scenario scenario_0)
		{
			try
			{
				float theAltitude;
				if (this.method_61().method_191())
				{
					if (this.method_63() == Weapon._WeaponType.DepthCharge)
					{
						if (!Information.IsNothing(this.method_61().vmethod_142().vmethod_3()) && (this.method_61().vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint || this.method_61().vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint))
						{
							theAltitude = (float)Math.Max(base.method_9(false, false, false), -300);
						}
						else if (!Information.IsNothing(this.contact_0) && (this.contact_0.contactType_0 == Contact_Base.ContactType.ActivationPoint || this.contact_0.contactType_0 == Contact_Base.ContactType.Aimpoint))
						{
							theAltitude = (float)Math.Max(base.method_9(false, false, false), -300);
						}
						else
						{
							theAltitude = this.vmethod_14(false);
						}
					}
					else
					{
						theAltitude = this.method_68() + (float)Math.Max(0, base.method_9(false, false, false));
					}
				}
				else
				{
					theAltitude = this.vmethod_14(false);
				}
				new Explosion(ref scenario_0, this.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null), this.vmethod_30(null), this.vmethod_9(), theAltitude, this.method_63(), this.warhead_0[0].float_0, this.warhead_0[0].float_0, this.warhead_0[0].warheadType_0, this.warhead_0[0].enum126_0, null, null, this.method_58(), null, null, 0, 0, 0, 0f, 0);
				this.method_75(ref scenario_0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100856", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x001D7AEC File Offset: 0x001D5CEC
		private bool method_71()
		{
			if (this.nullable_10 == null)
			{
				if (Information.IsNothing(this.method_58()) || Information.IsNothing(this.contact_0))
				{
					return false;
				}
				this.nullable_10 = new bool?((this.method_63() == Weapon._WeaponType.Gun || this.method_63() == Weapon._WeaponType.Rocket) && !this.method_58().bool_3 && !(this.contact_0.method_104() | this.contact_0.method_110()));
			}
			return this.nullable_10.Value;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x001D7B84 File Offset: 0x001D5D84
		private void method_72(Scenario scenario_0, float float_36)
		{
			this.method_82();
			this.vmethod_30(null);
			this.vmethod_28(null);
			double num = UnguidedWeapon.smethod_4(this.contact_0.contactType_0, this.method_61().method_159(), this.method_71());
			if (this.method_71())
			{
				this.float_33 = float.MaxValue;
				double num2 = (double)this.geoPoint_0.method_12(this.contact_0.vmethod_28(null), this.contact_0.vmethod_30(null));
				double num3 = num2 / (double)this.method_61().method_159();
				double double_ = 35.0 * num3;
				double num4 = Math.Pow(num, 2.0) * Math.Pow(Math2.smethod_1(double_), 2.0) / 19.62;
				double num5 = (double)this.vmethod_40() * Math2.smethod_2(double_);
				double value;
				double value2;
				Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref value, ref value2, num5 * (double)float_36 / 3600.0, (double)this.vmethod_9());
				this.vmethod_29(null, value);
				this.vmethod_31(null, value2);
				double num6 = num2 * 1852.0 / 2.0;
				double num7 = num4 / Math.Pow(num6, 2.0);
				double x = Math.Abs((double)(base.method_23(this.geoPoint_0) * 1852f) - num6);
				double num8 = -(num7 * Math.Pow(x, 2.0)) + num4;
				this.vmethod_15(false, (float)(num8 + (double)this.geoPoint_0.imethod_4()));
			}
			else
			{
				this.vmethod_48(float_36, false);
				float num9 = Math.Abs(this.geoPoint_0.imethod_4() - this.contact_0.vmethod_14(false));
				double num10 = (double)this.geoPoint_0.method_12(this.contact_0.vmethod_28(null), this.contact_0.vmethod_30(null));
				double num11 = (double)base.method_36(this.contact_0) / num10;
				if (this.contact_0.vmethod_14(false) > this.geoPoint_0.imethod_4())
				{
					this.vmethod_15(false, (float)((double)this.contact_0.vmethod_14(false) - (double)num9 * num11));
				}
				else
				{
					this.vmethod_15(false, (float)((double)this.contact_0.vmethod_14(false) + (double)num9 * num11));
				}
			}
			if (this.method_63() == Weapon._WeaponType.Gun)
			{
				double num12 = (double)(base.method_27(this.geoPoint_0) / this.method_61().method_159());
				double num13 = num * 1.94384;
				this.vmethod_41((float)(num13 * (0.34 + 0.67 * (1.0 - num12))));
			}
			this.method_84(scenario_0, false);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x001D7E80 File Offset: 0x001D6080
		public void method_73(ref Scenario scenario_0, float float_36, ref Random random_0)
		{
			try
			{
				if (this.method_65())
				{
					this.method_74(scenario_0, float_36, ref random_0);
				}
				else
				{
					if (this.float_34 > 0f)
					{
						this.float_34 -= float_36;
					}
					if (this.contact_0 != null)
					{
						if ((this.method_63() != Weapon._WeaponType.IronBomb && base.method_25(this.contact_0.vmethod_30(null), this.contact_0.vmethod_28(null)) * 2f < this.vmethod_40() / 3600f) || (this.method_63() == Weapon._WeaponType.IronBomb && this.float_34 <= 0f))
						{
							try
							{
								if (this.vmethod_13() < 0f)
								{
									this.vmethod_15(false, (float)base.method_9(false, false, false));
								}
								if (this.vmethod_14(false) < 0f)
								{
									this.vmethod_15(false, this.contact_0.vmethod_14(false));
								}
								this.method_77(this.contact_0.activeUnit_0, this.contact_0, ref scenario_0, ref random_0);
								this.method_75(ref scenario_0);
								goto IL_15C;
							}
							catch (Exception ex)
							{
								ex.Data.Add("Error at 200042", ex.Message);
								GameGeneral.smethod_25(ref ex);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								goto IL_15C;
							}
						}
						if (this.method_63() != Weapon._WeaponType.Laser)
						{
							this.method_72(scenario_0, float_36);
						}
						IL_15C:
						if (this._WeaponType_0 == Weapon._WeaponType.Laser && this.float_34 <= 0f)
						{
							this.method_77(this.contact_0.activeUnit_0, this.contact_0, ref scenario_0, ref random_0);
							this.method_75(ref scenario_0);
						}
					}
					else if (this.method_63() == Weapon._WeaponType.Gun)
					{
						this.method_70(scenario_0);
					}
					this.float_33 -= float_36;
					if (this.float_33 <= 0f)
					{
						this.method_75(ref scenario_0);
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100857", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x001D80CC File Offset: 0x001D62CC
		private void method_74(Scenario scenario_0, float float_36, ref Random random_0)
		{
			try
			{
				if (this.float_34 > 0f)
				{
					this.float_34 = Math.Max(0f, this.float_34 - float_36);
				}
				if (this.float_34 <= 0f)
				{
					this.float_35 -= float_36;
					ActiveUnit activeUnit = null;
					if (this.float_35 <= 0f)
					{
						bool flag = false;
						bool flag2 = false;
						if (scenario_0.CandidatesForDetectionByMines.Length != 0)
						{
							bool flag3 = true;
							bool flag4 = true;
							if (!Information.IsNothing(this.warhead_0[0].method_17(scenario_0)))
							{
								Weapon weapon = this.warhead_0[0].method_17(scenario_0);
								if (!weapon.method_196())
								{
									flag3 = false;
								}
								if (!weapon.method_197())
								{
									flag4 = false;
								}
							}
							int value;
							int value2;
							foreach (ActiveUnit activeUnit2 in scenario_0.CandidatesForDetectionByMines)
							{
								try
								{
									if (!activeUnit2.bool_6 || flag3)
									{
										if (activeUnit2.bool_5)
										{
											if (!flag4)
											{
												goto IL_365;
											}
											Submarine._SubmarineType submarineType_ = ((Submarine)activeUnit2)._SubmarineType_0;
											if (submarineType_ == Submarine._SubmarineType.SDV || submarineType_ - Submarine._SubmarineType.ROV <= 1 || submarineType_ - Submarine._SubmarineType.Biologics <= 1)
											{
												goto IL_365;
											}
										}
										double num = Math2.smethod_13((double)((float)((double)activeUnit2.vmethod_132(this.method_63(), false) / 1852.0)));
										if (this.method_63() == Weapon._WeaponType.RisingMine && !activeUnit2.vmethod_59())
										{
											Weapon weapon2 = this.warhead_0[0].method_17(activeUnit2.scenario_0);
											if (!Information.IsNothing(weapon2))
											{
												num = Math2.smethod_13((double)weapon2.method_159());
											}
										}
										int num2;
										if (activeUnit2.vmethod_59())
										{
											num2 = 5;
										}
										else
										{
											num2 = 1;
										}
										if (!activeUnit2.bool_3 && base.method_31(activeUnit2) <= num && (float)num2 < activeUnit2.vmethod_40() && (this.method_63() == Weapon._WeaponType.RisingMine || base.method_39(activeUnit2, this.vmethod_40(), this.vmethod_9()) < 0f))
										{
											flag = true;
											activeUnit = activeUnit2;
											value = (int)Math.Round((double)(base.method_36(activeUnit) * 1852f));
											value2 = (int)Math.Round((double)Math2.smethod_17(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null)));
											break;
										}
										try
										{
											foreach (Sensor sensor in activeUnit2.vmethod_95())
											{
												if (sensor.method_59(this) && GeoPoint.smethod_2(this.vmethod_30(null), this.vmethod_28(null), sensor.method_60(), false))
												{
													flag = true;
													flag2 = true;
													activeUnit = activeUnit2;
													value = (int)Math.Round((double)(base.method_36(activeUnit) * 1852f));
													value2 = (int)Math.Round((double)Math2.smethod_17(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null)));
													break;
												}
											}
										}
										finally
										{
											List<Sensor>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
									}
								}
								catch (Exception ex)
								{
									ex.Data.Add("Error at 200043", ex.Message);
									GameGeneral.smethod_25(ref ex);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
								IL_365:;
							}
							if (flag)
							{
								if (!Information.IsNothing(this.warhead_0[0].method_17(activeUnit.scenario_0)))
								{
									try
									{
										Contact contact = new Contact(activeUnit, 0);
										contact.vmethod_31(null, activeUnit.vmethod_30(null));
										contact.vmethod_29(null, activeUnit.vmethod_28(null));
										contact.contactType_0 = Contact_Base.ContactType.Aimpoint;
										Weapon weapon3 = Weapon.smethod_16(ref activeUnit.scenario_0, this.warhead_0[0].method_17(activeUnit.scenario_0).DBID, null);
										if (weapon3.bool_7)
										{
											this.method_76(ref weapon3, weapon3.DBID, ref contact, ActiveUnit.Throttle.Flank);
										}
										if (weapon3.method_167() == Weapon._WeaponType.Rocket)
										{
											GlobalVariables.ActiveUnitType activeUnitType = activeUnit.vmethod_56();
											if (activeUnitType != GlobalVariables.ActiveUnitType.Aircraft)
											{
												if (activeUnitType - GlobalVariables.ActiveUnitType.Ship > 1)
												{
													if (Debugger.IsAttached)
													{
														Debugger.Break();
													}
												}
												else if (flag2)
												{
													weapon3.vmethod_15(false, -1f);
													scenario_0.method_59(string.Concat(new string[]
													{
														"Underwater detonation! Bearing ",
														Conversions.ToString(value2),
														" - Range ",
														Conversions.ToString(value),
														"m from ",
														activeUnit.Name
													}), "Sonar transient", LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.string_0, activeUnit.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
													weapon3.method_223(weapon3.vmethod_30(null), weapon3.vmethod_28(null), 0f, ref random_0, true);
												}
												else
												{
													weapon3.vmethod_29(null, activeUnit.vmethod_28(null));
													weapon3.vmethod_31(null, activeUnit.vmethod_30(null));
													weapon3.vmethod_15(false, activeUnit.vmethod_14(false) - 1f);
													scenario_0.method_59("Underwater detonation! Right underneath " + activeUnit.Name, "Sonar transient", LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.string_0, activeUnit.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
													weapon3.method_270(activeUnit, null);
												}
											}
											else
											{
												weapon3.vmethod_15(false, -1f);
												scenario_0.method_59(string.Concat(new string[]
												{
													"Underwater detonation! Bearing ",
													Conversions.ToString(value2),
													" - Range ",
													Conversions.ToString(value),
													"m from ",
													activeUnit.Name
												}), "Sonar transient", LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.string_0, activeUnit.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
												weapon3.method_223(weapon3.vmethod_30(null), weapon3.vmethod_28(null), 0f, ref random_0, true);
											}
										}
										this.method_75(ref activeUnit.scenario_0);
										goto IL_769;
									}
									catch (Exception ex2)
									{
										ex2.Data.Add("Error at 200044", ex2.Message);
										GameGeneral.smethod_25(ref ex2);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										goto IL_769;
									}
								}
								scenario_0.method_59(string.Concat(new string[]
								{
									"Underwater detonation! Bearing ",
									Conversions.ToString(value2),
									" - Range ",
									Conversions.ToString(value),
									"m from ",
									activeUnit.Name
								}), "Sonar transient", LoggedMessage.MessageType.WeaponEndgame, 0, activeUnit.string_0, activeUnit.vmethod_7(false), new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								this.method_70(scenario_0);
							}
							IL_769:
							this.float_35 = (float)(random_0.NextDouble() * 3.0);
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100858", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x001D88F8 File Offset: 0x001D6AF8
		public void method_75(ref Scenario scenario_0)
		{
			scenario_0.vmethod_20().Remove(this.string_0);
			this.vmethod_7(false).method_84(ref scenario_0, ref this.string_0);
			foreach (IEventExporter eventExporter in scenario_0.method_6())
			{
				if (eventExporter.imethod_8() && eventExporter.imethod_20())
				{
					Dictionary<string, IEventExporter.EventNotificationParameter> dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(9);
					if (scenario_0.MonteCarloIteration > 0)
					{
						dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(scenario_0.method_0(), typeof(string), 500));
						dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(scenario_0.MonteCarloIteration, typeof(int), 0));
					}
					dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(scenario_0.TimelineID, typeof(string), 40));
					if (eventExporter.imethod_10())
					{
						dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().Subtract(scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
					}
					else
					{
						dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
					}
					dictionary.Add("UnitID", new IEventExporter.EventNotificationParameter(this.string_0, typeof(string), 40));
					dictionary.Add("UnitName", new IEventExporter.EventNotificationParameter(this.Name, typeof(string), 500));
					dictionary.Add("UnitClass", new IEventExporter.EventNotificationParameter(this.string_2, typeof(string), 500));
					dictionary.Add("UnitSide", new IEventExporter.EventNotificationParameter(this.vmethod_7(false).method_51(), typeof(string), 500));
					dictionary.Add("MiscInfo", new IEventExporter.EventNotificationParameter(string.Empty, typeof(string), 0));
					eventExporter.imethod_6(IEventExporter.ExportedEventType.UnitDestroyed, dictionary, scenario_0);
				}
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x001D8B48 File Offset: 0x001D6D48
		private void method_76(ref Weapon theWeapon, int WeaponID, ref Contact theTarget, ActiveUnit.Throttle ThrottleSetting = ActiveUnit.Throttle.Cruise)
		{
			if (!Information.IsNothing(theTarget.activeUnit_0))
			{
				try
				{
					Scenario scenario_ = theTarget.activeUnit_0.scenario_0;
					scenario_.UnitsAutoIncrement++;
					theWeapon.Name = theWeapon.Name + " #" + Conversions.ToString(scenario_.UnitsAutoIncrement);
					theWeapon.vmethod_8(false, this.vmethod_7(false));
					theWeapon.vmethod_142().vmethod_4(theTarget);
					theWeapon.vmethod_142().vmethod_8(theTarget.contactType_0);
					theWeapon.vmethod_29(null, this.vmethod_28(null));
					theWeapon.vmethod_31(null, this.vmethod_30(null));
					theWeapon.vmethod_15(true, this.vmethod_14(false));
					theWeapon.vmethod_134(ThrottleSetting, null);
					float num = (float)theWeapon.vmethod_143().vmethod_40(theWeapon.vmethod_14(false), ThrottleSetting, false);
					theWeapon.vmethod_71((float)theWeapon.vmethod_143().vmethod_40(theWeapon.vmethod_14(false), ThrottleSetting, false));
					theWeapon.vmethod_10(Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), theWeapon.vmethod_142().vmethod_3().vmethod_30(null), theWeapon.vmethod_142().vmethod_3().vmethod_28(null)));
					theWeapon.vmethod_69(ActiveUnit.Enum28.const_0, theWeapon.vmethod_9());
					if (theWeapon.bool_7)
					{
						foreach (Sensor sensor in theWeapon.vmethod_96())
						{
							if (sensor.method_58())
							{
								sensor.method_77();
							}
						}
					}
					theWeapon.geoPoint_0 = new GeoPoint(this.vmethod_28(null), this.vmethod_30(null), this.vmethod_14(false));
					scenario_.method_68(theWeapon);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100859", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x001D8DA4 File Offset: 0x001D6FA4
		private bool method_77(ActiveUnit activeUnit_1, Contact contact_1, ref Scenario scenario_0, ref Random random_0)
		{
			bool result;
			if (Information.IsNothing(activeUnit_1))
			{
				result = false;
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				bool flag = false;
				try
				{
					this.vmethod_15(false, this.method_68() + (float)Math.Max(base.method_9(false, false, false), 0));
					this.vmethod_17(this.vmethod_14(false));
					float num;
					if (!activeUnit_1.bool_2 && !activeUnit_1.bool_3)
					{
						if (!activeUnit_1.bool_5)
						{
							return this.method_80(activeUnit_1, contact_1, ref scenario_0, ref random_0);
						}
						if (!this.bool_7)
						{
							return this.method_80(activeUnit_1, contact_1, ref scenario_0, ref random_0);
						}
						num = this.float_16;
						if (num == 0f && activeUnit_1.vmethod_14(false) == 0f)
						{
							num = this.float_14;
						}
					}
					else
					{
						num = this.float_13;
					}
					Weapon._WeaponType weaponType = this.method_61().method_167();
					if (weaponType == Weapon._WeaponType.Gun)
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							"Gun (",
							this.string_2,
							") is attacking ",
							activeUnit_1.Name,
							" with a base-Ph of ",
							Conversions.ToString(Math.Round((double)num, 1)),
							"%. "
						}));
					}
					else
					{
						stringBuilder.Append(string.Concat(new string[]
						{
							"Weapon: ",
							this.Name,
							" is attacking ",
							activeUnit_1.Name,
							" with a base-Ph of ",
							Conversions.ToString(Math.Round((double)num, 1)),
							"%. "
						}));
					}
					float num6;
					if (this.method_61().method_167() != Weapon._WeaponType.Laser)
					{
						double num2 = (double)base.method_27(this.geoPoint_0);
						if (num2 > this.method_79(activeUnit_1) / 2.0)
						{
							double num3 = Math.Min(1.0, num2 / 2.0 / this.method_79(activeUnit_1));
							num -= (float)((double)(num / 2f) * num3);
						}
						stringBuilder.Append("Base-Ph adjusted for distance: " + Conversions.ToString(Math.Round((double)num, 1)) + "%. ");
						if (activeUnit_1.bool_3)
						{
							if (activeUnit_1.bool_24 | activeUnit_1.method_82())
							{
								return true;
							}
							if (((Aircraft)activeUnit_1).int_6 > 0 && ((Aircraft)activeUnit_1).float_25 > 0f)
							{
								float num4 = ((Aircraft)activeUnit_1).method_159().method_22(stringBuilder);
								float num5 = base.method_46(activeUnit_1, false);
								if (num5 < 345f && num5 > 15f)
								{
									if ((num5 >= 15f && num5 <= 60f) || (num5 <= 345f && num5 >= 300f))
									{
										num4 = (float)((double)num4 * 0.7);
										stringBuilder.Append("Agility adjusted for forward-oblique impact effect: " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
									}
									else if ((num5 >= 60f && num5 <= 110f) || (num5 <= 300f && num5 >= 250f))
									{
										num4 = num4;
										stringBuilder.Append("High-deflection impact (no effect on agility). ");
									}
									else if ((num5 >= 110f && num5 <= 165f) || (num5 <= 250f && num5 >= 195f))
									{
										num4 = (float)((double)num4 * 0.85);
										stringBuilder.Append("Agility adjusted for rear-oblique impact effect: " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
									}
									else
									{
										num4 = (float)((double)num4 * 0.5);
										stringBuilder.Append("Agility adjusted for tail-on impact effect: " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
									}
								}
								else
								{
									num4 = (float)((double)num4 * 0.6);
									stringBuilder.Append("Agility adjusted for head-on impact effect: " + Conversions.ToString(Math.Round((double)num4, 1)) + ". ");
								}
								num4 = (float)Math.Round((double)num4, 1);
								stringBuilder.Append("Final agility modifier: -" + Conversions.ToString((int)Math.Round((double)(num4 * 10f))) + "%. ");
								num6 = num - num4 * 10f;
							}
							else
							{
								num6 = num;
							}
						}
						else
						{
							num6 = num;
						}
						if (activeUnit_1.vmethod_14(false) > 0f && (activeUnit_1.bool_2 || activeUnit_1.bool_3) && !this.struct36_0.bool_9)
						{
							double num7 = Math.Round((double)this.method_61().method_272(activeUnit_1.vmethod_14(false)), 2);
							if (num7 > 0.0)
							{
								num6 = (float)((double)num6 - num7);
								stringBuilder.Append("Sea-skimmer modifier: -" + Conversions.ToString(num7) + "%. ");
							}
						}
						if (activeUnit_1.method_2())
						{
							GlobalVariables.TargetVisualSizeClass targetVisualSizeClass_ = this.contact_0.method_102(scenario_0);
							num6 = this.method_78((int)Math.Round((double)num6), activeUnit_1.vmethod_40(), targetVisualSizeClass_, stringBuilder);
							if (base.method_23(this.geoPoint_0) <= 2f)
							{
								Weapon weapon = (Weapon)activeUnit_1;
								if (!Information.IsNothing(weapon.vmethod_142().vmethod_3()) && weapon.method_36(weapon.vmethod_142().vmethod_3()) < 2f)
								{
									if (weapon.struct36_0.bool_54)
									{
										stringBuilder.Append("Target is missile with pop-up terminal manouver - hit probability reduced by 25%. ");
										num6 = (float)((double)num6 * 0.75);
									}
									else if (weapon.struct36_0.bool_55)
									{
										stringBuilder.Append("Target is missile with zig-zag terminal manouver - hit probability reduced by 33%. ");
										num6 = (float)((double)num6 * 0.66);
									}
									else if (weapon.struct36_0.bool_56)
									{
										stringBuilder.Append("Target is missile with random terminal manouver - hit probability reduced by 50%. ");
										num6 = (float)((double)num6 * 0.5);
									}
								}
							}
						}
					}
					else
					{
						num6 = num;
					}
					if (num6 < 0f)
					{
						num6 = 1f;
					}
					if (num6 > 99f)
					{
						num6 = 99f;
					}
					if (!float.IsNaN(num6))
					{
						stringBuilder.Append("Final Ph: " + Conversions.ToString((int)Math.Round((double)num6)) + "%. ");
					}
					float num8 = 0f;
					float num9 = 0f;
					int num10 = GameGeneral.smethod_5().Next(1, 101);
					if ((float)num10 <= num6)
					{
						stringBuilder.Append("Result: " + Conversions.ToString(num10) + " - HIT");
						flag = true;
					}
					else
					{
						stringBuilder.Append("Result: " + Conversions.ToString(num10) + " - MISS");
						if (this.warhead_0.Length > 0 && activeUnit_1.bool_8 && this.warhead_0[0].method_11())
						{
							num8 = (float)GameGeneral.smethod_5().Next(0, 359);
							num9 = (float)GameGeneral.smethod_5().Next(1, 50);
							stringBuilder.Append(" (Near miss: " + Conversions.ToString(num9) + "m)");
							if (!string.IsNullOrEmpty(this.string_4) && Information.IsNothing(this.method_58()))
							{
								ObservableDictionary<string, ActiveUnit> observableDictionary = this.method_61().scenario_0.vmethod_0();
								string key = this.string_4;
								ActiveUnit activeUnit_2 = this.method_58();
								observableDictionary.TryGetValue(key, ref activeUnit_2);
								this.method_59(activeUnit_2);
							}
							ActiveUnit_Damage activeUnit_Damage = activeUnit_1.vmethod_91();
							Weapon weapon2 = this.method_61();
							GeoPoint geoPoint = this.geoPoint_0;
							float float_ = num9;
							float float_2 = num8;
							ActiveUnit activeUnit_3 = this.method_58();
							double? nullable_ = null;
							double? nullable_2 = null;
							float? nullable_3 = null;
							string text = "";
							activeUnit_Damage.vmethod_10(weapon2, geoPoint, float_, float_2, activeUnit_3, nullable_, nullable_2, nullable_3, ref text);
						}
					}
					string messageSummary = string.Empty;
					if (flag)
					{
						messageSummary = this.Name + " impacts " + activeUnit_1.Name;
					}
					else
					{
						messageSummary = this.Name + " missed " + activeUnit_1.Name;
					}
					activeUnit_1.scenario_0.method_59(stringBuilder.ToString(), messageSummary, LoggedMessage.MessageType.WeaponEndgame, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					if (flag)
					{
						ActiveUnit activeUnit_2;
						if (!string.IsNullOrEmpty(this.string_4) && Information.IsNothing(this.method_58()))
						{
							ObservableDictionary<string, ActiveUnit> observableDictionary2 = this.method_61().scenario_0.vmethod_0();
							string key2 = this.string_4;
							activeUnit_2 = this.method_58();
							observableDictionary2.TryGetValue(key2, ref activeUnit_2);
							this.method_59(activeUnit_2);
						}
						float float_3 = num9;
						float float_4 = num8;
						activeUnit_2 = this.method_58();
						double? nullable_4 = null;
						double? nullable_5 = null;
						float? nullable_6 = null;
						string text = "";
						this.method_81(activeUnit_1, float_3, float_4, ref activeUnit_2, nullable_4, nullable_5, nullable_6, ref text);
						this.method_59(activeUnit_2);
					}
					this.method_83(activeUnit_1, flag, activeUnit_1.method_82(), stringBuilder, scenario_0);
					result = flag;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100860", "");
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

		// Token: 0x06001A14 RID: 6676 RVA: 0x001D9678 File Offset: 0x001D7878
		private float method_78(int int_1, float float_36, GlobalVariables.TargetVisualSizeClass targetVisualSizeClass_0, StringBuilder stringBuilder_0)
		{
			int num = 510;
			float result;
			try
			{
				float num2 = Math.Abs(30f * ((float_36 - (float)num) / (float)(this.method_61().int_20 - num)));
				num2 = Math.Min(30f, num2);
				stringBuilder_0.Append(" Target speed modifier: " + Conversions.ToString(-(int)Math.Round((double)num2)) + "%. ");
				float num3;
				if (targetVisualSizeClass_0 != GlobalVariables.TargetVisualSizeClass.VLarge)
				{
					switch (targetVisualSizeClass_0)
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
						num3 = 30f;
						break;
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						num3 = 21f;
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						num3 = 15f;
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						num3 = 9f;
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
						num3 = 3f;
						break;
					}
					stringBuilder_0.Append(" Target size modifier: " + Conversions.ToString(-(int)Math.Round((double)num3)) + "%. ");
				}
				result = Math.Max(1f, (float)int_1 - num2 - num3);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100861", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x001D97A8 File Offset: 0x001D79A8
		public static double smethod_4(Contact_Base.ContactType contactType_0, float float_36, bool bool_13)
		{
			double num = Math.Sqrt((double)(float_36 * 1852f) * 9.81 / Math.Sin(1.570796326794897));
			if (!bool_13)
			{
				num *= 3.0;
			}
			if (!Information.IsNothing(contactType_0) && contactType_0 <= Contact_Base.ContactType.Missile)
			{
				num = Math.Max(990.0, num);
			}
			return num;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x001D9810 File Offset: 0x001D7A10
		public double method_79(ActiveUnit activeUnit_1)
		{
			double result;
			if (!activeUnit_1.bool_3 && !activeUnit_1.method_2() && !activeUnit_1.method_3())
			{
				if (!activeUnit_1.bool_6 && !activeUnit_1.bool_8)
				{
					if (!activeUnit_1.bool_5 && !activeUnit_1.bool_7)
					{
						throw new NotImplementedException();
					}
					result = (double)this.float_23;
				}
				else
				{
					result = (double)this.float_19;
				}
			}
			else
			{
				result = (double)this.float_17;
			}
			return result;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x001D9878 File Offset: 0x001D7A78
		public bool method_80(ActiveUnit activeUnit_1, Contact contact_1, ref Scenario scenario_0, ref Random random_0)
		{
			bool result;
			try
			{
				UnguidedWeapon.Class393 @class = new UnguidedWeapon.Class393(@class);
				@class.unguidedWeapon_0 = this;
				double num;
				if (!activeUnit_1.bool_6 && (!activeUnit_1.bool_5 || !((Submarine)activeUnit_1).method_161()))
				{
					if (activeUnit_1.bool_8)
					{
						num = (double)this.float_15;
					}
					else if ((activeUnit_1.bool_5 && !((Submarine)activeUnit_1).method_161()) || activeUnit_1.bool_7)
					{
						num = (double)this.float_16;
					}
				}
				else
				{
					num = (double)this.float_14;
				}
				if (this.method_63() == Weapon._WeaponType.DepthCharge || (this.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon && this.warhead_0[0].method_17(scenario_0).method_167() == Weapon._WeaponType.DepthCharge))
				{
					if (this.float_9 == 0f)
					{
						num = 99.0;
						this.float_9 = 200f;
					}
					if (num < 85.0)
					{
						num = 85.0;
					}
				}
				bool flag = (double)random_0.Next(1, 101) < num;
				float num2;
				if (activeUnit_1.bool_8)
				{
					num2 = this.float_10;
				}
				else
				{
					num2 = this.float_9;
				}
				if (activeUnit_1.vmethod_40() > 0f && contact_1.method_57() > 0f)
				{
					if (activeUnit_1.bool_8)
					{
						contact_1.method_57();
						activeUnit_1.vmethod_40();
					}
					else
					{
						contact_1.method_57();
						activeUnit_1.vmethod_40();
					}
				}
				float num3 = (float)random_0.Next(0, 360);
				double num4 = random_0.NextDouble();
				float num5;
				if (num4 <= 0.5)
				{
					num5 = (float)((double)random_0.Next(0, 101) / 100.0 * (double)num2);
				}
				else if (num4 < 0.937)
				{
					num5 = (float)((double)num2 + (double)num2 * random_0.NextDouble());
				}
				else
				{
					num5 = (float)((double)(2f * num2) + (double)num2 * random_0.NextDouble());
				}
				double num6;
				double num7;
				if (activeUnit_1.method_6())
				{
					Mount mount = ((Facility)activeUnit_1).method_155();
					if (mount != null)
					{
						Class411.smethod_1(activeUnit_1.vmethod_28(null), activeUnit_1.vmethod_30(null), ref num6, ref num7, (double)(mount.method_27() / 1852f), (double)mount.method_26());
					}
					else
					{
						num7 = contact_1.vmethod_30(null);
						num6 = contact_1.vmethod_28(null);
					}
				}
				else
				{
					num7 = contact_1.vmethod_30(null);
					num6 = contact_1.vmethod_28(null);
				}
				@class.class316_0 = this.method_66(scenario_0);
				Class316.Class273 class2 = this.method_67(scenario_0);
				string text;
				if (class2 == null)
				{
					text = string.Empty;
				}
				else
				{
					text = class2.string_2;
				}
				if (@class.class316_0 != null && class2 != null && (this.method_63() == Weapon._WeaponType.IronBomb || this.method_63() == Weapon._WeaponType.Rocket))
				{
					if (class2.nullable_0 == null)
					{
						class2.nullable_0 = new int?(Enumerable.Count<UnguidedWeapon>(Enumerable.Where<UnguidedWeapon>(scenario_0.vmethod_20().Values, new Func<UnguidedWeapon, bool>(@class.method_0))));
						if (class2.nullable_0 == null)
						{
							class2.nullable_0 = new int?(1);
						}
					}
					int? num8 = class2.nullable_0;
					if (((num8 != null) ? new bool?(num8.GetValueOrDefault() < 2) : null).GetValueOrDefault())
					{
						double num9 = num7;
						double num10 = num6;
						double double_ = num10;
						double double_2 = num9;
						bool? hintIsOperating = null;
						double num11 = this.vmethod_28(hintIsOperating);
						bool? hintIsOperating2 = null;
						double num12 = this.vmethod_30(hintIsOperating2);
						Class411.smethod_1(double_, double_2, ref num11, ref num12, (double)(num5 / 1852f), (double)num3);
						this.vmethod_31(hintIsOperating2, num12);
						this.vmethod_29(hintIsOperating, num11);
					}
					else
					{
						if (class2.nullable_3 == null)
						{
							class2.nullable_3 = new int?(Class563.smethod_8((double)class2.nullable_0.Value / 2.0));
						}
						if (class2.nullable_1 == null)
						{
							class2.nullable_1 = new float?(this.vmethod_9());
						}
						if (class2.nullable_2 == null)
						{
							Weapon._WeaponType weaponType = this.method_63();
							switch (weaponType)
							{
							case Weapon._WeaponType.Rocket:
							case Weapon._WeaponType.Gun:
								break;
							case Weapon._WeaponType.IronBomb:
								break;
							default:
								if (weaponType != Weapon._WeaponType.DepthCharge)
								{
								}
								break;
							}
							if (!string.IsNullOrEmpty(this.string_4) && this.method_58() == null)
							{
								ObservableDictionary<string, ActiveUnit> observableDictionary = scenario_0.vmethod_0();
								string key = this.string_4;
								ActiveUnit activeUnit_2 = this.method_58();
								observableDictionary.TryGetValue(key, ref activeUnit_2);
								this.method_59(activeUnit_2);
							}
							if (this.method_58() != null && this.method_58().bool_3)
							{
								Aircraft._AircraftType aircraftType_ = ((Aircraft)this.method_58())._AircraftType_0;
								Weapon._WeaponType weaponType2 = this.method_63();
								float num13;
								if (weaponType2 != Weapon._WeaponType.IronBomb)
								{
									if (weaponType2 != Weapon._WeaponType.DepthCharge)
									{
										num13 = 9.144f;
										goto IL_509;
									}
								}
								if (aircraftType_ == Aircraft._AircraftType.Bomber)
								{
									num13 = 22.86f;
								}
								else
								{
									num13 = 15.24f;
								}
								IL_509:
								if (this.method_63() != Weapon._WeaponType.IronBomb)
								{
									if (this.method_63() != Weapon._WeaponType.DepthCharge)
									{
										if (class2.nullable_0.Value < 40)
										{
											class2.nullable_2 = new float?(30.48f);
											goto IL_648;
										}
										if (class2.nullable_0.Value < 80)
										{
											class2.nullable_2 = new float?(60.96f);
											goto IL_648;
										}
										class2.nullable_2 = new float?(91.44f);
										goto IL_648;
									}
								}
								if (aircraftType_ == Aircraft._AircraftType.Bomber)
								{
									if (class2.nullable_0.Value < 28)
									{
										class2.nullable_2 = new float?((float)class2.nullable_0.Value * num13);
									}
									else
									{
										class2.nullable_2 = new float?(609.60004f);
									}
								}
								else if (class2.nullable_0.Value < 8)
								{
									class2.nullable_2 = new float?((float)class2.nullable_0.Value * num13);
								}
								else if (class2.nullable_0.Value < 25)
								{
									class2.nullable_2 = new float?(91.44f);
								}
								else
								{
									class2.nullable_2 = new float?(182.88f);
								}
							}
							else
							{
								class2.nullable_2 = new float?(91.44f);
							}
						}
						IL_648:
						if (class2.geoPoint_0 == null)
						{
							class2.geoPoint_0 = new GeoPoint();
							class2.geoPoint_0.imethod_3(num7);
							class2.geoPoint_0.imethod_1(num6);
						}
						if (class2.geoPoint_1 == null)
						{
							class2.geoPoint_1 = new GeoPoint();
							double double_3 = class2.geoPoint_0.imethod_0();
							double double_4 = class2.geoPoint_0.imethod_2();
							GeoPoint geoPoint_;
							double num12 = (geoPoint_ = class2.geoPoint_1).imethod_0();
							GeoPoint geoPoint_2;
							double num11 = (geoPoint_2 = class2.geoPoint_1).imethod_2();
							Class411.smethod_1(double_3, double_4, ref num12, ref num11, (double)(num5 / 1852f), (double)num3);
							geoPoint_2.imethod_3(num11);
							geoPoint_.imethod_1(num12);
						}
						double num9;
						double num10;
						int ptr;
						if (this.method_63() != Weapon._WeaponType.IronBomb)
						{
							if (this.method_63() != Weapon._WeaponType.DepthCharge)
							{
								int num14 = class2.nullable_0.Value - class2.int_4;
								Class316.Class273 class3 = class2;
								ptr = ref class3.int_4;
								class3.int_4 = ptr + 1;
								num8 = class2.nullable_3;
								if (((num8 != null) ? new bool?(num8.GetValueOrDefault() == num14) : null).GetValueOrDefault())
								{
									num9 = class2.geoPoint_1.imethod_2();
									num10 = class2.geoPoint_1.imethod_0();
								}
								else
								{
									int i = num14;
									num8 = class2.nullable_3;
									if (((num8 != null) ? new bool?(i > num8.GetValueOrDefault()) : null).GetValueOrDefault())
									{
										float num15 = (float)(num14 - class2.nullable_3.Value);
										float? num16 = class2.nullable_2 / 2f;
										num8 = class2.nullable_3;
										float num17 = (num16 / ((num8 != null) ? new float?((float)num8.GetValueOrDefault()) : null)).Value;
										if (float.IsInfinity(num17) || float.IsNaN(num17))
										{
											num17 = 0f;
										}
										float num18 = num15 * num17;
										Class411.smethod_1(class2.geoPoint_1.imethod_0(), class2.geoPoint_1.imethod_2(), ref num10, ref num9, (double)(num18 / 1852f), (double)Math2.smethod_7(class2.nullable_1.Value + 180f));
									}
									else
									{
										float num19 = (float)(class2.nullable_0.Value - (num14 + class2.nullable_3.Value));
										float? num20 = class2.nullable_2 / 2f;
										num8 = class2.nullable_0.Value - 1 - class2.nullable_3;
										float num21 = (num20 / ((num8 != null) ? new float?((float)num8.GetValueOrDefault()) : null)).Value;
										if (float.IsInfinity(num21) || float.IsNaN(num21))
										{
											num21 = 0f;
										}
										float num22 = num19 * num21;
										Class411.smethod_1(class2.geoPoint_1.imethod_0(), class2.geoPoint_1.imethod_2(), ref num10, ref num9, (double)(num22 / 1852f), (double)Math2.smethod_7(class2.nullable_1.Value));
									}
								}
								if (random_0.Next(1, 4) > 1)
								{
									float num23 = (float)random_0.Next(0, 8);
									double double_5 = num10;
									double double_6 = num9;
									bool? hintIsOperating2 = null;
									double num11 = this.vmethod_28(hintIsOperating2);
									bool? hintIsOperating = null;
									double num12 = this.vmethod_30(hintIsOperating);
									Class411.smethod_1(double_5, double_6, ref num11, ref num12, (double)(num23 / 1852f), (double)num3);
									this.vmethod_31(hintIsOperating, num12);
									this.vmethod_29(hintIsOperating2, num11);
								}
								else
								{
									float num24 = (float)random_0.Next(7, 16);
									double double_7 = num10;
									double double_8 = num9;
									bool? hintIsOperating = null;
									double num12 = this.vmethod_28(hintIsOperating);
									bool? hintIsOperating2 = null;
									double num11 = this.vmethod_30(hintIsOperating2);
									Class411.smethod_1(double_7, double_8, ref num12, ref num11, (double)(num24 / 1852f), (double)num3);
									this.vmethod_31(hintIsOperating2, num11);
									this.vmethod_29(hintIsOperating, num12);
								}
								num5 = class2.geoPoint_0.method_12(this.vmethod_28(null), this.vmethod_30(null)) * 1852f;
								goto IL_104F;
							}
						}
						int num25 = class2.nullable_0.Value - class2.int_4;
						Class316.Class273 class4 = class2;
						ptr = ref class4.int_4;
						class4.int_4 = ptr + 1;
						num8 = class2.nullable_3;
						if (((num8 != null) ? new bool?(num8.GetValueOrDefault() == num25) : null).GetValueOrDefault())
						{
							this.vmethod_31(null, class2.geoPoint_1.imethod_2());
							this.vmethod_29(null, class2.geoPoint_1.imethod_0());
							num5 = class2.geoPoint_0.method_12(this.vmethod_28(null), this.vmethod_30(null)) * 1852f;
						}
						else
						{
							int i = num25;
							num8 = class2.nullable_3;
							if (((num8 != null) ? new bool?(i > num8.GetValueOrDefault()) : null).GetValueOrDefault())
							{
								float num26 = (float)(num25 - class2.nullable_3.Value);
								float? num16 = class2.nullable_2 / 2f;
								num8 = class2.nullable_3;
								float num27 = (num16 / ((num8 != null) ? new float?((float)num8.GetValueOrDefault()) : null)).Value;
								if (float.IsInfinity(num27) || float.IsNaN(num27))
								{
									num27 = 0f;
								}
								float num28 = num26 * num27;
								Class411.smethod_1(class2.geoPoint_1.imethod_0(), class2.geoPoint_1.imethod_2(), ref num10, ref num9, (double)(num28 / 1852f), (double)Math2.smethod_7(class2.nullable_1.Value + 180f));
								float num29 = (float)random_0.Next(0, (int)Math.Round((double)num27));
								double double_9 = num10;
								double double_10 = num9;
								bool? hintIsOperating2 = null;
								double num11 = this.vmethod_28(hintIsOperating2);
								bool? hintIsOperating = null;
								double num12 = this.vmethod_30(hintIsOperating);
								Class411.smethod_1(double_9, double_10, ref num11, ref num12, (double)(num29 / 1852f), (double)num3);
								this.vmethod_31(hintIsOperating, num12);
								this.vmethod_29(hintIsOperating2, num11);
								num5 = class2.geoPoint_0.method_12(this.vmethod_28(null), this.vmethod_30(null)) * 1852f;
							}
							else
							{
								float num30 = (float)(class2.nullable_0.Value - (num25 + class2.nullable_3.Value));
								float? num20 = class2.nullable_2 / 2f;
								num8 = class2.nullable_0.Value - 1 - class2.nullable_3;
								float num31 = (num20 / ((num8 != null) ? new float?((float)num8.GetValueOrDefault()) : null)).Value;
								if (float.IsInfinity(num31) || float.IsNaN(num31))
								{
									num31 = 0f;
								}
								float num32 = num30 * num31;
								Class411.smethod_1(class2.geoPoint_1.imethod_0(), class2.geoPoint_1.imethod_2(), ref num10, ref num9, (double)(num32 / 1852f), (double)Math2.smethod_7(class2.nullable_1.Value));
								float num33 = (float)random_0.Next(0, (int)Math.Round((double)num31));
								double double_11 = num10;
								double double_12 = num9;
								bool? hintIsOperating = null;
								double num12 = this.vmethod_28(hintIsOperating);
								bool? hintIsOperating2 = null;
								double num11 = this.vmethod_30(hintIsOperating2);
								Class411.smethod_1(double_11, double_12, ref num12, ref num11, (double)(num33 / 1852f), (double)num3);
								this.vmethod_31(hintIsOperating2, num11);
								this.vmethod_29(hintIsOperating, num12);
								num5 = class2.geoPoint_0.method_12(this.vmethod_28(null), this.vmethod_30(null)) * 1852f;
							}
						}
					}
				}
				else if (num2 > 0f)
				{
					double double_13 = num6;
					double double_14 = num7;
					bool? hintIsOperating2 = null;
					double num11 = this.vmethod_28(hintIsOperating2);
					bool? hintIsOperating = null;
					double num12 = this.vmethod_30(hintIsOperating);
					Class411.smethod_1(double_13, double_14, ref num11, ref num12, (double)(num5 / 1852f), (double)num3);
					this.vmethod_31(hintIsOperating, num12);
					this.vmethod_29(hintIsOperating2, num11);
				}
				else
				{
					this.vmethod_31(null, num7);
					this.vmethod_29(null, num6);
				}
				IL_104F:
				base.method_51();
				if (!this.bool_7)
				{
					if (this.method_63() != Weapon._WeaponType.DepthCharge)
					{
						if (this.warhead_0[0].warheadType_0 != Warhead.WarheadType.Weapon || this.warhead_0[0].method_17(scenario_0).method_167() != Weapon._WeaponType.DepthCharge)
						{
							this.vmethod_15(false, (float)Math.Max(0, (int)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false)));
							goto IL_111B;
						}
					}
					this.vmethod_15(false, (float)Math.Max(-100.0, (double)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false) / 2.0));
				}
				IL_111B:
				this.vmethod_17(this.vmethod_14(false));
				bool flag2;
				if (flag2 = Weapon.smethod_22(activeUnit_1, this.vmethod_30(null), this.vmethod_28(null), num5, this.geoPoint_0, this.method_61().method_159(), true))
				{
					Weapon.smethod_23(scenario_0, this.method_61(), contact_1, false);
					num5 = 0f;
				}
				if (this.warhead_0.Length > 0 && this.warhead_0[0].method_13())
				{
					if (flag)
					{
						foreach (Warhead warhead in this.warhead_0)
						{
							if (warhead.method_13())
							{
								new Explosion(ref scenario_0, this.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null), this.vmethod_30(null), this.vmethod_9(), this.vmethod_14(false), this.method_63(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, null, null, warhead.short_1, warhead.short_2, (int)warhead.short_0, 0f, 0).vmethod_10(this.vmethod_9());
							}
						}
					}
					else
					{
						scenario_0.method_59("Weapon: " + this.Name + " has malfunctioned.", this.Name + " malfunctioned", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
					flag2 = true;
				}
				if (!this.warhead_0[0].method_11() && (this.warhead_0[0].warheadType_0 != Warhead.WarheadType.Weapon || !this.warhead_0[0].method_17(scenario_0).warhead_0[0].method_11()) && !this.warhead_0[0].method_12() && (this.warhead_0[0].warheadType_0 != Warhead.WarheadType.Weapon || !this.warhead_0[0].method_17(scenario_0).warhead_0[0].method_12()))
				{
					if (flag2)
					{
						ActiveUnit activeUnit_2;
						if (!string.IsNullOrEmpty(this.string_4) && Information.IsNothing(this.method_58()))
						{
							ObservableDictionary<string, ActiveUnit> observableDictionary2 = scenario_0.vmethod_0();
							string key2 = this.string_4;
							activeUnit_2 = this.method_58();
							observableDictionary2.TryGetValue(key2, ref activeUnit_2);
							this.method_59(activeUnit_2);
						}
						float float_ = num5;
						float float_2 = num3;
						activeUnit_2 = this.method_58();
						this.method_81(activeUnit_1, float_, float_2, ref activeUnit_2, null, null, null, ref text);
						this.method_59(activeUnit_2);
						if (!Information.IsNothing(class2) && !Information.IsNothing(class2.nullable_0) && !Information.IsNothing(class2.int_4) && !string.IsNullOrEmpty(text) && !Information.IsNothing(class2))
						{
							class2.string_2 = text;
						}
					}
					else if (num5 < 926f)
					{
						if (Class570.class280_0.method_12())
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" missed ",
								activeUnit_1.Name,
								" by ",
								Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num5 * 3.28084f)))),
								"ft"
							}), this.Name + " missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
						else
						{
							scenario_0.method_59(string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" missed ",
								activeUnit_1.Name,
								" by ",
								Conversions.ToString(Math.Max(1, (int)Math.Round((double)num5))),
								"m"
							}), this.Name + " missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
					}
					else
					{
						scenario_0.method_59(string.Concat(new string[]
						{
							"Weapon: ",
							this.Name,
							" missed ",
							activeUnit_1.Name,
							" by ",
							Conversions.ToString(Math.Round((double)(num5 / 1852f), 1)),
							"nm"
						}), this.Name + " missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
				}
				else if (!flag)
				{
					scenario_0.method_59("Weapon: " + this.Name + " has malfunctioned.", this.Name + " malfunctioned", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
				else
				{
					if (flag2)
					{
						ActiveUnit activeUnit_2;
						if (!string.IsNullOrEmpty(this.string_4) && Information.IsNothing(this.method_58()))
						{
							ObservableDictionary<string, ActiveUnit> observableDictionary3 = scenario_0.vmethod_0();
							string key3 = this.string_4;
							activeUnit_2 = this.method_58();
							observableDictionary3.TryGetValue(key3, ref activeUnit_2);
							this.method_59(activeUnit_2);
						}
						float float_3 = num5;
						float float_4 = num3;
						activeUnit_2 = this.method_58();
						this.method_81(activeUnit_1, float_3, float_4, ref activeUnit_2, new double?(this.vmethod_30(null)), new double?(this.vmethod_28(null)), null, ref text);
						this.method_59(activeUnit_2);
					}
					else
					{
						if (!activeUnit_1.method_6())
						{
							if (this.warhead_0[0].method_16(this.method_61(), activeUnit_1))
							{
								double num34 = Math.Sqrt(Math.Pow((double)Math.Abs(this.vmethod_14(false) - activeUnit_1.vmethod_14(false)), 2.0) + Math.Pow((double)num5, 2.0));
								string text2 = " airbursted off ";
								if (this.vmethod_27() || this.vmethod_26() || this.vmethod_13() == 0f)
								{
									text2 = " missed ";
								}
								if (Class570.class280_0.method_12())
								{
									scenario_0.method_59(string.Concat(new string[]
									{
										"Weapon: ",
										this.Name,
										text2,
										activeUnit_1.Name,
										" by ",
										Conversions.ToString(Math.Max(1, (int)Math.Round(num34 * 3.2808399200439453))),
										"ft"
									}), this.Name + " missed/airbursted", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
								else
								{
									scenario_0.method_59(string.Concat(new string[]
									{
										"Weapon: ",
										this.Name,
										text2,
										activeUnit_1.Name,
										" by ",
										Conversions.ToString(Math.Max(1, (int)Math.Round(num34))),
										"m"
									}), this.Name + " missed/airbursted", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
							}
							else if (num5 < 926f)
							{
								if (Class570.class280_0.method_12())
								{
									scenario_0.method_59(string.Concat(new string[]
									{
										"Weapon: ",
										this.Name,
										" missed ",
										activeUnit_1.Name,
										" by ",
										Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num5 * 3.28084f)))),
										"ft"
									}), this.Name + " missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
								else
								{
									scenario_0.method_59(string.Concat(new string[]
									{
										"Weapon: ",
										this.Name,
										" missed ",
										activeUnit_1.Name,
										" by ",
										Conversions.ToString(Math.Max(1, (int)Math.Round((double)num5))),
										"m"
									}), this.Name + " missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
							}
							else
							{
								scenario_0.method_59(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" missed ",
									activeUnit_1.Name,
									" by ",
									Conversions.ToString(Math.Round((double)(num5 / 1852f), 1)),
									"nm"
								}), this.Name + " missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
						}
						bool flag3 = (this.vmethod_14(false) >= 0f && (base.method_15() || this.method_63() == Weapon._WeaponType.IronBomb || this.method_63() == Weapon._WeaponType.GuidedWeapon || this.method_63() == Weapon._WeaponType.Gun || this.method_63() == Weapon._WeaponType.Rocket)) || this.warhead_0[0].method_14(scenario_0) || this.bool_7 || this.method_63() == Weapon._WeaponType.DepthCharge || (this.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon && this.warhead_0[0].method_17(scenario_0).method_167() == Weapon._WeaponType.DepthCharge) || this.warhead_0[0].method_16(this.method_61(), activeUnit_1);
						if (flag3)
						{
							if (!string.IsNullOrEmpty(this.string_4) && Information.IsNothing(this.method_58()))
							{
								ObservableDictionary<string, ActiveUnit> observableDictionary4 = scenario_0.vmethod_0();
								string key4 = this.string_4;
								ActiveUnit activeUnit_2 = this.method_58();
								observableDictionary4.TryGetValue(key4, ref activeUnit_2);
								this.method_59(activeUnit_2);
							}
							if (this.method_63() == Weapon._WeaponType.DepthCharge)
							{
								activeUnit_1.vmethod_91().vmethod_10(this.method_61(), this.geoPoint_0, num5, num3, this.method_58(), new double?(this.vmethod_30(null)), new double?(this.vmethod_28(null)), new float?(activeUnit_1.vmethod_14(false)), ref text);
							}
							else
							{
								activeUnit_1.vmethod_91().vmethod_10(this.method_61(), this.geoPoint_0, num5, num3, this.method_58(), new double?(this.vmethod_30(null)), new double?(this.vmethod_28(null)), new float?(this.vmethod_14(false)), ref text);
							}
						}
					}
					if (!Information.IsNothing(class2) && !Information.IsNothing(class2.nullable_0) && !Information.IsNothing(class2.int_4) && !string.IsNullOrEmpty(text) && !Information.IsNothing(class2))
					{
						class2.string_2 = text;
					}
				}
				this.method_83(activeUnit_1, flag2, activeUnit_1.method_82(), null, scenario_0);
				result = flag2;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100862", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x001DB5EC File Offset: 0x001D97EC
		private void method_81(ActiveUnit activeUnit_1, float float_36, float float_37, ref ActiveUnit activeUnit_2, double? nullable_11, double? nullable_12, float? nullable_13, ref string string_5)
		{
			try
			{
				if (!this.method_61().method_208())
				{
					Weapon.smethod_23(this.method_61().scenario_0, this.method_61(), activeUnit_1, true);
					new WeaponImpact(ref activeUnit_1.scenario_0, activeUnit_1.vmethod_28(null), activeUnit_1.vmethod_30(null), activeUnit_1.vmethod_14(false), WeaponImpact.Enum124.const_0, this.int_0);
				}
				if (!activeUnit_1.bool_3 && !activeUnit_1.bool_2)
				{
					if (activeUnit_1.bool_8)
					{
						if (!((Facility)activeUnit_1).bool_27)
						{
							activeUnit_1.scenario_0.method_59("Weapon: " + this.string_2 + " has impacted " + activeUnit_1.Name, this.string_2 + " impacted", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
					}
					else
					{
						activeUnit_1.scenario_0.method_59("Weapon: " + this.string_2 + " has impacted " + activeUnit_1.Name, this.string_2 + " impacted", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
				}
				if (!string.IsNullOrEmpty(this.string_4) && Information.IsNothing(activeUnit_2))
				{
					this.method_61().scenario_0.vmethod_0().TryGetValue(this.string_4, ref activeUnit_2);
				}
				activeUnit_1.vmethod_91().vmethod_10(this.method_61(), this.geoPoint_0, float_36, float_37, activeUnit_2, nullable_11, nullable_12, nullable_13, ref string_5);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100863", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x001DB7FC File Offset: 0x001D99FC
		private void method_82()
		{
			double? num = ActiveUnit_Navigator.smethod_5(this.vmethod_30(null), this.vmethod_28(null), (double)this.vmethod_9(), this.contact_0, this.vmethod_40());
			if (num == null)
			{
				ValueTuple<Geopoint_Struct, TimeSpan> valueTuple = ActiveUnit_Navigator.smethod_4(this, this.vmethod_40(), this.contact_0);
				if (!Information.IsNothing(valueTuple))
				{
					num = new double?((double)base.method_34(valueTuple.Item1.double_1, valueTuple.Item1.double_0));
				}
			}
			if (num != null)
			{
				this.vmethod_10((float)num.Value);
				return;
			}
			this.vmethod_10(Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), this.contact_0.vmethod_30(null), this.contact_0.vmethod_28(null)));
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x001DB8F8 File Offset: 0x001D9AF8
		private void method_83(ActiveUnit activeUnit_1, bool bool_13, bool bool_14, StringBuilder stringBuilder_0, Scenario scenario_0)
		{
			try
			{
				foreach (IEventExporter eventExporter in scenario_0.method_6())
				{
					if (eventExporter.imethod_8() && eventExporter.imethod_16())
					{
						Dictionary<string, IEventExporter.EventNotificationParameter> dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>();
						if (scenario_0.MonteCarloIteration > 0)
						{
							dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(scenario_0.method_0(), typeof(string), 500));
							dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(scenario_0.MonteCarloIteration, typeof(int), 0));
						}
						dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(scenario_0.TimelineID, typeof(string), 40));
						if (eventExporter.imethod_10())
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().Subtract(scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
						}
						else
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
						}
						dictionary.Add("WeaponID", new IEventExporter.EventNotificationParameter(this.string_0, typeof(string), 40));
						dictionary.Add("WeaponName", new IEventExporter.EventNotificationParameter(this.Name, typeof(string), 500));
						dictionary.Add("WeaponSide", new IEventExporter.EventNotificationParameter(this.vmethod_7(false).method_51(), typeof(string), 500));
						if (!Information.IsNothing(this.method_58()))
						{
							dictionary.Add("ParentFiringUnitID", new IEventExporter.EventNotificationParameter(this.method_58().string_0, typeof(string), 40));
							dictionary.Add("ParentFiringUnitName", new IEventExporter.EventNotificationParameter(this.method_58().Name, typeof(string), 500));
						}
						else
						{
							dictionary.Add("ParentFiringUnitID", new IEventExporter.EventNotificationParameter("-", typeof(string), 40));
							dictionary.Add("ParentFiringUnitName", new IEventExporter.EventNotificationParameter("-", typeof(string), 500));
						}
						dictionary.Add("TargetID", new IEventExporter.EventNotificationParameter(activeUnit_1.string_0, typeof(string), 40));
						dictionary.Add("TargetName", new IEventExporter.EventNotificationParameter(activeUnit_1.Name, typeof(string), 500));
						dictionary.Add("TargetSide", new IEventExporter.EventNotificationParameter(activeUnit_1.vmethod_7(false).method_51(), typeof(string), 500));
						dictionary.Add("TargetLongitude", new IEventExporter.EventNotificationParameter(activeUnit_1.vmethod_28(null), typeof(double), 0));
						dictionary.Add("TargetLatitude", new IEventExporter.EventNotificationParameter(activeUnit_1.vmethod_30(null), typeof(double), 0));
						dictionary.Add("TargetAltitude_ASL_m", new IEventExporter.EventNotificationParameter(activeUnit_1.vmethod_14(false), typeof(float), 0));
						dictionary.Add("TargetAltitude_AGL_m", new IEventExporter.EventNotificationParameter(activeUnit_1.vmethod_13(), typeof(float), 0));
						dictionary.Add("DistanceFromFiringUnit_Horiz", new IEventExporter.EventNotificationParameter(Conversions.ToString(Interaction.IIf(!Information.IsNothing(this.method_58()), base.method_36(this.method_58()), "")), typeof(float), 0));
						if (bool_13)
						{
							if (bool_14)
							{
								dictionary.Add("Result", new IEventExporter.EventNotificationParameter("KILL", typeof(string), 10));
							}
							else
							{
								dictionary.Add("Result", new IEventExporter.EventNotificationParameter("HIT", typeof(string), 10));
							}
						}
						else
						{
							dictionary.Add("Result", new IEventExporter.EventNotificationParameter("MISS", typeof(string), 10));
						}
						if (Information.IsNothing(stringBuilder_0))
						{
							dictionary.Add("EndgameMessage", new IEventExporter.EventNotificationParameter("-", typeof(string), 0));
						}
						else
						{
							dictionary.Add("EndgameMessage", new IEventExporter.EventNotificationParameter(stringBuilder_0.ToString(), typeof(string), 0));
						}
						eventExporter.imethod_6(IEventExporter.ExportedEventType.WeaponEndgame, dictionary, activeUnit_1.scenario_0);
					}
				}
				foreach (Interface8 @interface in Class409.interface8_0)
				{
					if (@interface.imethod_2())
					{
						Dictionary<string, Tuple<Type, string>> dictionary2 = new Dictionary<string, Tuple<Type, string>>();
						dictionary2.Add("TimelineID", new Tuple<Type, string>(typeof(string), scenario_0.TimelineID));
						dictionary2.Add("Time", new Tuple<Type, string>(typeof(DateTime), scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.method_31().Millisecond.ToString("D3")));
						dictionary2.Add("WeaponID", new Tuple<Type, string>(typeof(string), this.string_0));
						dictionary2.Add("WeaponCourse", new Tuple<Type, string>(typeof(string), this.vmethod_9().ToString()));
						dictionary2.Add("WeaponSpeed_Horiz", new Tuple<Type, string>(typeof(string), base.method_20().ToString()));
						dictionary2.Add("WeaponSpeed_Vert", new Tuple<Type, string>(typeof(string), base.method_21(scenario_0).ToString()));
						dictionary2.Add("Longitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(this.vmethod_28(null))));
						dictionary2.Add("Latitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(this.vmethod_30(null))));
						dictionary2.Add("Altitude", new Tuple<Type, string>(typeof(float), Conversions.ToString(activeUnit_1.vmethod_14(false))));
						if (!Information.IsNothing(this.method_58()))
						{
							dictionary2.Add("FiringUnitID", new Tuple<Type, string>(typeof(string), this.method_58().string_0));
						}
						dictionary2.Add("TargetID", new Tuple<Type, string>(typeof(string), activeUnit_1.string_0));
						if (bool_13)
						{
							if (bool_14)
							{
								dictionary2.Add("Result", new Tuple<Type, string>(typeof(string), "KILL"));
							}
							else
							{
								dictionary2.Add("Result", new Tuple<Type, string>(typeof(string), "HIT"));
							}
						}
						else
						{
							dictionary2.Add("Result", new Tuple<Type, string>(typeof(string), "MISS"));
						}
						dictionary2.Add("EventType", new Tuple<Type, string>(typeof(string), "WeaponImpact"));
						@interface.imethod_1(Interface8.Enum135.const_4, dictionary2, scenario_0);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101329", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x001DC0C0 File Offset: 0x001DA2C0
		public void method_84(Scenario scenario_0, bool bool_13)
		{
			if (this.bool_12 && Debugger.IsAttached)
			{
				Debugger.Break();
			}
			try
			{
				foreach (IEventExporter eventExporter in scenario_0.method_6())
				{
					if (eventExporter.imethod_8() && eventExporter.imethod_18())
					{
						this.bool_12 = true;
						if (this.vmethod_7(false) != null)
						{
							Dictionary<string, IEventExporter.EventNotificationParameter> dictionary;
							if (scenario_0.MonteCarloIteration > 0)
							{
								dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(17);
								dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(scenario_0.method_0(), typeof(string), 500));
								dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(scenario_0.MonteCarloIteration, typeof(int), 0));
							}
							else
							{
								dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>(15);
							}
							dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(scenario_0.TimelineID, typeof(string), 40));
							if (eventExporter.imethod_10())
							{
								dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().Subtract(scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
							}
							else
							{
								dictionary.Add("Time", new IEventExporter.EventNotificationParameter(scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
							}
							dictionary.Add("UnitID", new IEventExporter.EventNotificationParameter(this.string_0, typeof(string), 40));
							dictionary.Add("UnitDBID", new IEventExporter.EventNotificationParameter(this.int_0, typeof(string), 10));
							dictionary.Add("UnitName", new IEventExporter.EventNotificationParameter(this.Name, typeof(string), 500));
							dictionary.Add("UnitType", new IEventExporter.EventNotificationParameter(this.method_61().method_63(), typeof(string), 20));
							dictionary.Add("UnitClass", new IEventExporter.EventNotificationParameter(this.string_2, typeof(string), 500));
							dictionary.Add("UnitSide", new IEventExporter.EventNotificationParameter(this.vmethod_7(false).method_51(), typeof(string), 500));
							dictionary.Add("UnitLongitude", new IEventExporter.EventNotificationParameter(this.vmethod_28(null), typeof(double), 0));
							dictionary.Add("UnitLatitude", new IEventExporter.EventNotificationParameter(this.vmethod_30(null), typeof(double), 0));
							dictionary.Add("UnitCourse", new IEventExporter.EventNotificationParameter(this.vmethod_9(), typeof(float), 0));
							dictionary.Add("UnitSpeed_kts", new IEventExporter.EventNotificationParameter(this.vmethod_40(), typeof(float), 0));
							dictionary.Add("UnitAltitude_m", new IEventExporter.EventNotificationParameter(this.vmethod_14(false), typeof(float), 0));
							dictionary.Add("UnitAttitude_Pitch", new IEventExporter.EventNotificationParameter(this.vmethod_18(), typeof(float), 0));
							dictionary.Add("UnitAttitude_Roll", new IEventExporter.EventNotificationParameter(this.vmethod_20(), typeof(float), 0));
							eventExporter.imethod_6(IEventExporter.ExportedEventType.UnitPositions, dictionary, scenario_0);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
			finally
			{
				this.bool_12 = false;
			}
		}

		// Token: 0x040016E6 RID: 5862
		private int int_0;

		// Token: 0x040016E7 RID: 5863
		private Weapon weapon_0;

		// Token: 0x040016E8 RID: 5864
		private Weapon._WeaponType _WeaponType_0;

		// Token: 0x040016E9 RID: 5865
		public float float_9;

		// Token: 0x040016EA RID: 5866
		public float float_10;

		// Token: 0x040016EB RID: 5867
		public float float_11;

		// Token: 0x040016EC RID: 5868
		public float float_12;

		// Token: 0x040016ED RID: 5869
		public float float_13;

		// Token: 0x040016EE RID: 5870
		public float float_14;

		// Token: 0x040016EF RID: 5871
		public float float_15;

		// Token: 0x040016F0 RID: 5872
		public float float_16;

		// Token: 0x040016F1 RID: 5873
		public float float_17;

		// Token: 0x040016F2 RID: 5874
		public float float_18;

		// Token: 0x040016F3 RID: 5875
		public float float_19;

		// Token: 0x040016F4 RID: 5876
		public float float_20;

		// Token: 0x040016F5 RID: 5877
		public float float_21;

		// Token: 0x040016F6 RID: 5878
		public float float_22;

		// Token: 0x040016F7 RID: 5879
		public float float_23;

		// Token: 0x040016F8 RID: 5880
		public float float_24;

		// Token: 0x040016F9 RID: 5881
		public float float_25;

		// Token: 0x040016FA RID: 5882
		public float float_26;

		// Token: 0x040016FB RID: 5883
		public float float_27;

		// Token: 0x040016FC RID: 5884
		public float float_28;

		// Token: 0x040016FD RID: 5885
		public float float_29;

		// Token: 0x040016FE RID: 5886
		public float float_30;

		// Token: 0x040016FF RID: 5887
		public float float_31;

		// Token: 0x04001700 RID: 5888
		public float float_32;

		// Token: 0x04001701 RID: 5889
		public Warhead[] warhead_0;

		// Token: 0x04001702 RID: 5890
		public Weapon.Struct36 struct36_0;

		// Token: 0x04001703 RID: 5891
		public Contact contact_0;

		// Token: 0x04001704 RID: 5892
		private float float_33;

		// Token: 0x04001705 RID: 5893
		private GeoPoint geoPoint_0;

		// Token: 0x04001706 RID: 5894
		private float float_34;

		// Token: 0x04001707 RID: 5895
		private ActiveUnit activeUnit_0;

		// Token: 0x04001708 RID: 5896
		public string string_4;

		// Token: 0x04001709 RID: 5897
		private float float_35;

		// Token: 0x0400170A RID: 5898
		private bool? nullable_10;

		// Token: 0x0400170B RID: 5899
		private bool bool_12;

		// Token: 0x0200036E RID: 878
		[CompilerGenerated]
		internal sealed class Class393
		{
			// Token: 0x06001A1C RID: 6684 RVA: 0x0000D400 File Offset: 0x0000B600
			public Class393(UnguidedWeapon.Class393 class393_0)
			{
				if (class393_0 != null)
				{
					this.class316_0 = class393_0.class316_0;
				}
			}

			// Token: 0x06001A1D RID: 6685 RVA: 0x0000D417 File Offset: 0x0000B617
			internal bool method_0(UnguidedWeapon unguidedWeapon_1)
			{
				return Operators.CompareString(unguidedWeapon_1.string_4, this.unguidedWeapon_0.string_4, false) == 0 && Enumerable.Contains<string>(this.class316_0.string_2, unguidedWeapon_1.string_0);
			}

			// Token: 0x0400170C RID: 5900
			public Class316 class316_0;

			// Token: 0x0400170D RID: 5901
			public UnguidedWeapon unguidedWeapon_0;
		}
	}
}
