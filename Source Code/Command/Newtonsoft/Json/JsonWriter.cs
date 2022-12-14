using System;
using System.Collections.Generic;
using System.Globalization;
using ns31;
using ns32;
using ns33;
using ns5;

namespace Newtonsoft.Json
{
	// Token: 0x02000C94 RID: 3220
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x060052C1 RID: 21185 RVA: 0x00035451 File Offset: 0x00033651
		protected internal int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00306560 File Offset: 0x00304760
		public Enum195 method_1()
		{
			switch (this.state_1)
			{
			case JsonWriter.State.Start:
				return Enum195.const_6;
			case JsonWriter.State.Property:
				return Enum195.const_5;
			case JsonWriter.State.ObjectStart:
			case JsonWriter.State.Object:
				return Enum195.const_2;
			case JsonWriter.State.ArrayStart:
			case JsonWriter.State.Array:
				return Enum195.const_3;
			case JsonWriter.State.ConstructorStart:
			case JsonWriter.State.Constructor:
				return Enum195.const_4;
			case JsonWriter.State.Closed:
				return Enum195.const_1;
			case JsonWriter.State.Error:
				return Enum195.const_0;
			}
			throw new Exception26("Invalid state: " + this.state_1);
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00035459 File Offset: 0x00033659
		public Enum196 method_2()
		{
			return this.enum196_0;
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00035461 File Offset: 0x00033661
		public void method_3(Enum196 enum196_1)
		{
			this.enum196_0 = enum196_1;
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x0003546A File Offset: 0x0003366A
		public JsonWriter()
		{
			this.list_0 = new List<Enum189>(8);
			this.list_0.Add(Enum189.const_0);
			this.state_1 = JsonWriter.State.Start;
			this.enum196_0 = Enum196.const_0;
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x003065D0 File Offset: 0x003047D0
		private void method_4(Enum189 enum189_0)
		{
			this.int_0++;
			if (this.list_0.Count <= this.int_0)
			{
				this.list_0.Add(enum189_0);
				return;
			}
			this.list_0[this.int_0] = enum189_0;
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00306620 File Offset: 0x00304820
		private Enum189 method_5()
		{
			Enum189 result = this.method_6();
			this.int_0--;
			return result;
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00035498 File Offset: 0x00033698
		private Enum189 method_6()
		{
			return this.list_0[this.int_0];
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x000354AB File Offset: 0x000336AB
		public virtual void vmethod_0()
		{
			this.method_17();
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x000354B3 File Offset: 0x000336B3
		public virtual void vmethod_1()
		{
			this.method_21(JsonToken.StartObject);
			this.method_4(Enum189.const_1);
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x000354C3 File Offset: 0x000336C3
		public void method_7()
		{
			this.method_20(JsonToken.EndObject);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x000354CD File Offset: 0x000336CD
		public virtual void vmethod_2()
		{
			this.method_21(JsonToken.StartArray);
			this.method_4(Enum189.const_2);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x000354DD File Offset: 0x000336DD
		public void method_8()
		{
			this.method_20(JsonToken.EndArray);
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x000354E7 File Offset: 0x000336E7
		public virtual void vmethod_3(string string_0)
		{
			this.method_21(JsonToken.StartConstructor);
			this.method_4(Enum189.const_3);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x000354F7 File Offset: 0x000336F7
		public void method_9()
		{
			this.method_20(JsonToken.EndConstructor);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00035501 File Offset: 0x00033701
		public virtual void vmethod_4(string string_0)
		{
			this.method_21(JsonToken.PropertyName);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x0003550A File Offset: 0x0003370A
		public void method_10()
		{
			this.method_16(this.method_6());
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00306644 File Offset: 0x00304844
		public void method_11(Class2263 class2263_0)
		{
			Class2409.smethod_4(class2263_0, "reader");
			int int_;
			if (class2263_0.vmethod_1() == JsonToken.None)
			{
				int_ = -1;
			}
			else if (!this.method_15(class2263_0.vmethod_1()))
			{
				int_ = class2263_0.vmethod_2() + 1;
			}
			else
			{
				int_ = class2263_0.vmethod_2();
			}
			this.method_12(class2263_0, int_);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00306690 File Offset: 0x00304890
		internal void method_12(Class2263 class2263_0, int int_1)
		{
			for (;;)
			{
				switch (class2263_0.vmethod_1())
				{
				case JsonToken.None:
					goto IL_6B;
				case JsonToken.StartObject:
					this.vmethod_1();
					goto IL_6B;
				case JsonToken.StartArray:
					this.vmethod_2();
					goto IL_6B;
				case JsonToken.StartConstructor:
				{
					string strA = class2263_0.Value.ToString();
					if (string.Compare(strA, "Date", StringComparison.Ordinal) == 0)
					{
						this.method_13(class2263_0);
						goto IL_6B;
					}
					this.vmethod_3(class2263_0.Value.ToString());
					goto IL_6B;
				}
				case JsonToken.PropertyName:
					this.vmethod_4(class2263_0.Value.ToString());
					goto IL_6B;
				case JsonToken.Comment:
					this.vmethod_31(class2263_0.Value.ToString());
					goto IL_6B;
				case JsonToken.Raw:
					this.vmethod_12((string)class2263_0.Value);
					goto IL_6B;
				case JsonToken.Integer:
					this.vmethod_16((long)class2263_0.Value);
					goto IL_6B;
				case JsonToken.Float:
					this.vmethod_19((double)class2263_0.Value);
					goto IL_6B;
				case JsonToken.String:
					this.vmethod_13(class2263_0.Value.ToString());
					goto IL_6B;
				case JsonToken.Boolean:
					this.vmethod_20((bool)class2263_0.Value);
					goto IL_6B;
				case JsonToken.Null:
					this.vmethod_9();
					goto IL_6B;
				case JsonToken.Undefined:
					this.vmethod_10();
					goto IL_6B;
				case JsonToken.EndObject:
					this.method_7();
					goto IL_6B;
				case JsonToken.EndArray:
					this.method_8();
					goto IL_6B;
				case JsonToken.EndConstructor:
					this.method_9();
					goto IL_6B;
				case JsonToken.Date:
					this.vmethod_27((DateTime)class2263_0.Value);
					goto IL_6B;
				case JsonToken.Bytes:
					this.vmethod_29((byte[])class2263_0.Value);
					goto IL_6B;
				}
				break;
				IL_6B:
				if (int_1 - 1 >= class2263_0.vmethod_2() - (this.method_14(class2263_0.vmethod_1()) ? 1 : 0))
				{
					return;
				}
				if (!class2263_0.vmethod_3())
				{
					return;
				}
			}
			throw Class2403.smethod_0("TokenType", class2263_0.vmethod_1(), "Unexpected token type.");
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00306878 File Offset: 0x00304A78
		private void method_13(Class2263 class2263_0)
		{
			if (!class2263_0.vmethod_3())
			{
				throw new Exception("Unexpected end while reading date constructor.");
			}
			if (class2263_0.vmethod_1() != JsonToken.Integer)
			{
				throw new Exception("Unexpected token while reading date constructor. Expected Integer, got " + class2263_0.vmethod_1());
			}
			long long_ = (long)class2263_0.Value;
			DateTime dateTime_ = Class2330.smethod_9(long_);
			if (!class2263_0.vmethod_3())
			{
				throw new Exception("Unexpected end while reading date constructor.");
			}
			if (class2263_0.vmethod_1() != JsonToken.EndConstructor)
			{
				throw new Exception("Unexpected token while reading date constructor. Expected EndConstructor, got " + class2263_0.vmethod_1());
			}
			this.vmethod_27(dateTime_);
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00306910 File Offset: 0x00304B10
		private bool method_14(JsonToken jsonToken_0)
		{
			switch (jsonToken_0)
			{
			case JsonToken.EndObject:
			case JsonToken.EndArray:
			case JsonToken.EndConstructor:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00306938 File Offset: 0x00304B38
		private bool method_15(JsonToken jsonToken_0)
		{
			switch (jsonToken_0)
			{
			case JsonToken.StartObject:
			case JsonToken.StartArray:
			case JsonToken.StartConstructor:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00306960 File Offset: 0x00304B60
		private void method_16(Enum189 enum189_0)
		{
			switch (enum189_0)
			{
			case Enum189.const_1:
				this.method_7();
				return;
			case Enum189.const_2:
				this.method_8();
				return;
			case Enum189.const_3:
				this.method_9();
				return;
			default:
				throw new Exception26("Unexpected type when writing end: " + enum189_0);
			}
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x00035518 File Offset: 0x00033718
		private void method_17()
		{
			while (this.int_0 > 0)
			{
				this.method_10();
			}
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x003069B0 File Offset: 0x00304BB0
		private Enum189 method_18(JsonToken jsonToken_0)
		{
			switch (jsonToken_0)
			{
			case JsonToken.EndObject:
				return Enum189.const_1;
			case JsonToken.EndArray:
				return Enum189.const_2;
			case JsonToken.EndConstructor:
				return Enum189.const_3;
			default:
				throw new Exception26("No type for token: " + jsonToken_0);
			}
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x003069F0 File Offset: 0x00304BF0
		private JsonToken method_19(Enum189 enum189_0)
		{
			switch (enum189_0)
			{
			case Enum189.const_1:
				return JsonToken.EndObject;
			case Enum189.const_2:
				return JsonToken.EndArray;
			case Enum189.const_3:
				return JsonToken.EndConstructor;
			default:
				throw new Exception26("No close token for type: " + enum189_0);
			}
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00306A34 File Offset: 0x00304C34
		private void method_20(JsonToken jsonToken_0)
		{
			int num = 0;
			int i = 0;
			while (i < this.int_0)
			{
				int index = this.int_0 - i;
				if (this.list_0[index] == this.method_18(jsonToken_0))
				{
					num = i + 1;
					IL_39:
					if (num == 0)
					{
						throw new Exception26("No token to close.");
					}
					for (int j = 0; j < num; j++)
					{
						JsonToken jsonToken_ = this.method_19(this.method_5());
						if (this.state_1 != JsonWriter.State.ObjectStart && this.state_1 != JsonWriter.State.ArrayStart)
						{
							this.vmethod_6();
						}
						this.vmethod_5(jsonToken_);
					}
					Enum189 @enum = this.method_6();
					switch (@enum)
					{
					case Enum189.const_0:
						this.state_1 = JsonWriter.State.Start;
						return;
					case Enum189.const_1:
						this.state_1 = JsonWriter.State.Object;
						return;
					case Enum189.const_2:
						this.state_1 = JsonWriter.State.Array;
						return;
					case Enum189.const_3:
						this.state_1 = JsonWriter.State.Array;
						return;
					default:
						throw new Exception26("Unknown JsonType: " + @enum);
					}
				}
				else
				{
					i++;
				}
			}
			goto IL_39;
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x0000378C File Offset: 0x0000198C
		protected virtual void vmethod_5(JsonToken jsonToken_0)
		{
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x0000378C File Offset: 0x0000198C
		protected virtual void vmethod_6()
		{
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x0000378C File Offset: 0x0000198C
		protected virtual void vmethod_7()
		{
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x0000378C File Offset: 0x0000198C
		protected virtual void vmethod_8()
		{
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00306B1C File Offset: 0x00304D1C
		internal void method_21(JsonToken jsonToken_0)
		{
			int num;
			switch (jsonToken_0)
			{
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Null:
			case JsonToken.Undefined:
			case JsonToken.Date:
			case JsonToken.Bytes:
				num = 7;
				break;
			default:
				num = (int)jsonToken_0;
				break;
			}
			JsonWriter.State state = JsonWriter.state_0[num][(int)this.state_1];
			if (state == JsonWriter.State.Error)
			{
				throw new Exception26(Class2407.smethod_0("Token {0} in state {1} would result in an invalid JavaScript object.", CultureInfo.InvariantCulture, new object[]
				{
					jsonToken_0.ToString(),
					this.state_1.ToString()
				}));
			}
			if ((this.state_1 == JsonWriter.State.Object || this.state_1 == JsonWriter.State.Array || this.state_1 == JsonWriter.State.Constructor) && jsonToken_0 != JsonToken.Comment)
			{
				this.vmethod_7();
			}
			else if (this.state_1 == JsonWriter.State.Property && this.enum196_0 == Enum196.const_1)
			{
				this.vmethod_8();
			}
			Enum195 @enum = this.method_1();
			if ((jsonToken_0 == JsonToken.PropertyName && @enum != Enum195.const_6) || @enum == Enum195.const_3 || @enum == Enum195.const_4)
			{
				this.vmethod_6();
			}
			this.state_1 = state;
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x0003552C File Offset: 0x0003372C
		public virtual void vmethod_9()
		{
			this.method_21(JsonToken.Null);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x00035536 File Offset: 0x00033736
		public virtual void vmethod_10()
		{
			this.method_21(JsonToken.Undefined);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x0000378C File Offset: 0x0000198C
		public virtual void vmethod_11(string string_0)
		{
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x00035540 File Offset: 0x00033740
		public virtual void vmethod_12(string string_0)
		{
			this.method_21(JsonToken.Undefined);
			this.vmethod_11(string_0);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00035551 File Offset: 0x00033751
		public virtual void vmethod_13(string string_0)
		{
			this.method_21(JsonToken.String);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_14(int int_1)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_15(uint uint_0)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_16(long long_0)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_17(ulong ulong_0)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x00035564 File Offset: 0x00033764
		public virtual void vmethod_18(float float_0)
		{
			this.method_21(JsonToken.Float);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x00035564 File Offset: 0x00033764
		public virtual void vmethod_19(double double_0)
		{
			this.method_21(JsonToken.Float);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x0003556D File Offset: 0x0003376D
		public virtual void vmethod_20(bool bool_0)
		{
			this.method_21(JsonToken.Boolean);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_21(short short_0)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_22(ushort ushort_0)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x00035551 File Offset: 0x00033751
		public virtual void vmethod_23(char char_0)
		{
			this.method_21(JsonToken.String);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_24(byte byte_0)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x0003555B File Offset: 0x0003375B
		public virtual void vmethod_25(sbyte sbyte_0)
		{
			this.method_21(JsonToken.Integer);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x00035564 File Offset: 0x00033764
		public virtual void vmethod_26(decimal decimal_0)
		{
			this.method_21(JsonToken.Float);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x00035577 File Offset: 0x00033777
		public virtual void vmethod_27(DateTime dateTime_0)
		{
			this.method_21(JsonToken.Date);
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x00035577 File Offset: 0x00033777
		public virtual void vmethod_28(DateTimeOffset dateTimeOffset_0)
		{
			this.method_21(JsonToken.Date);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x00035581 File Offset: 0x00033781
		public virtual void vmethod_29(byte[] byte_0)
		{
			if (byte_0 == null)
			{
				this.vmethod_9();
				return;
			}
			this.method_21(JsonToken.Bytes);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x00306C20 File Offset: 0x00304E20
		public virtual void vmethod_30(object object_0)
		{
			if (object_0 == null)
			{
				this.vmethod_9();
				return;
			}
			if (object_0 is IConvertible)
			{
				IConvertible convertible = object_0 as IConvertible;
				switch (convertible.GetTypeCode())
				{
				case TypeCode.DBNull:
					this.vmethod_9();
					return;
				case TypeCode.Boolean:
					this.vmethod_20(convertible.ToBoolean(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Char:
					this.vmethod_23(convertible.ToChar(CultureInfo.InvariantCulture));
					return;
				case TypeCode.SByte:
					this.vmethod_25(convertible.ToSByte(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Byte:
					this.vmethod_24(convertible.ToByte(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Int16:
					this.vmethod_21(convertible.ToInt16(CultureInfo.InvariantCulture));
					return;
				case TypeCode.UInt16:
					this.vmethod_22(convertible.ToUInt16(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Int32:
					this.vmethod_14(convertible.ToInt32(CultureInfo.InvariantCulture));
					return;
				case TypeCode.UInt32:
					this.vmethod_15(convertible.ToUInt32(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Int64:
					this.vmethod_16(convertible.ToInt64(CultureInfo.InvariantCulture));
					return;
				case TypeCode.UInt64:
					this.vmethod_17(convertible.ToUInt64(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Single:
					this.vmethod_18(convertible.ToSingle(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Double:
					this.vmethod_19(convertible.ToDouble(CultureInfo.InvariantCulture));
					return;
				case TypeCode.Decimal:
					this.vmethod_26(convertible.ToDecimal(CultureInfo.InvariantCulture));
					return;
				case TypeCode.DateTime:
					this.vmethod_27(convertible.ToDateTime(CultureInfo.InvariantCulture));
					return;
				case TypeCode.String:
					this.vmethod_13(convertible.ToString(CultureInfo.InvariantCulture));
					return;
				}
			}
			else
			{
				if (object_0 is DateTimeOffset)
				{
					this.vmethod_28((DateTimeOffset)object_0);
					return;
				}
				if (object_0 is byte[])
				{
					this.vmethod_29((byte[])object_0);
					return;
				}
			}
			throw new ArgumentException(Class2407.smethod_0("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.", CultureInfo.InvariantCulture, new object[]
			{
				object_0.GetType()
			}));
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00035595 File Offset: 0x00033795
		public virtual void vmethod_31(string string_0)
		{
			this.method_21(JsonToken.Comment);
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x0003559E File Offset: 0x0003379E
		void IDisposable.Dispose()
		{
			this.method_22(true);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x000355A7 File Offset: 0x000337A7
		private void method_22(bool bool_0)
		{
			if (this.method_1() != Enum195.const_1)
			{
				this.vmethod_0();
			}
		}

		// Token: 0x040031F6 RID: 12790
		private static readonly JsonWriter.State[][] state_0 = new JsonWriter.State[][]
		{
			new JsonWriter.State[]
			{
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			},
			new JsonWriter.State[]
			{
				JsonWriter.State.ObjectStart,
				JsonWriter.State.ObjectStart,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.ObjectStart,
				JsonWriter.State.ObjectStart,
				JsonWriter.State.ObjectStart,
				JsonWriter.State.ObjectStart,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			},
			new JsonWriter.State[]
			{
				JsonWriter.State.ArrayStart,
				JsonWriter.State.ArrayStart,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.ArrayStart,
				JsonWriter.State.ArrayStart,
				JsonWriter.State.ArrayStart,
				JsonWriter.State.ArrayStart,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			},
			new JsonWriter.State[]
			{
				JsonWriter.State.ConstructorStart,
				JsonWriter.State.ConstructorStart,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.ConstructorStart,
				JsonWriter.State.ConstructorStart,
				JsonWriter.State.ConstructorStart,
				JsonWriter.State.ConstructorStart,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			},
			new JsonWriter.State[]
			{
				JsonWriter.State.Property,
				JsonWriter.State.Error,
				JsonWriter.State.Property,
				JsonWriter.State.Property,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			},
			new JsonWriter.State[]
			{
				JsonWriter.State.Start,
				JsonWriter.State.Property,
				JsonWriter.State.ObjectStart,
				JsonWriter.State.Object,
				JsonWriter.State.ArrayStart,
				JsonWriter.State.Array,
				JsonWriter.State.Constructor,
				JsonWriter.State.Constructor,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			},
			new JsonWriter.State[]
			{
				JsonWriter.State.Start,
				JsonWriter.State.Property,
				JsonWriter.State.ObjectStart,
				JsonWriter.State.Object,
				JsonWriter.State.ArrayStart,
				JsonWriter.State.Array,
				JsonWriter.State.Constructor,
				JsonWriter.State.Constructor,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			},
			new JsonWriter.State[]
			{
				JsonWriter.State.Start,
				JsonWriter.State.Object,
				JsonWriter.State.Error,
				JsonWriter.State.Error,
				JsonWriter.State.Array,
				JsonWriter.State.Array,
				JsonWriter.State.Constructor,
				JsonWriter.State.Constructor,
				JsonWriter.State.Error,
				JsonWriter.State.Error
			}
		};

		// Token: 0x040031F7 RID: 12791
		private int int_0;

		// Token: 0x040031F8 RID: 12792
		private readonly List<Enum189> list_0;

		// Token: 0x040031F9 RID: 12793
		private JsonWriter.State state_1;

		// Token: 0x040031FA RID: 12794
		private Enum196 enum196_0;

		// Token: 0x02000C95 RID: 3221
		private enum State
		{
			// Token: 0x040031FC RID: 12796
			Start,
			// Token: 0x040031FD RID: 12797
			Property,
			// Token: 0x040031FE RID: 12798
			ObjectStart,
			// Token: 0x040031FF RID: 12799
			Object,
			// Token: 0x04003200 RID: 12800
			ArrayStart,
			// Token: 0x04003201 RID: 12801
			Array,
			// Token: 0x04003202 RID: 12802
			ConstructorStart,
			// Token: 0x04003203 RID: 12803
			Constructor,
			// Token: 0x04003204 RID: 12804
			Bytes,
			// Token: 0x04003205 RID: 12805
			Closed,
			// Token: 0x04003206 RID: 12806
			Error
		}
	}
}
