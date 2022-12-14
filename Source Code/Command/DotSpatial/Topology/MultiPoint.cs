using System;
using System.Collections;
using System.Collections.Generic;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B56 RID: 2902
	[Serializable]
	public sealed class MultiPoint : GeometryCollection, IEnumerable, ICloneable, IComparable, Interface20, IGeometry, IGeometryCollection, IMultiPoint
	{
		// Token: 0x060048B8 RID: 18616 RVA: 0x0002E086 File Offset: 0x0002C286
		public MultiPoint(IEnumerable<Coordinate> ienumerable_0, IGeometryFactory igeometryFactory_0) : base(MultiPoint.smethod_3(ienumerable_0), igeometryFactory_0)
		{
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x0002E03E File Offset: 0x0002C23E
		public MultiPoint(Interface20 interface20_0) : base(interface20_0, Geometry.DefaultFactory)
		{
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x0002E095 File Offset: 0x0002C295
		public MultiPoint(IEnumerable<Interface24> ienumerable_0) : base(MultiPoint.smethod_4(ienumerable_0), Geometry.DefaultFactory)
		{
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x170003C7 RID: 967
		public IPoint this[int int_0]
		{
			get
			{
				return base[int_0] as IPoint;
			}
			set
			{
				base[int_0] = value;
			}
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x002EB3B0 File Offset: 0x002E95B0
		private static IEnumerable<Interface20> smethod_3(IEnumerable<Coordinate> ienumerable_0)
		{
			List<Interface20> list = new List<Interface20>();
			foreach (Coordinate coordinate_ in ienumerable_0)
			{
				list.Add(new Point(coordinate_));
			}
			return list;
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x002EB408 File Offset: 0x002E9608
		private static IEnumerable<Interface20> smethod_4(IEnumerable<Interface24> ienumerable_0)
		{
			List<Interface20> list = new List<Interface20>();
			foreach (Interface24 interface24_ in ienumerable_0)
			{
				list.Add(new Point(interface24_));
			}
			return list;
		}

		// Token: 0x04002E47 RID: 11847
		public new static readonly IMultiPoint Empty = new MultiPoint(new Point[0]);
	}
}
