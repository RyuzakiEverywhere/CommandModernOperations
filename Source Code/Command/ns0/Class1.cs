using System;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000003 RID: 3
	internal sealed class Class1
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00053D94 File Offset: 0x00051F94
		public Class1()
		{
			Assembly assembly = Assembly.Load("mscorlib");
			this.type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
			this.object_0 = Activator.CreateInstance(this.type_0);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00053DD4 File Offset: 0x00051FD4
		public ICryptoTransform method_0(byte[] byte_0, byte[] byte_1, bool bool_0)
		{
			this.type_0.GetProperty("Key").GetSetMethod().Invoke(this.object_0, new object[]
			{
				byte_0
			});
			this.type_0.GetProperty("IV").GetSetMethod().Invoke(this.object_0, new object[]
			{
				byte_1
			});
			MethodInfo method = this.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(this.object_0, new object[0]);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000281C File Offset: 0x00000A1C
		public void method_1()
		{
			this.type_0.GetMethod("Clear").Invoke(this.object_0, new object[0]);
		}

		// Token: 0x04000003 RID: 3
		private readonly Type type_0;

		// Token: 0x04000004 RID: 4
		private readonly object object_0;
	}
}
