using System;
using System.Text;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000570 RID: 1392
	[Serializable]
	public class CoordinateArraySequence : ICloneable, ICoordinateSequence
	{
		// Token: 0x0600284F RID: 10319 RVA: 0x00013501 File Offset: 0x00011701
		public CoordinateArraySequence(ICoordinate[] icoordinate_0)
		{
			this.coordinates = icoordinate_0;
			if (icoordinate_0 == null)
			{
				this.coordinates = new ICoordinate[0];
			}
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x002C4688 File Offset: 0x002C2888
		public ICoordinate imethod_0(int int_0)
		{
			return this.coordinates[int_0];
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x002C46A0 File Offset: 0x002C28A0
		public virtual object Clone()
		{
			ICoordinate[] icoordinate_ = this.method_0();
			return new CoordinateArraySequence(icoordinate_);
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x002C46BC File Offset: 0x002C28BC
		protected ICoordinate[] method_0()
		{
			ICoordinate[] array = new ICoordinate[this.Count];
			for (int i = 0; i < this.coordinates.Length; i++)
			{
				array[i] = (ICoordinate)this.coordinates[i].Clone();
			}
			return array;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x002C4704 File Offset: 0x002C2904
		public int Count
		{
			get
			{
				return this.coordinates.Length;
			}
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x002C471C File Offset: 0x002C291C
		public void imethod_1(int int_0, Enum157 enum157_0, double double_0)
		{
			switch (enum157_0)
			{
			case Enum157.const_0:
				this.coordinates[int_0].imethod_1(double_0);
				break;
			case Enum157.const_1:
				this.coordinates[int_0].imethod_3(double_0);
				break;
			case Enum157.const_2:
				this.coordinates[int_0].imethod_5(double_0);
				break;
			default:
				throw new ArgumentException("invalid ordinate index: " + enum157_0);
			}
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x002C4784 File Offset: 0x002C2984
		public ICoordinate[] imethod_2()
		{
			return this.coordinates;
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x002C479C File Offset: 0x002C299C
		public override string ToString()
		{
			string result;
			if (this.coordinates.Length > 0)
			{
				StringBuilder stringBuilder = new StringBuilder(17 * this.coordinates.Length);
				stringBuilder.Append('(');
				stringBuilder.Append(this.coordinates[0]);
				for (int i = 1; i < this.coordinates.Length; i++)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(this.coordinates[i]);
				}
				stringBuilder.Append(')');
				result = stringBuilder.ToString();
			}
			else
			{
				result = "()";
			}
			return result;
		}

		// Token: 0x0400211E RID: 8478
		protected ICoordinate[] coordinates;
	}
}
