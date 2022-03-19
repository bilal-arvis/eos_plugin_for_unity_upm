// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.QueryOwnershipToken" /> function.
	/// </summary>
	public class QueryOwnershipTokenOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user whose ownership token you want to query
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The array of Catalog Item IDs to check for ownership, matching in number to the CatalogItemIdCount
		/// </summary>
		public string[] CatalogItemIds { get; set; }

		/// <summary>
		/// Optional product namespace, if not the one specified during initialization
		/// </summary>
		public string CatalogNamespace { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryOwnershipTokenOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_CatalogItemIds;
		private uint m_CatalogItemIdCount;
		private System.IntPtr m_CatalogNamespace;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string[] CatalogItemIds
		{
			set
			{
				Helper.TryMarshalSet(ref m_CatalogItemIds, value, out m_CatalogItemIdCount);
			}
		}

		public string CatalogNamespace
		{
			set
			{
				Helper.TryMarshalSet(ref m_CatalogNamespace, value);
			}
		}

		public void Set(QueryOwnershipTokenOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.QueryownershiptokenApiLatest;
				LocalUserId = other.LocalUserId;
				CatalogItemIds = other.CatalogItemIds;
				CatalogNamespace = other.CatalogNamespace;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryOwnershipTokenOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_CatalogItemIds);
			Helper.TryMarshalDispose(ref m_CatalogNamespace);
		}
	}
}