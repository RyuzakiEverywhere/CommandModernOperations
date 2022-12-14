using System;
using System.Collections;
using System.Collections.Generic;
using ns25;
using ns26;
using ns27;
using ns28;
using ns30;

namespace DotSpatial.Topology
{
	// Token: 0x02000B1A RID: 2842
	[Serializable]
	public abstract class Geometry : ICloneable, IComparable, Interface20, IGeometry
	{
		// Token: 0x060046FD RID: 18173 RVA: 0x0002D067 File Offset: 0x0002B267
		protected Geometry()
		{
			if (Geometry.DefaultFactory == null)
			{
				Geometry.DefaultFactory = new GeometryFactory(new PrecisionModel(PrecisionModelType.Floating));
			}
			this._factory = Geometry.DefaultFactory;
			this._srid = this._factory.imethod_0();
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x0002D0A2 File Offset: 0x0002B2A2
		protected Geometry(IGeometryFactory igeometryFactory_0)
		{
			this._factory = igeometryFactory_0;
			this._srid = igeometryFactory_0.imethod_0();
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x002E7C78 File Offset: 0x002E5E78
		private int method_0()
		{
			for (int i = 0; i < Geometry.SortedClasses.Length; i++)
			{
				if (base.GetType().Equals(Geometry.SortedClasses[i]))
				{
					return i;
				}
			}
			throw new Exception18(base.GetType().FullName);
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x0002D0BD File Offset: 0x0002B2BD
		public IGeometryFactory imethod_13()
		{
			return this._factory;
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x0002D0C5 File Offset: 0x0002B2C5
		public virtual PrecisionModelType imethod_15()
		{
			return this.imethod_13().imethod_1();
		}

		// Token: 0x06004702 RID: 18178
		public abstract Coordinate imethod_11();

		// Token: 0x06004703 RID: 18179
		public abstract IList<Coordinate> imethod_0();

		// Token: 0x06004704 RID: 18180
		public abstract void imethod_1(IList<Coordinate> ilist_0);

		// Token: 0x06004705 RID: 18181
		public abstract int imethod_3();

		// Token: 0x06004706 RID: 18182 RVA: 0x000041ED File Offset: 0x000023ED
		public virtual int imethod_2()
		{
			return 1;
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x00006C77 File Offset: 0x00004E77
		public virtual IGeometry imethod_10(int int_0)
		{
			return this;
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00006C77 File Offset: 0x00004E77
		public virtual Interface20 imethod_4(int int_0)
		{
			return this;
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x002E7CC0 File Offset: 0x002E5EC0
		public virtual bool vmethod_0()
		{
			Class2208 @class = new Class2208(this);
			return @class.vmethod_0();
		}

		// Token: 0x0600470A RID: 18186
		public abstract bool imethod_14();

		// Token: 0x0600470B RID: 18187 RVA: 0x0002D0D2 File Offset: 0x0002B2D2
		public virtual IEnvelope imethod_12()
		{
			if (this._envelope == null)
			{
				this._envelope = this.vmethod_4();
			}
			return this._envelope;
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x0002D0EE File Offset: 0x0002B2EE
		public virtual void imethod_9()
		{
			this._envelope = null;
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x0002D0F7 File Offset: 0x0002B2F7
		public override string ToString()
		{
			return this.vmethod_2();
		}

		// Token: 0x0600470E RID: 18190
		public abstract void imethod_5(Interface27 interface27_0);

		// Token: 0x0600470F RID: 18191
		public abstract void imethod_6(Interface28 interface28_0);

		// Token: 0x06004710 RID: 18192
		public abstract void imethod_7(Interface21 interface21_0);

		// Token: 0x06004711 RID: 18193 RVA: 0x002E7CDC File Offset: 0x002E5EDC
		object ICloneable.Clone()
		{
			Geometry geometry = (Geometry)base.MemberwiseClone();
			this.vmethod_3(geometry);
			return geometry;
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x002E7D00 File Offset: 0x002E5F00
		public virtual int CompareTo(object target)
		{
			Geometry geometry = target as Geometry;
			if (geometry == null)
			{
				Coordinate coordinate_ = target as Coordinate;
				if (Coordinate.smethod_1(coordinate_, null))
				{
					IEnvelope envelope = target as IEnvelope;
					if (envelope == null)
					{
						throw new ApplicationException("the specified object could not be treated like a geometry.");
					}
					geometry = (Class2062.smethod_5(envelope) as Geometry);
				}
				else
				{
					geometry = new Point(coordinate_);
				}
			}
			if (geometry != null)
			{
				if (this.method_0() != geometry.method_0())
				{
					return this.method_0() - geometry.method_0();
				}
				if (this.imethod_14() && geometry.imethod_14())
				{
					return 0;
				}
			}
			if (this.imethod_14())
			{
				return -1;
			}
			if (geometry == null)
			{
				return 1;
			}
			if (!geometry.imethod_14())
			{
				return this.imethod_8(geometry);
			}
			return 1;
		}

		// Token: 0x06004713 RID: 18195
		public abstract int imethod_8(object object_0);

		// Token: 0x06004714 RID: 18196 RVA: 0x0002D0FF File Offset: 0x0002B2FF
		public virtual IGeometry vmethod_1(double double_0, int int_0)
		{
			return Class2179.smethod_1(this, double_0, int_0);
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x002E7DA4 File Offset: 0x002E5FA4
		public static IGeometry smethod_0(Interface20 interface20_0)
		{
			Interface26 @interface = interface20_0 as Interface26;
			if (@interface != null)
			{
				return new Polygon(@interface);
			}
			Interface23 interface2 = interface20_0 as Interface23;
			if (interface2 != null)
			{
				return new LineString(interface2);
			}
			Interface25 interface3 = interface20_0 as Interface25;
			if (interface3 != null)
			{
				return new Point(interface3);
			}
			Interface20 interface4 = interface20_0.imethod_4(0);
			@interface = (interface4 as Interface26);
			if (@interface != null)
			{
				return new MultiPolygon(interface20_0);
			}
			interface2 = (interface4 as Interface23);
			if (interface2 != null)
			{
				return new Class2064(interface20_0);
			}
			interface3 = (interface4 as Interface25);
			if (interface3 != null)
			{
				return new MultiPoint(interface20_0);
			}
			return null;
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x002E7E20 File Offset: 0x002E6020
		protected static bool smethod_1(IGeometry[] igeometry_0)
		{
			foreach (IGeometry geometry in igeometry_0)
			{
				if (!geometry.imethod_14())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x002E7E50 File Offset: 0x002E6050
		protected static bool smethod_2(IEnumerable<Interface20> ienumerable_0)
		{
			foreach (Interface20 @interface in ienumerable_0)
			{
				if (@interface == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x002E7E9C File Offset: 0x002E609C
		public virtual string vmethod_2()
		{
			Class2110 @class = new Class2110();
			return @class.vmethod_0(this);
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x0000378C File Offset: 0x0000198C
		protected virtual void vmethod_3(Geometry geometry_0)
		{
		}

		// Token: 0x0600471A RID: 18202
		protected abstract IEnvelope vmethod_4();

		// Token: 0x0600471B RID: 18203 RVA: 0x002E7EB8 File Offset: 0x002E60B8
		protected virtual int vmethod_5(ArrayList arrayList_0, ArrayList arrayList_1)
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

		// Token: 0x04002DCB RID: 11723
		private readonly IGeometryFactory _factory;

		// Token: 0x04002DCC RID: 11724
		private IEnvelope _envelope;

		// Token: 0x04002DCD RID: 11725
		private int _srid;

		// Token: 0x04002DCE RID: 11726
		private object _userData;

		// Token: 0x04002DCF RID: 11727
		private static readonly Type[] SortedClasses = new Type[]
		{
			typeof(Point),
			typeof(MultiPoint),
			typeof(LineString),
			typeof(LinearRing),
			typeof(Class2064),
			typeof(Polygon),
			typeof(MultiPolygon),
			typeof(GeometryCollection)
		};

		// Token: 0x04002DD0 RID: 11728
		public static GeometryFactory DefaultFactory = new GeometryFactory();

		// Token: 0x04002DD1 RID: 11729
		private IGeometry _boundary;

		// Token: 0x04002DD2 RID: 11730
		private DimensionType _boundaryDimension;

		// Token: 0x04002DD3 RID: 11731
		private DimensionType _dimension;

		// Token: 0x02000B1B RID: 2843
		private sealed class Class2065 : Interface21
		{
			// Token: 0x0600471D RID: 18205 RVA: 0x0002D109 File Offset: 0x0002B309
			public void imethod_0(IGeometry igeometry_0)
			{
				igeometry_0.imethod_9();
			}
		}
	}
}
