using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns12;

namespace Command_Core
{
	// Token: 0x0200035C RID: 860
	public sealed class Submarine_Weaponry : ActiveUnit_Weaponry
	{
		// Token: 0x060019A6 RID: 6566 RVA: 0x0000CFFE File Offset: 0x0000B1FE
		private Submarine method_66()
		{
			if (Information.IsNothing(this.submarine_0))
			{
				this.submarine_0 = (Submarine)this.activeUnit_0;
			}
			return this.submarine_0;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x001D11BC File Offset: 0x001CF3BC
		public override void vmethod_2(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_1)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Submarine_Weaponry");
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
				if (this.bool_2)
				{
					xmlWriter_0.WriteElementString("IDLZ", "True");
				}
				xmlWriter_0.WriteEndElement();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100840", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x001D12A0 File Offset: 0x001CF4A0
		public static Submarine_Weaponry smethod_6(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Submarine_Weaponry result;
			try
			{
				Submarine_Weaponry submarine_Weaponry = new Submarine_Weaponry(ref activeUnit_1);
				submarine_Weaponry.activeUnit_0 = activeUnit_1;
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
								if (Operators.CompareString(name, "IDLZ", false) == 0)
								{
									submarine_Weaponry.bool_2 = true;
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
										submarine_Weaponry.vmethod_0().Add(@class);
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
				result = submarine_Weaponry;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100841", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Submarine_Weaponry(ref activeUnit_1);
			}
			return result;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00008F49 File Offset: 0x00007149
		public Submarine_Weaponry(ref ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x001D1484 File Offset: 0x001CF684
		public override Weapon vmethod_13()
		{
			List<WeaponRec> list = base.method_0(false);
			List<Weapon> list2 = new List<Weapon>();
			try
			{
				foreach (WeaponRec weaponRec in list)
				{
					if (weaponRec.int_0 != 0)
					{
						Weapon weapon = weaponRec.method_12(this.activeUnit_0.scenario_0);
						Submarine._SubmarineType submarineType_ = this.method_66()._SubmarineType_0;
						if (submarineType_ - Submarine._SubmarineType.SSB <= 3)
						{
							if (weapon.method_2())
							{
								list2.Add(weapon);
							}
						}
						else if (weapon.bool_7)
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
				result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list2, (Submarine_Weaponry._Closure$__.$I7-0 == null) ? (Submarine_Weaponry._Closure$__.$I7-0 = new Func<Weapon, float>(Submarine_Weaponry._Closure$__.$I.method_0)) : Submarine_Weaponry._Closure$__.$I7-0), 0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x001D1570 File Offset: 0x001CF770
		public override Weapon vmethod_14()
		{
			List<Weapon> list = new List<Weapon>();
			List<Weapon> list2 = this.vmethod_4();
			try
			{
				foreach (Weapon weapon in list2)
				{
					Submarine._SubmarineType submarineType_ = this.method_66()._SubmarineType_0;
					if (submarineType_ - Submarine._SubmarineType.SSB <= 3)
					{
						if (weapon.method_2())
						{
							list.Add(weapon);
						}
					}
					else if (weapon.bool_7)
					{
						list.Add(weapon);
					}
				}
			}
			finally
			{
				List<Weapon>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			Weapon result;
			if (list.Count > 0)
			{
				result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (Submarine_Weaponry._Closure$__.$I9-0 == null) ? (Submarine_Weaponry._Closure$__.$I9-0 = new Func<Weapon, float>(Submarine_Weaponry._Closure$__.$I.method_1)) : Submarine_Weaponry._Closure$__.$I9-0), 0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x001D1640 File Offset: 0x001CF840
		public override Weapon vmethod_15()
		{
			List<Weapon> list = Enumerable.ToList<Weapon>(Enumerable.Where<Weapon>(this.vmethod_4(), (Submarine_Weaponry._Closure$__.$I11-0 == null) ? (Submarine_Weaponry._Closure$__.$I11-0 = new Func<Weapon, bool>(Submarine_Weaponry._Closure$__.$I.method_2)) : Submarine_Weaponry._Closure$__.$I11-0));
			Weapon result;
			if (list.Count > 0)
			{
				result = Enumerable.ElementAtOrDefault<Weapon>(Enumerable.OrderByDescending<Weapon, float>(list, (Submarine_Weaponry._Closure$__.$I11-1 == null) ? (Submarine_Weaponry._Closure$__.$I11-1 = new Func<Weapon, float>(Submarine_Weaponry._Closure$__.$I.method_3)) : Submarine_Weaponry._Closure$__.$I11-1), 0);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x001D16C4 File Offset: 0x001CF8C4
		public bool method_67()
		{
			bool result;
			if (this.activeUnit_0 != null && this.activeUnit_0.scenario_0 != null && this.activeUnit_0.scenario_0.method_17() != null)
			{
				List<Weapon> list = Enumerable.ToList<Weapon>(this.activeUnit_0.scenario_0.method_17());
				try
				{
					foreach (Weapon weapon in list)
					{
						if (weapon.bool_7 && weapon.method_177() == this.activeUnit_0 && weapon.method_179() == this.activeUnit_0)
						{
							return true;
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
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x001D1780 File Offset: 0x001CF980
		public void method_68(Submarine_Weaponry.Enum121 enum121_0)
		{
			try
			{
				foreach (Weapon weapon in this.activeUnit_0.scenario_0.method_17())
				{
					if (weapon.bool_7 && weapon.method_177() == this.activeUnit_0 && weapon.method_179() == this.activeUnit_0)
					{
						if (enum121_0 != Submarine_Weaponry.Enum121.const_1)
						{
							if (enum121_0 == Submarine_Weaponry.Enum121.const_2)
							{
								this.activeUnit_0.method_124(this.activeUnit_0.Name + " has broken the guidance wire for " + weapon.Name + " (excessive speed)", "Torpedo wire broken", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
							}
						}
						else
						{
							this.activeUnit_0.method_124(this.activeUnit_0.Name + " has broken the guidance wire for " + weapon.Name + " (excessive turn rate)", "Torpedo wire broken", LoggedMessage.MessageType.UnitAI, 0, false, new Geopoint_Struct(this.activeUnit_0.vmethod_28(null), this.activeUnit_0.vmethod_30(null)));
						}
						weapon.method_228(false, true, true);
					}
				}
			}
			finally
			{
				List<Weapon>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x04001699 RID: 5785
		private Submarine submarine_0;

		// Token: 0x0200035D RID: 861
		internal enum Enum121
		{
			// Token: 0x0400169B RID: 5787
			const_0,
			// Token: 0x0400169C RID: 5788
			const_1,
			// Token: 0x0400169D RID: 5789
			const_2
		}
	}
}
