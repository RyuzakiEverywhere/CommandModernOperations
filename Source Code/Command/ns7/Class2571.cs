using System;
using System.ComponentModel;
using System.Drawing;
using Command;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Microsoft.VisualBasic.CompilerServices;
using ns19;
using ns20;
using ns21;
using ns5;

namespace ns7
{
	// Token: 0x02000F56 RID: 3926
	[StandardModule]
	internal sealed class Class2571
	{
		// Token: 0x02000F57 RID: 3927
		internal sealed class Class1880 : Class1870
		{
			// Token: 0x06008C50 RID: 35920 RVA: 0x004B7B38 File Offset: 0x004B5D38
			public Class1880(Class1874 class1874_1, Class1821 class1821_1) : base("Scale")
			{
				this.double_0 = 0.0;
				this.float_0 = 0.15f;
				this.float_1 = 0.0175f;
				this.string_3 = new string[4];
				this.int_0 = Color.FromArgb(255, 255, 255, 255).ToArgb();
				this.transformedColored_0 = new CustomVertex.TransformedColored[2];
				this.transformedColored_1 = new CustomVertex.TransformedColored[10][];
				this.vmethod_7(Enum170.const_5);
				this.vmethod_12(true);
				Device device = Class2413.smethod_2().method_41().vmethod_796().method_3();
				this.class1874_0 = class1874_1;
				this.class1821_0 = class1821_1;
				this.double_3 = (double)class1821_1.font_0.MeasureString(null, "Aj", DrawTextFormat.None, 0).Height;
				int num = this.transformedColored_1.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					this.transformedColored_1[i] = new CustomVertex.TransformedColored[2];
				}
				int num2 = this.transformedColored_0.Length - 1;
				for (int j = 0; j <= num2; j++)
				{
					this.transformedColored_0[j].Color = this.int_0;
				}
				int num3 = this.transformedColored_1.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					int num4 = this.transformedColored_1[k].Length - 1;
					for (int l = 0; l <= num4; l++)
					{
						this.transformedColored_1[k][l].Color = this.int_0;
					}
				}
				device.DeviceResizing += new CancelEventHandler(this.method_0);
				this.method_0(device, new CancelEventArgs());
			}

