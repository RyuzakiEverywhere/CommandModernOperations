using System;
using System.IO;
using Gameloop.Vdf;

namespace ns0
{
	// Token: 0x0200001E RID: 30
	internal sealed class Class13 : VdfWriter
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002AAD File Offset: 0x00000CAD
		public Class13(TextWriter textWriter_1) : this(textWriter_1, Class11.smethod_0())
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002ABB File Offset: 0x00000CBB
		public Class13(TextWriter textWriter_1, Class11 class11_1) : base(class11_1)
		{
			if (textWriter_1 == null)
			{
				throw new ArgumentNullException("writer");
			}
			this.textWriter_0 = textWriter_1;
			this.int_0 = 0;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public override void vmethod_2(string string_0)
		{
			this.method_5(VdfWriter.State.const_1);
			this.textWriter_0.Write('"');
			this.method_6(string_0);
			this.textWriter_0.Write('"');
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002B0A File Offset: 0x00000D0A
		public override void vmethod_3(Class42 class42_0)
		{
			this.method_5(VdfWriter.State.Value);
			this.textWriter_0.Write('"');
			this.method_6(class42_0.ToString());
			this.textWriter_0.Write('"');
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002B39 File Offset: 0x00000D39
		public override void vmethod_0()
		{
			this.method_5(VdfWriter.State.const_3);
			this.textWriter_0.Write('{');
			this.int_0++;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002B5D File Offset: 0x00000D5D
		public override void vmethod_1()
		{
			this.int_0--;
			this.method_5(VdfWriter.State.const_4);
			this.textWriter_0.Write('}');
			if (this.int_0 == 0)
			{
				this.method_5(VdfWriter.State.const_5);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0005539C File Offset: 0x0005359C
		private void method_5(VdfWriter.State state_1)
		{
			if (base.method_3() == VdfWriter.State.const_0)
			{
				base.method_4(state_1);
				return;
			}
			switch (state_1)
			{
			case VdfWriter.State.const_1:
			case VdfWriter.State.const_3:
			case VdfWriter.State.const_4:
				this.textWriter_0.WriteLine();
				this.textWriter_0.Write(new string('\t', this.int_0));
				break;
			case VdfWriter.State.Value:
				this.textWriter_0.Write(' ');
				break;
			case VdfWriter.State.const_5:
				this.textWriter_0.WriteLine();
				break;
			}
			base.method_4(state_1);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00055420 File Offset: 0x00053620
		private void method_6(string string_0)
		{
			if (!base.method_0().bool_0)
			{
				this.textWriter_0.Write(string_0);
				return;
			}
			foreach (char c in string_0)
			{
				if (!Class12.smethod_0(c))
				{
					this.textWriter_0.Write(c);
				}
				else
				{
					this.textWriter_0.Write('\\');
					this.textWriter_0.Write(Class12.smethod_1(c));
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002B90 File Offset: 0x00000D90
		public override void vmethod_4()
		{
			base.vmethod_4();
			if (base.method_1())
			{
				this.textWriter_0.Dispose();
			}
		}

		// Token: 0x0400005E RID: 94
		private readonly TextWriter textWriter_0;

		// Token: 0x0400005F RID: 95
		private int int_0;
	}
}
