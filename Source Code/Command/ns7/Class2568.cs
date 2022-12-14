using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace ns7
{
	// Token: 0x02000F52 RID: 3922
	internal sealed class Class2568 : IValueConverter
	{
		// Token: 0x06008C3C RID: 35900 RVA: 0x004B7940 File Offset: 0x004B5B40
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double num = Conversions.ToDouble(value);
			Brush result = Brushes.Green;
			if (num >= 90.0)
			{
				result = Brushes.Red;
			}
			else if (num >= 60.0)
			{
				result = Brushes.Yellow;
			}
			return result;
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x00002F8D File Offset: 0x0000118D
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
