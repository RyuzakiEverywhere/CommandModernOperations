using System;
using System.Runtime.CompilerServices;
using Gameloop.Vdf;

namespace ns0
{
	// Token: 0x02000045 RID: 69
	internal sealed class Class42 : Class41
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00003210 File Offset: 0x00001410
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00003218 File Offset: 0x00001418
		public new object Value { get; set; }

		// Token: 0x060000E2 RID: 226 RVA: 0x00003221 File Offset: 0x00001421
		public override void vmethod_0(VdfWriter vdfWriter_0)
		{
			vdfWriter_0.vmethod_3(this);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000322A File Offset: 0x0000142A
		public override string ToString()
		{
			object value = this.Value;
			string result;
			if (value != null)
			{
				if ((result = value.ToString()) != null)
				{
					return result;
				}
			}
			result = string.Empty;
			return result;
		}

		// Token: 0x040000A1 RID: 161
		[CompilerGenerated]
		private object object_0;
	}
}