			// Token: 0x06008C51 RID: 35921 RVA: 0x004B7CF0 File Offset: 0x004B5EF0
			public void method_0(object sender, CancelEventArgs e)
			{
				Device device = (Device)sender;
				int width = device.Viewport.Width;
				int height = device.Viewport.Height;
				this.point_0 = new Point((int)Math.Round((double)((float)width * (1f - this.float_0) / 2f)), (int)Math.Round((double)height / 2.0));
				this.point_1 = new Point((int)Math.Round((double)((float)width * (1f + this.float_0) / 2f)), (int)Math.Round((double)height / 2.0));
				this.point_2 = new Point((int)Math.Round((double)((float)width * (1f - this.float_1 - this.float_0))), (int)Math.Round((double)((float)height * (1f - this.float_1))));
				this.point_3 = new Point((int)Math.Round((double)((float)width * (1f - this.float_1))), (int)Math.Round((double)((float)height * (1f - this.float_1))));
				int num = (int)Math.Round((double)(10f * Client.float_1));
				ref Point ptr = ref this.point_2;
				this.point_2.X = ptr.X + -30;
				ptr = ref this.point_3;
				this.point_3.X = ptr.X + -30;
				ptr = ref this.point_2;
				this.point_2.Y = ptr.Y + num;
				ptr = ref this.point_3;
				this.point_3.Y = ptr.Y + num;
				this.transformedColored_0[0].X = (float)this.point_2.X;
				this.transformedColored_0[0].Y = (float)(this.point_2.Y - (int)Math.Round(this.double_3 * 1.1));
				this.transformedColored_0[1].X = (float)this.point_3.X;
				this.transformedColored_0[1].Y = (float)(this.point_3.Y - (int)Math.Round(this.double_3 * 1.1));
				float num2 = (float)(this.point_3.X - this.point_2.X) / (float)(this.transformedColored_1.Length - 1);
				int num3 = this.transformedColored_1.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					this.transformedColored_1[i][0].X = (float)this.point_2.X + num2 * (float)i;
					this.transformedColored_1[i][1].X = (float)this.point_2.X + num2 * (float)i;
					this.transformedColored_1[i][0].Y = (float)(this.point_2.Y - (int)Math.Round(this.double_3 * 1.1));
					this.transformedColored_1[i][1].Y = (float)(this.point_2.Y - (int)Math.Round(this.double_3 * 1.1)) - this.float_1 * (float)height;
				}
			}

			// Token: 0x06008C52 RID: 35922 RVA: 0x00053C2B File Offset: 0x00051E2B
			public override bool vmethod_11()
			{
				return base.vmethod_11();
			}

			// Token: 0x06008C53 RID: 35923 RVA: 0x00053C33 File Offset: 0x00051E33
			public override void vmethod_12(bool bool_3)
			{
				if (bool_3 != this.vmethod_11())
				{
					base.vmethod_12(bool_3);
				}
			}

			// Token: 0x06008C54 RID: 35924 RVA: 0x004B802C File Offset: 0x004B622C
			public override void vmethod_2(Class1821 class1821_1)
			{
				if (this.vmethod_11())
				{
					Device device = Class2413.smethod_2().method_41().vmethod_796().method_3();
					device.TextureState[0].ColorOperation = TextureOperation.Disable;
					device.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Transformed);
					if (class1821_1.method_1().vmethod_2().method_0() <= 70.0)
					{
						class1821_1.method_1().vmethod_28(this.point_0.X, this.point_0.Y, out this.struct65_0, out this.struct65_1);
						if (!Struct65.smethod_2(this.struct65_0) && !Struct65.smethod_2(this.struct65_1))
						{
							class1821_1.method_1().vmethod_28(this.point_1.X, this.point_1.Y, out this.struct65_2, out this.struct65_3);
							if (!Struct65.smethod_2(this.struct65_2) && !Struct65.smethod_2(this.struct65_3))
							{
								Struct65 @struct = Class1874.smethod_1(this.struct65_0, this.struct65_1, this.struct65_2, this.struct65_3);
								this.double_1 = @struct.double_0 * this.class1874_0.method_4();
								if (this.double_1 > 5556.0)
								{
									this.double_2 = 1852.0;
									this.string_2 = "Nautical miles";
								}
								else
								{
									this.double_2 = 1.0;
									this.string_2 = "Meters";
								}
								Device device2 = device;
								device2.Clear(ClearFlags.ZBuffer, 0, 1f, 0);
								Compare zbufferFunction = device2.RenderState.ZBufferFunction;
								Cull cullMode = device2.RenderState.CullMode;
								bool alphaBlendEnable = device2.RenderState.AlphaBlendEnable;
								Blend sourceBlend = device2.RenderState.SourceBlend;
								BlendOperation blendOperation = device2.RenderState.BlendOperation;
								Blend destinationBlend = device2.RenderState.DestinationBlend;
								Matrix world = device2.Transform.World;
								Matrix projection = device2.Transform.Projection;
								Matrix view = device2.Transform.View;
								VertexFormats vertexFormat = device2.VertexFormat;
								TextureOperation alphaOperation = device2.TextureState[0].AlphaOperation;
								TextureArgument alphaArgument = device2.TextureState[0].AlphaArgument0;
								TextureOperation colorOperation = device2.TextureState[0].ColorOperation;
								TextureArgument colorArgument = device2.TextureState[0].ColorArgument0;
								TextureArgument colorArgument2 = device2.TextureState[0].ColorArgument1;
								TextureArgument colorArgument3 = device2.TextureState[0].ColorArgument2;
								device2.RenderState.CullMode = Cull.None;
								device2.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
								device2.SamplerState[0].MagFilter = TextureFilter.Linear;
								device2.SamplerState[0].MinFilter = TextureFilter.Linear;
								device2.RenderState.BlendOperation = BlendOperation.Add;
								device2.RenderState.SourceBlend = Blend.SourceAlpha;
								device2.RenderState.DestinationBlend = Blend.InvSourceAlpha;
								device2.TextureState[0].AlphaOperation = TextureOperation.SelectArg1;
								device2.TextureState[0].AlphaArgument0 = TextureArgument.Diffuse;
								device2.TextureState[0].AlphaArgument1 = TextureArgument.Diffuse;
								device2.TextureState[0].AlphaArgument2 = TextureArgument.Diffuse;
								device2.TextureState[0].ColorOperation = TextureOperation.SelectArg1;
								device2.TextureState[0].ColorArgument0 = TextureArgument.Diffuse;
								device2.TextureState[0].ColorArgument1 = TextureArgument.Diffuse;
								device2.TextureState[0].ColorArgument2 = TextureArgument.Diffuse;
								device2.RenderState.Lighting = false;
								device2.RenderState.ZBufferFunction = Compare.Always;
								device2.RenderState.BlendFactor = Color.FromArgb(255, 255, 255, 0);
								int int_ = class1821_1.int_4;
								int int_2 = class1821_1.int_3;
								device2.Transform.World = Matrix.Identity;
								device2.Transform.Projection = Matrix.OrthoLH((float)int_2, (float)int_, -1f, 1f);
								device2.Transform.View = Matrix.Translation((float)((double)(-(double)int_2) / 2.0) - (float)this.double_0, (float)((double)(-(double)int_) / 2.0), 0f) * Matrix.Scaling(1f, -1f, 1f);
								device.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Position);
								device.DrawUserPrimitives(PrimitiveType.LineStrip, this.transformedColored_0.GetLength(0) - 1, this.transformedColored_0);
								this.method_2(Color.White, 1f, this.transformedColored_0[0].X, this.transformedColored_0[0].Y, this.transformedColored_0[1].X, this.transformedColored_0[1].Y);
								int num = this.transformedColored_1.Length - 1;
								for (int i = 0; i <= num; i++)
								{
									this.method_2(Color.White, 1f, this.transformedColored_1[i][0].X, this.transformedColored_1[i][0].Y, this.transformedColored_1[i][1].X, this.transformedColored_1[i][1].Y);
								}
								device.VertexFormat = (VertexFormats.Diffuse | VertexFormats.Transformed);
								device2.Transform.World = Matrix.Translation((float)(-(float)class1821_1.method_1().class1831_1.double_0), (float)(-(float)class1821_1.method_1().class1831_1.double_1), (float)(-(float)class1821_1.method_1().class1831_1.double_2));
								device2.Transform.Projection = projection;
								device2.Transform.View = view;
								device2.RenderState.CullMode = cullMode;
								device2.RenderState.AlphaBlendEnable = alphaBlendEnable;
								device2.RenderState.SourceBlend = sourceBlend;
								device2.RenderState.DestinationBlend = destinationBlend;
								device2.RenderState.BlendOperation = blendOperation;
								device2.Transform.World = world;
								device2.Transform.Projection = projection;
								device2.Transform.View = view;
								device2.RenderState.ZBufferFunction = zbufferFunction;
								device2.VertexFormat = vertexFormat;
								device2.TextureState[0].AlphaOperation = alphaOperation;
								device2.TextureState[0].AlphaArgument0 = alphaArgument;
								device2.TextureState[0].ColorOperation = colorOperation;
								device2.TextureState[0].ColorArgument0 = colorArgument;
								device2.TextureState[0].ColorArgument1 = colorArgument2;
								device2.TextureState[0].ColorArgument2 = colorArgument3;
								Rectangle rectangle = class1821_1.font_0.MeasureString(null, this.string_2, DrawTextFormat.None, 0);
								class1821_1.font_0.DrawText(null, this.string_2, (int)Math.Round((double)(this.point_2.X + this.point_3.X - rectangle.Width) / 2.0 - (double)((float)this.double_0)), this.point_2.Y - rectangle.Height, this.int_0);
								float num2 = (float)(this.point_3.X - this.point_2.X) / (float)(this.string_3.Length - 1);
								this.string_3[0] = "0";
								int num3 = this.string_3.Length - 1;
								for (int j = 0; j <= num3; j++)
								{
									if (j > 0)
									{
										double num4 = this.double_1 / this.double_2 * ((double)j / (double)(this.string_3.Length - 1));
										if (num4 == 0.0)
										{
											this.string_3[j] = "n/a";
										}
										else
										{
											this.string_3[j] = this.method_1(num4, 2).ToString();
										}
									}
									Rectangle rectangle2 = class1821_1.font_0.MeasureString(null, this.string_3[j], DrawTextFormat.None, 0);
									class1821_1.font_0.DrawText(null, this.string_3[j], (int)Math.Round((double)((float)this.point_2.X + num2 * (float)j) - (double)rectangle2.Width / 2.0 - (double)((float)this.double_0)), (int)Math.Round((double)(this.transformedColored_1[j][1].Y - (float)rectangle2.Height) - (double)(this.transformedColored_1[j][0].Y - this.transformedColored_1[j][1].Y) * 0.1), this.int_0);
								}
							}
						}
					}
				}
			}

			// Token: 0x06008C55 RID: 35925 RVA: 0x004B88A0 File Offset: 0x004B6AA0
			public int method_1(double double_4, int int_1)
			{
				if (double_4 == 0.0)
				{
					throw new ArgumentException("Precise is ZERO!");
				}
				int num = (int)Math.Round(Math.Log10(double_4) + 1.0);
				int result;
				if (num <= int_1)
				{
					result = (int)Math.Round(double_4);
				}
				else
				{
					int num2 = (int)Math.Round(Math.Pow(10.0, (double)(num - int_1)));
					result = (int)Math.Round(Math.Round(double_4 / (double)num2) * (double)num2);
				}
				return result;
			}

			// Token: 0x06008C56 RID: 35926 RVA: 0x0002BEFE File Offset: 0x0002A0FE
			public override void vmethod_0(Class1821 class1821_1)
			{
				this.bool_0 = true;
			}

			// Token: 0x06008C57 RID: 35927 RVA: 0x00053C45 File Offset: 0x00051E45
			public override bool vmethod_1(Class1821 class1821_1)
			{
				if (!this.bool_0)
				{
					this.vmethod_0(class1821_1);
				}
				return true;
			}

			// Token: 0x06008C58 RID: 35928 RVA: 0x00053C57 File Offset: 0x00051E57
			public override void Dispose()
			{
				this.bool_0 = false;
			}

			// Token: 0x06008C59 RID: 35929 RVA: 0x00003024 File Offset: 0x00001224
			public override bool vmethod_5(Class1821 class1821_1)
			{
				return false;
			}

			// Token: 0x06008C5A RID: 35930 RVA: 0x004B8918 File Offset: 0x004B6B18
			private void method_2(Color color_0, float float_2, float float_3, float float_4, float float_5, float float_6)
			{
				Device device = Class2413.smethod_2().method_41().vmethod_796().method_3();
				if (float_2 > 0f)
				{
					int c = color_0.ToArgb();
					Vector3 vector = new Vector3(float_3, float_4, 0f);
					Vector3 left = new Vector3(float_5, float_6, 0f);
					Vector3 vector2 = left - vector;
					Vector3 vector3 = new Vector3(vector2.Y, -vector2.X, 0f);
					vector3 = Vector3.Scale(vector3, float_2 / vector3.Length() / 2f);
					device.DrawUserPrimitives(PrimitiveType.TriangleList, 2, new CustomVertex.PositionColored[]
					{
						new CustomVertex.PositionColored(vector + vector3, c),
						new CustomVertex.PositionColored(left - vector3, c),
						new CustomVertex.PositionColored(vector - vector3, c),
						new CustomVertex.PositionColored(left + vector3, c),
						new CustomVertex.PositionColored(left - vector3, c),
						new CustomVertex.PositionColored(vector + vector3, c)
					});
				}
			}

			// Token: 0x04004BFA RID: 19450
			public double double_0;

			// Token: 0x04004BFB RID: 19451
			public Struct65 struct65_0;

			// Token: 0x04004BFC RID: 19452
			public Struct65 struct65_1;

			// Token: 0x04004BFD RID: 19453
			public Point point_0;

			// Token: 0x04004BFE RID: 19454
			public Struct65 struct65_2;

			// Token: 0x04004BFF RID: 19455
			public Struct65 struct65_3;

			// Token: 0x04004C00 RID: 19456
			public Point point_1;

			// Token: 0x04004C01 RID: 19457
			public Point point_2;

			// Token: 0x04004C02 RID: 19458
			public Point point_3;

			// Token: 0x04004C03 RID: 19459
			public double double_1;

			// Token: 0x04004C04 RID: 19460
			private Class1821 class1821_0;

			// Token: 0x04004C05 RID: 19461
			private string string_2;

			// Token: 0x04004C06 RID: 19462
			private double double_2;

			// Token: 0x04004C07 RID: 19463
			private double double_3;

			// Token: 0x04004C08 RID: 19464
			private float float_0;

			// Token: 0x04004C09 RID: 19465
			private float float_1;

			// Token: 0x04004C0A RID: 19466
			private string[] string_3;

			// Token: 0x04004C0B RID: 19467
			private int int_0;

			// Token: 0x04004C0C RID: 19468
			private CustomVertex.TransformedColored[] transformedColored_0;

			// Token: 0x04004C0D RID: 19469
			private CustomVertex.TransformedColored[][] transformedColored_1;
		}
	}
}
