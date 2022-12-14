using System;
using System.Collections.Generic;

namespace ns1
{
	// Token: 0x02000056 RID: 86
	internal sealed class Class52
	{
		// Token: 0x06000175 RID: 373 RVA: 0x000579A0 File Offset: 0x00055BA0
		private double method_0(Class51 class51_0, Class51 class51_1)
		{
			double num = class51_0.double_0 - class51_1.double_0;
			double num2 = class51_0.double_1 - class51_1.double_1;
			return num * num + num2 * num2;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000579D0 File Offset: 0x00055BD0
		private double method_1(Class51 class51_0, Class51 class51_1, Class51 class51_2)
		{
			double num = class51_1.double_0;
			double num2 = class51_1.double_1;
			double num3 = class51_2.double_0 - num;
			double num4 = class51_2.double_1 - num2;
			if (!num3.Equals(0.0) || !num4.Equals(0.0))
			{
				double num5 = ((class51_0.double_0 - num) * num3 + (class51_0.double_1 - num2) * num4) / (num3 * num3 + num4 * num4);
				if (num5 > 1.0)
				{
					num = class51_2.double_0;
					num2 = class51_2.double_1;
				}
				else if (num5 > 0.0)
				{
					num += num3 * num5;
					num2 += num4 * num5;
				}
			}
			num3 = class51_0.double_0 - num;
			num4 = class51_0.double_1 - num2;
			return num3 * num3 + num4 * num4;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00057A94 File Offset: 0x00055C94
		private List<Class51> method_2(Class51[] class51_0, double double_0)
		{
			Class51 @class = class51_0[0];
			List<Class51> list = new List<Class51>
			{
				@class
			};
			Class51 class2 = null;
			for (int i = 1; i < class51_0.Length; i++)
			{
				class2 = class51_0[i];
				if (this.method_0(class2, @class) > double_0)
				{
					list.Add(class2);
					@class = class2;
				}
			}
			if (class2 != null && !@class.Equals(class2))
			{
				list.Add(class2);
			}
			return list;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00057AF0 File Offset: 0x00055CF0
		private List<Class51> method_3(Class51[] class51_0, double double_0)
		{
			int num = class51_0.Length;
			int?[] array = new int?[num];
			int? num2 = new int?(0);
			int? num3 = new int?(num - 1);
			int? num4 = new int?(0);
			List<int?> list = new List<int?>();
			List<Class51> list2 = new List<Class51>();
			array[num2.Value] = (array[num3.Value] = new int?(1));
			while (num3 != null)
			{
				double num5 = 0.0;
				int? num6 = num2 + 1;
				for (;;)
				{
					int? num7 = num6;
					int? num8 = num3;
					if (!(num7.GetValueOrDefault() < num8.GetValueOrDefault() & (num7 != null & num8 != null)))
					{
						break;
					}
					double num9 = this.method_1(class51_0[num6.Value], class51_0[num2.Value], class51_0[num3.Value]);
					if (num9 > num5)
					{
						num4 = num6;
						num5 = num9;
					}
					num6++;
				}
				if (num5 > double_0)
				{
					array[num4.Value] = new int?(1);
					list.AddRange(new int?[]
					{
						num2,
						num4,
						num4,
						num3
					});
				}
				if (list.Count > 0)
				{
					num3 = list[list.Count - 1];
					list.RemoveAt(list.Count - 1);
				}
				else
				{
					num3 = null;
				}
				if (list.Count > 0)
				{
					num2 = list[list.Count - 1];
					list.RemoveAt(list.Count - 1);
				}
				else
				{
					num2 = null;
				}
			}
			for (int i = 0; i < num; i++)
			{
				if (array[i] != null)
				{
					list2.Add(class51_0[i]);
				}
			}
			return list2;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00057D00 File Offset: 0x00055F00
		public List<Class51> vmethod_0(Class51[] points, double tolerance = 0.3, bool highestQuality = false)
		{
			if (points == null || points.Length == 0)
			{
				return new List<Class51>();
			}
			double double_ = tolerance * tolerance;
			if (highestQuality)
			{
				return this.method_3(points, double_);
			}
			List<Class51> list = this.method_2(points, double_);
			return this.method_3(list.ToArray(), double_);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00003803 File Offset: 0x00001A03
		public static List<Class51> smethod_0(Class51[] points, double tolerance = 0.3, bool highestQuality = false)
		{
			return new Class52().vmethod_0(points, tolerance, highestQuality);
		}
	}
}
