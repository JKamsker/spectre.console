using Spectre.Console.Cli.Internal.Extensions;

namespace Spectre.Console.Cli.Internal;
internal static class CommandExceptionHandler
{
    public static bool HandleException(
        CommandTree leaf,
        CommandContext context,
        ITypeResolver resolver,
        Exception ex)
    {
        if (leaf?.Command?.CommandType == null)
        {
            return TryInvokeHandler(
                context,
                resolver,
                ex,
                typeof(IEnumerable<ICommandExceptionHandler>),
                typeof(ICommandExceptionHandler));
        }

        var handlerType = typeof(ICommandExceptionHandler<>)
            .MakeGenericType(leaf.Command.CommandType);

        var enumerableHandlerType = typeof(IEnumerable<>)
            .MakeGenericType(handlerType);

        var handled = TryInvokeHandler(context, resolver, ex, enumerableHandlerType, handlerType);
        if (handled)
        {
            return true;
        }

        return TryInvokeHandler(context, resolver, ex, typeof(IEnumerable<ICommandExceptionHandler>),
            typeof(ICommandExceptionHandler));
    }

    private static bool TryInvokeHandler(
        CommandContext context,
        ITypeResolver resolver,
        Exception ex,
        Type enumerableHandlerType,
        Type handlerType)
    {
        var handlers = resolver.TryResolve(enumerableHandlerType);
        if (handlers is IEnumerable<ICommandExceptionHandler> exHandlerEnumerable)
        {
            foreach (var exHandlerItem in exHandlerEnumerable)
            {
                var isHandled = exHandlerItem.Handle(context, ex);
                if (isHandled)
                {
                    return true;
                }
            }
        }

        var handler = resolver.TryResolve(handlerType);
        if (handler is not ICommandExceptionHandler exHandler)
        {
            return false;
        }

        {
            var isHandled = exHandler.Handle(context, ex);
            if (isHandled)
            {
                return true;
            }
        }

        return false;
    }
}
