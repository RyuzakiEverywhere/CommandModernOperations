using System;
using System.Collections;
using GeoAPI.Geometries;
using ns14;
using ns15;
using ns16;
using ns17;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000514 RID: 1300
	[Serializable]
	public abstract class Geometry : IComparable<IGeometry>, IEquatable<IGeometry>, ICloneable, IComparable, IGeometry
	{
		// Token: 0x06002600 RID: 9728 RVA: 0x002BDF0C File Offset: 0x002BC10C
		public IGeometryFactory imethod_0()
		{
			return this.factory;
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00012543 File Offset: 0x00010743
		public Geometry(IGeometryFactory igeometryFactory_0)
		{
			this.factory = igeometryFactory_0;
			this.srid = igeometryFactory_0.imethod_1();
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x002BDF24 File Offset: 0x002BC124
		protected static bool smethod_0(IGeometry[] igeometry_0)
		{
			foreach (IGeometry geometry in igeometry_0)
			{
				if (!geometry.imethod_10())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x002BDF58 File Offset: 0x002BC158
		public static bool smethod_1(object[] object_0)
		{
			foreach (object obj in object_0)
			{
				if (obj == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x002BDF90 File Offset: 0x002BC190
		public IPrecisionModel imethod_1()
		{
			return this.imethod_0().imethod_2();
		}

		// Token: 0x06002605 RID: 9733
		public abstract ICoordinate imethod_5();

		// Token: 0x06002606 RID: 9734
		public abstract ICoordinate[] imethod_6();

		// Token: 0x06002607 RID: 9735
		public abstract int imethod_3();

		// Token: 0x06002608 RID: 9736 RVA: 0x000041ED File Offset: 0x000023ED
		public virtual int imethod_2()
		{
			return 1;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x002BDFAC File Offset: 0x002BC1AC
		public virtual IGeometry imethod_9(int int_0)
		{
			return this;
		}

		// Token: 0x0600260A RID: 9738
		public abstract bool imethod_10();

		// Token: 0x0600260B RID: 9739 RVA: 0x002BDFBC File Offset: 0x002BC1BC
		public virtual Dimensions imethod_7()
		{
			return this.dimension;
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x002BDFD4 File Offset: 0x002BC1D4
		public virtual Dimensions imethod_4()
		{
			return this.boundaryDimension;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x002BDFEC File Offset: 0x002BC1EC
		public IEnvelope imethod_8()
		{
			if (this.envelope == null)
			{
				this.envelope = this.vmethod_1();
			}
			return this.envelope;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x002BE01C File Offset: 0x002BC21C
		public Class590 vmethod_0(IGeometry igeometry_0)
		{
			this.method_1(this);
			this.method_1(igeometry_0);
			return Class682.smethod_0(this, igeometry_0);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x002BE040 File Offset: 0x002BC240
		public bool Equals(IGeometry other)
		{
			bool result;
			if (this.imethod_10() && other.imethod_10())
			{
				result = true;
			}
			else if (!this.imethod_8().imethod_9(other.imethod_8()))
			{
				result = false;
			}
			else if (this.method_2(this) || this.method_2(other))
			{
				result = Geometry.smethod_2(this, other);
			}
			else
			{
				result = this.vmethod_0(other).method_6(this.imethod_7(), other.imethod_7());
			}
			return result;
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x002BE0BC File Offset: 0x002BC2BC
		private static bool smethod_2(IGeometry igeometry_0, IGeometry igeometry_1)
		{
			IGeometryCollection geometryCollection = igeometry_0 as IGeometryCollection;
			IGeometryCollection geometryCollection2 = igeometry_1 as IGeometryCollection;
			bool result;
			if (geometryCollection == null || geometryCollection2 == null)
			{
				result = false;
			}
			else if (geometryCollection.imethod_2() != geometryCollection2.imethod_2())
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < geometryCollection.imethod_2(); i++)
				{
					IGeometry geometry = geometryCollection[i];
					IGeometry other = geometryCollection2[i];
					if (!geometry.Equals(other))
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x002BE138 File Offset: 0x002BC338
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType().Namespace != obj.GetType().Namespace) && this.Equals((IGeometry)obj);
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x002BE184 File Offset: 0x002BC384
		public override int GetHashCode()
		{
			int num = 17;
			foreach (Coordinate coordinate in this.imethod_6())
			{
				num = 37 * num + coordinate.imethod_0().GetHashCode();
			}
			return num;
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x002BE1D0 File Offset: 0x002BC3D0
		public override string ToString()
		{
			return this.method_0();
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x002BE1E8 File Offset: 0x002BC3E8
		public string method_0()
		{
			Class659 @class = new Class659();
			return @class.vmethod_0(this);
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x002BE204 File Offset: 0x002BC404
		public virtual object Clone()
		{
			Geometry geometry = (Geometry)base.MemberwiseClone();
			if (geometry.envelope != null)
			{
				geometry.envelope = new Envelope(geometry.envelope);
			}
			return geometry;
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x002BE23C File Offset: 0x002BC43C
		public int CompareTo(object target)
		{
			return this.CompareTo((IGeometry)target);
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x002BE258 File Offset: 0x002BC458
		public int CompareTo(IGeometry other)
		{
			Geometry geometry = (Geometry)other;
			int result;
			if (this.method_4() != geometry.method_4())
			{
				result = this.method_4() - geometry.method_4();
			}
			else if (this.imethod_10() && geometry.imethod_10())
			{
				result = 0;
			}
			else if (this.imethod_10())
			{
				result = -1;
			}
			else if (geometry.imethod_10())
			{
				result = 1;
			}
			else
			{
				result = this.vmethod_2(other);
			}
			return result;
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x0001256C File Offset: 0x0001076C
		protected void method_1(IGeometry igeometry_0)
		{
			if (this.method_2(igeometry_0))
			{
				throw new ArgumentException("This method does not support GeometryCollection arguments");
			}
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x00012585 File Offset: 0x00010785
		private bool method_2(IGeometry igeometry_0)
		{
			return igeometry_0.GetType().Name == "GeometryCollection" && igeometry_0.GetType().Namespace == base.GetType().Namespace;
		}

		// Token: 0x0600261A RID: 9754
		protected abstract IEnvelope vmethod_1();

		// Token: 0x0600261B RID: 9755
		protected internal abstract int vmethod_2(object object_0);

		// Token: 0x0600261C RID: 9756 RVA: 0x002BE2D0 File Offset: 0x002BC4D0
		protected int method_3(ArrayList arrayList_0, ArrayList arrayList_1)
		{
			IEnumerator enumerator = arrayList_0.GetEnumerator();
			IEnumerator enumerator2 = arrayList_1.GetEnumerator();
			while (enumerator.MoveNext() && enumerator2.MoveNext())
			{
				IComparable comparable = (IComparable)enumerator.Current;
				IComparable obj = (IComparable)enumerator2.Current;
				int num = comparable.CompareTo(obj);
				if (num != 0)
				{
					return num;
				}
			}
			if (enumerator.MoveNext())
			{
				return 1;
			}
			if (enumerator2.MoveNext())
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x002BE358 File Offset: 0x002BC558
		private int method_4()
		{
			for (int i = 0; i < Geometry.SortedClasses.Length; i++)
			{
				if (base.GetType().Equals(Geometry.SortedClasses[i]))
				{
					return i;
				}
			}
			Class597.smethod_2(string.Format("Class not supported: {0}", base.GetType().FullName));
			return -1;
		}

		// Token: 0x0400203B RID: 8251
		private static readonly Type[] SortedClasses = new Type[]
		{
			typeof(Point),
			typeof(MultiPoint),
			typeof(LineString),
			typeof(LinearRing),
			typeof(Class622),
			typeof(Polygon),
			typeof(MultiPolygon),
			typeof(GeometryCollection)
		};

		// Token: 0x0400203C RID: 8252
		private IGeometryFactory factory = null;

		// Token: 0x0400203D RID: 8253
		private object userData = null;

		// Token: 0x0400203E RID: 8254
		protected IEnvelope envelope;

		// Token: 0x0400203F RID: 8255
		private int srid;

		// Token: 0x04002040 RID: 8256
		private Dimensions dimension;

		// Token: 0x04002041 RID: 8257
		private IGeometry boundary;

		// Token: 0x04002042 RID: 8258
		private Dimensions boundaryDimension;

		// Token: 0x04002043 RID: 8259
		public static readonly IGeometryFactory DefaultFactory = GeometryFactory.Default;
	}
}
