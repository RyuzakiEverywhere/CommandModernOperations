using System;
using System.Collections.Generic;
using System.Globalization;

namespace ns0
{
	// Token: 0x02000038 RID: 56
	internal static class Class34
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00002F0E File Offset: 0x0000110E
		public static U Value<U>(IEnumerable<Class41> ienumerable_0)
		{
			return Class34.Value<Class41, U>(ienumerable_0);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002F16 File Offset: 0x00001116
		public static U Value<T, U>(IEnumerable<T> ienumerable_0) where T : Class41
		{
			Class33.smethod_0(ienumerable_0, "value");
			Class41 @class = ienumerable_0 as Class41;
			if (@class == null)
			{
				throw new ArgumentException("Source value must be a JToken.");
			}
			return Class34.smethod_0<Class41, U>(@class);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00055E40 File Offset: 0x00054040
		internal static U smethod_0<T, U>(T gparam_0) where T : Class41
		{
			if (gparam_0 == null)
			{
				return default(U);
			}
			if (gparam_0 is U && typeof(U) != typeof(IComparable) && typeof(U) != typeof(IFormattable))
			{
				return (U)((object)gparam_0);
			}
			Class42 @class = gparam_0 as Class42;
			if (@class == null)
			{
				throw new InvalidCastException(string.Format("Cannot cast {0} to {1}.", gparam_0.GetType(), typeof(T)));
			}
			object value = @class.Value;
			if (value is U)
			{
				return (U)((object)value);
			}
			Type type = typeof(U);
			if (Class30.smethod_0(type))
			{
				if (@class.Value == null)
				{
					return default(U);
				}
				type = Nullable.GetUnderlyingType(type);
			}
			U result;
			if (Class34.smethod_1<U>(@class.Value, out result))
			{
				return result;
			}
			return (U)((object)Convert.ChangeType(@class.Value, type, CultureInfo.InvariantCulture));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00055F54 File Offset: 0x00054154
		private static bool smethod_1<U>(object value, out U result)
		{
			result = default(U);
			if (typeof(U) == typeof(bool) || Nullable.GetUnderlyingType(typeof(U)) == typeof(bool))
			{
				string text = value as string;
				if (text != null && text != null)
				{
					if (text == "1")
					{
						result = (U)((object)true);
						return true;
					}
					if (text == "0")
					{
						result = (U)((object)false);
						return true;
					}
				}
			}
			return false;
		}
	}
}
