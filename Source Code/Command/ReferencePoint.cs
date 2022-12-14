using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns13;
using ns14;

namespace Command_Core
{
	// Token: 0x0200025F RID: 607
	public sealed class ReferencePoint : GeoPoint
	{
		// Token: 0x06001290 RID: 4752 RVA: 0x00168F00 File Offset: 0x00167100
		public string method_17(ref HashSet<string> ObjectsAlreadySerialized = null)
		{
			string result;
			try
			{
				if (this.stringBuilder_1 == null)
				{
					this.stringBuilder_1 = new StringBuilder(500);
				}
				else
				{
					this.stringBuilder_1.Clear();
				}
				this.stringBuilder_1.Append("<RPoint>");
				this.stringBuilder_1.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(ObjectsAlreadySerialized))
				{
					if (ObjectsAlreadySerialized.Contains(this.string_0))
					{
						this.stringBuilder_1.Append("</RPoint>");
						return this.stringBuilder_1.ToString();
					}
					ObjectsAlreadySerialized.Add(this.string_0);
				}
				this.stringBuilder_1.Append("<Lon>").Append(XmlConvert.ToString(base.imethod_0())).Append("</Lon>");
				this.stringBuilder_1.Append("<Lat>").Append(XmlConvert.ToString(base.imethod_2())).Append("</Lat>");
				if (base.imethod_4() != 0f)
				{
					this.stringBuilder_1.Append("<Alt>").Append(XmlConvert.ToString(base.imethod_4())).Append("</Alt>");
				}
				this.stringBuilder_1.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
				if (this.bool_11)
				{
					this.stringBuilder_1.Append("<IH>True</IH>");
				}
				if (!Information.IsNothing(this.unit_0))
				{
					this.stringBuilder_1.Append("<IRT>").Append(this.unit_0.string_0).Append("</IRT>");
					this.stringBuilder_1.Append("<RB>").Append(XmlConvert.ToString(this.float_1)).Append("</RB>");
					this.stringBuilder_1.Append("<RD>").Append(XmlConvert.ToString(this.float_2)).Append("</RD>");
				}
				if (this.orientationType_0 != ReferencePoint.OrientationType.Fixed)
				{
					StringBuilder stringBuilder = this.stringBuilder_1.Append("<BT>");
					byte b = (byte)this.orientationType_0;
					stringBuilder.Append(b.ToString()).Append("</BT>");
				}
				if (this.bool_12)
				{
					this.stringBuilder_1.Append("<IsLocked>True</IsLocked>");
				}
				this.stringBuilder_1.Append("</RPoint>");
				result = this.stringBuilder_1.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100584", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x001691D8 File Offset: 0x001673D8
		public static ReferencePoint smethod_13(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			ReferencePoint result;
			try
			{
				ReferencePoint referencePoint = new ReferencePoint();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num > 1836990821U)
						{
							if (num <= 2131034325U)
							{
								if (num <= 2030368611U)
								{
									if (num != 2022647575U)
									{
										if (num != 2030368611U)
										{
											continue;
										}
										if (Operators.CompareString(name, "RD", false) == 0)
										{
											goto IL_239;
										}
										continue;
									}
									else if (Operators.CompareString(name, "Altitude", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2108682236U)
								{
									if (num != 2131034325U)
									{
										continue;
									}
									if (Operators.CompareString(name, "RB", false) != 0)
									{
										continue;
									}
									goto IL_322;
								}
								else if (Operators.CompareString(name, "Alt", false) != 0)
								{
									continue;
								}
								referencePoint.imethod_5(XmlConvert.ToSingle(xmlNode.InnerText));
								continue;
							}
							if (num <= 2564648390U)
							{
								if (num != 2310993645U)
								{
									if (num != 2564648390U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Lon", false) == 0)
									{
										goto IL_2FA;
									}
									continue;
								}
								else if (Operators.CompareString(name, "RelativeBearing", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3001749054U)
							{
								if (num != 3370226018U)
								{
									if (num != 3499333060U)
									{
										continue;
									}
									if (Operators.CompareString(name, "IsSelected", false) == 0)
									{
										goto IL_370;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "IRT", false) == 0)
									{
										goto IL_392;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Lat", false) == 0)
								{
									goto IL_3AF;
								}
								continue;
							}
							IL_322:
							referencePoint.float_1 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
							continue;
						}
						if (num <= 1368635491U)
						{
							if (num <= 685599235U)
							{
								if (num != 266367750U)
								{
									if (num != 685599235U)
									{
										continue;
									}
									if (Operators.CompareString(name, "BT", false) == 0)
									{
										referencePoint.orientationType_0 = (ReferencePoint.OrientationType)Conversions.ToByte(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										referencePoint.Name = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num != 1277788090U)
							{
								if (num != 1368635491U)
								{
									continue;
								}
								if (Operators.CompareString(name, "IsLocked", false) == 0)
								{
									referencePoint.bool_12 = true;
									continue;
								}
								continue;
							}
							else if (Operators.CompareString(name, "RelativeDistance", false) != 0)
							{
								continue;
							}
						}
						else if (num <= 1570547740U)
						{
							if (num != 1458105184U)
							{
								if (num != 1570547740U)
								{
									continue;
								}
								if (Operators.CompareString(name, "IsRelativeTo", false) != 0)
								{
									continue;
								}
								goto IL_392;
							}
							else
							{
								if (Operators.CompareString(name, "ID", false) != 0)
								{
									continue;
								}
								if (!Information.IsNothing(dictionary_0) && dictionary_0.ContainsKey(xmlNode.InnerText))
								{
									return (ReferencePoint)dictionary_0[xmlNode.InnerText];
								}
								referencePoint.vmethod_0(xmlNode.InnerText);
								if (!Information.IsNothing(dictionary_0))
								{
									dictionary_0.Add(referencePoint.string_0, referencePoint);
									continue;
								}
								continue;
							}
						}
						else if (num != 1659436612U)
						{
							if (num != 1729717486U)
							{
								if (num != 1836990821U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Latitude", false) != 0)
								{
									continue;
								}
								goto IL_3AF;
							}
							else
							{
								if (Operators.CompareString(name, "Longitude", false) != 0)
								{
									continue;
								}
								goto IL_2FA;
							}
						}
						else
						{
							if (Operators.CompareString(name, "IH", false) != 0)
							{
								continue;
							}
							goto IL_370;
						}
						IL_239:
						referencePoint.float_2 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
						continue;
						IL_2FA:
						referencePoint.imethod_1(XmlConvert.ToDouble(xmlNode.InnerText));
						continue;
						IL_370:
						referencePoint.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
						continue;
						IL_392:
						referencePoint.string_2 = xmlNode.InnerText;
						continue;
						IL_3AF:
						referencePoint.imethod_3(XmlConvert.ToDouble(xmlNode.InnerText));
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
				result = referencePoint;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100585", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new ReferencePoint();
			}
			return result;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000A9B2 File Offset: 0x00008BB2
		public void method_18(Dictionary<string, Class310> dictionary_0)
		{
			if (Operators.CompareString(this.string_2, "", false) != 0 && dictionary_0.ContainsKey(this.string_2))
			{
				this.unit_0 = (Unit)dictionary_0[this.string_2];
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0000A9EC File Offset: 0x00008BEC
		public bool method_19()
		{
			return this.bool_11;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		public void method_20(bool bool_13)
		{
			this.bool_11 = bool_13;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00169654 File Offset: 0x00167854
		public void method_21()
		{
			if (!Information.IsNothing(this.unit_0))
			{
				try
				{
					ReferencePoint.OrientationType orientationType = this.orientationType_0;
					if (orientationType != ReferencePoint.OrientationType.Fixed)
					{
						if (orientationType == ReferencePoint.OrientationType.Rotating)
						{
							this.float_1 = Class437.smethod_3(this.unit_0.vmethod_9(), Math2.smethod_17(this.unit_0.vmethod_30(null), this.unit_0.vmethod_28(null), base.imethod_2(), base.imethod_0()));
						}
					}
					else
					{
						this.float_1 = Math2.smethod_17(this.unit_0.vmethod_30(null), this.unit_0.vmethod_28(null), base.imethod_2(), base.imethod_0());
					}
					this.float_2 = Math2.smethod_15(this.unit_0.vmethod_30(null), this.unit_0.vmethod_28(null), base.imethod_2(), base.imethod_0());
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100586", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0000A9FD File Offset: 0x00008BFD
		public ReferencePoint(double double_2, double double_3)
		{
			base.imethod_1(double_2);
			base.imethod_3(double_3);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0000AA13 File Offset: 0x00008C13
		public ReferencePoint()
		{
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0016979C File Offset: 0x0016799C
		public ReferencePoint method_22(ref ReferencePoint referencePoint_0)
		{
			return new ReferencePoint(referencePoint_0.Name, referencePoint_0.string_0, referencePoint_0.imethod_2(), referencePoint_0.imethod_0(), referencePoint_0.imethod_4(), referencePoint_0.bool_11, referencePoint_0.string_2, referencePoint_0.float_1, referencePoint_0.float_2, referencePoint_0.orientationType_0, referencePoint_0.bool_12);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x001697FC File Offset: 0x001679FC
		public ReferencePoint(string string_3, string string_4, double double_2, double double_3, float float_3, bool bool_13, string string_5, float float_4, float float_5, ReferencePoint.OrientationType orientationType_1, bool bool_14)
		{
			this.Name = string_3;
			this.vmethod_0(string_4);
			base.imethod_3(double_2);
			base.imethod_1(double_3);
			base.imethod_5(float_3);
			this.bool_11 = bool_13;
			this.string_2 = string_5;
			this.float_1 = float_4;
			this.float_2 = float_5;
			this.orientationType_0 = orientationType_1;
			this.bool_12 = bool_14;
		}

		// Token: 0x04000D1A RID: 3354
		private bool bool_11;

		// Token: 0x04000D1B RID: 3355
		public Unit unit_0;

		// Token: 0x04000D1C RID: 3356
		private string string_2;

		// Token: 0x04000D1D RID: 3357
		public float float_1;

		// Token: 0x04000D1E RID: 3358
		public float float_2;

		// Token: 0x04000D1F RID: 3359
		public ReferencePoint.OrientationType orientationType_0;

		// Token: 0x04000D20 RID: 3360
		public bool bool_12;

		// Token: 0x04000D21 RID: 3361
		private StringBuilder stringBuilder_1;

		// Token: 0x02000260 RID: 608
		public enum OrientationType : byte
		{
			// Token: 0x04000D23 RID: 3363
			Fixed,
			// Token: 0x04000D24 RID: 3364
			Rotating
		}
	}
}
