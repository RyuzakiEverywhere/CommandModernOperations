using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Xml;
using Command_Core.DAL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace Command_Core
{
	// Token: 0x020002D4 RID: 724
	public sealed class Engine : PlatformComponent
	{
		// Token: 0x06001562 RID: 5474 RVA: 0x0000BA60 File Offset: 0x00009C60
		public override void vmethod_1()
		{
			base.vmethod_1();
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00191084 File Offset: 0x0018F284
		public string method_23(HashSet<string> hashSet_0)
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
				this.stringBuilder_0.Append("<Engine>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</Engine>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<DBID>").Append(this.DBID).Append("</DBID>");
				this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
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
				this.stringBuilder_0.Append("</Engine>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100669", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0000BA68 File Offset: 0x00009C68
		private Engine() : base(null)
		{
			this.altBand_0 = new AltBand[0];
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00191260 File Offset: 0x0018F460
		public static Engine smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ref ActiveUnit activeUnit_1)
		{
			Engine result;
			try
			{
				Engine engine = new Engine();
				engine.method_19(activeUnit_1);
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Name", false) != 0)
							{
								if (Operators.CompareString(name, "Status", false) != 0)
								{
									if (Operators.CompareString(name, "DamageSeverity", false) != 0)
									{
										if (Operators.CompareString(name, "DBID", false) == 0)
										{
											int int_ = Conversions.ToInteger(xmlNode.InnerText);
											Engine engine2;
											ActiveUnit activeUnit_2 = (engine2 = engine).method_18();
											Engine engine3 = DBFunctions.smethod_94(int_, ref activeUnit_2);
											engine2.method_19(activeUnit_2);
											engine3.vmethod_0(engine.string_0);
											engine3._ComponentStatus_0 = engine.vmethod_5();
											engine3.Name = engine.Name;
											engine = engine3;
										}
									}
									else
									{
										engine.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
									}
								}
								else
								{
									string innerText = xmlNode.InnerText;
									if (Operators.CompareString(innerText, "Operational", false) != 0)
									{
										if (Operators.CompareString(innerText, "Damaged", false) != 0)
										{
											if (Operators.CompareString(innerText, "Destroyed", false) != 0)
											{
												engine._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
											}
											else
											{
												engine._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
											}
										}
										else
										{
											engine._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
										}
									}
									else
									{
										engine._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
									}
								}
							}
							else
							{
								engine.Name = xmlNode.InnerText;
							}
						}
						else
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								return (Engine)dictionary_0[xmlNode.InnerText];
							}
							engine.vmethod_0(xmlNode.InnerText);
							dictionary_0.Add(engine.string_0, engine);
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
				result = engine;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100670", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new Engine();
			}
			return result;
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x001914A8 File Offset: 0x0018F6A8
		public AltBand method_24(ActiveUnit.Throttle throttle_0)
		{
			AltBand result;
			switch (throttle_0)
			{
			case ActiveUnit.Throttle.FullStop:
				result = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float?>(Enumerable.Select<AltBand, AltBand>(this.altBand_0, (Engine._Closure$__.$I9-0 == null) ? (Engine._Closure$__.$I9-0 = new Func<AltBand, AltBand>(Engine._Closure$__.$I.method_0)) : Engine._Closure$__.$I9-0), (Engine._Closure$__.$I9-1 == null) ? (Engine._Closure$__.$I9-1 = new Func<AltBand, float?>(Engine._Closure$__.$I.method_1)) : Engine._Closure$__.$I9-1), 0);
				break;
			case ActiveUnit.Throttle.Loiter:
				result = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float>(Enumerable.Select<AltBand, AltBand>(this.altBand_0, (Engine._Closure$__.$I9-2 == null) ? (Engine._Closure$__.$I9-2 = new Func<AltBand, AltBand>(Engine._Closure$__.$I.method_2)) : Engine._Closure$__.$I9-2), (Engine._Closure$__.$I9-3 == null) ? (Engine._Closure$__.$I9-3 = new Func<AltBand, float>(Engine._Closure$__.$I.method_3)) : Engine._Closure$__.$I9-3), 0);
				break;
			case ActiveUnit.Throttle.Cruise:
				result = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float>(Enumerable.Select<AltBand, AltBand>(this.altBand_0, (Engine._Closure$__.$I9-4 == null) ? (Engine._Closure$__.$I9-4 = new Func<AltBand, AltBand>(Engine._Closure$__.$I.method_4)) : Engine._Closure$__.$I9-4), (Engine._Closure$__.$I9-5 == null) ? (Engine._Closure$__.$I9-5 = new Func<AltBand, float>(Engine._Closure$__.$I.method_5)) : Engine._Closure$__.$I9-5), 0);
				break;
			case ActiveUnit.Throttle.Full:
				result = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float?>(Enumerable.Select<AltBand, AltBand>(this.altBand_0, (Engine._Closure$__.$I9-6 == null) ? (Engine._Closure$__.$I9-6 = new Func<AltBand, AltBand>(Engine._Closure$__.$I.method_6)) : Engine._Closure$__.$I9-6), (Engine._Closure$__.$I9-7 == null) ? (Engine._Closure$__.$I9-7 = new Func<AltBand, float?>(Engine._Closure$__.$I.method_7)) : Engine._Closure$__.$I9-7), 0);
				break;
			case ActiveUnit.Throttle.Flank:
				result = Enumerable.ElementAtOrDefault<AltBand>(Enumerable.OrderByDescending<AltBand, float?>(Enumerable.Select<AltBand, AltBand>(this.altBand_0, (Engine._Closure$__.$I9-8 == null) ? (Engine._Closure$__.$I9-8 = new Func<AltBand, AltBand>(Engine._Closure$__.$I.method_8)) : Engine._Closure$__.$I9-8), (Engine._Closure$__.$I9-9 == null) ? (Engine._Closure$__.$I9-9 = new Func<AltBand, float?>(Engine._Closure$__.$I.method_9)) : Engine._Closure$__.$I9-9), 0);
				break;
			default:
				if (this.altBand_0.Length > 0)
				{
					result = this.altBand_0[this.altBand_0.Length - 1];
				}
				else
				{
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					result = null;
				}
				break;
			}
			return result;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x001916F4 File Offset: 0x0018F8F4
		public bool method_25(FuelRec._FuelType _FuelType_0)
		{
			Engine.Enum112 @enum = this.enum112_0;
			if (@enum <= Engine.Enum112.const_8)
			{
				if (@enum - Engine.Enum112.const_1 <= 2 || @enum == Engine.Enum112.const_5)
				{
					return _FuelType_0 == FuelRec._FuelType.AviationFuel;
				}
				switch (@enum)
				{
				case Engine.Enum112.const_6:
					return _FuelType_0 == FuelRec._FuelType.DieselFuel;
				case Engine.Enum112.const_7:
					return _FuelType_0 == FuelRec._FuelType.OilFuel;
				case Engine.Enum112.const_8:
					return _FuelType_0 == FuelRec._FuelType.GasFuel;
				}
			}
			else
			{
				if (@enum == Engine.Enum112.const_10)
				{
					return _FuelType_0 == FuelRec._FuelType.Battery;
				}
				if (@enum == Engine.Enum112.const_11)
				{
					return _FuelType_0 == FuelRec._FuelType.AirIndepedent;
				}
				switch (@enum)
				{
				case Engine.Enum112.const_12:
					return _FuelType_0 == FuelRec._FuelType.RocketFuel;
				case Engine.Enum112.const_13:
					return _FuelType_0 == FuelRec._FuelType.RocketFuel;
				case Engine.Enum112.const_14:
					return _FuelType_0 == FuelRec._FuelType.WeaponCoast;
				}
			}
			return false;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0000BA7D File Offset: 0x00009C7D
		public Engine(ActiveUnit activeUnit_1, int int_0, string string_2, Engine.Enum112 enum112_1) : base(activeUnit_1)
		{
			this.altBand_0 = new AltBand[0];
			this.DBID = int_0;
			this.Name = string_2;
			this.enum112_0 = enum112_1;
		}

		// Token: 0x040011D9 RID: 4569
		public Engine.Enum112 enum112_0;

		// Token: 0x040011DA RID: 4570
		public AltBand[] altBand_0;

		// Token: 0x040011DB RID: 4571
		public bool bool_11;

		// Token: 0x040011DC RID: 4572
		private StringBuilder stringBuilder_0;

		// Token: 0x020002D5 RID: 725
		internal enum Enum112 : short
		{
			// Token: 0x040011DE RID: 4574
			const_0 = 1001,
			// Token: 0x040011DF RID: 4575
			const_1 = 2001,
			// Token: 0x040011E0 RID: 4576
			const_2,
			// Token: 0x040011E1 RID: 4577
			const_3,
			// Token: 0x040011E2 RID: 4578
			const_4,
			// Token: 0x040011E3 RID: 4579
			const_5,
			// Token: 0x040011E4 RID: 4580
			const_6 = 3001,
			// Token: 0x040011E5 RID: 4581
			const_7,
			// Token: 0x040011E6 RID: 4582
			const_8,
			// Token: 0x040011E7 RID: 4583
			const_9,
			// Token: 0x040011E8 RID: 4584
			const_10 = 4001,
			// Token: 0x040011E9 RID: 4585
			const_11,
			// Token: 0x040011EA RID: 4586
			const_12 = 5001,
			// Token: 0x040011EB RID: 4587
			const_13,
			// Token: 0x040011EC RID: 4588
			const_14
		}
	}
}
