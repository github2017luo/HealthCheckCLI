using System.Threading.Tasks;
using HealthCheckCLI.Core.Client;
using McMaster.Extensions.CommandLineUtils;

namespace HealthCheckCLI.CLI.Commands
{
    [Command(Name = "-r|--run", Description = "Run healthchecks")]
    [HelpOption("-h|--help")]
    public class RunCheckCommand
    {
        private readonly IHealthCheckClient _healthCheckClient;

        public RunCheckCommand(IHealthCheckClient healthCheckClient)
        {
            _healthCheckClient = healthCheckClient;
        }
        
        [Argument(0, "identifier", Description = "Identifier of url or group")]
        public string Identifier { get; set; }
        
        public async Task<int> OnExecute(CommandLineApplication cmd)
        {
            //Get settings from store
            
            //check for identifier in store as group or url
            
            //run checks
            _healthCheckClient.CheckHealth("");
            
            //print formatted too terminal
            return 0;
        }
    }
}