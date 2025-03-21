using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Grammophone.Queueing
{
	/// <summary>
	/// Represents a queued message.
	/// </summary>
	public interface IQueuedMessage
	{
		/// <summary>
		/// The contents of the message.
		/// </summary>
		BinaryData Body { get; }

		/// <summary>
		/// The time, in UTC, where the message was sent.
		/// </summary>
		DateTime IssueTime { get; }

		/// <summary>
		/// Attempts to commit the message, removing it from the queue.
		/// </summary>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>
		/// True if the message was successfully committed by this call; false if it was already committed or processed by another worker (e.g., due to visibility timeout expiration).
		/// </returns>
		Task<bool> TryCommitAsync(CancellationToken cancellationToken = default);

		/// <summary>
		/// Attempts to abandon the message, making it available again in the queue.
		/// </summary>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		/// <returns>
		/// True if the message was successfully abandoned by this call; false if it was already processed or no longer available (e.g., due to visibility timeout expiration).
		/// </returns>
		Task<bool> TryAbandonAsync(CancellationToken cancellationToken = default);
	}
}
