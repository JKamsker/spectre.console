using Spectre.Console.Cli;

namespace AutoCompletion;

// Adding autocomplete to powershell:
//  - .\AutoCompletion.exe completion powershell
//
// Adding autocomplete to powershell (permanent):
// - .\AutoCompletion.exe completion powershell --install
//
// Test completing:
// - .\AutoCompletion.exe cli complete "Li"
internal class Program
{
    private static void Main(string[] args)
    {
        var app = new CommandApp();
        app.Configure(config =>
        {
            config.AddCommand<LionCommand>("lion");
        });

        app.Run(args);
    }
}