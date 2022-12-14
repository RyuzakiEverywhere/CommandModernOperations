using System;

namespace ns8
{
	// Token: 0x02000103 RID: 259
	internal static class Class147
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x000741FC File Offset: 0x000723FC
		public static int smethod_0(byte[] byte_0, int int_0, Enum26 enum26_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			if (int_0 + 4 > byte_0.Length)
			{
				throw new ArgumentException("startIndex invalid (not enough space in value to extract an integer", "startIndex");
			}
			if (BitConverter.IsLittleEndian && enum26_0 == Enum26.const_0)
			{
				byte[] array = new byte[4];
				Array.Copy(byte_0, int_0, array, 0, 4);
				Array.Reverse(array);
				return BitConverter.ToInt32(array, 0);
			}
			return BitConverter.ToInt32(byte_0, int_0);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00074260 File Offset: 0x00072460
		public static double smethod_1(byte[] byte_0, int int_0, Enum26 enum26_0)
		{
			if (byte_0 == null)
			{
				throw new ArgumentNullException("value");
			}
			if (int_0 + 8 > byte_0.Length)
			{
				throw new ArgumentException("startIndex invalid (not enough space in value to extract a double", "startIndex");
			}
			if (BitConverter.IsLittleEndian && enum26_0 == Enum26.const_0)
			{
				byte[] array = new byte[8];
				Array.Copy(byte_0, int_0, array, 0, 8);
				Array.Reverse(array);
				return BitConverter.ToDouble(array, 0);
			}
			return BitConverter.ToDouble(byte_0, int_0);
		}
	}
}
