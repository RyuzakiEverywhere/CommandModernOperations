using System;
using System.Collections;
using GeoAPI.Geometries;
using ns17;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000515 RID: 1301
	[Serializable]
	public class GeometryCollection : Geometry, IEnumerable, IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry, IGeometryCollection
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x000125BC File Offset: 0x000107BC
		public GeometryCollection(IGeometry[] igeometry_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (igeometry_0 == null)
			{
				igeometry_0 = new IGeometry[0];
			}
			if (Geometry.smethod_1(igeometry_0))
			{
				throw new ArgumentException("geometries must not contain null elements");
			}
			this.geometries = igeometry_0;
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x002BE440 File Offset: 0x002BC640
		public override ICoordinate imethod_5()
		{
			ICoordinate result;
			if (this.imethod_10())
			{
				result = null;
			}
			else
			{
				result = this.geometries[0].imethod_5();
			}
			return result;
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x002BE46C File Offset: 0x002BC66C
		public override ICoordinate[] imethod_6()
		{
			ICoordinate[] array = new ICoordinate[this.imethod_3()];
			int num = -1;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				ICoordinate[] array2 = this.geometries[i].imethod_6();
				for (int j = 0; j < array2.Length; j++)
				{
					num++;
					array[num] = array2[j];
				}
			}
			return array;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x002BE4D0 File Offset: 0x002BC6D0
		public override bool imethod_10()
		{
			for (int i = 0; i < this.geometries.Length; i++)
			{
				if (!this.geometries[i].imethod_10())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x002BE508 File Offset: 0x002BC708
		public override Dimensions imethod_7()
		{
			Dimensions dimensions = Dimensions.False;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				dimensions = (Dimensions)Math.Max((int)dimensions, (int)this.geometries[i].imethod_7());
			}
			return dimensions;
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x002BE544 File Offset: 0x002BC744
		public override Dimensions imethod_4()
		{
			Dimensions dimensions = Dimensions.False;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				dimensions = (Dimensions)Math.Max((int)dimensions, (int)this.geometries[i].imethod_4());
			}
			return dimensions;
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x002BE580 File Offset: 0x002BC780
		public override int imethod_2()
		{
			return this.geometries.Length;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x002BE598 File Offset: 0x002BC798
		public override IGeometry imethod_9(int int_0)
		{
			return this.geometries[int_0];
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x002BE5B0 File Offset: 0x002BC7B0
		public IGeometry[] imethod_11()
		{
			return this.geometries;
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x002BE5C8 File Offset: 0x002BC7C8
		public override int imethod_3()
		{
			int num = 0;
			for (int i = 0; i < this.geometries.Length; i++)
			{
				num += this.geometries[i].imethod_3();
			}
			return num;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x002BE600 File Offset: 0x002BC800
		public override object Clone()
		{
			GeometryCollection geometryCollection = (GeometryCollection)base.Clone();
			geometryCollection.geometries = new IGeometry[this.geometries.Length];
			for (int i = 0; i < this.geometries.Length; i++)
			{
				geometryCollection.geometries[i] = (IGeometry)this.geometries[i].Clone();
			}
			return geometryCollection;
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x002BE660 File Offset: 0x002BC860
		protected override IEnvelope vmethod_1()
		{
			IEnvelope envelope = new Envelope();
			for (int i = 0; i < this.geometries.Length; i++)
			{
				envelope.imethod_7(this.geometries[i].imethod_8());
			}
			return envelope;
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x002BE6A0 File Offset: 0x002BC8A0
		protected internal override int vmethod_2(object object_0)
		{
			ArrayList arrayList_ = new ArrayList(this.geometries);
			ArrayList arrayList_2 = new ArrayList(((GeometryCollection)object_0).geometries);
			return base.method_3(arrayList_, arrayList_2);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x002BE6D4 File Offset: 0x002BC8D4
		public IEnumerator GetEnumerator()
		{
			return new Class683(this);
		}

		// Token: 0x17000153 RID: 339
		public IGeometry this[int int_0]
		{
			get
			{
				return this.geometries[int_0];
			}
		}

		// Token: 0x04002044 RID: 8260
		public static readonly IGeometryCollection Empty = Geometry.DefaultFactory.imethod_11(null);

		// Token: 0x04002045 RID: 8261
		protected IGeometry[] geometries = null;
	}
}
