using System;
using System.Windows;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace Command
{
	// Token: 0x02000F54 RID: 3924
	[StandardModule]
	[Attribute0]
	[Attribute1]
	[Attribute2]
	[Attribute3]
	internal sealed class SizeObserver
	{
		// Token: 0x06008C45 RID: 35909 RVA: 0x00053B5D File Offset: 0x00051D5D
		[Attribute2]
		public static bool GetObserve(FrameworkElement frameworkElement)
		{
			return Conversions.ToBoolean(frameworkElement.GetValue(SizeObserver.ObserveProperty));
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x00053B6F File Offset: 0x00051D6F
		[Attribute2]
		public static void SetObserve(FrameworkElement frameworkElement, bool observe)
		{
			frameworkElement.SetValue(SizeObserver.ObserveProperty, observe);
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x00053B82 File Offset: 0x00051D82
		[Attribute2]
		public static double GetObservedWidth(FrameworkElement frameworkElement)
		{
			return Conversions.ToDouble(frameworkElement.GetValue(SizeObserver.ObservedWidthProperty));
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x00053B94 File Offset: 0x00051D94
		[Attribute2]
		public static void SetObservedWidth(FrameworkElement frameworkElement, double observedWidth)
		{
			frameworkElement.SetValue(SizeObserver.ObservedWidthProperty, observedWidth);
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x00053BA7 File Offset: 0x00051DA7
		[Attribute2]
		public static double GetObservedHeight(FrameworkElement frameworkElement)
		{
			return Conversions.ToDouble(frameworkElement.GetValue(SizeObserver.ObservedHeightProperty));
		}

		// Token: 0x06008C4A RID: 35914 RVA: 0x00053BB9 File Offset: 0x00051DB9
		[Attribute2]
		public static void SetObservedHeight(FrameworkElement frameworkElement, double observedHeight)
		{
			frameworkElement.SetValue(SizeObserver.ObservedHeightProperty, observedHeight);
		}

		// Token: 0x06008C4B RID: 35915 RVA: 0x004B7A7C File Offset: 0x004B5C7C
		[Attribute2]
		private static void OnObserveChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
		{
			FrameworkElement frameworkElement = (FrameworkElement)dependencyObject;
			if (Conversions.ToBoolean(e.NewValue))
			{
				frameworkElement.SizeChanged += SizeObserver.OnFrameworkElementSizeChanged;
				SizeObserver.UpdateObservedSizesForFrameworkElement(frameworkElement);
				return;
			}
			frameworkElement.SizeChanged += SizeObserver.OnFrameworkElementSizeChanged;
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x00053BCC File Offset: 0x00051DCC
		[Attribute2]
		private static void OnFrameworkElementSizeChanged(object sender, SizeChangedEventArgs e)
		{
			SizeObserver.UpdateObservedSizesForFrameworkElement((FrameworkElement)sender);
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x00053BD9 File Offset: 0x00051DD9
		[Attribute2]
		private static void UpdateObservedSizesForFrameworkElement(FrameworkElement frameworkElement)
		{
			frameworkElement.SetCurrentValue(SizeObserver.ObservedWidthProperty, frameworkElement.ActualWidth);
			frameworkElement.SetCurrentValue(SizeObserver.ObservedHeightProperty, frameworkElement.ActualHeight);
		}

		// Token: 0x04004BF7 RID: 19447
		[Attribute2]
		public static readonly DependencyProperty ObserveProperty = DependencyProperty.RegisterAttached("Observe", typeof(bool), typeof(SizeObserver), new FrameworkPropertyMetadata(new PropertyChangedCallback(SizeObserver.OnObserveChanged)));

		// Token: 0x04004BF8 RID: 19448
		[Attribute2]
		public static readonly DependencyProperty ObservedWidthProperty = DependencyProperty.RegisterAttached("ObservedWidth", typeof(double), typeof(SizeObserver));

		// Token: 0x04004BF9 RID: 19449
		[Attribute2]
		public static readonly DependencyProperty ObservedHeightProperty = DependencyProperty.RegisterAttached("ObservedHeight", typeof(double), typeof(SizeObserver));
	}
}
