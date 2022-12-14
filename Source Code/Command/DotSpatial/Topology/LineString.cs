using System;
using System.Collections.Generic;
using System.Linq;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B51 RID: 2897
	[Serializable]
	public class LineString : Geometry, ICloneable, IComparable, Interface20, IGeometry, Interface23, ILineString
	{
		// Token: 0x06004883 RID: 18563 RVA: 0x0002DE73 File Offset: 0x0002C073
		public LineString(IList<Coordinate> ilist_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (ilist_0 == null)
			{
				ilist_0 = new Coordinate[0];
			}
			if (ilist_0.Count == 1)
			{
				throw new ArgumentException("point array must contain 0 or > 1 elements");
			}
			this._points = ilist_0;
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x0002DEA2 File Offset: 0x0002C0A2
		public LineString(IList<Coordinate> ilist_0) : base(Geometry.DefaultFactory)
		{
			if (ilist_0 == null)
			{
				ilist_0 = new Coordinate[0];
			}
			if (ilist_0.Count == 1)
			{
				throw new ArgumentException("point array must contain 0 or >1 elements");
			}
			this._points = ilist_0;
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x002EAA38 File Offset: 0x002E8C38
		public LineString(Interface23 interface23_0) : base(Geometry.DefaultFactory)
		{
			if (interface23_0.imethod_3() == 0)
			{
				this._points = new Coordinate[0];
			}
			if (interface23_0.imethod_3() == 1)
			{
				throw new ArgumentException("point array must contain 0 or > 1 elements");
			}
			this._points = interface23_0.imethod_0();
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x002EAA84 File Offset: 0x002E8C84
		public LineString(IEnumerable<Coordinate> ienumerable_0) : base(Geometry.DefaultFactory)
		{
			if (ienumerable_0 == null)
			{
				this._points = new List<Coordinate>();
				return;
			}
			this._points = (ienumerable_0 as IList<Coordinate>);
			if (this._points != null)
			{
				return;
			}
			this._points = new List<Coordinate>();
			foreach (Coordinate item in ienumerable_0)
			{
				this._points.Add(item);
			}
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x002EAB0C File Offset: 0x002E8D0C
		public override void imethod_5(Interface27 interface27_0)
		{
			foreach (Coordinate coordinate_ in this._points)
			{
				interface27_0.imethod_0(coordinate_);
			}
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x0002DED5 File Offset: 0x0002C0D5
		public override void imethod_6(Interface28 interface28_0)
		{
			interface28_0.imethod_0(this);
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x0002DEDE File Offset: 0x0002C0DE
		public override void imethod_7(Interface21 interface21_0)
		{
			interface21_0.imethod_0(this);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x002EAB5C File Offset: 0x002E8D5C
		public override int imethod_8(object object_0)
		{
			LineString lineString = object_0 as LineString;
			int num = 0;
			int num2 = 0;
			if (lineString != null)
			{
				while (num < this._points.Count && num2 < lineString._points.Count)
				{
					int num3 = this._points[num].CompareTo(lineString._points[num2]);
					if (num3 != 0)
					{
						return num3;
					}
					num++;
					num2++;
				}
			}
			if (num < this._points.Count)
			{
				return 1;
			}
			if (lineString != null && num2 < lineString._points.Count)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x002EABE8 File Offset: 0x002E8DE8
		protected override IEnvelope vmethod_4()
		{
			if (this.imethod_14())
			{
				return new Envelope();
			}
			double num = this._points[0].X;
			double num2 = this._points[0].Y;
			double num3 = this._points[0].X;
			double num4 = this._points[0].Y;
			for (int i = 1; i < this._points.Count; i++)
			{
				num = ((num < this._points[i].X) ? num : this._points[i].X);
				num3 = ((num3 > this._points[i].X) ? num3 : this._points[i].X);
				num2 = ((num2 < this._points[i].Y) ? num2 : this._points[i].Y);
				num4 = ((num4 > this._points[i].Y) ? num4 : this._points[i].Y);
			}
			return new Envelope(num, num3, num2, num4);
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x002EAD20 File Offset: 0x002E8F20
		protected override void vmethod_3(Geometry geometry_0)
		{
			base.vmethod_3(geometry_0);
			LineString lineString = geometry_0 as LineString;
			if (lineString == null)
			{
				return;
			}
			lineString.imethod_1(new List<Coordinate>());
			foreach (Coordinate item in this._points)
			{
				lineString.imethod_0().Add(item);
			}
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x0002DEE7 File Offset: 0x0002C0E7
		public virtual Coordinate vmethod_6(int int_0)
		{
			return this._points[int_0];
		}

		// Token: 0x170003C5 RID: 965
		public virtual Coordinate this[int int_0]
		{
			get
			{
				return this._points[int_0];
			}
			set
			{
				this._points[int_0] = value;
			}
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x0002DF04 File Offset: 0x0002C104
		public override Coordinate imethod_11()
		{
			if (this.imethod_14())
			{
				return null;
			}
			return Enumerable.First<Coordinate>(this._points);
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x0002DF1B File Offset: 0x0002C11B
		public override IList<Coordinate> imethod_0()
		{
			return this._points;
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x0002DF23 File Offset: 0x0002C123
		public override void imethod_1(IList<Coordinate> ilist_0)
		{
			this._points = ilist_0;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x0002DF2C File Offset: 0x0002C12C
		public virtual bool imethod_16()
		{
			return !this.imethod_14() && new Coordinate(this.vmethod_6(0)).method_2(this.vmethod_6(this.imethod_3() - 1));
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x0002DF57 File Offset: 0x0002C157
		public override bool imethod_14()
		{
			return this._points.Count == 0;
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x0002DF67 File Offset: 0x0002C167
		public override int imethod_3()
		{
			return this._points.Count;
		}

		// Token: 0x04002E42 RID: 11842
		public static readonly ILineString Empty = new GeometryFactory().imethod_9(new Coordinate[0]);

		// Token: 0x04002E43 RID: 11843
		private IList<Coordinate> _points;
	}
}
