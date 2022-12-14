using System;

namespace DotSpatial.Topology
{
	// Token: 0x02000B5B RID: 2907
	[Serializable]
	public sealed class PrecisionModel : IComparable
	{
		// Token: 0x060048F8 RID: 18680 RVA: 0x0002E32A File Offset: 0x0002C52A
		public PrecisionModel()
		{
			this._modelType = PrecisionModelType.Floating;
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x0002E339 File Offset: 0x0002C539
		public PrecisionModel(PrecisionModelType precisionModelType_0)
		{
			this._modelType = precisionModelType_0;
			if (precisionModelType_0 == PrecisionModelType.Fixed)
			{
				this._scale = 1.0;
			}
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x0002E35B File Offset: 0x0002C55B
		public PrecisionModel(double double_0)
		{
			this._modelType = PrecisionModelType.Fixed;
			this._scale = double_0;
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x0002E371 File Offset: 0x0002C571
		public PrecisionModel(PrecisionModel precisionModel_0)
		{
			this._modelType = precisionModel_0._modelType;
			this._scale = precisionModel_0._scale;
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x002EB828 File Offset: 0x002E9A28
		public int vmethod_0()
		{
			switch (this._modelType)
			{
			case PrecisionModelType.Floating:
				return 16;
			case PrecisionModelType.FloatingSingle:
				return 6;
			case PrecisionModelType.Fixed:
				return 1 + (int)Math.Ceiling(Math.Log(this.vmethod_1()) / Math.Log(10.0));
			default:
				throw new ArgumentOutOfRangeException(this._modelType.ToString());
			}
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x0002E391 File Offset: 0x0002C591
		public double vmethod_1()
		{
			return this._scale;
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x002EB88C File Offset: 0x002E9A8C
		public int CompareTo(object target)
		{
			PrecisionModel precisionModel = (PrecisionModel)target;
			int num = this.vmethod_0();
			int value = precisionModel.vmethod_0();
			return num.CompareTo(value);
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00006E41 File Offset: 0x00005041
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x0002E399 File Offset: 0x0002C599
		public PrecisionModelType vmethod_2()
		{
			return this._modelType;
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x002EB8B8 File Offset: 0x002E9AB8
		public double vmethod_3(double double_0)
		{
			if (this._modelType == PrecisionModelType.FloatingSingle)
			{
				float num = (float)double_0;
				return (double)num;
			}
			if (this._modelType == PrecisionModelType.Fixed)
			{
				return Math.Floor(double_0 * this._scale + 0.5) / this._scale;
			}
			return double_0;
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x0002E3A1 File Offset: 0x0002C5A1
		public void vmethod_4(Coordinate coordinate_0)
		{
			if (this._modelType == PrecisionModelType.Floating)
			{
				return;
			}
			coordinate_0.X = this.vmethod_3(coordinate_0.X);
			coordinate_0.Y = this.vmethod_3(coordinate_0.Y);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x002EB900 File Offset: 0x002E9B00
		public override string ToString()
		{
			string result = "UNKNOWN";
			if (this._modelType == PrecisionModelType.Floating)
			{
				result = "Floating";
			}
			else if (this._modelType == PrecisionModelType.FloatingSingle)
			{
				result = "Floating-Single";
			}
			else if (this._modelType == PrecisionModelType.Fixed)
			{
				result = "Fixed (Scale=" + this.vmethod_1() + ")";
			}
			return result;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x002EB95C File Offset: 0x002E9B5C
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is PrecisionModel))
			{
				return false;
			}
			PrecisionModel precisionModel = (PrecisionModel)obj;
			return this._modelType == precisionModel._modelType && this._scale == precisionModel._scale;
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		public static bool smethod_0(PrecisionModel precisionModel_0, PrecisionModel precisionModel_1)
		{
			return object.Equals(precisionModel_0, precisionModel_1);
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
		public static bool smethod_1(PrecisionModel precisionModel_0, PrecisionModel precisionModel_1)
		{
			return !PrecisionModel.smethod_0(precisionModel_0, precisionModel_1);
		}

		// Token: 0x04002E50 RID: 11856
		private const int FLOATING_PRECISION_DIGITS = 16;

		// Token: 0x04002E51 RID: 11857
		private const int FLOATING_SINGLE_PRECISION_DIGITS = 6;

		// Token: 0x04002E52 RID: 11858
		private const int FIXED_PRECISION_DIGITS = 1;

		// Token: 0x04002E53 RID: 11859
		public const double MAXIMUM_PRECISE_VALUE = 9007199254740992.0;

		// Token: 0x04002E54 RID: 11860
		private readonly PrecisionModelType _modelType;

		// Token: 0x04002E55 RID: 11861
		private double _scale;
	}
}
