using HealthCheckCLI.CLI.Commands;
using McMaster.Extensions.CommandLineUtils;

namespace HealthCheckCLI.CLI
{
    [Command(Name = "hc-cli", Description = "Runs healthchecks against stores URLs or Groups of URLS")]
    [HelpOption("-h|--help")]
    [Subcommand(typeof(RunCheckCommand))]
    //TODO [Subcommand(typeof(AddCommand))]
    //TODO [Subcommand(typeof(ImportCommand))]
    //TODO [Subcommand(typeof(ExportCommand))]
    public class App
    {
        public void OnExecute(CommandLineApplication app)
        {
            
        }
    }
}