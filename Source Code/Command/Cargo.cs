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

namespace Command_Core
{
	// Token: 0x020002CE RID: 718
	public sealed class Cargo : PlatformComponent
	{
		// Token: 0x06001549 RID: 5449 RVA: 0x0000B9D7 File Offset: 0x00009BD7
		public Cargo.Enum111 method_23()
		{
			return this.enum111_0;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0000B9DF File Offset: 0x00009BDF
		private void method_24(Cargo.Enum111 enum111_1)
		{
			this.enum111_0 = enum111_1;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0018F654 File Offset: 0x0018D854
		public object method_25()
		{
			if (this.enum111_0 == Cargo.Enum111.const_1)
			{
				return this.mount_0;
			}
			throw new NotImplementedException();
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0018F67C File Offset: 0x0018D87C
		public string method_26()
		{
			if (this.enum111_0 == Cargo.Enum111.const_1)
			{
				return this.mount_0.Name;
			}
			throw new NotImplementedException();
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0018F6A8 File Offset: 0x0018D8A8
		public override void vmethod_1()
		{
			Cargo.Enum111 @enum = this.method_23();
			if (@enum != Cargo.Enum111.const_1)
			{
				if (@enum == Cargo.Enum111.const_2)
				{
					((Weapon)this.method_25()).vmethod_1();
				}
			}
			else
			{
				((Mount)this.method_25()).vmethod_1();
			}
			base.vmethod_1();
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0018F6F0 File Offset: 0x0018D8F0
		public string method_27(HashSet<string> hashSet_0, Scenario scenario_0)
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
				this.stringBuilder_0.Append("<Cargo>");
				this.stringBuilder_0.Append("<ID>").Append(this.string_0).Append("</ID>");
				if (!Information.IsNothing(hashSet_0))
				{
					if (hashSet_0.Contains(this.string_0))
					{
						this.stringBuilder_0.Append("</Cargo>");
						return this.stringBuilder_0.ToString();
					}
					hashSet_0.Add(this.string_0);
				}
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
				if (!string.IsNullOrEmpty(this.Name))
				{
					this.stringBuilder_0.Append("<Name>").Append(SecurityElement.Escape(this.Name)).Append("</Name>");
				}
				this.stringBuilder_0.Append("<CurrentType>").Append((byte)this.enum111_0).Append("</CurrentType>");
				if (this.enum111_0 != Cargo.Enum111.const_1)
				{
					throw new NotImplementedException();
				}
				this.stringBuilder_0.Append(this.mount_0.method_23(ref hashSet_0, scenario_0));
				this.stringBuilder_0.Append("</Cargo>");
				result = this.stringBuilder_0.ToString();
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100658", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0018F908 File Offset: 0x0018DB08
		public override void vmethod_6(Side side_0, bool bool_11, bool bool_12)
		{
			try
			{
				base.vmethod_6(side_0, bool_11, bool_12);
				if (this.method_25().GetType() == typeof(Mount))
				{
					((Mount)this.method_25()).vmethod_6(side_0, bool_11, true);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100678", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0018F990 File Offset: 0x0018DB90
		public static Cargo smethod_2(ref XmlNode xmlNode_0, ref Dictionary<string, Class310> dictionary_0, ActiveUnit activeUnit_1)
		{
			Cargo result;
			try
			{
				Cargo cargo = new Cargo();
				try
				{
					foreach (object obj in xmlNode_0.ChildNodes)
					{
						XmlNode xmlNode = (XmlNode)obj;
						string name = xmlNode.Name;
						if (Operators.CompareString(name, "ID", false) != 0)
						{
							if (Operators.CompareString(name, "Status", false) != 0)
							{
								if (Operators.CompareString(name, "CurrentType", false) != 0)
								{
									if (Operators.CompareString(name, "Name", false) != 0)
									{
										if (Operators.CompareString(name, "DamageSeverity", false) != 0)
										{
											if (Operators.CompareString(name, "Mount", false) == 0)
											{
												cargo.mount_0 = Mount.smethod_6(ref xmlNode, ref dictionary_0, activeUnit_1);
												cargo.mount_0.method_19(null);
											}
										}
										else
										{
											cargo.method_17((PlatformComponent._DamageSeverityFactor)Conversions.ToByte(xmlNode.InnerText));
										}
									}
									else
									{
										cargo.Name = xmlNode.InnerText;
									}
								}
								else
								{
									cargo.enum111_0 = (Cargo.Enum111)Conversions.ToInteger(xmlNode.InnerText);
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
											cargo._ComponentStatus_0 = (PlatformComponent._ComponentStatus)Conversions.ToByte(xmlNode.InnerText);
										}
										else
										{
											cargo._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
										}
									}
									else
									{
										cargo._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
									}
								}
								else
								{
									cargo._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
								}
							}
						}
						else if (!Information.IsNothing(dictionary_0))
						{
							if (dictionary_0.ContainsKey(xmlNode.InnerText))
							{
								return (Cargo)dictionary_0[xmlNode.InnerText];
							}
							cargo.vmethod_0(xmlNode.InnerText);
							dictionary_0.Add(cargo.string_0, cargo);
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
				result = cargo;
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100659", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		private Cargo() : base(null)
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0000B9F1 File Offset: 0x00009BF1
		public Cargo(ActiveUnit activeUnit_1) : base(activeUnit_1)
		{
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0000B9FA File Offset: 0x00009BFA
		public Cargo(ActiveUnit activeUnit_1, Mount mount_1) : base(activeUnit_1)
		{
			this.mount_0 = mount_1;
			this.method_24(Cargo.Enum111.const_1);
		}

		// Token: 0x04001154 RID: 4436
		private Cargo.Enum111 enum111_0;

		// Token: 0x04001155 RID: 4437
		private Mount mount_0;

		// Token: 0x04001156 RID: 4438
		private StringBuilder stringBuilder_0;

		// Token: 0x020002CF RID: 719
		internal enum Enum111
		{
			// Token: 0x04001158 RID: 4440
			const_0,
			// Token: 0x04001159 RID: 4441
			const_1,
			// Token: 0x0400115A RID: 4442
			const_2
		}
	}
}
