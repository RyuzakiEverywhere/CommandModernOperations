using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;
using ns2;
using ns5;

namespace ns7
{
	// Token: 0x02000F3D RID: 3901
	[StandardModule]
	internal sealed class Class2558
	{
		// Token: 0x06008BD9 RID: 35801
		[DllImport("user32.dll")]
		public static extern bool ShowScrollBar(IntPtr intptr_0, int int_0, bool bool_0);

		// Token: 0x06008BDA RID: 35802 RVA: 0x004B5760 File Offset: 0x004B3960
		public static string smethod_0(string string_0)
		{
			string text = string_0;
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			foreach (char value in text)
			{
				foreach (char c in invalidFileNameChars)
				{
					if (Operators.CompareString(c.ToString(), value.ToString(), false) == 0)
					{
						text = text.Replace(Conversions.ToString(value), "");
					}
				}
			}
			return text;
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x00053809 File Offset: 0x00051A09
		public static Bitmap smethod_1(string string_0, Bitmap bitmap_1, float float_0)
		{
			return Class2558.smethod_2(string_0, bitmap_1, float_0);
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x004B57DC File Offset: 0x004B39DC
		private static Bitmap smethod_2(string string_0, Image image_0, float float_0)
		{
			Bitmap result;
			if ((int)Math.Round((double)float_0) == 0)
			{
				result = (Bitmap)image_0;
			}
			else if (image_0 == null)
			{
				result = null;
			}
			else
			{
				Image image = null;
				Client.dictionary_2.TryGetValue(string_0 + Conversions.ToString((int)Math.Round((double)float_0)), out image);
				if (Information.IsNothing(image))
				{
					Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
					Graphics graphics = Graphics.FromImage(bitmap);
					graphics.TranslateTransform((float)image_0.Width / 2f, (float)image_0.Height / 2f);
					graphics.RotateTransform((float)((int)Math.Round((double)float_0)));
					graphics.TranslateTransform(-(float)image_0.Width / 2f, -(float)image_0.Height / 2f);
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.DrawImage(image_0, new Point(0, 0));
					image = bitmap;
					Client.dictionary_2.Add(string_0 + Conversions.ToString((int)Math.Round((double)float_0)), image);
				}
				result = (Bitmap)image;
			}
			return result;
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x004B58DC File Offset: 0x004B3ADC
		public static void smethod_3(Control control_0)
		{
			Point p = new Point((int)Math.Round((double)(control_0.Left + control_0.Right) / 2.0), (int)Math.Round((double)(control_0.Top + control_0.Bottom) / 2.0));
			Cursor.Position = control_0.Parent.PointToScreen(p);
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x004B5940 File Offset: 0x004B3B40
		public static Bitmap smethod_4(Bitmap image, Size size, bool preserveAspectRatio = true)
		{
			int num;
			Bitmap result;
			Image image2;
			if (0 == image.Width && num == image.Height)
			{
				result = image;
			}
			else if (Client.dictionary_4.TryGetValue(image, out image2))
			{
				result = (Bitmap)image2;
			}
			else
			{
				int width2;
				if (preserveAspectRatio)
				{
					int width = image.Width;
					int height = image.Height;
					float num2 = (float)size.Width / (float)width;
					float num3 = (float)size.Height / (float)height;
					float num4 = (num3 < num2) ? num3 : num2;
					width2 = (int)Math.Round((double)((float)width * num4));
					num = (int)Math.Round((double)((float)height * num4));
				}
				else
				{
					width2 = size.Width;
					num = size.Height;
				}
				Bitmap bitmap = new Bitmap(width2, num);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.DrawImage(image, 0, 0, width2, num);
				}
				Client.dictionary_4.Add(image, bitmap);
				result = bitmap;
			}
			return result;
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x004B5A44 File Offset: 0x004B3C44
		public static ReadOnlyCollection<TreeNode> smethod_5(TreeView treeView_0)
		{
			List<TreeNode> list = new List<TreeNode>();
			try
			{
				foreach (object obj in treeView_0.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (!list.Contains(treeNode))
					{
						list.Add(treeNode);
					}
					Class2558.smethod_12(treeNode, list);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return list.AsReadOnly();
		}

		// Token: 0x06008BE0 RID: 35808 RVA: 0x004B5ABC File Offset: 0x004B3CBC
		public static void smethod_6(Control6 control6_0)
		{
			ReadOnlyCollection<Class127> readOnlyCollection = Class2558.smethod_9(control6_0);
			try
			{
				foreach (Class127 @class in readOnlyCollection)
				{
					@class.method_22(true);
				}
			}
			finally
			{
				IEnumerator<Class127> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x004B5B0C File Offset: 0x004B3D0C
		public static void smethod_7(Control5 control5_0)
		{
			ReadOnlyCollection<Class126> readOnlyCollection = Class2558.smethod_10(control5_0);
			try
			{
				foreach (Class126 @class in readOnlyCollection)
				{
					@class.method_21(true);
				}
			}
			finally
			{
				IEnumerator<Class126> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06008BE2 RID: 35810 RVA: 0x004B5B5C File Offset: 0x004B3D5C
		public static void smethod_8(Control5 control5_0)
		{
			ReadOnlyCollection<Class126> readOnlyCollection = Class2558.smethod_10(control5_0);
			try
			{
				foreach (Class126 @class in readOnlyCollection)
				{
					@class.method_21(false);
				}
			}
			finally
			{
				IEnumerator<Class126> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x004B5BAC File Offset: 0x004B3DAC
		public static ReadOnlyCollection<Class127> smethod_9(Control6 control6_0)
		{
			List<Class127> list = new List<Class127>();
			try
			{
				foreach (Class127 @class in control6_0.method_20())
				{
					if (!list.Contains(@class))
					{
						list.Add(@class);
					}
					Class2558.smethod_13(@class, list);
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return list.AsReadOnly();
		}

		// Token: 0x06008BE4 RID: 35812 RVA: 0x004B5C1C File Offset: 0x004B3E1C
		public static ReadOnlyCollection<Class126> smethod_10(Control5 control5_0)
		{
			List<Class126> list = new List<Class126>();
			try
			{
				foreach (Class126 @class in control5_0.method_19())
				{
					if (!list.Contains(@class))
					{
						list.Add(@class);
					}
					Class2558.smethod_14(@class, list);
				}
			}
			finally
			{
				List<Class126>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return list.AsReadOnly();
		}

		// Token: 0x06008BE5 RID: 35813 RVA: 0x004B5C8C File Offset: 0x004B3E8C
		public static void smethod_11(WebBrowser webBrowser_0, string string_0)
		{
			try
			{
				string_0 = "<style>\r\n                        body\r\n                            {\r\n                            background:#333333;\r\n                            color:Lightgrey;\r\n                            scrollbar-face-color: #696969;\r\n                            scrollbar-highlight-color: #696969;\r\n                            scrollbar-3dlight-color: #696969;\r\n                            scrollbar-darkshadow-color: #696969;\r\n                            scrollbar-shadow-color: #696969;\r\n                            scrollbar-arrow-color: #696969;\r\n                            scrollbar-track-color: #333333;\r\n                            }\r\n                        hr\r\n                            {\r\n                            border-color:Lightgrey; \r\n                            background-color:Lightgrey\r\n                            }\r\n                        </style><FONT face=Calibri>" + string_0 + "<FONT>";
				webBrowser_0.DocumentText = string_0;
				webBrowser_0.Document.BackColor = Color.Black;
				webBrowser_0.Document.Write(string_0);
			}
			catch (Exception ex)
			{
				ex.Data.Add("Error at 200101", ex.Message);
				GameGeneral.smethod_25(ref ex);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
			}
		}

		// Token: 0x06008BE6 RID: 35814 RVA: 0x004B5D18 File Offset: 0x004B3F18
		private static void smethod_12(TreeNode treeNode_0, List<TreeNode> list_0)
		{
			try
			{
				foreach (object obj in treeNode_0.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (!list_0.Contains(treeNode))
					{
						list_0.Add(treeNode);
					}
					Class2558.smethod_12(treeNode, list_0);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06008BE7 RID: 35815 RVA: 0x004B5D84 File Offset: 0x004B3F84
		private static void smethod_13(Class127 class127_0, List<Class127> list_0)
		{
			try
			{
				foreach (Class127 @class in class127_0.method_23())
				{
					if (!list_0.Contains(@class))
					{
						list_0.Add(@class);
					}
					Class2558.smethod_13(@class, list_0);
				}
			}
			finally
			{
				List<Class127>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06008BE8 RID: 35816 RVA: 0x004B5DE8 File Offset: 0x004B3FE8
		private static void smethod_14(Class126 class126_0, List<Class126> list_0)
		{
			try
			{
				foreach (Class126 @class in class126_0.method_22())
				{
					if (!list_0.Contains(@class))
					{
						list_0.Add(@class);
					}
					Class2558.smethod_14(@class, list_0);
				}
			}
			finally
			{
				List<Class126>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x004B5E4C File Offset: 0x004B404C
		public static ReadOnlyCollection<Class48> smethod_15(TreeGridView treeGridView_0)
		{
			List<Class48> list = new List<Class48>();
			try
			{
				foreach (Class48 @class in treeGridView_0.method_2())
				{
					if (!list.Contains(@class))
					{
						list.Add(@class);
					}
					Class2558.smethod_16(@class, list);
				}
			}
			finally
			{
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return list.AsReadOnly();
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x004B5EB8 File Offset: 0x004B40B8
		private static void smethod_16(Class48 class48_0, List<Class48> list_0)
		{
			try
			{
				foreach (Class48 @class in class48_0.method_7())
				{
					if (!list_0.Contains(@class))
					{
						list_0.Add(@class);
					}
					Class2558.smethod_16(@class, list_0);
				}
			}
			finally
			{
				IEnumerator<Class48> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x004B5F18 File Offset: 0x004B4118
		public static bool smethod_17(ActiveUnit activeUnit_0)
		{
			bool result;
			try
			{
				if (string.IsNullOrEmpty(Client.smethod_52().method_59()))
				{
					result = false;
				}
				else
				{
					result = (Operators.CompareString(activeUnit_0.string_0, Client.smethod_52().method_59(), false) == 0);
				}
			}
			catch (Exception ex)
			{
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x00053813 File Offset: 0x00051A13
		public static void smethod_18(Form form_0)
		{
			form_0.SuspendLayout();
			form_0.WindowState = FormWindowState.Normal;
			form_0.FormBorderStyle = FormBorderStyle.None;
			form_0.WindowState = FormWindowState.Maximized;
			if (form_0 == Class2413.smethod_2().mainForm_0)
			{
				Class2413.smethod_2().method_41().method_102();
			}
			form_0.ResumeLayout();
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x00053852 File Offset: 0x00051A52
		public static void smethod_19(Form form_0)
		{
			form_0.SuspendLayout();
			form_0.FormBorderStyle = FormBorderStyle.Sizable;
			form_0.WindowState = FormWindowState.Maximized;
			form_0.ResumeLayout();
		}

		// Token: 0x04004BD6 RID: 19414
		public static Bitmap bitmap_0;
	}
}
