using System.Threading;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WpfPlayground
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private readonly IHost _host;

        public App()
        {
            _host = new HostBuilder()
                .ConfigureServices((context, services) => services.AddSingleton<MainWindow>())
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            Thread.CurrentThread.Name = "UI";

            base.OnStartup(e);

            await _host.StartAsync();

            var mainWindow = _host.Services.GetService<MainWindow>();
            mainWindow?.Show();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            await _host.StopAsync();
        }
    }
}