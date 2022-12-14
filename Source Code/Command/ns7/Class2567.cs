using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace ns7
{
	// Token: 0x02000F4D RID: 3917
	internal sealed class Class2567 : IValueConverter
	{
		// Token: 0x06008C24 RID: 35876 RVA: 0x004B77CC File Offset: 0x004B59CC
		object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string text = value as string;
			object result;
			if (text == null)
			{
				result = null;
			}
			else
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = new MemoryStream(Convert.FromBase64String(text));
				bitmapImage.EndInit();
				result = bitmapImage;
			}
			return result;
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x00002F8D File Offset: 0x0000118D
		object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
