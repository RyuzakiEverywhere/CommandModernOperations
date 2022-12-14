using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using DarkUI.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns8;

namespace Command_Core
{
	// Token: 0x020002D7 RID: 727
	public sealed class Magazine : PlatformComponent
	{
		// Token: 0x06001575 RID: 5493 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		[CompilerGenerated]
		public ObservableList<WeaponRec> vmethod_10()
		{
			return this.observableList_0;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x001918E8 File Offset: 0x0018FAE8
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void vmethod_11(ObservableList<WeaponRec> observableList_1)
		{
			EventHandler<EventArgs5<WeaponRec>> eventHandler_ = new EventHandler<EventArgs5<WeaponRec>>(this.method_29);
			EventHandler<EventArgs5<WeaponRec>> eventHandler_2 = new EventHandler<EventArgs5<WeaponRec>>(this.method_30);
			ObservableList<WeaponRec> observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_1(eventHandler_);
				observableList.method_3(eventHandler_2);
			}
			this.observableList_0 = observableList_1;
			observableList = this.observableList_0;
			if (observableList != null)
			{
				observableList.method_0(eventHandler_);
				observableList.method_2(eventHandler_2);
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00191948 File Offset: 0x0018FB48
		[CompilerGenerated]
		public static void smethod_2(Magazine.Delegate42 delegate42_1)
		{
			Magazine.Delegate42 @delegate = Magazine.delegate42_0;
			Magazine.Delegate42 delegate2;
			do
			{
				delegate2 = @delegate;
				Magazine.Delegate42 value = (Magazine.Delegate42)Delegate.Combine(delegate2, delegate42_1);
				@delegate = Interlocked.CompareExchange<Magazine.Delegate42>(ref Magazine.delegate42_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0019197C File Offset: 0x0018FB7C
		[CompilerGenerated]
		public static void smethod_3(Magazine.Delegate42 delegate42_1)
		{
			Magazine.Delegate42 @delegate = Magazine.delegate42_0;
			Magazine.Delegate42 delegate2;
			do
			{
				delegate2 = @delegate;
				Magazine.Delegate42 value = (Magazine.Delegate42)Delegate.Remove(delegate2, delegate42_1);
				@delegate = Interlocked.CompareExchange<Magazine.Delegate42>(ref Magazine.delegate42_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x001919B0 File Offset: 0x0018FBB0
		[CompilerGenerated]
		public static void smethod_4(Magazine.Delegate43 delegate43_1)
		{
			Magazine.Delegate43 @delegate = Magazine.delegate43_0;
			Magazine.Delegate43 delegate2;
			do
			{
				delegate2 = @delegate;
				Magazine.Delegate43 value = (Magazine.Delegate43)Delegate.Combine(delegate2, delegate43_1);
				@delegate = Interlocked.CompareExchange<Magazine.Delegate43>(ref Magazine.delegate43_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x001919E4 File Offset: 0x0018FBE4
		[CompilerGenerated]
		public static void smethod_5(Magazine.Delegate43 delegate43_1)
		{
			Magazine.Delegate43 @delegate = Magazine.delegate43_0;
			Magazine.Delegate43 delegate2;
			do
			{
				delegate2 = @delegate;
				Magazine.Delegate43 value = (Magazine.Delegate43)Delegate.Remove(delegate2, delegate43_1);
				@delegate = Interlocked.CompareExchange<Magazine.Delegate43>(ref Magazine.delegate43_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00191A18 File Offset: 0x0018FC18
		public override void vmethod_1()
		{
			base.vmethod_1();
			try
			{
				foreach (WeaponRec weaponRec in this.vmethod_10())
				{
					weaponRec.vmethod_1();
				}
			}
			finally
			{
				List<WeaponRec>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00191A70 File Offset: 0x0018FC70
		public string method_23(HashSet<string> hashSet_0, Scenario scenario_0)
		{
			string result;
			try
			{
				if (this.stringBuilder_0 == null)
				{
					this.stringBuilder_0 = new StringBuilder(500);
				}
				else
				{
					this.stringBuilder_0.Clear();
				}
				this.stringBuilder_0.Append("<Magazine>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</Magazine>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<TTF>").Append(XmlConvert.ToString(this.float_0)).Append("</TTF>");
				if (this._ComponentStatus_0 != PlatformComponent._ComponentStatus.Operational)
				{
					StringBuilder stringBuilder = this.stringBuilder_0.Append("<Status>");
					byte componentStatus_ = (byte)this._ComponentStatus_0;
					stringBuilder.Append(componentStatus_.ToString()).Append("</Status>");
				}
				if (base.method_16() != PlatformComponent._DamageSeverityFactor.Light)
				{
					this.stringBuilder_0.Append("<DamageSeverity>").Append(((byte)base.method_16()).ToString()).Append("</DamageSeverity>");
				}
				this.stringBuilder_0.Append("<DBID>").Append(this.DBID.ToString()).Append("</DBID>");
				if (this.observableList_0.Count > 0)
				{
					this.stringBuilder_0.Append("<Weapons>");
					try
					{
						foreach (WeaponRec weaponRec in this.observableList_0)
						{
							this.stringBuilder_0.Append(weaponRec.method_8(hashSet_0, scenario_0));
						}
					}
					finally
					{
						List<WeaponRec>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.stringBuilder_0.Append("</Weapons>");
				}
				this.stringBuilder_0.Append("</Magazine>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100671", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0000BADC File Offset: 0x00009CDC
		private Magazine()
		{
			this.vmethod_11(new ObservableList<WeaponRec>());
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00191CDC File Offset: 0x0018FEDC
		public static Magazine smethod_6(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			Magazine result;
			try
			{
				Magazine magazine = new Magazine();
				XmlNode xmlNode = Misc.smethod_44(xmlNode_0.ChildNodes, "DBID");
				int magazineDBID;
				if (Information.IsNothing(xmlNode))
				{
					magazineDBID = DBFunctions.smethod_81(Misc.smethod_44(xmlNode_0.ChildNodes, "Name").InnerText, scenario_0.method_39());
				}
				else
				{
					magazineDBID = Conversions.ToInteger(xmlNode.InnerText);
				}
				magazine = DBFunctions.smethod_82(magazineDBID, ref scenario_0, false);
				string innerText = Misc.smethod_44(xmlNode_0.ChildNodes, "ID").InnerText;
				if (dictionary_0.ContainsKey(innerText))
				{
					result = (Magazine)dictionary_0[innerText];
				}
				else
				{
					magazine.vmethod_0(innerText);
					dictionary_0.Add(magazine.string_0, magazine);
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode2 = (XmlNode)obj;
							string name = xmlNode2.Name;
							if (Operators.CompareString(name, "Status", false) != 0)
							{
								if (Operators.CompareString(name, "DamageSeverity", false) != 0)
								{
									if (Operators.CompareString(name, "Weapons", false) != 0)
									{
										if (Operators.CompareString(name, "TimeToFire", false) == 0 || Operators.CompareString(name, "TTF", false) == 0)
										{
											magazine.float_0 = XmlConvert.ToSingle(xmlNode2.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										try
										{
											foreach (object obj2 in xmlNode2.ChildNodes)
											{
												XmlNode xmlNode3 = (XmlNode)obj2;
												WeaponRec gparam_ = WeaponRec.smethod_2(ref xmlNode3, ref dictionary_0, ref scenario_0);
												magazine.vmethod_10().method_4(gparam_);
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
								magazine.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode2.InnerText));
							}
							else
							{
								string innerText2 = xmlNode2.InnerText;
								if (Operators.CompareString(innerText2, "Operational", false) != 0)
								{
									if (Operators.CompareString(innerText2, "Damaged", false) != 0)
									{
										if (Operators.CompareString(innerText2, "Destroyed", false) != 0)
										{
											magazine._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode2.InnerText);
										}
										else
										{
											magazine._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										magazine._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									magazine._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
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
					result = magazine;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100672", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0000BAEF File Offset: 0x00009CEF
		public float method_24()
		{
			return this.float_0;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0000BAF7 File Offset: 0x00009CF7
		public void method_25(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0000BB00 File Offset: 0x00009D00
		public void ResetTimeToFire()
		{
			this.method_25((float)this.int_0);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00191FA4 File Offset: 0x001901A4
		public Magazine(ActiveUnit activeUnit_1, int int_2, string string_2, GlobalVariables.ArmorRating armorRating_1, int int_3, int int_4, bool bool_13) : base(activeUnit_1)
		{
			this.vmethod_11(new ObservableList<WeaponRec>());
			this.DBID = int_2;
			this.Name = string_2;
			this.armorRating_0 = armorRating_1;
			this.int_0 = int_3;
			this.float_0 = (float)this.int_0;
			this.int_1 = int_4;
			this.bool_11 = bool_13;
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00192000 File Offset: 0x00190200
		public string method_26(int int_2)
		{
			string result;
			try
			{
				try
				{
					foreach (WeaponRec weaponRec in this.vmethod_10())
					{
						if (weaponRec.method_12(base.method_18().scenario_0).DBID == int_2 && weaponRec.method_9() < weaponRec.int_2)
						{
							weaponRec.method_10(weaponRec.method_9() + 1);
							base.method_21();
							return "OK";
						}
					}
				}
				finally
				{
					List<WeaponRec>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				result = "No suitable weapon record found";
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100673", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x001920DC File Offset: 0x001902DC
		public int method_27(ref int int_2, ref int int_3)
		{
			int_2 = 0;
			int_3 = 0;
			try
			{
				foreach (WeaponRec weaponRec in this.vmethod_10())
				{
					if (weaponRec.method_9() != 0)
					{
						if (weaponRec.int_4 > 1)
						{
							float num = (float)weaponRec.method_9() / (float)weaponRec.int_4;
							if (num != (float)((int)Math.Round((double)num)))
							{
								int_3++;
								int_2 += (int)Math.Floor((double)weaponRec.method_9() / (double)weaponRec.int_4);
							}
							else
							{
								int_2 += (int)Math.Round((double)num);
							}
						}
						else
						{
							int_2 += weaponRec.method_9();
						}
					}
				}
			}
			finally
			{
				List<WeaponRec>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return int_2 + int_3;
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x0019219C File Offset: 0x0019039C
		public string method_28(int int_2, bool bool_13, ref float float_1)
		{
			bool flag = false;
			bool flag2 = false;
			string result;
			try
			{
				int num = this.vmethod_10().Count - 1;
				for (int i = 0; i <= num; i++)
				{
					WeaponRec weaponRec = this.vmethod_10()[i];
					if (weaponRec.int_5 == int_2)
					{
						if (weaponRec.method_9() > 0)
						{
							if (bool_13)
							{
								weaponRec.method_10(weaponRec.method_9() - 1);
								weaponRec.method_15();
								base.method_21();
								return "OK";
							}
							if (weaponRec.float_0 == 0f)
							{
								weaponRec.method_10(weaponRec.method_9() - 1);
								float_1 = weaponRec.method_16();
								base.method_21();
								return "OK";
							}
							flag = true;
						}
						else
						{
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					result = "Suitable weapon record found but not ready";
				}
				else if (flag2)
				{
					result = "Suitable weapon record not found";
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100674", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x001922B0 File Offset: 0x001904B0
		private void method_29(object sender, EventArgs5<WeaponRec> e)
		{
			try
			{
				foreach (WeaponRec weaponRec in e.method_0())
				{
					Magazine.Delegate42 @delegate = Magazine.delegate42_0;
					if (@delegate != null)
					{
						@delegate(this.string_0, weaponRec.string_0);
					}
				}
			}
			finally
			{
				IEnumerator<WeaponRec> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00192314 File Offset: 0x00190514
		private void method_30(object sender, EventArgs5<WeaponRec> e)
		{
			try
			{
				foreach (WeaponRec weaponRec in e.method_0())
				{
					Magazine.Delegate43 @delegate = Magazine.delegate43_0;
					if (@delegate != null)
					{
						@delegate(this.string_0, weaponRec.string_0);
					}
				}
			}
			finally
			{
				IEnumerator<WeaponRec> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x040011F8 RID: 4600
		public GlobalVariables.ArmorRating armorRating_0;

		// Token: 0x040011F9 RID: 4601
		public int int_0;

		// Token: 0x040011FA RID: 4602
		public int int_1;

		// Token: 0x040011FB RID: 4603
		[CompilerGenerated]
		[AccessedThroughProperty("Weapons")]
		private ObservableList<WeaponRec> observableList_0;

		// Token: 0x040011FC RID: 4604
		public bool bool_11;

		// Token: 0x040011FD RID: 4605
		private float float_0;

		// Token: 0x040011FE RID: 4606
		public bool bool_12;

		// Token: 0x040011FF RID: 4607
		[CompilerGenerated]
		private static Magazine.Delegate42 delegate42_0;

		// Token: 0x04001200 RID: 4608
		[CompilerGenerated]
		private static Magazine.Delegate43 delegate43_0;

		// Token: 0x04001201 RID: 4609
		private StringBuilder stringBuilder_0;

		// Token: 0x020002D8 RID: 728
		// (Invoke) Token: 0x0600158B RID: 5515
		internal delegate void Delegate42(string MagazineObjectID, string WeaponRecObjectID);

		// Token: 0x020002D9 RID: 729
		// (Invoke) Token: 0x0600158F RID: 5519
		internal delegate void Delegate43(string MagazineObjectID, string WeaponRecObjectID);
	}
}
