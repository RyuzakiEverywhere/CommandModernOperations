using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns10;
using ns14;

namespace Command_Core
{
	// Token: 0x020002DF RID: 735
	public abstract class PlatformComponent : Class310
	{
		// Token: 0x060015C3 RID: 5571 RVA: 0x001955FC File Offset: 0x001937FC
		[CompilerGenerated]
		public static void smethod_0(PlatformComponent.Delegate46 delegate46_1)
		{
			PlatformComponent.Delegate46 @delegate = PlatformComponent.delegate46_0;
			PlatformComponent.Delegate46 delegate2;
			do
			{
				delegate2 = @delegate;
				PlatformComponent.Delegate46 value = (PlatformComponent.Delegate46)Delegate.Combine(delegate2, delegate46_1);
				@delegate = Interlocked.CompareExchange<PlatformComponent.Delegate46>(ref PlatformComponent.delegate46_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00195630 File Offset: 0x00193830
		[CompilerGenerated]
		public static void smethod_1(PlatformComponent.Delegate46 delegate46_1)
		{
			PlatformComponent.Delegate46 @delegate = PlatformComponent.delegate46_0;
			PlatformComponent.Delegate46 delegate2;
			do
			{
				delegate2 = @delegate;
				PlatformComponent.Delegate46 value = (PlatformComponent.Delegate46)Delegate.Remove(delegate2, delegate46_1);
				@delegate = Interlocked.CompareExchange<PlatformComponent.Delegate46>(ref PlatformComponent.delegate46_0, value, delegate2);
			}
			while (@delegate != delegate2);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0000BBE9 File Offset: 0x00009DE9
		protected PlatformComponent()
		{
			this.class295_0 = new PlatformComponent.Class295();
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0000BBFC File Offset: 0x00009DFC
		public bool method_8()
		{
			return base.GetType() == typeof(Mount);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0000BC10 File Offset: 0x00009E10
		public bool method_9()
		{
			return base.GetType() == typeof(Magazine);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0000BC24 File Offset: 0x00009E24
		public bool method_10()
		{
			return base.GetType() == typeof(Sensor);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0000BC38 File Offset: 0x00009E38
		public bool method_11()
		{
			return base.GetType() == typeof(AirFacility);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0000BC4C File Offset: 0x00009E4C
		public bool method_12()
		{
			return base.GetType() == typeof(CommDevice);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0000BC60 File Offset: 0x00009E60
		public bool method_13()
		{
			return base.GetType() == typeof(Engine);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0000BC74 File Offset: 0x00009E74
		public bool method_14()
		{
			return base.GetType() == typeof(Cargo);
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0000BC88 File Offset: 0x00009E88
		public bool method_15()
		{
			return base.GetType() == typeof(Class345);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0000BC9C File Offset: 0x00009E9C
		public PlatformComponent._DamageSeverityFactor method_16()
		{
			return this._DamageSeverityFactor_0;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0000BCA4 File Offset: 0x00009EA4
		public void method_17(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			this._DamageSeverityFactor_0 = _DamageSeverityFactor_1;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0000BCAD File Offset: 0x00009EAD
		public ActiveUnit method_18()
		{
			return this.activeUnit_0;
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0000BCB5 File Offset: 0x00009EB5
		public void method_19(ActiveUnit activeUnit_1)
		{
			this.activeUnit_0 = activeUnit_1;
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0000BCBE File Offset: 0x00009EBE
		public virtual string vmethod_4()
		{
			return "None";
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00195664 File Offset: 0x00193864
		public bool method_20(Unit theTarget, float? CustomParentHeading = null)
		{
			bool result;
			try
			{
				if (this.class295_0.method_1())
				{
					result = true;
				}
				else if (Information.IsNothing(this.method_18()))
				{
					result = false;
				}
				else
				{
					double num;
					if (Information.IsNothing(CustomParentHeading))
					{
						num = (double)this.method_18().vmethod_9();
					}
					else
					{
						num = (double)CustomParentHeading.Value;
					}
					double num2 = Math2.smethod_6((double)Math2.smethod_17(this.method_18().vmethod_30(new bool?(true)), this.method_18().vmethod_28(new bool?(true)), theTarget.vmethod_30(new bool?(true)), theTarget.vmethod_28(new bool?(true))) - num);
					if (num2 <= 22.5)
					{
						result = this.class295_0.bool_7;
					}
					else if (num2 <= 45.0)
					{
						result = this.class295_0.bool_15;
					}
					else if (num2 <= 67.5)
					{
						result = this.class295_0.bool_6;
					}
					else if (num2 <= 90.0)
					{
						result = this.class295_0.bool_14;
					}
					else if (num2 <= 112.5)
					{
						result = this.class295_0.bool_5;
					}
					else if (num2 <= 135.0)
					{
						result = this.class295_0.bool_13;
					}
					else if (num2 <= 157.5)
					{
						result = this.class295_0.bool_4;
					}
					else if (num2 <= 180.0)
					{
						result = this.class295_0.bool_12;
					}
					else if (num2 <= 202.5)
					{
						result = this.class295_0.bool_0;
					}
					else if (num2 <= 225.0)
					{
						result = this.class295_0.bool_8;
					}
					else if (num2 <= 247.5)
					{
						result = this.class295_0.bool_1;
					}
					else if (num2 <= 270.0)
					{
						result = this.class295_0.bool_9;
					}
					else if (num2 <= 292.5)
					{
						result = this.class295_0.bool_2;
					}
					else if (num2 <= 315.0)
					{
						result = this.class295_0.bool_10;
					}
					else if (num2 <= 337.5)
					{
						result = this.class295_0.bool_3;
					}
					else
					{
						result = this.class295_0.bool_11;
					}
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100685", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
			return result;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x0000BCC5 File Offset: 0x00009EC5
		public virtual PlatformComponent._ComponentStatus vmethod_5()
		{
			return this._ComponentStatus_0;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0000BCCD File Offset: 0x00009ECD
		public PlatformComponent(ActiveUnit activeUnit_1)
		{
			this.class295_0 = new PlatformComponent.Class295();
			this.method_19(activeUnit_1);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0019591C File Offset: 0x00193B1C
		public void method_21()
		{
			PlatformComponent.Delegate46 @delegate = PlatformComponent.delegate46_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0019593C File Offset: 0x00193B3C
		public virtual void vmethod_6(Side side_0, bool bool_11, bool bool_12)
		{
			try
			{
				this._ComponentStatus_0 = PlatformComponent._ComponentStatus.Destroyed;
				if (!Information.IsNothing(this.method_18()) && this.method_18().bool_8 && !this.method_18().method_82() && ((Facility)this.method_18()).bool_27 && !bool_11 && !Information.IsNothing(this.method_18().vmethod_51()) && Enumerable.Count<Mount>(Enumerable.Where<Mount>(this.method_18().vmethod_51(), (PlatformComponent._Closure$__.$I44-0 == null) ? (PlatformComponent._Closure$__.$I44-0 = new Func<Mount, bool>(PlatformComponent._Closure$__.$I.method_0)) : PlatformComponent._Closure$__.$I44-0)) == this.method_18().vmethod_51().Count && !Information.IsNothing(this.method_18().scenario_0))
				{
					this.method_18().scenario_0.method_65(this.method_18());
				}
				PlatformComponent.Delegate46 @delegate = PlatformComponent.delegate46_0;
				if (@delegate != null)
				{
					@delegate(this);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 100686", "");
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00195A78 File Offset: 0x00193C78
		public virtual void vmethod_7()
		{
			this._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
			PlatformComponent.Delegate46 @delegate = PlatformComponent.delegate46_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00195A9C File Offset: 0x00193C9C
		public virtual void vmethod_8(PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_1)
		{
			this._ComponentStatus_0 = PlatformComponent._ComponentStatus.Damaged;
			this._DamageSeverityFactor_0 = _DamageSeverityFactor_1;
			PlatformComponent.Delegate46 @delegate = PlatformComponent.delegate46_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00195AC8 File Offset: 0x00193CC8
		public void method_22(bool bool_11)
		{
			this._ComponentStatus_0 = PlatformComponent._ComponentStatus.Operational;
			if (bool_11 && base.GetType() == typeof(AirFacility))
			{
				GameGeneral.smethod_1("A runway or pad's effective ability to host aircraft depends on its parent platform's integrity, i.e. the amount of damage sustained. Setting the component operational will not improve the aircraft capacity.");
			}
			PlatformComponent.Delegate46 @delegate = PlatformComponent.delegate46_0;
			if (@delegate != null)
			{
				@delegate(this);
			}
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_9(float float_0)
		{
		}

		// Token: 0x0400122C RID: 4652
		protected PlatformComponent._ComponentStatus _ComponentStatus_0;

		// Token: 0x0400122D RID: 4653
		protected ActiveUnit activeUnit_0;

		// Token: 0x0400122E RID: 4654
		private PlatformComponent._DamageSeverityFactor _DamageSeverityFactor_0;

		// Token: 0x0400122F RID: 4655
		public PlatformComponent.Class295 class295_0;

		// Token: 0x04001230 RID: 4656
		public int DBID;

		// Token: 0x04001231 RID: 4657
		[CompilerGenerated]
		private static PlatformComponent.Delegate46 delegate46_0;

		// Token: 0x020002E0 RID: 736
		// (Invoke) Token: 0x060015DF RID: 5599
		internal delegate void Delegate46(PlatformComponent theComponent);

		// Token: 0x020002E1 RID: 737
		public enum _ComponentStatus : byte
		{
			// Token: 0x04001233 RID: 4659
			Operational,
			// Token: 0x04001234 RID: 4660
			Damaged,
			// Token: 0x04001235 RID: 4661
			Destroyed
		}

		// Token: 0x020002E2 RID: 738
		public enum _DamageSeverityFactor : byte
		{
			// Token: 0x04001237 RID: 4663
			Light,
			// Token: 0x04001238 RID: 4664
			Medium,
			// Token: 0x04001239 RID: 4665
			Heavy
		}

		// Token: 0x020002E3 RID: 739
		internal sealed class Class295
		{
			// Token: 0x060015E1 RID: 5601 RVA: 0x00195B0C File Offset: 0x00193D0C
			public string method_0(bool bool_16)
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
					if (bool_16)
					{
						this.stringBuilder_0.Append("<Cov_Ill>");
					}
					else
					{
						this.stringBuilder_0.Append("<Cov>");
					}
					if (this.method_1())
					{
						this.stringBuilder_0.Append("<Seg>360</Seg>");
					}
					else
					{
						this.stringBuilder_0.Append("<Seg>");
						if (this.bool_3)
						{
							this.stringBuilder_0.Append("PB1,");
						}
						if (this.bool_11)
						{
							this.stringBuilder_0.Append("PB2,");
						}
						if (this.bool_1)
						{
							this.stringBuilder_0.Append("PMA1,");
						}
						if (this.bool_9)
						{
							this.stringBuilder_0.Append("PMA2,");
						}
						if (this.bool_2)
						{
							this.stringBuilder_0.Append("PMF1,");
						}
						if (this.bool_10)
						{
							this.stringBuilder_0.Append("PMF2,");
						}
						if (this.bool_0)
						{
							this.stringBuilder_0.Append("PS1,");
						}
						if (this.bool_8)
						{
							this.stringBuilder_0.Append("PS2,");
						}
						if (this.bool_7)
						{
							this.stringBuilder_0.Append("SB1,");
						}
						if (this.bool_15)
						{
							this.stringBuilder_0.Append("SB2,");
						}
						if (this.bool_5)
						{
							this.stringBuilder_0.Append("SMA1,");
						}
						if (this.bool_13)
						{
							this.stringBuilder_0.Append("SMA2,");
						}
						if (this.bool_6)
						{
							this.stringBuilder_0.Append("SMF1,");
						}
						if (this.bool_14)
						{
							this.stringBuilder_0.Append("SMF2,");
						}
						if (this.bool_4)
						{
							this.stringBuilder_0.Append("SS1,");
						}
						if (this.bool_12)
						{
							this.stringBuilder_0.Append("SS2,");
						}
						this.stringBuilder_0.Append("</Seg>");
					}
					if (bool_16)
					{
						this.stringBuilder_0.Append("</Cov_Ill>");
					}
					else
					{
						this.stringBuilder_0.Append("</Cov>");
					}
					result = this.stringBuilder_0.ToString();
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 104985609568943068", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
					throw;
				}
				return result;
			}

			// Token: 0x060015E2 RID: 5602 RVA: 0x00195DBC File Offset: 0x00193FBC
			public static PlatformComponent.Class295 smethod_0(ref XmlNode xmlNode_0)
			{
				PlatformComponent.Class295 result;
				try
				{
					PlatformComponent.Class295 @class = new PlatformComponent.Class295();
					try
					{
						foreach (object obj in xmlNode_0.ChildNodes)
						{
							XmlNode xmlNode = (XmlNode)obj;
							string name = xmlNode.Name;
							uint num = Class582.smethod_0(name);
							if (num <= 3867991516U)
							{
								if (num <= 555814959U)
								{
									if (num != 431064838U)
									{
										if (num != 555814959U)
										{
											continue;
										}
										if (Operators.CompareString(name, "StarboardMiddleForward", false) == 0)
										{
											@class.bool_6 = Conversions.ToBoolean(xmlNode.InnerText);
											@class.bool_14 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else if (Operators.CompareString(name, "Seg", false) != 0)
									{
										continue;
									}
								}
								else if (num != 2500017163U)
								{
									if (num != 2865575288U)
									{
										if (num != 3867991516U)
										{
											continue;
										}
										if (Operators.CompareString(name, "PortStern", false) == 0)
										{
											@class.bool_0 = Conversions.ToBoolean(xmlNode.InnerText);
											@class.bool_8 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
									else
									{
										if (Operators.CompareString(name, "PortMiddleForward", false) == 0)
										{
											@class.bool_2 = Conversions.ToBoolean(xmlNode.InnerText);
											@class.bool_10 = Conversions.ToBoolean(xmlNode.InnerText);
											continue;
										}
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "StarboardStern", false) == 0)
									{
										@class.bool_4 = Conversions.ToBoolean(xmlNode.InnerText);
										@class.bool_12 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num <= 4068245167U)
							{
								if (num != 3997954474U)
								{
									if (num != 4068245167U)
									{
										continue;
									}
									if (Operators.CompareString(name, "Segments", false) != 0)
									{
										continue;
									}
								}
								else
								{
									if (Operators.CompareString(name, "PortBow", false) == 0)
									{
										@class.bool_3 = Conversions.ToBoolean(xmlNode.InnerText);
										@class.bool_11 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else if (num != 4096566348U)
							{
								if (num != 4117168363U)
								{
									if (num != 4155129661U)
									{
										continue;
									}
									if (Operators.CompareString(name, "StarboardBow", false) == 0)
									{
										@class.bool_7 = Conversions.ToBoolean(xmlNode.InnerText);
										@class.bool_15 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
								else
								{
									if (Operators.CompareString(name, "StarboardMiddleAft", false) == 0)
									{
										@class.bool_5 = Conversions.ToBoolean(xmlNode.InnerText);
										@class.bool_13 = Conversions.ToBoolean(xmlNode.InnerText);
										continue;
									}
									continue;
								}
							}
							else
							{
								if (Operators.CompareString(name, "PortMiddleAft", false) == 0)
								{
									@class.bool_1 = Conversions.ToBoolean(xmlNode.InnerText);
									@class.bool_9 = Conversions.ToBoolean(xmlNode.InnerText);
									continue;
								}
								continue;
							}
							foreach (string text in xmlNode.InnerText.Split(new char[]
							{
								','
							}))
							{
								if (!string.IsNullOrEmpty(text))
								{
									string text2 = text.Trim();
									num = Class582.smethod_0(text2);
									if (num <= 2181607519U)
									{
										if (num <= 1604558652U)
										{
											if (num <= 1469204867U)
											{
												if (num != 3032978U)
												{
													if (num == 1469204867U)
													{
														if (Operators.CompareString(text2, "PMF1", false) == 0)
														{
															@class.bool_2 = true;
														}
													}
												}
												else if (Operators.CompareString(text2, "PS2", false) == 0)
												{
													@class.bool_8 = true;
												}
											}
											else if (num != 1485982486U)
											{
												if (num == 1604558652U)
												{
													if (Operators.CompareString(text2, "PMA1", false) == 0)
													{
														@class.bool_1 = true;
													}
												}
											}
											else if (Operators.CompareString(text2, "PMF2", false) == 0)
											{
												@class.bool_10 = true;
											}
										}
										else if (num <= 1729738499U)
										{
											if (num != 1654891509U)
											{
												if (num == 1729738499U)
												{
													if (Operators.CompareString(text2, "SS2", false) == 0)
													{
														@class.bool_12 = true;
													}
												}
											}
											else if (Operators.CompareString(text2, "PMA2", false) == 0)
											{
												@class.bool_9 = true;
											}
										}
										else if (num != 1746516118U)
										{
											if (num == 2181607519U)
											{
												if (Operators.CompareString(text2, "PB2", false) == 0)
												{
													@class.bool_11 = true;
												}
											}
										}
										else if (Operators.CompareString(text2, "SS1", false) == 0)
										{
											@class.bool_4 = true;
										}
									}
									else if (num <= 2859869279U)
									{
										if (num <= 2725501232U)
										{
											if (num != 2198385138U)
											{
												if (num == 2725501232U)
												{
													if (Operators.CompareString(text2, "SMF1", false) == 0)
													{
														@class.bool_6 = true;
													}
												}
											}
											else if (Operators.CompareString(text2, "PB1", false) == 0)
											{
												@class.bool_3 = true;
											}
										}
										else if (num != 2775834089U)
										{
											if (num == 2859869279U)
											{
												if (Operators.CompareString(text2, "SMA1", false) == 0)
												{
													@class.bool_5 = true;
												}
											}
										}
										else if (Operators.CompareString(text2, "SMF2", false) == 0)
										{
											@class.bool_14 = true;
										}
									}
									else if (num <= 3512027844U)
									{
										if (num != 2876646898U)
										{
											if (num == 3512027844U)
											{
												if (Operators.CompareString(text2, "360", false) == 0)
												{
													@class.bool_3 = true;
													@class.bool_1 = true;
													@class.bool_2 = true;
													@class.bool_0 = true;
													@class.bool_7 = true;
													@class.bool_5 = true;
													@class.bool_6 = true;
													@class.bool_4 = true;
													@class.bool_11 = true;
													@class.bool_9 = true;
													@class.bool_10 = true;
													@class.bool_8 = true;
													@class.bool_15 = true;
													@class.bool_13 = true;
													@class.bool_14 = true;
													@class.bool_12 = true;
													break;
												}
											}
										}
										else if (Operators.CompareString(text2, "SMA2", false) == 0)
										{
											@class.bool_13 = true;
										}
									}
									else if (num != 3824130755U)
									{
										if (num != 3840908374U)
										{
											if (num == 4281222655U)
											{
												if (Operators.CompareString(text2, "PS1", false) == 0)
												{
													@class.bool_0 = true;
												}
											}
										}
										else if (Operators.CompareString(text2, "SB2", false) == 0)
										{
											@class.bool_15 = true;
										}
									}
									else if (Operators.CompareString(text2, "SB1", false) == 0)
									{
										@class.bool_7 = true;
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
					result = @class;
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 100688", "");
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
				return result;
			}

			// Token: 0x060015E3 RID: 5603 RVA: 0x001964B8 File Offset: 0x001946B8
			public bool method_1()
			{
				return this.bool_3 && this.bool_11 && this.bool_1 && this.bool_9 && this.bool_2 && this.bool_10 && this.bool_0 && this.bool_8 && this.bool_7 && this.bool_15 && this.bool_5 && this.bool_13 && this.bool_6 && this.bool_14 && this.bool_4 && this.bool_12;
			}

			// Token: 0x060015E4 RID: 5604 RVA: 0x00196548 File Offset: 0x00194748
			public bool method_2()
			{
				return this.bool_3 || this.bool_11 || this.bool_1 || this.bool_9 || this.bool_2 || this.bool_10 || this.bool_0 || this.bool_8 || this.bool_7 || this.bool_15 || this.bool_5 || this.bool_13 || this.bool_6 || this.bool_14 || this.bool_4 || this.bool_12;
			}

			// Token: 0x0400123A RID: 4666
			public bool bool_0;

			// Token: 0x0400123B RID: 4667
			public bool bool_1;

			// Token: 0x0400123C RID: 4668
			public bool bool_2;

			// Token: 0x0400123D RID: 4669
			public bool bool_3;

			// Token: 0x0400123E RID: 4670
			public bool bool_4;

			// Token: 0x0400123F RID: 4671
			public bool bool_5;

			// Token: 0x04001240 RID: 4672
			public bool bool_6;

			// Token: 0x04001241 RID: 4673
			public bool bool_7;

			// Token: 0x04001242 RID: 4674
			public bool bool_8;

			// Token: 0x04001243 RID: 4675
			public bool bool_9;

			// Token: 0x04001244 RID: 4676
			public bool bool_10;

			// Token: 0x04001245 RID: 4677
			public bool bool_11;

			// Token: 0x04001246 RID: 4678
			public bool bool_12;

			// Token: 0x04001247 RID: 4679
			public bool bool_13;

			// Token: 0x04001248 RID: 4680
			public bool bool_14;

			// Token: 0x04001249 RID: 4681
			public bool bool_15;

			// Token: 0x0400124A RID: 4682
			private StringBuilder stringBuilder_0;
		}
	}
}
