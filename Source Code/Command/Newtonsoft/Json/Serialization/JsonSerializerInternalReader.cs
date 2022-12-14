using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ns31;
using ns32;
using ns33;
using ns34;
using ns35;
using ns5;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000D14 RID: 3348
	internal sealed class JsonSerializerInternalReader : Class2361
	{
		// Token: 0x06005792 RID: 22418 RVA: 0x0003812F File Offset: 0x0003632F
		public JsonSerializerInternalReader(Class2331 class2331_1) : base(class2331_1)
		{
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x00038138 File Offset: 0x00036338
		private Class2299 method_5(Type type_0)
		{
			if (type_0 == null)
			{
				return null;
			}
			return base.method_0().vmethod_23().imethod_0(type_0);
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00038150 File Offset: 0x00036350
		private Class2299 method_6(Type type_0, object object_0)
		{
			if (object_0 == null)
			{
				return this.method_5(type_0);
			}
			return base.method_0().vmethod_23().imethod_0(object_0.GetType());
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x00038173 File Offset: 0x00036373
		public object method_7(Class2263 class2263_0, Type type_0)
		{
			if (class2263_0 == null)
			{
				throw new ArgumentNullException("reader");
			}
			if (class2263_0.vmethod_1() == JsonToken.None && !class2263_0.vmethod_3())
			{
				return null;
			}
			return this.method_13(class2263_0, type_0, this.method_5(type_0));
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x000381A4 File Offset: 0x000363A4
		private Class2332 method_8()
		{
			if (this.class2332_0 == null)
			{
				this.class2332_0 = new Class2332(this);
			}
			return this.class2332_0;
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x000381C0 File Offset: 0x000363C0
		private Class2298 method_9()
		{
			if (this.class2298_0 == null)
			{
				this.class2298_0 = new Class2298(this.method_8());
			}
			return this.class2298_0;
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x003104A0 File Offset: 0x0030E6A0
		private Class2286 method_10(Class2263 class2263_0, Class2299 class2299_0)
		{
			Class2409.smethod_4(class2263_0, "reader");
			if (class2299_0 != null && class2299_0.method_0() == typeof(Class2288))
			{
				return Class2288.smethod_8(class2263_0);
			}
			Class2286 result;
			using (Class2276 @class = new Class2276())
			{
				@class.method_11(class2263_0);
				result = @class.method_23();
			}
			return result;
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x00310508 File Offset: 0x0030E708
		private Class2286 method_11(Class2263 class2263_0)
		{
			Class2409.smethod_4(class2263_0, "reader");
			Class2286 result;
			using (Class2276 @class = new Class2276())
			{
				@class.vmethod_1();
				if (class2263_0.vmethod_1() == JsonToken.PropertyName)
				{
					@class.method_12(class2263_0, class2263_0.vmethod_2() - 1);
				}
				else
				{
					@class.method_7();
				}
				result = @class.method_23();
			}
			return result;
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x00310570 File Offset: 0x0030E770
		private object method_12(Class2263 class2263_0, Class2353 class2353_0, object object_0, bool bool_0, object object_1)
		{
			Class2299 class2299_ = this.method_6(class2353_0.method_4(), object_1);
			Type type_ = class2353_0.method_4();
			Class2278 @class = this.method_15(class2299_, class2353_0.method_14());
			if (@class != null && @class.vmethod_3())
			{
				if (!bool_0 && object_0 != null && class2353_0.method_10())
				{
					object_1 = class2353_0.method_2().imethod_1(object_0);
				}
				return @class.vmethod_1(class2263_0, type_, object_1, this.method_8());
			}
			return this.method_14(class2263_0, type_, class2299_, class2353_0, object_1);
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x003105E8 File Offset: 0x0030E7E8
		private object method_13(Class2263 class2263_0, Type type_0, Class2299 class2299_0)
		{
			Class2278 @class = this.method_15(class2299_0, null);
			if (@class != null && @class.vmethod_3())
			{
				return @class.vmethod_1(class2263_0, type_0, null, this.method_8());
			}
			return this.method_14(class2263_0, type_0, class2299_0, null, null);
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00310624 File Offset: 0x0030E824
		private object method_14(Class2263 class2263_0, Type type_0, Class2299 class2299_0, Class2353 class2353_0, object object_0)
		{
			if (class2299_0 is Class2301)
			{
				return this.method_10(class2263_0, class2299_0);
			}
			for (;;)
			{
				switch (class2263_0.vmethod_1())
				{
				case JsonToken.StartObject:
					goto IL_71;
				case JsonToken.StartArray:
					goto IL_7F;
				case JsonToken.StartConstructor:
				case JsonToken.EndConstructor:
					goto IL_113;
				case JsonToken.Comment:
					if (class2263_0.vmethod_3())
					{
						continue;
					}
					goto IL_8E;
				case JsonToken.Raw:
					goto IL_99;
				case JsonToken.Integer:
				case JsonToken.Float:
				case JsonToken.Boolean:
				case JsonToken.Date:
				case JsonToken.Bytes:
					goto IL_121;
				case JsonToken.String:
					goto IL_AA;
				case JsonToken.Null:
				case JsonToken.Undefined:
					goto IL_D7;
				}
				break;
			}
			goto IL_F8;
			IL_71:
			return this.method_16(class2263_0, type_0, class2299_0, class2353_0, object_0);
			IL_7F:
			return this.method_19(class2263_0, type_0, class2299_0, class2353_0, object_0, null);
			IL_8E:
			throw new Exception28("Unexpected end when deserializing object.");
			IL_99:
			return new Class2288((string)class2263_0.Value);
			IL_AA:
			if (string.IsNullOrEmpty((string)class2263_0.Value) && type_0 != null && Class2404.smethod_8(type_0))
			{
				return null;
			}
			return this.method_21(class2263_0.Value, type_0);
			IL_D7:
			if (type_0 == typeof(DBNull))
			{
				return DBNull.Value;
			}
			return this.method_21(class2263_0.Value, type_0);
			IL_F8:
			throw new Exception28("Unexpected token while deserializing object: " + class2263_0.vmethod_1());
			IL_113:
			return class2263_0.Value.ToString();
			IL_121:
			return this.method_21(class2263_0.Value, type_0);
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00310760 File Offset: 0x0030E960
		private Class2278 method_15(Class2299 class2299_0, Class2278 class2278_0)
		{
			Class2278 result = null;
			if (class2278_0 != null)
			{
				result = class2278_0;
			}
			else if (class2299_0 != null)
			{
				Class2278 @class;
				if (class2299_0.method_6() != null)
				{
					result = class2299_0.method_6();
				}
				else if ((@class = base.method_0().method_2(class2299_0.method_0())) != null)
				{
					result = @class;
				}
				else if (class2299_0.method_8() != null)
				{
					result = class2299_0.method_8();
				}
			}
			return result;
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x003107B4 File Offset: 0x0030E9B4
		private object method_16(Class2263 class2263_0, Type type_0, Class2299 class2299_0, Class2353 class2353_0, object object_0)
		{
			this.method_18(class2263_0);
			string string_ = null;
			if (class2263_0.vmethod_1() == JsonToken.PropertyName)
			{
				string text;
				Type type;
				do
				{
					string a = class2263_0.Value.ToString();
					if (string.Equals(a, "$ref", StringComparison.Ordinal))
					{
						goto Block_13;
					}
					bool flag;
					if (string.Equals(a, "$type", StringComparison.Ordinal))
					{
						this.method_18(class2263_0);
						text = class2263_0.Value.ToString();
						this.method_18(class2263_0);
						if ((((class2353_0 != null) ? class2353_0.method_30() : null) ?? base.method_0().vmethod_4()) != Enum194.flag_0)
						{
							string typeName;
							string assemblyName;
							Class2404.smethod_34(text, out typeName, out assemblyName);
							try
							{
								type = base.method_0().vmethod_2().BindToType(assemblyName, typeName);
							}
							catch (Exception exception_)
							{
								throw new Exception28(Class2407.smethod_0("Error resolving type specified in JSON '{0}'.", CultureInfo.InvariantCulture, new object[]
								{
									text
								}), exception_);
							}
							if (type == null)
							{
								goto IL_1F2;
							}
							if (type_0 != null && !type_0.IsAssignableFrom(type))
							{
								goto IL_217;
							}
							type_0 = type;
							class2299_0 = this.method_5(type);
						}
						flag = true;
					}
					else if (string.Equals(a, "$id", StringComparison.Ordinal))
					{
						this.method_18(class2263_0);
						string_ = class2263_0.Value.ToString();
						this.method_18(class2263_0);
						flag = true;
					}
					else
					{
						if (string.Equals(a, "$values", StringComparison.Ordinal))
						{
							goto IL_24B;
						}
						flag = false;
					}
					if (!flag)
					{
						break;
					}
				}
				while (class2263_0.vmethod_1() == JsonToken.PropertyName);
				goto IL_26C;
				Block_13:
				this.method_18(class2263_0);
				if (class2263_0.vmethod_1() != JsonToken.String)
				{
					throw new Exception28(Class2407.smethod_0("JSON reference {0} property must have a string value.", CultureInfo.InvariantCulture, new object[]
					{
						"$ref"
					}));
				}
				string string_2 = class2263_0.Value.ToString();
				this.method_18(class2263_0);
				if (class2263_0.vmethod_1() == JsonToken.PropertyName)
				{
					throw new Exception28(Class2407.smethod_0("Additional content found in JSON reference object. A JSON reference object should only have a {0} property.", CultureInfo.InvariantCulture, new object[]
					{
						"$ref"
					}));
				}
				return base.method_0().vmethod_0().imethod_0(string_2);
				IL_1F2:
				throw new Exception28(Class2407.smethod_0("Type specified in JSON '{0}' was not resolved.", CultureInfo.InvariantCulture, new object[]
				{
					text
				}));
				IL_217:
				throw new Exception28(Class2407.smethod_0("Type specified in JSON '{0}' is not compatible with '{1}'.", CultureInfo.InvariantCulture, new object[]
				{
					type.AssemblyQualifiedName,
					type_0.AssemblyQualifiedName
				}));
				IL_24B:
				this.method_18(class2263_0);
				object result = this.method_19(class2263_0, type_0, class2299_0, class2353_0, object_0, string_);
				this.method_18(class2263_0);
				return result;
			}
			IL_26C:
			if (!this.method_20(type_0))
			{
				return this.method_11(class2263_0);
			}
			if (class2299_0 == null)
			{
				throw new Exception28(Class2407.smethod_0("Could not resolve type '{0}' to a JsonContract.", CultureInfo.InvariantCulture, new object[]
				{
					type_0
				}));
			}
			Class2304 @class = class2299_0 as Class2304;
			if (@class != null)
			{
				if (object_0 == null)
				{
					return this.method_25(class2263_0, @class, string_);
				}
				return this.method_26(@class.method_33(object_0), class2263_0, @class, string_);
			}
			else
			{
				Class2305 class2 = class2299_0 as Class2305;
				if (class2 != null)
				{
					if (object_0 == null)
					{
						return this.method_30(class2263_0, class2, string_);
					}
					return this.method_32(object_0, class2263_0, class2, string_);
				}
				else
				{
					Class2300 class3 = class2299_0 as Class2300;
					if (class3 == null)
					{
						throw new Exception28(Class2407.smethod_0("Cannot deserialize JSON object into type '{0}'.", CultureInfo.InvariantCulture, new object[]
						{
							type_0
						}));
					}
					return this.method_29(class2263_0, class3, string_);
				}
			}
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00310B08 File Offset: 0x0030ED08
		private Class2303 method_17(Type type_0, Class2299 class2299_0)
		{
			if (class2299_0 == null)
			{
				throw new Exception28(Class2407.smethod_0("Could not resolve type '{0}' to a JsonContract.", CultureInfo.InvariantCulture, new object[]
				{
					type_0
				}));
			}
			Class2303 @class = class2299_0 as Class2303;
			if (@class == null)
			{
				throw new Exception28(Class2407.smethod_0("Cannot deserialize JSON array into type '{0}'.", CultureInfo.InvariantCulture, new object[]
				{
					type_0
				}));
			}
			return @class;
		}

		// Token: 0x060057A0 RID: 22432 RVA: 0x000381E1 File Offset: 0x000363E1
		private void method_18(Class2263 class2263_0)
		{
			if (!class2263_0.vmethod_3())
			{
				throw new Exception28("Unexpected end when deserializing object.");
			}
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x00310B68 File Offset: 0x0030ED68
		private object method_19(Class2263 class2263_0, Type type_0, Class2299 class2299_0, Class2353 class2353_0, object object_0, string string_0)
		{
			object result;
			if (this.method_20(type_0))
			{
				Class2303 @class = this.method_17(type_0, class2299_0);
				if (object_0 == null)
				{
					result = this.method_27(class2263_0, string_0, @class);
				}
				else
				{
					result = this.method_28(@class.method_31(object_0), class2263_0, string_0, @class);
				}
			}
			else
			{
				result = this.method_10(class2263_0, class2299_0);
			}
			return result;
		}

		// Token: 0x060057A2 RID: 22434 RVA: 0x000381F6 File Offset: 0x000363F6
		private bool method_20(Type type_0)
		{
			return type_0 != null && type_0 != typeof(object) && !type_0.IsSubclassOf(typeof(Class2286));
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x00310BB8 File Offset: 0x0030EDB8
		private object method_21(object object_0, Type type_0)
		{
			if (type_0 == null)
			{
				return object_0;
			}
			Type type = Class2404.smethod_0(object_0);
			if (type != type_0)
			{
				object result;
				try
				{
					result = Class2388.smethod_3(object_0, CultureInfo.InvariantCulture, type_0);
				}
				catch (Exception exception_)
				{
					throw new Exception28(Class2407.smethod_0("Error converting value {0} to type '{1}'.", CultureInfo.InvariantCulture, new object[]
					{
						this.method_22(object_0),
						type_0
					}), exception_);
				}
				return result;
			}
			return object_0;
		}

		// Token: 0x060057A4 RID: 22436 RVA: 0x0003821D File Offset: 0x0003641D
		private string method_22(object object_0)
		{
			if (object_0 == null)
			{
				return "{null}";
			}
			if (object_0 is string)
			{
				return "\"" + object_0 + "\"";
			}
			return object_0.ToString();
		}

		// Token: 0x060057A5 RID: 22437 RVA: 0x00310C24 File Offset: 0x0030EE24
		private void method_23(Class2353 class2353_0, Class2263 class2263_0, object object_0)
		{
			if (class2353_0.method_8())
			{
				class2263_0.method_4();
				return;
			}
			object obj = null;
			bool flag = false;
			bool bool_ = false;
			Enum188 valueOrDefault = class2353_0.method_28().GetValueOrDefault(base.method_0().vmethod_18());
			if ((valueOrDefault == Enum188.const_0 || valueOrDefault == Enum188.const_1) && (class2263_0.vmethod_1() == JsonToken.StartArray || class2263_0.vmethod_1() == JsonToken.StartObject) && class2353_0.method_10())
			{
				obj = class2353_0.method_2().imethod_1(object_0);
				bool_ = true;
				flag = (obj != null && !class2353_0.method_4().IsArray && !Class2404.smethod_13(class2353_0.method_4(), typeof(ReadOnlyCollection<>)));
			}
			if (!class2353_0.method_12() && !flag)
			{
				class2263_0.method_4();
				return;
			}
			object object_ = flag ? obj : null;
			object obj2 = this.method_12(class2263_0, class2353_0, object_0, bool_, object_);
			if ((!flag || obj2 != obj) && this.method_24(class2353_0, obj2))
			{
				class2353_0.method_2().imethod_0(object_0, obj2);
			}
		}

		// Token: 0x060057A6 RID: 22438 RVA: 0x00310D08 File Offset: 0x0030EF08
		private bool method_24(Class2353 class2353_0, object object_0)
		{
			return (class2353_0.method_22().GetValueOrDefault(base.method_0().vmethod_14()) != Enum191.const_1 || object_0 != null) && (class2353_0.method_24().GetValueOrDefault(base.method_0().vmethod_16()) != Enum186.const_1 || !object.Equals(object_0, class2353_0.method_16())) && class2353_0.method_12();
		}

		// Token: 0x060057A7 RID: 22439 RVA: 0x00310D70 File Offset: 0x0030EF70
		private object method_25(Class2263 class2263_0, Class2304 class2304_0, string string_0)
		{
			if (class2304_0.method_18() != null)
			{
				if (class2304_0.method_20())
				{
					if (base.method_0().vmethod_20() != Enum183.const_1)
					{
						goto IL_20;
					}
				}
				object object_ = class2304_0.method_18()();
				Interface65 @interface = class2304_0.method_33(object_);
				this.method_26(@interface, class2263_0, class2304_0, string_0);
				return @interface.imethod_0();
			}
			IL_20:
			throw new Exception28(Class2407.smethod_0("Unable to find a default constructor to use for type {0}.", CultureInfo.InvariantCulture, new object[]
			{
				class2304_0.method_0()
			}));
		}

		// Token: 0x060057A8 RID: 22440 RVA: 0x00310DE8 File Offset: 0x0030EFE8
		private object method_26(Interface65 interface65_0, Class2263 class2263_0, Class2304 class2304_0, string string_0)
		{
			if (string_0 != null)
			{
				base.method_0().vmethod_0().imethod_3(string_0, interface65_0.imethod_0());
			}
			class2304_0.method_26(interface65_0.imethod_0(), base.method_0().vmethod_25());
			int int_ = class2263_0.vmethod_2();
			JsonToken jsonToken;
			for (;;)
			{
				jsonToken = class2263_0.vmethod_1();
				if (jsonToken != JsonToken.PropertyName)
				{
					break;
				}
				object obj;
				try
				{
					obj = this.method_21(class2263_0.Value, class2304_0.method_29());
				}
				catch (Exception exception_)
				{
					throw new Exception28(Class2407.smethod_0("Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.", CultureInfo.InvariantCulture, new object[]
					{
						class2263_0.Value,
						class2304_0.method_29()
					}), exception_);
				}
				this.method_18(class2263_0);
				try
				{
					interface65_0[obj] = this.method_13(class2263_0, class2304_0.method_31(), this.method_5(class2304_0.method_31()));
				}
				catch (Exception exception_2)
				{
					if (!base.method_4(interface65_0, class2304_0, obj, exception_2))
					{
						throw;
					}
					this.method_34(class2263_0, int_);
				}
				if (!class2263_0.vmethod_3())
				{
					goto Block_5;
				}
			}
			if (jsonToken != JsonToken.EndObject)
			{
				throw new Exception28("Unexpected token when deserializing object: " + class2263_0.vmethod_1());
			}
			class2304_0.method_27(interface65_0.imethod_0(), base.method_0().vmethod_25());
			return interface65_0.imethod_0();
			Block_5:
			throw new Exception28("Unexpected end when deserializing object.");
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x00310F40 File Offset: 0x0030F140
		private object method_27(Class2263 class2263_0, string string_0, Class2303 class2303_0)
		{
			JsonSerializerInternalReader.Class2363 @class = new JsonSerializerInternalReader.Class2363();
			@class.class2263_0 = class2263_0;
			@class.string_0 = string_0;
			@class.class2303_0 = class2303_0;
			@class.jsonSerializerInternalReader_0 = this;
			return Class2399.smethod_7(@class.class2303_0.method_2(), new Action<IList, bool>(@class.method_0));
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x00310F8C File Offset: 0x0030F18C
		private object method_28(Interface64 interface64_0, Class2263 class2263_0, string string_0, Class2303 class2303_0)
		{
			object object_ = interface64_0.imethod_0();
			if (string_0 != null)
			{
				base.method_0().vmethod_0().imethod_3(string_0, object_);
			}
			class2303_0.method_26(object_, base.method_0().vmethod_25());
			int int_ = class2263_0.vmethod_2();
			while (class2263_0.vmethod_3())
			{
				JsonToken jsonToken = class2263_0.vmethod_1();
				if (jsonToken != JsonToken.Comment)
				{
					if (jsonToken == JsonToken.EndArray)
					{
						class2303_0.method_27(object_, base.method_0().vmethod_25());
						return interface64_0.imethod_0();
					}
					try
					{
						object value = this.method_13(class2263_0, class2303_0.method_29(), this.method_5(class2303_0.method_29()));
						interface64_0.Add(value);
					}
					catch (Exception exception_)
					{
						if (!base.method_4(object_, class2303_0, interface64_0.Count, exception_))
						{
							throw;
						}
						this.method_34(class2263_0, int_);
					}
				}
			}
			throw new Exception28("Unexpected end when deserializing array.");
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x0031106C File Offset: 0x0030F26C
		private object method_29(Class2263 class2263_0, Class2300 class2300_0, string string_0)
		{
			Type type = class2300_0.method_0();
			SerializationInfo serializationInfo = new SerializationInfo(class2300_0.method_0(), this.method_9());
			bool flag = false;
			string text;
			do
			{
				JsonToken jsonToken = class2263_0.vmethod_1();
				if (jsonToken != JsonToken.PropertyName)
				{
					if (jsonToken != JsonToken.EndObject)
					{
						goto Block_4;
					}
					flag = true;
				}
				else
				{
					text = class2263_0.Value.ToString();
					if (!class2263_0.vmethod_3())
					{
						goto IL_81;
					}
					serializationInfo.AddValue(text, Class2286.smethod_1(class2263_0));
				}
				if (flag)
				{
					break;
				}
			}
			while (class2263_0.vmethod_3());
			goto IL_A5;
			Block_4:
			throw new Exception28("Unexpected token when deserializing object: " + class2263_0.vmethod_1());
			IL_81:
			throw new Exception28(Class2407.smethod_0("Unexpected end when setting {0}'s value.", CultureInfo.InvariantCulture, new object[]
			{
				text
			}));
			IL_A5:
			if (class2300_0.method_29() == null)
			{
				throw new Exception28(Class2407.smethod_0("ISerializable type '{0}' does not have a valid constructor.", CultureInfo.InvariantCulture, new object[]
				{
					type
				}));
			}
			object obj = class2300_0.method_29()(new object[]
			{
				serializationInfo,
				base.method_0().vmethod_25()
			});
			if (string_0 != null)
			{
				base.method_0().vmethod_0().imethod_3(string_0, obj);
			}
			class2300_0.method_26(obj, base.method_0().vmethod_25());
			class2300_0.method_27(obj, base.method_0().vmethod_25());
			return obj;
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x003111B8 File Offset: 0x0030F3B8
		private object method_30(Class2263 class2263_0, Class2305 class2305_0, string string_0)
		{
			object obj = null;
			if (class2305_0.method_0().IsInterface || class2305_0.method_0().IsAbstract)
			{
				throw new Exception28(Class2407.smethod_0("Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantated.", CultureInfo.InvariantCulture, new object[]
				{
					class2305_0.method_0()
				}));
			}
			if (class2305_0.method_18() != null && (!class2305_0.method_20() || base.method_0().vmethod_20() == Enum183.const_1))
			{
				obj = class2305_0.method_18()();
			}
			if (obj != null)
			{
				this.method_32(obj, class2263_0, class2305_0, string_0);
				return obj;
			}
			return this.method_31(class2263_0, class2305_0, string_0);
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x0031124C File Offset: 0x0030F44C
		private object method_31(Class2263 class2263_0, Class2305 class2305_0, string string_0)
		{
			Type type = class2305_0.method_0();
			if (class2305_0.method_33() == null)
			{
				throw new Exception28(Class2407.smethod_0("Unable to find a constructor to use for type {0}. A class should either have a default constructor or only one constructor with arguments.", CultureInfo.InvariantCulture, new object[]
				{
					type
				}));
			}
			IEnumerable<Class2353> enumerable = class2305_0.method_31();
			if (JsonSerializerInternalReader.func_0 == null)
			{
				JsonSerializerInternalReader.func_0 = new Func<Class2353, bool>(JsonSerializerInternalReader.smethod_0);
			}
			IEnumerable<Class2353> enumerable2 = Enumerable.Where<Class2353>(enumerable, JsonSerializerInternalReader.func_0);
			if (JsonSerializerInternalReader.func_1 == null)
			{
				JsonSerializerInternalReader.func_1 = new Func<Class2353, Class2353>(JsonSerializerInternalReader.smethod_1);
			}
			Func<Class2353, Class2353> func = JsonSerializerInternalReader.func_1;
			if (JsonSerializerInternalReader.func_2 == null)
			{
				JsonSerializerInternalReader.func_2 = new Func<Class2353, object>(JsonSerializerInternalReader.smethod_2);
			}
			IDictionary<Class2353, object> dictionary = Enumerable.ToDictionary<Class2353, Class2353, object>(enumerable2, func, JsonSerializerInternalReader.func_2);
			bool flag = false;
			string text;
			for (;;)
			{
				JsonToken jsonToken = class2263_0.vmethod_1();
				if (jsonToken != JsonToken.PropertyName)
				{
					if (jsonToken != JsonToken.EndObject)
					{
						goto Block_11;
					}
					flag = true;
				}
				else
				{
					text = class2263_0.Value.ToString();
					if (!class2263_0.vmethod_3())
					{
						goto IL_154;
					}
					Class2353 @class = class2305_0.method_31().method_1(text);
					if (@class != null)
					{
						if (!@class.method_8())
						{
							dictionary[@class] = this.method_12(class2263_0, @class, null, true, null);
						}
						else
						{
							class2263_0.method_4();
						}
					}
					else
					{
						if (base.method_0().vmethod_12() == Enum190.const_1)
						{
							break;
						}
						class2263_0.method_4();
					}
				}
				if (flag)
				{
					goto IL_1A6;
				}
				if (!class2263_0.vmethod_3())
				{
					goto Block_10;
				}
			}
			throw new Exception28(Class2407.smethod_0("Could not find member '{0}' on object of type '{1}'", CultureInfo.InvariantCulture, new object[]
			{
				text,
				type.Name
			}));
			Block_10:
			goto IL_1A6;
			Block_11:
			throw new Exception28("Unexpected token when deserializing object: " + class2263_0.vmethod_1());
			IL_154:
			throw new Exception28(Class2407.smethod_0("Unexpected end when setting {0}'s value.", CultureInfo.InvariantCulture, new object[]
			{
				text
			}));
			IL_1A6:
			IEnumerable<ParameterInfo> parameters = class2305_0.method_33().GetParameters();
			if (JsonSerializerInternalReader.func_3 == null)
			{
				JsonSerializerInternalReader.func_3 = new Func<ParameterInfo, ParameterInfo>(JsonSerializerInternalReader.smethod_3);
			}
			Func<ParameterInfo, ParameterInfo> func2 = JsonSerializerInternalReader.func_3;
			if (JsonSerializerInternalReader.func_4 == null)
			{
				JsonSerializerInternalReader.func_4 = new Func<ParameterInfo, object>(JsonSerializerInternalReader.smethod_4);
			}
			IDictionary<ParameterInfo, object> dictionary2 = Enumerable.ToDictionary<ParameterInfo, ParameterInfo, object>(parameters, func2, JsonSerializerInternalReader.func_4);
			IDictionary<Class2353, object> dictionary3 = new Dictionary<Class2353, object>();
			foreach (KeyValuePair<Class2353, object> item in dictionary)
			{
				IEnumerable<KeyValuePair<ParameterInfo, object>> ienumerable_ = dictionary2;
				if (JsonSerializerInternalReader.func_5 == null)
				{
					JsonSerializerInternalReader.func_5 = new Func<KeyValuePair<ParameterInfo, object>, string>(JsonSerializerInternalReader.smethod_5);
				}
				ParameterInfo key = Class2407.smethod_4<KeyValuePair<ParameterInfo, object>>(ienumerable_, JsonSerializerInternalReader.func_5, item.Key.method_0()).Key;
				if (key != null)
				{
					dictionary2[key] = item.Value;
				}
				else
				{
					dictionary3.Add(item);
				}
			}
			object obj = class2305_0.method_33().Invoke(Enumerable.ToArray<object>(dictionary2.Values));
			if (string_0 != null)
			{
				base.method_0().vmethod_0().imethod_3(string_0, obj);
			}
			class2305_0.method_26(obj, base.method_0().vmethod_25());
			foreach (KeyValuePair<Class2353, object> keyValuePair in dictionary3)
			{
				Class2353 key2 = keyValuePair.Key;
				object value = keyValuePair.Value;
				if (this.method_24(keyValuePair.Key, keyValuePair.Value))
				{
					key2.method_2().imethod_0(obj, value);
				}
			}
			class2305_0.method_27(obj, base.method_0().vmethod_25());
			return obj;
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x003115B0 File Offset: 0x0030F7B0
		private object method_32(object object_0, Class2263 class2263_0, Class2305 class2305_0, string string_0)
		{
			class2305_0.method_26(object_0, base.method_0().vmethod_25());
			IEnumerable<Class2353> enumerable = class2305_0.method_31();
			if (JsonSerializerInternalReader.func_6 == null)
			{
				JsonSerializerInternalReader.func_6 = new Func<Class2353, bool>(JsonSerializerInternalReader.smethod_6);
			}
			IEnumerable<Class2353> enumerable2 = Enumerable.Where<Class2353>(enumerable, JsonSerializerInternalReader.func_6);
			if (JsonSerializerInternalReader.func_7 == null)
			{
				JsonSerializerInternalReader.func_7 = new Func<Class2353, Class2353>(JsonSerializerInternalReader.smethod_7);
			}
			Func<Class2353, Class2353> func = JsonSerializerInternalReader.func_7;
			if (JsonSerializerInternalReader.func_8 == null)
			{
				JsonSerializerInternalReader.func_8 = new Func<Class2353, JsonSerializerInternalReader.RequiredValue>(JsonSerializerInternalReader.smethod_8);
			}
			Dictionary<Class2353, JsonSerializerInternalReader.RequiredValue> dictionary = Enumerable.ToDictionary<Class2353, Class2353, JsonSerializerInternalReader.RequiredValue>(enumerable2, func, JsonSerializerInternalReader.func_8);
			if (string_0 != null)
			{
				base.method_0().vmethod_0().imethod_3(string_0, object_0);
			}
			int int_ = class2263_0.vmethod_2();
			JsonToken jsonToken;
			string text;
			for (;;)
			{
				jsonToken = class2263_0.vmethod_1();
				switch (jsonToken)
				{
				case JsonToken.PropertyName:
				{
					text = class2263_0.Value.ToString();
					Class2353 @class = class2305_0.method_31().method_1(text);
					if (@class != null)
					{
						if (@class.method_4() == typeof(byte[]))
						{
							class2263_0.vmethod_4();
						}
						else if (!class2263_0.vmethod_3())
						{
							goto IL_257;
						}
						this.method_33(class2263_0, @class, dictionary);
						try
						{
							this.method_23(@class, class2263_0, object_0);
						}
						catch (Exception exception_)
						{
							if (!base.method_4(object_0, class2305_0, text, exception_))
							{
								throw;
							}
							this.method_34(class2263_0, int_);
						}
						goto IL_142;
					}
					if (base.method_0().vmethod_12() == Enum190.const_1)
					{
						goto Block_7;
					}
					class2263_0.method_4();
					goto IL_142;
				}
				case JsonToken.Comment:
					goto IL_142;
				}
				break;
				IL_142:
				if (!class2263_0.vmethod_3())
				{
					goto Block_10;
				}
			}
			if (jsonToken != JsonToken.EndObject)
			{
				throw new Exception28("Unexpected token when deserializing object: " + class2263_0.vmethod_1());
			}
			using (Dictionary<Class2353, JsonSerializerInternalReader.RequiredValue>.Enumerator enumerator = dictionary.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<Class2353, JsonSerializerInternalReader.RequiredValue> keyValuePair = enumerator.Current;
					if (keyValuePair.Value == JsonSerializerInternalReader.RequiredValue.const_0)
					{
						throw new Exception28(Class2407.smethod_0("Required property '{0}' not found in JSON.", CultureInfo.InvariantCulture, new object[]
						{
							keyValuePair.Key.method_0()
						}));
					}
					if (keyValuePair.Key.method_18() == Enum184.const_2 && keyValuePair.Value == JsonSerializerInternalReader.RequiredValue.const_1)
					{
						throw new Exception28(Class2407.smethod_0("Required property '{0}' expects a value but got null.", CultureInfo.InvariantCulture, new object[]
						{
							keyValuePair.Key.method_0()
						}));
					}
				}
				goto IL_286;
			}
			goto IL_224;
			IL_286:
			class2305_0.method_27(object_0, base.method_0().vmethod_25());
			return object_0;
			Block_7:
			goto IL_224;
			Block_10:
			throw new Exception28("Unexpected end when deserializing object.");
			IL_224:
			throw new Exception28(Class2407.smethod_0("Could not find member '{0}' on object of type '{1}'", CultureInfo.InvariantCulture, new object[]
			{
				text,
				class2305_0.method_0().Name
			}));
			IL_257:
			throw new Exception28(Class2407.smethod_0("Unexpected end when setting {0}'s value.", CultureInfo.InvariantCulture, new object[]
			{
				text
			}));
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x00038247 File Offset: 0x00036447
		private void method_33(Class2263 class2263_0, Class2353 class2353_0, Dictionary<Class2353, JsonSerializerInternalReader.RequiredValue> dictionary_0)
		{
			if (class2353_0 != null)
			{
				dictionary_0[class2353_0] = ((class2263_0.vmethod_1() == JsonToken.Null || class2263_0.vmethod_1() == JsonToken.Undefined) ? JsonSerializerInternalReader.RequiredValue.const_1 : JsonSerializerInternalReader.RequiredValue.Value);
			}
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x0003826B File Offset: 0x0003646B
		private void method_34(Class2263 class2263_0, int int_0)
		{
			base.method_3();
			class2263_0.method_4();
			while (class2263_0.vmethod_2() > int_0 + 1)
			{
				class2263_0.vmethod_3();
			}
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x0003828D File Offset: 0x0003648D
		[CompilerGenerated]
		private static bool smethod_0(Class2353 class2353_0)
		{
			return !class2353_0.method_8();
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x00006C77 File Offset: 0x00004E77
		[CompilerGenerated]
		private static Class2353 smethod_1(Class2353 class2353_0)
		{
			return class2353_0;
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00011675 File Offset: 0x0000F875
		[CompilerGenerated]
		private static object smethod_2(Class2353 class2353_0)
		{
			return null;
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00006C77 File Offset: 0x00004E77
		[CompilerGenerated]
		private static ParameterInfo smethod_3(ParameterInfo parameterInfo_0)
		{
			return parameterInfo_0;
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00011675 File Offset: 0x0000F875
		[CompilerGenerated]
		private static object smethod_4(ParameterInfo parameterInfo_0)
		{
			return null;
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00038298 File Offset: 0x00036498
		[CompilerGenerated]
		private static string smethod_5(KeyValuePair<ParameterInfo, object> keyValuePair_0)
		{
			return keyValuePair_0.Key.Name;
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x000382A6 File Offset: 0x000364A6
		[CompilerGenerated]
		private static bool smethod_6(Class2353 class2353_0)
		{
			return class2353_0.method_18() != Enum184.const_0;
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00006C77 File Offset: 0x00004E77
		[CompilerGenerated]
		private static Class2353 smethod_7(Class2353 class2353_0)
		{
			return class2353_0;
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00003024 File Offset: 0x00001224
		[CompilerGenerated]
		private static JsonSerializerInternalReader.RequiredValue smethod_8(Class2353 class2353_0)
		{
			return JsonSerializerInternalReader.RequiredValue.const_0;
		}

		// Token: 0x04003381 RID: 13185
		private Class2332 class2332_0;

		// Token: 0x04003382 RID: 13186
		private Class2298 class2298_0;

		// Token: 0x04003383 RID: 13187
		[CompilerGenerated]
		private static Func<Class2353, bool> func_0;

		// Token: 0x04003384 RID: 13188
		[CompilerGenerated]
		private static Func<Class2353, Class2353> func_1;

		// Token: 0x04003385 RID: 13189
		[CompilerGenerated]
		private static Func<Class2353, object> func_2;

		// Token: 0x04003386 RID: 13190
		[CompilerGenerated]
		private static Func<ParameterInfo, ParameterInfo> func_3;

		// Token: 0x04003387 RID: 13191
		[CompilerGenerated]
		private static Func<ParameterInfo, object> func_4;

		// Token: 0x04003388 RID: 13192
		[CompilerGenerated]
		private static Func<KeyValuePair<ParameterInfo, object>, string> func_5;

		// Token: 0x04003389 RID: 13193
		[CompilerGenerated]
		private static Func<Class2353, bool> func_6;

		// Token: 0x0400338A RID: 13194
		[CompilerGenerated]
		private static Func<Class2353, Class2353> func_7;

		// Token: 0x0400338B RID: 13195
		[CompilerGenerated]
		private static Func<Class2353, JsonSerializerInternalReader.RequiredValue> func_8;

		// Token: 0x02000D15 RID: 3349
		internal enum RequiredValue
		{
			// Token: 0x0400338D RID: 13197
			const_0,
			// Token: 0x0400338E RID: 13198
			const_1,
			// Token: 0x0400338F RID: 13199
			Value
		}

		// Token: 0x02000D16 RID: 3350
		[CompilerGenerated]
		private sealed class Class2363
		{
			// Token: 0x060057BB RID: 22459 RVA: 0x00311874 File Offset: 0x0030FA74
			public void method_0(IList ilist_0, bool bool_0)
			{
				if (this.string_0 != null && bool_0)
				{
					throw new Exception28(Class2407.smethod_0("Cannot preserve reference to array or readonly list: {0}", CultureInfo.InvariantCulture, new object[]
					{
						this.class2303_0.method_0()
					}));
				}
				if (this.class2303_0.method_16() != null && bool_0)
				{
					throw new Exception28(Class2407.smethod_0("Cannot call OnSerializing on an array or readonly list: {0}", CultureInfo.InvariantCulture, new object[]
					{
						this.class2303_0.method_0()
					}));
				}
				if (this.class2303_0.method_22() != null && bool_0)
				{
					throw new Exception28(Class2407.smethod_0("Cannot call OnError on an array or readonly list: {0}", CultureInfo.InvariantCulture, new object[]
					{
						this.class2303_0.method_0()
					}));
				}
				this.jsonSerializerInternalReader_0.method_28(this.class2303_0.method_31(ilist_0), this.class2263_0, this.string_0, this.class2303_0);
			}

			// Token: 0x04003390 RID: 13200
			public JsonSerializerInternalReader jsonSerializerInternalReader_0;

			// Token: 0x04003391 RID: 13201
			public Class2263 class2263_0;

			// Token: 0x04003392 RID: 13202
			public string string_0;

			// Token: 0x04003393 RID: 13203
			public Class2303 class2303_0;
		}
	}
}
