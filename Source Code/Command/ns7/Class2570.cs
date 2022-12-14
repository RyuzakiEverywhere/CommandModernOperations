using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Media.Imaging;
using Microsoft.VisualBasic.CompilerServices;

namespace ns7
{
	// Token: 0x02000F55 RID: 3925
	[StandardModule]
	internal sealed class Class2570
	{
		// Token: 0x06008C4E RID: 35918 RVA: 0x004B7ACC File Offset: 0x004B5CCC
		public static BitmapImage smethod_0(Bitmap bitmap_0)
		{
			BitmapImage result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bitmap_0.Save(memoryStream, ImageFormat.Png);
				memoryStream.Position = 0L;
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = memoryStream;
				bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
				bitmapImage.EndInit();
				result = bitmapImage;
			}
			return result;
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x00053C07 File Offset: 0x00051E07
		public static BitmapImage smethod_1(string string_0)
		{
			BitmapImage bitmapImage = new BitmapImage();
			bitmapImage.BeginInit();
			bitmapImage.StreamSource = new MemoryStream(Convert.FromBase64String(string_0));
			bitmapImage.EndInit();
			return bitmapImage;
		}
	}
}
