using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotSpatial.Topology
{
	// Token: 0x02000B0C RID: 2828
	[Serializable]
	public sealed class CoordinateArraySequence : IEnumerable, ICollection<Coordinate>, IEnumerable<Coordinate>, ICloneable
	{
		// Token: 0x06004686 RID: 18054 RVA: 0x0002CBC6 File Offset: 0x0002ADC6
		private void method_0()
		{
			if (this._versionId == 2147483647)
			{
				this._versionId = int.MinValue;
				return;
			}
			this._versionId++;
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x002E6FAC File Offset: 0x002E51AC
		public CoordinateArraySequence()
		{
			this.method_1(new Coordinate[]
			{
				new Coordinate()
			});
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x002E6FD8 File Offset: 0x002E51D8
		public CoordinateArraySequence(Coordinate[] coordinate_0)
		{
			Coordinate[] coordinate_ = coordinate_0 ?? new Coordinate[]
			{
				new Coordinate()
			};
			this.method_1(coordinate_);
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x0002CBEF File Offset: 0x0002ADEF
		private void method_1(Coordinate[] coordinate_0)
		{
			this._coordinates = coordinate_0;
			this._versionId = 0;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x002E7008 File Offset: 0x002E5208
		public void Add(Coordinate item)
		{
			Coordinate[] array = new Coordinate[this._coordinates.Length + 1];
			this._coordinates.CopyTo(array, 0);
			array[this._coordinates.Length] = item;
			this.method_0();
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x0002CBFF File Offset: 0x0002ADFF
		public void Clear()
		{
			this._coordinates = new Coordinate[1];
			this._coordinates[0] = new Coordinate();
			this.method_0();
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x002E7044 File Offset: 0x002E5244
		public bool Contains(Coordinate item)
		{
			foreach (Coordinate coordinate_ in this._coordinates)
			{
				if (Coordinate.smethod_1(coordinate_, item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x002E707C File Offset: 0x002E527C
		public object Clone()
		{
			Coordinate[] array = new Coordinate[this.Count];
			for (int i = 0; i < this._coordinates.Length; i++)
			{
				array[i] = new Coordinate(this._coordinates[i]);
			}
			return new CoordinateArraySequence(array);
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x0002CC20 File Offset: 0x0002AE20
		public void CopyTo(Coordinate[] array, int arrayIndex)
		{
			this._coordinates.CopyTo(array, arrayIndex);
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x0002CC2F File Offset: 0x0002AE2F
		public IEnumerator<Coordinate> GetEnumerator()
		{
			return new CoordinateArraySequence.Class2060(this._coordinates.GetEnumerator());
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x0002CC41 File Offset: 0x0002AE41
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._coordinates.GetEnumerator();
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x002E70C0 File Offset: 0x002E52C0
		public bool Remove(Coordinate item)
		{
			Coordinate[] array = new Coordinate[this._coordinates.Length - 1];
			bool flag = false;
			for (int i = 0; i < this._coordinates.Length; i++)
			{
				if (Coordinate.smethod_1(item, this._coordinates[i]) && !flag)
				{
					flag = true;
				}
				else if (flag)
				{
					array[i - 1] = this._coordinates[i];
				}
				else
				{
					array[i] = this._coordinates[i];
				}
			}
			if (flag)
			{
				this._coordinates = array;
			}
			return flag;
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x002E7134 File Offset: 0x002E5334
		public override string ToString()
		{
			if (this._coordinates.Length > 0)
			{
				StringBuilder stringBuilder = new StringBuilder(17 * this._coordinates.Length);
				stringBuilder.Append('(');
				stringBuilder.Append(this._coordinates[0]);
				for (int i = 1; i < this._coordinates.Length; i++)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append(this._coordinates[i]);
				}
				stringBuilder.Append(')');
				return stringBuilder.ToString();
			}
			return "()";
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x0002CC4E File Offset: 0x0002AE4E
		public int Count
		{
			get
			{
				return this._coordinates.Length;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06004694 RID: 18068 RVA: 0x00003024 File Offset: 0x00001224
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003B4 RID: 948
		public Coordinate this[int int_0]
		{
			get
			{
				return this._coordinates[int_0];
			}
			set
			{
				this._coordinates[int_0] = value;
				this.method_0();
			}
		}

		// Token: 0x04002DC2 RID: 11714
		private Coordinate[] _coordinates;

		// Token: 0x04002DC3 RID: 11715
		private int _versionId;

		// Token: 0x02000B0D RID: 2829
		internal sealed class Class2060 : IDisposable, IEnumerator, IEnumerator<Coordinate>
		{
			// Token: 0x06004697 RID: 18071 RVA: 0x0002CC73 File Offset: 0x0002AE73
			public Class2060(IEnumerator ienumerator_1)
			{
				this.ienumerator_0 = ienumerator_1;
			}

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x06004698 RID: 18072 RVA: 0x0002CC82 File Offset: 0x0002AE82
			public Coordinate Current
			{
				get
				{
					return this.ienumerator_0.Current as Coordinate;
				}
			}

			// Token: 0x170003B8 RID: 952
			// (get) Token: 0x06004699 RID: 18073 RVA: 0x0002CC94 File Offset: 0x0002AE94
			object IEnumerator.Current
			{
				get
				{
					return this.ienumerator_0.Current;
				}
			}

			// Token: 0x0600469A RID: 18074 RVA: 0x0000378C File Offset: 0x0000198C
			public void Dispose()
			{
			}

			// Token: 0x0600469B RID: 18075 RVA: 0x0002CCA1 File Offset: 0x0002AEA1
			public bool MoveNext()
			{
				return this.ienumerator_0.MoveNext();
			}

			// Token: 0x0600469C RID: 18076 RVA: 0x0002CCAE File Offset: 0x0002AEAE
			public void Reset()
			{
				this.ienumerator_0.Reset();
			}

			// Token: 0x04002DC4 RID: 11716
			private readonly IEnumerator ienumerator_0;
		}
	}
}
