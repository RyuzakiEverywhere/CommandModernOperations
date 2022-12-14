using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4
{
	// Token: 0x02000DDA RID: 3546
	internal sealed class Class2453 : EnumConverter
	{
		// Token: 0x060066B6 RID: 26294 RVA: 0x00040F42 File Offset: 0x0003F142
		public Class2453(Type type_1) : base(type_1)
		{
			this.type_0 = type_1;
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x00040F52 File Offset: 0x0003F152
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x003868BC File Offset: 0x00384ABC
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			DescriptionAttribute descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(this.type_0.GetField(Enum.GetName(this.type_0, RuntimeHelpers.GetObjectValue(value))), typeof(DescriptionAttribute));
			object result;
			if (descriptionAttribute != null)
			{
				result = descriptionAttribute.Description;
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x00040F52 File Offset: 0x0003F152
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x00386910 File Offset: 0x00384B10
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			foreach (FieldInfo fieldInfo in this.type_0.GetFields())
			{
				DescriptionAttribute descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
				if (descriptionAttribute != null && Operators.CompareString(Conversions.ToString(value), descriptionAttribute.Description, false) == 0)
				{
					return Enum.Parse(this.type_0, fieldInfo.Name);
				}
			}
			return Enum.Parse(this.type_0, Conversions.ToString(value));
		}

		// Token: 0x04003A8E RID: 14990
		private Type type_0;
	}
}
