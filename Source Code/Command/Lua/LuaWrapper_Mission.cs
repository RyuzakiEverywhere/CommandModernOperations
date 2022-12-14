using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using NLua;
using ns10;
using ns11;
using ns13;
using ns14;

namespace Command_Core.Lua
{
	// Token: 0x02000434 RID: 1076
	[Attribute1]
	[Attribute2]
	[Attribute3]
	public sealed class LuaWrapper_Mission
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0023AE5C File Offset: 0x0023905C
		public object fields
		{
			get
			{
				Type type = base.GetType();
				int num = 0;
				PropertyInfo[] properties = type.GetProperties();
				MethodInfo[] methods = type.GetMethods();
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				foreach (PropertyInfo propertyInfo in properties)
				{
					if (!propertyInfo.Name.StartsWith("__") && !propertyInfo.Name.StartsWith("fields"))
					{
						string text = "";
						bool flag = false;
						if (propertyInfo.MemberType == MemberTypes.Method)
						{
							text = ":";
						}
						else if (propertyInfo.MemberType == MemberTypes.Property)
						{
							text = ".";
						}
						foreach (MethodInfo memberInfo in methods)
						{
							string right = "set_" + propertyInfo.Name;
							if (Operators.CompareString(memberInfo.Name, right, false) == 0)
							{
								flag = true;
							}
						}
						num++;
						dictionary.Add("property_" + num.ToString(), string.Concat(new string[]
						{
							text,
							propertyInfo.Name,
							" , ",
							propertyInfo.PropertyType.Name,
							" , ",
							flag.ToString()
						}));
					}
				}
				num = 0;
				foreach (MethodInfo methodInfo in methods)
				{
					if (!methodInfo.Name.StartsWith("get_") && !methodInfo.Name.StartsWith("set_") && !methodInfo.Name.StartsWith("ToString") && !methodInfo.IsHideBySig)
					{
						string str = "";
						if (methodInfo.MemberType == MemberTypes.Method)
						{
							str = ":";
						}
						else if (methodInfo.MemberType == MemberTypes.Property)
						{
							str = ".";
						}
						num++;
						dictionary.Add("method_" + num.ToString(), str + methodInfo.Name + " , " + methodInfo.ReturnType.ToString());
					}
				}
				object result;
				if (dictionary.Count == 0)
				{
					result = null;
				}
				else
				{
					LuaUtility.smethod_3(dictionary, luaTable);
					result = luaTable;
				}
				return result;
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00248C34 File Offset: 0x00246E34
		public LuaWrapper_Mission(Mission theMission, Scenario theScen)
		{
			this.myMission = theMission;
			this.ScenarioContext = theScen;
			foreach (Side side in this.ScenarioContext.method_44())
			{
				try
				{
					IEnumerator<Mission> enumerator = side.method_35().GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (Operators.CompareString(enumerator.Current.string_0, this.myMission.string_0, false) == 0)
						{
							this.mySide = side;
							break;
						}
					}
				}
				finally
				{
					IEnumerator<Mission> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x000102EB File Offset: 0x0000E4EB
		[Attribute2]
		public object __obj
		{
			get
			{
				return this.myMission;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x000102F3 File Offset: 0x0000E4F3
		[Attribute2]
		public string guid
		{
			get
			{
				return this.myMission.string_0;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00010300 File Offset: 0x0000E500
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x0001030D File Offset: 0x0000E50D
		[Attribute2]
		public string name
		{
			get
			{
				return this.myMission.Name;
			}
			set
			{
				this.myMission.Name = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0001031B File Offset: 0x0000E51B
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x00248CCC File Offset: 0x00246ECC
		[Attribute2]
		public object isactive
		{
			get
			{
				return this.myMission.method_10(this.ScenarioContext) == Mission.Enum89.const_0;
			}
			set
			{
				try
				{
					bool? flag = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(value));
					if (flag != null)
					{
						bool? flag2 = flag;
						if (((flag2 != null) ? new bool?(flag2.GetValueOrDefault()) : null).GetValueOrDefault())
						{
							this.myMission.method_11(this.ScenarioContext, Mission.Enum89.const_0);
						}
						else
						{
							this.myMission.method_11(this.ScenarioContext, Mission.Enum89.const_1);
						}
					}
				}
				catch (Exception ex)
				{
					throw new Exception3(ex.Message);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x00010336 File Offset: 0x0000E536
		[Attribute2]
		public string side
		{
			get
			{
				return this.mySide.method_51();
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00248D68 File Offset: 0x00246F68
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00248D90 File Offset: 0x00246F90
		[Attribute2]
		public string endtime
		{
			get
			{
				return this.myMission.method_27().ToString();
			}
			set
			{
				try
				{
					if (value.Length > 0)
					{
						this.myMission.method_28(new DateTime?(Conversions.ToDate(value)), this.ScenarioContext);
					}
					else
					{
						this.myMission.method_28(null, this.ScenarioContext);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x00248DFC File Offset: 0x00246FFC
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00248E24 File Offset: 0x00247024
		[Attribute2]
		public string starttime
		{
			get
			{
				return this.myMission.method_24().ToString();
			}
			set
			{
				try
				{
					if (value.Length > 0)
					{
						this.myMission.method_25(new DateTime?(Conversions.ToDate(value)), this.ScenarioContext);
					}
					else
					{
						this.myMission.method_25(null, this.ScenarioContext);
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x00010343 File Offset: 0x0000E543
		[Attribute2]
		public Mission._MissionClass type
		{
			get
			{
				return this.myMission._MissionClass_0;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00010350 File Offset: 0x0000E550
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x00010363 File Offset: 0x0000E563
		[Attribute2]
		public object subtype
		{
			get
			{
				return this.myMission.vmethod_5(this.ScenarioContext);
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_Set.");
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x0001036F File Offset: 0x0000E56F
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x00248E90 File Offset: 0x00247090
		[Attribute2]
		public object SISH
		{
			get
			{
				return this.myMission.bool_11;
			}
			set
			{
				this.myMission.bool_11 = LuaUtility.smethod_10(RuntimeHelpers.GetObjectValue(value)).Value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x000102EB File Offset: 0x0000E4EB
		[Attribute2]
		public object __mission
		{
			get
			{
				return this.myMission;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x00248EBC File Offset: 0x002470BC
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00010363 File Offset: 0x0000E563
		[Attribute2]
		public LuaTable unitlist
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				List<ActiveUnit> list = new List<ActiveUnit>();
				list = this.myMission.method_15(this.ScenarioContext);
				int num = 1;
				try
				{
					foreach (ActiveUnit activeUnit in list)
					{
						luaTable[num] = activeUnit.string_0;
						num++;
					}
				}
				finally
				{
					List<ActiveUnit>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_Set.");
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x00248F44 File Offset: 0x00247144
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x00010363 File Offset: 0x0000E563
		[Attribute2]
		public LuaTable targetlist
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				HashSet<Unit> hashSet = new HashSet<Unit>();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.Strike)
				{
					hashSet = ((Strike)this.myMission).hashSet_0;
					int num = 1;
					try
					{
						foreach (Unit unit in hashSet)
						{
							luaTable[num] = unit.string_0;
							num++;
						}
					}
					finally
					{
						HashSet<Unit>.Enumerator enumerator;
						enumerator.Dispose();
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_Set.");
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x00248FD8 File Offset: 0x002471D8
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable aar
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				Doctrine.Enum56? @enum = null;
				@enum = this.myMission.doctrine_0.method_152(this.ScenarioContext, false, false, false, false);
				if (@enum != null)
				{
					luaTable["Doctrine_UseReplenishment"] = @enum.ToString();
				}
				foreach (string text in Class461.string_0)
				{
					uint num = Class582.smethod_0(text);
					if (num <= 1688531320U)
					{
						if (num <= 721363522U)
						{
							if (num != 620569374U)
							{
								if (num == 721363522U)
								{
									if (Operators.CompareString(text, "TankerMaxDistance_Airborne", false) == 0)
									{
										if (this.myMission.int_6 < 1000)
										{
											luaTable[text] = this.myMission.int_6;
										}
										else
										{
											luaTable[text] = "internal";
										}
									}
								}
							}
							else if (Operators.CompareString(text, "TankerMinNumber_Airborne", false) == 0 && this.myMission.tankerMethod_0 == Mission.TankerMethod.Mission)
							{
								luaTable[text] = this.myMission.int_2;
							}
						}
						else if (num != 882301358U)
						{
							if (num != 1025497782U)
							{
								if (num == 1688531320U)
								{
									if (Operators.CompareString(text, "TankerMinNumber_Station", false) == 0 && this.myMission.tankerMethod_0 == Mission.TankerMethod.Mission)
									{
										luaTable[text] = this.myMission.int_3;
									}
								}
							}
							else if (Operators.CompareString(text, "TankerMinNumber_Total", false) == 0 && this.myMission.tankerMethod_0 == Mission.TankerMethod.Mission)
							{
								luaTable[text] = this.myMission.int_1;
							}
						}
						else if (Operators.CompareString(text, "LaunchMissionWithoutTankersInPlace", false) == 0 && this.myMission.tankerMethod_0 == Mission.TankerMethod.Mission)
						{
							luaTable[text] = this.myMission.bool_17;
						}
					}
					else if (num <= 2435049132U)
					{
						if (num != 2367170728U)
						{
							if (num == 2435049132U)
							{
								if (Operators.CompareString(text, "TankerMissionList", false) == 0 && this.myMission.tankerMethod_0 == Mission.TankerMethod.Mission)
								{
									LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
									try
									{
										foreach (Mission mission in this.myMission.list_4)
										{
											luaTable2[1] = mission.Name;
										}
									}
									finally
									{
										List<Mission>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									luaTable[text] = luaTable2;
								}
							}
						}
						else if (Operators.CompareString(text, "FuelQtyToStartLookingForTanker_Airborne", false) == 0)
						{
							luaTable[text] = this.myMission.int_5;
						}
					}
					else if (num != 3749943133U)
					{
						if (num != 3802618614U)
						{
							if (num == 4100651282U)
							{
								if (Operators.CompareString(text, "MaxReceiversInQueuePerTanker_Airborne", false) == 0)
								{
									luaTable[text] = this.myMission.int_4;
								}
							}
						}
						else if (Operators.CompareString(text, "TankerFollowsReceivers", false) == 0)
						{
							luaTable[text] = this.myMission.bool_18;
						}
					}
					else if (Operators.CompareString(text, "TankerUsage", false) == 0)
					{
						luaTable[text] = this.myMission.tankerMethod_0.ToString();
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0024938C File Offset: 0x0024758C
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable ferrymission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.Ferry)
				{
					FerryMission ferryMission = (FerryMission)this.myMission;
					foreach (string text in Class461.string_7)
					{
						uint num = Class582.smethod_0(text);
						if (num <= 933087157U)
						{
							if (num != 486744163U)
							{
								if (num != 543863533U)
								{
									if (num == 933087157U)
									{
										if (Operators.CompareString(text, "FerryTerrainFollowingAircraft", false) == 0)
										{
											ferryMission.bool_22.ToString();
										}
									}
								}
								else if (Operators.CompareString(text, "FerryBehavior", false) == 0)
								{
									luaTable[text] = ferryMission.method_65().ToString();
								}
							}
							else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
							{
								luaTable[text] = ferryMission.bool_12.ToString();
							}
						}
						else if (num <= 3088063337U)
						{
							if (num != 2487526210U)
							{
								if (num == 3088063337U)
								{
									if (Operators.CompareString(text, "FerryThrottleAircraft", false) == 0)
									{
										luaTable[text] = ferryMission.nullable_4.ToString();
									}
								}
							}
							else if (Operators.CompareString(text, "FlightSize", false) == 0)
							{
								luaTable[text] = ferryMission._FlightSize_0.ToString();
							}
						}
						else if (num != 3838663019U)
						{
							if (num == 3875984603U)
							{
								if (Operators.CompareString(text, "FerryAltitudeAircraft", false) == 0)
								{
									luaTable[text] = ferryMission.nullable_5.ToString();
								}
							}
						}
						else if (Operators.CompareString(text, "MinAircraftReq", false) == 0)
						{
							luaTable[text] = ferryMission._FlightQty_0.ToString();
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0024957C File Offset: 0x0024777C
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable mineclearmission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.MineClearing)
				{
					Class341 @class = (Class341)this.myMission;
					foreach (string text in Class461.string_5)
					{
						uint num = Class582.smethod_0(text);
						if (num <= 1723673953U)
						{
							if (num <= 919337238U)
							{
								if (num <= 571839996U)
								{
									if (num != 486744163U)
									{
										if (num == 571839996U)
										{
											if (Operators.CompareString(text, "StationDepthSubmarine", false) == 0)
											{
												luaTable[text] = @class.nullable_9;
											}
										}
									}
									else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
									{
										luaTable[text] = @class.bool_12;
									}
								}
								else if (num != 589144192U)
								{
									if (num == 919337238U)
									{
										if (Operators.CompareString(text, "OneThirdRule", false) == 0)
										{
											luaTable[text] = @class.bool_22;
										}
									}
								}
								else if (Operators.CompareString(text, "TransitThrottleSubmarine", false) == 0)
								{
									luaTable[text] = @class.throttle_0;
								}
							}
							else if (num <= 1082283198U)
							{
								if (num != 1060493923U)
								{
									if (num == 1082283198U)
									{
										if (Operators.CompareString(text, "UseGroupSize", false) == 0)
										{
											luaTable[text] = @class.bool_13;
										}
									}
								}
								else if (Operators.CompareString(text, "StationAltitudeAircraft", false) == 0)
								{
									luaTable[text] = @class.nullable_7;
								}
							}
							else if (num != 1271533277U)
							{
								if (num != 1304453504U)
								{
									if (num == 1723673953U)
									{
										if (Operators.CompareString(text, "StationThrottleShip", false) == 0)
										{
											luaTable[text] = @class.throttle_3;
										}
									}
								}
								else if (Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
								{
									luaTable[text] = @class.nullable_6;
								}
							}
							else if (Operators.CompareString(text, "StationTerrainFollowingAircraft", false) == 0)
							{
								luaTable[text] = @class.bool_24;
							}
						}
						else if (num <= 3161091587U)
						{
							if (num <= 2251788647U)
							{
								if (num != 1971082657U)
								{
									if (num == 2251788647U)
									{
										if (Operators.CompareString(text, "Zone", false) == 0)
										{
											LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
											int num2 = 1;
											try
											{
												foreach (ReferencePoint referencePoint in @class.list_5)
												{
													LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
													luaTable3["name"] = referencePoint.Name;
													luaTable2[num2] = luaTable3;
													num2++;
												}
											}
											finally
											{
												List<ReferencePoint>.Enumerator enumerator;
												((IDisposable)enumerator).Dispose();
											}
											luaTable[text] = luaTable2;
										}
									}
								}
								else if (Operators.CompareString(text, "StationThrottleSubmarine", false) == 0)
								{
									luaTable[text] = @class.throttle_1;
								}
							}
							else if (num != 2487526210U)
							{
								if (num != 2895834706U)
								{
									if (num == 3161091587U)
									{
										if (Operators.CompareString(text, "TransitDepthSubmarine", false) == 0)
										{
											luaTable[text] = @class.nullable_8;
										}
									}
								}
								else if (Operators.CompareString(text, "TransitThrottleShip", false) == 0)
								{
									luaTable[text] = @class.throttle_2;
								}
							}
							else if (Operators.CompareString(text, "FlightSize", false) == 0)
							{
								luaTable[text] = @class._FlightSize_0.ToString();
							}
						}
						else if (num <= 3359711974U)
						{
							if (num != 3248436129U)
							{
								if (num == 3359711974U)
								{
									if (Operators.CompareString(text, "TransitTerrainFollowingAircraft", false) == 0)
									{
										luaTable[text] = @class.bool_23;
									}
								}
							}
							else if (Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
							{
								luaTable[text] = @class.nullable_5;
							}
						}
						else if (num != 3539526598U)
						{
							if (num != 3838663019U)
							{
								if (num == 3863701925U)
								{
									if (Operators.CompareString(text, "GroupSize", false) == 0)
									{
										luaTable[text] = @class._GroupSize_0.ToString();
									}
								}
							}
							else if (Operators.CompareString(text, "MinAircraftReq", false) == 0)
							{
								luaTable[text] = @class._FlightQty_0.ToString();
							}
						}
						else if (Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
						{
							luaTable[text] = @class.nullable_4;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x00249A90 File Offset: 0x00247C90
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable minemission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.Mining)
				{
					Class340 @class = (Class340)this.myMission;
					foreach (string text in Class461.string_4)
					{
						uint num = Class582.smethod_0(text);
						if (num <= 1971082657U)
						{
							if (num <= 1060493923U)
							{
								if (num <= 571839996U)
								{
									if (num != 486744163U)
									{
										if (num == 571839996U)
										{
											if (Operators.CompareString(text, "StationDepthSubmarine", false) == 0)
											{
												luaTable[text] = @class.nullable_9;
											}
										}
									}
									else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
									{
										luaTable[text] = @class.bool_12;
									}
								}
								else if (num != 589144192U)
								{
									if (num != 919337238U)
									{
										if (num == 1060493923U)
										{
											if (Operators.CompareString(text, "StationAltitudeAircraft", false) == 0)
											{
												luaTable[text] = @class.nullable_7;
											}
										}
									}
									else if (Operators.CompareString(text, "OneThirdRule", false) == 0)
									{
										luaTable[text] = @class.bool_22;
									}
								}
								else if (Operators.CompareString(text, "TransitThrottleSubmarine", false) == 0)
								{
									luaTable[text] = @class.throttle_0;
								}
							}
							else if (num <= 1271533277U)
							{
								if (num != 1082283198U)
								{
									if (num == 1271533277U)
									{
										if (Operators.CompareString(text, "StationTerrainFollowingAircraft", false) == 0)
										{
											luaTable[text] = @class.bool_24;
										}
									}
								}
								else if (Operators.CompareString(text, "UseGroupSize", false) == 0)
								{
									luaTable[text] = @class.bool_13;
								}
							}
							else if (num != 1304453504U)
							{
								if (num != 1723673953U)
								{
									if (num == 1971082657U)
									{
										if (Operators.CompareString(text, "StationThrottleSubmarine", false) == 0)
										{
											luaTable[text] = @class.throttle_1;
										}
									}
								}
								else if (Operators.CompareString(text, "StationThrottleShip", false) == 0)
								{
									luaTable[text] = @class.throttle_3;
								}
							}
							else if (Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
							{
								luaTable[text] = @class.nullable_6;
							}
						}
						else if (num <= 3161091587U)
						{
							if (num <= 2395892618U)
							{
								if (num != 2251788647U)
								{
									if (num == 2395892618U)
									{
										if (Operators.CompareString(text, "ArmingDelay", false) == 0)
										{
											TimeSpan timeSpan = TimeSpan.FromSeconds((double)@class.long_0);
											string value = string.Format("{0:D2}d:{1:D2}h:{2:D2}m:{3:D2}s", new object[]
											{
												timeSpan.Days,
												timeSpan.Hours,
												timeSpan.Minutes,
												timeSpan.Seconds
											});
											luaTable[text] = value;
										}
									}
								}
								else if (Operators.CompareString(text, "Zone", false) == 0)
								{
									LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
									int num2 = 1;
									try
									{
										foreach (ReferencePoint referencePoint in @class.list_5)
										{
											LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
											luaTable3["name"] = referencePoint.Name;
											luaTable2[num2] = luaTable3;
											num2++;
										}
									}
									finally
									{
										List<ReferencePoint>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									luaTable[text] = luaTable2;
								}
							}
							else if (num != 2487526210U)
							{
								if (num != 2895834706U)
								{
									if (num == 3161091587U)
									{
										if (Operators.CompareString(text, "TransitDepthSubmarine", false) == 0)
										{
											luaTable[text] = @class.nullable_8;
										}
									}
								}
								else if (Operators.CompareString(text, "TransitThrottleShip", false) == 0)
								{
									luaTable[text] = @class.throttle_2;
								}
							}
							else if (Operators.CompareString(text, "FlightSize", false) == 0)
							{
								luaTable[text] = @class._FlightSize_0.ToString();
							}
						}
						else if (num <= 3359711974U)
						{
							if (num != 3248436129U)
							{
								if (num == 3359711974U)
								{
									if (Operators.CompareString(text, "TransitTerrainFollowingAircraft", false) == 0)
									{
										luaTable[text] = @class.bool_23;
									}
								}
							}
							else if (Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
							{
								luaTable[text] = @class.nullable_5;
							}
						}
						else if (num != 3539526598U)
						{
							if (num != 3838663019U)
							{
								if (num == 3863701925U)
								{
									if (Operators.CompareString(text, "GroupSize", false) == 0)
									{
										luaTable[text] = @class._GroupSize_0.ToString();
									}
								}
							}
							else if (Operators.CompareString(text, "MinAircraftReq", false) == 0)
							{
								luaTable[text] = @class._FlightQty_0.ToString();
							}
						}
						else if (Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
						{
							luaTable[text] = @class.nullable_4;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0024A02C File Offset: 0x0024822C
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable supportmission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.Support)
				{
					Class344 @class = (Class344)this.myMission;
					foreach (string text in Class461.string_1)
					{
						string text2 = text.ToLower();
						uint num = Class582.smethod_0(text2);
						if (num <= 2399659585U)
						{
							if (num <= 1105879077U)
							{
								if (num <= 631210358U)
								{
									if (num <= 63502304U)
									{
										if (num != 59825223U)
										{
											if (num == 63502304U)
											{
												if (Operators.CompareString(text2, "transitaltitudeaircraft", false) == 0)
												{
													luaTable[text] = @class.nullable_6;
												}
											}
										}
										else if (Operators.CompareString(text2, "zone", false) == 0)
										{
											LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
											int num2 = 1;
											try
											{
												foreach (ReferencePoint referencePoint in @class.list_5)
												{
													LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
													luaTable3["name"] = referencePoint.Name;
													luaTable2[num2] = luaTable3;
													num2++;
												}
											}
											finally
											{
												List<ReferencePoint>.Enumerator enumerator;
												((IDisposable)enumerator).Dispose();
											}
											luaTable[text] = luaTable2;
										}
									}
									else if (num != 545306078U)
									{
										if (num == 631210358U)
										{
											if (Operators.CompareString(text2, "onethirdrule", false) == 0)
											{
												luaTable[text] = @class.bool_22;
											}
										}
									}
									else if (Operators.CompareString(text2, "usegroupsize", false) == 0)
									{
										luaTable[text] = @class.bool_13;
									}
								}
								else if (num <= 898087811U)
								{
									if (num != 866315302U)
									{
										if (num == 898087811U)
										{
											if (Operators.CompareString(text2, "useflightsize", false) == 0)
											{
												luaTable[text] = @class.bool_12;
											}
										}
									}
									else if (Operators.CompareString(text2, "transitthrottleaircraft", false) == 0)
									{
										luaTable[text] = @class.nullable_4;
									}
								}
								else if (num != 1064479965U)
								{
									if (num == 1105879077U)
									{
										if (Operators.CompareString(text2, "groupsize", false) == 0)
										{
											luaTable[text] = @class._GroupSize_0.ToString();
										}
									}
								}
								else if (Operators.CompareString(text2, "stationterrainfollowingaircraft", false) == 0)
								{
									luaTable[text] = @class.bool_26;
								}
							}
							else if (num <= 1625231388U)
							{
								if (num <= 1291369971U)
								{
									if (num != 1198085606U)
									{
										if (num == 1291369971U)
										{
											if (Operators.CompareString(text2, "looptype", false) == 0)
											{
												luaTable[text] = @class.enum108_0;
											}
										}
									}
									else if (Operators.CompareString(text2, "transitterrainfollowingaircraft", false) == 0)
									{
										luaTable[text] = @class.bool_25;
									}
								}
								else if (num != 1396751297U)
								{
									if (num == 1625231388U)
									{
										if (Operators.CompareString(text2, "stationdepthsubmarine", false) == 0)
										{
											luaTable[text] = @class.nullable_9;
										}
									}
								}
								else if (Operators.CompareString(text2, "stationthrottlesubmarine", false) == 0)
								{
									luaTable[text] = @class.throttle_1;
								}
							}
							else if (num <= 1875569072U)
							{
								if (num != 1654031875U)
								{
									if (num == 1875569072U)
									{
										if (Operators.CompareString(text2, "ccstationtime", false) == 0)
										{
											luaTable[text] = @class.enum97_0;
										}
									}
								}
								else if (Operators.CompareString(text2, "stationaltitudeaircraft", false) == 0)
								{
									luaTable[text] = @class.nullable_7;
								}
							}
							else if (num != 2192295490U)
							{
								if (num == 2399659585U)
								{
									if (Operators.CompareString(text2, "stationthrottleaircraft", false) == 0)
									{
										luaTable[text] = @class.nullable_5;
									}
								}
							}
							else if (Operators.CompareString(text2, "flightsize", false) == 0)
							{
								luaTable[text] = @class._FlightSize_0.ToString();
							}
						}
						else if (num <= 3666366732U)
						{
							if (num <= 2636310504U)
							{
								if (num <= 2553584699U)
								{
									if (num != 2511926636U)
									{
										if (num == 2553584699U)
										{
											if (Operators.CompareString(text2, "tankeronetime", false) == 0)
											{
												luaTable[text] = @class.bool_24;
											}
										}
									}
									else if (Operators.CompareString(text2, "ccenable", false) == 0)
									{
										luaTable[text] = @class.bool_28;
									}
								}
								else if (num != 2605425760U)
								{
									if (num == 2636310504U)
									{
										if (Operators.CompareString(text2, "onetimeonly", false) == 0)
										{
											luaTable[text] = @class.bool_23;
										}
									}
								}
								else if (Operators.CompareString(text2, "transitthrottlesubmarine", false) == 0)
								{
									luaTable[text] = @class.throttle_0;
								}
							}
							else if (num <= 3467617746U)
							{
								if (num != 3454392517U)
								{
									if (num == 3467617746U)
									{
										if (Operators.CompareString(text2, "ccallowqra", false) == 0)
										{
											luaTable[text] = @class.bool_29;
										}
									}
								}
								else if (Operators.CompareString(text2, "transitthrottlefacility", false) == 0)
								{
									luaTable[text] = @class.throttle_4;
								}
							}
							else if (num != 3530577340U)
							{
								if (num == 3666366732U)
								{
									if (Operators.CompareString(text2, "ccflightgenmethod", false) == 0)
									{
										luaTable[text] = @class.enum96_1;
									}
								}
							}
							else if (Operators.CompareString(text2, "onstation", false) == 0)
							{
								luaTable[text] = @class.int_7;
							}
						}
						else if (num <= 3910377814U)
						{
							if (num <= 3747968204U)
							{
								if (num != 3738186982U)
								{
									if (num == 3747968204U)
									{
										if (Operators.CompareString(text2, "stationthrottleshipfacility", false) == 0)
										{
											luaTable[text] = @class.throttle_5;
										}
									}
								}
								else if (Operators.CompareString(text2, "tankermaxreceivers", false) == 0)
								{
									luaTable[text] = @class.int_8;
								}
							}
							else if (num != 3748798743U)
							{
								if (num == 3910377814U)
								{
									if (Operators.CompareString(text2, "ccoverlap", false) == 0)
									{
										luaTable[text] = @class.enum98_0;
									}
								}
							}
							else if (Operators.CompareString(text2, "activeemcon", false) == 0)
							{
								luaTable[text] = @class.bool_27;
							}
						}
						else if (num <= 4160258891U)
						{
							if (num != 3997169842U)
							{
								if (num == 4160258891U)
								{
									if (Operators.CompareString(text2, "minaircraftreq", false) == 0)
									{
										luaTable[text] = @class._FlightQty_0.ToString();
									}
								}
							}
							else if (Operators.CompareString(text2, "transitthrottleship", false) == 0)
							{
								luaTable[text] = @class.throttle_2;
							}
						}
						else if (num != 4176547107U)
						{
							if (num == 4272266753U)
							{
								if (Operators.CompareString(text2, "stationthrottleship", false) == 0)
								{
									luaTable[text] = @class.throttle_3;
								}
							}
						}
						else if (Operators.CompareString(text2, "transitdepthsubmarine", false) == 0)
						{
							luaTable[text] = @class.nullable_8;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0024A858 File Offset: 0x00248A58
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable patrolmission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.Patrol)
				{
					Class343 @class = (Class343)this.myMission;
					foreach (string text in Class461.string_6)
					{
						string text2 = text.ToLower();
						uint num = Class582.smethod_0(text2);
						if (num <= 1654031875U)
						{
							if (num <= 715622684U)
							{
								if (num <= 212621024U)
								{
									if (num <= 63502304U)
									{
										if (num != 20317811U)
										{
											if (num == 63502304U)
											{
												if (Operators.CompareString(text2, "transitaltitudeaircraft", false) == 0)
												{
													luaTable[text] = @class.imethod_6();
												}
											}
										}
										else if (Operators.CompareString(text2, "attackthrottleaircraft", false) == 0)
										{
											luaTable[text] = @class.imethod_4();
										}
									}
									else if (num != 90090006U)
									{
										if (num == 212621024U)
										{
											if (Operators.CompareString(text2, "attackdistanceship", false) == 0)
											{
												luaTable[text] = @class.imethod_40();
											}
										}
									}
									else if (Operators.CompareString(text2, "wingmanengagedistance", false) == 0)
									{
										luaTable[text] = @class.int_8;
									}
								}
								else if (num <= 282087807U)
								{
									if (num != 230658312U)
									{
										if (num == 282087807U)
										{
											if (Operators.CompareString(text2, "attackthrottleship", false) == 0)
											{
												luaTable[text] = @class.imethod_38();
											}
										}
									}
									else if (Operators.CompareString(text2, "flightstoinvestigate", false) == 0)
									{
										luaTable[text] = @class._FlightQty_1;
									}
								}
								else if (num != 545306078U)
								{
									if (num != 631210358U)
									{
										if (num == 715622684U)
										{
											if (Operators.CompareString(text2, "prosecutionzone", false) == 0)
											{
												LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
												int num2 = 1;
												try
												{
													foreach (ReferencePoint referencePoint in @class.list_15)
													{
														LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
														luaTable3["name"] = referencePoint.Name;
														luaTable2[num2] = luaTable3;
														num2++;
													}
												}
												finally
												{
													List<ReferencePoint>.Enumerator enumerator;
													((IDisposable)enumerator).Dispose();
												}
												luaTable[text] = luaTable2;
											}
										}
									}
									else if (Operators.CompareString(text2, "onethirdrule", false) == 0)
									{
										luaTable[text] = @class.bool_22;
									}
								}
								else if (Operators.CompareString(text2, "usegroupsize", false) == 0)
								{
									luaTable[text] = @class.bool_13;
								}
							}
							else if (num <= 1105879077U)
							{
								if (num <= 898087811U)
								{
									if (num != 866315302U)
									{
										if (num == 898087811U)
										{
											if (Operators.CompareString(text2, "useflightsize", false) == 0)
											{
												luaTable[text] = @class.bool_12;
											}
										}
									}
									else if (Operators.CompareString(text2, "transitthrottleaircraft", false) == 0)
									{
										luaTable[text] = @class.imethod_0();
									}
								}
								else if (num != 968925166U)
								{
									if (num != 1064479965U)
									{
										if (num == 1105879077U)
										{
											if (Operators.CompareString(text2, "groupsize", false) == 0)
											{
												luaTable[text] = @class._GroupSize_0.ToString();
											}
										}
									}
									else if (Operators.CompareString(text2, "stationterrainfollowingaircraft", false) == 0)
									{
										luaTable[text] = @class.imethod_16();
									}
								}
								else if (Operators.CompareString(text2, "groupmemberengagedistance", false) == 0)
								{
									luaTable[text] = @class.int_9;
								}
							}
							else if (num <= 1221743319U)
							{
								if (num != 1198085606U)
								{
									if (num == 1221743319U)
									{
										if (Operators.CompareString(text2, "attackthrottlesubmarine", false) == 0)
										{
											luaTable[text] = @class.imethod_24();
										}
									}
								}
								else if (Operators.CompareString(text2, "transitterrainfollowingaircraft", false) == 0)
								{
									luaTable[text] = @class.imethod_14();
								}
							}
							else if (num != 1396751297U)
							{
								if (num != 1625231388U)
								{
									if (num == 1654031875U)
									{
										if (Operators.CompareString(text2, "stationaltitudeaircraft", false) == 0)
										{
											luaTable[text] = @class.imethod_8();
										}
									}
								}
								else if (Operators.CompareString(text2, "stationdepthsubmarine", false) == 0)
								{
									luaTable[text] = @class.imethod_28();
								}
							}
							else if (Operators.CompareString(text2, "stationthrottlesubmarine", false) == 0)
							{
								luaTable[text] = @class.imethod_22();
							}
						}
						else if (num <= 2676000094U)
						{
							if (num <= 2192295490U)
							{
								if (num <= 2011297067U)
								{
									if (num != 1689141883U)
									{
										if (num == 2011297067U)
										{
											if (Operators.CompareString(text2, "attacktaltitudeaircraft", false) == 0)
											{
												luaTable[text] = @class.imethod_10();
											}
										}
									}
									else if (Operators.CompareString(text2, "checkopa", false) == 0)
									{
										luaTable[text] = @class.method_66(this.ScenarioContext);
									}
								}
								else if (num != 2085539267U)
								{
									if (num != 2180078202U)
									{
										if (num == 2192295490U)
										{
											if (Operators.CompareString(text2, "flightsize", false) == 0)
											{
												luaTable[text] = @class._FlightSize_0.ToString();
											}
										}
									}
									else if (Operators.CompareString(text2, "flightstoengage", false) == 0)
									{
										luaTable[text] = @class._FlightQty_2;
									}
								}
								else if (Operators.CompareString(text2, "attackterrainfollowingaircraft", false) == 0)
								{
									luaTable[text] = @class.imethod_18();
								}
							}
							else if (num <= 2256252866U)
							{
								if (num != 2238710705U)
								{
									if (num == 2256252866U)
									{
										if (Operators.CompareString(text2, "boatstoengage", false) == 0)
										{
											luaTable[text] = @class.enum100_1;
										}
									}
								}
								else if (Operators.CompareString(text2, "patrolzone", false) == 0)
								{
									LuaTable luaTable4 = LuaSandBox.Singleton().CreateTable();
									int num3 = 1;
									try
									{
										foreach (ReferencePoint referencePoint2 in @class.list_5)
										{
											LuaTable luaTable5 = LuaSandBox.Singleton().CreateTable();
											luaTable5["name"] = referencePoint2.Name;
											luaTable4[num3] = luaTable5;
											num3++;
										}
									}
									finally
									{
										List<ReferencePoint>.Enumerator enumerator2;
										((IDisposable)enumerator2).Dispose();
									}
									luaTable[text] = luaTable4;
								}
							}
							else if (num != 2399659585U)
							{
								if (num != 2605425760U)
								{
									if (num == 2676000094U)
									{
										if (Operators.CompareString(text2, "attackdepthsubmarine", false) == 0)
										{
											luaTable[text] = @class.imethod_30();
										}
									}
								}
								else if (Operators.CompareString(text2, "transitthrottlesubmarine", false) == 0)
								{
									luaTable[text] = @class.imethod_20();
								}
							}
							else if (Operators.CompareString(text2, "stationthrottleaircraft", false) == 0)
							{
								luaTable[text] = @class.imethod_2();
							}
						}
						else if (num <= 3748798743U)
						{
							if (num <= 3317149648U)
							{
								if (num != 3100686965U)
								{
									if (num == 3317149648U)
									{
										if (Operators.CompareString(text2, "attackdistanceaircraft", false) == 0)
										{
											luaTable[text] = @class.imethod_12();
										}
									}
								}
								else if (Operators.CompareString(text2, "checkwwr", false) == 0)
								{
									luaTable[text] = @class.method_68(this.ScenarioContext);
								}
							}
							else if (num != 3530577340U)
							{
								if (num != 3596321824U)
								{
									if (num == 3748798743U)
									{
										if (Operators.CompareString(text2, "activeemcon", false) == 0)
										{
											luaTable[text] = @class.bool_25;
										}
									}
								}
								else if (Operators.CompareString(text2, "boatstoinvestigate", false) == 0)
								{
									luaTable[text] = @class.enum100_0;
								}
							}
							else if (Operators.CompareString(text2, "onstation", false) == 0)
							{
								luaTable[text] = @class.int_7;
							}
						}
						else if (num <= 4034015606U)
						{
							if (num != 3997169842U)
							{
								if (num == 4034015606U)
								{
									if (Operators.CompareString(text2, "attackdistancesubmarine", false) == 0)
									{
										luaTable[text] = @class.imethod_32();
									}
								}
							}
							else if (Operators.CompareString(text2, "transitthrottleship", false) == 0)
							{
								luaTable[text] = @class.imethod_34();
							}
						}
						else if (num != 4160258891U)
						{
							if (num != 4176547107U)
							{
								if (num == 4272266753U)
								{
									if (Operators.CompareString(text2, "stationthrottleship", false) == 0)
									{
										luaTable[text] = @class.imethod_36();
									}
								}
							}
							else if (Operators.CompareString(text2, "transitdepthsubmarine", false) == 0)
							{
								luaTable[text] = @class.imethod_26();
							}
						}
						else if (Operators.CompareString(text2, "minaircraftreq", false) == 0)
						{
							luaTable[text] = @class._FlightQty_0.ToString();
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0024B274 File Offset: 0x00249474
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable strikemission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.Strike)
				{
					Strike strike = (Strike)this.myMission;
					foreach (string text in Class461.string_2)
					{
						string text2 = text.ToLower();
						uint num = Class582.smethod_0(text2);
						if (num <= 968925166U)
						{
							if (num <= 337644276U)
							{
								if (num <= 113274565U)
								{
									if (num != 90090006U)
									{
										if (num == 113274565U)
										{
											if (Operators.CompareString(text2, "escortminshooter", false) == 0)
											{
												luaTable2[text] = strike._FlightQty_1.ToString();
											}
										}
									}
									else if (Operators.CompareString(text2, "wingmanengagedistance", false) == 0)
									{
										luaTable2[text] = strike.int_8;
									}
								}
								else if (num != 230658312U)
								{
									if (num == 337644276U)
									{
										if (Operators.CompareString(text2, "escortmaxnonshooter", false) == 0)
										{
											luaTable2[text] = strike._FlightQty_5.ToString();
										}
									}
								}
								else if (Operators.CompareString(text2, "flightstoinvestigate", false) == 0)
								{
									luaTable2[text] = strike._FlightQty_6;
								}
							}
							else if (num <= 916594414U)
							{
								if (num != 391355100U)
								{
									if (num == 916594414U)
									{
										if (Operators.CompareString(text2, "escortusegroupsize", false) == 0)
										{
											luaTable2[text] = strike.bool_29;
										}
									}
								}
								else if (Operators.CompareString(text2, "escortresponseradius", false) == 0)
								{
									luaTable2[text] = strike.int_7;
								}
							}
							else if (num != 930113638U)
							{
								if (num == 968925166U)
								{
									if (Operators.CompareString(text2, "groupmemberengagedistance", false) == 0)
									{
										luaTable2[text] = strike.int_9;
									}
								}
							}
							else if (Operators.CompareString(text2, "escortminnonshooter", false) == 0)
							{
								luaTable2[text] = strike._FlightQty_2.ToString();
							}
						}
						else if (num <= 2180078202U)
						{
							if (num <= 1383610623U)
							{
								if (num != 1253303603U)
								{
									if (num == 1383610623U)
									{
										if (Operators.CompareString(text2, "escortflightsizenonshooter", false) == 0)
										{
											luaTable2[text] = strike._FlightSize_2.ToString();
										}
									}
								}
								else if (Operators.CompareString(text2, "escortuseflightsize", false) == 0)
								{
									luaTable2[text] = strike.bool_28;
								}
							}
							else if (num != 2095067157U)
							{
								if (num == 2180078202U)
								{
									if (Operators.CompareString(text2, "flightstoengage", false) == 0)
									{
										luaTable2[text] = strike._FlightQty_7;
									}
								}
							}
							else if (Operators.CompareString(text2, "escortgroupsize", false) == 0)
							{
								luaTable2[text] = strike._GroupSize_1.ToString();
							}
						}
						else if (num <= 2338132339U)
						{
							if (num != 2256252866U)
							{
								if (num == 2338132339U)
								{
									if (Operators.CompareString(text2, "escortmaxshooter", false) == 0)
									{
										luaTable2[text] = strike._FlightQty_4.ToString();
									}
								}
							}
							else if (Operators.CompareString(text2, "boatstoengage", false) == 0)
							{
								luaTable2[text] = strike.enum100_1;
							}
						}
						else if (num != 3596321824U)
						{
							if (num == 3769707274U && Operators.CompareString(text2, "escortflightsizeshooter", false) == 0)
							{
								luaTable2[text] = strike._FlightSize_1.ToString();
							}
						}
						else if (Operators.CompareString(text2, "boatstoinvestigate", false) == 0)
						{
							luaTable2[text] = strike.enum100_0;
						}
					}
					luaTable["Escort"] = luaTable2;
					luaTable2 = LuaSandBox.Singleton().CreateTable();
					foreach (string text3 in Class461.string_2)
					{
						uint num = Class582.smethod_0(text3);
						if (num <= 2481972861U)
						{
							if (num <= 665797815U)
							{
								if (num != 177780080U)
								{
									if (num != 470627500U)
									{
										if (num == 665797815U)
										{
											if (Operators.CompareString(text3, "strikegroupsize", false) == 0)
											{
												luaTable2[text3] = strike._GroupSize_0.ToString();
											}
										}
									}
									else if (Operators.CompareString(text3, "strikeflightsize", false) == 0)
									{
										luaTable2[text3] = strike._FlightSize_0.ToString();
									}
								}
								else if (Operators.CompareString(text3, "strikeautoplanner", false) == 0)
								{
									luaTable2[text3] = strike.bool_22;
								}
							}
							else if (num <= 1082788694U)
							{
								if (num != 995420619U)
								{
									if (num == 1082788694U)
									{
										if (Operators.CompareString(text3, "strikeonetimeonly", false) == 0)
										{
											luaTable2[text3] = strike.bool_25;
										}
									}
								}
								else if (Operators.CompareString(text3, "strikepreplan", false) == 0)
								{
									luaTable2[text3] = strike.bool_27;
								}
							}
							else if (num != 2423947335U)
							{
								if (num == 2481972861U)
								{
									if (Operators.CompareString(text3, "strikemaxdistship", false) == 0)
									{
										luaTable2[text3] = strike.int_13;
									}
								}
							}
							else if (Operators.CompareString(text3, "strikemindistship", false) == 0)
							{
								luaTable2[text3] = strike.int_12;
							}
						}
						else if (num <= 3460893597U)
						{
							if (num != 2514538215U)
							{
								if (num != 3084807255U)
								{
									if (num == 3460893597U)
									{
										if (Operators.CompareString(text3, "strikeminaircraftreq", false) == 0)
										{
											luaTable2[text3] = strike._FlightQty_0.ToString();
										}
									}
								}
								else if (Operators.CompareString(text3, "strikeminimumtrigger", false) == 0)
								{
									luaTable2[text3] = strike.postureStance_0;
								}
							}
							else if (Operators.CompareString(text3, "strikemax", false) == 0)
							{
								luaTable2[text3] = strike._FlightQty_3.ToString();
							}
						}
						else if (num <= 4032067080U)
						{
							if (num != 3873951469U)
							{
								if (num == 4032067080U)
								{
									if (Operators.CompareString(text3, "strikeusegroupsize", false) == 0)
									{
										luaTable2[text3] = strike.bool_13;
									}
								}
							}
							else if (Operators.CompareString(text3, "strikemaxdistaircraft", false) == 0)
							{
								luaTable2[text3] = strike.int_11;
							}
						}
						else if (num != 4173190637U)
						{
							if (num == 4270367851U)
							{
								if (Operators.CompareString(text3, "strikemindistaircraft", false) == 0)
								{
									luaTable2[text3] = strike.int_10;
								}
							}
						}
						else if (Operators.CompareString(text3, "strikeuseflightsize", false) == 0)
						{
							luaTable2[text3] = strike.bool_12;
						}
					}
					luaTable["Strike"] = luaTable2;
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0024BA0C File Offset: 0x00249C0C
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x00010381 File Offset: 0x0000E581
		[Attribute2]
		public LuaTable cargomission
		{
			get
			{
				LuaTable luaTable = LuaSandBox.Singleton().CreateTable();
				if (this.myMission._MissionClass_0 == Mission._MissionClass.Cargo)
				{
					Class338 @class = (Class338)this.myMission;
					foreach (string text in Class461.string_3)
					{
						uint num = Class582.smethod_0(text);
						if (num <= 1304453504U)
						{
							if (num <= 1060493923U)
							{
								if (num != 486744163U)
								{
									if (num == 1060493923U)
									{
										if (Operators.CompareString(text, "StationAltitudeAircraft", false) == 0)
										{
											luaTable[text] = @class.float_1;
										}
									}
								}
								else if (Operators.CompareString(text, "UseFlightSize", false) == 0)
								{
									luaTable[text] = @class.bool_12;
								}
							}
							else if (num != 1082283198U)
							{
								if (num == 1304453504U)
								{
									if (Operators.CompareString(text, "TransitAltitudeAircraft", false) == 0)
									{
										luaTable[text] = @class.float_0;
									}
								}
							}
							else if (Operators.CompareString(text, "UseGroupSize", false) == 0)
							{
								luaTable[text] = @class.bool_13;
							}
						}
						else if (num <= 2251788647U)
						{
							if (num != 1723673953U)
							{
								if (num == 2251788647U)
								{
									if (Operators.CompareString(text, "Zone", false) == 0)
									{
										LuaTable luaTable2 = LuaSandBox.Singleton().CreateTable();
										int num2 = 1;
										try
										{
											foreach (ReferencePoint referencePoint in @class.list_5)
											{
												LuaTable luaTable3 = LuaSandBox.Singleton().CreateTable();
												luaTable3["name"] = referencePoint.Name;
												luaTable2[num2] = luaTable3;
												num2++;
											}
										}
										finally
										{
											List<ReferencePoint>.Enumerator enumerator;
											((IDisposable)enumerator).Dispose();
										}
										luaTable[text] = luaTable2;
									}
								}
							}
							else if (Operators.CompareString(text, "StationThrottleShip", false) == 0)
							{
								luaTable[text] = @class.throttle_3;
							}
						}
						else if (num != 2895834706U)
						{
							if (num != 3248436129U)
							{
								if (num == 3539526598U && Operators.CompareString(text, "TransitThrottleAircraft", false) == 0)
								{
									luaTable[text] = @class.throttle_0;
								}
							}
							else if (Operators.CompareString(text, "StationThrottleAircraft", false) == 0)
							{
								luaTable[text] = @class.throttle_1;
							}
						}
						else if (Operators.CompareString(text, "TransitThrottleShip", false) == 0)
						{
							luaTable[text] = @class.throttle_2;
						}
					}
				}
				return luaTable;
			}
			set
			{
				throw new Exception3("Cannot set this property. Please use ScenEdit_SetMission().");
			}
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x0024BCD0 File Offset: 0x00249ED0
		[Attribute2]
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"mission {\r\n guid = '",
				this.guid,
				"', \r\n name = '",
				this.name,
				"', \r\n side = '",
				this.side,
				"', \r\n type = '",
				this.type.ToString(),
				"', \r\n subtype = '",
				this.subtype.ToString(),
				"', \r\n isactive = '",
				this.isactive.ToString(),
				"', \r\n starttime = '",
				this.starttime,
				"', \r\n endtime = '",
				this.endtime,
				"', \r\n SISH = '",
				this.SISH.ToString(),
				"', \r\n aar = '",
				this.aar.ToString(),
				"',\r\n unitlist = '",
				this.unitlist.ToString(),
				"',\r\n"
			}) + "}";
		}

		// Token: 0x04001CFD RID: 7421
		private Mission myMission;

		// Token: 0x04001CFE RID: 7422
		private Scenario ScenarioContext;

		// Token: 0x04001CFF RID: 7423
		private Side mySide;
	}
}
