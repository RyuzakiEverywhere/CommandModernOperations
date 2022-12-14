using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x02000374 RID: 884
	public sealed class Warhead : Class310
	{
		// Token: 0x06001A82 RID: 6786 RVA: 0x0000944E File Offset: 0x0000764E
		public Warhead()
		{
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0000D760 File Offset: 0x0000B960
		public override void vmethod_1()
		{
			base.vmethod_1();
			if (!Information.IsNothing(this.weapon_0))
			{
				this.weapon_0.vmethod_1();
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x001DFFF4 File Offset: 0x001DE1F4
		public void method_8(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Warhead");
				xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
				xmlWriter_0.WriteElementString("ID", this.string_0);
				xmlWriter_0.WriteElementString("DP", XmlConvert.ToString(this.float_0));
				XmlWriter xmlWriter = xmlWriter_0;
				string localName = "Type";
				int num = (int)this.warheadType_0;
				xmlWriter.WriteElementString(localName, num.ToString());
				XmlWriter xmlWriter2 = xmlWriter_0;
				string localName2 = "ExpType";
				num = (int)this.enum126_0;
				xmlWriter2.WriteElementString(localName2, num.ToString());
				XmlWriter xmlWriter3 = xmlWriter_0;
				string localName3 = "Cal";
				num = (int)this.warheadCaliber_0;
				xmlWriter3.WriteElementString(localName3, num.ToString());
				xmlWriter_0.WriteElementString("NOW", this.short_0.ToString());
				xmlWriter_0.WriteElementString("CBDAL", this.short_1.ToString());
				xmlWriter_0.WriteElementString("CBDAW", this.short_2.ToString());
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100746", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x001E0130 File Offset: 0x001DE330
		public static Warhead smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			Warhead result;
			try
			{
				Warhead warhead = new Warhead();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1458105184U)
						{
							if (num <= 684613497U)
							{
								if (num != 593902289U)
								{
									if (num != 677790384U)
									{
										if (num == 684613497U)
										{
											if (Operators.CompareString(name, "DP", false) == 0)
											{
												warhead.float_0 = XmlConvert.ToSingle(xmlNode.InnerText);
											}
										}
									}
									else if (Operators.CompareString(name, "CBDAW", false) == 0)
									{
										warhead.short_2 = Conversions.ToShort(xmlNode.InnerText);
									}
								}
								else if (Operators.CompareString(name, "CBDAL", false) == 0)
								{
									warhead.short_1 = Conversions.ToShort(xmlNode.InnerText);
								}
							}
							else
							{
								if (num != 904230039U)
								{
									if (num != 1358876127U)
									{
										if (num != 1458105184U)
										{
											continue;
										}
										if (Operators.CompareString(name, "ID", false) != 0)
										{
											continue;
										}
										if (!dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											warhead.vmethod_0(xmlNode.InnerText);
											dictionary_0.Add(warhead.string_0, warhead);
											continue;
										}
										return (Warhead)dictionary_0[xmlNode.InnerText];
									}
									else if (Operators.CompareString(name, "Cal", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "Caliber", false) != 0)
								{
									continue;
								}
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									warhead.warheadCaliber_0 = (Warhead.WarheadCaliber)Conversions.ToShort(xmlNode.InnerText);
								}
								else
								{
									warhead.warheadCaliber_0 = (Warhead.WarheadCaliber)Enum.Parse(typeof(Warhead.WarheadCaliber), xmlNode.InnerText, true);
								}
							}
						}
						else if (num <= 2374875597U)
						{
							if (num != 1905141184U)
							{
								if (num != 2187602126U)
								{
									if (num != 2374875597U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ExplosivesType", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "DBID", false) == 0)
									{
										warhead.DBID = Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (Operators.CompareString(name, "ExpType", false) != 0)
							{
								continue;
							}
							warhead.enum126_0 = (Warhead.Enum126)Conversions.ToShort(xmlNode.InnerText);
						}
						else
						{
							if (num != 2867742231U)
							{
								if (num != 2938901124U)
								{
									if (num != 3512062061U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Type", false) != 0)
									{
										continue;
									}
									if (Versioned.IsNumeric(xmlNode.InnerText))
									{
										warhead.warheadType_0 = (Warhead.WarheadType)Conversions.ToInteger(xmlNode.InnerText);
										continue;
									}
									warhead.warheadType_0 = (Warhead.WarheadType)Enum.Parse(typeof(Warhead.WarheadType), xmlNode.InnerText, true);
									continue;
								}
								else if (Operators.CompareString(name, "NumberOfWarheads", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "NOW", false) != 0)
							{
								continue;
							}
							warhead.short_0 = (short)Conversions.ToInteger(xmlNode.InnerText);
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
				result = warhead;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100747", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Warhead();
			}
			return result;
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x001E04D8 File Offset: 0x001DE6D8
		public bool method_9()
		{
			Warhead.WarheadType warheadType = this.warheadType_0;
			if (warheadType <= Warhead.WarheadType.Chemical)
			{
				if (warheadType <= Warhead.WarheadType.SuperFrag)
				{
					if (warheadType == Warhead.WarheadType.Fragmentation || warheadType - Warhead.WarheadType.FAE <= 1)
					{
						goto IL_6F;
					}
				}
				else if (warheadType == Warhead.WarheadType.Nuclear || warheadType == Warhead.WarheadType.Chemical)
				{
					goto IL_6F;
				}
			}
			else if (warheadType <= Warhead.WarheadType.Cluster_Penetrator)
			{
				if (warheadType == Warhead.WarheadType.Biological || warheadType - Warhead.WarheadType.Cluster_AP <= 2)
				{
					goto IL_6F;
				}
			}
			else
			{
				if (warheadType == Warhead.WarheadType.Cluster_SmartSubs)
				{
					goto IL_6F;
				}
				if (warheadType == Warhead.WarheadType.AntiElectrical)
				{
					goto IL_6F;
				}
			}
			return false;
			IL_6F:
			return true;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x001E0558 File Offset: 0x001DE758
		public bool method_10()
		{
			bool result;
			if (this.method_9())
			{
				result = true;
			}
			else
			{
				Warhead.WarheadType warheadType = this.warheadType_0;
				if (warheadType <= Warhead.WarheadType.Chemical)
				{
					if (warheadType == Warhead.WarheadType.Fragmentation || warheadType - Warhead.WarheadType.FAE <= 1 || warheadType == Warhead.WarheadType.Chemical)
					{
						goto IL_57;
					}
				}
				else
				{
					if (warheadType - Warhead.WarheadType.Cluster_AP <= 2 || warheadType == Warhead.WarheadType.Cluster_SmartSubs)
					{
						goto IL_57;
					}
					if (warheadType == Warhead.WarheadType.AntiElectrical)
					{
						goto IL_57;
					}
				}
				return false;
				IL_57:
				result = true;
			}
			return result;
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x001E05C0 File Offset: 0x001DE7C0
		public bool method_11()
		{
			Warhead.WarheadType warheadType = this.warheadType_0;
			if (warheadType <= Warhead.WarheadType.DepthCharge)
			{
				switch (warheadType)
				{
				case Warhead.WarheadType.HE_BlastFrag:
				case Warhead.WarheadType.HEAT:
				case Warhead.WarheadType.Fragmentation:
				case Warhead.WarheadType.SemiAP:
				case Warhead.WarheadType.HESH:
				case Warhead.WarheadType.ContinuousRod:
				case Warhead.WarheadType.HardTargetPenetrator:
				case Warhead.WarheadType.FAE:
				case Warhead.WarheadType.Fragmentation_ABM:
					goto IL_6D;
				case Warhead.WarheadType.ArmorPiercing:
				case Warhead.WarheadType.Incendiary:
				case Warhead.WarheadType.SuperFrag:
					break;
				default:
					if (warheadType - Warhead.WarheadType.Torpedo <= 1)
					{
						goto IL_6D;
					}
					break;
				}
			}
			else if (warheadType == Warhead.WarheadType.Nuclear || warheadType - Warhead.WarheadType.Landmine_AP <= 1)
			{
				goto IL_6D;
			}
			return false;
			IL_6D:
			return true;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x001E0640 File Offset: 0x001DE840
		public bool method_12()
		{
			Warhead.WarheadType warheadType = this.warheadType_0;
			return warheadType == Warhead.WarheadType.Incendiary;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x001E0664 File Offset: 0x001DE864
		public bool method_13()
		{
			Warhead.WarheadType warheadType = this.warheadType_0;
			if (warheadType != Warhead.WarheadType.SuperFrag && warheadType - Warhead.WarheadType.Cluster_AP > 2)
			{
				if (warheadType != Warhead.WarheadType.Cluster_SmartSubs)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x001E069C File Offset: 0x001DE89C
		public bool method_14(Scenario scenario_0)
		{
			bool result;
			if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
			{
				result = true;
			}
			else if (this.warheadType_0 == Warhead.WarheadType.Weapon)
			{
				if (Information.IsNothing(this.weapon_0))
				{
					this.weapon_0 = scenario_0.method_87((int)Math.Round((double)this.float_0));
				}
				if (this.weapon_0.method_191())
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0000D780 File Offset: 0x0000B980
		public bool method_15()
		{
			return this.warheadType_0 == Warhead.WarheadType.EMP_Directed || this.warheadType_0 == Warhead.WarheadType.EMP_Omni;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x001E0700 File Offset: 0x001DE900
		public bool method_16(Weapon weapon_1, ActiveUnit activeUnit_0)
		{
			bool result;
			if (this.method_13())
			{
				result = true;
			}
			else if (Information.IsNothing(activeUnit_0))
			{
				result = false;
			}
			else if (weapon_1.method_2() && weapon_1.method_199() && !Information.IsNothing(activeUnit_0) && (activeUnit_0.bool_6 || activeUnit_0.bool_8) && activeUnit_0.vmethod_121() > GlobalVariables.TargetVisualSizeClass.VSmall)
			{
				result = false;
			}
			else
			{
				Warhead.WarheadType warheadType = this.warheadType_0;
				if (warheadType <= Warhead.WarheadType.SuperFrag)
				{
					if (warheadType == Warhead.WarheadType.Fragmentation || warheadType - Warhead.WarheadType.FAE <= 1)
					{
						goto IL_E2;
					}
				}
				else
				{
					if (warheadType - Warhead.WarheadType.Cluster_AP <= 2 || warheadType == Warhead.WarheadType.Cluster_SmartSubs)
					{
						goto IL_E2;
					}
					if (warheadType == Warhead.WarheadType.EMP_Omni)
					{
						goto IL_E2;
					}
				}
				if (this.method_14(weapon_1.scenario_0))
				{
					return !activeUnit_0.method_66();
				}
				if (weapon_1.method_199())
				{
					Warhead.WarheadType warheadType2 = this.warheadType_0;
					if (warheadType2 == Warhead.WarheadType.Fragmentation || warheadType2 == Warhead.WarheadType.ContinuousRod || warheadType2 == Warhead.WarheadType.Fragmentation_ABM)
					{
						return true;
					}
				}
				return false;
				IL_E2:
				result = true;
			}
			return result;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x001E07F4 File Offset: 0x001DE9F4
		public Weapon method_17(Scenario scenario_0)
		{
			Weapon result;
			if (this.warheadType_0 == Warhead.WarheadType.Weapon)
			{
				if (Information.IsNothing(this.weapon_0))
				{
					this.weapon_0 = scenario_0.method_87((int)Math.Round((double)this.float_0));
				}
				result = this.weapon_0;
			}
			return result;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x001E083C File Offset: 0x001DEA3C
		public Warhead.Enum125 method_18()
		{
			Warhead.WarheadType warheadType = this.warheadType_0;
			Warhead.Enum125 result;
			if (warheadType - Warhead.WarheadType.Laser_COIL > 1)
			{
				if (warheadType - Warhead.WarheadType.Laser_DeuteriumFluoride > 1)
				{
					result = Warhead.Enum125.const_0;
				}
				else
				{
					result = Warhead.Enum125.const_2;
				}
			}
			else
			{
				result = Warhead.Enum125.const_1;
			}
			return result;
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x001E0870 File Offset: 0x001DEA70
		public Warhead(string theName, float theDP, Warhead.WarheadType theType, Warhead.Enum126 theExplosivesType, Warhead.WarheadCaliber theCaliber, string theNumberOfWarheads = "")
		{
			try
			{
				this.Name = theName;
				this.float_0 = theDP;
				this.warheadType_0 = theType;
				this.enum126_0 = theExplosivesType;
				if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
				{
					this.float_0 = 1000000f * this.float_0;
				}
				this.warheadCaliber_0 = theCaliber;
				if (string.IsNullOrEmpty(theNumberOfWarheads))
				{
					this.short_0 = 1;
				}
				else
				{
					this.short_0 = (short)Conversions.ToInteger(theNumberOfWarheads);
				}
				if (this.warheadType_0 == Warhead.WarheadType.Cluster_AP || this.warheadType_0 == Warhead.WarheadType.Cluster_AT || this.warheadType_0 == Warhead.WarheadType.Cluster_Penetrator || this.warheadType_0 == Warhead.WarheadType.Cluster_SmartSubs || this.warheadType_0 == Warhead.WarheadType.SuperFrag)
				{
					this.float_0 *= (float)this.short_0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100748", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x001E0984 File Offset: 0x001DEB84
		public static double smethod_1(Class350 class350_0, double double_0, double double_1, float float_1)
		{
			double result;
			try
			{
				class350_0.vmethod_121();
				if (class350_0.bool_8 && class350_0.vmethod_99().Length > 0 && class350_0.vmethod_99()[0].method_31())
				{
					float num = Class437.smethod_3(class350_0.vmethod_9(), float_1);
					result = double_0 * 0.1 + double_0 * 0.9 * (1.0 - Math.Abs(Math.Sin((double)num * 3.14159265358979 / 180.0)));
				}
				else
				{
					float num2 = (float)((double)class350_0.vmethod_139() / double_1);
					if (num2 > 1f)
					{
						num2 = 1f;
					}
					result = double_0 * (double)num2;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100749", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.0;
			}
			return result;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x001E0A80 File Offset: 0x001DEC80
		public static float smethod_2(Mount mount_0, double double_0, int int_0, float float_1, double double_1, Warhead.WarheadType warheadType_1, Warhead.Enum126 enum126_1)
		{
			float result;
			try
			{
				int maxValue = (int)Math.Round(double_1 / (double)10f);
				bool flag;
				if (warheadType_1 == Warhead.WarheadType.Cluster_SmartSubs)
				{
					flag = (GameGeneral.smethod_5().Next(1, 101) > 30);
				}
				else
				{
					flag = (GameGeneral.smethod_5().Next(1, maxValue) <= int_0);
				}
				float num;
				if (flag)
				{
					num = float_1;
				}
				else
				{
					num = (float)(double_0 / double_1);
				}
				switch (enum126_1)
				{
				case Warhead.Enum126.const_37:
					num = (float)((double)num * 1.5);
					break;
				case Warhead.Enum126.const_38:
					num *= 2f;
					break;
				case Warhead.Enum126.const_39:
					num *= 3f;
					break;
				case Warhead.Enum126.const_40:
					num *= 4f;
					break;
				default:
					if (enum126_1 != Warhead.Enum126.const_41)
					{
						if (enum126_1 != Warhead.Enum126.const_42)
						{
						}
					}
					else
					{
						num *= 5f;
					}
					break;
				}
				num = (float)((double)num * ((double)GameGeneral.smethod_5().Next(8, 13) / 10.0));
				result = (float)Math.Min((double)(num * 100f), double_0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100750", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x001E0BC4 File Offset: 0x001DEDC4
		public static float smethod_3(double double_0, double double_1, double double_2, Warhead.WarheadType warheadType_1, double double_3, Weapon.Enum128 enum128_0, bool bool_12)
		{
			float result;
			try
			{
				if (warheadType_1 != Warhead.WarheadType.HE_BlastFrag)
				{
					if (warheadType_1 != Warhead.WarheadType.Fragmentation)
					{
						if (warheadType_1 != Warhead.WarheadType.Fragmentation_ABM)
						{
							return 0f;
						}
						double_3 *= 2.0;
					}
				}
				else
				{
					double_3 = double_3;
				}
				float num = Explosion.smethod_2(double_3, Weapon.Enum128.const_0);
				if (double_2 > (double)num)
				{
					result = 0f;
				}
				else
				{
					double num2 = Math.Pow((double)((float)(((double)num - double_2) / (double)num)), 2.0);
					if (bool_12 && Terrain.smethod_7(double_0, double_1, false) > 0)
					{
						switch (LandCover.smethod_1(double_0, double_1))
						{
						case LandCover.LandCoverType.Water:
						case LandCover.LandCoverType.Grasslands:
						case LandCover.LandCoverType.Permanent_wetlands:
						case LandCover.LandCoverType.SnowAndIce:
						case LandCover.LandCoverType.BarrenOrSparselyVegetated:
							break;
						case LandCover.LandCoverType.Evergreen_Needleleaf_forest:
						case LandCover.LandCoverType.Evergreen_Broadleaf_forest:
						case LandCover.LandCoverType.Deciduous_Needleleaf_forest:
						case LandCover.LandCoverType.Deciduous_Broadleaf_forest:
						case LandCover.LandCoverType.Mixed_forest:
							num2 *= 0.5;
							break;
						case LandCover.LandCoverType.Closed_shrublands:
						case LandCover.LandCoverType.Open_shrublands:
							num2 *= 0.75;
							break;
						case LandCover.LandCoverType.Woody_savannas:
						case LandCover.LandCoverType.Savannas:
							num2 *= 0.9;
							break;
						case LandCover.LandCoverType.Croplands:
						case LandCover.LandCoverType.CroplandNaturalVegetationMosaic:
							num2 *= 0.85;
							break;
						case LandCover.LandCoverType.UrbanAndBuiltUp:
							num2 *= 0.25;
							break;
						default:
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							break;
						}
					}
					double num3 = double_3 * num2;
					if (num3 > double_3)
					{
						num3 = double_3;
					}
					result = (float)num3;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100751", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x001E0D68 File Offset: 0x001DEF68
		public static float smethod_4(double double_0, double double_1, double double_2, double double_3, Warhead.WarheadType warheadType_1, double double_4, Weapon.Enum128 enum128_0, bool bool_12)
		{
			double num = 0.0;
			float result;
			try
			{
				double num2;
				if (warheadType_1 <= Warhead.WarheadType.HardTargetPenetrator)
				{
					switch (warheadType_1)
					{
					case Warhead.WarheadType.HE_BlastFrag:
						num2 = double_4;
						goto IL_90;
					case Warhead.WarheadType.ArmorPiercing:
					case Warhead.WarheadType.Incendiary:
						break;
					case Warhead.WarheadType.HEAT:
						num2 = double_4 / 5.0;
						goto IL_90;
					case Warhead.WarheadType.Fragmentation:
						num2 = double_4 / 3.0;
						goto IL_90;
					default:
						if (warheadType_1 == Warhead.WarheadType.HardTargetPenetrator)
						{
							num2 = double_4;
							goto IL_90;
						}
						break;
					}
				}
				else
				{
					if (warheadType_1 - Warhead.WarheadType.Torpedo <= 1)
					{
						num2 = double_4;
						goto IL_90;
					}
					if (warheadType_1 == Warhead.WarheadType.Nuclear)
					{
						num2 = double_4 / 2.0;
						goto IL_90;
					}
				}
				num2 = double_4;
				IL_90:
				num += num2;
				if (num == 0.0)
				{
					result = 0f;
				}
				else if (double_2 <= 0.0005399568034557236)
				{
					result = (float)num;
				}
				else
				{
					double num3 = (double)Explosion.smethod_1(num, enum128_0);
					if (double_2 > num3)
					{
						result = 0f;
					}
					else
					{
						double x = 1.0 - double_2 / num3;
						double num4;
						if (enum128_0 == Weapon.Enum128.const_2)
						{
							num4 = Math.Pow(x, 3.0);
						}
						else
						{
							num4 = Math.Pow(x, 2.0);
						}
						if (bool_12 && Terrain.smethod_7(double_0, double_1, false) > 0)
						{
							switch (LandCover.smethod_1(double_0, double_1))
							{
							case LandCover.LandCoverType.Water:
							case LandCover.LandCoverType.Grasslands:
							case LandCover.LandCoverType.Permanent_wetlands:
							case LandCover.LandCoverType.SnowAndIce:
							case LandCover.LandCoverType.BarrenOrSparselyVegetated:
								break;
							case LandCover.LandCoverType.Evergreen_Needleleaf_forest:
							case LandCover.LandCoverType.Evergreen_Broadleaf_forest:
							case LandCover.LandCoverType.Deciduous_Needleleaf_forest:
							case LandCover.LandCoverType.Deciduous_Broadleaf_forest:
							case LandCover.LandCoverType.Mixed_forest:
								num4 *= 0.5;
								break;
							case LandCover.LandCoverType.Closed_shrublands:
							case LandCover.LandCoverType.Open_shrublands:
								num4 *= 0.75;
								break;
							case LandCover.LandCoverType.Woody_savannas:
							case LandCover.LandCoverType.Savannas:
								num4 *= 0.9;
								break;
							case LandCover.LandCoverType.Croplands:
							case LandCover.LandCoverType.CroplandNaturalVegetationMosaic:
								num4 *= 0.85;
								break;
							case LandCover.LandCoverType.UrbanAndBuiltUp:
								num4 *= 0.25;
								break;
							default:
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								break;
							}
						}
						result = (float)Math.Min(num * num4, double_4);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100752", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x0400173C RID: 5948
		public int DBID;

		// Token: 0x0400173D RID: 5949
		public float float_0;

		// Token: 0x0400173E RID: 5950
		public Warhead.WarheadType warheadType_0;

		// Token: 0x0400173F RID: 5951
		public Warhead.Enum126 enum126_0;

		// Token: 0x04001740 RID: 5952
		public Warhead.WarheadCaliber warheadCaliber_0;

		// Token: 0x04001741 RID: 5953
		public short short_0;

		// Token: 0x04001742 RID: 5954
		public short short_1;

		// Token: 0x04001743 RID: 5955
		public short short_2;

		// Token: 0x04001744 RID: 5956
		public bool bool_11;

		// Token: 0x04001745 RID: 5957
		private Weapon weapon_0;

		// Token: 0x02000375 RID: 885
		public enum WarheadType
		{
			// Token: 0x04001747 RID: 5959
			None = 1001,
			// Token: 0x04001748 RID: 5960
			HE_BlastFrag = 2001,
			// Token: 0x04001749 RID: 5961
			ArmorPiercing,
			// Token: 0x0400174A RID: 5962
			HEAT,
			// Token: 0x0400174B RID: 5963
			Incendiary,
			// Token: 0x0400174C RID: 5964
			Fragmentation,
			// Token: 0x0400174D RID: 5965
			SemiAP,
			// Token: 0x0400174E RID: 5966
			HESH,
			// Token: 0x0400174F RID: 5967
			ContinuousRod,
			// Token: 0x04001750 RID: 5968
			HardTargetPenetrator,
			// Token: 0x04001751 RID: 5969
			FAE,
			// Token: 0x04001752 RID: 5970
			SuperFrag,
			// Token: 0x04001753 RID: 5971
			Fragmentation_ABM,
			// Token: 0x04001754 RID: 5972
			Torpedo = 3001,
			// Token: 0x04001755 RID: 5973
			DepthCharge,
			// Token: 0x04001756 RID: 5974
			Nuclear = 4001,
			// Token: 0x04001757 RID: 5975
			Chemical = 4011,
			// Token: 0x04001758 RID: 5976
			Biological = 4021,
			// Token: 0x04001759 RID: 5977
			Weapon = 5002,
			// Token: 0x0400175A RID: 5978
			Cluster_AP = 6001,
			// Token: 0x0400175B RID: 5979
			Cluster_AT,
			// Token: 0x0400175C RID: 5980
			Cluster_Penetrator,
			// Token: 0x0400175D RID: 5981
			Cluster_SmartSubs = 6012,
			// Token: 0x0400175E RID: 5982
			Landmine_AP = 7001,
			// Token: 0x0400175F RID: 5983
			Landmine_AT,
			// Token: 0x04001760 RID: 5984
			LongRodPenetrator = 8001,
			// Token: 0x04001761 RID: 5985
			AntiElectrical = 9001,
			// Token: 0x04001762 RID: 5986
			Leaflet,
			// Token: 0x04001763 RID: 5987
			Laser_COIL = 9101,
			// Token: 0x04001764 RID: 5988
			Laser_CarbonDioxide,
			// Token: 0x04001765 RID: 5989
			Laser_DeuteriumFluoride,
			// Token: 0x04001766 RID: 5990
			Laser_SolidStateFiber,
			// Token: 0x04001767 RID: 5991
			EMP_Directed = 9201,
			// Token: 0x04001768 RID: 5992
			EMP_Omni,
			// Token: 0x04001769 RID: 5993
			Kinetic = 9801
		}

		// Token: 0x02000376 RID: 886
		internal enum Enum125
		{
			// Token: 0x0400176B RID: 5995
			const_0,
			// Token: 0x0400176C RID: 5996
			const_1,
			// Token: 0x0400176D RID: 5997
			const_2
		}

		// Token: 0x02000377 RID: 887
		internal enum Enum126 : short
		{
			// Token: 0x0400176F RID: 5999
			const_0 = 1001,
			// Token: 0x04001770 RID: 6000
			const_1 = 2001,
			// Token: 0x04001771 RID: 6001
			const_2,
			// Token: 0x04001772 RID: 6002
			const_3,
			// Token: 0x04001773 RID: 6003
			const_4,
			// Token: 0x04001774 RID: 6004
			const_5,
			// Token: 0x04001775 RID: 6005
			const_6,
			// Token: 0x04001776 RID: 6006
			const_7,
			// Token: 0x04001777 RID: 6007
			const_8,
			// Token: 0x04001778 RID: 6008
			const_9,
			// Token: 0x04001779 RID: 6009
			const_10,
			// Token: 0x0400177A RID: 6010
			const_11,
			// Token: 0x0400177B RID: 6011
			const_12,
			// Token: 0x0400177C RID: 6012
			const_13,
			// Token: 0x0400177D RID: 6013
			const_14,
			// Token: 0x0400177E RID: 6014
			const_15,
			// Token: 0x0400177F RID: 6015
			const_16,
			// Token: 0x04001780 RID: 6016
			const_17,
			// Token: 0x04001781 RID: 6017
			const_18,
			// Token: 0x04001782 RID: 6018
			const_19,
			// Token: 0x04001783 RID: 6019
			const_20,
			// Token: 0x04001784 RID: 6020
			const_21,
			// Token: 0x04001785 RID: 6021
			const_22,
			// Token: 0x04001786 RID: 6022
			const_23,
			// Token: 0x04001787 RID: 6023
			const_24 = 2101,
			// Token: 0x04001788 RID: 6024
			const_25,
			// Token: 0x04001789 RID: 6025
			const_26,
			// Token: 0x0400178A RID: 6026
			const_27 = 2201,
			// Token: 0x0400178B RID: 6027
			const_28,
			// Token: 0x0400178C RID: 6028
			const_29,
			// Token: 0x0400178D RID: 6029
			const_30,
			// Token: 0x0400178E RID: 6030
			const_31 = 2301,
			// Token: 0x0400178F RID: 6031
			const_32 = 2401,
			// Token: 0x04001790 RID: 6032
			const_33 = 4001,
			// Token: 0x04001791 RID: 6033
			const_34 = 4011,
			// Token: 0x04001792 RID: 6034
			const_35,
			// Token: 0x04001793 RID: 6035
			const_36 = 6001,
			// Token: 0x04001794 RID: 6036
			const_37,
			// Token: 0x04001795 RID: 6037
			const_38,
			// Token: 0x04001796 RID: 6038
			const_39,
			// Token: 0x04001797 RID: 6039
			const_40,
			// Token: 0x04001798 RID: 6040
			const_41 = 6011,
			// Token: 0x04001799 RID: 6041
			const_42 = 7011,
			// Token: 0x0400179A RID: 6042
			const_43,
			// Token: 0x0400179B RID: 6043
			const_44,
			// Token: 0x0400179C RID: 6044
			const_45,
			// Token: 0x0400179D RID: 6045
			const_46,
			// Token: 0x0400179E RID: 6046
			const_47 = 8001,
			// Token: 0x0400179F RID: 6047
			const_48,
			// Token: 0x040017A0 RID: 6048
			const_49,
			// Token: 0x040017A1 RID: 6049
			const_50,
			// Token: 0x040017A2 RID: 6050
			const_51 = 9001,
			// Token: 0x040017A3 RID: 6051
			const_52,
			// Token: 0x040017A4 RID: 6052
			const_53 = 9101,
			// Token: 0x040017A5 RID: 6053
			const_54 = 9801,
			// Token: 0x040017A6 RID: 6054
			const_55 = 9998
		}

		// Token: 0x02000378 RID: 888
		public enum WarheadCaliber : short
		{
			// Token: 0x040017A8 RID: 6056
			None = 1001,
			// Token: 0x040017A9 RID: 6057
			Gun_6_15mm = 2001,
			// Token: 0x040017AA RID: 6058
			Gun_16_24mm,
			// Token: 0x040017AB RID: 6059
			Gun_25_60mm,
			// Token: 0x040017AC RID: 6060
			Gun_61_80mm,
			// Token: 0x040017AD RID: 6061
			Gun_81_150mm,
			// Token: 0x040017AE RID: 6062
			Gun_151_200mm,
			// Token: 0x040017AF RID: 6063
			Gun_201_350mm,
			// Token: 0x040017B0 RID: 6064
			Gun_351_450mm,
			// Token: 0x040017B1 RID: 6065
			Rocket_6_15mm = 3001,
			// Token: 0x040017B2 RID: 6066
			Rocket_16_24mm,
			// Token: 0x040017B3 RID: 6067
			Rocket_25_60mm,
			// Token: 0x040017B4 RID: 6068
			Rocket_61_80mm,
			// Token: 0x040017B5 RID: 6069
			Rocket_81_150mm,
			// Token: 0x040017B6 RID: 6070
			Rocket_151_200mm,
			// Token: 0x040017B7 RID: 6071
			Rocket_201_350mm,
			// Token: 0x040017B8 RID: 6072
			Rocket_351_450mm
		}
	}
}
