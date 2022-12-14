using System;
using System.Collections.Generic;
using System.Globalization;

namespace ns5
{
	// Token: 0x02000D54 RID: 3412
	internal static class Class2409
	{
		// Token: 0x06005962 RID: 22882 RVA: 0x00315ABC File Offset: 0x00313CBC
		public static void smethod_0(string string_0, string string_1)
		{
			if (string_0 == null)
			{
				throw new ArgumentNullException(string_1);
			}
			if (string_0.Length == 0)
			{
				throw new ArgumentException(Class2407.smethod_0("'{0}' cannot be empty.", CultureInfo.InvariantCulture, new object[]
				{
					string_1
				}), string_1);
			}
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x00315B00 File Offset: 0x00313D00
		public static void smethod_1(Type type_0, string string_0)
		{
			Class2409.smethod_4(type_0, "enumType");
			if (!type_0.IsEnum)
			{
				throw new ArgumentException(Class2407.smethod_0("Type {0} is not an Enum.", CultureInfo.InvariantCulture, new object[]
				{
					type_0
				}), string_0);
			}
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00315B44 File Offset: 0x00313D44
		public static void smethod_2<T>(ICollection<T> icollection_0, string string_0)
		{
			Class2409.smethod_3<T>(icollection_0, string_0, Class2407.smethod_0("Collection '{0}' cannot be empty.", CultureInfo.InvariantCulture, new object[]
			{
				string_0
			}));
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x00039933 File Offset: 0x00037B33
		public static void smethod_3<T>(ICollection<T> icollection_0, string string_0, string string_1)
		{
			if (icollection_0 == null)
			{
				throw new ArgumentNullException(string_0);
			}
			if (icollection_0.Count == 0)
			{
				throw new ArgumentException(string_1, string_0);
			}
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x00002F02 File Offset: 0x00001102
		public static void smethod_4(object object_0, string string_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentNullException(string_0);
			}
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x0003994F File Offset: 0x00037B4F
		public static void smethod_5(bool bool_0, string string_0, string string_1)
		{
			if (!bool_0)
			{
				throw new ArgumentException(string_1, string_0);
			}
		}
	}
}
