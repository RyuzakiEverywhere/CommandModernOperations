using System;
using System.ComponentModel;

namespace DotSpatial
{
	// Token: 0x02000BF9 RID: 3065
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class SerializeExtent : ICloneable
	{
		// Token: 0x06004C15 RID: 19477 RVA: 0x002F5174 File Offset: 0x002F3374
		public SerializeExtent()
		{
			this.XMin = double.MaxValue;
			this.XMax = double.MinValue;
			this.YMin = double.MaxValue;
			this.YMax = double.MinValue;
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x000301AF File Offset: 0x0002E3AF
		public SerializeExtent(double double_0, double double_1, double double_2, double double_3)
		{
			this.XMin = double_0;
			this.YMin = double_1;
			this.XMax = double_2;
			this.YMax = double_3;
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x000301D4 File Offset: 0x0002E3D4
		public object Clone()
		{
			return new SerializeExtent(this.XMin, this.YMin, this.XMax, this.YMax);
		}

		// Token: 0x04002F9A RID: 12186
		public double XMax;

		// Token: 0x04002F9B RID: 12187
		public double XMin;

		// Token: 0x04002F9C RID: 12188
		public double YMax;

		// Token: 0x04002F9D RID: 12189
		public double YMin;
	}
}
