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
using ns11;
using ns12;
using ns14;
using ns19;
using ns20;

namespace Command_Core
{
	// Token: 0x0200025E RID: 606
	public class GeoPoint : Class310, Interface4
	{
		// Token: 0x06001271 RID: 4721 RVA: 0x00167C34 File Offset: 0x00165E34
		public string method_8(HashSet<string> hashSet_0)
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
				this.stringBuilder_0.Append("<GPoint>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (hashSet_0 != null)
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</GPoint>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
				this.stringBuilder_0.Append("<Lon>").Append(XmlConvert.ToString(this.double_0)).Append("</Lon>");
				this.stringBuilder_0.Append("<Lat>").Append(XmlConvert.ToString(this.double_1)).Append("</Lat>");
				this.stringBuilder_0.Append("<Alt>").Append(XmlConvert.ToString(this.float_0)).Append("</Alt>");
				this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
				this.stringBuilder_0.Append("</GPoint>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100572", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00167DF8 File Offset: 0x00165FF8
		public static GeoPoint smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			GeoPoint geoPoint = new GeoPoint();
			GeoPoint result;
			try
			{
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num <= 1836990821U)
						{
							if (num <= 1458105184U)
							{
								if (num != 266367750U)
								{
									if (num != 1458105184U)
									{
										continue;
									}
									if (Operators.CompareString(name, "ID", false) != 0)
									{
										continue;
									}
									if (!dictionary_0.ContainsKey(xmlNode.InnerText))
									{
										geoPoint.vmethod_0(xmlNode.InnerText);
										dictionary_0.Add(geoPoint.string_0, geoPoint);
										continue;
									}
									return (GeoPoint)dictionary_0[xmlNode.InnerText];
								}
								else
								{
									if (Operators.CompareString(name, "Name", false) == 0)
									{
										geoPoint.Name = xmlNode.InnerText;
										continue;
									}
									continue;
								}
							}
							else if (num != 1729717486U)
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
								if (Operators.CompareString(name, "Longitude", false) != 0)
								{
									continue;
								}
								goto IL_1C8;
							}
						}
						else
						{
							if (num <= 2108682236U)
							{
								if (num != 2022647575U)
								{
									if (num != 2108682236U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Alt", false) != 0)
									{
										continue;
									}
								}
								else if (Operators.CompareString(name, "Altitude", false) != 0)
								{
									continue;
								}
								geoPoint.float_0 = XmlConvert.ToSingle(xmlNode.InnerText.Replace(",", "."));
								continue;
							}
							if (num != 2564648390U)
							{
								if (num != 3001749054U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Lat", false) != 0)
								{
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "Lon", false) == 0)
								{
									goto IL_1C8;
								}
								continue;
							}
						}
						geoPoint.double_1 = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
						continue;
						IL_1C8:
						geoPoint.double_0 = XmlConvert.ToDouble(xmlNode.InnerText.Replace(",", "."));
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
				result = geoPoint;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100573", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		public float method_9()
		{
			return this.imethod_4() - (float)Terrain.smethod_7(this.imethod_2(), this.imethod_0(), false);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0000A8DC File Offset: 0x00008ADC
		public GeoPoint()
		{
			this.Name = "";
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000A8EF File Offset: 0x00008AEF
		public GeoPoint(double double_2, double double_3)
		{
			this.double_0 = double_2;
			this.double_1 = double_3;
			this.Name = "";
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0000A910 File Offset: 0x00008B10
		public GeoPoint(double double_2, double double_3, float float_1)
		{
			this.double_0 = double_2;
			this.double_1 = double_3;
			this.float_0 = float_1;
			this.Name = "";
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0000A938 File Offset: 0x00008B38
		public bool method_10()
		{
			return Terrain.smethod_7(this.double_1, this.double_0, false) >= 0;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000A952 File Offset: 0x00008B52
		public bool method_11()
		{
			return Terrain.smethod_7(this.double_1, this.double_0, false) < 0;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0000A969 File Offset: 0x00008B69
		public float method_12(double double_2, double double_3)
		{
			return Math2.smethod_15(this.double_1, this.double_0, double_3, double_2);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00168098 File Offset: 0x00166298
		public float method_13(Geopoint_Struct geopoint_Struct_0)
		{
			float num = Math2.smethod_15(this.imethod_2(), this.imethod_0(), geopoint_Struct_0.double_1, geopoint_Struct_0.double_0);
			float num2 = (float)((double)Math.Abs(this.imethod_4() - geopoint_Struct_0.float_0) / 1852.0);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x001680F0 File Offset: 0x001662F0
		public float method_14(GeoPoint geoPoint_0)
		{
			float num = Math2.smethod_15(this.imethod_2(), this.imethod_0(), geoPoint_0.imethod_2(), geoPoint_0.imethod_0());
			float num2 = (float)((double)Math.Abs(this.imethod_4() - geoPoint_0.imethod_4()) / 1852.0);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00168148 File Offset: 0x00166348
		public static double smethod_1(double double_2, double double_3, double double_4, double double_5)
		{
			double result;
			try
			{
				Struct65 struct65_ = default(Struct65);
				Struct65 struct65_2 = default(Struct65);
				Struct65 struct65_3 = default(Struct65);
				Struct65 struct65_4 = default(Struct65);
				struct65_.method_1(double_3);
				struct65_2.method_1(double_2);
				struct65_3.method_1(double_5);
				struct65_4.method_1(double_4);
				result = Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4).method_0();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10032453245234", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = 0.0;
			}
			return result;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00168200 File Offset: 0x00166400
		public double method_15(double double_2, double double_3)
		{
			try
			{
				Struct65 struct65_ = default(Struct65);
				Struct65 struct65_2 = default(Struct65);
				Struct65 struct65_3 = default(Struct65);
				Struct65 struct65_4 = default(Struct65);
				struct65_.method_1(this.imethod_2());
				struct65_2.method_1(this.imethod_0());
				struct65_3.method_1(double_3);
				struct65_4.method_1(double_2);
				return Class1874.smethod_1(struct65_, struct65_2, struct65_3, struct65_4).method_0();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100574", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return 0.0;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0000A97E File Offset: 0x00008B7E
		public ReferencePoint method_16()
		{
			return new ReferencePoint(this.imethod_0(), this.imethod_2());
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x001682C0 File Offset: 0x001664C0
		public static bool smethod_2(double theLat, double theLon, Geopoint_Struct[] theArea, bool HaveToCheckAntimeridian = true)
		{
			bool result;
			try
			{
				if (Information.IsNothing(theArea))
				{
					result = false;
				}
				else if (theArea.Length < 3)
				{
					result = false;
				}
				else if (HaveToCheckAntimeridian)
				{
					if (Math2.smethod_26(theArea))
					{
						double num = theLon + 180.0;
						Geopoint_Struct geopoint_Struct = new Geopoint_Struct(Math2.smethod_11(ref num), theLat);
						Geopoint_Struct[] array = new Geopoint_Struct[theArea.Length - 1 + 1];
						int num2 = theArea.Length - 1;
						for (int i = 0; i <= num2; i++)
						{
							Geopoint_Struct[] array2 = array;
							int num3 = i;
							num = theArea[i].double_0 + 180.0;
							array2[num3] = new Geopoint_Struct(Math2.smethod_11(ref num), theArea[i].double_1);
						}
						result = GeoPoint.smethod_6(geopoint_Struct.double_1, geopoint_Struct.double_0, array);
					}
					else
					{
						result = GeoPoint.smethod_6(theLat, theLon, theArea);
					}
				}
				else
				{
					result = GeoPoint.smethod_6(theLat, theLon, theArea);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 10057342098690566", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x001683E8 File Offset: 0x001665E8
		public static bool smethod_3(double theLat, double theLon, List<GeoPoint> theArea, bool HaveToCheckAntimeridian = true)
		{
			bool result;
			try
			{
				if (Information.IsNothing(theArea))
				{
					result = false;
				}
				else if (theArea.Count < 3)
				{
					result = false;
				}
				else if (HaveToCheckAntimeridian)
				{
					if (Math2.smethod_27(theArea))
					{
						double num = theLon + 180.0;
						Geopoint_Struct geopoint_Struct = new Geopoint_Struct(Math2.smethod_11(ref num), theLat);
						Geopoint_Struct[] array = new Geopoint_Struct[theArea.Count - 1 + 1];
						int num2 = theArea.Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							Geopoint_Struct[] array2 = array;
							int num3 = i;
							num = theArea[i].imethod_0() + 180.0;
							array2[num3] = new Geopoint_Struct(Math2.smethod_11(ref num), theArea[i].imethod_2());
						}
						result = GeoPoint.smethod_6(geopoint_Struct.double_1, geopoint_Struct.double_0, array);
					}
					else
					{
						result = GeoPoint.smethod_7(theLat, theLon, theArea);
					}
				}
				else
				{
					result = GeoPoint.smethod_7(theLat, theLon, theArea);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100576", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0016851C File Offset: 0x0016671C
		public static bool smethod_4(double PointLat, double PointLon, List<ReferencePoint> theArea, bool HaveToCheckAntimeridian = true)
		{
			bool result;
			try
			{
				if (Information.IsNothing(theArea))
				{
					result = false;
				}
				else if (theArea.Count < 3)
				{
					result = false;
				}
				else if (HaveToCheckAntimeridian)
				{
					if (Math2.smethod_28(ref theArea))
					{
						double num = PointLon + 180.0;
						Geopoint_Struct geopoint_Struct = new Geopoint_Struct(Math2.smethod_11(ref num), PointLat);
						Geopoint_Struct[] array = new Geopoint_Struct[theArea.Count - 1 + 1];
						int num2 = theArea.Count - 1;
						for (int i = 0; i <= num2; i++)
						{
							Geopoint_Struct[] array2 = array;
							int num3 = i;
							num = theArea[i].imethod_0() + 180.0;
							array2[num3] = new Geopoint_Struct(Math2.smethod_11(ref num), theArea[i].imethod_2());
						}
						result = GeoPoint.smethod_6(geopoint_Struct.double_1, geopoint_Struct.double_0, array);
					}
					else
					{
						result = GeoPoint.smethod_5(PointLat, PointLon, theArea);
					}
				}
				else
				{
					result = GeoPoint.smethod_5(PointLat, PointLon, theArea);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100577", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0016864C File Offset: 0x0016684C
		public static bool smethod_5(double double_2, double double_3, List<ReferencePoint> list_0)
		{
			bool result;
			try
			{
				double num = -90.0;
				double num2 = 90.0;
				double num3 = 180.0;
				double num4 = -180.0;
				int count = list_0.Count;
				int num5 = count - 1;
				for (int i = 0; i <= num5; i++)
				{
					ReferencePoint referencePoint = list_0[i];
					double num6 = referencePoint.imethod_2();
					double num7 = referencePoint.imethod_0();
					if (num6 > num)
					{
						num = num6;
					}
					if (num6 < num2)
					{
						num2 = num6;
					}
					if (num7 > num4)
					{
						num4 = num7;
					}
					if (num7 < num3)
					{
						num3 = num7;
					}
				}
				if (double_2 > num)
				{
					result = false;
				}
				else if (double_2 < num2)
				{
					result = false;
				}
				else if (double_3 > num4)
				{
					result = false;
				}
				else if (double_3 < num3)
				{
					result = false;
				}
				else
				{
					int num8 = count;
					GeoPoint geoPoint = list_0[num8 - 1];
					int num9 = 0;
					int num10 = num8 - 1;
					for (int j = 0; j <= num10; j++)
					{
						ReferencePoint referencePoint2 = list_0[j];
						GeoPoint geoPoint2;
						if (referencePoint2 != geoPoint)
						{
							geoPoint2 = list_0[j + 1];
						}
						else
						{
							geoPoint2 = list_0[0];
						}
						double num11 = referencePoint2.imethod_2();
						double double_4 = referencePoint2.imethod_0();
						double num12 = geoPoint2.imethod_2();
						double double_5 = geoPoint2.imethod_0();
						if (num11 <= double_2)
						{
							if (num12 > double_2 && GeoPoint.smethod_9(double_4, num11, double_5, num12, double_3, double_2) > 0)
							{
								num9++;
							}
						}
						else if (num12 <= double_2 && GeoPoint.smethod_9(double_4, num11, double_5, num12, double_3, double_2) < 0)
						{
							num9--;
						}
					}
					if (num9 != 0)
					{
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
				ex.Data.Add("Error at 100578", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00168820 File Offset: 0x00166A20
		public static bool smethod_6(double double_2, double double_3, Geopoint_Struct[] geopoint_Struct_0)
		{
			bool result;
			try
			{
				int num = geopoint_Struct_0.Length;
				int num2 = num - 1;
				double num5;
				double num6;
				double num7;
				double num8;
				for (int i = 0; i <= num2; i++)
				{
					Geopoint_Struct geopoint_Struct = geopoint_Struct_0[i];
					double num3 = geopoint_Struct.double_1;
					double num4 = geopoint_Struct.double_0;
					if (num3 > num5)
					{
						num5 = num3;
					}
					if (num3 < num6)
					{
						num6 = num3;
					}
					if (num4 > num7)
					{
						num7 = num4;
					}
					if (num4 < num8)
					{
						num8 = num4;
					}
				}
				if (double_2 > num5)
				{
					result = false;
				}
				else if (double_2 < num6)
				{
					result = false;
				}
				else if (double_3 > num7)
				{
					result = false;
				}
				else if (double_3 < num8)
				{
					result = false;
				}
				else
				{
					int num9 = 0;
					int num10 = num - 1;
					for (int j = 0; j <= num10; j++)
					{
						Geopoint_Struct geopoint_Struct2 = geopoint_Struct_0[j];
						Geopoint_Struct geopoint_Struct3;
						if (j != num - 1)
						{
							geopoint_Struct3 = geopoint_Struct_0[j + 1];
						}
						else
						{
							geopoint_Struct3 = geopoint_Struct_0[0];
						}
						double num11 = geopoint_Struct2.double_1;
						double double_4 = geopoint_Struct2.double_0;
						double num12 = geopoint_Struct3.double_1;
						double double_5 = geopoint_Struct3.double_0;
						if (num11 <= double_2)
						{
							if (num12 > double_2 && GeoPoint.smethod_9(double_4, num11, double_5, num12, double_3, double_2) > 0)
							{
								num9++;
							}
						}
						else if (num12 <= double_2 && GeoPoint.smethod_9(double_4, num11, double_5, num12, double_3, double_2) < 0)
						{
							num9--;
						}
					}
					if (num9 != 0)
					{
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
				ex.Data.Add("Error at 100579324598421345103249502349591", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x001689BC File Offset: 0x00166BBC
		public static bool smethod_7(double double_2, double double_3, List<GeoPoint> list_0)
		{
			bool result;
			try
			{
				int count = list_0.Count;
				int num = count - 1;
				double num4;
				double num5;
				double num6;
				double num7;
				for (int i = 0; i <= num; i++)
				{
					GeoPoint geoPoint = list_0[i];
					double num2 = geoPoint.imethod_2();
					double num3 = geoPoint.imethod_0();
					if (num2 > num4)
					{
						num4 = num2;
					}
					if (num2 < num5)
					{
						num5 = num2;
					}
					if (num3 > num6)
					{
						num6 = num3;
					}
					if (num3 < num7)
					{
						num7 = num3;
					}
				}
				if (double_2 > num4)
				{
					result = false;
				}
				else if (double_2 < num5)
				{
					result = false;
				}
				else if (double_3 > num6)
				{
					result = false;
				}
				else if (double_3 < num7)
				{
					result = false;
				}
				else
				{
					GeoPoint geoPoint2 = list_0[count - 1];
					int num8 = 0;
					int num9 = count - 1;
					for (int j = 0; j <= num9; j++)
					{
						GeoPoint geoPoint3 = list_0[j];
						GeoPoint geoPoint4;
						if (geoPoint3 != geoPoint2)
						{
							geoPoint4 = list_0[j + 1];
						}
						else
						{
							geoPoint4 = list_0[0];
						}
						double num10 = geoPoint3.imethod_2();
						double double_4 = geoPoint3.imethod_0();
						double num11 = geoPoint4.imethod_2();
						double double_5 = geoPoint4.imethod_0();
						if (num10 <= double_2)
						{
							if (num11 > double_2 && GeoPoint.smethod_9(double_4, num10, double_5, num11, double_3, double_2) > 0)
							{
								num8++;
							}
						}
						else if (num11 <= double_2 && GeoPoint.smethod_9(double_4, num10, double_5, num11, double_3, double_2) < 0)
						{
							num8--;
						}
					}
					if (num8 != 0)
					{
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
				ex.Data.Add("Error at 100579", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00168B64 File Offset: 0x00166D64
		public static bool smethod_8(double double_2, double double_3, ref double[] double_4, ref double[] double_5)
		{
			bool result;
			try
			{
				int num = double_4.Length;
				int num2 = 0;
				int num3 = num - 1;
				for (int i = 0; i <= num3; i++)
				{
					double num4 = double_5[i];
					double double_6 = double_4[i];
					double num5;
					double double_7;
					if (i != num - 1)
					{
						num5 = double_5[i + 1];
						double_7 = double_4[i + 1];
					}
					else
					{
						num5 = double_5[0];
						double_7 = double_4[0];
					}
					if (num4 <= double_2)
					{
						if (num5 > double_2 && GeoPoint.smethod_9(double_6, num4, double_7, num5, double_3, double_2) > 0)
						{
							num2++;
						}
					}
					else if (num5 <= double_2 && GeoPoint.smethod_9(double_6, num4, double_7, num5, double_3, double_2) < 0)
					{
						num2--;
					}
				}
				if (num2 != 0)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100580", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00168C64 File Offset: 0x00166E64
		private static int smethod_9(double double_2, double double_3, double double_4, double double_5, double double_6, double double_7)
		{
			int result;
			try
			{
				double num = (double_4 - double_2) * (double_7 - double_3) - (double_6 - double_2) * (double_5 - double_3);
				if (num > 0.0)
				{
					result = 1;
				}
				else if (num < 0.0)
				{
					result = -1;
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100581", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00168CF0 File Offset: 0x00166EF0
		public static bool smethod_10(double double_2, double double_3, Scenario scenario_0, ref List<ActiveUnit> list_0)
		{
			bool result;
			try
			{
				for (int i = scenario_0.Cache_FacilitiesWithPiers.Count - 1; i >= 0; i += -1)
				{
					ActiveUnit activeUnit = scenario_0.Cache_FacilitiesWithPiers[i];
					if (GeoPoint.smethod_2(double_2, double_3, activeUnit.vmethod_93().method_4(), false))
					{
						return true;
					}
				}
				result = false;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200462", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00168D8C File Offset: 0x00166F8C
		public static bool smethod_11(double double_2, double double_3)
		{
			bool result;
			try
			{
				if (Class579.smethod_1().method_0(double_2, double_3, false))
				{
					result = true;
				}
				else if (Class579.smethod_0().method_0(double_2, double_3, false))
				{
					result = true;
				}
				else if (Class579.smethod_2().method_0(double_2, double_3, false))
				{
					result = true;
				}
				else if (Class579.smethod_3().method_0(double_2, double_3, false))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100583", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0000A991 File Offset: 0x00008B91
		public double imethod_0()
		{
			return this.double_0;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00168E30 File Offset: 0x00167030
		public void imethod_1(double double_2)
		{
			if (double_2 > 180.0 || double_2 < -180.0)
			{
				double_2 = Math2.smethod_11(ref double_2);
			}
			if (double.IsNaN(double_2))
			{
				bool isAttached = Debugger.IsAttached;
				double_2 = 0.0;
			}
			this.double_0 = double_2;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0000A999 File Offset: 0x00008B99
		public double imethod_2()
		{
			return this.double_1;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00168E80 File Offset: 0x00167080
		public void imethod_3(double double_2)
		{
			if (double_2 > 90.0 || double_2 < -90.0)
			{
				double_2 = Math2.smethod_10(ref double_2);
			}
			if (double.IsNaN(double_2))
			{
				bool isAttached = Debugger.IsAttached;
				double_2 = 0.0;
			}
			this.double_1 = double_2;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0000A9A1 File Offset: 0x00008BA1
		public float imethod_4()
		{
			return this.float_0;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0000A9A9 File Offset: 0x00008BA9
		public void imethod_5(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00168ED0 File Offset: 0x001670D0
		public static Geopoint_Struct smethod_12(double double_2, double double_3, float float_1, float float_2)
		{
			Geopoint_Struct result = default(Geopoint_Struct);
			Class411.smethod_1(double_3, double_2, ref result.double_0, ref result.double_1, (double)float_2, (double)float_1);
			return result;
		}

		// Token: 0x04000D16 RID: 3350
		private double double_0;

		// Token: 0x04000D17 RID: 3351
		private double double_1;

		// Token: 0x04000D18 RID: 3352
		private float float_0;

		// Token: 0x04000D19 RID: 3353
		private StringBuilder stringBuilder_0;
	}
}
