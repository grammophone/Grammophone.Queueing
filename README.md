# Grammophone.Queueing
This .NET Standard 2.0 class library defines the abstract contract for simple queueing operations.

The starting point of the contract is the `IQueueingProvider` interface, which is expected to be used
in a dependency injection system to provide an implementation. Once we obtain an instance of it, we use the `CreateClient`
method to obtain a client in order to perform operations: We can send a message via the `SensMessageAsync` method
and attempt to receive a message in a non-blocking way using one of the `TryReceiveMessageAsync` method overloads,
which can return an `IQueuedMessage` implementation.
Use the latter to either `Commitasync` or `AbandonAsync` the processing of the message.

This library has no project dependencies.
