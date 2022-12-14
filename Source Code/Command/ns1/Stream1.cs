using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns1
{
	// Token: 0x02000080 RID: 128
	internal sealed class Stream1 : Stream
	{
		// Token: 0x06000267 RID: 615 RVA: 0x00004180 File Offset: 0x00002380
		public Stream1()
		{
			this.Position = 0L;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000041B1 File Offset: 0x000023B1
		public Stream1(byte[] byte_0)
		{
			this.Write(byte_0, 0, byte_0.Length);
			this.Position = 0L;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000041ED File Offset: 0x000023ED
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000041F0 File Offset: 0x000023F0
		public override long Length
		{
			get
			{
				return this.long_1;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000041F8 File Offset: 0x000023F8
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00004200 File Offset: 0x00002400
		public override long Position { get; set; }

		// Token: 0x0600026F RID: 623 RVA: 0x0005DD14 File Offset: 0x0005BF14
		protected byte[] method_0()
		{
			while ((long)this.list_0.Count <= this.method_1())
			{
				this.list_0.Add(new byte[this.long_2]);
			}
			return this.list_0[(int)this.method_1()];
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00004209 File Offset: 0x00002409
		protected long method_1()
		{
			return this.Position / this.long_2;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00004218 File Offset: 0x00002418
		protected long method_2()
		{
			return this.Position % this.long_2;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000378C File Offset: 0x0000198C
		public override void Flush()
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0005DD64 File Offset: 0x0005BF64
		public override int Read(byte[] buffer, int offset, int count)
		{
			long num = (long)count;
			if (num < 0L)
			{
				throw new ArgumentOutOfRangeException("count", num, "Number of bytes to copy cannot be negative.");
			}
			long num2 = this.long_1 - this.Position;
			if (num > num2)
			{
				num = num2;
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", offset, "Destination offset cannot be negative.");
			}
			int num3 = 0;
			do
			{
				long num4 = Math.Min(num, this.long_2 - this.method_2());
				Buffer.BlockCopy(this.method_0(), (int)this.method_2(), buffer, offset, (int)num4);
				num -= num4;
				offset += (int)num4;
				num3 += (int)num4;
				this.Position += num4;
			}
			while (num > 0L);
			return num3;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0005DE38 File Offset: 0x0005C038
		public override long Seek(long offset, SeekOrigin origin)
		{
			switch (origin)
			{
			case SeekOrigin.Begin:
				this.Position = offset;
				break;
			case SeekOrigin.Current:
				this.Position += offset;
				break;
			case SeekOrigin.End:
				this.Position = this.Length - offset;
				break;
			}
			return this.Position;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00004227 File Offset: 0x00002427
		public override void SetLength(long value)
		{
			this.long_1 = value;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0005DE88 File Offset: 0x0005C088
		public override void Write(byte[] buffer, int offset, int count)
		{
			long position = this.Position;
			try
			{
				do
				{
					int num = Math.Min(count, (int)(this.long_2 - this.method_2()));
					this.method_3(this.Position + (long)num);
					Buffer.BlockCopy(buffer, offset, this.method_0(), (int)this.method_2(), num);
					count -= num;
					offset += num;
					this.Position += (long)num;
				}
				while (count > 0);
			}
			catch (Exception ex)
			{
				this.Position = position;
				throw ex;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0005DF0C File Offset: 0x0005C10C
		public override int ReadByte()
		{
			if (this.Position >= this.long_1)
			{
				return -1;
			}
			int result = (int)this.method_0()[(int)(checked((IntPtr)this.method_2()))];
			long position = this.Position;
			this.Position = position + 1L;
			return result;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0005DF50 File Offset: 0x0005C150
		public override void WriteByte(byte value)
		{
			this.method_3(this.Position + 1L);
			this.method_0()[(int)(checked((IntPtr)this.method_2()))] = value;
			long position = this.Position;
			this.Position = position + 1L;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00004230 File Offset: 0x00002430
		protected void method_3(long long_3)
		{
			if (long_3 > this.long_1)
			{
				this.long_1 = long_3;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00004242 File Offset: 0x00002442
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x040001E7 RID: 487
		[CompilerGenerated]
		private long long_0;

		// Token: 0x040001E8 RID: 488
		protected long long_1;

		// Token: 0x040001E9 RID: 489
		protected long long_2 = 65536L;

		// Token: 0x040001EA RID: 490
		protected List<byte[]> list_0 = new List<byte[]>();
	}
}
