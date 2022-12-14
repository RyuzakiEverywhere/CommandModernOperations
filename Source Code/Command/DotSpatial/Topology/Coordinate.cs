using System;
using ns25;
using ns27;

namespace DotSpatial.Topology
{
	// Token: 0x02000B08 RID: 2824
	[Serializable]
	public class Coordinate : IComparable<Coordinate>, ICloneable, IComparable
	{
		// Token: 0x06004669 RID: 18025 RVA: 0x002E6A6C File Offset: 0x002E4C6C
		public Coordinate()
		{
			this.X = double.NaN;
			this.Y = double.NaN;
			this.Z = double.NaN;
			this.M = double.NaN;
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x0002CAA7 File Offset: 0x0002ACA7
		public Coordinate(double double_0, double double_1)
		{
			this.X = double_0;
			this.Y = double_1;
			this.Z = double.NaN;
			this.M = double.NaN;
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x002E6ABC File Offset: 0x002E4CBC
		public Coordinate(Interface24 interface24_0)
		{
			double[] array = interface24_0.imethod_17();
			if (array.Length > 0)
			{
				this.X = array[0];
			}
			if (array.Length > 1)
			{
				this.Y = array[1];
			}
			if (array.Length > 2)
			{
				this.Z = array[2];
			}
			this.M = interface24_0.imethod_16();
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x0002CADB File Offset: 0x0002ACDB
		public Coordinate(Coordinate coordinate_0)
		{
			this.X = coordinate_0.X;
			this.Y = coordinate_0.Y;
			this.Z = coordinate_0.Z;
			this.M = coordinate_0.M;
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x0002CB13 File Offset: 0x0002AD13
		public Coordinate(double double_0, double double_1, double double_2, double double_3)
		{
			this.X = double_0;
			this.Y = double_1;
			this.Z = double_2;
			this.M = double_3;
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x002E6B10 File Offset: 0x002E4D10
		public override bool Equals(object obj)
		{
			if (!(obj is Coordinate))
			{
				Interface24 @interface = obj as Interface24;
				if (@interface == null)
				{
					return false;
				}
				if (!double.IsNaN(this.Z) && !double.IsNaN(@interface.imethod_20()))
				{
					return @interface.imethod_18() == this.X && @interface.imethod_19() == this.Y && @interface.imethod_20() == this.Z;
				}
				return @interface.imethod_18() == this.X && @interface.imethod_19() == this.Y;
			}
			else
			{
				Coordinate coordinate = (Coordinate)obj;
				if (!double.IsNaN(this.Z) && !double.IsNaN(coordinate.Z))
				{
					return coordinate.X == this.X && coordinate.Y == this.Y && coordinate.Z == this.Z;
				}
				return coordinate.X == this.X && coordinate.Y == this.Y;
			}
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00006E41 File Offset: 0x00005041
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x002E6C04 File Offset: 0x002E4E04
		public double[] method_0()
		{
			if (!double.IsNaN(this.Z))
			{
				return new double[]
				{
					this.X,
					this.Y,
					this.Z
				};
			}
			return new double[]
			{
				this.X,
				this.Y
			};
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x002E6C5C File Offset: 0x002E4E5C
		public double method_1(Coordinate coordinate_0)
		{
			double num = coordinate_0.X - this.X;
			double num2 = coordinate_0.Y - this.Y;
			return Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x0002CB38 File Offset: 0x0002AD38
		public bool method_2(Coordinate coordinate_0)
		{
			return this.X == coordinate_0.X && this.Y == coordinate_0.Y;
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x002E6C94 File Offset: 0x002E4E94
		public string method_3()
		{
			string text = "(" + this.X;
			for (int i = 1; i < this.method_4(); i++)
			{
				text = text + ", " + this[i];
			}
			return text + ")";
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x0002CB59 File Offset: 0x0002AD59
		public static Coordinate smethod_0()
		{
			return new Coordinate(double.NaN, double.NaN);
		}

		// Token: 0x170003B3 RID: 947
		public double this[int int_0]
		{
			get
			{
				switch (int_0)
				{
				case 0:
					return this.X;
				case 1:
					return this.Y;
				case 2:
					return this.Z;
				default:
					throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch (int_0)
				{
				case 0:
					this.X = value;
					return;
				case 1:
					this.Y = value;
					return;
				case 2:
					this.Z = value;
					return;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x0002CB72 File Offset: 0x0002AD72
		public int method_4()
		{
			if (!double.IsNaN(this.Z))
			{
				return 3;
			}
			return 2;
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x002E6D6C File Offset: 0x002E4F6C
		int IComparable.CompareTo(object obj)
		{
			Coordinate coordinate = obj as Coordinate;
			if (Coordinate.smethod_1(coordinate, null))
			{
				throw new ArgumentException(Class2111.smethod_1().Replace("%S1", "other").Replace("%S2", "ICoordinate"));
			}
			if (this.X < coordinate.X)
			{
				return -1;
			}
			if (this.X > coordinate.X)
			{
				return 1;
			}
			if (this.Y < coordinate.Y)
			{
				return -1;
			}
			if (this.Y > coordinate.Y)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x002E6DF4 File Offset: 0x002E4FF4
		public virtual int CompareTo(Coordinate other)
		{
			if (Coordinate.smethod_1(other, null))
			{
				throw new ArgumentException(Class2111.smethod_1().Replace("%S1", "other").Replace("%S2", "ICoordinate"));
			}
			if (this.X < other.X)
			{
				return -1;
			}
			if (this.X > other.X)
			{
				return 1;
			}
			if (this.Y < other.Y)
			{
				return -1;
			}
			if (this.Y > other.Y)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x0002CB84 File Offset: 0x0002AD84
		public bool method_5()
		{
			return double.IsNaN(this.X) || double.IsNaN(this.Y);
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x0002CBA0 File Offset: 0x0002ADA0
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		public static bool smethod_1(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			return object.Equals(coordinate_0, coordinate_1);
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x0002CBB1 File Offset: 0x0002ADB1
		public static bool smethod_2(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			return !Coordinate.smethod_1(coordinate_0, coordinate_1);
		}

		// Token: 0x04002DBE RID: 11710
		public double M;

		// Token: 0x04002DBF RID: 11711
		public double X;

		// Token: 0x04002DC0 RID: 11712
		public double Y;

		// Token: 0x04002DC1 RID: 11713
		public double Z;
	}
}
