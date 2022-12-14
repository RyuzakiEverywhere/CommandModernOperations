using System;
using System.Text;
using GeoAPI.Geometries;
using ns14;

namespace GisSharpBlog.NetTopologySuite.Geometries
{
	// Token: 0x02000537 RID: 1335
	[Obsolete("No longer used.")]
	[Serializable]
	public sealed class DefaultCoordinateSequence : ICloneable, ICoordinateSequence
	{
		// Token: 0x060026E8 RID: 9960 RVA: 0x00012A7F File Offset: 0x00010C7F
		public DefaultCoordinateSequence(ICoordinate[] icoordinate_0)
		{
			if (Geometry.smethod_1(icoordinate_0))
			{
				throw new ArgumentException("Null coordinate");
			}
			this.coordinates = icoordinate_0;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x002C02F0 File Offset: 0x002BE4F0
		public ICoordinate imethod_0(int int_0)
		{
			return this.coordinates[int_0];
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x002C0308 File Offset: 0x002BE508
		public void imethod_1(int int_0, Enum157 enum157_0, double double_0)
		{
			switch (enum157_0)
			{
			case Enum157.const_0:
				this.coordinates[int_0].imethod_1(double_0);
				break;
			case Enum157.const_1:
				this.coordinates[int_0].imethod_3(double_0);
				break;
			case Enum157.const_2:
				this.coordinates[int_0].imethod_5(double_0);
				break;
			}
		}

		// Token: 0x17000164 RID: 356
		public object this[int int_0]
		{
			get
			{
				return this.coordinates[int_0];
			}
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x002C0374 File Offset: 0x002BE574
		public object Clone()
		{
			ICoordinate[] array = new ICoordinate[this.coordinates.Length];
			for (int i = 0; i < this.coordinates.Length; i++)
			{
				array[i] = (Coordinate)this.coordinates[i].Clone();
			}
			return new DefaultCoordinateSequence(array);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x002C03C4 File Offset: 0x002BE5C4
		public int Count
		{
			get
			{
				return this.coordinates.Length;
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x002C03DC File Offset: 0x002BE5DC
		public ICoordinate[] imethod_2()
		{
			return this.coordinates;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x002C03F4 File Offset: 0x002BE5F4
		public override string ToString()
		{
			string result;
			if (this.coordinates.Length > 0)
			{
				StringBuilder stringBuilder = new StringBuilder(17 * this.coordinates.Length);
				stringBuilder.Append('(');
				stringBuilder.Append(this.coordinates[0]);
				for (int i = 1; i < this.coordinates.Length; i++)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(this.coordinates[i].ToString());
				}
				stringBuilder.Append(')');
				result = stringBuilder.ToString();
			}
			else
			{
				result = "()";
			}
			return result;
		}

		// Token: 0x0400209F RID: 8351
		private ICoordinate[] coordinates = null;
	}
}
