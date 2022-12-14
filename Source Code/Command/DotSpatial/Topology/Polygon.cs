using System;
using System.Collections.Generic;
using ns25;
using ns27;
using ns29;

namespace DotSpatial.Topology
{
	// Token: 0x02000B59 RID: 2905
	[Serializable]
	public sealed class Polygon : Geometry, ICloneable, IComparable, Interface20, IGeometry, Interface26, IPolygon
	{
		// Token: 0x060048DE RID: 18654 RVA: 0x0002E29D File Offset: 0x0002C49D
		public Polygon(ILinearRing ilinearRing_0) : this(ilinearRing_0, null, Geometry.DefaultFactory)
		{
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x002EB504 File Offset: 0x002E9704
		public Polygon(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (ilinearRing_0 == null)
			{
				ilinearRing_0 = base.imethod_13().imethod_7(null);
			}
			if (ilinearRing_1 == null)
			{
				ilinearRing_1 = new LinearRing[0];
			}
			if (Geometry.smethod_2(ilinearRing_1))
			{
				throw new Exception14(Class2111.smethod_7());
			}
			if (ilinearRing_0.imethod_14() && Geometry.smethod_1(ilinearRing_1))
			{
				throw new Exception14(Class2111.smethod_8());
			}
			this._shell = ilinearRing_0;
			this._holes = ilinearRing_1;
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x002EB570 File Offset: 0x002E9770
		public Polygon(Interface26 interface26_0) : base(Geometry.DefaultFactory)
		{
			this.method_2(interface26_0.imethod_5());
			LinearRing linearRing = new LinearRing(interface26_0.imethod_6());
			if (Geometry.smethod_2(this._holes))
			{
				throw new Exception14(Class2111.smethod_7());
			}
			if (linearRing.imethod_14() && Geometry.smethod_1(this._holes))
			{
				throw new Exception14(Class2111.smethod_8());
			}
			this._shell = linearRing;
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x002EB5E0 File Offset: 0x002E97E0
		public override void imethod_5(Interface27 interface27_0)
		{
			this._shell.imethod_5(interface27_0);
			for (int i = 0; i < this._holes.Length; i++)
			{
				this._holes[i].imethod_5(interface27_0);
			}
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x0002DED5 File Offset: 0x0002C0D5
		public override void imethod_6(Interface28 interface28_0)
		{
			interface28_0.imethod_0(this);
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x002EB61C File Offset: 0x002E981C
		public override void imethod_7(Interface21 interface21_0)
		{
			interface21_0.imethod_0(this);
			this._shell.imethod_7(interface21_0);
			for (int i = 0; i < this._holes.Length; i++)
			{
				this._holes[i].imethod_7(interface21_0);
			}
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x002EB660 File Offset: 0x002E9860
		public override int imethod_8(object object_0)
		{
			ILinearRing shell = this._shell;
			ILinearRing object_ = ((IPolygon)object_0).imethod_17();
			return shell.imethod_8(object_);
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x0002E2AC File Offset: 0x0002C4AC
		public ILineString imethod_19(int int_0)
		{
			return this._holes[int_0];
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x002EB688 File Offset: 0x002E9888
		protected override void vmethod_3(Geometry geometry_0)
		{
			base.vmethod_3(geometry_0);
			Polygon polygon = geometry_0 as Polygon;
			if (polygon == null)
			{
				return;
			}
			polygon.vmethod_7(Class2231.smethod_0<ILinearRing>(this._shell));
			polygon.method_1(new ILinearRing[this._holes.Length]);
			for (int i = 0; i < this._holes.Length; i++)
			{
				polygon.imethod_18()[i] = Class2231.smethod_0<ILinearRing>(this.imethod_18()[i]);
			}
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x0002E2B6 File Offset: 0x0002C4B6
		protected override IEnvelope vmethod_4()
		{
			return this._shell.imethod_12();
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x0002E2C3 File Offset: 0x0002C4C3
		public Interface23 vmethod_6()
		{
			return this._shell;
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x0002E2CB File Offset: 0x0002C4CB
		public override Coordinate imethod_11()
		{
			return this._shell.imethod_11();
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x002EB6F4 File Offset: 0x002E98F4
		public override IList<Coordinate> imethod_0()
		{
			if (this.imethod_14())
			{
				return new Coordinate[0];
			}
			List<Coordinate> list = new List<Coordinate>();
			list.AddRange(this.imethod_17().imethod_0());
			foreach (ILinearRing linearRing in this.imethod_18())
			{
				list.AddRange(linearRing.imethod_0());
			}
			return list;
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
		public override void imethod_1(IList<Coordinate> ilist_0)
		{
			this.imethod_17().imethod_1(ilist_0);
		}

		// Token: 0x060048EC RID: 18668 RVA: 0x0002E2E6 File Offset: 0x0002C4E6
		public ILinearRing[] imethod_18()
		{
			return this._holes;
		}

		// Token: 0x060048ED RID: 18669 RVA: 0x0002E2EE File Offset: 0x0002C4EE
		public void method_1(ILinearRing[] ilinearRing_0)
		{
			this._holes = ilinearRing_0;
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x0002E2E6 File Offset: 0x0002C4E6
		ICollection<Interface23> Interface26.imethod_5()
		{
			return this._holes;
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x0002E2F7 File Offset: 0x0002C4F7
		public override bool imethod_14()
		{
			return this._shell.imethod_14();
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x0002E304 File Offset: 0x0002C504
		public int imethod_16()
		{
			return this._holes.Length;
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x002EB750 File Offset: 0x002E9950
		public override int imethod_3()
		{
			int num = this._shell.imethod_3();
			for (int i = 0; i < this._holes.Length; i++)
			{
				num += this._holes[i].imethod_3();
			}
			return num;
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x0002E2C3 File Offset: 0x0002C4C3
		public ILinearRing imethod_17()
		{
			return this._shell;
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x0002E30E File Offset: 0x0002C50E
		public void vmethod_7(ILinearRing ilinearRing_0)
		{
			this._shell = ilinearRing_0;
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0002E2C3 File Offset: 0x0002C4C3
		Interface23 Interface26.imethod_6()
		{
			return this._shell;
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x002EB790 File Offset: 0x002E9990
		private void method_2(ICollection<Interface23> icollection_0)
		{
			if (icollection_0 == null || icollection_0.Count == 0)
			{
				this._holes = new ILinearRing[0];
				return;
			}
			this._holes = (icollection_0 as ILinearRing[]);
			if (this._holes != null)
			{
				return;
			}
			List<ILinearRing> list = new List<ILinearRing>();
			foreach (Interface23 interface20_ in icollection_0)
			{
				list.Add(new LinearRing(Geometry.smethod_0(interface20_) as ILineString));
			}
			this._holes = list.ToArray();
		}

		// Token: 0x04002E4D RID: 11853
		private ILinearRing[] _holes;

		// Token: 0x04002E4E RID: 11854
		private ILinearRing _shell;

		// Token: 0x04002E4F RID: 11855
		public static readonly IPolygon Empty = new GeometryFactory().imethod_10(null, null);
	}
}
