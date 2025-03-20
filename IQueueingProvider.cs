using System;

namespace Grammophone.Queueing
{
	/// <summary>
	/// Root contract for handling files of a queueing system.
	/// The implementations must be thread-safe.
	/// </summary>
	public interface IQueueingProvider
	{
		/// <summary>
		/// Create a client for queueing.
		/// </summary>
		IQueueingClient CreateClient();
	}
}
