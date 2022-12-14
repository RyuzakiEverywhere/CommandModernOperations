using System;
using System.Collections.Generic;
using System.Linq;
using ns25;
using ns29;

namespace DotSpatial.Topology
{
	// Token: 0x02000B52 RID: 2898
	[Serializable]
	public sealed class LinearRing : LineString, ICloneable, IComparable, Interface20, IGeometry, Interface23, ILineString, ILinearRing
	{
		// Token: 0x06004897 RID: 18583 RVA: 0x0002DF8B File Offset: 0x0002C18B
		public LinearRing(IEnumerable<Coordinate> ienumerable_0) : base(ienumerable_0)
		{
			this.method_1();
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x0002DF9A File Offset: 0x0002C19A
		public LinearRing(Interface23 interface23_0) : base(interface23_0)
		{
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool imethod_16()
		{
			return true;
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x002EAD90 File Offset: 0x002E8F90
		private void method_1()
		{
			if (!this.imethod_14() && !base.imethod_16())
			{
				IList<Coordinate> list = Enumerable.ToList<Coordinate>(this.imethod_0());
				list.Add(Class2231.smethod_0<Coordinate>(this.imethod_0()[0]));
				this.imethod_1(list);
			}
			if (this.imethod_0().Count >= 1 && this.imethod_0().Count < 3)
			{
				throw new ArgumentException("Number of points must be 0 or >= 3");
			}
		}
	}
}
