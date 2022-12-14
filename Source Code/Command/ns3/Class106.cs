using System;
using System.Drawing;

namespace ns3
{
	// Token: 0x020000B0 RID: 176
	internal static class Class106
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00063120 File Offset: 0x00061320
		internal static Bitmap smethod_0(Bitmap bitmap_0, Color color_0)
		{
			Bitmap bitmap = new Bitmap(bitmap_0.Width, bitmap_0.Height);
			for (int i = 0; i < bitmap_0.Width; i++)
			{
				for (int j = 0; j < bitmap_0.Height; j++)
				{
					if (bitmap_0.GetPixel(i, j).A > 0)
					{
						bitmap.SetPixel(i, j, color_0);
					}
				}
			}
			return bitmap;
		}
	}
}
