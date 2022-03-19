// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sanctions
{
	/// <summary>
	/// Contains information about a single player sanction.
	/// </summary>
	public class PlayerSanction : ISettable
	{
		/// <summary>
		/// The POSIX timestamp when the sanction was placed
		/// </summary>
		public long TimePlaced { get; set; }

		/// <summary>
		/// The action associated with this sanction
		/// </summary>
		public string Action { get; set; }

		/// <summary>
		/// The POSIX timestamp when the sanction will expire. If the sanction is permanent, this will be 0.
		/// </summary>
		public long TimeExpires { get; set; }

		/// <summary>
		/// A unique identifier for this specific sanction
		/// </summary>
		public string ReferenceId { get; set; }

		internal void Set(PlayerSanctionInternal? other)
		{
			if (other != null)
			{
				TimePlaced = other.Value.TimePlaced;
				Action = other.Value.Action;
				TimeExpires = other.Value.TimeExpires;
				ReferenceId = other.Value.ReferenceId;
			}
		}

		public void Set(object other)
		{
			Set(other as PlayerSanctionInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct PlayerSanctionInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private long m_TimePlaced;
		private System.IntPtr m_Action;
		private long m_TimeExpires;
		private System.IntPtr m_ReferenceId;

		public long TimePlaced
		{
			get
			{
				return m_TimePlaced;
			}

			set
			{
				m_TimePlaced = value;
			}
		}

		public string Action
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_Action, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_Action, value);
			}
		}

		public long TimeExpires
		{
			get
			{
				return m_TimeExpires;
			}

			set
			{
				m_TimeExpires = value;
			}
		}

		public string ReferenceId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_ReferenceId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_ReferenceId, value);
			}
		}

		public void Set(PlayerSanction other)
		{
			if (other != null)
			{
				m_ApiVersion = SanctionsInterface.PlayersanctionApiLatest;
				TimePlaced = other.TimePlaced;
				Action = other.Action;
				TimeExpires = other.TimeExpires;
				ReferenceId = other.ReferenceId;
			}
		}

		public void Set(object other)
		{
			Set(other as PlayerSanction);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_Action);
			Helper.TryMarshalDispose(ref m_ReferenceId);
		}
	}
}