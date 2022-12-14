using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Microsoft.VisualBasic.CompilerServices;
using ns7;

namespace Command
{
	// Token: 0x02000F4E RID: 3918
	[Attribute11]
	[Attribute12]
	[Attribute13]
	public sealed class BooleanToVisibilityConverter : IValueConverter
	{
		// Token: 0x06008C27 RID: 35879 RVA: 0x004B780C File Offset: 0x004B5A0C
		private object method_0(object value)
		{
			object result;
			if (!(value is bool))
			{
				result = Visibility.Collapsed;
			}
			else if (Conversions.ToBoolean(value))
			{
				result = Visibility.Visible;
			}
			else
			{
				result = Visibility.Collapsed;
			}
			return result;
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x00053A46 File Offset: 0x00051C46
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return this.method_0(RuntimeHelpers.GetObjectValue(value));
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x00002F8D File Offset: 0x0000118D
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
