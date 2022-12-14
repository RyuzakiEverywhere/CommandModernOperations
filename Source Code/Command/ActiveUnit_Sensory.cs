using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Spatial.Euclidean;
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
	// Token: 0x02000165 RID: 357
	public class ActiveUnit_Sensory
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x00007FF9 File Offset: 0x000061F9
		[CompilerGenerated]
		protected virtual ObservableDictionary<string, ActiveUnit_Sensory.Class311> vmethod_0()
		{
			return this.observableDictionary_0;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000AFF38 File Offset: 0x000AE138
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		protected virtual void vmethod_1(ObservableDictionary<string, ActiveUnit_Sensory.Class311> observableDictionary_2)
		{
			INotifyDictionaryChanged<string, ActiveUnit_Sensory.Class311>.DictionaryChangedEventHandler obj = new INotifyDictionaryChanged<string, ActiveUnit_Sensory.Class311>.DictionaryChangedEventHandler(this.method_66);
			ObservableDictionary<string, ActiveUnit_Sensory.Class311> observableDictionary = this.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged -= obj;
			}
			this.observableDictionary_0 = observableDictionary_2;
			observableDictionary = this.observableDictionary_0;
			if (observableDictionary != null)
			{
				observableDictionary.DictionaryChanged += obj;
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000AFF7C File Offset: 0x000AE17C
		[CompilerGenerated]
		public static void smethod_0(ActiveUnit_Sensory.Delegate21 delegate21_1)
		{
			ActiveUnit_Sensory.Delegate21 @delegate = ActiveUnit_Sensory.delegate21_0;
			ActiveUnit_Sensory.Delegate21 delegate2;
			do
			{
				delegate2 = @delegate;
				ActiveUnit_Sensory.Delegate21 value = (ActiveUnit_Sensory.Delegate21)Delegate.Combine(delegate2, delegate21_1);
				@delegate = Interlocked.CompareExchange<ActiveUnit_Sensory.Delegate21>(ref ActiveUnit_Sensory.delegate21_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000AFFB0 File Offset: 0x000AE1B0
		public virtual void vmethod_2(ref XmlWriter xmlWriter_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Sensory");
				xmlWriter_0.WriteElementString("ObE", this.bool_0.ToString());
				if (this.vmethod_0().Count > 0)
				{
					xmlWriter_0.WriteStartElement("ContactList_Local");
					try
					{
						foreach (ActiveUnit_Sensory.Class311 @class in this.vmethod_0().Values)
						{
							if (!Information.IsNothing(@class.contact_0) && !Information.IsNothing(@class.contact_0.activeUnit_0))
							{
								@class.method_8(ref xmlWriter_0, this.activeUnit_0.vmethod_7(false));
							}
						}
					}
					finally
					{
						IEnumerator<ActiveUnit_Sensory.Class311> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					xmlWriter_0.WriteEndElement();
				}
				if (this.dictionary_0.Count > 0)
				{
					xmlWriter_0.WriteStartElement("ContactList_OffGrid");
					List<Contact> list = Enumerable.ToList<Contact>(this.dictionary_0.Values);
					try
					{
						foreach (Contact contact in list)
						{
							if (!Information.IsNothing(contact.activeUnit_0))
							{
								xmlWriter_0.WriteRaw(contact.method_61(null));
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					xmlWriter_0.WriteEndElement();
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100234", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000B0168 File Offset: 0x000AE368
		public static ActiveUnit_Sensory smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_2, ref ActiveUnit activeUnit_1)
		{
			ActiveUnit_Sensory result;
			try
			{
				ActiveUnit_Sensory activeUnit_Sensory = new ActiveUnit_Sensory();
				activeUnit_Sensory.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ObeysEMCON", false) != 0 && Operators.CompareString(name, "ObE", false) != 0)
						{
							if (Operators.CompareString(name, "ContactList", false) != 0 && Operators.CompareString(name, "ContactList_Local", false) != 0)
							{
								if (Operators.CompareString(name, "ContactList_OffGrid", false) != 0)
								{
									continue;
								}
								try
								{
									foreach (object obj2 in xmlNode.ChildNodes)
									{
										XmlNode xmlNode2 = (XmlNode)obj2;
										Contact contact = Contact.smethod_1(ref xmlNode2, ref dictionary_2);
										activeUnit_Sensory.dictionary_0.Add(contact.string_6, contact);
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
							try
							{
								foreach (object obj3 in xmlNode.ChildNodes)
								{
									XmlNode xmlNode3 = (XmlNode)obj3;
									string text;
									ActiveUnit_Sensory.Class311 value = ActiveUnit_Sensory.Class311.smethod_0(ref xmlNode3, ref dictionary_2, ref text);
									if (!Information.IsNothing(text) && !activeUnit_Sensory.vmethod_0().ContainsKey(text))
									{
										activeUnit_Sensory.vmethod_0().Add(text, value);
									}
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
						activeUnit_Sensory.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
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
				result = activeUnit_Sensory;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100235", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ActiveUnit_Sensory();
			}
			return result;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000B03AC File Offset: 0x000AE5AC
		public List<Contact> method_0()
		{
			List<Contact> result;
			if (this.activeUnit_0.vmethod_90().vmethod_1())
			{
				result = this.activeUnit_0.vmethod_7(false).method_44();
			}
			else
			{
				result = this.activeUnit_0.vmethod_88().method_6();
			}
			return result;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000B03F4 File Offset: 0x000AE5F4
		public bool method_1(Contact contact_0, float float_0, ActiveUnit_Sensory.Enum34 enum34_0)
		{
			bool result;
			try
			{
				try
				{
					foreach (ActiveUnit_Sensory.Class311 @class in this.vmethod_0().Values)
					{
						if (Operators.CompareString(@class.contact_0.activeUnit_0.string_0, contact_0.activeUnit_0.string_0, false) == 0)
						{
							switch (enum34_0)
							{
							case ActiveUnit_Sensory.Enum34.const_0:
								if (@class.float_0 <= float_0)
								{
									return true;
								}
								return false;
							case ActiveUnit_Sensory.Enum34.const_1:
							{
								if (@class.nullable_0 == null)
								{
									return false;
								}
								float? num = @class.nullable_0;
								if (((num != null) ? new bool?(num.GetValueOrDefault() <= float_0) : null).GetValueOrDefault())
								{
									return true;
								}
								return false;
							}
							case ActiveUnit_Sensory.Enum34.const_2:
							{
								if (@class.nullable_1 == null)
								{
									return false;
								}
								float? num = @class.nullable_1;
								if (((num != null) ? new bool?(num.GetValueOrDefault() <= float_0) : null).GetValueOrDefault())
								{
									return true;
								}
								return false;
							}
							default:
								if (!Debugger.IsAttached)
								{
									throw new NotImplementedException();
								}
								Debugger.Break();
								break;
							case ActiveUnit_Sensory.Enum34.const_4:
							{
								if (@class.nullable_3 == null)
								{
									return false;
								}
								float? num = @class.nullable_3;
								if (((num != null) ? new bool?(num.GetValueOrDefault() <= float_0) : null).GetValueOrDefault())
								{
									return true;
								}
								return false;
							}
							case ActiveUnit_Sensory.Enum34.const_5:
							{
								if (@class.nullable_4 == null)
								{
									return false;
								}
								float? num = @class.nullable_4;
								if (((num != null) ? new bool?(num.GetValueOrDefault() <= float_0) : null).GetValueOrDefault())
								{
									return true;
								}
								return false;
							}
							case ActiveUnit_Sensory.Enum34.const_6:
							{
								if (@class.nullable_5 == null)
								{
									return false;
								}
								float? num = @class.nullable_5;
								if (((num != null) ? new bool?(num.GetValueOrDefault() <= float_0) : null).GetValueOrDefault())
								{
									return true;
								}
								return false;
							}
							}
						}
					}
				}
				finally
				{
					IEnumerator<ActiveUnit_Sensory.Class311> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00008001 File Offset: 0x00006201
		public virtual bool vmethod_3()
		{
			return this.bool_0;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00008009 File Offset: 0x00006209
		public virtual void vmethod_4(bool bool_1)
		{
			this.bool_0 = bool_1;
			if (bool_1)
			{
				this.vmethod_5(this.activeUnit_0.method_78());
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000B06B0 File Offset: 0x000AE8B0
		public bool method_2()
		{
			bool result;
			try
			{
				foreach (Sensor sensor in this.activeUnit_0.method_78())
				{
					if (sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor.method_73())
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100236", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000B0740 File Offset: 0x000AE940
		private ActiveUnit_Sensory()
		{
			this.list_0 = new List<Contact>();
			this.lazy_0 = new Lazy<ConcurrentDictionary<long, LoggedMessage>>();
			this.lazy_1 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_2 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_Sensory.Class311>());
			this.dictionary_0 = new Dictionary<string, Contact>();
			this.list_1 = new List<string>();
			this.hashSet_0 = new HashSet<ActiveUnit>();
			this.dictionary_1 = new Dictionary<bool, List<ActiveUnit>>();
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00008026 File Offset: 0x00006226
		internal void method_3()
		{
			this.vmethod_0().Clear();
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000B07B8 File Offset: 0x000AE9B8
		internal void method_4()
		{
			try
			{
				foreach (Contact contact in this.activeUnit_0.vmethod_7(false).method_44())
				{
					if (!Information.IsNothing(contact.activeUnit_0))
					{
						Contact contact2 = contact.method_141();
						contact2.method_97(0f);
						contact2.method_99(0f);
						this.dictionary_0.Add(contact2.activeUnit_0.string_0, contact2);
					}
				}
			}
			finally
			{
				List<Contact>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000B0850 File Offset: 0x000AEA50
		public void method_5()
		{
			this.activeUnit_0.method_124(this.activeUnit_0.Name + " has rejoined the communications network.", "Communication issue", LoggedMessage.MessageType.DockingOps, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
			try
			{
				foreach (KeyValuePair<string, Contact> keyValuePair in this.dictionary_0)
				{
					if (keyValuePair.Value.activeUnit_0 != null)
					{
						if (!Information.IsNothing(keyValuePair.Value.activeUnit_0.vmethod_7(false)))
						{
							Side side = keyValuePair.Value.activeUnit_0.vmethod_7(false);
							if (side == this.activeUnit_0.vmethod_7(false))
							{
								this.activeUnit_0.vmethod_86().vmethod_15(keyValuePair.Value, true);
							}
							else if (side.method_68(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Friendly)
							{
								this.activeUnit_0.vmethod_86().vmethod_15(keyValuePair.Value, true);
							}
							else if (this.activeUnit_0.vmethod_7(false).method_11().ContainsKey(keyValuePair.Key))
							{
								this.activeUnit_0.vmethod_7(false).method_59(this.activeUnit_0.vmethod_7(false).method_11()[keyValuePair.Key], keyValuePair.Value, this.activeUnit_0, this.activeUnit_0.scenario_0, true);
							}
							else
							{
								this.activeUnit_0.method_124("NEW DELAYED CONTACT: " + keyValuePair.Value.Name, "Contact report", LoggedMessage.MessageType.ContactChange, 0, false, new Geopoint_Struct(keyValuePair.Value.vmethod_28(null), keyValuePair.Value.vmethod_30(null)));
								this.activeUnit_0.vmethod_7(false).method_13(keyValuePair.Value);
								keyValuePair.Value.method_129(this.activeUnit_0.vmethod_7(false), false);
							}
						}
						else
						{
							this.activeUnit_0.vmethod_86().vmethod_15(keyValuePair.Value, true);
						}
					}
					else
					{
						this.activeUnit_0.vmethod_86().vmethod_15(keyValuePair.Value, true);
					}
				}
			}
			finally
			{
				Dictionary<string, Contact>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.dictionary_0.Clear();
			List<Contact> list = new List<Contact>();
			try
			{
				foreach (Contact contact in this.activeUnit_0.vmethod_7(false).method_44())
				{
					if (!Information.IsNothing(contact.activeUnit_0) && contact.activeUnit_0 == this.activeUnit_0)
					{
						list.Add(contact);
					}
				}
			}
			finally
			{
				List<Contact>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			try
			{
				foreach (Contact contact_ in list)
				{
					this.activeUnit_0.vmethod_7(false).method_15(contact_, ref this.activeUnit_0.scenario_0, false);
				}
			}
			finally
			{
				List<Contact>.Enumerator enumerator3;
				((IDisposable)enumerator3).Dispose();
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000B0BBC File Offset: 0x000AEDBC
		private List<Contact> method_6()
		{
			List<Contact> result;
			if (this.dictionary_0.Count == 0)
			{
				result = new List<Contact>();
			}
			else
			{
				result = Enumerable.ToList<Contact>(this.dictionary_0.Values);
			}
			return result;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000B0BF0 File Offset: 0x000AEDF0
		public virtual void vmethod_5(Sensor[] sensor_0)
		{
			try
			{
				if (!this.activeUnit_0.bool_1)
				{
					if (this.activeUnit_0.method_1())
					{
						foreach (Sensor sensor in sensor_0)
						{
							if (sensor.method_58())
							{
								sensor.method_77();
							}
						}
					}
					else
					{
						if (this.activeUnit_0.bool_2 && ((Weapon)this.activeUnit_0).method_208())
						{
							foreach (Sensor sensor2 in sensor_0)
							{
								if (sensor2.method_72() && !sensor2.method_43())
								{
									sensor2.method_77();
								}
							}
						}
						if (this.vmethod_3())
						{
							Doctrine.Class275 @class = this.activeUnit_0.doctrine_0.method_6(this.activeUnit_0.scenario_0);
							bool bool_ = false;
							if (@class.method_0() && !Information.IsNothing(this.activeUnit_0.vmethod_101()))
							{
								if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Patrol)
								{
									if (((Class343)this.activeUnit_0.vmethod_101()).bool_25)
									{
										Class343 class2 = (Class343)this.activeUnit_0.vmethod_101();
										if (this.activeUnit_0.bool_3)
										{
											if (!this.activeUnit_0.vmethod_85().method_40(ref class2.list_5, ref class2.list_12, ref class2.list_8, 5, true, false) && !this.activeUnit_0.vmethod_85().method_40(ref class2.list_15, ref class2.list_20, ref class2.list_18, 5, true, true))
											{
												bool_ = true;
											}
										}
										else if (!this.activeUnit_0.vmethod_85().method_40(ref class2.list_5, ref class2.list_11, ref class2.list_7, 2, true, false) && !this.activeUnit_0.vmethod_85().method_40(ref class2.list_15, ref class2.list_19, ref class2.list_17, 2, true, true))
										{
											bool_ = true;
										}
									}
								}
								else if (this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.Support && ((Class344)this.activeUnit_0.vmethod_101()).bool_27 && this.activeUnit_0.vmethod_85().method_15())
								{
									bool_ = true;
								}
							}
							int num = Enumerable.Count<Sensor>(sensor_0) - 1;
							Sensor sensor_;
							for (int k = 0; k <= num; k++)
							{
								try
								{
									sensor_ = sensor_0[k];
								}
								catch (Exception ex)
								{
									ex.Data.Add("Error at 200429", ex.Message);
									GameGeneral.smethod_25(ref ex);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
								this.method_7(sensor_, @class, bool_);
							}
							if (this.activeUnit_0.vmethod_59())
							{
								IEnumerable<Sensor> enumerable = this.activeUnit_0.vmethod_95();
								if (Enumerable.Count<Sensor>(enumerable) > 0)
								{
									int num2 = Enumerable.Count<Sensor>(enumerable) - 1;
									for (int l = 0; l <= num2; l++)
									{
										try
										{
											sensor_ = Enumerable.ElementAtOrDefault<Sensor>(enumerable, l);
										}
										catch (Exception ex2)
										{
											ex2.Data.Add("Error at 200430", ex2.Message);
											GameGeneral.smethod_25(ref ex2);
											if (Debugger.IsAttached)
											{
												Debugger.Break();
											}
										}
										this.method_7(sensor_, @class, bool_);
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100237", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000B0FB0 File Offset: 0x000AF1B0
		private void method_7(Sensor sensor_0, Doctrine.Class275 class275_0, bool bool_1)
		{
			if (sensor_0 != null && sensor_0.method_58())
			{
				try
				{
					if (sensor_0.method_49())
					{
						if (sensor_0.list_1.Count == 0)
						{
							sensor_0.method_78();
						}
					}
					else if (sensor_0.method_41().Count <= 0)
					{
						bool flag;
						if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.Radar)
						{
							if (class275_0.method_1() == Doctrine.Class275.Enum66.const_1 && !bool_1)
							{
								flag = true;
							}
							else if (sensor_0.method_41().Count == 0)
							{
								flag = false;
							}
							if (!flag && this.activeUnit_0.vmethod_108() == ActiveUnit._ActiveUnitStatus.EngagedOffensive)
							{
								ActiveUnit_Weaponry activeUnit_Weaponry = this.activeUnit_0.vmethod_89();
								Contact contact_ = this.activeUnit_0.vmethod_86().vmethod_3();
								Doctrine._GunStrafeGroundTargets? gunStrafeGroundTargets = null;
								List<Weapon> list = activeUnit_Weaponry.method_13(contact_, ref gunStrafeGroundTargets);
								try
								{
									foreach (Weapon weapon in list)
									{
										ActiveUnit_Weaponry activeUnit_Weaponry2 = this.activeUnit_0.vmethod_89();
										Weapon theWeapon = weapon;
										Contact theTarget = this.activeUnit_0.vmethod_86().vmethod_3();
										short? num = null;
										bool manualFire = false;
										bool ignoreAircraftOrientation = false;
										Mount theMount = null;
										Sensor sensor = null;
										if (activeUnit_Weaponry2.method_23(theWeapon, theTarget, ref num, manualFire, ignoreAircraftOrientation, theMount, ref sensor).Item2 == ActiveUnit_Weaponry.Enum36.const_1)
										{
											flag = true;
											break;
										}
									}
								}
								finally
								{
									List<Weapon>.Enumerator enumerator;
									((IDisposable)enumerator).Dispose();
								}
							}
							if (!flag)
							{
								foreach (Class312 @class in this.activeUnit_0.vmethod_90().method_2())
								{
									if (@class.activeUnit_0.bool_2)
									{
										Weapon weapon2 = (Weapon)@class.activeUnit_0;
										if (weapon2.method_199() && weapon2.method_226())
										{
											flag = true;
											break;
										}
									}
								}
							}
						}
						if (sensor_0.method_72())
						{
							flag = (class275_0.method_3() == Doctrine.Class275.Enum66.const_1 && !bool_1);
						}
						bool flag2 = this.activeUnit_0.vmethod_59();
						if (!flag2 && sensor_0.method_74() && sensor_0.method_58())
						{
							flag = ((sensor_0.sensor_Type_0 == Sensor.Sensor_Type.DippingSonar_ActiveOnly && this.activeUnit_0.bool_3 && ((Aircraft)this.activeUnit_0).method_164().method_36() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar) || (class275_0.method_2() == Doctrine.Class275.Enum66.const_1 && !bool_1));
						}
						if (flag2 && this.activeUnit_0.vmethod_101() != null && this.activeUnit_0.vmethod_101()._MissionClass_0 == Mission._MissionClass.MineClearing)
						{
							Class341 class2 = (Class341)this.activeUnit_0.vmethod_101();
							if (this.activeUnit_0.vmethod_85().method_40(ref class2.list_5, ref class2.list_12, ref class2.list_8, 5, false, false))
							{
								if (this.activeUnit_0.bool_3 && (this.activeUnit_0.vmethod_14(false) > 76.5048f || this.activeUnit_0.vmethod_40() > 30f))
								{
									flag = false;
								}
								else if ((sensor_0.method_65() || sensor_0.method_70()) && sensor_0.method_58())
								{
									flag = true;
								}
							}
						}
						if (flag)
						{
							sensor_0.method_77();
						}
						else if (sensor_0.method_43())
						{
							sensor_0.method_78();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200431", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000B1304 File Offset: 0x000AF504
		public bool method_8(Sensor[] sensor_0)
		{
			checked
			{
				bool result;
				try
				{
					if (Information.IsNothing(sensor_0))
					{
						sensor_0 = this.activeUnit_0.method_78();
					}
					if (sensor_0.Length == 0)
					{
						result = false;
					}
					else
					{
						Sensor[] array = sensor_0;
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].method_64())
							{
								return true;
							}
						}
						result = false;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100238", "");
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

		// Token: 0x06000A56 RID: 2646 RVA: 0x000B139C File Offset: 0x000AF59C
		public bool method_9()
		{
			bool result;
			try
			{
				if (this.activeUnit_0.method_1())
				{
					result = false;
				}
				else if (this.activeUnit_0.bool_5 && Math.Round((double)this.activeUnit_0.vmethod_14(false)) < -20.0)
				{
					result = false;
				}
				else
				{
					new HashSet<ActiveUnit>();
					Sensor[] array = this.activeUnit_0.method_78();
					if (!Information.IsNothing(array))
					{
						bool flag = false;
						int num = array.Length - 1;
						int i = 0;
						while (i <= num)
						{
							Sensor sensor = array[i];
							if (sensor.sensor_Type_0 != Sensor.Sensor_Type.Radar || !sensor.method_43())
							{
								i++;
							}
							else
							{
								flag = true;
								IL_A0:
								if (!flag)
								{
									return false;
								}
								foreach (Side side in this.activeUnit_0.scenario_0.method_44())
								{
									if (side != this.activeUnit_0.vmethod_7(false) && !this.activeUnit_0.vmethod_7(false).method_67(side))
									{
										int k = side.method_41(false).Count - 1;
										while (k >= 0)
										{
											ActiveUnit activeUnit_;
											try
											{
												activeUnit_ = side.method_41(false)[k];
											}
											catch (Exception ex)
											{
												ex.Data.Add("Error at 200432", ex.Message);
												GameGeneral.smethod_25(ref ex);
												if (Debugger.IsAttached)
												{
													Debugger.Break();
												}
												goto IL_15E;
											}
											goto IL_154;
											IL_15E:
											k += -1;
											continue;
											IL_154:
											if (!this.method_11(activeUnit_))
											{
												goto IL_15E;
											}
											return true;
										}
									}
								}
								return false;
							}
						}
						goto IL_A0;
					}
					result = false;
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100239", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000B159C File Offset: 0x000AF79C
		public List<ActiveUnit> method_10(bool bool_1)
		{
			List<ActiveUnit> result;
			try
			{
				if (this.activeUnit_0.bool_2 && ((Weapon)this.activeUnit_0).struct36_0.bool_3)
				{
					result = new List<ActiveUnit>();
				}
				else if (!this.dictionary_1.ContainsKey(bool_1))
				{
					HashSet<ActiveUnit> hashSet = new HashSet<ActiveUnit>();
					List<ActiveUnit> list = new List<ActiveUnit>();
					if (bool_1)
					{
						Sensor[] array = this.activeUnit_0.method_78();
						bool flag = false;
						int num = array.Length - 1;
						int i = 0;
						while (i <= num)
						{
							Sensor sensor = array[i];
							if (sensor.sensor_Type_0 != Sensor.Sensor_Type.Radar || !sensor.method_43())
							{
								i++;
							}
							else
							{
								flag = true;
								IL_9E:
								if (!flag)
								{
									list = Enumerable.ToList<ActiveUnit>(hashSet);
									try
									{
										this.dictionary_1.Add(bool_1, list);
									}
									catch (Exception ex)
									{
										ex.Data.Add("Error at 200433", ex.Message);
										GameGeneral.smethod_25(ref ex);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
									return list;
								}
								goto IL_F9;
							}
						}
						goto IL_9E;
					}
					IL_F9:
					foreach (Side side in this.activeUnit_0.scenario_0.method_44())
					{
						if (!Information.IsNothing(side) && !Information.IsNothing(this.activeUnit_0.vmethod_7(false)) && side != this.activeUnit_0.vmethod_7(false) && !this.activeUnit_0.vmethod_7(false).method_67(side))
						{
							for (int k = side.method_41(false).Count - 1; k >= 0; k += -1)
							{
								ActiveUnit activeUnit = side.method_41(false)[k];
								if (this.method_11(activeUnit))
								{
									hashSet.Add(activeUnit);
								}
							}
						}
					}
					list = Enumerable.ToList<ActiveUnit>(hashSet);
					try
					{
						if (!this.dictionary_1.ContainsKey(bool_1))
						{
							this.dictionary_1.Add(bool_1, list);
						}
					}
					catch (Exception ex2)
					{
						ex2.Data.Add("Error at 200434", ex2.Message);
						GameGeneral.smethod_25(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					result = list;
				}
				else
				{
					result = this.dictionary_1[bool_1];
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100240", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit>();
			}
			return result;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000B1854 File Offset: 0x000AFA54
		private bool method_11(ActiveUnit activeUnit_1)
		{
			bool result;
			if (Information.IsNothing(activeUnit_1))
			{
				result = false;
			}
			else
			{
				try
				{
					bool flag = false;
					Sensor[] array = activeUnit_1.method_78();
					bool flag2 = false;
					for (int i = array.Length - 1; i >= 0; i += -1)
					{
						Sensor sensor = array[i];
						if (sensor.method_72())
						{
							if (sensor.method_67())
							{
								flag2 = true;
							}
							if (sensor.method_43() && sensor.method_20(this.activeUnit_0, null))
							{
								int j = this.activeUnit_0.method_78().Length - 1;
								while (j >= 0)
								{
									Sensor sensor2 = this.activeUnit_0.method_78()[j];
									if (!sensor2.method_20(activeUnit_1, null) || !sensor.method_33(sensor2))
									{
										j += -1;
									}
									else
									{
										flag = true;
										IL_B7:
										if (!flag)
										{
											goto IL_BA;
										}
										goto IL_C8;
									}
								}
								goto IL_B7;
							}
						}
						IL_BA:;
					}
					IL_C8:
					if (!flag)
					{
						result = false;
					}
					else if (!flag2 && !this.activeUnit_0.method_42(activeUnit_1, ref this.activeUnit_0.scenario_0, false))
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
					ex.Data.Add("Error at 200352", ex.Message);
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

		// Token: 0x06000A59 RID: 2649 RVA: 0x000B19A4 File Offset: 0x000AFBA4
		public ActiveUnit_Sensory(ref ActiveUnit activeUnit_1)
		{
			this.list_0 = new List<Contact>();
			this.lazy_0 = new Lazy<ConcurrentDictionary<long, LoggedMessage>>();
			this.lazy_1 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.lazy_2 = new Lazy<ConcurrentDictionary<string, Contact>>();
			this.vmethod_1(new ObservableDictionary<string, ActiveUnit_Sensory.Class311>());
			this.dictionary_0 = new Dictionary<string, Contact>();
			this.list_1 = new List<string>();
			this.hashSet_0 = new HashSet<ActiveUnit>();
			this.dictionary_1 = new Dictionary<bool, List<ActiveUnit>>();
			this.activeUnit_0 = activeUnit_1;
			this.bool_0 = true;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000B1A2C File Offset: 0x000AFC2C
		public bool method_12()
		{
			foreach (Sensor sensor in this.activeUnit_0.method_78())
			{
				if (sensor.method_72() && sensor.method_43())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000B1A70 File Offset: 0x000AFC70
		private Sensor[] method_13(Sensor[] sensor_0)
		{
			Sensor[] result;
			if (sensor_0.Length == 0)
			{
				result = new Sensor[0];
			}
			else
			{
				List<Sensor> list = new List<Sensor>(sensor_0.Length);
				foreach (Sensor sensor in sensor_0)
				{
					if (sensor.method_55() && this.method_15(sensor))
					{
						list.Add(sensor);
					}
				}
				int count = list.Count;
				if (count == 0)
				{
					result = new Sensor[0];
				}
				else
				{
					Sensor[] array = new Sensor[count - 1 + 1];
					int num = count - 1;
					for (int j = 0; j <= num; j++)
					{
						array[j] = list[j];
					}
					result = array;
				}
			}
			return result;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00008033 File Offset: 0x00006233
		private Sensor[] method_14(Sensor[] sensor_0)
		{
			return Enumerable.ToArray<Sensor>(Enumerable.Where<Sensor>(sensor_0, (ActiveUnit_Sensory._Closure$__.$I55-0 == null) ? (ActiveUnit_Sensory._Closure$__.$I55-0 = new Func<Sensor, bool>(ActiveUnit_Sensory._Closure$__.$I.method_0)) : ActiveUnit_Sensory._Closure$__.$I55-0));
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000B1B14 File Offset: 0x000AFD14
		private bool method_15(Sensor sensor_0)
		{
			return sensor_0.method_64() && (!sensor_0.method_46() || sensor_0.method_43()) && sensor_0.method_24();
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000B1B50 File Offset: 0x000AFD50
		private bool method_16(Sensor sensor_0)
		{
			return sensor_0.method_25();
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00008064 File Offset: 0x00006264
		public virtual void vmethod_6(ref ActiveUnit activeUnit_1, ref Side side_0)
		{
			this.vmethod_11(activeUnit_1, side_0);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000B1B6C File Offset: 0x000AFD6C
		public virtual void vmethod_7(Sensor[] sensor_0, ActiveUnit[] activeUnit_1, float float_0)
		{
			checked
			{
				if (!this.activeUnit_0.bool_1 && !Information.IsNothing(this.activeUnit_0))
				{
					try
					{
						if (this.activeUnit_0.vmethod_7(false).method_28() != Side.AwarenessLevel_Enum.Blind)
						{
							if (this.activeUnit_0.method_78().Length != 0 || this.activeUnit_0.vmethod_51().Count <= 0)
							{
								if (this.activeUnit_0.method_128(this.activeUnit_0.scenario_0))
								{
									foreach (Sensor sensor in this.activeUnit_0.vmethod_96())
									{
										if (sensor.sensor_Type_0 == Sensor.Sensor_Type.ESM || sensor.sensor_Type_0 == Sensor.Sensor_Type.Infrared || sensor.sensor_Type_0 == Sensor.Sensor_Type.Visual || sensor.sensor_Type_0 == Sensor.Sensor_Type.PingIntercept)
										{
											sensor.int_2 = 0;
											sensor.int_3 = 0;
										}
										if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
										{
											sensor.int_3 = 0;
										}
									}
								}
								if (this.method_8(sensor_0))
								{
									Sensor[] array2 = this.method_13(sensor_0);
									Sensor[] array3 = this.method_14(sensor_0);
									if (array2.Length != 0 || array3.Length != 0)
									{
										Sensor[] array4 = Enumerable.ToArray<Sensor>(Enumerable.Where<Sensor>(array2, new Func<Sensor, bool>(this.method_77)));
										Sensor[] array5 = Enumerable.ToArray<Sensor>(Enumerable.Where<Sensor>(array2, new Func<Sensor, bool>(this.method_78)));
										Sensor[] array6 = Enumerable.ToArray<Sensor>(Enumerable.Where<Sensor>(array2, (ActiveUnit_Sensory._Closure$__.$I61-2 == null) ? (ActiveUnit_Sensory._Closure$__.$I61-2 = new Func<Sensor, bool>(ActiveUnit_Sensory._Closure$__.$I.method_1)) : ActiveUnit_Sensory._Closure$__.$I61-2));
										this.hashSet_0.Clear();
										List<ActiveUnit> list = new List<ActiveUnit>();
										List<ActiveUnit> list2 = new List<ActiveUnit>();
										if (array4.Length > 0)
										{
											if (this.activeUnit_0.bool_2)
											{
												Weapon weapon = (Weapon)this.activeUnit_0;
												if (weapon.method_227() && !weapon.method_199())
												{
													this.hashSet_0.UnionWith(this.activeUnit_0.scenario_0.method_42());
												}
												else
												{
													this.hashSet_0.UnionWith(this.activeUnit_0.vmethod_7(false).vmethod_4());
												}
											}
											else if (!this.activeUnit_0.vmethod_90().vmethod_1())
											{
												this.hashSet_0.UnionWith(this.activeUnit_0.scenario_0.method_42());
											}
											else
											{
												this.hashSet_0.UnionWith(this.activeUnit_0.vmethod_7(false).vmethod_4());
											}
										}
										foreach (ActiveUnit activeUnit in activeUnit_1)
										{
											if (!Information.IsNothing(activeUnit) && activeUnit != this.activeUnit_0 && (!activeUnit.bool_2 || ((Weapon)activeUnit).method_177() != this.activeUnit_0))
											{
												this.hashSet_0.Add(activeUnit);
											}
										}
										if (this.activeUnit_0.bool_2)
										{
											ActiveUnit activeUnit2 = ((Weapon)this.activeUnit_0).method_179();
											if (activeUnit2 != null)
											{
												this.hashSet_0.Remove(activeUnit2);
											}
										}
										if (!this.activeUnit_0.vmethod_90().vmethod_1())
										{
											try
											{
												foreach (Weapon weapon2 in this.activeUnit_0.scenario_0.method_17())
												{
													if (weapon2.method_177() == this.activeUnit_0)
													{
														this.hashSet_0.Remove(weapon2);
													}
												}
											}
											finally
											{
												List<Weapon>.Enumerator enumerator;
												((IDisposable)enumerator).Dispose();
											}
										}
										if (Enumerable.Count<Sensor>(array5) > 0)
										{
											try
											{
												foreach (Contact contact in this.activeUnit_0.vmethod_88().method_63().Values)
												{
													if (contact.activeUnit_0 != null)
													{
														list.Add(contact.activeUnit_0);
													}
												}
											}
											finally
											{
												IEnumerator<Contact> enumerator2;
												if (enumerator2 != null)
												{
													enumerator2.Dispose();
												}
											}
										}
										if (Enumerable.Count<Sensor>(array6) > 0)
										{
											try
											{
												foreach (Contact contact2 in this.activeUnit_0.vmethod_7(false).method_44())
												{
													if (contact2.activeUnit_0 != null)
													{
														list2.Add(contact2.activeUnit_0);
													}
												}
											}
											finally
											{
												List<Contact>.Enumerator enumerator3;
												((IDisposable)enumerator3).Dispose();
											}
										}
										List<ActiveUnit_Sensory.Class224> list3 = new List<ActiveUnit_Sensory.Class224>();
										List<ActiveUnit_Sensory.Class224> list4 = new List<ActiveUnit_Sensory.Class224>();
										List<ActiveUnit_Sensory.Class224> list5 = new List<ActiveUnit_Sensory.Class224>();
										new List<ActiveUnit_Sensory.Class224>();
										if (array4.Length > 0 && this.hashSet_0 != null && this.hashSet_0.Count > 0)
										{
											list3 = ActiveUnit_Sensory.smethod_2(this.activeUnit_0, array4, Enumerable.ToList<ActiveUnit>(this.hashSet_0));
										}
										if (Enumerable.Count<Sensor>(array5) > 0 && list.Count > 0)
										{
											list4 = ActiveUnit_Sensory.smethod_2(this.activeUnit_0, array5, list);
											if (list4 != null)
											{
												list3.AddRange(list4);
											}
										}
										if (Enumerable.Count<Sensor>(array6) > 0 && list2.Count > 0)
										{
											list5 = ActiveUnit_Sensory.smethod_2(this.activeUnit_0, array6, list2);
											if (list5 != null)
											{
												list3.AddRange(list5);
											}
										}
										if (Enumerable.Count<Sensor>(array3) > 0)
										{
											foreach (Sensor sensor2 in array3)
											{
												try
												{
													foreach (Contact contact3 in sensor2.method_41())
													{
														if (contact3.activeUnit_0 != null)
														{
															Sensor[] array8 = new Sensor[]
															{
																sensor2
															};
															ActiveUnit_Sensory.Class224 @class = new ActiveUnit_Sensory.Class224(ref contact3.activeUnit_0, ref array8);
															if (@class != null)
															{
																list3.Add(@class);
															}
														}
													}
												}
												finally
												{
													List<Contact>.Enumerator enumerator4;
													((IDisposable)enumerator4).Dispose();
												}
											}
										}
										if (list3.Count > 0)
										{
											List<ActiveUnit> list6 = null;
											Sensor[] array9 = array2;
											for (int l = 0; l < array9.Length; l++)
											{
												if (array9[l].sensor_Type_0 == Sensor.Sensor_Type.Radar)
												{
													if (list6 == null)
													{
														list6 = this.method_10(true);
													}
													IL_59C:
													Sensor[] array10 = array3;
													for (int m = 0; m < array10.Length; m++)
													{
														if (array10[m].sensor_Type_0 == Sensor.Sensor_Type.Radar)
														{
															if (list6 == null)
															{
																list6 = this.method_10(true);
															}
															IL_5D4:
															this.concurrentQueue_0 = new ConcurrentQueue<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>>();
															this.concurrentBag_0 = new ConcurrentBag<string>();
															try
															{
																foreach (ActiveUnit_Sensory.Class224 class224_ in list3)
																{
																	try
																	{
																		this.method_20(class224_, list6);
																	}
																	catch (Exception ex)
																	{
																		ex.Data.Add("Error at 101168", "");
																		GameGeneral.smethod_25(ref ex);
																		if (Debugger.IsAttached)
																		{
																			Debugger.Break();
																		}
																	}
																}
															}
															finally
															{
																List<ActiveUnit_Sensory.Class224>.Enumerator enumerator5;
																((IDisposable)enumerator5).Dispose();
															}
															goto IL_65B;
														}
													}
													goto IL_5D4;
												}
											}
											goto IL_59C;
										}
										IL_65B:
										if (array4.Length > 0)
										{
											this.method_17(array4);
										}
									}
								}
							}
						}
					}
					catch (Exception ex2)
					{
						ex2.Data.Add("Error at 100242", "");
						GameGeneral.smethod_25(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
				}
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000B22C8 File Offset: 0x000B04C8
		private static List<ActiveUnit_Sensory.Class224> smethod_2(ActiveUnit activeUnit_1, Sensor[] sensor_0, List<ActiveUnit> list_2)
		{
			List<ActiveUnit_Sensory.Class224> result;
			try
			{
				ActiveUnit_Sensory activeUnit_Sensory = activeUnit_1.vmethod_88();
				bool flag = false;
				List<ActiveUnit_Sensory.Class224> list = new List<ActiveUnit_Sensory.Class224>();
				List<Sensor> list2 = activeUnit_Sensory.method_51(false, false, true, true, ref sensor_0);
				List<Sensor> list3 = activeUnit_Sensory.method_53(false, false, true, true, ref sensor_0);
				List<Sensor> list4 = activeUnit_Sensory.method_54(false, false, true, true, ref sensor_0);
				List<Sensor> list5 = activeUnit_Sensory.method_55(false, false, true, true, ref sensor_0, false);
				float num = 0f;
				float num2 = 0f;
				float num3 = 0f;
				float num4 = 0f;
				if (list2.Count > 0)
				{
					num = list2[0].float_0;
				}
				if (list3.Count > 0)
				{
					num2 = list3[0].float_0;
				}
				if (list4.Count > 0)
				{
					num3 = list4[0].float_0;
				}
				if (list5.Count > 0)
				{
					num4 = list5[0].float_0;
				}
				float num5 = Math.Max(Math.Max(Math.Max(num, num2), num4), num3);
				if (num5 == 0f)
				{
					list = new List<ActiveUnit_Sensory.Class224>();
					result = list;
				}
				else
				{
					double double_ = activeUnit_1.vmethod_30(null);
					double double_2 = activeUnit_1.vmethod_28(null);
					List<ActiveUnit> list6 = Class410.smethod_4(list_2, true, double_, double_2, (double)num5);
					int num6 = list6.Count - 1;
					for (int i = 0; i <= num6; i++)
					{
						ActiveUnit activeUnit = list6[i];
						if (!Information.IsNothing(activeUnit) && !activeUnit.bool_1 && activeUnit.vmethod_127())
						{
							float num7;
							if (activeUnit.bool_8)
							{
								num7 = num3;
							}
							else if (activeUnit.bool_6)
							{
								num7 = num2;
							}
							else if (!activeUnit.bool_5 && !activeUnit.bool_7)
							{
								if (activeUnit.bool_3 || activeUnit.method_2() || activeUnit.method_1() || activeUnit.method_88())
								{
									num7 = num;
								}
							}
							else
							{
								num7 = Math.Max(num4, num2);
							}
							if (num7 != 0f && num7 > activeUnit_1.method_36(activeUnit))
							{
								ActiveUnit_Sensory.Class224 item = new ActiveUnit_Sensory.Class224(ref activeUnit, ref sensor_0);
								if (!flag)
								{
									list = new List<ActiveUnit_Sensory.Class224>(list_2.Count);
									flag = true;
								}
								list.Add(item);
							}
						}
					}
					if (!flag)
					{
						list = new List<ActiveUnit_Sensory.Class224>();
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101224", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit_Sensory.Class224>();
			}
			return result;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000B255C File Offset: 0x000B075C
		private void method_17(Sensor[] sensor_0)
		{
			try
			{
				if (!Information.IsNothing(this.activeUnit_0.scenario_0.Mines))
				{
					if (this.activeUnit_0.scenario_0.Mines.Count != 0)
					{
						if (!this.activeUnit_0.bool_8)
						{
							if (this.activeUnit_0.scenario_0.vmethod_20().Values.Count > 0)
							{
								if (this.activeUnit_0.bool_2)
								{
									Weapon weapon = (Weapon)this.activeUnit_0;
									if (weapon.method_167() != Weapon._WeaponType.HeliTowedPackage && !weapon.class394_0.bool_10)
									{
										return;
									}
								}
								Sensor[] array = new Sensor[0];
								foreach (Sensor sensor in sensor_0)
								{
									if (sensor.method_74())
									{
										if (sensor.method_43() && sensor.method_64() && (sensor.method_28(Sensor.FrequencyBand.const_30) || sensor.struct32_0.bool_7))
										{
											Class429.smethod_24(ref array, sensor);
										}
									}
									else if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Visual && (this.activeUnit_0.bool_3 || this.activeUnit_0.bool_6) && this.activeUnit_0.vmethod_14(false) < 150f && this.activeUnit_0.vmethod_40() < 200f)
									{
										Class429.smethod_24(ref array, sensor);
									}
								}
								if (array.Length != 0)
								{
									List<ActiveUnit_Sensory.Class225> list = new List<ActiveUnit_Sensory.Class225>();
									list = this.method_18(ref array, ref this.activeUnit_0.scenario_0.Mines);
									if (list.Count > 0)
									{
										try
										{
											foreach (ActiveUnit_Sensory.Class225 class225_ in list)
											{
												this.method_19(class225_, array);
											}
										}
										finally
										{
											List<ActiveUnit_Sensory.Class225>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
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
				ex.Data.Add("Error at 101272", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000B27AC File Offset: 0x000B09AC
		private List<ActiveUnit_Sensory.Class225> method_18(ref Sensor[] sensor_0, ref List<UnguidedWeapon> list_2)
		{
			List<ActiveUnit_Sensory.Class225> result;
			try
			{
				List<ActiveUnit_Sensory.Class225> list = new List<ActiveUnit_Sensory.Class225>();
				List<Sensor> list2 = this.method_56(ref sensor_0);
				if (Enumerable.Count<Sensor>(sensor_0) > 0)
				{
					double num = (double)list2[0].float_0;
					if (num > 1.0)
					{
						num = 1.0;
					}
					float num2 = (float)Math2.smethod_13(num);
					int num3 = list_2.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						UnguidedWeapon unguidedWeapon = list_2[i];
						if (Math.Abs(this.activeUnit_0.vmethod_30(null) - unguidedWeapon.vmethod_30(null)) <= (double)num2 && (double)num2 > this.activeUnit_0.method_31(unguidedWeapon))
						{
							ActiveUnit_Sensory.Class225 item = new ActiveUnit_Sensory.Class225(ref unguidedWeapon, ref sensor_0);
							list.Add(item);
						}
					}
					result = list;
				}
				else
				{
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101224", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<ActiveUnit_Sensory.Class225>();
			}
			return result;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000B28D4 File Offset: 0x000B0AD4
		private void method_19(ActiveUnit_Sensory.Class225 class225_0, Sensor[] sensor_0)
		{
			checked
			{
				try
				{
					UnguidedWeapon unguidedWeapon_ = class225_0.unguidedWeapon_0;
					float float_ = this.activeUnit_0.method_37(unguidedWeapon_, 0f);
					for (int i = 0; i < sensor_0.Length; i++)
					{
						if (sensor_0[i].method_86(this.activeUnit_0, unguidedWeapon_, float_))
						{
							if (Information.IsNothing(this.concurrentBag_0))
							{
								this.concurrentBag_0 = new ConcurrentBag<string>();
							}
							this.concurrentBag_0.Add(unguidedWeapon_.string_0);
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100244", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000B2990 File Offset: 0x000B0B90
		private void method_20(ActiveUnit_Sensory.Class224 class224_0, List<ActiveUnit> list_2)
		{
			Side side = this.activeUnit_0.vmethod_7(false);
			try
			{
				ActiveUnit activeUnit = class224_0.activeUnit_0;
				Sensor[] sensor_ = class224_0.sensor_0;
				if (!Information.IsNothing(activeUnit))
				{
					if (activeUnit != this.activeUnit_0)
					{
						if (activeUnit.vmethod_127())
						{
							Side side2 = activeUnit.vmethod_7(false);
							if (!this.activeUnit_0.vmethod_90().vmethod_1() || !activeUnit.vmethod_90().vmethod_1() || (side != side2 && side2.method_68(side) != Misc.PostureStance.Friendly))
							{
								bool flag;
								Contact contact;
								if ((flag = activeUnit.method_67(side)) && side != side2)
								{
									if (this.activeUnit_0.vmethod_90().vmethod_1())
									{
										if (!side.method_11().TryGetValue(activeUnit.string_0, ref contact))
										{
											return;
										}
									}
									else if (!this.dictionary_0.TryGetValue(activeUnit.string_0, out contact))
									{
										return;
									}
									if (!Information.IsNothing(contact) && !this.activeUnit_0.bool_2)
									{
										if (contact.method_73(side).Count > 0)
										{
											if (contact.method_59() < 10f)
											{
												return;
											}
										}
										else if (contact.method_59() < 15f)
										{
											return;
										}
									}
								}
								List<Sensor> item = new List<Sensor>();
								float? num = null;
								if (this.activeUnit_0.bool_5 && activeUnit.bool_3 && ((Aircraft)activeUnit).method_164().method_36() == Aircraft_AirOps._AirOpsCondition.DeployingDippingSonar)
								{
									num = new float?(this.activeUnit_0.method_36(activeUnit));
								}
								else
								{
									num = new float?(this.activeUnit_0.method_37(activeUnit, 0f));
								}
								bool? flag2 = null;
								bool? flag3 = null;
								Unit.Enum123? @enum = null;
								bool? flag4 = null;
								if (flag && side != side2)
								{
									if (activeUnit.method_81())
									{
										Contact contact2 = this.method_43(activeUnit, sensor_, num.Value, ref item, list_2, ref flag2, ref flag3, ref @enum, ref flag4, true);
										if (!Information.IsNothing(contact2))
										{
											ActiveUnit_Sensory.smethod_4(contact, contact2.method_68());
										}
									}
									if (!this.activeUnit_0.bool_2 || (!((Weapon)this.activeUnit_0).method_225() && this.activeUnit_0.vmethod_90().method_2().Length != 0))
									{
										foreach (Sensor sensor in this.activeUnit_0.method_78())
										{
											if (sensor.method_26(false, false))
											{
												Sensor sensor2 = sensor;
												Sensor.Enum114 enum114_ = Sensor.Enum114.const_3;
												ActiveUnit activeUnit_ = this.activeUnit_0;
												ActiveUnit activeUnit_2 = activeUnit;
												List<GeoPoint> list = new List<GeoPoint>();
												float value = num.Value;
												Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
												if (sensor2.method_87(enum114_, activeUnit_, activeUnit_2, ref list, value, ref lazy, list_2, ref flag2, ref flag3, ref @enum, ref flag4))
												{
													this.method_32(contact, activeUnit, sensor);
													this.method_31(contact, activeUnit, sensor);
												}
											}
										}
									}
									if (!this.activeUnit_0.bool_2)
									{
										return;
									}
								}
								contact = this.method_43(activeUnit, sensor_, num.Value, ref item, list_2, ref flag2, ref flag3, ref @enum, ref flag4, false);
								if (!Information.IsNothing(contact))
								{
									this.concurrentQueue_0.Enqueue(new Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>(contact, activeUnit, item, num.Value, ActiveUnit_Sensory.Enum35.const_0, this.activeUnit_0.scenario_0.method_31()));
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100245", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000B2D00 File Offset: 0x000B0F00
		public virtual void vmethod_8()
		{
			try
			{
				while (this.activeUnit_0.vmethod_7(false).queue_0.Count > 0)
				{
					Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime> tuple_ = this.activeUnit_0.vmethod_7(false).queue_0.Dequeue();
					this.vmethod_9(tuple_);
				}
				this.activeUnit_0.vmethod_88().method_68();
				if (!Information.IsNothing(this.concurrentQueue_0))
				{
					while (this.concurrentQueue_0.Count > 0)
					{
						Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime> tuple_2;
						if (this.concurrentQueue_0.TryDequeue(out tuple_2))
						{
							this.vmethod_9(tuple_2);
						}
					}
				}
				if (!Information.IsNothing(this.concurrentBag_0) && this.concurrentBag_0.Count > 0)
				{
					try
					{
						foreach (string text in this.concurrentBag_0)
						{
							if (!string.IsNullOrEmpty(text) && !this.activeUnit_0.vmethod_7(false).hashSet_0.Contains(text))
							{
								this.activeUnit_0.vmethod_7(false).hashSet_0.Add(text);
								try
								{
									UnguidedWeapon unguidedWeapon = this.activeUnit_0.scenario_0.vmethod_20()[text];
									if (unguidedWeapon.method_65())
									{
										string text2 = "";
										if (this.activeUnit_0.bool_3 && Operators.CompareString(this.activeUnit_0.Name, this.activeUnit_0.string_2, false) != 0)
										{
											text2 = " (" + this.activeUnit_0.string_2 + ")";
										}
										this.activeUnit_0.method_124(string.Concat(new string[]
										{
											"New mine contact! Detected by ",
											this.activeUnit_0.Name,
											text2,
											" at ",
											Conversions.ToString((int)Math.Round((double)this.activeUnit_0.vmethod_86().method_68(unguidedWeapon))),
											"deg - ",
											Conversions.ToString(Math.Round((double)this.activeUnit_0.method_36(unguidedWeapon), 1)),
											"NM"
										}), "Mine warfare", LoggedMessage.MessageType.NewMineContact, 1, false, new Geopoint_Struct(unguidedWeapon.vmethod_28(null), unguidedWeapon.vmethod_30(null)));
										try
										{
											foreach (ActiveUnit activeUnit in this.activeUnit_0.scenario_0.method_42())
											{
												if (!Information.IsNothing(activeUnit) && (activeUnit.bool_5 || activeUnit.bool_6))
												{
													activeUnit.vmethod_85().vmethod_2();
												}
											}
										}
										finally
										{
											List<ActiveUnit>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
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
					}
					finally
					{
						IEnumerator<string> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (!Information.IsNothing(this.concurrentQueue_0) && this.concurrentQueue_0.Count > 0)
				{
					this.concurrentQueue_0 = new ConcurrentQueue<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>>();
				}
				if (!Information.IsNothing(this.concurrentBag_0) && this.concurrentBag_0.Count > 0)
				{
					this.concurrentBag_0 = new ConcurrentBag<string>();
				}
				if (!Information.IsNothing(this.lazy_0) && !Misc.smethod_16(this.lazy_0.Value))
				{
					try
					{
						foreach (LoggedMessage loggedMessage_ in this.lazy_0.Value.Values)
						{
							this.activeUnit_0.scenario_0.method_58(loggedMessage_);
						}
					}
					finally
					{
						IEnumerator<LoggedMessage> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
					this.lazy_0.Value.Clear();
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100246", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000B313C File Offset: 0x000B133C
		public void method_21()
		{
			try
			{
				this.activeUnit_0.vmethod_88().method_68();
				if (!Information.IsNothing(this.concurrentQueue_0))
				{
					try
					{
						foreach (Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime> tuple in this.concurrentQueue_0)
						{
							if (!Information.IsNothing(tuple))
							{
								this.vmethod_10(tuple);
							}
						}
					}
					finally
					{
						IEnumerator<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (!Information.IsNothing(this.concurrentBag_0))
				{
					try
					{
						foreach (string text in this.concurrentBag_0)
						{
							if (!string.IsNullOrEmpty(text) && !this.list_1.Contains(text))
							{
								this.list_1.Add(text);
								try
								{
									UnguidedWeapon unguidedWeapon = this.activeUnit_0.scenario_0.vmethod_20()[text];
									if (unguidedWeapon.method_65())
									{
										this.activeUnit_0.method_124(string.Concat(new string[]
										{
											"New mine contact! Detected by ",
											this.activeUnit_0.Name,
											" at ",
											Conversions.ToString((int)Math.Round((double)this.activeUnit_0.vmethod_86().method_68(unguidedWeapon))),
											"deg - ",
											Conversions.ToString(Math.Round((double)this.activeUnit_0.method_36(unguidedWeapon), 1)),
											"NM"
										}), "Mine warfare", LoggedMessage.MessageType.CommsIsolatedMessage, 1, false, new Geopoint_Struct(unguidedWeapon.vmethod_28(null), unguidedWeapon.vmethod_30(null)));
										this.activeUnit_0.vmethod_85().vmethod_2();
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
					}
					finally
					{
						IEnumerator<string> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
				}
				if (!Information.IsNothing(this.concurrentQueue_0) && this.concurrentQueue_0.Count > 0)
				{
					this.concurrentQueue_0 = new ConcurrentQueue<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>>();
				}
				if (!Information.IsNothing(this.concurrentBag_0) && this.concurrentBag_0.Count > 0)
				{
					this.concurrentBag_0 = new ConcurrentBag<string>();
				}
				if (!Information.IsNothing(this.lazy_0))
				{
					try
					{
						foreach (LoggedMessage loggedMessage_ in this.lazy_0.Value.Values)
						{
							this.activeUnit_0.scenario_0.method_58(loggedMessage_);
						}
					}
					finally
					{
						IEnumerator<LoggedMessage> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				this.lazy_0.Value.Clear();
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 200653", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000B346C File Offset: 0x000B166C
		public static void smethod_3(ref Contact myContact, ActiveUnit ContactsActualUnit, bool ContactIsNew, List<GeoPoint> theUncertaintyArea = null)
		{
			try
			{
				bool flag;
				if (ContactIsNew)
				{
					flag = true;
				}
				else
				{
					Contact_Base.ContactType contactType_ = myContact.contactType_0;
					if (contactType_ <= Contact_Base.ContactType.Facility_Fixed)
					{
						if (contactType_ == Contact_Base.ContactType.Aimpoint || contactType_ == Contact_Base.ContactType.Facility_Fixed)
						{
							goto IL_29;
						}
					}
					else if (contactType_ == Contact_Base.ContactType.Explosion || contactType_ == Contact_Base.ContactType.ActivationPoint)
					{
						goto IL_29;
					}
					flag = true;
				}
				IL_29:
				if (flag)
				{
					if (!Information.IsNothing(theUncertaintyArea))
					{
						if (Information.IsNothing(myContact.method_112()))
						{
							if (ContactIsNew)
							{
								myContact.method_113(theUncertaintyArea);
							}
						}
						else if (!myContact.method_121())
						{
							if (!Information.IsNothing(myContact.activeUnit_0))
							{
								myContact.method_113(ActiveUnit_Sensory.smethod_9(myContact.method_112(), theUncertaintyArea));
							}
							else
							{
								myContact.method_113(theUncertaintyArea);
							}
						}
					}
					myContact.vmethod_10(ContactsActualUnit.vmethod_9());
					myContact.vmethod_41(ContactsActualUnit.vmethod_40());
					myContact.vmethod_15(false, ContactsActualUnit.vmethod_14(false));
					myContact.method_50();
				}
				myContact.method_137(ContactsActualUnit);
				myContact.method_58(0f);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100247", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000B358C File Offset: 0x000B178C
		public void method_22(Contact contact_0)
		{
			Sensor[] array = this.activeUnit_0.method_78();
			try
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					Sensor sensor = array[i];
					List<Contact> list = sensor.method_41();
					int num2 = list.Count - 1;
					int j = 0;
					while (j <= num2)
					{
						Contact contact;
						try
						{
							contact = list[j];
						}
						catch (Exception ex)
						{
							goto IL_5B;
						}
						goto IL_4E;
						IL_5B:
						j++;
						continue;
						IL_4E:
						if (contact == contact_0)
						{
							sensor.method_84(contact_0, false);
							goto IL_5B;
						}
						goto IL_5B;
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

		// Token: 0x06000A6A RID: 2666 RVA: 0x000B3640 File Offset: 0x000B1840
		public static void smethod_4(Contact contact_0, ObservableDictionary<int, EmissionContainer> observableDictionary_2)
		{
			if (observableDictionary_2.Count != 0)
			{
				try
				{
					try
					{
						foreach (KeyValuePair<int, EmissionContainer> keyValuePair in observableDictionary_2)
						{
							if (contact_0.method_68().ContainsKey(keyValuePair.Key))
							{
								if (contact_0.method_68()[keyValuePair.Key].bool_1)
								{
									keyValuePair.Value.bool_1 = true;
								}
								keyValuePair.Value.float_0 = Math.Min(keyValuePair.Value.float_0, contact_0.method_68()[keyValuePair.Key].float_0);
								contact_0.method_68()[keyValuePair.Key] = keyValuePair.Value;
							}
							else
							{
								try
								{
									contact_0.method_68().Add(keyValuePair.Key, keyValuePair.Value);
								}
								catch (Exception ex)
								{
									ex.Data.Add("Error at 200011", ex.Message);
									GameGeneral.smethod_25(ref ex);
									if (Debugger.IsAttached)
									{
										Debugger.Break();
									}
								}
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
				catch (Exception ex2)
				{
					ex2.Data.Add("Error at 100248", "");
					GameGeneral.smethod_25(ref ex2);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000B37E4 File Offset: 0x000B19E4
		private void method_23(List<Sensor> list_2, Contact contact_0)
		{
			try
			{
				foreach (Sensor sensor in list_2)
				{
					bool flag = ActiveUnit_Sensory.smethod_8(sensor, sensor.method_18().method_36(contact_0.activeUnit_0));
					if (sensor.method_98())
					{
						contact_0.method_97(10f);
						contact_0.method_99(10f);
					}
					else if (sensor.method_50())
					{
						contact_0.method_97(Math.Max(contact_0.method_96(), (float)sensor.method_47()));
						if (flag)
						{
							contact_0.method_99(Math.Max(contact_0.method_98(), (float)sensor.method_47()));
						}
					}
					else
					{
						Sensor sensor2 = sensor;
						ActiveUnit activeUnit = contact_0.activeUnit_0;
						if (sensor2.method_83(ref activeUnit))
						{
							contact_0.method_97(Math.Max(contact_0.method_96(), (float)sensor.method_47()));
							if (flag)
							{
								contact_0.method_99(Math.Max(contact_0.method_98(), (float)sensor.method_47()));
							}
						}
						else if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar)
						{
							contact_0.method_97(Math.Max(contact_0.method_96(), 3f));
							if (flag)
							{
								contact_0.method_99(Math.Max(contact_0.method_98(), (float)sensor.method_47()));
							}
						}
						else if (contact_0.method_135())
						{
							contact_0.method_97(Math.Max(contact_0.method_96(), (float)(sensor.method_47() * 6)));
							if (flag)
							{
								contact_0.method_99(Math.Max(contact_0.method_98(), (float)sensor.method_47()));
							}
						}
						else
						{
							contact_0.method_97(Math.Max(contact_0.method_96(), 1f));
						}
					}
				}
			}
			finally
			{
				List<Sensor>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000B399C File Offset: 0x000B1B9C
		protected virtual void vmethod_9(Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime> tuple_0)
		{
			Contact item = tuple_0.Item1;
			ActiveUnit item2 = tuple_0.Item2;
			List<Sensor> item3 = tuple_0.Item3;
			float item4 = tuple_0.Item4;
			ActiveUnit_Sensory.Enum35 item5 = tuple_0.Item5;
			List<GeoPoint> list = null;
			ObservableDictionary<int, EmissionContainer> observableDictionary_ = item.method_68();
			try
			{
				bool flag = this.activeUnit_0.vmethod_7(false).lazy_0.Value.ContainsKey(item2.string_0);
				bool flag2 = this.activeUnit_0.vmethod_7(false).method_11().ContainsKey(item2.string_0);
				bool flag3 = this.activeUnit_0.vmethod_88().method_63().ContainsKey(item2.string_0);
				Contact contact;
				if (flag2)
				{
					contact = this.activeUnit_0.vmethod_7(false).method_11()[item2.string_0];
					if (contact.method_67() || item.method_67())
					{
						ActiveUnit_Sensory.smethod_4(contact, item.method_68());
					}
				}
				else
				{
					if (flag)
					{
						return;
					}
					contact = item;
				}
				if (!Information.IsNothing(item.method_112()))
				{
					list = item.method_112();
				}
				this.method_23(item3, contact);
				if (this.activeUnit_0.vmethod_7(false).method_28() >= Side.AwarenessLevel_Enum.AutoSideID && !contact.bool_12)
				{
					contact.bool_12 = true;
					contact.bool_15 = false;
				}
				string name = contact.Name;
				Contact_Base.IdentificationStatus? identificationStatus;
				Contact_Base.IdentificationStatus? identificationStatus2;
				if (item3.Count != 0)
				{
					try
					{
						foreach (Sensor sensor in item3)
						{
							if (flag2)
							{
								this.method_24(sensor, contact, item2, item4, true, ref identificationStatus, ref identificationStatus2);
							}
							this.method_32(contact, item2, sensor);
							this.method_31(contact, item2, sensor);
							this.method_25(sensor, contact);
							if (!ActiveUnit_Sensory.smethod_8(sensor, sensor.method_18().method_36(contact.activeUnit_0)))
							{
								if (!contact.method_121() && !item2.method_5())
								{
									List<GeoPoint> list2 = this.method_49(sensor, item2, this.activeUnit_0.method_36(item2), observableDictionary_);
									if (Information.IsNothing(list))
									{
										list = list2;
									}
									else
									{
										list = ActiveUnit_Sensory.smethod_9(list, list2);
									}
								}
								if (sensor.struct32_0.bool_10 || this.activeUnit_0.bool_2)
								{
									contact.bool_19 = true;
								}
							}
							else
							{
								contact.method_122(true);
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (!contact.activeUnit_0.vmethod_90().vmethod_1() && (contact.activeUnit_0.vmethod_7(false) == this.activeUnit_0.vmethod_7(false) || contact.activeUnit_0.vmethod_7(false).method_68(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Friendly))
				{
					try
					{
						foreach (Sensor sensor_ in item3)
						{
							this.method_24(sensor_, contact, item2, item4, false, ref identificationStatus, ref identificationStatus2);
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
				if (identificationStatus != null)
				{
					short? num = (identificationStatus != null) ? new short?((short)identificationStatus.GetValueOrDefault()) : null;
					bool? flag4;
					if (!((num != null) ? new bool?(num.GetValueOrDefault() == 4) : null).GetValueOrDefault())
					{
						if (!contact.method_104())
						{
							flag4 = new bool?(false);
						}
						else
						{
							num = ((identificationStatus != null) ? new short?((short)identificationStatus.GetValueOrDefault()) : null);
							flag4 = ((num != null) ? new bool?(num.GetValueOrDefault() == 3) : null);
						}
					}
					else
					{
						flag4 = new bool?(true);
					}
					bool? flag5 = flag4;
					if (flag5.GetValueOrDefault() && !contact.activeUnit_0.vmethod_90().vmethod_1() && (contact.activeUnit_0.vmethod_7(false) == this.activeUnit_0.vmethod_7(false) || contact.activeUnit_0.vmethod_7(false).method_68(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Friendly))
					{
						if (flag3)
						{
							this.activeUnit_0.method_124(string.Concat(new string[]
							{
								"Contact: ",
								name,
								" was identified by ",
								this.activeUnit_0.Name,
								" as ",
								item2.Name,
								", an out-of-comms unit. Dropping contact and updating the unit's last-reported position"
							}), "Communication issue", LoggedMessage.MessageType.ContactChange, 0, false, new Geopoint_Struct(contact.vmethod_28(null), contact.vmethod_30(null)));
						}
						try
						{
							this.activeUnit_0.vmethod_7(false).method_15(contact, ref this.activeUnit_0.scenario_0, false);
						}
						catch (Exception ex)
						{
						}
						if (Information.IsNothing(list))
						{
							ActiveUnit_Sensory.smethod_3(ref contact, item2, !flag2, null);
						}
						else
						{
							ActiveUnit_Sensory.smethod_3(ref contact, item2, !flag2, list);
						}
						contact.activeUnit_0.method_57(new double?(contact.vmethod_30(null)));
						contact.activeUnit_0.method_59(new double?(contact.vmethod_28(null)));
						return;
					}
				}
				if (flag2)
				{
					if (Information.IsNothing(list))
					{
						ActiveUnit_Sensory.smethod_3(ref contact, item2, false, null);
					}
					else
					{
						ActiveUnit_Sensory.smethod_3(ref contact, item2, false, list);
					}
				}
				else
				{
					identificationStatus = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownDomain);
					identificationStatus2 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.Unknown);
					ActiveUnit[] array = new ActiveUnit[0];
					foreach (Side side in this.activeUnit_0.scenario_0.method_44())
					{
						if (side == this.activeUnit_0.vmethod_7(false) | side.method_68(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Friendly)
						{
							foreach (ActiveUnit activeUnit in side.activeUnit_0)
							{
								if (!activeUnit.vmethod_90().vmethod_1())
								{
									Class429.smethod_0(ref array, activeUnit);
								}
							}
						}
					}
					if (array.Length > 0)
					{
						if (Information.IsNothing(list))
						{
							ActiveUnit_Sensory.smethod_3(ref contact, item2, true, null);
						}
						else
						{
							ActiveUnit_Sensory.smethod_3(ref contact, item2, true, list);
						}
						foreach (ActiveUnit activeUnit2 in array)
						{
							bool isAttached = Debugger.IsAttached;
							if (((activeUnit2.bool_3 && contact.method_104()) || (activeUnit2.bool_6 && contact.method_108()) || (activeUnit2.bool_5 && contact.method_136()) || (activeUnit2.bool_8 && contact.contactType_0 == Contact_Base.ContactType.Facility_Mobile)) && contact.method_25(activeUnit2.method_56().Value, activeUnit2.method_58().Value) < 1f)
							{
								activeUnit2.method_57(new double?(contact.vmethod_30(null)));
								activeUnit2.method_59(new double?(contact.vmethod_28(null)));
								return;
							}
						}
					}
					contact.method_113(list);
					ActiveUnit_Sensory.smethod_5(ref contact, ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), item2, item5, this.activeUnit_0, Contact_Base.IdentificationStatus.KnownDomain, item3);
				}
				this.method_26(item);
				List<EventTrigger> list3 = new List<EventTrigger>();
				if (!Information.IsNothing(identificationStatus) && !Information.IsNothing(identificationStatus2))
				{
					if (!Information.IsNothing(item5) && item5 != ActiveUnit_Sensory.Enum35.const_0)
					{
						goto IL_949;
					}
					try
					{
						foreach (EventTrigger eventTrigger in this.activeUnit_0.scenario_0.vmethod_4().Values)
						{
							if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDetected)
							{
								if (((Class329)eventTrigger).method_8(item2, this.activeUnit_0, flag, identificationStatus.Value, new Contact_Base.IdentificationStatus?(identificationStatus2.Value), item3))
								{
									list3.Add(eventTrigger);
								}
							}
							else if (eventTrigger.eventTriggerType_0 == EventTrigger.EventTriggerType.unitEmissions && ((Class331)eventTrigger).method_8(item2, this.activeUnit_0, flag, identificationStatus.Value, new Contact_Base.IdentificationStatus?(identificationStatus2.Value), item3))
							{
								list3.Add(eventTrigger);
							}
						}
						goto IL_949;
					}
					finally
					{
						IEnumerator<EventTrigger> enumerator3;
						if (enumerator3 != null)
						{
							enumerator3.Dispose();
						}
					}
				}
				if (!Information.IsNothing(contact))
				{
					try
					{
						foreach (EventTrigger eventTrigger2 in this.activeUnit_0.scenario_0.vmethod_4().Values)
						{
							if (eventTrigger2.eventTriggerType_0 == EventTrigger.EventTriggerType.UnitDetected)
							{
								if (((Class329)eventTrigger2).list_0.Count > 0)
								{
									if (contact.vmethod_46(((Class329)eventTrigger2).list_0, this.activeUnit_0.scenario_0, false))
									{
										if (((Class329)eventTrigger2).method_8(item2, this.activeUnit_0, flag, Contact_Base.IdentificationStatus.Unknown, new Contact_Base.IdentificationStatus?(identificationStatus2.Value), item3))
										{
											list3.Add(eventTrigger2);
										}
									}
									else if (contact.list_0.Count > 0)
									{
										item2.list_0.Remove(((Class329)eventTrigger2).string_0);
									}
								}
							}
							else if (eventTrigger2.eventTriggerType_0 == EventTrigger.EventTriggerType.unitEmissions && ((Class331)eventTrigger2).method_8(item2, this.activeUnit_0, flag, Contact_Base.IdentificationStatus.Unknown, new Contact_Base.IdentificationStatus?(identificationStatus2.Value), item3))
							{
								list3.Add(eventTrigger2);
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
				}
				IL_949:
				if (!Information.IsNothing(list3) && list3.Count > 0)
				{
					this.activeUnit_0.scenario_0.method_24(list3);
				}
				if (flag3)
				{
					this.method_64(ref item2.string_0, item3);
				}
				else
				{
					this.lazy_1.Value.TryAdd(item2.string_0, contact);
					this.method_64(ref item2.string_0, item3);
				}
				if (!Information.IsNothing(contact))
				{
					try
					{
						foreach (Sensor sensor2 in tuple_0.Item3)
						{
							contact.method_142(new ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>(this.activeUnit_0.string_0, sensor2.string_0, tuple_0.Item4, tuple_0.Item5, tuple_0.Item6));
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator5;
						((IDisposable)enumerator5).Dispose();
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100249", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000B4494 File Offset: 0x000B2694
		private void method_24(Sensor sensor_0, Contact contact_0, ActiveUnit activeUnit_1, float float_0, bool bool_1, ref Contact_Base.IdentificationStatus? nullable_0, ref Contact_Base.IdentificationStatus? nullable_1)
		{
			if (sensor_0.struct32_0.bool_9)
			{
				contact_0.bool_18 = true;
			}
			if (sensor_0.struct32_0.bool_11)
			{
				contact_0.bool_17 = true;
			}
			if (sensor_0.struct32_0.bool_10 || this.activeUnit_0.bool_2)
			{
				contact_0.bool_19 = true;
			}
			nullable_1 = new Contact_Base.IdentificationStatus?(contact_0.method_125());
			bool bool_2 = false;
			Sensor.Sensor_Type sensor_Type_ = sensor_0.sensor_Type_0;
			if (sensor_Type_ <= Sensor.Sensor_Type.HullSonar_ActivePassive)
			{
				switch (sensor_Type_)
				{
				case Sensor.Sensor_Type.Radar:
					if (contact_0.method_125() >= Contact_Base.IdentificationStatus.KnownClass)
					{
						goto IL_33E;
					}
					nullable_0 = this.method_37(contact_0, activeUnit_1, sensor_0, float_0);
					if (!Information.IsNothing(nullable_0))
					{
						bool_2 = true;
						goto IL_33E;
					}
					goto IL_33E;
				case Sensor.Sensor_Type.SemiActive:
					goto IL_33E;
				case Sensor.Sensor_Type.Visual:
				{
					float num = sensor_0.method_91(this.activeUnit_0, activeUnit_1);
					if (float_0 < num)
					{
						switch (contact_0.contactType_0)
						{
						case Contact_Base.ContactType.Air:
						case Contact_Base.ContactType.Orbital:
						case Contact_Base.ContactType.Facility_Mobile:
						case Contact_Base.ContactType.Torpedo:
						case Contact_Base.ContactType.Mine:
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
							goto IL_33E;
						case Contact_Base.ContactType.Missile:
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_33E;
						case Contact_Base.ContactType.Surface:
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.PreciseID);
							goto IL_33E;
						case Contact_Base.ContactType.Submarine:
							if (((Submarine)contact_0.activeUnit_0).method_161())
							{
								nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
								goto IL_33E;
							}
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_33E;
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Facility_Fixed:
							goto IL_33E;
						default:
							goto IL_33E;
						}
					}
					else
					{
						if (float_0 < num * 3f)
						{
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_33E;
						}
						nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownDomain);
						goto IL_33E;
					}
					break;
				}
				case Sensor.Sensor_Type.Infrared:
				{
					if (!sensor_0.struct33_0.bool_1)
					{
						goto IL_33E;
					}
					float num2 = sensor_0.method_91(this.activeUnit_0, activeUnit_1);
					if (float_0 < num2)
					{
						switch (contact_0.contactType_0)
						{
						case Contact_Base.ContactType.Air:
						case Contact_Base.ContactType.Surface:
						case Contact_Base.ContactType.Orbital:
						case Contact_Base.ContactType.Facility_Mobile:
						case Contact_Base.ContactType.Torpedo:
						case Contact_Base.ContactType.Mine:
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
							goto IL_33E;
						case Contact_Base.ContactType.Missile:
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_33E;
						case Contact_Base.ContactType.Submarine:
						case Contact_Base.ContactType.UndeterminedNaval:
						case Contact_Base.ContactType.Aimpoint:
						case Contact_Base.ContactType.Facility_Fixed:
							goto IL_33E;
						default:
							goto IL_33E;
						}
					}
					else
					{
						if (float_0 < num2 * 3f)
						{
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownType);
							goto IL_33E;
						}
						nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownDomain);
						goto IL_33E;
					}
					break;
				}
				default:
					if (sensor_Type_ != Sensor.Sensor_Type.ESM)
					{
						if (sensor_Type_ - Sensor.Sensor_Type.HullSonar_PassiveOnly > 1)
						{
							goto IL_33E;
						}
					}
					else
					{
						Contact_Base.ContactType contactType_ = contact_0.contactType_0;
						if (contactType_ == Contact_Base.ContactType.Facility_Mobile)
						{
							nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownDomain);
						}
						if (sensor_0.sensor_Role_0 == Sensor.Sensor_Role.ESM_RWR)
						{
							goto IL_33E;
						}
						this.method_28(contact_0, float_0);
						if (contact_0.method_125() < Contact_Base.IdentificationStatus.KnownClass)
						{
							nullable_0 = new Contact_Base.IdentificationStatus?(this.method_38(contact_0, activeUnit_1, sensor_0));
							goto IL_33E;
						}
						goto IL_33E;
					}
					break;
				}
			}
			else if (sensor_Type_ <= Sensor.Sensor_Type.VDS_ActivePassive)
			{
				if (sensor_Type_ - Sensor.Sensor_Type.TowedArray_PassiveOnly > 1 && sensor_Type_ - Sensor.Sensor_Type.VDS_PassiveOnly > 1)
				{
					goto IL_33E;
				}
			}
			else if (sensor_Type_ - Sensor.Sensor_Type.DippingSonar_PassiveOnly > 1 && sensor_Type_ != Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
			{
				goto IL_33E;
			}
			if (!sensor_0.method_43())
			{
				this.method_27(contact_0, float_0);
				nullable_0 = new Contact_Base.IdentificationStatus?(this.method_39(contact_0, activeUnit_1, sensor_0));
			}
			IL_33E:
			if (this.activeUnit_0.vmethod_7(false).method_28() >= Side.AwarenessLevel_Enum.AutoSideAndUnitID)
			{
				nullable_0 = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.PreciseID);
			}
			if (nullable_0 != null)
			{
				Contact_Base.IdentificationStatus? identificationStatus = nullable_0;
				short? num3 = (identificationStatus != null) ? new short?((short)identificationStatus.GetValueOrDefault()) : null;
				short num4 = (short)contact_0.method_125();
				if (((num3 != null) ? new bool?(num3.GetValueOrDefault() != num4) : null).GetValueOrDefault())
				{
					if (Information.IsNothing(contact_0.method_112()))
					{
						contact_0.method_126(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), sensor_0, new float?((float)Math.Round((double)float_0, 1)), bool_2, this.activeUnit_0.vmethod_90().vmethod_1(), true, bool_1, nullable_0.Value);
						return;
					}
					contact_0.method_126(this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), sensor_0, new float?((float)Math.Round((double)this.activeUnit_0.method_37(contact_0, 0f), 1)), bool_2, this.activeUnit_0.vmethod_90().vmethod_1(), true, bool_1, nullable_0.Value);
				}
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000B4924 File Offset: 0x000B2B24
		private void method_25(Sensor sensor_0, Contact contact_0)
		{
			Sensor.Sensor_Type sensor_Type_ = sensor_0.sensor_Type_0;
			if (sensor_Type_ <= Sensor.Sensor_Type.TowedArray_ActiveOnly)
			{
				if (sensor_Type_ <= Sensor.Sensor_Type.ESM)
				{
					switch (sensor_Type_)
					{
					case Sensor.Sensor_Type.Radar:
						contact_0.nullable_14 = new float?(0f);
						return;
					case Sensor.Sensor_Type.SemiActive:
						return;
					case Sensor.Sensor_Type.Visual:
						contact_0.nullable_16 = new float?(0f);
						return;
					case Sensor.Sensor_Type.Infrared:
						contact_0.nullable_17 = new float?(0f);
						return;
					default:
						if (sensor_Type_ != Sensor.Sensor_Type.ESM)
						{
							return;
						}
						contact_0.nullable_15 = new float?(0f);
						return;
					}
				}
				else if (sensor_Type_ - Sensor.Sensor_Type.HullSonar_PassiveOnly > 2 && sensor_Type_ - Sensor.Sensor_Type.TowedArray_PassiveOnly > 2)
				{
					return;
				}
			}
			else if (sensor_Type_ <= Sensor.Sensor_Type.DippingSonar_ActiveOnly)
			{
				if (sensor_Type_ - Sensor.Sensor_Type.VDS_PassiveOnly > 2 && sensor_Type_ - Sensor.Sensor_Type.DippingSonar_PassiveOnly > 2)
				{
					return;
				}
			}
			else if (sensor_Type_ != Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
			{
				if (sensor_Type_ != Sensor.Sensor_Type.PingIntercept)
				{
					return;
				}
				contact_0.nullable_19 = new float?(0f);
				return;
			}
			if (sensor_0.method_46())
			{
				contact_0.nullable_18 = new float?(0f);
				return;
			}
			if (sensor_0.method_43())
			{
				contact_0.nullable_18 = new float?(0f);
				return;
			}
			contact_0.nullable_19 = new float?(0f);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000B4A4C File Offset: 0x000B2C4C
		protected virtual void vmethod_10(Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime> tuple_0)
		{
			Contact item = tuple_0.Item1;
			Unit item2 = tuple_0.Item2;
			List<Sensor> item3 = tuple_0.Item3;
			float item4 = tuple_0.Item4;
			ActiveUnit_Sensory.Enum35 item5 = tuple_0.Item5;
			try
			{
				List<GeoPoint> list = null;
				item.method_68();
				bool flag = this.activeUnit_0.vmethod_7(false).lazy_0.Value.ContainsKey(item2.string_0);
				bool flag2 = this.dictionary_0.ContainsKey(item2.string_0);
				bool flag3 = this.activeUnit_0.vmethod_88().method_63().ContainsKey(item2.string_0);
				Contact contact;
				if (flag2)
				{
					contact = this.dictionary_0[item2.string_0];
					if (contact.method_67() || item.method_67())
					{
						ActiveUnit_Sensory.smethod_4(contact, item.method_68());
					}
				}
				else
				{
					if (flag)
					{
						return;
					}
					contact = item;
				}
				if (item5 != ActiveUnit_Sensory.Enum35.const_0 && !Information.IsNothing(item.method_112()))
				{
					list = item.method_112();
				}
				this.method_23(item3, contact);
				if (this.activeUnit_0.vmethod_7(false).method_28() >= Side.AwarenessLevel_Enum.AutoSideID && !contact.bool_12)
				{
					contact.bool_12 = true;
				}
				if (item3.Count != 0)
				{
					try
					{
						foreach (Sensor sensor in item3)
						{
							if (flag2)
							{
								Contact_Base.IdentificationStatus? identificationStatus;
								Contact_Base.IdentificationStatus? identificationStatus2;
								this.method_24(sensor, contact, (ActiveUnit)item2, item4, true, ref identificationStatus, ref identificationStatus2);
							}
							this.method_25(sensor, contact);
							this.method_32(contact, (ActiveUnit)item2, sensor);
							this.method_31(contact, (ActiveUnit)item2, sensor);
							if (ActiveUnit_Sensory.smethod_8(sensor, sensor.method_18().method_36(item2)))
							{
								if (!Information.IsNothing(contact.method_112()))
								{
									contact.method_123(true);
								}
								contact.method_122(true);
								contact.method_113(null);
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
				if (flag2)
				{
					if (Information.IsNothing(list))
					{
						ActiveUnit_Sensory.smethod_3(ref contact, (ActiveUnit)item2, false, null);
					}
					else
					{
						ActiveUnit_Sensory.smethod_3(ref contact, (ActiveUnit)item2, false, list);
					}
				}
				else
				{
					contact.method_113(list);
					ActiveUnit_Sensory.smethod_5(ref contact, ref this.activeUnit_0.scenario_0, this.activeUnit_0.vmethod_7(false), item2, item5, this.activeUnit_0, Contact_Base.IdentificationStatus.KnownDomain, item3);
				}
				this.method_26(item);
				if (contact.method_110() && this.activeUnit_0.vmethod_86().method_21(contact))
				{
					contact.method_131(this.activeUnit_0.vmethod_7(false), false, Misc.PostureStance.Hostile);
				}
				if (!flag2 && !this.dictionary_0.ContainsKey(item2.string_0))
				{
					this.dictionary_0.Add(item2.string_0, contact);
				}
				if (flag3)
				{
					this.method_64(ref item2.string_0, item3);
				}
				else
				{
					this.lazy_1.Value.TryAdd(item2.string_0, contact);
					this.method_64(ref item2.string_0, item3);
				}
				if (!Information.IsNothing(contact))
				{
					try
					{
						foreach (Sensor sensor2 in tuple_0.Item3)
						{
							contact.method_142(new ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>(this.activeUnit_0.string_0, sensor2.string_0, tuple_0.Item4, tuple_0.Item5, tuple_0.Item6));
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100249", "");
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000B4E04 File Offset: 0x000B3004
		private void method_26(Contact contact_0)
		{
			if (contact_0.contactType_0 == Contact_Base.ContactType.Torpedo)
			{
				Weapon weapon = (Weapon)contact_0.activeUnit_0;
				if (!Information.IsNothing(weapon.method_177()) && weapon.method_177().bool_5)
				{
					bool flag = false;
					try
					{
						foreach (Contact contact in this.activeUnit_0.vmethod_7(false).method_44())
						{
							if (contact.contactType_0 == Contact_Base.ContactType.Submarine && this.activeUnit_0.method_36(contact) <= 15f && Math.Abs(Class437.smethod_3(Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact.vmethod_30(null), contact.vmethod_28(null)), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_0.vmethod_30(null), contact_0.vmethod_28(null)))) < 45f)
							{
								flag = true;
								break;
							}
						}
					}
					finally
					{
						List<Contact>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (!flag)
					{
						bool flag2;
						try
						{
							foreach (Contact contact2 in this.activeUnit_0.vmethod_7(false).method_44())
							{
								if (contact2.contactType_0 == Contact_Base.ContactType.Submarine && contact2.activeUnit_0 == ((Weapon)contact_0.activeUnit_0).method_177())
								{
									flag2 = true;
									break;
								}
							}
						}
						finally
						{
							List<Contact>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						if (!flag2 && weapon.method_177().method_82())
						{
							flag2 = true;
						}
						if (!flag2)
						{
							Contact contact3 = new Contact(((Weapon)contact_0.activeUnit_0).method_177(), 0);
							contact3.vmethod_31(null, contact_0.activeUnit_0.vmethod_30(null));
							contact3.vmethod_29(null, contact_0.activeUnit_0.vmethod_28(null));
							Class432.Struct48[] array = new Class432.Struct48[46];
							Class411.smethod_0(contact3.vmethod_30(null), contact3.vmethod_28(null), 10.0, 45, ref array);
							List<GeoPoint> list = new List<GeoPoint>();
							foreach (Class432.Struct48 @struct in array)
							{
								list.Add(new GeoPoint(@struct.double_0, @struct.double_1));
							}
							contact3.method_113(list);
							this.concurrentQueue_0.Enqueue(new Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>(contact3, ((Weapon)contact_0.activeUnit_0).method_177(), new List<Sensor>(), 0f, ActiveUnit_Sensory.Enum35.const_1, this.activeUnit_0.scenario_0.method_31()));
						}
					}
				}
			}
			if (contact_0.contactType_0 == Contact_Base.ContactType.Missile)
			{
				Weapon weapon2 = (Weapon)contact_0.activeUnit_0;
				if (!weapon2.method_208() && !Information.IsNothing(weapon2.method_177()))
				{
					if (weapon2.method_177().bool_5)
					{
						if (weapon2.method_36(weapon2.method_177()) < 5f)
						{
							bool flag3 = false;
							try
							{
								foreach (Contact contact4 in this.activeUnit_0.vmethod_7(false).method_44())
								{
									if (contact4.contactType_0 == Contact_Base.ContactType.Submarine && Math.Abs(Class437.smethod_3(Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact4.vmethod_30(null), contact4.vmethod_28(null)), Math2.smethod_17(this.activeUnit_0.vmethod_30(null), this.activeUnit_0.vmethod_28(null), contact_0.vmethod_30(null), contact_0.vmethod_28(null)))) < 45f)
									{
										flag3 = true;
										break;
									}
								}
							}
							finally
							{
								List<Contact>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							if (!flag3)
							{
								bool flag4;
								try
								{
									foreach (Contact contact5 in this.activeUnit_0.vmethod_7(false).method_44())
									{
										if (contact5.contactType_0 == Contact_Base.ContactType.Submarine && contact5.activeUnit_0 == ((Weapon)contact_0.activeUnit_0).method_177())
										{
											flag4 = true;
											break;
										}
									}
								}
								finally
								{
									List<Contact>.Enumerator enumerator4;
									((IDisposable)enumerator4).Dispose();
								}
								if (!flag4)
								{
									Contact contact6 = new Contact(((Weapon)contact_0.activeUnit_0).method_177(), 0);
									contact6.vmethod_31(null, contact_0.activeUnit_0.vmethod_30(null));
									contact6.vmethod_29(null, contact_0.activeUnit_0.vmethod_28(null));
									Class432.Struct48[] array3 = new Class432.Struct48[46];
									Class411.smethod_0(contact6.vmethod_30(null), contact6.vmethod_28(null), 1.0, 45, ref array3);
									List<GeoPoint> list2 = new List<GeoPoint>();
									foreach (Class432.Struct48 struct2 in array3)
									{
										list2.Add(new GeoPoint(struct2.double_0, struct2.double_1));
									}
									contact6.method_113(list2);
									this.concurrentQueue_0.Enqueue(new Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>(contact6, ((Weapon)contact_0.activeUnit_0).method_177(), new List<Sensor>(), 0f, ActiveUnit_Sensory.Enum35.const_2, this.activeUnit_0.scenario_0.method_31()));
									return;
								}
							}
						}
					}
					else
					{
						Contact contact7 = this.activeUnit_0.vmethod_7(false).method_11()[weapon2.method_177().string_0];
						if (!Information.IsNothing(contact7) && contact7.method_130(this.activeUnit_0.vmethod_7(false)) != Misc.PostureStance.Hostile && !Information.IsNothing(weapon2.vmethod_142().vmethod_3()) && weapon2.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.ActivationPoint && weapon2.vmethod_142().vmethod_3().contactType_0 != Contact_Base.ContactType.Aimpoint)
						{
							Contact contact8 = weapon2.vmethod_142().vmethod_3();
							if (!Information.IsNothing(contact8.activeUnit_0) && (contact8.activeUnit_0.vmethod_7(false) == this.activeUnit_0.vmethod_7(false) || contact8.activeUnit_0.vmethod_7(false).method_68(this.activeUnit_0.vmethod_7(false)) == Misc.PostureStance.Friendly))
							{
								bool flag5 = false;
								string text = "";
								if (contact7.method_125() > Contact_Base.IdentificationStatus.KnownDomain)
								{
									flag5 = true;
									text = " (Reason: Contact type)";
								}
								if (!flag5)
								{
									try
									{
										foreach (int num in contact7.method_68().Keys)
										{
											if (contact7.method_68()[num].method_0(num, this.activeUnit_0.scenario_0).method_51())
											{
												flag5 = true;
												text = " (Reason: Emissions pattern)";
												break;
											}
										}
									}
									finally
									{
										IEnumerator<int> enumerator5;
										if (enumerator5 != null)
										{
											enumerator5.Dispose();
										}
									}
								}
								if (flag5)
								{
									contact7.method_131(this.activeUnit_0.vmethod_7(false), false, Misc.PostureStance.Hostile);
									this.activeUnit_0.scenario_0.method_59(string.Concat(new string[]
									{
										"Contact: ",
										contact7.Name,
										" is the most likely firing unit of ",
										contact_0.Name,
										" and is now considered as hostile!",
										text
									}), contact7.Name + " is now HOSTILE!", LoggedMessage.MessageType.ContactChange, 0, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x000B56B8 File Offset: 0x000B38B8
		protected virtual void vmethod_11(Unit unit_0, Side side_0)
		{
			try
			{
				bool flag = side_0.method_12().ContainsKey(unit_0.string_0);
				bool flag2 = side_0.lazy_1.Value.ContainsKey(unit_0.string_0);
				Contact contact;
				if (flag)
				{
					contact = side_0.method_12()[unit_0.string_0];
				}
				else
				{
					if (flag2)
					{
						return;
					}
					contact = new Contact((ActiveUnit)unit_0, 0);
				}
				contact.bool_12 = true;
				if (flag)
				{
					contact.vmethod_10(unit_0.vmethod_9());
					contact.vmethod_41(unit_0.vmethod_40());
					contact.vmethod_15(false, unit_0.vmethod_14(false));
					contact.vmethod_29(null, unit_0.vmethod_28(null));
					contact.vmethod_31(null, unit_0.vmethod_30(null));
				}
				else
				{
					ActiveUnit_Sensory.smethod_7(contact, ref this.activeUnit_0.scenario_0, side_0, unit_0, this.activeUnit_0, Contact_Base.IdentificationStatus.PreciseID);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100250", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000B57EC File Offset: 0x000B39EC
		private void method_27(Contact contact_0, float float_0)
		{
			if (!contact_0.bool_18 || !contact_0.bool_17 || !contact_0.bool_19)
			{
				float num = this.method_48(contact_0, float_0);
				if (num >= 0.5f)
				{
					if (num < 0.65f)
					{
						contact_0.bool_17 = true;
						return;
					}
					if (num < 0.85f)
					{
						contact_0.bool_17 = true;
						contact_0.bool_18 = true;
						return;
					}
					contact_0.bool_17 = true;
					contact_0.bool_18 = true;
					contact_0.bool_19 = true;
				}
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x000B5860 File Offset: 0x000B3A60
		private void method_28(Contact contact_0, float float_0)
		{
			if (!contact_0.bool_18 || !contact_0.bool_17)
			{
				if (Information.IsNothing(contact_0.method_112()))
				{
					contact_0.bool_17 = true;
					contact_0.bool_18 = true;
					return;
				}
				float num = this.method_47(contact_0, float_0);
				if (num >= 0.5f)
				{
					if (num < 0.75f)
					{
						contact_0.bool_18 = true;
						return;
					}
					contact_0.bool_17 = true;
					contact_0.bool_18 = true;
				}
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000B58C8 File Offset: 0x000B3AC8
		public void method_29(ActiveUnit activeUnit_1, Contact contact_0, Sensor sensor_0)
		{
			Contact.Class269 @class = new Contact.Class269();
			@class.string_0 = activeUnit_1.string_0;
			@class.float_0 = 0f;
			@class.identificationStatus_0 = Contact_Base.IdentificationStatus.KnownDomain;
			contact_0.method_73(this.activeUnit_0.vmethod_7(false)).Add(@class);
			LoggedMessage.MessageType messageType_ = LoggedMessage.MessageType.ContactChange;
			if (!this.activeUnit_0.vmethod_90().vmethod_1())
			{
				messageType_ = LoggedMessage.MessageType.CommsIsolatedMessage;
			}
			this.activeUnit_0.method_124(string.Concat(new string[]
			{
				"New ",
				activeUnit_1.method_63().ToLower(),
				" spotted on ",
				contact_0.Name,
				" by ",
				this.activeUnit_0.Name,
				" (Sensor: ",
				sensor_0.Name,
				"). "
			}), "Contact report", messageType_, 0, false, new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000B59C0 File Offset: 0x000B3BC0
		private void method_30(AirFacility airFacility_0, Sensor sensor_0, Contact contact_0, float float_0)
		{
			if (airFacility_0.method_33() && airFacility_0.method_24().Count != 0)
			{
				LoggedMessage.MessageType messageType_ = LoggedMessage.MessageType.ContactChange;
				if (!this.activeUnit_0.vmethod_90().vmethod_1())
				{
					messageType_ = LoggedMessage.MessageType.CommsIsolatedMessage;
				}
				float num;
				try
				{
					foreach (Aircraft aircraft in airFacility_0.method_24().Values)
					{
						num = sensor_0.method_91(this.activeUnit_0, aircraft);
						if (num * 3f >= float_0)
						{
							Contact.Class269 @class = null;
							try
							{
								foreach (Contact.Class269 class2 in contact_0.method_73(this.activeUnit_0.vmethod_7(false)))
								{
									if (Operators.CompareString(class2.string_0, aircraft.string_0, false) == 0)
									{
										@class = class2;
										@class.float_0 = 0f;
										break;
									}
								}
								goto IL_27C;
							}
							finally
							{
								List<Contact.Class269>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							goto IL_E4;
							IL_26C:
							contact_0.float_11 = 0f;
							continue;
							IL_27C:
							if (Information.IsNothing(@class))
							{
								this.method_29(aircraft, contact_0, sensor_0);
								goto IL_26C;
							}
							IL_E4:
							if (float_0 < num)
							{
								if (@class.identificationStatus_0 < Contact_Base.IdentificationStatus.KnownClass)
								{
									@class.identificationStatus_0 = Contact_Base.IdentificationStatus.KnownClass;
									this.activeUnit_0.method_124(string.Concat(new string[]
									{
										"Aircraft previously spotted on ",
										contact_0.Name,
										" has been identified as: ",
										aircraft.string_2,
										" (recon by: ",
										this.activeUnit_0.Name,
										" - Sensor: ",
										sensor_0.Name,
										"). "
									}), "Contact report", messageType_, 0, false, new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
								}
							}
							else if (float_0 < num * 2f && @class.identificationStatus_0 < Contact_Base.IdentificationStatus.KnownType)
							{
								@class.identificationStatus_0 = Contact_Base.IdentificationStatus.KnownType;
								this.activeUnit_0.method_124(string.Concat(new string[]
								{
									"Aircraft previously spotted on ",
									contact_0.Name,
									" has been type-classified as: ",
									aircraft.vmethod_58(),
									" (recon by: ",
									this.activeUnit_0.Name,
									" - Sensor: ",
									sensor_0.Name,
									"). "
								}), "Contact report", messageType_, 0, false, new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
							}
							@class.float_0 = 0f;
							goto IL_26C;
						}
					}
				}
				finally
				{
					IEnumerator<Aircraft> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				Lazy<List<Contact.Class269>> lazy = new Lazy<List<Contact.Class269>>();
				try
				{
					foreach (Contact.Class269 class3 in contact_0.method_73(this.activeUnit_0.vmethod_7(false)))
					{
						ActiveUnit activeUnit;
						this.activeUnit_0.scenario_0.vmethod_0().TryGetValue(class3.string_0, ref activeUnit);
						if (Information.IsNothing(activeUnit))
						{
							if (float_0 < num * 2f)
							{
								lazy.Value.Add(class3);
							}
						}
						else if (!airFacility_0.method_18().vmethod_93().method_14().Contains(activeUnit) && (!activeUnit.bool_3 || !airFacility_0.method_18().vmethod_92().vmethod_4().Contains((Aircraft)activeUnit)) && float_0 < num * 2f)
						{
							lazy.Value.Add(class3);
						}
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				try
				{
					foreach (Contact.Class269 class269_ in lazy.Value)
					{
						this.method_76(contact_0, class269_);
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x000B5DE8 File Offset: 0x000B3FE8
		public void method_31(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0)
		{
			if ((Information.IsNothing(contact_0.activeUnit_0) || !contact_0.activeUnit_0.bool_5) && !activeUnit_1.bool_3 && sensor_0.method_26(true, false))
			{
				float float_ = this.activeUnit_0.method_37(activeUnit_1, 0f);
				foreach (AirFacility airFacility_ in activeUnit_1.vmethod_99())
				{
					this.method_30(airFacility_, sensor_0, contact_0, float_);
				}
				foreach (DockFacility dockFacility_ in activeUnit_1.vmethod_100())
				{
					this.method_75(dockFacility_, sensor_0, contact_0, float_);
				}
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000B5E84 File Offset: 0x000B4084
		public void method_32(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0)
		{
			try
			{
				if (Information.IsNothing(contact_0.activeUnit_0) || !contact_0.activeUnit_0.bool_5 || ((Submarine)contact_0.activeUnit_0).method_161())
				{
					if (!activeUnit_1.bool_3)
					{
						if (sensor_0.method_26(true, true))
						{
							string text = Misc.smethod_54(contact_0.method_74(this.activeUnit_0.vmethod_7(false))) + Misc.smethod_52(contact_0.method_76(this.activeUnit_0.vmethod_7(false)));
							if (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5)
							{
								text += Misc.smethod_53(contact_0.method_78(this.activeUnit_0.vmethod_7(false)));
							}
							Sensor.Sensor_Type sensor_Type_ = sensor_0.sensor_Type_0;
							if (sensor_Type_ != Sensor.Sensor_Type.Radar)
							{
								if (sensor_Type_ - Sensor.Sensor_Type.Visual <= 1)
								{
									this.method_34(contact_0, activeUnit_1, sensor_0);
									this.method_35(contact_0, activeUnit_1, sensor_0);
									this.method_36(contact_0, activeUnit_1, sensor_0);
								}
							}
							else if (sensor_0.struct33_0.bool_1)
							{
								this.method_34(contact_0, activeUnit_1, sensor_0);
							}
							if (sensor_0.method_74() && !sensor_0.method_43())
							{
								this.method_36(contact_0, activeUnit_1, sensor_0);
							}
							string text2 = Misc.smethod_54(contact_0.method_74(this.activeUnit_0.vmethod_7(false))) + Misc.smethod_52(contact_0.method_76(this.activeUnit_0.vmethod_7(false)));
							if (this.activeUnit_0.bool_6 || this.activeUnit_0.bool_5)
							{
								text2 += Misc.smethod_53(contact_0.method_78(this.activeUnit_0.vmethod_7(false)));
							}
							if (string.CompareOrdinal(text2, text) != 0 && !string.IsNullOrEmpty(text))
							{
								this.method_33(contact_0, this.activeUnit_0.vmethod_7(false));
							}
							if (!Information.IsNothing(contact_0))
							{
								contact_0.method_60(0f);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100251", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000B60A8 File Offset: 0x000B42A8
		public void method_33(Contact contact_0, Side side_0)
		{
			try
			{
				if (!Information.IsNothing(contact_0.activeUnit_0))
				{
					string text = this.activeUnit_0.Name + " reports BDA status change on contact: " + contact_0.Name;
					if (contact_0.method_74(side_0) != null)
					{
						text = text + " - " + Misc.smethod_54(contact_0.method_74(side_0));
					}
					if (contact_0.method_76(side_0) != null)
					{
						text = text + " - " + Misc.smethod_52(contact_0.method_76(side_0));
					}
					if ((contact_0.activeUnit_0.bool_6 || contact_0.activeUnit_0.bool_5) && contact_0.method_78(side_0) != null)
					{
						text = text + " - " + Misc.smethod_53(contact_0.method_78(side_0));
					}
					long num = this.activeUnit_0.scenario_0.method_55();
					this.activeUnit_0.scenario_0.method_56();
					LoggedMessage loggedMessage = new LoggedMessage(num, text, "Contact report", LoggedMessage.MessageType.ContactChange, this.activeUnit_0.scenario_0.method_31(), this.activeUnit_0.string_0, 0, side_0, new Geopoint_Struct?(new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null))));
					this.lazy_0.Value.TryAdd(num, loggedMessage);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100252", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000B625C File Offset: 0x000B445C
		private void method_34(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0)
		{
			try
			{
				if (!Information.IsNothing(activeUnit_1) && !activeUnit_1.bool_3 && !activeUnit_1.bool_2)
				{
					float num = activeUnit_1.vmethod_91().method_0();
					if (num == 0f)
					{
						contact_0.method_75(this.activeUnit_0.vmethod_7(false), new Contact.Enum47?(Contact.Enum47.const_0));
					}
					else if (num < 20f)
					{
						contact_0.method_75(this.activeUnit_0.vmethod_7(false), new Contact.Enum47?(Contact.Enum47.const_1));
					}
					else if (num < 50f)
					{
						contact_0.method_75(this.activeUnit_0.vmethod_7(false), new Contact.Enum47?(Contact.Enum47.const_2));
					}
					else if (num < 100f)
					{
						contact_0.method_75(this.activeUnit_0.vmethod_7(false), new Contact.Enum47?(Contact.Enum47.const_3));
					}
					else
					{
						contact_0.method_75(this.activeUnit_0.vmethod_7(false), new Contact.Enum47?(Contact.Enum47.const_4));
					}
				}
				else
				{
					contact_0.method_75(this.activeUnit_0.vmethod_7(false), null);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100253", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000B63A4 File Offset: 0x000B45A4
		private void method_35(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0)
		{
			try
			{
				if (!Information.IsNothing(activeUnit_1) && !activeUnit_1.bool_3 && !activeUnit_1.bool_2)
				{
					contact_0.method_77(this.activeUnit_0.vmethod_7(false), new ActiveUnit_Damage.FireIntensityLevel?(activeUnit_1.vmethod_91().vmethod_3()));
				}
				else
				{
					contact_0.method_77(this.activeUnit_0.vmethod_7(false), null);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100254", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000B6450 File Offset: 0x000B4650
		private void method_36(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0)
		{
			try
			{
				if (!Information.IsNothing(activeUnit_1) && !activeUnit_1.bool_3 && !activeUnit_1.bool_2)
				{
					contact_0.method_79(this.activeUnit_0.vmethod_7(false), new ActiveUnit_Damage.FloodingIntensityLevel?(activeUnit_1.vmethod_91().vmethod_1()));
				}
				else
				{
					contact_0.method_79(this.activeUnit_0.vmethod_7(false), null);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100255", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000B64FC File Offset: 0x000B46FC
		private Contact_Base.IdentificationStatus? method_37(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0, float float_0)
		{
			Contact_Base.IdentificationStatus? result;
			try
			{
				if (!sensor_0.struct33_0.bool_2 && !sensor_0.struct33_0.bool_3)
				{
					result = null;
				}
				else if (contact_0.contactType_0 != Contact_Base.ContactType.Air)
				{
					result = null;
				}
				else if (contact_0.method_125() >= Contact_Base.IdentificationStatus.KnownClass)
				{
					result = null;
				}
				else
				{
					if (sensor_0.struct33_0.bool_2 && Math.Abs(this.activeUnit_0.method_46(activeUnit_1, true)) <= 15f)
					{
						float num = 0.75f;
						float num2 = 0.5f;
						if (sensor_0.method_50())
						{
							num = (float)((double)num * 1.25);
							num2 = (float)((double)num2 * 1.25);
						}
						GlobalVariables.TechGenerationClass techGenerationClass_ = sensor_0.techGenerationClass_0;
						if (techGenerationClass_ - GlobalVariables.TechGenerationClass.Early1950s > 3)
						{
							if (techGenerationClass_ - GlobalVariables.TechGenerationClass.Early1970s <= 2)
							{
								GlobalVariables.ProficiencyLevel? proficiencyLevel = this.activeUnit_0.vmethod_53();
								int? num3 = (proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null;
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num = (float)((double)num * 0.25);
									num2 = (float)((double)num2 * 0.25);
								}
								else
								{
									num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
									if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										num = (float)((double)num * 0.5);
										num2 = (float)((double)num2 * 0.5);
									}
									else
									{
										num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
										bool? flag2;
										bool? flag = flag2 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null);
										bool? flag3;
										bool? flag4;
										if (flag2 != null && flag.GetValueOrDefault())
										{
											flag3 = new bool?(true);
										}
										else
										{
											num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											flag4 = (flag2 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null));
											flag3 = ((flag2 != null) ? (flag | flag4.GetValueOrDefault()) : null);
										}
										bool? flag5 = flag4 = flag3;
										bool? flag6;
										bool? flag7;
										if (flag4 != null && flag5.GetValueOrDefault())
										{
											flag6 = new bool?(true);
										}
										else
										{
											num3 = ((proficiencyLevel != null) ? new int?((int)proficiencyLevel.GetValueOrDefault()) : null);
											flag7 = (flag4 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null));
											flag6 = ((flag4 != null) ? (flag5 | flag7.GetValueOrDefault()) : null);
										}
										flag7 = flag6;
										flag7.GetValueOrDefault();
									}
								}
							}
						}
						else
						{
							GlobalVariables.ProficiencyLevel? proficiencyLevel2 = this.activeUnit_0.vmethod_53();
							int? num3 = (proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num = (float)((double)num * 0.1);
								num2 = (float)((double)num2 * 0.1);
							}
							else
							{
								num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									num = (float)((double)num * 0.25);
									num2 = (float)((double)num2 * 0.25);
								}
								else
								{
									num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
									if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										num = (float)((double)num * 0.5);
										num2 = (float)((double)num2 * 0.5);
									}
									else
									{
										num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
										if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num3 = ((proficiencyLevel2 != null) ? new int?((int)proficiencyLevel2.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												num = (float)((double)num * 1.5);
												num2 = (float)((double)num2 * 1.5);
											}
										}
									}
								}
							}
						}
						float num4 = float_0 / sensor_0.float_0;
						if (num4 > num)
						{
						}
						if (num4 <= num2)
						{
							return new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
						}
					}
					if (sensor_0.struct33_0.bool_3)
					{
						float num5 = 0.6f;
						float num6 = 0.3f;
						GlobalVariables.TechGenerationClass techGenerationClass_2 = sensor_0.techGenerationClass_0;
						if (techGenerationClass_2 - GlobalVariables.TechGenerationClass.Early1950s > 3)
						{
							if (techGenerationClass_2 - GlobalVariables.TechGenerationClass.Early1970s <= 2)
							{
								GlobalVariables.ProficiencyLevel? proficiencyLevel3 = this.activeUnit_0.vmethod_53();
								int? num3 = (proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null;
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
								{
									num5 = (float)((double)num5 * 0.25);
									num6 = (float)((double)num6 * 0.25);
								}
								else
								{
									num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
									if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
									{
										num5 = (float)((double)num5 * 0.5);
										num6 = (float)((double)num6 * 0.5);
									}
									else
									{
										num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
										bool? flag2;
										bool? flag4 = flag2 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null);
										bool? flag;
										bool? flag8;
										if (flag2 != null && flag4.GetValueOrDefault())
										{
											flag8 = new bool?(true);
										}
										else
										{
											num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
											flag = (flag2 = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null));
											flag8 = ((flag2 != null) ? (flag4 | flag.GetValueOrDefault()) : null);
										}
										bool? flag7 = flag = flag8;
										bool? flag5;
										bool? flag9;
										if (flag != null && flag7.GetValueOrDefault())
										{
											flag9 = new bool?(true);
										}
										else
										{
											num3 = ((proficiencyLevel3 != null) ? new int?((int)proficiencyLevel3.GetValueOrDefault()) : null);
											flag5 = (flag = ((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null));
											flag9 = ((flag != null) ? (flag7 | flag5.GetValueOrDefault()) : null);
										}
										flag5 = flag9;
										flag5.GetValueOrDefault();
									}
								}
							}
						}
						else
						{
							GlobalVariables.ProficiencyLevel? proficiencyLevel4 = this.activeUnit_0.vmethod_53();
							int? num3 = (proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null;
							if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 0) : null).GetValueOrDefault())
							{
								num5 = (float)((double)num5 * 0.1);
								num6 = (float)((double)num6 * 0.1);
							}
							else
							{
								num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
								if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 1) : null).GetValueOrDefault())
								{
									num5 = (float)((double)num5 * 0.25);
									num6 = (float)((double)num6 * 0.25);
								}
								else
								{
									num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
									if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 2) : null).GetValueOrDefault())
									{
										num5 = (float)((double)num5 * 0.5);
										num6 = (float)((double)num6 * 0.5);
									}
									else
									{
										num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
										if (!((num3 != null) ? new bool?(num3.GetValueOrDefault() == 3) : null).GetValueOrDefault())
										{
											num3 = ((proficiencyLevel4 != null) ? new int?((int)proficiencyLevel4.GetValueOrDefault()) : null);
											if (((num3 != null) ? new bool?(num3.GetValueOrDefault() == 4) : null).GetValueOrDefault())
											{
												num5 = (float)((double)num5 * 1.5);
												num6 = (float)((double)num6 * 1.5);
											}
										}
									}
								}
							}
						}
						float num7 = float_0 / sensor_0.float_0;
						if (num7 < num5)
						{
						}
						if (num7 >= num6)
						{
							result = new Contact_Base.IdentificationStatus?(Contact_Base.IdentificationStatus.KnownClass);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100256", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000B6FE8 File Offset: 0x000B51E8
		private Contact_Base.IdentificationStatus method_38(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0)
		{
			Contact_Base.IdentificationStatus result;
			try
			{
				if (contact_0.method_125() >= Contact_Base.IdentificationStatus.KnownClass)
				{
					result = Contact_Base.IdentificationStatus.Unknown;
				}
				else if (contact_0.float_12 < 15f)
				{
					result = Contact_Base.IdentificationStatus.Unknown;
				}
				else if (!contact_0.method_67())
				{
					result = Contact_Base.IdentificationStatus.Unknown;
				}
				else
				{
					Scenario scenario_ = this.activeUnit_0.scenario_0;
					GlobalVariables.ActiveUnitType activeUnitType_;
					switch (contact_0.contactType_0)
					{
					case Contact_Base.ContactType.Air:
						activeUnitType_ = GlobalVariables.ActiveUnitType.Aircraft;
						goto IL_91;
					case Contact_Base.ContactType.Missile:
					case Contact_Base.ContactType.Torpedo:
						activeUnitType_ = GlobalVariables.ActiveUnitType.Weapon;
						goto IL_91;
					case Contact_Base.ContactType.Surface:
						activeUnitType_ = GlobalVariables.ActiveUnitType.Ship;
						goto IL_91;
					case Contact_Base.ContactType.Submarine:
						activeUnitType_ = GlobalVariables.ActiveUnitType.Submarine;
						goto IL_91;
					case Contact_Base.ContactType.Facility_Fixed:
					case Contact_Base.ContactType.Facility_Mobile:
						activeUnitType_ = GlobalVariables.ActiveUnitType.Facility;
						goto IL_91;
					}
					return Contact_Base.IdentificationStatus.Unknown;
					IL_91:
					List<int> list = new List<int>();
					try
					{
						foreach (int num in contact_0.method_68().Keys)
						{
							if (contact_0.method_68()[num].bool_1)
							{
								list.Add(num);
							}
						}
					}
					finally
					{
						IEnumerator<int> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					if (Information.IsNothing(contact_0.list_7))
					{
						contact_0.list_7 = DBFunctions.smethod_10(list, activeUnitType_, scenario_, scenario_.method_39());
					}
					list = null;
					if (contact_0.list_7.Count == 0)
					{
						result = Contact_Base.IdentificationStatus.Unknown;
					}
					else
					{
						Contact_Base.IdentificationStatus identificationStatus = Contact_Base.IdentificationStatus.Unknown;
						if (contact_0.list_7.Count == 1)
						{
							contact_0.float_12 = 0f;
							result = Contact_Base.IdentificationStatus.KnownClass;
						}
						else
						{
							HashSet<int> hashSet = new HashSet<int>();
							switch (activeUnitType_)
							{
							case GlobalVariables.ActiveUnitType.Aircraft:
								try
								{
									foreach (int int_ in contact_0.list_7)
									{
										hashSet.Add(DBFunctions.smethod_20(ref scenario_, int_));
									}
									goto IL_2C5;
								}
								finally
								{
									List<int>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								break;
							case GlobalVariables.ActiveUnitType.Ship:
								break;
							case GlobalVariables.ActiveUnitType.Submarine:
								goto IL_1F9;
							case GlobalVariables.ActiveUnitType.Facility:
								goto IL_23F;
							case GlobalVariables.ActiveUnitType.Aimpoint:
								goto IL_2C5;
							case GlobalVariables.ActiveUnitType.Weapon:
								goto IL_282;
							default:
								goto IL_2C5;
							}
							try
							{
								foreach (int int_2 in contact_0.list_7)
								{
									hashSet.Add(DBFunctions.smethod_22(ref scenario_, int_2));
								}
								goto IL_2C5;
							}
							finally
							{
								List<int>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							IL_1F9:
							try
							{
								foreach (int int_3 in contact_0.list_7)
								{
									hashSet.Add(DBFunctions.smethod_24(ref scenario_, int_3));
								}
								goto IL_2C5;
							}
							finally
							{
								List<int>.Enumerator enumerator4;
								((IDisposable)enumerator4).Dispose();
							}
							IL_23F:
							try
							{
								foreach (int int_4 in contact_0.list_7)
								{
									hashSet.Add(DBFunctions.smethod_26(ref scenario_, int_4));
								}
								goto IL_2C5;
							}
							finally
							{
								List<int>.Enumerator enumerator5;
								((IDisposable)enumerator5).Dispose();
							}
							IL_282:
							try
							{
								foreach (int int_5 in contact_0.list_7)
								{
									hashSet.Add(DBFunctions.smethod_29(ref scenario_, int_5));
								}
							}
							finally
							{
								List<int>.Enumerator enumerator6;
								((IDisposable)enumerator6).Dispose();
							}
							IL_2C5:
							if (hashSet.Count == 1)
							{
								contact_0.float_12 = 0f;
								identificationStatus = Contact_Base.IdentificationStatus.KnownType;
							}
							if (identificationStatus < Contact_Base.IdentificationStatus.KnownType)
							{
								short num2 = (short)(30 + (sensor_0.techGenerationClass_0 - GlobalVariables.TechGenerationClass.Early1970s));
								float float_ = contact_0.float_16;
								if (float_ >= 180f)
								{
									if (float_ < 360f)
									{
										num2 += 5;
									}
									else if (float_ < 540f)
									{
										num2 += 10;
									}
									else if (float_ < 720f)
									{
										num2 += 15;
									}
									else if (float_ < 900f)
									{
										num2 += 25;
									}
									else
									{
										num2 += 30;
									}
								}
								int count = hashSet.Count;
								if (count < 5)
								{
									num2 = (short)Math.Round((double)num2 / 2.0);
								}
								else if (count < 10)
								{
									num2 = (short)Math.Round((double)num2 / 5.0);
								}
								else
								{
									num2 = (short)Math.Round((double)num2 / 10.0);
								}
								if (GameGeneral.smethod_5().Next(0, 101) < (int)num2)
								{
									contact_0.float_12 = 0f;
									identificationStatus = Contact_Base.IdentificationStatus.KnownType;
								}
							}
							if (contact_0.list_7.Count == 1)
							{
								contact_0.float_12 = 0f;
								identificationStatus = Contact_Base.IdentificationStatus.KnownClass;
							}
							else
							{
								byte b = (byte)(10 + (sensor_0.techGenerationClass_0 - GlobalVariables.TechGenerationClass.Early1970s));
								float float_2 = contact_0.float_16;
								if (float_2 >= 180f)
								{
									if (float_2 < 360f)
									{
										b += 5;
									}
									else if (float_2 < 540f)
									{
										b += 10;
									}
									else if (float_2 < 720f)
									{
										b += 15;
									}
									else if (float_2 < 900f)
									{
										b += 25;
									}
									else
									{
										b += 30;
									}
								}
								int num3 = DBFunctions.smethod_9(contact_0.list_7, activeUnitType_, this.activeUnit_0.scenario_0.method_39());
								if (num3 < 5)
								{
									b = (byte)Math.Round((double)b / 2.0);
								}
								else if (num3 < 10)
								{
									b = (byte)Math.Round((double)b / 5.0);
								}
								else
								{
									b = (byte)Math.Round((double)b / 10.0);
								}
								if (GameGeneral.smethod_5().Next(40, 101) < (int)b)
								{
									contact_0.float_12 = 0f;
									identificationStatus = Contact_Base.IdentificationStatus.KnownClass;
								}
							}
							hashSet = null;
							result = identificationStatus;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100257", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Contact_Base.IdentificationStatus.Unknown;
			}
			return result;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000B75E0 File Offset: 0x000B57E0
		private Contact_Base.IdentificationStatus method_39(Contact contact_0, ActiveUnit activeUnit_1, Sensor sensor_0)
		{
			Contact_Base.IdentificationStatus result;
			try
			{
				int num;
				switch (activeUnit_1.method_98())
				{
				case GlobalVariables.Enum145.const_0:
					if (sensor_0.method_28(Sensor.FrequencyBand.const_31))
					{
						num = 25;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_28))
					{
						num = 20;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_29))
					{
						num = 15;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_30))
					{
						num = 10;
					}
					break;
				case GlobalVariables.Enum145.const_1:
					if (sensor_0.method_28(Sensor.FrequencyBand.const_31))
					{
						num = 20;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_28))
					{
						num = 15;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_29))
					{
						num = 10;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_30))
					{
						num = 5;
					}
					break;
				case GlobalVariables.Enum145.const_2:
					if (sensor_0.method_28(Sensor.FrequencyBand.const_31))
					{
						num = 15;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_28))
					{
						num = 10;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_29))
					{
						num = 5;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_30))
					{
						num = -1;
					}
					break;
				case GlobalVariables.Enum145.const_3:
					if (sensor_0.method_28(Sensor.FrequencyBand.const_31))
					{
						num = 10;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_28))
					{
						num = 5;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_29))
					{
						num = -1;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_30))
					{
						num = -1;
					}
					break;
				case GlobalVariables.Enum145.const_4:
					if (sensor_0.method_28(Sensor.FrequencyBand.const_31))
					{
						num = 5;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_28))
					{
						num = -1;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_29))
					{
						num = -1;
					}
					else if (sensor_0.method_28(Sensor.FrequencyBand.const_30))
					{
						num = -1;
					}
					break;
				}
				if (num < 0)
				{
					result = Contact_Base.IdentificationStatus.Unknown;
				}
				else
				{
					float num2 = activeUnit_1.vmethod_70();
					if (num2 >= 6f)
					{
						if (num2 < 12f)
						{
							num += 5;
						}
						else if (num2 < 18f)
						{
							num += 10;
						}
						else if (num2 < 24f)
						{
							num += 15;
						}
						else
						{
							num += 20;
						}
					}
					if (activeUnit_1.bool_5 && ((Submarine)activeUnit_1).vmethod_93().method_8() == ActiveUnit_DockingOps._DockingOpsCondition.RechargingBatteries)
					{
						num += 15;
					}
					float float_ = contact_0.float_16;
					int num3;
					if (float_ < 360f)
					{
						num3 = num;
					}
					else if (float_ < 720f)
					{
						num3 = num + 5;
					}
					else if (float_ < 1080f)
					{
						num3 = num + 10;
					}
					else if (float_ < 1440f)
					{
						num3 = num + 15;
					}
					else if (float_ < 1800f)
					{
						num3 = num + 25;
					}
					else
					{
						num3 = num + 30;
					}
					int num4 = (int)Math.Round((double)num3 / 2.0);
					int num5 = num3 + 20;
					int num6 = GameGeneral.smethod_5().Next(20, 101);
					if (num6 < num4)
					{
						result = Contact_Base.IdentificationStatus.PreciseID;
					}
					else if (num6 < num3)
					{
						result = Contact_Base.IdentificationStatus.KnownClass;
					}
					else if (num6 < num5)
					{
						result = Contact_Base.IdentificationStatus.KnownType;
					}
					else
					{
						result = Contact_Base.IdentificationStatus.KnownDomain;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100258", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Contact_Base.IdentificationStatus.KnownDomain;
			}
			return result;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000B7960 File Offset: 0x000B5B60
		public static void smethod_5(ref Contact theContact, ref Scenario theScen, Side theDetectingSide, Unit theDetectedUnit, ActiveUnit_Sensory.Enum35 theSpecialDetectionMode, ActiveUnit DetectorUnit = null, Contact_Base.IdentificationStatus IDStatus = Contact_Base.IdentificationStatus.KnownDomain, List<Sensor> DetectingSensors = null)
		{
			try
			{
				List<GeoPoint> list_ = null;
				ObservableDictionary<int, EmissionContainer> observableDictionary_ = null;
				float float_ = 0f;
				if (!Information.IsNothing(theContact))
				{
					if (!Information.IsNothing(theContact.method_112()))
					{
						list_ = theContact.method_112();
					}
					if (theContact.method_67())
					{
						observableDictionary_ = theContact.method_68();
					}
					float_ = theContact.method_96();
				}
				theDetectingSide.int_1++;
				theContact = new Contact((ActiveUnit)theDetectedUnit, theDetectingSide.int_1);
				theContact.method_113(list_);
				theContact.method_69(observableDictionary_);
				theContact.method_97(float_);
				if (Information.IsNothing(DetectorUnit))
				{
					theContact.method_126(theScen, theDetectingSide, null, null, false, true, false, true, IDStatus);
				}
				else
				{
					theContact.method_126(theScen, theDetectingSide, null, null, false, DetectorUnit.vmethod_90().vmethod_1(), false, true, IDStatus);
				}
				theContact.side_1 = theDetectingSide;
				ActiveUnit_Sensory.smethod_3(ref theContact, (ActiveUnit)theDetectedUnit, true, null);
				if (!Information.IsNothing(DetectorUnit))
				{
					if (DetectorUnit.vmethod_90().vmethod_1())
					{
						theDetectingSide.method_13(theContact);
					}
					else
					{
						DetectorUnit.vmethod_88().dictionary_0[theDetectedUnit.string_0] = theContact;
					}
				}
				else
				{
					theDetectingSide.method_13(theContact);
				}
				if (theDetectedUnit.bool_0 && ((ActiveUnit)theDetectedUnit).method_92(theDetectingSide))
				{
					theContact.method_122(true);
					theContact.bool_18 = true;
					theContact.bool_17 = true;
					theContact.bool_19 = true;
					theContact.method_142(new ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>(null, null, 0f, ActiveUnit_Sensory.Enum35.const_4, ((ActiveUnit)theDetectedUnit).scenario_0.method_31()));
				}
				else
				{
					if (!Information.IsNothing(DetectingSensors))
					{
						float float_2 = DetectorUnit.method_37(theDetectedUnit, 0f);
						try
						{
							List<Sensor>.Enumerator enumerator = DetectingSensors.GetEnumerator();
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.method_42(float_2))
								{
									theContact.method_122(true);
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
					string text;
					try
					{
						if (Information.IsNothing(theContact.method_112()))
						{
							text = Math.Round((double)DetectorUnit.method_36(theContact), 1).ToString();
						}
						else
						{
							text = "Estimated " + Math.Round((double)DetectorUnit.method_36(theContact), 0).ToString();
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200012", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						text = "[unspecified]";
					}
					string text2;
					try
					{
						text2 = ((int)Math.Round((double)DetectorUnit.vmethod_86().method_68(theContact))).ToString();
					}
					catch (Exception ex2)
					{
						ex2.Data.Add("Error at 200015", ex2.Message);
						GameGeneral.smethod_25(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						text2 = "[unspecified]";
					}
					LoggedMessage.MessageType messageType_;
					if (!Information.IsNothing(DetectorUnit) && !DetectorUnit.vmethod_90().vmethod_1())
					{
						messageType_ = LoggedMessage.MessageType.CommsIsolatedMessage;
					}
					else if (theContact.activeUnit_0.bool_2 & !theContact.activeUnit_0.method_87())
					{
						messageType_ = LoggedMessage.MessageType.NewWeaponContact;
					}
					else
					{
						switch (theContact.activeUnit_0.vmethod_56())
						{
						case GlobalVariables.ActiveUnitType.Aircraft:
							messageType_ = LoggedMessage.MessageType.NewAirContact;
							break;
						case GlobalVariables.ActiveUnitType.Ship:
							messageType_ = LoggedMessage.MessageType.NewSurfaceContact;
							break;
						case GlobalVariables.ActiveUnitType.Submarine:
							messageType_ = LoggedMessage.MessageType.NewUnderwaterContact;
							break;
						case GlobalVariables.ActiveUnitType.Facility:
							messageType_ = LoggedMessage.MessageType.NewGroundContact;
							break;
						default:
							messageType_ = LoggedMessage.MessageType.NewContact;
							break;
						}
					}
					string text3 = ActiveUnit_Sensory.smethod_6(DetectingSensors, theDetectedUnit, DetectorUnit);
					string text4 = "";
					if (DetectorUnit.bool_3 && Operators.CompareString(DetectorUnit.Name, DetectorUnit.string_2, false) != 0)
					{
						text4 = " (" + DetectorUnit.string_2 + ")";
					}
					switch (theSpecialDetectionMode)
					{
					case ActiveUnit_Sensory.Enum35.const_0:
					{
						string string_;
						switch (theContact.contactType_0)
						{
						case Contact_Base.ContactType.Air:
							string_ = "New air contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Missile:
							string_ = "New weapon contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Surface:
							string_ = "New surface contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Submarine:
							string_ = "New sub contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Orbital:
							string_ = "New space contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Facility_Fixed:
						case Contact_Base.ContactType.Installation:
						case Contact_Base.ContactType.AirBase:
						case Contact_Base.ContactType.NavalBase:
							string_ = "New fixed land contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Facility_Mobile:
						case Contact_Base.ContactType.MobileGroup:
							string_ = "New mobile land contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Torpedo:
							string_ = "New torpedo contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Mine:
							string_ = "New mine contact (" + theContact.Name + ")";
							goto IL_566;
						case Contact_Base.ContactType.Sonobuoy:
							string_ = "New sonobuoy contact (" + theContact.Name + ")";
							goto IL_566;
						}
						string_ = "New contact (" + theContact.Name + ")";
						IL_566:
						if (DetectingSensors.Count == 0)
						{
							DetectorUnit.method_124(string.Concat(new string[]
							{
								"New contact! Designated ",
								theContact.Name,
								" - Detected by ",
								DetectorUnit.Name,
								text4,
								" at ",
								Conversions.ToString((int)Math.Round((double)DetectorUnit.vmethod_86().method_68(theContact))),
								"deg - ",
								Conversions.ToString(Math.Round((double)DetectorUnit.method_36(theContact), 1)),
								"nm"
							}), string_, messageType_, 1, false, new Geopoint_Struct(theContact.vmethod_28(null), theContact.vmethod_30(null)));
						}
						else
						{
							string text5 = "";
							try
							{
								foreach (Sensor sensor in DetectingSensors)
								{
									text5 = Misc.smethod_9(sensor.Name) + ", ";
								}
							}
							finally
							{
								List<Sensor>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							if (DetectingSensors.Count > 0)
							{
								text5 = Strings.Left(text5, Strings.Len(text5) - 2);
							}
							DetectorUnit.method_124(string.Concat(new string[]
							{
								"New contact! Designated ",
								theContact.Name,
								" - Detected by ",
								DetectorUnit.Name,
								text4,
								"  [Sensors: ",
								text5,
								"] at ",
								text2,
								"deg - ",
								text,
								"nm",
								text3
							}), string_, messageType_, 1, false, new Geopoint_Struct(theContact.vmethod_28(null), theContact.vmethod_30(null)));
						}
						break;
					}
					case ActiveUnit_Sensory.Enum35.const_1:
						theScen.method_59("New probable sub contact! (Torpedo detected). Designated " + theContact.Name, "New sub contact (" + theContact.Name + ")", LoggedMessage.MessageType.NewContact, 0, null, theDetectingSide, new Geopoint_Struct(theContact.vmethod_28(null), theContact.vmethod_30(null)));
						break;
					case ActiveUnit_Sensory.Enum35.const_2:
						theScen.method_59("New probable sub contact! (Missile launch observed). Designated " + theContact.Name, "New sub contact (" + theContact.Name + ")", LoggedMessage.MessageType.NewContact, 0, null, theDetectingSide, new Geopoint_Struct(theContact.vmethod_28(null), theContact.vmethod_30(null)));
						break;
					case ActiveUnit_Sensory.Enum35.const_3:
						theScen.method_59("New probable sub contact! (Flaming datum). Designated " + theContact.Name, "New sub contact (" + theContact.Name + ")", LoggedMessage.MessageType.NewContact, 0, null, theDetectingSide, new Geopoint_Struct(theContact.vmethod_28(null), theContact.vmethod_30(null)));
						break;
					case ActiveUnit_Sensory.Enum35.const_4:
						break;
					default:
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						break;
					}
					if (!Information.IsNothing(DetectorUnit) && DetectorUnit.vmethod_90().vmethod_1())
					{
						ActiveUnit_Sensory.Delegate21 @delegate = ActiveUnit_Sensory.delegate21_0;
						if (@delegate != null)
						{
							@delegate(theDetectingSide, theContact.contactType_0);
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100259", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000B82A0 File Offset: 0x000B64A0
		private static string smethod_6(List<Sensor> list_2, Unit unit_0, ActiveUnit activeUnit_1)
		{
			if (!Information.IsNothing(list_2))
			{
				try
				{
					List<Sensor>.Enumerator enumerator = list_2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.sensor_Type_0 == Sensor.Sensor_Type.Visual)
						{
							if ((unit_0.bool_6 | unit_0.bool_5) & (activeUnit_1.bool_3 | activeUnit_1.method_2()))
							{
								Ship.Enum119 @enum;
								if (unit_0.bool_6)
								{
									@enum = ((Ship)unit_0).method_143();
								}
								if (unit_0.bool_5)
								{
									@enum = ((Submarine)unit_0).method_151();
								}
								switch (@enum)
								{
								case Ship.Enum119.const_0:
									return " - No Wake Detected.";
								case Ship.Enum119.const_1:
									return " - Very Small Wake Detected.";
								case Ship.Enum119.const_2:
									return " - Small Wake Detected.";
								case Ship.Enum119.const_3:
									return " - Medium Wake Detected.";
								case Ship.Enum119.const_4:
									return " - Large Wake Detected.";
								case Ship.Enum119.const_5:
									return " - Very Large Wake Detected.";
								}
							}
							if (unit_0.bool_3 | unit_0.method_2())
							{
								ActiveUnit.Enum29 enum2;
								if (unit_0.bool_3)
								{
									enum2 = ((ActiveUnit)unit_0).method_75();
								}
								if (unit_0.method_2())
								{
									enum2 = ((ActiveUnit)unit_0).method_75();
								}
								switch (enum2)
								{
								case ActiveUnit.Enum29.const_0:
									return " - No Contrail Detected.";
								case ActiveUnit.Enum29.const_1:
									return " - Very Small Contrail Detected.";
								case ActiveUnit.Enum29.const_2:
									return " - Small Contrail Detected.";
								case ActiveUnit.Enum29.const_3:
									return " - Medium Contrail Detected.";
								case ActiveUnit.Enum29.const_4:
									return " - Large Contrail Detected.";
								case ActiveUnit.Enum29.const_5:
									return " - Very Large Contrail Detected.";
								}
							}
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			return "";
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000B8434 File Offset: 0x000B6634
		public static void smethod_7(Contact theContact, ref Scenario theScen, Side theDetectingSide, Unit theDetectedUnit, ActiveUnit DetectorUnit = null, Contact_Base.IdentificationStatus IDStatus = Contact_Base.IdentificationStatus.KnownDomain)
		{
			try
			{
				theDetectingSide.int_2++;
				theContact = new Contact((ActiveUnit)theDetectedUnit, theDetectingSide.int_2);
				theContact.method_113(null);
				theContact.method_122(true);
				theContact.bool_18 = true;
				theContact.bool_17 = true;
				theContact.bool_19 = true;
				theContact.method_126(theScen, theDetectingSide, null, null, false, DetectorUnit.vmethod_90().vmethod_1(), false, true, IDStatus);
				theContact.side_1 = theDetectingSide;
				theContact.method_58(0f);
				theContact.method_137((ActiveUnit)theDetectedUnit);
				theDetectingSide.method_14(theContact);
				if (theDetectedUnit.bool_0 && ((ActiveUnit)theDetectedUnit).method_92(theDetectingSide) && theContact.method_125() == Contact_Base.IdentificationStatus.PreciseID)
				{
					theContact.method_142(new ValueTuple<string, string, float, ActiveUnit_Sensory.Enum35, DateTime>(null, null, 0f, ActiveUnit_Sensory.Enum35.const_4, ((ActiveUnit)theDetectedUnit).scenario_0.method_31()));
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100260", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000B8558 File Offset: 0x000B6758
		public bool method_40(Contact contact_0)
		{
			bool result;
			try
			{
				foreach (Sensor sensor in this.activeUnit_0.method_78())
				{
					if (sensor.method_43() && sensor.method_41().Contains(contact_0))
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100261", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000B85EC File Offset: 0x000B67EC
		public bool method_41(Contact contact_0, Weapon weapon_0, ref Sensor sensor_0, ref bool? nullable_0, ref bool? nullable_1, ref Unit.Enum123? nullable_2, ref bool? nullable_3)
		{
			bool result;
			if (weapon_0.bool_31)
			{
				result = true;
			}
			else
			{
				try
				{
					if (this.activeUnit_0.method_2())
					{
						result = false;
					}
					else if (!this.activeUnit_0.vmethod_127())
					{
						result = false;
					}
					else
					{
						List<ActiveUnit> list = null;
						foreach (Sensor sensor in this.activeUnit_0.method_78())
						{
							if (sensor.method_79(ref weapon_0))
							{
								if (sensor.method_82(ref contact_0))
								{
									return true;
								}
								if (sensor.vmethod_5() != PlatformComponent._ComponentStatus.Operational)
								{
									return false;
								}
								if (sensor.method_85())
								{
									if (Information.IsNothing(contact_0) || Information.IsNothing(contact_0.activeUnit_0))
									{
										return false;
									}
									ActiveUnit activeUnit = contact_0.activeUnit_0;
									if (Information.IsNothing(activeUnit))
									{
										return false;
									}
									if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar && Information.IsNothing(list))
									{
										list = this.activeUnit_0.vmethod_88().method_10(false);
									}
									if (sensor.method_123(this.activeUnit_0, activeUnit, this.activeUnit_0.method_36(contact_0), list, this.activeUnit_0.bool_6, false, ref nullable_0, ref nullable_1, ref nullable_2, ref nullable_3) == Sensor.Enum115.const_1)
									{
										sensor_0 = sensor;
										return true;
									}
								}
							}
						}
						result = false;
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100262", "");
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

		// Token: 0x06000A84 RID: 2692 RVA: 0x000B8788 File Offset: 0x000B6988
		public bool method_42(Contact contact_0, Weapon weapon_0, ref bool? nullable_0, ref bool? nullable_1, ref Unit.Enum123? nullable_2, ref bool? nullable_3)
		{
			bool result;
			try
			{
				foreach (Sensor sensor in this.activeUnit_0.method_78())
				{
					if (sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational && (sensor.method_85() || sensor.method_82(ref contact_0)) && sensor.method_79(ref weapon_0))
					{
						List<ActiveUnit> list;
						if (sensor.sensor_Type_0 == Sensor.Sensor_Type.Radar && Information.IsNothing(list))
						{
							list = this.activeUnit_0.vmethod_88().method_10(false);
						}
						if (sensor.method_123(this.activeUnit_0, contact_0.activeUnit_0, this.activeUnit_0.method_36(contact_0), list, this.activeUnit_0.bool_6, false, ref nullable_0, ref nullable_1, ref nullable_2, ref nullable_3) == Sensor.Enum115.const_1)
						{
							sensor.method_80(ref contact_0);
							if (!sensor.list_1.Contains(weapon_0))
							{
								sensor.list_1.Add(weapon_0);
								weapon_0.method_171(sensor);
							}
							return true;
						}
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100263", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000B88C4 File Offset: 0x000B6AC4
		private Contact method_43(Unit theUnit, Sensor[] mySensors, float SlantRange, ref List<Sensor> SensorsThatMadeDetection, List<ActiveUnit> AffectingJammers, ref bool? LOS_Exists_Radar, ref bool? LOS_Exists_RadarSW, ref Unit.Enum123? LOS_Exists_Visual, ref bool? LOS_Exists_Sonar, bool EmissionDetectionOnly = false)
		{
			Contact result;
			try
			{
				if (this.activeUnit_0.method_0() && theUnit.method_0() && theUnit.bool_0)
				{
					Contact_Base.ContactType contactType = ((ActiveUnit)theUnit).vmethod_86().vmethod_7();
					if (!Information.IsNothing(contactType) && (contactType == Contact_Base.ContactType.Air || contactType == Contact_Base.ContactType.Missile || contactType == Contact_Base.ContactType.Orbital))
					{
						return null;
					}
				}
				Sensor[] array;
				if (EmissionDetectionOnly)
				{
					array = Enumerable.ToArray<Sensor>(Enumerable.Where<Sensor>(mySensors, (ActiveUnit_Sensory._Closure$__.$I98-0 == null) ? (ActiveUnit_Sensory._Closure$__.$I98-0 = new Func<Sensor, bool>(ActiveUnit_Sensory._Closure$__.$I.method_2)) : ActiveUnit_Sensory._Closure$__.$I98-0));
				}
				else
				{
					array = mySensors;
				}
				int num = array.Length - 1;
				Contact contact;
				for (int i = 0; i <= num; i++)
				{
					Sensor sensor = array[i];
					if (sensor.method_64())
					{
						Sensor sensor2 = sensor;
						ActiveUnit activeUnit = (ActiveUnit)theUnit;
						if (sensor2.method_83(ref activeUnit) && sensor.method_24() && sensor.method_57() && sensor.method_123(this.activeUnit_0, (ActiveUnit)theUnit, SlantRange, AffectingJammers, this.activeUnit_0.bool_6, false, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW, ref LOS_Exists_Visual, ref LOS_Exists_Sonar) == Sensor.Enum115.const_1)
						{
							SensorsThatMadeDetection.Add(sensor);
							if (Information.IsNothing(contact))
							{
								contact = new Contact((ActiveUnit)theUnit, 0);
							}
						}
						if (sensor.method_24() && sensor.method_55() && (sensor.sensor_Type_0 != Sensor.Sensor_Type.Radar || (sensor.struct33_0.bool_19 && !sensor.struct33_0.bool_20 && !sensor.struct33_0.bool_15) || sensor.method_41().Count <= 0))
						{
							List<GeoPoint> list = null;
							Lazy<ObservableDictionary<int, EmissionContainer>> lazy = new Lazy<ObservableDictionary<int, EmissionContainer>>();
							if (sensor.method_87(Sensor.Enum114.const_0, this.activeUnit_0, (ActiveUnit)theUnit, ref list, SlantRange, ref lazy, AffectingJammers, ref LOS_Exists_Radar, ref LOS_Exists_RadarSW, ref LOS_Exists_Visual, ref LOS_Exists_Sonar))
							{
								SensorsThatMadeDetection.Add(sensor);
								if (Information.IsNothing(contact))
								{
									contact = new Contact((ActiveUnit)theUnit, 0);
									if (!Information.IsNothing(list))
									{
										contact.method_113(list);
									}
								}
								else if (!Information.IsNothing(list))
								{
									contact.method_113(list);
								}
								if (ActiveUnit_Sensory.smethod_8(sensor, this.activeUnit_0.method_36(theUnit)))
								{
									contact.method_122(true);
									contact.vmethod_31(null, theUnit.vmethod_30(null));
									contact.vmethod_29(null, theUnit.vmethod_28(null));
									if (sensor.struct32_0.bool_10)
									{
										contact.vmethod_15(false, theUnit.vmethod_14(false));
										contact.bool_19 = true;
									}
								}
								if (lazy.IsValueCreated)
								{
									try
									{
										try
										{
											foreach (int key in lazy.Value.Keys)
											{
												if (contact.method_68().ContainsKey(key))
												{
													contact.method_68()[key].float_0 = 0f;
													if (lazy.Value[key].bool_0)
													{
														contact.method_68()[key].bool_0 = true;
													}
													if (lazy.Value[key].bool_1)
													{
														contact.method_68()[key].bool_1 = true;
													}
												}
												else
												{
													contact.method_68().Add(key, new EmissionContainer(0.0, lazy.Value[key].bool_0, lazy.Value[key].bool_1));
												}
											}
										}
										finally
										{
											IEnumerator<int> enumerator;
											if (enumerator != null)
											{
												enumerator.Dispose();
											}
										}
									}
									catch (Exception ex)
									{
										ex.Data.Add("Error at 101169", "");
										GameGeneral.smethod_25(ref ex);
										if (Debugger.IsAttached)
										{
											Debugger.Break();
										}
									}
								}
							}
						}
					}
				}
				result = contact;
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100264", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000B8D08 File Offset: 0x000B6F08
		public static bool smethod_8(Sensor sensor_0, float float_0)
		{
			bool result;
			if (!sensor_0.method_42(float_0))
			{
				result = false;
			}
			else if (sensor_0.method_74() && sensor_0.method_43())
			{
				float num = (float)((double)Class568.smethod_0(sensor_0.method_18().vmethod_30(null)) - 2.5);
				result = (float_0 < num);
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x000B8D68 File Offset: 0x000B6F68
		public void method_44(Sensor[] sensor_0)
		{
			try
			{
				foreach (Sensor sensor in sensor_0)
				{
					if (sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						sensor.int_2--;
						sensor.int_3--;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100265", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000B8DF8 File Offset: 0x000B6FF8
		public void method_45(Sensor[] sensor_0)
		{
			try
			{
				foreach (Sensor sensor in sensor_0)
				{
					if (sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational && sensor.method_24())
					{
						sensor.int_2 = sensor.method_47();
						if (sensor.method_25() && !Information.IsNothing(sensor.method_18()))
						{
							sensor.int_3 = (int)sensor.method_18().short_0;
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100266", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000B8EA4 File Offset: 0x000B70A4
		public bool method_46()
		{
			bool result;
			try
			{
				foreach (Sensor sensor in this.activeUnit_0.method_78())
				{
					if (sensor.method_68() && sensor.vmethod_5() == PlatformComponent._ComponentStatus.Operational)
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100267", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000B8F34 File Offset: 0x000B7134
		public float method_47(Contact contact_0, float float_0)
		{
			float result;
			try
			{
				int num = (int)Math.Round((double)contact_0.float_16);
				if (num == 0)
				{
					result = 0f;
				}
				else if (float_0 < 10f)
				{
					result = (float)Math.Min((double)num / 600.0, 0.99);
				}
				else if (float_0 < 25f)
				{
					result = (float)Math.Min((double)num / 900.0, 0.99);
				}
				else if (float_0 < 50f)
				{
					result = (float)Math.Min((double)num / 1800.0, 0.99);
				}
				else
				{
					result = (float)Math.Min((double)num / 3600.0, 0.99);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100268", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.99f;
			}
			return result;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x000B9044 File Offset: 0x000B7244
		public float method_48(Contact contact_0, float float_0)
		{
			float result;
			try
			{
				if (Information.IsNothing(contact_0.method_112()))
				{
					result = 1f;
				}
				else
				{
					int num = (int)Math.Round((double)contact_0.float_16);
					if (num == 0)
					{
						result = 0f;
					}
					else if (float_0 < 2.5f)
					{
						result = (float)Math.Min((double)num / 600.0, 0.99);
					}
					else if (float_0 < 5f)
					{
						result = (float)Math.Min((double)num / 900.0, 0.99);
					}
					else if (float_0 < 10f)
					{
						result = (float)Math.Min((double)num / 1800.0, 0.99);
					}
					else
					{
						result = (float)Math.Min((double)num / 3600.0, 0.99);
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100269", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.99f;
			}
			return result;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000B916C File Offset: 0x000B736C
		public List<GeoPoint> method_49(Sensor sensor_0, Unit unit_0, float float_0, ObservableDictionary<int, EmissionContainer> observableDictionary_2)
		{
			List<GeoPoint> result;
			if (Information.IsNothing(this.activeUnit_0))
			{
				result = null;
			}
			else if (Information.IsNothing(this.activeUnit_0.vmethod_7(false)))
			{
				result = null;
			}
			else
			{
				float num = sensor_0.float_6;
				float num2 = sensor_0.float_8;
				bool flag = false;
				double num3 = this.activeUnit_0.vmethod_28(null);
				double num4 = this.activeUnit_0.vmethod_30(null);
				try
				{
					if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.ESM)
					{
						Contact contact = null;
						this.activeUnit_0.vmethod_7(false).method_11().TryGetValue(unit_0.string_0, ref contact);
						if (!Information.IsNothing(contact) && sensor_0.sensor_Role_0 != Sensor.Sensor_Role.ESM_RWR && float_0 <= 300f)
						{
							float num5 = this.method_47(contact, float_0);
							num = float_0 * (1f - num5);
							flag = true;
						}
					}
					else if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.Visual)
					{
						double num6 = (double)sensor_0.method_18().method_37(unit_0, 0f);
						num2 = 0.1f;
						num = (float)(num6 * 0.1);
					}
					else if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.Infrared)
					{
						float num7 = sensor_0.method_18().method_37(unit_0, 0f);
						num2 = 0.1f;
						if (sensor_0.struct33_0.bool_1)
						{
							num = (float)((double)num7 * 0.2);
						}
						else
						{
							num = (float)((double)num7 * 0.5);
						}
					}
					else
					{
						if (!sensor_0.method_74())
						{
							if (sensor_0.sensor_Type_0 != Sensor.Sensor_Type.PingIntercept)
							{
								if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.Radar)
								{
									num = float_0 / 20f;
									goto IL_236;
								}
								num *= float_0 / sensor_0.float_0;
								goto IL_236;
							}
						}
						float num8 = (float)((double)Class568.smethod_0(num4) - 2.5);
						if (float_0 < num8)
						{
							Contact contact2 = null;
							this.activeUnit_0.vmethod_7(false).method_11().TryGetValue(unit_0.string_0, ref contact2);
							if (!Information.IsNothing(contact2) && float_0 <= 20f)
							{
								float num9 = this.method_48(contact2, float_0);
								num = float_0 * (1f - num9);
								flag = true;
							}
						}
						else
						{
							num = 30f;
							num2 = 4f;
						}
					}
					IL_236:
					double num10 = (double)Math2.smethod_17(num4, num3, unit_0.vmethod_30(null), unit_0.vmethod_28(null));
					Random random = GameGeneral.smethod_5();
					float num11 = (float)Math2.smethod_6(num10 + (double)num2 * ((double)random.Next(-90, 91) / 100.0));
					float num12 = (float)Math.Max(0.0, (double)float_0 + (double)num * ((double)random.Next(-90, 91) / 100.0));
					List<GeoPoint> list = new List<GeoPoint>(6);
					float num13;
					float num14;
					if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.ESM)
					{
						if (flag)
						{
							num13 = Math.Max(num12 - num, 0f);
							num14 = num12 + num;
						}
						else
						{
							num13 = Math.Max(num12 - sensor_0.float_0 / 3f, 0f);
							float num15 = Class562.smethod_1(this.activeUnit_0, unit_0);
							if (!float.IsInfinity(num15) && !float.IsNaN(num15))
							{
								num14 = Math.Min(num15, num12 + sensor_0.float_0 / 3f);
							}
							else
							{
								num14 = num12 + sensor_0.float_0 / 3f;
							}
						}
						if (unit_0.bool_6 || unit_0.bool_8 || unit_0.bool_5)
						{
							bool flag2 = false;
							try
							{
								foreach (int num16 in observableDictionary_2.Keys)
								{
									EmissionContainer emissionContainer = observableDictionary_2[num16];
									if (emissionContainer.bool_1)
									{
										if (!emissionContainer.method_0(num16, this.activeUnit_0.scenario_0).method_67())
										{
											continue;
										}
										flag2 = true;
									}
									else
									{
										flag2 = true;
									}
									break;
								}
							}
							finally
							{
								IEnumerator<int> enumerator;
								if (enumerator != null)
								{
									enumerator.Dispose();
								}
							}
							if (!sensor_0.method_67() && !flag2)
							{
								Unit unit_ = this.activeUnit_0;
								float num17 = 0f;
								num14 = Math.Min(Class562.smethod_0(unit_, ref num17), num14);
							}
						}
					}
					else if (sensor_0.method_74())
					{
						float num18 = (float)((double)Class568.smethod_0(num4) - 2.5);
						if (float_0 < num18)
						{
							if (flag)
							{
								num13 = Math.Max(num12 - num, 0f);
								num14 = num12 + num;
							}
							else
							{
								num13 = 1E-05f;
								num14 = num18;
							}
						}
						else
						{
							num13 = num18;
							num14 = sensor_0.float_0;
						}
					}
					else if (sensor_0.sensor_Type_0 == Sensor.Sensor_Type.MAD)
					{
						num13 = 0.001f;
						num14 = sensor_0.float_0;
					}
					else
					{
						num13 = Math.Max(num12 - num, 0f);
						num14 = num12 + num;
					}
					float num19 = Math2.smethod_7(num11 - num2);
					float num20 = Math2.smethod_7(num11 + num2);
					float num21 = Math2.smethod_7(num11);
					GeoPoint geoPoint = new GeoPoint();
					double double_ = num3;
					double double_2 = num4;
					GeoPoint geoPoint2;
					double double_3 = (geoPoint2 = geoPoint).imethod_0();
					GeoPoint geoPoint3;
					double double_4 = (geoPoint3 = geoPoint).imethod_2();
					Class411.smethod_1(double_, double_2, ref double_3, ref double_4, (double)num13, (double)num19);
					geoPoint3.imethod_3(double_4);
					geoPoint2.imethod_1(double_3);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double double_5 = num3;
					double double_6 = num4;
					double_4 = (geoPoint3 = geoPoint).imethod_0();
					double_3 = (geoPoint2 = geoPoint).imethod_2();
					Class411.smethod_1(double_5, double_6, ref double_4, ref double_3, (double)num13, (double)num21);
					geoPoint2.imethod_3(double_3);
					geoPoint3.imethod_1(double_4);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double double_7 = num3;
					double double_8 = num4;
					double_3 = (geoPoint2 = geoPoint).imethod_0();
					double_4 = (geoPoint3 = geoPoint).imethod_2();
					Class411.smethod_1(double_7, double_8, ref double_3, ref double_4, (double)num13, (double)num20);
					geoPoint3.imethod_3(double_4);
					geoPoint2.imethod_1(double_3);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double double_9 = num3;
					double double_10 = num4;
					double_4 = (geoPoint3 = geoPoint).imethod_0();
					double_3 = (geoPoint2 = geoPoint).imethod_2();
					Class411.smethod_1(double_9, double_10, ref double_4, ref double_3, (double)num14, (double)num20);
					geoPoint2.imethod_3(double_3);
					geoPoint3.imethod_1(double_4);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double double_11 = num3;
					double double_12 = num4;
					double_3 = (geoPoint2 = geoPoint).imethod_0();
					double_4 = (geoPoint3 = geoPoint).imethod_2();
					Class411.smethod_1(double_11, double_12, ref double_3, ref double_4, (double)num14, (double)num21);
					geoPoint3.imethod_3(double_4);
					geoPoint2.imethod_1(double_3);
					list.Add(geoPoint);
					geoPoint = new GeoPoint();
					double double_13 = num3;
					double double_14 = num4;
					double_4 = (geoPoint3 = geoPoint).imethod_0();
					double_3 = (geoPoint2 = geoPoint).imethod_2();
					Class411.smethod_1(double_13, double_14, ref double_4, ref double_3, (double)num14, (double)num19);
					geoPoint2.imethod_3(double_3);
					geoPoint3.imethod_1(double_4);
					list.Add(geoPoint);
					try
					{
						foreach (GeoPoint geoPoint4 in list)
						{
							if (geoPoint4.imethod_2() > 90.0)
							{
								geoPoint4.imethod_3(90.0);
							}
							if (geoPoint4.imethod_2() < -90.0)
							{
								geoPoint4.imethod_3(-90.0);
							}
						}
					}
					finally
					{
						List<GeoPoint>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200585", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000B9900 File Offset: 0x000B7B00
		public static List<GeoPoint> smethod_9(List<GeoPoint> list_2, List<GeoPoint> list_3)
		{
			List<GeoPoint> result;
			try
			{
				if (list_2.Count > 100)
				{
					list_2 = Math2.smethod_21(list_2);
				}
				if (list_3.Count > 100)
				{
					list_3 = Math2.smethod_21(list_3);
				}
				List<Vector3D> list = Enumerable.ToList<Vector3D>(Enumerable.Select<GeoPoint, Vector3D>(list_2, new Func<GeoPoint, Vector3D>(Class437.smethod_15)));
				List<Vector3D> list2 = Enumerable.ToList<Vector3D>(Enumerable.Select<GeoPoint, Vector3D>(list_3, new Func<GeoPoint, Vector3D>(Class437.smethod_15)));
				Vector3D vector3D = default(Vector3D);
				try
				{
					foreach (Vector3D v in list2)
					{
						vector3D += v;
					}
				}
				finally
				{
					List<Vector3D>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				try
				{
					foreach (Vector3D v2 in list)
					{
						vector3D += v2;
					}
				}
				finally
				{
					List<Vector3D>.Enumerator enumerator2;
					((IDisposable)enumerator2).Dispose();
				}
				vector3D /= (double)(list2.Count + list.Count);
				vector3D /= vector3D.Length;
				Matrix<double> matrix = Matrix3D.RotationTo(vector3D, new Vector3D(1.0, 0.0, 0.0), null);
				Matrix<double> m = matrix.Inverse();
				int num = list2.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					list2[i] = list2[i].TransformBy(matrix);
				}
				int num2 = list.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					list[j] = list[j].TransformBy(matrix);
				}
				List<GeoPoint> list3 = Enumerable.ToList<GeoPoint>(Enumerable.Select<Vector3D, GeoPoint>(list, new Func<Vector3D, GeoPoint>(Class437.smethod_14)));
				List<GeoPoint> list4 = Enumerable.ToList<GeoPoint>(Enumerable.Select<Vector3D, GeoPoint>(list2, new Func<Vector3D, GeoPoint>(Class437.smethod_14)));
				List<GeoPoint> list5 = Math2.smethod_30(list3, list4);
				if (list5.Count == 0)
				{
					result = list_3;
				}
				else
				{
					List<Vector3D> list6 = Enumerable.ToList<Vector3D>(Enumerable.Select<GeoPoint, Vector3D>(list5, new Func<GeoPoint, Vector3D>(Class437.smethod_15)));
					int num3 = list6.Count - 1;
					for (int k = 0; k <= num3; k++)
					{
						list6[k] = list6[k].TransformBy(m);
					}
					List<GeoPoint> list7 = Enumerable.ToList<GeoPoint>(Enumerable.Select<Vector3D, GeoPoint>(list6, new Func<Vector3D, GeoPoint>(Class437.smethod_14)));
					if (list7.Count > 100)
					{
						list7 = Math2.smethod_21(list7);
					}
					result = list7;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200586", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = list_3;
			}
			return result;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000B9BF8 File Offset: 0x000B7DF8
		public List<Sensor> method_50()
		{
			List<Sensor> result;
			try
			{
				Sensor[] array = this.activeUnit_0.method_78();
				if (Information.IsNothing(array))
				{
					result = new List<Sensor>();
				}
				else
				{
					int num = array.Length;
					List<Sensor> list = new List<Sensor>();
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((sensor.method_55() || sensor.method_41().Count != 0) && (sensor.method_61(GlobalVariables.ActiveUnitType.Aircraft) || sensor.method_61(GlobalVariables.ActiveUnitType.Satellite) || sensor.struct32_0.bool_6))
						{
							list.Add(sensor);
						}
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100272", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000B9CD8 File Offset: 0x000B7ED8
		public List<Sensor> method_51(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> result;
			try
			{
				list3 = this.method_57(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				float float_;
				int num;
				try
				{
					foreach (Sensor sensor in list3)
					{
						if (sensor.float_0 >= float_)
						{
							list2.Add(sensor);
							float_ = sensor.float_0;
							num = 1;
						}
						else if (sensor.float_0 == float_)
						{
							list2.Add(sensor);
							num++;
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list2.Count == 0)
				{
					result = list;
				}
				else
				{
					try
					{
						foreach (Sensor sensor2 in list2)
						{
							if (sensor2.float_0 == float_)
							{
								if (num == 1)
								{
									list.Add(sensor2);
								}
								else
								{
									if (sensor2.class295_0.method_1())
									{
										list.Add(sensor2);
										return list;
									}
									num--;
								}
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100273", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000B9E4C File Offset: 0x000B804C
		public List<Sensor> method_52(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> list4 = new List<Sensor>();
			List<Sensor> result;
			try
			{
				list4 = this.method_58(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				if (Information.IsNothing(list4))
				{
					result = new List<Sensor>();
				}
				else
				{
					float float_;
					int num;
					float float_2;
					int num2;
					try
					{
						foreach (Sensor sensor in list4)
						{
							if (sensor.float_0 >= float_ && !sensor.struct32_0.bool_18)
							{
								if (sensor.float_0 >= float_)
								{
									list2.Add(sensor);
									float_ = sensor.float_0;
									num = 1;
								}
								else if (sensor.float_0 == float_)
								{
									list2.Add(sensor);
									num++;
								}
							}
							else if (sensor.float_0 >= float_2 && sensor.struct32_0.bool_18)
							{
								if (sensor.float_0 >= float_)
								{
									list3.Add(sensor);
									float_2 = sensor.float_0;
									num2 = 1;
								}
								else if (sensor.float_0 == float_)
								{
									list3.Add(sensor);
									num2++;
								}
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					if (list2.Count == 0 && list3.Count == 0)
					{
						result = list;
					}
					else
					{
						if (list3.Count == 0)
						{
							try
							{
								foreach (Sensor sensor2 in list2)
								{
									if (sensor2.float_0 == float_)
									{
										if (num == 1)
										{
											list.Add(sensor2);
										}
										else
										{
											if (sensor2.class295_0.method_1())
											{
												list.Add(sensor2);
												return list;
											}
											num--;
										}
									}
								}
								goto IL_20E;
							}
							finally
							{
								List<Sensor>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
						}
						try
						{
							foreach (Sensor sensor3 in list3)
							{
								if (sensor3.float_0 == float_2)
								{
									if (num2 == 1)
									{
										list.Add(sensor3);
									}
									else
									{
										if (sensor3.class295_0.method_1())
										{
											list.Add(sensor3);
											return list;
										}
										num2--;
									}
								}
							}
						}
						finally
						{
							List<Sensor>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
						IL_20E:
						result = list;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100274", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000BA110 File Offset: 0x000B8310
		public List<Sensor> method_53(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> result;
			try
			{
				list3 = this.method_59(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				float float_;
				int num;
				try
				{
					foreach (Sensor sensor in list3)
					{
						if (sensor.float_0 >= float_)
						{
							list2.Add(sensor);
							float_ = sensor.float_0;
							num = 1;
						}
						else if (sensor.float_0 == float_)
						{
							list2.Add(sensor);
							num++;
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list2.Count == 0)
				{
					result = list;
				}
				else
				{
					try
					{
						foreach (Sensor sensor2 in list2)
						{
							if (sensor2.float_0 == float_)
							{
								if (num == 1)
								{
									list.Add(sensor2);
								}
								else
								{
									if (sensor2.class295_0.method_1())
									{
										list.Add(sensor2);
										return list;
									}
									num--;
								}
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100275", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x000BA284 File Offset: 0x000B8484
		public List<Sensor> method_54(bool bool_1, bool bool_2, bool bool_3, bool bool_4, ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> result;
			try
			{
				list3 = this.method_60(bool_1, bool_2, bool_3, bool_4, ref sensor_0, false);
				float float_;
				int num;
				try
				{
					foreach (Sensor sensor in list3)
					{
						if (sensor.float_0 >= float_)
						{
							list2.Add(sensor);
							float_ = sensor.float_0;
							num = 1;
						}
						else if (sensor.float_0 == float_)
						{
							list2.Add(sensor);
							num++;
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list2.Count == 0)
				{
					result = list;
				}
				else
				{
					try
					{
						foreach (Sensor sensor2 in list2)
						{
							if (sensor2.float_0 == float_)
							{
								if (num == 1)
								{
									list.Add(sensor2);
								}
								else
								{
									if (sensor2.class295_0.method_1())
									{
										list.Add(sensor2);
										return list;
									}
									num--;
								}
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100276", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000BA3F8 File Offset: 0x000B85F8
		public List<Sensor> method_55(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> list3 = new List<Sensor>();
			List<Sensor> result;
			try
			{
				list3 = this.method_61(ActiveCapableSensorsOnly, EmmittingSensorsOnly, OnlyOperatingSensors, OnlySensorsScanningThisPulse, ref theSensorList, SonarsOnly);
				float float_;
				int num;
				try
				{
					foreach (Sensor sensor in list3)
					{
						if (sensor.float_0 > float_)
						{
							list2.Add(sensor);
							float_ = sensor.float_0;
							num = 1;
						}
						else if (sensor.float_0 == float_)
						{
							list2.Add(sensor);
							num++;
						}
					}
				}
				finally
				{
					List<Sensor>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				if (list2.Count == 0)
				{
					result = list;
				}
				else
				{
					try
					{
						foreach (Sensor sensor2 in list2)
						{
							if (sensor2.float_0 == float_)
							{
								if (num == 1)
								{
									list.Add(sensor2);
								}
								else
								{
									if (sensor2.class295_0.method_1())
									{
										list.Add(sensor2);
										return list;
									}
									num--;
								}
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100277", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000BA56C File Offset: 0x000B876C
		public List<Sensor> method_56(ref Sensor[] sensor_0)
		{
			List<Sensor> list = new List<Sensor>();
			List<Sensor> list2 = new List<Sensor>();
			List<Sensor> result;
			try
			{
				float float_;
				int num;
				foreach (Sensor sensor in sensor_0)
				{
					if (sensor.float_0 >= float_)
					{
						list2.Add(sensor);
						float_ = sensor.float_0;
						num = 1;
					}
					else if (sensor.float_0 == float_)
					{
						list2.Add(sensor);
						num++;
					}
				}
				if (list2.Count == 0)
				{
					result = list;
				}
				else
				{
					try
					{
						foreach (Sensor sensor2 in list2)
						{
							if (sensor2.float_0 == float_)
							{
								if (num == 1)
								{
									list.Add(sensor2);
								}
								else
								{
									if (sensor2.class295_0.method_1())
									{
										list.Add(sensor2);
										return list;
									}
									num--;
								}
							}
						}
					}
					finally
					{
						List<Sensor>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101273", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000BA6B0 File Offset: 0x000B88B0
		public List<Sensor> method_57(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			List<Sensor> result;
			try
			{
				List<Sensor> list = new List<Sensor>();
				Sensor[] array;
				if (Information.IsNothing(theSensorList))
				{
					array = this.method_50().ToArray();
				}
				else
				{
					array = theSensorList;
				}
				if (Information.IsNothing(array))
				{
					result = list;
				}
				else
				{
					int num = array.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						Sensor sensor = array[i];
						if ((!ActiveCapableSensorsOnly || sensor.method_58()) && (!EmmittingSensorsOnly || sensor.method_43()) && (!OnlySensorsScanningThisPulse || sensor.method_24()) && (sensor.method_55() || sensor.method_41().Count != 0) && (!OnlyOperatingSensors || sensor.method_64()))
						{
							if (this.activeUnit_0.bool_2)
							{
								if (!sensor.method_62(GlobalVariables.ActiveUnitType.Aircraft, (Weapon)this.activeUnit_0) && !sensor.method_62(GlobalVariables.ActiveUnitType.Weapon, (Weapon)this.activeUnit_0))
								{
									goto IL_E6;
								}
							}
							else if (!sensor.method_61(GlobalVariables.ActiveUnitType.Aircraft) && !sensor.method_61(GlobalVariables.ActiveUnitType.Weapon) && !sensor.method_61(GlobalVariables.ActiveUnitType.Satellite))
							{
								goto IL_E6;
							}
							list.Add(sensor);
						}
						IL_E6:;
					}
					result = list;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100278", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new List<Sensor>();
			}
			return result;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000BA808 File Offset: 0x000B8A08
		public List<Sensor> method_58(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.activeUnit_0.method_78();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> result;
			if (Information.IsNothing(array))
			{
				result = new List<Sensor>();
			}
			else
			{
				List<Sensor> list = new List<Sensor>();
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!ActiveCapableSensorsOnly || sensor.method_58()) && (!EmmittingSensorsOnly || sensor.method_43()) && (!OnlySensorsScanningThisPulse || sensor.method_24()) && sensor.method_55() && (!OnlyOperatingSensors || sensor.method_64()) && (sensor.method_61(GlobalVariables.ActiveUnitType.Ship) || sensor.method_61(GlobalVariables.ActiveUnitType.Facility)))
						{
							list.Add(sensor);
						}
					}
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100279", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
				}
			}
			return result;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000BA914 File Offset: 0x000B8B14
		public List<Sensor> method_59(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.activeUnit_0.method_78();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> list = new List<Sensor>();
			List<Sensor> result;
			if (Information.IsNothing(array))
			{
				result = list;
			}
			else
			{
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!ActiveCapableSensorsOnly || sensor.method_58()) && (!EmmittingSensorsOnly || sensor.method_43()) && (!OnlySensorsScanningThisPulse || sensor.method_24()) && sensor.method_55() && (!OnlyOperatingSensors || sensor.method_64()))
						{
							if (this.activeUnit_0.bool_2)
							{
								if (!sensor.method_62(GlobalVariables.ActiveUnitType.Ship, (Weapon)this.activeUnit_0))
								{
									goto IL_B5;
								}
							}
							else if (!sensor.method_61(GlobalVariables.ActiveUnitType.Ship))
							{
								goto IL_B5;
							}
							list.Add(sensor);
						}
						IL_B5:;
					}
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100280", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
				}
			}
			return result;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000BAA38 File Offset: 0x000B8C38
		public List<Sensor> method_60(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.activeUnit_0.method_78();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> list = new List<Sensor>();
			List<Sensor> result;
			if (Information.IsNothing(array))
			{
				result = list;
			}
			else
			{
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!ActiveCapableSensorsOnly || sensor.method_58()) && (!EmmittingSensorsOnly || sensor.method_43()) && (!OnlySensorsScanningThisPulse || sensor.method_24()) && sensor.method_55() && (!OnlyOperatingSensors || sensor.method_64()))
						{
							if (this.activeUnit_0.bool_2)
							{
								if (!sensor.method_62(GlobalVariables.ActiveUnitType.Facility, (Weapon)this.activeUnit_0))
								{
									goto IL_B5;
								}
							}
							else if (!sensor.method_61(GlobalVariables.ActiveUnitType.Facility))
							{
								goto IL_B5;
							}
							list.Add(sensor);
						}
						IL_B5:;
					}
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100281", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
				}
			}
			return result;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000BAB5C File Offset: 0x000B8D5C
		public List<Sensor> method_61(bool ActiveCapableSensorsOnly, bool EmmittingSensorsOnly, bool OnlyOperatingSensors, bool OnlySensorsScanningThisPulse, ref Sensor[] theSensorList, bool SonarsOnly = false)
		{
			List<Sensor> list = new List<Sensor>();
			Sensor[] array;
			if (Information.IsNothing(theSensorList))
			{
				array = this.activeUnit_0.method_78();
			}
			else
			{
				array = theSensorList;
			}
			List<Sensor> result;
			if (Information.IsNothing(array))
			{
				result = list;
			}
			else
			{
				int num = array.Length;
				try
				{
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						Sensor sensor = array[i];
						if ((!SonarsOnly || sensor.method_74()) && (!ActiveCapableSensorsOnly || sensor.method_58()) && (!EmmittingSensorsOnly || sensor.method_43()) && (!OnlySensorsScanningThisPulse || sensor.method_24()) && sensor.method_55() && (!OnlyOperatingSensors || sensor.method_64()))
						{
							if (this.activeUnit_0.bool_2)
							{
								if (((Weapon)this.activeUnit_0).method_167() != Weapon._WeaponType.Sonobuoy && !sensor.method_62(GlobalVariables.ActiveUnitType.Submarine, (Weapon)this.activeUnit_0))
								{
									if (!sensor.method_62(GlobalVariables.ActiveUnitType.Ship, (Weapon)this.activeUnit_0))
									{
										goto IL_10A;
									}
									if (!this.activeUnit_0.bool_7)
									{
										goto IL_10A;
									}
								}
							}
							else if (!sensor.method_61(GlobalVariables.ActiveUnitType.Submarine))
							{
								goto IL_10A;
							}
							list.Add(sensor);
						}
						IL_10A:;
					}
					result = list;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100282", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new List<Sensor>();
				}
			}
			return result;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000BACD8 File Offset: 0x000B8ED8
		public void method_62()
		{
			checked
			{
				try
				{
					bool flag = false;
					Sensor[] array = this.activeUnit_0.method_78();
					Sensor[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i].method_41().Contains(this.activeUnit_0.vmethod_86().vmethod_3()))
						{
							flag = true;
							IL_41:
							foreach (Sensor sensor in array)
							{
								if (sensor.method_41().Count > 0)
								{
									if (sensor.list_1.Count == 0)
									{
										List<Contact> list = new List<Contact>();
										try
										{
											foreach (Contact contact in sensor.method_41())
											{
												if (contact == null || contact.method_95(this.activeUnit_0))
												{
													list.Add(contact);
												}
											}
										}
										finally
										{
											List<Contact>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
										if (!flag && !sensor.method_85())
										{
											list.Add(sensor.method_41()[0]);
										}
										try
										{
											foreach (Contact theTarget in list)
											{
												sensor.method_84(theTarget, false);
											}
											goto IL_1CE;
										}
										finally
										{
											List<Contact>.Enumerator enumerator2;
											((IDisposable)enumerator2).Dispose();
										}
									}
									List<Contact> list2 = new List<Contact>();
									try
									{
										foreach (Contact contact2 in sensor.method_41())
										{
											if (Information.IsNothing(contact2))
											{
												list2.Add(contact2);
											}
											else if (contact2.method_124(this.activeUnit_0.scenario_0))
											{
												list2.Add(contact2);
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
										foreach (Contact theTarget2 in list2)
										{
											sensor.method_84(theTarget2, false);
										}
									}
									finally
									{
										List<Contact>.Enumerator enumerator4;
										((IDisposable)enumerator4).Dispose();
									}
								}
								IL_1CE:;
							}
							return;
						}
					}
					goto IL_41;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100283", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x000BAF74 File Offset: 0x000B9174
		public ObservableDictionary<string, Contact> method_63()
		{
			ObservableDictionary<string, Contact> result;
			try
			{
				if (Information.IsNothing(this.observableDictionary_1))
				{
					ObservableDictionary<string, Contact> observableDictionary = new ObservableDictionary<string, Contact>();
					try
					{
						foreach (KeyValuePair<string, ActiveUnit_Sensory.Class311> keyValuePair in this.vmethod_0())
						{
							if (!Information.IsNothing(keyValuePair.Value.contact_0))
							{
								observableDictionary.Add(keyValuePair.Key, keyValuePair.Value.contact_0);
							}
							else
							{
								this.lazy_2.Value.TryAdd(keyValuePair.Key, null);
							}
						}
					}
					finally
					{
						IEnumerator<KeyValuePair<string, ActiveUnit_Sensory.Class311>> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.observableDictionary_1 = observableDictionary;
				}
				result = this.observableDictionary_1;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101216", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ObservableDictionary<string, Contact>();
			}
			return result;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000BB070 File Offset: 0x000B9270
		public void method_64(ref string string_0, List<Sensor> list_2)
		{
			if (this.vmethod_0().ContainsKey(string_0))
			{
				ActiveUnit_Sensory.Class311 @class = this.vmethod_0()[string_0];
				@class.float_1 = 0f;
				try
				{
					foreach (Sensor sensor in list_2)
					{
						Sensor.Sensor_Type sensor_Type_ = sensor.sensor_Type_0;
						if (sensor_Type_ <= Sensor.Sensor_Type.TowedArray_ActiveOnly)
						{
							if (sensor_Type_ <= Sensor.Sensor_Type.ESM)
							{
								switch (sensor_Type_)
								{
								case Sensor.Sensor_Type.Radar:
									@class.nullable_0 = new float?(0f);
									continue;
								case Sensor.Sensor_Type.SemiActive:
									continue;
								case Sensor.Sensor_Type.Visual:
									@class.nullable_2 = new float?(0f);
									continue;
								case Sensor.Sensor_Type.Infrared:
									@class.nullable_3 = new float?(0f);
									continue;
								default:
									if (sensor_Type_ != Sensor.Sensor_Type.ESM)
									{
										continue;
									}
									@class.nullable_1 = new float?(0f);
									continue;
								}
							}
							else if (sensor_Type_ - Sensor.Sensor_Type.HullSonar_PassiveOnly > 2 && sensor_Type_ - Sensor.Sensor_Type.TowedArray_PassiveOnly > 2)
							{
								continue;
							}
						}
						else if (sensor_Type_ <= Sensor.Sensor_Type.DippingSonar_ActiveOnly)
						{
							if (sensor_Type_ - Sensor.Sensor_Type.VDS_PassiveOnly > 2 && sensor_Type_ - Sensor.Sensor_Type.DippingSonar_PassiveOnly > 2)
							{
								continue;
							}
						}
						else if (sensor_Type_ != Sensor.Sensor_Type.BottomFixedSonar_PassiveOnly)
						{
							if (sensor_Type_ != Sensor.Sensor_Type.PingIntercept)
							{
								continue;
							}
							@class.nullable_5 = new float?(0f);
							continue;
						}
						if (sensor.method_46())
						{
							@class.nullable_4 = new float?(0f);
						}
						else if (sensor.method_43())
						{
							@class.nullable_4 = new float?(0f);
						}
						else
						{
							@class.nullable_5 = new float?(0f);
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

		// Token: 0x06000A9D RID: 2717 RVA: 0x000BB22C File Offset: 0x000B942C
		public float? method_65(ref Contact contact_0)
		{
			float? result;
			if (!Information.IsNothing(contact_0.activeUnit_0))
			{
				if (this.vmethod_0().ContainsKey(contact_0.activeUnit_0.string_0))
				{
					result = new float?(this.vmethod_0()[contact_0.activeUnit_0.string_0].float_0);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00008070 File Offset: 0x00006270
		private void method_66(object sender, NotifyDictionaryChangedEventArgs<string, ActiveUnit_Sensory.Class311> e)
		{
			this.observableDictionary_1 = null;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00008079 File Offset: 0x00006279
		public void method_67(ref string string_0)
		{
			if (this.vmethod_0().ContainsKey(string_0))
			{
				this.vmethod_0().Remove(string_0);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000BB290 File Offset: 0x000B9490
		public void method_68()
		{
			try
			{
				if (!Misc.smethod_15(this.lazy_1.Value))
				{
					try
					{
						foreach (string text in this.lazy_1.Value.Keys)
						{
							if (!this.vmethod_0().ContainsKey(text))
							{
								ActiveUnit_Sensory.Class311 @class = new ActiveUnit_Sensory.Class311();
								@class.contact_0 = this.lazy_1.Value[text];
								this.vmethod_0().Add(text, @class);
							}
						}
					}
					finally
					{
						IEnumerator<string> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
					this.lazy_1.Value.Clear();
				}
				if (!Misc.smethod_15(this.lazy_2.Value))
				{
					try
					{
						foreach (string key in this.lazy_2.Value.Keys)
						{
							this.vmethod_0().Remove(key);
						}
					}
					finally
					{
						IEnumerator<string> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					this.lazy_2.Value.Clear();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101220", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000BB3F8 File Offset: 0x000B95F8
		public void method_69(float float_0)
		{
			try
			{
				if (this.vmethod_0().Count > 0)
				{
					try
					{
						foreach (KeyValuePair<string, ActiveUnit_Sensory.Class311> keyValuePair in this.vmethod_0())
						{
							ActiveUnit_Sensory.Class311 value = keyValuePair.Value;
							value.float_0 = keyValuePair.Value.float_0 + float_0;
							if (value.float_0 > (float)this.activeUnit_0.short_1)
							{
								if (this.activeUnit_0.short_1 > 0 && this.activeUnit_0.vmethod_7(false).method_73(value.contact_0).Count > 0)
								{
									value.float_1 = 0f;
								}
								else if (value.float_1 > 300f)
								{
									this.lazy_2.Value.TryAdd(keyValuePair.Key, value.contact_0);
								}
								else
								{
									float num = 1f;
									if (this.activeUnit_0.scenario_0.method_14())
									{
										num = 10f;
									}
									value.float_1 += 1f / num;
								}
							}
							if (!Information.IsNothing(value.nullable_0))
							{
								value.nullable_0 += float_0;
							}
							if (!Information.IsNothing(value.nullable_1))
							{
								value.nullable_1 += float_0;
							}
							if (!Information.IsNothing(value.nullable_2))
							{
								value.nullable_2 += float_0;
							}
							if (!Information.IsNothing(value.nullable_3))
							{
								value.nullable_3 += float_0;
							}
							if (!Information.IsNothing(value.nullable_4))
							{
								value.nullable_4 += float_0;
							}
							if (!Information.IsNothing(value.nullable_5))
							{
								value.nullable_5 += float_0;
							}
						}
					}
					finally
					{
						IEnumerator<KeyValuePair<string, ActiveUnit_Sensory.Class311>> enumerator;
						if (enumerator != null)
						{
							enumerator.Dispose();
						}
					}
				}
				if (this.activeUnit_0.scenario_0.SecondIsChangingOnThisPulse && this.dictionary_0.Count > 0)
				{
					try
					{
						foreach (Contact contact in this.dictionary_0.Values)
						{
							contact.method_65(this.activeUnit_0.vmethod_7(false), 1f, this.activeUnit_0.scenario_0);
						}
					}
					finally
					{
						Dictionary<string, Contact>.ValueCollection.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101223", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000BB7D4 File Offset: 0x000B99D4
		public void method_70(float float_0)
		{
			if (this.dictionary_1.Count > 0)
			{
				this.dictionary_1.Clear();
			}
			this.activeUnit_0.method_78();
			if (!this.activeUnit_0.vmethod_90().vmethod_1())
			{
				try
				{
					foreach (Contact contact in this.method_6())
					{
						contact.vmethod_44(float_0, this.activeUnit_0.scenario_0);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000BB868 File Offset: 0x000B9A68
		public void method_71(float float_0)
		{
			if (this.dictionary_1.Count > 0)
			{
				this.dictionary_1.Clear();
			}
			if (!this.activeUnit_0.vmethod_90().vmethod_1())
			{
				try
				{
					foreach (Contact contact in this.method_6())
					{
						contact.method_62(float_0, this.activeUnit_0.vmethod_7(false), this.activeUnit_0.scenario_0);
					}
				}
				finally
				{
					List<Contact>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				this.method_72();
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000BB904 File Offset: 0x000B9B04
		private void method_72()
		{
			try
			{
				if (this.dictionary_0.Count > 0)
				{
					foreach (Contact contact in Enumerable.ToArray<Contact>(this.dictionary_0.Values))
					{
						if (Information.IsNothing(contact) || contact.method_132() || contact.method_124(this.activeUnit_0.scenario_0))
						{
							this.activeUnit_0.scenario_0.method_59(this.activeUnit_0.Name + ": Private contact " + contact.Name + " has been lost.", contact.Name + " vanished", LoggedMessage.MessageType.CommsIsolatedMessage, 5, null, this.activeUnit_0.vmethod_7(false), new Geopoint_Struct(contact.vmethod_28(null), contact.vmethod_30(null)));
							try
							{
								this.dictionary_0.Remove(contact.activeUnit_0.string_0);
							}
							catch (Exception ex)
							{
								foreach (KeyValuePair<string, Contact> keyValuePair in Enumerable.ToArray<KeyValuePair<string, Contact>>(this.dictionary_0))
								{
									if (keyValuePair.Value == contact)
									{
										this.dictionary_0.Remove(keyValuePair.Key);
										break;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 300011", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000BBAC4 File Offset: 0x000B9CC4
		public void method_73(ref ActiveUnit activeUnit_1, Dictionary<string, Class310> dictionary_2)
		{
			try
			{
				foreach (KeyValuePair<string, ActiveUnit_Sensory.Class311> keyValuePair in this.vmethod_0())
				{
					if (activeUnit_1.vmethod_7(false).method_11().ContainsKey(keyValuePair.Key))
					{
						keyValuePair.Value.contact_0 = activeUnit_1.vmethod_7(false).method_11()[keyValuePair.Key];
					}
				}
			}
			finally
			{
				IEnumerator<KeyValuePair<string, ActiveUnit_Sensory.Class311>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (Contact contact in this.dictionary_0.Values)
				{
					ActiveUnit activeUnit = this.activeUnit_0;
					ActiveUnit activeUnit2;
					Side value = (activeUnit2 = this.activeUnit_0).vmethod_7(false);
					contact.method_64(ref activeUnit.scenario_0, ref dictionary_2, ref value);
					activeUnit2.vmethod_8(false, value);
				}
			}
			finally
			{
				Dictionary<string, Contact>.ValueCollection.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000BBBB8 File Offset: 0x000B9DB8
		public void method_74()
		{
			try
			{
				try
				{
					foreach (KeyValuePair<string, ActiveUnit_Sensory.Class311> keyValuePair in this.vmethod_0())
					{
						if (!Information.IsNothing(keyValuePair.Value.contact_0) && !Information.IsNothing(keyValuePair.Value.contact_0.activeUnit_0))
						{
							keyValuePair.Value.contact_0.activeUnit_0 = null;
						}
					}
				}
				finally
				{
					IEnumerator<KeyValuePair<string, ActiveUnit_Sensory.Class311>> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101225", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000BBC80 File Offset: 0x000B9E80
		private void method_75(DockFacility dockFacility_0, Sensor sensor_0, Contact contact_0, float float_0)
		{
			if (dockFacility_0.method_24() && dockFacility_0.lazy_0.Value.Count != 0)
			{
				float num;
				try
				{
					foreach (ActiveUnit activeUnit in dockFacility_0.lazy_0.Value.Values)
					{
						num = sensor_0.method_91(this.activeUnit_0, activeUnit);
						if (num * 3f >= float_0)
						{
							Contact.Class269 @class = null;
							try
							{
								foreach (Contact.Class269 class2 in contact_0.method_73(this.activeUnit_0.vmethod_7(false)))
								{
									if (Operators.CompareString(class2.string_0, activeUnit.string_0, false) == 0)
									{
										@class = class2;
										@class.float_0 = 0f;
										break;
									}
								}
								goto IL_27D;
							}
							finally
							{
								List<Contact.Class269>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							IL_D7:
							if (float_0 < num)
							{
								if (@class.identificationStatus_0 < Contact_Base.IdentificationStatus.KnownClass)
								{
									@class.identificationStatus_0 = Contact_Base.IdentificationStatus.KnownClass;
									this.activeUnit_0.method_124(string.Concat(new string[]
									{
										activeUnit.method_63(),
										" previously spotted on ",
										contact_0.Name,
										" has been identified as: ",
										activeUnit.string_2,
										" (recon by: ",
										this.activeUnit_0.Name,
										" - Sensor: ",
										sensor_0.Name,
										"). "
									}), "Contact report", LoggedMessage.MessageType.ContactChange, 0, false, new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
								}
							}
							else if (float_0 < num * 2f && @class.identificationStatus_0 < Contact_Base.IdentificationStatus.KnownType)
							{
								@class.identificationStatus_0 = Contact_Base.IdentificationStatus.KnownType;
								this.activeUnit_0.method_124(string.Concat(new string[]
								{
									activeUnit.method_63(),
									" previously spotted on ",
									contact_0.Name,
									" has been type-classified as: ",
									activeUnit.vmethod_58(),
									" (recon by: ",
									this.activeUnit_0.Name,
									" - Sensor: ",
									sensor_0.Name,
									"). "
								}), "Contact report", LoggedMessage.MessageType.ContactChange, 0, false, new Geopoint_Struct(contact_0.vmethod_28(null), contact_0.vmethod_30(null)));
							}
							@class.float_0 = 0f;
							continue;
							IL_27D:
							if (!Information.IsNothing(@class))
							{
								goto IL_D7;
							}
							this.method_29(activeUnit, contact_0, sensor_0);
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
				Lazy<List<Contact.Class269>> lazy = new Lazy<List<Contact.Class269>>();
				try
				{
					foreach (Contact.Class269 class3 in contact_0.method_73(this.activeUnit_0.vmethod_7(false)))
					{
						ActiveUnit activeUnit2;
						this.activeUnit_0.scenario_0.vmethod_0().TryGetValue(class3.string_0, ref activeUnit2);
						if (Information.IsNothing(activeUnit2))
						{
							if (float_0 < num * 2f)
							{
								lazy.Value.Add(class3);
							}
						}
						else if (!dockFacility_0.method_18().vmethod_93().method_14().Contains(activeUnit2) && (!activeUnit2.bool_3 || !dockFacility_0.method_18().vmethod_92().vmethod_4().Contains((Aircraft)activeUnit2)) && float_0 < num * 2f)
						{
							lazy.Value.Add(class3);
						}
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator3;
					((IDisposable)enumerator3).Dispose();
				}
				try
				{
					foreach (Contact.Class269 class269_ in lazy.Value)
					{
						this.method_76(contact_0, class269_);
					}
				}
				finally
				{
					List<Contact.Class269>.Enumerator enumerator4;
					((IDisposable)enumerator4).Dispose();
				}
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000BC0A4 File Offset: 0x000BA2A4
		internal void method_76(Contact contact_0, Contact.Class269 class269_0)
		{
			contact_0.method_73(this.activeUnit_0.vmethod_7(false)).Remove(class269_0);
			HashSet<string> hashSet = new HashSet<string>();
			this.activeUnit_0.vmethod_7(false).method_70(this.activeUnit_0.scenario_0, hashSet);
			foreach (Side side in this.activeUnit_0.scenario_0.method_44())
			{
				Contact contact;
				if (hashSet.Contains(side.method_51()) && side.method_11().TryGetValue(contact_0.activeUnit_0.string_0, ref contact))
				{
					try
					{
						foreach (Contact.Class269 @class in contact.method_73(side))
						{
							if (Operators.CompareString(@class.string_0, class269_0.string_0, false) == 0)
							{
								contact.method_73(side).Remove(@class);
								break;
							}
						}
					}
					finally
					{
						List<Contact.Class269>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00008098 File Offset: 0x00006298
		[CompilerGenerated]
		private bool method_77(Sensor sensor_0)
		{
			return this.method_16(sensor_0) && !sensor_0.method_56();
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000080AE File Offset: 0x000062AE
		[CompilerGenerated]
		private bool method_78(Sensor sensor_0)
		{
			return !this.method_16(sensor_0) && !sensor_0.method_56();
		}

		// Token: 0x040006E5 RID: 1765
		protected ActiveUnit activeUnit_0;

		// Token: 0x040006E6 RID: 1766
		protected bool bool_0;

		// Token: 0x040006E7 RID: 1767
		internal ConcurrentQueue<Tuple<Contact, ActiveUnit, List<Sensor>, float, ActiveUnit_Sensory.Enum35, DateTime>> concurrentQueue_0;

		// Token: 0x040006E8 RID: 1768
		internal ConcurrentBag<string> concurrentBag_0;

		// Token: 0x040006E9 RID: 1769
		private List<Contact> list_0;

		// Token: 0x040006EA RID: 1770
		internal Lazy<ConcurrentDictionary<long, LoggedMessage>> lazy_0;

		// Token: 0x040006EB RID: 1771
		public Lazy<ConcurrentDictionary<string, Contact>> lazy_1;

		// Token: 0x040006EC RID: 1772
		public Lazy<ConcurrentDictionary<string, Contact>> lazy_2;

		// Token: 0x040006ED RID: 1773
		[CompilerGenerated]
		[AccessedThroughProperty("_ContactsList_Local")]
		private ObservableDictionary<string, ActiveUnit_Sensory.Class311> observableDictionary_0;

		// Token: 0x040006EE RID: 1774
		protected Dictionary<string, Contact> dictionary_0;

		// Token: 0x040006EF RID: 1775
		protected List<string> list_1;

		// Token: 0x040006F0 RID: 1776
		private HashSet<ActiveUnit> hashSet_0;

		// Token: 0x040006F1 RID: 1777
		private Dictionary<bool, List<ActiveUnit>> dictionary_1;

		// Token: 0x040006F2 RID: 1778
		[CompilerGenerated]
		private static ActiveUnit_Sensory.Delegate21 delegate21_0;

		// Token: 0x040006F3 RID: 1779
		private ObservableDictionary<string, Contact> observableDictionary_1;

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x06000AAE RID: 2734
		internal delegate void Delegate21(Side DetectingSide, Contact_Base.ContactType ContactType);

		// Token: 0x02000167 RID: 359
		internal enum Enum34
		{
			// Token: 0x040006F5 RID: 1781
			const_0,
			// Token: 0x040006F6 RID: 1782
			const_1,
			// Token: 0x040006F7 RID: 1783
			const_2,
			// Token: 0x040006F8 RID: 1784
			const_3,
			// Token: 0x040006F9 RID: 1785
			const_4,
			// Token: 0x040006FA RID: 1786
			const_5,
			// Token: 0x040006FB RID: 1787
			const_6,
			// Token: 0x040006FC RID: 1788
			const_7,
			// Token: 0x040006FD RID: 1789
			const_8
		}

		// Token: 0x02000168 RID: 360
		internal enum Enum35
		{
			// Token: 0x040006FF RID: 1791
			const_0,
			// Token: 0x04000700 RID: 1792
			const_1,
			// Token: 0x04000701 RID: 1793
			const_2,
			// Token: 0x04000702 RID: 1794
			const_3,
			// Token: 0x04000703 RID: 1795
			const_4
		}

		// Token: 0x02000169 RID: 361
		internal sealed class Class224
		{
			// Token: 0x06000AAF RID: 2735 RVA: 0x000080C4 File Offset: 0x000062C4
			public Class224(ref ActiveUnit activeUnit_1, ref Sensor[] sensor_1)
			{
				this.activeUnit_0 = activeUnit_1;
				this.sensor_0 = sensor_1;
			}

			// Token: 0x04000704 RID: 1796
			public ActiveUnit activeUnit_0;

			// Token: 0x04000705 RID: 1797
			public Sensor[] sensor_0;
		}

		// Token: 0x0200016A RID: 362
		internal sealed class Class225
		{
			// Token: 0x06000AB0 RID: 2736 RVA: 0x000080DC File Offset: 0x000062DC
			public Class225(ref UnguidedWeapon unguidedWeapon_1, ref Sensor[] sensor_1)
			{
				this.unguidedWeapon_0 = unguidedWeapon_1;
				this.sensor_0 = sensor_1;
			}

			// Token: 0x04000706 RID: 1798
			public UnguidedWeapon unguidedWeapon_0;

			// Token: 0x04000707 RID: 1799
			public Sensor[] sensor_0;
		}

		// Token: 0x0200016B RID: 363
		internal sealed class Class311 : Class310
		{
			// Token: 0x06000AB1 RID: 2737 RVA: 0x000BC1A8 File Offset: 0x000BA3A8
			public void method_8(ref XmlWriter xmlWriter_0, Side side_0)
			{
				try
				{
					if (!Information.IsNothing(this.contact_0))
					{
						if (side_0.method_11().ContainsKey(this.contact_0.activeUnit_0.string_0))
						{
							xmlWriter_0.WriteStartElement("ContactEntry");
							xmlWriter_0.WriteElementString("Contact", this.contact_0.activeUnit_0.string_0);
							xmlWriter_0.WriteElementString("TSD", this.float_0.ToString());
							if (!Information.IsNothing(this.nullable_0))
							{
								xmlWriter_0.WriteElementString("TSD_Radar", this.nullable_0.ToString());
							}
							if (!Information.IsNothing(this.nullable_1))
							{
								xmlWriter_0.WriteElementString("TSD_ESM", this.nullable_1.ToString());
							}
							if (!Information.IsNothing(this.nullable_2))
							{
								xmlWriter_0.WriteElementString("TSD_Visual", this.nullable_2.ToString());
							}
							if (!Information.IsNothing(this.nullable_3))
							{
								xmlWriter_0.WriteElementString("TSD_Infrared", this.nullable_3.ToString());
							}
							if (!Information.IsNothing(this.nullable_4))
							{
								xmlWriter_0.WriteElementString("TSD_SonarActive", this.nullable_4.ToString());
							}
							if (!Information.IsNothing(this.nullable_5))
							{
								xmlWriter_0.WriteElementString("TSD_SonarPassive", this.nullable_5.ToString());
							}
							xmlWriter_0.WriteElementString("NDC", this.float_1.ToString());
							xmlWriter_0.WriteEndElement();
						}
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101217", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}

			// Token: 0x06000AB2 RID: 2738 RVA: 0x000BC3BC File Offset: 0x000BA5BC
			public static ActiveUnit_Sensory.Class311 smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref string string_2)
			{
				ActiveUnit_Sensory.Class311 result;
				try
				{
					ActiveUnit_Sensory.Class311 @class = new ActiveUnit_Sensory.Class311();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							uint num = Class582.smethod_0(name);
							if (num <= 998171479U)
							{
								if (num <= 770528374U)
								{
									if (num <= 687476049U)
									{
										if (num != 196400981U)
										{
											if (num != 687476049U)
											{
												continue;
											}
											if (Operators.CompareString(name, "TimeSinceDetection", false) != 0)
											{
												continue;
											}
											goto IL_190;
										}
										else if (Operators.CompareString(name, "TSD_Visual", false) != 0)
										{
											continue;
										}
									}
									else if (num != 755333778U)
									{
										if (num != 770528374U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TimeSinceDetection_Visual", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "TimeSinceDetection_Radar", false) != 0)
										{
											continue;
										}
										goto IL_27E;
									}
									@class.nullable_2 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								if (num <= 863132826U)
								{
									if (num != 818239444U)
									{
										if (num != 863132826U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TSD_SonarActive", false) != 0)
										{
											continue;
										}
										goto IL_383;
									}
									else
									{
										if (Operators.CompareString(name, "NoDetectionCount", false) != 0)
										{
											continue;
										}
										goto IL_1F3;
									}
								}
								else if (num != 894866588U)
								{
									if (num != 998171479U)
									{
										continue;
									}
									if (Operators.CompareString(name, "TimeSinceDetection_Infrared", false) != 0)
									{
										continue;
									}
									goto IL_34D;
								}
								else if (Operators.CompareString(name, "TSD", false) != 0)
								{
									continue;
								}
								IL_190:
								@class.float_0 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
								continue;
							}
							if (num <= 1940690115U)
							{
								if (num <= 1591216164U)
								{
									if (num != 1453604037U)
									{
										if (num != 1591216164U)
										{
											continue;
										}
										if (Operators.CompareString(name, "NDC", false) == 0)
										{
											goto IL_1F3;
										}
										continue;
									}
									else if (Operators.CompareString(name, "TimeSinceDetection_ESM", false) != 0)
									{
										continue;
									}
								}
								else if (num != 1779304655U)
								{
									if (num != 1940690115U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Contact", false) == 0)
									{
										@class.contact_0 = null;
										string_2 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "TSD_Radar", false) == 0)
									{
										goto IL_27E;
									}
									continue;
								}
							}
							else
							{
								if (num <= 2732107685U)
								{
									if (num != 2183398782U)
									{
										if (num != 2732107685U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TSD_SonarPassive", false) != 0)
										{
											continue;
										}
									}
									else if (Operators.CompareString(name, "TimeSinceDetection_SonarPassive", false) != 0)
									{
										continue;
									}
									@class.nullable_5 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
									continue;
								}
								if (num != 2988962680U)
								{
									if (num != 3093760719U)
									{
										if (num != 3704493208U)
										{
											continue;
										}
										if (Operators.CompareString(name, "TSD_Infrared", false) == 0)
										{
											goto IL_34D;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "TimeSinceDetection_SonarActive", false) == 0)
										{
											goto IL_383;
										}
										continue;
									}
								}
								else if (Operators.CompareString(name, "TSD_ESM", false) != 0)
								{
									continue;
								}
							}
							@class.nullable_1 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
							IL_1F3:
							@class.float_1 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
							continue;
							IL_27E:
							@class.nullable_0 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
							IL_34D:
							@class.nullable_3 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
							continue;
							IL_383:
							@class.nullable_4 = new float?(XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", ".")));
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
					result = @class;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 101218", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = new ActiveUnit_Sensory.Class311();
				}
				return result;
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x000080F4 File Offset: 0x000062F4
			public Class311()
			{
				this.float_0 = 0f;
				this.float_1 = 0f;
			}

			// Token: 0x04000708 RID: 1800
			public float float_0;

			// Token: 0x04000709 RID: 1801
			public float? nullable_0;

			// Token: 0x0400070A RID: 1802
			public float? nullable_1;

			// Token: 0x0400070B RID: 1803
			public float? nullable_2;

			// Token: 0x0400070C RID: 1804
			public float? nullable_3;

			// Token: 0x0400070D RID: 1805
			public float? nullable_4;

			// Token: 0x0400070E RID: 1806
			public float? nullable_5;

			// Token: 0x0400070F RID: 1807
			public Contact contact_0;

			// Token: 0x04000710 RID: 1808
			public float float_1;
		}
	}
}
