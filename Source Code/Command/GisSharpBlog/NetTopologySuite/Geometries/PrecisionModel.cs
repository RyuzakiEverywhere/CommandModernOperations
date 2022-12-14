using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000510 RID: 1296
	[Serializable]
	public sealed class PrecisionModel : IComparable<IPrecisionModel>, IEquatable<IPrecisionModel>, IComparable, IPrecisionModel
	{
		// Token: 0x060025DE RID: 9694 RVA: 0x000123F5 File Offset: 0x000105F5
		public PrecisionModel()
		{
			this.modelType = PrecisionModels.Floating;
		}

		// Token: 0x060025DF RID: 9695 RVA: 0x00012404 File Offset: 0x00010604
		public PrecisionModel(PrecisionModels precisionModels_0)
		{
			this.modelType = precisionModels_0;
			if (precisionModels_0 == PrecisionModels.Fixed)
			{
				this.method_0(1.0);
			}
		}

		// Token: 0x060025E0 RID: 9696 RVA: 0x002BD96C File Offset: 0x002BBB6C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060025E1 RID: 9697 RVA: 0x002BD984 File Offset: 0x002BBB84
		public int imethod_1()
		{
			int result;
			switch (this.modelType)
			{
			case PrecisionModels.Floating:
				result = 16;
				break;
			case PrecisionModels.FloatingSingle:
				result = 6;
				break;
			case PrecisionModels.Fixed:
				result = 1 + (int)Math.Ceiling(Math.Log(this.imethod_2()) / Math.Log(10.0));
				break;
			default:
				throw new ArgumentOutOfRangeException(this.modelType.ToString());
			}
			return result;
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x002BD9F0 File Offset: 0x002BBBF0
		public double imethod_2()
		{
			return this.scale;
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x0001242B File Offset: 0x0001062B
		public void method_0(double double_0)
		{
			this.scale = Math.Abs(double_0);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x002BDA08 File Offset: 0x002BBC08
		public PrecisionModels imethod_0()
		{
			return this.modelType;
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x002BDA20 File Offset: 0x002BBC20
		public double vmethod_0(double double_0)
		{
			double result;
			if (this.modelType == PrecisionModels.FloatingSingle)
			{
				float num = (float)double_0;
				result = (double)num;
			}
			else if (this.modelType == PrecisionModels.Fixed)
			{
				result = Math.Floor(double_0 * this.scale + 0.5) / this.scale;
			}
			else
			{
				result = double_0;
			}
			return result;
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00012439 File Offset: 0x00010639
		public void imethod_3(ICoordinate icoordinate_0)
		{
			if (this.modelType != PrecisionModels.Floating)
			{
				icoordinate_0.imethod_1(this.vmethod_0(icoordinate_0.imethod_0()));
				icoordinate_0.imethod_3(this.vmethod_0(icoordinate_0.imethod_2()));
			}
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x002BDA78 File Offset: 0x002BBC78
		public override string ToString()
		{
			string result = "UNKNOWN";
			if (this.modelType == PrecisionModels.Floating)
			{
				result = "Floating";
			}
			else if (this.modelType == PrecisionModels.FloatingSingle)
			{
				result = "Floating-Single";
			}
			else if (this.modelType == PrecisionModels.Fixed)
			{
				result = "Fixed (Scale=" + this.imethod_2() + ")";
			}
			return result;
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x002BDAE4 File Offset: 0x002BBCE4
		public override bool Equals(object obj)
		{
			return obj != null && obj is IPrecisionModel && this.Equals((IPrecisionModel)obj);
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x0001246D File Offset: 0x0001066D
		public bool Equals(IPrecisionModel other)
		{
			return this.modelType == other.imethod_0() && this.scale == other.imethod_2();
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x002BDB1C File Offset: 0x002BBD1C
		public int CompareTo(object target)
		{
			return this.CompareTo((IPrecisionModel)target);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x002BDB38 File Offset: 0x002BBD38
		public int CompareTo(IPrecisionModel other)
		{
			int num = this.imethod_1();
			int value = other.imethod_1();
			return num.CompareTo(value);
		}

		// Token: 0x04002031 RID: 8241
		private const int FloatingPrecisionDigits = 16;

		// Token: 0x04002032 RID: 8242
		private const int FloatingSinglePrecisionDigits = 6;

		// Token: 0x04002033 RID: 8243
		private const int FixedPrecisionDigits = 1;

		// Token: 0x04002034 RID: 8244
		public const double MaximumPreciseValue = 9007199254740992.0;

		// Token: 0x04002035 RID: 8245
		private PrecisionModels modelType;

		// Token: 0x04002036 RID: 8246
		private double scale;
	}
}
