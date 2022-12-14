using System;
using System.Text;
using ns25;
using ns26;
using ns27;

namespace DotSpatial.Topology
{
	// Token: 0x02000B53 RID: 2899
	[Serializable]
	public class LineSegment : IComparable, Interface29, Interface30
	{
		// Token: 0x0600489B RID: 18587 RVA: 0x0002DFA3 File Offset: 0x0002C1A3
		public LineSegment(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			this._p0 = coordinate_0;
			this._p1 = coordinate_1;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x0002DFB9 File Offset: 0x0002C1B9
		public LineSegment(Interface29 interface29_0) : this(interface29_0.imethod_1(), interface29_0.imethod_0())
		{
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x0002DFCD File Offset: 0x0002C1CD
		public LineSegment() : this(new Coordinate(), new Coordinate())
		{
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x0002DFDF File Offset: 0x0002C1DF
		public virtual Coordinate imethod_0()
		{
			return this._p1;
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x0002DFE7 File Offset: 0x0002C1E7
		public virtual void vmethod_0(Coordinate coordinate_0)
		{
			this._p1 = coordinate_0;
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		public virtual Coordinate imethod_1()
		{
			return this._p0;
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x0002DFF8 File Offset: 0x0002C1F8
		public virtual void vmethod_1(Coordinate coordinate_0)
		{
			this._p0 = coordinate_0;
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x002EAE00 File Offset: 0x002E9000
		public virtual void vmethod_2(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			this.imethod_1().X = coordinate_0.X;
			this.imethod_1().Y = coordinate_0.Y;
			this.imethod_0().X = coordinate_1.X;
			this.imethod_0().Y = coordinate_1.Y;
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x0002E001 File Offset: 0x0002C201
		public virtual bool vmethod_3()
		{
			return this.imethod_1().Y == this.imethod_0().Y;
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x002EAE54 File Offset: 0x002E9054
		public virtual int vmethod_4(Interface29 interface29_0)
		{
			int num = Class2112.smethod_0(this.imethod_1(), this.imethod_0(), interface29_0.imethod_1());
			int num2 = Class2112.smethod_0(this.imethod_1(), this.imethod_0(), interface29_0.imethod_0());
			if (num >= 0 && num2 >= 0)
			{
				return Math.Max(num, num2);
			}
			if (num <= 0 && num2 <= 0)
			{
				return Math.Max(num, num2);
			}
			return 0;
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x002EAEB4 File Offset: 0x002E90B4
		public virtual void vmethod_5()
		{
			Coordinate coordinate_ = this.imethod_1();
			this.vmethod_1(this.imethod_0());
			this.vmethod_0(coordinate_);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x0002E01B File Offset: 0x0002C21B
		public virtual double imethod_2(Coordinate coordinate_0)
		{
			return Class2112.smethod_6(new Coordinate(coordinate_0), this.imethod_1(), this.imethod_0());
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x002EAEDC File Offset: 0x002E90DC
		public virtual double vmethod_6(Coordinate coordinate_0)
		{
			if (coordinate_0.Equals(this.imethod_1()))
			{
				return 0.0;
			}
			if (coordinate_0.Equals(this.imethod_0()))
			{
				return 1.0;
			}
			double num = this.imethod_0().X - this.imethod_1().X;
			double num2 = this.imethod_0().Y - this.imethod_1().Y;
			double num3 = num * num + num2 * num2;
			return ((coordinate_0.X - this.imethod_1().X) * num + (coordinate_0.Y - this.imethod_1().Y) * num2) / num3;
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x002EAF80 File Offset: 0x002E9180
		public virtual Coordinate vmethod_7(Coordinate coordinate_0)
		{
			if (!coordinate_0.Equals(this.imethod_1()) && !coordinate_0.Equals(this.imethod_0()))
			{
				double num = this.vmethod_6(coordinate_0);
				return new Coordinate
				{
					X = this.imethod_1().X + num * (this.imethod_0().X - this.imethod_1().X),
					Y = this.imethod_1().Y + num * (this.imethod_0().Y - this.imethod_1().Y)
				};
			}
			return new Coordinate(coordinate_0);
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x002EB018 File Offset: 0x002E9218
		public virtual Coordinate vmethod_8(Coordinate coordinate_0)
		{
			double num = this.vmethod_6(coordinate_0);
			if (num > 0.0 && num < 1.0)
			{
				return this.vmethod_7(coordinate_0);
			}
			double num2 = new Coordinate(this._p0).method_1(coordinate_0);
			double num3 = new Coordinate(this.imethod_0()).method_1(coordinate_0);
			if (num2 < num3)
			{
				return new Coordinate(this._p0);
			}
			return new Coordinate(this._p1);
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x002EB08C File Offset: 0x002E928C
		public virtual Coordinate[] vmethod_9(Interface29 interface29_0)
		{
			LineSegment lineSegment = new LineSegment(interface29_0);
			Coordinate coordinate = this.vmethod_10(interface29_0);
			if (Coordinate.smethod_2(coordinate, null))
			{
				return new Coordinate[]
				{
					coordinate,
					coordinate
				};
			}
			Coordinate[] array = new Coordinate[2];
			Coordinate coordinate2 = new Coordinate(this.vmethod_8(interface29_0.imethod_1()));
			double num = coordinate2.method_1(interface29_0.imethod_1());
			array[0] = coordinate2;
			array[1] = new Coordinate(interface29_0.imethod_1());
			Coordinate coordinate3 = new Coordinate(this.vmethod_8(interface29_0.imethod_0()));
			double num2 = coordinate3.method_1(interface29_0.imethod_0());
			if (num2 < num)
			{
				num = num2;
				array[0] = coordinate3;
				array[1] = new Coordinate(interface29_0.imethod_0());
			}
			Coordinate coordinate4 = new Coordinate(lineSegment.vmethod_8(this.imethod_1()));
			num2 = coordinate4.method_1(this.imethod_1());
			if (num2 < num)
			{
				num = num2;
				array[0] = new Coordinate(this.imethod_1());
				array[1] = coordinate4;
			}
			Coordinate coordinate5 = new Coordinate(lineSegment.vmethod_8(this.imethod_0()));
			num2 = coordinate5.method_1(this.imethod_0());
			if (num2 < num)
			{
				array[0] = new Coordinate(this.imethod_0());
				array[1] = coordinate5;
			}
			return array;
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x002EB1BC File Offset: 0x002E93BC
		public virtual Coordinate vmethod_10(Interface29 interface29_0)
		{
			Class2116 @class = new Class2117();
			@class.vmethod_3(this.imethod_1(), this.imethod_0(), new Coordinate(interface29_0.imethod_1()), new Coordinate(interface29_0.imethod_0()));
			if (@class.vmethod_10())
			{
				return @class.vmethod_5(0);
			}
			return null;
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x002EB208 File Offset: 0x002E9408
		public virtual int CompareTo(object target)
		{
			Interface29 @interface = (Interface29)target;
			int num = new Coordinate(this._p0).CompareTo(@interface.imethod_1());
			if (num != 0)
			{
				return num;
			}
			return new Coordinate(this._p1).CompareTo(@interface.imethod_0());
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x002EB250 File Offset: 0x002E9450
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("LINESTRING( ");
			stringBuilder.Append(this.imethod_1().X).Append(" ");
			stringBuilder.Append(this.imethod_1().Y).Append(", ");
			stringBuilder.Append(this.imethod_0().X).Append(" ");
			stringBuilder.Append(this.imethod_0().Y).Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x002EB2E0 File Offset: 0x002E94E0
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is Interface29))
			{
				return false;
			}
			Interface29 @interface = (Interface29)obj;
			return this._p0.X == @interface.imethod_1().X && this._p0.Y == @interface.imethod_1().Y && this._p1.X == @interface.imethod_0().X && this._p1.Y == @interface.imethod_0().Y;
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x00006E41 File Offset: 0x00005041
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04002E44 RID: 11844
		private Coordinate _p0;

		// Token: 0x04002E45 RID: 11845
		private Coordinate _p1;
	}
}
