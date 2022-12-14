using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;
using ns9;

namespace Command_Core
{
	// Token: 0x0200038D RID: 909
	public sealed class Weapon_CommStuff : ActiveUnit_CommStuff
	{
		// Token: 0x06001BB3 RID: 7091 RVA: 0x0000DD46 File Offset: 0x0000BF46
		private Weapon method_13()
		{
			if (Information.IsNothing(this.weapon_0))
			{
				this.weapon_0 = (Weapon)this.activeUnit_0;
			}
			return this.weapon_0;
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x001F917C File Offset: 0x001F737C
		public override void vmethod_0(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			checked
			{
				try
				{
					xmlWriter_0.WriteStartElement("Weapon_CommStuff");
					CommDevice[] array = this.activeUnit_0.vmethod_94();
					for (int i = 0; i < array.Length; i++)
					{
						array[i].method_19(this.activeUnit_0);
					}
					xmlWriter_0.WriteStartElement("CLE");
					Class312[] array2 = base.method_2();
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j].method_8(ref xmlWriter_0, ref hashSet_0, this.activeUnit_0.scenario_0);
					}
					xmlWriter_0.WriteEndElement();
					xmlWriter_0.WriteEndElement();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100973", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x001F924C File Offset: 0x001F744C
		public static Weapon_CommStuff smethod_1(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Weapon_CommStuff result;
			try
			{
				Weapon_CommStuff weapon_CommStuff = new Weapon_CommStuff(ref activeUnit_1);
				weapon_CommStuff.activeUnit_0 = activeUnit_1;
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "CommLinksEstablished", false) == 0 || Operators.CompareString(name, "CLE", false) == 0)
						{
							weapon_CommStuff.class312_0 = new Class312[xmlNode.ChildNodes.Count - 1 + 1];
							int num = xmlNode.ChildNodes.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								XmlNode xmlNode2 = xmlNode.ChildNodes[i];
								Class312 @class = Class312.smethod_0(ref xmlNode2, ref dictionary_0, ref activeUnit_1);
								weapon_CommStuff.class312_0[i] = @class;
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
				result = weapon_CommStuff;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100974", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Weapon_CommStuff(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00008E05 File Offset: 0x00007005
		public Weapon_CommStuff(ref ActiveUnit activeUnit_1) : base(ref activeUnit_1)
		{
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x001F938C File Offset: 0x001F758C
		public bool method_14()
		{
			return !Information.IsNothing(this.method_13().method_179()) && !Information.IsNothing(this.method_15()) && !this.method_15().commDevice_0.struct31_0.bool_2;
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x001F93DC File Offset: 0x001F75DC
		public Class312 method_15()
		{
			foreach (Class312 @class in base.method_2())
			{
				if (@class.activeUnit_0 == this.method_13().method_179())
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0000DD6C File Offset: 0x0000BF6C
		public override void vmethod_2()
		{
			if (this.float_0 <= 0f)
			{
				base.vmethod_2();
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0000DD81 File Offset: 0x0000BF81
		public override bool vmethod_3(CommDevice commDevice_0, ActiveUnit activeUnit_1, bool bool_2)
		{
			bool flag = base.vmethod_3(commDevice_0, activeUnit_1, bool_2);
			if (flag)
			{
				this.method_13().method_180(activeUnit_1);
			}
			return flag;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x001F9420 File Offset: 0x001F7620
		public void method_16(float float_1)
		{
			try
			{
				Weapon weapon = this.method_13();
				if (weapon.method_179() != null)
				{
					if (weapon.method_179().method_82())
					{
						weapon.method_180(null);
					}
					else if (!weapon.method_179().vmethod_127())
					{
						weapon.method_180(null);
					}
				}
				else
				{
					base.vmethod_2();
				}
				this.float_0 -= float_1;
				if (!weapon.method_199() & weapon.method_159() > 20f)
				{
					if (this.float_0 > 0f)
					{
						return;
					}
					this.float_0 = (float)GameGeneral.smethod_5().Next(1, 16);
				}
				if (this.float_0 < 0f)
				{
					this.float_0 = 0f;
				}
				CommDevice[] array = this.activeUnit_0.vmethod_94();
				if (array.Length != 0)
				{
					if (base.method_12())
					{
						if (!Information.IsNothing(weapon.method_179()))
						{
							CommDevice commDevice = base.method_11(array, weapon.method_179());
							if (!Information.IsNothing(commDevice))
							{
								this.vmethod_3(commDevice, weapon.method_179(), false);
							}
							else
							{
								weapon.method_180(null);
							}
						}
						if (weapon.method_179() == null && Enumerable.Any<CommDevice>(Enumerable.Where<CommDevice>(array, (Weapon_CommStuff._Closure$__.$I12-0 == null) ? (Weapon_CommStuff._Closure$__.$I12-0 = new Func<CommDevice, bool>(Weapon_CommStuff._Closure$__.$I.method_0)) : Weapon_CommStuff._Closure$__.$I12-0)))
						{
							Weapon_CommStuff.Class398 @class = new Weapon_CommStuff.Class398(@class);
							double num = Enumerable.Max(Enumerable.Select<CommDevice, double>(array, (Weapon_CommStuff._Closure$__.$I12-1 == null) ? (Weapon_CommStuff._Closure$__.$I12-1 = new Func<CommDevice, double>(Weapon_CommStuff._Closure$__.$I.method_1)) : Weapon_CommStuff._Closure$__.$I12-1));
							Math2.smethod_13(num);
							@class.double_0 = weapon.vmethod_30(null);
							@class.double_1 = weapon.vmethod_28(null);
							List<ActiveUnit> list = new List<ActiveUnit>(Enumerable.Count<ActiveUnit>(this.activeUnit_0.vmethod_7(false).method_48(this.activeUnit_0.scenario_0)));
							foreach (ActiveUnit activeUnit in this.activeUnit_0.vmethod_7(false).method_48(this.activeUnit_0.scenario_0))
							{
								if (activeUnit != this.activeUnit_0 && !activeUnit.bool_2 && (weapon.method_167() != Weapon._WeaponType.Sonobuoy || !activeUnit.bool_8))
								{
									list.Add(activeUnit);
								}
							}
							List<ActiveUnit> list2 = Class410.smethod_4(list, true, @class.double_0, @class.double_1, num);
							list2 = Enumerable.ToList<ActiveUnit>(Enumerable.OrderBy<ActiveUnit, double>(list2, new Func<ActiveUnit, double>(@class.method_0)));
							try
							{
								foreach (ActiveUnit activeUnit_ in list2)
								{
									CommDevice commDevice2 = base.method_11(array, activeUnit_);
									if (!Information.IsNothing(commDevice2))
									{
										base.vmethod_2();
										if (weapon.method_167() == Weapon._WeaponType.Sonobuoy)
										{
											this.vmethod_3(commDevice2, activeUnit_, false);
										}
										else
										{
											this.vmethod_3(commDevice2, activeUnit_, true);
										}
										break;
									}
								}
							}
							finally
							{
								List<ActiveUnit>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100975", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x040018CA RID: 6346
		private Weapon weapon_0;

		// Token: 0x0200038E RID: 910
		[CompilerGenerated]
		internal sealed class Class398
		{
			// Token: 0x06001BBC RID: 7100 RVA: 0x0000DD9B File Offset: 0x0000BF9B
			public Class398(Weapon_CommStuff.Class398 class398_0)
			{
				if (class398_0 != null)
				{
					this.double_0 = class398_0.double_0;
					this.double_1 = class398_0.double_1;
				}
			}

			// Token: 0x06001BBD RID: 7101 RVA: 0x001F977C File Offset: 0x001F797C
			internal double method_0(ActiveUnit activeUnit_0)
			{
				return Class410.smethod_0(this.double_0, this.double_1, activeUnit_0.vmethod_30(null), activeUnit_0.vmethod_28(null));
			}

			// Token: 0x040018CB RID: 6347
			public double double_0;

			// Token: 0x040018CC RID: 6348
			public double double_1;
		}
	}
}
