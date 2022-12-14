using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Data;
using Command_Core;
using ns14;

namespace Command
{
	// Token: 0x02000D8F RID: 3471
	[Attribute3]
	[Attribute0]
	[Attribute2]
	public sealed class DoctrineViewModel : INotifyPropertyChanged
	{
		// Token: 0x06005CDD RID: 23773 RVA: 0x0032E580 File Offset: 0x0032C780
		public DoctrineViewModel(ActiveUnit theUnit, List<SpecificDoctrineViewModel> SpecificDoctrineCache)
		{
			this.activeUnit_0 = theUnit;
			this.SpecificDoctrines = new ObservableCollection<SpecificDoctrineViewModel>(SpecificDoctrineCache);
			this.GroupedCollection = (ListCollectionView)CollectionViewSource.GetDefaultView(this.SpecificDoctrines);
			this.GroupedCollection.GroupDescriptions.Add(new PropertyGroupDescription("DoctrineGroup"));
			this.Refresh();
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x0032E5DC File Offset: 0x0032C7DC
		[Attribute0]
		[Attribute2]
		public void Refresh()
		{
			try
			{
				foreach (SpecificDoctrineViewModel specificDoctrineViewModel in this.SpecificDoctrines)
				{
					specificDoctrineViewModel.activeUnit_0 = this.activeUnit_0;
					specificDoctrineViewModel.Refresh();
				}
			}
			finally
			{
				IEnumerator<SpecificDoctrineViewModel> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06005CDF RID: 23775 RVA: 0x0003BA76 File Offset: 0x00039C76
		// (set) Token: 0x06005CE0 RID: 23776 RVA: 0x0003BA7E File Offset: 0x00039C7E
		public ObservableCollection<SpecificDoctrineViewModel> SpecificDoctrines
		{
			[CompilerGenerated]
			get
			{
				return this.observableCollection_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.observableCollection_0 == value)
				{
					return;
				}
				this.observableCollection_0 = value;
				this.vmethod_0("SpecificDoctrines");
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x0003BA9E File Offset: 0x00039C9E
		// (set) Token: 0x06005CE2 RID: 23778 RVA: 0x0003BAA6 File Offset: 0x00039CA6
		public ListCollectionView GroupedCollection
		{
			[CompilerGenerated]
			get
			{
				return this.listCollectionView_0;
			}
			[CompilerGenerated]
			set
			{
				if (this.listCollectionView_0 == value)
				{
					return;
				}
				this.listCollectionView_0 = value;
				this.vmethod_0("GroupedCollection");
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06005CE3 RID: 23779 RVA: 0x0032E634 File Offset: 0x0032C834
		// (remove) Token: 0x06005CE4 RID: 23780 RVA: 0x0032E66C File Offset: 0x0032C86C
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

		// Token: 0x06005CE5 RID: 23781 RVA: 0x0032E6A4 File Offset: 0x0032C8A4
		public void vmethod_0(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04003618 RID: 13848
		public ActiveUnit activeUnit_0;

		// Token: 0x04003619 RID: 13849
		[CompilerGenerated]
		private ObservableCollection<SpecificDoctrineViewModel> observableCollection_0;

		// Token: 0x0400361A RID: 13850
		[CompilerGenerated]
		private ListCollectionView listCollectionView_0;

		// Token: 0x0400361B RID: 13851
		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
