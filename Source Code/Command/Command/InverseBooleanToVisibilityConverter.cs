using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using Microsoft.VisualBasic.CompilerServices;
using ns7;

namespace Command
{
	// Token: 0x02000F4F RID: 3919
	[Attribute12]
	[Attribute13]
	[Attribute11]
	public sealed class InverseBooleanToVisibilityConverter : IValueConverter
	{
		// Token: 0x06008C2B RID: 35883 RVA: 0x004B7844 File Offset: 0x004B5A44
		private object method_0(object value)
		{
			object result;
			if (!(value is bool))
			{
				result = Visibility.Visible;
			}
			else if (Conversions.ToBoolean(value))
			{
				result = Visibility.Collapsed;
			}
			else
			{
				result = Visibility.Visible;
			}
			return result;
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x00053A54 File Offset: 0x00051C54
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return this.method_0(RuntimeHelpers.GetObjectValue(value));
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x00002F8D File Offset: 0x0000118D
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
