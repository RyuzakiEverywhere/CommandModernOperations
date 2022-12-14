using System;
using System.Collections;
using System.Collections.Generic;
using DotSpatial.Topology.Utilities;
using ns25;
using ns27;
using ns29;

namespace DotSpatial.Topology
{
	// Token: 0x02000B21 RID: 2849
	[Serializable]
	public sealed class GeometryFactory : IGeometryFactory
	{
		// Token: 0x06004748 RID: 18248 RVA: 0x0002D236 File Offset: 0x0002B436
		public GeometryFactory(PrecisionModel precisionModel_0, int int_0, ICoordinateSequenceFactory icoordinateSequenceFactory_0)
		{
			this._precisionModel = precisionModel_0;
			this._coordinateSequenceFactory = icoordinateSequenceFactory_0;
			this._srid = int_0;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x0002D253 File Offset: 0x0002B453
		public GeometryFactory(PrecisionModel precisionModel_0) : this(precisionModel_0, 0, GeometryFactory.smethod_4())
		{
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x0002D262 File Offset: 0x0002B462
		public GeometryFactory(PrecisionModel precisionModel_0, int int_0) : this(precisionModel_0, int_0, GeometryFactory.smethod_4())
		{
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x0002D271 File Offset: 0x0002B471
		public GeometryFactory() : this(new PrecisionModel(), 0)
		{
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x0002D27F File Offset: 0x0002B47F
		public PrecisionModelType imethod_1()
		{
			return this._precisionModel.vmethod_2();
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x0002D28C File Offset: 0x0002B48C
		public int imethod_0()
		{
			return this._srid;
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x0002D294 File Offset: 0x0002B494
		public IPoint imethod_3(Coordinate coordinate_0)
		{
			return new Point(coordinate_0, this);
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x002E8438 File Offset: 0x002E6638
		public Interface31 imethod_4(Interface23[] interface23_0)
		{
			if (interface23_0 == null)
			{
				return new Class2064();
			}
			int num = interface23_0.Length;
			LineString[] array = new LineString[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new LineString(interface23_0[i]);
			}
			return new Class2064(array);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x0002D29D File Offset: 0x0002B49D
		public IGeometryCollection imethod_5(IGeometry[] igeometry_0)
		{
			return new GeometryCollection(igeometry_0, this);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x0002D2A6 File Offset: 0x0002B4A6
		public IMultiPolygon imethod_6(IPolygon[] ipolygon_0)
		{
			return new MultiPolygon(ipolygon_0, this);
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x0002D2AF File Offset: 0x0002B4AF
		public ILinearRing imethod_7(IList<Coordinate> ilist_0)
		{
			return new LinearRing(ilist_0);
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x0002D2B7 File Offset: 0x0002B4B7
		public IMultiPoint vmethod_0(IEnumerable<Coordinate> ienumerable_0)
		{
			return new MultiPoint(ienumerable_0, this);
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x0002D2C0 File Offset: 0x0002B4C0
		public IMultiPoint imethod_8(IEnumerable<Interface24> ienumerable_0)
		{
			return new MultiPoint(ienumerable_0);
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
		public IPolygon imethod_10(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1)
		{
			return new Polygon(ilinearRing_0, ilinearRing_1, this);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x002E8478 File Offset: 0x002E6678
		public IGeometry imethod_2(IList ilist_0)
		{
			Type type = null;
			bool flag = false;
			foreach (object obj in ilist_0)
			{
				Geometry geometry = (Geometry)obj;
				Type type2 = geometry.GetType();
				if (type == null)
				{
					type = type2;
				}
				if (type2 != type)
				{
					flag = true;
				}
			}
			if (type == null)
			{
				return this.imethod_5(null);
			}
			if (flag)
			{
				return this.imethod_5(GeometryFactory.smethod_1(ilist_0));
			}
			IEnumerator enumerator2 = ilist_0.GetEnumerator();
			enumerator2.MoveNext();
			Geometry geometry2 = (Geometry)enumerator2.Current;
			if (ilist_0.Count <= 1)
			{
				return geometry2;
			}
			if (geometry2 is Polygon)
			{
				return this.imethod_6(GeometryFactory.smethod_3(ilist_0));
			}
			if (geometry2 is LineString)
			{
				return this.imethod_4(GeometryFactory.smethod_2(ilist_0));
			}
			if (geometry2 is Point)
			{
				return new MultiPoint(GeometryFactory.smethod_0(ilist_0));
			}
			throw new Exception22();
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x0002D2D2 File Offset: 0x0002B4D2
		public ILineString imethod_9(IList<Coordinate> ilist_0)
		{
			return new LineString(ilist_0, this);
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x0002D2DB File Offset: 0x0002B4DB
		public static IPoint[] smethod_0(IList ilist_0)
		{
			return (Point[])new ArrayList(ilist_0).ToArray(typeof(Point));
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x0002D2F7 File Offset: 0x0002B4F7
		public static IGeometry[] smethod_1(IList ilist_0)
		{
			if (ilist_0 == null)
			{
				return null;
			}
			return (Geometry[])new ArrayList(ilist_0).ToArray(typeof(Geometry));
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x0002D318 File Offset: 0x0002B518
		public static ILineString[] smethod_2(IList ilist_0)
		{
			return (LineString[])new ArrayList(ilist_0).ToArray(typeof(LineString));
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x0002D334 File Offset: 0x0002B534
		public static IPolygon[] smethod_3(IList ilist_0)
		{
			return (Polygon[])new ArrayList(ilist_0).ToArray(typeof(Polygon));
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x0002D350 File Offset: 0x0002B550
		private static ICoordinateSequenceFactory smethod_4()
		{
			return CoordinateArraySequenceFactory.Instance;
		}

		// Token: 0x04002DDB RID: 11739
		private static GeometryFactory _default = new GeometryFactory();

		// Token: 0x04002DDC RID: 11740
		private static GeometryFactory _floating = new GeometryFactory();

		// Token: 0x04002DDD RID: 11741
		private static GeometryFactory _floatingSingle = new GeometryFactory(new PrecisionModel(PrecisionModelType.FloatingSingle));

		// Token: 0x04002DDE RID: 11742
		private static GeometryFactory _fixed = new GeometryFactory(new PrecisionModel(PrecisionModelType.Fixed));

		// Token: 0x04002DDF RID: 11743
		private readonly ICoordinateSequenceFactory _coordinateSequenceFactory;

		// Token: 0x04002DE0 RID: 11744
		private readonly PrecisionModel _precisionModel;

		// Token: 0x04002DE1 RID: 11745
		private readonly int _srid;
	}
}
