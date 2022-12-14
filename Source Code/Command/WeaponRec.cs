using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x0200037A RID: 890
	public sealed class WeaponRec : Class310
	{
		// Token: 0x06001A98 RID: 6808 RVA: 0x001E1430 File Offset: 0x001DF630
		[CompilerGenerated]
		public static void smethod_0(WeaponRec.Delegate54 delegate54_1)
		{
			WeaponRec.Delegate54 @delegate = WeaponRec.delegate54_0;
			WeaponRec.Delegate54 delegate2;
			do
			{
				delegate2 = @delegate;
				WeaponRec.Delegate54 value = (WeaponRec.Delegate54)Delegate.Combine(delegate2, delegate54_1);
				@delegate = Interlocked.CompareExchange<WeaponRec.Delegate54>(ref WeaponRec.delegate54_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x001E1464 File Offset: 0x001DF664
		[CompilerGenerated]
		public static void smethod_1(WeaponRec.Delegate54 delegate54_1)
		{
			WeaponRec.Delegate54 @delegate = WeaponRec.delegate54_0;
			WeaponRec.Delegate54 delegate2;
			do
			{
				delegate2 = @delegate;
				WeaponRec.Delegate54 value = (WeaponRec.Delegate54)Delegate.Remove(delegate2, delegate54_1);
				@delegate = Interlocked.CompareExchange<WeaponRec.Delegate54>(ref WeaponRec.delegate54_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0000D7B1 File Offset: 0x0000B9B1
		public override void vmethod_1()
		{
			base.vmethod_1();
			if (!Information.IsNothing(this.weapon_0))
			{
				this.weapon_0.vmethod_1();
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x001E1498 File Offset: 0x001DF698
		public string method_8(HashSet<string> hashSet_0, Scenario scenario_0)
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
				this.stringBuilder_0.Append("<WRec>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</WRec>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<DL>").Append(this.int_0.ToString()).Append("</DL>");
				this.stringBuilder_0.Append("<CL>").Append(this.method_9().ToString()).Append("</CL>");
				this.stringBuilder_0.Append("<ML>").Append(this.int_2.ToString()).Append("</ML>");
				this.stringBuilder_0.Append("<ROF>").Append(this.int_3.ToString()).Append("</ROF>");
				if (this.bool_11)
				{
					this.stringBuilder_0.Append("<OW>").Append("True").Append("</OW>");
				}
				if (this.bool_12)
				{
					this.stringBuilder_0.Append("<IW>").Append("True").Append("</IW>");
				}
				if (this.int_4 != 1)
				{
					this.stringBuilder_0.Append("<Mult>").Append(this.int_4.ToString()).Append("</Mult>");
				}
				this.stringBuilder_0.Append("<WeapID>").Append(this.int_5.ToString()).Append("</WeapID>");
				if (this.float_0 != 0f)
				{
					this.stringBuilder_0.Append("<TTF>").Append(XmlConvert.ToString(this.float_0)).Append("</TTF>");
				}
				if (this.nullable_0 != null)
				{
					this.stringBuilder_0.Append("<RecID>").Append(this.nullable_0.Value.ToString()).Append("</RecID>");
				}
				if (!Information.IsNothing(this.method_12(scenario_0)) && this.method_12(scenario_0).method_214())
				{
					this.stringBuilder_0.Append("<FuelTank>").Append(XmlConvert.ToString(this.method_12(scenario_0).vmethod_67()[0].float_0)).Append("</FuelTank>");
				}
				this.stringBuilder_0.Append("</WRec>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 1013249583745892137", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x001E17E8 File Offset: 0x001DF9E8
		public static WeaponRec smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref Scenario scenario_0)
		{
			WeaponRec result;
			try
			{
				WeaponRec weaponRec = new WeaponRec();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num > 1776879945U)
						{
							if (num <= 2195334682U)
							{
								if (num <= 1978145240U)
								{
									if (num != 1902341061U)
									{
										if (num != 1978145240U)
										{
											continue;
										}
										if (Operators.CompareString(name, "ROF", false) == 0)
										{
											weaponRec.int_3 = Conversions.ToInteger(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "WeapID", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2045027659U)
								{
									if (num != 2195334682U)
									{
										continue;
									}
									if (Operators.CompareString(name, "CL", false) == 0)
									{
										goto IL_26B;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "OW", false) == 0)
									{
										weaponRec.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 2333728401U)
							{
								if (num != 2305894001U)
								{
									if (num != 2333728401U)
									{
										continue;
									}
									if (Operators.CompareString(name, "TimeToFire", false) == 0)
									{
										goto IL_2DB;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "FuelTank", false) == 0)
									{
										weaponRec.method_12(scenario_0).vmethod_67()[0].float_0 = XmlConvert.ToSingle(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 3140810977U)
							{
								if (num != 3611682378U)
								{
									if (num != 3767140958U)
									{
										continue;
									}
									if (Operators.CompareString(name, "DefaultLoad", false) == 0)
									{
										goto IL_353;
									}
									continue;
								}
								else if (Operators.CompareString(name, "WeaponDBID", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Multiple", false) == 0)
								{
									goto IL_397;
								}
								continue;
							}
							weaponRec.int_5 = Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						if (num > 1037013698U)
						{
							if (num <= 1154386829U)
							{
								if (num != 1054853948U)
								{
									if (num != 1154386829U)
									{
										continue;
									}
									if (Operators.CompareString(name, "DL", false) != 0)
									{
										continue;
									}
									goto IL_353;
								}
								else if (Operators.CompareString(name, "ML", false) != 0)
								{
									continue;
								}
							}
							else if (num != 1298133685U)
							{
								if (num != 1458105184U)
								{
									if (num != 1776879945U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IW", false) == 0)
									{
										weaponRec.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "ID", false) == 0)
									{
										weaponRec.vmethod_0(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (Operators.CompareString(name, "MaxLoad", false) != 0)
							{
								continue;
							}
							weaponRec.int_2 = Conversions.ToInteger(xmlNode.InnerText);
							continue;
						}
						if (num <= 547133647U)
						{
							if (num != 126317010U)
							{
								if (num != 547133647U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Mult", false) != 0)
								{
									continue;
								}
								goto IL_397;
							}
							else if (Operators.CompareString(name, "CurrentLoad", false) != 0)
							{
								continue;
							}
						}
						else if (num != 963109897U)
						{
							if (num != 1037013698U)
							{
								continue;
							}
							if (Operators.CompareString(name, "RecDBID", false) == 0)
							{
								weaponRec.nullable_0 = new int?(Conversions.ToInteger(xmlNode.InnerText));
								continue;
							}
							continue;
						}
						else
						{
							if (Operators.CompareString(name, "TTF", false) != 0)
							{
								continue;
							}
							goto IL_2DB;
						}
						IL_26B:
						weaponRec.int_1 = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_2DB:
						weaponRec.float_0 = XmlConvert.ToSingle(xmlNode.InnerText);
						continue;
						IL_353:
						weaponRec.int_0 = Conversions.ToInteger(xmlNode.InnerText);
						continue;
						IL_397:
						weaponRec.int_4 = Conversions.ToInteger(xmlNode.InnerText);
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
				result = weaponRec;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101076", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new WeaponRec();
			}
			return result;
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0000D7D1 File Offset: 0x0000B9D1
		private WeaponRec()
		{
			this.int_4 = 1;
			this.bool_11 = false;
			this.bool_12 = false;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x0000D7EE File Offset: 0x0000B9EE
		public int method_9()
		{
			return this.int_1;
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x001E1C38 File Offset: 0x001DFE38
		public void method_10(int int_6)
		{
			bool flag = int_6 != this.int_1;
			this.int_1 = int_6;
			if (flag)
			{
				WeaponRec.Delegate54 @delegate = WeaponRec.delegate54_0;
				if (@delegate != null)
				{
					@delegate(this.string_0);
				}
			}
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0000D7F6 File Offset: 0x0000B9F6
		public bool method_11(Mount mount_1)
		{
			return mount_1.hashSet_0.Contains(this.int_5);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x001E1C70 File Offset: 0x001DFE70
		public Weapon method_12(Scenario scenario_0)
		{
			if (this.weapon_0 == null)
			{
				if (this.method_14(scenario_0))
				{
					this.weapon_0 = scenario_0.method_87(this.int_5);
				}
				else
				{
					this.weapon_0 = Weapon.smethod_16(ref scenario_0, this.int_5, null);
				}
			}
			return this.weapon_0;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0000D809 File Offset: 0x0000BA09
		public void method_13()
		{
			this.weapon_0 = null;
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x001E1CBC File Offset: 0x001DFEBC
		public bool method_14(Scenario scenario_0)
		{
			int num = this.int_5;
			SQLiteConnection sqliteConnection = scenario_0.method_39();
			Weapon._WeaponType weaponType = DBFunctions.smethod_73(num, ref sqliteConnection);
			if (weaponType <= Weapon._WeaponType.DepthCharge)
			{
				if (weaponType - Weapon._WeaponType.Rocket <= 2 || weaponType == Weapon._WeaponType.DepthCharge)
				{
					goto IL_47;
				}
			}
			else if (weaponType == Weapon._WeaponType.Laser || weaponType - Weapon._WeaponType.Troops <= 1)
			{
				goto IL_47;
			}
			return false;
			IL_47:
			return true;
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0000D812 File Offset: 0x0000BA12
		public void method_15()
		{
			if (this.int_3 < 0)
			{
				this.float_0 = (float)(30 * -(float)this.int_3);
				return;
			}
			this.float_0 = (float)this.int_3;
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0000D83C File Offset: 0x0000BA3C
		public float method_16()
		{
			return (float)this.int_3;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x001E1D14 File Offset: 0x001DFF14
		public WeaponRec(ref Scenario scenario_0, int int_6, int int_7, int int_8, int int_9, int int_10, bool bool_13, bool bool_14)
		{
			this.int_4 = 1;
			this.bool_11 = false;
			this.bool_12 = false;
			this.int_0 = int_7;
			this.int_1 = this.int_0;
			this.int_2 = int_8;
			this.int_3 = int_9;
			this.int_4 = int_10;
			this.float_0 = 0f;
			this.int_5 = int_6;
			this.bool_11 = bool_13;
			this.bool_12 = bool_14;
		}

		// Token: 0x040017BF RID: 6079
		public int? nullable_0;

		// Token: 0x040017C0 RID: 6080
		public int int_0;

		// Token: 0x040017C1 RID: 6081
		private int int_1;

		// Token: 0x040017C2 RID: 6082
		public int int_2;

		// Token: 0x040017C3 RID: 6083
		private int int_3;

		// Token: 0x040017C4 RID: 6084
		public int int_4;

		// Token: 0x040017C5 RID: 6085
		private Weapon weapon_0;

		// Token: 0x040017C6 RID: 6086
		public bool bool_11;

		// Token: 0x040017C7 RID: 6087
		public bool bool_12;

		// Token: 0x040017C8 RID: 6088
		public int int_5;

		// Token: 0x040017C9 RID: 6089
		public float float_0;

		// Token: 0x040017CA RID: 6090
		public Mount mount_0;

		// Token: 0x040017CB RID: 6091
		[CompilerGenerated]
		private static WeaponRec.Delegate54 delegate54_0;

		// Token: 0x040017CC RID: 6092
		private StringBuilder stringBuilder_0;

		// Token: 0x0200037B RID: 891
		// (Invoke) Token: 0x06001AAA RID: 6826
		internal delegate void Delegate54(string WeaponRecObjectID);
	}
}
