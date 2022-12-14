using System;
using System.Collections.Generic;
using ns25;
using ns29;

namespace DotSpatial.Topology
{
	// Token: 0x02000B58 RID: 2904
	[Serializable]
	public sealed class Point : Geometry, ICloneable, IComparable, Interface20, IGeometry, Interface24, Interface25, IPoint
	{
		// Token: 0x060048C4 RID: 18628 RVA: 0x0002E0E4 File Offset: 0x0002C2E4
		public Point()
		{
			this._coordinates.Add(new Coordinate());
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x0002E107 File Offset: 0x0002C307
		public Point(Coordinate coordinate_0) : this(coordinate_0, new GeometryFactory())
		{
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x0002E115 File Offset: 0x0002C315
		public Point(Interface24 interface24_0) : this(new Coordinate(interface24_0), new GeometryFactory())
		{
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x0002E128 File Offset: 0x0002C328
		public Point(Coordinate coordinate_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			this._coordinates.Add(coordinate_0);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x0002E148 File Offset: 0x0002C348
		public Point(double double_0, double double_1) : this(new Coordinate(double_0, double_1), Geometry.DefaultFactory)
		{
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x0002E15C File Offset: 0x0002C35C
		public override void imethod_5(Interface27 interface27_0)
		{
			if (this.imethod_14())
			{
				return;
			}
			interface27_0.imethod_0(this.imethod_11());
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x0002DED5 File Offset: 0x0002C0D5
		public override void imethod_6(Interface28 interface28_0)
		{
			interface28_0.imethod_0(this);
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x0002DEDE File Offset: 0x0002C0DE
		public override void imethod_7(Interface21 interface21_0)
		{
			interface21_0.imethod_0(this);
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x002EB460 File Offset: 0x002E9660
		public override int imethod_8(object object_0)
		{
			Point point = (Point)object_0;
			return this.imethod_11().CompareTo(point.imethod_11());
		}

		// Token: 0x170003C8 RID: 968
		public double this[int int_0]
		{
			get
			{
				return this.imethod_11()[int_0];
			}
			set
			{
				this.imethod_11()[int_0] = value;
			}
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x002EB488 File Offset: 0x002E9688
		protected override void vmethod_3(Geometry geometry_0)
		{
			base.vmethod_3(geometry_0);
			Point point = geometry_0 as Point;
			if (point != null)
			{
				point.method_1(Class2231.smethod_0<Coordinate>(this.imethod_11()));
			}
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x002EB4B8 File Offset: 0x002E96B8
		protected override IEnvelope vmethod_4()
		{
			if (this.imethod_14())
			{
				return new Envelope();
			}
			return new Envelope(this.imethod_11().X, this.imethod_11().X, this.imethod_11().Y, this.imethod_11().Y);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x0002E190 File Offset: 0x0002C390
		public override Coordinate imethod_11()
		{
			if (this._coordinates == null)
			{
				this._coordinates = new List<Coordinate>();
			}
			if (this._coordinates.Count == 0)
			{
				this._coordinates.Add(new Coordinate());
			}
			return this._coordinates[0];
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x0002E1CE File Offset: 0x0002C3CE
		public override IList<Coordinate> imethod_0()
		{
			return this._coordinates;
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x0002E1D6 File Offset: 0x0002C3D6
		public override void imethod_1(IList<Coordinate> ilist_0)
		{
			this._coordinates = ilist_0;
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x0002E1DF File Offset: 0x0002C3DF
		public override bool imethod_14()
		{
			return Coordinate.smethod_1(this.imethod_11(), null);
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x0002E1ED File Offset: 0x0002C3ED
		public double imethod_16()
		{
			if (Coordinate.smethod_1(this.imethod_11(), null))
			{
				throw new ArgumentOutOfRangeException();
			}
			return this.imethod_11().M;
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x0002E20E File Offset: 0x0002C40E
		public override int imethod_3()
		{
			if (!this.imethod_14())
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x0002E21B File Offset: 0x0002C41B
		public double[] imethod_17()
		{
			return this.imethod_11().method_0();
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x0002E228 File Offset: 0x0002C428
		public double imethod_18()
		{
			return this.imethod_11().X;
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x0002E235 File Offset: 0x0002C435
		public double imethod_19()
		{
			return this.imethod_11().Y;
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x0002E242 File Offset: 0x0002C442
		public double imethod_20()
		{
			return this.imethod_11().Z;
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x0002E24F File Offset: 0x0002C44F
		public void method_1(Coordinate coordinate_0)
		{
			if (this._coordinates == null)
			{
				this._coordinates = new List<Coordinate>();
			}
			if (this._coordinates.Count == 0)
			{
				this._coordinates.Add(coordinate_0);
				return;
			}
			this._coordinates[0] = coordinate_0;
		}

		// Token: 0x04002E49 RID: 11849
		private const Coordinate EMPTY_COORDINATE = null;

		// Token: 0x04002E4A RID: 11850
		private IList<Coordinate> _coordinates = new List<Coordinate>();

		// Token: 0x04002E4B RID: 11851
		private int _recordNumber;

		// Token: 0x04002E4C RID: 11852
		public static readonly IPoint Empty = new GeometryFactory().imethod_3(null);
	}
}
