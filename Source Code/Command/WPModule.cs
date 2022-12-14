using System;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using QuickGraph;

namespace Command_Core
{
	// Token: 0x0200046A RID: 1130
	[StandardModule]
	public sealed class WPModule
	{
		// Token: 0x04001D7D RID: 7549
		private static CultureInfo cultureInfo_0 = new CultureInfo("en-US");

		// Token: 0x0200046B RID: 1131
		internal class Class523 : IIdentifiable
		{
			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00010E60 File Offset: 0x0000F060
			public string ID
			{
				get
				{
					return this.string_0;
				}
			}

			// Token: 0x060022F2 RID: 8946 RVA: 0x002902D4 File Offset: 0x0028E4D4
			public Class523()
			{
				this.string_0 = Guid.NewGuid().ToString();
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00010E68 File Offset: 0x0000F068
			// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00010E70 File Offset: 0x0000F070
			[XmlIgnore]
			public double Altitude
			{
				get
				{
					return this.double_0;
				}
				set
				{
					this.double_0 = value;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060022F5 RID: 8949 RVA: 0x00010E79 File Offset: 0x0000F079
			// (set) Token: 0x060022F6 RID: 8950 RVA: 0x00010E81 File Offset: 0x0000F081
			[XmlIgnore]
			public double Latitude
			{
				get
				{
					return this.double_1;
				}
				set
				{
					this.double_1 = value;
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060022F7 RID: 8951 RVA: 0x00010E8A File Offset: 0x0000F08A
			// (set) Token: 0x060022F8 RID: 8952 RVA: 0x00010E92 File Offset: 0x0000F092
			[XmlIgnore]
			public double Longitude
			{
				get
				{
					return this.double_2;
				}
				set
				{
					this.double_2 = value;
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060022F9 RID: 8953 RVA: 0x00010E9B File Offset: 0x0000F09B
			// (set) Token: 0x060022FA RID: 8954 RVA: 0x00290300 File Offset: 0x0028E500
			[XmlAttribute]
			public string Coords
			{
				get
				{
					return this.ToString();
				}
				set
				{
					string[] array = value.Split(new char[]
					{
						' '
					});
					if (array.Length == 3)
					{
						string s = array[0];
						NumberStyles style = NumberStyles.AllowDecimalPoint;
						IFormatProvider cultureInfo_ = WPModule.cultureInfo_0;
						double num = this.Latitude;
						bool flag = double.TryParse(s, style, cultureInfo_, out num);
						this.Latitude = num;
						if (flag)
						{
							string s2 = array[1];
							NumberStyles style2 = NumberStyles.AllowDecimalPoint;
							IFormatProvider cultureInfo_2 = WPModule.cultureInfo_0;
							num = this.Longitude;
							bool flag2 = double.TryParse(s2, style2, cultureInfo_2, out num);
							this.Longitude = num;
							if (flag2)
							{
								string s3 = array[2];
								NumberStyles style3 = NumberStyles.AllowDecimalPoint;
								IFormatProvider cultureInfo_3 = WPModule.cultureInfo_0;
								num = this.Altitude;
								double.TryParse(s3, style3, cultureInfo_3, out num);
								this.Altitude = num;
								return;
							}
						}
					}
					else if (array.Length == 2)
					{
						string s4 = array[0];
						NumberStyles style4 = NumberStyles.AllowDecimalPoint;
						IFormatProvider cultureInfo_4 = WPModule.cultureInfo_0;
						double num = this.Latitude;
						bool flag3 = double.TryParse(s4, style4, cultureInfo_4, out num);
						this.Latitude = num;
						if (flag3)
						{
							string s5 = array[1];
							NumberStyles style5 = NumberStyles.AllowDecimalPoint;
							IFormatProvider cultureInfo_5 = WPModule.cultureInfo_0;
							num = this.Longitude;
							bool flag4 = double.TryParse(s5, style5, cultureInfo_5, out num);
							this.Longitude = num;
							if (flag4)
							{
								this.Altitude = 0.0;
								return;
							}
						}
					}
					else
					{
						try
						{
							throw new Exception("Coords parse error");
						}
						catch (Exception ex)
						{
							ex.Data.Add("Error at 200260", ex.Message);
							GameGeneral.smethod_25(ref ex);
							if (Debugger.IsAttached)
							{
								Debugger.Break();
							}
							throw;
						}
					}
				}
			}

			// Token: 0x04001D7E RID: 7550
			protected string string_0;

			// Token: 0x04001D7F RID: 7551
			protected double double_0;

			// Token: 0x04001D80 RID: 7552
			protected double double_1;

			// Token: 0x04001D81 RID: 7553
			protected double double_2;
		}

		// Token: 0x0200046C RID: 1132
		internal sealed class Class524 : IIdentifiableVertexFactory<WPModule.Waypoint>
		{
			// Token: 0x060022FC RID: 8956 RVA: 0x00010EA3 File Offset: 0x0000F0A3
			public WPModule.Waypoint CreateVertex(string string_0)
			{
				return new WPModule.Waypoint(string_0);
			}
		}

		// Token: 0x0200046D RID: 1133
		[Serializable]
		public sealed class Waypoint : WPModule.Class523
		{
			// Token: 0x060022FD RID: 8957 RVA: 0x00010EAB File Offset: 0x0000F0AB
			public Waypoint(string string_1)
			{
				this.string_0 = string_1;
			}

			// Token: 0x060022FE RID: 8958 RVA: 0x00010EBA File Offset: 0x0000F0BA
			public Waypoint()
			{
			}

			// Token: 0x060022FF RID: 8959 RVA: 0x00290434 File Offset: 0x0028E634
			public override string ToString()
			{
				return string.Concat(new string[]
				{
					this.double_1.ToString(WPModule.cultureInfo_0),
					" ",
					this.double_2.ToString(WPModule.cultureInfo_0),
					" ",
					this.double_0.ToString(WPModule.cultureInfo_0)
				});
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06002300 RID: 8960 RVA: 0x00010EC2 File Offset: 0x0000F0C2
			// (set) Token: 0x06002301 RID: 8961 RVA: 0x00290498 File Offset: 0x0028E698
			[XmlAttribute]
			public string DisplayCoords
			{
				get
				{
					return this._X.ToString(WPModule.cultureInfo_0) + " " + this._Y.ToString(WPModule.cultureInfo_0);
				}
				set
				{
					string[] array = value.Split(new char[]
					{
						' '
					});
					try
					{
						if (array.Length != 2)
						{
							throw new Exception("DisplayCoords parse error");
						}
					}
					catch (Exception ex)
					{
						ex.Data.Add("Error at 200261", ex.Message);
						GameGeneral.smethod_25(ref ex);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw;
					}
					try
					{
						if (!double.TryParse(array[0], NumberStyles.AllowDecimalPoint, WPModule.cultureInfo_0, out this._X))
						{
							throw new Exception("x parse error");
						}
						if (!double.TryParse(array[1], NumberStyles.AllowDecimalPoint, WPModule.cultureInfo_0, out this._Y))
						{
							throw new Exception("y parse error");
						}
					}
					catch (Exception ex2)
					{
						ex2.Data.Add("Error at 200262", ex2.Message);
						GameGeneral.smethod_25(ref ex2);
						if (Debugger.IsAttached)
						{
							Debugger.Break();
						}
						throw;
					}
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06002302 RID: 8962 RVA: 0x00010EEE File Offset: 0x0000F0EE
			// (set) Token: 0x06002303 RID: 8963 RVA: 0x00010EF6 File Offset: 0x0000F0F6
			[XmlIgnore]
			public double X
			{
				get
				{
					return this._X;
				}
				set
				{
					this._X = value;
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06002304 RID: 8964 RVA: 0x00010EFF File Offset: 0x0000F0FF
			// (set) Token: 0x06002305 RID: 8965 RVA: 0x00010F07 File Offset: 0x0000F107
			[XmlIgnore]
			public double Y
			{
				get
				{
					return this._Y;
				}
				set
				{
					this._Y = value;
				}
			}

			// Token: 0x04001D82 RID: 7554
			protected double _X;

			// Token: 0x04001D83 RID: 7555
			protected double _Y;
		}

		// Token: 0x0200046E RID: 1134
		internal sealed class Class525 : IIdentifiableEdgeFactory<WPModule.Waypoint, WPModule.Class526>
		{
			// Token: 0x06002307 RID: 8967 RVA: 0x00010F10 File Offset: 0x0000F110
			public WPModule.Class526 CreateEdge(string string_0, WPModule.Waypoint waypoint_0, WPModule.Waypoint waypoint_1)
			{
				return new WPModule.Class526(string_0, ref waypoint_0, ref waypoint_1);
			}
		}

		// Token: 0x0200046F RID: 1135
		internal sealed class Class526 : IdentifiableEdge<WPModule.Waypoint>
		{
			// Token: 0x06002308 RID: 8968 RVA: 0x00290594 File Offset: 0x0028E794
			public Class526(string string_1, ref WPModule.Waypoint waypoint_0, ref WPModule.Waypoint waypoint_1) : base(string_1, waypoint_0, waypoint_1)
			{
				this.string_0 = Guid.NewGuid().ToString();
			}

			// Token: 0x04001D84 RID: 7556
			protected string string_0;
		}
	}
}
