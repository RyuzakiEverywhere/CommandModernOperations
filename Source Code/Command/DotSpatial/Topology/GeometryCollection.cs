using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ns25;

namespace DotSpatial.Topology
{
	// Token: 0x02000B1E RID: 2846
	[Serializable]
	public class GeometryCollection : Geometry, IEnumerable, ICloneable, IComparable, Interface20, IGeometry, IGeometryCollection
	{
		// Token: 0x06004722 RID: 18210 RVA: 0x0002D111 File Offset: 0x0002B311
		protected GeometryCollection() : base(Geometry.DefaultFactory)
		{
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x0002D11E File Offset: 0x0002B31E
		public GeometryCollection(IGeometry[] igeometry_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (igeometry_0 == null)
			{
				igeometry_0 = new IGeometry[0];
			}
			if (Geometry.smethod_2(igeometry_0))
			{
				throw new ArgumentException("geometries must not contain null elements");
			}
			this._geometries = igeometry_0;
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x002E7FB0 File Offset: 0x002E61B0
		public GeometryCollection(Interface20 interface20_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (interface20_0 == null)
			{
				this._geometries = new IGeometry[0];
				return;
			}
			Interface26 @interface = interface20_0.imethod_4(0) as Interface26;
			if (@interface != null)
			{
				this._geometries = new IGeometry[interface20_0.imethod_2()];
				for (int i = 0; i < interface20_0.imethod_2(); i++)
				{
					@interface = (interface20_0.imethod_4(i) as Interface26);
					this._geometries[i] = new Polygon(@interface);
				}
				return;
			}
			Interface25 interface2 = interface20_0.imethod_4(0) as Interface25;
			if (interface2 != null)
			{
				this._geometries = new IGeometry[interface20_0.imethod_2()];
				for (int j = 0; j < interface20_0.imethod_2(); j++)
				{
					interface2 = (interface20_0.imethod_4(j) as Interface25);
					this._geometries[j] = new Point(interface2);
				}
				return;
			}
			Interface23 interface3 = interface20_0.imethod_4(0) as Interface23;
			if (interface3 != null)
			{
				this._geometries = new IGeometry[interface20_0.imethod_2()];
				for (int k = 0; k < interface20_0.imethod_2(); k++)
				{
					interface3 = (interface20_0.imethod_4(k) as Interface23);
					this._geometries[k] = new LineString(interface3);
				}
			}
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x002E80C8 File Offset: 0x002E62C8
		public GeometryCollection(IEnumerable<Interface20> ienumerable_0, IGeometryFactory igeometryFactory_0) : base(igeometryFactory_0)
		{
			if (ienumerable_0 == null)
			{
				return;
			}
			int num = Enumerable.Count<Interface20>(ienumerable_0);
			if (this._geometries == null)
			{
				this._geometries = new IGeometry[num];
			}
			if (Geometry.smethod_2(ienumerable_0))
			{
				throw new ArgumentException("geometries must not contain null elements");
			}
			int num2 = 0;
			foreach (Interface20 interface20_ in ienumerable_0)
			{
				this._geometries[num2] = Geometry.smethod_0(interface20_);
				num2++;
			}
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x0002D14C File Offset: 0x0002B34C
		public override Coordinate imethod_11()
		{
			if (this.imethod_14())
			{
				return null;
			}
			return this._geometries[0].imethod_11();
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x002E8158 File Offset: 0x002E6358
		public override IList<Coordinate> imethod_0()
		{
			IList<Coordinate> list = new Coordinate[this.imethod_3()];
			int num = -1;
			for (int i = 0; i < this._geometries.Length; i++)
			{
				IList<Coordinate> list2 = this._geometries[i].imethod_0();
				for (int j = 0; j < list2.Count; j++)
				{
					num++;
					list[num] = list2[j];
				}
			}
			return list;
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0002D165 File Offset: 0x0002B365
		public override void imethod_1(IList<Coordinate> ilist_0)
		{
			if (this._geometries.Length < 1)
			{
				return;
			}
			this._geometries[0].imethod_1(ilist_0);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x002E81C0 File Offset: 0x002E63C0
		public override bool imethod_14()
		{
			for (int i = 0; i < this._geometries.Length; i++)
			{
				if (!this._geometries[i].imethod_14())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0002D181 File Offset: 0x0002B381
		public override int imethod_2()
		{
			return this._geometries.Length;
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x0002D18B File Offset: 0x0002B38B
		public override IGeometry imethod_10(int int_0)
		{
			return this._geometries[int_0];
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0002D18B File Offset: 0x0002B38B
		public override Interface20 imethod_4(int int_0)
		{
			return this._geometries[int_0];
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x0002D195 File Offset: 0x0002B395
		public virtual IGeometry[] imethod_16()
		{
			return this._geometries;
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x002E81F4 File Offset: 0x002E63F4
		public override int imethod_3()
		{
			int num = 0;
			for (int i = 0; i < this._geometries.Length; i++)
			{
				num += ((Geometry)this._geometries[i]).imethod_3();
			}
			return num;
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x002E822C File Offset: 0x002E642C
		public override void imethod_5(Interface27 interface27_0)
		{
			for (int i = 0; i < this._geometries.Length; i++)
			{
				this._geometries[i].imethod_5(interface27_0);
			}
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x002E825C File Offset: 0x002E645C
		public override void imethod_6(Interface28 interface28_0)
		{
			interface28_0.imethod_0(this);
			for (int i = 0; i < this._geometries.Length; i++)
			{
				this._geometries[i].imethod_6(interface28_0);
			}
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x002E8294 File Offset: 0x002E6494
		public override void imethod_7(Interface21 interface21_0)
		{
			interface21_0.imethod_0(this);
			for (int i = 0; i < this._geometries.Length; i++)
			{
				this._geometries[i].imethod_7(interface21_0);
			}
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x002E82CC File Offset: 0x002E64CC
		public override int imethod_8(object object_0)
		{
			ArrayList arrayList_ = new ArrayList(this._geometries);
			ArrayList arrayList_2 = new ArrayList(((GeometryCollection)object_0)._geometries);
			return this.vmethod_5(arrayList_, arrayList_2);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0002D19D File Offset: 0x0002B39D
		public IEnumerator GetEnumerator()
		{
			return new GeometryCollection.Class2066(this);
		}

		// Token: 0x170003BD RID: 957
		public virtual IGeometry this[int int_0]
		{
			get
			{
				return this._geometries[int_0];
			}
			set
			{
				this._geometries[int_0] = value;
			}
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x002E8300 File Offset: 0x002E6500
		protected override void vmethod_3(Geometry geometry_0)
		{
			GeometryCollection geometryCollection = geometry_0 as GeometryCollection;
			if (geometryCollection == null)
			{
				return;
			}
			geometryCollection._geometries = new Geometry[this._geometries.Length];
			for (int i = 0; i < this._geometries.Length; i++)
			{
				geometryCollection._geometries[i] = (Geometry)this._geometries[i].Clone();
			}
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x002E8358 File Offset: 0x002E6558
		protected override IEnvelope vmethod_4()
		{
			Envelope envelope = new Envelope();
			for (int i = 0; i < this._geometries.Length; i++)
			{
				Class2062.smethod_13(envelope, this._geometries[i].imethod_12());
			}
			return envelope;
		}

		// Token: 0x04002DD4 RID: 11732
		public static readonly IGeometryCollection Empty = new GeometryFactory().imethod_5(null);

		// Token: 0x04002DD5 RID: 11733
		private IGeometry[] _geometries;

		// Token: 0x02000B1F RID: 2847
		internal sealed class Class2066 : IEnumerator
		{
			// Token: 0x06004739 RID: 18233 RVA: 0x0002D1C2 File Offset: 0x0002B3C2
			internal Class2066(IGeometryCollection igeometryCollection_1)
			{
				this.igeometryCollection_0 = igeometryCollection_1;
				this.bool_0 = true;
				this.int_1 = 0;
				this.int_0 = igeometryCollection_1.imethod_2();
			}

			// Token: 0x0600473A RID: 18234 RVA: 0x0002D1EB File Offset: 0x0002B3EB
			public bool MoveNext()
			{
				if (this.bool_0)
				{
					return true;
				}
				if (this.class2066_0 != null)
				{
					if (this.class2066_0.MoveNext())
					{
						return true;
					}
					this.class2066_0 = null;
				}
				return this.int_1 < this.int_0;
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x0600473B RID: 18235 RVA: 0x002E8394 File Offset: 0x002E6594
			public object Current
			{
				get
				{
					if (this.bool_0)
					{
						this.bool_0 = false;
						return this.igeometryCollection_0;
					}
					if (this.class2066_0 != null)
					{
						if (this.class2066_0.MoveNext())
						{
							return this.class2066_0.Current;
						}
						this.class2066_0 = null;
					}
					if (this.int_1 >= this.int_0)
					{
						throw new ArgumentOutOfRangeException();
					}
					IGeometry geometry = this.igeometryCollection_0.imethod_10(this.int_1++);
					if (geometry is GeometryCollection)
					{
						this.class2066_0 = new GeometryCollection.Class2066((GeometryCollection)geometry);
						return this.class2066_0.Current;
					}
					return geometry;
				}
			}

			// Token: 0x0600473C RID: 18236 RVA: 0x0002D226 File Offset: 0x0002B426
			public void Reset()
			{
				this.bool_0 = true;
				this.int_1 = 0;
			}

			// Token: 0x04002DD6 RID: 11734
			private readonly int int_0;

			// Token: 0x04002DD7 RID: 11735
			private readonly IGeometryCollection igeometryCollection_0;

			// Token: 0x04002DD8 RID: 11736
			private bool bool_0;

			// Token: 0x04002DD9 RID: 11737
			private int int_1;

			// Token: 0x04002DDA RID: 11738
			private GeometryCollection.Class2066 class2066_0;
		}
	}
}
