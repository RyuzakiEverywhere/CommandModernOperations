using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;
using ns5;
using ns7;
using Steamworks;

namespace ns6
{
	// Token: 0x02000E85 RID: 3717
	[StandardModule]
	internal sealed class Class2486
	{
		// Token: 0x060072AD RID: 29357 RVA: 0x003D8298 File Offset: 0x003D6498
		public static void smethod_0(Class2486.Class2488 class2488_1, SteamUGCDetails_t steamUGCDetails_t_0)
		{
			if (!Class2474.bool_0)
			{
				throw new Exception31();
			}
			Class2413.smethod_2().method_69().Enabled = false;
			Class2486.class2488_0 = class2488_1;
			if (Class2486.class2488_0.string_0.Length > 120)
			{
				Class2486.class2488_0.string_0 = Class2486.class2488_0.string_0.Substring(0, 100);
			}
			if (Class2486.class2488_0.string_1.Length > 7500)
			{
				Class2486.class2488_0.string_1 = Class2486.class2488_0.string_1.Substring(0, 7500);
			}
			Class2486.class2488_0.list_0 = new List<string>();
			Class2486.class2488_0.list_0.Add("Scenario");
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_0))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_1))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_2))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_3))
			{
				throw new ArgumentNullException();
			}
			Class2486.class2488_0.string_4 = Path.Combine(new string[]
			{
				Path.GetTempPath() + Class2486.class2488_0.string_2
			});
			Directory.CreateDirectory(Class2486.class2488_0.string_4);
			Directory.CreateDirectory(Path.Combine(Class2486.class2488_0.string_4, "attachments"));
			Client.smethod_75(false, Path.Combine(Class2486.class2488_0.string_4, Class2486.class2488_0.string_2 + ".scen"), false);
			Class2486.class2488_0.string_3 = Path.GetFullPath(Class2486.class2488_0.string_3);
			try
			{
				foreach (KeyValuePair<string, ScenAttachmentObject> keyValuePair in Client.smethod_46().vmethod_2())
				{
					if (Directory.Exists(Path.Combine(GameGeneral.string_6, keyValuePair.Key)))
					{
						Misc.smethod_1(Path.Combine(GameGeneral.string_6, keyValuePair.Key), Path.Combine(Class2486.class2488_0.string_4, "attachments", keyValuePair.Key), true);
					}
				}
			}
			finally
			{
				IEnumerator<KeyValuePair<string, ScenAttachmentObject>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(Class2556.appId_t_0, steamUGCDetails_t_0.m_nPublishedFileId);
			SteamUGC.SetItemTitle(ugcupdateHandle_t, Class2486.class2488_0.string_0);
			SteamUGC.SetItemDescription(ugcupdateHandle_t, Class2486.class2488_0.string_1);
			SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
			SteamUGC.SetItemTags(ugcupdateHandle_t, Class2486.class2488_0.list_0);
			SteamUGC.SetItemContent(ugcupdateHandle_t, Class2486.class2488_0.string_4);
			SteamUGC.SetItemPreview(ugcupdateHandle_t, Class2486.class2488_0.string_3);
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, "Update");
			Class2486.callResult_1.Set(hAPICall, null);
		}

		// Token: 0x060072AE RID: 29358 RVA: 0x003D8550 File Offset: 0x003D6750
		public static void smethod_1(Class2486.Class2488 class2488_1)
		{
			if (!Class2474.bool_0)
			{
				throw new Exception31();
			}
			Class2413.smethod_2().method_68().Enabled = false;
			Class2486.class2488_0 = class2488_1;
			if (Class2486.class2488_0.string_0.Length > 120)
			{
				Class2486.class2488_0.string_0 = Enumerable.Take<char>(Class2486.class2488_0.string_0, 127).ToString();
			}
			if (Class2486.class2488_0.string_1.Length > 7500)
			{
				Class2486.class2488_0.string_1 = Enumerable.Take<char>(Class2486.class2488_0.string_1, 7999).ToString();
			}
			Class2486.class2488_0.list_0 = new List<string>();
			Class2486.class2488_0.list_0.Add("Scenario");
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_0))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_1))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_2))
			{
				throw new ArgumentNullException();
			}
			if (string.IsNullOrEmpty(Class2486.class2488_0.string_3))
			{
				throw new ArgumentNullException();
			}
			Class2486.class2488_0.string_4 = Path.Combine(new string[]
			{
				Path.GetTempPath() + Class2486.class2488_0.string_2
			});
			Directory.CreateDirectory(Class2486.class2488_0.string_4);
			Directory.CreateDirectory(Path.Combine(Class2486.class2488_0.string_4, "attachments"));
			Client.smethod_75(false, Path.Combine(Class2486.class2488_0.string_4, Class2486.class2488_0.string_2 + ".scen"), false);
			Class2486.class2488_0.string_3 = Path.GetFullPath(Class2486.class2488_0.string_3);
			try
			{
				foreach (KeyValuePair<string, ScenAttachmentObject> keyValuePair in Client.smethod_46().vmethod_2())
				{
					if (Directory.Exists(Path.Combine(GameGeneral.string_6, keyValuePair.Key)))
					{
						Misc.smethod_1(Path.Combine(GameGeneral.string_6, keyValuePair.Key), Path.Combine(Class2486.class2488_0.string_4, "attachments", keyValuePair.Key), true);
					}
				}
			}
			finally
			{
				IEnumerator<KeyValuePair<string, ScenAttachmentObject>> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			SteamAPICall_t hAPICall = SteamUGC.CreateItem(Class2556.appId_t_0, EWorkshopFileType.k_EWorkshopFileTypeFirst);
			Class2486.callResult_0.Set(hAPICall, null);
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x003D87A4 File Offset: 0x003D69A4
		public static void smethod_2()
		{
			if (Class2474.bool_0)
			{
				Class2486.callResult_0 = new CallResult<CreateItemResult_t>(new CallResult<CreateItemResult_t>.APIDispatchDelegate(Class2486.smethod_11));
				Class2486.callResult_1 = new CallResult<SubmitItemUpdateResult_t>(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(Class2486.smethod_10));
				Class2486.callResult_2 = new CallResult<RemoteStoragePublishedFileSubscribed_t>(new CallResult<RemoteStoragePublishedFileSubscribed_t>.APIDispatchDelegate(Class2486.smethod_12));
				Class2486.callResult_3 = new CallResult<RemoteStoragePublishedFileUnsubscribed_t>(new CallResult<RemoteStoragePublishedFileUnsubscribed_t>.APIDispatchDelegate(Class2486.smethod_13));
				Class2486.callResult_4 = new CallResult<ItemInstalled_t>(new CallResult<ItemInstalled_t>.APIDispatchDelegate(Class2486.smethod_14));
				Class2486.callResult_5 = new CallResult<DownloadItemResult_t>(new CallResult<DownloadItemResult_t>.APIDispatchDelegate(Class2486.smethod_9));
				Class2486.callResult_6 = new CallResult<SteamUGCQueryCompleted_t>(new CallResult<SteamUGCQueryCompleted_t>.APIDispatchDelegate(Class2486.smethod_8));
				Class2486.smethod_3();
				Class2486.smethod_7();
			}
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x003D8860 File Offset: 0x003D6A60
		public static void smethod_3()
		{
			if (!Class2486.bool_0)
			{
				object obj = Class2486.object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					Class2486.bool_0 = true;
					if (Class2474.bool_0)
					{
						uint numSubscribedItems = SteamUGC.GetNumSubscribedItems();
						PublishedFileId_t[] array = new PublishedFileId_t[numSubscribedItems + 1U];
						SteamUGC.GetSubscribedItems(array, numSubscribedItems);
						Class2486.list_0 = Enumerable.ToList<PublishedFileId_t>(array);
						List<Class2486.Class2487> list = new List<Class2486.Class2487>();
						try
						{
							foreach (PublishedFileId_t publishedFileId_t_ in Class2486.list_0)
							{
								list.Add(new Class2486.Class2487(publishedFileId_t_));
							}
						}
						finally
						{
							List<PublishedFileId_t>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						Class2486.list_1 = list;
						Class2486.smethod_7();
						Class2486.bool_0 = false;
					}
				}
			}
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x003D893C File Offset: 0x003D6B3C
		private static void smethod_4(PublishedFileId_t publishedFileId_t_0)
		{
			Class2486.Class2487 @class = new Class2486.Class2487(publishedFileId_t_0);
			if (@class.method_13())
			{
				@class.method_22();
			}
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x00047C12 File Offset: 0x00045E12
		public static void smethod_5()
		{
			if (Class2474.bool_0)
			{
				SteamAPI.RunCallbacks();
			}
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x00047C20 File Offset: 0x00045E20
		private static void smethod_6(object object_1, bool bool_1)
		{
			if (!Class2474.bool_0)
			{
				throw new Exception31();
			}
			if (bool_1)
			{
				throw new Exception30("IO Failure");
			}
			if (object_1 == null)
			{
				throw new Exception30("Null callback object");
			}
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x003D8960 File Offset: 0x003D6B60
		public static void smethod_7()
		{
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Published, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_TitleAsc, Class2556.appId_t_0, Class2556.appId_t_0, 1U));
			Class2486.callResult_6.Set(hAPICall, null);
			Class2486.list_2 = new List<SteamUGCDetails_t>();
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x003D89AC File Offset: 0x003D6BAC
		private static void smethod_8(SteamUGCQueryCompleted_t steamUGCQueryCompleted_t_0, bool bool_1)
		{
			Class2486.smethod_6(steamUGCQueryCompleted_t_0, bool_1);
			uint unNumResultsReturned = steamUGCQueryCompleted_t_0.m_unNumResultsReturned;
			for (uint num = 0U; num <= unNumResultsReturned; num += 1U)
			{
				Class2486.Class2489 @class = new Class2486.Class2489(@class);
				@class.steamUGCDetails_t_0 = default(SteamUGCDetails_t);
				SteamUGC.GetQueryUGCResult(steamUGCQueryCompleted_t_0.m_handle, num, out @class.steamUGCDetails_t_0);
				if (!Enumerable.Any<SteamUGCDetails_t>(Class2486.list_2, new Func<SteamUGCDetails_t, bool>(@class.method_0)))
				{
					Class2486.list_2.Add(@class.steamUGCDetails_t_0);
				}
			}
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x00047C4B File Offset: 0x00045E4B
		private static void smethod_9(DownloadItemResult_t downloadItemResult_t_1, bool bool_1)
		{
			Class2486.smethod_6(downloadItemResult_t_1, bool_1);
			if (downloadItemResult_t_1.m_unAppID.m_AppId == Class2556.appId_t_0.m_AppId)
			{
				Class2486.downloadItemResult_t_0 = downloadItemResult_t_1;
				Class2486.smethod_4(downloadItemResult_t_1.m_nPublishedFileId);
			}
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x003D8A28 File Offset: 0x003D6C28
		private static void smethod_10(SubmitItemUpdateResult_t submitItemUpdateResult_t_1, bool bool_1)
		{
			Class2486.smethod_6(submitItemUpdateResult_t_1, bool_1);
			Class2486.submitItemUpdateResult_t_0 = submitItemUpdateResult_t_1;
			if (Class2486.submitItemUpdateResult_t_0.m_eResult == EResult.k_EResultOK)
			{
				DarkMessageBox.smethod_0("The scenario has been successfully uploaded to Steam!", "Success", Enum11.const_0);
				Class2413.smethod_2().method_68().Enabled = true;
				Class2413.smethod_2().method_68().Close();
			}
			else
			{
				DarkMessageBox.smethod_2("There was a problem in uploading the scenario to Steam. The error code was: " + Class2486.submitItemUpdateResult_t_0.m_eResult.ToString(), "Error", Enum11.const_0);
			}
			if (Class2486.submitItemUpdateResult_t_0.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
				Process.Start("http: //steamcommunity.com/sharedfiles/workshoplegalagreement");
				DarkMessageBox.smethod_0("Please accept Steam Workshop Legal Agreement.", "", Enum11.const_0);
			}
			if (!Information.IsNothing(Class2413.smethod_2().method_68()))
			{
				Class2413.smethod_2().method_68().Enabled = true;
				Class2413.smethod_2().method_68().Close();
			}
			if (!Information.IsNothing(Class2413.smethod_2().method_69()))
			{
				Class2413.smethod_2().method_69().Enabled = true;
				Class2413.smethod_2().method_69().Close();
			}
			if (Directory.Exists(Class2486.class2488_0.string_4))
			{
				try
				{
					Directory.Delete(Class2486.class2488_0.string_4, true);
				}
				catch (Exception ex)
				{
					ex.Data.Add("Error at 200423", ex.Message);
					GameGeneral.smethod_25(ref ex);
					if (Debugger.IsAttached)
					{
						Debugger.Break();
					}
				}
			}
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x003D8BA4 File Offset: 0x003D6DA4
		private static void smethod_11(CreateItemResult_t createItemResult_t_1, bool bool_1)
		{
			Class2486.smethod_6(createItemResult_t_1, bool_1);
			Class2486.createItemResult_t_0 = createItemResult_t_1;
			if (Class2486.createItemResult_t_0.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
				Process.Start("http://steamcommunity.com/sharedfiles/workshoplegalagreement");
				DarkMessageBox.smethod_0("Please accept Steam Workshop Legal Agreement.", "", Enum11.const_0);
			}
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(Class2556.appId_t_0, Class2486.createItemResult_t_0.m_nPublishedFileId);
			SteamUGC.SetItemTitle(ugcupdateHandle_t, Class2486.class2488_0.string_0);
			SteamUGC.SetItemDescription(ugcupdateHandle_t, Class2486.class2488_0.string_1);
			SteamUGC.SetItemVisibility(ugcupdateHandle_t, ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPublic);
			SteamUGC.SetItemTags(ugcupdateHandle_t, Class2486.class2488_0.list_0);
			SteamUGC.SetItemContent(ugcupdateHandle_t, Class2486.class2488_0.string_4);
			SteamUGC.SetItemPreview(ugcupdateHandle_t, Class2486.class2488_0.string_3);
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(ugcupdateHandle_t, "Initial Upload");
			Class2486.callResult_1.Set(hAPICall, null);
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x00047C81 File Offset: 0x00045E81
		private static void smethod_12(RemoteStoragePublishedFileSubscribed_t remoteStoragePublishedFileSubscribed_t_1, bool bool_1)
		{
			Class2486.smethod_6(remoteStoragePublishedFileSubscribed_t_1, bool_1);
			Class2486.remoteStoragePublishedFileSubscribed_t_0 = remoteStoragePublishedFileSubscribed_t_1;
			Class2486.smethod_4(remoteStoragePublishedFileSubscribed_t_1.m_nPublishedFileId);
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x00047CA0 File Offset: 0x00045EA0
		private static void smethod_13(RemoteStoragePublishedFileUnsubscribed_t remoteStoragePublishedFileUnsubscribed_t_1, bool bool_1)
		{
			Class2486.smethod_6(remoteStoragePublishedFileUnsubscribed_t_1, bool_1);
			Class2486.remoteStoragePublishedFileUnsubscribed_t_0 = remoteStoragePublishedFileUnsubscribed_t_1;
			Class2486.smethod_4(remoteStoragePublishedFileUnsubscribed_t_1.m_nPublishedFileId);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x00047CBF File Offset: 0x00045EBF
		private static void smethod_14(ItemInstalled_t itemInstalled_t_1, bool bool_1)
		{
			Class2486.smethod_6(itemInstalled_t_1, bool_1);
			if (itemInstalled_t_1.m_unAppID.m_AppId == Class2556.appId_t_0.m_AppId)
			{
				Class2486.itemInstalled_t_0 = itemInstalled_t_1;
				Class2486.smethod_4(itemInstalled_t_1.m_nPublishedFileId);
			}
		}

		// Token: 0x04004096 RID: 16534
		public static Class2486.Class2488 class2488_0;

		// Token: 0x04004097 RID: 16535
		private static List<PublishedFileId_t> list_0;

		// Token: 0x04004098 RID: 16536
		public static List<Class2486.Class2487> list_1 = new List<Class2486.Class2487>();

		// Token: 0x04004099 RID: 16537
		private static CallResult<CreateItemResult_t> callResult_0;

		// Token: 0x0400409A RID: 16538
		private static CreateItemResult_t createItemResult_t_0;

		// Token: 0x0400409B RID: 16539
		private static CallResult<SubmitItemUpdateResult_t> callResult_1;

		// Token: 0x0400409C RID: 16540
		private static SubmitItemUpdateResult_t submitItemUpdateResult_t_0;

		// Token: 0x0400409D RID: 16541
		private static CallResult<RemoteStoragePublishedFileSubscribed_t> callResult_2;

		// Token: 0x0400409E RID: 16542
		private static RemoteStoragePublishedFileSubscribed_t remoteStoragePublishedFileSubscribed_t_0;

		// Token: 0x0400409F RID: 16543
		private static CallResult<RemoteStoragePublishedFileUnsubscribed_t> callResult_3;

		// Token: 0x040040A0 RID: 16544
		private static RemoteStoragePublishedFileUnsubscribed_t remoteStoragePublishedFileUnsubscribed_t_0;

		// Token: 0x040040A1 RID: 16545
		private static CallResult<ItemInstalled_t> callResult_4;

		// Token: 0x040040A2 RID: 16546
		private static ItemInstalled_t itemInstalled_t_0;

		// Token: 0x040040A3 RID: 16547
		private static CallResult<DownloadItemResult_t> callResult_5;

		// Token: 0x040040A4 RID: 16548
		private static DownloadItemResult_t downloadItemResult_t_0;

		// Token: 0x040040A5 RID: 16549
		private static CallResult<SteamUGCQueryCompleted_t> callResult_6;

		// Token: 0x040040A6 RID: 16550
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x040040A7 RID: 16551
		private static bool bool_0 = false;

		// Token: 0x040040A8 RID: 16552
		public static List<SteamUGCDetails_t> list_2 = new List<SteamUGCDetails_t>();

		// Token: 0x02000E86 RID: 3718
		internal sealed class Class2487
		{
			// Token: 0x060072BC RID: 29372 RVA: 0x00047CF5 File Offset: 0x00045EF5
			[CompilerGenerated]
			public void method_0(bool bool_8)
			{
				this.bool_0 = bool_8;
			}

			// Token: 0x060072BD RID: 29373 RVA: 0x00047CFE File Offset: 0x00045EFE
			[CompilerGenerated]
			public bool method_1()
			{
				return this.bool_1;
			}

			// Token: 0x060072BE RID: 29374 RVA: 0x00047D06 File Offset: 0x00045F06
			[CompilerGenerated]
			public void method_2(bool bool_8)
			{
				this.bool_1 = bool_8;
			}

			// Token: 0x060072BF RID: 29375 RVA: 0x00047D0F File Offset: 0x00045F0F
			[CompilerGenerated]
			public bool method_3()
			{
				return this.bool_2;
			}

			// Token: 0x060072C0 RID: 29376 RVA: 0x00047D17 File Offset: 0x00045F17
			[CompilerGenerated]
			public void method_4(bool bool_8)
			{
				this.bool_2 = bool_8;
			}

			// Token: 0x060072C1 RID: 29377 RVA: 0x00047D20 File Offset: 0x00045F20
			[CompilerGenerated]
			public void method_5(bool bool_8)
			{
				this.bool_3 = bool_8;
			}

			// Token: 0x060072C2 RID: 29378 RVA: 0x00047D29 File Offset: 0x00045F29
			[CompilerGenerated]
			public void method_6(bool bool_8)
			{
				this.bool_4 = bool_8;
			}

			// Token: 0x060072C3 RID: 29379 RVA: 0x00047D32 File Offset: 0x00045F32
			[CompilerGenerated]
			public void method_7(PublishedFileId_t publishedFileId_t_1)
			{
				this.publishedFileId_t_0 = publishedFileId_t_1;
			}

			// Token: 0x060072C4 RID: 29380 RVA: 0x00047D3B File Offset: 0x00045F3B
			[CompilerGenerated]
			public void method_8(bool bool_8)
			{
				this.bool_5 = bool_8;
			}

			// Token: 0x060072C5 RID: 29381 RVA: 0x00047D44 File Offset: 0x00045F44
			[CompilerGenerated]
			public ulong method_9()
			{
				return this.ulong_0;
			}

			// Token: 0x060072C6 RID: 29382 RVA: 0x00047D4C File Offset: 0x00045F4C
			[CompilerGenerated]
			public void method_10(ulong ulong_3)
			{
				this.ulong_0 = ulong_3;
			}

			// Token: 0x060072C7 RID: 29383 RVA: 0x00047D55 File Offset: 0x00045F55
			[CompilerGenerated]
			public ulong method_11()
			{
				return this.ulong_1;
			}

			// Token: 0x060072C8 RID: 29384 RVA: 0x00047D5D File Offset: 0x00045F5D
			[CompilerGenerated]
			public void method_12(ulong ulong_3)
			{
				this.ulong_1 = ulong_3;
			}

			// Token: 0x060072C9 RID: 29385 RVA: 0x00047D66 File Offset: 0x00045F66
			[CompilerGenerated]
			public bool method_13()
			{
				return this.bool_6;
			}

			// Token: 0x060072CA RID: 29386 RVA: 0x00047D6E File Offset: 0x00045F6E
			[CompilerGenerated]
			public void method_14(bool bool_8)
			{
				this.bool_6 = bool_8;
			}

			// Token: 0x060072CB RID: 29387 RVA: 0x00047D77 File Offset: 0x00045F77
			[CompilerGenerated]
			public ulong method_15()
			{
				return this.ulong_2;
			}

			// Token: 0x060072CC RID: 29388 RVA: 0x00047D7F File Offset: 0x00045F7F
			[CompilerGenerated]
			public void method_16(ulong ulong_3)
			{
				this.ulong_2 = ulong_3;
			}

			// Token: 0x060072CD RID: 29389 RVA: 0x00047D88 File Offset: 0x00045F88
			[CompilerGenerated]
			public string method_17()
			{
				return this.string_0;
			}

			// Token: 0x060072CE RID: 29390 RVA: 0x00047D90 File Offset: 0x00045F90
			[CompilerGenerated]
			public void method_18(string string_1)
			{
				this.string_0 = string_1;
			}

			// Token: 0x060072CF RID: 29391 RVA: 0x00047D99 File Offset: 0x00045F99
			[CompilerGenerated]
			public uint method_19()
			{
				return this.uint_0;
			}

			// Token: 0x060072D0 RID: 29392 RVA: 0x00047DA1 File Offset: 0x00045FA1
			[CompilerGenerated]
			public void method_20(uint uint_1)
			{
				this.uint_0 = uint_1;
			}

			// Token: 0x060072D1 RID: 29393 RVA: 0x00047DAA File Offset: 0x00045FAA
			[CompilerGenerated]
			public void method_21(bool bool_8)
			{
				this.bool_7 = bool_8;
			}

			// Token: 0x060072D2 RID: 29394 RVA: 0x003D8C74 File Offset: 0x003D6E74
			public Class2487(PublishedFileId_t publishedFileId_t_1)
			{
				this.method_7(publishedFileId_t_1);
				uint itemState = SteamUGC.GetItemState(publishedFileId_t_1);
				this.method_0(((ulong)itemState & 1UL) > 0UL);
				this.method_2(((ulong)itemState & 4UL) > 0UL);
				this.method_4(((ulong)itemState & 8UL) > 0UL);
				this.method_5(((ulong)itemState & 16UL) > 0UL);
				this.method_6(((ulong)itemState & 32UL) > 0UL);
				ulong ulong_ = this.method_9();
				ulong ulong_2 = this.method_11();
				bool itemDownloadInfo = SteamUGC.GetItemDownloadInfo(publishedFileId_t_1, out ulong_, out ulong_2);
				this.method_12(ulong_2);
				this.method_10(ulong_);
				this.method_8(itemDownloadInfo);
				this.method_14(true);
				if ((this.method_3() | !this.method_1()) && SteamUGC.DownloadItem(publishedFileId_t_1, false))
				{
					this.method_14(false);
				}
				if (this.method_13())
				{
					ulong_2 = this.method_15();
					string string_ = this.method_17();
					uint cchFolderSize = 1024U;
					uint uint_ = this.method_19();
					bool itemInstallInfo = SteamUGC.GetItemInstallInfo(publishedFileId_t_1, out ulong_2, out string_, cchFolderSize, out uint_);
					this.method_20(uint_);
					this.method_18(string_);
					this.method_16(ulong_2);
					this.method_21(itemInstallInfo);
				}
			}

			// Token: 0x060072D3 RID: 29395 RVA: 0x003D8DC8 File Offset: 0x003D6FC8
			public void method_22()
			{
				if (this.method_1())
				{
					try
					{
						if (Directory.Exists(this.method_17()))
						{
							this.method_23(this.method_17(), Client.string_4, true);
						}
					}
					catch (Exception ex)
					{
					}
				}
			}

			// Token: 0x060072D4 RID: 29396 RVA: 0x003D8E1C File Offset: 0x003D701C
			public void method_23(string string_1, string string_2, bool bool_8)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				if (!directoryInfo.Exists)
				{
					throw new DirectoryNotFoundException(Convert.ToString("Source directory does not exist or could not be found: ") + string_1);
				}
				if (!Directory.Exists(string_2))
				{
					Directory.CreateDirectory(string_2);
				}
				FileInfo[] files = directoryInfo.GetFiles();
				int i = 0;
				checked
				{
					while (i < files.Length)
					{
						FileInfo fileInfo = files[i];
						string text = Path.Combine(string_2, fileInfo.Name);
						if (!File.Exists(text))
						{
							goto IL_B5;
						}
						FileInfo fileInfo2 = Class2413.smethod_0().FileSystem.GetFileInfo(text);
						FileInfo fileInfo3 = Class2413.smethod_0().FileSystem.GetFileInfo(fileInfo.FullName);
						if (!(DateTime.Compare(fileInfo2.LastWriteTimeUtc, fileInfo3.LastWriteTimeUtc) == 0 & fileInfo2.Length == fileInfo3.Length))
						{
							goto IL_B5;
						}
						IL_C6:
						i++;
						continue;
						IL_B5:
						fileInfo.CopyTo(text, true);
						Thread.Sleep(100);
						goto IL_C6;
					}
					if (bool_8)
					{
						foreach (DirectoryInfo directoryInfo2 in directories)
						{
							string string_3 = Path.Combine(string_2, directoryInfo2.Name);
							this.method_23(directoryInfo2.FullName, string_3, bool_8);
						}
					}
				}
			}

			// Token: 0x040040A9 RID: 16553
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x040040AA RID: 16554
			[CompilerGenerated]
			private bool bool_1;

			// Token: 0x040040AB RID: 16555
			[CompilerGenerated]
			private bool bool_2;

			// Token: 0x040040AC RID: 16556
			[CompilerGenerated]
			private bool bool_3;

			// Token: 0x040040AD RID: 16557
			[CompilerGenerated]
			private bool bool_4;

			// Token: 0x040040AE RID: 16558
			[CompilerGenerated]
			private PublishedFileId_t publishedFileId_t_0;

			// Token: 0x040040AF RID: 16559
			[CompilerGenerated]
			private bool bool_5;

			// Token: 0x040040B0 RID: 16560
			[CompilerGenerated]
			private ulong ulong_0;

			// Token: 0x040040B1 RID: 16561
			[CompilerGenerated]
			private ulong ulong_1;

			// Token: 0x040040B2 RID: 16562
			[CompilerGenerated]
			private bool bool_6;

			// Token: 0x040040B3 RID: 16563
			[CompilerGenerated]
			private ulong ulong_2;

			// Token: 0x040040B4 RID: 16564
			[CompilerGenerated]
			private string string_0;

			// Token: 0x040040B5 RID: 16565
			[CompilerGenerated]
			private uint uint_0;

			// Token: 0x040040B6 RID: 16566
			[CompilerGenerated]
			private bool bool_7;
		}

		// Token: 0x02000E87 RID: 3719
		internal sealed class Class2488
		{
			// Token: 0x040040B7 RID: 16567
			public string string_0;

			// Token: 0x040040B8 RID: 16568
			public string string_1;

			// Token: 0x040040B9 RID: 16569
			public List<string> list_0;

			// Token: 0x040040BA RID: 16570
			public string string_2;

			// Token: 0x040040BB RID: 16571
			public string string_3;

			// Token: 0x040040BC RID: 16572
			public string string_4;
		}

		// Token: 0x02000E88 RID: 3720
		[CompilerGenerated]
		internal sealed class Class2489
		{
			// Token: 0x060072D6 RID: 29398 RVA: 0x00047DB3 File Offset: 0x00045FB3
			public Class2489(Class2486.Class2489 class2489_0)
			{
				if (class2489_0 != null)
				{
					this.steamUGCDetails_t_0 = class2489_0.steamUGCDetails_t_0;
				}
			}

			// Token: 0x060072D7 RID: 29399 RVA: 0x00047DCA File Offset: 0x00045FCA
			internal bool method_0(SteamUGCDetails_t steamUGCDetails_t_1)
			{
				return steamUGCDetails_t_1.m_nPublishedFileId.m_PublishedFileId == this.steamUGCDetails_t_0.m_nPublishedFileId.m_PublishedFileId;
			}

			// Token: 0x040040BD RID: 16573
			public SteamUGCDetails_t steamUGCDetails_t_0;
		}
	}
}
