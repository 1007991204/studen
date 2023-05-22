using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ihost
{
    internal class AlberHostService : IHostedService
    {
        private Timer _timer;
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(state =>
            {
                Console.WriteLine($"{DateTime.Now.ToString()}");
            }, null, 0, 1000);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Dispose();
            return Task.CompletedTask;
        }
        public static void Start()
        {
            var host = new HostBuilder().ConfigureServices(services =>
            services.AddHostedService<AlberHostService>()).Build();
            host.Run();
        }
    }
}