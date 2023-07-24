namespace Spectre.Console.Cli;

/// <summary>
/// Represents an exception handler.
/// Exception handlers are used to handle exceptions that occur during command execution.
/// </summary>
public interface ICommandExceptionHandler
{
    /// <summary>
    /// Handles the specified exception.
    /// </summary>
    /// <param name="context">The command context.</param>
    /// <param name="exception">The exception to handle.</param>
    /// <returns><c>true</c> if the exception was handled, otherwise <c>false</c>.</returns>
    bool Handle(CommandContext context, Exception exception);
}

/// <summary>
/// Represents an exception handler for a specific command.
/// </summary>
/// <typeparam name="TCommand">Type of the command.</typeparam>
// ReSharper disable once UnusedTypeParameter
#pragma warning disable S2326
public interface ICommandExceptionHandler<TCommand> : ICommandExceptionHandler
    where TCommand : ICommand
{
}
#pragma warning restore S2326
