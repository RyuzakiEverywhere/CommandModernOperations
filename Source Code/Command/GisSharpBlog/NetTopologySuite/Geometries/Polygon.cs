using System;
using GeoAPI.Geometries;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000562 RID: 1378
	[Serializable]
	public sealed class Polygon : Geometry, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry, IPolygon
	{
		// Token: 0x06002802 RID: 10242 RVA: 0x002C3B90 File Offset: 0x002C1D90
		public Polygon(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (ilinearRing_0 == null)
			{
				ilinearRing_0 = base.imethod_0().imethod_6(null);
			}
			if (ilinearRing_1 == null)
			{
				ilinearRing_1 = new ILinearRing[0];
			}
			if (Geometry.smethod_1(ilinearRing_1))
			{
				throw new ArgumentException("holes must not contain null elements");
			}
			if (ilinearRing_0.imethod_10() && Geometry.smethod_0(ilinearRing_1))
			{
				throw new ArgumentException("shell is empty but holes are not");
			}
			this.shell = ilinearRing_0;
			this.holes = ilinearRing_1;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x002C3C18 File Offset: 0x002C1E18
		public override ICoordinate imethod_5()
		{
			return this.shell.imethod_5();
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x002C3C34 File Offset: 0x002C1E34
		public override ICoordinate[] imethod_6()
		{
			ICoordinate[] result;
			if (this.imethod_10())
			{
				result = new ICoordinate[0];
			}
			else
			{
				ICoordinate[] array = new ICoordinate[this.imethod_3()];
				int num = -1;
				ICoordinate[] array2 = this.shell.imethod_6();
				for (int i = 0; i < array2.Length; i++)
				{
					num++;
					array[num] = array2[i];
				}
				for (int j = 0; j < this.holes.Length; j++)
				{
					ICoordinate[] array3 = this.holes[j].imethod_6();
					for (int k = 0; k < array3.Length; k++)
					{
						num++;
						array[num] = array3[k];
					}
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x002C3CE0 File Offset: 0x002C1EE0
		public override int imethod_3()
		{
			int num = this.shell.imethod_3();
			for (int i = 0; i < this.holes.Length; i++)
			{
				num += this.holes[i].imethod_3();
			}
			return num;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x0000C629 File Offset: 0x0000A829
		public override Dimensions imethod_7()
		{
			return Dimensions.Surface;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000041ED File Offset: 0x000023ED
		public override Dimensions imethod_4()
		{
			return Dimensions.Curve;
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00013253 File Offset: 0x00011453
		public override bool imethod_10()
		{
			return this.shell.imethod_10();
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x002C3D24 File Offset: 0x002C1F24
		public ILineString imethod_11()
		{
			return this.shell;
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x002C3D3C File Offset: 0x002C1F3C
		public int imethod_13()
		{
			return this.holes.Length;
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x002C3D54 File Offset: 0x002C1F54
		public ILineString[] imethod_14()
		{
			return this.holes;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x002C3D6C File Offset: 0x002C1F6C
		public ILineString imethod_15(int int_0)
		{
			return this.holes[int_0];
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x002C3D84 File Offset: 0x002C1F84
		protected override IEnvelope vmethod_1()
		{
			return this.shell.imethod_8();
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x002C3DA0 File Offset: 0x002C1FA0
		public override object Clone()
		{
			Polygon polygon = (Polygon)base.Clone();
			polygon.shell = (LinearRing)this.shell.Clone();
			polygon.holes = new ILinearRing[this.holes.Length];
			for (int i = 0; i < this.holes.Length; i++)
			{
				polygon.holes[i] = (LinearRing)this.holes[i].Clone();
			}
			return polygon;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x002C3E14 File Offset: 0x002C2014
		protected internal override int vmethod_2(object object_0)
		{
			LinearRing linearRing = (LinearRing)this.shell;
			ILinearRing object_ = ((IPolygon)object_0).imethod_12();
			return linearRing.vmethod_2(object_);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x002C3E44 File Offset: 0x002C2044
		public ILinearRing imethod_12()
		{
			return this.shell;
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x002C3E5C File Offset: 0x002C205C
		public ILinearRing[] imethod_16()
		{
			return this.holes;
		}

		// Token: 0x040020FE RID: 8446
		public static readonly IPolygon Empty = new GeometryFactory().imethod_7(null, null);

		// Token: 0x040020FF RID: 8447
		protected ILinearRing shell = null;

		// Token: 0x04002100 RID: 8448
		protected ILinearRing[] holes;
	}
}
