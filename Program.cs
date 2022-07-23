using CliWrap;
using CliWrap.Buffered;
using CliWrap.Exceptions;

if (args.Length == 0)
{
    // Nothing to do
    Console.WriteLine("kns: Nothing to do!");
    return;
}

var path = args[0].Split('/');

var context = path.Length > 1 ? path[0] : "";
var ns = path.Length > 1 ? path[1] : path[0];

if (!string.IsNullOrEmpty(context))
{
    // Set context
    try
    {
        var _ = await Cli.Wrap("kubectx")
                .WithArguments(context)
                .ExecuteBufferedAsync();
        Console.WriteLine($"Switched to context \"{context}\"");
    }
    catch (CommandExecutionException e)
    {
        Console.WriteLine(e.Message);
        return;
    }
}

if (!string.IsNullOrEmpty(ns))
{
    // Set namespace
    try
    {
        var _ = await Cli.Wrap("kubens")
                    .WithArguments(ns)
                    .ExecuteBufferedAsync();
        Console.WriteLine($"Active namespace is \"{ns}\"");
    }
    catch (CommandExecutionException e)
    {
        Console.WriteLine(e.Message);
        return;
    }
}
