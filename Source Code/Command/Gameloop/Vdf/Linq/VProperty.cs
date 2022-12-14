using System;
using System.Runtime.CompilerServices;
using ns0;

namespace Gameloop.Vdf.Linq
{
	// Token: 0x02000043 RID: 67
	public sealed class VProperty : Class41
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00003147 File Offset: 0x00001347
		[CompilerGenerated]
		public string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000314F File Offset: 0x0000134F
		[CompilerGenerated]
		public void method_1(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003158 File Offset: 0x00001358
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00003160 File Offset: 0x00001360
		public new Class41 Value { get; set; }

		// Token: 0x060000D2 RID: 210 RVA: 0x00003169 File Offset: 0x00001369
		public VProperty()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003171 File Offset: 0x00001371
		public VProperty(string string_1, Class41 class41_1)
		{
			if (string_1 == null)
			{
				throw new ArgumentNullException("key");
			}
			this.method_1(string_1);
			this.Value = class41_1;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003195 File Offset: 0x00001395
		public override void vmethod_0(VdfWriter vdfWriter_0)
		{
			vdfWriter_0.vmethod_2(this.method_0());
			this.Value.vmethod_0(vdfWriter_0);
		}

		// Token: 0x0400009F RID: 159
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040000A0 RID: 160
		[CompilerGenerated]
		private Class41 class41_0;
	}
}
