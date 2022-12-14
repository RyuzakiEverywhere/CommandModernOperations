using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Gameloop.Vdf.Utilities;
using ns0;

namespace Gameloop.Vdf.Linq
{
	// Token: 0x02000039 RID: 57
	public sealed class VObject : Class41, IDictionary<string, Class41>, ICollection<KeyValuePair<string, Class41>>, IEnumerable<KeyValuePair<string, Class41>>, IEnumerable
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00002F3C File Offset: 0x0000113C
		public VObject()
		{
			this.list_0 = new List<VProperty>();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002F4F File Offset: 0x0000114F
		public int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x17000002 RID: 2
		public override Class41 this[object object_0]
		{
			get
			{
				Class33.smethod_0(object_0, "key");
				string text = object_0 as string;
				if (text == null)
				{
					throw new ArgumentException("Accessed JObject values with invalid key value: " + Class29.smethod_0(object_0) + ". Object property name expected.");
				}
				return this[text];
			}
			set
			{
				Class33.smethod_0(object_0, "key");
				string text = object_0 as string;
				if (text == null)
				{
					throw new ArgumentException("Set JObject values with invalid key value: " + Class29.smethod_0(object_0) + ". Object property name expected.");
				}
				this[text] = value;
			}
		}

		// Token: 0x17000003 RID: 3
		public Class41 this[string key]
		{
			get
			{
				Class41 result;
				if (!this.TryGetValue(key, out result))
				{
					return null;
				}
				return result;
			}
			set
			{
				VObject.Class35 @class = new VObject.Class35();
				@class.string_0 = key;
				VProperty vproperty = Enumerable.FirstOrDefault<VProperty>(this.list_0, new Func<VProperty, bool>(@class.method_0));
				if (vproperty != null)
				{
					vproperty.Value = value;
					return;
				}
				this.Add(@class.string_0, value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002F5C File Offset: 0x0000115C
		ICollection<string> IDictionary<string, Class41>.Keys
		{
			get
			{
				return Enumerable.ToList<string>(Enumerable.Select<VProperty, string>(this.list_0, new Func<VProperty, string>(VObject.<>c.<>9.method_0)));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002F8D File Offset: 0x0000118D
		ICollection<Class41> IDictionary<string, Class41>.Values
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002F94 File Offset: 0x00001194
		public override IEnumerable<VProperty> vmethod_1()
		{
			return this.list_0;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002F9C File Offset: 0x0000119C
		public void Add(string key, Class41 value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.list_0.Add(new VProperty(key, value));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002FBE File Offset: 0x000011BE
		public void Add(VProperty vproperty_0)
		{
			if (vproperty_0 == null)
			{
				throw new ArgumentNullException("property");
			}
			if (vproperty_0.Value == null)
			{
				throw new ArgumentNullException("Value");
			}
			this.list_0.Add(vproperty_0);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000560E8 File Offset: 0x000542E8
		public bool ContainsKey(string key)
		{
			VObject.Class36 @class = new VObject.Class36();
			@class.string_0 = key;
			return this.list_0.Exists(new Predicate<VProperty>(@class.method_0));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0005611C File Offset: 0x0005431C
		public bool Remove(string key)
		{
			VObject.Class37 @class = new VObject.Class37();
			@class.string_0 = key;
			return this.list_0.RemoveAll(new Predicate<VProperty>(@class.method_0)) != 0;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00056150 File Offset: 0x00054350
		public bool TryGetValue(string key, out Class41 value)
		{
			VObject.Class38 @class = new VObject.Class38();
			@class.string_0 = key;
			VProperty vproperty = Enumerable.FirstOrDefault<VProperty>(this.list_0, new Func<VProperty, bool>(@class.method_0));
			value = ((vproperty != null) ? vproperty.Value : null);
			return value != null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00056194 File Offset: 0x00054394
		public override void vmethod_0(VdfWriter vdfWriter_0)
		{
			vdfWriter_0.vmethod_0();
			foreach (VProperty vproperty in this.list_0)
			{
				vproperty.vmethod_0(vdfWriter_0);
			}
			vdfWriter_0.vmethod_1();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002FED File Offset: 0x000011ED
		public IEnumerator<KeyValuePair<string, Class41>> GetEnumerator()
		{
			VObject.Class39 @class = new VObject.Class39(0);
			@class.vobject_0 = this;
			return @class;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002FFC File Offset: 0x000011FC
		void ICollection<KeyValuePair<string, Class41>>.Add(KeyValuePair<string, Class41> item)
		{
			this.Add(new VProperty(item.Key, item.Value));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003017 File Offset: 0x00001217
		void ICollection<KeyValuePair<string, Class41>>.Clear()
		{
			this.list_0.Clear();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000561F4 File Offset: 0x000543F4
		bool ICollection<KeyValuePair<string, Class41>>.Contains(KeyValuePair<string, Class41> item)
		{
			VObject.Class40 @class = new VObject.Class40();
			@class.keyValuePair_0 = item;
			VProperty vproperty = Enumerable.FirstOrDefault<VProperty>(this.list_0, new Func<VProperty, bool>(@class.method_0));
			return vproperty != null && vproperty.Value == @class.keyValuePair_0.Value;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00056240 File Offset: 0x00054440
		void ICollection<KeyValuePair<string, Class41>>.CopyTo(KeyValuePair<string, Class41>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (arrayIndex >= array.Length && arrayIndex != 0)
			{
				throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (this.Count > array.Length - arrayIndex)
			{
				throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				array[arrayIndex + i] = new KeyValuePair<string, Class41>(this.list_0[i].method_0(), this.list_0[i].Value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00003024 File Offset: 0x00001224
		bool ICollection<KeyValuePair<string, Class41>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003027 File Offset: 0x00001227
		bool ICollection<KeyValuePair<string, Class41>>.Remove(KeyValuePair<string, Class41> item)
		{
			if (!((ICollection<KeyValuePair<string, Class41>>)this).Contains(item))
			{
				return false;
			}
			((IDictionary<string, Class41>)this).Remove(item.Key);
			return true;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003043 File Offset: 0x00001243
		protected override DynamicMetaObject GetMetaObject(Expression expression_0)
		{
			return new DynamicProxyMetaObject<VObject>(expression_0, this, new VObject.VObjectDynamicProxy());
		}

		// Token: 0x04000091 RID: 145
		private readonly List<VProperty> list_0;

		// Token: 0x0200003A RID: 58
		private sealed class VObjectDynamicProxy : Class15<VObject>
		{
			// Token: 0x060000B5 RID: 181 RVA: 0x00003051 File Offset: 0x00001251
			public override IEnumerable<string> vmethod_0(VObject vobject_0)
			{
				return Enumerable.Select<VProperty, string>(vobject_0.vmethod_1(), new Func<VProperty, string>(VObject.VObjectDynamicProxy.<>c.<>9.method_0));
			}
		}

		// Token: 0x0200003C RID: 60
		[CompilerGenerated]
		private sealed class Class35
		{
			// Token: 0x060000BB RID: 187 RVA: 0x00003099 File Offset: 0x00001299
			internal bool method_0(VProperty vproperty_0)
			{
				return vproperty_0.method_0() == this.string_0;
			}

			// Token: 0x04000094 RID: 148
			public string string_0;
		}

		// Token: 0x0200003E RID: 62
		[CompilerGenerated]
		private sealed class Class36
		{
			// Token: 0x060000C0 RID: 192 RVA: 0x000030B8 File Offset: 0x000012B8
			internal bool method_0(VProperty vproperty_0)
			{
				return vproperty_0.method_0() == this.string_0;
			}

			// Token: 0x04000097 RID: 151
			public string string_0;
		}

		// Token: 0x0200003F RID: 63
		[CompilerGenerated]
		private sealed class Class37
		{
			// Token: 0x060000C2 RID: 194 RVA: 0x000030CB File Offset: 0x000012CB
			internal bool method_0(VProperty vproperty_0)
			{
				return vproperty_0.method_0() == this.string_0;
			}

			// Token: 0x04000098 RID: 152
			public string string_0;
		}

		// Token: 0x02000040 RID: 64
		[CompilerGenerated]
		private sealed class Class38
		{
			// Token: 0x060000C4 RID: 196 RVA: 0x000030DE File Offset: 0x000012DE
			internal bool method_0(VProperty vproperty_0)
			{
				return vproperty_0.method_0() == this.string_0;
			}

			// Token: 0x04000099 RID: 153
			public string string_0;
		}

		// Token: 0x02000042 RID: 66
		[CompilerGenerated]
		private sealed class Class40
		{
			// Token: 0x060000CD RID: 205 RVA: 0x0000312F File Offset: 0x0000132F
			internal bool method_0(VProperty vproperty_0)
			{
				return vproperty_0.method_0() == this.keyValuePair_0.Key;
			}

			// Token: 0x0400009E RID: 158
			public KeyValuePair<string, Class41> keyValuePair_0;
		}
	}
}
