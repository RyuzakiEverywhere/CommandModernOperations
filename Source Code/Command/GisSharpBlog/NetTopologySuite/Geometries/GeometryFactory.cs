using System;
using GeoAPI.Geometries;
using ns14;
using ns16;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000572 RID: 1394
	[Serializable]
	public sealed class GeometryFactory : IGeometryFactory
	{
		// Token: 0x06002865 RID: 10341 RVA: 0x002C48C4 File Offset: 0x002C2AC4
		public IPrecisionModel imethod_2()
		{
			return this.precisionModel;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x002C48DC File Offset: 0x002C2ADC
		public ICoordinateSequenceFactory imethod_0()
		{
			return this.coordinateSequenceFactory;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x002C48F4 File Offset: 0x002C2AF4
		public int imethod_1()
		{
			return this.srid;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000135A2 File Offset: 0x000117A2
		public GeometryFactory(IPrecisionModel iprecisionModel_0, int int_0, ICoordinateSequenceFactory icoordinateSequenceFactory_0)
		{
			this.precisionModel = iprecisionModel_0;
			this.coordinateSequenceFactory = icoordinateSequenceFactory_0;
			this.srid = int_0;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x000135BF File Offset: 0x000117BF
		public GeometryFactory(IPrecisionModel iprecisionModel_0) : this(iprecisionModel_0, 0, GeometryFactory.smethod_0())
		{
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000135CE File Offset: 0x000117CE
		public GeometryFactory(PrecisionModel precisionModel_0, int int_0) : this(precisionModel_0, int_0, GeometryFactory.smethod_0())
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x000135DD File Offset: 0x000117DD
		public GeometryFactory() : this(new PrecisionModel(), 0)
		{
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x002C490C File Offset: 0x002C2B0C
		public IPoint imethod_3(ICoordinate icoordinate_0)
		{
			return this.vmethod_0((icoordinate_0 != null) ? this.imethod_0().imethod_0(new ICoordinate[]
			{
				icoordinate_0
			}) : null);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x002C4940 File Offset: 0x002C2B40
		public IPoint vmethod_0(ICoordinateSequence icoordinateSequence_0)
		{
			return new Point(icoordinateSequence_0, this);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x002C4958 File Offset: 0x002C2B58
		public ILineString imethod_4(ICoordinate[] icoordinate_0)
		{
			return this.vmethod_1((icoordinate_0 != null) ? this.imethod_0().imethod_0(icoordinate_0) : null);
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x002C4980 File Offset: 0x002C2B80
		public ILineString vmethod_1(ICoordinateSequence icoordinateSequence_0)
		{
			return new LineString(icoordinateSequence_0, this);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x002C4998 File Offset: 0x002C2B98
		public ILinearRing imethod_5(ICoordinate[] icoordinate_0)
		{
			return this.imethod_6((icoordinate_0 != null) ? this.imethod_0().imethod_0(icoordinate_0) : null);
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x002C49C0 File Offset: 0x002C2BC0
		public ILinearRing imethod_6(ICoordinateSequence icoordinateSequence_0)
		{
			return new LinearRing(icoordinateSequence_0, this);
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x002C49D8 File Offset: 0x002C2BD8
		public IPolygon imethod_7(ILinearRing ilinearRing_0, ILinearRing[] ilinearRing_1)
		{
			return new Polygon(ilinearRing_0, ilinearRing_1, this);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x002C49F0 File Offset: 0x002C2BF0
		public IMultiPoint imethod_8(IPoint[] ipoint_0)
		{
			return new MultiPoint(ipoint_0, this);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x002C4A08 File Offset: 0x002C2C08
		public Interface13 imethod_9(ILineString[] ilineString_0)
		{
			return new Class622(ilineString_0, this);
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x002C4A20 File Offset: 0x002C2C20
		public IMultiPolygon imethod_10(IPolygon[] ipolygon_0)
		{
			return new MultiPolygon(ipolygon_0, this);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x002C4A38 File Offset: 0x002C2C38
		public IGeometryCollection imethod_11(IGeometry[] igeometry_0)
		{
			return new GeometryCollection(igeometry_0, this);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x002C4A50 File Offset: 0x002C2C50
		private static ICoordinateSequenceFactory smethod_0()
		{
			return CoordinateArraySequenceFactory.smethod_0();
		}

		// Token: 0x04002120 RID: 8480
		public static readonly IGeometryFactory Default = new GeometryFactory();

		// Token: 0x04002121 RID: 8481
		public static readonly IGeometryFactory Floating = GeometryFactory.Default;

		// Token: 0x04002122 RID: 8482
		public static readonly IGeometryFactory FloatingSingle = new GeometryFactory(new PrecisionModel(PrecisionModels.FloatingSingle));

		// Token: 0x04002123 RID: 8483
		public static readonly IGeometryFactory Fixed = new GeometryFactory(new PrecisionModel(PrecisionModels.Fixed));

		// Token: 0x04002124 RID: 8484
		private IPrecisionModel precisionModel;

		// Token: 0x04002125 RID: 8485
		private ICoordinateSequenceFactory coordinateSequenceFactory;

		// Token: 0x04002126 RID: 8486
		private int srid;
	}
}
