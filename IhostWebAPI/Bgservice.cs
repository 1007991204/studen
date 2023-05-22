namespace IhostWebAPI
{
    public class Bgservice : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                await Task.Delay(1000);
                Console.WriteLine($"当前时间 {DateTime.Now.ToString()}");
            }
        }
    }
}
