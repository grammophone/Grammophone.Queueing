using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Grammophone.Queueing
{
	/// <summary>
	/// A client for queueing and dequeueing messages.
	/// </summary>
	public interface IQueueingClient
	{
		/// <summary>
		/// Attempot to receive a message in a non-clocking way, or return null if there is no message available.
		/// </summary>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		Task<IQueuedMessage?> TryReceiveMessageAsync(CancellationToken cancellationToken = default);

		/// <summary>
		/// Sends a message to the queue with the specified data.
		/// </summary>
		/// <param name="data">The message payload as a byte array.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		Task SendMessageAsync(byte[] data, CancellationToken cancellationToken = default);

		/// <summary>
		/// Sends a message to the queue with the specified string data.
		/// </summary>
		/// <param name="data">The message payload as a string.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		Task SendMessageAsync(string data, CancellationToken cancellationToken = default);

		/// <summary>
		/// Sends a message to the queue with the specified binary data.
		/// </summary>
		/// <param name="data">The message payload as <see cref="BinaryData"/>.</param>
		/// <param name="cancellationToken">A token to cancel the operation.</param>
		Task SendMessageAsync(BinaryData data, CancellationToken cancellationToken = default);
	}
}
