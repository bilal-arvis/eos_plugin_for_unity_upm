// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UserInfo
{
	/// <summary>
	/// Output parameters for the <see cref="UserInfoInterface.QueryUserInfoByDisplayName" /> Function.
	/// </summary>
	public class QueryUserInfoByDisplayNameCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="UserInfoInterface.QueryUserInfoByDisplayName" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Epic Account ID of the local player requesting the information
		/// </summary>
		public EpicAccountId LocalUserId { get; private set; }

		/// <summary>
		/// The Epic Account ID of the player whose information is being retrieved
		/// </summary>
		public EpicAccountId TargetUserId { get; private set; }

		/// <summary>
		/// Display name of the player being queried. This memory is only valid during the scope of the callback.
		/// </summary>
		public string DisplayName { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(QueryUserInfoByDisplayNameCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				TargetUserId = other.Value.TargetUserId;
				DisplayName = other.Value.DisplayName;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryUserInfoByDisplayNameCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryUserInfoByDisplayNameCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_TargetUserId;
		private System.IntPtr m_DisplayName;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public EpicAccountId TargetUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
		}

		public string DisplayName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_DisplayName, out value);
				return value;
			}
		}
	}
}