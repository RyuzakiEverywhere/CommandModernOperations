using System;
using System.ComponentModel;
using ns25;
using ns29;

namespace DotSpatial.Topology
{
	// Token: 0x02000B14 RID: 2836
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[Serializable]
	public sealed class Envelope : ICloneable, Interface19, IEnvelope
	{
		// Token: 0x060046C2 RID: 18114 RVA: 0x0002CE1C File Offset: 0x0002B01C
		public Envelope()
		{
			this.method_0();
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x002E7384 File Offset: 0x002E5584
		public Envelope(double double_0, double double_1, double double_2, double double_3)
		{
			Coordinate coordinate_ = new Coordinate(Math.Min(double_0, double_1), Math.Min(double_2, double_3));
			Coordinate coordinate_2 = new Coordinate(Math.Max(double_0, double_1), Math.Max(double_2, double_3));
			this.method_1(coordinate_, coordinate_2);
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x002E73CC File Offset: 0x002E55CC
		public Envelope(IEnvelope ienvelope_0)
		{
			Coordinate coordinate_ = Class2231.smethod_0<Coordinate>(ienvelope_0.imethod_5());
			Coordinate coordinate_2 = Class2231.smethod_0<Coordinate>(ienvelope_0.imethod_6());
			this.method_1(coordinate_, coordinate_2);
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x002E7400 File Offset: 0x002E5600
		public Envelope(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			if (!Coordinate.smethod_1(coordinate_0, null) && !Coordinate.smethod_1(coordinate_1, null))
			{
				int num = Math.Min(coordinate_0.method_4(), coordinate_1.method_4());
				this._min = new Coordinate();
				this._max = new Coordinate();
				for (int i = 0; i < num; i++)
				{
					this._min[i] = Math.Min(coordinate_0[i], coordinate_1[i]);
					this._max[i] = Math.Max(coordinate_0[i], coordinate_1[i]);
				}
				this._min.M = Math.Min(coordinate_0.M, coordinate_1.M);
				this._max.M = Math.Min(coordinate_0.M, coordinate_1.M);
				return;
			}
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x002E74D8 File Offset: 0x002E56D8
		public void imethod_4(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			if (Coordinate.smethod_1(coordinate_0, null) && Coordinate.smethod_1(coordinate_1, null))
			{
				this.vmethod_0();
				return;
			}
			if (Coordinate.smethod_1(coordinate_0, null))
			{
				this.imethod_4(coordinate_1, coordinate_1);
				return;
			}
			if (Coordinate.smethod_1(coordinate_1, null))
			{
				this.imethod_4(coordinate_0, coordinate_0);
				return;
			}
			int num = Math.Min(coordinate_0.method_4(), coordinate_1.method_4());
			this._min = new Coordinate();
			this._max = new Coordinate();
			for (int i = 0; i < num; i++)
			{
				this._min[i] = Math.Min(coordinate_0[i], coordinate_1[i]);
				this._max[i] = Math.Max(coordinate_0[i], coordinate_1[i]);
			}
			this._min.M = Math.Min(coordinate_0.M, coordinate_1.M);
			this._max.M = Math.Min(coordinate_0.M, coordinate_1.M);
			this.method_2();
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0002CE2A File Offset: 0x0002B02A
		private void method_0()
		{
			this._min = new Coordinate(0.0, 0.0);
			this._max = new Coordinate(-1.0, -1.0);
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x0002CE66 File Offset: 0x0002B066
		private void method_1(Coordinate coordinate_0, Coordinate coordinate_1)
		{
			this._min = coordinate_0;
			this._max = coordinate_1;
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0002CE76 File Offset: 0x0002B076
		public void vmethod_0()
		{
			this.vmethod_1();
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x0002CE7E File Offset: 0x0002B07E
		public object Clone()
		{
			return this.vmethod_2();
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x002E75D4 File Offset: 0x002E57D4
		public void vmethod_1()
		{
			this._min = new Coordinate();
			this._max = new Coordinate();
			for (int i = 0; i < this.imethod_7(); i++)
			{
				this._min[i] = 0.0;
				this._max[i] = -1.0;
			}
			this.method_2();
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x0002CE86 File Offset: 0x0002B086
		public Envelope vmethod_2()
		{
			if (this.imethod_8())
			{
				return new Envelope();
			}
			return new Envelope(this._min, this._max);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x002E7638 File Offset: 0x002E5838
		public static bool smethod_0(Coordinate coordinate_0, Coordinate coordinate_1, Coordinate coordinate_2)
		{
			Envelope ienvelope_ = new Envelope(coordinate_0, coordinate_1);
			return Class2062.smethod_14(ienvelope_, coordinate_2);
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x002E7654 File Offset: 0x002E5854
		public static bool smethod_1(Coordinate coordinate_0, Coordinate coordinate_1, Coordinate coordinate_2, Coordinate coordinate_3)
		{
			Envelope ienvelope_ = new Envelope(coordinate_0, coordinate_1);
			Envelope ienvelope_2 = new Envelope(coordinate_2, coordinate_3);
			return Class2062.smethod_15(ienvelope_, ienvelope_2);
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x0002CEA7 File Offset: 0x0002B0A7
		public Coordinate imethod_5()
		{
			return this._min;
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x0002CEAF File Offset: 0x0002B0AF
		public Coordinate imethod_6()
		{
			return this._max;
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x0002CEB7 File Offset: 0x0002B0B7
		public int imethod_7()
		{
			return this._min.method_4();
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x0002CEC4 File Offset: 0x0002B0C4
		public bool imethod_8()
		{
			return Coordinate.smethod_1(this._max, null) || Coordinate.smethod_1(this._min, null) || this._max.X < this._min.X;
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x0002CEFC File Offset: 0x0002B0FC
		public double imethod_0()
		{
			if (this.imethod_8())
			{
				return 0.0;
			}
			return this.imethod_6().Y - this.imethod_5().Y;
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x0002CF27 File Offset: 0x0002B127
		public double imethod_1()
		{
			if (this.imethod_8())
			{
				return 0.0;
			}
			return this._max.X - this._min.X;
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x0002CF52 File Offset: 0x0002B152
		public double imethod_2()
		{
			return this._min.X;
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x0002CF5F File Offset: 0x0002B15F
		public double imethod_3()
		{
			return this._max.Y;
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x002E7678 File Offset: 0x002E5878
		public override string ToString()
		{
			string text = "Env[";
			for (int i = 0; i < this.imethod_7(); i++)
			{
				if (i > 0)
				{
					text += ", ";
				}
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					this.imethod_5()[i],
					" : ",
					this.imethod_6()[i]
				});
			}
			return text;
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x0002CF6C File Offset: 0x0002B16C
		protected void method_2()
		{
			if (this.EnvelopeChanged == null)
			{
				return;
			}
			this.EnvelopeChanged(this, new EventArgs());
		}

		// Token: 0x04002DC8 RID: 11720
		private Coordinate _max;

		// Token: 0x04002DC9 RID: 11721
		private Coordinate _min;

		// Token: 0x04002DCA RID: 11722
		private EventHandler EnvelopeChanged;
	}
}
