using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using Microsoft.VisualBasic;
using ns10;
using ns12;
using ns13;
using ns19;
using ns20;

namespace Command_Core
{
	// Token: 0x0200036F RID: 879
	public class Unit : Class310
	{
		// Token: 0x06001A1E RID: 6686 RVA: 0x0000D44A File Offset: 0x0000B64A
		public bool method_8()
		{
			return this.enum122_0 > Unit.Enum122.const_0;
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x001DC4AC File Offset: 0x001DA6AC
		public virtual void vmethod_4(ref XmlWriter xmlWriter_0, ref HashSet<string> hashSet_0)
		{
			try
			{
				xmlWriter_0.WriteStartElement("Unit");
				xmlWriter_0.WriteElementString("ID", this.string_0);
				if (hashSet_0.Contains(this.string_0))
				{
					xmlWriter_0.WriteEndElement();
				}
				else
				{
					hashSet_0.Add(this.string_0);
					xmlWriter_0.WriteElementString("Name", this.Name);
					xmlWriter_0.WriteElementString("CurrentHeading", XmlConvert.ToString(this.vmethod_9()));
					xmlWriter_0.WriteElementString("CurrentSpeed", XmlConvert.ToString(this.vmethod_40()));
					xmlWriter_0.WriteElementString("CurrentAltitude", XmlConvert.ToString(this.vmethod_14(false)));
					xmlWriter_0.WriteElementString("Longitude", XmlConvert.ToString(this.double_1));
					xmlWriter_0.WriteElementString("Latitude", XmlConvert.ToString(this.double_0));
					xmlWriter_0.WriteElementString("UnitClass", this.string_2);
					if (this.method_17().Count > 0)
					{
						xmlWriter_0.WriteStartElement("RangeSymbols");
						try
						{
							foreach (RangeSymbol rangeSymbol in this.method_17())
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
					xmlWriter_0.WriteElementString("Side", this.side_0.method_51());
					if (!string.IsNullOrEmpty(this.string_3))
					{
						xmlWriter_0.WriteElementString("Message", this.string_3);
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
							List<string>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						xmlWriter_0.WriteEndElement();
					}
					xmlWriter_0.WriteEndElement();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100864", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_5()
		{
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00003024 File Offset: 0x00001224
		public virtual bool vmethod_6()
		{
			return false;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0000D455 File Offset: 0x0000B655
		public virtual Side vmethod_7(bool SetSideOnly = false)
		{
			return this.side_0;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000095C7 File Offset: 0x000077C7
		public virtual void vmethod_8(bool SetSideOnly = false, Side value)
		{
			this.side_0 = value;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0000D45D File Offset: 0x0000B65D
		public virtual float vmethod_9()
		{
			return this.float_0;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0000D465 File Offset: 0x0000B665
		public virtual void vmethod_10(float float_9)
		{
			if (float.IsNaN(float_9))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.float_0 = float_9;
			}
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00003024 File Offset: 0x00001224
		public virtual int vmethod_11()
		{
			return 0;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00003024 File Offset: 0x00001224
		public virtual int vmethod_12()
		{
			return 0;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x001DC778 File Offset: 0x001DA978
		public int method_9(bool bool_12, bool bool_13, bool bool_14)
		{
			int result;
			try
			{
				if (!this.bool_1)
				{
					if (bool_14 || this.nullable_7 == null)
					{
						this.nullable_7 = new int?((int)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), bool_13));
					}
				}
				else
				{
					Group group = (Group)this;
					if (group.method_143() == Group.GroupType.AirGroup)
					{
						if (Information.IsNothing(group.method_147()))
						{
							return 0;
						}
						Aircraft aircraft = (Aircraft)group.method_147();
						this.nullable_7 = new int?(aircraft.method_9(false, bool_13, bool_14));
					}
					else if (group.method_143() == Group.GroupType.SubGroup)
					{
						if (Information.IsNothing(group.method_147()))
						{
							return 0;
						}
						Submarine submarine = (Submarine)group.method_147();
						this.nullable_7 = new int?(submarine.method_9(false, bool_13, bool_14));
					}
					else
					{
						this.nullable_7 = new int?((int)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), bool_13));
					}
				}
				if (bool_12)
				{
					int? num = this.nullable_7;
					if (((num != null) ? new bool?(num.GetValueOrDefault() < 0) : null).GetValueOrDefault())
					{
						return 0;
					}
				}
				if (this.nullable_7 == null)
				{
					int num2 = (int)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), bool_13);
					this.nullable_7 = new int?(num2);
					result = num2;
				}
				else
				{
					result = this.nullable_7.Value;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200295", ex.Message);
				GameGeneral.smethod_25(ref ex);
				result = (int)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), bool_13);
			}
			return result;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x001DC98C File Offset: 0x001DAB8C
		public int method_10(bool bool_12, float float_9)
		{
			if (Information.IsNothing(this.nullable_8))
			{
				this.method_13(float_9);
			}
			if (bool_12)
			{
				int? num = this.nullable_8;
				if (((num != null) ? new bool?(num.GetValueOrDefault() < 0) : null).GetValueOrDefault())
				{
					return 0;
				}
			}
			return this.nullable_8.Value;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0000D483 File Offset: 0x0000B683
		public double method_11(float float_9)
		{
			if (Information.IsNothing(this.nullable_3))
			{
				this.method_13(float_9);
			}
			return this.nullable_3.Value;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0000D4A9 File Offset: 0x0000B6A9
		public double method_12(float float_9)
		{
			if (Information.IsNothing(this.nullable_4))
			{
				this.method_13(float_9);
			}
			return this.nullable_4.Value;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x001DC9FC File Offset: 0x001DABFC
		private void method_13(float float_9)
		{
			if (this.vmethod_40() > 0f)
			{
				float num = this.method_48(float_9);
				double value;
				double value2;
				Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref value, ref value2, (double)num, (double)this.vmethod_9());
				this.nullable_8 = new int?((int)Terrain.smethod_7(value2, value, false));
				this.nullable_3 = new double?(value);
				this.nullable_4 = new double?(value2);
				return;
			}
			if (Information.IsNothing(this.nullable_7))
			{
				this.nullable_7 = new int?(this.method_9(true, false, false));
			}
			this.nullable_8 = this.nullable_7;
			this.nullable_3 = new double?(this.double_1);
			this.nullable_4 = new double?(this.double_0);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x001DCAD0 File Offset: 0x001DACD0
		public virtual float vmethod_13()
		{
			float result;
			try
			{
				if (this.nullable_9 != null)
				{
					result = this.nullable_9.Value;
				}
				else
				{
					if (!this.bool_1)
					{
						if (!this.method_14())
						{
							if (this.bool_3)
							{
								if (this.method_15())
								{
									this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
								}
								else
								{
									this.nullable_9 = new float?(this.vmethod_14(false));
								}
							}
							else if (this.bool_2)
							{
								if (this.method_15())
								{
									this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
								}
								else if (this.bool_7)
								{
									this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
								}
								else
								{
									this.nullable_9 = new float?(this.vmethod_14(false));
								}
							}
							else
							{
								if (this.vmethod_14(false) < -11000f)
								{
									this.vmethod_15(false, 0f);
								}
								this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
							}
						}
						else
						{
							Contact contact = (Contact)this;
							if (Information.IsNothing(contact.activeUnit_0))
							{
								return 0f;
							}
							if (contact.activeUnit_0.bool_3)
							{
								if (this.method_15())
								{
									this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
								}
								else
								{
									this.nullable_9 = new float?(this.vmethod_14(false));
								}
							}
							else if (contact.activeUnit_0.bool_2)
							{
								if (this.method_15())
								{
									this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
								}
								else if (this.bool_7)
								{
									this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
								}
								else
								{
									this.nullable_9 = new float?(this.vmethod_14(false));
								}
							}
							else
							{
								if (this.vmethod_14(false) < -11000f)
								{
									this.vmethod_15(false, 0f);
								}
								this.nullable_9 = new float?(this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false));
							}
						}
					}
					else
					{
						Group group = (Group)this;
						if (group.method_143() == Group.GroupType.AirGroup)
						{
							if (Information.IsNothing(group.method_147()))
							{
								return 0f;
							}
							Aircraft aircraft = (Aircraft)group.method_147();
							this.nullable_9 = new float?(aircraft.vmethod_13());
						}
						else if (group.method_143() == Group.GroupType.SubGroup)
						{
							if (Information.IsNothing(group.method_147()))
							{
								return 0f;
							}
							Submarine submarine = (Submarine)group.method_147();
							this.nullable_9 = new float?(submarine.vmethod_13());
						}
						else
						{
							this.nullable_9 = new float?(0f);
						}
					}
					if (this.nullable_9 == null)
					{
						float num = this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false);
						this.nullable_9 = new float?(num);
						result = num;
					}
					else
					{
						result = this.nullable_9.Value;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200320", ex.Message);
				GameGeneral.smethod_25(ref ex);
				bool isAttached = Debugger.IsAttached;
				float num2 = this.vmethod_14(false) - (float)Terrain.smethod_7(this.vmethod_30(null), this.vmethod_28(null), false);
				this.nullable_9 = new float?(num2);
				result = num2;
			}
			return result;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0000D4CF File Offset: 0x0000B6CF
		public virtual float vmethod_14(bool DoSanityCheck = false)
		{
			return this.float_2;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0000D4D7 File Offset: 0x0000B6D7
		public virtual void vmethod_15(bool DoSanityCheck = false, float value)
		{
			if (this.float_2 != value)
			{
				this.nullable_9 = null;
			}
			this.float_2 = value;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0000D4F5 File Offset: 0x0000B6F5
		public virtual float vmethod_16()
		{
			return this.float_7;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0000D4FD File Offset: 0x0000B6FD
		public virtual void vmethod_17(float float_9)
		{
			float_9 = (float)Math.Round((double)float_9, 2);
			this.float_7 = float_9;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00009D67 File Offset: 0x00007F67
		public virtual float vmethod_18()
		{
			return this.float_3;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00009D6F File Offset: 0x00007F6F
		public virtual void vmethod_19(float float_9)
		{
			this.float_3 = float_9;
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0000D511 File Offset: 0x0000B711
		public virtual float vmethod_20()
		{
			return this.float_4;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0000D519 File Offset: 0x0000B719
		public virtual void vmethod_21(float float_9)
		{
			this.float_4 = float_9;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00009D78 File Offset: 0x00007F78
		public virtual float vmethod_22()
		{
			return this.float_5;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0000D522 File Offset: 0x0000B722
		public virtual void vmethod_23(float float_9)
		{
			if (float.IsInfinity(float_9))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				if (float.IsPositiveInfinity(float_9))
				{
					float_9 = 89.9f;
				}
				if (float.IsNegativeInfinity(float_9))
				{
					float_9 = -89.9f;
				}
			}
			this.float_5 = float_9;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0000D55D File Offset: 0x0000B75D
		public virtual float vmethod_24()
		{
			return this.float_6;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0000D565 File Offset: 0x0000B765
		public virtual void vmethod_25(float float_9)
		{
			this.float_6 = float_9;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0000D56E File Offset: 0x0000B76E
		public bool method_14()
		{
			return base.GetType() == typeof(Contact);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0000D582 File Offset: 0x0000B782
		public bool method_15()
		{
			return this.method_9(false, false, false) > 0;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0000D590 File Offset: 0x0000B790
		public bool method_16(float float_9)
		{
			return this.method_10(false, float_9) > 0;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0000D59D File Offset: 0x0000B79D
		public virtual bool vmethod_26()
		{
			return this.vmethod_13() < 0f;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		public virtual bool vmethod_27()
		{
			return this.vmethod_14(false) < 0f && this.vmethod_14(false) >= (float)this.method_9(false, false, false);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		public Unit()
		{
			this.list_0 = new List<string>();
			this.lazy_0 = new Lazy<ConcurrentDictionary<int, bool>>();
			this.enum122_0 = Unit.Enum122.const_0;
			this.bool_11 = false;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0000D600 File Offset: 0x0000B800
		public List<RangeSymbol> method_17()
		{
			if (Information.IsNothing(this.list_1))
			{
				this.list_1 = new List<RangeSymbol>();
			}
			return this.list_1;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0000D620 File Offset: 0x0000B820
		public virtual double vmethod_28(bool? _HintIsOperating = null)
		{
			return this.double_1;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x001DCF94 File Offset: 0x001DB194
		public virtual void vmethod_29(bool? _HintIsOperating = null, double value)
		{
			if (value > 180.0 || value < -180.0)
			{
				value = Math2.smethod_11(ref value);
			}
			if (double.IsNaN(value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				if (this.double_1 != value)
				{
					this.nullable_9 = null;
				}
				this.double_1 = value;
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0000D628 File Offset: 0x0000B828
		public virtual double vmethod_30(bool? _HintIsOperating = null)
		{
			return this.double_0;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x001DCFF4 File Offset: 0x001DB1F4
		public virtual void vmethod_31(bool? _HintIsOperating = null, double value)
		{
			if (value > 90.0 || value < -90.0)
			{
				value = Math2.smethod_10(ref value);
			}
			if (double.IsNaN(value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				if (this.double_0 != value)
				{
					this.nullable_9 = null;
				}
				this.double_0 = value;
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0000D630 File Offset: 0x0000B830
		public virtual double vmethod_32()
		{
			if (Information.IsNothing(this.nullable_0))
			{
				this.nullable_0 = new double?(this.double_1);
			}
			return this.nullable_0.Value;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x001DD054 File Offset: 0x001DB254
		public virtual void vmethod_33(double double_2)
		{
			if (double_2 > 180.0 || double_2 < -180.0)
			{
				double_2 = Math2.smethod_11(ref double_2);
			}
			if (double.IsNaN(double_2))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.nullable_0 = new double?(double_2);
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0000D660 File Offset: 0x0000B860
		public virtual double vmethod_34()
		{
			if (Information.IsNothing(this.nullable_1))
			{
				this.nullable_1 = new double?(this.double_0);
			}
			return this.nullable_1.Value;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x001DD0A4 File Offset: 0x001DB2A4
		public virtual void vmethod_35(double double_2)
		{
			if (double_2 > 90.0 || double_2 < -90.0)
			{
				double_2 = Math2.smethod_10(ref double_2);
			}
			if (double.IsNaN(double_2))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.nullable_1 = new double?(double_2);
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x001DD0F4 File Offset: 0x001DB2F4
		public virtual double? vmethod_36()
		{
			double? result;
			if (Information.IsNothing(this.nullable_5))
			{
				result = this.nullable_5;
			}
			else
			{
				result = new double?(this.nullable_5.Value);
			}
			return result;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x001DD130 File Offset: 0x001DB330
		public virtual void vmethod_37(double? nullable_10)
		{
			if (nullable_10 == null)
			{
				this.nullable_5 = null;
				return;
			}
			double? num = nullable_10;
			if (!((num != null) ? new bool?(num.GetValueOrDefault() > 180.0) : null).GetValueOrDefault())
			{
				num = nullable_10;
				if (!((num != null) ? new bool?(num.GetValueOrDefault() < -180.0) : null).GetValueOrDefault())
				{
					goto IL_9A;
				}
			}
			double value = nullable_10.Value;
			nullable_10 = new double?(Math2.smethod_11(ref value));
			IL_9A:
			if (double.IsNaN(nullable_10.Value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.nullable_5 = nullable_10;
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x001DD1FC File Offset: 0x001DB3FC
		public virtual double? vmethod_38()
		{
			double? result;
			if (Information.IsNothing(this.nullable_6))
			{
				result = null;
			}
			else
			{
				result = new double?(this.nullable_6.Value);
			}
			return result;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x001DD238 File Offset: 0x001DB438
		public virtual void vmethod_39(double? nullable_10)
		{
			if (nullable_10 == null)
			{
				this.nullable_6 = null;
				return;
			}
			double? num = nullable_10;
			if (!((num != null) ? new bool?(num.GetValueOrDefault() > 90.0) : null).GetValueOrDefault())
			{
				num = nullable_10;
				if (!((num != null) ? new bool?(num.GetValueOrDefault() < -90.0) : null).GetValueOrDefault())
				{
					goto IL_9A;
				}
			}
			double value = nullable_10.Value;
			nullable_10 = new double?(Math2.smethod_10(ref value));
			IL_9A:
			if (double.IsNaN(nullable_10.Value))
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
					return;
				}
			}
			else
			{
				this.nullable_6 = nullable_10;
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0000D690 File Offset: 0x0000B890
		public float method_18()
		{
			if (this.nullable_2 == null)
			{
				this.nullable_2 = new float?(this.vmethod_14(false));
			}
			return this.nullable_2.Value;
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000D6BC File Offset: 0x0000B8BC
		public void method_19(float float_9)
		{
			this.nullable_2 = new float?(float_9);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x001DD304 File Offset: 0x001DB504
		public float method_20()
		{
			float result;
			if (this.vmethod_6())
			{
				result = (float)(Math2.smethod_2((double)this.vmethod_18()) * (double)this.vmethod_40());
			}
			else
			{
				result = this.vmethod_40();
			}
			return result;
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0000D6CA File Offset: 0x0000B8CA
		public float method_21(Scenario scenario_0)
		{
			return (this.vmethod_14(false) - this.method_18()) / scenario_0.method_40();
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0000D6E1 File Offset: 0x0000B8E1
		public virtual float vmethod_40()
		{
			return this.float_1;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0000D6E9 File Offset: 0x0000B8E9
		public virtual void vmethod_41(float float_9)
		{
			if (float.IsNaN(float_9) || float.IsInfinity(float_9))
			{
				float_9 = 0f;
			}
			this.float_1 = float_9;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x001DD33C File Offset: 0x001DB53C
		public bool method_22()
		{
			return !this.bool_1 && this.bool_8 && ((Facility)this)._FacilityCategory_0 == Facility._FacilityCategory.AirBase;
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x001DD378 File Offset: 0x001DB578
		public float method_23(GeoPoint geoPoint_0)
		{
			return Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), geoPoint_0.imethod_2(), geoPoint_0.imethod_0());
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x001DD3B4 File Offset: 0x001DB5B4
		public float method_24(Geopoint_Struct geopoint_Struct_0)
		{
			return Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), geopoint_Struct_0.double_1, geopoint_Struct_0.double_0);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x001DD3F0 File Offset: 0x001DB5F0
		public float method_25(double double_2, double double_3)
		{
			return Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), double_2, double_3);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x001DD424 File Offset: 0x001DB624
		public float method_26(Geopoint_Struct geopoint_Struct_0)
		{
			float num = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), geopoint_Struct_0.double_1, geopoint_Struct_0.double_0);
			float num2 = (float)((double)Math.Abs(this.vmethod_14(false) - geopoint_Struct_0.float_0) / 1852.0);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x001DD490 File Offset: 0x001DB690
		public float method_27(GeoPoint geoPoint_0)
		{
			float num = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), geoPoint_0.imethod_2(), geoPoint_0.imethod_0());
			float num2 = (float)((double)Math.Abs(this.vmethod_14(false) - geoPoint_0.imethod_4()) / 1852.0);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x001DD4FC File Offset: 0x001DB6FC
		public double method_28(GeoPoint geoPoint_0)
		{
			Struct65 struct65_ = default(Struct65);
			Struct65 struct65_2 = default(Struct65);
			Struct65 struct65_3 = default(Struct65);
			Struct65 struct65_4 = default(Struct65);
			struct65_.method_1(this.vmethod_30(null));
			struct65_2.method_1(this.vmethod_28(null));
			struct65_3.method_1(geoPoint_0.imethod_2());
			struct65_4.method_1(geoPoint_0.imethod_0());
			return Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4).method_0();
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x001DD584 File Offset: 0x001DB784
		public double method_29(Geopoint_Struct geopoint_Struct_0)
		{
			Struct65 struct65_ = default(Struct65);
			Struct65 struct65_2 = default(Struct65);
			Struct65 struct65_3 = default(Struct65);
			Struct65 struct65_4 = default(Struct65);
			struct65_.method_1(this.vmethod_30(null));
			struct65_2.method_1(this.vmethod_28(null));
			struct65_3.method_1(geopoint_Struct_0.double_1);
			struct65_4.method_1(geopoint_Struct_0.double_0);
			return Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4).method_0();
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x001DD60C File Offset: 0x001DB80C
		public double method_30(ref double double_2, ref double double_3)
		{
			Struct65 struct65_ = default(Struct65);
			Struct65 struct65_2 = default(Struct65);
			Struct65 struct65_3 = default(Struct65);
			Struct65 struct65_4 = default(Struct65);
			struct65_.method_1(this.vmethod_30(null));
			struct65_2.method_1(this.vmethod_28(null));
			struct65_3.method_1(double_2);
			struct65_4.method_1(double_3);
			return Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4).method_0();
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x001DD68C File Offset: 0x001DB88C
		public double method_31(Unit unit_0)
		{
			Struct65 struct65_ = default(Struct65);
			Struct65 struct65_2 = default(Struct65);
			Struct65 struct65_3 = default(Struct65);
			Struct65 struct65_4 = default(Struct65);
			struct65_.method_1(this.vmethod_30(null));
			struct65_2.method_1(this.vmethod_28(null));
			struct65_3.method_1(unit_0.vmethod_30(null));
			struct65_4.method_1(unit_0.vmethod_28(null));
			return Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4).method_0();
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x001DD728 File Offset: 0x001DB928
		public float method_32(Unit unit_0)
		{
			return Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), unit_0.vmethod_30(null), unit_0.vmethod_28(null));
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x001DD778 File Offset: 0x001DB978
		public float method_33(Unit unit_0)
		{
			float num = Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), unit_0.vmethod_30(null), unit_0.vmethod_28(null));
			return Math2.smethod_7(Class437.smethod_3(this.vmethod_9(), num));
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x001DD7D8 File Offset: 0x001DB9D8
		public float method_34(double double_2, double double_3)
		{
			return Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), double_2, double_3);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x001DD80C File Offset: 0x001DBA0C
		public float method_35(double double_2, double double_3)
		{
			float num = Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), double_2, double_3);
			return Math2.smethod_7(Class437.smethod_3(this.vmethod_9(), num));
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x001DD850 File Offset: 0x001DBA50
		public float method_36(Unit unit_0)
		{
			float result;
			if (unit_0 == null)
			{
				result = float.MaxValue;
			}
			else
			{
				result = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), unit_0.vmethod_30(null), unit_0.vmethod_28(null));
			}
			return result;
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x001DD8AC File Offset: 0x001DBAAC
		public float method_37(Unit theTarget, float HorizRangeProvided = 0f)
		{
			float result;
			if (theTarget == null)
			{
				result = float.MaxValue;
			}
			else
			{
				float num;
				if (HorizRangeProvided == 0f)
				{
					num = this.method_36(theTarget);
				}
				else
				{
					num = HorizRangeProvided;
				}
				float num2 = (float)((double)Math.Abs(this.vmethod_14(false) - theTarget.vmethod_14(false)) * 0.000539957);
				if (num2 == 0f)
				{
					result = num;
				}
				else
				{
					result = (float)Math.Sqrt((double)(num * num + num2 * num2));
				}
			}
			return result;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x001DD918 File Offset: 0x001DBB18
		public float method_38(double double_2, double double_3, float float_9, float float_10, float float_11, float float_12)
		{
			float result;
			try
			{
				if (float_10 == 0f && Math.Abs(Math.Round((double)Class437.smethod_3(this.method_34(double_2, double_3), float_12), 1)) <= 0.1)
				{
					result = float_11;
				}
				else if (Class410.smethod_2(this.vmethod_30(null), this.vmethod_28(null), double_2, double_3) < 50.0)
				{
					result = (float)Class432.smethod_1(this.vmethod_30(null), this.vmethod_28(null), (double)float_11, (double)float_12, double_2, double_3, (double)float_10, (double)float_9);
				}
				else
				{
					float num = float_11 / 3600f;
					double num2;
					double num3;
					Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref num2, ref num3, (double)num, (double)float_12);
					num = float_10 / 3600f;
					double double_4 = 0.0;
					double double_5 = 0.0;
					Class411.smethod_1(double_3, double_2, ref double_5, ref double_4, (double)num, (double)float_9);
					float num4 = Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), double_2, double_3);
					float num5 = Math2.smethod_15(num3, num2, double_4, double_5);
					result = (num4 - num5) * 3600f;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200045", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x001DDABC File Offset: 0x001DBCBC
		public float method_39(Unit unit_0, float float_9, float float_10)
		{
			return this.method_38(unit_0.vmethod_30(null), unit_0.vmethod_28(null), unit_0.vmethod_9(), unit_0.vmethod_40(), float_9, float_10);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x001DDAFC File Offset: 0x001DBCFC
		public float method_40(Unit unit_0)
		{
			float result;
			try
			{
				if (unit_0.bool_5)
				{
					if (((Submarine)unit_0).method_162())
					{
						result = 2f;
					}
					else if (((Submarine)unit_0).method_161())
					{
						result = 8f;
					}
					else
					{
						result = 0f;
					}
				}
				else if (!unit_0.bool_6 && !unit_0.bool_8)
				{
					result = unit_0.vmethod_14(false);
				}
				else if (unit_0.vmethod_14(false) < 0f)
				{
					result = 0f;
				}
				else
				{
					result = unit_0.vmethod_14(false) + (float)unit_0.vmethod_11();
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100868", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0f;
			}
			return result;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x001DDBD8 File Offset: 0x001DBDD8
		public float method_41(Unit unit_0)
		{
			float result;
			if (unit_0.bool_5)
			{
				if (Math.Round((double)unit_0.vmethod_14(false)) < -20.0)
				{
					result = 0f;
				}
				else if (Math.Round((double)unit_0.vmethod_14(false)) == -20.0)
				{
					result = 2f;
				}
				else
				{
					result = 2f + ((float)Math.Abs(-20) - Math.Abs(unit_0.vmethod_14(false)));
				}
			}
			else if (!this.bool_6 && !this.bool_8)
			{
				result = this.vmethod_14(false);
			}
			else if (this.vmethod_14(false) < 0f)
			{
				result = 0f;
			}
			else
			{
				result = this.vmethod_14(false) + (float)this.vmethod_11();
			}
			return result;
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x001DDC8C File Offset: 0x001DBE8C
		public bool method_42(Unit theUnit, ref Scenario theScen, bool IgnoreRadarHorizon = false)
		{
			bool result;
			try
			{
				if (this.vmethod_14(false) > 0f && this.vmethod_13() > 0f && (theUnit.bool_6 || theUnit.bool_8 || theUnit.bool_5))
				{
					result = theUnit.method_42(this, ref theScen, IgnoreRadarHorizon);
				}
				else if (!IgnoreRadarHorizon && Class562.smethod_1(this, theUnit) < this.method_36(theUnit))
				{
					result = false;
				}
				else
				{
					float num = this.method_40(theUnit);
					float num2 = this.method_41(this);
					if (this.bool_5 && Math.Round((double)this.vmethod_14(false)) < -20.0 && theUnit.vmethod_14(false) > 0f)
					{
						result = false;
					}
					else
					{
						bool flag2;
						try
						{
							bool? hintIsOperating = null;
							double value = this.vmethod_30(hintIsOperating);
							bool? hintIsOperating2 = null;
							double value2 = this.vmethod_28(hintIsOperating2);
							bool? hintIsOperating3 = null;
							double value3 = theUnit.vmethod_30(hintIsOperating3);
							bool? hintIsOperating4 = null;
							double value4 = theUnit.vmethod_28(hintIsOperating4);
							bool flag = Scenario.smethod_16(ref value, ref value2, ref num2, ref value3, ref value4, ref num, false, 0, IgnoreRadarHorizon);
							theUnit.vmethod_29(hintIsOperating4, value4);
							theUnit.vmethod_31(hintIsOperating3, value3);
							this.vmethod_29(hintIsOperating2, value2);
							this.vmethod_31(hintIsOperating, value);
							flag2 = flag;
						}
						catch (OutOfMemoryException ex)
						{
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							GameGeneral.smethod_10();
							bool? hintIsOperating4 = null;
							double value4 = this.vmethod_30(hintIsOperating4);
							bool? hintIsOperating3 = null;
							double value3 = this.vmethod_28(hintIsOperating3);
							bool? hintIsOperating2 = null;
							double value2 = theUnit.vmethod_30(hintIsOperating2);
							bool? hintIsOperating = null;
							double value = theUnit.vmethod_28(hintIsOperating);
							bool flag3 = Scenario.smethod_16(ref value4, ref value3, ref num2, ref value2, ref value, ref num, false, 0, IgnoreRadarHorizon);
							theUnit.vmethod_29(hintIsOperating, value);
							theUnit.vmethod_31(hintIsOperating2, value2);
							this.vmethod_29(hintIsOperating3, value3);
							this.vmethod_31(hintIsOperating4, value4);
							flag2 = flag3;
						}
						catch (Exception ex2)
						{
							ex2.Data.Add("Error at 101175", "");
							GameGeneral.smethod_25(ref ex2);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
						}
						result = flag2;
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100869", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x001DDF3C File Offset: 0x001DC13C
		public Unit.Enum123 method_43(Unit unit_0, ref Scenario scenario_0, bool bool_12)
		{
			Unit.Enum123 result;
			try
			{
				if (this.bool_5 && Math.Round((double)this.vmethod_14(false)) < -20.0 && unit_0.vmethod_14(false) > 0f)
				{
					result = Unit.Enum123.const_5;
				}
				else
				{
					float num;
					if (unit_0.bool_5)
					{
						if (((Submarine)unit_0).method_162())
						{
							num = 2f;
						}
						else if (((Submarine)unit_0).method_161())
						{
							num = 8f;
						}
					}
					else if (!unit_0.bool_6 && !unit_0.bool_8)
					{
						num = unit_0.vmethod_14(false);
					}
					else
					{
						num = unit_0.vmethod_14(false) + (float)unit_0.vmethod_12();
					}
					float num2;
					if (!this.bool_6 && !this.bool_8)
					{
						if (this.bool_2 && ((Weapon)this).method_167() == Weapon._WeaponType.Sonobuoy && !unit_0.bool_5)
						{
							num2 = 1f;
						}
						else if (this.bool_5 && Math.Round((double)this.vmethod_14(false)) <= -20.0)
						{
							num2 = (float)(Math.Abs(-20) + 2) + this.vmethod_14(false);
						}
						else
						{
							num2 = this.vmethod_14(false);
						}
					}
					else
					{
						num2 = this.vmethod_14(false) + (float)this.vmethod_12();
					}
					bool flag = true;
					bool flag2 = num2 < 0f;
					bool flag3 = num < 0f;
					if (flag2 && num > 0f)
					{
						result = Unit.Enum123.const_5;
					}
					else if (this.vmethod_14(false) > 0f && flag3)
					{
						result = Unit.Enum123.const_5;
					}
					else
					{
						if (flag2 && num == 0f)
						{
							flag = false;
						}
						if (this.vmethod_14(false) == 0f && flag3)
						{
							flag = false;
						}
						if (flag2 && flag3)
						{
							flag = false;
						}
						if (flag && Class562.smethod_4(num2, num) < Math2.smethod_15(this.vmethod_30(null), this.vmethod_28(null), unit_0.vmethod_30(null), unit_0.vmethod_28(null)))
						{
							result = Unit.Enum123.const_2;
						}
						else if (bool_12 && !Weather.smethod_6(this, unit_0, ref scenario_0))
						{
							result = Unit.Enum123.const_4;
						}
						else if (base.method_1())
						{
							result = Unit.Enum123.const_1;
						}
						else if (unit_0.method_1())
						{
							result = unit_0.method_43(this, ref scenario_0, bool_12);
						}
						else
						{
							bool flag5;
							try
							{
								bool? hintIsOperating = null;
								double value = this.vmethod_30(hintIsOperating);
								bool? hintIsOperating2 = null;
								double value2 = this.vmethod_28(hintIsOperating2);
								bool? hintIsOperating3 = null;
								double value3 = unit_0.vmethod_30(hintIsOperating3);
								bool? hintIsOperating4 = null;
								double value4 = unit_0.vmethod_28(hintIsOperating4);
								bool flag4 = Scenario.smethod_16(ref value, ref value2, ref num2, ref value3, ref value4, ref num, false, 0, false);
								unit_0.vmethod_29(hintIsOperating4, value4);
								unit_0.vmethod_31(hintIsOperating3, value3);
								this.vmethod_29(hintIsOperating2, value2);
								this.vmethod_31(hintIsOperating, value);
								flag5 = flag4;
							}
							catch (OutOfMemoryException ex)
							{
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
								GameGeneral.smethod_10();
								bool? hintIsOperating4 = null;
								double value4 = this.vmethod_30(hintIsOperating4);
								bool? hintIsOperating3 = null;
								double value3 = this.vmethod_28(hintIsOperating3);
								bool? hintIsOperating2 = null;
								double value2 = unit_0.vmethod_30(hintIsOperating2);
								bool? hintIsOperating = null;
								double value = unit_0.vmethod_28(hintIsOperating);
								bool flag6 = Scenario.smethod_16(ref value4, ref value3, ref num2, ref value2, ref value, ref num, false, 0, false);
								unit_0.vmethod_29(hintIsOperating, value);
								unit_0.vmethod_31(hintIsOperating2, value2);
								this.vmethod_29(hintIsOperating3, value3);
								this.vmethod_31(hintIsOperating4, value4);
								flag5 = flag6;
							}
							catch (Exception ex2)
							{
								ex2.Data.Add("Error at 101176", "");
								GameGeneral.smethod_25(ref ex2);
								if (Debugger.IsAttached)
								{
									Debugger.Break();
								}
							}
							if (flag5)
							{
								result = Unit.Enum123.const_1;
							}
							else
							{
								result = Unit.Enum123.const_3;
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100870", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = Unit.Enum123.const_5;
			}
			return result;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x001DE380 File Offset: 0x001DC580
		public bool method_44(Unit theUnit, ref Scenario theScen, ref bool LandmassCheckIsNeeded, float? ExplicitSensorDepth = null)
		{
			bool result;
			try
			{
				float num;
				if (ExplicitSensorDepth != null)
				{
					num = ExplicitSensorDepth.Value;
				}
				else
				{
					num = this.vmethod_14(false);
				}
				if (num <= 0f && theUnit.vmethod_14(false) <= 0f)
				{
					float num2 = theUnit.vmethod_14(false);
					bool flag2;
					try
					{
						bool? hintIsOperating = null;
						double value = this.vmethod_30(hintIsOperating);
						bool? hintIsOperating2 = null;
						double value2 = this.vmethod_28(hintIsOperating2);
						bool? hintIsOperating3 = null;
						double value3 = theUnit.vmethod_30(hintIsOperating3);
						bool? hintIsOperating4 = null;
						double value4 = theUnit.vmethod_28(hintIsOperating4);
						bool flag = Scenario.smethod_16(ref value, ref value2, ref num, ref value3, ref value4, ref num2, LandmassCheckIsNeeded, 0, false);
						theUnit.vmethod_29(hintIsOperating4, value4);
						theUnit.vmethod_31(hintIsOperating3, value3);
						this.vmethod_29(hintIsOperating2, value2);
						this.vmethod_31(hintIsOperating, value);
						flag2 = flag;
					}
					catch (OutOfMemoryException ex)
					{
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						GameGeneral.smethod_10();
						bool? hintIsOperating4 = null;
						double value4 = this.vmethod_30(hintIsOperating4);
						bool? hintIsOperating3 = null;
						double value3 = this.vmethod_28(hintIsOperating3);
						bool? hintIsOperating2 = null;
						double value2 = theUnit.vmethod_30(hintIsOperating2);
						bool? hintIsOperating = null;
						double value = theUnit.vmethod_28(hintIsOperating);
						bool flag3 = Scenario.smethod_16(ref value4, ref value3, ref num, ref value2, ref value, ref num2, LandmassCheckIsNeeded, 0, false);
						theUnit.vmethod_29(hintIsOperating, value);
						theUnit.vmethod_31(hintIsOperating2, value2);
						this.vmethod_29(hintIsOperating3, value3);
						this.vmethod_31(hintIsOperating4, value4);
						flag2 = flag3;
					}
					catch (Exception ex2)
					{
						ex2.Data.Add("Error at 101178", "");
						GameGeneral.smethod_25(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
					}
					result = flag2;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex3)
			{
				ex3.Data.Add("Error at 100871", "");
				GameGeneral.smethod_25(ref ex3);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x001DE5D4 File Offset: 0x001DC7D4
		public virtual void vmethod_42(ref Scenario scenario_0, double double_2, double double_3)
		{
			this.vmethod_29(null, double_2);
			this.vmethod_31(null, double_3);
			if (this.bool_0)
			{
				ActiveUnit activeUnit = (ActiveUnit)this;
				activeUnit.vmethod_85().double_0 = 0.0;
				activeUnit.vmethod_85().double_1 = 0.0;
				activeUnit.vmethod_85().double_2 = 0.0;
				activeUnit.vmethod_85().double_3 = 0.0;
				activeUnit.vmethod_85().double_4 = 0.0;
				activeUnit.vmethod_85().double_5 = 0.0;
				activeUnit.vmethod_85().double_6 = 0.0;
				activeUnit.vmethod_85().double_7 = 0.0;
				activeUnit.vmethod_85().double_9 = 0.0;
				activeUnit.vmethod_85().vmethod_2();
			}
			checked
			{
				if (this.bool_0 && this.bool_3)
				{
					Aircraft aircraft = (Aircraft)this;
					if (!Information.IsNothing(aircraft.method_167()))
					{
						WeaponRec[] weaponRec_ = aircraft.method_167().weaponRec_0;
						for (int i = 0; i < weaponRec_.Length; i++)
						{
							Weapon weapon = weaponRec_[i].method_12(aircraft.scenario_0);
							weapon.vmethod_29(null, aircraft.vmethod_28(null));
							weapon.vmethod_31(null, aircraft.vmethod_30(null));
							weapon.vmethod_15(false, aircraft.vmethod_14(false));
							weapon.vmethod_10(aircraft.vmethod_9());
							weapon.vmethod_41(aircraft.vmethod_40());
						}
					}
				}
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0000D709 File Offset: 0x0000B909
		public virtual bool vmethod_43()
		{
			return base.GetType().BaseType == typeof(Class350) || base.GetType() == typeof(Class350);
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x001DE788 File Offset: 0x001DC988
		public virtual void vmethod_44(float float_9, Scenario scenario_0)
		{
			if (string.IsNullOrEmpty(this.string_0))
			{
				this.vmethod_1();
			}
			if (scenario_0.SecondIsChangingOnThisPulse && this.bool_11)
			{
				if (!Misc.smethod_13(this.lazy_0.Value))
				{
					this.lazy_0.Value.Clear();
				}
				this.bool_11 = false;
			}
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x001DE7E4 File Offset: 0x001DC9E4
		public bool method_45(Geopoint_Struct[] geopoint_Struct_0, Scenario scenario_0, bool bool_12)
		{
			bool result;
			try
			{
				if (geopoint_Struct_0 == null)
				{
					result = false;
				}
				else if (geopoint_Struct_0.Length < 3)
				{
					result = false;
				}
				else
				{
					bool flag;
					if (bool_12 && (this.bool_0 || this.method_14()))
					{
						int hashCode = geopoint_Struct_0.GetHashCode();
						if (this.lazy_0.Value.ContainsKey(hashCode))
						{
							flag = this.lazy_0.Value[hashCode];
						}
						else
						{
							flag = GeoPoint.smethod_2(this.vmethod_30(null), this.vmethod_28(null), geopoint_Struct_0, true);
							if (!this.lazy_0.Value.ContainsKey(hashCode))
							{
								this.lazy_0.Value.TryAdd(hashCode, flag);
								this.bool_11 = true;
							}
						}
					}
					else
					{
						flag = GeoPoint.smethod_2(this.vmethod_30(null), this.vmethod_28(null), geopoint_Struct_0, true);
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10043563407600", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x001DE91C File Offset: 0x001DCB1C
		public virtual bool vmethod_45(List<GeoPoint> list_2, Scenario scenario_0, bool bool_12)
		{
			bool result;
			try
			{
				if (Information.IsNothing(list_2))
				{
					result = false;
				}
				else if (list_2.Count < 3)
				{
					result = false;
				}
				else
				{
					bool flag;
					if (bool_12 && (this.bool_0 || this.method_14()))
					{
						int hashCode = list_2.GetHashCode();
						if (this.lazy_0.Value.ContainsKey(hashCode))
						{
							flag = this.lazy_0.Value[hashCode];
						}
						else
						{
							flag = GeoPoint.smethod_3(this.vmethod_30(null), this.vmethod_28(null), list_2, true);
							if (!this.lazy_0.Value.ContainsKey(hashCode))
							{
								this.lazy_0.Value.TryAdd(hashCode, flag);
								this.bool_11 = true;
							}
						}
					}
					else
					{
						flag = GeoPoint.smethod_3(this.vmethod_30(null), this.vmethod_28(null), list_2, true);
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100873", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x001DEA5C File Offset: 0x001DCC5C
		public virtual bool vmethod_46(List<ReferencePoint> list_2, Scenario scenario_0, bool bool_12)
		{
			bool result;
			try
			{
				if (Information.IsNothing(list_2))
				{
					result = false;
				}
				else if (list_2.Count < 3)
				{
					result = false;
				}
				else
				{
					bool flag;
					if (bool_12 && (this.bool_0 || this.method_14()))
					{
						int hashCode = list_2.GetHashCode();
						if (this.lazy_0.Value.ContainsKey(hashCode))
						{
							try
							{
								flag = this.lazy_0.Value[hashCode];
								goto IL_11D;
							}
							catch (Exception ex)
							{
								flag = GeoPoint.smethod_4(this.vmethod_30(null), this.vmethod_28(null), list_2, true);
								this.lazy_0.Value.TryAdd(hashCode, flag);
								this.bool_11 = true;
								goto IL_11D;
							}
						}
						flag = GeoPoint.smethod_4(this.vmethod_30(null), this.vmethod_28(null), list_2, true);
						this.lazy_0.Value.TryAdd(hashCode, flag);
						this.bool_11 = true;
					}
					else
					{
						flag = GeoPoint.smethod_4(this.vmethod_30(null), this.vmethod_28(null), list_2, true);
					}
					IL_11D:
					result = flag;
				}
			}
			catch (Exception ex2)
			{
				ex2.Data.Add("Error at 100873", "");
				GameGeneral.smethod_25(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				Geopoint_Struct geopoint_Struct = new Geopoint_Struct(this.vmethod_28(null), this.vmethod_30(null));
				result = GeoPoint.smethod_4(geopoint_Struct.double_1, geopoint_Struct.double_0, list_2, true);
			}
			return result;
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x001DEC34 File Offset: 0x001DCE34
		public float method_46(Unit unit_0, bool bool_12)
		{
			float num = unit_0.float_0;
			float num2 = Math2.smethod_17(unit_0.vmethod_30(null), unit_0.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null));
			num2 = Math2.smethod_7(num2 - num);
			float result;
			if (bool_12 && num2 > 180f)
			{
				result = -(360f - num2);
			}
			else
			{
				result = num2;
			}
			return result;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x001DECB4 File Offset: 0x001DCEB4
		public float method_47(Unit unit_0)
		{
			float num = unit_0.float_0;
			float num2 = Math2.smethod_17(unit_0.vmethod_30(null), unit_0.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null));
			num2 = Math2.smethod_7(num2 - num);
			double num3 = (double)(unit_0.float_2 - this.float_2);
			double num4 = (double)Math2.smethod_15(unit_0.vmethod_30(null), unit_0.vmethod_28(null), this.vmethod_30(null), this.vmethod_28(null)) * 1852.0;
			double value = Math.Tan(num3 / num4) * 57.2957795130823;
			if (num2 > 180f)
			{
				num2 = 360f - num2;
			}
			return (float)((double)Math.Abs(num2) + Math.Abs(value));
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000041ED File Offset: 0x000023ED
		public virtual bool vmethod_47(double double_2, double double_3, ref int int_0, bool bool_12, bool bool_13, bool bool_14, ref bool bool_15, bool bool_16, ref bool bool_17, float? nullable_10, short? nullable_11, ref List<ActiveUnit> list_2, float float_9, bool bool_18, bool bool_19, ref string string_4, ref bool bool_20)
		{
			return true;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x001DEDB0 File Offset: 0x001DCFB0
		public float method_48(float float_9)
		{
			float result;
			if (this.vmethod_6())
			{
				result = (float)(Math2.smethod_2((double)this.vmethod_18()) * (double)(this.vmethod_40() / 3600f)) * float_9;
			}
			else
			{
				result = this.vmethod_40() / 3600f * float_9;
			}
			return result;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x001DEDF8 File Offset: 0x001DCFF8
		public virtual void vmethod_48(float float_9, bool bool_12)
		{
			if (this.vmethod_40() != 0f)
			{
				this.vmethod_33(this.vmethod_28(null));
				this.vmethod_35(this.vmethod_30(null));
				try
				{
					float num;
					if (this.bool_0)
					{
						num = ((ActiveUnit)this).vmethod_87().vmethod_47(float_9);
					}
					else
					{
						num = this.method_48(float_9);
					}
					double num2;
					double num3;
					Class411.smethod_1(this.vmethod_32(), this.vmethod_34(), ref num2, ref num3, (double)num, (double)this.vmethod_9());
					if (double.IsNaN(num3))
					{
						num3 = this.vmethod_34();
					}
					if (double.IsNaN(num2))
					{
						num2 = this.vmethod_32();
					}
					if (this.vmethod_43())
					{
						bool flag = false;
						bool flag2 = true;
						bool flag3 = true;
						double double_ = num3;
						double double_2 = num2;
						int num4 = 0;
						bool bool_13 = false;
						bool bool_14 = false;
						bool bool_15 = true;
						bool bool_16 = true;
						float? nullable_ = null;
						short? nullable_2 = null;
						float float_10 = 0f;
						bool bool_17 = false;
						bool bool_18 = true;
						string text = "";
						List<ActiveUnit> list;
						if (this.vmethod_47(double_, double_2, ref num4, bool_13, bool_14, bool_15, ref flag2, bool_16, ref flag, nullable_, nullable_2, ref list, float_10, bool_17, bool_18, ref text, ref flag3))
						{
							this.vmethod_31(null, num3);
							this.vmethod_29(null, num2);
							if (((ActiveUnit)this).scenario_0.MinuteIsChangingOnThisPulse)
							{
								((ActiveUnit)this).vmethod_85().nullable_1 = null;
							}
						}
						else if (!flag && !flag2)
						{
							double double_3 = this.vmethod_34();
							double double_4 = this.vmethod_32();
							num4 = 0;
							bool bool_19 = false;
							bool bool_20 = false;
							bool bool_21 = true;
							bool bool_22 = true;
							float? nullable_3 = null;
							short? nullable_4 = null;
							float float_11 = 0f;
							bool bool_23 = false;
							bool bool_24 = true;
							text = "";
							if (this.vmethod_47(double_3, double_4, ref num4, bool_19, bool_20, bool_21, ref flag2, bool_22, ref flag, nullable_3, nullable_4, ref list, float_11, bool_23, bool_24, ref text, ref flag3))
							{
								flag3 = true;
							}
							if (flag3)
							{
								this.vmethod_10(this.method_52(this.float_0, num, false));
								Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref num2, ref num3, (double)num, (double)this.vmethod_9());
								ActiveUnit activeUnit = (ActiveUnit)this;
								if (activeUnit.scenario_0.MinuteIsChangingOnThisPulse)
								{
									double double_5 = num3;
									double double_6 = num2;
									num4 = 0;
									bool bool_25 = false;
									bool bool_26 = false;
									bool bool_27 = true;
									bool flag4 = false;
									bool bool_28 = true;
									float? nullable_5 = null;
									short? nullable_6 = null;
									float float_12 = 0f;
									bool bool_29 = false;
									bool bool_30 = false;
									text = "";
									bool flag5 = false;
									double num5;
									double num6;
									if (!this.vmethod_47(double_5, double_6, ref num4, bool_25, bool_26, bool_27, ref flag4, bool_28, ref flag, nullable_5, nullable_6, ref list, float_12, bool_29, bool_30, ref text, ref flag5) && activeUnit.vmethod_85().method_10(num3, num2, ref num5, ref num6, false, false, true, 0f, ref list, false))
									{
										num3 = num5;
										num2 = num6;
										activeUnit.vmethod_85().vmethod_2();
									}
									activeUnit.vmethod_85().nullable_1 = null;
								}
							}
						}
						else
						{
							ActiveUnit activeUnit2 = (ActiveUnit)this;
							if (!activeUnit2.scenario_0.MinuteIsChangingOnThisPulse && !Information.IsNothing(activeUnit2.vmethod_85().nullable_1))
							{
								activeUnit2.vmethod_10(activeUnit2.vmethod_85().nullable_1.Value);
							}
							else
							{
								if (flag && activeUnit2.vmethod_85().method_44())
								{
									activeUnit2.vmethod_85().method_18();
								}
								double double_7;
								double double_8;
								if (activeUnit2.vmethod_85().method_10(num3, num2, ref double_7, ref double_8, false, false, true, 0f, ref list, false))
								{
									activeUnit2.vmethod_85().nullable_1 = new float?(Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), double_7, double_8));
									activeUnit2.vmethod_10(activeUnit2.vmethod_85().nullable_1.Value);
									activeUnit2.vmethod_85().vmethod_2();
								}
							}
							this.vmethod_31(null, num3);
							this.vmethod_29(null, num2);
						}
					}
					this.vmethod_31(null, num3);
					this.vmethod_29(null, num2);
					if (double.IsNaN(this.vmethod_30(null)))
					{
						this.vmethod_31(null, this.vmethod_34());
					}
					if (double.IsNaN(this.vmethod_28(null)))
					{
						this.vmethod_29(null, this.vmethod_32());
					}
					if (!bool_12)
					{
						this.method_49(float_9);
					}
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100875", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x001DF268 File Offset: 0x001DD468
		protected void method_49(float float_9)
		{
			if (this.vmethod_32() != this.vmethod_28(null) || this.vmethod_34() != this.vmethod_30(null))
			{
				this.nullable_9 = null;
				this.nullable_7 = null;
			}
			if (this.method_11(float_9) != this.vmethod_28(null) || this.method_12(float_9) != this.vmethod_30(null))
			{
				this.nullable_8 = null;
				this.nullable_3 = null;
				this.nullable_4 = null;
			}
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x001DF310 File Offset: 0x001DD510
		public void method_50()
		{
			if (this.vmethod_32() != this.vmethod_28(null) || this.vmethod_34() != this.vmethod_30(null))
			{
				this.method_51();
			}
			this.vmethod_33(this.vmethod_28(null));
			this.vmethod_35(this.vmethod_30(null));
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0000D736 File Offset: 0x0000B936
		public void method_51()
		{
			this.nullable_9 = null;
			this.nullable_7 = null;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x001DF37C File Offset: 0x001DD57C
		public float method_52(float float_9, float float_10, bool bool_12)
		{
			float result;
			try
			{
				int num = 3;
				float num2;
				for (;;)
				{
					num2 = Math2.smethod_7(float_9 + (float)num);
					double num3;
					double num4;
					Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref num3, ref num4, (double)float_10, (double)num2);
					double double_ = num4;
					double double_2 = num3;
					int num5 = 0;
					bool bool_13 = false;
					bool bool_14 = false;
					bool flag = false;
					bool bool_15 = true;
					bool flag2 = true;
					float? nullable_ = null;
					short? nullable_2 = null;
					float float_11 = 0f;
					bool bool_16 = false;
					bool bool_17 = false;
					string text = "";
					bool flag3 = false;
					List<ActiveUnit> list;
					if (this.vmethod_47(double_, double_2, ref num5, bool_12, bool_13, bool_14, ref flag, bool_15, ref flag2, nullable_, nullable_2, ref list, float_11, bool_16, bool_17, ref text, ref flag3))
					{
						break;
					}
					num2 = Math2.smethod_7(float_9 - (float)num);
					Class411.smethod_1(this.vmethod_28(null), this.vmethod_30(null), ref num3, ref num4, (double)float_10, (double)num2);
					double double_3 = num4;
					double double_4 = num3;
					num5 = 0;
					bool bool_18 = false;
					bool bool_19 = false;
					flag3 = true;
					bool bool_20 = true;
					flag2 = true;
					float? nullable_3 = null;
					short? nullable_4 = null;
					float float_12 = 0f;
					bool bool_21 = false;
					bool bool_22 = false;
					text = "";
					flag = false;
					if (this.vmethod_47(double_3, double_4, ref num5, bool_12, bool_18, bool_19, ref flag3, bool_20, ref flag2, nullable_3, nullable_4, ref list, float_12, bool_21, bool_22, ref text, ref flag))
					{
						goto IL_124;
					}
					num += 3;
					if (num > 177)
					{
						goto IL_128;
					}
				}
				return num2;
				IL_124:
				return num2;
				IL_128:
				result = float_9;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100876", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = float_9;
			}
			return result;
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x001DF50C File Offset: 0x001DD70C
		public float method_53(float float_9, float float_10)
		{
			float result;
			if (float_9 <= 0f)
			{
				result = float.MaxValue;
			}
			else
			{
				result = (float)Math.Round((double)(float_10 / (float_9 / 3600f)), 2);
			}
			return result;
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x001DF53C File Offset: 0x001DD73C
		public float method_54(Unit unit_0)
		{
			float num = this.method_36(unit_0);
			float num2 = this.method_39(unit_0, this.vmethod_40(), this.vmethod_9());
			return num / num2 * 3600f;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x001DF570 File Offset: 0x001DD770
		public string method_55(Unit unit_0)
		{
			float num = Math2.smethod_17(this.vmethod_30(null), this.vmethod_28(null), unit_0.vmethod_30(null), unit_0.vmethod_28(null));
			string result;
			if (Math2.smethod_7(this.vmethod_9() - num) > 180f)
			{
				result = "Starboard";
			}
			else
			{
				result = "Port";
			}
			return result;
		}

		// Token: 0x0400170E RID: 5902
		private float float_0;

		// Token: 0x0400170F RID: 5903
		private float float_1;

		// Token: 0x04001710 RID: 5904
		private float float_2;

		// Token: 0x04001711 RID: 5905
		protected float float_3;

		// Token: 0x04001712 RID: 5906
		private float float_4;

		// Token: 0x04001713 RID: 5907
		protected float float_5;

		// Token: 0x04001714 RID: 5908
		private float float_6;

		// Token: 0x04001715 RID: 5909
		protected float float_7;

		// Token: 0x04001716 RID: 5910
		protected double double_0;

		// Token: 0x04001717 RID: 5911
		protected double double_1;

		// Token: 0x04001718 RID: 5912
		private double? nullable_0;

		// Token: 0x04001719 RID: 5913
		private double? nullable_1;

		// Token: 0x0400171A RID: 5914
		private float? nullable_2;

		// Token: 0x0400171B RID: 5915
		private double? nullable_3;

		// Token: 0x0400171C RID: 5916
		private double? nullable_4;

		// Token: 0x0400171D RID: 5917
		private double? nullable_5;

		// Token: 0x0400171E RID: 5918
		private double? nullable_6;

		// Token: 0x0400171F RID: 5919
		public List<string> list_0;

		// Token: 0x04001720 RID: 5920
		public string string_2;

		// Token: 0x04001721 RID: 5921
		private List<RangeSymbol> list_1;

		// Token: 0x04001722 RID: 5922
		protected Side side_0;

		// Token: 0x04001723 RID: 5923
		public string string_3;

		// Token: 0x04001724 RID: 5924
		public Lazy<ConcurrentDictionary<int, bool>> lazy_0;

		// Token: 0x04001725 RID: 5925
		public Unit.Enum122 enum122_0;

		// Token: 0x04001726 RID: 5926
		internal float float_8;

		// Token: 0x04001727 RID: 5927
		private int? nullable_7;

		// Token: 0x04001728 RID: 5928
		private int? nullable_8;

		// Token: 0x04001729 RID: 5929
		private float? nullable_9;

		// Token: 0x0400172A RID: 5930
		private bool bool_11;

		// Token: 0x02000370 RID: 880
		internal enum Enum122 : short
		{
			// Token: 0x0400172C RID: 5932
			const_0,
			// Token: 0x0400172D RID: 5933
			const_1,
			// Token: 0x0400172E RID: 5934
			const_2
		}

		// Token: 0x02000371 RID: 881
		internal enum Enum123
		{
			// Token: 0x04001730 RID: 5936
			const_0,
			// Token: 0x04001731 RID: 5937
			const_1,
			// Token: 0x04001732 RID: 5938
			const_2,
			// Token: 0x04001733 RID: 5939
			const_3,
			// Token: 0x04001734 RID: 5940
			const_4,
			// Token: 0x04001735 RID: 5941
			const_5 = 9999
		}
	}
}
