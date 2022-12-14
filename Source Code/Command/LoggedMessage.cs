using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x02000288 RID: 648
	public sealed class LoggedMessage : Class310
	{
		// Token: 0x060013B0 RID: 5040 RVA: 0x00177C64 File Offset: 0x00175E64
		public Color method_8()
		{
			switch (this.messageType_0)
			{
			case LoggedMessage.MessageType.NewContact:
			case LoggedMessage.MessageType.NewAirContact:
			case LoggedMessage.MessageType.NewSurfaceContact:
			case LoggedMessage.MessageType.NewUnderwaterContact:
			case LoggedMessage.MessageType.NewGroundContact:
				return Color.Yellow;
			case LoggedMessage.MessageType.ContactChange:
				return Color.Yellow;
			case LoggedMessage.MessageType.WeaponEndgame:
			case LoggedMessage.MessageType.WeaponDamage:
			case LoggedMessage.MessageType.WeaponLogic:
			case LoggedMessage.MessageType.UnguidedWeaponModifiers:
				return Color.LightGray;
			case LoggedMessage.MessageType.AirOps:
			case LoggedMessage.MessageType.DockingOps:
				return Color.LimeGreen;
			case LoggedMessage.MessageType.UnitLost:
				return Color.Red;
			case LoggedMessage.MessageType.UnitDamage:
				return Color.OrangeRed;
			case LoggedMessage.MessageType.PointDefence:
				return Color.Gray;
			case LoggedMessage.MessageType.UnitAI:
				return Color.Gray;
			case LoggedMessage.MessageType.EventEngine:
				return Color.LightBlue;
			case LoggedMessage.MessageType.NewWeaponContact:
			case LoggedMessage.MessageType.NewMineContact:
				return Color.Red;
			case LoggedMessage.MessageType.CommsIsolatedMessage:
				return Color.Gray;
			}
			return Color.White;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00177D40 File Offset: 0x00175F40
		public Font method_9(Font font_0)
		{
			LoggedMessage.MessageType messageType = this.messageType_0;
			switch (messageType)
			{
			case LoggedMessage.MessageType.WeaponEndgame:
			case LoggedMessage.MessageType.WeaponDamage:
			case LoggedMessage.MessageType.PointDefence:
			case LoggedMessage.MessageType.WeaponLogic:
			case LoggedMessage.MessageType.UnitAI:
				goto IL_49;
			case LoggedMessage.MessageType.AirOps:
			case LoggedMessage.MessageType.UnitLost:
			case LoggedMessage.MessageType.UnitDamage:
			case LoggedMessage.MessageType.UI:
				break;
			default:
				if (messageType == LoggedMessage.MessageType.CommsIsolatedMessage)
				{
					goto IL_49;
				}
				if (messageType == LoggedMessage.MessageType.UnguidedWeaponModifiers)
				{
					goto IL_49;
				}
				break;
			}
			return new Font(font_0, FontStyle.Regular);
			IL_49:
			return new Font(font_0, FontStyle.Italic);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00177DA0 File Offset: 0x00175FA0
		public string method_10()
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
				this.stringBuilder_0.Append("<LM>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				this.stringBuilder_0.Append("<Inc>").Append(this.long_0).Append("</Inc>");
				this.stringBuilder_0.Append("<Text>").Append(SecurityElement.Escape(this.string_2)).Append("</Text>");
				this.stringBuilder_0.Append("<Summary>").Append(SecurityElement.Escape(this.string_4)).Append("</Summary>");
				this.stringBuilder_0.Append("<TStamp>").Append(this.dateTime_0.ToBinary()).Append("</TStamp>");
				if (this.byte_0 != 0)
				{
					this.stringBuilder_0.Append("<Level>").Append((int)this.byte_0).Append("</Level>");
				}
				this.stringBuilder_0.Append("<Type>").Append((int)this.messageType_0).Append("</Type>");
				if (!string.IsNullOrEmpty(this.string_3))
				{
					this.stringBuilder_0.Append("<R_ID>").Append(this.string_3).Append("</R_ID>");
				}
				if (this.side_0 != null)
				{
					this.stringBuilder_0.Append("<Side>").Append(this.side_0.string_0).Append("</Side>");
				}
				if (this.nullable_0 != null && (this.nullable_0.Value.double_1 != 0.0 | this.nullable_0.Value.double_0 != 0.0))
				{
					this.stringBuilder_0.Append("<Loc>").Append(XmlConvert.ToString(this.nullable_0.Value.double_0)).Append("_").Append(XmlConvert.ToString(this.nullable_0.Value.double_1)).Append("</Loc>");
				}
				this.stringBuilder_0.Append("</LM>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101011", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0000944E File Offset: 0x0000764E
		private LoggedMessage()
		{
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0017808C File Offset: 0x0017628C
		public static LoggedMessage smethod_0(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0)
		{
			LoggedMessage result;
			try
			{
				LoggedMessage loggedMessage = new LoggedMessage();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						uint num = Class582.smethod_0(name);
						if (num > 1539345862U)
						{
							if (num <= 2595629539U)
							{
								if (num != 1719845082U)
								{
									if (num != 2590053246U)
									{
										if (num != 2595629539U)
										{
											continue;
										}
										if (Operators.CompareString(name, "R_ID", false) != 0)
										{
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(name, "Side", false) != 0)
										{
											continue;
										}
										if (dictionary_0.ContainsKey(xmlNode.InnerText))
										{
											loggedMessage.side_0 = (Side)dictionary_0[xmlNode.InnerText];
											continue;
										}
										return null;
									}
								}
								else
								{
									if (Operators.CompareString(name, "TStamp", false) != 0)
									{
										continue;
									}
									goto IL_34C;
								}
							}
							else if (num <= 2782757437U)
							{
								if (num != 2653670837U)
								{
									if (num != 2782757437U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Loc", false) == 0)
									{
										goto IL_255;
									}
									continue;
								}
								else if (Operators.CompareString(name, "ReporterID", false) != 0)
								{
									continue;
								}
							}
							else if (num != 3055432035U)
							{
								if (num != 3512062061U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Type", false) != 0)
								{
									continue;
								}
								if (Versioned.IsNumeric(xmlNode.InnerText))
								{
									loggedMessage.messageType_0 = (LoggedMessage.MessageType)Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								loggedMessage.messageType_0 = (LoggedMessage.MessageType)Enum.Parse(typeof(LoggedMessage.MessageType), xmlNode.InnerText, true);
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "TimeStamp", false) == 0)
								{
									goto IL_34C;
								}
								continue;
							}
							loggedMessage.string_3 = xmlNode.InnerText;
							continue;
							IL_34C:
							loggedMessage.dateTime_0 = DateTime.FromBinary(Conversions.ToLong(xmlNode.InnerText));
							continue;
						}
						if (num <= 1041509726U)
						{
							if (num != 65639134U)
							{
								if (num != 192164839U)
								{
									if (num != 1041509726U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Text", false) == 0)
									{
										loggedMessage.string_2 = xmlNode.InnerText;
										continue;
									}
									continue;
								}
								else if (Operators.CompareString(name, "Inc", false) != 0)
								{
									continue;
								}
							}
							else if (Operators.CompareString(name, "Increment", false) != 0)
							{
								continue;
							}
							loggedMessage.long_0 = Conversions.ToLong(xmlNode.InnerText);
							continue;
						}
						if (num <= 1096112509U)
						{
							if (num != 1095677363U)
							{
								if (num != 1096112509U)
								{
									continue;
								}
								if (Operators.CompareString(name, "Level", false) == 0)
								{
									loggedMessage.byte_0 = Conversions.ToByte(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							else
							{
								if (Operators.CompareString(name, "Summary", false) == 0)
								{
									loggedMessage.string_4 = xmlNode.InnerText;
									continue;
								}
								continue;
							}
						}
						else if (num != 1458105184U)
						{
							if (num != 1539345862U)
							{
								continue;
							}
							if (Operators.CompareString(name, "Location", false) != 0)
							{
								continue;
							}
						}
						else
						{
							if (Operators.CompareString(name, "ID", false) == 0)
							{
								loggedMessage.vmethod_0(xmlNode.InnerText);
								continue;
							}
							continue;
						}
						IL_255:
						if (xmlNode.HasChildNodes)
						{
							loggedMessage.nullable_0 = new Geopoint_Struct?(Geopoint_Struct.smethod_0(xmlNode, dictionary_0));
						}
						else
						{
							string[] array = xmlNode.InnerText.Split(new char[]
							{
								'_'
							});
							loggedMessage.nullable_0 = new Geopoint_Struct?(new Geopoint_Struct(XmlConvert.ToDouble(array[0]), XmlConvert.ToDouble(array[1])));
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
				result = loggedMessage;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 101012", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = new LoggedMessage();
			}
			return result;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00178498 File Offset: 0x00176698
		public LoggedMessage(long theIncrement, string theText, string Summary, LoggedMessage.MessageType theType, DateTime theTimestamp, string theReporterID, byte theLevel, Side theSide = null, Geopoint_Struct? theLocation = null)
		{
			this.long_0 = theIncrement;
			this.string_2 = theText;
			this.string_4 = Summary;
			this.dateTime_0 = theTimestamp;
			this.byte_0 = theLevel;
			this.messageType_0 = theType;
			this.string_3 = theReporterID;
			this.side_0 = theSide;
			this.nullable_0 = theLocation;
		}

		// Token: 0x04000E73 RID: 3699
		public long long_0;

		// Token: 0x04000E74 RID: 3700
		public string string_2;

		// Token: 0x04000E75 RID: 3701
		public DateTime dateTime_0;

		// Token: 0x04000E76 RID: 3702
		public byte byte_0;

		// Token: 0x04000E77 RID: 3703
		public LoggedMessage.MessageType messageType_0;

		// Token: 0x04000E78 RID: 3704
		public string string_3;

		// Token: 0x04000E79 RID: 3705
		public Side side_0;

		// Token: 0x04000E7A RID: 3706
		public Geopoint_Struct? nullable_0;

		// Token: 0x04000E7B RID: 3707
		public bool bool_11;

		// Token: 0x04000E7C RID: 3708
		public string string_4;

		// Token: 0x04000E7D RID: 3709
		private StringBuilder stringBuilder_0;

		// Token: 0x02000289 RID: 649
		public enum MessageType : byte
		{
			// Token: 0x04000E7F RID: 3711
			None,
			// Token: 0x04000E80 RID: 3712
			NewContact,
			// Token: 0x04000E81 RID: 3713
			ContactChange,
			// Token: 0x04000E82 RID: 3714
			WeaponEndgame,
			// Token: 0x04000E83 RID: 3715
			WeaponDamage,
			// Token: 0x04000E84 RID: 3716
			AirOps,
			// Token: 0x04000E85 RID: 3717
			UnitLost,
			// Token: 0x04000E86 RID: 3718
			UnitDamage,
			// Token: 0x04000E87 RID: 3719
			PointDefence,
			// Token: 0x04000E88 RID: 3720
			UI,
			// Token: 0x04000E89 RID: 3721
			WeaponLogic,
			// Token: 0x04000E8A RID: 3722
			UnitAI,
			// Token: 0x04000E8B RID: 3723
			EventEngine = 13,
			// Token: 0x04000E8C RID: 3724
			NewWeaponContact,
			// Token: 0x04000E8D RID: 3725
			DockingOps,
			// Token: 0x04000E8E RID: 3726
			SpecialMessage,
			// Token: 0x04000E8F RID: 3727
			NewMineContact,
			// Token: 0x04000E90 RID: 3728
			CommsIsolatedMessage,
			// Token: 0x04000E91 RID: 3729
			NewAirContact,
			// Token: 0x04000E92 RID: 3730
			NewSurfaceContact,
			// Token: 0x04000E93 RID: 3731
			NewUnderwaterContact,
			// Token: 0x04000E94 RID: 3732
			NewGroundContact,
			// Token: 0x04000E95 RID: 3733
			UnguidedWeaponModifiers
		}

		// Token: 0x0200028A RID: 650
		internal sealed class Class284
		{
			// Token: 0x060013B6 RID: 5046 RVA: 0x0000AF52 File Offset: 0x00009152
			public Class284(bool bool_3, bool bool_4, bool bool_5)
			{
				this.bool_0 = bool_3;
				this.bool_1 = bool_4;
				this.bool_2 = bool_5;
			}

			// Token: 0x04000E96 RID: 3734
			public bool bool_0;

			// Token: 0x04000E97 RID: 3735
			public bool bool_1;

			// Token: 0x04000E98 RID: 3736
			public bool bool_2;
		}
	}
}
