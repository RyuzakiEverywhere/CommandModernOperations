using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using DarkUI.Collections;
using Easy.Common;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns9;

namespace Command_Core
{
	// Token: 0x0200037D RID: 893
	public class Weapon : ActiveUnit, Interface6
	{
		// Token: 0x06001AAD RID: 6829 RVA: 0x0000D845 File Offset: 0x0000BA45
		[CompilerGenerated]
		public virtual ObservableList<WeaponRec> vmethod_139()
		{
			return this.observableList_2;
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0000D84D File Offset: 0x0000BA4D
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public virtual void vmethod_140(ObservableList<WeaponRec> observableList_3)
		{
			this.observableList_2 = observableList_3;
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x001E1DAC File Offset: 0x001DFFAC
		[CompilerGenerated]
		public static void smethod_10(Weapon.Delegate55 delegate55_1)
		{
			Weapon.Delegate55 @delegate = Weapon.delegate55_0;
			Weapon.Delegate55 delegate2;
			do
			{
				delegate2 = @delegate;
				Weapon.Delegate55 value = (Weapon.Delegate55)Delegate.Combine(delegate2, delegate55_1);
				@delegate = Interlocked.CompareExchange<Weapon.Delegate55>(ref Weapon.delegate55_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x001E1DE0 File Offset: 0x001DFFE0
		public override bool vmethod_6()
		{
			bool result;
			if (GameGeneral.smethod_6() && !GameGeneral.bool_1)
			{
				result = false;
			}
			else
			{
				if (this.nullable_17 == null)
				{
					if (Information.IsNothing(this.method_177()))
					{
						return false;
					}
					this.nullable_17 = new bool?(this.method_167() == Weapon._WeaponType.RV || this.method_167() == Weapon._WeaponType.GuidedWeapon);
				}
				result = this.nullable_17.Value;
			}
			return result;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00008563 File Offset: 0x00006763
		public override float vmethod_22()
		{
			return base.vmethod_22();
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0000856B File Offset: 0x0000676B
		public override void vmethod_23(float float_52)
		{
			base.vmethod_23(float_52);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x001E1E54 File Offset: 0x001E0054
		internal float method_140()
		{
			Weapon._WeaponType weaponType = this.method_167();
			if (weaponType <= Weapon._WeaponType.GuidedProjectile)
			{
				switch (weaponType)
				{
				case Weapon._WeaponType.GuidedWeapon:
					return -5f;
				case Weapon._WeaponType.Rocket:
				case Weapon._WeaponType.Gun:
					return -30f;
				case Weapon._WeaponType.IronBomb:
					break;
				default:
					if (weaponType == Weapon._WeaponType.GuidedProjectile)
					{
						return -30f;
					}
					break;
				}
			}
			else
			{
				if (weaponType == Weapon._WeaponType.Torpedo)
				{
					return -85f;
				}
				if (weaponType - Weapon._WeaponType.BallisticMissile <= 1)
				{
					return -80f;
				}
				if (weaponType == Weapon._WeaponType.HGV)
				{
					return -70f;
				}
			}
			return 0f;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x001E1EE8 File Offset: 0x001E00E8
		public override void vmethod_1()
		{
			base.vmethod_1();
			Warhead[] array = this.warhead_0;
			checked
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i].vmethod_1();
				}
			}
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0000D856 File Offset: 0x0000BA56
		internal float method_141()
		{
			return this.float_51;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0000D85E File Offset: 0x0000BA5E
		internal void method_142(float float_52)
		{
			this.float_51 = float_52;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x001E1F18 File Offset: 0x001E0118
		public override void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Weapon");
					xmlWriter_0.WriteElementString("ID", this.string_0);
					if (hashSet_1.Contains(this.string_0))
					{
						xmlWriter_0.WriteEndElement();
					}
					else
					{
						hashSet_1.Add(this.string_0);
						xmlWriter_0.WriteElementString("Name", this.Name.Replace("\0", "").Replace("\u0010", ""));
						xmlWriter_0.WriteElementString("CH", XmlConvert.ToString(this.vmethod_9()));
						xmlWriter_0.WriteElementString("CS", XmlConvert.ToString(this.vmethod_40()));
						xmlWriter_0.WriteElementString("CA", XmlConvert.ToString(this.vmethod_14(false)));
						xmlWriter_0.WriteElementString("ImpactAltitude", XmlConvert.ToString(this.vmethod_16()));
						xmlWriter_0.WriteElementString("Lon", XmlConvert.ToString(this.vmethod_28(null)));
						xmlWriter_0.WriteElementString("Lat", XmlConvert.ToString(this.vmethod_30(null)));
						if (base.method_58() != null)
						{
							xmlWriter_0.WriteElementString("LonLR", XmlConvert.ToString(base.method_58().Value));
						}
						if (base.method_56() != null)
						{
							xmlWriter_0.WriteElementString("LatLR", XmlConvert.ToString(base.method_56().Value));
						}
						if (this.vmethod_18() != 0f)
						{
							xmlWriter_0.WriteElementString("Pitch", XmlConvert.ToString(this.vmethod_18()));
						}
						if (this.vmethod_20() != 0f)
						{
							xmlWriter_0.WriteElementString("Roll", XmlConvert.ToString(this.vmethod_20()));
						}
						if (this.vmethod_36() != null)
						{
							xmlWriter_0.WriteElementString("Longitude_UnitEntersAreaCheck", XmlConvert.ToString(this.vmethod_36().Value));
						}
						if (this.vmethod_38() != null)
						{
							xmlWriter_0.WriteElementString("Latitude_UnitEntersAreaCheck", XmlConvert.ToString(this.vmethod_38().Value));
						}
						if (this.list_0.Count > 0)
						{
							xmlWriter_0.WriteStartElement("ActiveEnterAreaTriggers");
							try
							{
								foreach (string value in this.list_0)
								{
									xmlWriter_0.WriteElementString("ActiveEnterAreaTrigger", value);
								}
							}
							finally
							{
								List<string>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("CEP_Surface", Conversions.ToString(XmlConvert.ToDouble(Conversions.ToString(this.method_172()))));
						xmlWriter_0.WriteElementString("CEP_Land", Conversions.ToString(XmlConvert.ToDouble(Conversions.ToString(this.method_174()))));
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
								List<RangeSymbol>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						if (Information.IsNothing(this.vmethod_7(false)))
						{
							foreach (Side side in this.scenario_0.method_44())
							{
								if (Enumerable.Contains<ActiveUnit>(side.activeUnit_0, this))
								{
									this.side_0 = side;
									break;
								}
							}
						}
						if (!Information.IsNothing(this.vmethod_7(false)))
						{
							xmlWriter_0.WriteElementString("Side", this.vmethod_7(false).method_51());
						}
						if (!string.IsNullOrEmpty(this.string_3))
						{
							xmlWriter_0.WriteElementString("Message", this.string_3);
						}
						xmlWriter_0.WriteElementString("DBID", this.DBID.ToString());
						xmlWriter_0.WriteElementString("DH", XmlConvert.ToString(this.vmethod_68()));
						xmlWriter_0.WriteElementString("DS", XmlConvert.ToString(this.vmethod_70()));
						xmlWriter_0.WriteElementString("DA", XmlConvert.ToString(this.vmethod_72()));
						xmlWriter_0.WriteElementString("DT", ((byte)this.vmethod_78()).ToString());
						xmlWriter_0.WriteElementString("DTN", ((byte)this.vmethod_80()).ToString());
						if (this.vmethod_76(this))
						{
							xmlWriter_0.WriteElementString("TerrainFollowing", this.vmethod_76(this).ToString());
						}
						xmlWriter_0.WriteElementString("TS", ((byte)this.vmethod_84()).ToString());
						xmlWriter_0.WriteStartElement("Sensors");
						foreach (Sensor sensor in this.sensor_0)
						{
							xmlWriter_0.WriteRaw(sensor.method_23(hashSet_1));
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Comms");
						foreach (CommDevice commDevice in this.commDevice_0)
						{
							xmlWriter_0.WriteRaw(commDevice.method_23(ref hashSet_1));
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Propulsion");
						try
						{
							foreach (Engine engine in this.vmethod_49())
							{
								xmlWriter_0.WriteRaw(engine.method_23(hashSet_1));
							}
						}
						finally
						{
							List<Engine>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Fuel");
						foreach (FuelRec fuelRec in this.fuelRec_0)
						{
							xmlWriter_0.WriteRaw(fuelRec.method_8());
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Mounts");
						try
						{
							foreach (Mount mount in this.vmethod_51())
							{
								if (mount.method_18() == null)
								{
									mount.method_19(this);
								}
								xmlWriter_0.WriteRaw(mount.method_23(ref hashSet_1, this.scenario_0));
							}
						}
						finally
						{
							List<Mount>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("OnboardCargo");
						foreach (Cargo cargo in this.cargo_0)
						{
							xmlWriter_0.WriteRaw(cargo.method_27(hashSet_1, this.scenario_0));
						}
						xmlWriter_0.WriteEndElement();
						XmlWriter xmlWriter = xmlWriter_0;
						string localName = "Status";
						byte b = (byte)this._ActiveUnitStatus_0;
						xmlWriter.WriteElementString(localName, b.ToString());
						XmlWriter xmlWriter2 = xmlWriter_0;
						string localName2 = "FuelState";
						b = (byte)this._ActiveUnitFuelState_0;
						xmlWriter2.WriteElementString(localName2, b.ToString());
						XmlWriter xmlWriter3 = xmlWriter_0;
						string localName3 = "WeaponState";
						b = (byte)this._ActiveUnitWeaponState_0;
						xmlWriter3.WriteElementString(localName3, b.ToString());
						XmlWriter xmlWriter4 = xmlWriter_0;
						string localName4 = "SBR";
						b = (byte)this._ActiveUnitStatus_2;
						xmlWriter4.WriteElementString(localName4, b.ToString());
						XmlWriter xmlWriter5 = xmlWriter_0;
						string localName5 = "SBED";
						b = (byte)this._ActiveUnitStatus_3;
						xmlWriter5.WriteElementString(localName5, b.ToString());
						XmlWriter xmlWriter6 = xmlWriter_0;
						string localName6 = "SBEO";
						b = (byte)this._ActiveUnitStatus_4;
						xmlWriter6.WriteElementString(localName6, b.ToString());
						XmlWriter xmlWriter7 = xmlWriter_0;
						string localName7 = "FSBR";
						b = (byte)this._ActiveUnitFuelState_1;
						xmlWriter7.WriteElementString(localName7, b.ToString());
						xmlWriter_0.WriteElementString("SBR_Altitude", XmlConvert.ToString(this.float_17));
						xmlWriter_0.WriteElementString("SBR_Altitude_TF", XmlConvert.ToString(this.float_18));
						xmlWriter_0.WriteElementString("SBR_TF", XmlConvert.ToString(this.bool_19));
						XmlWriter xmlWriter8 = xmlWriter_0;
						string localName8 = "SBR_ThrottleSetting";
						b = (byte)this.throttle_1;
						xmlWriter8.WriteElementString(localName8, b.ToString());
						xmlWriter_0.WriteElementString("SBED_Altitude", XmlConvert.ToString(this.float_19));
						if (this.nullable_14 != null)
						{
							xmlWriter_0.WriteElementString("SBED_Altitude_TF", XmlConvert.ToString(this.nullable_14.Value));
						}
						xmlWriter_0.WriteElementString("SBED_TF", XmlConvert.ToString(this.bool_20));
						XmlWriter xmlWriter9 = xmlWriter_0;
						string localName9 = "SBED_ThrottleSetting";
						b = (byte)this.throttle_2;
						xmlWriter9.WriteElementString(localName9, b.ToString());
						xmlWriter_0.WriteElementString("SBEO_Altitude", XmlConvert.ToString(this.float_20));
						xmlWriter_0.WriteElementString("SBEO_Altitude_TF", XmlConvert.ToString(this.float_21));
						xmlWriter_0.WriteElementString("SBEO_TF", XmlConvert.ToString(this.bool_21));
						XmlWriter xmlWriter10 = xmlWriter_0;
						string localName10 = "SBEO_ThrottleSetting";
						b = (byte)this.throttle_3;
						xmlWriter10.WriteElementString(localName10, b.ToString());
						xmlWriter_0.WriteElementString("SBPF_Altitude", XmlConvert.ToString(this.float_22));
						xmlWriter_0.WriteElementString("SBPF_Altitude_TF", XmlConvert.ToString(this.float_23));
						xmlWriter_0.WriteElementString("SBPF_TF", XmlConvert.ToString(this.bool_22));
						XmlWriter xmlWriter11 = xmlWriter_0;
						string localName11 = "SBPF_ThrottleSetting";
						b = (byte)this.throttle_4;
						xmlWriter11.WriteElementString(localName11, b.ToString());
						xmlWriter_0.WriteElementString("AMP_OC", this.bool_17.ToString());
						if (!Information.IsNothing(this.nullable_13))
						{
							xmlWriter_0.WriteElementString("AMP_OC_DSO", this.nullable_13.ToString());
						}
						xmlWriter_0.WriteElementString("AMP_OC_DAO", this.bool_18.ToString());
						xmlWriter_0.WriteElementString("AMP_OC_Speed", XmlConvert.ToString(this.float_16));
						if (this.method_141() > 0f)
						{
							xmlWriter_0.WriteElementString("TTReseek", XmlConvert.ToString(this.method_141()));
						}
						if (this.method_145() != 0f)
						{
							xmlWriter_0.WriteElementString("CruiseAltitude_ASL", XmlConvert.ToString(this.method_145()));
						}
						xmlWriter_0.WriteElementString("DamagePts", XmlConvert.ToString(this.vmethod_63(false, null)));
						if (this.airFacility_0.Length > 0)
						{
							xmlWriter_0.WriteStartElement("AirFacilities");
							foreach (AirFacility airFacility in this.airFacility_0)
							{
								xmlWriter_0.WriteRaw(airFacility.method_23(hashSet_1));
							}
							xmlWriter_0.WriteEndElement();
						}
						if (this.dockFacility_0.Length > 0)
						{
							xmlWriter_0.WriteStartElement("DockFacilities");
							foreach (DockFacility dockFacility in this.dockFacility_0)
							{
								xmlWriter_0.WriteRaw(dockFacility.method_23(hashSet_1));
							}
							xmlWriter_0.WriteEndElement();
						}
						if (!Information.IsNothing(this.mission_0))
						{
							xmlWriter_0.WriteElementString("AssignedMission", this.mission_0.string_0);
						}
						if (!Information.IsNothing(this.vmethod_103()))
						{
							xmlWriter_0.WriteElementString("AssignedTaskPool", this.mission_1.string_0);
						}
						if (!Information.IsNothing(this.vmethod_65(false)))
						{
							xmlWriter_0.WriteElementString("ParentGroup", this.group_0.string_0);
						}
						if (base.method_92(null))
						{
							xmlWriter_0.WriteElementString("IsAD", base.method_92(null).ToString());
						}
						this.doctrine_0.method_282(ref xmlWriter_0, ref this.scenario_0, "Doctrine");
						xmlWriter_0.WriteStartElement("Warheads");
						Warhead[] array2 = this.warhead_0;
						for (int num2 = 0; num2 < array2.Length; num2++)
						{
							array2[num2].method_8(ref xmlWriter_0);
						}
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteElementString("BT", this.float_48.ToString());
						xmlWriter_0.WriteElementString("DRT", this.float_49.ToString());
						if (!Information.IsNothing(this.method_179()))
						{
							xmlWriter_0.WriteElementString("DataLinkParent", this.method_179().string_0);
						}
						if (!Information.IsNothing(this.method_177()))
						{
							xmlWriter_0.WriteElementString("FiringParent", this.method_177().string_0);
						}
						if (!Information.IsNothing(this.enum127_0))
						{
							XmlWriter xmlWriter12 = xmlWriter_0;
							string localName12 = "SearchPatternType";
							b = (byte)this.enum127_0;
							xmlWriter12.WriteElementString(localName12, b.ToString());
						}
						xmlWriter_0.WriteElementString("Guidance", ((int)this.method_169()).ToString());
						xmlWriter_0.WriteStartElement("LaunchPoint");
						xmlWriter_0.WriteRaw(this.geoPoint_0.method_8(hashSet_1));
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteElementString("TTD", XmlConvert.ToString(this.float_50));
						if (!Information.IsNothing(this.sensor_2))
						{
							xmlWriter_0.WriteElementString("SIFM", this.sensor_2.string_0);
						}
						if (!Information.IsNothing(this.keyValuePair_0.Value))
						{
							xmlWriter_0.WriteStartElement("ARM_SE");
							xmlWriter_0.WriteElementString("Emission" + this.keyValuePair_0.Key.ToString(), this.keyValuePair_0.Value.ToString());
							xmlWriter_0.WriteEndElement();
						}
						if (this.vmethod_139().Count > 0)
						{
							xmlWriter_0.WriteStartElement("WeaponWeapons");
							try
							{
								foreach (WeaponRec weaponRec in this.vmethod_139())
								{
									xmlWriter_0.WriteRaw(weaponRec.method_8(hashSet_1, this.scenario_0));
								}
							}
							finally
							{
								List<WeaponRec>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
							xmlWriter_0.WriteEndElement();
						}
						xmlWriter_0.WriteElementString("ARM_SEIM", this.bool_28.ToString());
						if (!Information.IsNothing(this.activeUnit_2))
						{
							xmlWriter_0.WriteElementString("IlluminatorUnit", this.activeUnit_2.string_0);
						}
						this.method_187().vmethod_0(ref xmlWriter_0, ref hashSet_1);
						xmlWriter_0.WriteStartElement("Weapon_AI");
						this.vmethod_142().method_115(ref xmlWriter_0, ref hashSet_1);
						xmlWriter_0.WriteEndElement();
						xmlWriter_0.WriteStartElement("Weapon_Kinematics");
						this.vmethod_143().vmethod_0(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
						this.method_188().vmethod_2(ref xmlWriter_0);
						this.method_189().vmethod_0(ref xmlWriter_0, ref hashSet_1);
						this.method_190().vmethod_0(ref xmlWriter_0);
						xmlWriter_0.WriteEndElement();
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100881", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
			}
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x001E2D7C File Offset: 0x001E0F7C
		protected Weapon(string CustomGUID = null)
		{
			this.warhead_0 = new Warhead[0];
			this.hashSet_0 = new HashSet<int>();
			this.struct36_0 = default(Weapon.Struct36);
			this.vmethod_140(new ObservableList<WeaponRec>());
			this.list_3 = new List<Weapon.Enum130>();
			this.bool_31 = false;
			this.bool_32 = false;
			this.bool_33 = false;
			if (string.IsNullOrEmpty(CustomGUID))
			{
				this.vmethod_0(IDGenerator.smethod_0().method_0().ToLower());
			}
			else
			{
				this.vmethod_0(CustomGUID);
			}
			this.bool_2 = true;
			base.method_134();
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x001E2E10 File Offset: 0x001E1010
		public static Weapon smethod_11(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_1)
		{
			Weapon weapon;
			try
			{
				weapon = Weapon.smethod_13(xmlNode_0, dictionary_0, scenario_1, scenario_1.LoadStockUnits);
			}
			catch (Exception1 exception)
			{
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				dictionary_0.Remove(innerText);
				weapon = Weapon.smethod_13(xmlNode_0, dictionary_0, scenario_1, true);
				string text = "";
				if (weapon.method_120())
				{
					text = "(member of group: [" + weapon.vmethod_65(false).Name + "])";
				}
				scenario_1.LoadingNotices.Add(string.Concat(new string[]
				{
					"The following weapon:[",
					weapon.Name,
					"]",
					text,
					" failed to shallow-rebuild because of a component missing. The weapon was instead deep-rebuilt, and instantiated in its pristine DB-stock condition. All customizations present in the weapon's components (damaged components, additions/removals etc. etc.) have been lost. Please re-apply any necessary customizations either manually or using an SBR script."
				}));
			}
			return weapon;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x001E2EE8 File Offset: 0x001E10E8
		protected static void smethod_12(Weapon weapon_1, Scenario scenario_1, XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0)
		{
			try
			{
				foreach (object obj in xmlNode_0.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					string name = xmlNode.Name;
					uint num = Class582.smethod_0(name);
					if (num <= 2241118125U)
					{
						if (num <= 1305748348U)
						{
							if (num != 970174858U)
							{
								if (num != 1305748348U)
								{
									continue;
								}
								if (Operators.CompareString(name, "OnboardCargo", false) != 0)
								{
									continue;
								}
								try
								{
									foreach (object obj2 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode2 = (XmlNode)obj2;
										Cargo cargo = Cargo.smethod_2(ref xmlNode2, ref dictionary_0, weapon_1);
										Class429.smethod_6(ref weapon_1.cargo_0, cargo);
										cargo.method_19(weapon_1);
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
							if (Operators.CompareString(name, "WeaponWeapons", false) != 0)
							{
								continue;
							}
							try
							{
								foreach (object obj3 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode3 = (XmlNode)obj3;
									WeaponRec gparam_ = WeaponRec.smethod_2(ref xmlNode3, ref dictionary_0, ref scenario_1);
									weapon_1.vmethod_139().method_4(gparam_);
								}
								continue;
							}
							finally
							{
								IEnumerator enumerator3;
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
							}
						}
						if (num != 2008421230U)
						{
							if (num != 2241118125U)
							{
								continue;
							}
							if (Operators.CompareString(name, "Fuel", false) != 0)
							{
								continue;
							}
							try
							{
								foreach (object obj4 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode4 = (XmlNode)obj4;
									FuelRec fuelRec_ = FuelRec.smethod_0(ref xmlNode4, ref dictionary_0);
									Class429.smethod_19(ref weapon_1.fuelRec_0, fuelRec_);
								}
								continue;
							}
							finally
							{
								IEnumerator enumerator4;
								if (enumerator4 is IDisposable)
								{
									(enumerator4 as IDisposable).Dispose();
								}
							}
						}
						if (Operators.CompareString(name, "Comms", false) == 0)
						{
							int num2 = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num2; i++)
							{
								XmlNode xmlNode5 = xmlNode.ChildNodes[i];
								CommDevice commDevice = CommDevice.smethod_2(ref xmlNode5, ref dictionary_0, weapon_1);
								if (commDevice.DBID == 0)
								{
									Weapon weapon = new Weapon(null);
									weapon.scenario_0 = scenario_1;
									DBFunctions.smethod_60(scenario_1.method_39(), weapon, weapon_1.DBID, scenario_1, true);
									try
									{
										commDevice = weapon.vmethod_94()[i];
										goto IL_2A8;
									}
									catch (Exception ex)
									{
										ex.Data.Add("Error at 101179", "");
										GameGeneral.smethod_25(ref ex);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
										goto IL_2A8;
									}
									goto IL_278;
									IL_2A8:
									dictionary_0.Add(commDevice.string_0, commDevice);
								}
								IL_278:
								if (weapon_1.method_167() == Weapon._WeaponType.Sonobuoy)
								{
									commDevice.bool_12 = false;
								}
								weapon_1.method_101(commDevice);
								commDevice.method_19(weapon_1);
							}
						}
					}
					else
					{
						if (num <= 2424405304U)
						{
							if (num != 2246682072U)
							{
								if (num != 2424405304U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Sensors", false) != 0)
								{
									continue;
								}
								try
								{
									foreach (object obj5 in xmlNode.ChildNodes)
									{
										Sensor sensor = Sensor.smethod_2((XmlNode)obj5, dictionary_0, weapon_1);
										Class429.smethod_24(ref weapon_1.sensor_0, sensor);
										sensor.method_19(weapon_1);
									}
									continue;
								}
								finally
								{
									IEnumerator enumerator5;
									if (enumerator5 is IDisposable)
									{
										(enumerator5 as IDisposable).Dispose();
									}
								}
							}
							if (Operators.CompareString(name, "Propulsion", false) != 0)
							{
								continue;
							}
							try
							{
								foreach (object obj6 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode6 = (XmlNode)obj6;
									ActiveUnit activeUnit = weapon_1;
									Engine engine = Engine.smethod_2(ref xmlNode6, ref dictionary_0, ref activeUnit);
									weapon_1.vmethod_49().method_4(engine);
									engine.method_19(weapon_1);
								}
								continue;
							}
							finally
							{
								IEnumerator enumerator6;
								if (enumerator6 is IDisposable)
								{
									(enumerator6 as IDisposable).Dispose();
								}
							}
						}
						if (num != 3760177291U)
						{
							if (num != 3989581338U)
							{
								continue;
							}
							if (Operators.CompareString(name, "AirFacilities", false) != 0)
							{
								continue;
							}
							try
							{
								foreach (object obj7 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode7 = (XmlNode)obj7;
									AirFacility airFacility = AirFacility.smethod_3(ref xmlNode7, ref dictionary_0, ref scenario_1);
									weapon_1.method_103(airFacility);
									airFacility.method_19(weapon_1);
								}
								continue;
							}
							finally
							{
								IEnumerator enumerator7;
								if (enumerator7 is IDisposable)
								{
									(enumerator7 as IDisposable).Dispose();
								}
							}
						}
						if (Operators.CompareString(name, "Mounts", false) == 0)
						{
							try
							{
								foreach (object obj8 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode8 = (XmlNode)obj8;
									Mount mount = Mount.smethod_6(ref xmlNode8, ref dictionary_0, weapon_1);
									weapon_1.vmethod_51().method_4(mount);
									mount.method_19(weapon_1);
								}
							}
							finally
							{
								IEnumerator enumerator8;
								if (enumerator8 is IDisposable)
								{
									(enumerator8 as IDisposable).Dispose();
								}
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
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x001E34A8 File Offset: 0x001E16A8
		protected static Weapon smethod_13(XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0, Scenario scenario_1, bool bool_34)
		{
			Weapon result;
			try
			{
				XmlNode xmlNode = Misc.smethod_44(xmlNode_0.ChildNodes, "DBID");
				int num;
				if (!Information.IsNothing(xmlNode))
				{
					num = Conversions.ToInteger(xmlNode.InnerText);
					Weapon._WeaponType weaponType = DBFunctions.smethod_58(num, scenario_1);
					if (weaponType <= Weapon._WeaponType.Torpedo)
					{
						if (weaponType == Weapon._WeaponType.GuidedProjectile)
						{
							return Class352.smethod_24(xmlNode_0, dictionary_0, scenario_1, bool_34);
						}
						if (weaponType == Weapon._WeaponType.Torpedo)
						{
							return Class354.smethod_24(xmlNode_0, dictionary_0, scenario_1, bool_34);
						}
					}
					else
					{
						if (weaponType == Weapon._WeaponType.BallisticMissile)
						{
							return Class351.smethod_24(xmlNode_0, dictionary_0, scenario_1, bool_34);
						}
						if (weaponType == Weapon._WeaponType.HGV)
						{
							return Class353.smethod_24(xmlNode_0, dictionary_0, scenario_1, bool_34);
						}
					}
				}
				Weapon weapon = new Weapon(null);
				weapon.scenario_0 = scenario_1;
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Weapon)dictionary_0[innerText];
				}
				else
				{
					weapon.vmethod_0(innerText);
					if (xmlNode_0.ChildNodes.Count == 1)
					{
						scenario_1.UnitsForLateInstantiation.Add(xmlNode_0);
						result = weapon;
					}
					else
					{
						dictionary_0.Add(weapon.string_0, weapon);
						DBFunctions.smethod_60(scenario_1.method_39(), weapon, num, scenario_1, bool_34);
						weapon.DBID = num;
						if (weapon.vmethod_141())
						{
							weapon.method_146(100000f);
						}
						if (bool_34)
						{
							weapon.method_99(ref xmlNode_0, ref dictionary_0, ref scenario_1);
						}
						if (!bool_34)
						{
							Weapon.smethod_12(weapon, scenario_1, xmlNode_0, dictionary_0);
						}
						Weapon.smethod_14(weapon, scenario_1, xmlNode_0, dictionary_0);
						float num2 = weapon.vmethod_143().vmethod_30();
						float num3 = weapon.vmethod_143().vmethod_31();
						if (weapon.vmethod_14(false) > num2 && (weapon.method_167() == Weapon._WeaponType.GuidedWeapon || weapon.method_167() == Weapon._WeaponType.Torpedo))
						{
							weapon.vmethod_15(false, num2);
						}
						else if (weapon.vmethod_14(false) < num3 && (weapon.method_167() == Weapon._WeaponType.GuidedWeapon || weapon.method_167() == Weapon._WeaponType.Torpedo))
						{
							weapon.vmethod_15(false, num3);
						}
						if (weapon.vmethod_72() > num2 && (weapon.method_167() == Weapon._WeaponType.GuidedWeapon || weapon.method_167() == Weapon._WeaponType.Torpedo))
						{
							weapon.vmethod_73(num2);
						}
						else if (weapon.vmethod_72() < num3 && (weapon.method_167() == Weapon._WeaponType.GuidedWeapon || weapon.method_167() == Weapon._WeaponType.Torpedo))
						{
							weapon.vmethod_73(num3);
						}
						weapon.method_134();
						result = weapon;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100882", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Weapon(null);
			}
			return result;
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x001E3750 File Offset: 0x001E1950
		protected static void smethod_14(Weapon weapon_1, Scenario scenario_1, XmlNode xmlNode_0, Dictionary<string, Class310> dictionary_0)
		{
			try
			{
				foreach (object obj in xmlNode_0.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					string name = xmlNode.Name;
					uint num = Class582.smethod_0(name);
					if (num > 1729717486U)
					{
						if (num <= 2834497881U)
						{
							if (num <= 2527167325U)
							{
								if (num <= 2010780873U)
								{
									if (num <= 1836990821U)
									{
										if (num != 1738278884U)
										{
											if (num != 1836990821U)
											{
												continue;
											}
											if (Operators.CompareString(name, "Latitude", false) != 0)
											{
												continue;
											}
										}
										else
										{
											if (Operators.CompareString(name, "SBED_TF", false) == 0)
											{
												weapon_1.bool_20 = Conversions.ToBoolean(xmlNode.InnerText);
												continue;
											}
											continue;
										}
									}
									else if (num != 1953416793U)
									{
										if (num != 1992083866U)
										{
											if (num != 2010780873U)
											{
												continue;
											}
											if (Operators.CompareString(name, "CA", false) == 0)
											{
												goto IL_BD3;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Latitude_UnitEntersAreaCheck", false) == 0)
											{
												weapon_1.vmethod_39(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "AMP_OC_DSO", false) == 0)
										{
											weapon_1.nullable_13 = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else if (num <= 2128224206U)
								{
									if (num != 2019197265U)
									{
										if (num != 2066337159U)
										{
											if (num != 2128224206U)
											{
												continue;
											}
											if (Operators.CompareString(name, "CH", false) != 0)
											{
												continue;
											}
											goto IL_1678;
										}
										else
										{
											if (Operators.CompareString(name, "DesiredAltitude", false) == 0)
											{
												goto IL_C91;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Pitch", false) == 0)
										{
											weapon_1.vmethod_19(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
								}
								else
								{
									if (num != 2247649009U)
									{
										if (num != 2496321123U)
										{
											if (num != 2527167325U)
											{
												continue;
											}
											if (Operators.CompareString(name, "TerrainFollowing", false) == 0)
											{
												weapon_1.vmethod_77(weapon_1, Conversions.ToBoolean(xmlNode.InnerText));
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "RangeSymbols", false) != 0)
											{
												continue;
											}
											try
											{
												foreach (object obj2 in xmlNode.ChildNodes)
												{
													RangeSymbol item = RangeSymbol.smethod_0((XmlNode)obj2, dictionary_0);
													weapon_1.method_17().Add(item);
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
									}
									if (Operators.CompareString(name, "AssignedMission", false) == 0 && xmlNode.HasChildNodes)
									{
										XmlNode xmlNode2 = xmlNode.ChildNodes[0];
										weapon_1.string_4 = xmlNode2.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num <= 2638010429U)
							{
								if (num <= 2545405656U)
								{
									if (num != 2532358002U)
									{
										if (num != 2536212798U)
										{
											if (num != 2545405656U)
											{
												continue;
											}
											if (Operators.CompareString(name, "LaunchPoint", false) == 0)
											{
												XmlNode xmlNode3 = xmlNode.FirstChild;
												weapon_1.geoPoint_0 = GeoPoint.smethod_0(ref xmlNode3, ref dictionary_0);
												continue;
											}
											continue;
										}
										else
										{
											if (Operators.CompareString(name, "Roll", false) == 0)
											{
												weapon_1.vmethod_21(XmlConvert.ToSingle(xmlNode.InnerText));
												continue;
											}
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "FiringParent", false) == 0)
										{
											weapon_1.string_9 = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else if (num != 2564648390U)
								{
									if (num != 2590053246U)
									{
										if (num != 2638010429U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SearchPatternType", false) == 0)
										{
											weapon_1.enum127_0 = (Weapon.Enum127)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Side", false) == 0)
										{
											weapon_1.string_7 = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Lon", false) == 0)
									{
										goto IL_ED8;
									}
									continue;
								}
							}
							else
							{
								if (num > 2720289992U)
								{
									goto IL_101A;
								}
								if (num != 2650669718U)
								{
									if (num != 2698398137U)
									{
										if (num != 2720289992U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TTReseek", false) == 0)
										{
											weapon_1.method_142(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TimeToDetonate", false) == 0)
										{
											goto IL_F58;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "ARM_SE", false) == 0)
									{
										goto IL_F9A;
									}
									continue;
								}
							}
						}
						else if (num <= 3204468496U)
						{
							if (num <= 2923116889U)
							{
								if (num <= 2883730117U)
								{
									if (num != 2844845263U)
									{
										if (num != 2883730117U)
										{
											continue;
										}
										if (Operators.CompareString(name, "CEP_Land", false) == 0)
										{
											weapon_1.method_175(Conversions.ToInteger(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SBEO_Altitude", false) == 0)
										{
											weapon_1.float_20 = XmlConvert.ToSingle(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (num != 2904824734U)
								{
									if (num != 2920208772U)
									{
										if (num != 2923116889U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SBR_ThrottleSetting", false) != 0)
										{
											continue;
										}
										string innerText = xmlNode.InnerText;
										if (Operators.CompareString(innerText, "FullStop", false) == 0)
										{
											weapon_1.throttle_1 = ActiveUnit.Throttle.FullStop;
											continue;
										}
										if (Operators.CompareString(innerText, "Loiter", false) == 0)
										{
											weapon_1.throttle_1 = ActiveUnit.Throttle.Loiter;
											continue;
										}
										if (Operators.CompareString(innerText, "Cruise", false) == 0)
										{
											weapon_1.throttle_1 = ActiveUnit.Throttle.Cruise;
											continue;
										}
										if (Operators.CompareString(innerText, "Full", false) == 0)
										{
											weapon_1.throttle_1 = ActiveUnit.Throttle.Full;
											continue;
										}
										if (Operators.CompareString(innerText, "Flank", false) != 0)
										{
											weapon_1.throttle_1 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										weapon_1.throttle_1 = ActiveUnit.Throttle.Flank;
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Message", false) == 0)
										{
											weapon_1.string_3 = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SBEO_Altitude_TF", false) == 0)
									{
										weapon_1.float_21 = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 3089922411U)
							{
								if (num != 3001749054U)
								{
									if (num != 3070770765U)
									{
										if (num != 3089922411U)
										{
											continue;
										}
										if (Operators.CompareString(name, "CEP_Surface", false) == 0)
										{
											goto IL_12D2;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SBR_Altitude", false) == 0)
										{
											weapon_1.float_17 = XmlConvert.ToSingle(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "Lat", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3164489068U)
							{
								if (num != 3189373444U)
								{
									if (num != 3204468496U)
									{
										continue;
									}
									if (Operators.CompareString(name, "SBEO", false) == 0)
									{
										weapon_1._ActiveUnitStatus_4 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "LonLR", false) == 0)
									{
										weapon_1.method_59(new double?(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."))));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "AMP_OC", false) == 0)
								{
									weapon_1.bool_17 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3609180422U)
						{
							if (num <= 3352664703U)
							{
								if (num != 3251319825U)
								{
									if (num != 3283119613U)
									{
										if (num != 3352664703U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Weapon_Sensory", false) == 0)
										{
											ActiveUnit activeUnit = weapon_1;
											weapon_1.class223_0 = Class223.smethod_10(ref xmlNode, ref dictionary_0, ref activeUnit);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "CurrentSpeed", false) == 0)
										{
											goto IL_1454;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SBR_TF", false) == 0)
									{
										weapon_1.bool_19 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3389022305U)
							{
								if (num != 3559367371U)
								{
									if (num != 3609180422U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ARM_SpecifiedEmissionIsMandatory", false) == 0)
									{
										goto IL_14C2;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "SBEO_ThrottleSetting", false) != 0)
									{
										continue;
									}
									string innerText2 = xmlNode.InnerText;
									if (Operators.CompareString(innerText2, "FullStop", false) == 0)
									{
										weapon_1.throttle_3 = ActiveUnit.Throttle.FullStop;
										continue;
									}
									if (Operators.CompareString(innerText2, "Loiter", false) == 0)
									{
										weapon_1.throttle_3 = ActiveUnit.Throttle.Loiter;
										continue;
									}
									if (Operators.CompareString(innerText2, "Cruise", false) == 0)
									{
										weapon_1.throttle_3 = ActiveUnit.Throttle.Cruise;
										continue;
									}
									if (Operators.CompareString(innerText2, "Full", false) == 0)
									{
										weapon_1.throttle_3 = ActiveUnit.Throttle.Full;
										continue;
									}
									if (Operators.CompareString(innerText2, "Flank", false) != 0)
									{
										weapon_1.throttle_3 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									weapon_1.throttle_3 = ActiveUnit.Throttle.Flank;
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "SBED", false) == 0)
								{
									weapon_1._ActiveUnitStatus_3 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 3792306253U)
						{
							if (num != 3644814505U)
							{
								if (num != 3736393060U)
								{
									if (num != 3792306253U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Longitude_UnitEntersAreaCheck", false) == 0)
									{
										weapon_1.vmethod_37(new double?(XmlConvert.ToDouble(xmlNode.InnerText)));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ParentGroup", false) == 0)
									{
										weapon_1.string_6 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "ImpactAltitude", false) == 0)
								{
									weapon_1.vmethod_17(XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else if (num != 4080539297U)
						{
							if (num != 4087976791U)
							{
								if (num == 4152621540U && Operators.CompareString(name, "CurrentHeading", false) == 0)
								{
									goto IL_1678;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Weapon_Damage", false) == 0)
								{
									ActiveUnit activeUnit = weapon_1;
									weapon_1.class188_0 = Class188.smethod_1(ref xmlNode, ref dictionary_0, ref activeUnit);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "IsAutoDetectable", false) == 0)
							{
								goto IL_16BD;
							}
							continue;
						}
						weapon_1.vmethod_31(null, XmlConvert.ToDouble(xmlNode.InnerText));
						continue;
						IL_1678:
						weapon_1.vmethod_10(XmlConvert.ToSingle(xmlNode.InnerText));
						continue;
					}
					if (num <= 827630232U)
					{
						if (num <= 506380204U)
						{
							if (num <= 422144471U)
							{
								if (num <= 263373746U)
								{
									if (num != 6222351U)
									{
										if (num != 263373746U)
										{
											continue;
										}
										if (Operators.CompareString(name, "FSBR", false) == 0)
										{
											weapon_1._ActiveUnitFuelState_1 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Status", false) != 0)
										{
											continue;
										}
										if (Versioned.IsNumeric(xmlNode.InnerText))
										{
											weapon_1.vmethod_109((ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText));
										}
										else
										{
											weapon_1.vmethod_109((ActiveUnit._ActiveUnitStatus)Enum.Parse(typeof(ActiveUnit._ActiveUnitStatus), xmlNode.InnerText, true));
										}
										if (weapon_1.vmethod_108() == (ActiveUnit._ActiveUnitStatus)9)
										{
											weapon_1.vmethod_109(ActiveUnit._ActiveUnitStatus.RTB);
											continue;
										}
										continue;
									}
								}
								else if (num != 266367750U)
								{
									if (num != 273958740U)
									{
										if (num != 422144471U)
										{
											continue;
										}
										if (Operators.CompareString(name, "ARM_SpecifiedEmission", false) != 0)
										{
											continue;
										}
										goto IL_F9A;
									}
									else
									{
										if (Operators.CompareString(name, "AMP_OC_Speed", false) == 0)
										{
											weapon_1.float_16 = XmlConvert.ToSingle(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										weapon_1.Name = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num <= 468031071U)
							{
								if (num != 441941816U)
								{
									if (num != 454106749U)
									{
										if (num != 468031071U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SBED_Altitude_TF", false) == 0)
										{
											weapon_1.nullable_14 = new float?(XmlConvert.ToSingle(xmlNode.InnerText));
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "SBPF_TF", false) == 0)
										{
											weapon_1.bool_22 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "CurrentAltitude", false) != 0)
									{
										continue;
									}
									goto IL_BD3;
								}
							}
							else if (num != 485784328U)
							{
								if (num != 500883205U)
								{
									if (num != 506380204U)
									{
										continue;
									}
									if (Operators.CompareString(name, "LatLR", false) == 0)
									{
										weapon_1.method_57(new double?(XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."))));
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "DRT", false) == 0)
									{
										weapon_1.float_49 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "IsAD", false) != 0)
								{
									continue;
								}
								goto IL_16BD;
							}
						}
						else if (num <= 697011643U)
						{
							if (num <= 639961112U)
							{
								if (num != 634280640U)
								{
									if (num != 636840496U)
									{
										if (num != 639961112U)
										{
											continue;
										}
										if (Operators.CompareString(name, "Weapon_AI", false) != 0)
										{
											continue;
										}
										Weapon_AI.smethod_1(xmlNode, dictionary_0, weapon_1);
										if (weapon_1.vmethod_76(weapon_1) && weapon_1.vmethod_74() == 0f)
										{
											weapon_1.vmethod_75(60.96f);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TS", false) != 0)
										{
											continue;
										}
										goto IL_981;
									}
								}
								else
								{
									if (Operators.CompareString(name, "DS", false) != 0)
									{
										continue;
									}
									goto IL_10DD;
								}
							}
							else if (num != 664498478U)
							{
								if (num != 685599235U)
								{
									if (num != 697011643U)
									{
										continue;
									}
									if (Operators.CompareString(name, "CruiseAltitude_ASL", false) == 0)
									{
										weapon_1.method_146(XmlConvert.ToSingle(xmlNode.InnerText));
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "BT", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "FuelState", false) == 0)
								{
									weapon_1._ActiveUnitFuelState_0 = (ActiveUnit._ActiveUnitFuelState)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
						}
						else if (num <= 793602867U)
						{
							if (num != 699412232U)
							{
								if (num != 759940032U)
								{
									if (num != 793602867U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Weapon_Navigator", false) == 0)
									{
										ActiveUnit activeUnit = weapon_1;
										weapon_1.weapon_Navigator_0 = Weapon_Navigator.smethod_8(ref xmlNode, ref dictionary_0, ref activeUnit);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ARM_SEIM", false) != 0)
									{
										continue;
									}
									goto IL_14C2;
								}
							}
							else
							{
								if (Operators.CompareString(name, "SIFM", false) != 0)
								{
									continue;
								}
								goto IL_7D8;
							}
						}
						else if (num != 802113503U)
						{
							if (num != 803760973U)
							{
								if (num != 827630232U)
								{
									continue;
								}
								if (Operators.CompareString(name, "SBED_Altitude", false) == 0)
								{
									weapon_1.float_19 = XmlConvert.ToSingle(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "DamagePts", false) == 0)
								{
									weapon_1.vmethod_64(false, null, XmlConvert.ToSingle(xmlNode.InnerText));
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "IlluminatorUnit", false) == 0)
							{
								weapon_1.activeUnit_2 = ActiveUnit.smethod_9(ref xmlNode, ref dictionary_0, ref scenario_1);
								continue;
							}
							continue;
						}
					}
					else
					{
						if (num <= 1143797280U)
						{
							if (num <= 936277782U)
							{
								if (num <= 882606391U)
								{
									if (num != 834703028U)
									{
										if (num != 882606391U)
										{
											continue;
										}
										if (Operators.CompareString(name, "AMP_OC_DAO", false) == 0)
										{
											weapon_1.bool_18 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "Weapon_CommStuff", false) == 0)
										{
											ActiveUnit activeUnit = weapon_1;
											weapon_1.weapon_CommStuff_0 = Weapon_CommStuff.smethod_1(ref xmlNode, ref dictionary_0, ref activeUnit);
											continue;
										}
										continue;
									}
								}
								else if (num != 892023141U)
								{
									if (num != 929554659U)
									{
										if (num != 936277782U)
										{
											continue;
										}
										if (Operators.CompareString(name, "DA", false) != 0)
										{
											continue;
										}
										goto IL_C91;
									}
									else
									{
										if (Operators.CompareString(name, "TTD", false) != 0)
										{
											continue;
										}
										goto IL_F58;
									}
								}
								else if (Operators.CompareString(name, "DesiredHeading", false) != 0)
								{
									continue;
								}
							}
							else if (num <= 1053953301U)
							{
								if (num != 967155461U)
								{
									if (num != 1029238175U)
									{
										if (num != 1053953301U)
										{
											continue;
										}
										if (Operators.CompareString(name, "BlindTime", false) == 0)
										{
											goto IL_60D;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "CEP", false) != 0)
										{
											continue;
										}
										goto IL_12D2;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SBPF_ThrottleSetting", false) != 0)
									{
										continue;
									}
									string innerText3 = xmlNode.InnerText;
									if (Operators.CompareString(innerText3, "FullStop", false) == 0)
									{
										weapon_1.throttle_4 = ActiveUnit.Throttle.FullStop;
										continue;
									}
									if (Operators.CompareString(innerText3, "Loiter", false) == 0)
									{
										weapon_1.throttle_4 = ActiveUnit.Throttle.Loiter;
										continue;
									}
									if (Operators.CompareString(innerText3, "Cruise", false) == 0)
									{
										weapon_1.throttle_4 = ActiveUnit.Throttle.Cruise;
										continue;
									}
									if (Operators.CompareString(innerText3, "Full", false) == 0)
									{
										weapon_1.throttle_4 = ActiveUnit.Throttle.Full;
										continue;
									}
									if (Operators.CompareString(innerText3, "Flank", false) != 0)
									{
										weapon_1.throttle_4 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									weapon_1.throttle_4 = ActiveUnit.Throttle.Flank;
									continue;
								}
							}
							else if (num != 1087276353U)
							{
								if (num != 1099941372U)
								{
									if (num != 1143797280U)
									{
										continue;
									}
									if (Operators.CompareString(name, "SBR_Altitude_TF", false) == 0)
									{
										weapon_1.float_18 = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "SBPF_Altitude_TF", false) == 0)
									{
										weapon_1.float_23 = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (Operators.CompareString(name, "DH", false) != 0)
							{
								continue;
							}
							weapon_1.vmethod_69(ActiveUnit.Enum28.const_0, XmlConvert.ToSingle(xmlNode.InnerText));
							continue;
						}
						if (num <= 1339890663U)
						{
							if (num <= 1238454347U)
							{
								if (num != 1156592502U)
								{
									if (num != 1171512409U)
									{
										if (num != 1238454347U)
										{
											continue;
										}
										if (Operators.CompareString(name, "SensorIlluminatingForMe", false) == 0)
										{
											goto IL_7D8;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "DataLinkParent", false) == 0)
										{
											weapon_1.string_10 = xmlNode.InnerText;
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "SBR", false) == 0)
									{
										weapon_1._ActiveUnitStatus_2 = (ActiveUnit._ActiveUnitStatus)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 1255847155U)
							{
								if (num != 1259548010U)
								{
									if (num != 1339890663U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ActiveEnterAreaTriggers", false) != 0)
									{
										continue;
									}
									try
									{
										foreach (object obj3 in xmlNode.ChildNodes)
										{
											string innerText4 = ((XmlNode)obj3).InnerText;
											weapon_1.list_0.Add(innerText4);
										}
										continue;
									}
									finally
									{
										IEnumerator enumerator3;
										if (enumerator3 is IDisposable)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
								}
								if (Operators.CompareString(name, "SBED_ThrottleSetting", false) != 0)
								{
									continue;
								}
								string innerText5 = xmlNode.InnerText;
								if (Operators.CompareString(innerText5, "FullStop", false) == 0)
								{
									weapon_1.throttle_2 = ActiveUnit.Throttle.FullStop;
									continue;
								}
								if (Operators.CompareString(innerText5, "Loiter", false) == 0)
								{
									weapon_1.throttle_2 = ActiveUnit.Throttle.Loiter;
									continue;
								}
								if (Operators.CompareString(innerText5, "Cruise", false) == 0)
								{
									weapon_1.throttle_2 = ActiveUnit.Throttle.Cruise;
									continue;
								}
								if (Operators.CompareString(innerText5, "Full", false) == 0)
								{
									weapon_1.throttle_2 = ActiveUnit.Throttle.Full;
									continue;
								}
								if (Operators.CompareString(innerText5, "Flank", false) != 0)
								{
									weapon_1.throttle_2 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								weapon_1.throttle_2 = ActiveUnit.Throttle.Flank;
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "ThrottleSetting", false) == 0)
								{
									goto IL_981;
								}
								continue;
							}
						}
						else if (num <= 1488303767U)
						{
							if (num != 1422437055U)
							{
								if (num != 1476905714U)
								{
									if (num != 1488303767U)
									{
										continue;
									}
									if (Operators.CompareString(name, "SBEO_TF", false) == 0)
									{
										weapon_1.bool_21 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "WeaponState", false) == 0)
									{
										weapon_1._ActiveUnitWeaponState_0 = (ActiveUnit._ActiveUnitWeaponState)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Doctrine", false) == 0)
								{
									weapon_1.doctrine_0 = Doctrine.smethod_9(ref xmlNode, weapon_1);
									continue;
								}
								continue;
							}
						}
						else if (num != 1708783731U)
						{
							if (num != 1716063484U)
							{
								if (num != 1729717486U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Longitude", false) != 0)
								{
									continue;
								}
								goto IL_ED8;
							}
							else
							{
								if (Operators.CompareString(name, "Weapon_Kinematics", false) == 0)
								{
									ActiveUnit_Kinematics.smethod_0(xmlNode, dictionary_0, weapon_1);
									continue;
								}
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "CS", false) != 0)
							{
								continue;
							}
							goto IL_1454;
						}
					}
					IL_60D:
					weapon_1.float_48 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
					continue;
					IL_7D8:
					weapon_1.string_11 = xmlNode.InnerText;
					continue;
					IL_981:
					string innerText6 = xmlNode.InnerText;
					if (Operators.CompareString(innerText6, "FullStop", false) == 0)
					{
						weapon_1.throttle_0 = ActiveUnit.Throttle.FullStop;
						continue;
					}
					if (Operators.CompareString(innerText6, "Loiter", false) == 0)
					{
						weapon_1.throttle_0 = ActiveUnit.Throttle.Loiter;
						continue;
					}
					if (Operators.CompareString(innerText6, "Cruise", false) == 0)
					{
						weapon_1.throttle_0 = ActiveUnit.Throttle.Cruise;
						continue;
					}
					if (Operators.CompareString(innerText6, "Full", false) == 0)
					{
						weapon_1.throttle_0 = ActiveUnit.Throttle.Full;
						continue;
					}
					if (Operators.CompareString(innerText6, "Flank", false) != 0)
					{
						weapon_1.throttle_0 = (ActiveUnit.Throttle)Conversions.ToByte(xmlNode.InnerText);
						continue;
					}
					weapon_1.throttle_0 = ActiveUnit.Throttle.Flank;
					continue;
					IL_BD3:
					weapon_1.vmethod_15(false, XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_C91:
					weapon_1.vmethod_73(XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_ED8:
					weapon_1.vmethod_29(null, XmlConvert.ToDouble(xmlNode.InnerText));
					continue;
					IL_F58:
					xmlNode.InnerText = xmlNode.InnerText.Replace(",", ".");
					weapon_1.float_50 = XmlConvert.ToSingle(xmlNode.InnerText);
					continue;
					IL_F9A:
					try
					{
						foreach (object obj4 in xmlNode.ChildNodes)
						{
							XmlNode xmlNode4 = (XmlNode)obj4;
							int num2 = Conversions.ToInteger(xmlNode4.Name.Remove(0, 8));
							int key = num2;
							XmlNode xmlNode3;
							string innerText7 = (xmlNode3 = xmlNode4).InnerText;
							EmissionContainer value = EmissionContainer.smethod_0(ref innerText7);
							xmlNode3.InnerText = innerText7;
							weapon_1.keyValuePair_0 = new KeyValuePair<int, EmissionContainer>(key, value);
						}
						continue;
					}
					finally
					{
						IEnumerator enumerator4;
						if (enumerator4 is IDisposable)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
					IL_101A:
					if (num != 2749693904U)
					{
						if (num != 2811069936U)
						{
							if (num != 2834497881U)
							{
								continue;
							}
							if (Operators.CompareString(name, "SBPF_Altitude", false) == 0)
							{
								weapon_1.float_22 = XmlConvert.ToSingle(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "Warheads", false) != 0)
							{
								continue;
							}
							try
							{
								foreach (object obj5 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode5 = (XmlNode)obj5;
									Warhead warhead_ = Warhead.smethod_0(ref xmlNode5, ref dictionary_0);
									Class429.smethod_34(ref weapon_1.warhead_0, warhead_);
								}
								continue;
							}
							finally
							{
								IEnumerator enumerator5;
								if (enumerator5 is IDisposable)
								{
									(enumerator5 as IDisposable).Dispose();
								}
							}
						}
					}
					if (Operators.CompareString(name, "DesiredSpeed", false) != 0)
					{
						continue;
					}
					IL_10DD:
					weapon_1.vmethod_71(XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_12D2:
					weapon_1.method_173(Conversions.ToInteger(xmlNode.InnerText));
					continue;
					IL_1454:
					weapon_1.vmethod_41(XmlConvert.ToSingle(xmlNode.InnerText));
					continue;
					IL_14C2:
					weapon_1.bool_28 = Conversions.ToBoolean(xmlNode.InnerText);
					continue;
					IL_16BD:
					weapon_1.method_93(null, Conversions.ToBoolean(xmlNode.InnerText));
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
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x001E4ECC File Offset: 0x001E30CC
		public override void vmethod_122(ref Scenario scenario_1, Dictionary<string, Class310> dictionary_0, List<ActiveUnit> list_4, bool bool_34)
		{
			try
			{
				base.vmethod_122(ref scenario_1, dictionary_0, list_4, bool_34);
				if (!Information.IsNothing(this.string_10))
				{
					scenario_1.vmethod_0().TryGetValue(this.string_10, ref this.activeUnit_1);
				}
				if (!Information.IsNothing(this.string_9))
				{
					scenario_1.vmethod_0().TryGetValue(this.string_9, ref this.activeUnit_0);
				}
				if (!Information.IsNothing(this.string_11))
				{
					try
					{
						foreach (ActiveUnit activeUnit in scenario_1.vmethod_0().Values)
						{
							foreach (Sensor sensor in activeUnit.vmethod_96())
							{
								if (string.CompareOrdinal(sensor.string_0, this.string_11) == 0)
								{
									this.sensor_2 = sensor;
									return;
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
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100883", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0000D867 File Offset: 0x0000BA67
		public GlobalVariables.TechGenerationClass method_143()
		{
			if (this.techGenerationClass_0 == GlobalVariables.TechGenerationClass.None && base.method_78().Length > 0)
			{
				this.techGenerationClass_0 = base.method_78()[0].techGenerationClass_0;
			}
			return this.techGenerationClass_0;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0000D89A File Offset: 0x0000BA9A
		public void method_144(GlobalVariables.TechGenerationClass techGenerationClass_1)
		{
			this.techGenerationClass_0 = techGenerationClass_1;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0000D8A3 File Offset: 0x0000BAA3
		public float method_145()
		{
			return this.float_28;
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0000D8AB File Offset: 0x0000BAAB
		public void method_146(float float_52)
		{
			this.float_28 = float_52;
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		public override float vmethod_9()
		{
			return base.vmethod_9();
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0000D8BC File Offset: 0x0000BABC
		public override void vmethod_10(float float_52)
		{
			base.vmethod_10(float_52);
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x00008501 File Offset: 0x00006701
		public override float vmethod_72()
		{
			return base.vmethod_72();
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0000D8C5 File Offset: 0x0000BAC5
		public override void vmethod_73(float float_52)
		{
			base.vmethod_73(float_52);
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0000D8CE File Offset: 0x0000BACE
		public override void vmethod_69(ActiveUnit.Enum28 enum28_1, float float_52)
		{
			base.vmethod_69(enum28_1, float_52);
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		internal virtual bool vmethod_141()
		{
			return this.method_167() == Weapon._WeaponType.HGV;
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0000CC74 File Offset: 0x0000AE74
		public override float vmethod_14(bool DoSanityCheck = false)
		{
			return base.vmethod_14(DoSanityCheck);
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0000D8E7 File Offset: 0x0000BAE7
		public override void vmethod_15(bool DoSanityCheck = false, float value)
		{
			if (DoSanityCheck && base.method_0() && value < 6.0959997f)
			{
				value = 6.0959997f;
			}
			base.vmethod_15(DoSanityCheck, value);
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0000D90B File Offset: 0x0000BB0B
		public override Sensor[] vmethod_96()
		{
			return this.sensor_0;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x001E4FF8 File Offset: 0x001E31F8
		public Sensor[] method_147()
		{
			Sensor[] result;
			switch (this.method_169())
			{
			case Weapon.WeaponGuidanceType.SemiActive:
			case Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive:
			case Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive:
			case Weapon.WeaponGuidanceType.CommandGuided_Datalinked:
			case Weapon.WeaponGuidanceType.TVM:
			case Weapon.WeaponGuidanceType.BeamRiding:
				result = new Sensor[]
				{
					this.method_170()
				};
				break;
			default:
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
				break;
			case Weapon.WeaponGuidanceType.Passive:
			case Weapon.WeaponGuidanceType.Inertial_Plus_Passive:
			case Weapon.WeaponGuidanceType.DataLink_Plus_Passive:
			case Weapon.WeaponGuidanceType.Active:
			case Weapon.WeaponGuidanceType.Datalink_Plus_Active:
			case Weapon.WeaponGuidanceType.Inertial_Plus_Active:
			case Weapon.WeaponGuidanceType.SemiActive_Plus_Active:
			case Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active:
				result = this.sensor_0;
				break;
			case Weapon.WeaponGuidanceType.Inertial:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0000C64A File Offset: 0x0000A84A
		public override float vmethod_70()
		{
			return base.vmethod_70();
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0000D913 File Offset: 0x0000BB13
		public override void vmethod_71(float float_52)
		{
			base.vmethod_71(float_52);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0000D91C File Offset: 0x0000BB1C
		public override bool vmethod_76(ActiveUnit activeUnit_3)
		{
			return this.bool_12;
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0000D924 File Offset: 0x0000BB24
		public override void vmethod_77(ActiveUnit activeUnit_3, bool bool_34)
		{
			this.bool_12 = bool_34;
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x001E5080 File Offset: 0x001E3280
		public float method_148(GlobalVariables.ArmorRating armorRating_0, GlobalVariables.TargetVisualSizeClass targetVisualSizeClass_0)
		{
			Warhead warhead = this.warhead_0[0];
			if (armorRating_0 == GlobalVariables.ArmorRating.None && this.method_167() == Weapon._WeaponType.Gun)
			{
				switch (targetVisualSizeClass_0)
				{
				case GlobalVariables.TargetVisualSizeClass.Stealthy:
					return 100f;
				case GlobalVariables.TargetVisualSizeClass.Small:
				{
					Warhead.WarheadCaliber warheadCaliber_ = warhead.warheadCaliber_0;
					if (warheadCaliber_ - Warhead.WarheadCaliber.Gun_6_15mm > 1)
					{
						return 100f;
					}
					break;
				}
				case GlobalVariables.TargetVisualSizeClass.Medium:
				{
					Warhead.WarheadCaliber warheadCaliber_2 = warhead.warheadCaliber_0;
					if (warheadCaliber_2 - Warhead.WarheadCaliber.Gun_6_15mm > 2)
					{
						return 100f;
					}
					break;
				}
				case GlobalVariables.TargetVisualSizeClass.Large:
				case GlobalVariables.TargetVisualSizeClass.VLarge:
				{
					Warhead.WarheadCaliber warheadCaliber_3 = warhead.warheadCaliber_0;
					if (warheadCaliber_3 - Warhead.WarheadCaliber.Gun_6_15mm > 3)
					{
						return 100f;
					}
					break;
				}
				}
			}
			Warhead.WarheadType warheadType_ = warhead.warheadType_0;
			short num;
			if (warheadType_ <= Warhead.WarheadType.Weapon)
			{
				if (warheadType_ <= Warhead.WarheadType.DepthCharge)
				{
					switch (warheadType_)
					{
					case Warhead.WarheadType.HE_BlastFrag:
						goto IL_8B0;
					case Warhead.WarheadType.ArmorPiercing:
					case Warhead.WarheadType.SemiAP:
					case Warhead.WarheadType.HardTargetPenetrator:
						goto IL_452;
					case Warhead.WarheadType.HEAT:
						break;
					case Warhead.WarheadType.Incendiary:
						num = 0;
						goto IL_8E6;
					case Warhead.WarheadType.Fragmentation:
					case Warhead.WarheadType.ContinuousRod:
						goto IL_2C1;
					case Warhead.WarheadType.HESH:
					case Warhead.WarheadType.FAE:
						goto IL_8E6;
					case Warhead.WarheadType.SuperFrag:
					case Warhead.WarheadType.Fragmentation_ABM:
						if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_HMG)
						{
							if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_Handgun)
							{
								if (armorRating_0 == GlobalVariables.ArmorRating.None)
								{
									num = 100;
									goto IL_8E6;
								}
								if (armorRating_0 != GlobalVariables.ArmorRating.Armor_Handgun)
								{
									goto IL_8E6;
								}
								num = 100;
								goto IL_8E6;
							}
							else
							{
								if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Rifle)
								{
									num = 90;
									goto IL_8E6;
								}
								if (armorRating_0 != GlobalVariables.ArmorRating.Armor_HMG)
								{
									goto IL_8E6;
								}
								num = 80;
								goto IL_8E6;
							}
						}
						else if (armorRating_0 <= GlobalVariables.ArmorRating.RHA_25mm)
						{
							if (armorRating_0 == GlobalVariables.ArmorRating.RHA_20mm)
							{
								num = 70;
								goto IL_8E6;
							}
							if (armorRating_0 != GlobalVariables.ArmorRating.RHA_25mm)
							{
								goto IL_8E6;
							}
							num = 60;
							goto IL_8E6;
						}
						else
						{
							if (armorRating_0 == GlobalVariables.ArmorRating.RHA_30mm)
							{
								num = 50;
								goto IL_8E6;
							}
							if (armorRating_0 == GlobalVariables.ArmorRating.RHA_35mm)
							{
								num = 40;
								goto IL_8E6;
							}
							switch (armorRating_0)
							{
							case GlobalVariables.ArmorRating.Light:
								num = 30;
								goto IL_8E6;
							case GlobalVariables.ArmorRating.Medium:
								return 0f;
							case GlobalVariables.ArmorRating.Heavy:
								return 0f;
							case GlobalVariables.ArmorRating.Special:
								return 0f;
							default:
								goto IL_8E6;
							}
						}
						break;
					default:
						if (warheadType_ - Warhead.WarheadType.Torpedo > 1)
						{
							goto IL_8E6;
						}
						goto IL_8B0;
					}
				}
				else
				{
					if (warheadType_ == Warhead.WarheadType.Nuclear)
					{
						num = 0;
						goto IL_8E6;
					}
					if (warheadType_ != Warhead.WarheadType.Weapon)
					{
						goto IL_8E6;
					}
					return this.warhead_0[0].method_17(this.scenario_0).method_148(armorRating_0, targetVisualSizeClass_0);
				}
			}
			else if (warheadType_ <= Warhead.WarheadType.Cluster_AT)
			{
				if (warheadType_ == Warhead.WarheadType.Cluster_AP)
				{
					goto IL_2C1;
				}
				if (warheadType_ != Warhead.WarheadType.Cluster_AT)
				{
					goto IL_8E6;
				}
			}
			else
			{
				if (warheadType_ == Warhead.WarheadType.Cluster_SmartSubs)
				{
					goto IL_8B0;
				}
				if (warheadType_ == Warhead.WarheadType.LongRodPenetrator)
				{
					goto IL_452;
				}
				if (warheadType_ - Warhead.WarheadType.Laser_COIL <= 3)
				{
					if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_HMG)
					{
						if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_Handgun)
						{
							if (armorRating_0 == GlobalVariables.ArmorRating.None)
							{
								num = 100;
								goto IL_8E6;
							}
							if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Handgun)
							{
								num = 80;
								goto IL_8E6;
							}
						}
						else
						{
							if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Rifle)
							{
								num = 60;
								goto IL_8E6;
							}
							if (armorRating_0 == GlobalVariables.ArmorRating.Armor_HMG)
							{
								num = 50;
								goto IL_8E6;
							}
						}
					}
					else if (armorRating_0 <= GlobalVariables.ArmorRating.RHA_25mm)
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.RHA_20mm)
						{
							num = 40;
							goto IL_8E6;
						}
						if (armorRating_0 == GlobalVariables.ArmorRating.RHA_25mm)
						{
							num = 30;
							goto IL_8E6;
						}
					}
					else
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.RHA_30mm)
						{
							num = 20;
							goto IL_8E6;
						}
						if (armorRating_0 == GlobalVariables.ArmorRating.RHA_35mm)
						{
							num = 10;
							goto IL_8E6;
						}
					}
					return 0f;
				}
				goto IL_8E6;
			}
			switch (armorRating_0)
			{
			case GlobalVariables.ArmorRating.Medium:
				num = 60;
				goto IL_8E6;
			case GlobalVariables.ArmorRating.Heavy:
				num = 35;
				goto IL_8E6;
			case GlobalVariables.ArmorRating.Special:
				num = 15;
				goto IL_8E6;
			default:
				num = 100;
				goto IL_8E6;
			}
			IL_2C1:
			if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_HMG)
			{
				if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_Handgun)
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.None || armorRating_0 == GlobalVariables.ArmorRating.Armor_Handgun)
					{
						num = 100;
						goto IL_8E6;
					}
				}
				else if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Rifle || armorRating_0 == GlobalVariables.ArmorRating.Armor_HMG)
				{
					num = 90;
					goto IL_8E6;
				}
			}
			else if (armorRating_0 <= GlobalVariables.ArmorRating.RHA_25mm)
			{
				if (armorRating_0 == GlobalVariables.ArmorRating.RHA_20mm)
				{
					num = 80;
					goto IL_8E6;
				}
				if (armorRating_0 == GlobalVariables.ArmorRating.RHA_25mm)
				{
					num = 70;
					goto IL_8E6;
				}
			}
			else
			{
				if (armorRating_0 == GlobalVariables.ArmorRating.RHA_30mm)
				{
					num = 60;
					goto IL_8E6;
				}
				if (armorRating_0 == GlobalVariables.ArmorRating.RHA_35mm)
				{
					num = 55;
					goto IL_8E6;
				}
				if (armorRating_0 == GlobalVariables.ArmorRating.Light)
				{
					num = 50;
					goto IL_8E6;
				}
			}
			num = 0;
			goto IL_8E6;
			IL_452:
			Warhead.Enum126 enum126_ = warhead.enum126_0;
			switch (enum126_)
			{
			case Warhead.Enum126.const_47:
				if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.None)
						{
							num = 100;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_Handgun)
						{
							goto IL_8E6;
						}
						num = 85;
						goto IL_8E6;
					}
					else
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Rifle)
						{
							num = 80;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_HMG)
						{
							goto IL_8E6;
						}
						num = 75;
						goto IL_8E6;
					}
				}
				else if (armorRating_0 <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num = 70;
						goto IL_8E6;
					}
					if (armorRating_0 != GlobalVariables.ArmorRating.RHA_25mm)
					{
						goto IL_8E6;
					}
					num = 65;
					goto IL_8E6;
				}
				else
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_30mm)
					{
						num = 60;
						goto IL_8E6;
					}
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_35mm)
					{
						num = 55;
						goto IL_8E6;
					}
					switch (armorRating_0)
					{
					case GlobalVariables.ArmorRating.Light:
						num = 50;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Medium:
						num = 20;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Heavy:
						return 0f;
					case GlobalVariables.ArmorRating.Special:
						return 0f;
					default:
						goto IL_8E6;
					}
				}
				break;
			case Warhead.Enum126.const_48:
				if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.None)
						{
							num = 100;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_Handgun)
						{
							goto IL_8E6;
						}
						num = 100;
						goto IL_8E6;
					}
					else
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Rifle)
						{
							num = 100;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_HMG)
						{
							goto IL_8E6;
						}
						num = 95;
						goto IL_8E6;
					}
				}
				else if (armorRating_0 <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num = 90;
						goto IL_8E6;
					}
					if (armorRating_0 != GlobalVariables.ArmorRating.RHA_25mm)
					{
						goto IL_8E6;
					}
					num = 85;
					goto IL_8E6;
				}
				else
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_30mm)
					{
						num = 80;
						goto IL_8E6;
					}
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_35mm)
					{
						num = 75;
						goto IL_8E6;
					}
					switch (armorRating_0)
					{
					case GlobalVariables.ArmorRating.Light:
						num = 70;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Medium:
						num = 50;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Heavy:
						num = 20;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Special:
						return 0f;
					default:
						goto IL_8E6;
					}
				}
				break;
			case Warhead.Enum126.const_49:
				if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.None)
						{
							num = 100;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_Handgun)
						{
							goto IL_8E6;
						}
						num = 100;
						goto IL_8E6;
					}
					else
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Rifle)
						{
							num = 100;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_HMG)
						{
							goto IL_8E6;
						}
						num = 100;
						goto IL_8E6;
					}
				}
				else if (armorRating_0 <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num = 100;
						goto IL_8E6;
					}
					if (armorRating_0 != GlobalVariables.ArmorRating.RHA_25mm)
					{
						goto IL_8E6;
					}
					num = 100;
					goto IL_8E6;
				}
				else
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_30mm)
					{
						num = 95;
						goto IL_8E6;
					}
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_35mm)
					{
						num = 90;
						goto IL_8E6;
					}
					switch (armorRating_0)
					{
					case GlobalVariables.ArmorRating.Light:
						num = 85;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Medium:
						num = 80;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Heavy:
						num = 50;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Special:
						num = 20;
						goto IL_8E6;
					default:
						goto IL_8E6;
					}
				}
				break;
			case Warhead.Enum126.const_50:
				if (armorRating_0 == GlobalVariables.ArmorRating.Heavy)
				{
					num = 80;
					goto IL_8E6;
				}
				if (armorRating_0 != GlobalVariables.ArmorRating.Special)
				{
					return 100f;
				}
				num = 50;
				goto IL_8E6;
			default:
				if (enum126_ != Warhead.Enum126.const_54)
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.Heavy)
					{
						num = 80;
						goto IL_8E6;
					}
					if (armorRating_0 != GlobalVariables.ArmorRating.Special)
					{
						return 100f;
					}
					num = 50;
					goto IL_8E6;
				}
				else if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_HMG)
				{
					if (armorRating_0 <= GlobalVariables.ArmorRating.Armor_Handgun)
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.None)
						{
							num = 100;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_Handgun)
						{
							goto IL_8E6;
						}
						num = 90;
						goto IL_8E6;
					}
					else
					{
						if (armorRating_0 == GlobalVariables.ArmorRating.Armor_Rifle)
						{
							num = 80;
							goto IL_8E6;
						}
						if (armorRating_0 != GlobalVariables.ArmorRating.Armor_HMG)
						{
							goto IL_8E6;
						}
						num = 70;
						goto IL_8E6;
					}
				}
				else if (armorRating_0 <= GlobalVariables.ArmorRating.RHA_25mm)
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_20mm)
					{
						num = 60;
						goto IL_8E6;
					}
					if (armorRating_0 != GlobalVariables.ArmorRating.RHA_25mm)
					{
						goto IL_8E6;
					}
					num = 50;
					goto IL_8E6;
				}
				else
				{
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_30mm)
					{
						num = 40;
						goto IL_8E6;
					}
					if (armorRating_0 == GlobalVariables.ArmorRating.RHA_35mm)
					{
						num = 30;
						goto IL_8E6;
					}
					switch (armorRating_0)
					{
					case GlobalVariables.ArmorRating.Light:
						num = 20;
						goto IL_8E6;
					case GlobalVariables.ArmorRating.Medium:
						return 0f;
					case GlobalVariables.ArmorRating.Heavy:
						return 0f;
					case GlobalVariables.ArmorRating.Special:
						return 0f;
					default:
						goto IL_8E6;
					}
				}
				break;
			}
			IL_8B0:
			switch (armorRating_0)
			{
			case GlobalVariables.ArmorRating.Light:
				num = 90;
				break;
			case GlobalVariables.ArmorRating.Medium:
				num = 40;
				break;
			case GlobalVariables.ArmorRating.Heavy:
				num = 20;
				break;
			case GlobalVariables.ArmorRating.Special:
				num = 5;
				break;
			default:
				num = 100;
				break;
			}
			IL_8E6:
			int num2 = GameGeneral.smethod_5().Next((int)(num - 15), (int)(num + 16));
			float result;
			if (num2 > 100)
			{
				result = 100f;
			}
			else if (num2 < 0)
			{
				result = 0f;
			}
			else
			{
				result = (float)num2;
			}
			return result;
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x001E59A4 File Offset: 0x001E3BA4
		public bool method_149(bool bool_34)
		{
			Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
			if (weaponGuidanceType > Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive && weaponGuidanceType - Weapon.WeaponGuidanceType.Passive > 1)
			{
				if (weaponGuidanceType != Weapon.WeaponGuidanceType.BeamRiding)
				{
					return false;
				}
			}
			bool result;
			if (base.method_78().Length > 0)
			{
				Sensor.Sensor_Type sensor_Type_ = base.method_78()[0].sensor_Type_0;
				if (sensor_Type_ - Sensor.Sensor_Type.Visual > 1)
				{
					if (sensor_Type_ != Sensor.Sensor_Type.LaserSpotTracker)
					{
						return false;
					}
				}
				result = (!bool_34 || (!this.struct36_0.bool_28 && !this.struct36_0.bool_29 && !this.struct36_0.bool_30));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x001E5A34 File Offset: 0x001E3C34
		public List<string> method_150()
		{
			List<string> list = new List<string>();
			if (this.class394_0.bool_2)
			{
				list.Add("Aircraft");
			}
			if (this.class394_0.bool_11)
			{
				list.Add("Helicopters");
			}
			if (this.class394_0.bool_1)
			{
				list.Add("Submarines");
			}
			if (this.class394_0.bool_0)
			{
				list.Add("Surface Ships");
			}
			if (this.class394_0.bool_8)
			{
				list.Add("Land Structures (Hard)");
			}
			if (this.class394_0.bool_7)
			{
				list.Add("Land Structures (Soft)");
			}
			if (this.class394_0.bool_13)
			{
				list.Add("Mobile Units (Hard)");
			}
			if (this.class394_0.bool_12)
			{
				list.Add("Mobile Units (Soft)");
			}
			if (this.class394_0.bool_5)
			{
				list.Add("Radars");
			}
			if (this.class394_0.bool_6)
			{
				list.Add("Runways");
			}
			if (this.class394_0.bool_10)
			{
				list.Add("Mines");
			}
			if (this.class394_0.bool_3)
			{
				list.Add("Missiles & Guided Bombs");
			}
			if (this.class394_0.bool_9)
			{
				list.Add("Torpedoes");
			}
			return list;
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x001E5B80 File Offset: 0x001E3D80
		public string method_151()
		{
			Weapon._WeaponType weaponType = this.method_167();
			if (weaponType <= Weapon._WeaponType.HeliTowedPackage)
			{
				if (weaponType <= Weapon._WeaponType.GuidedProjectile)
				{
					if (weaponType == Weapon._WeaponType.None)
					{
						return "None";
					}
					switch (weaponType)
					{
					case Weapon._WeaponType.GuidedWeapon:
						return "Guided Weapon";
					case Weapon._WeaponType.Rocket:
						return "Rocket";
					case Weapon._WeaponType.IronBomb:
						return "Iron Bomb";
					case Weapon._WeaponType.Gun:
						return "Gun";
					case Weapon._WeaponType.Decoy_Expendable:
						return "Expendable Decoy";
					case Weapon._WeaponType.Decoy_Towed:
						return "Towed Decoy";
					case Weapon._WeaponType.Decoy_Vehicle:
						return "Decoy Vehicle";
					case Weapon._WeaponType.TrainingRound:
						return "Training Round";
					case Weapon._WeaponType.Dispenser:
						return "Weapon Dispenser";
					case Weapon._WeaponType.GuidedProjectile:
						return "Guided Projectile";
					}
				}
				else
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.SensorPod:
						return "Sensor Pod";
					case Weapon._WeaponType.DropTank:
						return "Drop Tank";
					case Weapon._WeaponType.BuddyStore:
						return "Buddy Store";
					case Weapon._WeaponType.FerryTank:
						return "Ferry Tank";
					default:
						switch (weaponType)
						{
						case Weapon._WeaponType.Torpedo:
							return "Torpedo";
						case Weapon._WeaponType.DepthCharge:
							return "Depth Charge";
						case Weapon._WeaponType.Sonobuoy:
							return "Sonobuoy";
						case Weapon._WeaponType.BottomMine:
							return "Bottom Mine";
						case Weapon._WeaponType.MooredMine:
							return "Moored Mine";
						case Weapon._WeaponType.FloatingMine:
							return "Floading Mine";
						case Weapon._WeaponType.MovingMine:
							return "Moving Mine";
						case Weapon._WeaponType.RisingMine:
							return "Rising Mine";
						case Weapon._WeaponType.DriftingMine:
							return "Drifting Mine";
						case (Weapon._WeaponType)4010:
							break;
						case Weapon._WeaponType.DummyMine:
							return "Dummy Mine";
						default:
							if (weaponType == Weapon._WeaponType.HeliTowedPackage)
							{
								return "Helicopter-Towed Package";
							}
							break;
						}
						break;
					}
				}
			}
			else if (weaponType <= Weapon._WeaponType.RV)
			{
				if (weaponType == Weapon._WeaponType.BallisticMissile)
				{
					return "Ballistic Missile";
				}
				if (weaponType == Weapon._WeaponType.RV)
				{
					return "Re-Entry Vehicle";
				}
			}
			else
			{
				if (weaponType == Weapon._WeaponType.Laser)
				{
					return "Laser";
				}
				if (weaponType == Weapon._WeaponType.HGV)
				{
					return "Hypersonic Glide Vehicle";
				}
				switch (weaponType)
				{
				case Weapon._WeaponType.Cargo:
					return "Cargo";
				case Weapon._WeaponType.Troops:
					return "Troops";
				case Weapon._WeaponType.Paratroops:
					return "Paratroopers";
				}
			}
			return this.method_167().ToString();
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0000D92D File Offset: 0x0000BB2D
		public override Side vmethod_7(bool SetSideOnly = false)
		{
			return base.vmethod_7(SetSideOnly);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000D936 File Offset: 0x0000BB36
		public override void vmethod_8(bool SetSideOnly = false, Side value)
		{
			base.vmethod_8(SetSideOnly, value);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0000D940 File Offset: 0x0000BB40
		public override GlobalVariables.ActiveUnitType vmethod_56()
		{
			return GlobalVariables.ActiveUnitType.Weapon;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x001E5E08 File Offset: 0x001E4008
		public override CommDevice[] vmethod_94()
		{
			CommDevice[] result;
			if (this.method_167() == Weapon._WeaponType.Sonobuoy)
			{
				result = this.commDevice_0;
			}
			else
			{
				result = base.vmethod_94();
			}
			return result;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x001E5E34 File Offset: 0x001E4034
		public bool method_152()
		{
			return base.method_2() && (this.method_195() || this.method_196()) && this.float_27 != 0f && this.vmethod_49().Count > 0 && this.vmethod_49()[0].altBand_0.Length == 1 && this.vmethod_67()[0].int_0 > 600;
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x001E5EA8 File Offset: 0x001E40A8
		public bool method_153()
		{
			if (this.method_167() == Weapon._WeaponType.GuidedWeapon)
			{
				if (this.vmethod_49().Count > 0 && this.vmethod_49()[0].enum112_0 == Engine.Enum112.const_14 && !this.method_208())
				{
					return false;
				}
				if ((this.method_195() || this.method_196()) && this.int_11 > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x001E5F14 File Offset: 0x001E4114
		public bool method_154()
		{
			if (this.nullable_18 == null)
			{
				this.nullable_18 = new bool?(this.method_167() == Weapon._WeaponType.Decoy_Expendable && this.Name.ToLower().Contains("chaff"));
			}
			return this.nullable_18.Value;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x001E5F6C File Offset: 0x001E416C
		public bool method_155()
		{
			Weapon._WeaponType weaponType = this.method_167();
			return weaponType - Weapon._WeaponType.BottomMine <= 4;
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x001E5F94 File Offset: 0x001E4194
		public bool method_156()
		{
			bool result;
			if (this.method_169() != Weapon.WeaponGuidanceType.Inertial)
			{
				result = false;
			}
			else
			{
				Weapon._WeaponType weaponType = this.method_167();
				if (weaponType <= Weapon._WeaponType.RisingMine)
				{
					if (weaponType - Weapon._WeaponType.Rocket <= 2 || weaponType - Weapon._WeaponType.DepthCharge <= 6)
					{
						goto IL_49;
					}
				}
				else if (weaponType == Weapon._WeaponType.RV || weaponType - Weapon._WeaponType.Cargo <= 2)
				{
					goto IL_49;
				}
				return false;
				IL_49:
				result = true;
			}
			return result;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x001E5FF0 File Offset: 0x001E41F0
		public float method_157()
		{
			float num = 0f;
			foreach (Warhead warhead in this.warhead_0)
			{
				num += warhead.float_0;
			}
			return num;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x001E6028 File Offset: 0x001E4228
		public float method_158(float float_52, Contact_Base.ContactType contactType_0)
		{
			float result;
			try
			{
				float num = this.float_40;
				float num2 = this.float_39;
				if (this.method_167() == Weapon._WeaponType.Gun)
				{
					num = this.method_182(contactType_0) * 1852f / 2f;
				}
				if (float_52 > num)
				{
					result = this.method_182(contactType_0);
				}
				else if (float_52 <= num && float_52 >= this.float_39)
				{
					float num3 = (float_52 - num2) / (num - num2);
					float num4;
					if (this.method_167() == Weapon._WeaponType.Gun)
					{
						num4 = 0.05f;
					}
					else
					{
						num4 = 0.5f;
					}
					float num5 = 1f;
					float num6 = num4 + (num5 - num4) * num3;
					result = Math.Max(this.method_182(contactType_0), this.method_182(Contact_Base.ContactType.Submarine)) * num6;
				}
				else
				{
					result = -1f;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100884", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0000D943 File Offset: 0x0000BB43
		public float method_159()
		{
			return Math.Max(this.float_29, Math.Max(this.float_31, Math.Max(this.float_33, this.float_35)));
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0000D96C File Offset: 0x0000BB6C
		public float method_160()
		{
			return Math.Max(this.float_30, Math.Max(this.float_32, Math.Max(this.float_34, this.float_36)));
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x001E612C File Offset: 0x001E432C
		public float method_161()
		{
			float result;
			try
			{
				switch (this.method_169())
				{
				case Weapon.WeaponGuidanceType.SemiActive:
				case Weapon.WeaponGuidanceType.CommandGuided_Datalinked:
				case Weapon.WeaponGuidanceType.TVM:
				case Weapon.WeaponGuidanceType.BeamRiding:
				case Weapon.WeaponGuidanceType.SemiActive_Plus_Active:
				case Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active:
					result = 0f;
					break;
				case Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive:
				case Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive:
				case Weapon.WeaponGuidanceType.Passive:
				case Weapon.WeaponGuidanceType.Inertial_Plus_Passive:
				case Weapon.WeaponGuidanceType.DataLink_Plus_Passive:
				case Weapon.WeaponGuidanceType.Active:
				case Weapon.WeaponGuidanceType.Datalink_Plus_Active:
				case Weapon.WeaponGuidanceType.Inertial_Plus_Active:
					if (this.sensor_0.Length == 0)
					{
						result = 0f;
					}
					else
					{
						result = Enumerable.ElementAtOrDefault<Sensor>(Enumerable.OrderByDescending<Sensor, float>(this.sensor_0, (Weapon._Closure$__.$I164-0 == null) ? (Weapon._Closure$__.$I164-0 = new Func<Sensor, float>(Weapon._Closure$__.$I.method_0)) : Weapon._Closure$__.$I164-0), 0).method_30();
					}
					break;
				default:
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw new NotImplementedException();
				case Weapon.WeaponGuidanceType.Inertial:
					if (this.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon)
					{
						Weapon weapon = this.warhead_0[0].method_17(this.scenario_0);
						if (weapon.sensor_0.Length > 0)
						{
							result = weapon.sensor_0[0].method_30();
							break;
						}
						if (weapon.warhead_0.Length <= 0)
						{
							result = 0f;
							break;
						}
						if (weapon.warhead_0[0].method_11())
						{
							Weapon._WeaponType weaponType = weapon.method_167();
							if (weaponType <= Weapon._WeaponType.DepthCharge)
							{
								if (weaponType - Weapon._WeaponType.GuidedWeapon <= 3 || weaponType == Weapon._WeaponType.GuidedProjectile)
								{
									goto IL_180;
								}
								if (weaponType - Weapon._WeaponType.Torpedo <= 1)
								{
									goto IL_184;
								}
							}
							else
							{
								if (weaponType - Weapon._WeaponType.BottomMine <= 4)
								{
									goto IL_184;
								}
								if (weaponType - Weapon._WeaponType.BallisticMissile <= 1 || weaponType == Weapon._WeaponType.HGV)
								{
									goto IL_180;
								}
							}
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new NotImplementedException();
							IL_180:
							Weapon.Enum128 enum128_ = Weapon.Enum128.const_0;
							goto IL_186;
							IL_184:
							enum128_ = Weapon.Enum128.const_2;
							IL_186:
							result = Explosion.smethod_1((double)weapon.warhead_0[0].float_0, enum128_);
							break;
						}
					}
					result = 0f;
					break;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100885", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x001E634C File Offset: 0x001E454C
		public bool method_162()
		{
			Weapon._WeaponType weaponType = this.method_167();
			return weaponType - Weapon._WeaponType.ContactBomb_Suicide <= 1;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x001E6374 File Offset: 0x001E4574
		public float method_163()
		{
			float result;
			try
			{
				if (this.method_162())
				{
					result = 0f;
				}
				else
				{
					switch (this.method_169())
					{
					case Weapon.WeaponGuidanceType.SemiActive:
					case Weapon.WeaponGuidanceType.CommandGuided_Datalinked:
					case Weapon.WeaponGuidanceType.TVM:
					case Weapon.WeaponGuidanceType.BeamRiding:
					case Weapon.WeaponGuidanceType.SemiActive_Plus_Active:
					case Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active:
						result = 0f;
						break;
					case Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive:
					case Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive:
					case Weapon.WeaponGuidanceType.Passive:
					case Weapon.WeaponGuidanceType.Inertial_Plus_Passive:
					case Weapon.WeaponGuidanceType.DataLink_Plus_Passive:
					case Weapon.WeaponGuidanceType.Active:
					case Weapon.WeaponGuidanceType.Datalink_Plus_Active:
					case Weapon.WeaponGuidanceType.Inertial_Plus_Active:
						result = this.method_159();
						break;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw new NotImplementedException();
					case Weapon.WeaponGuidanceType.Inertial:
						if (this.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon)
						{
							Weapon weapon = this.warhead_0[0].method_17(this.scenario_0);
							if (weapon.sensor_0.Length > 0)
							{
								result = weapon.sensor_0[0].method_30();
								break;
							}
							if (weapon.warhead_0.Length <= 0)
							{
								result = 0f;
								break;
							}
							if (weapon.warhead_0[0].method_11())
							{
								Weapon._WeaponType weaponType = weapon.method_167();
								if (weaponType <= Weapon._WeaponType.DepthCharge)
								{
									if (weaponType - Weapon._WeaponType.GuidedWeapon <= 3)
									{
										goto IL_141;
									}
									if (weaponType - Weapon._WeaponType.Torpedo <= 1)
									{
										goto IL_145;
									}
								}
								else
								{
									if (weaponType - Weapon._WeaponType.BottomMine <= 4)
									{
										goto IL_145;
									}
									if (weaponType - Weapon._WeaponType.BallisticMissile <= 1 || weaponType == Weapon._WeaponType.HGV)
									{
										goto IL_141;
									}
								}
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								throw new NotImplementedException();
								IL_141:
								Weapon.Enum128 enum128_ = Weapon.Enum128.const_0;
								goto IL_147;
								IL_145:
								enum128_ = Weapon.Enum128.const_2;
								IL_147:
								result = Explosion.smethod_1((double)weapon.warhead_0[0].float_0, enum128_);
								break;
							}
						}
						if (this.warhead_0[0].method_11())
						{
							Weapon._WeaponType weaponType2 = this.method_167();
							if (weaponType2 <= Weapon._WeaponType.DepthCharge)
							{
								if (weaponType2 - Weapon._WeaponType.GuidedWeapon <= 3 || weaponType2 == Weapon._WeaponType.GuidedProjectile)
								{
									goto IL_1E2;
								}
								if (weaponType2 - Weapon._WeaponType.Torpedo <= 1)
								{
									goto IL_1E7;
								}
							}
							else
							{
								if (weaponType2 - Weapon._WeaponType.BottomMine <= 4)
								{
									goto IL_1E7;
								}
								if (weaponType2 - Weapon._WeaponType.BallisticMissile <= 1 || weaponType2 == Weapon._WeaponType.HGV)
								{
									goto IL_1E2;
								}
							}
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw new NotImplementedException();
							IL_1E2:
							Weapon.Enum128 enum128_2 = Weapon.Enum128.const_0;
							goto IL_1EA;
							IL_1E7:
							enum128_2 = Weapon.Enum128.const_2;
							IL_1EA:
							result = Explosion.smethod_1((double)this.warhead_0[0].float_0, enum128_2);
						}
						else
						{
							result = 0f;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200294", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x001E65F0 File Offset: 0x001E47F0
		public bool method_164()
		{
			Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
			if (weaponGuidanceType != Weapon.WeaponGuidanceType.SemiActive && weaponGuidanceType != Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive)
			{
				switch (weaponGuidanceType)
				{
				case Weapon.WeaponGuidanceType.DataLink_Plus_Passive:
				case Weapon.WeaponGuidanceType.Datalink_Plus_Active:
				case Weapon.WeaponGuidanceType.CommandGuided_Datalinked:
				case Weapon.WeaponGuidanceType.BeamRiding:
				case Weapon.WeaponGuidanceType.SemiActive_Plus_Active:
				case Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active:
					break;
				default:
					return false;
				}
			}
			return !Information.IsNothing(this.method_179());
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x001E6654 File Offset: 0x001E4854
		public bool method_165()
		{
			Sensor[] sensor_ = this.sensor_0;
			checked
			{
				for (int i = 0; i < sensor_.Length; i++)
				{
					if (sensor_[i].struct33_0.bool_1)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x001E668C File Offset: 0x001E488C
		public bool method_166()
		{
			bool result;
			try
			{
				Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
				if (weaponGuidanceType == Weapon.WeaponGuidanceType.Inertial)
				{
					if (!this.method_187().method_46())
					{
						result = true;
					}
					else
					{
						Waypoint waypoint = this.method_187().method_4()[Enumerable.Count<Waypoint>(this.method_187().method_4()) - 1];
						float num = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), waypoint.imethod_2(), waypoint.imethod_0());
						float num2 = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), this.geoPoint_0.imethod_2(), this.geoPoint_0.imethod_0());
						result = (num < num2);
					}
				}
				else
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100887", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0000D995 File Offset: 0x0000BB95
		public Weapon._WeaponType method_167()
		{
			return this._WeaponType_0;
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0000D99D File Offset: 0x0000BB9D
		public void method_168(Weapon._WeaponType _WeaponType_1)
		{
			this._WeaponType_0 = _WeaponType_1;
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0000D9A6 File Offset: 0x0000BBA6
		public Weapon.WeaponGuidanceType method_169()
		{
			if (this.nullable_16 == null)
			{
				this.method_271();
			}
			return this.nullable_16.Value;
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0000D9C6 File Offset: 0x0000BBC6
		public Sensor method_170()
		{
			return this.sensor_2;
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0000D9CE File Offset: 0x0000BBCE
		public void method_171(Sensor sensor_3)
		{
			this.sensor_2 = sensor_3;
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0000D9D7 File Offset: 0x0000BBD7
		public int method_172()
		{
			return this.int_8;
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0000D9DF File Offset: 0x0000BBDF
		public void method_173(int int_21)
		{
			this.int_8 = int_21;
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		public int method_174()
		{
			return this.int_10;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		public void method_175(int int_21)
		{
			this.int_10 = int_21;
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x001E67A0 File Offset: 0x001E49A0
		public bool method_176()
		{
			Weapon._WeaponType weaponType_ = this._WeaponType_0;
			if (weaponType_ - Weapon._WeaponType.Decoy_Expendable > 2)
			{
				if (weaponType_ != Weapon._WeaponType.SensorPod)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x001E67D0 File Offset: 0x001E49D0
		public ActiveUnit method_177()
		{
			ActiveUnit result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = null;
			}
			else
			{
				result = this.activeUnit_0;
			}
			return result;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0000D9F9 File Offset: 0x0000BBF9
		public void method_178(ActiveUnit activeUnit_3)
		{
			this.activeUnit_0 = activeUnit_3;
			if (Information.IsNothing(activeUnit_3))
			{
				this.string_9 = null;
				return;
			}
			this.string_9 = activeUnit_3.string_0;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x001E67F8 File Offset: 0x001E49F8
		public ActiveUnit method_179()
		{
			ActiveUnit result;
			if (this.activeUnit_1 == null)
			{
				result = null;
			}
			else if (this.activeUnit_1.method_82())
			{
				result = null;
			}
			else
			{
				result = this.activeUnit_1;
			}
			return result;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x001E682C File Offset: 0x001E4A2C
		public void method_180(ActiveUnit activeUnit_3)
		{
			checked
			{
				if (activeUnit_3 == null)
				{
					CommDevice[] array = this.vmethod_94();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].method_25(0);
					}
					this.method_271();
				}
				this.activeUnit_1 = activeUnit_3;
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x001E6868 File Offset: 0x001E4A68
		public float method_181(ActiveUnit activeUnit_3, Contact contact_0, bool bool_34, Doctrine doctrine_1, bool bool_35)
		{
			float result;
			try
			{
				if (!bool_35 && !Information.IsNothing(doctrine_1) && !Information.IsNothing(activeUnit_3) && this.method_167() == Weapon._WeaponType.Gun && contact_0.method_134() && activeUnit_3.bool_3)
				{
					Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = doctrine_1.method_147(this.scenario_0, false, false, false);
					byte? b = (gunStrafeGroundTargets != null) ? new byte?((byte)gunStrafeGroundTargets.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null).GetValueOrDefault())
					{
						return 0f;
					}
				}
				if (Information.IsNothing(contact_0.activeUnit_0))
				{
					if (this.method_199())
					{
						result = this.method_182(Contact_Base.ContactType.Air);
					}
					else if (this.bool_6)
					{
						result = this.method_182(Contact_Base.ContactType.Surface);
					}
					else if (this.bool_8)
					{
						result = this.method_182(Contact_Base.ContactType.Facility_Fixed);
					}
					else if (this.bool_5)
					{
						result = this.method_182(Contact_Base.ContactType.Submarine);
					}
					else
					{
						result = this.method_159();
					}
				}
				else
				{
					ActiveUnit activeUnit = contact_0.activeUnit_0;
					float num;
					if (Information.IsNothing(activeUnit))
					{
						num = this.method_182(contact_0.contactType_0);
					}
					else if (activeUnit.bool_5 && ((Submarine)activeUnit).method_161())
					{
						if (this.method_182(Contact_Base.ContactType.Submarine) == 0f)
						{
							num = this.method_182(Contact_Base.ContactType.Surface);
						}
						else
						{
							num = this.method_182(Contact_Base.ContactType.Submarine);
						}
					}
					else if (activeUnit.bool_3 && ((Aircraft)activeUnit).method_144())
					{
						num = Math.Max(this.method_182(Contact_Base.ContactType.Air), this.method_182(Contact_Base.ContactType.Surface));
					}
					else
					{
						num = this.method_182(contact_0.contactType_0);
					}
					if (bool_34 && num > 0f && !Information.IsNothing(doctrine_1))
					{
						Weapon weapon = this;
						if (doctrine_1.method_239(ref weapon))
						{
							weapon = this;
							Doctrine._WRA_WeaponTargetType wra_WeaponTargetType = Doctrine.smethod_7(ref contact_0);
							Doctrine._WRA_WeaponTargetType wra_WeaponTargetType2 = Doctrine.smethod_6(ref weapon, ref contact_0, ref wra_WeaponTargetType);
							Scenario scenario_ = this.scenario_0;
							Doctrine._WRA_WeaponTargetType selectedNodeTargetType = wra_WeaponTargetType2;
							bool findInheritedValuesOnly = false;
							int? num2 = null;
							int? num3 = null;
							num3 = doctrine_1.method_9(scenario_, this, selectedNodeTargetType, findInheritedValuesOnly, ref num2, ref num3);
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num = 0f;
							}
							if (num > 0f)
							{
								Scenario scenario_2 = this.scenario_0;
								int dbid = this.DBID;
								Doctrine._WRA_WeaponTargetType selectedNodeTargetType2 = wra_WeaponTargetType2;
								bool findInheritedValuesOnly2 = false;
								num3 = null;
								num2 = null;
								int? num4 = doctrine_1.method_23(scenario_2, dbid, selectedNodeTargetType2, findInheritedValuesOnly2, ref num3, ref num2);
								if (!Information.IsNothing(num4))
								{
									num2 = num4;
									if (((num2 != null) ? new bool?(num2.GetValueOrDefault() == 0) : null).GetValueOrDefault())
									{
										num = 0f;
									}
									num2 = num4;
									if (((num2 != null) ? new bool?(num2.GetValueOrDefault() > 0) : null).GetValueOrDefault() && (float)num4.Value < num)
									{
										num = (float)num4.Value;
									}
								}
							}
						}
					}
					result = num;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200582", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x001E6BE4 File Offset: 0x001E4DE4
		private float method_182(Contact_Base.ContactType contactType_0)
		{
			switch (contactType_0)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
				return this.float_29;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.UndeterminedNaval:
			case Contact_Base.ContactType.Mine:
			case Contact_Base.ContactType.ActivationPoint:
				return this.float_31;
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Torpedo:
				return this.float_35;
			case Contact_Base.ContactType.Aimpoint:
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
				return this.float_33;
			case Contact_Base.ContactType.Decoy_Air:
				return this.float_29;
			}
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
			throw new NotImplementedException();
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0000DA1E File Offset: 0x0000BC1E
		public float method_183()
		{
			return this.float_48;
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x001E6C98 File Offset: 0x001E4E98
		public void method_184(float float_52)
		{
			this.float_48 = float_52;
			if (this.float_48 > 5f && (Information.IsNothing(this.method_179()) || this.method_169() == Weapon.WeaponGuidanceType.TVM))
			{
				Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
				if (weaponGuidanceType != Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive)
				{
					if (weaponGuidanceType - Weapon.WeaponGuidanceType.SemiActive_Plus_Active <= 1)
					{
						this.method_228(true, true, false);
						return;
					}
					this.scenario_0.method_65(this);
					if (this.method_199())
					{
						base.method_124(string.Concat(new string[]
						{
							"Weapon: ",
							this.Name,
							" is running blind for more than ",
							Conversions.ToString((int)Math.Round((double)this.float_48)),
							" sec... self-destructing."
						}), "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						return;
					}
					base.method_124(string.Concat(new string[]
					{
						"Weapon: ",
						this.Name,
						" is running blind for more than ",
						Conversions.ToString((int)Math.Round((double)this.float_48)),
						" sec... missed target."
					}), "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0000DA26 File Offset: 0x0000BC26
		public float method_185()
		{
			return this.float_49;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0000DA2E File Offset: 0x0000BC2E
		public void method_186(float float_52)
		{
			this.float_49 = float_52;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00003024 File Offset: 0x00001224
		public override bool vmethod_43()
		{
			return false;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x001E6DF4 File Offset: 0x001E4FF4
		public Weapon_Navigator method_187()
		{
			if (Information.IsNothing(this.weapon_Navigator_0))
			{
				ActiveUnit activeUnit = this;
				this.weapon_Navigator_0 = new Weapon_Navigator(ref activeUnit);
			}
			return this.weapon_Navigator_0;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0000DA37 File Offset: 0x0000BC37
		public virtual Weapon_AI vmethod_142()
		{
			if (Information.IsNothing(this.weapon_AI_0))
			{
				this.weapon_AI_0 = new Weapon_AI(this);
			}
			return this.weapon_AI_0;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x001E6E24 File Offset: 0x001E5024
		public virtual Class203 vmethod_143()
		{
			if (Information.IsNothing(this.class203_0))
			{
				ActiveUnit activeUnit = this;
				this.class203_0 = new Class203(ref activeUnit);
			}
			return this.class203_0;
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x001E6E54 File Offset: 0x001E5054
		public Class223 method_188()
		{
			if (Information.IsNothing(this.class223_0))
			{
				ActiveUnit activeUnit = this;
				this.class223_0 = new Class223(ref activeUnit);
			}
			return this.class223_0;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x001E6E84 File Offset: 0x001E5084
		public Weapon_CommStuff method_189()
		{
			if (Information.IsNothing(this.weapon_CommStuff_0))
			{
				ActiveUnit activeUnit = this;
				this.weapon_CommStuff_0 = new Weapon_CommStuff(ref activeUnit);
			}
			return this.weapon_CommStuff_0;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x001E6EB4 File Offset: 0x001E50B4
		public Class188 method_190()
		{
			if (Information.IsNothing(this.class188_0))
			{
				ActiveUnit activeUnit = this;
				this.class188_0 = new Class188(ref activeUnit);
			}
			return this.class188_0;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x001E6EE4 File Offset: 0x001E50E4
		public bool method_191()
		{
			return this.warhead_0.Length != 0 && this.warhead_0[0].method_14(this.scenario_0);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0000DA58 File Offset: 0x0000BC58
		public bool method_192()
		{
			return this.float_29 > 15f;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x001E6F1C File Offset: 0x001E511C
		public bool method_193()
		{
			return this.method_167() == Weapon._WeaponType.GuidedWeapon && this.float_29 <= 15f;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0000DA67 File Offset: 0x0000BC67
		public bool method_194()
		{
			return Math.Max(this.float_31, Math.Max(this.float_33, this.float_35)) >= 6f;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0000D620 File Offset: 0x0000B820
		public override double vmethod_28(bool? _HintIsOperating = null)
		{
			return this.double_1;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00008549 File Offset: 0x00006749
		public override void vmethod_29(bool? _HintIsOperating = null, double value)
		{
			this.double_1 = value;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0000D628 File Offset: 0x0000B828
		public override double vmethod_30(bool? _HintIsOperating = null)
		{
			return this.double_0;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000085A7 File Offset: 0x000067A7
		public override void vmethod_31(bool? _HintIsOperating = null, double value)
		{
			this.double_0 = value;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x001E6F4C File Offset: 0x001E514C
		public bool method_195()
		{
			return this.class394_0.bool_8 || this.class394_0.bool_7 || this.class394_0.bool_13 || this.class394_0.bool_12 || this.class394_0.bool_6 || this.class394_0.bool_5;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0000DA8F File Offset: 0x0000BC8F
		public bool method_196()
		{
			return this.class394_0.bool_0 || this.class394_0.bool_5;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x001E6FA8 File Offset: 0x001E51A8
		public bool method_197()
		{
			return !Information.IsNothing(this.class394_0) && this.class394_0.bool_1;
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0000DAAB File Offset: 0x0000BCAB
		public bool method_198()
		{
			return this.class394_0.bool_5;
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x001E6FD4 File Offset: 0x001E51D4
		public override bool vmethod_3()
		{
			return this.method_167() == Weapon._WeaponType.BallisticMissile || this.struct36_0.bool_15;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x001E7000 File Offset: 0x001E5200
		public bool method_199()
		{
			return this.method_167() != Weapon._WeaponType.Decoy_Vehicle && this.method_167() != Weapon._WeaponType.Decoy_Expendable && this.method_167() != Weapon._WeaponType.Decoy_Towed && !Information.IsNothing(this.class394_0) && (this.class394_0.bool_3 || this.class394_0.bool_2);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x001E7070 File Offset: 0x001E5270
		public bool method_200()
		{
			return this.method_167() == Weapon._WeaponType.GuidedWeapon && !Information.IsNothing(this.class394_0) && (this.class394_0.bool_3 || this.class394_0.bool_2);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x001E70BC File Offset: 0x001E52BC
		public bool method_201()
		{
			checked
			{
				if (this.method_200())
				{
					Sensor[] sensor_ = this.sensor_0;
					for (int i = 0; i < sensor_.Length; i++)
					{
						if (sensor_[i].sensor_Type_0 == Sensor.Sensor_Type.Radar)
						{
							bool result = true;
							IL_36:
							return result;
						}
					}
					goto IL_36;
				}
				return false;
			}
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x001E710C File Offset: 0x001E530C
		public bool method_202()
		{
			Weapon._WeaponType weaponType = this.method_167();
			if (weaponType != Weapon._WeaponType.GuidedWeapon)
			{
				if (weaponType != Weapon._WeaponType.Decoy_Vehicle)
				{
					switch (weaponType)
					{
					case Weapon._WeaponType.Torpedo:
						goto IL_5B;
					default:
						return false;
					case Weapon._WeaponType.Sonobuoy:
						break;
					case Weapon._WeaponType.BottomMine:
					case Weapon._WeaponType.MooredMine:
					case Weapon._WeaponType.FloatingMine:
					case Weapon._WeaponType.MovingMine:
					case Weapon._WeaponType.RisingMine:
					case Weapon._WeaponType.DriftingMine:
					case Weapon._WeaponType.DummyMine:
						return true;
					}
				}
				return true;
			}
			IL_5B:
			return true;
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		public bool method_203()
		{
			return this.class394_0.bool_4;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x001E7178 File Offset: 0x001E5378
		public bool method_204()
		{
			return this.method_167() == Weapon._WeaponType.RV | this.method_167() == Weapon._WeaponType.HGV;
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x001E71AC File Offset: 0x001E53AC
		public bool method_205()
		{
			Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
			return weaponGuidanceType - Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive <= 1 || weaponGuidanceType - Weapon.WeaponGuidanceType.Inertial_Plus_Passive <= 4;
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0000DAC5 File Offset: 0x0000BCC5
		public override bool vmethod_127()
		{
			return !base.method_82();
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x001E71D4 File Offset: 0x001E53D4
		public int method_206(ActiveUnit activeUnit_3)
		{
			int result;
			if (this.warhead_0.Length == 0)
			{
				result = 0;
			}
			else if (!this.warhead_0[0].method_16(this, activeUnit_3))
			{
				result = 0;
			}
			else if (Information.IsNothing(activeUnit_3))
			{
				result = 0;
			}
			else
			{
				if (this.method_191())
				{
					if (activeUnit_3.bool_5)
					{
						if (((Submarine)activeUnit_3).method_161())
						{
							return 220;
						}
						return -100;
					}
					else if (activeUnit_3.bool_3 || activeUnit_3.method_2() || activeUnit_3.method_1())
					{
						return (int)Math.Round((double)activeUnit_3.vmethod_13());
					}
				}
				if (this.warhead_0[0].method_16(this, activeUnit_3))
				{
					Warhead.WarheadType warheadType_ = this.warhead_0[0].warheadType_0;
					if (warheadType_ > Warhead.WarheadType.Fragmentation_ABM)
					{
						if (warheadType_ <= Warhead.WarheadType.Cluster_Penetrator)
						{
							if (warheadType_ == Warhead.WarheadType.Nuclear)
							{
								return (int)Math.Round(Math.Pow((double)(this.warhead_0[0].float_0 / 1000000f), 0.3333333333333333) * 220.0);
							}
							if (warheadType_ - Warhead.WarheadType.Cluster_AP > 2)
							{
								goto IL_1BF;
							}
						}
						else if (warheadType_ != Warhead.WarheadType.Cluster_SmartSubs)
						{
							if (warheadType_ != Warhead.WarheadType.EMP_Omni)
							{
								goto IL_1BF;
							}
							return (int)Math.Round(3055.8);
						}
						return 800;
					}
					if (warheadType_ != Warhead.WarheadType.HE_BlastFrag)
					{
						if (warheadType_ != Warhead.WarheadType.Fragmentation)
						{
							switch (warheadType_)
							{
							case Warhead.WarheadType.ContinuousRod:
							case Warhead.WarheadType.Fragmentation_ABM:
								break;
							case Warhead.WarheadType.HardTargetPenetrator:
							case Warhead.WarheadType.SuperFrag:
								goto IL_1BF;
							case Warhead.WarheadType.FAE:
								return 1;
							default:
								goto IL_1BF;
							}
						}
						return (int)Math.Round((double)(Explosion.smethod_2((double)this.warhead_0[0].float_0, Weapon.Enum128.const_0) * 1852f) * 0.5);
					}
					return (int)Math.Round((double)(Explosion.smethod_1((double)this.warhead_0[0].float_0, Weapon.Enum128.const_0) * 1852f) * 0.5);
					IL_1BF:
					result = 0;
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x001E73C4 File Offset: 0x001E55C4
		public override GlobalVariables.TargetVisualSizeClass vmethod_121()
		{
			float float_ = this.float_13;
			GlobalVariables.TargetVisualSizeClass result;
			if (float_ > 10f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VLarge;
			}
			else if (float_ > 5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Large;
			}
			else if (float_ > 3.5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Medium;
			}
			else if (float_ > 2.5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.Small;
			}
			else if (float_ > 1.5f)
			{
				result = GlobalVariables.TargetVisualSizeClass.VSmall;
			}
			else
			{
				result = GlobalVariables.TargetVisualSizeClass.Stealthy;
			}
			return result;
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x001E7418 File Offset: 0x001E5618
		public static void smethod_15(Weapon weapon_1, Scenario scenario_1, bool bool_34)
		{
			if (weapon_1.vmethod_6() && weapon_1.method_167() == Weapon._WeaponType.GuidedWeapon && (!weapon_1.vmethod_3() || !weapon_1.method_276()) && !scenario_1.FeatureCompatibility.get_GuidedWeaponsPitchAttitude(scenario_1.method_39()))
			{
				int num;
				if (scenario_1.Cache_FuelForPitchEnabledWeapons.ContainsKey(weapon_1.DBID))
				{
					num = scenario_1.Cache_FuelForPitchEnabledWeapons[weapon_1.DBID];
				}
				else
				{
					num = Class404.smethod_0(weapon_1.DBID, scenario_1, bool_34);
					scenario_1.Cache_FuelForPitchEnabledWeapons.TryAdd(weapon_1.DBID, num);
				}
				if ((float)num > weapon_1.vmethod_67()[0].float_0)
				{
					weapon_1.vmethod_67()[0].float_0 = (float)num;
					weapon_1.vmethod_67()[0].int_0 = num;
				}
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x001E74DC File Offset: 0x001E56DC
		public static Weapon smethod_16(ref Scenario theScen, int WeaponDBID, string theGUID = null)
		{
			Weapon result;
			try
			{
				if (WeaponDBID == 0)
				{
					result = null;
				}
				else
				{
					Weapon._WeaponType weaponType = DBFunctions.smethod_58(WeaponDBID, theScen);
					Weapon weapon;
					if (weaponType <= Weapon._WeaponType.Torpedo)
					{
						if (weaponType == Weapon._WeaponType.GuidedProjectile)
						{
							weapon = new Class352(ref theScen, WeaponDBID, null);
							goto IL_72;
						}
						if (weaponType == Weapon._WeaponType.Torpedo)
						{
							weapon = new Class354(ref theScen, WeaponDBID, null);
							goto IL_72;
						}
					}
					else
					{
						if (weaponType == Weapon._WeaponType.BallisticMissile)
						{
							weapon = new Class351(ref theScen, WeaponDBID, null);
							goto IL_72;
						}
						if (weaponType == Weapon._WeaponType.HGV)
						{
							weapon = new Class353(ref theScen, WeaponDBID, null);
							goto IL_72;
						}
					}
					weapon = new Weapon(ref theScen, WeaponDBID, null);
					IL_72:
					weapon.scenario_0 = theScen;
					weapon.bool_2 = true;
					DBFunctions.smethod_60(theScen.method_39(), weapon, WeaponDBID, theScen, true);
					if (weapon.vmethod_141() && weapon.method_145() > 100000f)
					{
						weapon.method_146(100000f);
					}
					if (weapon._WeaponType_0 == Weapon._WeaponType.RV)
					{
						weapon.float_32 = 1f;
					}
					if (weapon._WeaponType_0 == Weapon._WeaponType.Sonobuoy && weapon.sensor_0.Length > 0 && weapon.sensor_0[0].method_46())
					{
						weapon.sensor_0[0].method_77();
					}
					if (weapon.vmethod_3() && weapon.method_191())
					{
						weapon.list_3.Add(Weapon.Enum130.const_1);
					}
					if (string.IsNullOrEmpty(theGUID))
					{
						weapon.vmethod_0(IDGenerator.smethod_0().method_0().ToLower());
					}
					else
					{
						weapon.vmethod_0(theGUID);
					}
					result = weapon;
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ex.Data.Add("Error at 100902", "");
				GameGeneral.smethod_25(ref ex);
				result = null;
			}
			return result;
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x001E7684 File Offset: 0x001E5884
		public Weapon(ref Scenario scenario_1) : base(ref scenario_1, null)
		{
			this.warhead_0 = new Warhead[0];
			this.hashSet_0 = new HashSet<int>();
			this.struct36_0 = default(Weapon.Struct36);
			this.vmethod_140(new ObservableList<WeaponRec>());
			this.list_3 = new List<Weapon.Enum130>();
			this.bool_31 = false;
			this.bool_32 = false;
			this.bool_33 = false;
			this.bool_2 = true;
			base.method_134();
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x001E7684 File Offset: 0x001E5884
		private Weapon(ref Scenario theScen, int WeaponDBID, string theGUID = null) : base(ref theScen, null)
		{
			this.warhead_0 = new Warhead[0];
			this.hashSet_0 = new HashSet<int>();
			this.struct36_0 = default(Weapon.Struct36);
			this.vmethod_140(new ObservableList<WeaponRec>());
			this.list_3 = new List<Weapon.Enum130>();
			this.bool_31 = false;
			this.bool_32 = false;
			this.bool_33 = false;
			this.bool_2 = true;
			base.method_134();
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x001E76F4 File Offset: 0x001E58F4
		public bool method_207()
		{
			bool result;
			if (this.warhead_0.Length > 0)
			{
				Warhead.WarheadType warheadType_ = this.warhead_0[0].warheadType_0;
				result = (warheadType_ - Warhead.WarheadType.Laser_COIL <= 3);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		public bool method_208()
		{
			return this._WeaponType_0 == Weapon._WeaponType.Decoy_Expendable || this._WeaponType_0 == Weapon._WeaponType.Decoy_Towed || this._WeaponType_0 == Weapon._WeaponType.Decoy_Vehicle;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public bool method_209()
		{
			return this._WeaponType_0 == Weapon._WeaponType.TrainingRound;
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x001E7730 File Offset: 0x001E5930
		public bool method_210()
		{
			bool result;
			if (!this.method_208())
			{
				result = false;
			}
			else
			{
				foreach (XSection xsection in base.method_64())
				{
					if ((xsection.enum132_0 == XSection.Enum132.const_4 || xsection.enum132_0 == XSection.Enum132.const_0) && (xsection.method_9(this) > -10000f || xsection.method_10(this) > -10000f || xsection.method_11(this) > -10000f))
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x001E77B0 File Offset: 0x001E59B0
		public bool method_211()
		{
			if (this.nullable_19 == null)
			{
				this.nullable_19 = new bool?(false);
				if (!this.method_208())
				{
					this.nullable_19 = new bool?(false);
				}
				else
				{
					foreach (XSection xsection in base.method_64())
					{
						if ((xsection.enum132_0 == XSection.Enum132.const_9 || xsection.enum132_0 == XSection.Enum132.const_10) && (xsection.method_9(this) > -10000f || xsection.method_10(this) > -10000f || xsection.method_11(this) > -10000f))
						{
							this.nullable_19 = new bool?(true);
							break;
						}
					}
				}
			}
			return this.nullable_19.Value;
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x001E7868 File Offset: 0x001E5A68
		public bool method_212()
		{
			bool result;
			if (!this.method_208())
			{
				result = false;
			}
			else
			{
				foreach (XSection xsection in base.method_64())
				{
					XSection.Enum132 enum132_ = xsection.enum132_0;
					if (enum132_ - XSection.Enum132.const_7 <= 1 && (xsection.method_9(this) > -10000f || xsection.method_10(this) > -10000f || xsection.method_11(this) > -10000f))
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x001E78E0 File Offset: 0x001E5AE0
		public bool method_213()
		{
			bool result;
			if (!this.method_208())
			{
				result = false;
			}
			else
			{
				foreach (XSection xsection in base.method_64())
				{
					XSection.Enum132 enum132_ = xsection.enum132_0;
					if (enum132_ - XSection.Enum132.const_5 <= 1 && (xsection.method_9(this) > -10000f || xsection.method_10(this) > -10000f || xsection.method_11(this) > -10000f))
					{
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0000DB0A File Offset: 0x0000BD0A
		public static bool smethod_17(int int_21, ref Scenario scenario_1)
		{
			return Weapon.smethod_18(int_21, ref scenario_1) || Weapon.smethod_20(int_21, ref scenario_1) || Weapon.smethod_21(int_21, ref scenario_1) || Weapon.smethod_19(int_21, ref scenario_1);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x001E7958 File Offset: 0x001E5B58
		public static bool smethod_18(int int_21, ref Scenario scenario_1)
		{
			SQLiteConnection sqliteConnection = scenario_1.method_39();
			Weapon._WeaponType weaponType = DBFunctions.smethod_73(int_21, ref sqliteConnection);
			return weaponType == Weapon._WeaponType.DropTank || weaponType == Weapon._WeaponType.FerryTank;
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x001E7988 File Offset: 0x001E5B88
		public static bool smethod_19(int int_21, ref Scenario scenario_1)
		{
			SQLiteConnection sqliteConnection = scenario_1.method_39();
			Weapon._WeaponType weaponType = DBFunctions.smethod_73(int_21, ref sqliteConnection);
			return weaponType == Weapon._WeaponType.Cargo || weaponType == Weapon._WeaponType.Paratroops || weaponType == Weapon._WeaponType.Troops;
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x001E79C0 File Offset: 0x001E5BC0
		public static bool smethod_20(int int_21, ref Scenario scenario_1)
		{
			SQLiteConnection sqliteConnection = scenario_1.method_39();
			return DBFunctions.smethod_73(int_21, ref sqliteConnection) == Weapon._WeaponType.Sonobuoy;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x001E79E4 File Offset: 0x001E5BE4
		public static bool smethod_21(int int_21, ref Scenario scenario_1)
		{
			SQLiteConnection sqliteConnection = scenario_1.method_39();
			return DBFunctions.smethod_73(int_21, ref sqliteConnection) == Weapon._WeaponType.Gun;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000DB30 File Offset: 0x0000BD30
		public bool method_214()
		{
			return this._WeaponType_0 == Weapon._WeaponType.DropTank || this._WeaponType_0 == Weapon._WeaponType.FerryTank;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0000DB4E File Offset: 0x0000BD4E
		public bool method_215()
		{
			return this._WeaponType_0 == Weapon._WeaponType.SensorPod;
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x001E7A08 File Offset: 0x001E5C08
		private int method_216(Side side_1, Contact contact_0, int int_21)
		{
			Weapon.Class395 @class = new Weapon.Class395();
			@class.contact_0 = contact_0;
			@class.int_0 = int_21;
			int result;
			try
			{
				result = Enumerable.Count<ActiveUnit>(Enumerable.Where<ActiveUnit>(Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.Where<ActiveUnit>(Enumerable.Select<ActiveUnit, ActiveUnit>(Enumerable.ToList<ActiveUnit>(side_1.activeUnit_0), (Weapon._Closure$__.$I305-0 == null) ? (Weapon._Closure$__.$I305-0 = new Func<ActiveUnit, ActiveUnit>(Weapon._Closure$__.$I.method_1)) : Weapon._Closure$__.$I305-0), (Weapon._Closure$__.$I305-1 == null) ? (Weapon._Closure$__.$I305-1 = new Func<ActiveUnit, bool>(Weapon._Closure$__.$I.method_2)) : Weapon._Closure$__.$I305-1), (Weapon._Closure$__.$I305-2 == null) ? (Weapon._Closure$__.$I305-2 = new Func<ActiveUnit, ActiveUnit>(Weapon._Closure$__.$I.method_3)) : Weapon._Closure$__.$I305-2), new Func<ActiveUnit, bool>(@class.method_0)));
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100903", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x001E7B14 File Offset: 0x001E5D14
		public bool method_217(ObservableDictionary<int, EmissionContainer> observableDictionary_0, Side side_1, Contact contact_0, bool bool_34, ref Random random_0)
		{
			Weapon.Class396 @class = new Weapon.Class396(@class);
			@class.weapon_0 = this;
			@class.side_0 = side_1;
			@class.contact_0 = contact_0;
			int count = observableDictionary_0.Count;
			bool result;
			try
			{
				float num;
				if (bool_34)
				{
					num = 36000f;
				}
				else
				{
					num = 20f;
				}
				List<int> list = new List<int>();
				int num2 = count - 1;
				int i = 0;
				while (i <= num2)
				{
					int num3;
					EmissionContainer emissionContainer;
					try
					{
						num3 = Enumerable.ElementAtOrDefault<int>(observableDictionary_0.Keys, i);
						emissionContainer = observableDictionary_0[num3];
					}
					catch (Exception ex)
					{
						goto IL_A7;
					}
					goto IL_6F;
					IL_A7:
					i++;
					continue;
					IL_6F:
					if (emissionContainer.float_0 <= num)
					{
						if (!emissionContainer.bool_0)
						{
							int int_ = num3;
							SQLiteConnection sqliteConnection = this.scenario_0.method_39();
							if (!DBFunctions.smethod_97(int_, ref sqliteConnection).method_49())
							{
								goto IL_A7;
							}
						}
						list.Add(num3);
						goto IL_A7;
					}
					goto IL_A7;
				}
				if (list.Count > 0)
				{
					try
					{
						foreach (int num4 in list)
						{
							if (this.method_216(@class.side_0, @class.contact_0, num4) == 0)
							{
								this.keyValuePair_0 = new KeyValuePair<int, EmissionContainer>(num4, observableDictionary_0[num4]);
								return true;
							}
						}
					}
					finally
					{
						List<int>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				List<int> list2 = new List<int>();
				int num5 = count - 1;
				int j = 0;
				while (j <= num5)
				{
					int num3;
					EmissionContainer emissionContainer;
					try
					{
						num3 = Enumerable.ElementAtOrDefault<int>(observableDictionary_0.Keys, j);
						emissionContainer = observableDictionary_0[num3];
					}
					catch (Exception ex2)
					{
						goto IL_186;
					}
					goto IL_156;
					IL_186:
					j++;
					continue;
					IL_156:
					if (emissionContainer.float_0 > num)
					{
						goto IL_186;
					}
					int int_2 = num3;
					SQLiteConnection sqliteConnection = this.scenario_0.method_39();
					if (DBFunctions.smethod_97(int_2, ref sqliteConnection).method_52())
					{
						list2.Add(num3);
						goto IL_186;
					}
					goto IL_186;
				}
				if (list2.Count > 0)
				{
					try
					{
						foreach (int num6 in list2)
						{
							if (this.method_216(@class.side_0, @class.contact_0, num6) == 0)
							{
								this.keyValuePair_0 = new KeyValuePair<int, EmissionContainer>(num6, observableDictionary_0[num6]);
								return true;
							}
						}
					}
					finally
					{
						List<int>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				List<int> list3 = new List<int>();
				int num7 = count - 1;
				int k = 0;
				while (k <= num7)
				{
					int num3;
					EmissionContainer emissionContainer;
					try
					{
						num3 = Enumerable.ElementAtOrDefault<int>(observableDictionary_0.Keys, k);
						emissionContainer = observableDictionary_0[num3];
					}
					catch (Exception ex3)
					{
						goto IL_267;
					}
					goto IL_237;
					IL_267:
					k++;
					continue;
					IL_237:
					if (emissionContainer.float_0 > num)
					{
						goto IL_267;
					}
					int int_3 = num3;
					SQLiteConnection sqliteConnection = this.scenario_0.method_39();
					if (DBFunctions.smethod_97(int_3, ref sqliteConnection).method_53())
					{
						list3.Add(num3);
						goto IL_267;
					}
					goto IL_267;
				}
				if (list3.Count > 0)
				{
					try
					{
						foreach (int num8 in list3)
						{
							if (this.method_216(@class.side_0, @class.contact_0, num8) == 0)
							{
								this.keyValuePair_0 = new KeyValuePair<int, EmissionContainer>(num8, observableDictionary_0[num8]);
								return true;
							}
						}
					}
					finally
					{
						List<int>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
				}
				if (this.struct36_0.bool_3)
				{
					List<int> list4 = new List<int>();
					int num9 = count - 1;
					int l = 0;
					while (l <= num9)
					{
						int num3;
						EmissionContainer emissionContainer;
						try
						{
							num3 = Enumerable.ElementAtOrDefault<int>(observableDictionary_0.Keys, l);
							emissionContainer = observableDictionary_0[num3];
						}
						catch (Exception ex4)
						{
							goto IL_358;
						}
						goto IL_328;
						IL_358:
						l++;
						continue;
						IL_328:
						if (emissionContainer.float_0 > num)
						{
							goto IL_358;
						}
						int int_4 = num3;
						SQLiteConnection sqliteConnection = this.scenario_0.method_39();
						if (DBFunctions.smethod_97(int_4, ref sqliteConnection).method_54())
						{
							list4.Add(num3);
							goto IL_358;
						}
						goto IL_358;
					}
					if (list4.Count > 0)
					{
						try
						{
							foreach (int num10 in list4)
							{
								if (this.method_216(@class.side_0, @class.contact_0, num10) == 0)
								{
									this.keyValuePair_0 = new KeyValuePair<int, EmissionContainer>(num10, observableDictionary_0[num10]);
									return true;
								}
							}
						}
						finally
						{
							List<int>.Enumerator enumerator4;
							((IDisposable)enumerator4).Dispose();
						}
					}
				}
				List<int> list5 = new List<int>();
				int num11 = count - 1;
				int m = 0;
				while (m <= num11)
				{
					int num3;
					EmissionContainer emissionContainer;
					try
					{
						num3 = Enumerable.ElementAtOrDefault<int>(observableDictionary_0.Keys, m);
						emissionContainer = observableDictionary_0[num3];
					}
					catch (Exception ex5)
					{
						goto IL_4A9;
					}
					goto IL_40F;
					IL_4A9:
					m++;
					continue;
					IL_40F:
					if (emissionContainer.float_0 > num)
					{
						goto IL_4A9;
					}
					if (observableDictionary_0[num3].bool_0)
					{
						list5.Add(num3);
						goto IL_4A9;
					}
					int int_5 = num3;
					SQLiteConnection sqliteConnection = this.scenario_0.method_39();
					Sensor sensor = DBFunctions.smethod_97(int_5, ref sqliteConnection);
					if (sensor.method_49())
					{
						list5.Add(num3);
						goto IL_4A9;
					}
					if (sensor.method_52())
					{
						list5.Add(num3);
						goto IL_4A9;
					}
					if (sensor.method_53())
					{
						list5.Add(num3);
						goto IL_4A9;
					}
					if (this.struct36_0.bool_3 && sensor.method_54())
					{
						list5.Add(num3);
						goto IL_4A9;
					}
					goto IL_4A9;
				}
				if (list5.Count > 0)
				{
					IEnumerable<int> enumerable = Enumerable.OrderBy<int, int>(list5, new Func<int, int>(@class.method_0));
					this.keyValuePair_0 = new KeyValuePair<int, EmissionContainer>(Enumerable.ElementAtOrDefault<int>(enumerable, 0), observableDictionary_0[Enumerable.ElementAtOrDefault<int>(enumerable, 0)]);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex6)
			{
				ex6.Data.Add("Error at 100904", "");
				GameGeneral.smethod_25(ref ex6);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x001E8154 File Offset: 0x001E6354
		public override void vmethod_126(float float_52, ref Random random_0)
		{
			if (!Information.IsNothing(this.vmethod_89()))
			{
				try
				{
					if (this.method_167() == Weapon._WeaponType.Sonobuoy)
					{
						return;
					}
					if (base.method_82() | this.bool_24)
					{
						return;
					}
					switch (this.method_169())
					{
					case Weapon.WeaponGuidanceType.SemiActive:
						try
						{
							this.method_247(float_52);
							goto IL_AC6;
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 100908", "");
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							goto IL_AC6;
						}
						break;
					case Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive:
						break;
					case Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive:
						goto IL_117;
					case (Weapon.WeaponGuidanceType)3:
						goto IL_AC6;
					case Weapon.WeaponGuidanceType.Passive:
						goto IL_166;
					case Weapon.WeaponGuidanceType.Inertial_Plus_Passive:
						goto IL_1C5;
					case Weapon.WeaponGuidanceType.DataLink_Plus_Passive:
						goto IL_22A;
					case Weapon.WeaponGuidanceType.Active:
						goto IL_278;
					case Weapon.WeaponGuidanceType.Datalink_Plus_Active:
						goto IL_327;
					case Weapon.WeaponGuidanceType.Inertial_Plus_Active:
						goto IL_3C1;
					case Weapon.WeaponGuidanceType.CommandGuided_Datalinked:
						goto IL_440;
					case Weapon.WeaponGuidanceType.TVM:
						goto IL_488;
					case Weapon.WeaponGuidanceType.BeamRiding:
						goto IL_4D0;
					case Weapon.WeaponGuidanceType.Inertial:
						goto IL_6BB;
					case Weapon.WeaponGuidanceType.SemiActive_Plus_Active:
						try
						{
							if (this.sensor_0.Length > 0 && this.sensor_0[0].method_43())
							{
								if (!this.method_239() && this.method_241(60f, true, true, true, float_52))
								{
									return;
								}
							}
							else if ((double)base.method_37(this.vmethod_142().vmethod_3(), 0f) <= (double)this.sensor_0[0].float_0 * 0.8)
							{
								this.method_228(false, true, true);
							}
							else if (this.method_183() > 5f)
							{
								this.method_228(false, true, true);
							}
							else
							{
								if (this.method_238(float_52))
								{
									return;
								}
								Sensor sensor = this.method_170();
								if (Information.IsNothing(sensor))
								{
									if (!this.method_222())
									{
										this.method_184(this.method_183() + float_52);
										goto IL_AC6;
									}
								}
								else if (!sensor.method_41().Contains(this.vmethod_142().vmethod_3()))
								{
									if (!this.method_222())
									{
										this.method_184(this.method_183() + float_52);
										goto IL_AC6;
									}
								}
								else if (!sensor.method_43() && !this.method_222())
								{
									this.method_184(this.method_183() + float_52);
									goto IL_AC6;
								}
								if (this.method_183() > 0f)
								{
									this.method_184(0f);
								}
								if (this.method_242(90f))
								{
									return;
								}
								if (this.method_241(60f, true, true, true, float_52))
								{
									return;
								}
							}
							goto IL_AC6;
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 100909", "");
							GameGeneral.smethod_25(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							goto IL_AC6;
						}
						goto IL_86C;
					case Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active:
						goto IL_86C;
					default:
						goto IL_AC6;
					}
					try
					{
						this.method_248(float_52);
						goto IL_AC6;
					}
					catch (Exception ex3)
					{
						ex3.Data.Add("Error at 100922", "");
						GameGeneral.smethod_25(ref ex3);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_117:
					try
					{
						this.method_243(float_52);
						this.method_249(float_52);
						goto IL_AC6;
					}
					catch (Exception ex4)
					{
						ex4.Data.Add("Error at 100917", "");
						GameGeneral.smethod_25(ref ex4);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_166:
					try
					{
						if (!this.method_239() && this.method_241(60f, true, false, true, float_52))
						{
							return;
						}
						goto IL_AC6;
					}
					catch (Exception ex5)
					{
						ex5.Data.Add("Error at 100914", "");
						GameGeneral.smethod_25(ref ex5);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_1C5:
					try
					{
						if (!this.method_239())
						{
							if (this.method_241(60f, true, false, false, float_52))
							{
								return;
							}
							this.vmethod_144();
						}
						goto IL_AC6;
					}
					catch (Exception ex6)
					{
						ex6.Data.Add("Error at 100921", "");
						GameGeneral.smethod_25(ref ex6);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_22A:
					try
					{
						this.method_243(float_52);
						this.vmethod_144();
						goto IL_AC6;
					}
					catch (Exception ex7)
					{
						ex7.Data.Add("Error at 100916", "");
						GameGeneral.smethod_25(ref ex7);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_278:
					try
					{
						if (!this.method_239() && this.method_241(60f, true, false, true, float_52))
						{
							return;
						}
						if (!this.method_187().method_46())
						{
							foreach (Sensor sensor2 in this.sensor_0)
							{
								if (sensor2.method_58() && !sensor2.method_43())
								{
									sensor2.method_77();
								}
							}
						}
						else
						{
							this.vmethod_144();
						}
						goto IL_AC6;
					}
					catch (Exception ex8)
					{
						ex8.Data.Add("Error at 100913", "");
						GameGeneral.smethod_25(ref ex8);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_327:
					try
					{
						if (this.sensor_0.Length > 0 && this.sensor_0[0].method_43())
						{
							if (this.method_236(float_52))
							{
								return;
							}
							if (this.method_237(float_52))
							{
								return;
							}
							if (this.method_241(60f, true, true, true, float_52))
							{
								return;
							}
						}
						else
						{
							this.method_243(float_52);
							this.vmethod_144();
						}
						goto IL_AC6;
					}
					catch (Exception ex9)
					{
						ex9.Data.Add("Error at 100915", "");
						GameGeneral.smethod_25(ref ex9);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_3C1:
					try
					{
						if (!this.method_239())
						{
							if (this.method_241(60f, true, false, false, float_52))
							{
								return;
							}
							if (this.sensor_0.Length > 0 && !this.sensor_0[0].method_43())
							{
								this.vmethod_144();
							}
						}
						goto IL_AC6;
					}
					catch (Exception ex10)
					{
						ex10.Data.Add("Error at 100920", "");
						GameGeneral.smethod_25(ref ex10);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_440:
					try
					{
						this.method_243(float_52);
						goto IL_AC6;
					}
					catch (Exception ex11)
					{
						ex11.Data.Add("Error at 100919", "");
						GameGeneral.smethod_25(ref ex11);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_488:
					try
					{
						this.method_245(float_52);
						goto IL_AC6;
					}
					catch (Exception ex12)
					{
						ex12.Data.Add("Error at 100918", "");
						GameGeneral.smethod_25(ref ex12);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_4D0:
					try
					{
						if (this.method_238(float_52))
						{
							return;
						}
						Sensor sensor3 = this.method_170();
						if (Information.IsNothing(sensor3))
						{
							this.vmethod_142().vmethod_4(null);
							base.method_124("Weapon: " + this.Name + " no longer receives guidance signals.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							return;
						}
						if (!sensor3.method_41().Contains(this.vmethod_142().vmethod_3()))
						{
							this.vmethod_142().vmethod_4(null);
							base.method_124("Weapon: " + this.Name + " no longer receives guidance signals.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							return;
						}
						if (!sensor3.method_43())
						{
							this.vmethod_142().vmethod_4(null);
							base.method_124("Weapon: " + this.Name + " no longer receives guidance signals.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							return;
						}
						if (this.method_224() && !Information.IsNothing(sensor3))
						{
							this.method_252(float_52);
							return;
						}
						if (this.method_224())
						{
							this.method_184(this.method_183() + float_52);
							return;
						}
						this.method_184(0f);
						this.vmethod_142().vmethod_3().method_58(0f);
						goto IL_AC6;
					}
					catch (Exception ex13)
					{
						ex13.Data.Add("Error at 100912", "");
						GameGeneral.smethod_25(ref ex13);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						goto IL_AC6;
					}
					IL_6BB:
					this.method_240();
					goto IL_AC6;
					IL_86C:
					try
					{
						if (this.sensor_0.Length > 0 && this.sensor_0[0].method_43())
						{
							if (!this.method_239() && this.method_241(60f, true, true, true, float_52))
							{
								return;
							}
						}
						else if ((double)base.method_37(this.vmethod_142().vmethod_3(), 0f) <= (double)this.sensor_0[0].float_0 * 0.8)
						{
							this.method_228(false, true, true);
						}
						else if (this.method_183() > 5f)
						{
							this.method_228(false, true, true);
						}
						else
						{
							if (this.method_238(float_52))
							{
								return;
							}
							bool flag4;
							if (!Information.IsNothing(this.method_179()))
							{
								try
								{
									List<ActiveUnit> list = null;
									Unit.Enum123? @enum = null;
									bool? flag = null;
									bool? flag2 = null;
									bool? flag3 = null;
									foreach (Sensor sensor4 in this.method_179().vmethod_96())
									{
										if (sensor4.method_43())
										{
											if (sensor4.sensor_Type_0 == Sensor.Sensor_Type.Radar && Information.IsNothing(list))
											{
												list = this.method_179().vmethod_88().method_10(false);
											}
											Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
											Sensor sensor5 = sensor4;
											Sensor.Enum114 enum114_ = Sensor.Enum114.const_1;
											ActiveUnit activeUnit = this.method_179();
											ActiveUnit activeUnit2 = this.vmethod_142().vmethod_3().activeUnit_0;
											List<GeoPoint> list2 = null;
											if (sensor5.method_87(enum114_, activeUnit, activeUnit2, ref list2, this.method_179().method_37(this.vmethod_142().vmethod_3(), 0f), ref lazy, list, ref flag, ref flag2, ref @enum, ref flag3))
											{
												flag4 = true;
												break;
											}
										}
									}
								}
								catch (Exception ex14)
								{
									ex14.Data.Add("Error at 100910", "");
									GameGeneral.smethod_25(ref ex14);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
							}
							if (!flag4)
							{
								this.method_184(this.method_183() + float_52);
							}
							else
							{
								if (this.method_183() > 0f)
								{
									this.method_184(0f);
								}
								if (this.method_242(90f))
								{
									return;
								}
								if (this.method_241(60f, true, true, true, float_52))
								{
									return;
								}
							}
						}
					}
					catch (Exception ex15)
					{
						ex15.Data.Add("Error at 100911", "");
						GameGeneral.smethod_25(ref ex15);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					IL_AC6:;
				}
				catch (Exception ex16)
				{
					ex16.Data.Add("Error at 100907", "");
					GameGeneral.smethod_25(ref ex16);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				if (this.method_185() > 0f && !Information.IsNothing(this.vmethod_142().vmethod_3()))
				{
					this.method_186(0f);
				}
				if (!Information.IsNothing(this.keyValuePair_0) && !Information.IsNothing(this.keyValuePair_0.Value))
				{
					this.keyValuePair_0.Value.float_0 = this.keyValuePair_0.Value.float_0 + float_52;
				}
				float num = this.vmethod_13();
				if (num < 0f)
				{
					base.method_124("Weapon: " + this.Name + " has smashed into the ground", "Weapon issue", LoggedMessage.MessageType.WeaponEndgame, 0, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					double double_ = this.vmethod_30(null);
					double double_2 = this.vmethod_28(null);
					float float_53 = this.vmethod_14(false);
					Random random = GameGeneral.smethod_5();
					this.method_223(double_, double_2, float_53, ref random, true);
					return;
				}
				try
				{
					if (this.vmethod_3())
					{
						if (this.method_221())
						{
							List<Warhead> list3 = new List<Warhead>();
							if (this.method_219())
							{
								int num2 = this.warhead_0.Length - 1;
								for (int k = 0; k <= num2; k++)
								{
									Warhead warhead = this.warhead_0[k];
									Weapon weapon = warhead.method_17(this.scenario_0);
									Contact contact;
									if (Information.IsNothing(this.vmethod_142().vmethod_3()))
									{
										if (Enumerable.Count<Sensor>(weapon.sensor_0) > 0)
										{
											contact = new Class356(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
										}
										else
										{
											contact = new Class355(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
										}
									}
									else if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
									{
										if (this.method_187().method_47())
										{
											if (Enumerable.Count<Sensor>(weapon.sensor_0) > 0)
											{
												contact = new Class356(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
											else
											{
												contact = new Class355(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
										}
									}
									else if (weapon.method_204())
									{
										contact = new Class355(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null));
									}
									else
									{
										contact = this.vmethod_142().vmethod_3();
									}
									ActiveUnit_Weaponry activeUnit_Weaponry = this.vmethod_89();
									Weapon theWeapon = weapon;
									Contact theTarget = contact;
									bool manualFire = false;
									bool ignoreAircraftOrientation = false;
									Mount theMount = null;
									Sensor sensor6 = null;
									short? num3;
									if (activeUnit_Weaponry.method_23(theWeapon, theTarget, ref num3, manualFire, ignoreAircraftOrientation, theMount, ref sensor6).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
									{
										if (k != 0)
										{
											try
											{
												if (this.vmethod_142().method_12().Length > 0)
												{
													if (k - 1 < this.vmethod_142().method_12().Length)
													{
														this.method_218(this, weapon, this.vmethod_142().method_12()[k - 1], float_52, false);
													}
													else
													{
														this.method_218(this, weapon, this.vmethod_142().vmethod_3(), float_52, false);
													}
												}
												else
												{
													this.method_218(this, weapon, contact, float_52, false);
												}
												goto IL_EDE;
											}
											catch (Exception ex17)
											{
												this.method_218(this, weapon, this.vmethod_142().vmethod_3(), float_52, false);
												ex17.Data.Add("Error at 200047", ex17.Message);
												GameGeneral.smethod_25(ref ex17);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												goto IL_EDE;
											}
											goto IL_ED3;
										}
										this.method_218(this, weapon, contact, float_52, true);
										IL_EDE:
										list3.Add(warhead);
									}
									IL_ED3:;
								}
							}
							else if (this.method_220())
							{
								int num4 = this.warhead_0.Length - 1;
								for (int l = 0; l <= num4; l++)
								{
									Warhead warhead2 = this.warhead_0[l];
									Weapon weapon2 = warhead2.method_17(this.scenario_0);
									Contact contact2;
									if (Information.IsNothing(this.vmethod_142().vmethod_3()))
									{
										if (this.method_187().method_47())
										{
											if (Enumerable.Count<Sensor>(weapon2.sensor_0) > 0)
											{
												contact2 = new Class356(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
											else
											{
												contact2 = new Class355(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
										}
									}
									else if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
									{
										if (this.method_187().method_47())
										{
											if (Enumerable.Count<Sensor>(weapon2.sensor_0) > 0)
											{
												contact2 = new Class356(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
											else
											{
												contact2 = new Class355(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
										}
									}
									else if (weapon2.method_204())
									{
										contact2 = new Class355(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null));
									}
									else
									{
										contact2 = this.vmethod_142().vmethod_3();
									}
									ActiveUnit_Weaponry activeUnit_Weaponry2 = this.vmethod_89();
									Weapon theWeapon2 = weapon2;
									Contact theTarget2 = contact2;
									bool manualFire2 = false;
									bool ignoreAircraftOrientation2 = false;
									Mount theMount2 = null;
									Sensor sensor6 = null;
									short? num3;
									if (activeUnit_Weaponry2.method_23(theWeapon2, theTarget2, ref num3, manualFire2, ignoreAircraftOrientation2, theMount2, ref sensor6).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
									{
										this.method_218(this, weapon2, contact2, float_52, l == 0);
										list3.Add(warhead2);
									}
								}
							}
							else
							{
								Warhead warhead3 = this.warhead_0[0];
								Weapon weapon3 = warhead3.method_17(this.scenario_0);
								if (!Information.IsNothing(weapon3))
								{
									Contact contact3;
									if (Information.IsNothing(this.vmethod_142().vmethod_3()))
									{
										if (this.method_187().method_47())
										{
											if (Enumerable.Count<Sensor>(weapon3.sensor_0) > 0)
											{
												contact3 = new Class356(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
											else
											{
												contact3 = new Class355(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
										}
									}
									else if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
									{
										if (this.method_187().method_47())
										{
											if (Enumerable.Count<Sensor>(weapon3.sensor_0) > 0)
											{
												contact3 = new Class356(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
											else
											{
												contact3 = new Class355(Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_2(), Enumerable.Last<Waypoint>(this.method_187().method_4()).imethod_0());
											}
										}
									}
									else if (weapon3.method_204() && weapon3.method_78().Length == 0)
									{
										contact3 = new Class355(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null));
									}
									else
									{
										contact3 = this.vmethod_142().vmethod_3();
									}
									ActiveUnit_Weaponry activeUnit_Weaponry3 = this.vmethod_89();
									Weapon theWeapon3 = weapon3;
									Contact theTarget3 = contact3;
									bool manualFire3 = false;
									bool ignoreAircraftOrientation3 = false;
									Mount theMount3 = null;
									Sensor sensor6 = null;
									short? num3;
									if (activeUnit_Weaponry3.method_23(theWeapon3, theTarget3, ref num3, manualFire3, ignoreAircraftOrientation3, theMount3, ref sensor6).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
									{
										this.method_218(this, weapon3, contact3, float_52, true);
										list3.Add(warhead3);
									}
								}
							}
							try
							{
								foreach (Warhead warhead_ in list3)
								{
									Class429.smethod_35(ref this.warhead_0, warhead_);
								}
							}
							finally
							{
								List<Warhead>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							if (this.warhead_0.Length == 0)
							{
								this.scenario_0.method_65(this);
								return;
							}
						}
					}
					else if (!this.method_231() && this.warhead_0.Length > 0 && this.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon && !this.warhead_0[0].method_17(this.scenario_0).method_191())
					{
						Weapon weapon4 = this.warhead_0[0].method_17(this.scenario_0);
						ActiveUnit_Weaponry activeUnit_Weaponry4 = this.vmethod_89();
						Weapon theWeapon4 = weapon4;
						Contact theTarget4 = this.vmethod_142().vmethod_3();
						short? num5 = new short?((short)Math.Round((double)this.vmethod_14(false)));
						bool manualFire4 = false;
						bool ignoreAircraftOrientation4 = false;
						Mount theMount4 = null;
						Sensor sensor6 = null;
						if (activeUnit_Weaponry4.method_23(theWeapon4, theTarget4, ref num5, manualFire4, ignoreAircraftOrientation4, theMount4, ref sensor6).Item2 == ActiveUnit_Weaponry.Enum36.const_0)
						{
							this.method_218(this, weapon4, this.vmethod_142().vmethod_3(), float_52, true);
							this.scenario_0.method_65(this);
							return;
						}
					}
				}
				catch (Exception ex18)
				{
					ex18.Data.Add("Error at 100923", "");
					GameGeneral.smethod_25(ref ex18);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				if (Enumerable.Any<Warhead>(this.warhead_0) && this.warhead_0[0].method_15())
				{
					float num6 = 5f;
					try
					{
						double? num7;
						double? num8;
						if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
						{
							num7 = new double?(this.vmethod_142().vmethod_3().vmethod_30(null));
							num8 = new double?(this.vmethod_142().vmethod_3().vmethod_28(null));
						}
						else if (this.method_187().method_47())
						{
							num7 = new double?(this.method_187().method_4()[0].imethod_2());
							num8 = new double?(this.method_187().method_4()[0].imethod_0());
						}
						Warhead.WarheadType warheadType_ = this.warhead_0[0].warheadType_0;
						if (warheadType_ != Warhead.WarheadType.EMP_Directed)
						{
							if (warheadType_ == Warhead.WarheadType.EMP_Omni && num7 != null && num8 != null)
							{
								float num9 = base.method_25(num7.Value, num8.Value);
								if ((double)num9 <= (double)num6 * 0.33)
								{
									this.method_223(this.vmethod_30(null), this.vmethod_28(null), this.vmethod_14(false), ref random_0, true);
									return;
								}
								if (num9 <= num6 && !Information.IsNothing(this.vmethod_142().vmethod_3()) && !Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
								{
									this.vmethod_73(this.vmethod_16());
									this.vmethod_143().vmethod_13(true);
								}
							}
						}
						else if (num7 != null && num8 != null)
						{
							if ((double)base.method_25(num7.Value, num8.Value) <= 0.25)
							{
								if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
								{
									if (!Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
									{
										this.vmethod_142().vmethod_3().activeUnit_0.vmethod_91().method_14(0.9f);
									}
									this.vmethod_142().vmethod_15(this.vmethod_142().vmethod_3(), true);
									this.vmethod_142().vmethod_4(null);
									this.method_187().vmethod_9();
								}
								if (this.vmethod_142().method_12().Length == 0)
								{
									this.scenario_0.method_65(this);
								}
								else
								{
									this.vmethod_142().vmethod_4(Enumerable.ElementAtOrDefault<Contact>(Enumerable.OrderBy<Contact, double>(this.vmethod_142().method_12(), new Func<Contact, double>(this.method_279)), 0));
								}
							}
							return;
						}
					}
					catch (Exception ex19)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
				try
				{
					if ((this.vmethod_142().vmethod_3() != null && this.bool_29) || this.bool_30)
					{
						if (base.method_87())
						{
							if (this.method_187().method_46())
							{
								this.method_187().vmethod_9();
							}
							return;
						}
						if (this.method_231() && (this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint))
						{
							if (this.method_187().method_47())
							{
								this.vmethod_29(null, this.method_187().method_4()[0].imethod_0());
								this.vmethod_31(null, this.method_187().method_4()[0].imethod_2());
							}
							else
							{
								this.vmethod_29(null, this.vmethod_142().vmethod_3().vmethod_28(null));
								this.vmethod_31(null, this.vmethod_142().vmethod_3().vmethod_30(null));
							}
							this.method_233();
							return;
						}
						if (this.method_232())
						{
							this.method_234();
							return;
						}
						if (this.warhead_0.Length > 0 && this.warhead_0[0].method_14(this.scenario_0))
						{
							if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && !Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
							{
								ActiveUnit activeUnit_ = this.vmethod_142().vmethod_3().activeUnit_0;
								Scenario scenario_ = this.scenario_0;
								bool bool_ = false;
								List<string> list4 = null;
								this.vmethod_146(activeUnit_, scenario_, bool_, ref list4);
								if (!this.scenario_0.method_46().Contains(this))
								{
									this.method_223(this.vmethod_30(null), this.vmethod_28(null), this.vmethod_14(false), ref random_0, true);
								}
							}
							else if (Information.IsNothing(this.vmethod_142().vmethod_3()))
							{
								if (this.method_187().method_47())
								{
									this.method_223(this.method_187().method_4()[0].imethod_2(), this.method_187().method_4()[0].imethod_0(), this.vmethod_16(), ref random_0, true);
								}
								else
								{
									this.method_223(this.vmethod_30(null), this.vmethod_28(null), this.vmethod_16(), ref random_0, true);
								}
							}
							else if (this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint && this.method_187().method_47() && Enumerable.First<Waypoint>(this.method_187().method_4()).imethod_4() > 9000f)
							{
								this.method_223(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null), Enumerable.First<Waypoint>(this.method_187().method_4()).imethod_4(), ref random_0, true);
							}
							else
							{
								this.method_223(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null), this.vmethod_16(), ref random_0, true);
							}
							return;
						}
						this.vmethod_142().vmethod_32();
						if (this.bool_29)
						{
							if (this.vmethod_142().vmethod_3() != null)
							{
								if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
								{
									if (this.vmethod_142().vmethod_3().method_107())
									{
										this.method_223(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null), this.vmethod_16(), ref random_0, true);
									}
									return;
								}
								if (this.vmethod_142().vmethod_3().activeUnit_0 != null && this.vmethod_142().vmethod_3().activeUnit_0.vmethod_89() != null)
								{
									ActiveUnit_Weaponry activeUnit_Weaponry5 = this.vmethod_142().vmethod_3().activeUnit_0.vmethod_89();
									Weapon weapon5 = this;
									activeUnit_Weaponry5.method_29(float_52, ref weapon5);
								}
								else
								{
									if (this.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint && Debugger.IsAttached)
									{
										Debugger.Break();
									}
									this.scenario_0.method_65(this);
								}
							}
						}
						else if (this.vmethod_142().vmethod_3() != null && this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint)
						{
							if (Enumerable.Any<Warhead>(this.warhead_0) && this.warhead_0[0].method_16(this, this.vmethod_142().vmethod_3().activeUnit_0))
							{
								this.method_223(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null), this.vmethod_16(), ref random_0, true);
							}
							else
							{
								float num10;
								float num11;
								this.method_269(this.vmethod_142().vmethod_3().activeUnit_0, ref this.scenario_0, ref num10, ref num11, ref random_0);
								double num12;
								double num13;
								Class411.smethod_1(this.vmethod_142().vmethod_3().vmethod_28(null), this.vmethod_142().vmethod_3().vmethod_30(null), ref num12, ref num13, (double)(num10 / 1852f), (double)num11);
								try
								{
									foreach (ActiveUnit activeUnit3 in this.scenario_0.method_42())
									{
										if (activeUnit3 != null && activeUnit3.method_30(ref num13, ref num12) < Misc.double_0)
										{
											float float_54 = Math2.smethod_15(num13, num12, activeUnit3.vmethod_30(null), activeUnit3.vmethod_28(null)) * 1852f;
											if (Weapon.smethod_22(activeUnit3, num13, num12, float_54, this.geoPoint_0, this.method_159(), false))
											{
												this.scenario_0.method_59(string.Concat(new string[]
												{
													"Weapon: ",
													this.Name,
													" has impacted ",
													activeUnit3.Name,
													". "
												}), this.Name + " impacted", LoggedMessage.MessageType.WeaponEndgame, 0, this.string_0, null, new Geopoint_Struct(activeUnit3.vmethod_28(null), activeUnit3.vmethod_30(null)));
												this.method_270(activeUnit3, null);
												this.scenario_0.method_65(this);
												return;
											}
										}
									}
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								this.scenario_0.method_59("Weapon: " + this.Name + " impacts surface. ", this.Name + " impacts", LoggedMessage.MessageType.WeaponEndgame, 0, this.string_0, null, new Geopoint_Struct(num12, num13));
								this.method_223(num13, num12, (float)Terrain.smethod_7(num13, num12, false), ref random_0, false);
							}
						}
						else
						{
							if (this.method_169() != Weapon.WeaponGuidanceType.Inertial && (Information.IsNothing(this.vmethod_142().vmethod_3()) || !this.vmethod_142().vmethod_3().method_107()))
							{
								this.vmethod_142().vmethod_15(this.vmethod_142().vmethod_3(), true);
								return;
							}
							if (this.vmethod_142().vmethod_3() == null)
							{
								if (this.method_187().method_47())
								{
									Waypoint waypoint = this.method_187().method_4()[0];
									this.method_223(waypoint.imethod_2(), waypoint.imethod_0(), this.vmethod_16(), ref random_0, true);
								}
								else
								{
									this.method_223(this.vmethod_30(null), this.vmethod_28(null), (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false), ref random_0, true);
								}
							}
							else
							{
								this.method_223(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null), this.vmethod_16(), ref random_0, true);
							}
						}
					}
					if (this.float_50 > 0f)
					{
						this.float_50 -= float_52;
						if (this.float_50 <= 0f)
						{
							this.method_223(this.vmethod_30(null), this.vmethod_28(null), (float)base.method_9(false, false, false), ref random_0, true);
						}
					}
					if (!this.method_204() && num < 0f)
					{
						if (this.vmethod_14(false) >= this.vmethod_143().vmethod_30())
						{
							base.method_124("Weapon: " + this.Name + " has smashed into the ground", this.Name + " has crashed", LoggedMessage.MessageType.WeaponEndgame, 0, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							double double_3 = this.vmethod_30(null);
							double double_4 = this.vmethod_28(null);
							float float_55 = this.vmethod_14(false);
							Random random = GameGeneral.smethod_5();
							this.method_223(double_3, double_4, float_55, ref random, true);
						}
						else
						{
							this.vmethod_15(false, (float)(Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false) + 1));
						}
					}
				}
				catch (Exception ex20)
				{
					ex20.Data.Add("Error at 100925", "");
					GameGeneral.smethod_25(ref ex20);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x001EA464 File Offset: 0x001E8664
		private void method_218(Weapon weapon_1, Weapon weapon_2, Contact contact_0, float float_52, bool bool_34)
		{
			WeaponRec weaponRec = new WeaponRec(ref this.scenario_0, weapon_2.DBID, 1, 1, 1, 1, false, false);
			Contact contact = weapon_1.vmethod_142().vmethod_3();
			checked
			{
				Class316 class2;
				if (!Information.IsNothing(contact))
				{
					foreach (Class316 @class in this.vmethod_7(false).class316_0)
					{
						if (!Information.IsNothing(@class) && @class.class273_0.Length != 0 && @class.int_0 == weapon_2.DBID && @class.contact_0 == contact)
						{
							if (!Information.IsNothing(weapon_1) && !Information.IsNothing(weapon_1.method_177()))
							{
								bool flag = false;
								Class316.Class273[] class273_ = @class.class273_0;
								int j = 0;
								while (j < class273_.Length)
								{
									if (Operators.CompareString(class273_[j].string_0, weapon_1.method_177().string_0, false) != 0)
									{
										j++;
									}
									else
									{
										flag = true;
										IL_E7:
										if (!flag)
										{
											int value = 1;
											if (!Information.IsNothing(weapon_1.warhead_0) && Enumerable.Count<Warhead>(weapon_1.warhead_0) > 1)
											{
												value = Enumerable.Count<Warhead>(weapon_1.warhead_0);
											}
											weapon_1.method_177().vmethod_7(false).method_82(ref @class, new int?(value), 1, new int?(value), false, ref weapon_1.method_177().string_0);
											goto IL_144;
										}
										goto IL_144;
									}
								}
								goto IL_E7;
							}
							IL_144:
							class2 = @class;
							break;
						}
					}
				}
				if (Information.IsNothing(class2))
				{
					string theShooterObjectID = null;
					int num = 1;
					if (!Information.IsNothing(weapon_1) && !Information.IsNothing(weapon_1.method_177()))
					{
						theShooterObjectID = weapon_1.method_177().string_0;
					}
					if (!Information.IsNothing(weapon_1.warhead_0) && Enumerable.Count<Warhead>(weapon_1.warhead_0) > 1)
					{
						num = Enumerable.Count<Warhead>(weapon_1.warhead_0);
					}
					int theQuantity_ToFire = 1;
					int theQuantity_Fired = 1;
					int theQuantity_Assigned = num;
					bool flag2 = false;
					class2 = new Class316(ref weapon_2.DBID, theQuantity_ToFire, theQuantity_Fired, theQuantity_Assigned, ref contact, ref flag2, theShooterObjectID, 1, false, DateTime.MinValue, null);
					Class429.smethod_42(ref this.vmethod_7(false).class316_0, class2);
				}
				ActiveUnit_Weaponry activeUnit_Weaponry = this.vmethod_89();
				int k = 0;
				List<Unit> list = activeUnit_Weaponry.method_43(float_52, ref weaponRec, contact_0, ref k, 0, 0f, ActiveUnit.Throttle.Flank, null, Class568.Enum154.const_0, 0L, ref class2);
				try
				{
					foreach (Unit unit in list)
					{
						if (unit.bool_2 && ((Weapon)unit).method_204() && !((Weapon)unit).vmethod_141())
						{
							((Weapon)unit).method_146(this.vmethod_14(false));
						}
					}
				}
				finally
				{
					List<Unit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (bool_34)
				{
					try
					{
						foreach (Unit unit2 in list)
						{
							ActiveUnit activeUnit = (ActiveUnit)unit2;
							try
							{
								foreach (ActiveUnit activeUnit2 in this.scenario_0.method_42())
								{
									if (!Information.IsNothing(activeUnit2))
									{
										try
										{
											foreach (Contact contact2 in activeUnit2.vmethod_88().method_63().Values)
											{
												if (!Information.IsNothing(contact2.activeUnit_0) && contact2.activeUnit_0 == this)
												{
													activeUnit2.vmethod_88().lazy_1.Value.TryAdd(activeUnit.string_0, contact2);
													activeUnit2.vmethod_88().lazy_2.Value.TryAdd(this.string_0, contact2);
												}
											}
										}
										finally
										{
											IEnumerator<Contact> enumerator4;
											if (enumerator4 != null)
											{
												enumerator4.Dispose();
											}
										}
									}
								}
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							foreach (Side side in this.scenario_0.method_44())
							{
								if (side.method_11().ContainsKey(this.string_0))
								{
									Contact contact3;
									side.method_11().TryGetValue(this.string_0, ref contact3);
									if (!Information.IsNothing(contact3))
									{
										contact3.activeUnit_0 = activeUnit;
										contact3.string_6 = activeUnit.string_0;
										side.method_11().Add(activeUnit.string_0, contact3);
										side.method_11().Remove(this.string_0);
									}
								}
							}
						}
					}
					finally
					{
						List<Unit>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x001EA8EC File Offset: 0x001E8AEC
		public bool method_219()
		{
			if (this.nullable_20 == null)
			{
				this.nullable_20 = new bool?(this.method_167() == Weapon._WeaponType.GuidedWeapon && this.vmethod_3() && this.struct36_0.bool_46);
			}
			return this.nullable_20.Value;
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x001EA940 File Offset: 0x001E8B40
		public bool method_220()
		{
			if (this.nullable_21 == null)
			{
				this.nullable_21 = new bool?(this.method_167() == Weapon._WeaponType.GuidedWeapon && this.vmethod_3() && this.struct36_0.bool_45);
			}
			return this.nullable_21.Value;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x001EA994 File Offset: 0x001E8B94
		public bool method_221()
		{
			bool result;
			try
			{
				if (this.bool_33)
				{
					result = this.bool_33;
				}
				else if (this.method_204())
				{
					result = true;
				}
				else
				{
					float num;
					float num2;
					if (this.method_169() == Weapon.WeaponGuidanceType.Inertial)
					{
						if (!this.method_187().method_47())
						{
							return false;
						}
						num = Math2.smethod_15(this.geoPoint_0.imethod_2(), this.geoPoint_0.imethod_0(), this.method_187().method_4()[Enumerable.Count<Waypoint>(this.method_187().method_4()) - 1].imethod_2(), this.method_187().method_4()[Enumerable.Count<Waypoint>(this.method_187().method_4()) - 1].imethod_0());
						num2 = base.method_23(this.method_187().method_4()[Enumerable.Count<Waypoint>(this.method_187().method_4()) - 1]);
					}
					else
					{
						if (Information.IsNothing(this.vmethod_142()) || Information.IsNothing(this.vmethod_142().vmethod_3()))
						{
							return false;
						}
						num = Math2.smethod_15(this.geoPoint_0.imethod_2(), this.geoPoint_0.imethod_0(), this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null));
						num2 = base.method_36(this.vmethod_142().vmethod_3());
					}
					if (Enumerable.Any<Warhead>(this.warhead_0) && !Information.IsNothing(this.warhead_0[0].method_17(this.scenario_0)) && this.warhead_0[0].method_17(this.scenario_0).vmethod_141() && this.vmethod_14(false) == this.method_145())
					{
						this.bool_33 = true;
					}
					this.bool_33 = ((double)num2 * 1.1 < (double)(num / 2f));
					result = this.bool_33;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100926", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x001EABD0 File Offset: 0x001E8DD0
		public bool method_222()
		{
			bool result;
			try
			{
				if (!this.struct36_0.bool_2)
				{
					result = false;
				}
				else
				{
					List<ActiveUnit> list = this.method_244(this.vmethod_7(false), this.vmethod_142().vmethod_3());
					if (list.Count > 0)
					{
						ActiveUnit_Sensory activeUnit_Sensory = list[0].vmethod_88();
						Contact contact_ = this.vmethod_142().vmethod_3();
						bool? flag = null;
						bool? flag2 = null;
						Unit.Enum123? @enum = null;
						bool? flag3 = null;
						activeUnit_Sensory.method_42(contact_, this, ref flag, ref flag2, ref @enum, ref flag3);
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100927", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x001EACAC File Offset: 0x001E8EAC
		public void method_223(double double_4, double double_5, float float_52, ref Random random_0, bool bool_34)
		{
			try
			{
				if (this.method_167() != Weapon._WeaponType.Sonobuoy)
				{
					float num = this.method_267();
					int num2 = random_0.Next(1, 101);
					this.bool_32 = ((float)num2 < num);
					StringBuilder stringBuilder = new StringBuilder();
					string text;
					if (this.bool_32)
					{
						float num3;
						float num4;
						if (this.method_269(null, ref this.scenario_0, ref num3, ref num4, ref random_0))
						{
							double num5;
							double num6;
							Class411.smethod_1(double_5, double_4, ref num5, ref num6, (double)(num3 / 1852f), (double)num4);
							new Explosion(ref this.scenario_0, num5, num6, num5, num6, this.vmethod_9(), float_52, this.method_167(), this.warhead_0[0].float_0, this.warhead_0[0].float_0, this.warhead_0[0].warheadType_0, this.warhead_0[0].enum126_0, null, null, null, null, null, this.warhead_0[0].short_1, this.warhead_0[0].short_2, (int)this.warhead_0[0].short_0, 0f, 0);
						}
						else
						{
							new Explosion(ref this.scenario_0, double_5, double_4, double_5, double_4, this.vmethod_9(), float_52, this.method_167(), this.warhead_0[0].float_0, this.warhead_0[0].float_0, this.warhead_0[0].warheadType_0, this.warhead_0[0].enum126_0, null, null, null, null, null, this.warhead_0[0].short_1, this.warhead_0[0].short_2, (int)this.warhead_0[0].short_0, 0f, 0);
						}
						if (Enumerable.Count<Warhead>(this.warhead_0) > 0 && this.warhead_0[0].method_13())
						{
							text = "Weapon: " + this.Name + " is dispensing submunitions...";
						}
						else if (Information.IsNothing(this.vmethod_142().vmethod_3()))
						{
							text = string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" impacts surface, ",
								Conversions.ToString(num3),
								"m from intended target point."
							});
						}
						else
						{
							text = string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" has detonated, ",
								Conversions.ToString(num3),
								"m from intended target point."
							});
						}
						this.Name + " detonating";
					}
					else
					{
						text = "Weapon: " + this.Name + " has malfunctioned.";
						this.scenario_0.method_59(text, this.Name + " malfunctioned", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
					if (bool_34)
					{
						this.scenario_0.method_59(text, this.Name + " detonating", LoggedMessage.MessageType.WeaponEndgame, 0, this.string_0, null, new Geopoint_Struct(double_5, double_4));
					}
					this.scenario_0.method_65(this);
					stringBuilder.Append(text);
					Unit unit_ = null;
					if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
					{
						if (this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint)
						{
							unit_ = this.vmethod_142().vmethod_3();
						}
						else
						{
							unit_ = this.vmethod_142().vmethod_3().activeUnit_0;
						}
					}
					this.method_264(unit_, false, false, stringBuilder);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101338", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x001EB060 File Offset: 0x001E9260
		public bool method_224()
		{
			return this.vmethod_142().vmethod_3() == null || this.scenario_0 == null || (this.vmethod_142().vmethod_3().activeUnit_0 != null && !this.vmethod_142().vmethod_3().activeUnit_0.vmethod_127());
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x001EB0BC File Offset: 0x001E92BC
		protected virtual void vmethod_144()
		{
			if (this.method_169() != Weapon.WeaponGuidanceType.Inertial && !this.method_187().method_46())
			{
				this.method_228(this.vmethod_142().vmethod_3() != null && this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint, true, false);
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x001EB10C File Offset: 0x001E930C
		public bool method_225()
		{
			bool result;
			if (this.method_227())
			{
				result = !this.method_187().method_47();
			}
			else
			{
				result = (this.method_226() && this.method_179() == null);
			}
			return result;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x001EB14C File Offset: 0x001E934C
		public bool method_226()
		{
			Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
			return weaponGuidanceType == Weapon.WeaponGuidanceType.DataLink_Plus_Passive || weaponGuidanceType == Weapon.WeaponGuidanceType.Datalink_Plus_Active || weaponGuidanceType - Weapon.WeaponGuidanceType.SemiActive_Plus_Active <= 1;
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x001EB178 File Offset: 0x001E9378
		public bool method_227()
		{
			Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
			switch (weaponGuidanceType)
			{
			case Weapon.WeaponGuidanceType.Passive:
			case Weapon.WeaponGuidanceType.Inertial_Plus_Passive:
			case Weapon.WeaponGuidanceType.Active:
			case Weapon.WeaponGuidanceType.Inertial_Plus_Active:
				goto IL_32;
			case Weapon.WeaponGuidanceType.DataLink_Plus_Passive:
			case Weapon.WeaponGuidanceType.Datalink_Plus_Active:
				break;
			default:
				if (weaponGuidanceType == Weapon.WeaponGuidanceType.Inertial)
				{
					goto IL_32;
				}
				break;
			}
			return false;
			IL_32:
			return true;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x001EB1BC File Offset: 0x001E93BC
		internal void method_228(bool clearPrimaryTarget = false, bool clearDatalink = false, bool clearPlottedCourse = false)
		{
			try
			{
				if (this.float_49 <= 0f || this.method_169() != Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive)
				{
					this.float_48 = 0f;
				}
				if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
				{
					this.float_49 = 0f;
				}
				if (clearPrimaryTarget)
				{
					ActiveUnit_AI activeUnit_AI = this.vmethod_142();
					ActiveUnit activeUnit = this;
					activeUnit_AI.method_33(ref activeUnit);
					if (!this.method_187().method_46())
					{
						this.vmethod_69(ActiveUnit.Enum28.const_0, this.vmethod_9());
					}
				}
				if (clearDatalink)
				{
					this.method_229();
					this.method_271();
					Weapon.WeaponGuidanceType? weaponGuidanceType = this.nullable_16;
					byte? b = (weaponGuidanceType != null) ? new byte?((byte)weaponGuidanceType.GetValueOrDefault()) : null;
					if (((b != null) ? new bool?(b.GetValueOrDefault() == 13) : null).GetValueOrDefault() && !Information.IsNothing(this.vmethod_142().vmethod_3()) && this.method_187().method_4().Length == 0)
					{
						this.method_187().vmethod_24(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null), this.vmethod_142().vmethod_3().vmethod_14(false), Waypoint.WaypointType.TerminalPoint, Waypoint.Enum80.const_1, Waypoint.Enum79.const_0);
					}
				}
				if (clearPlottedCourse && this.method_169() != Weapon.WeaponGuidanceType.Inertial)
				{
					this.method_187().vmethod_9();
				}
				if (!this.method_187().method_46())
				{
					foreach (Sensor sensor in this.sensor_0)
					{
						if (sensor.method_58())
						{
							sensor.method_77();
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100928", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0000DB5D File Offset: 0x0000BD5D
		public void method_229()
		{
			if (this.method_179() != null)
			{
				this.method_180(null);
			}
			this.commDevice_0 = new CommDevice[0];
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0000DB7A File Offset: 0x0000BD7A
		public void method_230()
		{
			if (this.sensor_0.Length > 0)
			{
				Class429.smethod_26(ref this.sensor_0);
				base.method_79(null);
			}
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x001EB3C0 File Offset: 0x001E95C0
		public bool method_231()
		{
			bool result;
			try
			{
				foreach (Warhead warhead in this.warhead_0)
				{
					if (warhead.bool_7)
					{
						return true;
					}
					if (warhead.warheadType_0 == Warhead.WarheadType.Weapon && warhead.method_17(this.scenario_0).bool_7)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100929", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x001EB468 File Offset: 0x001E9668
		private bool method_232()
		{
			bool result;
			try
			{
				foreach (Warhead warhead in this.warhead_0)
				{
					if (warhead.warheadType_0 == Warhead.WarheadType.DepthCharge)
					{
						return true;
					}
					if (warhead.warheadType_0 == Warhead.WarheadType.Weapon && warhead.method_17(this.scenario_0).method_167() == Weapon._WeaponType.DepthCharge)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100930", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x001EB51C File Offset: 0x001E971C
		private void method_233()
		{
			List<Warhead> list = new List<Warhead>();
			try
			{
				foreach (Warhead warhead in this.warhead_0)
				{
					if (!Information.IsNothing(warhead.method_17(this.scenario_0)) && warhead.method_17(this.scenario_0).bool_7)
					{
						Weapon weapon = Weapon.smethod_16(ref this.scenario_0, (int)Math.Round((double)warhead.float_0), null);
						weapon.vmethod_31(null, this.vmethod_30(null));
						weapon.vmethod_29(null, this.vmethod_28(null));
						weapon.vmethod_15(false, -20f);
						weapon.vmethod_10(this.vmethod_9());
						weapon.vmethod_69(ActiveUnit.Enum28.const_0, weapon.vmethod_9());
						weapon.geoPoint_0 = new GeoPoint(this.vmethod_28(null), this.vmethod_30(null));
						weapon.vmethod_8(false, this.vmethod_7(false));
						weapon.vmethod_134(weapon.vmethod_82(), null);
						weapon.vmethod_142().vmethod_4(this.vmethod_142().vmethod_3());
						weapon.method_178(this.method_177());
						weapon.enum127_0 = Weapon.Enum127.const_2;
						if (!this.scenario_0.vmethod_0().ContainsKey(weapon.string_0))
						{
							this.scenario_0.method_68(weapon);
						}
						list.Add(warhead);
						Weapon_AI weapon_AI;
						Contact contact_ = (weapon_AI = weapon.vmethod_142()).vmethod_3();
						this.method_250(ref weapon, ref contact_, this.scenario_0);
						weapon_AI.vmethod_4(contact_);
					}
				}
				try
				{
					foreach (Warhead warhead_ in list)
					{
						Class429.smethod_35(ref this.warhead_0, warhead_);
					}
				}
				finally
				{
					List<Warhead>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.warhead_0.Length == 0 || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine)
				{
					this.scenario_0.method_65(this);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100931", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x001EB7A8 File Offset: 0x001E99A8
		private void method_234()
		{
			List<Warhead> list = new List<Warhead>();
			try
			{
				foreach (Warhead warhead in this.warhead_0)
				{
					if (!Information.IsNothing(warhead.method_17(this.scenario_0)) && warhead.method_17(this.scenario_0).method_167() == Weapon._WeaponType.DepthCharge)
					{
						UnguidedWeapon unguidedWeapon = new UnguidedWeapon(warhead.method_17(this.scenario_0), this.vmethod_142().vmethod_3(), this, this.vmethod_30(null), this.vmethod_28(null), 0L);
						unguidedWeapon.float_9 = (float)warhead.method_17(this.scenario_0).int_7;
						unguidedWeapon.vmethod_10(this.vmethod_142().method_68(this.vmethod_142().vmethod_3()));
						unguidedWeapon.vmethod_8(false, this.vmethod_7(false));
						unguidedWeapon.method_59(this.activeUnit_0);
						if (!Information.IsNothing(this.activeUnit_0))
						{
							unguidedWeapon.string_4 = this.activeUnit_0.string_0;
						}
						if (warhead.method_17(this.scenario_0).method_191())
						{
							if ((float)GameGeneral.smethod_5().Next(1, 101) < unguidedWeapon.float_16)
							{
								unguidedWeapon.method_70(this.scenario_0);
							}
						}
						else
						{
							this.scenario_0.vmethod_20().Add(unguidedWeapon.string_0, unguidedWeapon);
						}
						list.Add(warhead);
					}
				}
				try
				{
					foreach (Warhead warhead_ in list)
					{
						Class429.smethod_35(ref this.warhead_0, warhead_);
					}
				}
				finally
				{
					List<Warhead>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (this.warhead_0.Length == 0 || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine)
				{
					this.scenario_0.method_65(this);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100932", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x001EB9F0 File Offset: 0x001E9BF0
		public void method_235(bool ComputeTerminalPoint = true)
		{
			try
			{
				if (this.method_169() == Weapon.WeaponGuidanceType.SemiActive)
				{
					this.struct36_0.bool_0 = false;
					this.struct36_0.bool_1 = false;
					try
					{
						foreach (ActiveUnit activeUnit in this.scenario_0.vmethod_0().Values)
						{
							foreach (Sensor sensor in activeUnit.vmethod_96())
							{
								if (sensor.list_1.Contains(this))
								{
									sensor.list_1.Remove(this);
									this.method_171(null);
								}
								if (sensor.list_1.Count == 0)
								{
									sensor.method_84(this.vmethod_142().vmethod_3(), false);
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
				}
				if (Enumerable.Count<CommDevice>(this.commDevice_0) > 0 && (this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Surface || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Submarine || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Facility_Fixed || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Facility_Mobile))
				{
					if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
					{
						Class355 contact_ = new Class355(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null));
						this.vmethod_142().vmethod_4(contact_);
					}
					else
					{
						Class355 contact_2 = new Class355(this.vmethod_142().method_2(), this.vmethod_142().method_4());
						this.vmethod_142().vmethod_4(contact_2);
					}
				}
				else
				{
					this.method_230();
					this.method_229();
					this.method_271();
					if (this.method_169() == Weapon.WeaponGuidanceType.Inertial && ComputeTerminalPoint)
					{
						this.method_187().method_64((float)this.vmethod_143().vmethod_40(this.vmethod_14(false), this.vmethod_84(), false), false);
					}
				}
				if (this.struct36_0.bool_57)
				{
					this.struct36_0.bool_57 = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100933", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x001EBC4C File Offset: 0x001E9E4C
		protected bool method_236(float float_52)
		{
			bool result;
			try
			{
				if (!this.method_199() && this.method_167() != Weapon._WeaponType.Torpedo && this.method_187().method_46())
				{
					result = false;
				}
				else
				{
					if (Information.IsNothing(this.method_179()) || this.method_179().method_82())
					{
						this.method_189().method_16(float_52);
					}
					if (!Information.IsNothing(this.method_179()) && !this.method_179().method_82())
					{
						if (this.method_179().bool_6 && ((Ship)this.method_179()).method_152())
						{
							this.method_228(false, true, false);
							result = true;
						}
						else
						{
							result = false;
						}
					}
					else
					{
						if (this.method_169() == Weapon.WeaponGuidanceType.TVM)
						{
							this.method_228(true, true, true);
						}
						else
						{
							this.method_228(false, true, false);
						}
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100934", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x001EBD60 File Offset: 0x001E9F60
		protected bool method_237(float float_52)
		{
			bool result;
			try
			{
				if (this.method_224())
				{
					this.method_251(float_52, 60f);
					result = true;
				}
				else if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && !this.vmethod_142().vmethod_3().method_124(this.scenario_0))
				{
					if (this.vmethod_142().vmethod_3().method_57() > 30f && this.vmethod_142().vmethod_3().method_103() && !this.method_187().method_46())
					{
						if (!this.method_225())
						{
							this.method_228(true, true, false);
							base.method_124("Weapon: " + this.Name + " is not receiving firm target updates from parent unit... Going autonomous.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
						result = true;
					}
					else if (this.bool_7 && this.vmethod_142().vmethod_3().method_57() > 1200f && !this.method_187().method_46() && !this.method_225())
					{
						this.method_228(true, true, false);
						base.method_124("Weapon: " + this.Name + " is not receiving firm target updates from parent unit... Going autonomous.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else
				{
					this.method_251(float_52, 60f);
					result = true;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100935", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x001EBF44 File Offset: 0x001EA144
		private bool method_238(float float_52)
		{
			bool result;
			try
			{
				if (this.method_224())
				{
					if (!base.method_116())
					{
						this.method_184(this.method_183() + float_52);
					}
					result = true;
				}
				else if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
				{
					if (!this.vmethod_142().vmethod_3().method_134())
					{
						if (!Information.IsNothing(this.method_179()))
						{
							base.method_124("Weapon: " + this.Name + " had its target destroyed in the terminal illumination phase, attempt retargeting...", "Weapon issue", LoggedMessage.MessageType.WeaponEndgame, 5, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							this.method_251(float_52, 60f);
						}
						else
						{
							base.method_124("Weapon: " + this.Name + " had its target destroyed...", "Weapon issue", LoggedMessage.MessageType.WeaponEndgame, 5, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							this.method_228(true, true, true);
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100936", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x001EC0B4 File Offset: 0x001EA2B4
		protected bool method_239()
		{
			bool result;
			try
			{
				if (this.method_187().method_46())
				{
					result = false;
				}
				else
				{
					if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
					{
						if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
						{
							this.method_228(true, true, false);
							return true;
						}
					}
					else if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && this.bool_7 && this.vmethod_142().vmethod_3().method_57() > 600f)
					{
						base.method_124("Weapon: " + this.Name + " is not receiving firm target updates from parent unit... Going autonomous.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						return true;
					}
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100937", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x001EC1DC File Offset: 0x001EA3DC
		private bool method_240()
		{
			bool result;
			try
			{
				if (this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Surface || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Submarine || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Facility_Fixed || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Facility_Mobile)
				{
					if (this.method_224())
					{
						Class355 contact_ = new Class355(this.vmethod_142().method_2(), this.vmethod_142().method_4());
						this.vmethod_142().vmethod_4(contact_);
						return true;
					}
					if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
					{
						Class355 contact_2 = new Class355(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null));
						this.vmethod_142().vmethod_4(contact_2);
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101297", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x001EC30C File Offset: 0x001EA50C
		protected bool method_241(float float_52, bool bool_34, bool bool_35, bool bool_36, float float_53)
		{
			bool result;
			if (this.struct36_0.bool_57)
			{
				result = false;
			}
			else
			{
				try
				{
					if (this.method_187().method_46())
					{
						result = false;
					}
					else if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && this.method_231() && (this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint))
					{
						result = false;
					}
					else
					{
						if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && this.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint)
						{
							if ((double)base.method_36(this.vmethod_142().vmethod_3()) < 0.3)
							{
								return false;
							}
							if (this.bool_7 && this.struct36_0.bool_12)
							{
								ActiveUnit_AI activeUnit_AI = this.vmethod_142();
								Weapon weapon = this;
								if (!activeUnit_AI.method_69(ref weapon))
								{
									return false;
								}
							}
							float num;
							if (!Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
							{
								num = Class437.smethod_11(this.vmethod_9(), this.vmethod_142().method_68(this.vmethod_142().vmethod_3().activeUnit_0));
							}
							else
							{
								num = Class437.smethod_11(this.vmethod_9(), this.vmethod_142().method_68(this.vmethod_142().vmethod_3()));
							}
							if (360f - float_52 > num && num > float_52 && !this.bool_29)
							{
								if (!Information.IsNothing(this.method_179()))
								{
									if (base.method_36(this.method_179()) < 2f)
									{
										return false;
									}
									this.method_251(float_53, float_52);
									return true;
								}
								else
								{
									if (!Information.IsNothing(this.method_177()) && base.method_36(this.method_177()) < 2f)
									{
										return false;
									}
									if (this.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint)
									{
										base.method_124("Weapon: " + this.Name + " overshot its target...", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									}
									this.method_228(bool_34, bool_35, bool_36);
									return true;
								}
							}
						}
						result = false;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100938", "");
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

		// Token: 0x06001B47 RID: 6983 RVA: 0x001EC5BC File Offset: 0x001EA7BC
		private bool method_242(float float_52)
		{
			bool result;
			if (Information.IsNothing(this.method_179()) && Information.IsNothing(this.method_177()))
			{
				result = false;
			}
			else if (Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
			{
				result = false;
			}
			else
			{
				try
				{
					if (this.vmethod_142().vmethod_3().activeUnit_0.bool_3 || this.vmethod_142().vmethod_3().activeUnit_0.bool_2)
					{
						if ((double)base.method_36(this.vmethod_142().vmethod_3()) < 0.3)
						{
							return false;
						}
						float num;
						if (!Information.IsNothing(this.method_179()))
						{
							if (base.method_36(this.method_179()) < 2f)
							{
								return false;
							}
							num = Class437.smethod_11(this.vmethod_9(), Math2.smethod_17(this.method_179().vmethod_30(null), this.method_179().vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null)));
						}
						else if (!Information.IsNothing(this.method_177()))
						{
							if (base.method_36(this.method_177()) < 2f)
							{
								return false;
							}
							num = Class437.smethod_11(this.vmethod_9(), Math2.smethod_17(this.method_177().vmethod_30(null), this.method_177().vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null)));
						}
						if (num > float_52 && num < 360f - float_52 && !this.bool_29)
						{
							if (this.method_169() != Weapon.WeaponGuidanceType.SemiActive_Plus_Active)
							{
								if (this.method_169() != Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active)
								{
									if (this.sensor_0.Length != 1)
									{
										if (this.method_169() != Weapon.WeaponGuidanceType.TVM)
										{
											base.method_124("Weapon: " + this.Name + " can no longer see reflected energy from target (engagement geometry issue)... Switching to backup seeker", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
											this.method_228(false, true, true);
											goto IL_2DF;
										}
									}
									base.method_124("Weapon: " + this.Name + " can no longer see reflected energy from target (engagement geometry issue)...", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									this.method_228(true, true, true);
									goto IL_2DF;
								}
							}
							base.method_124("Weapon: " + this.Name + " can no longer see reflected energy from its target (engagement geometry issue)... switching to onboard seeker", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							this.method_228(false, true, true);
							IL_2DF:
							return true;
						}
					}
					result = false;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100939", "");
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

		// Token: 0x06001B48 RID: 6984 RVA: 0x001EC908 File Offset: 0x001EAB08
		protected void method_243(float float_52)
		{
			try
			{
				if (!this.method_236(float_52))
				{
					if (!this.method_237(float_52))
					{
						if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && this.vmethod_142().vmethod_3().method_91())
						{
							if (this.method_241(120f, true, true, true, float_52))
							{
							}
						}
						else
						{
							this.method_241(90f, true, true, true, float_52);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100941", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x001EC9C0 File Offset: 0x001EABC0
		public List<ActiveUnit> method_244(Side side_1, Contact contact_0)
		{
			Weapon.Class397 @class = new Weapon.Class397();
			@class.weapon_0 = this;
			@class.contact_0 = contact_0;
			List<ActiveUnit> list = new List<ActiveUnit>();
			List<ActiveUnit> result;
			try
			{
				if (!Information.IsNothing(this.activeUnit_2) && !Information.IsNothing(@class.contact_0))
				{
					ActiveUnit_Sensory activeUnit_Sensory = this.activeUnit_2.vmethod_88();
					Contact contact_ = @class.contact_0;
					Weapon.Class397 class2 = @class;
					bool? flag = null;
					bool? flag2 = null;
					Unit.Enum123? @enum = null;
					bool? flag3 = null;
					if (activeUnit_Sensory.method_41(contact_, this, ref class2.sensor_0, ref flag, ref flag2, ref @enum, ref flag3))
					{
						list.Add(this.activeUnit_2);
					}
				}
				if (this.struct36_0.bool_2 && !Information.IsNothing(@class.contact_0))
				{
					IEnumerable<ActiveUnit> collection = Enumerable.OrderBy<ActiveUnit, double>(Enumerable.Where<ActiveUnit>(Enumerable.ToList<ActiveUnit>(side_1.activeUnit_0), new Func<ActiveUnit, bool>(@class.method_0)), new Func<ActiveUnit, double>(@class.method_1));
					list.AddRange(collection);
				}
				result = list;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100942", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x001ECAF4 File Offset: 0x001EACF4
		private void method_245(float float_52)
		{
			try
			{
				if (this.method_167() != Weapon._WeaponType.Sonobuoy)
				{
					if (!this.method_236(float_52))
					{
						if (!this.method_237(float_52))
						{
							if (this.method_246())
							{
								this.method_184(this.method_183() + float_52);
							}
							else
							{
								this.method_184(0f);
								this.vmethod_142().vmethod_3().method_58(0f);
								base.method_39(this.vmethod_142().vmethod_3(), this.vmethod_40(), this.vmethod_9());
								if (this.bool_29 || this.bool_30)
								{
									if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
									{
										return;
									}
									if (Information.IsNothing(this.method_179()) || Information.IsNothing(this.method_170()))
									{
										List<ActiveUnit> list = this.method_244(this.vmethod_7(false), this.vmethod_142().vmethod_3());
										if (list.Count > 0)
										{
											try
											{
												foreach (ActiveUnit activeUnit in list)
												{
													if (!Information.IsNothing(activeUnit))
													{
														ActiveUnit_Sensory activeUnit_Sensory = activeUnit.vmethod_88();
														Contact contact_ = this.vmethod_142().vmethod_3();
														bool? flag = null;
														bool? flag2 = null;
														Unit.Enum123? @enum = null;
														bool? hintIsOperating = null;
														activeUnit_Sensory.method_42(contact_, this, ref flag, ref flag2, ref @enum, ref hintIsOperating);
														IL_15A:
														goto IL_264;
													}
												}
												goto IL_15A;
											}
											finally
											{
												List<ActiveUnit>.Enumerator enumerator;
												((IDisposable)enumerator).Dispose();
											}
										}
										Contact_Base.ContactType contactType_ = this.vmethod_142().vmethod_3().contactType_0;
										if (contactType_ > Contact_Base.ContactType.Missile)
										{
											if (contactType_ != Contact_Base.ContactType.Orbital)
											{
												this.method_173(3 * this.method_172());
												this.method_175(3 * this.method_174());
												this.int_14 = (int)Math.Round((double)this.int_14 / 3.0);
												this.int_15 = (int)Math.Round((double)this.int_15 / 3.0);
												this.int_16 = (int)Math.Round((double)this.int_16 / 3.0);
												goto IL_264;
											}
										}
										if (this.sensor_0.Length == 1)
										{
											string text = "Weapon: " + this.Name + " cannot have its target illuminated...";
											string text2 = "Weapon issue";
											LoggedMessage.MessageType messageType_ = LoggedMessage.MessageType.WeaponEndgame;
											byte byte_ = 5;
											bool flag3 = false;
											bool? hintIsOperating = null;
											double double_ = this.vmethod_28(hintIsOperating);
											hintIsOperating = null;
											base.method_124(text, text2, messageType_, byte_, flag3, new Geopoint_Struct(double_, this.vmethod_30(hintIsOperating)));
											this.vmethod_142().vmethod_4(null);
											return;
										}
									}
								}
								IL_264:
								if (!this.method_179().vmethod_88().method_40(this.vmethod_142().vmethod_3()))
								{
									ActiveUnit_Sensory activeUnit_Sensory2 = this.method_179().vmethod_88();
									Contact contact_2 = this.vmethod_142().vmethod_3();
									bool? hintIsOperating = null;
									bool? flag2 = null;
									Unit.Enum123? @enum = null;
									bool? flag = null;
									Sensor sensor;
									if (activeUnit_Sensory2.method_41(contact_2, this, ref sensor, ref hintIsOperating, ref flag2, ref @enum, ref flag))
									{
										ActiveUnit_Sensory activeUnit_Sensory3 = this.method_179().vmethod_88();
										Contact contact_3 = this.vmethod_142().vmethod_3();
										flag = null;
										flag2 = null;
										@enum = null;
										hintIsOperating = null;
										activeUnit_Sensory3.method_42(contact_3, this, ref flag, ref flag2, ref @enum, ref hintIsOperating);
									}
								}
								if (!this.method_242(90f))
								{
									this.method_241(60f, true, true, true, float_52);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100943", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x001ECEA0 File Offset: 0x001EB0A0
		private bool method_246()
		{
			bool result;
			try
			{
				if (Information.IsNothing(this.vmethod_142().vmethod_3()))
				{
					result = true;
				}
				else if (Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
				{
					result = true;
				}
				else
				{
					Sensor sensor = this.method_170();
					bool flag = false;
					if (!Information.IsNothing(sensor) && sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						Sensor sensor2 = sensor;
						Weapon_AI weapon_AI;
						Contact contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
						bool flag2 = sensor2.method_82(ref contact_);
						weapon_AI.vmethod_4(contact_);
						if (!flag2)
						{
							flag = true;
						}
						Sensor sensor3 = sensor;
						ActiveUnit activeUnit = sensor.method_18();
						contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
						float num = sensor.method_18().method_37(this.vmethod_142().vmethod_3().activeUnit_0, 0f);
						List<ActiveUnit> list = null;
						bool bool_ = sensor.method_18().bool_6;
						bool bool_2 = sensor.method_18().bool_6;
						bool? flag3 = null;
						bool? flag4 = null;
						Unit.Enum123? @enum = null;
						bool? flag5 = null;
						int num2 = (int)sensor3.method_118(activeUnit, ref contact_, ref this.scenario_0, num, list, bool_, bool_2, ref flag3, ref flag4, ref @enum, ref flag5);
						weapon_AI.vmethod_4(contact_);
						if (num2 != 1)
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						if (!Information.IsNothing(this.method_177()))
						{
							ActiveUnit_Sensory activeUnit_Sensory = this.method_177().vmethod_88();
							Contact contact_2 = this.vmethod_142().vmethod_3();
							bool? flag5 = null;
							bool? flag4 = null;
							Unit.Enum123? @enum = null;
							bool? flag3 = null;
							if (activeUnit_Sensory.method_42(contact_2, this, ref flag5, ref flag4, ref @enum, ref flag3))
							{
								flag = false;
							}
						}
						if (flag && this.method_222())
						{
							flag = false;
						}
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100944", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x001ED07C File Offset: 0x001EB27C
		private void method_247(float float_52)
		{
			try
			{
				if (!this.method_238(float_52))
				{
					if (this.method_246())
					{
						this.method_184(this.method_183() + float_52);
					}
					else
					{
						this.method_184(0f);
						this.vmethod_142().vmethod_3().method_58(0f);
					}
					if (this.bool_29 || this.bool_30)
					{
						if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
						{
							return;
						}
						if ((double)this.method_183() > 0.5)
						{
							Contact_Base.ContactType contactType_ = this.vmethod_142().vmethod_3().contactType_0;
							if (contactType_ > Contact_Base.ContactType.Missile)
							{
								if (contactType_ != Contact_Base.ContactType.Orbital)
								{
									this.method_173(200 * this.method_172() * (int)Math.Round((double)this.method_183()));
									this.method_175(200 * this.method_174() * (int)Math.Round((double)this.method_183()));
									base.method_124("Weapon: " + this.Name + " cannot have its target illuminated... will impact with severe accuracy reduction.", "Weapon issue", LoggedMessage.MessageType.WeaponEndgame, 5, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									return;
								}
							}
							if (this.sensor_0.Length == 1)
							{
								base.method_124("Weapon: " + this.Name + " cannot have its target illuminated...", "Weapon issue", LoggedMessage.MessageType.WeaponEndgame, 5, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								this.vmethod_142().vmethod_4(null);
								return;
							}
						}
					}
					if (!this.method_242(90f))
					{
						this.method_241(60f, true, true, true, float_52);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100945", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x001ED294 File Offset: 0x001EB494
		private void method_248(float float_52)
		{
			try
			{
				if (!this.method_187().method_47())
				{
					if (!this.method_238(float_52))
					{
						float float_53 = base.method_39(this.vmethod_142().vmethod_3(), this.vmethod_40(), this.vmethod_9());
						if (this.method_246())
						{
							this.method_184(this.method_183() + float_52);
						}
						else
						{
							this.method_184(0f);
							this.vmethod_142().vmethod_3().method_58(0f);
						}
						if (this.bool_29 || this.bool_30)
						{
							if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
							{
								return;
							}
							if ((double)this.method_183() > 0.5)
							{
								Contact_Base.ContactType contactType_ = this.vmethod_142().vmethod_3().contactType_0;
								if (contactType_ > Contact_Base.ContactType.Missile)
								{
									if (contactType_ != Contact_Base.ContactType.Orbital)
									{
										this.method_173(200 * this.method_172());
										this.method_175(200 * this.method_174());
										string text = "Weapon: " + this.Name + " cannot have its target illuminated... will impact with severe accuracy reduction.";
										string text2 = "Weapon goes blind";
										LoggedMessage.MessageType messageType_ = LoggedMessage.MessageType.WeaponEndgame;
										byte byte_ = 5;
										bool flag = false;
										bool? hintIsOperating = null;
										double double_ = this.vmethod_28(hintIsOperating);
										hintIsOperating = null;
										base.method_124(text, text2, messageType_, byte_, flag, new Geopoint_Struct(double_, this.vmethod_30(hintIsOperating)));
										return;
									}
								}
								if (this.sensor_0.Length == 1)
								{
									string text3 = "Weapon: " + this.Name + " cannot have its target illuminated...";
									string text4 = "Weapon goes blind";
									LoggedMessage.MessageType messageType_2 = LoggedMessage.MessageType.WeaponEndgame;
									byte byte_2 = 5;
									bool flag2 = false;
									bool? hintIsOperating = null;
									double double_2 = this.vmethod_28(hintIsOperating);
									hintIsOperating = null;
									base.method_124(text3, text4, messageType_2, byte_2, flag2, new Geopoint_Struct(double_2, this.vmethod_30(hintIsOperating)));
									this.vmethod_142().vmethod_4(null);
									return;
								}
							}
						}
						if (base.method_53(float_53, base.method_36(this.vmethod_142().vmethod_3())) <= (float)Math.Max(10, this.int_12))
						{
							if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
							{
								return;
							}
							bool flag3;
							if (flag3 = Information.IsNothing(this.method_179()))
							{
								if (!flag3)
								{
									goto IL_2BF;
								}
								List<ActiveUnit> list = this.method_244(this.vmethod_7(false), this.vmethod_142().vmethod_3());
								try
								{
									foreach (ActiveUnit activeUnit in list)
									{
										if (!Information.IsNothing(activeUnit))
										{
											ActiveUnit_Sensory activeUnit_Sensory = activeUnit.vmethod_88();
											Contact contact_ = this.vmethod_142().vmethod_3();
											bool? hintIsOperating = null;
											bool? flag4 = null;
											Unit.Enum123? @enum = null;
											bool? flag5 = null;
											activeUnit_Sensory.method_42(contact_, this, ref hintIsOperating, ref flag4, ref @enum, ref flag5);
											IL_28B:
											goto IL_2BF;
										}
									}
									goto IL_28B;
								}
								finally
								{
									List<ActiveUnit>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
							}
							if (!this.method_179().vmethod_88().method_40(this.vmethod_142().vmethod_3()))
							{
								this.method_246();
							}
						}
						IL_2BF:
						if (!this.method_242(90f))
						{
							if (this.method_169() != Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive)
							{
								this.method_241(60f, true, true, true, float_52);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100946", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x001ED5F8 File Offset: 0x001EB7F8
		private void method_249(float float_52)
		{
			try
			{
				if (!this.method_238(float_52))
				{
					float float_53 = base.method_39(this.vmethod_142().vmethod_3(), this.vmethod_40(), this.vmethod_9());
					if (this.bool_29 || this.bool_30)
					{
						if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
						{
							return;
						}
						if ((double)this.method_183() > 0.5)
						{
							Contact_Base.ContactType contactType_ = this.vmethod_142().vmethod_3().contactType_0;
							if (contactType_ > Contact_Base.ContactType.Missile)
							{
								if (contactType_ != Contact_Base.ContactType.Orbital)
								{
									this.method_173(200 * this.method_172());
									this.method_175(200 * this.method_174());
									string text = "Weapon: " + this.Name + " cannot have its target illuminated... will impact with severe accuracy reduction.";
									string text2 = "Weapon issue";
									LoggedMessage.MessageType messageType_ = LoggedMessage.MessageType.WeaponEndgame;
									byte byte_ = 5;
									bool flag = false;
									bool? hintIsOperating = null;
									double double_ = this.vmethod_28(hintIsOperating);
									hintIsOperating = null;
									base.method_124(text, text2, messageType_, byte_, flag, new Geopoint_Struct(double_, this.vmethod_30(hintIsOperating)));
									return;
								}
							}
							if (this.sensor_0.Length == 1)
							{
								string text3 = "Weapon: " + this.Name + " cannot have its target illuminated...";
								string text4 = "Weapon issue";
								LoggedMessage.MessageType messageType_2 = LoggedMessage.MessageType.WeaponEndgame;
								byte byte_2 = 5;
								bool flag2 = false;
								bool? hintIsOperating = null;
								double double_2 = this.vmethod_28(hintIsOperating);
								hintIsOperating = null;
								base.method_124(text3, text4, messageType_2, byte_2, flag2, new Geopoint_Struct(double_2, this.vmethod_30(hintIsOperating)));
								this.vmethod_142().vmethod_4(null);
								return;
							}
						}
					}
					if (base.method_53(float_53, base.method_36(this.vmethod_142().vmethod_3())) <= (float)Math.Max(10, this.int_12))
					{
						if (this.vmethod_142().vmethod_3().method_124(this.scenario_0))
						{
							return;
						}
						bool flag3 = false;
						bool flag4;
						if (flag4 = Information.IsNothing(this.method_179()))
						{
							if (!flag4)
							{
								goto IL_279;
							}
							List<ActiveUnit> list = this.method_244(this.vmethod_7(false), this.vmethod_142().vmethod_3());
							try
							{
								foreach (ActiveUnit activeUnit in list)
								{
									if (!Information.IsNothing(activeUnit))
									{
										ActiveUnit_Sensory activeUnit_Sensory = activeUnit.vmethod_88();
										Contact contact_ = this.vmethod_142().vmethod_3();
										bool? hintIsOperating = null;
										bool? flag5 = null;
										Unit.Enum123? @enum = null;
										bool? flag6 = null;
										activeUnit_Sensory.method_42(contact_, this, ref hintIsOperating, ref flag5, ref @enum, ref flag6);
										IL_245:
										goto IL_279;
									}
								}
								goto IL_245;
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
						if (!this.method_179().vmethod_88().method_40(this.vmethod_142().vmethod_3()))
						{
							flag3 = this.method_246();
						}
						IL_279:
						if (flag3)
						{
							this.method_184(this.method_183() + float_52);
						}
						else
						{
							this.method_184(0f);
							this.vmethod_142().vmethod_3().method_58(0f);
						}
					}
					if (!this.method_242(90f))
					{
						if (this.method_169() != Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive)
						{
							this.method_241(60f, true, true, true, float_52);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100946", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x001ED948 File Offset: 0x001EBB48
		public void method_250(ref Weapon weapon_1, ref Contact contact_0, Scenario scenario_1)
		{
			string text;
			foreach (Class316 @class in weapon_1.vmethod_7(false).class316_0)
			{
				if (@class.contact_0 == contact_0 && @class.int_0 == weapon_1.DBID)
				{
					Class316.Class273[] class273_ = @class.class273_0;
					int j = 0;
					while (j < class273_.Length)
					{
						Class316.Class273 class2 = class273_[j];
						if (Information.IsNothing(weapon_1.method_177()) || Operators.CompareString(class2.string_0, weapon_1.method_177().string_0, false) != 0)
						{
							checked
							{
								j++;
							}
						}
						else
						{
							class2.int_0++;
							class2.int_1++;
							Class429.smethod_32(ref @class.string_2, weapon_1.string_0);
							if (@class.int_2 != 2147483647)
							{
								@class.int_2++;
								return;
							}
							return;
						}
					}
					if (!Information.IsNothing(weapon_1.method_177()))
					{
						weapon_1.vmethod_7(false).method_82(ref @class, new int?(1), 1, new int?(1), false, ref weapon_1.method_177().string_0);
						goto IL_E2;
					}
					Side side = weapon_1.vmethod_7(false);
					int? nullable_ = new int?(1);
					int int_ = 1;
					int? nullable_2 = new int?(1);
					bool bool_ = false;
					text = "12456789";
					side.method_82(ref @class, nullable_, int_, nullable_2, bool_, ref text);
				}
				IL_E2:;
			}
			int? num;
			if (!Information.IsNothing(weapon_1.method_177()))
			{
				Side side2 = weapon_1.vmethod_7(false);
				int? nullable_3 = new int?(1);
				int int_2 = 1;
				int? nullable_4 = new int?(1);
				bool bool_2 = false;
				Class310 class3 = weapon_1.method_177();
				num = new int?(1);
				Class429.smethod_32(ref side2.method_81(scenario_1, ref weapon_1, ref contact_0, nullable_3, int_2, nullable_4, bool_2, ref class3.string_0, ref num, DateTime.MinValue).string_2, weapon_1.string_0);
				return;
			}
			Side side3 = weapon_1.vmethod_7(false);
			int? nullable_5 = new int?(1);
			int int_3 = 1;
			int? nullable_6 = new int?(1);
			bool bool_3 = false;
			text = "123456789";
			num = new int?(1);
			Class429.smethod_32(ref side3.method_81(scenario_1, ref weapon_1, ref contact_0, nullable_5, int_3, nullable_6, bool_3, ref text, ref num, DateTime.MinValue).string_2, weapon_1.string_0);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x001EDB34 File Offset: 0x001EBD34
		private void method_251(float float_52, float float_53)
		{
			try
			{
				if (this.method_167() != Weapon._WeaponType.Sonobuoy)
				{
					Contact contact = null;
					if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
					{
						contact = this.vmethod_142().vmethod_3();
						ActiveUnit_AI activeUnit_AI = this.vmethod_142();
						ActiveUnit activeUnit = this;
						activeUnit_AI.method_33(ref activeUnit);
						if (!this.method_187().method_46())
						{
							this.vmethod_69(ActiveUnit.Enum28.const_0, this.vmethod_9());
						}
					}
					this.method_186(this.method_185() + float_52);
					double num = Math.Round((double)this.method_185(), 1);
					if (num == 0.1 || num == 1.0 || num == 6.0 || num == 11.0 || (num > 11.0 && this.vmethod_142().vmethod_7() == Contact_Base.ContactType.ActivationPoint && num % 15.0 == 0.0))
					{
						List<Contact> list = new List<Contact>();
						List<Contact> list2 = new List<Contact>();
						if (!Information.IsNothing(this.vmethod_142().vmethod_7()) && (this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Air || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Missile || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Submarine || this.vmethod_142().vmethod_7() == Contact_Base.ContactType.Torpedo))
						{
							this.vmethod_7(false).method_84(ref this.scenario_0, ref this.string_0);
						}
						if (!Information.IsNothing(this.method_179()))
						{
							foreach (Contact contact2 in this.method_179().vmethod_86().method_12())
							{
								if (Math.Abs(base.method_33(contact2)) <= float_53 && contact != contact2)
								{
									bool? flag;
									bool? flag2;
									if (contact2.method_130(this.method_179().vmethod_7(false)) == Misc.PostureStance.Hostile)
									{
										flag = new bool?(false);
									}
									else
									{
										Doctrine.Enum52? @enum = this.method_179().doctrine_0.method_63(this.method_179().scenario_0, false, null, false, false);
										byte? b = (@enum != null) ? new byte?((byte)@enum.GetValueOrDefault()) : null;
										flag2 = ((b != null) ? new bool?(b.GetValueOrDefault() == 0) : null);
										flag = ((flag2 != null) ? new bool?(!flag2.GetValueOrDefault()) : flag2);
									}
									bool? flag3 = flag2 = flag;
									if (!((flag2 == null || flag3.GetValueOrDefault()) ? (flag3 & !contact2.method_136()) : new bool?(false)).GetValueOrDefault() && this.method_179().vmethod_86().method_73(contact2) && (Math.Abs(contact2.method_46(this, false)) <= 20f || contact2.method_91() || contact2.method_109()))
									{
										float num2;
										if (contact2.vmethod_40() == 0f)
										{
											num2 = this.vmethod_40();
										}
										else
										{
											num2 = base.method_39(contact2, this.vmethod_40(), this.vmethod_9());
										}
										if (base.method_36(contact2) / (num2 / 3600f) >= 3f)
										{
											try
											{
												if (Information.IsNothing(this.method_179()))
												{
													goto IL_3B4;
												}
												if (Operators.CompareString(this.method_179().vmethod_89().method_26(this, contact2), "OK", false) != 0)
												{
													goto IL_3B4;
												}
												goto IL_3BF;
											}
											catch (Exception ex)
											{
												ex.Data.Add("Error at 200048", ex.Message);
												GameGeneral.smethod_25(ref ex);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												goto IL_3BF;
											}
											IL_38E:
											if (contact2.contactType_0 == this.vmethod_142().vmethod_7())
											{
												list.Add(contact2);
												goto IL_3B4;
											}
											goto IL_3AC;
											IL_3BF:
											if (!Information.IsNothing(this.vmethod_142().vmethod_7()))
											{
												goto IL_38E;
											}
											IL_3AC:
											list2.Add(contact2);
										}
									}
								}
								IL_3B4:;
							}
							int count = list.Count;
							if (count != 0)
							{
								if (count == 1)
								{
									this.method_184(0f);
									this.method_186(0f);
									this.vmethod_142().vmethod_4(list[0]);
									Weapon weapon = this;
									Weapon_AI weapon_AI;
									Contact contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
									this.method_250(ref weapon, ref contact_, this.scenario_0);
									weapon_AI.vmethod_4(contact_);
									base.method_124("Weapon: " + this.Name + " has only one alternative target to be redirected to: " + this.vmethod_142().vmethod_3().Name, "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
								else
								{
									this.method_184(0f);
									this.method_186(0f);
									IEnumerable<Contact> enumerable = Enumerable.ThenBy<Contact, double>(Enumerable.OrderBy<Contact, int>(list, (Weapon._Closure$__.$I354-0 == null) ? (Weapon._Closure$__.$I354-0 = new Func<Contact, int>(Weapon._Closure$__.$I.method_4)) : Weapon._Closure$__.$I354-0), new Func<Contact, double>(this.method_280));
									this.vmethod_142().vmethod_4(Enumerable.ElementAtOrDefault<Contact>(enumerable, 0));
									Weapon weapon = this;
									Weapon_AI weapon_AI;
									Contact contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
									this.method_250(ref weapon, ref contact_, this.scenario_0);
									weapon_AI.vmethod_4(contact_);
									if (!Information.IsNothing(contact) && contact == this.vmethod_142().vmethod_3())
									{
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
									else
									{
										base.method_124("Weapon: " + this.Name + " has been redirected to new target: " + this.vmethod_142().vmethod_3().Name, "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									}
								}
							}
							else
							{
								int count2 = list2.Count;
								if (count2 != 0)
								{
									if (count2 != 1)
									{
										this.method_184(0f);
										this.method_186(0f);
										IEnumerable<Contact> enumerable2 = Enumerable.ThenBy<Contact, double>(Enumerable.OrderBy<Contact, int>(list2, (Weapon._Closure$__.$I354-2 == null) ? (Weapon._Closure$__.$I354-2 = new Func<Contact, int>(Weapon._Closure$__.$I.method_5)) : Weapon._Closure$__.$I354-2), new Func<Contact, double>(this.method_281));
										this.vmethod_142().vmethod_4(Enumerable.ElementAtOrDefault<Contact>(enumerable2, 0));
										Weapon weapon = this;
										Weapon_AI weapon_AI;
										Contact contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
										this.method_250(ref weapon, ref contact_, this.scenario_0);
										weapon_AI.vmethod_4(contact_);
										if (!Information.IsNothing(contact) && contact == this.vmethod_142().vmethod_3())
										{
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
										else
										{
											base.method_124("Weapon: " + this.Name + " has been redirected to new target: " + this.vmethod_142().vmethod_3().Name, "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
										}
									}
									else
									{
										this.method_184(0f);
										this.method_186(0f);
										this.vmethod_142().vmethod_4(list2[0]);
										Weapon weapon = this;
										Weapon_AI weapon_AI;
										Contact contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
										this.method_250(ref weapon, ref contact_, this.scenario_0);
										weapon_AI.vmethod_4(contact_);
										base.method_124("Weapon: " + this.Name + " has only one alternative (secondary) target to be redirected to: " + this.vmethod_142().vmethod_3().Name, "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									}
								}
								else
								{
									if (this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Surface && this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Submarine && this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Facility_Fixed)
									{
										if (this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Facility_Mobile)
										{
											if (this.method_185() < 11f)
											{
												goto IL_924;
											}
											if (this.method_199())
											{
												this.method_228(true, true, true);
												if (this.method_169() != Weapon.WeaponGuidanceType.Active && this.method_169() != Weapon.WeaponGuidanceType.Passive && this.method_169() != Weapon.WeaponGuidanceType.SemiActive_Plus_Active && this.method_169() != Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active && this.sensor_0.Length <= 1)
												{
													base.method_124("Weapon: " + this.Name + " has no eligible alternative target to be redirected to...", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
													goto IL_924;
												}
												base.method_124("Weapon: " + this.Name + " has no eligible alternative target to be redirected to... going autonomous.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
												goto IL_924;
											}
											else
											{
												if (this.vmethod_142().vmethod_7() != Contact_Base.ContactType.ActivationPoint)
												{
													this.method_228(true, true, true);
													return;
												}
												goto IL_924;
											}
										}
									}
									if (this.sensor_0.Length > 0 && this.class394_0.bool_5 && this.method_205())
									{
										this.method_228(true, true, true);
										return;
									}
									this.method_235(true);
								}
								IL_924:
								if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && this.method_187().method_46())
								{
									this.method_187().method_64((float)this.vmethod_143().vmethod_40(this.vmethod_14(false), this.vmethod_84(), false), false);
									if (this.method_187().method_46())
									{
										this.vmethod_69(ActiveUnit.Enum28.const_0, Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), this.method_187().method_4()[0].imethod_2(), this.method_187().method_4()[0].imethod_0()));
									}
								}
							}
						}
						else
						{
							this.method_186(0f);
							this.method_228(true, true, false);
							if (this.method_169() == Weapon.WeaponGuidanceType.Datalink_Plus_Active)
							{
								base.method_124("Weapon: " + this.Name + " has no eligible alternative target to be redirected to... going autonomous.", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
							else
							{
								base.method_124("Weapon: " + this.Name + " lost datalink connection...", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								this.vmethod_142().vmethod_4(null);
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100947", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x001EE648 File Offset: 0x001EC848
		public void method_252(float float_52)
		{
			try
			{
				ActiveUnit activeUnit = this.method_170().method_18();
				if (!Information.IsNothing(this.vmethod_142().vmethod_3()))
				{
					ActiveUnit_AI activeUnit_AI = this.vmethod_142();
					ActiveUnit activeUnit2 = this;
					activeUnit_AI.method_33(ref activeUnit2);
					if (!this.method_187().method_46())
					{
						this.vmethod_69(ActiveUnit.Enum28.const_0, this.vmethod_9());
					}
				}
				this.method_186(this.method_185() + float_52);
				double num = Math.Round((double)this.method_185(), 1);
				if (num == 0.1 || num == 1.0 || num == 6.0 || num == 11.0)
				{
					List<Contact> list = new List<Contact>();
					foreach (Contact contact in activeUnit.vmethod_86().method_12())
					{
						float num2 = Class437.smethod_11(this.vmethod_9(), Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), contact.vmethod_30(null), contact.vmethod_28(null)));
						if (340f <= num2 || num2 <= 20f)
						{
							list.Add(contact);
						}
					}
					int count = list.Count;
					if (count != 0)
					{
						if (count != 1)
						{
							this.method_186(0f);
							this.vmethod_142().vmethod_4(this.vmethod_142().method_49(list));
							Weapon weapon = this;
							Weapon_AI weapon_AI;
							Contact contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
							this.method_250(ref weapon, ref contact_, this.scenario_0);
							weapon_AI.vmethod_4(contact_);
						}
						else
						{
							this.method_186(0f);
							this.vmethod_142().vmethod_4(list[0]);
							Weapon weapon = this;
							Weapon_AI weapon_AI;
							Contact contact_ = (weapon_AI = this.vmethod_142()).vmethod_3();
							this.method_250(ref weapon, ref contact_, this.scenario_0);
							weapon_AI.vmethod_4(contact_);
						}
					}
					else if (this.method_185() >= 11f)
					{
						this.method_186(0f);
						this.vmethod_142().vmethod_4(null);
						base.method_124("Weapon: " + this.Name + " has no eligible alternative target to be redirected to...", "Weapon issue", LoggedMessage.MessageType.WeaponLogic, 10, false, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100948", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x001EE904 File Offset: 0x001ECB04
		public bool method_253(Scenario scenario_1, ref Contact contact_0, ref bool? nullable_22)
		{
			bool flag = false;
			bool result;
			if (contact_0 == null)
			{
				result = false;
			}
			else
			{
				try
				{
					if (contact_0.contactType_0 != Contact_Base.ContactType.Aimpoint)
					{
						if (contact_0.contactType_0 != Contact_Base.ContactType.ActivationPoint)
						{
							Weapon._WeaponType weaponType = this.method_167();
							if (weaponType == Weapon._WeaponType.Decoy_Vehicle)
							{
								return false;
							}
							if (this.method_208() && this.method_167() != Weapon._WeaponType.Decoy_Vehicle)
							{
								Contact_Base.ContactType contactType_ = contact_0.contactType_0;
								if (contactType_ != Contact_Base.ContactType.Missile && contactType_ - Contact_Base.ContactType.Torpedo > 1)
								{
									return false;
								}
								ActiveUnit activeUnit = contact_0.activeUnit_0;
								if (activeUnit == null)
								{
									return false;
								}
								if (activeUnit.bool_2)
								{
									foreach (Sensor sensor_ in activeUnit.vmethod_96())
									{
										if (this.method_260(sensor_))
										{
											if (nullable_22 == null)
											{
												nullable_22 = new bool?(contact_0.method_124(scenario_1));
											}
											return !nullable_22.Value;
										}
									}
								}
								return false;
							}
							else
							{
								if (this.class394_0.bool_5)
								{
									if (contact_0.method_67())
									{
										int num = 0;
										foreach (int key in Enumerable.ToArray<int>(contact_0.method_68().Keys))
										{
											try
											{
												if (contact_0.method_68()[key].float_0 < 30f)
												{
													num++;
												}
											}
											catch (Exception ex)
											{
											}
										}
										if (num > 0)
										{
											if (this.float_29 > 0f)
											{
												if (contact_0.contactType_0 == Contact_Base.ContactType.Air)
												{
													if (nullable_22 == null)
													{
														nullable_22 = new bool?(contact_0.method_124(scenario_1));
													}
													return !nullable_22.Value;
												}
											}
											else if (this.float_31 > 0f && (contact_0.contactType_0 == Contact_Base.ContactType.Facility_Fixed || contact_0.contactType_0 == Contact_Base.ContactType.Facility_Mobile || contact_0.contactType_0 == Contact_Base.ContactType.Surface))
											{
												if (nullable_22 == null)
												{
													nullable_22 = new bool?(contact_0.method_124(scenario_1));
												}
												return !nullable_22.Value;
											}
										}
									}
									else
									{
										if (Information.IsNothing(contact_0.activeUnit_0))
										{
											return false;
										}
										if (contact_0.method_125() >= Contact_Base.IdentificationStatus.KnownClass && Enumerable.Count<Sensor>(Enumerable.Where<Sensor>(contact_0.activeUnit_0.method_78(), (Weapon._Closure$__.$I356-0 == null) ? (Weapon._Closure$__.$I356-0 = new Func<Sensor, bool>(Weapon._Closure$__.$I.method_6)) : Weapon._Closure$__.$I356-0)) > 0)
										{
											if (nullable_22 == null)
											{
												nullable_22 = new bool?(contact_0.method_124(scenario_1));
											}
											return !nullable_22.Value;
										}
										return false;
									}
								}
								switch (contact_0.contactType_0)
								{
								case Contact_Base.ContactType.Air:
									if (contact_0.activeUnit_0.bool_3)
									{
										if (((Aircraft)contact_0.activeUnit_0).method_144())
										{
											if (this.method_199())
											{
												flag = true;
											}
											if ((this.method_195() || this.method_196()) && this.method_167() == Weapon._WeaponType.GuidedWeapon)
											{
												flag = true;
											}
										}
										else if (this.class394_0.bool_2)
										{
											flag = true;
										}
									}
									else if (this.class394_0.bool_2)
									{
										flag = true;
									}
									break;
								case Contact_Base.ContactType.Missile:
									if (contact_0.activeUnit_0 == null)
									{
										return false;
									}
									if (this.class394_0.bool_3)
									{
										flag = true;
									}
									if (this.method_207())
									{
										if (nullable_22 == null)
										{
											nullable_22 = new bool?(contact_0.method_124(scenario_1));
										}
										return !nullable_22.Value;
									}
									if (((Weapon)contact_0.activeUnit_0).method_199())
									{
										if (!Information.IsNothing(((Weapon)contact_0.activeUnit_0).vmethod_142().vmethod_3()) && !Information.IsNothing(((Weapon)contact_0.activeUnit_0).vmethod_142().vmethod_3().activeUnit_0))
										{
											if (!((Weapon)contact_0.activeUnit_0).vmethod_142().vmethod_3().activeUnit_0.bool_6 && (!((Weapon)contact_0.activeUnit_0).vmethod_142().vmethod_3().activeUnit_0.bool_5 || !((Submarine)((Weapon)contact_0.activeUnit_0).vmethod_142().vmethod_3().activeUnit_0).method_161()))
											{
												flag = false;
											}
										}
										else
										{
											flag = false;
										}
									}
									break;
								case Contact_Base.ContactType.Surface:
								{
									if (this.class394_0.bool_0)
									{
										flag = true;
									}
									ActiveUnit activeUnit2 = contact_0.activeUnit_0;
									if (this.class394_0.bool_1 && activeUnit2.bool_5 && activeUnit2.vmethod_14(false) == 0f)
									{
										flag = true;
									}
									break;
								}
								case Contact_Base.ContactType.Submarine:
									if (this.class394_0.bool_1)
									{
										flag = true;
									}
									if (contact_0.vmethod_14(false) == 0f && this.class394_0.bool_0)
									{
										flag = true;
									}
									break;
								case Contact_Base.ContactType.Aimpoint:
									return this.class394_0.bool_8 || this.class394_0.bool_7 || this.class394_0.bool_6;
								case Contact_Base.ContactType.Orbital:
									return this.class394_0.bool_4;
								case Contact_Base.ContactType.Facility_Fixed:
									if (contact_0.activeUnit_0.vmethod_27())
									{
										Weapon._WeaponType weaponType2 = this.method_167();
										if (weaponType2 - Weapon._WeaponType.Torpedo <= 1)
										{
											if (nullable_22 == null)
											{
												nullable_22 = new bool?(contact_0.method_124(scenario_1));
											}
											return !nullable_22.Value;
										}
										return false;
									}
									else
									{
										Facility._FacilityCategory facilityCategory_ = ((Facility)contact_0.activeUnit_0)._FacilityCategory_0;
										if (facilityCategory_ - Facility._FacilityCategory.Runway <= 2)
										{
											return this.class394_0.bool_6;
										}
										if (facilityCategory_ != Facility._FacilityCategory.AirBase)
										{
											return this.class394_0.bool_8 || this.class394_0.bool_7;
										}
										return false;
									}
									break;
								case Contact_Base.ContactType.Facility_Mobile:
									return this.class394_0.bool_13 || this.class394_0.bool_12 || ((this.class394_0.bool_8 || this.class394_0.bool_7) && contact_0.vmethod_40() == 0f);
								case Contact_Base.ContactType.Torpedo:
									return this.class394_0.bool_9;
								case Contact_Base.ContactType.Decoy_Air:
									if (this.class394_0.bool_2 && contact_0.method_68().Count > 0)
									{
										try
										{
											foreach (KeyValuePair<int, EmissionContainer> keyValuePair in contact_0.method_68())
											{
												if (keyValuePair.Value.method_0(keyValuePair.Key, scenario_1).method_72())
												{
													flag = true;
												}
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
									break;
								case Contact_Base.ContactType.ActivationPoint:
									return this.class394_0.bool_0;
								}
								if (flag)
								{
									if (nullable_22 == null)
									{
										nullable_22 = new bool?(contact_0.method_124(scenario_1));
									}
									return !nullable_22.Value;
								}
								return false;
							}
						}
					}
					Weapon._WeaponType weaponType3 = this.method_167();
					if (weaponType3 <= Weapon._WeaponType.TrainingRound)
					{
						if (weaponType3 - Weapon._WeaponType.Decoy_Expendable <= 1 || weaponType3 == Weapon._WeaponType.TrainingRound)
						{
							goto IL_7A2;
						}
					}
					else
					{
						if (weaponType3 - Weapon._WeaponType.SensorPod <= 3)
						{
							goto IL_7A2;
						}
						if (weaponType3 == Weapon._WeaponType.HeliTowedPackage)
						{
							goto IL_7A2;
						}
					}
					if (nullable_22 == null)
					{
						nullable_22 = new bool?(contact_0.method_124(scenario_1));
					}
					return !nullable_22.Value;
					IL_7A2:
					result = false;
				}
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 200276", ex2.Message);
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0000DB99 File Offset: 0x0000BD99
		public bool method_254(float float_52, Contact contact_0)
		{
			return this.method_182(contact_0.contactType_0) >= float_52;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x001EF140 File Offset: 0x001ED340
		public bool method_255(Contact contact_0, bool bool_34)
		{
			bool result;
			try
			{
				if (contact_0.activeUnit_0.bool_6 || contact_0.activeUnit_0.bool_5 || contact_0.activeUnit_0.bool_8 || contact_0.activeUnit_0.bool_7)
				{
					if (this.method_205())
					{
						Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
						if (weaponGuidanceType - Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive <= 1)
						{
							return false;
						}
						return true;
					}
					else
					{
						if (this.struct36_0.bool_14)
						{
							return true;
						}
						if (this.class394_0.bool_5)
						{
							return true;
						}
						if (this.struct36_0.bool_0)
						{
							return true;
						}
						Weapon._WeaponType weaponType_ = this._WeaponType_0;
						if (weaponType_ - Weapon._WeaponType.Rocket <= 2)
						{
							switch (contact_0.contactType_0)
							{
							case Contact_Base.ContactType.Surface:
								return false;
							case Contact_Base.ContactType.Submarine:
							case Contact_Base.ContactType.Aimpoint:
							case Contact_Base.ContactType.Facility_Fixed:
							case Contact_Base.ContactType.Facility_Mobile:
							case Contact_Base.ContactType.Torpedo:
								return true;
							}
							return bool_34;
						}
						if (Enumerable.Count<CommDevice>(this.vmethod_94()) > 0 && this.sensor_0.Length > 0 && (contact_0.method_107() || contact_0.method_134() || contact_0.method_136()))
						{
							return true;
						}
						if (this.method_169() == Weapon.WeaponGuidanceType.Inertial)
						{
							return true;
						}
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100950", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x001EF2D8 File Offset: 0x001ED4D8
		public bool method_256(float float_52, Contact contact_0)
		{
			Contact_Base.ContactType contactType_ = contact_0.contactType_0;
			switch (contactType_)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
				return this.float_30 > float_52;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.UndeterminedNaval:
				return this.float_32 > float_52;
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Mine:
				return this.float_36 > float_52;
			case Contact_Base.ContactType.Aimpoint:
				break;
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
				return this.float_34 > float_52;
			case Contact_Base.ContactType.Torpedo:
				goto IL_84;
			default:
				if (contactType_ != Contact_Base.ContactType.ActivationPoint)
				{
					goto IL_84;
				}
				break;
			}
			if (contact_0.method_15())
			{
				return this.float_34 > float_52;
			}
			return this.float_32 > float_52;
			IL_84:
			return false;
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x001EF378 File Offset: 0x001ED578
		public float method_257(Contact contact_0)
		{
			switch (contact_0.contactType_0)
			{
			case Contact_Base.ContactType.Air:
			case Contact_Base.ContactType.Missile:
			case Contact_Base.ContactType.Orbital:
				return this.float_30;
			case Contact_Base.ContactType.Surface:
			case Contact_Base.ContactType.UndeterminedNaval:
				return this.float_32;
			case Contact_Base.ContactType.Submarine:
			case Contact_Base.ContactType.Mine:
				return this.float_36;
			case Contact_Base.ContactType.Facility_Fixed:
			case Contact_Base.ContactType.Facility_Mobile:
				return this.float_34;
			}
			return 0f;
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x001EF3EC File Offset: 0x001ED5EC
		private bool method_258(Unit theTarget, float elapsedTime, bool CheckDistranceBasedOnClosureSpeed = false)
		{
			bool result;
			try
			{
				if (this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint && this.method_169() != Weapon.WeaponGuidanceType.Inertial)
				{
					result = false;
				}
				else
				{
					if (this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint)
					{
						if (this.method_199())
						{
							return false;
						}
						if ((this.method_196() || this.method_195()) && this.method_169() != Weapon.WeaponGuidanceType.Inertial && this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Surface && this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Submarine && this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Facility_Fixed && this.vmethod_142().vmethod_7() != Contact_Base.ContactType.Facility_Mobile)
						{
							return false;
						}
					}
					if (this.struct36_0.bool_57 && this.vmethod_142().vmethod_3() != null)
					{
						float num = base.method_35(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null));
						if (num > 90f && num < 270f)
						{
							return false;
						}
					}
					if (base.method_36(theTarget) > 10f)
					{
						result = false;
					}
					else
					{
						float num2;
						if (this.bool_7 || this.method_169() != Weapon.WeaponGuidanceType.Inertial)
						{
							num2 = base.method_39(theTarget, base.method_20(), this.vmethod_9());
						}
						float num3 = num2 / 3600f;
						bool flag;
						if (this.method_187().method_47() && ((this.method_169() == Weapon.WeaponGuidanceType.Inertial && !this.bool_7) || (!Information.IsNothing(this.vmethod_142().vmethod_3().contactType_0) && this.method_231() && (this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Submarine || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.ActivationPoint || this.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Aimpoint))))
						{
							Waypoint waypoint = this.method_187().method_4()[Enumerable.Count<Waypoint>(this.method_187().method_4()) - 1];
							float num4 = base.method_23(waypoint);
							float num5 = this.vmethod_40() / 3600f;
							if (num4 <= num5)
							{
								flag = true;
							}
						}
						else
						{
							if (this.bool_7 && (theTarget.bool_5 || (theTarget.method_14() && ((Contact)theTarget).method_136())) && Math.Abs(Math.Abs(this.vmethod_14(false)) - Math.Abs(theTarget.vmethod_14(false))) > 15f)
							{
								return false;
							}
							float num6 = theTarget.method_48(1f);
							double double_;
							double double_2;
							Class411.smethod_1(theTarget.vmethod_28(null), theTarget.vmethod_30(null), ref double_, ref double_2, (double)num6, (double)theTarget.vmethod_9());
							float num7 = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), double_2, double_);
							float num8 = base.method_20() / 3600f;
							if (num7 <= num8)
							{
								flag = true;
							}
							if (!flag)
							{
								float num9 = base.method_48(1f);
								float num10 = Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), double_2, double_);
								double double_3;
								double double_4;
								Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref double_3, ref double_4, (double)num9, (double)num10);
								float num11 = Math2.smethod_15(theTarget.vmethod_30(null), theTarget.vmethod_28(null), double_4, double_3);
								float num12 = Math.Abs(num3 - base.method_20() / 3600f);
								if (num11 <= num12)
								{
									flag = true;
								}
							}
							if (!flag && CheckDistranceBasedOnClosureSpeed && num7 <= num3)
							{
								flag = true;
							}
						}
						if (flag)
						{
							if (this.warhead_0[0].method_13())
							{
								return true;
							}
							if (this.warhead_0.Length > 0 && this.warhead_0[0].method_13())
							{
								return true;
							}
							if (base.method_2() && this.vmethod_142().vmethod_3().method_136())
							{
								return true;
							}
							if (this.vmethod_6())
							{
								if ((int)Math.Round((double)this.vmethod_16()) == (int)Math.Round((double)this.vmethod_14(false)))
								{
									return true;
								}
								if ((double)Math.Abs(this.vmethod_16() - this.vmethod_14(false)) < (double)base.method_36(theTarget) * 1852.0)
								{
									return true;
								}
								if (this.vmethod_14(false) < this.vmethod_16() && (this.vmethod_142().vmethod_3().method_135() || this.vmethod_142().vmethod_3().method_134()))
								{
									return true;
								}
								if ((int)Math.Round((double)this.vmethod_14(false)) < (int)Math.Round((double)this.vmethod_16()))
								{
									if (this.vmethod_22() > 0f)
									{
										this.vmethod_19(this.vmethod_22());
									}
									if (this.vmethod_143().vmethod_16() * 2f >= this.vmethod_16() - this.vmethod_14(false))
									{
										return true;
									}
								}
								else
								{
									if ((int)Math.Round((double)this.vmethod_14(false)) <= (int)Math.Round((double)this.vmethod_16()))
									{
										return true;
									}
									if (this.vmethod_22() < 0f)
									{
										this.vmethod_19(this.vmethod_22());
									}
									if (this.vmethod_143().vmethod_23() * 2f >= this.vmethod_14(false) - this.vmethod_16())
									{
										return true;
									}
								}
							}
							else
							{
								float num13 = this.vmethod_143().vmethod_31();
								if (base.method_2() && this.vmethod_16() < num13 && this.vmethod_14(false) <= num13 + 25f)
								{
									return true;
								}
								if (this.vmethod_16() > this.vmethod_143().vmethod_30())
								{
									return false;
								}
								if (this.vmethod_16() < num13)
								{
									return false;
								}
								return true;
							}
						}
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100951", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x001EFA18 File Offset: 0x001EDC18
		public bool method_259(float float_52)
		{
			bool result;
			try
			{
				if (this.vmethod_142().vmethod_3() == null)
				{
					result = false;
				}
				else
				{
					result = this.method_258(this.vmethod_142().vmethod_3(), float_52, false);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100952", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x001EFA98 File Offset: 0x001EDC98
		public virtual bool vmethod_145(float float_52)
		{
			return this.vmethod_142().vmethod_3() != null && this.vmethod_142().vmethod_3().activeUnit_0 != null && !this.vmethod_142().vmethod_3().method_124(this.scenario_0) && this.method_258(this.vmethod_142().vmethod_3().activeUnit_0, float_52, true);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x001EFB04 File Offset: 0x001EDD04
		private bool method_260(Sensor sensor_3)
		{
			bool result;
			if (sensor_3.method_74())
			{
				result = this.method_210();
			}
			else
			{
				Sensor.Sensor_Type sensor_Type_ = sensor_3.sensor_Type_0;
				switch (sensor_Type_)
				{
				case Sensor.Sensor_Type.Radar:
					return this.method_211();
				case Sensor.Sensor_Type.SemiActive:
					if (!Information.IsNothing(sensor_3.method_18()) && !Information.IsNothing(((Weapon)sensor_3.method_18()).method_170()) && ((Weapon)sensor_3.method_18()).method_170().sensor_Type_0 == Sensor.Sensor_Type.Radar)
					{
						return this.method_211();
					}
					break;
				case Sensor.Sensor_Type.Visual:
					return this.method_213();
				case Sensor.Sensor_Type.Infrared:
					return this.method_212();
				default:
					if (sensor_Type_ - Sensor.Sensor_Type.LaserDesignator <= 2)
					{
						return false;
					}
					break;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x001EFBC0 File Offset: 0x001EDDC0
		private bool method_261(ref Weapon weapon_1, ref Sensor sensor_3, ref ActiveUnit activeUnit_3, ref List<string> list_4)
		{
			bool result;
			try
			{
				if (sensor_3.method_45().GetValueOrDefault())
				{
					result = false;
				}
				else
				{
					StringBuilder stringBuilder = new StringBuilder();
					if (Information.IsNothing(sensor_3))
					{
						result = false;
					}
					else
					{
						float num = this.method_267();
						float num2;
						if (this.method_211() && this.method_143() == GlobalVariables.TechGenerationClass.NotApplicable)
						{
							GlobalVariables.TechGenerationClass techGenerationClass = sensor_3.techGenerationClass_0;
							if (techGenerationClass <= GlobalVariables.TechGenerationClass.Early1960s)
							{
								if (Information.IsNothing(weapon_1.vmethod_142().vmethod_3()))
								{
									return false;
								}
								if (weapon_1.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Surface && !Information.IsNothing(weapon_1.vmethod_142().vmethod_3().activeUnit_0))
								{
									switch (weapon_1.vmethod_142().vmethod_3().activeUnit_0.vmethod_121())
									{
									case GlobalVariables.TargetVisualSizeClass.Stealthy:
									case GlobalVariables.TargetVisualSizeClass.VSmall:
										num2 = 100f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Small:
										num2 = 98f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Medium:
										num2 = 80f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Large:
										num2 = 60f;
										break;
									case GlobalVariables.TargetVisualSizeClass.VLarge:
										num2 = 40f;
										break;
									}
								}
								else
								{
									num2 = 35f;
								}
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1960s)
							{
								if (weapon_1.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Surface && !Information.IsNothing(weapon_1.vmethod_142().vmethod_3().activeUnit_0))
								{
									switch (weapon_1.vmethod_142().vmethod_3().activeUnit_0.vmethod_121())
									{
									case GlobalVariables.TargetVisualSizeClass.Stealthy:
									case GlobalVariables.TargetVisualSizeClass.VSmall:
										num2 = 70f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Small:
										num2 = 50f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Medium:
										num2 = 40f;
										break;
									case GlobalVariables.TargetVisualSizeClass.Large:
										num2 = 30f;
										break;
									default:
										num2 = num;
										break;
									}
								}
								else
								{
									num2 = 35f;
								}
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Early1970s)
							{
								if (Information.IsNothing(weapon_1.vmethod_142().vmethod_3()))
								{
									return false;
								}
								if (weapon_1.vmethod_142().vmethod_3().contactType_0 == Contact_Base.ContactType.Surface && !Information.IsNothing(weapon_1.vmethod_142().vmethod_3().activeUnit_0))
								{
									GlobalVariables.TargetVisualSizeClass targetVisualSizeClass = weapon_1.vmethod_142().vmethod_3().activeUnit_0.vmethod_121();
									if (targetVisualSizeClass > GlobalVariables.TargetVisualSizeClass.VSmall)
									{
										if (targetVisualSizeClass != GlobalVariables.TargetVisualSizeClass.Small)
										{
											num2 = num;
										}
										else
										{
											num2 = 30f;
										}
									}
									else
									{
										num2 = 50f;
									}
								}
								else
								{
									num2 = 35f;
								}
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1970s)
							{
								num2 = num;
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1980s)
							{
								num2 = num;
							}
							else if (techGenerationClass <= GlobalVariables.TechGenerationClass.Late1990s)
							{
								num2 = num - 5f;
							}
							else
							{
								num2 = num - 10f;
							}
						}
						else if (this.method_143() == GlobalVariables.TechGenerationClass.NotApplicable)
						{
							num2 = num;
						}
						else if (this.method_212())
						{
							int num3 = this.method_143() - sensor_3.techGenerationClass_0;
							if (num3 < 0)
							{
								num2 = num - 10f;
							}
							else if (num3 == 0)
							{
								num2 = num;
							}
							else if (num3 > 0)
							{
								num2 = num + 5f;
							}
						}
						else
						{
							int num4 = this.method_143() - sensor_3.techGenerationClass_0;
							if (num4 < -3)
							{
								num2 = num - 15f;
							}
							else if (num4 == -3)
							{
								num2 = num - 10f;
							}
							else if (num4 == -2)
							{
								num2 = num - 5f;
							}
							else if (num4 == -1)
							{
								num2 = num;
							}
							else if (num4 == 0)
							{
								num2 = num;
							}
							else if (num4 == 1)
							{
								num2 = num;
							}
							else if (num4 == 2)
							{
								num2 = num + 5f;
							}
							else if (num4 == 3)
							{
								num2 = num + 10f;
							}
							else if (num4 > 3)
							{
								num2 = num + 15f;
							}
						}
						if (num2 < 0f)
						{
							num2 = 0f;
						}
						stringBuilder.Append(string.Concat(new string[]
						{
							"Decoy (",
							this.string_2,
							"; Tech: ",
							Misc.smethod_50(this.method_143()),
							") from ",
							activeUnit_3.Name,
							" is attempting to seduce sensor: ",
							Misc.smethod_9(sensor_3.Name),
							" (Tech: ",
							Misc.smethod_50(sensor_3.techGenerationClass_0),
							")(Guiding weapon: ",
							weapon_1.Name,
							"). Final probability: ",
							Conversions.ToString(Math.Round((double)num2, 2)),
							"%. "
						}));
						if (weapon_1.struct36_0.bool_32)
						{
							stringBuilder.Append("FAIL: The weapon uses imaging seeker.");
							weapon_1.scenario_0.method_59(stringBuilder.ToString(), Misc.smethod_9(this.Name) + " failed to spoof " + Misc.smethod_9(sensor_3.Name), LoggedMessage.MessageType.WeaponEndgame, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							if (list_4 != null)
							{
								list_4.Add(stringBuilder.ToString());
							}
							result = false;
						}
						else
						{
							int num5 = GameGeneral.smethod_5().Next(1, 101);
							string messageSummary;
							bool flag;
							if ((float)num5 <= num2)
							{
								stringBuilder.Append("Result: " + Conversions.ToString(num5) + " - SUCCESS");
								messageSummary = Misc.smethod_9(this.Name) + " spoofed " + Misc.smethod_9(sensor_3.Name);
								sensor_3.method_44(new bool?(true));
								flag = true;
							}
							else
							{
								stringBuilder.Append("Result: " + Conversions.ToString(num5) + " - FAILURE");
								messageSummary = Misc.smethod_9(this.Name) + " failed to spoof " + Misc.smethod_9(sensor_3.Name);
								sensor_3.method_44(new bool?(false));
								flag = false;
							}
							weapon_1.scenario_0.method_59(stringBuilder.ToString(), messageSummary, LoggedMessage.MessageType.WeaponEndgame, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							if (list_4 != null)
							{
								list_4.Add(stringBuilder.ToString());
							}
							result = flag;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100953", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x001F0230 File Offset: 0x001EE430
		public bool method_262(ref Weapon weapon_1, ref ActiveUnit activeUnit_3, ref List<string> list_4)
		{
			bool result;
			try
			{
				if (weapon_1.method_169() == Weapon.WeaponGuidanceType.TVM)
				{
					Sensor sensor = weapon_1.method_170();
					if (sensor != null)
					{
						result = this.method_261(ref weapon_1, ref sensor, ref activeUnit_3, ref list_4);
					}
					else
					{
						result = false;
					}
				}
				else
				{
					bool flag;
					foreach (Sensor sensor2 in weapon_1.sensor_0)
					{
						if (sensor2 != null && this.method_260(sensor2) && this.method_261(ref weapon_1, ref sensor2, ref activeUnit_3, ref list_4))
						{
							flag = true;
						}
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100954", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x001F02F4 File Offset: 0x001EE4F4
		private double method_263(double double_4)
		{
			if (double_4 > 180.0)
			{
				double_4 = -360.0 + double_4;
			}
			double_4 = Math.Abs(double_4);
			if (double_4 > 90.0)
			{
				double_4 = 180.0 - double_4;
			}
			double num = 0.5;
			return 1.0 - double_4 * num / 90.0;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x001F035C File Offset: 0x001EE55C
		public virtual bool vmethod_146(ActiveUnit activeUnit_3, Scenario scenario_1, bool bool_34, ref List<string> list_4)
		{
			bool result;
			if (Information.IsNothing(this))
			{
				result = false;
			}
			else if (this.scenario_0.method_46().Contains(this))
			{
				result = false;
			}
			else
			{
				Random random = GameGeneral.smethod_5();
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					bool flag = false;
					bool flag2 = false;
					float num;
					if (activeUnit_3.bool_3)
					{
						if (((Aircraft)activeUnit_3).method_144())
						{
							if (!this.method_199())
							{
								bool result2 = this.method_268(activeUnit_3, ref scenario_1, ref random);
								this.scenario_0.method_65(this);
								return result2;
							}
							num = (float)this.int_13;
						}
						else
						{
							num = (float)this.int_13;
						}
					}
					else if (activeUnit_3.bool_2)
					{
						if (activeUnit_3.method_2())
						{
							num = (float)this.int_13;
						}
						else if (activeUnit_3.method_88())
						{
							num = (float)this.int_13;
						}
						else if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					else if (activeUnit_3.method_1())
					{
						num = (float)this.int_13;
					}
					else
					{
						if (activeUnit_3.bool_6)
						{
							bool result3 = this.method_268(activeUnit_3, ref scenario_1, ref random);
							this.scenario_0.method_65(this);
							return result3;
						}
						if (activeUnit_3.bool_5)
						{
							if (activeUnit_3.vmethod_14(false) == 0f)
							{
								if (!this.bool_7)
								{
									bool result4 = this.method_268(activeUnit_3, ref scenario_1, ref random);
									this.scenario_0.method_65(this);
									return result4;
								}
								num = (float)Math.Max(this.int_16, this.int_14);
							}
							else
							{
								num = (float)this.int_16;
							}
						}
						else if (activeUnit_3.bool_8)
						{
							bool result5 = this.method_268(activeUnit_3, ref scenario_1, ref random);
							this.scenario_0.method_65(this);
							return result5;
						}
					}
					string text;
					if (string.IsNullOrEmpty(this.Name))
					{
						text = this.string_2;
					}
					else
					{
						text = this.Name;
					}
					if ((float)random.Next(1, 101) < num && this.method_191())
					{
						this.method_223(this.vmethod_142().vmethod_3().vmethod_30(null), this.vmethod_142().vmethod_3().vmethod_28(null), this.vmethod_16(), ref random, true);
						result = false;
					}
					else
					{
						Weapon._WeaponType weaponType_ = this._WeaponType_0;
						if (weaponType_ == Weapon._WeaponType.Gun)
						{
							stringBuilder.Append(string.Concat(new string[]
							{
								"Gun (",
								text,
								") is attacking ",
								activeUnit_3.Name,
								" with a base PH of ",
								Conversions.ToString(Math.Round((double)num, 2)),
								"%. "
							}));
						}
						else
						{
							string text2;
							if (activeUnit_3.bool_3 && Operators.CompareString(activeUnit_3.Name, activeUnit_3.string_2, false) != 0)
							{
								text2 = activeUnit_3.Name + " (" + activeUnit_3.string_2 + ")";
							}
							else
							{
								text2 = activeUnit_3.Name;
							}
							stringBuilder.Append(string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" is attacking ",
								text2,
								" with a base PH of ",
								Conversions.ToString(Math.Round((double)num, 2)),
								"%. "
							}));
						}
						float num7;
						if (activeUnit_3.bool_3)
						{
							if (activeUnit_3.bool_24 | activeUnit_3.method_82())
							{
								return false;
							}
							if (base.method_2())
							{
								float num2 = base.method_23(this.geoPoint_0) / this.float_29;
								Engine.Enum112 enum112_ = this.vmethod_49()[0].enum112_0;
								float num3;
								if (enum112_ != Engine.Enum112.const_12)
								{
									if (enum112_ != Engine.Enum112.const_14)
									{
										num3 = 0.75f;
										goto IL_382;
									}
								}
								num3 = 0.5f;
								IL_382:
								if (num2 > num3)
								{
									num = num * num3 + num * (1f - num3) * (1f - (num2 - num3) / (1f - num3));
									if (float.IsNaN(num))
									{
										num = 0f;
									}
									stringBuilder.Append("PH adjusted for distance: " + Conversions.ToString((int)Math.Round((double)num)) + "%. ");
								}
							}
							if (this.int_20 > 0)
							{
								float num4;
								if (activeUnit_3.vmethod_40() > (float)this.int_20)
								{
									num4 = 50f;
								}
								else if ((double)activeUnit_3.vmethod_40() > (double)this.int_20 * 0.8)
								{
									num4 = 25f;
								}
								else if ((double)activeUnit_3.vmethod_40() > (double)this.int_20 * 0.7)
								{
									num4 = 15f;
								}
								else if ((double)activeUnit_3.vmethod_40() > (double)this.int_20 * 0.6)
								{
									num4 = 10f;
								}
								else if ((double)activeUnit_3.vmethod_40() > (double)this.int_20 * 0.5)
								{
									num4 = 5f;
								}
								if (num4 != 0f)
								{
									num = (float)((int)Math.Round((double)(num - num4)));
									if (num < 0f)
									{
										num = 0f;
									}
									stringBuilder.Append("PH adjusted for actual target speed (").Append((int)Math.Round((double)activeUnit_3.vmethod_40())).Append(" kts): ").Append(Math.Round((double)num, 1)).Append("%. ");
								}
							}
							if (((Aircraft)activeUnit_3).int_6 > 0 && ((Aircraft)activeUnit_3).float_25 > 0f)
							{
								if (!Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0) && this.vmethod_142().vmethod_3().activeUnit_0.vmethod_7(false).method_66(this))
								{
									float num5 = ((Aircraft)activeUnit_3).method_159().method_22(stringBuilder);
									float num6 = base.method_46(activeUnit_3, false);
									if (num6 < 345f && num6 > 15f)
									{
										if ((num6 >= 15f && num6 <= 60f) || (num6 <= 345f && num6 >= 300f))
										{
											num5 = (float)((double)num5 * 0.7);
											stringBuilder.Append("Agility adjusted for forward-oblique impact effect: " + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
										}
										else if ((num6 >= 60f && num6 <= 110f) || (num6 <= 300f && num6 >= 250f))
										{
											num5 = num5;
											stringBuilder.Append("High-deflection impact (no effect on agility). ");
										}
										else if ((num6 >= 110f && num6 <= 165f) || (num6 <= 250f && num6 >= 195f))
										{
											num5 = (float)((double)num5 * 0.85);
											stringBuilder.Append("Agility adjusted for rear-oblique impact effect: " + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
										}
										else
										{
											num5 = (float)((double)num5 * 0.5);
											stringBuilder.Append("Agility adjusted for tail-on impact effect: " + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
										}
									}
									else
									{
										num5 = (float)((double)num5 * 0.6);
										stringBuilder.Append("Agility adjusted for head-on impact effect: " + Conversions.ToString(Math.Round((double)num5, 1)) + ". ");
									}
									num5 = (float)Math.Round((double)num5, 1);
									stringBuilder.Append("Final agility modifier: -" + Conversions.ToString((int)Math.Round((double)(num5 * 10f))) + "%. ");
									num7 = num - num5 * 10f;
								}
								else
								{
									num7 = num;
								}
							}
							else
							{
								num7 = num;
							}
						}
						else
						{
							num7 = num;
						}
						if (activeUnit_3.vmethod_14(false) > 0f && (activeUnit_3.method_2() || activeUnit_3.bool_3) && !this.struct36_0.bool_9)
						{
							float num8 = this.method_272(activeUnit_3.vmethod_14(false));
							if (num8 > 0f)
							{
								num7 -= num8;
								stringBuilder.Append("Sea-skimmer modifier: -" + Conversions.ToString(num8) + "%. ");
							}
						}
						if (activeUnit_3.method_2())
						{
							float num9 = base.method_46(activeUnit_3, false);
							XSection xsection = Sensor.smethod_3(activeUnit_3, XSection.Enum132.const_10);
							XSection xsection2 = Sensor.smethod_3(activeUnit_3, XSection.Enum132.const_7);
							float float_;
							float float_2;
							if (num9 < 315f && num9 > 45f)
							{
								if ((num9 >= 45f && num9 <= 135f) || (num9 >= 225f && num9 <= 315f))
								{
									float_ = xsection.method_10(activeUnit_3);
									float_2 = xsection2.method_10(activeUnit_3);
								}
								else if (num9 >= 135f && num9 <= 225f)
								{
									float_ = xsection.method_11(activeUnit_3);
									float_2 = xsection2.method_11(activeUnit_3);
								}
							}
							else
							{
								float_ = xsection.method_9(activeUnit_3);
								float_2 = xsection2.method_9(activeUnit_3);
							}
							float num10 = base.method_46(activeUnit_3, false);
							num7 = (float)((double)num7 * this.method_263((double)num10));
							stringBuilder.Append(string.Concat(new string[]
							{
								"Intercept angle is ",
								Conversions.ToString((int)Math.Round((double)num10)),
								" deg - hit probability adjusted to ",
								Conversions.ToString((int)Math.Round((double)num7)),
								"%."
							}));
							num7 = this.method_273((int)Math.Round((double)num7), activeUnit_3.vmethod_40(), float_, float_2, stringBuilder);
							if (bool_34 || base.method_23(this.geoPoint_0) <= 2f)
							{
								Weapon weapon = (Weapon)activeUnit_3;
								if (!Information.IsNothing(weapon.vmethod_142().vmethod_3()) && weapon.method_36(weapon.vmethod_142().vmethod_3()) < 2f)
								{
									if (weapon.struct36_0.bool_54)
									{
										stringBuilder.Append("Target is missile with pop-up terminal manouver - hit probability reduced by 25%. ");
										num7 = (float)((double)num7 * 0.75);
									}
									else if (weapon.struct36_0.bool_55)
									{
										stringBuilder.Append("Target is missile with zig-zag terminal manouver - hit probability reduced by 33%. ");
										num7 = (float)((double)num7 * 0.66);
									}
									else if (weapon.struct36_0.bool_56)
									{
										stringBuilder.Append("Target is missile with random terminal manouver - hit probability reduced by 50%. ");
										num7 = (float)((double)num7 * 0.5);
									}
								}
							}
						}
						if (activeUnit_3.bool_7)
						{
							stringBuilder.Append("Target is torpedo - hit probability halved. ");
							num7 = (float)((double)num7 * 0.5);
						}
						if (num7 < 0f)
						{
							num7 = 1f;
						}
						stringBuilder.Append("Final PH: " + Conversions.ToString((int)Math.Round((double)num7)) + "%. ");
						int num11 = random.Next(1, 101);
						if ((float)num11 <= num7)
						{
							stringBuilder.Append("Result: " + Conversions.ToString(num11) + " - HIT");
							flag = true;
						}
						else
						{
							stringBuilder.Append("Result: " + Conversions.ToString(num11));
							if (this.struct36_0.bool_57)
							{
								float num12 = num7 / 4f;
								if ((float)random.Next(1, 101) < num12)
								{
									stringBuilder.Append(" - MISS - NO REATTACK (DUD)");
								}
								else
								{
									stringBuilder.Append(" - MISS - REATTACK");
									this.method_275(activeUnit_3);
									flag2 = true;
								}
							}
							else
							{
								stringBuilder.Append(" - MISS");
								if (this.warhead_0.Length > 0 && activeUnit_3.bool_8 && this.warhead_0[0].method_11())
								{
									float num13 = 0f;
									num13 = (float)random.Next(0, 359);
									float num14 = (float)random.Next(1, 50);
									stringBuilder.Append(" (Near miss: " + Conversions.ToString(num14) + "m)");
									ActiveUnit_Damage activeUnit_Damage = activeUnit_3.vmethod_91();
									GeoPoint geoPoint = this.geoPoint_0;
									float float_3 = num14;
									float float_4 = num13;
									ActiveUnit activeUnit = null;
									double? nullable_ = null;
									double? nullable_2 = null;
									float? nullable_3 = null;
									string text3 = "";
									activeUnit_Damage.vmethod_10(this, geoPoint, float_3, float_4, activeUnit, nullable_, nullable_2, nullable_3, ref text3);
								}
							}
						}
						string messageSummary;
						if (flag)
						{
							messageSummary = Misc.smethod_9(this.Name) + " impacts on " + activeUnit_3.Name;
						}
						else
						{
							messageSummary = Misc.smethod_9(this.Name) + " missed " + activeUnit_3.Name;
						}
						activeUnit_3.scenario_0.method_59(stringBuilder.ToString(), messageSummary, LoggedMessage.MessageType.WeaponEndgame, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						if (list_4 != null)
						{
							list_4.Add(stringBuilder.ToString());
						}
						if (flag)
						{
							this.method_270(activeUnit_3, stringBuilder);
						}
						else
						{
							this.method_264(activeUnit_3, false, false, stringBuilder);
						}
						if (flag | !flag2)
						{
							this.scenario_0.method_65(this);
						}
						if (flag)
						{
							result = true;
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100955", "");
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

		// Token: 0x06001B5F RID: 7007 RVA: 0x001F0FE0 File Offset: 0x001EF1E0
		public void method_264(Unit unit_0, bool bool_34, bool bool_35, StringBuilder stringBuilder_0)
		{
			try
			{
				foreach (IEventExporter eventExporter in this.scenario_0.method_6())
				{
					if (eventExporter.imethod_8() && eventExporter.imethod_16())
					{
						Dictionary<string, IEventExporter.EventNotificationParameter> dictionary = new Dictionary<string, IEventExporter.EventNotificationParameter>();
						if (this.method_177().scenario_0.MonteCarloIteration > 0)
						{
							dictionary.Add("Scenario", new IEventExporter.EventNotificationParameter(this.method_177().scenario_0.method_0(), typeof(string), 500));
							dictionary.Add("MC_Run", new IEventExporter.EventNotificationParameter(this.method_177().scenario_0.MonteCarloIteration, typeof(int), 0));
						}
						dictionary.Add("TimelineID", new IEventExporter.EventNotificationParameter(this.method_177().scenario_0.TimelineID, typeof(string), 40));
						if (eventExporter.imethod_10())
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.scenario_0.method_31().Subtract(this.scenario_0.ZeroHour).ToString("c"), typeof(TimeSpan), 0));
						}
						else
						{
							dictionary.Add("Time", new IEventExporter.EventNotificationParameter(this.scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + this.scenario_0.method_31().Millisecond.ToString("D3"), typeof(DateTime), 0));
						}
						dictionary.Add("WeaponID", new IEventExporter.EventNotificationParameter(this.string_0, typeof(string), 40));
						dictionary.Add("WeaponName", new IEventExporter.EventNotificationParameter(this.Name, typeof(string), 500));
						dictionary.Add("WeaponSide", new IEventExporter.EventNotificationParameter(this.vmethod_7(false).method_51(), typeof(string), 500));
						if (!Information.IsNothing(this.method_177()))
						{
							dictionary.Add("ParentFiringUnitID", new IEventExporter.EventNotificationParameter(this.method_177().string_0, typeof(string), 40));
							dictionary.Add("ParentFiringUnitName", new IEventExporter.EventNotificationParameter(this.method_177().Name, typeof(string), 500));
						}
						else
						{
							dictionary.Add("ParentFiringUnitID", new IEventExporter.EventNotificationParameter("-", typeof(string), 40));
							dictionary.Add("ParentFiringUnitName", new IEventExporter.EventNotificationParameter("-", typeof(string), 500));
						}
						if (!Information.IsNothing(unit_0))
						{
							dictionary.Add("TargetID", new IEventExporter.EventNotificationParameter(unit_0.string_0, typeof(string), 40));
							dictionary.Add("TargetName", new IEventExporter.EventNotificationParameter(unit_0.Name, typeof(string), 500));
							if (Information.IsNothing(unit_0.vmethod_7(false)))
							{
								dictionary.Add("TargetSide", new IEventExporter.EventNotificationParameter("-", typeof(string), 500));
							}
							else
							{
								dictionary.Add("TargetSide", new IEventExporter.EventNotificationParameter(unit_0.vmethod_7(false).method_51(), typeof(string), 500));
							}
							dictionary.Add("TargetLongitude", new IEventExporter.EventNotificationParameter(unit_0.vmethod_28(null), typeof(double), 0));
							dictionary.Add("TargetLatitude", new IEventExporter.EventNotificationParameter(unit_0.vmethod_30(null), typeof(double), 0));
							dictionary.Add("TargetAltitude_ASL_m", new IEventExporter.EventNotificationParameter(unit_0.vmethod_14(false), typeof(float), 0));
							dictionary.Add("TargetAltitude_AGL_m", new IEventExporter.EventNotificationParameter(unit_0.vmethod_13(), typeof(float), 0));
						}
						else
						{
							dictionary.Add("TargetID", new IEventExporter.EventNotificationParameter("-", typeof(string), 0));
							dictionary.Add("TargetName", new IEventExporter.EventNotificationParameter("-", typeof(string), 0));
							dictionary.Add("TargetSide", new IEventExporter.EventNotificationParameter("-", typeof(string), 0));
							dictionary.Add("TargetLongitude", new IEventExporter.EventNotificationParameter("-", typeof(double), 0));
							dictionary.Add("TargetLatitude", new IEventExporter.EventNotificationParameter("-", typeof(double), 0));
							dictionary.Add("TargetAltitude_ASL_m", new IEventExporter.EventNotificationParameter("-", typeof(float), 0));
							dictionary.Add("TargetAltitude_AGL_m", new IEventExporter.EventNotificationParameter("-", typeof(float), 0));
						}
						dictionary.Add("DistanceFromFiringUnit_Horiz", new IEventExporter.EventNotificationParameter(Conversions.ToString(Interaction.IIf(!Information.IsNothing(this.method_177()), base.method_36(this.method_177()), "")), typeof(float), 0));
						if (bool_34)
						{
							if (bool_35)
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
							dictionary.Add("EndgameMessage", new IEventExporter.EventNotificationParameter(Strings.Trim(stringBuilder_0.ToString()), typeof(string), 0));
						}
						eventExporter.imethod_6(IEventExporter.ExportedEventType.WeaponEndgame, dictionary, this.scenario_0);
					}
				}
				foreach (Interface8 @interface in Class409.interface8_0)
				{
					if (@interface.imethod_2())
					{
						Dictionary<string, Tuple<Type, string>> dictionary2 = new Dictionary<string, Tuple<Type, string>>();
						dictionary2.Add("TimelineID", new Tuple<Type, string>(typeof(string), this.scenario_0.TimelineID));
						dictionary2.Add("Time", new Tuple<Type, string>(typeof(DateTime), this.scenario_0.method_31().ToString("MM/dd/yyyy HH:mm:ss") + "." + this.scenario_0.method_31().Millisecond.ToString("D3")));
						dictionary2.Add("WeaponID", new Tuple<Type, string>(typeof(string), this.string_0));
						dictionary2.Add("WeaponDBID", new Tuple<Type, string>(typeof(string), Conversions.ToString(this.DBID)));
						dictionary2.Add("Longitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(this.vmethod_28(null))));
						dictionary2.Add("Latitude", new Tuple<Type, string>(typeof(double), Conversions.ToString(this.vmethod_30(null))));
						dictionary2.Add("Altitude", new Tuple<Type, string>(typeof(float), Conversions.ToString(this.vmethod_14(false))));
						dictionary2.Add("WeaponCourse", new Tuple<Type, string>(typeof(string), this.vmethod_9().ToString()));
						dictionary2.Add("WeaponSpeed_Horiz", new Tuple<Type, string>(typeof(string), base.method_20().ToString()));
						dictionary2.Add("WeaponSpeed_Vert", new Tuple<Type, string>(typeof(string), base.method_21(this.scenario_0).ToString()));
						if (!Information.IsNothing(this.method_177()))
						{
							dictionary2.Add("FiringUnitID", new Tuple<Type, string>(typeof(string), this.method_177().string_0));
						}
						if (!Information.IsNothing(unit_0))
						{
							dictionary2.Add("TargetID", new Tuple<Type, string>(typeof(string), unit_0.string_0));
						}
						if (bool_34)
						{
							if (bool_35)
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
						@interface.imethod_1(Interface8.Enum135.const_4, dictionary2, this.scenario_0);
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

		// Token: 0x06001B60 RID: 7008 RVA: 0x001F194C File Offset: 0x001EFB4C
		public bool method_265()
		{
			checked
			{
				bool result;
				try
				{
					if (!this.class394_0.bool_5)
					{
						result = false;
					}
					else if (this.sensor_0.Length < 2)
					{
						result = false;
					}
					else
					{
						Sensor[] sensor_ = this.sensor_0;
						for (int i = 0; i < sensor_.Length; i++)
						{
							if (sensor_[i].sensor_Type_0 != Sensor.Sensor_Type.ESM)
							{
								return true;
							}
						}
						result = false;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100956", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x001F19F0 File Offset: 0x001EFBF0
		public static bool smethod_22(ActiveUnit activeUnit_3, double double_4, double double_5, float float_52, GeoPoint geoPoint_1, float float_53, bool bool_34)
		{
			bool result;
			try
			{
				if (activeUnit_3.bool_6)
				{
					if (((Ship)activeUnit_3).float_13 / 2f < float_52)
					{
						result = false;
					}
					else
					{
						Geopoint_Struct[] theArea = Math2.smethod_24(activeUnit_3.vmethod_30(null), activeUnit_3.vmethod_28(null), ((Ship)activeUnit_3).float_13, ((Ship)activeUnit_3).float_25, activeUnit_3.vmethod_9());
						if (GeoPoint.smethod_2(double_4, double_5, theArea, true))
						{
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
				else if (activeUnit_3.bool_5)
				{
					if (((Submarine)activeUnit_3).float_13 / 2f < float_52)
					{
						result = false;
					}
					else if (((Submarine)activeUnit_3).float_13 / 2f > float_52 && ((Submarine)activeUnit_3).float_25 / 2f > float_52)
					{
						result = true;
					}
					else
					{
						Geopoint_Struct[] theArea2 = Math2.smethod_24(activeUnit_3.vmethod_30(null), activeUnit_3.vmethod_28(null), ((Submarine)activeUnit_3).float_13, ((Submarine)activeUnit_3).float_25, activeUnit_3.vmethod_9());
						if (GeoPoint.smethod_2(double_4, double_5, theArea2, true))
						{
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
				else if (activeUnit_3.bool_8)
				{
					if (((Facility)activeUnit_3).bool_27)
					{
						result = ((int)Math.Round((double)float_52) <= 4);
					}
					else if (Math.Max(((Facility)activeUnit_3).float_13, ((Facility)activeUnit_3).float_25) / 2f < float_52)
					{
						result = false;
					}
					else
					{
						Geopoint_Struct[] theArea3 = Math2.smethod_24(activeUnit_3.vmethod_30(null), activeUnit_3.vmethod_28(null), ((Facility)activeUnit_3).float_13, ((Facility)activeUnit_3).float_25, activeUnit_3.vmethod_9());
						if (GeoPoint.smethod_2(double_4, double_5, theArea3, true))
						{
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
				else if (activeUnit_3.bool_3 && ((Aircraft)activeUnit_3).method_144())
				{
					if (((Aircraft)activeUnit_3).float_13 / 2f < float_52)
					{
						result = false;
					}
					else
					{
						Geopoint_Struct[] theArea4 = Math2.smethod_24(activeUnit_3.vmethod_30(null), activeUnit_3.vmethod_28(null), ((Aircraft)activeUnit_3).float_13, ((Aircraft)activeUnit_3).float_27, activeUnit_3.vmethod_9());
						if (GeoPoint.smethod_2(double_4, double_5, theArea4, true))
						{
							result = true;
						}
						else
						{
							result = false;
						}
					}
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100957", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x001F1CBC File Offset: 0x001EFEBC
		public static void smethod_23(Scenario scenario_1, Weapon weapon_1, Unit unit_0, bool bool_34)
		{
			Weapon.Delegate55 @delegate = Weapon.delegate55_0;
			if (@delegate != null)
			{
				@delegate(scenario_1, weapon_1, unit_0, bool_34);
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x001F1CDC File Offset: 0x001EFEDC
		public float method_266(ref ActiveUnit activeUnit_3)
		{
			float result;
			if (Information.IsNothing(activeUnit_3))
			{
				result = 0f;
			}
			else if (!activeUnit_3.bool_6 && (!activeUnit_3.bool_3 || !((Aircraft)activeUnit_3).method_144()) && (!activeUnit_3.bool_5 || !((Submarine)activeUnit_3).method_161()))
			{
				if (activeUnit_3.bool_8)
				{
					result = (float)this.int_15;
				}
				else if (!activeUnit_3.bool_5 && !activeUnit_3.bool_7)
				{
					result = 0f;
				}
				else
				{
					result = (float)this.int_16;
				}
			}
			else
			{
				result = (float)this.int_14;
			}
			return result;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0000DBAD File Offset: 0x0000BDAD
		public float method_267()
		{
			return (float)Math.Max(this.int_13, Math.Max(this.int_14, Math.Max(this.int_15, this.int_16)));
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x001F1D74 File Offset: 0x001EFF74
		protected bool method_268(ActiveUnit activeUnit_3, ref Scenario scenario_1, ref Random random_0)
		{
			bool result;
			try
			{
				scenario_1.method_65(this);
				float num = this.method_266(ref activeUnit_3);
				bool flag = (float)random_0.Next(1, 101) < num;
				float num2;
				float num3;
				if (!this.method_269(activeUnit_3, ref scenario_1, ref num2, ref num3, ref random_0))
				{
					result = false;
				}
				else
				{
					double num4;
					double num5;
					double double_;
					double double_2;
					if (this.method_169() == Weapon.WeaponGuidanceType.Inertial)
					{
						if (this.method_187().method_46())
						{
							num4 = this.method_187().method_4()[Enumerable.Count<Waypoint>(this.method_187().method_4()) - 1].imethod_2();
							num5 = this.method_187().method_4()[Enumerable.Count<Waypoint>(this.method_187().method_4()) - 1].imethod_0();
							double_ = num4;
							double_2 = num5;
						}
					}
					else if (activeUnit_3.method_6())
					{
						Mount mount2;
						if (!Information.IsNothing(this.keyValuePair_0.Value))
						{
							List<Mount> list = new List<Mount>();
							List<Mount> list2 = new List<Mount>();
							try
							{
								foreach (Mount mount in activeUnit_3.vmethod_51())
								{
									foreach (Sensor sensor in mount.method_36())
									{
										if (sensor.DBID == this.keyValuePair_0.Key || (int)sensor.short_0 == this.keyValuePair_0.Key)
										{
											list.Add(mount);
											if (sensor.method_43())
											{
												list2.Add(mount);
											}
										}
									}
								}
							}
							finally
							{
								List<Mount>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							if (list2.Count > 0)
							{
								mount2 = list2[random_0.Next(0, list2.Count)];
							}
							else if (list.Count > 0)
							{
								mount2 = list[random_0.Next(0, list.Count)];
							}
							else
							{
								mount2 = ((Facility)activeUnit_3).method_155();
							}
						}
						else
						{
							mount2 = ((Facility)activeUnit_3).method_155();
						}
						if (!Information.IsNothing(mount2))
						{
							Class411.smethod_1(activeUnit_3.vmethod_28(null), activeUnit_3.vmethod_30(null), ref num5, ref num4, (double)(mount2.method_27() / 1852f), (double)mount2.method_26());
							double_ = num4;
							double_2 = num5;
						}
						else if (this.vmethod_142().vmethod_3().method_57() == 0f && !Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
						{
							num4 = this.vmethod_142().vmethod_3().activeUnit_0.vmethod_30(null);
							num5 = this.vmethod_142().vmethod_3().activeUnit_0.vmethod_28(null);
						}
						else
						{
							num4 = this.vmethod_142().vmethod_3().vmethod_30(null);
							num5 = this.vmethod_142().vmethod_3().vmethod_28(null);
						}
					}
					else if (this.vmethod_142().vmethod_3().method_57() == 0f && !Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
					{
						num4 = this.vmethod_142().vmethod_3().activeUnit_0.vmethod_30(null);
						num5 = this.vmethod_142().vmethod_3().activeUnit_0.vmethod_28(null);
					}
					else
					{
						num4 = this.vmethod_142().vmethod_3().vmethod_30(null);
						num5 = this.vmethod_142().vmethod_3().vmethod_28(null);
					}
					double num6;
					double num7;
					Class411.smethod_1(num5, num4, ref num6, ref num7, (double)(num2 / 1852f), (double)num3);
					float num8;
					if (activeUnit_3.method_6())
					{
						num8 = Math2.smethod_15(num7, num6, double_, double_2) * 1852f;
					}
					else
					{
						num8 = Math2.smethod_15(num7, num6, activeUnit_3.vmethod_30(null), activeUnit_3.vmethod_28(null)) * 1852f;
					}
					float num9 = Math2.smethod_17(activeUnit_3.vmethod_30(null), activeUnit_3.vmethod_28(null), num7, num6);
					bool flag2;
					if (flag2 = Weapon.smethod_22(activeUnit_3, num7, num6, num8, this.geoPoint_0, this.method_159(), false))
					{
						Weapon.Delegate55 @delegate = Weapon.delegate55_0;
						if (@delegate != null)
						{
							@delegate(this.scenario_0, this, activeUnit_3, false);
						}
					}
					if (this.warhead_0.Length > 0 && this.warhead_0[0].method_13())
					{
						if (flag)
						{
							foreach (Warhead warhead in this.warhead_0)
							{
								if (warhead.method_13())
								{
									new Explosion(ref scenario_1, num6, num7, num6, num7, this.vmethod_9(), this.vmethod_14(false), this.method_167(), warhead.float_0, warhead.float_0, warhead.warheadType_0, warhead.enum126_0, null, null, null, null, null, warhead.short_1, warhead.short_2, (int)warhead.short_0, 0f, 0).vmethod_10(this.vmethod_9());
								}
							}
							if (num8 < 926f)
							{
								if (Class570.class280_0.method_12())
								{
									scenario_1.method_59(string.Concat(new string[]
									{
										"Weapon: ",
										this.Name,
										" airbursted off ",
										activeUnit_3.Name,
										" by ",
										Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num8 * 3.28084f)))),
										"ft, dispensing submunitions..."
									}), this.Name + " detonating", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
								else
								{
									scenario_1.method_59(string.Concat(new string[]
									{
										"Weapon: ",
										this.Name,
										" airbursted off ",
										activeUnit_3.Name,
										" by ",
										Conversions.ToString(Math.Max(1, (int)Math.Round((double)num8))),
										"m, dispensing submunitions..."
									}), this.Name + " detonating", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								}
							}
							else
							{
								scenario_1.method_59(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" airbursted off ",
									activeUnit_3.Name,
									" by ",
									Conversions.ToString(Math.Round((double)(num8 / 1852f), 1)),
									"nm, dispensing submunitions..."
								}), this.Name + " detonating", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
						}
						else
						{
							scenario_1.method_59("Weapon: " + this.Name + " has malfunctioned.", "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(num6, num7));
						}
						result = false;
					}
					else
					{
						if (this.warhead_0[0].method_11())
						{
							if (!flag)
							{
								scenario_1.method_59("Weapon: " + this.Name + " has malfunctioned.", "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(num6, num7));
							}
							else if (flag2)
							{
								if (this.warhead_0[0].method_16(this, activeUnit_3))
								{
									if (base.method_2() && this.method_199() && (activeUnit_3.bool_6 || activeUnit_3.bool_8))
									{
										if (activeUnit_3.vmethod_121() > GlobalVariables.TargetVisualSizeClass.VSmall)
										{
											this.method_270(activeUnit_3, null);
										}
										else
										{
											scenario_1.method_59("Weapon: " + this.Name + " airbursted directly on top of " + activeUnit_3.Name, "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
											ActiveUnit_Damage activeUnit_Damage = activeUnit_3.vmethod_91();
											GeoPoint geoPoint = this.geoPoint_0;
											float float_ = num8;
											float float_2 = num9;
											ActiveUnit activeUnit = null;
											double? nullable_ = null;
											double? nullable_2 = null;
											float? nullable_3 = null;
											string text = "";
											activeUnit_Damage.vmethod_10(this, geoPoint, float_, float_2, activeUnit, nullable_, nullable_2, nullable_3, ref text);
										}
									}
									else
									{
										scenario_1.method_59("Weapon: " + this.Name + " airbursted directly on top of " + activeUnit_3.Name, "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
										ActiveUnit_Damage activeUnit_Damage2 = activeUnit_3.vmethod_91();
										GeoPoint geoPoint2 = this.geoPoint_0;
										float float_3 = num8;
										float float_4 = num9;
										ActiveUnit activeUnit2 = null;
										double? nullable_4 = null;
										double? nullable_5 = null;
										float? nullable_6 = null;
										string text = "";
										activeUnit_Damage2.vmethod_10(this, geoPoint2, float_3, float_4, activeUnit2, nullable_4, nullable_5, nullable_6, ref text);
									}
								}
								else
								{
									this.method_270(activeUnit_3, null);
								}
							}
							else
							{
								if (!activeUnit_3.method_6())
								{
									if (this.warhead_0[0].method_16(this, activeUnit_3))
									{
										string text2 = " airbursted off ";
										if (this.vmethod_27() || this.vmethod_26() || this.vmethod_13() == 0f)
										{
											text2 = " missed ";
										}
										if (Class570.class280_0.method_12())
										{
											scenario_1.method_59(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												text2,
												activeUnit_3.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num8 * 3.28084f)))),
												"ft"
											}), "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
										}
										else
										{
											scenario_1.method_59(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												text2,
												activeUnit_3.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)num8))),
												"m"
											}), "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
										}
									}
									else if (num8 < 926f)
									{
										if (Class570.class280_0.method_12())
										{
											scenario_1.method_59(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												" missed ",
												activeUnit_3.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num8 * 3.28084f)))),
												"ft"
											}), "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
										}
										else
										{
											scenario_1.method_59(string.Concat(new string[]
											{
												"Weapon: ",
												this.Name,
												" missed ",
												activeUnit_3.Name,
												" by ",
												Conversions.ToString(Math.Max(1, (int)Math.Round((double)num8))),
												"m"
											}), "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
										}
									}
									else
									{
										scenario_1.method_59(string.Concat(new string[]
										{
											"Weapon: ",
											this.Name,
											" missed ",
											activeUnit_3.Name,
											" by ",
											Conversions.ToString(Math.Round((double)(num8 / 1852f), 1)),
											"nm"
										}), "Weapon hit", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									}
								}
								float num10;
								if (this.bool_7)
								{
									num10 = this.vmethod_14(false);
								}
								else
								{
									num10 = this.vmethod_16();
								}
								bool flag3 = num10 >= 0f || this.warhead_0[0].method_14(this.scenario_0) || this.bool_7 || this.warhead_0[0].method_16(this, activeUnit_3);
								if (flag3)
								{
									if (this.warhead_0[0].method_16(this, activeUnit_3))
									{
										double double_3 = num7;
										double double_4 = num6;
										float float_5 = this.vmethod_16();
										Random random = GameGeneral.smethod_5();
										this.method_223(double_3, double_4, float_5, ref random, true);
									}
									else
									{
										ActiveUnit_Damage activeUnit_Damage3 = activeUnit_3.vmethod_91();
										GeoPoint geoPoint3 = this.geoPoint_0;
										float num11;
										float float_6 = num8 - num11;
										float float_7 = num9;
										ActiveUnit activeUnit3 = null;
										double? nullable_7 = null;
										double? nullable_8 = null;
										float? nullable_9 = null;
										string text = "";
										activeUnit_Damage3.vmethod_10(this, geoPoint3, float_6, float_7, activeUnit3, nullable_7, nullable_8, nullable_9, ref text);
									}
								}
							}
						}
						else if (!flag)
						{
							scenario_1.method_59("Weapon: " + this.Name + " has malfunctioned.", "Weapon malfunctioned", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(num6, num7));
						}
						else if (!flag)
						{
							scenario_1.method_59("Weapon: " + this.Name + " has malfunctioned.", "Weapon malfunctioned", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(num6, num7));
						}
						else if (flag2)
						{
							this.method_270(activeUnit_3, null);
						}
						else if (this.warhead_0[0].method_16(this, activeUnit_3))
						{
							if (Class570.class280_0.method_12())
							{
								scenario_1.method_59(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" airbursted off ",
									activeUnit_3.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num8 * 3.28084f)))),
									"ft"
								}), "Weapon airbursted", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
							else
							{
								scenario_1.method_59(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" airbursted off ",
									activeUnit_3.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)num8))),
									"m"
								}), "Weapon airbursted", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
						}
						else if (num8 > 926f)
						{
							if (Class570.class280_0.method_12())
							{
								scenario_1.method_59(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" missed ",
									activeUnit_3.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)(num8 * 3.28084f)))),
									"ft"
								}), "Weapon missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
							else
							{
								scenario_1.method_59(string.Concat(new string[]
								{
									"Weapon: ",
									this.Name,
									" missed ",
									activeUnit_3.Name,
									" by ",
									Conversions.ToString(Math.Max(1, (int)Math.Round((double)num8))),
									"m"
								}), "Weapon missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
						}
						else
						{
							scenario_1.method_59(string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" missed ",
								activeUnit_3.Name,
								" by ",
								Conversions.ToString(Math.Round((double)(num8 / 1852f), 1)),
								"nm"
							}), "Weapon missed", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						}
						if (!flag2)
						{
							this.method_264(activeUnit_3, false, false, null);
						}
						result = flag2;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100958", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x001F2EAC File Offset: 0x001F10AC
		public bool method_269(ActiveUnit activeUnit_3, ref Scenario scenario_1, ref float float_52, ref float float_53, ref Random random_0)
		{
			bool result;
			try
			{
				float num;
				if (!Information.IsNothing(activeUnit_3))
				{
					if (activeUnit_3.bool_8)
					{
						num = (float)this.method_174();
					}
					else
					{
						num = (float)this.method_172();
					}
				}
				else
				{
					num = (float)Math.Max(this.method_174(), this.method_172());
				}
				if (this.method_169() == Weapon.WeaponGuidanceType.Inertial && !Information.IsNothing(activeUnit_3) && activeUnit_3.vmethod_40() > 0f)
				{
					float num2 = (float)activeUnit_3.vmethod_87().vmethod_40(activeUnit_3.vmethod_14(false), ActiveUnit.Throttle.Flank, false);
					float num3;
					if (num2 > 0f)
					{
						num3 = activeUnit_3.vmethod_40() / num2;
					}
					else
					{
						num3 = 0f;
					}
					if (activeUnit_3.bool_8)
					{
						num = (float)this.method_174() + (float)this.method_174() * num3;
					}
					else
					{
						num = (float)this.method_172() + (float)this.method_172() * num3;
					}
				}
				if (this.class394_0.bool_5)
				{
					if (!Information.IsNothing(this.keyValuePair_0.Value))
					{
						if (this.keyValuePair_0.Value.float_0 > 1f)
						{
							if (this.struct36_0.bool_10)
							{
								num = Math.Min(num * 5f, num + this.keyValuePair_0.Value.float_0 * 100f);
							}
							else
							{
								float num4 = Math.Min(this.keyValuePair_0.Value.float_0, (float)this.vmethod_67()[0].int_0 - this.vmethod_67()[0].float_0);
								num += num4 * 20f;
							}
						}
					}
					else if (!this.method_265())
					{
						scenario_1.method_59("Weapon: " + this.Name + " has no emission lock and no alternative sensor.... clean miss.", this.Name + " missed completely", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
						return false;
					}
				}
				float_53 = (float)(random_0.NextDouble() * 359.99);
				double num5 = random_0.NextDouble();
				if (num5 <= 0.5)
				{
					float_52 = (float)((double)random_0.Next(0, 101) / 100.0 * (double)num);
				}
				else if (num5 < 0.937)
				{
					float_52 = (float)((double)num + (double)num * random_0.NextDouble());
				}
				else
				{
					float_52 = (float)((double)(2f * num) + (double)num * random_0.NextDouble());
				}
				if (!Information.IsNothing(this.keyValuePair_0) && !Information.IsNothing(this.keyValuePair_0.Value) && !Information.IsNothing(activeUnit_3) && activeUnit_3.vmethod_40() > 0f && this.keyValuePair_0.Value.float_0 > 1f)
				{
					float_52 += this.keyValuePair_0.Value.float_0 / 3600f * activeUnit_3.vmethod_40() * 1852f;
				}
				result = true;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101339", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x001F31DC File Offset: 0x001F13DC
		public void method_270(ActiveUnit activeUnit_3, StringBuilder stringBuilder_0)
		{
			try
			{
				if (Information.IsNothing(stringBuilder_0))
				{
					stringBuilder_0 = new StringBuilder();
				}
				else
				{
					stringBuilder_0.Append("\r\n");
				}
				string text = "";
				bool flag = false;
				if (!this.method_208())
				{
					Weapon.Delegate55 @delegate = Weapon.delegate55_0;
					if (@delegate != null)
					{
						@delegate(this.scenario_0, this, activeUnit_3, true);
					}
					new WeaponImpact(ref activeUnit_3.scenario_0, activeUnit_3.vmethod_28(null), activeUnit_3.vmethod_30(null), activeUnit_3.vmethod_14(false), WeaponImpact.Enum124.const_0, this.DBID);
				}
				if (!activeUnit_3.bool_3 && !activeUnit_3.bool_2)
				{
					if (activeUnit_3.bool_8)
					{
						if (!((Facility)activeUnit_3).bool_27)
						{
							text = string.Concat(new string[]
							{
								"Weapon: ",
								this.Name,
								" has impacted ",
								activeUnit_3.Name,
								". "
							});
						}
					}
					else
					{
						text = string.Concat(new string[]
						{
							"Weapon: ",
							this.Name,
							" has impacted ",
							activeUnit_3.Name,
							". "
						});
					}
				}
				if (activeUnit_3.bool_2)
				{
					Weapon weapon = (Weapon)activeUnit_3;
					if (weapon.method_204() || weapon.vmethod_3())
					{
						Warhead.WarheadType warheadType_ = this.warhead_0[0].warheadType_0;
						if (warheadType_ != Warhead.WarheadType.ArmorPiercing)
						{
							if (warheadType_ != Warhead.WarheadType.Fragmentation_ABM)
							{
								if (warheadType_ != Warhead.WarheadType.Kinetic)
								{
									text += "Conventional warhead: 15% chance of outright destruction, 30% chance of significant deviation. ";
									int num = GameGeneral.smethod_5().Next(1, 101);
									int num2 = num;
									if (num2 <= 15)
									{
										text = text + "RESULT: " + Conversions.ToString(num) + ". Target destroyed outright. ";
										flag = true;
										goto IL_4A0;
									}
									if (num2 <= 30)
									{
										text = text + "RESULT: " + Conversions.ToString(num) + ". Significant trajectory deviation (CEP of target weapon tripled). ";
										weapon.method_175(weapon.method_174() * 3);
										weapon.method_173(weapon.method_172() * 3);
										activeUnit_3.scenario_0.method_59(text, this.Name + " impacted " + activeUnit_3.Name + " - no kill", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
										flag = false;
										goto IL_4A0;
									}
									text = text + "RESULT: " + Conversions.ToString(num) + ". Minor trajectory deviation (CEP of target weapon multipled by 1.5). ";
									weapon.method_175((int)Math.Round((double)weapon.method_174() * 1.5));
									weapon.method_173((int)Math.Round((double)weapon.method_172() * 1.5));
									activeUnit_3.scenario_0.method_59(text, this.Name + " impacted " + activeUnit_3.Name + " - no kill", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									flag = false;
									goto IL_4A0;
								}
							}
							else
							{
								text += "ABM-optimized fragmentation warhead: 30% chance of outright destruction, 60% chance of significant deviation. ";
								int num3 = GameGeneral.smethod_5().Next(1, 101);
								int num4 = num3;
								if (num4 <= 30)
								{
									text = text + "RESULT: " + Conversions.ToString(num3) + ". Target destroyed outright. ";
									flag = true;
									goto IL_4A0;
								}
								if (num4 <= 60)
								{
									text = text + "RESULT: " + Conversions.ToString(num3) + ". Significant trajectory deviation (CEP of target weapon tripled). ";
									weapon.method_175(weapon.method_174() * 3);
									weapon.method_173(weapon.method_172() * 3);
									activeUnit_3.scenario_0.method_59(text, this.Name + " impacted " + activeUnit_3.Name + " - no kill", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
									flag = false;
									goto IL_4A0;
								}
								text = text + "RESULT: " + Conversions.ToString(num3) + ". Minor trajectory deviation (CEP of target weapon multipled by 1.5). ";
								weapon.method_175((int)Math.Round((double)weapon.method_174() * 1.5));
								weapon.method_173((int)Math.Round((double)weapon.method_172() * 1.5));
								activeUnit_3.scenario_0.method_59(text, this.Name + " impacted " + activeUnit_3.Name + " - no kill", LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
								flag = false;
								goto IL_4A0;
							}
						}
						text += "Hit-To-Kill warhead: Target destroyed outright. ";
						flag = true;
						IL_4A0:
						stringBuilder_0.Append(text);
						this.method_264(activeUnit_3, true, flag, stringBuilder_0);
						if (flag)
						{
							ActiveUnit_Damage activeUnit_Damage = activeUnit_3.vmethod_91();
							GeoPoint geoPoint = this.geoPoint_0;
							float float_ = 0f;
							float float_2 = 0f;
							ActiveUnit activeUnit = null;
							double? nullable_ = null;
							double? nullable_2 = null;
							float? nullable_3 = null;
							string text2 = "";
							activeUnit_Damage.vmethod_10(this, geoPoint, float_, float_2, activeUnit, nullable_, nullable_2, nullable_3, ref text2);
						}
						return;
					}
				}
				if (Operators.CompareString(text, "", false) != 0)
				{
					activeUnit_3.scenario_0.method_59(text, this.Name + " impacted " + activeUnit_3.Name, LoggedMessage.MessageType.WeaponDamage, 10, this.string_0, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
				}
				if (!activeUnit_3.bool_3 && !activeUnit_3.method_2())
				{
					if (activeUnit_3.method_2())
					{
						stringBuilder_0.Append("\r\n").Append(text);
						this.method_264(activeUnit_3, true, flag, stringBuilder_0);
						ActiveUnit_Damage activeUnit_Damage2 = activeUnit_3.vmethod_91();
						GeoPoint geoPoint2 = this.geoPoint_0;
						float float_3 = 0f;
						float float_4 = 0f;
						ActiveUnit activeUnit2 = null;
						double? nullable_4 = null;
						double? nullable_5 = null;
						float? nullable_6 = null;
						string text2 = "";
						activeUnit_Damage2.vmethod_10(this, geoPoint2, float_3, float_4, activeUnit2, nullable_4, nullable_5, nullable_6, ref text2);
					}
					else
					{
						stringBuilder_0.Append(text);
						ActiveUnit_Damage activeUnit_Damage3 = activeUnit_3.vmethod_91();
						GeoPoint geoPoint3 = this.geoPoint_0;
						float float_5 = 0f;
						float float_6 = 0f;
						ActiveUnit activeUnit3 = null;
						double? nullable_7 = null;
						double? nullable_8 = null;
						float? nullable_9 = null;
						string text2 = "";
						activeUnit_Damage3.vmethod_10(this, geoPoint3, float_5, float_6, activeUnit3, nullable_7, nullable_8, nullable_9, ref text2);
						bool bool_ = activeUnit_3.method_82();
						this.method_264(activeUnit_3, true, bool_, stringBuilder_0);
					}
				}
				else
				{
					ActiveUnit_Damage activeUnit_Damage4 = activeUnit_3.vmethod_91();
					GeoPoint geoPoint4 = this.geoPoint_0;
					float float_7 = 0f;
					float float_8 = 0f;
					ActiveUnit activeUnit4 = null;
					double? nullable_10 = null;
					double? nullable_11 = null;
					float? nullable_12 = null;
					string text2 = "";
					activeUnit_Damage4.vmethod_10(this, geoPoint4, float_7, float_8, activeUnit4, nullable_10, nullable_11, nullable_12, ref text2);
					flag = activeUnit_3.method_82();
					this.method_264(activeUnit_3, true, flag, stringBuilder_0);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100959", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x001F38D4 File Offset: 0x001F1AD4
		public override void vmethod_133(bool bool_34, bool bool_35, bool bool_36)
		{
			this.bool_24 = true;
			try
			{
				if (!Information.IsNothing(this.vmethod_142().vmethod_3()) && !this.vmethod_142().vmethod_3().method_124(this.scenario_0) && this.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint && this.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.ActivationPoint && !Information.IsNothing(this.vmethod_142().vmethod_3().activeUnit_0))
				{
					foreach (Contact contact in this.vmethod_142().vmethod_3().activeUnit_0.vmethod_86().method_15())
					{
						if (contact.activeUnit_0 == this)
						{
							this.vmethod_142().vmethod_3().activeUnit_0.vmethod_86().vmethod_14(contact);
							IL_D0:
							this.vmethod_142().vmethod_3().activeUnit_0.vmethod_86().vmethod_6(null);
							goto IL_EB;
						}
					}
					goto IL_D0;
				}
				IL_EB:
				try
				{
					foreach (ActiveUnit activeUnit in this.scenario_0.vmethod_0().Values)
					{
						if (!Information.IsNothing(activeUnit))
						{
							foreach (Sensor sensor in activeUnit.vmethod_96())
							{
								if (sensor.list_1.Contains(this))
								{
									sensor.list_1.Remove(this);
									this.method_171(null);
								}
								if (sensor.list_1.Count == 0)
								{
									sensor.method_84(this.vmethod_142().vmethod_3(), false);
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
				base.vmethod_133(bool_34, bool_35, bool_36);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200343", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x001F3AF0 File Offset: 0x001F1CF0
		public void method_271()
		{
			if (this.method_167() == Weapon._WeaponType.Decoy_Vehicle)
			{
				this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Inertial);
				return;
			}
			if (this.struct36_0.bool_0)
			{
				if (this.sensor_0.Length > 0)
				{
					Sensor.Sensor_Type sensor_Type_ = this.sensor_0[0].sensor_Type_0;
					if (sensor_Type_ == Sensor.Sensor_Type.Radar)
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.SemiActive_Plus_Active);
						return;
					}
					if (sensor_Type_ == Sensor.Sensor_Type.SemiActive)
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.SemiActive);
						return;
					}
					if (sensor_Type_ != Sensor.Sensor_Type.LaserSpotTracker)
					{
						return;
					}
					this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.SemiActive);
					return;
				}
				else
				{
					if (Enumerable.Count<CommDevice>(this.vmethod_94()) > 0)
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.TVM);
						return;
					}
					this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.BeamRiding);
					return;
				}
			}
			else
			{
				if (this.hashSet_0.Count > 0 && Enumerable.Count<CommDevice>(this.vmethod_94()) == 0 && !this.struct36_0.bool_1 && base.method_115())
				{
					this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active);
					return;
				}
				if (this.struct36_0.bool_1)
				{
					if (Enumerable.Count<CommDevice>(this.vmethod_94()) != 0)
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive);
						return;
					}
					if (!base.method_116())
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive);
						return;
					}
					if (!this.struct36_0.bool_14 && !this.struct36_0.bool_28 && !this.struct36_0.bool_29 && !this.struct36_0.bool_30)
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Passive);
						return;
					}
					this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Inertial_Plus_Passive);
					return;
				}
				else if (!base.method_115() && !base.method_119())
				{
					if (base.method_118())
					{
						if (!this.struct36_0.bool_14 && !this.struct36_0.bool_28 && !this.struct36_0.bool_29 && !this.struct36_0.bool_30)
						{
							if (Enumerable.Count<CommDevice>(this.vmethod_94()) == 0)
							{
								this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Passive);
								return;
							}
							this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.DataLink_Plus_Passive);
							return;
						}
						else
						{
							if (Enumerable.Count<CommDevice>(this.vmethod_94()) == 0)
							{
								this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Inertial_Plus_Passive);
								return;
							}
							this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.DataLink_Plus_Passive);
							return;
						}
					}
					else
					{
						if (Enumerable.Count<CommDevice>(this.vmethod_94()) > 0)
						{
							this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.CommandGuided_Datalinked);
							return;
						}
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Inertial);
						return;
					}
				}
				else if (this.struct36_0.bool_14)
				{
					if (Enumerable.Count<CommDevice>(this.vmethod_94()) == 0)
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Inertial_Plus_Active);
						return;
					}
					this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Datalink_Plus_Active);
					return;
				}
				else
				{
					if (Enumerable.Count<CommDevice>(this.vmethod_94()) == 0)
					{
						this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Active);
						return;
					}
					this.nullable_16 = new Weapon.WeaponGuidanceType?(Weapon.WeaponGuidanceType.Datalink_Plus_Active);
					return;
				}
			}
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x001F3D9C File Offset: 0x001F1F9C
		internal float method_272(float float_52)
		{
			float result;
			if (float_52 >= 91.44f)
			{
				result = 0f;
			}
			else if (float_52 >= 60.96f)
			{
				result = 5f;
			}
			else if (float_52 >= 30.48f)
			{
				result = 15f;
			}
			else
			{
				result = 30f;
			}
			return result;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x001F3DE4 File Offset: 0x001F1FE4
		public override void vmethod_137(float float_52)
		{
			try
			{
				if (Enumerable.Count<FuelRec>(this.vmethod_67()) != 0)
				{
					if (this.fuelRec_0[0].float_0 == 0f)
					{
						if (this.vmethod_6() && this.vmethod_18() < this.method_140())
						{
							return;
						}
						if (!this.method_191() || this.method_199())
						{
							if (this.method_167() != Weapon._WeaponType.Sonobuoy)
							{
								this.scenario_0.method_59("Weapon: " + this.Name + " has run out of energy... self-destructing", this.Name + " petered out", LoggedMessage.MessageType.WeaponEndgame, 3, null, null, new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null)));
							}
							this.scenario_0.method_65(this);
							return;
						}
						double double_ = this.vmethod_30(null);
						double double_2 = this.vmethod_28(null);
						float float_53 = this.vmethod_14(false);
						Random random = GameGeneral.smethod_5();
						this.method_223(double_, double_2, float_53, ref random, true);
					}
					float num = this.vmethod_98(this.vmethod_84(), null, null, null, false, false, false, false, false);
					this.fuelRec_0[0].float_0 = this.fuelRec_0[0].float_0 - float_52 * num;
					if (this.fuelRec_0[0].float_0 < 0f)
					{
						this.fuelRec_0[0].float_0 = 0f;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100961", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x001F3FB0 File Offset: 0x001F21B0
		public override float vmethod_98(ActiveUnit.Throttle throttle_5, AltBand altBand_0, float? nullable_22, float? nullable_23, bool bool_34, bool bool_35, bool bool_36, bool bool_37, bool bool_38)
		{
			float result;
			try
			{
				if (this.vmethod_49().Count == 0)
				{
					result = 1f;
				}
				else
				{
					AltBand altBand;
					if (Information.IsNothing(altBand_0))
					{
						if (Information.IsNothing(nullable_23))
						{
							altBand = this.vmethod_143().vmethod_42(this.vmethod_14(false), false);
						}
						else
						{
							altBand = this.vmethod_143().vmethod_42(nullable_23.Value, false);
						}
					}
					else
					{
						altBand = altBand_0;
					}
					if (Information.IsNothing(altBand))
					{
						throw new Exception();
					}
					switch (throttle_5)
					{
					case ActiveUnit.Throttle.Loiter:
						if (!Information.IsNothing(altBand.float_2))
						{
							result = Math.Max(1f, altBand.float_2);
						}
						else
						{
							result = 0f;
						}
						break;
					case ActiveUnit.Throttle.Cruise:
						result = altBand.float_3;
						break;
					case ActiveUnit.Throttle.Full:
						if (altBand.nullable_2 != null)
						{
							result = altBand.nullable_2.Value;
						}
						else
						{
							result = altBand.float_3;
						}
						break;
					case ActiveUnit.Throttle.Flank:
						if (altBand.nullable_3 != null)
						{
							result = altBand.nullable_3.Value;
						}
						else if (altBand.nullable_2 != null)
						{
							result = altBand.nullable_2.Value;
						}
						else
						{
							result = altBand.float_3;
						}
						break;
					default:
						result = 0f;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100962", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x001F414C File Offset: 0x001F234C
		private float method_273(int int_21, float float_52, float float_53, float float_54, StringBuilder stringBuilder_0)
		{
			float num = 0f;
			float result;
			try
			{
				if (float_52 > (float)this.int_20)
				{
					num = 50f;
				}
				else if ((double)float_52 > (double)this.int_20 * 0.8)
				{
					num = 25f;
				}
				else if ((double)float_52 > (double)this.int_20 * 0.7)
				{
					num = 15f;
				}
				else if ((double)float_52 > (double)this.int_20 * 0.6)
				{
					num = 10f;
				}
				else if ((double)float_52 > (double)this.int_20 * 0.5)
				{
					num = 5f;
				}
				if (num != 0f)
				{
					stringBuilder_0.Append(" Target speed modifier: " + Conversions.ToString(-(int)Math.Round((double)num)) + "%. ");
				}
				float num2;
				if (!Information.IsNothing(this.method_147()) && this.method_147().Length > 0 && !Information.IsNothing(this.method_147()[0]))
				{
					Sensor.Sensor_Type sensor_Type_ = this.method_147()[0].sensor_Type_0;
					if (sensor_Type_ - Sensor.Sensor_Type.Radar > 1)
					{
						if (sensor_Type_ != Sensor.Sensor_Type.Infrared)
						{
							if (sensor_Type_ != Sensor.Sensor_Type.LaserDesignator)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								num2 = 0f;
							}
							else
							{
								num2 = 0f;
							}
						}
						else if (float_54 > 1f)
						{
							num2 = 0f;
						}
						else if (float_54 > 0.5f)
						{
							num2 = 10f;
						}
						else if (float_54 > 0.25f)
						{
							num2 = 15f;
						}
						else
						{
							num2 = 20f;
						}
					}
					else
					{
						float num3 = (float)new Class563.Class567
						{
							double_0 = (double)float_53
						}.method_0();
						if (num3 > 1f)
						{
							num2 = 0f;
						}
						else if (num3 > 0.1f)
						{
							num2 = 10f;
						}
						else if (num3 > 0.01f)
						{
							num2 = 15f;
						}
						else
						{
							num2 = 20f;
						}
					}
					if (num2 != 0f)
					{
						stringBuilder_0.Append(" Target signature modifier: " + Conversions.ToString(-(int)Math.Round((double)num2)) + "%. ");
					}
				}
				result = Math.Max(1f, (float)int_21 - num - num2);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100963", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x001F43B4 File Offset: 0x001F25B4
		public string method_274()
		{
			string text = "";
			string str = "";
			bool flag;
			if (this.struct36_0.bool_28)
			{
				text = "Inertial (INS)";
				flag = true;
			}
			else if (this.struct36_0.bool_29)
			{
				text = "GPS-Updated Inertial (INS)";
				flag = true;
			}
			else if (this.struct36_0.bool_30)
			{
				text = "Terrain Comparison (TERCOM)";
				flag = true;
			}
			else if (this.struct36_0.bool_5)
			{
				text = "Rear-Aspect";
				flag = true;
			}
			else if (this.struct36_0.bool_4)
			{
				text = "Stern-Chase";
				flag = true;
			}
			else if (this.struct36_0.bool_6)
			{
				text = "All-Aspect";
				flag = true;
			}
			else if (this.struct36_0.bool_7)
			{
				text = "All-Aspect, High Off-Boresight";
				flag = true;
			}
			else if (this.struct36_0.bool_52)
			{
				text = "Pattern-Running";
				flag = true;
			}
			else if (this.struct36_0.bool_51)
			{
				text = "Straight-Running Time Detonation";
				flag = true;
			}
			else if (this.struct36_0.bool_49)
			{
				text = "Straight-Running";
				flag = true;
			}
			else if (this.struct36_0.bool_50)
			{
				text = "Wake-Homing (WH)";
				flag = true;
			}
			checked
			{
				switch (this.method_169())
				{
				case Weapon.WeaponGuidanceType.SemiActive:
					text = "Semi-Active";
					if (this.hashSet_0.Count <= 0)
					{
						return text;
					}
					try
					{
						foreach (int int_ in this.hashSet_0)
						{
							SQLiteConnection sqliteConnection = this.scenario_0.method_39();
							Sensor sensor = DBFunctions.smethod_97(int_, ref sqliteConnection);
							if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (SARH)";
								break;
							}
							if (sensor.sensor_Type_0 == Sensor.Sensor_Type.LaserDesignator)
							{
								text += " Laser Homing (SALH)";
								break;
							}
						}
						return text;
					}
					finally
					{
						HashSet<int>.Enumerator enumerator;
						enumerator.Dispose();
					}
					break;
				case Weapon.WeaponGuidanceType.Inertial_Plus_SemiActive:
					break;
				case Weapon.WeaponGuidanceType.Datalink_Plus_SemiActive:
					text = "Datalink (DL/INS) mid-course plus Semi-Active";
					if (this.hashSet_0.Count > 0)
					{
						try
						{
							foreach (int int_2 in this.hashSet_0)
							{
								SQLiteConnection sqliteConnection = this.scenario_0.method_39();
								Sensor sensor2 = DBFunctions.smethod_97(int_2, ref sqliteConnection);
								if (sensor2.sensor_Type_0 == Sensor.Sensor_Type.Radar)
								{
									text += " Radar Homing (SARH)";
									break;
								}
								if (sensor2.sensor_Type_0 == Sensor.Sensor_Type.LaserDesignator)
								{
									text += " Laser Homing (SALH)";
									break;
								}
							}
						}
						finally
						{
							HashSet<int>.Enumerator enumerator2;
							enumerator2.Dispose();
						}
					}
					if (this.sensor_0.Length > 0)
					{
						foreach (Sensor sensor3 in this.sensor_0)
						{
							if (sensor3.sensor_Type_0 == Sensor.Sensor_Type.Infrared)
							{
								str = " with Infrared (IR) backup seeker";
							}
							else if (sensor3.sensor_Type_0 == Sensor.Sensor_Type.Visual)
							{
								str = " with Electro-Optical (EO) backup seeker";
							}
						}
					}
					return text + " terminal guidance" + str;
				case (Weapon.WeaponGuidanceType)3:
					return text;
				case Weapon.WeaponGuidanceType.Passive:
					if (flag)
					{
						text += " mid-course plus ";
					}
					text += "Passive";
					if (this.sensor_0.Length > 0)
					{
						foreach (Sensor sensor4 in this.sensor_0)
						{
							if (sensor4.sensor_Type_0 == Sensor.Sensor_Type.Infrared)
							{
								text += " Infrared (IR)";
								break;
							}
							if (sensor4.sensor_Type_0 == Sensor.Sensor_Type.Visual)
							{
								text += " Electro-Optical (EO)";
								break;
							}
							if (sensor4.sensor_Type_0 == Sensor.Sensor_Type.ESM)
							{
								text += " Radar Homing";
								break;
							}
						}
					}
					if (flag)
					{
						return text + " terminal guidance";
					}
					return text;
				case Weapon.WeaponGuidanceType.Inertial_Plus_Passive:
					text = "Inertial (INS) mid-course plus Passive";
					if (this.sensor_0.Length > 0)
					{
						foreach (Sensor sensor5 in this.sensor_0)
						{
							if (sensor5.sensor_Type_0 == Sensor.Sensor_Type.Infrared)
							{
								text += " Infrared (IR)";
								break;
							}
							if (sensor5.sensor_Type_0 == Sensor.Sensor_Type.Visual)
							{
								text += " Electro-Optical (EO)";
								break;
							}
							if (sensor5.sensor_Type_0 == Sensor.Sensor_Type.ESM)
							{
								text += " Radar Homing (ARM)";
								break;
							}
						}
					}
					return text + " terminal guidance";
				case Weapon.WeaponGuidanceType.DataLink_Plus_Passive:
					if (flag)
					{
						text += " and ";
					}
					if (this.method_167() == Weapon._WeaponType.GuidedWeapon)
					{
						text += "Datalink (DL/INS) mid-course plus Passive";
					}
					else if (this.method_167() == Weapon._WeaponType.Torpedo)
					{
						text += "Wire-Guidance mid-course plus Passive";
					}
					if (this.sensor_0.Length > 0)
					{
						Sensor[] sensor_4 = this.sensor_0;
						for (int l = 0; l < sensor_4.Length; l++)
						{
							if (sensor_4[l].sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (ARH)";
								break;
							}
						}
					}
					return text + " terminal guidance";
				case Weapon.WeaponGuidanceType.Active:
					if (flag)
					{
						text += " mid-course plus ";
					}
					text += "Active";
					if (this.sensor_0.Length > 0)
					{
						Sensor[] sensor_5 = this.sensor_0;
						for (int m = 0; m < sensor_5.Length; m++)
						{
							if (sensor_5[m].sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (ARH)";
								break;
							}
						}
					}
					if (flag)
					{
						return text + " terminal guidance";
					}
					return text;
				case Weapon.WeaponGuidanceType.Datalink_Plus_Active:
					if (flag)
					{
						text += " and ";
					}
					if (this.method_167() == Weapon._WeaponType.GuidedWeapon)
					{
						text += "Datalink (DL/INS) mid-course plus Active";
					}
					else if (this.method_167() == Weapon._WeaponType.Torpedo)
					{
						text += "Wire-Guidance mid-course plus Active";
					}
					if (this.sensor_0.Length > 0)
					{
						foreach (Sensor sensor6 in this.sensor_0)
						{
							if (sensor6.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (ARH)";
							}
							else if (sensor6.sensor_Type_0 == Sensor.Sensor_Type.Infrared)
							{
								str = " with Infrared (IR) backup seeker";
							}
							else if (sensor6.sensor_Type_0 == Sensor.Sensor_Type.Visual)
							{
								str = " with Electro-Optical (EO) backup seeker";
							}
						}
					}
					return text + " terminal guidance" + str;
				case Weapon.WeaponGuidanceType.Inertial_Plus_Active:
					text = "Inertial (INS) mid-course plus Active";
					if (this.sensor_0.Length > 0)
					{
						foreach (Sensor sensor7 in this.sensor_0)
						{
							if (sensor7.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (ARH)";
							}
							else if (sensor7.sensor_Type_0 == Sensor.Sensor_Type.Infrared)
							{
								str = " with Infrared (IR) backup seeker";
							}
							else if (sensor7.sensor_Type_0 == Sensor.Sensor_Type.Visual)
							{
								str = " with Electro-Optical (EO) backup seeker";
							}
							else if (sensor7.sensor_Type_0 == Sensor.Sensor_Type.ESM && this.class394_0.bool_5)
							{
								str = " with anti-radar (ARM) backup seeker";
							}
						}
					}
					return text + " terminal guidance" + str;
				case Weapon.WeaponGuidanceType.CommandGuided_Datalinked:
					return "Command-Guided";
				case Weapon.WeaponGuidanceType.TVM:
					return "Track Via Missile (TVM)";
				case Weapon.WeaponGuidanceType.BeamRiding:
					return "Beam Riding";
				case Weapon.WeaponGuidanceType.Inertial:
					return "Inertially Guided";
				case Weapon.WeaponGuidanceType.SemiActive_Plus_Active:
					text = "Semi-Active (SARH) mid-course Plus Active";
					if (this.sensor_0.Length > 0)
					{
						Sensor[] sensor_8 = this.sensor_0;
						for (int num2 = 0; num2 < sensor_8.Length; num2++)
						{
							if (sensor_8[num2].sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (ARH)";
								break;
							}
						}
					}
					return text + " terminal guidance";
				case Weapon.WeaponGuidanceType.TimesharedSemiActive_Plus_Active:
					text = "Time-Shared Semi-Active (TSARH) mid-course Plus Active";
					if (this.sensor_0.Length > 0)
					{
						Sensor[] sensor_9 = this.sensor_0;
						for (int num3 = 0; num3 < sensor_9.Length; num3++)
						{
							if (sensor_9[num3].sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (ARH)";
								break;
							}
						}
					}
					return text + " terminal guidance";
				default:
					return text;
				}
				text = "Inertial (INS) mid-course plus Semi-Active";
				if (this.hashSet_0.Count > 0)
				{
					try
					{
						foreach (int int_3 in this.hashSet_0)
						{
							SQLiteConnection sqliteConnection = this.scenario_0.method_39();
							Sensor sensor8 = DBFunctions.smethod_97(int_3, ref sqliteConnection);
							if (sensor8.sensor_Type_0 == Sensor.Sensor_Type.Radar)
							{
								text += " Radar Homing (SARH)";
								break;
							}
							if (sensor8.sensor_Type_0 == Sensor.Sensor_Type.LaserDesignator)
							{
								text += " Laser Homing (SALH)";
								break;
							}
						}
					}
					finally
					{
						HashSet<int>.Enumerator enumerator3;
						enumerator3.Dispose();
					}
				}
				text += " terminal guidance";
				return text;
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x001F4C64 File Offset: 0x001F2E64
		public void method_275(Unit unit_0)
		{
			base.method_32(unit_0);
			double num = (double)base.method_36(unit_0);
			float num2 = base.method_54(unit_0);
			this.method_142(Math.Max(num2 * 2f, 15f));
			this.enum127_0 = Weapon.Enum127.const_2;
			Sensor[] sensor_ = this.sensor_0;
			checked
			{
				for (int i = 0; i < sensor_.Length; i++)
				{
					sensor_[i].method_44(null);
				}
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x001F4CD0 File Offset: 0x001F2ED0
		public bool method_276()
		{
			return this.method_219() || this.method_220() || (this.warhead_0.Length > 0 && this.warhead_0[0].warheadType_0 == Warhead.WarheadType.Weapon && this.warhead_0[0].method_17(this.scenario_0).method_204());
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x001F4D34 File Offset: 0x001F2F34
		public bool method_277()
		{
			Weapon.WeaponGuidanceType weaponGuidanceType = this.method_169();
			return weaponGuidanceType != Weapon.WeaponGuidanceType.Inertial;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x001F4D54 File Offset: 0x001F2F54
		public float? imethod_4()
		{
			float? result;
			try
			{
				int num = base.method_9(false, false, false);
				bool flag = num > 0;
				float num2;
				if (flag)
				{
					num2 = 18.288f;
				}
				else
				{
					num2 = 9.144f;
				}
				if (this.vmethod_141())
				{
					num2 = 1000f;
				}
				if (flag)
				{
					result = new float?((float)num + num2);
				}
				else
				{
					result = new float?(num2);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100891", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new float?(0f);
			}
			return result;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0000378C File Offset: 0x0000198C
		public void imethod_5(float? nullable_22)
		{
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x001F4DF8 File Offset: 0x001F2FF8
		public float method_278()
		{
			float result;
			try
			{
				Weapon._WeaponType weaponType_ = this._WeaponType_0;
				float num;
				if (weaponType_ <= Weapon._WeaponType.GuidedProjectile)
				{
					switch (weaponType_)
					{
					case Weapon._WeaponType.GuidedWeapon:
						goto IL_21C;
					case Weapon._WeaponType.Rocket:
						return (float)(0.5 * (double)this.int_0 * Math.Pow((double)300f, 2.0) / 100.0 / 15000.0);
					case Weapon._WeaponType.IronBomb:
						return (float)(0.5 * (double)this.int_0 * Math.Pow((double)200f, 2.0) / 100.0 / 15000.0);
					case Weapon._WeaponType.Gun:
						num = (float)((double)this.vmethod_40() * 0.514444);
						return (float)(0.5 * (double)this.int_0 * Math.Pow((double)num, 2.0) / 100.0 / 15000.0);
					default:
						if (weaponType_ == Weapon._WeaponType.GuidedProjectile)
						{
							num = (float)((double)this.vmethod_40() * 0.514444);
							return (float)(0.5 * (double)this.int_0 * Math.Pow((double)num, 2.0) / 100.0 / 15000.0);
						}
						break;
					}
				}
				else
				{
					if (weaponType_ == Weapon._WeaponType.Torpedo)
					{
						goto IL_21C;
					}
					if (weaponType_ == Weapon._WeaponType.HGV)
					{
						float num2 = (float)Math.Max(Math.Max(this.int_1, this.int_6), Math.Max(this.int_0, this.int_2));
						if (num2 == 0f && Enumerable.Any<Warhead>(this.warhead_0))
						{
							num2 = this.warhead_0[0].float_0;
						}
						num = (float)((double)this.vmethod_40() * 0.514444);
						return (float)(0.5 * (double)num2 * Math.Pow((double)num, 2.0) / 100.0 / 15000.0);
					}
				}
				return 0f;
				IL_21C:
				num = (float)((double)this.vmethod_40() * 0.514444);
				result = (float)(0.5 * (double)this.int_0 * Math.Pow((double)num, 2.0) / 100.0 / 15000.0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100979", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00007348 File Offset: 0x00005548
		[CompilerGenerated]
		private double method_279(Contact contact_0)
		{
			return base.method_31(contact_0);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00007348 File Offset: 0x00005548
		[CompilerGenerated]
		private double method_280(Contact contact_0)
		{
			return base.method_31(contact_0);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00007348 File Offset: 0x00005548
		[CompilerGenerated]
		private double method_281(Contact contact_0)
		{
			return base.method_31(contact_0);
		}

		// Token: 0x040017DF RID: 6111
		private Weapon._WeaponType _WeaponType_0;

		// Token: 0x040017E0 RID: 6112
		private GlobalVariables.TechGenerationClass techGenerationClass_0;

		// Token: 0x040017E1 RID: 6113
		public int int_6;

		// Token: 0x040017E2 RID: 6114
		public float float_25;

		// Token: 0x040017E3 RID: 6115
		public float float_26;

		// Token: 0x040017E4 RID: 6116
		public int int_7;

		// Token: 0x040017E5 RID: 6117
		private int int_8;

		// Token: 0x040017E6 RID: 6118
		public int int_9;

		// Token: 0x040017E7 RID: 6119
		private int int_10;

		// Token: 0x040017E8 RID: 6120
		public float float_27;

		// Token: 0x040017E9 RID: 6121
		private float float_28;

		// Token: 0x040017EA RID: 6122
		public int int_11;

		// Token: 0x040017EB RID: 6123
		public int int_12;

		// Token: 0x040017EC RID: 6124
		public int int_13;

		// Token: 0x040017ED RID: 6125
		public int int_14;

		// Token: 0x040017EE RID: 6126
		public int int_15;

		// Token: 0x040017EF RID: 6127
		public int int_16;

		// Token: 0x040017F0 RID: 6128
		public int int_17;

		// Token: 0x040017F1 RID: 6129
		public int int_18;

		// Token: 0x040017F2 RID: 6130
		public float float_29;

		// Token: 0x040017F3 RID: 6131
		public float float_30;

		// Token: 0x040017F4 RID: 6132
		public float float_31;

		// Token: 0x040017F5 RID: 6133
		public float float_32;

		// Token: 0x040017F6 RID: 6134
		public float float_33;

		// Token: 0x040017F7 RID: 6135
		public float float_34;

		// Token: 0x040017F8 RID: 6136
		public float float_35;

		// Token: 0x040017F9 RID: 6137
		public float float_36;

		// Token: 0x040017FA RID: 6138
		public float float_37;

		// Token: 0x040017FB RID: 6139
		public float float_38;

		// Token: 0x040017FC RID: 6140
		public float float_39;

		// Token: 0x040017FD RID: 6141
		public float float_40;

		// Token: 0x040017FE RID: 6142
		public float float_41;

		// Token: 0x040017FF RID: 6143
		public float float_42;

		// Token: 0x04001800 RID: 6144
		public float float_43;

		// Token: 0x04001801 RID: 6145
		public float float_44;

		// Token: 0x04001802 RID: 6146
		public float float_45;

		// Token: 0x04001803 RID: 6147
		public float float_46;

		// Token: 0x04001804 RID: 6148
		public int int_19;

		// Token: 0x04001805 RID: 6149
		public int int_20;

		// Token: 0x04001806 RID: 6150
		public float float_47;

		// Token: 0x04001807 RID: 6151
		public Class394 class394_0;

		// Token: 0x04001808 RID: 6152
		public Warhead[] warhead_0;

		// Token: 0x04001809 RID: 6153
		public HashSet<int> hashSet_0;

		// Token: 0x0400180A RID: 6154
		protected float float_48;

		// Token: 0x0400180B RID: 6155
		protected float float_49;

		// Token: 0x0400180C RID: 6156
		public Weapon.Struct36 struct36_0;

		// Token: 0x0400180D RID: 6157
		private ActiveUnit activeUnit_0;

		// Token: 0x0400180E RID: 6158
		protected string string_9;

		// Token: 0x0400180F RID: 6159
		private ActiveUnit activeUnit_1;

		// Token: 0x04001810 RID: 6160
		protected string string_10;

		// Token: 0x04001811 RID: 6161
		public Weapon.Enum127 enum127_0;

		// Token: 0x04001812 RID: 6162
		private Weapon.WeaponGuidanceType? nullable_16;

		// Token: 0x04001813 RID: 6163
		public GeoPoint geoPoint_0;

		// Token: 0x04001814 RID: 6164
		internal float float_50;

		// Token: 0x04001815 RID: 6165
		public bool bool_27;

		// Token: 0x04001816 RID: 6166
		private Sensor sensor_2;

		// Token: 0x04001817 RID: 6167
		protected string string_11;

		// Token: 0x04001818 RID: 6168
		public KeyValuePair<int, EmissionContainer> keyValuePair_0;

		// Token: 0x04001819 RID: 6169
		public bool bool_28;

		// Token: 0x0400181A RID: 6170
		internal bool bool_29;

		// Token: 0x0400181B RID: 6171
		internal bool bool_30;

		// Token: 0x0400181C RID: 6172
		[CompilerGenerated]
		[AccessedThroughProperty("WeaponWeapons")]
		private ObservableList<WeaponRec> observableList_2;

		// Token: 0x0400181D RID: 6173
		public List<Weapon.Enum130> list_3;

		// Token: 0x0400181E RID: 6174
		internal bool bool_31;

		// Token: 0x0400181F RID: 6175
		private float float_51;

		// Token: 0x04001820 RID: 6176
		protected Weapon_Navigator weapon_Navigator_0;

		// Token: 0x04001821 RID: 6177
		private Weapon_AI weapon_AI_0;

		// Token: 0x04001822 RID: 6178
		private Class203 class203_0;

		// Token: 0x04001823 RID: 6179
		private Class223 class223_0;

		// Token: 0x04001824 RID: 6180
		private Weapon_CommStuff weapon_CommStuff_0;

		// Token: 0x04001825 RID: 6181
		private Class188 class188_0;

		// Token: 0x04001826 RID: 6182
		protected ActiveUnit activeUnit_2;

		// Token: 0x04001827 RID: 6183
		[CompilerGenerated]
		private static Weapon.Delegate55 delegate55_0;

		// Token: 0x04001828 RID: 6184
		internal bool bool_32;

		// Token: 0x04001829 RID: 6185
		private bool? nullable_17;

		// Token: 0x0400182A RID: 6186
		private bool? nullable_18;

		// Token: 0x0400182B RID: 6187
		private bool? nullable_19;

		// Token: 0x0400182C RID: 6188
		private bool? nullable_20;

		// Token: 0x0400182D RID: 6189
		private bool? nullable_21;

		// Token: 0x0400182E RID: 6190
		private bool bool_33;

		// Token: 0x0200037E RID: 894
		// (Invoke) Token: 0x06001B7B RID: 7035
		internal delegate void Delegate55(Scenario theScen, Weapon theWeapon, Unit theTarget, bool DirectHit);

		// Token: 0x0200037F RID: 895
		public enum _WeaponType : short
		{
			// Token: 0x04001830 RID: 6192
			None = 1001,
			// Token: 0x04001831 RID: 6193
			GuidedWeapon = 2001,
			// Token: 0x04001832 RID: 6194
			Rocket,
			// Token: 0x04001833 RID: 6195
			IronBomb,
			// Token: 0x04001834 RID: 6196
			Gun,
			// Token: 0x04001835 RID: 6197
			Decoy_Expendable,
			// Token: 0x04001836 RID: 6198
			Decoy_Towed,
			// Token: 0x04001837 RID: 6199
			Decoy_Vehicle,
			// Token: 0x04001838 RID: 6200
			TrainingRound,
			// Token: 0x04001839 RID: 6201
			Dispenser,
			// Token: 0x0400183A RID: 6202
			ContactBomb_Suicide,
			// Token: 0x0400183B RID: 6203
			ContactBomb_Sabotage,
			// Token: 0x0400183C RID: 6204
			GuidedProjectile,
			// Token: 0x0400183D RID: 6205
			SensorPod = 3001,
			// Token: 0x0400183E RID: 6206
			DropTank,
			// Token: 0x0400183F RID: 6207
			BuddyStore,
			// Token: 0x04001840 RID: 6208
			FerryTank,
			// Token: 0x04001841 RID: 6209
			Torpedo = 4001,
			// Token: 0x04001842 RID: 6210
			DepthCharge,
			// Token: 0x04001843 RID: 6211
			Sonobuoy,
			// Token: 0x04001844 RID: 6212
			BottomMine,
			// Token: 0x04001845 RID: 6213
			MooredMine,
			// Token: 0x04001846 RID: 6214
			FloatingMine,
			// Token: 0x04001847 RID: 6215
			MovingMine,
			// Token: 0x04001848 RID: 6216
			RisingMine,
			// Token: 0x04001849 RID: 6217
			DriftingMine,
			// Token: 0x0400184A RID: 6218
			DummyMine = 4011,
			// Token: 0x0400184B RID: 6219
			HeliTowedPackage = 4101,
			// Token: 0x0400184C RID: 6220
			BallisticMissile = 5000,
			// Token: 0x0400184D RID: 6221
			RV,
			// Token: 0x0400184E RID: 6222
			Laser = 6001,
			// Token: 0x0400184F RID: 6223
			HGV = 8001,
			// Token: 0x04001850 RID: 6224
			Cargo = 9001,
			// Token: 0x04001851 RID: 6225
			Troops,
			// Token: 0x04001852 RID: 6226
			Paratroops
		}

		// Token: 0x02000380 RID: 896
		public enum WeaponGuidanceType : byte
		{
			// Token: 0x04001854 RID: 6228
			SemiActive,
			// Token: 0x04001855 RID: 6229
			Inertial_Plus_SemiActive,
			// Token: 0x04001856 RID: 6230
			Datalink_Plus_SemiActive,
			// Token: 0x04001857 RID: 6231
			Passive = 4,
			// Token: 0x04001858 RID: 6232
			Inertial_Plus_Passive,
			// Token: 0x04001859 RID: 6233
			DataLink_Plus_Passive,
			// Token: 0x0400185A RID: 6234
			Active,
			// Token: 0x0400185B RID: 6235
			Datalink_Plus_Active,
			// Token: 0x0400185C RID: 6236
			Inertial_Plus_Active,
			// Token: 0x0400185D RID: 6237
			CommandGuided_Datalinked,
			// Token: 0x0400185E RID: 6238
			TVM,
			// Token: 0x0400185F RID: 6239
			BeamRiding,
			// Token: 0x04001860 RID: 6240
			Inertial,
			// Token: 0x04001861 RID: 6241
			SemiActive_Plus_Active,
			// Token: 0x04001862 RID: 6242
			TimesharedSemiActive_Plus_Active
		}

		// Token: 0x02000381 RID: 897
		internal enum Enum127 : byte
		{
			// Token: 0x04001864 RID: 6244
			const_0,
			// Token: 0x04001865 RID: 6245
			const_1,
			// Token: 0x04001866 RID: 6246
			const_2
		}

		// Token: 0x02000382 RID: 898
		internal enum Enum128 : byte
		{
			// Token: 0x04001868 RID: 6248
			const_0,
			// Token: 0x04001869 RID: 6249
			const_1,
			// Token: 0x0400186A RID: 6250
			const_2,
			// Token: 0x0400186B RID: 6251
			const_3,
			// Token: 0x0400186C RID: 6252
			const_4
		}

		// Token: 0x02000383 RID: 899
		internal struct Struct36
		{
			// Token: 0x0400186D RID: 6253
			public bool bool_0;

			// Token: 0x0400186E RID: 6254
			public bool bool_1;

			// Token: 0x0400186F RID: 6255
			public bool bool_2;

			// Token: 0x04001870 RID: 6256
			public bool bool_3;

			// Token: 0x04001871 RID: 6257
			public bool bool_4;

			// Token: 0x04001872 RID: 6258
			public bool bool_5;

			// Token: 0x04001873 RID: 6259
			public bool bool_6;

			// Token: 0x04001874 RID: 6260
			public bool bool_7;

			// Token: 0x04001875 RID: 6261
			public bool bool_8;

			// Token: 0x04001876 RID: 6262
			public bool bool_9;

			// Token: 0x04001877 RID: 6263
			public bool bool_10;

			// Token: 0x04001878 RID: 6264
			public bool bool_11;

			// Token: 0x04001879 RID: 6265
			public bool bool_12;

			// Token: 0x0400187A RID: 6266
			public bool bool_13;

			// Token: 0x0400187B RID: 6267
			public bool bool_14;

			// Token: 0x0400187C RID: 6268
			public bool bool_15;

			// Token: 0x0400187D RID: 6269
			public bool bool_16;

			// Token: 0x0400187E RID: 6270
			public bool bool_17;

			// Token: 0x0400187F RID: 6271
			public bool bool_18;

			// Token: 0x04001880 RID: 6272
			public bool bool_19;

			// Token: 0x04001881 RID: 6273
			public bool bool_20;

			// Token: 0x04001882 RID: 6274
			public bool bool_21;

			// Token: 0x04001883 RID: 6275
			public bool bool_22;

			// Token: 0x04001884 RID: 6276
			public bool bool_23;

			// Token: 0x04001885 RID: 6277
			public bool bool_24;

			// Token: 0x04001886 RID: 6278
			public bool bool_25;

			// Token: 0x04001887 RID: 6279
			public bool bool_26;

			// Token: 0x04001888 RID: 6280
			public bool bool_27;

			// Token: 0x04001889 RID: 6281
			public bool bool_28;

			// Token: 0x0400188A RID: 6282
			public bool bool_29;

			// Token: 0x0400188B RID: 6283
			public bool bool_30;

			// Token: 0x0400188C RID: 6284
			public bool bool_31;

			// Token: 0x0400188D RID: 6285
			public bool bool_32;

			// Token: 0x0400188E RID: 6286
			public bool bool_33;

			// Token: 0x0400188F RID: 6287
			public bool bool_34;

			// Token: 0x04001890 RID: 6288
			public bool bool_35;

			// Token: 0x04001891 RID: 6289
			public bool bool_36;

			// Token: 0x04001892 RID: 6290
			public bool bool_37;

			// Token: 0x04001893 RID: 6291
			public bool bool_38;

			// Token: 0x04001894 RID: 6292
			public bool bool_39;

			// Token: 0x04001895 RID: 6293
			public bool bool_40;

			// Token: 0x04001896 RID: 6294
			public bool bool_41;

			// Token: 0x04001897 RID: 6295
			public bool bool_42;

			// Token: 0x04001898 RID: 6296
			public bool bool_43;

			// Token: 0x04001899 RID: 6297
			public bool bool_44;

			// Token: 0x0400189A RID: 6298
			public bool bool_45;

			// Token: 0x0400189B RID: 6299
			public bool bool_46;

			// Token: 0x0400189C RID: 6300
			public bool bool_47;

			// Token: 0x0400189D RID: 6301
			public bool bool_48;

			// Token: 0x0400189E RID: 6302
			public bool bool_49;

			// Token: 0x0400189F RID: 6303
			public bool bool_50;

			// Token: 0x040018A0 RID: 6304
			public bool bool_51;

			// Token: 0x040018A1 RID: 6305
			public bool bool_52;

			// Token: 0x040018A2 RID: 6306
			public bool bool_53;

			// Token: 0x040018A3 RID: 6307
			public bool bool_54;

			// Token: 0x040018A4 RID: 6308
			public bool bool_55;

			// Token: 0x040018A5 RID: 6309
			public bool bool_56;

			// Token: 0x040018A6 RID: 6310
			public bool bool_57;

			// Token: 0x040018A7 RID: 6311
			public Weapon.Struct36.Enum129 enum129_0;

			// Token: 0x02000384 RID: 900
			internal enum Enum129
			{
				// Token: 0x040018A9 RID: 6313
				const_0,
				// Token: 0x040018AA RID: 6314
				const_1,
				// Token: 0x040018AB RID: 6315
				const_2,
				// Token: 0x040018AC RID: 6316
				const_3
			}
		}

		// Token: 0x02000385 RID: 901
		internal enum Enum130
		{
			// Token: 0x040018AE RID: 6318
			const_0,
			// Token: 0x040018AF RID: 6319
			const_1
		}

		// Token: 0x02000387 RID: 903
		[CompilerGenerated]
		internal sealed class Class395
		{
			// Token: 0x06001B86 RID: 7046 RVA: 0x0000DC17 File Offset: 0x0000BE17
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.vmethod_86().vmethod_3() == this.contact_0 && ((Weapon)activeUnit_0).keyValuePair_0.Key == this.int_0;
			}

			// Token: 0x040018B8 RID: 6328
			public Contact contact_0;

			// Token: 0x040018B9 RID: 6329
			public int int_0;
		}

		// Token: 0x02000388 RID: 904
		[CompilerGenerated]
		internal sealed class Class396
		{
			// Token: 0x06001B87 RID: 7047 RVA: 0x0000DC46 File Offset: 0x0000BE46
			public Class396(Weapon.Class396 class396_0)
			{
				if (class396_0 != null)
				{
					this.side_0 = class396_0.side_0;
					this.contact_0 = class396_0.contact_0;
				}
			}

			// Token: 0x06001B88 RID: 7048 RVA: 0x0000DC69 File Offset: 0x0000BE69
			internal int method_0(int int_0)
			{
				return this.weapon_0.method_216(this.side_0, this.contact_0, int_0);
			}

			// Token: 0x040018BA RID: 6330
			public Side side_0;

			// Token: 0x040018BB RID: 6331
			public Contact contact_0;

			// Token: 0x040018BC RID: 6332
			public Weapon weapon_0;
		}

		// Token: 0x02000389 RID: 905
		[CompilerGenerated]
		internal sealed class Class397
		{
			// Token: 0x06001B8A RID: 7050 RVA: 0x001F50CC File Offset: 0x001F32CC
			internal bool method_0(ActiveUnit activeUnit_0)
			{
				ActiveUnit_Sensory activeUnit_Sensory = activeUnit_0.vmethod_88();
				Contact contact = this.contact_0;
				Weapon weapon = this.weapon_0;
				bool? flag = null;
				bool? flag2 = null;
				Unit.Enum123? @enum = null;
				bool? flag3 = null;
				return activeUnit_Sensory.method_41(contact, weapon, ref this.sensor_0, ref flag, ref flag2, ref @enum, ref flag3);
			}

			// Token: 0x06001B8B RID: 7051 RVA: 0x001F5120 File Offset: 0x001F3320
			internal double method_1(ActiveUnit activeUnit_0)
			{
				return activeUnit_0.method_28(new GeoPoint(this.contact_0.vmethod_28(null), this.contact_0.vmethod_30(null)));
			}

			// Token: 0x040018BD RID: 6333
			public Contact contact_0;

			// Token: 0x040018BE RID: 6334
			public Sensor sensor_0;

			// Token: 0x040018BF RID: 6335
			public Weapon weapon_0;
		}
	}
}
