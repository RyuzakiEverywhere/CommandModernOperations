using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualBasic;

namespace Command_Core
{
	// Token: 0x020004BC RID: 1212
	public abstract class FixedGeoPolygon
	{
		// Token: 0x0600241C RID: 9244
		public abstract List<Geopoint_Struct> vmethod_0();

		// Token: 0x0600241D RID: 9245 RVA: 0x002B59AC File Offset: 0x002B3BAC
		public bool method_0(double double_2, double double_3, bool bool_0)
		{
			bool result;
			try
			{
				if (double_2 > (double)this.method_3())
				{
					result = false;
				}
				else if (double_2 < (double)this.method_4())
				{
					result = false;
				}
				else if (double_3 > (double)this.method_5())
				{
					result = false;
				}
				else if (double_3 < (double)this.method_6())
				{
					result = false;
				}
				else
				{
					double[] array = this.method_1();
					double[] array2 = this.method_2();
					result = GeoPoint.smethod_8(double_2, double_3, ref array, ref array2);
				}
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200095", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x002B5A58 File Offset: 0x002B3C58
		public double[] method_1()
		{
			if (Information.IsNothing(this.double_0))
			{
				double[] array = Enumerable.ToArray<double>(Enumerable.Select<Geopoint_Struct, double>(this.vmethod_0(), (FixedGeoPolygon._Closure$__.$I14-0 == null) ? (FixedGeoPolygon._Closure$__.$I14-0 = new Func<Geopoint_Struct, double>(FixedGeoPolygon._Closure$__.$I.method_0)) : FixedGeoPolygon._Closure$__.$I14-0));
				this.double_0 = array;
			}
			return this.double_0;
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x002B5AB4 File Offset: 0x002B3CB4
		public double[] method_2()
		{
			if (Information.IsNothing(this.double_1))
			{
				double[] array = Enumerable.ToArray<double>(Enumerable.Select<Geopoint_Struct, double>(this.vmethod_0(), (FixedGeoPolygon._Closure$__.$I16-0 == null) ? (FixedGeoPolygon._Closure$__.$I16-0 = new Func<Geopoint_Struct, double>(FixedGeoPolygon._Closure$__.$I.method_1)) : FixedGeoPolygon._Closure$__.$I16-0));
				this.double_1 = array;
			}
			return this.double_1;
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x002B5B10 File Offset: 0x002B3D10
		protected float method_3()
		{
			if (this.nullable_0 == null)
			{
				this.nullable_0 = new float?((float)Enumerable.ElementAtOrDefault<Geopoint_Struct>(Enumerable.OrderByDescending<Geopoint_Struct, double>(Enumerable.Select<Geopoint_Struct, Geopoint_Struct>(this.vmethod_0(), (FixedGeoPolygon._Closure$__.$I18-0 == null) ? (FixedGeoPolygon._Closure$__.$I18-0 = new Func<Geopoint_Struct, Geopoint_Struct>(FixedGeoPolygon._Closure$__.$I.method_2)) : FixedGeoPolygon._Closure$__.$I18-0), (FixedGeoPolygon._Closure$__.$I18-1 == null) ? (FixedGeoPolygon._Closure$__.$I18-1 = new Func<Geopoint_Struct, double>(FixedGeoPolygon._Closure$__.$I.method_3)) : FixedGeoPolygon._Closure$__.$I18-1), 0).double_1);
			}
			return this.nullable_0.Value;
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x002B5BA4 File Offset: 0x002B3DA4
		protected float method_4()
		{
			if (this.nullable_1 == null)
			{
				this.nullable_1 = new float?((float)Enumerable.ElementAtOrDefault<Geopoint_Struct>(Enumerable.OrderBy<Geopoint_Struct, double>(Enumerable.Select<Geopoint_Struct, Geopoint_Struct>(this.vmethod_0(), (FixedGeoPolygon._Closure$__.$I20-0 == null) ? (FixedGeoPolygon._Closure$__.$I20-0 = new Func<Geopoint_Struct, Geopoint_Struct>(FixedGeoPolygon._Closure$__.$I.method_4)) : FixedGeoPolygon._Closure$__.$I20-0), (FixedGeoPolygon._Closure$__.$I20-1 == null) ? (FixedGeoPolygon._Closure$__.$I20-1 = new Func<Geopoint_Struct, double>(FixedGeoPolygon._Closure$__.$I.method_5)) : FixedGeoPolygon._Closure$__.$I20-1), 0).double_1);
			}
			return this.nullable_1.Value;
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x002B5C38 File Offset: 0x002B3E38
		protected float method_5()
		{
			if (this.nullable_2 == null)
			{
				this.nullable_2 = new float?((float)Enumerable.ElementAtOrDefault<Geopoint_Struct>(Enumerable.OrderByDescending<Geopoint_Struct, double>(Enumerable.Select<Geopoint_Struct, Geopoint_Struct>(this.vmethod_0(), (FixedGeoPolygon._Closure$__.$I22-0 == null) ? (FixedGeoPolygon._Closure$__.$I22-0 = new Func<Geopoint_Struct, Geopoint_Struct>(FixedGeoPolygon._Closure$__.$I.method_6)) : FixedGeoPolygon._Closure$__.$I22-0), (FixedGeoPolygon._Closure$__.$I22-1 == null) ? (FixedGeoPolygon._Closure$__.$I22-1 = new Func<Geopoint_Struct, double>(FixedGeoPolygon._Closure$__.$I.method_7)) : FixedGeoPolygon._Closure$__.$I22-1), 0).double_0);
			}
			return this.nullable_2.Value;
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x002B5CCC File Offset: 0x002B3ECC
		protected float method_6()
		{
			if (this.nullable_3 == null)
			{
				this.nullable_3 = new float?((float)Enumerable.ElementAtOrDefault<Geopoint_Struct>(Enumerable.OrderBy<Geopoint_Struct, double>(Enumerable.Select<Geopoint_Struct, Geopoint_Struct>(this.vmethod_0(), (FixedGeoPolygon._Closure$__.$I24-0 == null) ? (FixedGeoPolygon._Closure$__.$I24-0 = new Func<Geopoint_Struct, Geopoint_Struct>(FixedGeoPolygon._Closure$__.$I.method_8)) : FixedGeoPolygon._Closure$__.$I24-0), (FixedGeoPolygon._Closure$__.$I24-1 == null) ? (FixedGeoPolygon._Closure$__.$I24-1 = new Func<Geopoint_Struct, double>(FixedGeoPolygon._Closure$__.$I.method_9)) : FixedGeoPolygon._Closure$__.$I24-1), 0).double_0);
			}
			return this.nullable_3.Value;
		}

		// Token: 0x04001F0B RID: 7947
		protected float? nullable_0;

		// Token: 0x04001F0C RID: 7948
		protected float? nullable_1;

		// Token: 0x04001F0D RID: 7949
		protected float? nullable_2;

		// Token: 0x04001F0E RID: 7950
		protected float? nullable_3;

		// Token: 0x04001F0F RID: 7951
		private double[] double_0;

		// Token: 0x04001F10 RID: 7952
		private double[] double_1;
	}
}
