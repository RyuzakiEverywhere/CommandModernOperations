using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x0200035F RID: 863
	public sealed class Explosion : Unit
	{
		// Token: 0x060019B5 RID: 6581 RVA: 0x001D18F0 File Offset: 0x001CFAF0
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Explosion");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_0.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(this.string_0);
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.vmethod_9()));
					xmlWriter_0.WriteElementString("CA", XmlConvert.ToString(this.vmethod_14(false)));
					xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.vmethod_28(null)));
					xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.vmethod_30(null)));
					xmlWriter_0.WriteElementString("Lon_Graphics", XmlConvert.ToString(this.method_56()));
					xmlWriter_0.WriteElementString("Lat_Graphics", XmlConvert.ToString(this.method_58()));
					if (base.method_17().Count > 0)
					{
						xmlWriter_0.WriteStartElement("RangeSymbols");
						try
						{
							foreach (RangeSymbol rangeSymbol in base.method_17())
							{
								xmlWriter_0.WriteRaw(rangeSymbol.method_8());
							}
						}
						finally
						{
							List<RangeSymbol>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					if (!string.IsNullOrEmpty(this.string_3))
					{
						xmlWriter_0.WriteElementString("Message", this.string_3);
					}
					xmlWriter_0.WriteElementString("Yield", XmlConvert.ToString(this.double_2));
					xmlWriter_0.WriteElementString("Yield_Graphics", XmlConvert.ToString(this.double_3));
					xmlWriter_0.WriteElementString("TTL", XmlConvert.ToString(this.double_4));
					if (!Information.IsNothing(this.nullable_10))
					{
						xmlWriter_0.WriteElementString("MaxD", XmlConvert.ToString(this.nullable_10.Value));
					}
					XmlWriter xmlWriter = xmlWriter_0;
					string localName = "WarheadType";
					int weaponType_ = (int)this.warheadType_0;
					xmlWriter.WriteElementString(localName, weaponType_.ToString());
					XmlWriter xmlWriter2 = xmlWriter_0;
					string localName2 = "WeaponType";
					weaponType_ = (int)this._WeaponType_0;
					xmlWriter2.WriteElementString(localName2, weaponType_.ToString());
					XmlWriter xmlWriter3 = xmlWriter_0;
					string localName3 = "ExpType";
					short num = (short)this.enum126_0;
					xmlWriter3.WriteElementString(localName3, num.ToString());
					if (!Information.IsNothing(this.activeUnit_0))
					{
						xmlWriter_0.WriteElementString("_DirectImpactUnit", this.activeUnit_0.string_0);
					}
					if (!Information.IsNothing(this.mount_0))
					{
						xmlWriter_0.WriteElementString("_DirectImpactAimpoint", this.mount_0.string_0);
					}
					if (!Information.IsNothing(this.activeUnit_1))
					{
						xmlWriter_0.WriteElementString("_ExcludedUnit", this.activeUnit_1.string_0);
					}
					xmlWriter_0.WriteElementString("_ExcludedAimPointID", this.string_7);
					if (!Information.IsNothing(this.mount_1))
					{
						xmlWriter_0.WriteElementString("_ExcludedAimpoint", this.mount_1.string_0);
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100842", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x001D1C48 File Offset: 0x001CFE48
		public static Explosion smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			Explosion result;
			try
			{
				Explosion explosion = new Explosion();
				explosion.warheadType_0 = Warhead.WarheadType.HE_BlastFrag;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 2010780873U)
						{
							if (num <= 1213695817U)
							{
								if (num <= 559944763U)
								{
									if (num != 266367750U)
									{
										if (num != 441941816U)
										{
											if (num != 559944763U)
											{
												continue;
											}
											if (Operators.CompareString(name, "WarheadType", false) != 0)
											{
												continue;
											}
											goto IL_567;
										}
										else if (Operators.CompareString(name, "CurrentAltitude", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Name", false) == 0)
										{
											explosion.Name = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 1063775611U)
								{
									if (num != 1091296846U)
									{
										if (num != 1213695817U)
										{
											continue;
										}
										if (Operators.CompareString(name, "_ExcludedAimPoint", false) == 0)
										{
											explosion.string_7 = xmlNode.InnerText;
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Yield", false) == 0)
										{
											explosion.double_2 = XmlConvert.ToDouble(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TTL", false) == 0)
									{
										explosion.double_4 = XmlConvert.ToDouble(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 1729717486U)
							{
								if (num != 1458105184U)
								{
									if (num != 1564175899U)
									{
										if (num != 1729717486U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Longitude", false) != 0)
										{
											continue;
										}
										goto IL_44B;
									}
									else
									{
										if (Operators.CompareString(name, "Latitude_Graphics", false) == 0)
										{
											explosion.method_59(XmlConvert.ToDouble(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										explosion.vmethod_0(xmlNode.InnerText);
										continue;
									}
									return (Explosion)dictionary_0[xmlNode.InnerText];
								}
							}
							else if (num <= 1878684297U)
							{
								if (num != 1836990821U)
								{
									if (num != 1878684297U)
									{
										continue;
									}
									if (Operators.CompareString(name, "WeaponType", false) == 0)
									{
										explosion._WeaponType_0 = (Weapon._WeaponType)Conversions.ToShort(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Latitude", false) != 0)
									{
										continue;
									}
									goto IL_3F6;
								}
							}
							else if (num != 1905141184U)
							{
								if (num != 2010780873U)
								{
									continue;
								}
								if (Operators.CompareString(name, "CA", false) == 0)
								{
									explosion.vmethod_15(false, XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "ExpType", false) == 0)
								{
									explosion.enum126_0 = (Warhead.Enum126)Conversions.ToShort(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3001749054U)
						{
							if (num <= 2496321123U)
							{
								if (num != 2035017543U)
								{
									if (num != 2128224206U)
									{
										if (num != 2496321123U)
										{
											continue;
										}
										if (Operators.CompareString(name, "RangeSymbols", false) != 0)
										{
											continue;
										}
										try
										{
											foreach (object obj2 in xmlNode.ChildNodes)
											{
												RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj2, dictionary_0);
												explosion.method_17().Add(item);
											}
											continue;
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
									if (Operators.CompareString(name, "CH", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "MaxD", false) == 0)
									{
										explosion.nullable_10 = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else if (num != 2564648390U)
							{
								if (num != 2920208772U)
								{
									if (num != 3001749054U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Lat", false) == 0)
									{
										goto IL_3F6;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Message", false) == 0)
									{
										explosion.string_3 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Lon", false) == 0)
								{
									goto IL_44B;
								}
								continue;
							}
						}
						else if (num <= 3311729638U)
						{
							if (num != 3019778271U)
							{
								if (num != 3281247622U)
								{
									if (num != 3311729638U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Yield_Graphics", false) == 0)
									{
										explosion.double_3 = XmlConvert.ToDouble(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Longitude_Graphics", false) == 0)
									{
										explosion.method_57(XmlConvert.ToDouble(xmlNode.InnerText));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "_DirectImpactUnit", false) == 0)
								{
									explosion.string_4 = xmlNode.InnerText;
									continue;
								}
								continue;
							}
						}
						else if (num <= 3569830189U)
						{
							if (num != 3512062061U)
							{
								if (num != 3569830189U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Duration", false) == 0)
								{
									explosion.double_4 = XmlConvert.ToDouble(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Type", false) == 0)
								{
									goto IL_567;
								}
								continue;
							}
						}
						else if (num != 3680159696U)
						{
							if (num != 3891284906U)
							{
								continue;
							}
							if (Operators.CompareString(name, "_ExcludedUnit", false) == 0)
							{
								explosion.string_6 = xmlNode.InnerText;
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "_DirectImpactAimpoint", false) == 0)
							{
								explosion.string_5 = xmlNode.InnerText;
								continue;
							}
							continue;
						}
						explosion.vmethod_10(XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
						IL_3F6:
						explosion.vmethod_31(null, XmlConvert.ToDouble(xmlNode.InnerText));
						continue;
						IL_44B:
						explosion.vmethod_29(null, XmlConvert.ToDouble(xmlNode.InnerText));
						continue;
						IL_567:
						explosion.warheadType_0 = (Warhead.WarheadType)Conversions.ToInteger(xmlNode.InnerText);
						if (Versioned.IsNumeric(xmlNode.InnerText))
						{
							explosion.warheadType_0 = (Warhead.WarheadType)Conversions.ToInteger(xmlNode.InnerText);
						}
						else
						{
							explosion.warheadType_0 = (Warhead.WarheadType)Enum.Parse(typeof(Warhead.WarheadType), xmlNode.InnerText, true);
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
				dictionary_0.Add(explosion.string_0, explosion);
				result = explosion;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100843", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0000D038 File Offset: 0x0000B238
		public double method_56()
		{
			return this.double_6;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0000D040 File Offset: 0x0000B240
		public void method_57(double double_7)
		{
			if (double_7 > 180.0 || double_7 < -180.0)
			{
				double_7 = Math2.smethod_11(ref double_7);
			}
			if (double.IsNaN(double_7))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.double_6 = double_7;
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0000D07F File Offset: 0x0000B27F
		public double method_58()
		{
			return this.double_5;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0000D087 File Offset: 0x0000B287
		public void method_59(double double_7)
		{
			if (double_7 > 90.0 || double_7 < -90.0)
			{
				double_7 = Math2.smethod_10(ref double_7);
			}
			if (double.IsNaN(double_7))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.double_5 = double_7;
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x001D232C File Offset: 0x001D052C
		public void method_60(ref Dictionary<string, Class310> dictionary_0)
		{
			try
			{
				if (!Information.IsNothing(this.string_4))
				{
					this.activeUnit_0 = (ActiveUnit)dictionary_0[this.string_4];
					this.mount_0 = (Mount)dictionary_0[this.string_5];
					this.activeUnit_1 = (ActiveUnit)dictionary_0[this.string_6];
					this.mount_1 = (Mount)dictionary_0[this.string_7];
				}
				if (!string.IsNullOrEmpty(this.string_6) && dictionary_0.ContainsKey(this.string_6))
				{
					this.activeUnit_1 = (ActiveUnit)dictionary_0[this.string_6];
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200040", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0000D0C6 File Offset: 0x0000B2C6
		private Explosion()
		{
			this.enum126_0 = Warhead.Enum126.const_0;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x001D2424 File Offset: 0x001D0624
		public float method_61()
		{
			float result;
			if (this.nullable_10 != null)
			{
				result = this.nullable_10.Value;
			}
			else
			{
				double num = (double)this.vmethod_13();
				Warhead.WarheadType warheadType = this.warheadType_0;
				if (warheadType <= Warhead.WarheadType.DepthCharge)
				{
					if (warheadType == Warhead.WarheadType.HE_BlastFrag)
					{
						goto IL_EB;
					}
					switch (warheadType)
					{
					case Warhead.WarheadType.SemiAP:
					case Warhead.WarheadType.HESH:
					case Warhead.WarheadType.HardTargetPenetrator:
						goto IL_EB;
					case Warhead.WarheadType.ContinuousRod:
					case Warhead.WarheadType.FAE:
						break;
					case Warhead.WarheadType.SuperFrag:
						goto IL_CD;
					default:
						if (warheadType - Warhead.WarheadType.Torpedo <= 1)
						{
							double num2 = (double)Explosion.smethod_1(this.double_2, Weapon.Enum128.const_2);
							return (float)Math.Max(2.0, num2 / 2916.0 * 3600.0);
						}
						break;
					}
				}
				else
				{
					if (warheadType == Warhead.WarheadType.Nuclear)
					{
						goto IL_EB;
					}
					if (warheadType - Warhead.WarheadType.Cluster_AP <= 2 || warheadType == Warhead.WarheadType.Cluster_SmartSubs)
					{
						goto IL_CD;
					}
				}
				return 0f;
				IL_CD:
				return Math.Max(2f, this.vmethod_14(false) / 300f);
				IL_EB:
				double num3 = num;
				double num4;
				if (num3 >= 0.0)
				{
					num4 = (double)Explosion.smethod_1(this.double_2, Weapon.Enum128.const_0);
				}
				else if (num3 < 0.0)
				{
					if (base.method_15())
					{
						double num5 = (double)Explosion.smethod_1(this.double_2, Weapon.Enum128.const_3);
						return (float)Math.Max(2.0, num5 / 5832.0 * 3600.0);
					}
					double num6 = (double)Explosion.smethod_1(this.double_2, Weapon.Enum128.const_2);
					return (float)Math.Max(2.0, num6 / 2916.0 * 3600.0);
				}
				result = (float)Math.Max(2.0, num4 / 661.0 * 3600.0);
			}
			return result;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0000D0D9 File Offset: 0x0000B2D9
		public override bool vmethod_26()
		{
			if (this.nullable_11 == null)
			{
				this.nullable_11 = new bool?(base.vmethod_26());
			}
			return this.nullable_11.Value;
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0000D104 File Offset: 0x0000B304
		public override bool vmethod_27()
		{
			if (this.nullable_12 == null)
			{
				this.nullable_12 = new bool?(base.vmethod_27());
			}
			return this.nullable_12.Value;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0000D12F File Offset: 0x0000B32F
		public double method_62()
		{
			return this.double_4;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0000D137 File Offset: 0x0000B337
		public bool method_63()
		{
			return this.double_4 == (double)this.method_61();
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x001D25E8 File Offset: 0x001D07E8
		public bool method_64()
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

		// Token: 0x060019C3 RID: 6595 RVA: 0x001D2620 File Offset: 0x001D0820
		public void method_65(ref Scenario scenario_0, float float_10)
		{
			this.double_4 += (double)float_10;
			double num = (double)this.method_61();
			if (this.double_4 > num)
			{
				this.double_4 = num;
			}
			string string_;
			if (this.activeUnit_1 != null)
			{
				string_ = this.activeUnit_1.string_0;
			}
			else
			{
				string_ = this.string_6;
			}
			if (this.double_4 == num && this.method_64())
			{
				this.method_78(scenario_0, string_);
			}
			if (this.double_4 < num)
			{
				Warhead.WarheadType warheadType = this.warheadType_0;
				if (warheadType <= Warhead.WarheadType.HESH)
				{
					if (warheadType != Warhead.WarheadType.HE_BlastFrag && warheadType - Warhead.WarheadType.SemiAP > 1)
					{
						return;
					}
				}
				else if (warheadType != Warhead.WarheadType.HardTargetPenetrator && warheadType - Warhead.WarheadType.Torpedo > 1 && warheadType != Warhead.WarheadType.Nuclear)
				{
					return;
				}
				bool bool_ = scenario_0.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10);
				if (this.vmethod_27())
				{
					this.method_73(scenario_0, string_, Weapon.Enum128.const_2, this.warheadType_0, float_10, bool_);
					return;
				}
				if (this.vmethod_26())
				{
					this.method_73(scenario_0, string_, Weapon.Enum128.const_3, this.warheadType_0, float_10, bool_);
					return;
				}
				this.method_73(scenario_0, string_, Weapon.Enum128.const_0, this.warheadType_0, float_10, bool_);
			}
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x001D272C File Offset: 0x001D092C
		public Explosion(ref Scenario theScen, double theLongitude, double theLatitude, double theLongitude_Graphics, double theLatitude_Graphics, float theHeading, float theAltitude, Weapon._WeaponType theWeaponType, float theExpYield, float theExpYield_Graphics, Warhead.WarheadType theWarheadType, Warhead.Enum126 theExplosiveType, ActiveUnit DirectImpactUnit = null, Mount DirectImpactAimpoint = null, ActiveUnit ExcludedUnit = null, Mount ExcludedAimPoint = null, float? ExplosionDuration = null, short theClusterCoverageLength = 0, short theClusterCoverageWidth = 0, int theClusterSubmunitionQty = 0, float theClusterSubmunitionYield = 0f, int ARM_TargetedRadar = 0)
		{
			this.enum126_0 = Warhead.Enum126.const_0;
			try
			{
				this.vmethod_29(null, theLongitude);
				this.vmethod_31(null, theLatitude);
				this.method_57(theLongitude_Graphics);
				this.method_59(theLatitude_Graphics);
				this.vmethod_15(false, theAltitude);
				this.double_2 = (double)theExpYield;
				this.double_3 = (double)theExpYield_Graphics;
				this.warheadType_0 = theWarheadType;
				this._WeaponType_0 = theWeaponType;
				this.enum126_0 = theExplosiveType;
				this.activeUnit_0 = DirectImpactUnit;
				this.mount_0 = DirectImpactAimpoint;
				this.activeUnit_1 = ExcludedUnit;
				this.mount_1 = ExcludedAimPoint;
				this.double_4 = 0.0;
				base.method_51();
				this.int_0 = (int)theClusterCoverageLength;
				this.int_1 = (int)theClusterCoverageWidth;
				this.int_2 = theClusterSubmunitionQty;
				this.float_9 = (float)(this.double_2 / (double)theClusterSubmunitionQty);
				if (!Information.IsNothing(this.activeUnit_1))
				{
					this.string_6 = this.activeUnit_1.string_0;
				}
				else
				{
					this.string_6 = "";
				}
				if (theWarheadType == Warhead.WarheadType.Nuclear)
				{
					this.method_75(ref theScen, this.string_6);
					this.method_76(ref theScen, this.string_6);
				}
				if (this.method_66())
				{
					if (this.double_2 > 0.0)
					{
						Explosion explosion = new Explosion(ref theScen, theLongitude, theLatitude, this.method_56(), this.method_58(), theHeading, theAltitude, theWeaponType, theExpYield, theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon.Enum128.const_0, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, ARM_TargetedRadar);
						explosion.int_0 = this.int_0;
						explosion.int_1 = this.int_1;
						explosion.int_2 = this.int_2;
						explosion.float_9 = this.float_9;
						if (!Information.IsNothing(ExplosionDuration))
						{
							explosion.nullable_10 = ExplosionDuration;
						}
						if (this.method_80((double)(theExpYield / 1000000f), (double)this.vmethod_13()))
						{
							this.method_74(ref theScen, this.string_6, Weapon.Enum128.const_0);
						}
					}
					if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
					{
						if (this.double_2 > 0.0)
						{
							this.method_83(theScen);
						}
					}
					else if (this.warheadType_0 == Warhead.WarheadType.Fragmentation || this.warheadType_0 == Warhead.WarheadType.HardTargetPenetrator || this.warheadType_0 == Warhead.WarheadType.HE_BlastFrag || this.warheadType_0 == Warhead.WarheadType.HEAT || this.warheadType_0 == Warhead.WarheadType.HESH || this.warheadType_0 == Warhead.WarheadType.Landmine_AP || this.warheadType_0 == Warhead.WarheadType.Landmine_AT || this.warheadType_0 == Warhead.WarheadType.SemiAP || this.warheadType_0 == Warhead.WarheadType.FAE)
					{
						if (!base.method_15())
						{
							if (this.warheadType_0 != Warhead.WarheadType.Incendiary)
							{
								if (Information.IsNothing(ExcludedUnit))
								{
									new WaterSplash(ref theScen, this.method_56(), this.method_58(), Explosion.smethod_1(this.double_3, Weapon.Enum128.const_1));
									goto IL_2EB;
								}
								goto IL_2EB;
							}
						}
						new GroundImpact(ref theScen, this.method_56(), this.method_58(), Explosion.smethod_1(this.double_3, Weapon.Enum128.const_0), this.warheadType_0 == Warhead.WarheadType.Incendiary);
					}
					IL_2EB:
					if (this.warheadType_0 == Warhead.WarheadType.EMP_Omni)
					{
						this.double_2 = 42999999.0;
						this.method_83(theScen);
					}
				}
				else if (this.method_67())
				{
					if (this.double_2 > 0.0)
					{
						Explosion explosion2 = new Explosion(ref theScen, theLongitude, theLatitude, this.method_56(), this.method_58(), theHeading, (float)(Terrain.smethod_7(theLatitude, theLongitude, false) + 1), theWeaponType, (float)((double)theExpYield * 0.95), theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon.Enum128.const_0, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
						explosion2.int_0 = this.int_0;
						explosion2.int_1 = this.int_1;
						explosion2.int_2 = this.int_2;
						explosion2.float_9 = this.float_9;
						if (!Information.IsNothing(ExplosionDuration))
						{
							explosion2.nullable_10 = ExplosionDuration;
						}
						this.method_74(ref theScen, this.string_6, Weapon.Enum128.const_1);
					}
					if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
					{
						if (this.double_2 > 0.0)
						{
							this.method_83(theScen);
						}
					}
					else if (this.warheadType_0 == Warhead.WarheadType.Incendiary || this.warheadType_0 == Warhead.WarheadType.Fragmentation || this.warheadType_0 == Warhead.WarheadType.HardTargetPenetrator || this.warheadType_0 == Warhead.WarheadType.HE_BlastFrag || this.warheadType_0 == Warhead.WarheadType.HEAT || this.warheadType_0 == Warhead.WarheadType.HESH || this.warheadType_0 == Warhead.WarheadType.Landmine_AP || this.warheadType_0 == Warhead.WarheadType.Landmine_AT || this.warheadType_0 == Warhead.WarheadType.SemiAP || this.warheadType_0 == Warhead.WarheadType.FAE)
					{
						new GroundImpact(ref theScen, this.method_56(), this.method_58(), Explosion.smethod_1(this.double_3, Weapon.Enum128.const_0), this.warheadType_0 == Warhead.WarheadType.Incendiary);
					}
				}
				else if (this.method_68())
				{
					if (this.double_2 > 0.0)
					{
						Explosion explosion3 = new Explosion(ref theScen, theLongitude, theLatitude, this.method_56(), this.method_58(), theHeading, 1f, theWeaponType, (float)((double)theExpYield * 0.9), theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon.Enum128.const_0, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
						explosion3.int_0 = this.int_0;
						explosion3.int_1 = this.int_1;
						explosion3.int_2 = this.int_2;
						explosion3.float_9 = this.float_9;
						if (!Information.IsNothing(ExplosionDuration))
						{
							explosion3.nullable_10 = ExplosionDuration;
						}
						if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
						{
							Explosion explosion4 = new Explosion(ref theScen, theLongitude, theLatitude, this.method_56(), this.method_58(), theHeading, -1f, theWeaponType, (float)((double)theExpYield * 0.1), theExpYield_Graphics, Warhead.WarheadType.HE_BlastFrag, theExplosiveType, Weapon.Enum128.const_2, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
							explosion4.int_0 = this.int_0;
							explosion4.int_1 = this.int_1;
							if (!Information.IsNothing(ExplosionDuration))
							{
								explosion4.nullable_10 = ExplosionDuration;
							}
						}
					}
					if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
					{
						if (this.double_2 > 0.0)
						{
							this.method_83(theScen);
						}
					}
					else if (this.warheadType_0 == Warhead.WarheadType.Incendiary)
					{
						new GroundImpact(ref theScen, this.method_56(), this.method_58(), 0.01349892f, this.warheadType_0 == Warhead.WarheadType.Incendiary);
					}
					else if (!this.method_64())
					{
						new WaterSplash(ref theScen, this.method_56(), this.method_58(), Explosion.smethod_1(this.double_3, Weapon.Enum128.const_0));
					}
				}
				else if (this.vmethod_27())
				{
					if (this.double_2 > 0.0)
					{
						int num = 1;
						if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
						{
							num = 600;
						}
						if (this.vmethod_14(false) < (float)(-(float)num))
						{
							Explosion explosion5 = new Explosion(ref theScen, theLongitude, theLatitude, this.method_56(), this.method_58(), theHeading, theAltitude, theWeaponType, theExpYield, theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon.Enum128.const_2, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
							explosion5.int_0 = this.int_0;
							explosion5.int_1 = this.int_1;
							explosion5.int_2 = this.int_2;
							explosion5.float_9 = this.float_9;
							if (!Information.IsNothing(ExplosionDuration))
							{
								explosion5.nullable_10 = ExplosionDuration;
							}
						}
						else
						{
							double x = Math.Sqrt(Math.Pow((double)num, 2.0) - Math.Pow((double)this.vmethod_14(false), 2.0));
							double num2 = 0.5235987755982988 * (double)Math.Abs(this.vmethod_14(false)) * (3.0 * Math.Pow((double)num, 2.0) + 3.0 * Math.Pow(x, 2.0) + Math.Pow((double)this.vmethod_14(false), 2.0));
							double num3 = 4.1887902047863905 * Math.Pow((double)num, 3.0);
							double num4 = num3 / 2.0 + num2;
							double num5 = (double)theExpYield * (num4 / num3);
							double num6 = (double)theExpYield - num5;
							Explosion explosion6 = new Explosion(ref theScen, theLongitude, theLatitude, this.method_56(), this.method_58(), theHeading, theAltitude, theWeaponType, (float)num5, theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon.Enum128.const_2, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
							explosion6.int_0 = this.int_0;
							explosion6.int_1 = this.int_1;
							explosion6.int_2 = this.int_2;
							explosion6.float_9 = this.float_9;
							if (!Information.IsNothing(ExplosionDuration))
							{
								explosion6.nullable_10 = ExplosionDuration;
							}
							Explosion explosion7 = new Explosion(ref theScen, theLongitude, theLatitude, this.method_56(), this.method_58(), theHeading, 0f, theWeaponType, (float)num6, theExpYield_Graphics, theWarheadType, theExplosiveType, Weapon.Enum128.const_2, DirectImpactUnit, DirectImpactAimpoint, ExcludedUnit, ExcludedAimPoint, ExplosionDuration, 0);
							explosion7.int_0 = this.int_0;
							explosion7.int_1 = this.int_1;
							explosion7.int_2 = this.int_2;
							explosion7.float_9 = this.float_9;
							if (!Information.IsNothing(ExplosionDuration))
							{
								explosion7.nullable_10 = ExplosionDuration;
							}
						}
					}
					if (!this.method_64())
					{
						new WaterSplash(ref theScen, this.method_56(), this.method_58(), Explosion.smethod_1(this.double_3, Weapon.Enum128.const_2));
					}
				}
				else
				{
					if (!this.vmethod_26())
					{
						throw new NotImplementedException();
					}
					if (this.double_2 > 0.0)
					{
						this.method_74(ref theScen, this.string_6, Weapon.Enum128.const_3);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100844", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x001D30EC File Offset: 0x001D12EC
		private Explosion(ref Scenario theScen, double theLongitude, double theLatitude, double theLongitude_Graphics, double theLatitude_Graphics, float theHeading, float theAltitude, Weapon._WeaponType theWeaponType, float theExpYield, float theExpYield_Graphics, Warhead.WarheadType theWarheadType, Warhead.Enum126 theExplosiveType, Weapon.Enum128 DetMedium, ActiveUnit DirectImpactUnit = null, Mount DirectImpactAimpoint = null, ActiveUnit ExcludedUnit = null, Mount ExcludedAimPoint = null, float? ExplosionDuration = null, int ARM_TargetedRadar = 0)
		{
			this.enum126_0 = Warhead.Enum126.const_0;
			try
			{
				this.vmethod_29(null, theLongitude);
				this.vmethod_31(null, theLatitude);
				this.method_57(theLongitude_Graphics);
				this.method_59(theLatitude_Graphics);
				this.vmethod_15(false, theAltitude);
				this.vmethod_10(theHeading);
				this.double_2 = (double)theExpYield;
				this.double_3 = (double)theExpYield_Graphics;
				this.warheadType_0 = theWarheadType;
				this._WeaponType_0 = theWeaponType;
				this.enum126_0 = theExplosiveType;
				this.activeUnit_0 = DirectImpactUnit;
				this.mount_0 = DirectImpactAimpoint;
				this.activeUnit_1 = ExcludedUnit;
				this.mount_1 = ExcludedAimPoint;
				this.double_4 = 0.0;
				if (!Information.IsNothing(ExplosionDuration))
				{
					this.nullable_10 = ExplosionDuration;
				}
				if (!Information.IsNothing(this.activeUnit_1))
				{
					this.string_6 = this.activeUnit_1.string_0;
				}
				else
				{
					this.string_6 = "";
				}
				theScen.UnitsAutoIncrement++;
				theScen.vmethod_12().method_4(this);
				bool flag = theScen.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10);
				Warhead.WarheadType warheadType = this.warheadType_0;
				switch (warheadType)
				{
				case Warhead.WarheadType.HE_BlastFrag:
				case Warhead.WarheadType.SemiAP:
				case Warhead.WarheadType.HardTargetPenetrator:
					break;
				case Warhead.WarheadType.ArmorPiercing:
				case Warhead.WarheadType.HEAT:
				case Warhead.WarheadType.HESH:
				case Warhead.WarheadType.ContinuousRod:
					goto IL_273;
				case Warhead.WarheadType.Incendiary:
					this.method_71(theScen, null, this.warheadType_0, theScen.method_40());
					goto IL_273;
				case Warhead.WarheadType.Fragmentation:
					if (this.vmethod_14(false) >= 0f)
					{
						this.method_69(theScen, this.string_6, flag, ARM_TargetedRadar);
						goto IL_273;
					}
					goto IL_273;
				case Warhead.WarheadType.FAE:
					this.method_72(theScen, this.string_6, Warhead.WarheadType.FAE, theScen.method_40(), theScen.DeclaredFeatures.Contains(Scenario.ScenarioFeatureOption.const_10));
					goto IL_273;
				default:
					if (warheadType - Warhead.WarheadType.Torpedo > 1)
					{
						goto IL_273;
					}
					break;
				}
				if (this.vmethod_13() >= 0f && base.method_15())
				{
					this.method_69(theScen, this.string_6, flag, ARM_TargetedRadar);
				}
				if (this.method_61() <= theScen.method_40())
				{
					this.double_4 = (double)theScen.method_40();
					if (this.vmethod_27())
					{
						this.method_73(theScen, this.string_6, Weapon.Enum128.const_2, theWarheadType, theScen.method_40(), flag);
					}
					else if (this.vmethod_26())
					{
						this.method_73(theScen, this.string_6, Weapon.Enum128.const_3, theWarheadType, theScen.method_40(), flag);
					}
					else
					{
						this.method_73(theScen, this.string_6, Weapon.Enum128.const_0, theWarheadType, theScen.method_40(), flag);
					}
				}
				IL_273:;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100845", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0000D148 File Offset: 0x0000B348
		public bool method_66()
		{
			return this.vmethod_13() > 0f && this.vmethod_14(false) > 0f;
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0000D167 File Offset: 0x0000B367
		private bool method_67()
		{
			return this.vmethod_13() == 0f && base.method_15();
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0000D17E File Offset: 0x0000B37E
		private bool method_68()
		{
			return this.vmethod_14(false) == 0f && !base.method_15();
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x001D33C0 File Offset: 0x001D15C0
		private void method_69(Scenario theScen, string ExcludedUnit_ObjectID, bool LandTypeEffectsEnabled, int ARM_TargetedRadar = 0)
		{
			Explosion.Class381 @class = new Explosion.Class381(@class);
			@class.explosion_0 = this;
			@class.scenario_0 = theScen;
			@class.string_0 = ExcludedUnit_ObjectID;
			try
			{
				Explosion.Class382 class2 = new Explosion.Class382(class2);
				class2.class381_0 = @class;
				class2.float_0 = Explosion.smethod_2(this.double_2, Weapon.Enum128.const_0);
				if (!Information.IsNothing(this.mount_0))
				{
					this.mount_0.method_45(this.double_2, class2.float_0, ARM_TargetedRadar);
				}
				class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
				Parallel.ForEach<ActiveUnit>(class2.class381_0.scenario_0.vmethod_0().Values, new Action<ActiveUnit>(class2.method_0));
				try
				{
					foreach (ActiveUnit activeUnit in class2.concurrentBag_0)
					{
						float num = Class437.smethod_4(Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), activeUnit.vmethod_30(null), activeUnit.vmethod_28(null)), Math.Abs(this.vmethod_14(false) - activeUnit.vmethod_14(false)));
						if (activeUnit.bool_8 && ((Facility)activeUnit).bool_27)
						{
							if (!Information.IsNothing(this.mount_0))
							{
								this.mount_0.method_48(this.double_2, this.warheadType_0);
							}
							IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(activeUnit.vmethod_51(), new Func<Mount, bool>(this.method_84));
							try
							{
								foreach (Mount mount in enumerable)
								{
									double double_;
									double double_2;
									Class411.smethod_1(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null), ref double_, ref double_2, (double)(mount.method_27() / 1852f), (double)mount.method_26());
									float num2 = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), double_2, double_);
									if (num2 < 0f)
									{
										num2 = -num2;
									}
									double num3 = (double)Class437.smethod_4(num2, Math.Abs(this.vmethod_14(false) - activeUnit.vmethod_14(false)));
									double num4 = (double)Warhead.smethod_3(double_2, double_, num3, this.warheadType_0, this.double_2, Weapon.Enum128.const_0, LandTypeEffectsEnabled);
									if (num4 > 0.0)
									{
										mount.method_45(num4, class2.float_0, ARM_TargetedRadar);
									}
								}
								continue;
							}
							finally
							{
								IEnumerator<Mount> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
						}
						float damageYield = Warhead.smethod_3(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), (double)num, this.warheadType_0, this.double_2, Weapon.Enum128.const_0, LandTypeEffectsEnabled);
						activeUnit.vmethod_91().vmethod_5(damageYield, class2.float_0, ARM_TargetedRadar);
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100846", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x001D371C File Offset: 0x001D191C
		private bool method_70(ActiveUnit activeUnit_2, Weapon.Enum128 enum128_0)
		{
			switch (enum128_0)
			{
			case Weapon.Enum128.const_0:
				return !activeUnit_2.vmethod_26() && !activeUnit_2.vmethod_27();
			case Weapon.Enum128.const_2:
				return (!activeUnit_2.bool_6 || this._WeaponType_0 != Weapon._WeaponType.DepthCharge) && activeUnit_2.vmethod_14(false) <= 0f && !activeUnit_2.method_15();
			case Weapon.Enum128.const_3:
				return activeUnit_2.method_5() || activeUnit_2.vmethod_26();
			}
			throw new NotImplementedException();
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x001D37AC File Offset: 0x001D19AC
		private void method_71(Scenario scenario_0, string string_8, Warhead.WarheadType warheadType_1, float float_10)
		{
			Explosion.Class383 @class = new Explosion.Class383(@class);
			@class.explosion_0 = this;
			@class.double_0 = Math.Sqrt(668.4507609859604);
			@class.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
			Parallel.ForEach<ActiveUnit>(scenario_0.vmethod_0().Values, new Action<ActiveUnit>(@class.method_0));
			try
			{
				foreach (ActiveUnit activeUnit in @class.concurrentBag_0)
				{
					if (activeUnit.bool_8 && ((Facility)activeUnit).bool_27)
					{
						IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(activeUnit.vmethod_51(), new Func<Mount, bool>(this.method_85));
						try
						{
							foreach (Mount mount in enumerable)
							{
								int num;
								switch (mount.armorRating_0)
								{
								case GlobalVariables.ArmorRating.Light:
									num = 6;
									break;
								case GlobalVariables.ArmorRating.Medium:
									num = 4;
									break;
								case GlobalVariables.ArmorRating.Heavy:
								case GlobalVariables.ArmorRating.Special:
									num = 2;
									break;
								default:
									num = 8;
									break;
								}
								if (GameGeneral.smethod_5().Next(1, 11) < num)
								{
									activeUnit.method_124(Misc.smethod_9(activeUnit.Name) + " damage report: " + Misc.smethod_9(mount.Name) + " has been destroyed!", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
									mount.vmethod_6(activeUnit.vmethod_7(false), false, true);
								}
							}
							continue;
						}
						finally
						{
							IEnumerator<Mount> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					GlobalVariables.ArmorRating armorRating;
					switch (activeUnit.vmethod_56())
					{
					case GlobalVariables.ActiveUnitType.Ship:
						armorRating = ((Ship)activeUnit).armorRating_4;
						break;
					case GlobalVariables.ActiveUnitType.Submarine:
						continue;
					case GlobalVariables.ActiveUnitType.Facility:
						armorRating = ((Facility)activeUnit).armorRating_0;
						break;
					}
					int num2;
					switch (activeUnit.vmethod_121())
					{
					case GlobalVariables.TargetVisualSizeClass.Stealthy:
					case GlobalVariables.TargetVisualSizeClass.VSmall:
						num2 += 4;
						break;
					case GlobalVariables.TargetVisualSizeClass.Small:
						num2 += 3;
						break;
					case GlobalVariables.TargetVisualSizeClass.Medium:
						num2 += 2;
						break;
					case GlobalVariables.TargetVisualSizeClass.Large:
					case GlobalVariables.TargetVisualSizeClass.VLarge:
						num2++;
						break;
					}
					switch (armorRating)
					{
					case GlobalVariables.ArmorRating.Light:
						num2 += 3;
						break;
					case GlobalVariables.ArmorRating.Medium:
						num2 += 2;
						break;
					case GlobalVariables.ArmorRating.Heavy:
					case GlobalVariables.ArmorRating.Special:
						num2++;
						break;
					default:
						num2 += 4;
						break;
					}
					num2 = Math.Min(4, (int)Math.Round((double)num2 / 2.0));
					activeUnit.vmethod_91().method_10((ActiveUnit_Damage.FireIntensityLevel)Math.Max((int)activeUnit.vmethod_91().vmethod_3(), num2));
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
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x001D3A74 File Offset: 0x001D1C74
		private void method_72(Scenario scenario_0, string string_8, Warhead.WarheadType warheadType_1, float float_10, bool bool_12)
		{
			Explosion.Class384 @class = new Explosion.Class384(@class);
			@class.explosion_0 = this;
			@class.string_0 = string_8;
			double num = this.double_2;
			float float_11 = Weather.smethod_0(scenario_0, this.vmethod_30(null), this.vmethod_28(null), (int)Math.Round((double)this.vmethod_14(false))).float_0;
			if (float_11 >= 5f)
			{
				if (float_11 < 10f)
				{
					num *= 0.9;
				}
				else if (float_11 < 20f)
				{
					num *= 0.7;
				}
				else if (float_11 < 30f)
				{
					num *= 0.5;
				}
				else if (float_11 < 40f)
				{
					num *= 0.35;
				}
				else
				{
					num *= 0.2;
				}
			}
			float num2 = this.vmethod_14(false);
			if (num2 >= 1000f)
			{
				if (num2 < 2000f)
				{
					num *= 0.9;
				}
				else if (num2 < 3000f)
				{
					num *= 0.75;
				}
				else if (num2 < 4000f)
				{
					num *= 0.6;
				}
				else if (num2 < 5000f)
				{
					num *= 0.45;
				}
				else if (num2 < 6000f)
				{
					num *= 0.3;
				}
				else
				{
					num *= 0.2;
				}
			}
			@class.float_1 = (float)(this.double_2 / 5.0);
			@class.float_2 = @class.float_1 + Explosion.smethod_1(num, Weapon.Enum128.const_0) * 1852f;
			@class.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
			@class.concurrentBag_1 = new ConcurrentBag<ActiveUnit>();
			Parallel.ForEach<ActiveUnit>(scenario_0.vmethod_0().Values, new Action<ActiveUnit>(@class.method_0));
			try
			{
				foreach (ActiveUnit activeUnit in @class.concurrentBag_0)
				{
					if (activeUnit.bool_8 && ((Facility)activeUnit).bool_27)
					{
						IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(activeUnit.vmethod_51(), new Func<Mount, bool>(this.method_86));
						try
						{
							foreach (Mount mount in enumerable)
							{
								mount.method_48(num, warheadType_1);
							}
							continue;
						}
						finally
						{
							IEnumerator<Mount> enumerator2;
							if (enumerator2 != null)
							{
								enumerator2.Dispose();
							}
						}
					}
					activeUnit.vmethod_91().method_10(ActiveUnit_Damage.FireIntensityLevel.Major);
					activeUnit.vmethod_91().vmethod_6((float)num, warheadType_1, this.enum126_0, Weapon.Enum128.const_0);
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
			try
			{
				foreach (ActiveUnit activeUnit2 in @class.concurrentBag_1)
				{
					float num3 = activeUnit2.method_25(this.vmethod_30(null), this.vmethod_28(null)) - @class.float_1 / 1852f;
					float num4 = Warhead.smethod_4(activeUnit2.vmethod_30(null), activeUnit2.vmethod_28(null), (double)num3, (double)activeUnit2.method_60(), this.warheadType_0, num, Weapon.Enum128.const_0, bool_12);
					if (activeUnit2.bool_8 && ((Facility)activeUnit2).bool_27)
					{
						IEnumerable<Mount> enumerable2 = Enumerable.Where<Mount>(activeUnit2.vmethod_51(), new Func<Mount, bool>(this.method_87));
						try
						{
							foreach (Mount mount2 in enumerable2)
							{
								mount2.method_48((double)num4, warheadType_1);
							}
							continue;
						}
						finally
						{
							IEnumerator<Mount> enumerator4;
							if (enumerator4 != null)
							{
								enumerator4.Dispose();
							}
						}
					}
					activeUnit2.vmethod_91().method_10(ActiveUnit_Damage.FireIntensityLevel.Major);
					activeUnit2.vmethod_91().vmethod_6(num4, warheadType_1, this.enum126_0, Weapon.Enum128.const_0);
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

		// Token: 0x060019CD RID: 6605 RVA: 0x001D3E80 File Offset: 0x001D2080
		private void method_73(Scenario scenario_0, string string_8, Weapon.Enum128 enum128_0, Warhead.WarheadType warheadType_1, float float_10, bool bool_12)
		{
			Explosion.Class385 @class = new Explosion.Class385(@class);
			@class.explosion_0 = this;
			@class.scenario_0 = scenario_0;
			@class.string_0 = string_8;
			@class.enum128_0 = enum128_0;
			@class.warheadType_0 = warheadType_1;
			try
			{
				Explosion.Class386 class2 = new Explosion.Class386(class2);
				class2.class385_0 = @class;
				if (this.mount_0 != null)
				{
					this.mount_0.method_48(this.double_2, this.warheadType_0);
				}
				int num;
				switch (class2.class385_0.enum128_0)
				{
				case Weapon.Enum128.const_0:
					num = 661;
					break;
				case Weapon.Enum128.const_2:
					num = 2916;
					break;
				case Weapon.Enum128.const_3:
					num = 5832;
					break;
				}
				class2.double_0 = this.double_4 / 3600.0 * (double)num;
				class2.double_1 = (this.double_4 - (double)float_10) / 3600.0 * (double)num;
				float num2 = Explosion.smethod_1(this.double_2, class2.class385_0.enum128_0);
				if (class2.double_0 > (double)num2)
				{
					class2.double_0 = (double)num2;
				}
				class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
				Parallel.ForEach<ActiveUnit>(class2.class385_0.scenario_0.method_42(), new Action<ActiveUnit>(class2.method_0));
				try
				{
					foreach (ActiveUnit activeUnit in class2.concurrentBag_0)
					{
						float num3 = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), activeUnit.vmethod_30(null), activeUnit.vmethod_28(null));
						float num4;
						if (Math.Abs(this.vmethod_14(false) - activeUnit.vmethod_14(false)) == 0f)
						{
							num4 = num3;
						}
						else
						{
							num4 = Class437.smethod_4(num3, Math.Abs(this.vmethod_14(false) - activeUnit.vmethod_14(false)));
						}
						if (activeUnit.bool_8)
						{
							if (((Facility)activeUnit).bool_27)
							{
								if (!Information.IsNothing(this.mount_0))
								{
									this.mount_0.method_48(this.double_2, this.warheadType_0);
								}
								IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(activeUnit.vmethod_51(), new Func<Mount, bool>(this.method_88));
								try
								{
									foreach (Mount mount in enumerable)
									{
										double double_;
										double double_2;
										Class411.smethod_1(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null), ref double_, ref double_2, (double)(mount.method_27() / 1852f), (double)mount.method_26());
										double num5 = (double)Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), double_2, double_);
										double num6;
										if (Math.Abs(this.vmethod_14(false) - activeUnit.vmethod_14(false)) == 0f)
										{
											num6 = num5;
										}
										else
										{
											num6 = (double)Class437.smethod_4((float)num5, Math.Abs(this.vmethod_14(false) - activeUnit.vmethod_14(false)));
										}
										if (num6 <= (double)num2)
										{
											double num7 = (double)Warhead.smethod_4(double_2, double_, num6, (double)mount.float_2, this.warheadType_0, this.double_2, class2.class385_0.enum128_0, bool_12);
											if (num7 > 0.0)
											{
												mount.method_48(num7, this.warheadType_0);
											}
										}
									}
									continue;
								}
								finally
								{
									IEnumerator<Mount> enumerator2;
									if (enumerator2 != null)
									{
										enumerator2.Dispose();
									}
								}
							}
							float float_11 = Warhead.smethod_4(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), (double)num4, (double)activeUnit.method_60(), this.warheadType_0, this.double_2, class2.class385_0.enum128_0, bool_12);
							activeUnit.vmethod_91().vmethod_6(float_11, this.warheadType_0, this.enum126_0, class2.class385_0.enum128_0);
						}
						else if (activeUnit.bool_2)
						{
							activeUnit.method_124(activeUnit.Name + " has been destroyed by blast!", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
							activeUnit.scenario_0.method_65(activeUnit);
						}
						else
						{
							Weapon.Enum128 enum128_ = class2.class385_0.enum128_0;
							if (enum128_ == Weapon.Enum128.const_2)
							{
								if (Class570.class280_0.method_12())
								{
									activeUnit.method_124(activeUnit.Name + " is being hit by an underwater explosion at " + Conversions.ToString((int)Math.Round((double)(num4 * 1852f * 3.28084f))) + " ft!", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
								}
								else
								{
									activeUnit.method_124(activeUnit.Name + " is being hit by an underwater explosion at " + Conversions.ToString((int)Math.Round((double)(num4 * 1852f))) + " m!", "Damage report", LoggedMessage.MessageType.UnitDamage, 0, false, new Geopoint_Struct(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null)));
								}
							}
							float num8 = Warhead.smethod_4(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), (double)num4, (double)activeUnit.method_60(), this.warheadType_0, this.double_2, class2.class385_0.enum128_0, bool_12);
							if (class2.class385_0.enum128_0 == Weapon.Enum128.const_3 || class2.class385_0.enum128_0 == Weapon.Enum128.const_2)
							{
								float num9 = Math.Abs((float)Math2.smethod_1((double)Math2.smethod_17(activeUnit.vmethod_30(null), activeUnit.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null))));
								num8 = (float)((double)num8 * (0.2 + 0.8 * (double)num9));
							}
							activeUnit.vmethod_91().vmethod_6(num8, this.warheadType_0, this.enum126_0, class2.class385_0.enum128_0);
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100847", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x001D4544 File Offset: 0x001D2744
		private void method_74(ref Scenario scenario_0, string string_8, Weapon.Enum128 enum128_0)
		{
			try
			{
				float num;
				if (this.warheadType_0 == Warhead.WarheadType.Nuclear)
				{
					num = (float)(1.0 * this.double_2) / 1000f;
				}
				else
				{
					num = (float)(1.0 * this.double_2);
				}
				switch (enum128_0)
				{
				case Weapon.Enum128.const_0:
					num = (float)((double)num * 0.01);
					break;
				case Weapon.Enum128.const_1:
					num = (float)((double)num * 0.05);
					break;
				}
				double num2;
				double num3;
				double num4;
				this.method_81((double)num, ref num2, ref num3, ref num4, (double)this.vmethod_13());
				num2 /= 1852.0;
				num3 /= 1852.0;
				float num5 = (float)(3.0 * num3);
				float num6 = (float)(2.0 * num3);
				float num7 = (float)(1.5 * num3);
				float num8 = (float)(2.5 * num3);
				float num9 = (float)(2.0 * num3);
				float num10 = (float)(1.25 * num3);
				try
				{
					foreach (ActiveUnit activeUnit in scenario_0.vmethod_0().Values)
					{
						if (!Information.IsNothing(activeUnit) && activeUnit.vmethod_127() && !activeUnit.bool_1 && activeUnit.bool_8 && Operators.CompareString(string_8, activeUnit.string_0, false) != 0 && ((Facility)activeUnit)._FacilityCategory_0 == Facility._FacilityCategory.Building_Underground)
						{
							float num11 = base.method_37(activeUnit, 0f);
							float num12;
							if (((Facility)activeUnit).armorRating_0 > GlobalVariables.ArmorRating.Medium)
							{
								if (num11 > num5)
								{
									continue;
								}
								if (num5 > num11 && num11 > num6)
								{
									num12 = (float)(GameGeneral.smethod_5().NextDouble() * 0.3);
								}
								else if (num6 > num11 && num11 > num7)
								{
									num12 = (float)(GameGeneral.smethod_5().NextDouble() * 0.5);
								}
								else
								{
									num12 = (float)(GameGeneral.smethod_5().NextDouble() * 0.8);
								}
							}
							else
							{
								if (num11 > num8)
								{
									break;
								}
								if (num8 > num11 && num11 > num9)
								{
									num12 = (float)(GameGeneral.smethod_5().NextDouble() * 0.3);
								}
								else if (num9 > num11 && num11 > num10)
								{
									num12 = (float)(GameGeneral.smethod_5().NextDouble() * 0.5);
								}
								else
								{
									num12 = (float)(GameGeneral.smethod_5().NextDouble() * 0.8);
								}
							}
							activeUnit.vmethod_91().vmethod_6((float)activeUnit.method_60() * num12, this.warheadType_0, this.enum126_0, Weapon.Enum128.const_3);
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100848", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x001D486C File Offset: 0x001D2A6C
		private void method_75(ref Scenario scenario_0, string string_8)
		{
			Explosion.Class388 @class = new Explosion.Class388(@class);
			@class.explosion_0 = this;
			@class.string_0 = string_8;
			try
			{
				Explosion.Class387 class2 = new Explosion.Class387(class2);
				class2.class388_0 = @class;
				if (base.method_15())
				{
					double num;
					double num2;
					this.method_81(1.0 * this.double_2 / 1000000.0, ref class2.double_0, ref num, ref num2, (double)this.vmethod_13());
				}
				else
				{
					double num;
					double num2;
					this.method_81(1.0 * this.double_2 / 1000000.0, ref class2.double_0, ref num, ref num2, (double)this.vmethod_14(false));
				}
				if (class2.double_0 != 0.0)
				{
					class2.double_0 /= 1852.0;
					class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
					Parallel.ForEach<ActiveUnit>(scenario_0.vmethod_0().Values, new Action<ActiveUnit>(class2.method_0));
					try
					{
						foreach (ActiveUnit activeUnit in class2.concurrentBag_0)
						{
							scenario_0.method_65(activeUnit);
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
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100849", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x001D4A04 File Offset: 0x001D2C04
		private void method_76(ref Scenario scenario_0, string string_8)
		{
			Explosion.Class390 @class = new Explosion.Class390(@class);
			@class.explosion_0 = this;
			@class.string_0 = string_8;
			try
			{
				Explosion.Class389 class2 = new Explosion.Class389(class2);
				class2.class390_0 = @class;
				if (this.vmethod_14(false) >= 0f && this.vmethod_13() >= 0f)
				{
					class2.double_0 = 1.0;
					class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
					Parallel.ForEach<ActiveUnit>(scenario_0.vmethod_0().Values, new Action<ActiveUnit>(class2.method_0));
					try
					{
						foreach (ActiveUnit activeUnit in class2.concurrentBag_0)
						{
							scenario_0.method_65(activeUnit);
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
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100849", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x001D4B10 File Offset: 0x001D2D10
		public Geopoint_Struct[] method_77(float float_10)
		{
			Geopoint_Struct[] result;
			try
			{
				float float_11 = (float)this.int_0 * float_10;
				float float_12 = (float)this.int_1 * float_10;
				result = Math2.smethod_24(this.vmethod_30(null), this.vmethod_28(null), float_11, float_12, this.vmethod_9());
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100850", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x001D4BAC File Offset: 0x001D2DAC
		private void method_78(Scenario scenario_0, string string_8)
		{
			Explosion.Class392 @class = new Explosion.Class392(@class);
			@class.scenario_0 = scenario_0;
			@class.string_0 = string_8;
			try
			{
				Explosion.Class391 class2 = new Explosion.Class391(class2);
				class2.class392_0 = @class;
				class2.geopoint_Struct_0 = this.method_77(1f);
				int num = this.int_0 * this.int_1;
				class2.concurrentBag_0 = new ConcurrentBag<ActiveUnit>();
				Parallel.ForEach<ActiveUnit>(class2.class392_0.scenario_0.vmethod_0().Values, new Action<ActiveUnit>(class2.method_0));
				try
				{
					foreach (ActiveUnit activeUnit in class2.concurrentBag_0)
					{
						if (activeUnit.bool_8 && ((Facility)activeUnit).bool_27)
						{
							List<Mount> list = new List<Mount>();
							IEnumerable<Mount> enumerable = Enumerable.Where<Mount>(activeUnit.vmethod_51(), (Explosion._Closure$__.$I65-1 == null) ? (Explosion._Closure$__.$I65-1 = new Func<Mount, bool>(Explosion._Closure$__.$I.method_0)) : Explosion._Closure$__.$I65-1);
							try
							{
								foreach (Mount mount in enumerable)
								{
									double theLon;
									double theLat;
									Class411.smethod_1(activeUnit.vmethod_28(null), activeUnit.vmethod_30(null), ref theLon, ref theLat, (double)(mount.method_27() / 1852f), (double)mount.method_26());
									if (GeoPoint.smethod_2(theLat, theLon, class2.geopoint_Struct_0, true))
									{
										list.Add(mount);
									}
								}
							}
							finally
							{
								IEnumerator<Mount> enumerator2;
								if (enumerator2 != null)
								{
									enumerator2.Dispose();
								}
							}
							try
							{
								foreach (Mount mount2 in list)
								{
									double double_ = (double)Warhead.smethod_2(mount2, this.double_2, this.int_2, this.float_9, (double)num, this.warheadType_0, this.enum126_0);
									mount2.method_46(double_, this.warheadType_0, (float)this.int_0);
								}
								continue;
							}
							finally
							{
								List<Mount>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
						}
						double num2 = Warhead.smethod_1((Class350)activeUnit, this.double_2, (double)num, this.vmethod_9());
						activeUnit.vmethod_91().method_2((float)num2, this.warheadType_0, this.enum126_0, (float)this.int_0);
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
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100851", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x001D4E80 File Offset: 0x001D3080
		public static float smethod_1(double double_7, Weapon.Enum128 enum128_0)
		{
			double d = double_7 * 1.0;
			double num = Math.Exp(0.3315 * Math.Log(d) + 2.9034);
			float result;
			switch (enum128_0)
			{
			case Weapon.Enum128.const_0:
			case Weapon.Enum128.const_1:
				result = (float)(num / 1852.0);
				break;
			case Weapon.Enum128.const_2:
				result = (float)(num * 4.4114977307110435 / 1852.0);
				break;
			case Weapon.Enum128.const_3:
				result = (float)(num * 8.822995461422087 / 1852.0);
				break;
			case Weapon.Enum128.const_4:
				result = 0f;
				break;
			default:
				throw new NotImplementedException();
			}
			return result;
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x001D4F24 File Offset: 0x001D3124
		public static float smethod_2(double double_7, Weapon.Enum128 enum128_0)
		{
			double num;
			if (enum128_0 != Weapon.Enum128.const_0)
			{
				if (enum128_0 != Weapon.Enum128.const_4)
				{
					num = 0.0;
				}
				else
				{
					num = 10.0 * double_7;
				}
			}
			else
			{
				num = 10.0 * Math.Pow(double_7, 0.3333333333333333);
			}
			return (float)(num / 1852.0);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x001D4F7C File Offset: 0x001D317C
		private double method_79(double double_7, double double_8)
		{
			double result;
			if (double_8 < 0.15 && double_8 > -3.0)
			{
				double num;
				double num2;
				double num3;
				double num4;
				double num5;
				double num6;
				if (double_8 >= 0.0)
				{
					if (double_7 <= 1.0)
					{
						num = -1.05;
						num2 = -0.105;
						num3 = 0.0573;
						num4 = -0.5;
						num5 = 16989.0;
						num6 = 5.0;
					}
					else
					{
						if (double_7 < 20.0)
						{
							return result;
						}
						num = -2.0;
						num2 = -0.3044;
						num3 = 0.0707;
						num4 = -0.9059;
						num5 = 5663.0;
						num6 = 5.0;
					}
				}
				else if (double_7 <= 1.0)
				{
					num = 0.258;
					num2 = 0.01;
					num3 = 0.1;
					num4 = 1.9;
					num5 = 16989.0;
					num6 = 5.0;
				}
				else
				{
					if (double_7 < 20.0)
					{
						return result;
					}
					num = 0.53;
					num2 = 0.028;
					num3 = -0.021739130434782608;
					num4 = 1.74;
					num5 = 5663.0;
					num6 = 5.0;
				}
				result = num5 / num6 * Math.Pow(10.0, num4 * (Math.Exp(num * double_8 + num2 * double_8 * double_8) - 1.0) + num3 * double_8);
			}
			else if (double_8 >= 5.0 && double_8 <= 40.0)
			{
				double num7 = 9.34;
				double num8 = 0.131;
				double num9 = -0.00231;
				double num10 = 0.0;
				result = Math.Exp(num7 + num8 * double_8 + num9 * double_8 * double_8) - num10;
			}
			return result;
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x001D518C File Offset: 0x001D338C
		private bool method_80(double double_7, double double_8)
		{
			double num = Math.Pow(double_7, 0.3333333333333333);
			return double_8 < 3.0 * num;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x001D51B8 File Offset: 0x001D33B8
		private void method_81(double Yield_kT, ref double CraterRadius, ref double ApparentCraterRadius, ref double CraterDepth, double HOB = 0.0)
		{
			try
			{
				double num = 0.29411764705882354;
				if (Yield_kT >= 0.1 && Yield_kT <= 30000.0)
				{
					double num2 = Math.Pow(Yield_kT, 0.3333333333333333);
					if (HOB >= -40.0 * num2 && HOB <= 3.0 * num2)
					{
						double num3 = -HOB / num2;
						double num4;
						if (num3 < 0.15)
						{
							num4 = 0.3333333333333333;
						}
						else if (num3 < 5.0)
						{
							num4 = 0.2946 * Math.Exp(-num3 * Math.Log10(583.0)) / Math.Sqrt(305.0);
						}
						else
						{
							num4 = 0.29411764705882354;
						}
						double x;
						if (Yield_kT < 1.0)
						{
							double num5 = num4;
							double double_ = -HOB / Math.Pow(Yield_kT, num5);
							double num6 = this.method_79(Yield_kT, double_);
							x = num6 * Math.Pow(Yield_kT, 3.0 * num5);
						}
						else if (Yield_kT > 20.0)
						{
							double num5 = num;
							double double_ = -HOB / Math.Pow(Yield_kT, num5);
							double num7 = this.method_79(Yield_kT, double_);
							x = num7 * Math.Pow(Yield_kT, 3.0 * num5);
						}
						else
						{
							double num8 = 1.0 - Math.Min(1.0, Math.Max(0.0, Math.Log(Yield_kT) / Math.Log(20.0)));
							double num5 = 3.0 * (num + num8 * (num4 - num));
							double num6 = this.method_79(1.0, -HOB);
							double num7 = this.method_79(20.0, -HOB / Math.Pow(20.0, num5));
							if (num7 != 0.0)
							{
								x = num7 * Math.Pow(num6 / num7, num8) * Math.Pow(Yield_kT, num5);
							}
							else
							{
								x = 0.0;
							}
						}
						ApparentCraterRadius = 1.2 * Math.Pow(x, 0.3333333333333333);
						double num9 = 1.8 * ApparentCraterRadius;
						CraterRadius = num9;
						CraterDepth = 0.5 * Math.Pow(x, 0.3333333333333333);
					}
				}
			}
			catch (Exception ex)
			{
				CraterRadius = 0.0;
				CraterDepth = 0.0;
				ex.Data.Add("Error at 200041", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0000B9CF File Offset: 0x00009BCF
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x001D54A4 File Offset: 0x001D36A4
		internal float method_82(double double_7)
		{
			float result;
			if (this.vmethod_14(false) <= 12000f)
			{
				result = Explosion.smethod_1(double_7, Weapon.Enum128.const_0);
			}
			else
			{
				result = Explosion.smethod_1(double_7, Weapon.Enum128.const_0) * this.vmethod_14(false) / 12000f;
			}
			return result;
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x001D54E0 File Offset: 0x001D36E0
		private void method_83(Scenario scenario_0)
		{
			try
			{
				float num = this.method_82(this.double_2);
				ConcurrentBag<ActiveUnit> concurrentBag = new ConcurrentBag<ActiveUnit>();
				try
				{
					foreach (ActiveUnit activeUnit in scenario_0.method_42())
					{
						if (!Information.IsNothing(activeUnit) && (activeUnit.vmethod_127() || (activeUnit.vmethod_55() && activeUnit.vmethod_128())) && !activeUnit.bool_1 && !activeUnit.bool_2 && (!activeUnit.bool_8 || ((Facility)activeUnit)._FacilityCategory_0 != Facility._FacilityCategory.Building_Underground) && activeUnit.vmethod_14(false) >= 0f && (double)base.method_37(activeUnit, 0f) < (double)num)
						{
							concurrentBag.Add(activeUnit);
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
					foreach (ActiveUnit activeUnit2 in concurrentBag)
					{
						float float_ = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), activeUnit2.vmethod_30(null), activeUnit2.vmethod_28(null));
						if (Math.Abs(this.vmethod_14(false) - activeUnit2.vmethod_14(false)) != 0f)
						{
							Class437.smethod_4(float_, Math.Abs(this.vmethod_14(false) - activeUnit2.vmethod_14(false)));
						}
						if (base.method_42(activeUnit2, ref scenario_0, false))
						{
							float float_2 = 1f - base.method_37(activeUnit2, 0f) / num;
							activeUnit2.vmethod_91().method_14(float_2);
						}
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
			catch (Exception ex)
			{
				ex.Data.Add("Error at 192758436", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x001D5710 File Offset: 0x001D3910
		public static void smethod_3(Explosion explosion_0, Scenario scenario_0)
		{
			foreach (IEventExporter eventExporter in scenario_0.method_6())
			{
				if (eventExporter.imethod_8() && eventExporter.imethod_24())
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
					dictionary.Add("ExplosionID", new IEventExporter.EventNotificationParameter(explosion_0.string_0, typeof(string), 40));
					dictionary.Add("ExplosionType", new IEventExporter.EventNotificationParameter((int)explosion_0.warheadType_0, typeof(int), 0));
					dictionary.Add("Longitude", new IEventExporter.EventNotificationParameter(Conversions.ToString(explosion_0.vmethod_28(null)), typeof(double), 0));
					dictionary.Add("Latitude", new IEventExporter.EventNotificationParameter(Conversions.ToString(explosion_0.vmethod_30(null)), typeof(double), 0));
					dictionary.Add("Altitude", new IEventExporter.EventNotificationParameter(Conversions.ToString(explosion_0.vmethod_14(false)), typeof(float), 0));
					dictionary.Add("EventType", new IEventExporter.EventNotificationParameter("Explosion", typeof(string), 40));
					eventExporter.imethod_6(IEventExporter.ExportedEventType.Explosion, dictionary, scenario_0);
				}
			}
			foreach (Interface8 @interface in Class409.interface8_0)
			{
				if (@interface.imethod_2())
				{
					@interface.imethod_1(Interface8.Enum135.const_4, new Dictionary<string, Tuple<Type, string>>
					{
						{
							"TimelineID",
							new Tuple<Type, string>(typeof(string), scenario_0.TimelineID)
						},
						{
							"Time",
							new Tuple<Type, string>(typeof(DateTime), scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + scenario_0.method_31().Millisecond.ToString("D3"))
						},
						{
							"ExplosionID",
							new Tuple<Type, string>(typeof(string), explosion_0.string_0)
						},
						{
							"ExplosionType",
							new Tuple<Type, string>(typeof(int), Conversions.ToString((int)explosion_0.warheadType_0))
						},
						{
							"Longitude",
							new Tuple<Type, string>(typeof(double), Conversions.ToString(explosion_0.vmethod_28(null)))
						},
						{
							"Latitude",
							new Tuple<Type, string>(typeof(double), Conversions.ToString(explosion_0.vmethod_30(null)))
						},
						{
							"Altitude",
							new Tuple<Type, string>(typeof(float), Conversions.ToString(explosion_0.vmethod_14(false)))
						},
						{
							"EventType",
							new Tuple<Type, string>(typeof(string), "Explosion")
						}
					}, scenario_0);
				}
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0000D199 File Offset: 0x0000B399
		[CompilerGenerated]
		private bool method_84(Mount mount_2)
		{
			return mount_2.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && mount_2 != this.mount_0 && mount_2 != this.mount_1;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0000D199 File Offset: 0x0000B399
		[CompilerGenerated]
		private bool method_85(Mount mount_2)
		{
			return mount_2.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && mount_2 != this.mount_0 && mount_2 != this.mount_1;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0000D199 File Offset: 0x0000B399
		[CompilerGenerated]
		private bool method_86(Mount mount_2)
		{
			return mount_2.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && mount_2 != this.mount_0 && mount_2 != this.mount_1;
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0000D199 File Offset: 0x0000B399
		[CompilerGenerated]
		private bool method_87(Mount mount_2)
		{
			return mount_2.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && mount_2 != this.mount_0 && mount_2 != this.mount_1;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0000D199 File Offset: 0x0000B399
		[CompilerGenerated]
		private bool method_88(Mount mount_2)
		{
			return mount_2.vmethod_5() != PlatformComponent._ComponentStatus.Destroyed && mount_2 != this.mount_0 && mount_2 != this.mount_1;
		}

		// Token: 0x040016A4 RID: 5796
		public double double_2;

		// Token: 0x040016A5 RID: 5797
		public double double_3;

		// Token: 0x040016A6 RID: 5798
		private double double_4;

		// Token: 0x040016A7 RID: 5799
		public Warhead.WarheadType warheadType_0;

		// Token: 0x040016A8 RID: 5800
		public Weapon._WeaponType _WeaponType_0;

		// Token: 0x040016A9 RID: 5801
		public Warhead.Enum126 enum126_0;

		// Token: 0x040016AA RID: 5802
		public int int_0;

		// Token: 0x040016AB RID: 5803
		public int int_1;

		// Token: 0x040016AC RID: 5804
		public int int_2;

		// Token: 0x040016AD RID: 5805
		public float float_9;

		// Token: 0x040016AE RID: 5806
		private ActiveUnit activeUnit_0;

		// Token: 0x040016AF RID: 5807
		private Mount mount_0;

		// Token: 0x040016B0 RID: 5808
		private ActiveUnit activeUnit_1;

		// Token: 0x040016B1 RID: 5809
		private Mount mount_1;

		// Token: 0x040016B2 RID: 5810
		private string string_4;

		// Token: 0x040016B3 RID: 5811
		private string string_5;

		// Token: 0x040016B4 RID: 5812
		private string string_6;

		// Token: 0x040016B5 RID: 5813
		private string string_7;

		// Token: 0x040016B6 RID: 5814
		private float? nullable_10;

		// Token: 0x040016B7 RID: 5815
		private bool? nullable_11;

		// Token: 0x040016B8 RID: 5816
		private bool? nullable_12;

		// Token: 0x040016B9 RID: 5817
		private double double_5;

		// Token: 0x040016BA RID: 5818
		private double double_6;

		// Token: 0x02000360 RID: 864
		[CompilerGenerated]
		internal sealed class Class381
		{
			// Token: 0x060019E1 RID: 6625 RVA: 0x0000D1BB File Offset: 0x0000B3BB
			public Class381(Explosion.Class381 class381_0)
			{
				if (class381_0 != null)
				{
					this.scenario_0 = class381_0.scenario_0;
					this.string_0 = class381_0.string_0;
				}
			}

			// Token: 0x040016BB RID: 5819
			public Scenario scenario_0;

			// Token: 0x040016BC RID: 5820
			public string string_0;

			// Token: 0x040016BD RID: 5821
			public Explosion explosion_0;
		}

		// Token: 0x02000361 RID: 865
		[CompilerGenerated]
		internal sealed class Class382
		{
			// Token: 0x060019E2 RID: 6626 RVA: 0x0000D1DE File Offset: 0x0000B3DE
			public Class382(Explosion.Class382 class382_0)
			{
				if (class382_0 != null)
				{
					this.concurrentBag_0 = class382_0.concurrentBag_0;
					this.float_0 = class382_0.float_0;
				}
			}

			// Token: 0x060019E3 RID: 6627 RVA: 0x001D5B10 File Offset: 0x001D3D10
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (!Information.IsNothing(activeUnit_0) && activeUnit_0.vmethod_127())
				{
					if (activeUnit_0.method_6())
					{
						if (this.class381_0.explosion_0.method_43(activeUnit_0, ref this.class381_0.scenario_0, false) == Unit.Enum123.const_1)
						{
							this.concurrentBag_0.Add(activeUnit_0);
							return;
						}
					}
					else if (!activeUnit_0.bool_2 && !activeUnit_0.bool_3 && !activeUnit_0.bool_1 && activeUnit_0 != this.class381_0.explosion_0.activeUnit_0 && activeUnit_0 != this.class381_0.explosion_0.activeUnit_1 && this.class381_0.explosion_0.method_37(activeUnit_0, 0f) <= this.float_0 && Operators.CompareString(this.class381_0.string_0, activeUnit_0.string_0, false) != 0 && (!this.class381_0.explosion_0.method_15() || this.class381_0.explosion_0.method_43(activeUnit_0, ref this.class381_0.scenario_0, false) == Unit.Enum123.const_1))
					{
						this.concurrentBag_0.Add(activeUnit_0);
					}
				}
			}

			// Token: 0x040016BE RID: 5822
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040016BF RID: 5823
			public float float_0;

			// Token: 0x040016C0 RID: 5824
			public Explosion.Class381 class381_0;
		}

		// Token: 0x02000362 RID: 866
		[CompilerGenerated]
		internal sealed class Class383
		{
			// Token: 0x060019E4 RID: 6628 RVA: 0x0000D201 File Offset: 0x0000B401
			public Class383(Explosion.Class383 class383_0)
			{
				if (class383_0 != null)
				{
					this.float_0 = class383_0.float_0;
					this.double_0 = class383_0.double_0;
					this.concurrentBag_0 = class383_0.concurrentBag_0;
				}
			}

			// Token: 0x060019E5 RID: 6629 RVA: 0x001D5C2C File Offset: 0x001D3E2C
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.vmethod_127() && !activeUnit_0.bool_2 && !activeUnit_0.bool_3 && !activeUnit_0.bool_1 && activeUnit_0 != this.explosion_0.activeUnit_1)
				{
					this.float_0 = this.explosion_0.method_37(activeUnit_0, 0f);
					if ((double)(this.float_0 * 1852f) <= this.double_0)
					{
						this.concurrentBag_0.Add(activeUnit_0);
					}
				}
			}

			// Token: 0x040016C1 RID: 5825
			public float float_0;

			// Token: 0x040016C2 RID: 5826
			public double double_0;

			// Token: 0x040016C3 RID: 5827
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040016C4 RID: 5828
			public Explosion explosion_0;
		}

		// Token: 0x02000363 RID: 867
		[CompilerGenerated]
		internal sealed class Class384
		{
			// Token: 0x060019E6 RID: 6630 RVA: 0x001D5CA0 File Offset: 0x001D3EA0
			public Class384(Explosion.Class384 class384_0)
			{
				if (class384_0 != null)
				{
					this.string_0 = class384_0.string_0;
					this.float_0 = class384_0.float_0;
					this.float_1 = class384_0.float_1;
					this.concurrentBag_0 = class384_0.concurrentBag_0;
					this.float_2 = class384_0.float_2;
					this.concurrentBag_1 = class384_0.concurrentBag_1;
				}
			}

			// Token: 0x060019E7 RID: 6631 RVA: 0x001D5D00 File Offset: 0x001D3F00
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.vmethod_127() && !activeUnit_0.bool_2 && !activeUnit_0.bool_3 && !activeUnit_0.bool_1 && activeUnit_0 != this.explosion_0.activeUnit_1 && Operators.CompareString(this.string_0, activeUnit_0.string_0, false) != 0)
				{
					this.float_0 = this.explosion_0.method_37(activeUnit_0, 0f);
					if (this.float_0 * 1852f <= this.float_1)
					{
						this.concurrentBag_0.Add(activeUnit_0);
						return;
					}
					if (this.float_0 * 1852f <= this.float_2)
					{
						this.concurrentBag_1.Add(activeUnit_0);
					}
				}
			}

			// Token: 0x040016C5 RID: 5829
			public string string_0;

			// Token: 0x040016C6 RID: 5830
			public float float_0;

			// Token: 0x040016C7 RID: 5831
			public float float_1;

			// Token: 0x040016C8 RID: 5832
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040016C9 RID: 5833
			public float float_2;

			// Token: 0x040016CA RID: 5834
			public ConcurrentBag<ActiveUnit> concurrentBag_1;

			// Token: 0x040016CB RID: 5835
			public Explosion explosion_0;
		}

		// Token: 0x02000364 RID: 868
		[CompilerGenerated]
		internal sealed class Class385
		{
			// Token: 0x060019E8 RID: 6632 RVA: 0x0000D230 File Offset: 0x0000B430
			public Class385(Explosion.Class385 class385_0)
			{
				if (class385_0 != null)
				{
					this.string_0 = class385_0.string_0;
					this.scenario_0 = class385_0.scenario_0;
					this.warheadType_0 = class385_0.warheadType_0;
					this.enum128_0 = class385_0.enum128_0;
				}
			}

			// Token: 0x040016CC RID: 5836
			public string string_0;

			// Token: 0x040016CD RID: 5837
			public Scenario scenario_0;

			// Token: 0x040016CE RID: 5838
			public Warhead.WarheadType warheadType_0;

			// Token: 0x040016CF RID: 5839
			public Weapon.Enum128 enum128_0;

			// Token: 0x040016D0 RID: 5840
			public Explosion explosion_0;
		}

		// Token: 0x02000365 RID: 869
		[CompilerGenerated]
		internal sealed class Class386
		{
			// Token: 0x060019E9 RID: 6633 RVA: 0x0000D26B File Offset: 0x0000B46B
			public Class386(Explosion.Class386 class386_0)
			{
				if (class386_0 != null)
				{
					this.double_0 = class386_0.double_0;
					this.double_1 = class386_0.double_1;
					this.concurrentBag_0 = class386_0.concurrentBag_0;
				}
			}

			// Token: 0x060019EA RID: 6634 RVA: 0x001D5DB0 File Offset: 0x001D3FB0
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0 != null && Operators.CompareString(this.class385_0.string_0, activeUnit_0.string_0, false) != 0)
				{
					if (activeUnit_0.method_6())
					{
						float num = this.class385_0.explosion_0.method_37(activeUnit_0, 0f);
						double num2 = (double)num + (double)((Facility)activeUnit_0).int_9 * 0.000539957;
						if ((double)num + (double)((Facility)activeUnit_0).int_9 * 0.000539957 <= this.double_0 && num2 >= this.double_1 && this.class385_0.explosion_0.method_43(activeUnit_0, ref this.class385_0.scenario_0, false) == Unit.Enum123.const_1)
						{
							this.concurrentBag_0.Add(activeUnit_0);
							return;
						}
					}
					else if (activeUnit_0.vmethod_127() && !activeUnit_0.bool_1 && (!activeUnit_0.bool_2 || (this.class385_0.warheadType_0 == Warhead.WarheadType.Nuclear && ((Weapon)activeUnit_0).method_202())) && (!activeUnit_0.bool_3 || this.class385_0.explosion_0.warheadType_0 != Warhead.WarheadType.HE_BlastFrag) && (!activeUnit_0.bool_8 || ((Facility)activeUnit_0)._FacilityCategory_0 != Facility._FacilityCategory.Building_Underground) && activeUnit_0 != this.class385_0.explosion_0.activeUnit_1 && this.class385_0.explosion_0.method_70(activeUnit_0, this.class385_0.enum128_0))
					{
						double num3 = (double)this.class385_0.explosion_0.method_37(activeUnit_0, 0f);
						if (this.double_1 <= num3 && num3 <= this.double_0 && (!this.class385_0.explosion_0.method_15() || this.class385_0.explosion_0.method_43(activeUnit_0, ref this.class385_0.scenario_0, false) == Unit.Enum123.const_1))
						{
							this.concurrentBag_0.Add(activeUnit_0);
						}
					}
				}
			}

			// Token: 0x040016D1 RID: 5841
			public double double_0;

			// Token: 0x040016D2 RID: 5842
			public double double_1;

			// Token: 0x040016D3 RID: 5843
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040016D4 RID: 5844
			public Explosion.Class385 class385_0;
		}

		// Token: 0x02000366 RID: 870
		[CompilerGenerated]
		internal sealed class Class387
		{
			// Token: 0x060019EB RID: 6635 RVA: 0x0000D29A File Offset: 0x0000B49A
			public Class387(Explosion.Class387 class387_0)
			{
				if (class387_0 != null)
				{
					this.double_0 = class387_0.double_0;
					this.concurrentBag_0 = class387_0.concurrentBag_0;
				}
			}

			// Token: 0x060019EC RID: 6636 RVA: 0x001D5F98 File Offset: 0x001D4198
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.vmethod_127() && !activeUnit_0.bool_1)
				{
					if ((double)this.class388_0.explosion_0.method_27(new GeoPoint(activeUnit_0.vmethod_28(null), activeUnit_0.vmethod_30(null), activeUnit_0.vmethod_14(false))) <= this.double_0)
					{
						if (Operators.CompareString(this.class388_0.string_0, activeUnit_0.string_0, false) != 0)
						{
							this.concurrentBag_0.Add(activeUnit_0);
							return;
						}
					}
					else if (this.class388_0.explosion_0.vmethod_14(false) < 0f && activeUnit_0.vmethod_14(false) > this.class388_0.explosion_0.vmethod_14(false) && activeUnit_0.vmethod_14(false) < 2000f && (double)this.class388_0.explosion_0.method_25(activeUnit_0.vmethod_30(null), activeUnit_0.vmethod_28(null)) <= this.double_0 * 2.0 && Operators.CompareString(this.class388_0.string_0, activeUnit_0.string_0, false) != 0)
					{
						this.concurrentBag_0.Add(activeUnit_0);
					}
				}
			}

			// Token: 0x040016D5 RID: 5845
			public double double_0;

			// Token: 0x040016D6 RID: 5846
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040016D7 RID: 5847
			public Explosion.Class388 class388_0;
		}

		// Token: 0x02000367 RID: 871
		[CompilerGenerated]
		internal sealed class Class388
		{
			// Token: 0x060019ED RID: 6637 RVA: 0x0000D2BD File Offset: 0x0000B4BD
			public Class388(Explosion.Class388 class388_0)
			{
				if (class388_0 != null)
				{
					this.string_0 = class388_0.string_0;
				}
			}

			// Token: 0x040016D8 RID: 5848
			public string string_0;

			// Token: 0x040016D9 RID: 5849
			public Explosion explosion_0;
		}

		// Token: 0x02000368 RID: 872
		[CompilerGenerated]
		internal sealed class Class389
		{
			// Token: 0x060019EE RID: 6638 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
			public Class389(Explosion.Class389 class389_0)
			{
				if (class389_0 != null)
				{
					this.double_0 = class389_0.double_0;
					this.concurrentBag_0 = class389_0.concurrentBag_0;
				}
			}

			// Token: 0x060019EF RID: 6639 RVA: 0x001D60D0 File Offset: 0x001D42D0
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.vmethod_127() && !activeUnit_0.bool_1 && activeUnit_0.vmethod_14(false) >= 0f && activeUnit_0.vmethod_13() >= 0f && (double)this.class390_0.explosion_0.method_27(new GeoPoint(activeUnit_0.vmethod_28(null), activeUnit_0.vmethod_30(null), activeUnit_0.vmethod_14(false))) <= this.double_0 && Operators.CompareString(this.class390_0.string_0, activeUnit_0.string_0, false) != 0)
				{
					this.concurrentBag_0.Add(activeUnit_0);
				}
			}

			// Token: 0x040016DA RID: 5850
			public double double_0;

			// Token: 0x040016DB RID: 5851
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040016DC RID: 5852
			public Explosion.Class390 class390_0;
		}

		// Token: 0x02000369 RID: 873
		[CompilerGenerated]
		internal sealed class Class390
		{
			// Token: 0x060019F0 RID: 6640 RVA: 0x0000D2F7 File Offset: 0x0000B4F7
			public Class390(Explosion.Class390 class390_0)
			{
				if (class390_0 != null)
				{
					this.string_0 = class390_0.string_0;
				}
			}

			// Token: 0x040016DD RID: 5853
			public string string_0;

			// Token: 0x040016DE RID: 5854
			public Explosion explosion_0;
		}

		// Token: 0x0200036A RID: 874
		[CompilerGenerated]
		internal sealed class Class391
		{
			// Token: 0x060019F1 RID: 6641 RVA: 0x0000D30E File Offset: 0x0000B50E
			public Class391(Explosion.Class391 class391_0)
			{
				if (class391_0 != null)
				{
					this.concurrentBag_0 = class391_0.concurrentBag_0;
					this.geopoint_Struct_0 = class391_0.geopoint_Struct_0;
				}
			}

			// Token: 0x060019F2 RID: 6642 RVA: 0x001D6178 File Offset: 0x001D4378
			internal void method_0(ActiveUnit activeUnit_0)
			{
				if (activeUnit_0.method_6())
				{
					this.concurrentBag_0.Add(activeUnit_0);
					return;
				}
				if (!activeUnit_0.bool_2 && !activeUnit_0.bool_3 && !activeUnit_0.bool_1 && activeUnit_0.vmethod_127() && activeUnit_0.method_45(this.geopoint_Struct_0, this.class392_0.scenario_0, false) && Operators.CompareString(this.class392_0.string_0, activeUnit_0.string_0, false) != 0)
				{
					this.concurrentBag_0.Add(activeUnit_0);
				}
			}

			// Token: 0x040016DF RID: 5855
			public ConcurrentBag<ActiveUnit> concurrentBag_0;

			// Token: 0x040016E0 RID: 5856
			public Geopoint_Struct[] geopoint_Struct_0;

			// Token: 0x040016E1 RID: 5857
			public Explosion.Class392 class392_0;
		}

		// Token: 0x0200036B RID: 875
		[CompilerGenerated]
		internal sealed class Class392
		{
			// Token: 0x060019F3 RID: 6643 RVA: 0x0000D331 File Offset: 0x0000B531
			public Class392(Explosion.Class392 class392_0)
			{
				if (class392_0 != null)
				{
					this.scenario_0 = class392_0.scenario_0;
					this.string_0 = class392_0.string_0;
				}
			}

			// Token: 0x040016E2 RID: 5858
			public Scenario scenario_0;

			// Token: 0x040016E3 RID: 5859
			public string string_0;
		}
	}
}
