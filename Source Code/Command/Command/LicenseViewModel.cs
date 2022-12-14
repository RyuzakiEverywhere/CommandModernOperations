﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using ns5;
using ns7;

namespace Command
{
	// Token: 0x02000DFA RID: 3578
	[Attribute12]
	[Attribute13]
	[Attribute11]
	public sealed class LicenseViewModel : INotifyPropertyChanged
	{
		// Token: 0x06006855 RID: 26709 RVA: 0x0004248E File Offset: 0x0004068E
		public LicenseViewModel()
		{
			this.UnlockCommand = new Class2569(new Action<object>(this.method_1));
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06006856 RID: 26710 RVA: 0x000424AD File Offset: 0x000406AD
		// (set) Token: 0x06006857 RID: 26711 RVA: 0x000424B5 File Offset: 0x000406B5
		public string Title
		{
			[CompilerGenerated]
			get
			{
				return this.string_0;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_0, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_0 = value;
				this.vmethod_0("Title");
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06006858 RID: 26712 RVA: 0x000424D9 File Offset: 0x000406D9
		// (set) Token: 0x06006859 RID: 26713 RVA: 0x000424E1 File Offset: 0x000406E1
		public string Subtitle
		{
			[CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.string_1, value, StringComparison.Ordinal))
				{
					return;
				}
				this.string_1 = value;
				this.vmethod_0("Subtitle");
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x00042505 File Offset: 0x00040705
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x0004250D File Offset: 0x0004070D
		public bool Required
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				this.vmethod_0("Required");
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x0600685C RID: 26716 RVA: 0x0004252D File Offset: 0x0004072D
		// (set) Token: 0x0600685D RID: 26717 RVA: 0x00042535 File Offset: 0x00040735
		public bool Owned
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				if (this.bool_1 == value)
				{
					return;
				}
				this.bool_1 = value;
				this.vmethod_0("Owned");
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x0600685E RID: 26718 RVA: 0x00042555 File Offset: 0x00040755
		// (set) Token: 0x0600685F RID: 26719 RVA: 0x0004255D File Offset: 0x0004075D
		public Class2556.Enum209 AssociatedLicense
		{
			[CompilerGenerated]
			get
			{
				return this.enum209_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.enum209_0 == value)
				{
					return;
				}
				this.enum209_0 = value;
				this.vmethod_0("AssociatedLicense");
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x0004257D File Offset: 0x0004077D
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x00042585 File Offset: 0x00040785
		public Class2569 UnlockCommand
		{
			[CompilerGenerated]
			get
			{
				return this.class2569_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.class2569_0 == value)
				{
					return;
				}
				this.class2569_0 = value;
				this.vmethod_0("UnlockCommand");
			}
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x000425A5 File Offset: 0x000407A5
		public void method_0()
		{
			Class2413.smethod_2().method_30().method_2(new List<Class2556.Enum209>
			{
				this.AssociatedLicense
			});
			Class2413.smethod_2().method_30().Show();
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06006863 RID: 26723 RVA: 0x000425D6 File Offset: 0x000407D6
		public static BitmapImage LockImage { get; } = Class2570.smethod_1("iVBORw0KGgoAAAANSUhEUgAAAB4AAAAkCAMAAACpD3pbAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAMAUExURQAAAABVUwBXVABXVQBXVwBXWABYWABZWgBdWwBeWwBfYABgXQBgYABiYABkYQBmZwBpaABraABraQBragBtagBubABubgBubwBwbgBzdAB0cQB1cgB1dAB2dAB2dQB3dgB2dwB1eQB1egB3eQB5eAB6ewB7fAB7fwB9ewB9fAB9fwB+gQx8hBF/hgCDgQGDhgGDhwCFgwCFhACFhgCFhwCJhwGKjACNjACNjgCNjwCOjACPjgCPjwWJjgmDjACPkAWOkwmJkgmKkgmLlAiNlQmNlgiOlgCQkQCTkQCSkgCRlQCTlACVlQCUlgCVlwCWlgCWlwCYmACYmQCZmgCamACamgCanQCcnACcnwCengCfnwmQmAiQmQmRmhGAhhKNlBGOlRWPlBKUmxKVnBGYnwCdoACfogufpgufpwChoACioQCiogCipACkpACmpQCnpgClqACopwCpqACqqQCsqgCurQCwrgCxrwC2swC2tQC5tgC6uAC7uQC7uwC8ugC+uwC+vw61uhOmqxuvshG5vhG5vxuzthq8vxe/xADBvgDCvgDCvwDHwwDJxQDLxgDLxwDNyQDOywDQywLSzwDT0gDX1wjb2xLKzxjExxnEyBvIyhTQ1R/d3hDd4Rne4Q7l6BHi5hDn6xfp7Bfq7R3s7R3s7iLT0iLW1SPX1iPX1yLc3CTf3iXn5SPt7CTr6iHz8yj28wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB8/qLMAAAEAdFJOU////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////wBT9wclAAAACXBIWXMAAA7DAAAOwwHHb6hkAAAAGHRFWHRTb2Z0d2FyZQBwYWludC5uZXQgNC4wLjlsM35OAAACN0lEQVQ4T5WQ6VsSURSHKcwWtSzT1JQi9zQrDTVzNxUyI1RUXFLLFgqZRlzASXEpl1IZwLDccNos9/9wuvfcE9FTX3o/vef3PnM/jEL+RefUN2SqEydZDuSH01sHyNb0IxwDuevD6h7Wg73Vj104Y+6Z+bK/u7P9Y3Pz+/bO7v7XmR62Y3698ml9ebKbavfk8vrnlTcwYy5Z25CWJh6Ay1cmlqSNtRJwliskSRrPAiVkjZOzAvR3fgoGPPtHbgMD2v4vl/+dy8FYriR3OxjQTs5KMJaryN0BBnSQswqM5dt+vz/4a3JWg7Fc7PP5ysCAMnIWg7F81ev15oEBeeS8BsZyjcfjMYEBJnLWgLHcS+5Ryx3EMkrOXgg0q+sdbtHlXnyPLLpdottRr8asH3wrztodI2PIiMM+K74bvM9yqTAvuuzmVstLxNJqti+I80IpzQXPh51OwWZsaHmCtDQYbYLTOfyigOSBfp7jrCZDcDaYrBzH9w/IirS5IeNdiqHpMdJkgME4NJemUL/i9TpKbd09pK4WBj0vXCKPm3W3KEU3AxTBoDOTx2Vbo+Y6JSf3BpKbA4Om0UZynzZdRUlOvYykJsOQru0jmS+MP0uJjbuIxMXCEF/IB+XomHNITDQMf+aoyFNIZBQMLHOaMycpEeEnkPAIGE5rOJKt2WGHKcqQI0iIEoawbCvJzRnHD1GUoUeRUCUMxzKaSc5MSTxPSVBdQFQJMCSmZJIsJ+VrKfAjERjyk2T5J1HVVoo17z2HAAAAAElFTkSuQmCC");

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06006864 RID: 26724 RVA: 0x000425DD File Offset: 0x000407DD
		public static BitmapImage PositiveImage { get; } = Class2570.smethod_1("iVBORw0KGgoAAAANSUhEUgAAAIAAAACACAMAAAD04JH5AAAABGdBTUEAALGPC/xhBQAAAwBQTFRFAAAAV6UGVqsBV6oDV6sEVqsGVqwAV6wBV6wCV6wDV6wFVqwGWKsAWKoCWKoEWKwAWKwBWawCWawDWa4BWa4CWKwEWKwFWKwGWawHW64EWq4GXK8HWawIWqwJWq0LWq4IWq4KXK0KXK4IXK8JXK4KXK0MXa4NXa4OXa4QX7AMX7AOXrAPYKgVYLEPYLARYrESYrEVY7EWYrAXY7IWZbEXZrMXZLEaZbIYZbIaZbIcZ7MdZrQaZrQcZ7QfaLMcarMfaLQaaLQdaLQea7YfbqwvabQgarQiarYgarYharYia7Yja7cka7YlbLYjbLUkbLYkbrYnb7cob7cpbrgob7grcrcrcbgqcLgrcLgscbgtcrkuc7ouc7oydLkydLowdLoxdboydro0d7s2d7o3d7w3d7s4d7w5eLs2eLs3eLw3eLs4ebs6ebs8eLw4eLw5eLw6ebw7er08erw9er0+er48e74+fb0/fL49fL4+e71Afb5Bf75Cfr9EfsBCf8BFgL9Egb9Fi75XgMBDgcBFgsBGgsBHgsBIgsJJhMFKhcJKhsNMhsNNicNPh8RQicNSiMRQiMVRicRSicRTicRUi8RVi8ZXjMZVj8dXjcZYjsdZjsdajsdbj8hZkcZbkcddkchbkclekchfk8pdlMlfkchgk8phlcljlspilspklstmlsxlmMtlmMxnmcxrm85tns5wn890n9BzoNByoNB0otB2otF3otJ3o9F4o9J4o9J6pNF4pNF5pNJ5pNJ6pdJ7ptJ8ptN+qNR+qNOAqdSAqtSDq9aDq9SErNWGrNWHrdaGr9iMudyZudyau92cvN2cw9Sy1+vE3O3K3O7I3e7N3u7O3+/Q4O/P4O/Q4e/S4fDS4/DV4/HW5PHU5PHW5PLV5PLX5fHZ5fLY5/Pb6PTc7vbj7PXk7fbk7vbm7/fp8Pfm8Pbo8ffq8Pjo8fjq8vjs8/nu8/ru9Pnt9Pnu9Prx+fvz+vv2+vz1+fz2+vv4/P34/Pz6/P76/P38/f78/v7+AAAAZILJawAAAQB0Uk5T////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////AFP3ByUAAAAJcEhZcwAADsIAAA7CARUoSoAAAAAYdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjAuOWwzfk4AAAgySURBVHhevZt3nBXVGYZvJAobxfudI3fBVcGCrsZAYoxedLHsKrjYULESsQRNNMoCgnEFERvYSyI/ewFFEyuxRQ0IUQiBiElULGDFwkrZjTXExdnjmZn33jt95ky5zz87O+V73/OdMueemcmJmPx15tRhA3ekfJ62Gdg8YeZz2K1MDAOPjqvfnDEiRnmpr0OMccY2r295BKcooGjg2WN60FamqhdENUc9gVMjomLgjoE1XBY7GOI9dr8XF0QhsoH5+9QwaITC+N4v4LJQIhq4tlZWeljhK8hzf3QFLg0hkoELwjPvglGhBZcHEsHAr7hC2SvIa7ofjxABhBqYUYglD9h1CONLiIF52yVQ16G+8xHKh2ADp3HEiQ0RPwHBvAky8JfeiJIMVvsYAnoRYOBs2fMQIxFy0P4NQnrgb2Bn9a7nB7G+COrGz8DiPqnJS4j6PI3ATnwM3MYjj7sR4b9HaAfeBsalU/s2aDSC2/E08MvEvc8L7jkuehk4ybf4yfLCDoCAFQ8Dx6Vd/WXY0ZCw4DZwSmb6+XyvwyFSwWVgUob6sjuOh0wZp4FZWepL+I0QKuEwsCS94c8H9jykgMNAquOfJ9QbUsBu4OcZV4DBrhAzsRk4J4MB0A07C3IGVgOLCtXQl78crDcmq4ECzsicWgjqWAyMqkYDMOCnQ1JSMbAo8x5oYQFErQbqq6ifr4eoxcAdmdyC/eA3QbZioLaaCZAzZciWDVxeVX3ZF38L4ZKBqnVBQBzCMDCtal2wBPudqQwDtdhdRQqmsmnggQxaQFhIdrMhbRronb4BCqtU2taQNgz8I/0WwIb8PaRjE1tcNuA/D48LHbGqc1l//ONHU9lA2n2QCs0rtK5vl/UJHl17lAw8lXYN0PCPta4ubeOy/sGpnQUDe6RcA1wvv07ny3WBoYfAQE2qBogO+8iQlznQXvHJgZnzbqaBhenWAGtesREGumQ76IfddkxbJKcF0sBk45/UGPYBxA06/9U/oHynGgZ2xn/p0PRuJ7QNtM5ldTjiQY1hIM0aYMM/hDLQtNUjcMwD0g0sTbEJ0pBVEC6htY0NKqBu4Kr0DBSGv2/2vxKy/GfwoPjTpIGfpmWAWOMqu74sf4uj/I7fXoOlgU2xnRh2xMpQfaeBftJAd2wnhLi7/J+2OLLrSjaXBlLqBDQM42+F9l+HxmYi92LAQ7AyVLjncmx6Q/wQZ/m7Ph0b/luLFubmYDMQdveG/7YGRCNqcpZfax+9BY4GwO7KzcZmALTlg99oXR3T/FcPeLOr/lePCy2+hK7NXY1Nf6jnrG/1kB2Tfbo0UeNbdn1NaxsTqW3RsbmDsekLbfnQ/8zwHdO9K5Uf6qr/1WOjlF8GH5Q7CJt+ULf7NyBqV/sU5i4X8aY3cbyEtibyaveA3IHY8qPnwxsqt/cvrnQbYM0ffIfDQPukJfJaw065Irb8uO9rhDVov9j5IIEPcdX/2olR5fP5uhADW1z6f1t47fMr7CtZNPSdSoIMtE/GRNeXBhqw5c0P/u1sXusus+aANb3l1P/sfAV9WQUhjfAnrzkcaF9NLTsgal6J3SVC7v8uBuROxZYfDW8gdJl1U0rjAdvfNf6tnai21tUQOhBR8VVnLXw52eiNxJvfxh4gx58WtcVWOil8KGbFFYhfQh8T5QEqrnT2vzXjVZe6rolwM+INrzoaWlfHJE7Mo/9FGv+t0K25haG3Y+JF162+46JCw3vO+lcvf569FGlCwga72sEXt77p1G8/r5dqAuS8XBoIv4pY0ZFuPeHYKNEWQ9+YkkWZlFKhaTl0fJDlV5fPkz4pjTQtJ/aL5Y4mb0NrmxBDP0+N0sBVkUYu4vsF5EDrmBhrqZmmSwNLI17Kiq87qx3I8ecCpfG3DJsjDUSelzO/dqC1K46/Zcxfx/X4LxTunYONbXHan0HBMDA16vBNMgduB9ra1nj5l5xsGFikcH3xdchWWDMxtj79zTCgtEjV+IY9B9r6KTHrX+9ZWCXbAzsiYc+BJssfV19O52Dgz0o53P/tcg60jesmxZaX3Wo2DIhu2BONQeXeKO9/avMPOz11bcPAidgTDdoXMxStPUn58/n9ygYUl+vZvsZ4oK2P3/8MjKeXhgHV1wbYPjIH2voL47c/ne0MadPAbMWiUOPy7zpak+nbHtmoP7Qq/uf8wPW3cPDcDgamK99Nkz5ppVZTGQZErNt5ApwPLsUlCQukCp0J4ZKBKrw/Y8X98FrMSNanFSmU3y4sGxC74lhV2AWiVgNLk3VrJfRnNaBiQIzqhcOZw0ZCUmIxILatUgrw1NjEauCf1RkM/F9kEmqrKzEh/1e5qvIyG1HAy2yyGeC07KA6SAGHgYWZt0P2LKSAw4CYnXFDZDdAqITTgBifaQ7oXMiUcRkQp2XYEPlREKngNiCGZ+WAmFvfy4AYmZEDdiQErHgZECOzeLGL+DEIb8PTgJiU8DV2D4jGIbgdbwPizoRTXjeFPyC0Ax8DYkm/dKcHdXMR2ImfATlDSi8JxOzjvxV/A2JMWg6Y9S1aJwEGxNx0PnSiPo8joBdBBoQ4PYVvnQojEMybYANiwQ4JDdD2TyKUDyEGhLglyY9A6n09wvgSakCIs2O+6kXET0GIACIYEOK8TRBTBapN65NPnatrlV79l+f+cCouDSGiASHmDY4+VyI26BlcFkpkA5Lb9qwN/QaOGC/87G5cEAUVA5JnRvTwHhnMnVuxmqFzcGpEFA3o/Kl1r+0Z6R9Cl6zIv8R53z1b/4hTFIhhwOTpmROafrw1dd+Mtt6tafTtft8zhiDE963c4Wu7kDZMAAAAAElFTkSuQmCC");

		// Token: 0x06006865 RID: 26725 RVA: 0x000425E4 File Offset: 0x000407E4
		[CompilerGenerated]
		private void method_1(object a0)
		{
			this.method_0();
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06006866 RID: 26726 RVA: 0x00389C24 File Offset: 0x00387E24
		// (remove) Token: 0x06006867 RID: 26727 RVA: 0x00389C5C File Offset: 0x00387E5C
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x00389C94 File Offset: 0x00387E94
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003B57 RID: 15191
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04003B58 RID: 15192
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04003B59 RID: 15193
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04003B5A RID: 15194
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04003B5B RID: 15195
		[CompilerGenerated]
		private Class2556.Enum209 enum209_0;

		// Token: 0x04003B5C RID: 15196
		[CompilerGenerated]
		private Class2569 class2569_0;

		// Token: 0x04003B5D RID: 15197
		[CompilerGenerated]
		private static BitmapImage bitmapImage_0;

		// Token: 0x04003B5E RID: 15198
		[CompilerGenerated]
		private static BitmapImage bitmapImage_1;

		// Token: 0x04003B5F RID: 15199
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
